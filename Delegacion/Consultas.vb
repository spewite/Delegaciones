Imports Dllgaciones.BaseDeDatos

Public Class Consultas

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pp = ConsultaBBDD("SELECT * FROM ESTADO_PEDIDOS")
        dataGridPedidos.DataSource = pp
    End Sub
End Class