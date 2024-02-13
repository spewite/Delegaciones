Imports System.Text.RegularExpressions
Imports Dllgaciones.BaseDeDatos

'https://stackoverflow.com/questions/846395/how-can-i-make-a-datetimepicker-display-an-empty-string
Public Class FormularioFacturas

    Dim ConnectionString As String = ConexionBD.CadenaConexion
    Dim DataTable As DataTable
    Dim BindingSource As New BindingSource

    Dim IndiceNavigator As Integer
    Dim SentenciaWhere As String
    Dim SentenciaSelect As String = "SELECT 
	                                    ROW_NUMBER() OVER (ORDER BY IdFactura) AS NumRegistro,
	                                    IdFactura,
	                                    FechaEmitida,
	                                    FechaEnvio,
	                                    FechaPago,
	                                    Estado
                                    FROM FACTURAS
                                    WHERE 1 = 1"

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
            SELECT 
	            ROW_NUMBER() OVER (ORDER BY IdFactura) AS NumRegistro,
	            IdFactura,
	            FechaEmitida,
	            FechaEnvio,
	            FechaPago,
	            Estado
            FROM FACTURAS
            WHERE 1 = 1  {SentenciaWhere}
        )

        SELECT NumRegistro FROM CTE WHERE IdFactura = {IdRegistro}"

        Dim DataTableNumRegistro As DataTable = ConsultaBBDD(ConnectionString, Consulta)

        ' Verificar si ha retornado alguna linea
        If DataTableNumRegistro.Rows.Count > 0 Then
            ' Retrieve the NumRegistro value from the first row
            NumRegistro = Convert.ToInt32(DataTableNumRegistro.Rows(0)("NumRegistro"))
        End If

        Return NumRegistro
    End Function


    Private Sub FormularioFacturas_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Si el el modo del formulario es Añadir no se van a cargar los valores de los inputs.
        If ModoFormulario <> ModoAñadir Then
            DataTable = ConsultaBBDD(ConnectionString, SentenciaSelect)

            'Rellenar biding navigator
            BindingSource.DataSource = DataTable
            BindingSource.Position = IndiceNavigator - 1
            BindNavigatorFacturas.BindingSource = BindingSource

            BindNavigatorFacturas.PositionItem.Text = IndiceNavigator

            'Rellenar los datos 
            ActualizarDatos()

        End If

        ' Detecta el valor de la variable ModoFormulario y ajusta la ventana acorde al modo
        ActualizarModo()
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

            BindNavigatorFacturas.Visible = True
        Else
            BtnEditar.Image = Delegacion.My.Resources.Resources.editar

            If ModoFormulario = ModoAñadir Then
                ' Si el modo del formulario es 'Añadir' oculta el binding navigator porque no tiene sentido que esté ahi
                BindNavigatorFacturas.Visible = False
            End If

        End If

    End Sub


    Private Sub ActivarDesactivarInputs()
        ' Si en el recibido ModoFormulario es true, activa los inputs, sino, los desactiva
        If ModoFormulario = ModoEditar Then

            comboEstado.Enabled = True
            checkFechaEmitida.Enabled = True
            checkFechaEnvio.Enabled = True
            checkFechaPago.Enabled = True

            If checkFechaEmitida.Checked = True Then
                inputFechaEmitida.Enabled = True
            Else
                inputFechaEmitida.Enabled = False
            End If

            If checkFechaEnvio.Checked = True Then
                inputFechaEnvio.Enabled = True
            Else
                inputFechaEnvio.Enabled = False
            End If

            If checkFechaPago.Checked = True Then
                inputFechaPago.Enabled = True
            Else
                inputFechaPago.Enabled = False
            End If

        ElseIf ModoFormulario = ModoAñadir Then

            comboEstado.Enabled = True
            checkFechaEmitida.Enabled = True
            checkFechaEnvio.Enabled = True
            checkFechaPago.Enabled = True
            inputFechaEmitida.Enabled = True
            inputFechaEnvio.Enabled = True
            inputFechaPago.Enabled = True

        Else
            comboEstado.Enabled = False
            inputFechaEmitida.Enabled = False
            inputFechaEnvio.Enabled = False
            inputFechaPago.Enabled = False
            checkFechaEmitida.Enabled = False
            checkFechaEnvio.Enabled = False
            checkFechaPago.Enabled = False
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

    ' ⬇️ Metodo para rellenar los inputs con los datos de la base de datos del registro actual ⬇️
    Private Sub ActualizarDatos()

        ' Si el modo del formulario es Añadir no va actualizar los datos porque no se muestran
        If ModoFormulario = ModoEditar Or ModoFormulario = ModoVer Then

            DataTable = ConsultaBBDD(ConnectionString, SentenciaSelect)

            Dim indiceNavigator = BindNavigatorFacturas.PositionItem.Text

            ' Si el indice del navigator es 0, es que se esta inicializando. Entonces, se sale del metodo porque no nos interesa.
            If indiceNavigator < 1 Then
                Return
            End If

            Try

                Dim dataRow As DataRow = DataTable.Select("NumRegistro = " & indiceNavigator)(0)

                ' Obtener las fechas del abase de dtaos
                Dim fechaEmitida = dataRow("FechaEmitida")
                Dim fechaEnvio = dataRow("FechaEnvio")
                Dim fechaPago = dataRow("FechaPago")

                ' Activar / Desactivar los inputs dependiendo si en la base de datos son nulos o no
                CargarInputFecha(fechaEmitida, inputFechaEmitida, checkFechaEmitida)
                CargarInputFecha(fechaEnvio, inputFechaEnvio, checkFechaEnvio)
                CargarInputFecha(fechaPago, inputFechaPago, checkFechaPago)

                ' Cargar ComboBox Estado
                'CargarComboEstados()

                ' Rellenar los inputs
                'comboEstado.Text = If(dataRow("Estado") IsNot DBNull.Value, dataRow("Estado"), "")
                inputIdFactura.Text = dataRow("IdFactura")

                ' Rellenar la tabla de pedidos con los pedidos que contiene la factura
                CargarDataGridPedidos()

            Catch ex As Exception
                MsgBox("Ha habido un error: " + ex.Message, vbCritical + vbOKOnly, "Error en al leer los datos del a base de datos")
            End Try

        End If

    End Sub

    ' Queremos que cuando se carge la página actualize los datos para que muestre correctamente los checkboxs.
    ' Si no hiciesemos lo de abajo, los checkboxs no estarian correctamente con el tick 
    Private Sub FormularioFacturas_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ActualizarDatos()
    End Sub

    Private Sub checkFechaEmitida_Click(sender As Object, e As EventArgs) Handles checkFechaEmitida.Click
        ' Si el checkbox esta con tick, el usuario podra seleccionar una fecha
        ' Si el checkbox no tiene un tick, el campo de fecha estará bloqueado y vacio
        If checkFechaEmitida.Checked = True Then
            inputFechaEmitida.Format = DateTimePickerFormat.Custom
            inputFechaEmitida.CustomFormat = "dd/MM/yyyy"
            inputFechaEmitida.Value = DateTime.Now
            inputFechaEmitida.Enabled = True
        Else
            inputFechaEmitida.Format = DateTimePickerFormat.Custom
            inputFechaEmitida.CustomFormat = " "
            inputFechaEmitida.Enabled = False
        End If
    End Sub


    Private Sub checkFechaEnvio_Click(sender As Object, e As EventArgs) Handles checkFechaEnvio.Click
        ' Si el checkbox esta con tick, el usuario podra seleccionar una fecha
        ' Si el checkbox no tiene un tick, el campo de fecha estará bloqueado y vacio
        If checkFechaEnvio.Checked = True Then
            inputFechaEnvio.Format = DateTimePickerFormat.Custom
            inputFechaEnvio.CustomFormat = "dd/MM/yyyy"
            inputFechaEnvio.Value = DateTime.Now
            inputFechaEnvio.Enabled = True
        Else
            inputFechaEnvio.Format = DateTimePickerFormat.Custom
            inputFechaEnvio.CustomFormat = " "
            inputFechaEnvio.Enabled = False
        End If
    End Sub

    Private Sub checkFechaPago_Click(sender As Object, e As EventArgs) Handles checkFechaPago.Click

        ' Si el checkbox esta con tick, el usuario podra seleccionar una fecha
        ' Si el checkbox no tiene un tick, el campo de fecha estará bloqueado y vacio
        If checkFechaPago.Checked = True Then
            inputFechaPago.Format = DateTimePickerFormat.Custom
            inputFechaPago.CustomFormat = "dd/MM/yyyy"
            inputFechaPago.Value = DateTime.Now
            inputFechaPago.Enabled = True
        Else
            inputFechaPago.Format = DateTimePickerFormat.Custom
            inputFechaPago.CustomFormat = " "
            inputFechaPago.Enabled = False
        End If

    End Sub


    Private Sub CargarInputFecha(valorFecha, input, checkbox)

        ' Si el valor de la fecha de la base de datos es nulo, quita el check del checkbox, y si tiene valor, activa el checkbox
        If valorFecha Is DBNull.Value Then
            checkbox.Checked = False
        Else
            checkbox.Checked = True
        End If

        ' Si el checkbox esta activado se le pone el valor del campo de la base de datos, sino, pone una cadena vacia
        If checkbox.Checked Then
            input.Format = DateTimePickerFormat.Custom
            input.CustomFormat = "dd/MM/yyyy"
            input.Value = valorFecha
            ' Solo queremos que el input sea editable cuando el checkbox esta activado y cuando el formulairo esta en modo edicion
            If ModoFormulario = ModoEditar Then
                input.Enabled = True
            Else
                input.Enabled = False
            End If
        Else
            input.Format = DateTimePickerFormat.Custom
            input.CustomFormat = " "
            input.Enabled = False
        End If

    End Sub

    Private Sub CargarDataGridPedidos()

        Dim consultaObtenerPedidos = $"SELECT * FROM CAB_PEDIDOS WHERE IdFactura = {inputIdFactura.Text}"

        Dim dataTablePedidos = ConsultaBBDD(ConnectionString, consultaObtenerPedidos)

        dataGridPedidos.DataSource = dataTablePedidos

    End Sub

    Private Sub BindingNavigatorPositionItem_TextChanged(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.TextChanged
        ' Cuando el valor del indice del BindingNavigator cambie, se actualizaran los datos.
        ActualizarDatos()
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


    Private Sub ActualizarRegistro()

        ' Validacion de los inputs
        Dim CamposSonValidos = ValidarCampos()

        If CamposSonValidos Then

            ' Obtener valores de los inputs
            Dim IdFactura As String = inputIdFactura.Text.Trim
            Dim Estado As String = comboEstado.Text

            Dim FechaEmitida As String
            Dim FechaEnvio As String
            Dim FechaPago As String

            If (checkFechaEmitida.Checked) Then
                FechaEmitida = $"CONVERT(DATE, '{inputFechaEmitida.Text}', 103)"
            Else
                FechaEmitida = "NULL"
            End If

            If (checkFechaEnvio.Checked) Then
                FechaEnvio = $"CONVERT(DATE, '{inputFechaEnvio.Text}', 103)"
            Else
                FechaEnvio = "NULL"
            End If

            If (checkFechaPago.Checked) Then
                FechaPago = $"CONVERT(DATE, '{inputFechaPago.Text}', 103)"
            Else
                FechaPago = "NULL"
            End If

            If comboEstado.Text = "" Then
                Estado = "NULL"
            End If

            ' Construccion de la Consulta
            Dim registrosInsertados As Integer

            ' El convert de la consulta es para cambiar del formato Dia/Mes/Año (Formato que usamos en español) a Año/Mes/Dia (Formato que utiliza SQLSERVER)
            Dim consulta As String =
                $"UPDATE FACTURAS 
                SET FechaEmitida= {FechaEmitida}, 
                FechaEnvio = {FechaEnvio}, 
                FechaPago = {FechaPago}, 
                Estado = {Estado}
                WHERE IdFactura = {IdFactura}"

            registrosInsertados = UpdateBBDD(ConnectionString, consulta)

            If registrosInsertados = 1 Then
                MsgBox("Registro actualizado con éxito.", vbInformation + vbOKOnly, "Registro actualizado")
            Else
                MsgBox("Ha habido un error al actualizar el registro.", vbExclamation + vbOKOnly, "Error de base de datos")
            End If

            InterruptorModoEdicion()

        End If

    End Sub

    Function ValidarCampos() As Boolean
        ' Funciona para validar el formulario entero. La funciona retorara un boolean sobre si es valido o no.  

        Return True

    End Function

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)
        ' BindingNavigatorAddNewItem: boton añadir del BindingNavigator
        Dim formularioTransportistas As New FormularioTransportistas(ModoAñadir)
        formularioTransportistas.Show()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        ' btnEdtiar: Boton de edicion del BindingNavitor
        If ModoFormulario = ModoEditar Then
            ActualizarRegistro()
        Else
            InterruptorModoEdicion()
        End If
    End Sub

    Private Sub btnAbajo_Click(sender As Object, e As EventArgs) Handles btnAbajo.Click
        ' btnAbajo: el boton que está abajo del formulario. Según el modo va a cambiar lo que hace
        If ModoFormulario = ModoEditar Then
            ActualizarRegistro()
        ElseIf ModoFormulario = ModoVer Then
            Me.Close()
        End If
    End Sub


End Class