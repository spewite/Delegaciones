<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportarPartners
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPartners = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPartners
        '
        Me.btnPartners.Location = New System.Drawing.Point(152, 97)
        Me.btnPartners.Name = "btnPartners"
        Me.btnPartners.Size = New System.Drawing.Size(259, 38)
        Me.btnPartners.TabIndex = 0
        Me.btnPartners.Text = "Exportar Partners"
        Me.btnPartners.UseVisualStyleBackColor = True
        '
        'ExportarPartners
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 234)
        Me.Controls.Add(Me.btnPartners)
        Me.Name = "ExportarPartners"
        Me.Text = "Exportar Partners"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPartners As Button
End Class
