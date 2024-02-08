Imports Microsoft.VisualBasic.FileIO
Imports System.Data.SqlClient

Public Class ImportarArticulos

    Dim rutaCSV As String
    Dim RegistrosInsertados As Integer = 0

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
        Dim nombreTabla As String = "ARTICULOS"

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
                            Dim nombre As String = campos(0)
                            Dim descripcion As String = campos(1)
                            Dim proveedor As String = campos(2)

                            ' Convertir el precio de venta y el coste a Decimal
                            Dim precioVenta As Decimal
                            Dim coste As Decimal

                            If Decimal.TryParse(campos(3), Globalization.NumberStyles.AllowDecimalPoint, Globalization.CultureInfo.InvariantCulture, precioVenta) AndAlso
                                Decimal.TryParse(campos(4), Globalization.NumberStyles.AllowDecimalPoint, Globalization.CultureInfo.InvariantCulture, coste) Then
                                ' Ambas conversiones fueron exitosas

                                ' Puedes manejar el campo de imagen si es necesario

                                ' Inserta los datos en la base de datos
                                cmd.CommandText = $"INSERT INTO {nombreTabla} (Nombre, Descripcion, Proveedor, PrVent, PrCost) VALUES (@Nombre, @Descripcion, @Proveedor, @PrecioVenta, @Coste)"
                                cmd.Parameters.Clear()

                                cmd.Parameters.AddWithValue("@Nombre", nombre)
                                cmd.Parameters.AddWithValue("@Descripcion", descripcion)
                                cmd.Parameters.AddWithValue("@Proveedor", proveedor)
                                cmd.Parameters.AddWithValue("@PrecioVenta", precioVenta)
                                cmd.Parameters.AddWithValue("@Coste", coste)

                                cmd.ExecuteNonQuery()

                                RegistrosInsertados += 1
                            Else
                                ' Hubo un problema al convertir el precio de venta o el coste
                                MessageBox.Show($"Error al convertir el precio de venta o el coste en la línea {tfp.LineNumber}.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    End Using
                End Using
            End Using

            MessageBox.Show($"Se han insertado {RegistrosInsertados} artículos.", "Importación Terminada", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al procesar el CSV o insertar en la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Close()
    End Sub
End Class
