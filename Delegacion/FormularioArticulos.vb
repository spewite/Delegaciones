Imports System.IO
Imports Dllgaciones.BaseDeDatos

Public Class FormularioArticulos

    Dim ConnectionString As String = ConexionBD.CadenaConexion
    Dim DataTable As DataTable
    Dim BindingSource As New BindingSource

    Dim IndiceNavigator As Integer
    Dim SentenciaWhere As String
    Dim SentenciaSelect As String = "SELECT ROW_NUMBER() OVER (ORDER BY IdArticulo) AS NumRegistro, * 
                                        FROM ARTICULOS 
                                        WHERE 1=1"

    Dim ModoFormulario As Integer

    Dim base64FormularioAñadir As String = ""

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
            SELECT ROW_NUMBER() OVER (ORDER BY IdArticulo) AS NumRegistro, *
            FROM ARTICULOS 
            WHERE 1=1 {SentenciaWhere}
        )

        SELECT NumRegistro FROM CTE WHERE IdArticulo = {IdRegistro}"

        Dim DataTableNumRegistro As DataTable = ConsultaBBDD(ConnectionString, Consulta)

        ' Verificar si ha retornado alguna linea
        If DataTableNumRegistro.Rows.Count > 0 Then
            ' Retrieve the NumRegistro value from the first row
            NumRegistro = Convert.ToInt32(DataTableNumRegistro.Rows(0)("NumRegistro"))
        End If
        TextBox1.Text = (Consulta)

        Return NumRegistro
    End Function


    Private Sub ArticulosEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        ActualizarBotonerImagen()
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

    Private Sub ActualizarBotonerImagen()

        If ModoFormulario = ModoEditar Then
            btnEditarFoto.Visible = True
            btnEliminarFoto.Visible = True
        ElseIf ModoFormulario = ModoVer Then
            btnEditarFoto.Visible = False
            btnEliminarFoto.Visible = False
        ElseIf ModoFormulario = ModoAñadir Then
            btnEditarFoto.Visible = True
            btnEliminarFoto.Visible = False
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

                ' Poner la imagen
                Dim stringBase64 As String = If(dataRow("ImagenBase64") IsNot DBNull.Value, dataRow("ImagenBase64"), "")
                PonerImagen(stringBase64)

            Catch ex As Exception
                MsgBox("Ha habido un error: " + ex.Message, vbCritical + vbOKOnly, "Error en al leer los datos del a base de datos")
            End Try

        End If
    End Sub

    Private Sub PonerImagen(imagenBase64 As String)

        If imagenBase64 = "" Then
            Dim rutaSinImagen As String = "articulos/sin-imagen.jpg"
            pictureboxArticulos.ImageLocation = rutaSinImagen
        Else
            Try
                ' Convertir la cadena base64 a un array de bytes
                Dim bytesImagen As Byte() = Convert.FromBase64String(imagenBase64)

                ' Crear un MemoryStream a partir del array de bytes
                Using ms As New MemoryStream(bytesImagen)
                    ' Crear una imagen desde el MemoryStream
                    Dim imagen As Drawing.Image = Drawing.Image.FromStream(ms)

                    ' Asignar la imagen al PictureBox
                    pictureboxArticulos.Image = imagen
                End Using
            Catch ex As Exception
                ' Manejar las excepciones relacionadas con la decodificación de base64
                MessageBox.Show("Error al decodificar la imagen base64: " & ex.Message, "Error de decodificación", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' Si ha habido un error al asignar la imagen, se va a poner la imagen por defecto.
                Dim rutaSinImagen As String = "articulos/sin-imagen.jpg"
                pictureboxArticulos.ImageLocation = rutaSinImagen
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
            ActualizarArticulo()
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
            ActualizarArticulo()
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
            INSERT INTO ARTICULOS(Nombre, Descripcion, Categoria, Proveedor, PrVent, PrCost, Existencias, SobreMaximo, BajoMinimo, ImagenBase64)
            VALUES ('{Nombre}', '{Descripcion}', '{Categoria}', '{Proveedor}', {PrecioVenta}, {PrecioCoste}, '{Existencias}', '{SobreMaximo}', '{BajoMinimo}', '{base64FormularioAñadir}')"

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
        ' Funciona para validar el formulario entero. La funciona retorara un boolean sobre si es valido o no.  

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
        ' OpenFileDialog: Ventana de Windows para elegir un archivo. Esta linea solo es para crear el objeto, se muestra despues.
        Dim openFileDialog As New OpenFileDialog()

        ' Establecer el título y el     o para la ventana de elegir un archivo
        openFileDialog.Title = "Selecciona una imagen"
        openFileDialog.Filter = "Archivos de imagen|*.jpg;*.png;"

        ' Mostrar el OpenFileDialog y verificar si el usuario hizo clic en OK
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Obtener la ruta del archivo seleccionado
            Dim rutaImagenSeleccionada As String = openFileDialog.FileName

            Try
                ' Leer la imagen como un array de bytes
                Dim bytesImagen As Byte() = File.ReadAllBytes(rutaImagenSeleccionada)

                ' Convertir el array de bytes a una cadena base64
                Dim imagenBase64 As String = Convert.ToBase64String(bytesImagen)

                ' Si estamos en modo editar, vamos a hacer el update en la base de datos
                If ModoFormulario = ModoEditar Then

                    Dim consulta As String = $"
                    UPDATE ARTICULOS 
                    SET ImagenBase64 = '{imagenBase64}'
                    WHERE IdArticulo = '{inputIdArticulo.Text}'"

                    Dim registrosActualizados As Integer = UpdateBBDD(ConnectionString, consulta)

                    If registrosActualizados > 0 Then
                        MsgBox("La imagen ha sido actualizada con éxito.", vbInformation + vbOKOnly, "Imagen actualizado en la base de datos")
                    Else
                        MsgBox("Ha habido un error al actualizar la imagen en la base de datos.", vbAbort + vbOKOnly, "Error en la base de datos")
                    End If

                ElseIf ModoFormulario = ModoAñadir Then
                    ' Si estamos en modo añadir, vamos a guardar en una variable la cadena base64 (luego al añadir el registro en BBDD se insertara).
                    base64FormularioAñadir = imagenBase64
                    PonerImagen(base64FormularioAñadir)
                End If

            Catch ex As Exception
                MessageBox.Show("Error al leer la imagen: " & ex.Message, "Error de lectura de archivo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        ActualizarDatos()
    End Sub


    Private Sub BtnEliminarFoto_Click(sender As Object, e As EventArgs) Handles btnEliminarFoto.Click
        ' Hacer un update en el registro actual para cambiar el campo imagen a una cadena vacia

        Dim sentenciaBorrarImagen = $"UPDATE ARTICULOS
                                     SET ImagenBase64 = ''
                                     WHERE IdArticulo = '{inputIdArticulo.Text}'"

        Dim columnasCambiadas As Integer = UpdateBBDD(ConnectionString, sentenciaBorrarImagen)

        If columnasCambiadas > 0 Then
            MsgBox("La imagen ha sido eliminada corréctamente.", vbInformation + vbOKOnly, "Imagen eliminada.")
        Else
            MsgBox("Ha habido un error al eliminar la imagen.", vbAbort + vbOKOnly, "No se ha podido eliminar la imagen.")
        End If

        ActualizarDatos()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ' BtnEliminar: boton de eliminar que está situado en el BindingNavigator

        Dim idArticulo As Integer = inputIdArticulo.Text.Trim
        Dim registrosActualizados As Integer

        Dim consulta As String = $"DELETE FROM ARTICULOS WHERE IdArticulo = {idArticulo}"

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
                If BindNavigatorArticulo.MoveNextItem.Enabled Then
                    BindNavigatorArticulo.MoveNextItem.PerformClick()
                Else
                    BindNavigatorArticulo.MovePreviousItem.PerformClick()
                End If
                'BindNavigatorArticulo.MoveFirstItem.PerformClick()
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
        ' BindingNavigatorAddNewItem: boton añadir del BindingNavigator
        Dim formularioArticulos As New FormularioArticulos(ModoAñadir)
        formularioArticulos.Show()
    End Sub
End Class