Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows
Imports Dllgaciones.BaseDeDatos

Public Class ArticulosEdit

    Dim ConnectionString As String = ConexionBD.CadenaConexion
    Dim DataTable As DataTable
    Dim BindingSource As New BindingSource

    Dim IndiceNavigator As Integer
    Dim SentenciaArticulos As String

    Dim ModoFormulario As Integer

    Public Const ModoEditar As Integer = 1
    Public Const ModoVer As Integer = 2
    Public Const ModoAñadir As Integer = 3

    Public Sub New(IdRegistro As Integer, SentenciaArticulos As String, ModoFormulario As Integer)
        InitializeComponent()
        ' Guardar las variables recibidas en variables locales 
        Me.ModoFormulario = ModoFormulario
        Me.SentenciaArticulos = SentenciaArticulos
        Me.IndiceNavigator = ObtenerNumRegistro(IdRegistro)
    End Sub

    Public Sub New(ModoFormulario As Integer)
        InitializeComponent()
        ' Guardar las variables recibidas en variables locales 
        If ModoFormulario <> ModoAñadir Then
            MsgBox("Se ha llamada al formulario del registro en modo editar/ver sin el ID del registro. Utilizar el otro constructor para ello",
            vbCritical + vbOKOnly, "Error interno, contacte con el administrador.")
        End If

        Me.ModoFormulario = ModoAñadir
    End Sub

    Function ObtenerNumRegistro(IdRegistro As Integer) As Integer
        Dim NumRegistro As Integer = 0
        Dim Consulta As String =
        $"WITH CTE AS (
            SELECT ROW_NUMBER() OVER (ORDER BY IdArticulo) AS NumRegistro, *
            FROM ARTICULOS
        )

        SELECT NumRegistro FROM CTE WHERE IdArticulo = {IdRegistro}"

        ' Assuming ConsultaBBDD is a method that executes the SQL query and returns a DataTable
        Dim DataTableNumRegistro As DataTable = ConsultaBBDD(ConnectionString, Consulta)

        ' Verificar si ha retornado alguna linea
        If DataTableNumRegistro.Rows.Count > 0 Then
            ' Retrieve the NumRegistro value from the first row
            NumRegistro = Convert.ToInt32(DataTableNumRegistro.Rows(0)("NumRegistro"))
        End If

        Return NumRegistro
    End Function


    Private Sub ArticulosEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        DataTable = ConsultaBBDD(ConnectionString, SentenciaArticulos)

        'Rellenar biding navigator
        BindingSource.DataSource = DataTable
        BindingSource.Position = IndiceNavigator - 1
        BindNavigator.BindingSource = BindingSource

        BindNavigator.PositionItem.Text = IndiceNavigator

        'Rellenar los datos 
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
            BtnEditar.Image = Delegacion.My.Resources.Resources.confirmar_editar

            BindNavigator.Visible = True
            BtnEliminar.Visible = True
        Else
            BtnEditar.Image = Delegacion.My.Resources.Resources.editar

            If ModoFormulario = ModoAñadir Then
                ' Si el modo del formulario es 'Añadir' oculta el binding navigator porque no tiene sentido que esté ahi
                BindNavigator.Visible = False
            End If

            BtnEliminar.Visible = False
        End If

    End Sub

    Private Sub ActivarDesactivarInputs()
        ' Si en el recibido ModoFormulario es true, activa los inputs, sino, los desactiva
        If ModoFormulario = ModoEditar Or ModoFormulario = ModoAñadir Then
            inputNombreArticulos.Enabled = True
            inputCategoriaArticulos.Enabled = True
            inputProveedorArticulos.Enabled = True
            inputExistenciasArticulos.Enabled = True
            inputPrCostArticulos.Enabled = True
            inputPrVentArticulos.Enabled = True
            inputBajoMinimoArticulos.Enabled = True
            inputSobreMaximoArticulos.Enabled = True
            inputDescripcionArticulos.Enabled = True
        Else
            inputIdArticulo.Enabled = False
            inputNombreArticulos.Enabled = False
            inputCategoriaArticulos.Enabled = False
            inputProveedorArticulos.Enabled = False
            inputExistenciasArticulos.Enabled = False
            inputPrCostArticulos.Enabled = False
            inputPrVentArticulos.Enabled = False
            inputBajoMinimoArticulos.Enabled = False
            inputSobreMaximoArticulos.Enabled = False
            inputDescripcionArticulos.Enabled = False
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

        If ModoFormulario = ModoEditar Or ModoFormulario = ModoVer Then

            Dim indiceNavigator = BindNavigator.PositionItem.Text

            ' Si el indice del navigator es 0, es que se esta inicializando. Entonces, se sale del metodo porque no nos interesa.
            If indiceNavigator < 1 Then
                Return
            End If

            Try
                Dim dataRow As DataRow = DataTable.Select("NumRegistro = " & indiceNavigator)(0)

                ' Rellenar los inputs
                inputIdArticulo.Text = dataRow("IdArticulo")
                inputNombreArticulos.Text = If(dataRow("Nombre") IsNot DBNull.Value, dataRow("Nombre"), "")
                inputCategoriaArticulos.Text = If(dataRow("Categoria") IsNot DBNull.Value, dataRow("Categoria"), "")
                inputProveedorArticulos.Text = If(dataRow("Proveedor") IsNot DBNull.Value, dataRow("Proveedor"), "")
                inputExistenciasArticulos.Text = If(dataRow("Existencias") IsNot DBNull.Value, dataRow("Existencias"), 0)
                inputPrCostArticulos.Text = If(dataRow("PrCost") IsNot DBNull.Value, dataRow("PrCost"), 0)
                inputPrVentArticulos.Text = If(dataRow("PrVent") IsNot DBNull.Value, dataRow("PrVent"), 0)
                inputBajoMinimoArticulos.Text = If(dataRow("BajoMinimo") IsNot DBNull.Value, dataRow("BajoMinimo"), 0)
                inputSobreMaximoArticulos.Text = If(dataRow("SobreMaximo") IsNot DBNull.Value, dataRow("SobreMaximo"), 0)
                inputDescripcionArticulos.Text = If(dataRow("Descripcion") IsNot DBNull.Value, dataRow("Descripcion"), "")

                ' Poner imagen
                'Dim rutaImagen As String = If(Not String.IsNullOrEmpty(dataRow("RutaImagen")), dataRow("RutaImagen"), "articulos/sin-imagen.jpg")
                Dim rutaImagen As String = "articulos/articulo" + inputIdArticulo.Text + ".jpg"
                rutaImagen = If(System.IO.File.Exists(rutaImagen), rutaImagen, "articulos/sin-imagen.jpg")
                pictureboxArticulos.ImageLocation = rutaImagen

            Catch ex As Exception
                MsgBox("Ha habido un error: " + ex.Message, vbCritical + vbOKOnly, "Error en al leer los datos del a base de datos")
            End Try

        End If
    End Sub

    Private Sub BindingNavigatorPositionItem_TextChanged(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.TextChanged
        ' Cuando el valor del indice del bindingnavigator cambie, se actualizaran los inputs 
        ActualizarDatos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If ModoFormulario = ModoEditar Then
            ActualizarArticulo()
        Else
            InterruptorModoEdicion()
        End If
    End Sub

    Private Sub InterruptorModoEdicion()
        If ModoFormulario = ModoEditar Then
            ModoFormulario = ModoVer
        Else
            ModoFormulario = ModoEditar
        End If
        ActualizarModo()
    End Sub

    Private Sub btnAbajo_Click(sender As Object, e As EventArgs) Handles btnAbajo.Click
        If ModoFormulario = ModoEditar Then
            ActualizarArticulo()
        ElseIf ModoFormulario = ModoAñadir Then
            InsertarArticulo()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub InsertarArticulo()

        Dim CamposSonValidos = ValidarCampos()

        If CamposSonValidos Then

            ' Obtener valores de los inputs
            Dim IdArticulo As String = inputIdArticulo.Text.Trim
            Dim Nombre As String = inputNombreArticulos.Text.Trim
            Dim Categoria As String = inputCategoriaArticulos.Text.Trim
            Dim Proveedor As String = inputProveedorArticulos.Text.Trim
            Dim Existencias As Integer = inputExistenciasArticulos.Text.Trim
            Dim PrecioCoste As String = inputPrCostArticulos.Text.Trim.Replace(".", "").Replace(",", ".")
            Dim PrecioVenta As String = inputPrVentArticulos.Text.Trim.Replace(".", "").Replace(",", ".")
            Dim BajoMinimo As Integer = inputBajoMinimoArticulos.Text.Trim
            Dim SobreMaximo As Integer = inputSobreMaximoArticulos.Text.Trim
            Dim Descripcion As String = inputDescripcionArticulos.Text.Trim
            ' Construccion de la Consulta
            Dim registrosActualizados As Integer

            Dim consulta As String = $"
            INSERT INTO ARTICULOS(Nombre, Descripcion, Categoria, Proveedor, PrVent, PrCost, Existencias, SobreMaximo, BajoMinimo)
            VALUES ('{Nombre}', '{Descripcion}', '{Categoria}', '{Proveedor}', {PrecioVenta}, {PrecioCoste}, '{Existencias}', '{SobreMaximo}', '{BajoMinimo}')"

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

    Private Sub ActualizarArticulo()

        ' Validacion de los inputs
        Dim CamposSonValidos = ValidarCampos()

        If CamposSonValidos Then

            ' Obtener valores de los inputs
            Dim IdArticulo As String = inputIdArticulo.Text.Trim
            Dim Nombre As String = inputNombreArticulos.Text.Trim
            Dim Categoria As String = inputCategoriaArticulos.Text.Trim
            Dim Proveedor As String = inputProveedorArticulos.Text.Trim
            Dim Existencias As Integer = inputExistenciasArticulos.Text.Trim
            Dim PrecioCoste As String = inputPrCostArticulos.Text.Trim.Replace(".", "").Replace(",", ".")
            Dim PrecioVenta As String = inputPrVentArticulos.Text.Trim.Replace(".", "").Replace(",", ".")
            Dim BajoMinimo As Integer = inputBajoMinimoArticulos.Text.Trim
            Dim SobreMaximo As Integer = inputSobreMaximoArticulos.Text.Trim
            Dim Descripcion As String = inputDescripcionArticulos.Text.Trim
            'Dim rutaImagen As String = pictureboxArticulos.ImageLocation

            ' Construccion de la Consulta
            Dim registrosActualizados As Integer

            Dim consulta As String = $"
            UPDATE ARTICULOS 
            SET nombre = '{Nombre}',
            categoria = '{Categoria}',
            proveedor = '{Proveedor}',
            existencias = {Existencias},
            prvent = {PrecioVenta},
            prcost = {PrecioCoste},
            bajoMinimo = {BajoMinimo},
            sobreMaximo = {SobreMaximo},
            descripcion = '{Descripcion}'
            WHERE IdArticulo = {IdArticulo}"

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
        Dim basura As Integer

        Dim IdArticulo As String = inputIdArticulo.Text.Trim
        Dim Nombre As String = inputNombreArticulos.Text.Trim
        Dim Categoria As String = inputCategoriaArticulos.Text.Trim
        Dim Proveedor As String = inputProveedorArticulos.Text.Trim
        Dim Existencias As String = inputExistenciasArticulos.Text.Trim
        Dim PrecioCoste As String = inputPrCostArticulos.Text.Trim.Replace(".", "").Replace(",", ".")
        Dim PrecioVenta As String = inputPrVentArticulos.Text.Trim.Replace(".", "").Replace(",", ".")
        Dim BajoMinimo As String = inputBajoMinimoArticulos.Text.Trim
        Dim SobreMaximo As String = inputSobreMaximoArticulos.Text.Trim
        Dim Descripcion As String = inputDescripcionArticulos.Text.Trim
        'Dim rutaImagen As String = pictureboxArticulos.ImageLocation


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



    Private Sub btnEditarFoto_Click(sender As Object, e As EventArgs) Handles btnEditarFoto.Click
        ' Crear una instancia de OpenFileDialog
        Dim openFileDialog As New OpenFileDialog()

        ' Establecer el título y el filtro para archivos de imagen
        openFileDialog.Title = "Selecciona una imagen"
        openFileDialog.Filter = "Archivos de imagen|*.jpg;"

        ' Mostrar el OpenFileDialog y verificar si el usuario hizo clic en OK
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Obtener la ruta del archivo seleccionado
            Dim rutaImagenSeleccionada As String = openFileDialog.FileName

            ' Establecer la ruta deseada para guardar la imagen (cambia esta ruta según sea necesario)
            Dim rutaDestino As String = "articulos\"

            ' Crear un Nombre de archivo único utilizando la fecha y hora actual
            Dim nombreArchivoDestino As String = "articulo" & inputIdArticulo.Text & Path.GetExtension(rutaImagenSeleccionada)

            ' Combinar la ruta de destino con el nuevo Nombre del archivo
            Dim rutaArchivoDestino As String = Path.Combine(rutaDestino, nombreArchivoDestino)

            Try
                ' Copiar la imagen seleccionada a la ruta deseada con el nuevo Nombre
                File.Copy(rutaImagenSeleccionada, rutaArchivoDestino, True)
            Catch ex As Exception
                ' Manejar otras excepciones aquí
                MessageBox.Show("Error al copiar la imagen: " & ex.Message, "Error de copia de archivo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        ActualizarDatos()
    End Sub

    Private Sub BtnEliminarFoto_Click(sender As Object, e As EventArgs) Handles btnEliminarFoto.Click

        ' Especificar la carpeta y el Nombre del archivo que deseas eliminar
        Dim RutaCarpeta As String = "articulos\"
        Dim NombreArchivo As String = "articulo" & inputIdArticulo.Text & ".jpg"

        ' Combinar la ruta de la carpeta con el Nombre del archivo
        Dim RutaCompleta As String = Path.Combine(RutaCarpeta, NombreArchivo)

        ' Verificar si el archivo existe antes de intentar eliminarlo
        If File.Exists(RutaCompleta) Then
            Dim RespuestaUsuario As DialogResult = MessageBox.Show("¿Seguro que deseas eliminar la foto del artículo?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If RespuestaUsuario = DialogResult.Yes Then
                Try
                    ' Eliminar el archivo
                    File.Delete(RutaCompleta)
                Catch ex As Exception
                    ' Manejar excepciones de eliminación aquí
                    MessageBox.Show("Error al eliminar el archivo: " + ex.Message, "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            ' Informar al usuario que el archivo no existe
            MessageBox.Show("No se ha encontrado foto para ese artículo", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ActualizarDatos()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim idArticulo As Integer = inputIdArticulo.Text.Trim
        Dim registrosActualizados As Integer

        Dim consulta As String = $"DELETE FROM ARTICULOS WHERE IdArticulo = {idArticulo}"

        ' Check if there is a current item
        If BindingSource.Current IsNot Nothing Then
            ' Ask the user for confirmation
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' If the user clicks Yes, remove the current item
            If result = DialogResult.Yes Then
                registrosActualizados = DeleteBBDD(ConnectionString, consulta)
                DataTable = ConsultaBBDD(ConnectionString, SentenciaArticulos)

                ' Actualizar el fuente de datos (BindingSource) que tiene asignado el BindingNavigator 
                BindingSource.DataSource = DataTable

            End If
        End If


        If registrosActualizados = 1 Then
            MsgBox("Registro borrado con éxito: " + idArticulo.ToString, vbInformation + vbOKOnly, "Registro borrado")
        Else
            MsgBox("Ha habido un error al borrar el registro.", vbExclamation + vbOKOnly, "Error de base de datos")
        End If

        ModoFormulario = ModoVer
        ActualizarModo()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        Dim formularioArticulos As New ArticulosEdit(ModoAñadir)
        formularioArticulos.Show()
    End Sub
End Class