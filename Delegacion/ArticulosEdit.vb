Imports System.Data.SqlClient
Imports System.Windows
Imports Dllgaciones.BaseDeDatos

Public Class ArticulosEdit

    Dim connectionString As String = ConexionBD.CadenaConexion
    Dim dataTable As DataTable
    Dim bs As New BindingSource

    Dim modoEditar As Boolean
    Dim indiceNavigator As Integer
    Dim sentenciaArticulos As String

    Public Sub New(indiceNavigator As Integer, sentenciaArticulos As String, modoEditar As Boolean)
        InitializeComponent()
        ' Guardar las variables recibidas en variables locales 
        Me.sentenciaArticulos = sentenciaArticulos
        Me.modoEditar = modoEditar
        Me.indiceNavigator = indiceNavigator
    End Sub

    Private Sub ArticulosEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        dataTable = ConsultaBBDD(connectionString, sentenciaArticulos)

        'Rellenar biding navigator
        bs.DataSource = dataTable
        bs.Position = indiceNavigator
        bindingNavigatorArticulos.BindingSource = bs

        'Rellenar los datos 
        ActualizarDatosNavigator()

        ' Detecta el valor de la variable modoEditar y ajusta la ventana acorde al modo
        ActualizarModoEdicion()
    End Sub

    Private Sub ActualizarModoEdicion()
        ActualizarBotonEdicionNavigator()
        ActivarDesactivarInputs()
        ActualizarBotonAbajo()
    End Sub

    Private Sub ActualizarBotonEdicionNavigator()
        If modoEditar Then
            btnEditar.Image = Delegacion.My.Resources.Resources.confirmar_editar
        Else
            btnEditar.Image = Delegacion.My.Resources.Resources.editar
        End If
    End Sub

    Private Sub ActivarDesactivarInputs()
        ' Si en el recibido modoEditar es true, activa los inputs, sino, los desactiva
        If modoEditar Then
            inputNombreArticulos.Enabled = True
            comboCategoriaArticulos.Enabled = True
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
            comboCategoriaArticulos.Enabled = False
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
        If modoEditar Then
            btnAbajo.Text = "Actualizar"
        Else
            btnAbajo.Text = "Listo"
        End If

    End Sub

    Private Sub ActualizarDatosNavigator()
        Dim indiceNavigator = bindingNavigatorArticulos.PositionItem.Text

        ' Si el indice del navigator es 0, es que se esta inicializando. Entonces, se sale del metodo porque no nos interesa.
        If indiceNavigator = 0 Then
            Return
        End If

        Dim dataRow As DataRow = dataTable.Select("IdArticulo = " & indiceNavigator)(0)

        ' Rellenar los inputs
        inputIdArticulo.Text = dataRow("IdArticulo")
        inputNombreArticulos.Text = dataRow("Nombre")
        comboCategoriaArticulos.Text = dataRow("Categoria")
        inputProveedorArticulos.Text = dataRow("Proveedor")
        inputExistenciasArticulos.Text = dataRow("Cantidad")
        inputPrCostArticulos.Text = dataRow("PrCost")
        inputPrVentArticulos.Text = dataRow("PrVent")
        inputBajoMinimoArticulos.Text = dataRow("BajoMinimo")
        inputSobreMaximoArticulos.Text = dataRow("SobreMaximo")
        inputDescripcionArticulos.Text = dataRow("Descripcion")

        ' Poner imagen
        pictureboxArticulos.ImageLocation = dataRow("RutaImagen")
    End Sub


    Private Sub BindingNavigatorPositionItem_TextChanged(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.TextChanged
        ' Cuando el valor del indice del bindingnavigator cambie, se actualizaran los inputs 
        ActualizarDatosNavigator()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If modoEditar Then
            ActualizarArticulo()
        End If

        InterruptorModoEdicion()
    End Sub

    Private Sub InterruptorModoEdicion()
        modoEditar = Not modoEditar
        ActualizarModoEdicion()
    End Sub



    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        MsgBox("Eliminar registro")
    End Sub

    Private Sub btnAbajo_Click(sender As Object, e As EventArgs) Handles btnAbajo.Click
        If modoEditar Then
            ActualizarArticulo()
            InterruptorModoEdicion()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub ActualizarArticulo()
        MsgBox("Actualizar")
    End Sub


End Class