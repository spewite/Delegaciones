Imports System.Data.SqlClient
Imports Dllgaciones.BaseDeDatos
Public Class Facturas

    Dim connectionString As String = ConexionBD.CadenaConexion
    Dim dataTable As DataTable

    Private Sub Facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False

        ' ⬇️ Insertar datos de los combobox ⬇️ '
        ActualizarCombosDeFacturas()

        ' ⬇️ Ajustar la anchura del datagrid al ancho de pantalla ⬇️ '
        AjustarAnchuraDataGrid()
    End Sub

    Private Sub AjustarAnchuraDataGrid()
        ' Ajustar la anchura del datagrid al ancho de pantalla
        dataGridFacturas.Width = Me.ClientSize.Width - 50
    End Sub

    Private Sub Facturas_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        AjustarAnchuraDataGrid()
    End Sub


    Private Sub ActualizarCombosDeFacturas()
        comboEstadoFactura.Items.Add("Pagado")
        comboEstadoFactura.Items.Add("Pendiente de pago")
    End Sub


    '---------------------------------------------------------'
    '                                                         '
    '                         CONSULTA                        '
    '                                                         '
    '---------------------------------------------------------'

    Private Sub btnConsultarPedidos_Click(sender As Object, e As EventArgs) Handles btnConsultarPedidos.Click
        Dim consulta As String = "
        SELECT 
	        IdFactura, FechaEmitida, FechaEnvio, FechaPago,  
	        (SELECT IIF(Estado=0, 'Pagado', 'Pendiente de pago')) Estado	
        FROM FACTURAS
        WHERE 1 = 1"


        If Not String.IsNullOrEmpty(inputIdFactura.Text.Trim) Then
            consulta &= $" AND IdFactura = '{inputIdFactura.Text.Trim}'"
        End If

        If Not String.IsNullOrEmpty(comboEstadoFactura.Text.Trim) Then
            Dim estado As Integer = IIf(comboEstadoFactura.Text.Trim = "Pagado", 0, 1)
            consulta &= $" And Estado = '{estado}'"
        End If

        If checkFechaEmitidaDesdeFacturas.Checked Then
            Dim fechaEmitidaDesde As String = DateFechaEmitidaDesdeFactura.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaEmitida, 112) >= CONVERT(DATE, '{fechaEmitidaDesde}', 112)"
        End If

        If checkFechaEmitidaHastaFacturas.Checked Then
            Dim fechaEmitidaHasta As String = DateFechaEmitidaHastaFactura.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaEmitida, 112) <= CONVERT(DATE, '{fechaEmitidaHasta}', 112)"
        End If

        If checkFechaEnvioDesdeFacturas.Checked Then
            Dim fechaEnvioDesde As String = DateFechaEnvioDesdeFactura.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaEnvio, 112) >= CONVERT(DATE, '{fechaEnvioDesde}', 112)"
        End If

        If checkFechaEnvioHastaFacturas.Checked Then
            Dim fechaEnvioHasta As String = DateFechaEnvioHastaFactura.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaEnvio, 112) <= CONVERT(DATE, '{fechaEnvioHasta}', 112)"
        End If

        If checkFechaPagoDesdeFacturas.Checked Then
            Dim fechaPagoDesde As String = DateFechaPagoDesdeFactura.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaPago, 112) >= CONVERT(DATE, '{fechaPagoDesde}', 112)"
        End If

        If checkFechaPagoHastaFacturas.Checked Then
            Dim fechaPagoHasta As String = DateFechaPagoHastaFactura.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaPago, 112) <= CONVERT(DATE, '{fechaPagoHasta}', 112)"
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

End Class