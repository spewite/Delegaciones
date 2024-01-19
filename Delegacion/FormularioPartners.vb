Imports System.IO
Imports Dllgaciones.BaseDeDatos
Public Class FormularioPartners
    Dim ConnectionString As String = ConexionBD.CadenaConexion
    Dim DataTable As DataTable
    Dim BindingSource As New BindingSource

    Dim IndiceNavigator As Integer
    Dim SentenciaWhere As String
    Dim SentenciaSelect As String = "WITH TablaPartners AS (
                                        SELECT ROW_NUMBER() OVER (ORDER BY IdPartner) AS NumRegistro, p.IdPartner, z.Descripcion AS Zona, p.Nombre, p.CIF, p.Direccion, p.Telefono, p.Correo, p.FechaRegistro
                                        FROM PARTNERS p
                                        INNER JOIN ZONAS z ON (z.IdZona = p.IdZona))
                                    SELECT * FROM TablaPartners
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
            SELECT ROW_NUMBER() OVER (ORDER BY IdPartner) AS NumRegistro, p.IdPartner, z.Descripcion AS Zona, p.Nombre, p.CIF, p.Direccion, p.Telefono, p.Correo, p.FechaRegistro
            FROM PARTNERS p
            INNER JOIN ZONAS z ON (z.IdZona = p.IdZona) WHERE 1=1 {SentenciaWhere}
            )

            SELECT NumRegistro FROM CTE WHERE IdPartner = {IdRegistro}"

        TextBox1.Text = Consulta


        Dim DataTableNumRegistro As DataTable = ConsultaBBDD(ConnectionString, Consulta)

        ' Verificar si ha retornado alguna linea
        If DataTableNumRegistro.Rows.Count > 0 Then
            ' Retrieve the NumRegistro value from the first row
            NumRegistro = Convert.ToInt32(DataTableNumRegistro.Rows(0)("NumRegistro"))
        End If

        Return NumRegistro
    End Function


    Private Sub PartnersEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Si el el modo del formulario es Añadir no se van a cargar los valores de los inputs.
        If ModoFormulario <> ModoAñadir Then
            DataTable = ConsultaBBDD(ConnectionString, SentenciaSelect)

            'Rellenar biding navigator
            BindingSource.DataSource = DataTable
            BindingSource.Position = IndiceNavigator - 1
            BindNavigatorPartner.BindingSource = BindingSource

            BindNavigatorPartner.PositionItem.Text = IndiceNavigator

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

            BindNavigatorPartner.Visible = True
            BtnEliminar.Visible = True
        Else
            BtnEditar.Image = Delegacion.My.Resources.Resources.editar

            If ModoFormulario = ModoAñadir Then
                ' Si el modo del formulario es 'Añadir' oculta el binding navigator porque no tiene sentido que esté ahi
                BindNavigatorPartner.Visible = False
            End If

            BtnEliminar.Visible = False
        End If

    End Sub


    Private Sub ActivarDesactivarInputs()
        ' Si en el recibido ModoFormulario es true, activa los inputs, sino, los desactiva
        If ModoFormulario = ModoEditar Or ModoFormulario = ModoAñadir Then
            inputIdPartner.Enabled = True
            inputIdZona.Enabled = True
            inputNombre.Enabled = True
            inputCif.Enabled = True
            inputDireccion.Enabled = True
            inputTelefono.Enabled = True
            inputCorreo.Enabled = True
            inputFechaRegistro.Enabled = True

        Else
            inputIdPartner.Enabled = False
            inputIdZona.Enabled = False
            inputNombre.Enabled = False
            inputCif.Enabled = False
            inputDireccion.Enabled = False
            inputTelefono.Enabled = False
            inputCorreo.Enabled = False
            inputFechaRegistro.Enabled = False
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

            Dim indiceNavigator = BindNavigatorPartner.PositionItem.Text

            ' Si el indice del navigator es 0, es que se esta inicializando. Entonces, se sale del metodo porque no nos interesa.
            If indiceNavigator < 1 Then
                Return
            End If

            Try
                Dim dataRow As DataRow = DataTable.Select("NumRegistro = " & indiceNavigator)(0)

                ' Rellenar los inputs
                inputIdPartner.Text = dataRow("IdPartner")
                inputIdZona.Text = dataRow("Zona")
                inputNombre.Text = If(dataRow("Nombre") IsNot DBNull.Value, dataRow("Nombre"), "")
                inputCif.Text = dataRow("CIF")
                inputDireccion.Text = If(dataRow("Direccion") IsNot DBNull.Value, dataRow("Direccion"), "")
                inputTelefono.Text = If(dataRow("Telefono") IsNot DBNull.Value, dataRow("Telefono"), 0)
                inputCorreo.Text = If(dataRow("Correo") IsNot DBNull.Value, dataRow("Correo"), "")
                inputFechaRegistro.Text = If(dataRow("FechaRegistro") IsNot DBNull.Value, dataRow("FechaRegistro"), "")

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
        ' btnEdtiar: Boton de edicion del BindingNavitor
        If ModoFormulario = ModoEditar Then
            ActualizarPartner()
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
            ActualizarPartner()
        ElseIf ModoFormulario = ModoAñadir Then
            InsertarPartner()
        ElseIf ModoFormulario = ModoVer Then
            Me.Close()
        End If
    End Sub

    Private Sub InsertarPartner()

        Dim CamposSonValidos = ValidarCampos()

        If CamposSonValidos Then

            ' Obtener valores de los inputs
            Dim IdPartner As String = inputIdPartner.Text.Trim
            Dim IdZona As String = inputIdZona.Text.Trim
            Dim Nombre As String = inputNombre.Text.Trim
            Dim Cif As String = inputCif.Text.Trim
            Dim Direccion As String = inputDireccion.Text.Trim
            Dim Telefono As String = inputTelefono.Text.Trim
            Dim Correo As String = inputCorreo.Text.Trim
            Dim FechaRegistro As String = inputFechaRegistro.Text.Trim

            ' Construccion de la Consulta
            Dim registrosActualizados As Integer

            Dim consulta As String = $"
                INSERT INTO PARTNERS (IdPartner, IdZona, Nombre, Cif, Direccion, Telefono, Correo, FechaRegistro) 
                VALUES ('{IdPartner}', '{IdZona}', '{Nombre}', '{Cif}', '{Direccion}', '{Telefono}', '{Correo}', '{FechaRegistro}')"

            If registrosActualizados = 1 Then
                MsgBox("Registro actualizado con éxito.", vbInformation + vbOKOnly, "Registro actualizado")
            Else
                MsgBox("Ha habido un error al actualizar el registro.", vbExclamation + vbOKOnly, "Error de base de datos")
            End If

            InterruptorModoEdicion()
            Me.Close()
        End If
    End Sub

    Private Sub ActualizarPartner()

        ' Validacion de los inputs
        Dim CamposSonValidos = ValidarCampos()

        If CamposSonValidos Then

            ' Obtener valores de los inputs
            Dim IdPartner As String = inputIdPartner.Text.Trim
            Dim IdZona As String = inputIdZona.Text.Trim
            Dim Nombre As String = inputNombre.Text.Trim
            Dim Cif As String = inputCif.Text.Trim
            Dim Direccion As String = inputDireccion.Text.Trim
            Dim Telefono As String = inputTelefono.Text.Trim
            Dim Correo As String = inputCorreo.Text.Trim
            Dim FechaRegistro As String = inputFechaRegistro.Text.Trim

            ' Construccion de la Consulta
            Dim registrosActualizados As Integer

            Dim consulta As String = $"
            UPDATE PARTNERS 
            SET IdZona = {IdZona},
            Nombre = '{Nombre}',
            CIF = '{Cif}',
            Direccion = '{Direccion}',
            Telefono = {Telefono},
            Correo = '{Correo}',
            FechaRegistro = '{FechaRegistro}'
            WHERE IdPartner = {IdPartner}"

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

        Dim IdPartner As String = inputIdPartner.Text.Trim
        Dim IdZona As String = inputIdZona.Text.Trim
        Dim Nombre As String = inputNombre.Text.Trim
        Dim Cif As String = inputCif.Text.Trim
        Dim Direccion As String = inputDireccion.Text.Trim
        Dim Telefono As String = inputTelefono.Text.Trim
        Dim Correo As String = inputCorreo.Text.Trim
        Dim FechaRegistro As String = inputFechaRegistro.Text.Trim

        ' Validacion de los inputs
        If Not Integer.TryParse(Telefono, basura) Then
            MsgBox("¡Debes introducir un valor numerico en el campo de Telefono!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If
        Return True
    End Function


    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        ' BindingNavigatorAddNewItem: boton añadir del BindingNavigator
        Dim formularioPartners As New FormularioPartners(ModoAñadir)
        formularioPartners.Show()
    End Sub
End Class