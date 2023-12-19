Imports System.Data.SqlClient
Imports Dllgaciones.BaseDeDatos


Public Class Gestion

    Dim connectionString As String = "Data Source=192.168.0.241;Initial Catalog=DELEGACION;User ID=sa;Password=Negrocabron8@"
    Dim dataTable As DataTable

    Private Sub Gestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.ControlBox = False
    End Sub

    Private Sub btnConsultarArticulos_Click(sender As Object, e As EventArgs) Handles btnConsultarArticulos.Click
        ' Construir la sentencia SQL base
        Dim sqlQuery As String = "SELECT * FROM ARTICULOS WHERE 1 = 1"

        ' Agregar condiciones según los valores ingresados en los controles
        If Not String.IsNullOrEmpty(inputIdArticulo.Text) Then
            sqlQuery &= " AND IdArticulo = @IdArticulo"
        End If

        If Not String.IsNullOrEmpty(inputNombreArticulo.Text) Then
            sqlQuery &= " AND NombreArticulo = @NombreArticulo"
        End If

        If Not String.IsNullOrEmpty(inputProveedorArticulo.Text) Then
            sqlQuery &= " AND ProveedorArticulo = @ProveedorArticulo"
        End If

        If Not String.IsNullOrEmpty(inputExistenciasArticulo.Text) Then
            sqlQuery &= " AND ExistenciasArticulo = @ExistenciasArticulo"
        End If

        If Not String.IsNullOrEmpty(inputPrCostArticulos.Text) Then
            sqlQuery &= " AND PrCostArticulos = @PrCostArticulos"
        End If

        If Not String.IsNullOrEmpty(inputPrVentArticulos.Text) Then
            sqlQuery &= " AND PrVentArticulos = @PrVentArticulos"
        End If

        If Not String.IsNullOrEmpty(inputSobreMaximoArticulos.Text) Then
            sqlQuery &= " AND SobreMaximoArticulos = @SobreMaximoArticulos"
        End If

        If Not String.IsNullOrEmpty(inputBajoMinimoArticulos.Text) Then
            sqlQuery &= " AND BajoMinimoArticulos = @BajoMinimoArticulos"
        End If

        dataTable = ConsultaBBDD(connectionString, sqlQuery)
        dataGridArticulos.DataSource = dataTable

    End Sub
End Class