<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidosEdit
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
        Me.comboComercialPedido = New System.Windows.Forms.ComboBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateFechaPagoHastaPedido
        '
        Me.DateFechaPagoHastaPedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaPagoHastaPedido.Location = New System.Drawing.Point(200, 374)
        Me.DateFechaPagoHastaPedido.Name = "DateFechaPagoHastaPedido"
        Me.DateFechaPagoHastaPedido.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaPagoHastaPedido.TabIndex = 90
        '
        'DateFechaPagoDesdePedido
        '
        Me.DateFechaPagoDesdePedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaPagoDesdePedido.Location = New System.Drawing.Point(200, 331)
        Me.DateFechaPagoDesdePedido.Name = "DateFechaPagoDesdePedido"
        Me.DateFechaPagoDesdePedido.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaPagoDesdePedido.TabIndex = 89
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(57, 379)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(126, 16)
        Me.Label51.TabIndex = 88
        Me.Label51.Text = "Fecha Pago Hasta: "
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(55, 332)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(128, 16)
        Me.Label52.TabIndex = 87
        Me.Label52.Text = "Fecha Pago Desde:"
        '
        'DateFechaEnvioHastaPedido
        '
        Me.DateFechaEnvioHastaPedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaEnvioHastaPedido.Location = New System.Drawing.Point(175, 242)
        Me.DateFechaEnvioHastaPedido.Name = "DateFechaEnvioHastaPedido"
        Me.DateFechaEnvioHastaPedido.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaEnvioHastaPedido.TabIndex = 86
        '
        'DateFechaEnvioDesdePedido
        '
        Me.DateFechaEnvioDesdePedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaEnvioDesdePedido.Location = New System.Drawing.Point(175, 199)
        Me.DateFechaEnvioDesdePedido.Name = "DateFechaEnvioDesdePedido"
        Me.DateFechaEnvioDesdePedido.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaEnvioDesdePedido.TabIndex = 85
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(32, 247)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(127, 16)
        Me.Label49.TabIndex = 84
        Me.Label49.Text = "Fecha Envio Hasta: "
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(30, 200)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(129, 16)
        Me.Label50.TabIndex = 83
        Me.Label50.Text = "Fecha Envio Desde:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(354, 108)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(55, 16)
        Me.Label40.TabIndex = 82
        Me.Label40.Text = "Factura:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(355, 65)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(119, 16)
        Me.Label41.TabIndex = 81
        Me.Label41.Text = "Estado de Pedido:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(322, 24)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(53, 16)
        Me.Label42.TabIndex = 80
        Me.Label42.Text = "Partner:"
        '
        'DateFechaPedidoHastaPedido
        '
        Me.DateFechaPedidoHastaPedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaPedidoHastaPedido.Location = New System.Drawing.Point(173, 109)
        Me.DateFechaPedidoHastaPedido.Name = "DateFechaPedidoHastaPedido"
        Me.DateFechaPedidoHastaPedido.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaPedidoHastaPedido.TabIndex = 79
        '
        'DateFechaPedidoDesdePedido
        '
        Me.DateFechaPedidoDesdePedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaPedidoDesdePedido.Location = New System.Drawing.Point(173, 66)
        Me.DateFechaPedidoDesdePedido.Name = "DateFechaPedidoDesdePedido"
        Me.DateFechaPedidoDesdePedido.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaPedidoDesdePedido.TabIndex = 78
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(30, 114)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(137, 16)
        Me.Label43.TabIndex = 77
        Me.Label43.Text = "Fecha Pedido Hasta: "
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(28, 67)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(139, 16)
        Me.Label44.TabIndex = 76
        Me.Label44.Text = "Fecha Pedido Desde:"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(26, 22)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(70, 16)
        Me.Label45.TabIndex = 75
        Me.Label45.Text = "ID Pedido:"
        '
        'inputIdPedido
        '
        Me.inputIdPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdPedido.Location = New System.Drawing.Point(114, 22)
        Me.inputIdPedido.Name = "inputIdPedido"
        Me.inputIdPedido.Size = New System.Drawing.Size(172, 22)
        Me.inputIdPedido.TabIndex = 74
        '
        'comboPartnerPedido
        '
        Me.comboPartnerPedido.FormattingEnabled = True
        Me.comboPartnerPedido.Location = New System.Drawing.Point(381, 20)
        Me.comboPartnerPedido.Name = "comboPartnerPedido"
        Me.comboPartnerPedido.Size = New System.Drawing.Size(116, 24)
        Me.comboPartnerPedido.TabIndex = 73
        '
        'comboFacturaPedido
        '
        Me.comboFacturaPedido.FormattingEnabled = True
        Me.comboFacturaPedido.Location = New System.Drawing.Point(484, 105)
        Me.comboFacturaPedido.Name = "comboFacturaPedido"
        Me.comboFacturaPedido.Size = New System.Drawing.Size(121, 24)
        Me.comboFacturaPedido.TabIndex = 72
        '
        'comboEstadoPedido
        '
        Me.comboEstadoPedido.FormattingEnabled = True
        Me.comboEstadoPedido.Location = New System.Drawing.Point(484, 61)
        Me.comboEstadoPedido.Name = "comboEstadoPedido"
        Me.comboEstadoPedido.Size = New System.Drawing.Size(121, 24)
        Me.comboEstadoPedido.TabIndex = 71
        '
        'comboTransportistaPedido
        '
        Me.comboTransportistaPedido.FormattingEnabled = True
        Me.comboTransportistaPedido.Location = New System.Drawing.Point(134, 285)
        Me.comboTransportistaPedido.Name = "comboTransportistaPedido"
        Me.comboTransportistaPedido.Size = New System.Drawing.Size(116, 24)
        Me.comboTransportistaPedido.TabIndex = 70
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(36, 290)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(92, 16)
        Me.Label47.TabIndex = 69
        Me.Label47.Text = "Transportista: "
        '
        'comboComercialPedido
        '
        Me.comboComercialPedido.FormattingEnabled = True
        Me.comboComercialPedido.Location = New System.Drawing.Point(110, 152)
        Me.comboComercialPedido.Name = "comboComercialPedido"
        Me.comboComercialPedido.Size = New System.Drawing.Size(116, 24)
        Me.comboComercialPedido.TabIndex = 68
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(30, 155)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(74, 16)
        Me.Label48.TabIndex = 67
        Me.Label48.Text = "Comercial: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(430, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 91
        Me.Button1.Text = "Listo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PedidosEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 448)
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
        Me.Controls.Add(Me.comboComercialPedido)
        Me.Controls.Add(Me.Label48)
        Me.Name = "PedidosEdit"
        Me.Text = "PedidosEdit"
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
    Friend WithEvents comboComercialPedido As ComboBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Button1 As Button
End Class
