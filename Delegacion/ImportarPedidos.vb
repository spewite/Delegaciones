
Imports System.Data.SqlClient
Imports System.Xml

Public Class ImportarPedidos

    Dim rutaXML As String

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Mostrar el cuadro de diálogo para seleccionar un archivo XML
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

            ' Obtener la lista de nodos "pedido"
            Dim pedidoNodes As XmlNodeList = xmlDoc.SelectNodes("/pedidos/pedido")

            ' Conexión a la base de datos (ajusta la cadena de conexión según tus necesidades)
            Dim ConnectionString As String = ConexionBD.CadenaConexion
            Using connection As New SqlConnection(ConnectionString)
                connection.Open()

                ' Comando SQL para insertar datos en la tabla de pedidos (ajusta según tu esquema)
                Dim insertPedidoQuery As String = "INSERT INTO CAB_PEDIDOS (IdPartner, IdComercial, IdTransportista, IdEstadoPedido, FechaPedido, FechaEnvio, FechaPago) VALUES ( @IdPartner, @IdComercial, @IdTransportista, @IdEstadoPedido, @FechaPedido, @FechaEnvio, @FechaPago)"

                ' Comando SQL para insertar datos en la tabla de líneas de pedido (ajusta según tu esquema)
                Dim insertLineaQuery As String = "INSERT INTO LINEAS_PEDIDO (IdPedido, IdArticulo, Cantidad, Descuento, Precio) VALUES (@IdPedido, @IdArticulo, @Cantidad, @Descuento, @Precio)"

                ' Crear y ejecutar el comando SQL para cada nodo "pedido"
                For Each pedidoNode As XmlNode In pedidoNodes
                    Dim idPedido As Integer = Convert.ToInt32(pedidoNode.SelectSingleNode("cabecera/IdPedido").InnerText)
                    Dim idFactura As Integer = Convert.ToInt32(pedidoNode.SelectSingleNode("cabecera/IdFactura").InnerText)
                    Dim idPartner As Integer = Convert.ToInt32(pedidoNode.SelectSingleNode("cabecera/IdPartner").InnerText)
                    Dim idComercial As Integer = Convert.ToInt32(pedidoNode.SelectSingleNode("cabecera/IdComercial").InnerText)
                    Dim idTransportista As Integer = Convert.ToInt32(pedidoNode.SelectSingleNode("cabecera/IdTransportista").InnerText)
                    Dim idEstadoPedido As Integer = Convert.ToInt32(pedidoNode.SelectSingleNode("cabecera/IdEstadoPedido").InnerText)
                    Dim fechaPedido As Date = DateTime.Parse(pedidoNode.SelectSingleNode("cabecera/FechaPedido").InnerText)
                    Dim fechaEnvio As Date = DateTime.Parse(pedidoNode.SelectSingleNode("cabecera/FechaEnvio").InnerText)
                    Dim fechaPago As Date = DateTime.Parse(pedidoNode.SelectSingleNode("cabecera/FechaPago").InnerText)

                    Using insertPedidoCommand As New SqlCommand(insertPedidoQuery, connection)
                        insertPedidoCommand.Parameters.AddWithValue("@IdPedido", idPedido)
                        insertPedidoCommand.Parameters.AddWithValue("@IdFactura", idFactura)
                        insertPedidoCommand.Parameters.AddWithValue("@IdPartner", idPartner)
                        insertPedidoCommand.Parameters.AddWithValue("@IdComercial", idComercial)
                        insertPedidoCommand.Parameters.AddWithValue("@IdTransportista", idTransportista)
                        insertPedidoCommand.Parameters.AddWithValue("@IdEstadoPedido", idEstadoPedido)
                        insertPedidoCommand.Parameters.AddWithValue("@FechaPedido", fechaPedido)
                        insertPedidoCommand.Parameters.AddWithValue("@FechaEnvio", fechaEnvio)
                        insertPedidoCommand.Parameters.AddWithValue("@FechaPago", fechaPago)

                        insertPedidoCommand.ExecuteNonQuery()
                    End Using

                    ' Obtener la lista de nodos "linea" dentro de cada "pedido"
                    Dim lineaNodes As XmlNodeList = pedidoNode.SelectNodes("lineasPedido/linea")

                    ' Crear y ejecutar el comando SQL para cada nodo "linea"
                    For Each lineaNode As XmlNode In lineaNodes
                        Dim idLinea As Integer = Convert.ToInt32(lineaNode.SelectSingleNode("IdLinea").InnerText)
                        Dim idArticulo As Integer = Convert.ToInt32(lineaNode.SelectSingleNode("IdArticulo").InnerText)
                        Dim cantidad As Integer = Convert.ToInt32(lineaNode.SelectSingleNode("Cantidad").InnerText)
                        Dim descuento As Double = Convert.ToDouble(lineaNode.SelectSingleNode("Descuento").InnerText)
                        Dim precio As Double = Convert.ToDouble(lineaNode.SelectSingleNode("Precio").InnerText)

                        Using insertLineaCommand As New SqlCommand(insertLineaQuery, connection)
                            insertLineaCommand.Parameters.AddWithValue("@IdPedido", idPedido)
                            insertLineaCommand.Parameters.AddWithValue("@IdLinea", idLinea)
                            insertLineaCommand.Parameters.AddWithValue("@IdArticulo", idArticulo)
                            insertLineaCommand.Parameters.AddWithValue("@Cantidad", cantidad)
                            insertLineaCommand.Parameters.AddWithValue("@Descuento", descuento)
                            insertLineaCommand.Parameters.AddWithValue("@Precio", precio)

                            insertLineaCommand.ExecuteNonQuery()
                        End Using
                    Next
                Next

                MessageBox.Show("Datos insertados correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al procesar el XML o insertar en la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
