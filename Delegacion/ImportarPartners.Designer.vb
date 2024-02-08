<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImportarPartners
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.inputRuta = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'inputRuta
        '
        Me.inputRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputRuta.Location = New System.Drawing.Point(52, 67)
        Me.inputRuta.Name = "inputRuta"
        Me.inputRuta.Size = New System.Drawing.Size(345, 22)
        Me.inputRuta.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(52, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(506, 45)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Importar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(412, 65)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(146, 27)
        Me.btnCargar.TabIndex = 4
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'ImportarPartners
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 241)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.inputRuta)
        Me.Controls.Add(Me.Button2)
        Me.Name = "ImportarPartners"
        Me.Text = "Importar Partners"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inputRuta As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnCargar As Button
End Class
