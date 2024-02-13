Imports System.Globalization
Imports System.IO
Imports Dllgaciones.BaseDeDatos
Public Class FormularioPartners
    Dim ConnectionString As String = ConexionBD.CadenaConexion
    Dim DataTable As DataTable
    Dim BindingSource As New BindingSource

    Dim IndiceNavigator As Integer
    Dim SentenciaWhere As String
    Dim SentenciaSelect As String = "SELECT ROW_NUMBER() OVER (ORDER BY IdPartner) AS NumRegistro, 
	                                    IdPartner, 
	                                    zonas.Descripcion AS Zona,
	                                    Nombre, 
	                                    CIF, 
	                                    Direccion, 
	                                    Telefono, 
	                                    Correo, 
	                                    FechaRegistro
                                    FROM PARTNERS p
                                    INNER JOIN ZONAS ON (zonas.IdZona = p.IdZona)"
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
            SELECT ROW_NUMBER() OVER (ORDER BY IdPartner) AS NumRegistro, p.IdPartner, zonas.Descripcion As Zona, p.Nombre, p.CIF, p.Direccion, p.Telefono, p.Correo, p.FechaRegistro
            FROM PARTNERS p
            INNER JOIN ZONAS ON (zonas.IdZona = p.IdZona)
            Where 1=1 {SentenciaWhere}
            )
            SELECT NumRegistro FROM CTE WHERE IdPartner = {IdRegistro}"

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
            comboZonaPartners.Enabled = True
            inputNombre.Enabled = True
            inputCif.Enabled = True
            inputDireccion.Enabled = True
            inputTelefono.Enabled = True
            inputCorreo.Enabled = True

        Else
            inputIdPartner.Enabled = False
            comboZonaPartners.Enabled = False
            inputNombre.Enabled = False
            inputCif.Enabled = False
            inputDireccion.Enabled = False
            inputTelefono.Enabled = False
            inputCorreo.Enabled = False

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

        ActualizarComboBoxZonas()
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
                comboZonaPartners.Text = If(dataRow("Zona") IsNot DBNull.Value, dataRow("Zona"), "")
                inputNombre.Text = If(dataRow("Nombre") IsNot DBNull.Value, dataRow("Nombre"), "")
                inputCif.Text = dataRow("CIF")
                inputDireccion.Text = If(dataRow("Direccion") IsNot DBNull.Value, dataRow("Direccion"), "")
                inputTelefono.Text = If(dataRow("Telefono") IsNot DBNull.Value, dataRow("Telefono"), "")
                inputCorreo.Text = If(dataRow("Correo") IsNot DBNull.Value, dataRow("Correo"), "")

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
            InsertarRegistro()
        ElseIf ModoFormulario = ModoVer Then
            Me.Close()
        End If
    End Sub

    Private Sub InsertarRegistro()

        Dim CamposSonValidos = ValidarCampos()

        If CamposSonValidos Then

            ' Obtener valores de los inputs
            Dim IdPartner As String = inputIdPartner.Text.Trim
            Dim zonaSeleccionada As Zona = DirectCast(comboZonaPartners.SelectedItem, Zona)
            Dim IdZona As Integer = zonaSeleccionada.Id
            Dim Nombre As String = inputNombre.Text.Trim
            Dim Cif As String = inputCif.Text.Trim
            Dim Direccion As String = inputDireccion.Text.Trim
            Dim Telefono As String = If(String.IsNullOrWhiteSpace(inputTelefono.Text), "NULL", $"'{inputTelefono.Text.Trim}'")
            Dim Correo As String = inputCorreo.Text.Trim

            ' Construccion de la Consulta
            Dim registrosActualizados As Integer

            Dim consulta As String = $"
            INSERT INTO PARTNERS (IdZona, Nombre, Cif, Direccion, Telefono, Correo, FechaRegistro) 
            VALUES ({IdZona}, '{Nombre}', '{Cif}', '{Direccion}', {Telefono}, '{Correo}', GETDATE())"


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

    Private Sub ActualizarPartner()
        ' Validacion de los inputs
        Dim CamposSonValidos = ValidarCampos()

        If CamposSonValidos Then
            ' Obtener valores de los inputs
            Dim IdPartner As String = inputIdPartner.Text.Trim

            ' Verificar si se ha seleccionado un nuevo valor en comboZonaPartners o no
            Dim zonaSeleccionada As Zona = DirectCast(comboZonaPartners.SelectedItem, Zona)
            Dim IdZona As Integer = zonaSeleccionada.Id


            ' Obtener otros valores de los inputs
            Dim Nombre As String = inputNombre.Text.Trim
            Dim Cif As String = inputCif.Text.Trim
            Dim Direccion As String = inputDireccion.Text.Trim
            Dim Telefono As String = If(String.IsNullOrWhiteSpace(inputTelefono.Text), "NULL", $"'{inputTelefono.Text.Trim}'")
            Dim Correo As String = inputCorreo.Text.Trim

            ' Construccion de la Consulta
            Dim registrosActualizados As Integer

            Dim consulta As String = $"
             UPDATE PARTNERS 
             SET IdZona = {IdZona},
             Nombre = '{Nombre}',
             CIF = '{Cif}',
             Direccion = '{Direccion}',
             Telefono = {Telefono},
             Correo = '{Correo}'
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
        ' Función para validar el formulario entero. La función retornará un booleano sobre si es válido o no.
        Dim IdZona As String = comboZonaPartners.Text.Trim
        Dim Nombre As String = inputNombre.Text.Trim
        Dim Cif As String = inputCif.Text.Trim
        Dim Direccion As String = inputDireccion.Text.Trim
        Dim Telefono As String = inputTelefono.Text.Trim
        Dim Correo As String = inputCorreo.Text.Trim

        ' Validación de los inputs

        ' Validación de IdZona 
        If String.IsNullOrEmpty(IdZona) Then
            MsgBox("¡Debe seleccionar una zona!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        ' Validación de Nombre
        If String.IsNullOrEmpty(Nombre) Then
            MsgBox("¡El campo Nombre no puede estar vacío!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        ElseIf IsNumeric(Nombre) Then
            MsgBox("¡El campo Nombre no puede ser un número!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        ' Validación de CIF
        If String.IsNullOrEmpty(Cif) Then
            MsgBox("¡El campo CIF no puede estar vacío!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(Cif, "^[ABCDEFGHJKLMNPQRSUVW][0-9]{7}[A-J0-9]$") Then
            MsgBox("¡El formato del CIF no es válido!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        ' Validación de Dirección - Asegurarse de que no esté vacía
        If String.IsNullOrEmpty(Direccion) Then
            MsgBox("¡El campo Dirección no puede estar vacío!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        ' Validación de Teléfono
        If Not String.IsNullOrEmpty(Telefono) AndAlso Not IsNumeric(Telefono) Then
            MsgBox("¡El campo Teléfono solo puede contener números!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        ElseIf Telefono.Length <> 9 Then
            MsgBox("¡El teléfono debe tener 9 dígitos!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        ' Validación de Correo Electrónico
        If Not String.IsNullOrEmpty(Correo) AndAlso Not System.Text.RegularExpressions.Regex.IsMatch(Correo, "^\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b$") Then
            MsgBox("¡El formato del correo electrónico no es válido!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        Return True
    End Function

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' BtnEliminar: boton de eliminar que está situado en el BindingNavigator

        Dim idPartner As Integer = inputIdPartner.Text.Trim
        Dim registrosActualizados As Integer

        Dim consulta As String = $"DELETE FROM PARTNERS WHERE IdPartner = {idPartner}"

        ' Verifica si hay un valor actual
        If BindingSource.Current IsNot Nothing Then
            ' Preguntar al usuario si quiere eliminar
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Si el usuario a seleccionado que si, borra el registro
            If result = DialogResult.Yes Then
                registrosActualizados = DeleteBBDD(ConnectionString, consulta)
                DataTable = ConsultaBBDD(ConnectionString, SentenciaSelect)

                ' Actualizar el fuente de datos (BindingSource) que tiene asignado el BindingNavigator 
                BindingSource.DataSource = DataTable

                ' Mover al elemento siguiente/anterior (Para actualizar los registros)
                If BindNavigatorPartner.MoveNextItem.Enabled Then
                    BindNavigatorPartner.MoveNextItem.PerformClick()
                Else
                    BindNavigatorPartner.MovePreviousItem.PerformClick()
                End If
                'BindNavigatorPartner.MoveFirstItem.PerformClick()
            End If
        End If

        If registrosActualizados = 1 Then
            MsgBox("Registro borrado con éxito: " + idPartner.ToString, vbInformation + vbOKOnly, "Registro borrado")
        Else
            MsgBox("Ha habido un error al borrar el registro.", vbExclamation + vbOKOnly, "Error de base de datos")
        End If

        ModoFormulario = ModoVer
        ActualizarModo()
    End Sub
    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        ' BindingNavigatorAddNewItem: boton añadir del BindingNavigator

        Dim formularioPartners As New FormularioPartners(ModoAñadir)

        formularioPartners.Show()
    End Sub
    Public Class Zona
        Public Property Id As Integer
        Public Property Nombre As String

        Public Overrides Function ToString() As String
            Return Nombre
        End Function
    End Class
    Sub ActualizarComboBoxZonas()
        comboZonaPartners.DataSource = Nothing
        comboZonaPartners.Items.Clear()

        Dim consulta As String = "SELECT IdZona, Descripcion FROM ZONAS"
        Dim zonasDataTable As DataTable = ConsultaBBDD(ConnectionString, consulta)

        Dim zonasList As New List(Of Zona)
        For Each fila As DataRow In zonasDataTable.Rows
            Dim zona = New Zona With {
                .Id = Convert.ToInt32(fila("IdZona")),
                .Nombre = fila("Descripcion").ToString()
            }
            zonasList.Add(zona)
        Next

        comboZonaPartners.DataSource = zonasList
        comboZonaPartners.DisplayMember = "Nombre"
        comboZonaPartners.ValueMember = "Id"
    End Sub

End Class