Imports System.IO
Imports Dllgaciones.BaseDeDatos

Public Class FormularioPedidos

    Dim ConnectionString As String = ConexionBD.CadenaConexion
    Dim DataTable As DataTable
    Dim BindingSource As New BindingSource

    Dim IndiceNavigator As Integer
    Dim SentenciaWhere As String
    Dim SentenciaSelect As String = "SELECT ROW_NUMBER() OVER (ORDER BY IdPedido) AS NumRegistro, * 
                                        FROM CAB_PEDIDOS 
                                        WHERE 1=1"

    Dim ModoFormulario As Integer

    Public Const ModoEditar As Integer = 1
    Public Const ModoVer As Integer = 2
    Public Const ModoAñadir As Integer = 3

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
            SELECT ROW_NUMBER() OVER (ORDER BY IdPedido) AS NumRegistro, *
            FROM CAB_PEDIDOS 
            WHERE 1=1 {SentenciaWhere}
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
        dataGridPedido.DataSource = DataTable
    End Sub

    Private Sub ActualizarModo()
        ActualizarBotoneraNavigator()
        ActivarDesactivarInputs()
        ActualizarBotonAbajo()
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
            comboFactura.Enabled = True
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
            comboFactura.Enabled = False
            comboPartner.Enabled = False
            comboComercial.Enabled = False
            comboTransportista.Enabled = False
            comboEstadoPedido.Enabled = False
        End If

    End Sub

    Private Sub ActualizarBotonAbajo()
        If ModoFormulario = ModoEditar Then
            btnAbajo.Text = "Actualizar"
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
            If indiceNavigator < 1 Then
                Return
            End If

            Try
                Dim dataRow As DataRow = DataTable.Select("NumRegistro = " & indiceNavigator)(0)

                ' Rellenar los inputs
                inputIdPedido.Text = dataRow("IdPedido")
                comboFactura.Text = If(dataRow("IdFactura") IsNot DBNull.Value, dataRow("IdFactura"), "")
                comboPartner.Text = If(dataRow("IdPartner") IsNot DBNull.Value, dataRow("IdPartner"), "")
                comboComercial.Text = If(dataRow("IdComercial") IsNot DBNull.Value, dataRow("IdComercial"), "")
                comboTransportista.Text = If(dataRow("IdTransportista") IsNot DBNull.Value, dataRow("IdTransportista"), 0)
                comboEstadoPedido.Text = If(dataRow("IdEstadoPedido") IsNot DBNull.Value, dataRow("IdEstadoPedido"), 0)
                inputFechaPedido.Text = If(dataRow("FechaPedido") IsNot DBNull.Value, dataRow("FechaPedido"), 0)
                inputFechaEnvio.Text = If(dataRow("FechaEnvio") IsNot DBNull.Value, dataRow("FechaEnvio"), 0)
                inputFechaPago.Text = If(dataRow("FechaPago") IsNot DBNull.Value, dataRow("FechaPago"), 0)

            Catch ex As Exception
                MsgBox("Ha habido un error: " + ex.Message, vbCritical + vbOKOnly, "Error en al leer los datos del a base de datos")
            End Try

        End If
    End Sub

    Private Sub BindingNavigatorPositionItem_TextChanged(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.TextChanged
        ' Cuando el valor del indice del BindingNavigator cambie, se actualizaran los datos.
        ActualizarDatos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

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

    End Sub

    Private Sub InsertarRegistro()

        Dim CamposSonValidos = ValidarCampos()

        If CamposSonValidos Then

            ' Obtener valores de los inputs
            'Dim idPedido As Integer = inputIdPedido.Text.Trim
            Dim factura As Integer = comboFactura.Text.Trim
            Dim partner As Integer = comboPartner.Text.Trim
            Dim comercial As Integer = comboComercial.Text.Trim
            Dim transportista As Integer = comboTransportista.Text.Trim
            Dim estadoPedido As Integer = comboEstadoPedido.Text.Trim
            Dim fechaPedido As Date = inputFechaPedido.Text.Trim
            Dim fechaEnvio As Date = inputFechaEnvio.Text.Trim
            Dim fechaPago As Date = inputFechaPago.Text.Trim

            ' Construccion de la Consulta
            Dim registrosActualizados As Integer

            Dim consulta As String = $"
            INSERT INTO CAB_PEDIDOS(IdFactura, IdPartner, IdComercial, IdTransportista, IdEstadoPedido, FechaPedido, FechaEnvio, FechaPago)
            VALUES ('{factura}', '{partner}', '{comercial}', '{transportista}', '{estadoPedido}', '{fechaPedido}', '{fechaEnvio}', '{fechaPago}')
            "

            registrosActualizados = UpdateBBDD(ConnectionString, consulta)

            If registrosActualizados = 1 Then
                MsgBox("Registro actualizado con éxito.", vbInformation + vbOKOnly, "Registro actualizado")
            Else
                MsgBox("Ha habido un error al actualizar el registro.", vbExclamation + vbOKOnly, "Error de base de datos")
            End If

            InterruptorModoEdicion()
            Me.Close()
        End If
    End Sub

    Private Sub ActualizarRegistro()

        ' Validacion de los inputs
        Dim CamposSonValidos = ValidarCampos()

        If CamposSonValidos Then

            ' Obtener valores de los inputs
            Dim idPedido As Integer = inputIdPedido.Text.Trim
            Dim factura As Integer = comboFactura.Text.Trim
            Dim partner As Integer = comboPartner.Text.Trim
            Dim comercial As Integer = comboComercial.Text.Trim
            Dim transportista As Integer = comboTransportista.Text.Trim
            Dim estadoPedido As Integer = comboEstadoPedido.Text.Trim
            Dim fechaPedido As Date = inputFechaPedido.Text.Trim
            Dim fechaEnvio As Date = inputFechaEnvio.Text.Trim
            Dim fechaPago As Date = inputFechaPago.Text.Trim

            ' Construccion de la Consulta
            Dim registrosActualizados As Integer

            Dim consulta As String = $"
            UPDATE CAB_PEDIDOS 
            SET IdFactura = '{factura}',
            IdPartner = '{partner}',
            IdComercial = '{comercial}',
            IdTransportista = {transportista},
            IdEstadoPedido = {estadoPedido},
            FechaPedido = {fechaPedido},
            FechaEnvio = {fechaEnvio},
            FechaPago = {fechaPago},
            WHERE IdPedido = {idPedido}"

            registrosActualizados = UpdateBBDD(ConnectionString, consulta)

            If registrosActualizados = 1 Then
                MsgBox("Registro actualizado con éxito.", vbInformation + vbOKOnly, "Registro actualizado")
            Else
                MsgBox("Ha habido un error al actualizar el registro.", vbExclamation + vbOKOnly, "Error de base de datos")
            End If

            InterruptorModoEdicion()

        End If

    End Sub

    Function ValidarCampos() As Boolean
        ' Funciona para validar el formulario entero. La funciona retorara un boolean sobre si es valido o no.  

        Dim basura As Integer

        Dim IdArticulo As String = inputIdPedido.Text.Trim
        Dim Nombre As String = comboFactura.Text.Trim
        Dim Categoria As String = comboPartner.Text.Trim
        Dim Proveedor As String = comboComercial.Text.Trim
        Dim Existencias As String = inputFechaPago.Text.Trim
        Dim PrecioCoste As String = comboTransportista.Text.Trim.Replace(".", "").Replace(",", ".")
        Dim PrecioVenta As String = inputFechaPedido.Text.Trim.Replace(".", "").Replace(",", ".")
        Dim BajoMinimo As String = comboEstadoPedido.Text.Trim
        Dim SobreMaximo As String = inputFechaEnvio.Text.Trim

        ' Validacion de los inputs
        If Not Integer.TryParse(Existencias, basura) Then
            MsgBox("¡Debes introducir un valor entero en el campo de existencias!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        If Not Double.TryParse(PrecioCoste, basura) Then
            MsgBox("¡Debes introducir un valor numérico en el campo de precio coste!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        If Not Double.TryParse(PrecioVenta, basura) Then
            MsgBox("¡Debes introducir un valor numérico en el campo de precio venta!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        If Not Integer.TryParse(BajoMinimo, basura) Then
            MsgBox("¡Debes introducir un valor entero en el campo de bajo mínimo!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        If Not Integer.TryParse(SobreMaximo, basura) Then
            MsgBox("¡Debes introducir un valor entero en el campo de sobre máximo!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        Return True
    End Function

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        ' BindingNavigatorAddNewItem: boton añadir del BindingNavigator
        Dim formularioPedidos As New FormularioPedidos(ModoAñadir)
        formularioPedidos.Show()
    End Sub
End Class