Imports System.Data.SqlClient
Imports System.Xml.Linq
Imports System.Windows.Forms
Imports System.Net.Mail

Public Class ExportarPartners
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPartners.Click

        ' Cambia la cadena de conexión según tu configuración
        Dim ConnectionString As String = ConexionBD.CadenaConexion

        ' Cambia la consulta SQL según tus necesidades
        Dim query As String = "SELECT IdPartner, IdZona, Nombre, CIF, Direccion, Telefono, Correo, FechaRegistro FROM PARTNERS"

        Try
            Using connection As New SqlConnection(ConnectionString)
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Crear un elemento raíz XML
                        Dim root As New XElement("Partners")

                        ' Leer cada fila y agregarla como un elemento al XML
                        While reader.Read()
                            Dim partner As New XElement("Partner",
                            New XElement("IdPartner", reader("IdPartner").ToString()),
                            New XElement("IdZona", reader("IdZona").ToString()),
                            New XElement("Nombre", reader("Nombre").ToString()),
                            New XElement("CIF", reader("CIF").ToString()),
                            New XElement("Direccion", reader("Direccion").ToString()),
                            New XElement("Telefono", reader("Telefono").ToString()),
                            New XElement("Correo", reader("Correo").ToString()),
                            New XElement("FechaRegistro", reader("FechaRegistro").ToString())
        )

                            ' Agregar el partner al elemento raíz
                            root.Add(partner)
                        End While

                        ' Definir la ruta y el nombre del archivo donde se guardará el XML
                        Dim directorio As String = "exportaciones\partners" ' Asegúrate de que este directorio exista o crea el directorio antes de guardar el archivo

                        Dim fechaHoraFormateada As String = DateTime.Now.ToString("yyyy-MM-dd-(HH_mm)")
                        Dim nombreArchivo As String = $"Partners_{fechaHoraFormateada}.xml"

                        Dim rutaArchivo As String = System.IO.Path.Combine(Application.StartupPath, directorio, nombreArchivo)

                        ' Guardar el XML en la ruta especificada
                        root.Save(rutaArchivo)

                        MessageBox.Show($"Datos de PARTNERS exportados exitosamente a XML ({nombreArchivo}).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
