Imports System.Data.SqlClient
Imports Dllgaciones.BaseDeDatos

Public Class Gestion

    Dim connectionString As String = ConexionBD.CadenaConexion
    Dim dataTable As DataTable

    Public Const ModoEditar As Integer = 1
    Public Const ModoVer As Integer = 2
    Public Const ModoAñadir As Integer = 3

    Dim sentenciaWhereArticulos As String = ""

    Private Sub Gestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ajustar_Anchuras_DataGrids()

        Me.ControlBox = False

        ' ⬇️ Insertar datos de los combobox⬇️ ' 
        ActualizarComboBoxCategoria()
        ActualizarComboBoxZonas()
    End Sub

    Private Sub Gestion_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Ajustar_Anchuras_DataGrids()
    End Sub

    Private Sub Ajustar_Anchuras_DataGrids()
        dataGridArticulos.Width = Me.ClientSize.Width - 100
        dataGridPartners.Width = Me.ClientSize.Width - 100
        dataGridComerciales.Width = Me.ClientSize.Width - 100
        dataGridTransportistas.Width = Me.ClientSize.Width - 100
    End Sub

    '---------------------------------------------------------'
    '                                                         '
    '                      ARTICULOS                          '
    '                                                         '
    '---------------------------------------------------------'

    Private Sub BtnConsultarArticulos_Click(sender As Object, e As EventArgs) Handles btnConsultarArticulos.Click
        ' Construir la sentencia SQL base
        Dim consulta As String = "
        SELECT IdArticulo, Nombre, Descripcion, Categoria, Proveedor, Prvent, PrCost, Existencias, SobreMaximo, BajoMinimo 
        FROM ARTICULOS 
        WHERE 1 = 1"

        sentenciaWhereArticulos = ""

        ' Agregar condiciones según los valores ingresados en los controles
        If Not String.IsNullOrEmpty(inputIdArticulo.Text.Trim) Then
            consulta &= $" AND IdArticulo = {inputIdArticulo.Text.Trim}"
            sentenciaWhereArticulos &= $" AND IdArticulo = {inputIdArticulo.Text.Trim}"
        End If

        If Not String.IsNullOrEmpty(inputNombreArticulo.Text.Trim) Then
            consulta &= $" AND UPPER(Nombre) LIKE '%{inputNombreArticulo.Text.ToUpper.Trim}%'"
            sentenciaWhereArticulos &= $" AND UPPER(Nombre) LIKE '%{inputNombreArticulo.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(inputProveedorArticulo.Text.Trim) Then
            consulta &= $" AND UPPER(Proveedor) LIKE '%{inputProveedorArticulo.Text.ToUpper}%'"
            sentenciaWhereArticulos &= $" AND UPPER(Proveedor) LIKE '%{inputProveedorArticulo.Text.ToUpper}%'"
        End If

        If Not String.IsNullOrEmpty(inputExistenciasArticulo.Text.Trim) Then
            consulta &= $" AND Existencias = {inputExistenciasArticulo.Text.Trim}"
            sentenciaWhereArticulos &= $" AND Existencias = {inputExistenciasArticulo.Text.Trim}"
        End If

        If Not String.IsNullOrEmpty(inputPrCostArticulos.Text.Trim) Then
            consulta &= $" AND PrCost = {inputPrCostArticulos.Text.Trim}"
            sentenciaWhereArticulos &= $" AND PrCost = {inputPrCostArticulos.Text.Trim}"
        End If

        If Not String.IsNullOrEmpty(inputPrVentArticulos.Text.Trim) Then
            consulta &= $" AND PrVent = {inputPrCostArticulos.Text.Trim}"
            sentenciaWhereArticulos &= $" AND PrVent = {inputPrCostArticulos.Text.Trim}"
        End If

        If Not String.IsNullOrEmpty(inputSobreMaximoArticulos.Text.Trim) Then
            consulta &= $" AND SobreMaximo = {inputSobreMaximoArticulos.Text.Trim}"
            sentenciaWhereArticulos &= $" AND SobreMaximo = {inputSobreMaximoArticulos.Text.Trim}"
        End If

        If Not String.IsNullOrEmpty(inputBajoMinimoArticulos.Text.Trim) Then
            consulta &= $" AND BajoMinimo = {inputBajoMinimoArticulos.Text.Trim}"
            sentenciaWhereArticulos &= $" AND BajoMinimo = {inputBajoMinimoArticulos.Text.Trim}"
        End If

        If Not String.IsNullOrEmpty(comboCategoriaArticulos.Text.Trim) Then
            consulta &= $" AND Categoria = '{comboCategoriaArticulos.Text.Trim}'"
            sentenciaWhereArticulos &= $" AND Categoria = '{comboCategoriaArticulos.Text.Trim}'"
        End If

        If Not String.IsNullOrEmpty(inputDescripcionArticulos.Text.Trim) Then
            consulta &= $" AND UPPER(Descripcion) LIKE '%{inputDescripcionArticulos.Text.ToUpper}%'"
            sentenciaWhereArticulos &= $" AND UPPER(Descripcion) LIKE '%{inputDescripcionArticulos.Text.ToUpper}%'"
        End If

        dataTable = ConsultaBBDD(connectionString, consulta)
        dataGridArticulos.AllowUserToAddRows = False

        dataGridArticulos.DataSource = dataTable

    End Sub

    Sub ActualizarComboBoxCategoria()
        comboCategoriaArticulos.Items.Clear()
        Dim consulta As String = $"SELECT DISTINCT CATEGORIA FROM ARTICULOS"
        dataTable = ConsultaBBDD(connectionString, consulta)
        For Each fila As DataRow In dataTable.Rows
            comboCategoriaArticulos.Items.Add(fila("CATEGORIA"))
        Next
    End Sub


    Private Sub DataGridArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridArticulos.CellDoubleClick
        ' Verifica si la celda seleccionada es válida y si es necesario realizar alguna acción específica
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Obtiene el valor de la celda
            Dim IdArticulo As Object = dataGridArticulos.Rows(e.RowIndex).Cells(0).Value

            ' Abrir formulario del artiiculo
            Dim formularioArticulos As New FormularioArticulos(IdArticulo, sentenciaWhereArticulos, ModoVer)
            formularioArticulos.Show()
        End If
    End Sub


    Private Sub BtnAltaArticulos_Click(sender As Object, e As EventArgs) Handles btnAltaArticulos.Click
        Dim formularioArticulos As New FormularioArticulos(ModoAñadir)
        formularioArticulos.Show()
    End Sub


    '---------------------------------------------------------'
    '                                                         '
    '                      PARTNERS                           '
    '                                                         '
    '---------------------------------------------------------'

    Private Sub btnConsultarPartners_Click(sender As Object, e As EventArgs) Handles btnConsultarPartners.Click
        ' Construir la sentencia SQL base
        Dim consulta As String = "
        WITH TablaPartners AS (
            SELECT p.IdPartner, z.Descripcion AS Zona, p.Nombre, p.CIF, p.Direccion, p.Telefono, p.Correo, p.FechaRegistro [Fecha Registro]
            FROM PARTNERS p
            INNER JOIN ZONAS z ON z.IdZona = p.IdZona)
        SELECT * FROM TablaPartners
        WHERE 1=1"

        If Not String.IsNullOrEmpty(inputIdPartner.Text.Trim) Then
            consulta &= $" AND IdPartner = {inputIdPartner.Text.Trim}"
        End If

        If Not String.IsNullOrEmpty(comboZonaPartners.Text.Trim) Then
            consulta &= $" AND UPPER(Zona) LIKE '%{comboZonaPartners.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(inputCifPartners.Text.Trim) Then
            consulta &= $" AND UPPER(CIF) LIKE '%{inputCifPartners.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(inputNombrePartners.Text.Trim) Then
            consulta &= $" AND UPPER(Nombre) LIKE '%{inputNombrePartners.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(inputTelefonoPartners.Text.Trim) Then
            consulta &= $" AND Telefono = {inputTelefonoPartners.Text.Trim}"
        End If

        If Not String.IsNullOrEmpty(inputDireccionPartners.Text.Trim) Then
            consulta &= $" AND UPPER(Direccion) like '%{inputDireccionPartners.Text.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(inputCorreoPartners.Text.Trim) Then
            consulta &= $" AND UPPER(Correo) LIKE '%{inputCorreoPartners.Text.Trim}%'"
        End If

        If checkFechaRegistroDesdePartners.Checked Then
            Dim fechaRegistroDesde As String = inputFechaRegistroPartnersDesde.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, [Fecha Registro], 112) >= CONVERT(DATE, '{fechaRegistroDesde}', 112)"
        End If

        If checkFechaRegistroHastaPartners.Checked Then
            Dim fechaEnvioHasta As String = inputFechaRegistroPartnersHasta.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, [Fecha Registro], 112) <= CONVERT(DATE, '{fechaEnvioHasta}', 112)"
        End If

        dataTable = ConsultaBBDD(connectionString, consulta)
        dataGridPartners.DataSource = dataTable
    End Sub


    ' ⬇️ Habilitar/Desahabilitar Fechas ⬇️ 
    Private Sub checkFechaRegistroDesdePartners_CheckedChanged(sender As Object, e As EventArgs) Handles checkFechaRegistroDesdePartners.CheckedChanged
        inputFechaRegistroPartnersDesde.Enabled = checkFechaRegistroDesdePartners.Checked
    End Sub

    Private Sub checkFechaRegistroHastaPartners_CheckedChanged(sender As Object, e As EventArgs) Handles checkFechaRegistroHastaPartners.CheckedChanged
        inputFechaRegistroPartnersHasta.Enabled = checkFechaRegistroHastaPartners.Checked
    End Sub

    Sub ActualizarComboBoxZonas()
        comboZonaPartners.Items.Clear()
        comboZonaComerciales.Items.Clear()
        comboZona2Comerciales.Items.Clear()

        Dim consulta As String = $"SELECT DISTINCT DESCRIPCION FROM ZONAS"
        dataTable = ConsultaBBDD(connectionString, consulta)
        For Each fila As DataRow In dataTable.Rows
            comboZonaPartners.Items.Add(fila("DESCRIPCION"))
            comboZonaComerciales.Items.Add(fila("DESCRIPCION"))
            comboZona2Comerciales.Items.Add(fila("DESCRIPCION"))
        Next
    End Sub


    '---------------------------------------------------------'
    '                                                         '
    '                       COMERCIALES                       '
    '                                                         '
    '---------------------------------------------------------'
    Private Sub btnConsultarComerciales_Click(sender As Object, e As EventArgs) Handles btnConsultarComerciales.Click
        Dim consulta As String = "
        SELECT IdComercial, 
		    (SELECT DESCRIPCION FROM ZONAS z WHERE IdZona = c.IdZona) Zona1,
		    (SELECT DESCRIPCION FROM ZONAS z WHERE IdZona = c.IdZona2) Zona2,
		    Nombre, Apellidos, Telefono, Correo, Direccion, DNI
        FROM COMERCIALES c
        WHERE 1=1"

        If Not String.IsNullOrEmpty(inputIdComerciales.Text.Trim) Then
            consulta &= $" AND IdComercial = {inputIdComerciales.Text.Trim}"
        End If

        If Not String.IsNullOrEmpty(comboZonaComerciales.Text.Trim) Then
            consulta &= $" AND UPPER(Zona1) LIKE '%{comboZonaComerciales.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(comboZona2Comerciales.Text.Trim) Then
            consulta &= $" AND UPPER(Zona2) LIKE '%{comboZona2Comerciales.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(inputNombreComerciales.Text.Trim) Then
            consulta &= $" AND UPPER(Nombre) LIKE '%{inputNombreComerciales.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(inputApellidosComerciales.Text.Trim) Then
            consulta &= $" AND UPPER(Apellidos) LIKE '%{inputApellidosComerciales.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(inputTelefonoComerciales.Text.Trim) Then
            consulta &= $" AND Telefono = {inputTelefonoComerciales.Text.Trim}"
        End If

        If Not String.IsNullOrEmpty(inputCorreoComerciales.Text.Trim) Then
            consulta &= $" AND UPPER(Correo) LIKE '%{inputCorreoComerciales.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(inputDireccionComerciales.Text.Trim) Then
            consulta &= $" AND UPPER(Direccion) LIKE '%{inputDireccionComerciales.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(inputDNIComerciales.Text.Trim) Then
            consulta &= $" AND UPPER(DNI) LIKE '%{inputDNIComerciales.Text.ToUpper.Trim}%'"
        End If

        dataTable = ConsultaBBDD(connectionString, consulta)
        dataGridComerciales.DataSource = dataTable
    End Sub


    '---------------------------------------------------------'
    '                                                         '
    '                    COMERCIALES                          '
    '                                                         '
    '---------------------------------------------------------'
    Private Sub btnConsultarTransportista_Click(sender As Object, e As EventArgs) Handles btnConsultarTransportista.Click
        Dim consulta As String = "SELECT * FROM TRANSPORTISTAS WHERE 1=1"

        If Not String.IsNullOrEmpty(inputIdTransportistas.Text.Trim) Then
            consulta &= $" AND IdTransportista = {inputIdTransportistas.Text.Trim}"
        End If

        If Not String.IsNullOrEmpty(inputEmpresaTransportistas.Text.Trim) Then
            consulta &= $" AND UPPER(Empresa) LIKE '%{inputEmpresaTransportistas.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(inputTelefonoTransportistas.Text.Trim) Then
            consulta &= $" AND Telefono LIKE '%{inputTelefonoTransportistas.Text.Trim}%'"
        End If

        DataTable = ConsultaBBDD(connectionString, consulta)
        dataGridTransportistas.DataSource = DataTable
    End Sub

End Class