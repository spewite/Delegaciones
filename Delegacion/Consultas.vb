Imports Dllgaciones.BaseDeDatos

Public Class Consultas

    Dim conexion As String = "Data Source=192.168.0.241; Initial Catalog=DELEGACION; User ID=sa; Password=Negrocabron8@"

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pp = ConsultaBBDD(conexion, "SELECT * FROM ESTADO_PEDIDOS")
        dataGridPedidos.DataSource = pp
    End Sub
End Class