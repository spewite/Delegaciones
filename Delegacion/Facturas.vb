Imports System.Data.SqlClient
Imports Dllgaciones.BaseDeDatos
Public Class Facturas

    Dim connectionString As String = ConexionBD.CadenaConexion
    Dim dataTable As DataTable

    Dim ModoEditar As Integer = ModosFormulario.ModoEditar
    Dim ModoVer As Integer = ModosFormulario.ModoVer
    Dim ModoAñadir As Integer = ModosFormulario.ModoAñadir

    Private WithEvents formularioFacturas As FormularioFacturas
    Private WithEvents formularioGenerarFacturas As GenerarFacturas

    Dim sentenciaWhereFactura As String = ""

    Private Sub Facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False

        ' ⬇️ Insertar datos de los combobox ⬇️ '
        ActualizarCombos()

        ' ⬇️ Ajustar la anchura del datagrid al ancho de pantalla ⬇️ '
        AjustarAnchuraDataGrid()

        CargarDataGrid()
    End Sub

    Private Sub AjustarAnchuraDataGrid()
        ' Ajustar la anchura del datagrid al ancho de pantalla
        dataGridFacturas.Width = Me.ClientSize.Width - 50
    End Sub

    Private Sub Facturas_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        AjustarAnchuraDataGrid()
    End Sub


    Private Sub ActualizarCombos()


        comboEstadoFactura.Items.Clear()
        comboEstadoFactura.Items.Clear()


        Dim consulta As String = $"SELECT IdPedido FROM CAB_PEDIDOS"
        dataTable = ConsultaBBDD(connectionString, consulta)
        For Each fila As DataRow In dataTable.Rows
            comboIdPedido.Items.Add(fila("IdPedido"))
        Next

        consulta = $"SELECT Distinct Estado FROM FACTURAS"
        dataTable = ConsultaBBDD(connectionString, consulta)
        For Each fila As DataRow In dataTable.Rows
            comboEstadoFactura.Items.Add(fila("Estado"))
        Next
    End Sub


    '---------------------------------------------------------'
    '                                                         '
    '                         CONSULTA                        '
    '                                                         '
    '---------------------------------------------------------'

    Private Sub btnConsultarPedidos_Click(sender As Object, e As EventArgs) Handles btnConsultarPedidos.Click
        CargarDataGrid()
    End Sub

    Private Sub CargarDataGrid()
        Dim consulta As String = "
        SELECT 
	        FACTURAS.IdFactura As [Id Factura],
	         (SELECT STRING_AGG (IdPedido, ', ') FROM CAB_PEDIDOS WHERE IdFactura=FACTURAS.IdFactura) As 'Pedidos',
	        FechaEmitida As [Fecha Emitida],
	        FACTURAS.FechaEnvio As [Fecha Envoio],
	        FACTURAS.FechaPago As [Fecha Pago],
	        Estado
        FROM FACTURAS
        WHERE 1 = 1
