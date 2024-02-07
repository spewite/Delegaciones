Imports Dllgaciones.BaseDeDatos

Public Class Gestion

    Dim connectionString As String = ConexionBD.CadenaConexion
    Dim dataTable As DataTable

    Dim ModoEditar As Integer = ModosFormulario.ModoEditar
    Dim ModoVer As Integer = ModosFormulario.ModoVer
    Dim ModoAñadir As Integer = ModosFormulario.ModoAñadir

    Dim sentenciaWhereArticulos As String = ""
    Dim sentenciaWherePartners As String = ""
    Dim sentenciaWhereComerciales As String = ""
    Dim sentenciaWhereZonas As String = ""
    Dim sentenciaWhereTransportistas As String = ""


    ' Creamos los formularios aqui con WithEvents. Así cuando se cierre el formulario que se abre podemos actualizar el Datagrid.
    Private WithEvents formularioArticulos As FormularioArticulos
    Private WithEvents formularioPartners As FormularioPartners
    Private WithEvents formularioComerciales As FormularioComerciales
    Private WithEvents formularioTransportistas As FormularioTransportistas
    Private WithEvents formularioZonas As FormularioZonas

    Dim advertenciaSeleccionarRegistroEliminar As String = "Seleccione al menos un registro para poder eliminarla. Ten en cuenta que tienes que seleccionar el artícluo entero haciendo click en la primera columna de la tabla. Puedes seleccionar varias filas manteniendo Ctrl al hacer click, o arrastrando el raton."

    Private Sub Gestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ajustar_Anchuras_DataGrids()

        Me.ControlBox = False

        ' ⬇️ Insertar datos de los combobox⬇️ ' 
        ActualizarComboBoxCategoria()
        ActualizarComboBoxZonas()
        CargarDataGrids()
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

    Private Sub CargarDataGrids()
        CargarDataGridArticulo()
        CargarDataGridPartners()
        CargarDataGridComerciales()
        CargarDataGridTransportistas()
    End Sub

    '---------------------------------------------------------'
    '                                                         '
    '                      ARTICULOS                          '
    '                                                         '
    '---------------------------------------------------------'

    Private Sub BtnConsultarArticulos_Click(sender As Object, e As EventArgs) Handles btnConsultarArticulos.Click
        CargarDataGridArticulo()
    End Sub

    Private Sub CargarDataGridArticulo()
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
        FormularioArticulos = New FormularioArticulos(ModoAñadir)
        FormularioArticulos.Show()
    End Sub

    Private Sub btnBorrarArticulos_Click(sender As Object, e As EventArgs) Handles btnBorrarArticulos.Click
        If dataGridArticulos.SelectedRows.Count > 0 Then
            For Each fila As DataGridViewRow In dataGridArticulos.SelectedRows
                ' Por cada registro seleccionado pregunta si quiere eliminarlo
                Dim idArticulo As Integer = CInt(fila.Cells("IdArticulo").Value.ToString())
                Dim nombreArticulo As String = fila.Cells("Nombre").Value.ToString()

                Dim respuesta As DialogResult = MessageBox.Show($"¿Quieres eliminar el artículo '{nombreArticulo}' (ID: {idArticulo})? ¡Si tiene líneas se van a eliminar! ", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If respuesta = DialogResult.Yes Then

                    ' Eliminar las Lineas que contienen el artículo que queremos eliminar (Si no, no se puede)
                    Dim consultaEliminarLineas As String = $"DELETE From LINEAS_PEDIDO Where IdArticulo = {idArticulo}"
                    Dim lineasEliminadas As Integer = DeleteBBDD(connectionString, consultaEliminarLineas)
                    MsgBox($"Se han eliminado {lineasEliminadas} líneas.", vbInformation + vbOKOnly, "Líneas eliminadas.")

                    ' Eliminar el artículo 
                    Dim consultaEliminarArticulo As String = $"DELETE From ARTICULOS Where IdArticulo = {idArticulo}"
                    Dim articulosEliminados As Integer = DeleteBBDD(connectionString, consultaEliminarArticulo)
                    If (articulosEliminados > 0) Then
                        MsgBox($"El artículo '{nombreArticulo}' ha sido eliminado con éxito.", vbInformation + vbOKOnly, "Artículo eliminado con éxito.")
                    Else
                        MsgBox($"No se ha podido eliminar el artículo '{nombreArticulo}'. Intentelo de nuevo, por favor.", vbExclamation + vbOKOnly, "Error al eliminar el artículo.")
                    End If

                End If
            Next
            CargarDataGridArticulo()
        Else
            MsgBox(advertenciaSeleccionarRegistroEliminar, vbExclamation + vbOKOnly, "Seleccione artículos.")
        End If
    End Sub

    Private Sub CerrarFormularioArticulos(sender As Object, e As FormClosedEventArgs) Handles formularioArticulos.FormClosed
        CargarDataGridArticulo()
    End Sub


    '---------------------------------------------------------'
    '                                                         '
    '                      PARTNERS                           '
    '                                                         '
    '---------------------------------------------------------'

    Private Sub btnConsultarPartners_Click(sender As Object, e As EventArgs) Handles btnConsultarPartners.Click
        CargarDataGridPartners()
    End Sub

    Private Sub CargarDataGridPartners()

        ' Construir la sentencia SQL base
        Dim consulta As String = "
            SELECT p.IdPartner, zonas.Descripcion AS Zona, p.Nombre, p.CIF, p.Direccion, p.Telefono, p.Correo, p.FechaRegistro [Fecha Registro]
            FROM PARTNERS p
            INNER JOIN ZONAS ON zonas.IdZona = p.IdZona
            WHERE 1=1 "

        sentenciaWherePartners = ""

        If Not String.IsNullOrEmpty(inputIdPartner.Text.Trim) Then
            consulta &= $" AND IdPartner = {inputIdPartner.Text.Trim}"
            sentenciaWherePartners &= $" AND IdPartner = {inputIdPartner.Text.Trim}"
        End If

        If Not String.IsNullOrEmpty(comboZonaPartners.Text.Trim) Then
            consulta &= $" AND zonas.Descripcion = '{comboZonaPartners.Text.Trim}'"
            sentenciaWherePartners &= $" AND zonas.Descripcion = '{comboZonaPartners.Text.Trim}'"
        End If

        If Not String.IsNullOrEmpty(inputCifPartners.Text.Trim) Then
            consulta &= $" AND UPPER(Cif) LIKE '%{inputCifPartners.Text.ToUpper.Trim}%'"
            sentenciaWherePartners &= $" AND UPPER(Cif) LIKE '%{inputCifPartners.Text.ToUpper.Trim}"
        End If

        If Not String.IsNullOrEmpty(inputNombrePartners.Text.Trim) Then
            consulta &= $" AND UPPER(Nombre) LIKE '%{inputNombrePartners.Text.ToUpper.Trim}%'"
            sentenciaWherePartners &= $" AND UPPER(Nombre) LIKE '%{inputNombrePartners.Text.ToUpper.Trim}"

        End If

        If Not String.IsNullOrEmpty(inputTelefonoPartners.Text.Trim) Then
            consulta &= $" AND Telefono = {inputTelefonoPartners.Text.Trim}"
            sentenciaWherePartners &= $" AND Telefono = {inputTelefonoPartners.Text.Trim}"
        End If

        If Not String.IsNullOrEmpty(inputDireccionPartners.Text.Trim) Then
            consulta &= $" AND UPPER(Direccion) LIKE '%{inputDireccionPartners.Text.Trim}%'"
            sentenciaWherePartners &= $" AND UPPER(Direccion) LIKE '%{inputDireccionPartners.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(inputCorreoPartners.Text.Trim) Then
            consulta &= $" AND UPPER(Correo) LIKE '%{inputCorreoPartners.Text.Trim}%'"
            sentenciaWherePartners &= $" AND UPPER(Correo) LIKE '%{inputCorreoPartners.Text.ToUpper.Trim}%'"
        End If

        If checkFechaRegistroDesdePartners.Checked Then
            Dim fechaRegistroDesde As String = inputFechaRegistroPartnersDesde.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaRegistro, 112) >= CONVERT(DATE, '{fechaRegistroDesde}', 112)"
            sentenciaWherePartners &= $" AND FechaRegistro >= '{fechaRegistroDesde}'"
        End If

        If checkFechaRegistroHastaPartners.Checked Then
            Dim fechaRegistroHasta As String = inputFechaRegistroPartnersHasta.Value.ToString("yyyyMMdd")
            consulta &= $" AND CONVERT(DATE, FechaRegistro, 112) <= CONVERT(DATE, '{fechaRegistroHasta}', 112)"
            sentenciaWherePartners &= $" AND FechaRegistro <= '{fechaRegistroHasta}'"
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

        Dim consulta As String = $"SELECT DISTINCT DESCRIPCION FROM ZONAS"
        dataTable = ConsultaBBDD(connectionString, consulta)
        For Each fila As DataRow In dataTable.Rows
            comboZonaPartners.Items.Add(fila("DESCRIPCION"))
            comboZonaComerciales.Items.Add(fila("DESCRIPCION"))
        Next
    End Sub
    Private Sub DataGridPartners_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridPartners.CellDoubleClick
        ' Verifica si la celda seleccionada es válida y si es necesario realizar alguna acción específica
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Obtiene el valor de la celda
            Dim IdPartner As Object = dataGridPartners.Rows(e.RowIndex).Cells(0).Value

            ' Abrir formulario del artiiculo
            Dim formularioPartners As New FormularioPartners(IdPartner, sentenciaWherePartners, ModoVer)
            formularioPartners.Show()
        End If
    End Sub

    Private Sub btnAltaPartners_Click(sender As Object, e As EventArgs) Handles btnAltaPartners.Click
        formularioPartners = New FormularioPartners(ModoAñadir)
        formularioPartners.Show()
    End Sub

    Private Sub CerrarFormularioParnters(sender As Object, e As FormClosedEventArgs) Handles formularioPartners.FormClosed
        CargarDataGridPartners()
    End Sub

    Private Sub btnBorrarPartners_Click(sender As Object, e As EventArgs) Handles btnBorrarPartners.Click
        If dataGridPartners.SelectedRows.Count > 0 Then
            For Each fila As DataGridViewRow In dataGridPartners.SelectedRows
                Dim idPartner As Integer = CInt(fila.Cells("IdPartner").Value.ToString())
                Dim nombrePartner As String = fila.Cells("Nombre").Value.ToString()

                ' Por cada registro seleccionado pregunta si quiere eliminarlo
                Dim respuesta As DialogResult = MessageBox.Show($"¿Quieres eliminar el partner '{nombrePartner}' (ID: {idPartner})? ¡Si tiene pedidos asignados se van a desvincular! ", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If respuesta = DialogResult.Yes Then

                    ' Poner a IdPartner = Null todos los pedidos de este partner
                    Dim consultaDesvincularPedidos As String = $"UPDATE CAB_PEDIDOS SET IdPartner = NULL WHERE IdPartner = {idPartner}"
                    Dim pedidosActualizados As Integer = UpdateBBDD(connectionString, consultaDesvincularPedidos)
                    MsgBox($"Se han desvinculado {pedidosActualizados} pedidos.", vbInformation + vbOKOnly, "Partners desvinculados.")

                    ' Eliminar el artículo 
                    Dim consultaEliminarPartner As String = $"DELETE FROM PARTNERS Where IdPartner = {idPartner}"
                    Dim partnersEliminados As Integer = DeleteBBDD(connectionString, consultaEliminarPartner)
                    If (partnersEliminados > 0) Then
                        MsgBox($"El partner '{nombrePartner}' ha sido eliminado con éxito.", vbInformation + vbOKOnly, "Partner eliminado con éxito.")
                    Else
                        MsgBox($"No se ha podido eliminar el partner '{nombrePartner}'. Intentelo de nuevo, por favor.", vbExclamation + vbOKOnly, "Error al eliminar el partner.")
                    End If

                End If
            Next
            CargarDataGridPartners()
        Else
            MsgBox(advertenciaSeleccionarRegistroEliminar, vbExclamation + vbOKOnly, "Seleccione artículos.")
        End If
    End Sub


    '---------------------------------------------------------'
    '                                                         '
    '                       COMERCIALES                       '
    '                                                         '
    '---------------------------------------------------------'
    Private Sub btnConsultarComerciales_Click(sender As Object, e As EventArgs) Handles btnConsultarComerciales.Click
        CargarDataGridComerciales()
    End Sub

    Private Sub CargarDataGridComerciales()
        Dim consulta As String = "
        SELECT IdComercial, 
		    ZONAS.Descripcion As Zona, Nombre, Apellidos, Telefono, Correo, Direccion, DNI
        FROM COMERCIALES c
        INNER JOIN ZONAS ON (ZONAS.IdZona = c.IdZona)
        WHERE 1=1"

        sentenciaWhereComerciales = ""


        If Not String.IsNullOrEmpty(inputIdComerciales.Text.Trim) Then
            consulta &= $" AND IdComercial = {inputIdComerciales.Text.Trim}"
            sentenciaWhereComerciales &= $" AND IdComercial = {inputIdComerciales.Text.Trim}"
        End If

        If Not String.IsNullOrEmpty(comboZonaComerciales.Text.Trim) Then
            consulta &= $" AND UPPER(Zona) LIKE '%{comboZonaComerciales.Text.ToUpper.Trim}%'"
            sentenciaWhereComerciales &= $" AND UPPER(Zona) LIKE '%{comboZonaComerciales.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(inputNombreComerciales.Text.Trim) Then
            consulta &= $" AND UPPER(Nombre) LIKE '%{inputNombreComerciales.Text.ToUpper.Trim}%'"
            sentenciaWhereComerciales &= $" AND UPPER(Nombre) LIKE '%{inputNombreComerciales.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(inputApellidosComerciales.Text.Trim) Then
            consulta &= $" AND UPPER(Apellidos) LIKE '%{inputApellidosComerciales.Text.ToUpper.Trim}%'"
            sentenciaWhereComerciales &= $" AND UPPER(Apellidos) LIKE '%{inputApellidosComerciales.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(inputTelefonoComerciales.Text.Trim) Then
            consulta &= $" AND Telefono = {inputTelefonoComerciales.Text.Trim}"
            sentenciaWhereComerciales &= $" AND Telefono = {inputTelefonoComerciales.Text.Trim}"
        End If

        If Not String.IsNullOrEmpty(inputCorreoComerciales.Text.Trim) Then
            consulta &= $" AND UPPER(Correo) LIKE '%{inputCorreoComerciales.Text.ToUpper.Trim}%'"
            sentenciaWhereComerciales &= $" AND UPPER(Correo) LIKE '%{inputCorreoComerciales.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(inputDireccionComerciales.Text.Trim) Then
            consulta &= $" AND UPPER(Direccion) LIKE '%{inputDireccionComerciales.Text.ToUpper.Trim}%'"
            sentenciaWhereComerciales &= $" AND UPPER(Direccion) LIKE '%{inputDireccionComerciales.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(inputDNIComerciales.Text.Trim) Then
            consulta &= $" AND UPPER(DNI) LIKE '%{inputDNIComerciales.Text.ToUpper.Trim}%'"
            sentenciaWhereComerciales &= $" AND UPPER(DNI) LIKE '%{inputDNIComerciales.Text.ToUpper.Trim}%'"
        End If

        dataTable = ConsultaBBDD(connectionString, consulta)
        dataGridComerciales.DataSource = dataTable

    End Sub

    Private Sub DataGridComerciales_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridComerciales.CellDoubleClick
        ' Verifica si la celda seleccionada es válida y si es necesario realizar alguna acción específica
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Obtiene el valor de la celda
            Dim IdComercial As Object = dataGridComerciales.Rows(e.RowIndex).Cells(0).Value
            ' Abrir formulario del artiiculo
            formularioComerciales = New FormularioComerciales(IdComercial, sentenciaWhereComerciales, ModoVer)
            formularioComerciales.Show()
        End If
    End Sub

    Private Sub btnAltaComerciales_Click(sender As Object, e As EventArgs) Handles btnAltaComerciales.Click
        formularioComerciales = New FormularioComerciales(ModoAñadir)
        formularioComerciales.Show()
    End Sub

    Private Sub CerrarFormularioComerciales(sender As Object, e As FormClosedEventArgs) Handles formularioComerciales.FormClosed
        CargarDataGridComerciales()
    End Sub

    Private Sub btnBorrarComerciales_Click(sender As Object, e As EventArgs) Handles btnBorrarComerciales.Click
        If dataGridComerciales.SelectedRows.Count > 0 Then
            For Each fila As DataGridViewRow In dataGridComerciales.SelectedRows
                Dim idComercial As Integer = CInt(fila.Cells("IdComercial").Value.ToString())
                Dim nombreApellido As String = fila.Cells("Nombre").Value.ToString() + " " + fila.Cells("Apellidos").Value.ToString()

                ' Por cada registro seleccionado pregunta si quiere eliminarlo
                Dim respuesta As DialogResult = MessageBox.Show($"¿Quieres eliminar el comercial '{nombreApellido}' (ID: {idComercial})? ¡Si tiene pedidos asignados se van a desvincular! ", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If respuesta = DialogResult.Yes Then

                    ' Poner a IdTransportista = Null todos los pedidos de este transportista
                    Dim consultaDesvincularComercial As String = $"UPDATE CAB_PEDIDOS SET IdComercial = NULL WHERE IdComercial = {idComercial}"
                    Dim pedidosActualizados As Integer = UpdateBBDD(connectionString, consultaDesvincularComercial)
                    MsgBox($"Se han desvinculado {pedidosActualizados} pedidos.", vbInformation + vbOKOnly, "Comerciales desvinculados.")

                    ' Eliminar el transportista
                    Dim consultaEliminarComercial As String = $"DELETE FROM COMERCIALES Where IdComercial = {idComercial}"
                    Dim comercialesEliminados As Integer = DeleteBBDD(connectionString, consultaEliminarComercial)
                    If (comercialesEliminados > 0) Then
                        MsgBox($"El comercial '{nombreApellido}' ha sido eliminado con éxito.", vbInformation + vbOKOnly, "Comercial eliminado con éxito.")
                    Else
                        MsgBox($"No se ha podido eliminar el comercial '{nombreApellido}'. Intentelo de nuevo, por favor.", vbExclamation + vbOKOnly, "Error al eliminar el comercial.")
                    End If

                End If
            Next
            CargarDataGridComerciales()
        Else
            MsgBox(advertenciaSeleccionarRegistroEliminar, vbExclamation + vbOKOnly, "Seleccione transportista.")
        End If

    End Sub

    '---------------------------------------------------------'
    '                                                         '
    '                     TRANSPORTISTAS                      '
    '                                                         '
    '---------------------------------------------------------'
    Private Sub btnConsultarTransportista_Click(sender As Object, e As EventArgs) Handles btnConsultarTransportista.Click
        CargarDataGridTransportistas()
    End Sub

    Private Sub CargarDataGridTransportistas()
        Dim consulta As String = "SELECT * FROM TRANSPORTISTAS WHERE 1=1"
        sentenciaWhereTransportistas = ""

        If Not String.IsNullOrEmpty(inputIdTransportistas.Text.Trim) Then
            consulta &= $" AND IdTransportista = {inputIdTransportistas.Text.Trim}"
            sentenciaWhereTransportistas &= $" AND IdTransportista = {inputIdTransportistas.Text.Trim}"
        End If

        If Not String.IsNullOrEmpty(inputEmpresaTransportistas.Text.Trim) Then
            consulta &= $" AND UPPER(Empresa) LIKE '%{inputEmpresaTransportistas.Text.ToUpper.Trim}%'"
            sentenciaWhereTransportistas &= $" AND UPPER(Empresa) LIKE '%{inputEmpresaTransportistas.Text.ToUpper.Trim}%'"
        End If

        If Not String.IsNullOrEmpty(inputTelefonoTransportistas.Text.Trim) Then
            consulta &= $" AND Telefono LIKE '%{inputTelefonoTransportistas.Text.Trim}%'"
            sentenciaWhereTransportistas &= $" AND Telefono LIKE '%{inputTelefonoTransportistas.Text.Trim}%'"
        End If

        dataTable = ConsultaBBDD(connectionString, consulta)
        dataGridTransportistas.DataSource = dataTable
    End Sub



    Private Sub DataGridTransoprtistas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridTransportistas.CellDoubleClick
        ' Verifica si la celda seleccionada es válida y si es necesario realizar alguna acción específica
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Obtiene el valor de la celda
            Dim IdTransportista As Object = dataGridTransportistas.Rows(e.RowIndex).Cells(0).Value
            ' Abrir formulario del Transportista
            formularioTransportistas = New FormularioTransportistas(IdTransportista, sentenciaWhereTransportistas, ModoVer)
            formularioTransportistas.Show()
        End If
    End Sub

    Private Sub btnBorrarTransportista_Click(sender As Object, e As EventArgs) Handles btnBorrarTransportista.Click
        If dataGridTransportistas.SelectedRows.Count > 0 Then

            For Each fila As DataGridViewRow In dataGridTransportistas.SelectedRows
                Dim idTransportista As Integer = CInt(fila.Cells("IdTransportista").Value.ToString())
                Dim empresa As String = fila.Cells("Empresa").Value.ToString()

                ' Por cada registro seleccionado pregunta si quiere eliminarlo
                Dim respuesta As DialogResult = MessageBox.Show($"¿Quieres eliminar el transportista '{empresa}' (ID: {idTransportista})? ¡Si tiene pedidos asignados se van a desvincular! ", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If respuesta = DialogResult.Yes Then

                    ' Poner a IdTransportista = Null todos los pedidos de este transportista
                    Dim consultaDesvincularTransportista As String = $"UPDATE CAB_PEDIDOS SET IdTransportista = NULL WHERE IdTransportista = {idTransportista}"
                    Dim pedidosActualizados As Integer = UpdateBBDD(connectionString, consultaDesvincularTransportista)
                    MsgBox($"Se han desvinculado {pedidosActualizados} pedidos.", vbInformation + vbOKOnly, "Transportistas desvinculados.")

                    ' Eliminar el transportista
                    Dim consultaEliminarTransportista As String = $"DELETE FROM TRANSPORTISTAS Where IdTransportista = {idTransportista}"
                    Dim transportistasEliminados As Integer = DeleteBBDD(connectionString, consultaEliminarTransportista)
                    If (transportistasEliminados > 0) Then
                        MsgBox($"El tranpostista '{empresa}' ha sido eliminado con éxito.", vbInformation + vbOKOnly, "Transportista eliminado con éxito.")
                    Else
                        MsgBox($"No se ha podido eliminar el transportista '{empresa}'. Intentelo de nuevo, por favor.", vbExclamation + vbOKOnly, "Error al eliminar el transportista.")
                    End If

                End If
            Next
            CargarDataGridTransportistas()
        Else
            MsgBox(advertenciaSeleccionarRegistroEliminar, vbExclamation + vbOKOnly, "Seleccione transportista.")
        End If

    End Sub

    Private Sub btnAltaTransportista_Click(sender As Object, e As EventArgs) Handles btnAltaTransportista.Click
        formularioTransportistas = New FormularioTransportistas(ModoAñadir)
        formularioTransportistas.Show()
    End Sub

    Private Sub CerrarFormularioTransportistas(sender As Object, e As FormClosedEventArgs) Handles formularioTransportistas.FormClosed
        CargarDataGridTransportistas()
    End Sub



    '---------------------------------------------------------'
    '                                                         '
    '                         ZONAS                           '
    '                                                         '
    '---------------------------------------------------------'

    Private Sub btnConsultarZonas_Click(sender As Object, e As EventArgs) Handles btnConsultarZonas.Click
        CargarDataGridZonas()
    End Sub

    Private Sub CargarDataGridZonas()
        Dim consulta As String = "SELECT * FROM ZONAS WHERE 1=1"
        sentenciaWhereZonas = ""

        If Not String.IsNullOrEmpty(inputIdZona.Text.Trim) Then
            consulta &= $" AND IdZona = {inputIdZona.Text.Trim}"
            sentenciaWhereZonas &= $" AND IdZona = {inputIdZona.Text.Trim}"
        End If

        If Not String.IsNullOrEmpty(inputZonaZonas.Text.Trim) Then
            consulta &= $" AND UPPER(Descripcion) LIKE '%{inputZonaZonas.Text.ToUpper.Trim}%'"
            sentenciaWhereZonas &= $" AND UPPER(Descripcion) LIKE '%{inputZonaZonas.Text.ToUpper.Trim}%'"
        End If


        dataTable = ConsultaBBDD(connectionString, consulta)
        dataGridZonas.DataSource = dataTable
    End Sub

    Private Sub dataGridZonas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridZonas.CellDoubleClick
        ' Verifica si la celda seleccionada es válida y si es necesario realizar alguna acción específica
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Obtiene el valor de la celda
            Dim IdZona As Object = dataGridZonas.Rows(e.RowIndex).Cells(0).Value
            ' Abrir formulario del Zonas
            formularioZonas = New FormularioZonas(IdZona, sentenciaWhereZonas, ModoVer)
            formularioZonas.Show()
        End If
    End Sub

    Private Sub btnBorrarZonas_Click(sender As Object, e As EventArgs) Handles btnBorrarZonas.Click
        If dataGridZonas.SelectedRows.Count > 0 Then

            For Each fila As DataGridViewRow In dataGridZonas.SelectedRows
                Dim idZona As Integer = CInt(fila.Cells("IdZona").Value.ToString())
                Dim Descripcion As String = fila.Cells("Descripcion").Value.ToString()

                ' Por cada registro seleccionado pregunta si quiere eliminarlo
                Dim respuesta As DialogResult = MessageBox.Show($"¿Quieres eliminar la zona '{Descripcion}' (ID: {idZona})? ¡Si tiene Partners o Comerciales asignados se van a desvincular! ", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If respuesta = DialogResult.Yes Then

                    Dim SentenciaUpdateComerciales = $"UPDATE COMERCIALES
                                        SET IdZona = NULL 
                                        WHERE IdZona = {idZona}"

                    Dim SentenciaUpdatePartners = $"UPDATE PARTNERS
                                        SET IdZona = NULL 
                                        WHERE IdZona = {idZona}"


                    Dim comercialesActualizados As Integer = UpdateBBDD(connectionString, SentenciaUpdateComerciales)

                    MsgBox($"Se han desvinculado {comercialesActualizados} comerciales.", vbInformation + vbOKOnly, "Comerciales desvinculados.")


                    Dim partnersActualizados As Integer = UpdateBBDD(connectionString, SentenciaUpdatePartners)

                    MsgBox($"Se han desvinculado {partnersActualizados} partners.", vbInformation + vbOKOnly, "Partners desvinculados.")



                    Dim SentenciaDelete As String = $"DELETE FROM ZONAS WHERE IdZona = {idZona}"

                    Dim registrosEliminados As Integer = DeleteBBDD(connectionString, SentenciaDelete)


                    If registrosEliminados > 0 Then
                        MsgBox($"La Zona con ID {idZona} ha sido eliminado con éxito.", vbInformation + vbOKOnly, "Registro eliminado con éxito.")
                    Else
                        MsgBox("Ha habido un error al eliminar el registro", vbInformation + vbOKOnly, "Error.")
                    End If

                End If
            Next
            CargarDataGridZonas()
        Else
            MsgBox(advertenciaSeleccionarRegistroEliminar, vbExclamation + vbOKOnly, "Seleccione transportista.")
        End If

    End Sub



    Private Sub btnAltaZona_Click(sender As Object, e As EventArgs) Handles btnAltaZona.Click
        formularioZonas = New FormularioZonas(ModoAñadir)
        formularioZonas.Show()
    End Sub

    Private Sub CerrarFormularioZonas(sender As Object, e As FormClosedEventArgs) Handles formularioZonas.FormClosed
        CargarDataGridZonas()
    End Sub


    Private Sub btnImportarArticulos_Click(sender As Object, e As EventArgs) Handles btnImportarArticulos.Click
        Dim formularioImportarArticulos As New ImportarArticulos()
        formularioImportarArticulos.Show()
    End Sub


End Class

