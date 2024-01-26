<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportarCatalogo
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
        Me.btnCatalogo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCatalogo
        '
        Me.btnCatalogo.Location = New System.Drawing.Point(152, 97)
        Me.btnCatalogo.Name = "btnCatalogo"
        Me.btnCatalogo.Size = New System.Drawing.Size(259, 38)
        Me.btnCatalogo.TabIndex = 0
        Me.btnCatalogo.Text = "Exportar Catalogo"
        Me.btnCatalogo.UseVisualStyleBackColor = True
        '
        'ExportarCatalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 234)
        Me.Controls.Add(Me.btnCatalogo)
        Me.Name = "ExportarCatalogo"
        Me.Text = "Exportar Catalogo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCatalogo As Button
End Class
