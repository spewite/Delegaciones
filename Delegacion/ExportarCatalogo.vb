Imports System.Data.SqlClient
Imports System.Xml.Linq
Imports System.Windows.Forms
Imports System.Net.Mail
Imports System.Diagnostics

Public Class ExportarCatalogo

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Cambia la cadena de conexión según tu configuración
        Dim ConnectionString As String = ConexionBD.CadenaConexion

        ' Cambia la consulta SQL según tus necesidades
        Dim query As String = "SELECT IdArticulo, Nombre, Descripcion, Categoria, Proveedor, PrVent, PrCost, Existencias, SobreMaximo, BajoMinimo, ImagenBase64 FROM ARTICULOS"

        Try
            Using connection As New SqlConnection(ConnectionString)
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Crear un cuadro de diálogo para guardar archivo
                        Dim saveFileDialog As New SaveFileDialog()
                        saveFileDialog.Filter = "Archivos XML (*.xml)|*.xml"
                        saveFileDialog.Title = "Guardar archivo XML"

                        If saveFileDialog.ShowDialog() = DialogResult.OK Then
                            ' Crear un elemento raíz XML
                            Dim root As New XElement("Articulos")

                            ' Leer cada fila y agregarla como un elemento al XML
                            While reader.Read()
                                Dim articulo As New XElement("Articulo",
                                    New XElement("IdArticulo", reader("IdArticulo").ToString()),
                                    New XElement("Nombre", reader("Nombre").ToString()),
                                    New XElement("Descripcion", reader("Descripcion").ToString()),
                                    New XElement("Categoria", reader("Categoria").ToString()),
                                    New XElement("Proveedor", reader("Proveedor").ToString()),
                                    New XElement("PrVent", reader("PrVent").ToString()),
                                    New XElement("PrCost", reader("PrCost").ToString()),
                                    New XElement("Existencias", reader("Existencias").ToString()),
                                    New XElement("SobreMaximo", reader("SobreMaximo").ToString()),
                                    New XElement("BajoMinimo", reader("BajoMinimo").ToString()),
                                    New XElement("ImagenBase64", reader("ImagenBase64").ToString())
                                )

                                ' Agregar el artículo al elemento raíz
                                root.Add(articulo)
                            End While

                            ' Guardar el XML en el archivo seleccionado por el usuario
                            root.Save(saveFileDialog.FileName)

                            MessageBox.Show($"Datos de ARTICULOS exportados exitosamente a XML ({saveFileDialog.FileName}).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Preguntar al usuario si desea enviar el archivo por correo electrónico
                            Dim result As DialogResult = MessageBox.Show("¿Desea enviar el archivo por correo electrónico?", "Enviar por correo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                            If result = DialogResult.Yes Then
                                ' Abrir el cliente de correo electrónico con el archivo adjunto
                                Try
                                    Dim processInfo As New ProcessStartInfo()
                                    processInfo.UseShellExecute = True
                                    processInfo.FileName = $"mailto:destinatario@example.com?subject=Datos%20de%20ARTICULOS&body=Adjunto%20encontrarás%20el%20archivo%20XML%20con%20los%20datos%20de%20ARTICULOS&attach={saveFileDialog.FileName}"

                                    Process.Start(processInfo)

                                    MessageBox.Show("Cliente de correo electrónico abierto con el archivo adjunto.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Catch ex As Exception
                                    MessageBox.Show("Error al intentar abrir el cliente de correo electrónico: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End Try
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
