<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos
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
        Me.DateFechaPagoHastaPedido = New System.Windows.Forms.DateTimePicker()
        Me.DateFechaPagoDesdePedido = New System.Windows.Forms.DateTimePicker()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.DateFechaEnvioHastaPedido = New System.Windows.Forms.DateTimePicker()
        Me.DateFechaEnvioDesdePedido = New System.Windows.Forms.DateTimePicker()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.DateFechaPedidoHastaPedido = New System.Windows.Forms.DateTimePicker()
        Me.DateFechaPedidoDesdePedido = New System.Windows.Forms.DateTimePicker()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.inputIdPedido = New System.Windows.Forms.TextBox()
        Me.comboPartnerPedido = New System.Windows.Forms.ComboBox()
        Me.comboFacturaPedido = New System.Windows.Forms.ComboBox()
        Me.comboEstadoPedido = New System.Windows.Forms.ComboBox()
        Me.comboTransportistaPedido = New System.Windows.Forms.ComboBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.comboComercialPedido = New System.Windows.Forms.ComboBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateFechaPagoHastaPedido
        '
        Me.DateFechaPagoHastaPedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaPagoHastaPedido.Location = New System.Drawing.Point(769, 116)
        Me.DateFechaPagoHastaPedido.Name = "DateFechaPagoHastaPedido"
        Me.DateFechaPagoHastaPedido.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaPagoHastaPedido.TabIndex = 66
        '
        'DateFechaPagoDesdePedido
        '
        Me.DateFechaPagoDesdePedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaPagoDesdePedido.Location = New System.Drawing.Point(769, 73)
        Me.DateFechaPagoDesdePedido.Name = "DateFechaPagoDesdePedido"
        Me.DateFechaPagoDesdePedido.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaPagoDesdePedido.TabIndex = 65
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(626, 121)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(126, 16)
        Me.Label51.TabIndex = 64
        Me.Label51.Text = "Fecha Pago Hasta: "
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(624, 74)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(128, 16)
        Me.Label52.TabIndex = 63
        Me.Label52.Text = "Fecha Pago Desde:"
        '
        'DateFechaEnvioHastaPedido
        '
        Me.DateFechaEnvioHastaPedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaEnvioHastaPedido.Location = New System.Drawing.Point(489, 116)
        Me.DateFechaEnvioHastaPedido.Name = "DateFechaEnvioHastaPedido"
        Me.DateFechaEnvioHastaPedido.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaEnvioHastaPedido.TabIndex = 62
        '
        'DateFechaEnvioDesdePedido
        '
        Me.DateFechaEnvioDesdePedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaEnvioDesdePedido.Location = New System.Drawing.Point(489, 73)
        Me.DateFechaEnvioDesdePedido.Name = "DateFechaEnvioDesdePedido"
        Me.DateFechaEnvioDesdePedido.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaEnvioDesdePedido.TabIndex = 61
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(346, 121)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(127, 16)
        Me.Label49.TabIndex = 60
        Me.Label49.Text = "Fecha Envio Hasta: "
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(344, 74)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(129, 16)
        Me.Label50.TabIndex = 59
        Me.Label50.Text = "Fecha Envio Desde:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(913, 117)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(55, 16)
        Me.Label40.TabIndex = 58
        Me.Label40.Text = "Factura:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(914, 74)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(119, 16)
        Me.Label41.TabIndex = 57
        Me.Label41.Text = "Estado de Pedido:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(881, 33)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(53, 16)
        Me.Label42.TabIndex = 56
        Me.Label42.Text = "Partner:"
        '
        'DateFechaPedidoHastaPedido
        '
        Me.DateFechaPedidoHastaPedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaPedidoHastaPedido.Location = New System.Drawing.Point(176, 116)
        Me.DateFechaPedidoHastaPedido.Name = "DateFechaPedidoHastaPedido"
        Me.DateFechaPedidoHastaPedido.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaPedidoHastaPedido.TabIndex = 55
        '
        'DateFechaPedidoDesdePedido
        '
        Me.DateFechaPedidoDesdePedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaPedidoDesdePedido.Location = New System.Drawing.Point(176, 73)
        Me.DateFechaPedidoDesdePedido.Name = "DateFechaPedidoDesdePedido"
        Me.DateFechaPedidoDesdePedido.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaPedidoDesdePedido.TabIndex = 54
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(33, 121)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(137, 16)
        Me.Label43.TabIndex = 53
        Me.Label43.Text = "Fecha Pedido Hasta: "
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(31, 74)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(139, 16)
        Me.Label44.TabIndex = 52
        Me.Label44.Text = "Fecha Pedido Desde:"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(29, 29)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(70, 16)
        Me.Label45.TabIndex = 51
        Me.Label45.Text = "ID Pedido:"
        '
        'inputIdPedido
        '
        Me.inputIdPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdPedido.Location = New System.Drawing.Point(117, 29)
        Me.inputIdPedido.Name = "inputIdPedido"
        Me.inputIdPedido.Size = New System.Drawing.Size(172, 22)
        Me.inputIdPedido.TabIndex = 50
        '
        'comboPartnerPedido
        '
        Me.comboPartnerPedido.FormattingEnabled = True
        Me.comboPartnerPedido.Location = New System.Drawing.Point(940, 29)
        Me.comboPartnerPedido.Name = "comboPartnerPedido"
        Me.comboPartnerPedido.Size = New System.Drawing.Size(116, 24)
        Me.comboPartnerPedido.TabIndex = 49
        '
        'comboFacturaPedido
        '
        Me.comboFacturaPedido.FormattingEnabled = True
        Me.comboFacturaPedido.Location = New System.Drawing.Point(1043, 114)
        Me.comboFacturaPedido.Name = "comboFacturaPedido"
        Me.comboFacturaPedido.Size = New System.Drawing.Size(121, 24)
        Me.comboFacturaPedido.TabIndex = 48
        '
        'comboEstadoPedido
        '
        Me.comboEstadoPedido.FormattingEnabled = True
        Me.comboEstadoPedido.Location = New System.Drawing.Point(1043, 70)
        Me.comboEstadoPedido.Name = "comboEstadoPedido"
        Me.comboEstadoPedido.Size = New System.Drawing.Size(121, 24)
        Me.comboEstadoPedido.TabIndex = 47
        '
        'comboTransportistaPedido
        '
        Me.comboTransportistaPedido.FormattingEnabled = True
        Me.comboTransportistaPedido.Location = New System.Drawing.Point(703, 27)
        Me.comboTransportistaPedido.Name = "comboTransportistaPedido"
        Me.comboTransportistaPedido.Size = New System.Drawing.Size(116, 24)
        Me.comboTransportistaPedido.TabIndex = 46
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(605, 32)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(92, 16)
        Me.Label47.TabIndex = 45
        Me.Label47.Text = "Transportista: "
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(30, 176)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.RowHeadersWidth = 51
        Me.DataGridView5.RowTemplate.Height = 24
        Me.DataGridView5.Size = New System.Drawing.Size(1288, 576)
        Me.DataGridView5.TabIndex = 44
        '
        'comboComercialPedido
        '
        Me.comboComercialPedido.FormattingEnabled = True
        Me.comboComercialPedido.Location = New System.Drawing.Point(424, 26)
        Me.comboComercialPedido.Name = "comboComercialPedido"
        Me.comboComercialPedido.Size = New System.Drawing.Size(116, 24)
        Me.comboComercialPedido.TabIndex = 43
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(344, 29)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(74, 16)
        Me.Label48.TabIndex = 42
        Me.Label48.Text = "Comercial: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1248, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1467, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateFechaPagoHastaPedido)
        Me.Controls.Add(Me.DateFechaPagoDesdePedido)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.DateFechaEnvioHastaPedido)
        Me.Controls.Add(Me.DateFechaEnvioDesdePedido)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.DateFechaPedidoHastaPedido)
        Me.Controls.Add(Me.DateFechaPedidoDesdePedido)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.inputIdPedido)
        Me.Controls.Add(Me.comboPartnerPedido)
        Me.Controls.Add(Me.comboFacturaPedido)
        Me.Controls.Add(Me.comboEstadoPedido)
        Me.Controls.Add(Me.comboTransportistaPedido)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.DataGridView5)
        Me.Controls.Add(Me.comboComercialPedido)
        Me.Controls.Add(Me.Label48)
        Me.Name = "Pedidos"
        Me.Text = "Pedidos"
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateFechaPagoHastaPedido As DateTimePicker
    Friend WithEvents DateFechaPagoDesdePedido As DateTimePicker
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents DateFechaEnvioHastaPedido As DateTimePicker
    Friend WithEvents DateFechaEnvioDesdePedido As DateTimePicker
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents DateFechaPedidoHastaPedido As DateTimePicker
    Friend WithEvents DateFechaPedidoDesdePedido As DateTimePicker
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents inputIdPedido As TextBox
    Friend WithEvents comboPartnerPedido As ComboBox
    Friend WithEvents comboFacturaPedido As ComboBox
    Friend WithEvents comboEstadoPedido As ComboBox
    Friend WithEvents comboTransportistaPedido As ComboBox
    Friend WithEvents Label47 As Label
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents comboComercialPedido As ComboBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Button1 As Button
End Class
