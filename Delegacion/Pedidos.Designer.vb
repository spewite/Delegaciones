<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pedidos
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
        Me.dateFechaPagoHastaPedidos = New System.Windows.Forms.DateTimePicker()
        Me.dateFechaPagoDesdePedidos = New System.Windows.Forms.DateTimePicker()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.dateFechaEnvioHastaPedidos = New System.Windows.Forms.DateTimePicker()
        Me.dateFechaEnvioDesdePedidos = New System.Windows.Forms.DateTimePicker()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.dateFechaPedidoHastaPedidos = New System.Windows.Forms.DateTimePicker()
        Me.dateFechaPedidoDesdePedidos = New System.Windows.Forms.DateTimePicker()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.inputIdPedidos = New System.Windows.Forms.TextBox()
        Me.comboPartnerPedidos = New System.Windows.Forms.ComboBox()
        Me.comboIdFacturaPedidos = New System.Windows.Forms.ComboBox()
        Me.comboEstadoPedidos = New System.Windows.Forms.ComboBox()
        Me.comboTransportistaPedido = New System.Windows.Forms.ComboBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.dataGridPedidos = New System.Windows.Forms.DataGridView()
        Me.comboComercialPedidos = New System.Windows.Forms.ComboBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.btnBorrarPedidos = New System.Windows.Forms.Button()
        Me.btnAltaPedidos = New System.Windows.Forms.Button()
        Me.btnConsultarPedidos = New System.Windows.Forms.Button()
        Me.checkFechaPedidoDesdePedidos = New System.Windows.Forms.CheckBox()
        Me.checkFechaPedidoHastaPedidos = New System.Windows.Forms.CheckBox()
        Me.checkFechaEnvioHastaPedidos = New System.Windows.Forms.CheckBox()
        Me.checkFechaEnvioDesdePedidos = New System.Windows.Forms.CheckBox()
        Me.checkFechaPagoDesdePedidos = New System.Windows.Forms.CheckBox()
        Me.checkFechaPagoHastaPedidos = New System.Windows.Forms.CheckBox()
        CType(Me.dataGridPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dateFechaPagoHastaPedidos
        '
        Me.dateFechaPagoHastaPedidos.Enabled = False
        Me.dateFechaPagoHastaPedidos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFechaPagoHastaPedidos.Location = New System.Drawing.Point(784, 116)
        Me.dateFechaPagoHastaPedidos.Name = "dateFechaPagoHastaPedidos"
        Me.dateFechaPagoHastaPedidos.Size = New System.Drawing.Size(110, 22)
        Me.dateFechaPagoHastaPedidos.TabIndex = 66
        '
        'dateFechaPagoDesdePedidos
        '
        Me.dateFechaPagoDesdePedidos.Enabled = False
        Me.dateFechaPagoDesdePedidos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFechaPagoDesdePedidos.Location = New System.Drawing.Point(784, 73)
        Me.dateFechaPagoDesdePedidos.Name = "dateFechaPagoDesdePedidos"
        Me.dateFechaPagoDesdePedidos.Size = New System.Drawing.Size(110, 22)
        Me.dateFechaPagoDesdePedidos.TabIndex = 65
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(647, 121)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(126, 16)
        Me.Label51.TabIndex = 64
        Me.Label51.Text = "Fecha Pago Hasta: "
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(648, 76)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(128, 16)
        Me.Label52.TabIndex = 63
        Me.Label52.Text = "Fecha Pago Desde:"
        '
        'dateFechaEnvioHastaPedidos
        '
        Me.dateFechaEnvioHastaPedidos.Enabled = False
        Me.dateFechaEnvioHastaPedidos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFechaEnvioHastaPedidos.Location = New System.Drawing.Point(482, 118)
        Me.dateFechaEnvioHastaPedidos.Name = "dateFechaEnvioHastaPedidos"
        Me.dateFechaEnvioHastaPedidos.Size = New System.Drawing.Size(110, 22)
        Me.dateFechaEnvioHastaPedidos.TabIndex = 62
        '
        'dateFechaEnvioDesdePedidos
        '
        Me.dateFechaEnvioDesdePedidos.Enabled = False
        Me.dateFechaEnvioDesdePedidos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFechaEnvioDesdePedidos.Location = New System.Drawing.Point(481, 75)
        Me.dateFechaEnvioDesdePedidos.Name = "dateFechaEnvioDesdePedidos"
        Me.dateFechaEnvioDesdePedidos.Size = New System.Drawing.Size(110, 22)
        Me.dateFechaEnvioDesdePedidos.TabIndex = 61
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(344, 121)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(127, 16)
        Me.Label49.TabIndex = 60
        Me.Label49.Text = "Fecha Envio Hasta: "
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(342, 74)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(129, 16)
        Me.Label50.TabIndex = 59
        Me.Label50.Text = "Fecha Envio Desde:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(986, 118)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(71, 16)
        Me.Label40.TabIndex = 58
        Me.Label40.Text = "ID Factura:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(937, 75)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(119, 16)
        Me.Label41.TabIndex = 57
        Me.Label41.Text = "Estado de Pedido:"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(1003, 31)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(53, 16)
        Me.Label42.TabIndex = 56
        Me.Label42.Text = "Partner:"
        '
        'dateFechaPedidoHastaPedidos
        '
        Me.dateFechaPedidoHastaPedidos.Enabled = False
        Me.dateFechaPedidoHastaPedidos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFechaPedidoHastaPedidos.Location = New System.Drawing.Point(183, 116)
        Me.dateFechaPedidoHastaPedidos.Name = "dateFechaPedidoHastaPedidos"
        Me.dateFechaPedidoHastaPedidos.Size = New System.Drawing.Size(114, 22)
        Me.dateFechaPedidoHastaPedidos.TabIndex = 55
        '
        'dateFechaPedidoDesdePedidos
        '
        Me.dateFechaPedidoDesdePedidos.Enabled = False
        Me.dateFechaPedidoDesdePedidos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFechaPedidoDesdePedidos.Location = New System.Drawing.Point(183, 73)
        Me.dateFechaPedidoDesdePedidos.Name = "dateFechaPedidoDesdePedidos"
        Me.dateFechaPedidoDesdePedidos.Size = New System.Drawing.Size(114, 22)
        Me.dateFechaPedidoDesdePedidos.TabIndex = 54
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(40, 121)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(137, 16)
        Me.Label43.TabIndex = 53
        Me.Label43.Text = "Fecha Pedido Hasta: "
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(39, 74)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(139, 16)
        Me.Label44.TabIndex = 52
        Me.Label44.Text = "Fecha Pedido Desde:"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(41, 33)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(70, 16)
        Me.Label45.TabIndex = 51
        Me.Label45.Text = "ID Pedido:"
        '
        'inputIdPedidos
        '
        Me.inputIdPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdPedidos.Location = New System.Drawing.Point(117, 29)
        Me.inputIdPedidos.Name = "inputIdPedidos"
        Me.inputIdPedidos.Size = New System.Drawing.Size(204, 22)
        Me.inputIdPedidos.TabIndex = 50
        '
        'comboPartnerPedidos
        '
        Me.comboPartnerPedidos.FormattingEnabled = True
        Me.comboPartnerPedidos.Location = New System.Drawing.Point(1067, 27)
        Me.comboPartnerPedidos.Name = "comboPartnerPedidos"
        Me.comboPartnerPedidos.Size = New System.Drawing.Size(204, 24)
        Me.comboPartnerPedidos.TabIndex = 49
        '
        'comboIdFacturaPedidos
        '
        Me.comboIdFacturaPedidos.FormattingEnabled = True
        Me.comboIdFacturaPedidos.Location = New System.Drawing.Point(1067, 114)
        Me.comboIdFacturaPedidos.Name = "comboIdFacturaPedidos"
        Me.comboIdFacturaPedidos.Size = New System.Drawing.Size(204, 24)
        Me.comboIdFacturaPedidos.TabIndex = 48
        '
        'comboEstadoPedidos
        '
        Me.comboEstadoPedidos.FormattingEnabled = True
        Me.comboEstadoPedidos.Location = New System.Drawing.Point(1067, 71)
        Me.comboEstadoPedidos.Name = "comboEstadoPedidos"
        Me.comboEstadoPedidos.Size = New System.Drawing.Size(204, 24)
        Me.comboEstadoPedidos.TabIndex = 47
        '
        'comboTransportistaPedido
        '
        Me.comboTransportistaPedido.FormattingEnabled = True
        Me.comboTransportistaPedido.Location = New System.Drawing.Point(748, 28)
        Me.comboTransportistaPedido.Name = "comboTransportistaPedido"
        Me.comboTransportistaPedido.Size = New System.Drawing.Size(170, 24)
        Me.comboTransportistaPedido.TabIndex = 46
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(648, 33)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(92, 16)
        Me.Label47.TabIndex = 45
        Me.Label47.Text = "Transportista: "
        '
        'dataGridPedidos
        '
        Me.dataGridPedidos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridPedidos.Location = New System.Drawing.Point(36, 177)
        Me.dataGridPedidos.Name = "dataGridPedidos"
        Me.dataGridPedidos.RowHeadersWidth = 51
        Me.dataGridPedidos.RowTemplate.Height = 24
        Me.dataGridPedidos.Size = New System.Drawing.Size(1390, 651)
        Me.dataGridPedidos.TabIndex = 44
        '
        'comboComercialPedidos
        '
        Me.comboComercialPedidos.FormattingEnabled = True
        Me.comboComercialPedidos.Location = New System.Drawing.Point(419, 26)
        Me.comboComercialPedidos.Name = "comboComercialPedidos"
        Me.comboComercialPedidos.Size = New System.Drawing.Size(195, 24)
        Me.comboComercialPedidos.TabIndex = 43
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(339, 29)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(74, 16)
        Me.Label48.TabIndex = 42
        Me.Label48.Text = "Comercial: "
        '
        'btnBorrarPedidos
        '
        Me.btnBorrarPedidos.Location = New System.Drawing.Point(1310, 67)
        Me.btnBorrarPedidos.Name = "btnBorrarPedidos"
        Me.btnBorrarPedidos.Size = New System.Drawing.Size(162, 32)
        Me.btnBorrarPedidos.TabIndex = 69
        Me.btnBorrarPedidos.Text = "Borrar"
        Me.btnBorrarPedidos.UseVisualStyleBackColor = True
        '
        'btnAltaPedidos
        '
        Me.btnAltaPedidos.Location = New System.Drawing.Point(1310, 109)
        Me.btnAltaPedidos.Name = "btnAltaPedidos"
        Me.btnAltaPedidos.Size = New System.Drawing.Size(162, 32)
        Me.btnAltaPedidos.TabIndex = 68
        Me.btnAltaPedidos.Text = "Alta"
        Me.btnAltaPedidos.UseVisualStyleBackColor = True
        '
        'btnConsultarPedidos
        '
        Me.btnConsultarPedidos.Location = New System.Drawing.Point(1310, 26)
        Me.btnConsultarPedidos.Name = "btnConsultarPedidos"
        Me.btnConsultarPedidos.Size = New System.Drawing.Size(162, 32)
        Me.btnConsultarPedidos.TabIndex = 67
        Me.btnConsultarPedidos.Text = "Consultar"
        Me.btnConsultarPedidos.UseVisualStyleBackColor = True
        '
        'checkFechaPedidoDesdePedidos
        '
        Me.checkFechaPedidoDesdePedidos.AutoSize = True
        Me.checkFechaPedidoDesdePedidos.Location = New System.Drawing.Point(306, 76)
        Me.checkFechaPedidoDesdePedidos.Name = "checkFechaPedidoDesdePedidos"
        Me.checkFechaPedidoDesdePedidos.Size = New System.Drawing.Size(18, 17)
        Me.checkFechaPedidoDesdePedidos.TabIndex = 70
        Me.checkFechaPedidoDesdePedidos.UseVisualStyleBackColor = True
        '
        'checkFechaPedidoHastaPedidos
        '
        Me.checkFechaPedidoHastaPedidos.AutoSize = True
        Me.checkFechaPedidoHastaPedidos.Location = New System.Drawing.Point(306, 120)
        Me.checkFechaPedidoHastaPedidos.Name = "checkFechaPedidoHastaPedidos"
        Me.checkFechaPedidoHastaPedidos.Size = New System.Drawing.Size(18, 17)
        Me.checkFechaPedidoHastaPedidos.TabIndex = 71
        Me.checkFechaPedidoHastaPedidos.UseVisualStyleBackColor = True
        '
        'checkFechaEnvioHastaPedidos
        '
        Me.checkFechaEnvioHastaPedidos.AutoSize = True
        Me.checkFechaEnvioHastaPedidos.Location = New System.Drawing.Point(601, 122)
        Me.checkFechaEnvioHastaPedidos.Name = "checkFechaEnvioHastaPedidos"
        Me.checkFechaEnvioHastaPedidos.Size = New System.Drawing.Size(18, 17)
        Me.checkFechaEnvioHastaPedidos.TabIndex = 73
        Me.checkFechaEnvioHastaPedidos.UseVisualStyleBackColor = True
        '
        'checkFechaEnvioDesdePedidos
        '
        Me.checkFechaEnvioDesdePedidos.AutoSize = True
        Me.checkFechaEnvioDesdePedidos.Location = New System.Drawing.Point(600, 79)
        Me.checkFechaEnvioDesdePedidos.Name = "checkFechaEnvioDesdePedidos"
        Me.checkFechaEnvioDesdePedidos.Size = New System.Drawing.Size(18, 17)
        Me.checkFechaEnvioDesdePedidos.TabIndex = 72
        Me.checkFechaEnvioDesdePedidos.UseVisualStyleBackColor = True
        '
        'checkFechaPagoDesdePedidos
        '
        Me.checkFechaPagoDesdePedidos.AutoSize = True
        Me.checkFechaPagoDesdePedidos.Location = New System.Drawing.Point(905, 76)
        Me.checkFechaPagoDesdePedidos.Name = "checkFechaPagoDesdePedidos"
        Me.checkFechaPagoDesdePedidos.Size = New System.Drawing.Size(18, 17)
        Me.checkFechaPagoDesdePedidos.TabIndex = 74
        Me.checkFechaPagoDesdePedidos.UseVisualStyleBackColor = True
        '
        'checkFechaPagoHastaPedidos
        '
        Me.checkFechaPagoHastaPedidos.AutoSize = True
        Me.checkFechaPagoHastaPedidos.Location = New System.Drawing.Point(906, 119)
        Me.checkFechaPagoHastaPedidos.Name = "checkFechaPagoHastaPedidos"
        Me.checkFechaPagoHastaPedidos.Size = New System.Drawing.Size(18, 17)
        Me.checkFechaPagoHastaPedidos.TabIndex = 75
        Me.checkFechaPagoHastaPedidos.UseVisualStyleBackColor = True
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1467, 752)
        Me.ControlBox = False
        Me.Controls.Add(Me.checkFechaPagoHastaPedidos)
        Me.Controls.Add(Me.checkFechaPagoDesdePedidos)
        Me.Controls.Add(Me.checkFechaEnvioHastaPedidos)
        Me.Controls.Add(Me.checkFechaEnvioDesdePedidos)
        Me.Controls.Add(Me.checkFechaPedidoHastaPedidos)
        Me.Controls.Add(Me.checkFechaPedidoDesdePedidos)
        Me.Controls.Add(Me.btnBorrarPedidos)
        Me.Controls.Add(Me.btnAltaPedidos)
        Me.Controls.Add(Me.btnConsultarPedidos)
        Me.Controls.Add(Me.dateFechaPagoHastaPedidos)
        Me.Controls.Add(Me.dateFechaPagoDesdePedidos)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.dateFechaEnvioHastaPedidos)
        Me.Controls.Add(Me.dateFechaEnvioDesdePedidos)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.dateFechaPedidoHastaPedidos)
        Me.Controls.Add(Me.dateFechaPedidoDesdePedidos)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.inputIdPedidos)
        Me.Controls.Add(Me.comboPartnerPedidos)
        Me.Controls.Add(Me.comboIdFacturaPedidos)
        Me.Controls.Add(Me.comboEstadoPedidos)
        Me.Controls.Add(Me.comboTransportistaPedido)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.dataGridPedidos)
        Me.Controls.Add(Me.comboComercialPedidos)
        Me.Controls.Add(Me.Label48)
        Me.Name = "Pedidos"
        Me.Text = "Pedidos"
        CType(Me.dataGridPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dateFechaPagoHastaPedidos As DateTimePicker
    Friend WithEvents dateFechaPagoDesdePedidos As DateTimePicker
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents dateFechaEnvioHastaPedidos As DateTimePicker
    Friend WithEvents dateFechaEnvioDesdePedidos As DateTimePicker
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents dateFechaPedidoHastaPedidos As DateTimePicker
    Friend WithEvents dateFechaPedidoDesdePedidos As DateTimePicker
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents inputIdPedidos As TextBox
    Friend WithEvents comboPartnerPedidos As ComboBox
    Friend WithEvents comboIdFacturaPedidos As ComboBox
    Friend WithEvents comboEstadoPedidos As ComboBox
    Friend WithEvents comboTransportistaPedido As ComboBox
    Friend WithEvents Label47 As Label
    Friend WithEvents dataGridPedidos As DataGridView
    Friend WithEvents comboComercialPedidos As ComboBox
    Friend WithEvents Label48 As Label
    Friend WithEvents btnBorrarPedidos As Button
    Friend WithEvents btnAltaPedidos As Button
    Friend WithEvents btnConsultarPedidos As Button
    Friend WithEvents checkFechaPedidoDesdePedidos As CheckBox
    Friend WithEvents checkFechaPedidoHastaPedidos As CheckBox
    Friend WithEvents checkFechaEnvioHastaPedidos As CheckBox
    Friend WithEvents checkFechaEnvioDesdePedidos As CheckBox
    Friend WithEvents checkFechaPagoDesdePedidos As CheckBox
    Friend WithEvents checkFechaPagoHastaPedidos As CheckBox
End Class
