﻿Imports System.IO
Imports System.Windows
Imports Dllgaciones.BaseDeDatos

Public Class FormularioPedidos

    Dim ConnectionString As String = ConexionBD.CadenaConexion
    Dim DataTable As DataTable
    Dim DataTableLineas As DataTable
    Dim BindingSource As New BindingSource

    ' ⬇️ Se usa para actualizar este formulario cuando se cierra el de Lineas ⬇️
    Private WithEvents formularioLinea As FormularioLineas
    Private WithEvents formularioPedidos As FormularioPedidos
    Private WithEvents formularioFactura As FormularioFacturas
    Private WithEvents formularioImportarPedidos As ImportarPedidos


    Dim IndiceNavigator As Integer

    Dim SentenciaWhere As String
    Dim SentenciaSelect As String = "SELECT ROW_NUMBER() OVER (ORDER BY IdPedido) AS 
	                                    NumRegistro, 
	                                    cab.IdPedido, 
		                                IdFactura,
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

    Dim ModoFormulario As Integer

    Dim ModoEditar As Integer = ModosFormulario.ModoEditar
    Dim ModoVer As Integer = ModosFormulario.ModoVer
    Dim ModoAñadir As Integer = ModosFormulario.ModoAñadir

    Public Sub New(IdRegistro As Integer, SentenciaWhere As String, ModoFormulario As Integer)
        InitializeComponent()
        ' Guardar las variables recibidas en variables locales 

        Me.ModoFormulario = ModoFormulario
        Me.SentenciaSelect += SentenciaWhere
        Me.SentenciaWhere = SentenciaWhere
        Me.IndiceNavigator = ObtenerNumRegistro(IdRegistro)

    End Sub

    Public Sub New(ModoFormulario As Integer)
        InitializeComponent()

        ' Verificar que no se le ha llamado al contructor de Añadir formulario con otro Modo.
        If ModoFormulario <> ModoAñadir Then
            MsgBox("Se ha llamada al formulario del registro en modo ver, sin el ID del registro. Utilizar el otro constructor para ello",
            vbCritical + vbOKOnly, "Error interno, contacte con el administrador.")
        End If

        ' Guardar las variables recibidas en variables locales 
        Me.ModoFormulario = ModoAñadir
    End Sub

    Function ObtenerNumRegistro(IdRegistro As Integer) As Integer
        ' Metodo para obtener a que indice de BindingNavigator le pertenece a al ID del registro.
        ' Ejemplo: Un binding navigator puede tener 1-8 registros. Y el Id del registro puede ser 31, por ejemplo. 
        ' Lo que hace es coge la consulta original, y añade una columna ordenada por el ID (seria el indice del BindingNavigator)

        Dim NumRegistro As Integer = 0
        Dim Consulta As String =
        $"WITH CTE AS (
		    SELECT ROW_NUMBER() OVER (ORDER BY IdPedido) AS 
	            NumRegistro, 
	            cab.IdPedido, 
		        IdFactura,
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
            WHERE 1=1  {SentenciaWhere}
        )

        SELECT NumRegistro FROM CTE WHERE IdPedido = {IdRegistro}"

        Dim DataTableNumRegistro As DataTable = ConsultaBBDD(ConnectionString, Consulta)

        ' Verificar si ha retornado alguna linea
        If DataTableNumRegistro.Rows.Count > 0 Then
            ' Retrieve the NumRegistro value from the first row
            NumRegistro = Convert.ToInt32(DataTableNumRegistro.Rows(0)("NumRegistro"))
        End If

        Return NumRegistro
    End Function

    Private Sub FormularioPedidos_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Si el el modo del formulario es Añadir no se van a cargar los valores de los inputs.
        If ModoFormulario <> ModoAñadir Then
            DataTable = ConsultaBBDD(ConnectionString, SentenciaSelect)

            'Rellenar biding navigator
            BindingSource.DataSource = DataTable
            BindingSource.Position = IndiceNavigator - 1
            BindNavigatorArticulo.BindingSource = BindingSource

            BindNavigatorArticulo.PositionItem.Text = IndiceNavigator

            'Rellenar los datos 
            ActualizarDatos()
        End If

        ' Detecta el valor de la variable ModoFormulario y ajusta la ventana acorde al modo
        ActualizarModo()
        ActualizarBotonEliminarLineas()
    End Sub

    Private Sub CargarDataGridLineas()
        ' Cargar el DataTableLineas con los valores del pedido actual

        Dim SentenciaLineas As String = $"
            SELECT IdLinea, Nombre Artículo, Cantidad, Descuento, Precio
            FROM LINEAS_PEDIDO ped
            INNER JOIN ARTICULOS art ON (ped.IdArticulo = art.IdArticulo)
            WHERE IdPedido = {inputIdPedido.Text.Trim}"

        DataTableLineas = ConsultaBBDD(ConnectionString, SentenciaLineas)
        dataGridLineas.DataSource = DataTableLineas

        ActualizarBotonEliminarLineas()

    End Sub


    Private Sub ActualizarModo()
        ActualizarBotoneraNavigator()
        ActivarDesactivarInputs()
        ActualizarBotonPrincipal()
        ActualizarDatos()
        ActualizarBotonesAbajo()
    End Sub

    Private Sub ActualizarBotonesAbajo()
        ' Botones Abajo: Añadir Linea, Eliminar Linea, Importar Pedidos

        ' Si el formulario esta en modo Añadir, no mostrar los botones de abajo.
        ' Si el formulario esta en modo Editar o modo Ver mostrar los botones.
        '   Si el boton esta en modo Editar la botonera estará bloqueada
        '   Si el boton esta en modo Ver la botonera estará activada

        If ModoFormulario = ModoEditar Or ModoFormulario = ModoVer Then
            btnAñadirLinea.Visible = True
            btnEliminarLinea.Visible = True
            btnImportarPedidos.Visible = True

            If ModoFormulario = ModoVer Then
                btnAñadirLinea.Enabled = True
                btnEliminarLinea.Enabled = True
                btnImportarPedidos.Enabled = True
            Else
                btnAñadirLinea.Enabled = False
                btnEliminarLinea.Enabled = False
                btnImportarPedidos.Enabled = False
            End If
        ElseIf ModoFormulario = ModoAñadir Then
            btnAñadirLinea.Visible = False
            btnEliminarLinea.Visible = False
            btnImportarPedidos.Visible = False
        End If

    End Sub


    Private Sub ActualizarBotoneraNavigator()

        If ModoFormulario = ModoEditar Then
            ' Si el modo del formulario es editar va a mostrar todos los botones.
            BtnEditar.Image = Delegacion.My.Resources.Resources.confirmar_editar

            BindNavigatorArticulo.Visible = True
            BtnEliminar.Visible = True
        Else
            BtnEditar.Image = Delegacion.My.Resources.Resources.editar

            If ModoFormulario = ModoAñadir Then
                ' Si el modo del formulario es 'Añadir' oculta el binding navigator porque no tiene sentido que esté ahi
                BindNavigatorArticulo.Visible = False
            End If

            BtnEliminar.Visible = False
        End If

    End Sub

    Private Sub ActivarDesactivarInputs()
        ' Si en el recibido ModoFormulario es true, activa los inputs, sino, los desactiva
        If ModoFormulario = ModoEditar Or ModoFormulario = ModoAñadir Then
            comboPartner.Enabled = True
            comboComercial.Enabled = True
            comboTransportista.Enabled = True
            comboEstadoPedido.Enabled = True
            inputFechaPago.Enabled = True
            inputFechaPedido.Enabled = True
            inputFechaEnvio.Enabled = True
        Else
            inputIdPedido.Enabled = False
            inputFechaPago.Enabled = False
            inputFechaPedido.Enabled = False
            inputFechaEnvio.Enabled = False
            comboPartner.Enabled = False
            comboComercial.Enabled = False
            comboTransportista.Enabled = False
            comboEstadoPedido.Enabled = False
        End If

    End Sub

    Private Sub ActualizarBotonPrincipal()
        If ModoFormulario = ModoEditar Then
            btnAbajo.Text = "Actualizar Pedido"
        ElseIf ModoFormulario = ModoAñadir Then
            btnAbajo.Text = "Añadir"
        Else
            btnAbajo.Text = "Listo"
        End If
    End Sub

    Private Sub ActualizarDatos()

        ' Si el modo del formulario es Añadir no va actualizar los datos porque no se muestran
        If ModoFormulario = ModoEditar Or ModoFormulario = ModoVer Then

            DataTable = ConsultaBBDD(ConnectionString, SentenciaSelect)

            Dim indiceNavigator = BindNavigatorArticulo.PositionItem.Text

            ' Si el indice del navigator es 0, es que se esta inicializando. Entonces, se sale del metodo porque no nos interesa.
            If indiceNavigator Is Nothing Or indiceNavigator = "" Or indiceNavigator.Contains("-") Then
                Return
            End If

            If indiceNavigator < 1 Then
                Return
            End If

            Try
                Dim dataRow As DataRow = DataTable.Select("NumRegistro = " & indiceNavigator)(0)

                inputIdPedido.Text = If(dataRow("IdPedido") IsNot DBNull.Value, dataRow("IdPedido"), "")

                ' Poner las fechas 
                Dim fechaPedido As Object = If(dataRow("Fecha Pedido") IsNot DBNull.Value, dataRow("Fecha Pedido"), DBNull.Value)
                Dim fechaEnvio As Object = If(dataRow("Fecha Envío") IsNot DBNull.Value, dataRow("Fecha Envío"), DBNull.Value)
                Dim fechaPago As Object = If(dataRow("Fecha Pago") IsNot DBNull.Value, dataRow("Fecha Pago"), DBNull.Value)

                ' Convertir y formatear las fechas
                inputFechaPedido.Text = If(fechaPedido IsNot DBNull.Value, Convert.ToDateTime(fechaPedido).ToString("yyyy-MM-dd"), "")
                inputFechaEnvio.Text = If(fechaEnvio IsNot DBNull.Value, Convert.ToDateTime(fechaEnvio).ToString("yyyy-MM-dd"), "")
                inputFechaPago.Text = If(fechaPago IsNot DBNull.Value, Convert.ToDateTime(fechaPago).ToString("yyyy-MM-dd"), "")

                ' Rellenar los combos con las foreign keys
                CargarComboBoxes()

                ' Poner el item correspondiente a cada comboxbox comboFactura
                comboPartner.Text = If(dataRow("Partner") IsNot DBNull.Value, dataRow("Partner"), "")
                comboComercial.Text = If(dataRow("Comercial") IsNot DBNull.Value, dataRow("Comercial"), "")
                comboTransportista.Text = If(dataRow("Transportista") IsNot DBNull.Value, dataRow("Transportista"), "")
                comboEstadoPedido.Text = If(dataRow("Estado Pedido") IsNot DBNull.Value, dataRow("Estado Pedido"), "")

            Catch ex As Exception
                MsgBox("Ha habido un error: " + ex.Message, vbCritical + vbOKOnly, "Error")
            End Try

            ' Cargar el DataTableLineas con los valores del pedido actual
            CargarDataGridLineas()

        ElseIf ModoFormulario = ModoAñadir Then
            CargarComboBoxes()
        End If
    End Sub

    Private Sub CargarComboBoxes()

        ' Borra todos los registros de los combos, porque si el formulario esta en modo edicion luego se cargaran
        ' los valores posibles y se duplicarian los datos.
        comboPartner.Items.Clear()
        comboComercial.Items.Clear()
        comboTransportista.Items.Clear()
        comboEstadoPedido.Items.Clear()

        ' Combo Partners
        Dim DataTableComboPartners As DataTable = ConsultaBBDD(ConnectionString, "SELECT Nombre FROM PARTNERS")
        For Each fila As DataRow In DataTableComboPartners.Rows
            Dim partner As String = fila("Nombre").ToString()
            If Not comboPartner.Items.Contains(partner) Then
                comboPartner.Items.Add(partner)
            End If
        Next

        ' Combo Comerciales
        Dim DataTableComboComerciales As DataTable = ConsultaBBDD(ConnectionString, "SELECT Nombre + ' ' + Apellidos As Comerciales FROM COMERCIALES")
        For Each fila As DataRow In DataTableComboComerciales.Rows
            Dim comercial As String = fila("Comerciales").ToString()
            If Not comboComercial.Items.Contains(comercial) Then
                comboComercial.Items.Add(comercial)
            End If
        Next

        ' Combo Transportistas
        Dim DataTableComboTransportista As DataTable = ConsultaBBDD(ConnectionString, "SELECT Empresa FROM TRANSPORTISTAS")
        For Each fila As DataRow In DataTableComboTransportista.Rows
            Dim transportista As String = fila("Empresa").ToString()
            If Not comboTransportista.Items.Contains(transportista) Then
                comboTransportista.Items.Add(transportista)
            End If
        Next

        ' Combo Estado Pedido
        Dim DataTableComboEstadoPedido As DataTable = ConsultaBBDD(ConnectionString, "SELECT Descripcion FROM ESTADO_PEDIDOS")
        For Each fila As DataRow In DataTableComboEstadoPedido.Rows
            Dim estadoPedido As String = fila("Descripcion").ToString()
            If Not comboEstadoPedido.Items.Contains(estadoPedido) Then
                comboEstadoPedido.Items.Add(estadoPedido)
            End If
        Next


    End Sub

    Private Sub BindingNavigatorPositionItem_TextChanged(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.TextChanged
        ' Cuando el valor del indice del BindingNavigator cambie, se actualizaran los datos.
        ActualizarDatos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        ' btnEdtiar: Boton de edicion del BindingNavitor
        If ModoFormulario = ModoEditar Then
            ActualizarRegistro()
        Else
            InterruptorModoEdicion()
        End If
    End Sub

    Private Sub InterruptorModoEdicion()
        ' Si el modo del forulario es editar, lo cambia a ver; y viceversa.
        If ModoFormulario = ModoEditar Then
            ModoFormulario = ModoVer
        Else
            ModoFormulario = ModoEditar
        End If
        ActualizarModo()
    End Sub

    Private Sub btnAbajo_Click(sender As Object, e As EventArgs) Handles btnAbajo.Click
        ' btnAbajo: el boton que está abajo del formulario. Según el modo va a cambiar lo que hace
        If ModoFormulario = ModoEditar Then
            ActualizarRegistro()
        ElseIf ModoFormulario = ModoAñadir Then
            InsertarRegistro()
        ElseIf ModoFormulario = ModoVer Then
            Me.Close()
        End If
    End Sub

    Private Sub InsertarRegistro()
        If ValidarCampos() = True Then


            ' Obtener valores de los inputs
            'Dim idPedido As Integer = inputIdPedido.Text.Trim
            Dim partner As String = comboPartner.Text.Trim
            Dim comercial As String = comboComercial.Text.Trim
            Dim transportista As String = comboTransportista.Text.Trim
            Dim estadoPedido As String = comboEstadoPedido.Text.Trim
            Dim fechaPedido As Date = inputFechaPedido.Text.Trim
            Dim fechaEnvio As Date = inputFechaEnvio.Text.Trim
            Dim fechaPago As Date = inputFechaPago.Text.Trim

            ' Construccion de la Consulta
            Dim registrosActualizados As Integer



            Dim consulta As String = $"
        INSERT INTO CAB_PEDIDOS(IdPartner, IdComercial, IdTransportista, IdEstadoPedido, FechaPedido, FechaEnvio, FechaPago)
        VALUES (
		(SELECT TOP 1 IdPartner FROM PARTNERS WHERE NOMBRE = '{partner}'), 
		(SELECT TOP 1 IdComercial FROM COMERCIALES WHERE Nombre + ' ' + Apellidos = '{comercial}'), 
		(SELECT TOP 1 IdTransportista FROM TRANSPORTISTAS WHERE Empresa = '{transportista}'), 
		(SELECT TOP 1 IdEstadoPedido FROM ESTADO_PEDIDOS WHERE Descripcion = '{estadoPedido}'), 
		CONVERT(DATETIME, '{fechaPedido}', 103), 
		CONVERT(DATETIME, '{fechaEnvio}', 103), 
		CONVERT(DATETIME, '{fechaPago}', 103))
        "

            registrosActualizados = UpdateBBDD(ConnectionString, consulta)

            If registrosActualizados = 1 Then
                MsgBox("Registro insertado con éxito.", vbInformation + vbOKOnly, "Registro insertado")
            Else
                MsgBox("Ha habido un error al insertar el registro.", vbExclamation + vbOKOnly, "Error de base de datos")
            End If

            InterruptorModoEdicion()
            Me.Close()
        End If
    End Sub

    Private Sub ActualizarRegistro()

        If ValidarCampos() = True Then

            ' Obtener valores de los inputs
            Dim idPedido As String = inputIdPedido.Text.Trim
            Dim partner As String = comboPartner.Text.Trim
            Dim comercial As String = comboComercial.Text.Trim
            Dim transportista As String = comboTransportista.Text.Trim
            Dim estadoPedido As String = comboEstadoPedido.Text.Trim
            Dim fechaPedido As Date = inputFechaPedido.Text.Trim
            Dim fechaEnvio As Date = inputFechaEnvio.Text.Trim
            Dim fechaPago As Date = inputFechaPago.Text.Trim

            Dim consulta As String = $"UPDATE CAB_PEDIDOS SET 
                                IdPartner = (SELECT IdPartner FROM PARTNERS WHERE Nombre = '{partner}'),
                                IdComercial = (SELECT IdComercial FROM COMERCIALES comer WHERE comer.Nombre + ' ' + comer.Apellidos = '{comercial}'), 
                                IdTransportista = (SELECT IdTransportista FROM TRANSPORTISTAS WHERE Empresa = '{transportista}'),
                                IdEstadoPedido = (SELECT IdEstadoPedido FROM ESTADO_PEDIDOS WHERE Descripcion = '{estadoPedido}'),
                                FechaPedido = CONVERT(date, '{fechaPedido}', 105), 
                                FechaEnvio = CONVERT(date, '{fechaEnvio}', 105), 
                                FechaPago = CONVERT(date, '{fechaPago}', 105)
                                WHERE IdPedido = '{idPedido}'"


            Dim registrosActualizados As Integer = UpdateBBDD(ConnectionString, consulta)

            If registrosActualizados = 1 Then
                MsgBox("Registro actualizado con éxito.", vbInformation + vbOKOnly, "Registro actualizado")
            Else
                MsgBox("Ha habido un error al actualizar el registro.", vbExclamation + vbOKOnly, "Error de base de datos")
            End If

            InterruptorModoEdicion()
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        ' BindingNavigatorAddNewItem: boton añadir del BindingNavigator
        formularioPedidos = New FormularioPedidos(ModoAñadir)
        formularioPedidos.Show()
    End Sub

    Private Sub DataGridLineas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridLineas.CellDoubleClick
        ' Verifica si la celda seleccionada es válida y si es necesario realizar alguna acción específica
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Obtiene el valor de la celda
            Dim IdLinea As Object = dataGridLineas.Rows(e.RowIndex).Cells(0).Value

            ' Abrir formulario de la linea
            formularioLinea = New FormularioLineas(IdLinea, $" AND IdPedido = {inputIdPedido.Text}", ModoVer)
            formularioLinea.Show()
        End If
    End Sub

    Private Sub CerrarFormularioImportar(sender As Object, e As FormClosedEventArgs) Handles formularioImportarPedidos.FormClosed
        ActualizarDatos()
    End Sub

    Private Sub CerrarFormularioLineas(sender As Object, e As FormClosedEventArgs) Handles formularioLinea.FormClosed
        ActualizarDatos()
    End Sub

    Private Sub CerrarFormularioPedidos(sender As Object, e As FormClosedEventArgs) Handles formularioPedidos.FormClosed
        DataTable = ConsultaBBDD(ConnectionString, SentenciaSelect)

        'Rellenar biding navigator
        BindingSource.DataSource = DataTable
        BindingSource.Position = IndiceNavigator - 1
        BindNavigatorArticulo.BindingSource = BindingSource

        BindNavigatorArticulo.PositionItem.Text = IndiceNavigator

        ActualizarDatos()
    End Sub

    Private Sub btnAñadirLinea_Click(sender As Object, e As EventArgs) Handles btnAñadirLinea.Click
        formularioLinea = New FormularioLineas(ModoAñadir)
        formularioLinea.Show()
    End Sub

    Private Sub btnImportarPedidos_Click(sender As Object, e As EventArgs) Handles btnImportarPedidos.Click
        formularioImportarPedidos = New ImportarPedidos()
        formularioImportarPedidos.Show()
    End Sub

    Private Sub btnEliminarLinea_Click(sender As Object, e As EventArgs) Handles btnEliminarLinea.Click

        If dataGridLineas.SelectedRows.Count > 0 Then
            For Each fila As DataGridViewRow In dataGridLineas.SelectedRows

                ' Por cada registro seleccionado pregunta si quiere eliminarlo
                Dim idLinea As Integer = CInt(fila.Cells("IdLinea").Value.ToString())
                Dim articulo As String = fila.Cells("Artículo").Value.ToString()

                Dim respuesta As DialogResult = MessageBox.Show($"¿Quieres eliminar la línea del artículo {articulo} (Linea: {idLinea})? ", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If respuesta = DialogResult.Yes Then

                    Dim columnasEliminadas As Integer = DeleteBBDD(ConnectionString, $"DELETE FROM LINEAS_PEDIDO WHERE IdLinea = {idLinea}")
                    If (columnasEliminadas > 0) Then
                        MsgBox($"El artículo {articulo} ha sido eliminado con éxito.", vbInformation + vbOKOnly, "Artícluo eliminado con éxito.")
                    Else
                        MsgBox($"No se ha podido eliminar el artículo {articulo}. Intentelo de nuevo, por favor.", vbExclamation + vbOKOnly, "Error al eliminar el artículo.")
                    End If
                End If
            Next

            ActualizarDatos()
        Else
            MsgBox("Seleccione al menos una línea para poder eliminarla. Ten en cuenta que tienes que seleccionar la línea entera haciendo click en la primera columna de la tabla.", vbExclamation + vbOKOnly, "Seleccione líneas.")
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        ' BtnEliminar: boton de eliminar que está situado en el BindingNavigator

        Dim IdPedido As Integer = inputIdPedido.Text.Trim

        ' Verifica si hay un valor actual
        If BindingSource.Current IsNot Nothing Then
            ' Preguntar al usuario si quiere eliminar
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este pedido? ¡Se eliminarán las lineas asociadas!", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Si el usuario a seleccionado que sí, borra el registro
            If result = DialogResult.Yes Then

                Dim consulta As String = $"DELETE FROM LINEAS_PEDIDO WHERE IdPedido = {IdPedido}"
                Dim lineasEliminadas = DeleteBBDD(ConnectionString, consulta)

                MsgBox($"Se han eliminado {lineasEliminadas} líneas asociadas al pedido.", vbInformation + vbOKOnly, "Líneas eliminadas")

                consulta = $"DELETE FROM CAB_PEDIDOS WHERE IdPedido = {IdPedido}"
                Dim pedidosEliminados As Integer = DeleteBBDD(ConnectionString, consulta)

                If pedidosEliminados > 0 Then
                    MsgBox($"El pedido con le ID {IdPedido} ha sido eliminado exitosamente.", vbInformation + vbOKOnly, "Pedido eliminado")
                Else
                    MsgBox($"No se ha podido eliminar el pedido con el ID {IdPedido}", vbInformation + vbOKOnly, "Error")
                End If


                DataTable = ConsultaBBDD(ConnectionString, SentenciaSelect)

                ' Actualizar el fuente de datos (BindingSource) que tiene asignado el BindingNavigator 
                BindingSource.DataSource = DataTable

                ' Verificar si no quedan registros después de eliminar
                If DataTable.Rows.Count = 0 Then
                    ' Cerrar el formulario
                    Me.Close()
                    Return
                End If

                ' Mover al elemento siguiente/anterior (Para actualizar los registros)
                If BindNavigatorArticulo.MoveNextItem.Enabled Then
                    BindNavigatorArticulo.MoveNextItem.PerformClick()
                Else
                    BindNavigatorArticulo.MovePreviousItem.PerformClick()
                End If

            End If
        End If

        ModoFormulario = ModoVer
        ActualizarModo()

    End Sub
    Function ValidarCampos() As Boolean
        ' Función para validar el formulario entero. La función retornará un booleano sobre si es válido o no.

        Dim partner As String = comboPartner.Text.Trim
        Dim comercial As String = comboComercial.Text.Trim
        Dim transportista As String = comboTransportista.Text.Trim
        Dim estadoPedido As String = comboEstadoPedido.Text.Trim
        Dim fechaPedido As String = inputFechaPedido.Text.Trim
        Dim fechaEnvio As String = inputFechaEnvio.Text.Trim
        Dim fechaPago As String = inputFechaPago.Text.Trim
        Dim fechaPedidoDate, fechaEnvioDate, fechaPagoDate As Date

        If String.IsNullOrEmpty(partner) Then
            MsgBox("¡Debe seleccionar un partner!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        If String.IsNullOrEmpty(comercial) Then
            MsgBox("¡Debe seleccionar un comercial!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        If String.IsNullOrEmpty(transportista) Then
            MsgBox("¡Debe seleccionar un transportista!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        If String.IsNullOrEmpty(estadoPedido) Then
            MsgBox("¡Debe seleccionar el estado del pedido!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        Return True

    End Function


    '---------------------------------------------------------'
    '                                                         '
    '           HABILITAR / DESHABILITAR BOTON ELIMINAR       '
    '              CUANDO SE SELECCIONA UNA LINEA             '
    '                                                         '
    '---------------------------------------------------------'

    Private Sub ActualizarBotonEliminarLineas()
        If dataGridLineas.SelectedRows.Count > 0 Then
            ' Habilitar el botón cuando al menos una fila está seleccionada
            btnEliminarLinea.Enabled = True
        Else
            ' Deshabilitar el botón si no hay filas seleccionadas
            btnEliminarLinea.Enabled = False
        End If
    End Sub

    Private Sub dataGridLineas_SelectionChanged(sender As Object, e As EventArgs) Handles dataGridLineas.SelectionChanged
        ActualizarBotonEliminarLineas()
    End Sub


End Class