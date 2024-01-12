<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lineas
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.inputIdPedido = New System.Windows.Forms.TextBox()
        Me.comboTransportistaPedido = New System.Windows.Forms.ComboBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.comboComercialPedido = New System.Windows.Forms.ComboBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1115, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 93
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(41, 33)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(59, 16)
        Me.Label45.TabIndex = 77
        Me.Label45.Text = "ID Linea:"
        '
        'inputIdPedido
        '
        Me.inputIdPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdPedido.Location = New System.Drawing.Point(129, 33)
        Me.inputIdPedido.Name = "inputIdPedido"
        Me.inputIdPedido.Size = New System.Drawing.Size(172, 22)
        Me.inputIdPedido.TabIndex = 76
        '
        'comboTransportistaPedido
        '
        Me.comboTransportistaPedido.FormattingEnabled = True
        Me.comboTransportistaPedido.Location = New System.Drawing.Point(715, 31)
        Me.comboTransportistaPedido.Name = "comboTransportistaPedido"
        Me.comboTransportistaPedido.Size = New System.Drawing.Size(116, 24)
        Me.comboTransportistaPedido.TabIndex = 72
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(617, 36)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(70, 16)
        Me.Label47.TabIndex = 71
        Me.Label47.Text = "ID Pedido:"
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(42, 180)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.RowHeadersWidth = 51
        Me.DataGridView5.RowTemplate.Height = 24
        Me.DataGridView5.Size = New System.Drawing.Size(1288, 576)
        Me.DataGridView5.TabIndex = 70
        '
        'comboComercialPedido
        '
        Me.comboComercialPedido.FormattingEnabled = True
        Me.comboComercialPedido.Location = New System.Drawing.Point(436, 30)
        Me.comboComercialPedido.Name = "comboComercialPedido"
        Me.comboComercialPedido.Size = New System.Drawing.Size(116, 24)
        Me.comboComercialPedido.TabIndex = 69
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(356, 33)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(70, 16)
        Me.Label48.TabIndex = 68
        Me.Label48.Text = "ID Articulo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Cantidad:"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(129, 77)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(172, 22)
        Me.TextBox1.TabIndex = 94
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(329, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Descuento:"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(417, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(172, 22)
        Me.TextBox2.TabIndex = 96
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(613, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Precio:"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(701, 79)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(172, 22)
        Me.TextBox3.TabIndex = 98
        '
        'Lineas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1495, 801)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.inputIdPedido)
        Me.Controls.Add(Me.comboTransportistaPedido)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.DataGridView5)
        Me.Controls.Add(Me.comboComercialPedido)
        Me.Controls.Add(Me.Label48)
        Me.Name = "Lineas"
        Me.Text = "Lineas"
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label45 As Label
    Friend WithEvents inputIdPedido As TextBox
    Friend WithEvents comboTransportistaPedido As ComboBox
    Friend WithEvents Label47 As Label
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents comboComercialPedido As ComboBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
