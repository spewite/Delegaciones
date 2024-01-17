Imports System.Data.SqlClient
Imports Dllgaciones.BaseDeDatos

Public Class Pedidos

    Dim connectionString As String = ConexionBD.CadenaConexion
    Dim dataTable As DataTable

    Private Sub Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False

        ' ⬇️ Ajustar la anchura del datagrid al ancho de pantalla ⬇️ '
        AjustarAnchuraDataGrid()

        ' ⬇️ Insertar datos de los combobox ⬇️ '
        ActualizarCombosDePedidos()

    End Sub

    Private Sub Gestion_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        AjustarAnchuraDataGrid()
    End Sub

    Private Sub ActualizarCombosDePedidos()
        comboComercialPedidos.Items.Clear()
        comboTransportistaPedido.Items.Clear()
        comboPartnerPedidos.Items.Clear()
        comboEstadoPedidos.Items.Clear()
        comboIdFacturaPedidos.Items.Clear()

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
            comboIdFacturaPedidos.Items.Add(fila("IdFactura"))
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

          Dim formularioPedidos As New FormularioPedidos(1, "", 2)
        formularioPedidos.Size = New Size(1400, 700)
        formularioPedidos.StartPosition = FormStartPosition.CenterScreen
        formularioPedidos.Show()



        Dim consulta As String = "
        WITH Pedidos AS (
            SELECT 
                cab.IdPedido, 
                IdLinea, 
                (SELECT Descripcion FROM ARTICULOS WHERE IdArticulo = lin.IdArticulo) AS Articulo,
                Cantidad, Descuento, Precio, FechaPedido [Fecha Pedido], FechaEnvio [Fecha Envio], FechaPago [Fecha Pago],
                IdFactura,
                (SELECT Nombre FROM PARTNERS WHERE IdPartner = cab.IdPartner) AS Partner,
                (SELECT Nombre + ' ' + Apellidos FROM COMERCIALES WHERE IdComercial = cab.IdComercial) AS Comercial,
                (SELECT Empresa FROM TRANSPORTISTAS WHERE IdTransportista = cab.IdTransportista) AS Transportista, 
                (SELECT Descripcion FROM ESTADO_PEDIDOS WHERE IdEstadoPedido = cab.IdEstadoPedido) AS [Estado Pedido] 
            FROM CAB_PEDIDOS cab 
            INNER JOIN LINEAS_PEDIDO lin ON (cab.IdPedido = lin.IdPedido)
        )
        SELECT *
        FROM Pedidos
        WHERE 1 = 1"


        If Not String.IsNullOrEmpty(inputIdPedidos.Text.Trim) Then
            consulta &= $" AND IdPedido = '{inputIdPedidos.Text.Trim}'"
        End If

        If checkFechaPedidoDesdePedidos.Checked Then
            Dim fechaPedidoDesde As String = dateFechaPedidoDesdePedidos.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, [Fecha Pedido], 112) >= CONVERT(DATE, '{fechaPedidoDesde}', 112)"
        End If

        If checkFechaPedidoHastaPedidos.Checked Then
            Dim fechaPedidoHasta As String = dateFechaPedidoHastaPedidos.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, [Fecha Pedido], 112) <= CONVERT(DATE, '{fechaPedidoHasta}', 112)"
        End If

        If checkFechaEnvioDesdePedidos.Checked Then
            Dim fechaEnvioDesde As String = dateFechaEnvioDesdePedidos.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, [Fecha Envio], 112) >= CONVERT(DATE, '{fechaEnvioDesde}', 112)"
        End If

        If checkFechaEnvioHastaPedidos.Checked Then
            Dim fechaEnvioHasta As String = dateFechaEnvioHastaPedidos.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, [Fecha Envio], 112) <= CONVERT(DATE, '{fechaEnvioHasta}', 112)"
        End If

        If checkFechaPagoDesdePedidos.Checked Then
            Dim fechaPagoDesde As String = dateFechaPagoDesdePedidos.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, [Fecha Pago], 112) >= CONVERT(DATE, '{fechaPagoDesde}', 112)"
        End If

        If checkFechaPagoHastaPedidos.Checked Then
            Dim fechaEnvioHasta As String = dateFechaEnvioHastaPedidos.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, [Fecha Pago], 112) <= CONVERT(DATE, '{fechaEnvioHasta}', 112)"
        End If

        If Not String.IsNullOrEmpty(comboComercialPedidos.Text.Trim) Then
            consulta &= $" AND UPPER(Comercial) LIKE '%{comboComercialPedidos.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(comboTransportistaPedido.Text.Trim) Then
            consulta &= $" AND UPPER(Transportista) LIKE '%{comboTransportistaPedido.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(comboPartnerPedidos.Text.Trim) Then
            consulta &= $" AND UPPER(Partner) LIKE '%{comboPartnerPedidos.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(comboEstadoPedidos.Text.Trim) Then
            consulta &= $" AND UPPER([Estado Pedido]) LIKE '%{comboEstadoPedidos.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(comboIdFacturaPedidos.Text.Trim) Then
            consulta &= $" AND IdFactura = '{comboIdFacturaPedidos.Text.Trim}'"
        End If

        dataTable = ConsultaBBDD(connectionString, consulta)
        dataGridPedidos.DataSource = dataTable
    End Sub

    '---------------------------------------------------------'
    '                                                         '
    '               ABILITAR/DESHABILITAR FECHAS              '
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
End Class