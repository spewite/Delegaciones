Public Class Consultas
<<<<<<< HEAD
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

=======
<<<<<<< HEAD
>>>>>>> origin/main

=======
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dataTableGeneral = Dllgaciones.BaseDeDatos.ConsultaBBDD("SELECT * FROM ESTADO_PEDIDOS")
        dataGridPedidos.DataSource = dataTableGeneral
    End Sub
>>>>>>> 63dc5f10538bd1e79d50ec622a9ddaaf409bc96d
End Class