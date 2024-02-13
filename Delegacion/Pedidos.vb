Imports System.Data.SqlClient
Imports Dllgaciones.BaseDeDatos

Public Class Pedidos

    Dim connectionString As String = ConexionBD.CadenaConexion
    Dim dataTable As DataTable

    Dim ModoEditar As Integer = ModosFormulario.ModoEditar
    Dim ModoVer As Integer = ModosFormulario.ModoVer
    Dim ModoAñadir As Integer = ModosFormulario.ModoAñadir

    Dim sentenciaWhere As String = ""

    ' Creamos el formulario pedido aqui con WithEvents. Así cuando se cierre el formulario que se abre podemos actualizar el Datagrid.
    Private WithEvents formularioPedidos As FormularioPedidos

    Private Sub Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False

        ' ⬇️ Ajustar la anchura del datagrid al ancho de pantalla ⬇️ '
        AjustarAnchuraDataGrid()

        ' ⬇️ Insertar datos de los combobox ⬇️ '
        ActualizarCombosDePedidos()

        CargarDataGridPedido()
    End Sub

    Private Sub Gestion_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        AjustarAnchuraDataGrid()
    End Sub

    Private Sub ActualizarCombosDePedidos()
        comboComercialPedidos.Items.Clear()
        comboTransportistaPedido.Items.Clear()
        comboPartnerPedidos.Items.Clear()
        comboEstadoPedidos.Items.Clear()
        comboIdFacturas.Items.Clear()

        Dim consulta As String = $"SELECT NOMBRE + ' ' + Apellidos As NombreApellido FROM COMERCIALES"
        dataTable = ConsultaBBDD(connectionString, consulta)
        For Each fila As DataRow In dataTable.Rows
            comboComercialPedidos.Items.Add(fila("NombreApellido"))
        Next

        consulta = $"SELECT Empresa FROM TRANSPORTISTAS"
        dataTable = ConsultaBBDD(connectionString, consulta)
        For Each fila As DataRow In dataTable.Rows
            comboTransportistaPedido.Items.Add(fila("Empresa"))
        Next

        consulta = $"SELECT Nombre FROM PARTNERS"
        dataTable = ConsultaBBDD(connectionString, consulta)
        For Each fila As DataRow In dataTable.Rows
            comboPartnerPedidos.Items.Add(fila("Nombre"))
        Next

        consulta = $"Select Descripcion FROM ESTADO_PEDIDOS"
        dataTable = ConsultaBBDD(connectionString, consulta)
        For Each fila As DataRow In dataTable.Rows
            comboEstadoPedidos.Items.Add(fila("Descripcion"))
        Next

        consulta = $"Select IdFactura FROM FACTURAS"
        dataTable = ConsultaBBDD(connectionString, consulta)
        For Each fila As DataRow In dataTable.Rows
            comboIdFacturas.Items.Add(fila("IdFactura"))
        Next


    End Sub

    Private Sub AjustarAnchuraDataGrid()
        ' Ajustar la anchura del datagrid al ancho de pantalla
        dataGridPedidos.Width = Me.ClientSize.Width - 50
    End Sub


    '---------------------------------------------------------'
    '                                                         '
    '                       CONSULTA                          '
    '                                                         '
    '---------------------------------------------------------'

    Private Sub btnConsultarPedidos_Click_1(sender As Object, e As EventArgs) Handles btnConsultarPedidos.Click
        CargarDataGridPedido()
    End Sub

    Private Sub CargarDataGridPedido()

        Dim consulta As String = "SELECT 
	                                    cab.IdPedido, 
	                                    IdFactura,
                                        (SELECT STRING_AGG (IdLinea, ', ') FROM LINEAS_PEDIDO WHERE IdPedido=cab.IdPedido) As 'Lineas',
                                        part.Nombre AS Partner, 
                                        comer.Nombre + ' ' + comer.Apellidos Comercial,
                                        transp.Empresa AS Transportista, 
                                        est_ped.Descripcion AS [Estado Pedido],
	                                    FechaPedido [Fecha Pedido], 
	                                    FechaEnvio [Fecha Envío],
	                                    FechaPago [Fecha Pago]
                                    FROM CAB_PEDIDOS cab
                                    LEFT JOIN COMERCIALES comer ON (cab.IdComercial = comer.IdComercial)
                                    LEFT JOIN TRANSPORTISTAS transp ON (cab.IdTransportista = transp.IdTransportista)
                                    LEFT JOIN PARTNERS part ON (cab.IdPartner = part.IdPartner)
                                    LEFT JOIN ESTADO_PEDIDOS est_ped ON (cab.IdEstadoPedido = est_ped.IdEstadoPedido)
                                    WHERE 1=1"

        sentenciaWhere = ""

        If Not String.IsNullOrEmpty(inputIdPedidos.Text.Trim) Then
            consulta &= $" AND cab.IdPedido = '{inputIdPedidos.Text.Trim}'"
            sentenciaWhere &= $" AND cab.IdPedido = '{inputIdPedidos.Text.Trim}'"
        End If

        If checkFechaPedidoDesdePedidos.Checked Then
            Dim fechaPedidoDesde As String = dateFechaPedidoDesdePedidos.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaPedido, 112) >= CONVERT(DATE, '{fechaPedidoDesde}', 112)"
            sentenciaWhere &= $" AND CONVERT(DATE, FechaPedido, 112) >= CONVERT(DATE, '{fechaPedidoDesde}', 112)"
        End If

        If checkFechaPedidoHastaPedidos.Checked Then
            Dim fechaPedidoHasta As String = dateFechaPedidoHastaPedidos.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaPedido, 112) <= CONVERT(DATE, '{fechaPedidoHasta}', 112)"
            sentenciaWhere &= $" AND CONVERT(DATE, FechaPedido, 112) <= CONVERT(DATE, '{fechaPedidoHasta}', 112)"
        End If

        If checkFechaEnvioDesdePedidos.Checked Then
            Dim fechaEnvioDesde As String = dateFechaEnvioDesdePedidos.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaEnvio, 112) >= CONVERT(DATE, '{fechaEnvioDesde}', 112)"
            sentenciaWhere &= $" AND CONVERT(DATE, FechaEnvio, 112) >= CONVERT(DATE, '{fechaEnvioDesde}', 112)"
        End If

        If checkFechaEnvioHastaPedidos.Checked Then
            Dim fechaEnvioHasta As String = dateFechaEnvioHastaPedidos.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaEnvio, 112) <= CONVERT(DATE, '{fechaEnvioHasta}', 112)"
            sentenciaWhere &= $" AND CONVERT(DATE, FechaEnvio, 112) <= CONVERT(DATE, '{fechaEnvioHasta}', 112)"
        End If

        If checkFechaPagoDesdePedidos.Checked Then
            Dim fechaPagoDesde As String = dateFechaPagoDesdePedidos.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaPago, 112) >= CONVERT(DATE, '{fechaPagoDesde}', 112)"
            sentenciaWhere &= $" AND CONVERT(DATE, FechaPago, 112) >= CONVERT(DATE, '{fechaPagoDesde}', 112)"
        End If

        If checkFechaPagoHastaPedidos.Checked Then
            Dim fechaEnvioHasta As String = dateFechaEnvioHastaPedidos.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaPago, 112) <= CONVERT(DATE, '{fechaEnvioHasta}', 112)"
            sentenciaWhere &= $" AND CONVERT(DATE, FechaPago, 112) <= CONVERT(DATE, '{fechaEnvioHasta}', 112)"
        End If

        If Not String.IsNullOrEmpty(comboComercialPedidos.Text.Trim) Then
            consulta &= $" AND comer.Nombre + ' ' + comer.Apellidos LIKE '%{comboComercialPedidos.Text.ToUpper.Trim}%'"
            sentenciaWhere &= $" AND comer.Nombre + ' ' + comer.Apellidos LIKE '%{comboComercialPedidos.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(comboTransportistaPedido.Text.Trim) Then
            consulta &= $" AND UPPER(transp.Empresa) LIKE '%{comboTransportistaPedido.Text.ToUpper.Trim}%'"
            sentenciaWhere &= $" AND UPPER(transp.Empresa) LIKE '%{comboTransportistaPedido.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(comboPartnerPedidos.Text.Trim) Then
            consulta &= $" AND UPPER(part.Nombre) LIKE '%{comboPartnerPedidos.Text.ToUpper.Trim}%'"
            sentenciaWhere &= $" AND UPPER(part.Nombre) LIKE '%{comboPartnerPedidos.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(comboEstadoPedidos.Text.Trim) Then
            consulta &= $" AND UPPER(est_ped.Descripcion) LIKE '%{comboEstadoPedidos.Text.ToUpper.Trim}%'"
            sentenciaWhere &= $" AND UPPER(est_ped.Descripcion) LIKE '%{comboEstadoPedidos.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(comboIdFacturas.Text.Trim) Then
            consulta &= $" AND IdFactura = '{comboIdFacturas.Text.Trim}'"
            sentenciaWhere &= $" AND IdFactura = '{comboIdFacturas.Text.Trim}'"
        End If

        consulta &= $" ORDER BY IdPedido"

        dataTable = ConsultaBBDD(connectionString, consulta)
        dataGridPedidos.DataSource = dataTable

        ActualizarBotonEliminar()
    End Sub

    '---------------------------------------------------------'
    '                                                         '
    '           HABILITAR/DESHABILITAR BOTON BORRAR           '
    '                                                         '
    '---------------------------------------------------------'

    Private Sub ActualizarBotonEliminar()
        If dataGridPedidos.SelectedRows.Count > 0 Then
            ' Habilitar el botón cuando al menos una fila está seleccionada
            btnBorrarPedidos.Enabled = True
        Else
            ' Deshabilitar el botón si no hay filas seleccionadas
            btnBorrarPedidos.Enabled = False
        End If
    End Sub

    Private Sub dataGridPedidos_SelectionChanged(sender As Object, e As EventArgs) Handles dataGridPedidos.SelectionChanged
        ActualizarBotonEliminar()
    End Sub


    '---------------------------------------------------------'
    '                                                         '
    '               HABILITAR/DESHABILITAR FECHAS             '
    '                                                         '
    '---------------------------------------------------------'

    Private Sub checkFechaPedidoDesde_CheckedChanged(sender As Object, e As EventArgs) Handles checkFechaPedidoDesdePedidos.CheckedChanged
        dateFechaPedidoDesdePedidos.Enabled = checkFechaPedidoDesdePedidos.Checked
    End Sub

    Private Sub checkFechaPedidoHasta_CheckedChanged(sender As Object, e As EventArgs) Handles checkFechaPedidoHastaPedidos.CheckedChanged
        dateFechaPedidoHastaPedidos.Enabled = checkFechaPedidoHastaPedidos.Checked
    End Sub

    Private Sub checkFechaEnvioDesde_CheckedChanged(sender As Object, e As EventArgs) Handles checkFechaEnvioDesdePedidos.CheckedChanged
        dateFechaEnvioDesdePedidos.Enabled = checkFechaEnvioDesdePedidos.Checked
    End Sub

    Private Sub checkFechaEnvioHasta_CheckedChanged(sender As Object, e As EventArgs) Handles checkFechaEnvioHastaPedidos.CheckedChanged
        dateFechaEnvioHastaPedidos.Enabled = checkFechaEnvioHastaPedidos.Checked
    End Sub

    Private Sub checkFechaPagoDesde_CheckedChanged(sender As Object, e As EventArgs) Handles checkFechaPagoDesdePedidos.CheckedChanged
        dateFechaPagoDesdePedidos.Enabled = checkFechaPagoDesdePedidos.Checked
    End Sub

    Private Sub checkFechaPagoHasta_CheckedChanged(sender As Object, e As EventArgs) Handles checkFechaPagoHastaPedidos.CheckedChanged
        dateFechaPagoHastaPedidos.Enabled = checkFechaPagoHastaPedidos.Checked
    End Sub

    '---------------------------------------------------------'
    '                                                         '
    '             ABRIR PEDIDO AL HACER DOBLE CLICK           '
    '                                                         '
    '---------------------------------------------------------'

    Private Sub DataGridPedidos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridPedidos.CellDoubleClick
        ' Verifica si la celda seleccionada es válida y si es necesario realizar alguna acción específica
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Obtiene el valor de la celda
            Dim IdPedido As Integer = dataGridPedidos.Rows(e.RowIndex).Cells(0).Value

            ' Abrir formulario del artiiculo
            formularioPedidos = New FormularioPedidos(IdPedido, sentenciaWhere, ModoVer)
            formularioPedidos.Show()
        End If
    End Sub

    Private Sub btnAltaPedidos_Click(sender As Object, e As EventArgs) Handles btnAltaPedidos.Click
        ' Abrir formulario del artiiculo
        formularioPedidos = New FormularioPedidos(ModoAñadir)
        formularioPedidos.Show()
    End Sub

    Private Sub btnBorrarPedidos_Click(sender As Object, e As EventArgs) Handles btnBorrarPedidos.Click

        If dataGridPedidos.SelectedRows.Count > 0 Then
            For Each fila As DataGridViewRow In dataGridPedidos.SelectedRows

                ' Por cada registro seleccionado pregunta si quiere eliminarlo
                Dim idPedido As Integer = CInt(fila.Cells("IdPedido").Value.ToString())

                Dim respuesta As DialogResult = MessageBox.Show($"¿Quieres eliminar el pedido {idPedido}?", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If respuesta = DialogResult.Yes Then

                    Dim cantLineasPedido As Integer = ConsultaBBDD(connectionString, $"SELECT COUNT(*) As cantLineas FROM LINEAS_PEDIDO WHERE IdPedido = {idPedido}").Rows(0)("cantLineas")

                    If cantLineasPedido > 0 Then

                        ' EL PEDIDO TIENE LINEAS, ASIQUE HAY QUE ELIMINAR LAS LINEAS ANTES DE ELIMINAR EL PEDIDO

                        Dim respuesta2 As DialogResult = MessageBox.Show($"El pedido seleccionado contiene líneas. ¿Quieres eliminar todas las lineas del pedido {idPedido}?", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        If respuesta2 = DialogResult.Yes Then
                            Dim columnasEliminadasLineas As Integer = DeleteBBDD(connectionString, $"DELETE FROM LINEAS_PEDIDO WHERE IdPedido = {idPedido}")

                            If columnasEliminadasLineas > 0 Then
                                MsgBox($"Se han eliminado {columnasEliminadasLineas} líneas", vbInformation + vbOKOnly, "Líneas eliminadas con éxtio.")
                            Else
                                MsgBox("No se han podido eliminar las líneas", vbExclamation + vbOKOnly, "Error.")
                            End If

                        Else
                            ' En este punto el usuario a dado a eliminar un pedido con lineas, pero no quiere eliminar el pedido porque tiene lineas, asique saltamos al siguiente pedido
                            ' Para saltar al siguiente pedido
                            Continue For
                        End If


                    End If

                    Dim pedidosEliminados As Integer = DeleteBBDD(connectionString, $"DELETE FROM CAB_PEDIDOS WHERE IdPedido = {idPedido}")
                    If (pedidosEliminados > 0) Then
                        MsgBox($"El pedido {idPedido} ha sido eliminado con éxito.", vbInformation + vbOKOnly, "Pedido eliminado con éxito.")
                    Else
                        MsgBox($"No se ha podido eliminar el pedido {idPedido}. Intentelo de nuevo, por favor.", vbExclamation + vbOKOnly, "Error al eliminar el pedido.")
                    End If

                End If
            Next

            CargarDataGridPedido()
        Else
            MsgBox("Seleccione al menos una línea para poder eliminarla. Ten en cuenta que tienes que seleccionar la línea entera haciendo click en la primera columna de la tabla.", vbExclamation + vbOKOnly, "Seleccione líneas.")
        End If

    End Sub

    Private Sub btnImportarPedidos_Click(sender As Object, e As EventArgs) Handles btnImportarPedidos.Click
        Dim formularioImportarPedidos As New ImportarPedidos()
        formularioImportarPedidos.Show()
    End Sub

    Private Sub CerrarFormularioPedidos(sender As Object, e As FormClosedEventArgs) Handles formularioPedidos.FormClosed
        CargarDataGridPedido()
    End Sub


End Class