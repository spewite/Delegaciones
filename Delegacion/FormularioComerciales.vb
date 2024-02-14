Imports System.IO
Imports System.Text.RegularExpressions
Imports Dllgaciones.BaseDeDatos

Public Class FormularioComerciales

    Dim ConnectionString As String = ConexionBD.CadenaConexion
    Dim DataTable As DataTable
    Dim BindingSource As New BindingSource

    Dim IndiceNavigator As Integer
    Dim SentenciaWhere As String
    Dim SentenciaSelect As String = "SELECT 
	                                    ROW_NUMBER() OVER (ORDER BY IdComercial) AS NumRegistro, 
	                                    IdComercial,
	                                    COMERCIALES.IdZona,
	                                    ZONAS.Descripcion As Zona,
	                                    Nombre,
	                                    Apellidos,
	                                    Telefono,
	                                    Correo,
	                                    Direccion,
	                                    DNI
                                    FROM COMERCIALES
                                    INNER JOIN ZONAS ON (COMERCIALES.IdZona = ZONAS.IdZona)"

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
	            ROW_NUMBER() OVER (ORDER BY IdComercial) AS NumRegistro, 
	            IdComercial,
	            COMERCIALES.IdZona,
	            ZONAS.Descripcion As Zona,
	            Nombre,
	            Apellidos,
	            Telefono,
	            Correo,
	            Direccion,
	            DNI
            FROM COMERCIALES
            INNER JOIN ZONAS ON (COMERCIALES.IdZona = ZONAS.IdZona)
            WHERE 1=1 {SentenciaWhere}
        )

        SELECT NumRegistro FROM CTE WHERE IdComercial = {IdRegistro}"

        Dim DataTableNumRegistro As DataTable = ConsultaBBDD(ConnectionString, Consulta)

        ' Verificar si ha retornado alguna linea
        If DataTableNumRegistro.Rows.Count > 0 Then
            ' Retrieve the NumRegistro value from the first row
            NumRegistro = Convert.ToInt32(DataTableNumRegistro.Rows(0)("NumRegistro"))
        End If

        Return NumRegistro
    End Function


    Private Sub FormularioComerciales_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Si el el modo del formulario es Añadir no se van a cargar los valores de los inputs.
        If ModoFormulario <> ModoAñadir Then
            DataTable = ConsultaBBDD(ConnectionString, SentenciaSelect)

            'Rellenar biding navigator
            BindingSource.DataSource = DataTable
            BindingSource.Position = IndiceNavigator - 1
            BindNavigatorComerciales.BindingSource = BindingSource

            BindNavigatorComerciales.PositionItem.Text = IndiceNavigator

        End If

        'Rellenar los datos. Si es modo ver solo añadira los foreign keys
        ActualizarDatos()

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

            BindNavigatorComerciales.Visible = True
            BtnEliminar.Visible = True
        Else
            BtnEditar.Image = Delegacion.My.Resources.Resources.editar

            If ModoFormulario = ModoAñadir Then
                ' Si el modo del formulario es 'Añadir' oculta el binding navigator porque no tiene sentido que esté ahi
                BindNavigatorComerciales.Visible = False
            End If

            BtnEliminar.Visible = False
        End If

    End Sub


    Private Sub ActivarDesactivarInputs()
        ' Si en el recibido ModoFormulario es true, activa los inputs, sino, los desactiva
        If ModoFormulario = ModoEditar Or ModoFormulario = ModoAñadir Then
            comboZona.Enabled = True
            inputNombre.Enabled = True
            inputApellidos.Enabled = True
            inputTelefono.Enabled = True
            inputDireccion.Enabled = True
            inputCorreo.Enabled = True
            inputDNI.Enabled = True
        Else
            comboZona.Enabled = False
            inputNombre.Enabled = False
            inputApellidos.Enabled = False
            inputTelefono.Enabled = False
            inputDireccion.Enabled = False
            inputCorreo.Enabled = False
            inputDNI.Enabled = False
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

            Dim indiceNavigator = BindNavigatorComerciales.PositionItem.Text

            ' Si el indice del navigator es 0, es que se esta inicializando. Entonces, se sale del metodo porque no nos interesa.
            If indiceNavigator < 1 Then
                Return
            End If

            Try
                Dim dataRow As DataRow = DataTable.Select("NumRegistro = " & indiceNavigator)(0)

                ' Insertar las claves extranjeras en el combobox
                CargarCombos()

                ' Rellenar los inputs
                inputIdComercial.Text = dataRow("IdComercial")
                inputNombre.Text = If(dataRow("Nombre") IsNot DBNull.Value, dataRow("Nombre"), "")
                inputApellidos.Text = If(dataRow("Apellidos") IsNot DBNull.Value, dataRow("Apellidos"), "")
                inputTelefono.Text = If(dataRow("Telefono") IsNot DBNull.Value, dataRow("Telefono"), "")
                inputDireccion.Text = If(dataRow("Direccion") IsNot DBNull.Value, dataRow("Direccion"), "")
                inputCorreo.Text = If(dataRow("Correo") IsNot DBNull.Value, dataRow("Correo"), "")
                inputDNI.Text = If(dataRow("DNI") IsNot DBNull.Value, dataRow("DNI"), "")
                comboZona.Text = If(dataRow("Zona") IsNot DBNull.Value, dataRow("Zona"), "")

            Catch ex As Exception
                MsgBox("Ha habido un error: " + ex.Message, vbCritical + vbOKOnly, "Error en al leer los datos del a base de datos")
            End Try

        ElseIf ModoFormulario = ModoAñadir Then
            ' Insertar las claves extranjeras en el combobox
            CargarCombos()
        End If
    End Sub

    Private Sub CargarCombos()


        ' Borra todos los registros de los combos, porque si el formulario esta en modo edicion luego se cargaran
        ' los valores posibles y se duplicarian los datos.
        comboZona.Items.Clear()

        ' Rellenar los combos con las foreign keys ⬇️

        Dim DataTablecomboZona As DataTable = ConsultaBBDD(ConnectionString, "SELECT Descripcion FROM ZONAS")
        For Each fila As DataRow In DataTablecomboZona.Rows
            Dim zona As String = fila("Descripcion").ToString()

            comboZona.Items.Add(zona)
        Next

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

    Private Sub InsertarRegistro()

        Dim CamposSonValidos = ValidarCampos()

        If CamposSonValidos Then

            ' Obtener valores de los inputs
            Dim IdComercial As String = inputIdComercial.Text.Trim
            Dim Zona As String = comboZona.Text.Trim
            Dim Nombre As String = inputNombre.Text.Trim
            Dim Apellidos As String = inputApellidos.Text.Trim
            Dim Telefono As Integer = inputTelefono.Text.Trim
            Dim Direccion As String = inputDireccion.Text.Trim
            Dim Correo As String = inputCorreo.Text.Trim
            Dim DNI As String = inputDNI.Text.Trim

            ' Construccion de la Consulta
            Dim registrosActualizados As Integer

            Dim consulta As String =
                $"INSERT INTO COMERCIALES (IdZona, Nombre, Apellidos, Telefono, Correo, Direccion, DNI)
                VALUES ((SELECT TOP 1 IdZona FROM ZONAS WHERE Descripcion = '{Zona}'), '{Nombre}', '{Apellidos}', '{Telefono}', '{Correo}', '{Direccion}', '{DNI}')"

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

        ' Validacion de los inputs
        Dim CamposSonValidos = ValidarCampos()

        If CamposSonValidos Then

            ' Obtener valores de los inputs
            Dim IdComercial As String = inputIdComercial.Text.Trim
            Dim Zona As String = comboZona.Text.Trim
            Dim Nombre As String = inputNombre.Text.Trim
            Dim Apellidos As String = inputApellidos.Text.Trim
            Dim Telefono As String = inputTelefono.Text.Trim
            Dim Direccion As String = inputDireccion.Text.Trim
            Dim Correo As String = inputCorreo.Text.Trim
            Dim DNI As String = inputDNI.Text.Trim

            ' Construccion de la Consulta
            Dim registrosActualizados As Integer

            Dim consulta As String = $"
            UPDATE COMERCIALES 
            SET IdZona = (SELECT TOP 1 IdZona FROM ZONAS WHERE Descripcion = '{Zona}'),
            Nombre = '{Nombre}',
            Apellidos = '{Apellidos}',
            Telefono = '{Telefono}',
            Direccion = '{Direccion}',
            Correo = '{Correo}',
            DNI = '{DNI}'
            WHERE IdComercial = {IdComercial}"

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
        ' Obtener valores de los inputs
        Dim IdComercial As String = inputIdComercial.Text.Trim
        Dim Zona As String = comboZona.Text.Trim
        Dim Nombre As String = inputNombre.Text.Trim
        Dim Apellidos As String = inputApellidos.Text.Trim
        Dim Telefono As String = inputTelefono.Text.Trim
        Dim Direccion As String = inputDireccion.Text.Trim
        Dim Correo As String = inputCorreo.Text.Trim
        Dim DNI As String = inputDNI.Text.Trim

        ' Validación de campos no vacíos
        If String.IsNullOrEmpty(Zona) OrElse String.IsNullOrEmpty(Nombre) OrElse String.IsNullOrEmpty(Apellidos) OrElse String.IsNullOrEmpty(Telefono) OrElse String.IsNullOrEmpty(Direccion) OrElse String.IsNullOrEmpty(Correo) OrElse String.IsNullOrEmpty(DNI) Then
            MsgBox("Todos los campos son obligatorios.", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        ' Validación de formato de correo electrónico
        If Not Regex.IsMatch(Correo, "^\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b$") Then
            MsgBox("El formato del correo electrónico no es válido.", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        ' Validación de número de teléfono
        If Not EsNumerico(Telefono) Or Telefono.Length <> 9 Then
            MsgBox("El teléfono debe ser numérico y debe contener 9 dígitos.", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        ' Validación de DNI
        If Not EsDNIValido(DNI) Then
            MsgBox("El DNI es incorrecto. Debe contener 8 dígitos y su correspondiente letra.", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        Return True
    End Function

    Public Function EsNumerico(text As String) As Boolean
        Dim number As Integer
        Return Integer.TryParse(text, number)
    End Function


    ' Función para validar un DNI español
    Private Function EsDNIValido(dni As String) As Boolean
        ' Verificar que el DNI tiene 9 caracteres (8 dígitos + 1 letra)
        If dni.Length <> 9 Then
            Return False
        End If

        ' Extraer los primeros 8 dígitos
        Dim digitos As String = dni.Substring(0, 8)

        ' Extraer la letra
        Dim letra As Char = dni(8)

        ' Validar la letra utilizando el algoritmo específico
        If Char.IsLetter(letra) AndAlso letra.ToString.ToUpper() = CalcularLetraDNI(digitos) Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Función para calcular la letra del DNI
    Private Function CalcularLetraDNI(digitos As String) As Char
        ' Array de letras posibles para un DNI
        Dim letras As String = "TRWAGMYFPDXBNJZSQVHLCKE"

        ' Calcular el índice correspondiente al módulo de 23 de los primeros 8 dígitos
        Dim indice As Integer = Convert.ToInt32(digitos) Mod 23

        ' Devolver la letra correspondiente al índice calculado
        Return letras.Chars(indice)
    End Function

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        ' BindingNavigatorAddNewItem: boton añadir del BindingNavigator
        Dim formularioComerciales As New FormularioComerciales(ModoAñadir)
        formularioComerciales.Show()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        ' btnEdtiar: Boton de edicion del BindingNavitor
        If ModoFormulario = ModoEditar Then
            ActualizarRegistro()
        Else
            InterruptorModoEdicion()
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        ' BtnEliminar: boton de eliminar que está situado en el BindingNavigator

        Dim IdComercial As Integer = inputIdComercial.Text.Trim

        ' Verifica si hay un valor actual
        If BindingSource.Current IsNot Nothing Then
            ' Preguntar al usuario si quiere eliminar
            Dim result As DialogResult = MessageBox.Show($"¿Está seguro de que desea eliminar este comercial? (ID: {IdComercial}) ", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Si el usuario a seleccionado que sí, borra el registro
            If result = DialogResult.Yes Then

                Dim ConsultaCantidadPedidosAsociados As String = $"SELECT COUNT(*) cantidad FROM CAB_PEDIDOS WHERE IdComercial = {IdComercial}"

                Dim CantidadPedidos As Integer = ConsultaBBDD(ConnectionString, ConsultaCantidadPedidosAsociados).Rows(0)("cantidad")

                If CantidadPedidos <> 0 Then
                    MsgBox($"¡El comercial '(ID: {IdComercial})' tiene pedidos asignados! No puedes eliminar comerciales que tienen pedidos asignados.", vbExclamation + vbOKOnly, "Error")
                    Return
                End If


                ' -- ⬇️ ELIMINAR ⬇️ -- 

                Dim SentenciaDelete As String = $"DELETE FROM COMERCIALES WHERE IdComercial = {IdComercial}"

                Dim registrosEliminados As Integer = DeleteBBDD(ConnectionString, SentenciaDelete)

                If registrosEliminados > 0 Then
                    MsgBox($"El comercial con el ID {IdComercial} ha sido eliminado con éxito.", vbInformation + vbOKOnly, "Registro eliminado con éxito.")
                Else
                    MsgBox("Ha habido un error al eliminar el registro", vbInformation + vbOKOnly, "Error.")
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
                If BindNavigatorComerciales.MoveNextItem.Enabled Then
                    BindNavigatorComerciales.MoveNextItem.PerformClick()
                Else
                    BindNavigatorComerciales.MovePreviousItem.PerformClick()
                End If

            End If
        End If

        ModoFormulario = ModoVer
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

End Class