﻿Imports System.Data.SqlClient
Imports System.Xml
Imports Dllgaciones.BaseDeDatos

Public Class ImportarPartners

    Dim rutaXML As String

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            
		' Mostrar el cuadro de diálogo para seleccionar un archivo XML IÑIGO PUTERO
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Archivos XML|*.xml"
            openFileDialog.Title = "Seleccionar archivo XML"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Obtener la ruta del archivo XML seleccionado
                rutaXML = openFileDialog.FileName

                TextBox1.Text = rutaXML
            End If

        Catch ex As Exception
            MessageBox.Show("Error al procesar el XML o insertar en la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Crear un nuevo objeto XmlDocument
            Dim xmlDoc As New XmlDocument()

            ' Cargar el XML desde el archivo
            xmlDoc.Load(rutaXML)

            ' Obtener la lista de nodos "partner"
            Dim partnerNodes As XmlNodeList = xmlDoc.SelectNodes("/partners/partner")

            ' Conexión a la base de datos (ajusta la cadena de conexión según tus necesidades)
            Dim ConnectionString As String = ConexionBD.CadenaConexion
            Using connection As New SqlConnection(ConnectionString)
                connection.Open()

                ' Comando SQL para insertar datos en la tabla adecuada (ajusta según tu esquema)
                Dim insertQuery As String = "INSERT INTO PARTNERS (idZona, Nombre, CIF, Direccion, Telefono, Correo) VALUES (@Zona, @Nombre, @CIF, @Direccion, @Telefono, @Email)"

                ' Crear y ejecutar el comando SQL para cada nodo "partner"
                For Each partnerNode As XmlNode In partnerNodes
                    Dim zona As Integer = partnerNode.SelectSingleNode("zona").InnerText
                    Dim nombre As String = partnerNode.SelectSingleNode("nombre").InnerText
                    Dim direccion As String = partnerNode.SelectSingleNode("direccion").InnerText
                    Dim cif As String = partnerNode.SelectSingleNode("cif").InnerText
                    Dim telefono As String = partnerNode.SelectSingleNode("telefono").InnerText
                    Dim email As String = partnerNode.SelectSingleNode("email").InnerText

                    Using insertCommand As New SqlCommand(insertQuery, connection)
                        insertCommand.Parameters.AddWithValue("@Zona", zona)
                        insertCommand.Parameters.AddWithValue("@Nombre", nombre)
                        insertCommand.Parameters.AddWithValue("@CIF", cif)
                        insertCommand.Parameters.AddWithValue("@Direccion", direccion)
                        insertCommand.Parameters.AddWithValue("@Telefono", telefono)
                        insertCommand.Parameters.AddWithValue("@Email", email)

                        insertCommand.ExecuteNonQuery()
                    End Using
                Next

                MessageBox.Show("Datos insertados correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al procesar el XML o insertar en la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class