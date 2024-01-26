<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportarArticulos
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
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnSubir = New System.Windows.Forms.Button()
        Me.inputRuta = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(406, 67)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(146, 27)
        Me.btnCargar.TabIndex = 0
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'btnSubir
        '
        Me.btnSubir.Location = New System.Drawing.Point(31, 136)
        Me.btnSubir.Name = "btnSubir"
        Me.btnSubir.Size = New System.Drawing.Size(506, 44)
        Me.btnSubir.TabIndex = 1
        Me.btnSubir.Text = "Importar"
        Me.btnSubir.UseVisualStyleBackColor = True
        '
        'inputRuta
        '
        Me.inputRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputRuta.Location = New System.Drawing.Point(31, 69)
        Me.inputRuta.Name = "inputRuta"
        Me.inputRuta.Size = New System.Drawing.Size(363, 22)
        Me.inputRuta.TabIndex = 2
        '
        'ImportarArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 234)
        Me.Controls.Add(Me.inputRuta)
        Me.Controls.Add(Me.btnSubir)
        Me.Controls.Add(Me.btnCargar)
        Me.Name = "ImportarArticulos"
        Me.Text = "Importar Articulos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCargar As Button
    Friend WithEvents btnSubir As Button
    Friend WithEvents inputRuta As TextBox
End Class