"

        sentenciaWhereFactura = ""

        If Not String.IsNullOrEmpty(inputIdFactura.Text.Trim) Then
            consulta &= $" AND IdFactura = '{inputIdFactura.Text.Trim}'"
            sentenciaWhereFactura &= $" AND IdFactura = '{inputIdFactura.Text.Trim}'"
        End If

        If Not String.IsNullOrEmpty(comboEstadoFactura.Text.Trim) Then
            consulta &= $" And Estado = '{comboEstadoFactura.Text}'"
            sentenciaWhereFactura &= $" And Estado = '{comboEstadoFactura.Text}'"
        End If

        If Not String.IsNullOrEmpty(comboIdPedido.Text.Trim) Then
            consulta &= $" AND IdPedido = '{comboIdPedido.Text.Trim}'"
            sentenciaWhereFactura &= $" AND IdPedido = '{comboIdPedido.Text.Trim}'"
        End If

        If checkFechaEmitidaDesdeFacturas.Checked Then
            Dim fechaEmitidaDesde As String = DateFechaEmitidaDesdeFactura.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaEmitida, 112) >= CONVERT(DATE, '{fechaEmitidaDesde}', 112)"
            sentenciaWhereFactura &= $" AND CONVERT(DATE, FechaEmitida, 112) >= CONVERT(DATE, '{fechaEmitidaDesde}', 112)"
        End If

        If checkFechaEmitidaHastaFacturas.Checked Then
            Dim fechaEmitidaHasta As String = DateFechaEmitidaHastaFactura.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaEmitida, 112) <= CONVERT(DATE, '{fechaEmitidaHasta}', 112)"
            sentenciaWhereFactura &= $" AND CONVERT(DATE, FechaEmitida, 112) <= CONVERT(DATE, '{fechaEmitidaHasta}', 112)"
        End If

        If checkFechaEnvioDesdeFacturas.Checked Then
            Dim fechaEnvioDesde As String = DateFechaEnvioDesdeFactura.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaEnvio, 112) >= CONVERT(DATE, '{fechaEnvioDesde}', 112)"
            sentenciaWhereFactura &= $" AND CONVERT(DATE, FechaEnvio, 112) >= CONVERT(DATE, '{fechaEnvioDesde}', 112)"
        End If

        If checkFechaEnvioHastaFacturas.Checked Then
            Dim fechaEnvioHasta As String = DateFechaEnvioHastaFactura.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaEnvio, 112) <= CONVERT(DATE, '{fechaEnvioHasta}', 112)"
            sentenciaWhereFactura &= $" AND CONVERT(DATE, FechaEnvio, 112) <= CONVERT(DATE, '{fechaEnvioHasta}', 112)"
        End If

        If checkFechaPagoDesdeFacturas.Checked Then
            Dim fechaPagoDesde As String = DateFechaPagoDesdeFactura.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaPago, 112) >= CONVERT(DATE, '{fechaPagoDesde}', 112)"
            sentenciaWhereFactura &= $" AND CONVERT(DATE, FechaPago, 112) >= CONVERT(DATE, '{fechaPagoDesde}', 112)"
        End If

        If checkFechaPagoHastaFacturas.Checked Then
            Dim fechaPagoHasta As String = DateFechaPagoHastaFactura.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaPago, 112) <= CONVERT(DATE, '{fechaPagoHasta}', 112)"
            sentenciaWhereFactura &= $" AND CONVERT(DATE, FechaPago, 112) <= CONVERT(DATE, '{fechaPagoHasta}', 112)"
        End If

        dataTable = ConsultaBBDD(connectionString, consulta)
        dataGridFacturas.DataSource = dataTable
    End Sub


    '---------------------------------------------------------'
    '                                                         '
    '               ABILITAR/DESHABILITAR FECHAS              '
    '                                                         '
    '---------------------------------------------------------'

    Private Sub checkFechaEmitidaDesdeFacturas_CheckedChanged(sender As Object, e As EventArgs) Handles checkFechaEmitidaDesdeFacturas.CheckedChanged
        DateFechaEmitidaDesdeFactura.Enabled = checkFechaEmitidaDesdeFacturas.Checked
    End Sub

    Private Sub checkFechaEmitidaHastaFacturas_CheckedChanged(sender As Object, e As EventArgs) Handles checkFechaEmitidaHastaFacturas.CheckedChanged
        DateFechaEmitidaHastaFactura.Enabled = checkFechaEmitidaHastaFacturas.Checked
    End Sub

    Private Sub checkFechaEnvioDesdeFacturas_CheckedChanged(sender As Object, e As EventArgs) Handles checkFechaEnvioDesdeFacturas.CheckedChanged
        DateFechaEnvioDesdeFactura.Enabled = checkFechaEnvioDesdeFacturas.Checked
    End Sub

    Private Sub checkFechaEnvioHastaFacturas_CheckedChanged(sender As Object, e As EventArgs) Handles checkFechaEnvioHastaFacturas.CheckedChanged
        DateFechaEnvioHastaFactura.Enabled = checkFechaEnvioHastaFacturas.Checked
    End Sub

    Private Sub checkFechaPagoDesdeFacturas_CheckedChanged(sender As Object, e As EventArgs) Handles checkFechaPagoDesdeFacturas.CheckedChanged
        DateFechaPagoDesdeFactura.Enabled = checkFechaPagoDesdeFacturas.Checked
    End Sub

    Private Sub checkFechaPagoHastaFacturas_CheckedChanged(sender As Object, e As EventArgs) Handles checkFechaPagoHastaFacturas.CheckedChanged
        DateFechaPagoHastaFactura.Enabled = checkFechaPagoHastaFacturas.Checked
    End Sub

    '---------------------------------------------------------'
    '                                                         '
    '               ABRIR LA FACTURA DOBLE CLICK              '
    '                                                         '
    '---------------------------------------------------------'

    Private Sub DataGridPartners_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridFacturas.CellDoubleClick
        ' Verifica si la celda seleccionada es válida y si es necesario realizar alguna acción específica
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Obtiene el valor de la celda
            Dim IdFactura As Object = dataGridFacturas.Rows(e.RowIndex).Cells(0).Value

            ' Abrir formulario del artiiculo
            formularioFacturas = New FormularioFacturas(IdFactura, sentenciaWhereFactura, ModoVer)
            formularioFacturas.Show()
        End If
    End Sub

    ' Cuando se cierra el FormularioFacturas se actualiza el DataGrid de este formulario
    Private Sub CerrarFormularioFacturas(sender As Object, e As FormClosedEventArgs) Handles formularioFacturas.FormClosed
        CargarDataGrid()
    End Sub

    Private Sub btnGenerarFacturas_Click(sender As Object, e As EventArgs) Handles btnGenerarFacturas.Click
        formularioGenerarFacturas = New GenerarFacturas
        formularioGenerarFacturas.Show()
    End Sub

    ' Cuando se cierra el formulario GenerarFacturas se actualiza el DataGrid de este formulario
    Private Sub CerrarFormularioGenerarFacturas(sender As Object, e As FormClosedEventArgs) Handles formularioGenerarFacturas.FormClosed
        CargarDataGrid()
    End Sub

End Class