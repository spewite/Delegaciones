Imports Microsoft.VisualBasic.FileIO
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ImportarArticulos

    Dim rutaCSV As String

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click

        Try

            ' Mostrar el cuadro de diálogo para seleccionar un archivo csv
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Archivos csv|*.csv"
            openFileDialog.Title = "Seleccionar archivo CSV"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Obtener la ruta del archivo XML seleccionado
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
                        Dim referencia As String = campos(0)
                        Dim nombre As String = campos(1)
                        Dim descripcion As String = campos(2)
                        Dim precioVenta As Decimal = Convert.ToDecimal(campos(3))
                        Dim coste As Decimal = Convert.ToDecimal(campos(4))
                        Dim imagen As String = campos(5)

                        ' Inserta los datos en la base de datos
                        cmd.CommandText = $"INSERT INTO {nombreTabla} (idArticulo, Nombre, Descripcion, PrVent, PrCost, ImagenBase64) VALUES (@Referencia, @Nombre, @Descripcion, @PrecioVenta, @Coste, @Imagen)"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@Referencia", referencia)
                        cmd.Parameters.AddWithValue("@Nombre", nombre)
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion)
                        cmd.Parameters.AddWithValue("@PrecioVenta", precioVenta)
                        cmd.Parameters.AddWithValue("@Coste", coste)
                        cmd.Parameters.AddWithValue("@Imagen", imagen)

                        cmd.ExecuteNonQuery()
                    End While
                End Using
            End Using
        End Using




    End Sub


End Class

