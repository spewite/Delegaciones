Public Class Consultas
<<<<<<< HEAD

=======
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dataTableGeneral = Dllgaciones.BaseDeDatos.ConsultaBBDD("SELECT * FROM ESTADO_PEDIDOS")
        dataGridPedidos.DataSource = dataTableGeneral
    End Sub
>>>>>>> d1c5344 (Primera implementacion de la dll y consultar datagrid)
End Class