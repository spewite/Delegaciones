Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows
Imports Dllgaciones.BaseDeDatos

Public Class ArticulosEdit

    Dim connectionString As String = ConexionBD.CadenaConexion
    Dim dataTable As DataTable
    Dim bs As New BindingSource

    Dim IndiceNavigator As Integer
    Dim SentenciaArticulos As String = "SELECT ROW_NUMBER() OVER (ORDER BY IdArticulo) AS NumRegistro, * FROM ARTICULOS"

    Dim ModoFormulario As Integer

    Public Const ModoEditar As Integer = 1
    Public Const ModoVer As Integer = 2
    Public Const ModoAñadir As Integer = 3

    Public Sub New(IdRegistro As Integer, ModoFormulario As Integer)
        InitializeComponent()
        ' Guardar las variables recibidas en variables locales 
        Me.ModoFormulario = ModoFormulario
        Me.IndiceNavigator = ObtenerNumRegistro(IdRegistro)
    End Sub

    Function ObtenerNumRegistro(idRegistro As Integer) As Integer
        Dim numRegistro As Integer = 0
        Dim consulta As String =
        $"WITH CTE AS (
            SELECT ROW_NUMBER() OVER (ORDER BY IdArticulo) AS NumRegistro, *
            FROM ARTICULOS
        )

        SELECT NumRegistro FROM CTE WHERE IdArticulo = {idRegistro}"

        ' Assuming ConsultaBBDD is a method that executes the SQL query and returns a DataTable

        Dim dataTableNumRegistro As DataTable = ConsultaBBDD(connectionString, consulta)

        ' Verificar si ha retornado alguna linea
        If dataTableNumRegistro.Rows.Count > 0 Then
            ' Retrieve the NumRegistro value from the first row
            numRegistro = Convert.ToInt32(dataTableNumRegistro.Rows(0)("NumRegistro"))
        End If

        Return numRegistro
    End Function


    Private Sub ArticulosEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        dataTable = ConsultaBBDD(connectionString, SentenciaArticulos)

        'Rellenar biding navigator
        bs.DataSource = dataTable
        bs.Position = IndiceNavigator
        bindingNavigatorArticulos.BindingSource = bs

        bindingNavigatorArticulos.PositionItem.Text = IndiceNavigator

        'Rellenar los datos 
        ActualizarDatos()

        ' Detecta el valor de la variable ModoFormulario y ajusta la ventana acorde al modo
        ActualizarModoEdicion()
    End Sub

    Private Sub ActualizarModoEdicion()
        ActualizarBotonEdicionNavigator()
        ActivarDesactivarInputs()
        ActualizarBotonAbajo()
    End Sub

    Private Sub ActualizarBotonEdicionNavigator()
        If ModoFormulario = ModoEditar Then
            btnEditar.Image = Delegacion.My.Resources.Resources.confirmar_editar
        Else
            btnEditar.Image = Delegacion.My.Resources.Resources.editar
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

            Dim indiceNavigator = bindingNavigatorArticulos.PositionItem.Text

            ' Si el indice del navigator es 0, es que se esta inicializando. Entonces, se sale del metodo porque no nos interesa.
            If indiceNavigator = 0 Then
                Return
            End If

            Try
                Dim dataRow As DataRow = dataTable.Select("NumRegistro = " & indiceNavigator)(0)

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

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If ModoFormulario Then
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
        ActualizarModoEdicion()
    End Sub

    Private Sub btnAbajo_Click(sender As Object, e As EventArgs) Handles btnAbajo.Click
        If ModoFormulario = ModoEditar Then
            ActualizarArticulo()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub ActualizarArticulo()

        Dim basura As Integer
        ' Obtener valores de los inputs
        Dim idArticulo As String = inputIdArticulo.Text.Trim
        Dim nombre As String = inputNombreArticulos.Text.Trim
        Dim categoria As String = inputCategoriaArticulos.Text.Trim
        Dim proveedor As String = inputProveedorArticulos.Text.Trim
        Dim existencias As Integer = inputExistenciasArticulos.Text.Trim
        Dim precioCoste As String = inputPrCostArticulos.Text.Trim.Replace(".", "").Replace(",", ".")
        Dim precioVenta As String = inputPrVentArticulos.Text.Trim.Replace(".", "").Replace(",", ".")
        Dim bajoMinimo As Integer = inputBajoMinimoArticulos.Text.Trim
        Dim sobreMaximo As Integer = inputSobreMaximoArticulos.Text.Trim
        Dim descripcion As String = inputDescripcionArticulos.Text.Trim
        'Dim rutaImagen As String = pictureboxArticulos.ImageLocation


        ' Validacion de los inputs
        If Not Integer.TryParse(existencias, basura) Then
            MsgBox("¡Debes introducir un valor entero en el campo de existencias!", vbExclamation + vbOKOnly, "Error de validación")
            Return
        End If

        If Not Double.TryParse(precioCoste, basura) Then
            MsgBox("¡Debes introducir un valor numérico en el campo de precio coste!", vbExclamation + vbOKOnly, "Error de validación")
            Return
        End If

        If Not Double.TryParse(precioVenta, basura) Then
            MsgBox("¡Debes introducir un valor numérico en el campo de precio venta!", vbExclamation + vbOKOnly, "Error de validación")
            Return
        End If

        If Not Integer.TryParse(bajoMinimo, basura) Then
            MsgBox("¡Debes introducir un valor entero en el campo de bajo mínimo!", vbExclamation + vbOKOnly, "Error de validación")
            Return
        End If

        If Not Integer.TryParse(sobreMaximo, basura) Then
            MsgBox("¡Debes introducir un valor entero en el campo de sobre máximo!", vbExclamation + vbOKOnly, "Error de validación")
            Return
        End If

        ' Construccion de la consulta
        Dim registrosActualizados As Integer

        Dim consulta As String = $"
        UPDATE ARTICULOS 
        SET nombre = '{nombre}',
        categoria = '{categoria}',
        proveedor = '{proveedor}',
        existencias = {existencias},
        prvent = {precioVenta},
        prcost = {precioCoste},
        bajoMinimo = {bajoMinimo},
        sobreMaximo = {sobreMaximo},
        descripcion = '{descripcion}'
        WHERE IdArticulo = {idArticulo}"

        TextBox1.Text = consulta

        registrosActualizados = UpdateBBDD(connectionString, consulta)

        If registrosActualizados = 1 Then
            MsgBox("Registro actualizado con éxito.", vbInformation + vbOKOnly, "Registro actualizado")
        Else
            MsgBox("Ha habido un error al actualizar el registro.", vbExclamation + vbOKOnly, "Error de base de datos")
        End If

        InterruptorModoEdicion()

    End Sub

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

            ' Crear un nombre de archivo único utilizando la fecha y hora actual
            Dim nombreArchivoDestino As String = "articulo" & inputIdArticulo.Text & Path.GetExtension(rutaImagenSeleccionada)

            ' Combinar la ruta de destino con el nuevo nombre del archivo
            Dim rutaArchivoDestino As String = Path.Combine(rutaDestino, nombreArchivoDestino)

            Try
                ' Copiar la imagen seleccionada a la ruta deseada con el nuevo nombre
                File.Copy(rutaImagenSeleccionada, rutaArchivoDestino, True)
            Catch ex As Exception
                ' Manejar otras excepciones aquí
                MessageBox.Show("Error al copiar la imagen: " & ex.Message, "Error de copia de archivo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        ActualizarDatos()
    End Sub

    Private Sub BtnEliminarFoto_Click(sender As Object, e As EventArgs) Handles btnEliminarFoto.Click

        ' Especificar la carpeta y el nombre del archivo que deseas eliminar
        Dim rutaCarpeta As String = "articulos\"
        Dim nombreArchivo As String = "articulo" & inputIdArticulo.Text & ".jpg"

        ' Combinar la ruta de la carpeta con el nombre del archivo
        Dim rutaCompleta As String = Path.Combine(rutaCarpeta, nombreArchivo)

        ' Verificar si el archivo existe antes de intentar eliminarlo
        If File.Exists(rutaCompleta) Then
            Dim respuestaUsuario As DialogResult = MessageBox.Show("¿Seguro que deseas eliminar la foto del artículo?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respuestaUsuario = DialogResult.Yes Then
                Try
                    ' Eliminar el archivo
                    File.Delete(rutaCompleta)
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim idArticulo As Integer = inputIdArticulo.Text.Trim
        Dim registrosActualizados As Integer

        Dim consulta As String = $"DELETE FROM ARTICULOS WHERE IdArticulo = {idArticulo}"

        'Dim respuestaUsuario As DialogResult = MessageBox.Show("¿Seguro que deseas eliminar este artículo?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check if there is a current item
        If bs.Current IsNot Nothing Then
            ' Ask the user for confirmation
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' If the user clicks Yes, remove the current item
            If result = DialogResult.Yes Then

                registrosActualizados = DeleteBBDD(connectionString, consulta)
                dataTable = ConsultaBBDD(connectionString, SentenciaArticulos)

            End If
        End If


        If registrosActualizados = 1 Then
            MsgBox("Registro borrado con éxito: " + idArticulo.ToString, vbInformation + vbOKOnly, "Registro borrado")
        Else
            MsgBox("Ha habido un error al borrar el registro.", vbExclamation + vbOKOnly, "Error de base de datos")
        End If

        bindingNavigatorArticulos.MoveFirstItem.PerformClick()
    End Sub

End Class