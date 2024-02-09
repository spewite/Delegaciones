Imports System.Text.RegularExpressions
Imports Dllgaciones.BaseDeDatos


Public Class FormularioZonas

    Dim ConnectionString As String = ConexionBD.CadenaConexion
    Dim DataTable As DataTable
    Dim BindingSource As New BindingSource

    Dim IndiceNavigator As Integer
    Dim SentenciaWhere As String
    Dim SentenciaSelect As String = "SELECT 
                                        ROW_NUMBER() OVER (ORDER BY IdZona) AS NumRegistro,  * 
                                        FROM ZONAS 
                                    WHERE 1=1 "

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
                ROW_NUMBER() OVER (ORDER BY IdZona) AS NumRegistro,  * 
                FROM ZONAS 
            WHERE 1=1  {SentenciaWhere}
        )

        SELECT NumRegistro FROM CTE WHERE IdZona = {IdRegistro}"

        Dim DataTableNumRegistro As DataTable = ConsultaBBDD(ConnectionString, Consulta)

        ' Verificar si ha retornado alguna linea
        If DataTableNumRegistro.Rows.Count > 0 Then
            ' Retrieve the NumRegistro value from the first row
            NumRegistro = Convert.ToInt32(DataTableNumRegistro.Rows(0)("NumRegistro"))
        End If

        Return NumRegistro
    End Function


    Private Sub FormularioZonas_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Si el el modo del formulario es Añadir no se van a cargar los valores de los inputs.
        If ModoFormulario <> ModoAñadir Then
            DataTable = ConsultaBBDD(ConnectionString, SentenciaSelect)

            'Rellenar biding navigator
            BindingSource.DataSource = DataTable
            BindingSource.Position = IndiceNavigator - 1
            BindNavigatorZonas.BindingSource = BindingSource

            BindNavigatorZonas.PositionItem.Text = IndiceNavigator

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

            BindNavigatorZonas.Visible = True
            BtnEliminar.Visible = True
        Else
            BtnEditar.Image = Delegacion.My.Resources.Resources.editar

            If ModoFormulario = ModoAñadir Then
                ' Si el modo del formulario es 'Añadir' oculta el binding navigator porque no tiene sentido que esté ahi
                BindNavigatorZonas.Visible = False
            End If

            BtnEliminar.Visible = False
        End If

    End Sub


    Private Sub ActivarDesactivarInputs()
        ' Si en el recibido ModoFormulario es true, activa los inputs, sino, los desactiva
        If ModoFormulario = ModoEditar Or ModoFormulario = ModoAñadir Then
            inputIdZona.Enabled = False ' El ID siempre esta desactivado.
            inputZona.Enabled = True

        Else

            inputIdZona.Enabled = False
            inputZona.Enabled = False
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

            Dim indiceNavigator = BindNavigatorZonas.PositionItem.Text

            ' Si el indice del navigator es 0, es que se esta inicializando. Entonces, se sale del metodo porque no nos interesa.
            If indiceNavigator < 1 Then
                Return
            End If

            Try
                Dim dataRow As DataRow = DataTable.Select("NumRegistro = " & indiceNavigator)(0)

                ' Rellenar los inputs
                inputIdZona.Text = dataRow("IdZona")
                inputZona.Text = If(dataRow("Descripcion") IsNot DBNull.Value, dataRow("Descripcion"), "")

            Catch ex As Exception
                MsgBox("Ha habido un error: " + ex.Message, vbCritical + vbOKOnly, "Error en al leer los datos del a base de datos")
            End Try
        End If
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
            Dim IdZona As String = inputIdZona.Text.Trim
            Dim Descripcion As String = inputZona.Text.Trim


            ' Construccion de la Consulta
            Dim registrosInsertados As Integer

            Dim consulta As String =
                $"INSERT INTO ZONAS (Descripcion)
                VALUES ('{Descripcion}')"

            registrosInsertados = UpdateBBDD(ConnectionString, consulta)

            If registrosInsertados = 1 Then
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
            Dim IdZona As String = inputIdZona.Text.Trim
            Dim Descripcion As String = inputZona.Text.Trim


            ' Construccion de la Consulta
            Dim registrosActualizados As Integer

            Dim consulta As String = $"
            UPDATE ZONAS 
            SET 
            Descripcion = '{Descripcion}'
            WHERE IdZona = {IdZona}"

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

        Dim IdZona As String = inputIdZona.Text.Trim
        Dim Descripcion As String = inputZona.Text.Trim

        ' Validación de campo no vacío para IdZona
        If String.IsNullOrEmpty(IdZona) Then
            MsgBox("¡El campo ID de Zona no puede estar vacío!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        ' Validación de campo no vacío para Descripcion
        If String.IsNullOrEmpty(Descripcion) Then
            MsgBox("¡El campo Descripción no puede estar vacío!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        ' Validaciones adicionales para Descripcion si es necesario, por ejemplo, longitud mínima o máxima
        If Descripcion.Length < 3 Then ' Ejemplo de validación de longitud mínima
            MsgBox("¡La descripción debe tener al menos 3 caracteres!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        Return True
    End Function


    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        ' BindingNavigatorAddNewItem: boton añadir del BindingNavigator
        Dim formularioZonas As New FormularioZonas(ModoAñadir)
        formularioZonas.Show()
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

        Dim IdZona As Integer = inputIdZona.Text.Trim

        ' Verifica si hay un valor actual
        If BindingSource.Current IsNot Nothing Then
            ' Preguntar al usuario si quiere eliminar
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar esta Zona? Si tiene Clientes o Comerciales asignados se va a eliminar la relación!", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Si el usuario a seleccionado que sí, borra el registro
            If result = DialogResult.Yes Then

                Dim SentenciaUpdateComerciales = $"UPDATE COMERCIALES
                                        SET IdZona = NULL 
                                        WHERE IdZona = {IdZona}"

                Dim SentenciaUpdatePartners = $"UPDATE PARTNERS
                                        SET IdZona = NULL 
                                        WHERE IdZona = {IdZona}"


                Dim comercialesActualizados As Integer = UpdateBBDD(ConnectionString, SentenciaUpdateComerciales)

                MsgBox($"Se han desvinculado {comercialesActualizados} comerciales.", vbInformation + vbOKOnly, "Comerciales desvinculados.")


                Dim partnersActualizados As Integer = UpdateBBDD(ConnectionString, SentenciaUpdatePartners)

                MsgBox($"Se han desvinculado {partnersActualizados} partners.", vbInformation + vbOKOnly, "Partners desvinculados.")



                Dim SentenciaDelete As String = $"DELETE FROM ZONAS WHERE IdZona = {IdZona}"

                Dim registrosEliminados As Integer = DeleteBBDD(ConnectionString, SentenciaDelete)

                If registrosEliminados > 0 Then
                    MsgBox($"La Zona con ID {IdZona} ha sido eliminado con éxito.", vbInformation + vbOKOnly, "Registro eliminado con éxito.")
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
                If BindNavigatorZonas.MoveNextItem.Enabled Then
                    BindNavigatorZonas.MoveNextItem.PerformClick()
                Else
                    BindNavigatorZonas.MovePreviousItem.PerformClick()
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