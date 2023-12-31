﻿Imports System.Reflection.Emit
Imports System.Windows.Forms

Public Class Inicio

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.IsMdiContainer = True
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

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class

Public Class ConexionBD
    Public Shared ReadOnly Property CadenaConexion As String
        Get
            ' ⬇️ Klase ⬇️
            Return "Data Source=192.168.0.241;Initial Catalog=DELEGACION;User ID=sa;Password=Negrocabron8@"

            ' ⬇️ Julen ⬇️
            'Return "Data Source=localhost;Initial Catalog=DELEGACIONES;User ID=sa;Password=sa"
        End Get
    End Property
End Class

