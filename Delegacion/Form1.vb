Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelGestion.Hide()

    End Sub

    Private Sub GestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionToolStripMenuItem.Click
        PanelGestion.Show()
    End Sub
End Class
