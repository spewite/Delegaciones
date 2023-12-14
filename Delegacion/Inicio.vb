Imports System.Windows.Forms

Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionToolStripMenuItem.Click
        OpenOrActivateForm(Of Gestion)()
    End Sub
    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click
        OpenOrActivateForm(Of Pedidos)()
    End Sub

    Private Sub FacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasToolStripMenuItem.Click
        OpenOrActivateForm(Of Facturas)()
    End Sub

    Private Sub OpenOrActivateForm(Of T As {Form, New})()
        Dim existingForm = MdiChildren.OfType(Of T)().FirstOrDefault()

        If existingForm Is Nothing Then
            ' Si el formulario no está abierto, crea una nueva instancia y ábrelo
            Dim newForm As New T()
            newForm.MdiParent = Me
            newForm.WindowState = FormWindowState.Maximized
            newForm.Show()
        Else
            ' Si el formulario ya está abierto, actívalo y maximízalo
            existingForm.Activate()
            existingForm.WindowState = FormWindowState.Maximized
        End If
    End Sub


End Class
