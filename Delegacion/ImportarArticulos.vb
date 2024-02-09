Imports Microsoft.VisualBasic.FileIO
Imports System.Data.SqlClient
Imports Dllgaciones.BaseDeDatos
Public Class ImportarArticulos

    Dim rutaCSV As String
    Dim RegistrosInsertados As Integer = 0
    Dim RegistrosActualizados As Integer = 0
    Dim ConnectionString As String = ConexionBD.CadenaConexion

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            ' Mostrar el cuadro de diálogo para seleccionar un archivo csv
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Archivos csv|*.csv"
            openFileDialog.Title = "Seleccionar archivo CSV"

            ' Convertir la ruta relativa en una ruta absoluta
            Dim rutaRelativa As String = "importaciones\sede-central"
            Dim rutaAbsoluta As String = System.IO.Path.Combine(Application.StartupPath, rutaRelativa)

            openFileDialog.InitialDirectory = rutaAbsoluta ' Utilizar la ruta absoluta como directorio inicial

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Obtener la ruta del archivo CSV seleccionado
                rutaCSV = openFileDialog.FileName
                inputRuta.Text = rutaCSV
            End If

        Catch ex As Exception
            MessageBox.Show("Error al procesar el CSV o insertar en la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSubir_Click(sender As Object, e As EventArgs) Handles btnSubir.Click
        Dim cadenaConexion As String = ConexionBD.CadenaConexion

        Try
            Using cn As New SqlConnection(cadenaConexion)
                cn.Open()

                Using cmd As New SqlCommand()
                    cmd.Connection = cn

                    Using tfp As New TextFieldParser(rutaCSV)
                        tfp.TextFieldType = FieldType.Delimited
                        tfp.SetDelimiters(",")

                        ' Ignorar la primera línea (encabezados)
                        tfp.ReadLine()


                        While Not tfp.EndOfData
                            Dim campos As String() = tfp.ReadFields()

                            ' Accede a cada campo según su posición en el archivo CSV
                            Dim IdArticulo As String = campos(0)
                            Dim nombre As String = campos(1)
                            Dim descripcion As String = campos(2)
                            Dim proveedor As String = campos(3)

                            ' Convertir el precio de venta y el coste a Decimal
                            Dim precioVenta As Decimal
                            Dim coste As Decimal

                            If Decimal.TryParse(campos(4), Globalization.NumberStyles.AllowDecimalPoint, Globalization.CultureInfo.InvariantCulture, precioVenta) AndAlso
                                Decimal.TryParse(campos(5), Globalization.NumberStyles.AllowDecimalPoint, Globalization.CultureInfo.InvariantCulture, coste) Then

                                ' Si SE METE EN ESTE PUNTO ES QUE LOS PRECIOS SON VALIDOS.

                                ' Cambiamos los decmiales de formato para poder meterlos en la base de datos

                                Dim precioVenta2 = precioVenta.ToString.Replace(".", "").Replace(",", ".")
                                Dim coste2 = coste.ToString.Replace(".", "").Replace(",", ".")

                                ' Vamos a ver si el ID del articulo ya existe en la base de datos.
                                ' Si ya existe el articulo, lo actualizamos. 
                                ' Si no existe, lo insertamos


                                ' Si esta consulta no retorna ninguna linea, es que no exite el pedido en nuestra base de datos.
                                Dim ConsultaExisteArticulo As String = $"SELECT * FROM ARTICULOS WHERE IdArticulo={IdArticulo}"
                                Dim TablaExisteArticulo As DataTable = ConsultaBBDD(ConnectionString, ConsultaExisteArticulo)
                                Dim Filas As Integer = TablaExisteArticulo.Rows.Count

                                If (Filas = 0) Then
                                    ' Insertar el articulo 
                                    Dim consultaInsert = $"INSERT INTO ARTICULOS (IdArticulo, Nombre, Descripcion, Proveedor, PrVent, PrCost) 
                                                           VALUES ('{IdArticulo}', '{nombre}', '{descripcion}', '{proveedor}', '{precioVenta2}', '{coste2}')"

                                    RegistrosInsertados += InsertBBDD(ConnectionString, consultaInsert)
                                Else
                                    ' Actualizar los datos del articulo
                                    Dim consultaUpdate = $"UPDATE ARTICULOS 
                                                          SET Nombre = '{nombre}',
                                                          Descripcion = '{descripcion}',
                                                          Proveedor = '{proveedor}',
                                                          PrVent = '{precioVenta2}', 
                                                          PrCost = '{coste2}'
                                                          WHERE IdArticulo = '{IdArticulo}'"

                                    RegistrosActualizados += UpdateBBDD(ConnectionString, consultaUpdate)
                                End If

                            Else
                                ' Hubo un problema al convertir el precio de venta o el coste
                                MessageBox.Show($"Error al convertir el precio de venta o el coste en la línea {tfp.LineNumber}.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    End Using
                End Using
            End Using

            MessageBox.Show($"Se han insertado {RegistrosInsertados} y  actualizado {RegistrosActualizados } artículos.", "Importación Terminada", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al procesar el CSV o insertar en la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Close()
    End Sub
End Class
