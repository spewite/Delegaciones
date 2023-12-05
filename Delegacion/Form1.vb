Imports System.Drawing.Drawing2D

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ' Configura el degradado
        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim brush As New LinearGradientBrush(rect, Color.Blue, Color.White, LinearGradientMode.Vertical)

        ' Dibuja el degradado en el fondo del formulario
        e.Graphics.FillRectangle(brush, rect)
    End Sub
End Class
