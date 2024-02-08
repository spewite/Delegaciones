Imports System.Data.SqlClient
Imports System.Xml.Linq
Imports System.Windows.Forms
Imports System.Net.Mail
Imports System.Diagnostics

Public Class ExportarCatalogo

    Private Sub btnCatalogo_Click(sender As Object, e As EventArgs) Handles btnCatalogo.Click

        ' Cambia la cadena de conexión según tu configuración
        Dim ConnectionString As String = ConexionBD.CadenaConexion

        ' Cambia la consulta SQL según tus necesidades
        Dim query As String = "SELECT IdArticulo, Nombre, Descripcion, Categoria, Proveedor, PrVent, PrCost, Existencias, SobreMaximo, BajoMinimo, ImagenBase64 FROM ARTICULOS"

        Try
            Using connection As New SqlConnection(ConnectionString)
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
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

                        ' Definir la ruta y el nombre del archivo donde se guardará el XML
                        Dim directorio As String = "exportaciones\catalogo" ' Asegúrate de que este directorio exista o crea el directorio antes de guardar el archivo
                        Dim fechaHoraFormateada As String = DateTime.Now.ToString("yyyy-MM-dd-(HH_mm)")
                        Dim nombreArchivo As String = $"Catalogo_{fechaHoraFormateada}.xml"
                        Dim rutaArchivo As String = System.IO.Path.Combine(Application.StartupPath, directorio, nombreArchivo)

                        ' Guardar el XML en la ruta especificada
                        root.Save(rutaArchivo)

                        MessageBox.Show($"Catálogo exportados exitosamente a XML ({rutaArchivo}).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Preguntar al usuario si desea abrir la carpeta
                        Dim respuesta As DialogResult = MessageBox.Show("¿Desea abrir la carpeta donde se guardó el archivo?", "Abrir Carpeta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        If respuesta = DialogResult.Yes Then
                            ' Abrir la carpeta
                            Process.Start("explorer.exe", $"/select, ""{rutaArchivo}""")
                        End If
                    End Using
                End Using
            End Using

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class
