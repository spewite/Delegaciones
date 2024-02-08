<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarFacturas
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
        Me.comboMes = New System.Windows.Forms.ComboBox()
        Me.comboPartner = New System.Windows.Forms.ComboBox()
        Me.btnGenerarFactura = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comboAño = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'comboMes
        '
        Me.comboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMes.FormattingEnabled = True
        Me.comboMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.comboMes.Location = New System.Drawing.Point(23, 94)
        Me.comboMes.Name = "comboMes"
        Me.comboMes.Size = New System.Drawing.Size(117, 24)
        Me.comboMes.TabIndex = 0
        '
        'comboPartner
        '
        Me.comboPartner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboPartner.FormattingEnabled = True
        Me.comboPartner.Location = New System.Drawing.Point(270, 94)
        Me.comboPartner.Name = "comboPartner"
        Me.comboPartner.Size = New System.Drawing.Size(198, 24)
        Me.comboPartner.TabIndex = 1
        '
        'btnGenerarFactura
        '
        Me.btnGenerarFactura.Location = New System.Drawing.Point(37, 183)
        Me.btnGenerarFactura.Name = "btnGenerarFactura"
        Me.btnGenerarFactura.Size = New System.Drawing.Size(424, 30)
        Me.btnGenerarFactura.TabIndex = 2
        Me.btnGenerarFactura.Text = "Generar Factura"
        Me.btnGenerarFactura.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(268, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Partner:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(147, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Año:"
        '
        'comboAño
        '
        Me.comboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboAño.FormattingEnabled = True
        Me.comboAño.Location = New System.Drawing.Point(146, 94)
        Me.comboAño.Name = "comboAño"
        Me.comboAño.Size = New System.Drawing.Size(117, 24)
        Me.comboAño.TabIndex = 7
        '
        'GenerarFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 315)
        Me.Controls.Add(Me.comboAño)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGenerarFactura)
        Me.Controls.Add(Me.comboPartner)
        Me.Controls.Add(Me.comboMes)
        Me.Name = "GenerarFacturas"
        Me.Text = "Generar Facturas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboMes As ComboBox
    Friend WithEvents comboPartner As ComboBox
    Friend WithEvents btnGenerarFactura As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents comboAño As ComboBox
End Class
