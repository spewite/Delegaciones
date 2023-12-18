<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransportistasEdit
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
        Me.Label39 = New System.Windows.Forms.Label()
        Me.inputTelefonoTransportista = New System.Windows.Forms.TextBox()
        Me.inputNombreTransportista = New System.Windows.Forms.TextBox()
        Me.inputIdTransportista = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(21, 152)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(64, 16)
        Me.Label39.TabIndex = 87
        Me.Label39.Text = "Telefono:"
        '
        'inputTelefonoTransportista
        '
        Me.inputTelefonoTransportista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputTelefonoTransportista.Location = New System.Drawing.Point(102, 150)
        Me.inputTelefonoTransportista.Name = "inputTelefonoTransportista"
        Me.inputTelefonoTransportista.Size = New System.Drawing.Size(79, 22)
        Me.inputTelefonoTransportista.TabIndex = 86
        '
        'inputNombreTransportista
        '
        Me.inputNombreTransportista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNombreTransportista.Location = New System.Drawing.Point(102, 107)
        Me.inputNombreTransportista.Name = "inputNombreTransportista"
        Me.inputNombreTransportista.Size = New System.Drawing.Size(79, 22)
        Me.inputNombreTransportista.TabIndex = 84
        '
        'inputIdTransportista
        '
        Me.inputIdTransportista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdTransportista.Location = New System.Drawing.Point(123, 57)
        Me.inputIdTransportista.Name = "inputIdTransportista"
        Me.inputIdTransportista.Size = New System.Drawing.Size(79, 22)
        Me.inputIdTransportista.TabIndex = 82
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(20, 110)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(59, 16)
        Me.Label38.TabIndex = 85
        Me.Label38.Text = "Nombre:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(12, 58)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(105, 16)
        Me.Label46.TabIndex = 83
        Me.Label46.Text = "ID Transportista:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(272, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 88
        Me.Button1.Text = "Listo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TransportistasEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 302)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.inputTelefonoTransportista)
        Me.Controls.Add(Me.inputNombreTransportista)
        Me.Controls.Add(Me.inputIdTransportista)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label46)
        Me.Name = "TransportistasEdit"
        Me.Text = "TransportistasEdit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label39 As Label
    Friend WithEvents inputTelefonoTransportista As TextBox
    Friend WithEvents inputNombreTransportista As TextBox
    Friend WithEvents inputIdTransportista As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Button1 As Button
End Class
