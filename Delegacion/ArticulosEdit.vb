Imports System.Data.SqlClient
Imports System.Windows
Imports Dllgaciones.BaseDeDatos

Public Class ArticulosEdit

    Dim connectionString As String = ConexionBD.CadenaConexion
    Dim dataTable As DataTable
    Dim bs As New BindingSource

    Dim indiceNavigator As Integer
    Dim sentenciaArticulos As String

    ' Constructor que acepta la variable al abrir el formulario
    Public Sub New(indiceArticulo As String, sentenciaArticulos As String)
        InitializeComponent()
        ' Guardar la variable recibida en la variable local del formulario
        Me.indiceNavigator = indiceArticulo
        Me.sentenciaArticulos = sentenciaArticulos
    End Sub

    Private Sub ArticulosEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        dataTable = ConsultaBBDD(connectionString, sentenciaArticulos)

        'Rellenar biding navigator
        bs.DataSource = dataTable
        bindingNavigatorArticulos.BindingSource = bs

        MsgBox(indiceNavigator)
        MsgBox(sentenciaArticulos)


        'Rellenar los datos 
        'ActualizarDatosNavigator()
    End Sub

    Private Sub ActualizarDatosNavigator()

        bindingNavigatorArticulos.PositionItem.Text = indiceNavigator

        Dim dataRow As DataRow = dataTable.Select("IdArticulo = " & indiceNavigator)(0)

        '' Rellenar los inputs
        'inputIdArticulo.Text = dataRow("IdArticulo")
        'inputNombreArticulos.Text = dataRow("Nombre")
        'comboCategoriaArticulos.Text = dataRow("Categoria")
        'inputProveedorArticulos.Text = dataRow("Proveedor")
        'inputExistenciasArticulos.Text = dataRow("Cantidad")
        'inputPrCostArticulos.Text = dataRow("PrCost")
        'inputPrVentArticulos.Text = dataRow("PrVent")
        'inputBajoMinimoArticulos.Text = dataRow("BajoMinimo")
        'inputSobreMaximoArticulos.Text = dataRow("SobreMaximo")
        'inputDescripcionArticulos.Text = dataRow("Descripcion")

        '' Poner imagen
        'pictureboxArticulos.ImageLocation = dataRow("RutaImagen")
    End Sub

    Private Sub BindingNavigatorPositionItem_TextChanged(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.TextChanged
        ' cuando el valor del indice del bindingnavigator cambie, se actualizaran los inputs 
        ActualizarDatosNavigator()
    End Sub
End Class