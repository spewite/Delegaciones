Imports System.IO
Imports Dllgaciones.BaseDeDatos
Public Class FormularioLineas

    Dim ConnectionString As String = ConexionBD.CadenaConexion
    Dim DataTable As DataTable
    Dim BindingSource As New BindingSource

    Dim IndiceNavigator As Integer
    Dim SentenciaWhere As String
    Dim SentenciaSelect As String = "SELECT 
	                                    ROW_NUMBER() OVER (ORDER BY IdLinea) AS NumRegistro, 
	                                    IdLinea, 
	                                    IdPedido, 
	                                    art.Nombre As Articulo, 
	                                    Cantidad, 
	                                    Descuento, 
	                                    Precio 
                                    FROM LINEAS_PEDIDO 
                                    INNER JOIN ARTICULOS art ON (art.IdArticulo = LINEAS_PEDIDO.IdArticulo)
                                    WHERE 1=1
                                    "

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
	            ROW_NUMBER() OVER (ORDER BY IdLinea) AS NumRegistro, 
	            IdLinea, 
	            IdPedido, 
	            art.Nombre As Articulo, 
	            Cantidad, 
	            Descuento, 
	            Precio 
            FROM LINEAS_PEDIDO 
            INNER JOIN ARTICULOS art ON (art.IdArticulo = LINEAS_PEDIDO.IdArticulo)
            WHERE 1=1 {SentenciaWhere}
        )

        SELECT NumRegistro FROM CTE WHERE IdLinea = {IdRegistro}"

        Dim DataTableNumRegistro As DataTable = ConsultaBBDD(ConnectionString, Consulta)

        ' Verificar si ha retornado alguna linea
        If DataTableNumRegistro.Rows.Count > 0 Then
            NumRegistro = Convert.ToInt32(DataTableNumRegistro.Rows(0)("NumRegistro"))
        End If

        Return NumRegistro
    End Function


    Private Sub FormularioLineas_Load(sender As Object, e As EventArgs) Handles Me.Load
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
    End Sub

    Private Sub ActualizarModo()
        ActualizarBotoneraNavigator()
        ActivarDesactivarInputs()
        ActualizarBotonAbajo()
        ActualizarDatos()
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
            comboIdPedido.Enabled = True
            comboArticulo.Enabled = True
            inputCantidad.Enabled = True
            inputDescuento.Enabled = True

        Else
            inputIdLinea.Enabled = False
            comboIdPedido.Enabled = False
            comboArticulo.Enabled = False
            inputCantidad.Enabled = False
            inputDescuento.Enabled = False
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
            If indiceNavigator Is Nothing Or indiceNavigator = "" Or indiceNavigator.Contains("-") Then
                Return
            End If

            If indiceNavigator < 1 Then
                Return
            End If

            Try
                Dim dataRow As DataRow = DataTable.Select("NumRegistro = " & indiceNavigator)(0)

                ' Rellenar los inputs
                inputIdLinea.Text = dataRow("IdLinea")
                inputCantidad.Text = If(dataRow("Cantidad") IsNot DBNull.Value, dataRow("Cantidad"), "")
                inputPrecio.Text = If(dataRow("Precio") IsNot DBNull.Value, dataRow("Precio"), "")
                inputDescuento.Text = If(dataRow("Descuento") IsNot DBNull.Value, dataRow("Descuento"), "")

                ' Insertar las claves extranjeras en el combobox
                CargarCombos()

                ' Rellenar los combos con el valor actual de la cabecera.
                comboIdPedido.Text = If(dataRow("IdPedido") IsNot DBNull.Value, dataRow("IdPedido"), "")
                comboArticulo.Text = If(dataRow("Articulo") IsNot DBNull.Value, dataRow("Articulo"), "")

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
        comboIdPedido.Items.Clear()
        comboArticulo.Items.Clear()

        ' Rellenar los combos con las foreign keys ⬇️

        ' Combo IdPedido
        Dim DataTableComboIdPedidos As DataTable = ConsultaBBDD(ConnectionString, "SELECT IdPedido FROM CAB_PEDIDOS")
        For Each fila As DataRow In DataTableComboIdPedidos.Rows
            Dim idPedido As String = fila("IdPedido").ToString()

            comboIdPedido.Items.Add(idPedido)
        Next

        ' Combo Articulo
        Dim DataTableComboArticulo As DataTable = ConsultaBBDD(ConnectionString, "SELECT Nombre As Articulo FROM ARTICULOS")
        For Each fila As DataRow In DataTableComboArticulo.Rows
            Dim articulo As String = fila("Articulo").ToString()

            comboArticulo.Items.Add(articulo)
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
            InsertarArticulo()
        ElseIf ModoFormulario = ModoVer Then
            Me.Close()
        End If
    End Sub

    Private Sub InsertarArticulo()

        Dim CamposSonValidos = ValidarCampos()

        If CamposSonValidos Then

            ' Obtener valores de los inputs
            Dim IdLinea As String = inputIdLinea.Text.Trim
            Dim IdPedido As String = comboIdPedido.Text.Trim
            Dim Articulo As String = comboArticulo.Text.Trim
            Dim Cantidad As String = inputCantidad.Text.Trim
            Dim Precio As Integer = inputPrecio.Text.Trim
            Dim Descuento As Integer = If(inputDescuento.Text.Trim = "", 0, inputDescuento.Text.Trim)

            ' Construccion de la Consulta
            Dim registrosActualizados As Integer

            Dim consulta As String = $"INSERT INTO LINEAS_PEDIDO(IdPedido, IdArticulo, Cantidad, Descuento, Precio) 
                                      VALUES ('{IdPedido}', (SELECT IdArticulo FROM ARTICULOS WHERE Nombre = '{Articulo}'), '{Cantidad}', '{Descuento}', '{Precio}')"

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
            Dim IdLinea As String = inputIdLinea.Text.Trim
            Dim IdPedido As String = comboIdPedido.Text.Trim
            Dim Articulo As String = comboArticulo.Text.Trim
            Dim Cantidad As String = inputCantidad.Text.Trim
            Dim Descuento As Integer = inputDescuento.Text.Trim.Replace(".", "ñ").Replace(",", ".").Replace("ñ", "")
            Dim Precio As String = inputPrecio.Text.Trim.Replace(".", "ñ").Replace(",", ".").Replace("ñ", "")

            ' Construccion de la Consulta
            Dim registrosActualizados As Integer

            Dim consulta As String = $"
            UPDATE LINEAS_PEDIDO 
            SET IdPedido = '{IdPedido}',
            IdArticulo = (SELECT IdArticulo FROM ARTICULOS WHERE Nombre = '{Articulo}'),
            Precio = {Precio},
            Cantidad = {Cantidad},
            Descuento = {Descuento} 
            WHERE IdLinea = {IdLinea}"

            registrosActualizados = UpdateBBDD(ConnectionString, consulta)

            If registrosActualizados = 1 Then
                MsgBox("Registro actualizado con éxito.", vbInformation + vbOKOnly, "Registro actualizado")
            Else
                MsgBox("Ha habido un error al actualizar el registro.", vbExclamation + vbOKOnly, "Error de base de datos")
            End If

            InterruptorModoEdicion()

        End If

    End Sub

    Private Sub inputCantidad_LostFocus(sender As Object, e As EventArgs) Handles inputCantidad.LostFocus
        ActualizarPrecio()
    End Sub

    Private Sub comboArticulo_TextChanged(sender As Object, e As EventArgs) Handles comboArticulo.TextChanged
        ActualizarPrecio()
    End Sub

    Private Sub inputDescuento_LostFocus(sender As Object, e As EventArgs) Handles inputDescuento.LostFocus
        ActualizarPrecio()
    End Sub

    Private Sub ActualizarPrecio()

        Dim cantidad As Decimal

        If inputCantidad.Text <> "" Then

            ' Si el usuario mete un decimal lo convierte en entero

            If Decimal.TryParse(inputCantidad.Text, cantidad) Then
                ' Math.Truncate: Quita las decimales de un valor numerico.
                ' Math.Abs: Retorna el valor positivo de un valor numerico
                cantidad = Math.Abs(Math.Truncate(cantidad))
                If (cantidad = 0) Then
                    cantidad = 1
                End If
                inputCantidad.Text = cantidad
            Else
                MsgBox("Debes insertar un valor entero en el campo de Cantidad", vbExclamation + vbOKOnly, "Error de tipos de datos")
                inputCantidad.Text = 1
            End If

            ' Cuando se cambie el valor del campo Cantidad se pone automaticamente el precio correspondiente.
            If (comboArticulo.Text <> "") Then
                Dim DataTablePrecioArticulo As DataTable = ConsultaBBDD(ConnectionString, $"SELECT PrVent FROM ARTICULOS WHERE IdArticulo = (Select IdArticulo FROM ARTICULOS WHERE Nombre LIKE '%{comboArticulo.Text}%')")
                Dim precioUnitario As Double = DataTablePrecioArticulo.Rows(0)("PrVent")

                ' Calcular el descuento
                Dim descuento As Integer = 0

                If inputDescuento.Text <> "" Then

                    If Decimal.TryParse(inputDescuento.Text, descuento) Then

                        ' Quitar las decimales del descuento (siempre vamos a guardar los descuentos sin decimales)
                        descuento = Math.Truncate(descuento)
                        inputDescuento.Text = descuento

                        If descuento < 0 Or descuento > 100 Then
                            MsgBox("El descuento debe de estar entre 0 y 100", vbExclamation + vbOKOnly, "Error de tipos de datos")
                            descuento = 0
                            inputDescuento.Text = ""
                        End If
                    Else
                        MsgBox("Debes insertar un valor numerico en el campo de Descuento", vbExclamation + vbOKOnly, "Error de tipos de datos")
                        inputDescuento.Text = ""
                    End If
                End If

                ' Coger el descuento y pasar a un formato valido. Si el descuento es 5, lo tomamos como 0.96 para calcular el precio
                inputPrecio.Text = precioUnitario * cantidad * (1 - (descuento / 100))
            End If
        Else
            inputCantidad.Text = 1
            ActualizarPrecio()
        End If

    End Sub

    Function ValidarCampos() As Boolean
        ' Funciona para validar el formulario entero. La funciona retorara un boolean sobre si es valido o no.  

        If comboIdPedido.Text = "" Then
            MsgBox("Seleccione el ID del pedido.", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        If comboArticulo.Text = "" Then
            MsgBox("Seleccione un artículo.", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        If inputCantidad.Text = "" Then
            MsgBox("Rellene el campo Cantidad.", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        Dim basura As Integer

        ' Validacion de los inputs
        If Not Integer.TryParse(inputCantidad.Text, basura) Then
            MsgBox("¡Debes introducir un valor entero en el campo de existencias!", vbExclamation + vbOKOnly, "Error de validación")
            Return False
        End If

        Return True
    End Function

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' BtnEliminar: boton de eliminar que está situado en el BindingNavigator

        Dim IdLinea As Integer = inputIdLinea.Text.Trim
        Dim registrosActualizados As Integer

        Dim consulta As String = $"DELETE FROM LINEAS_PEDIDO WHERE IdLinea = {IdLinea}"

        ' Verifica si hay un valor actual
        If BindingSource.Current IsNot Nothing Then
            ' Preguntar al usuario si quiere eliminar
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Si el usuario a seleccionado que sí, borra el registro
            If result = DialogResult.Yes Then
                registrosActualizados = DeleteBBDD(ConnectionString, consulta)
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

        If registrosActualizados = 1 Then
            MsgBox("Registro borrado con éxito: " + IdLinea.ToString, vbInformation + vbOKOnly, "Registro borrado")
        Else
            MsgBox("Ha habido un error al borrar el registro.", vbExclamation + vbOKOnly, "Error de base de datos")
        End If

        ModoFormulario = ModoVer
        ActualizarModo()
    End Sub


    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        ' BindingNavigatorAddNewItem: boton añadir del BindingNavigator
        Dim formularioArticulos As New FormularioArticulos(ModoAñadir)
        formularioArticulos.Show()
    End Sub

End Class