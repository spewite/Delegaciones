<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Facturas
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
        Me.DateFechaPagoHastaFactura = New System.Windows.Forms.DateTimePicker()
        Me.DateFechaPagoDesdeFactura = New System.Windows.Forms.DateTimePicker()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.DateFechaEnvioHastaFactura = New System.Windows.Forms.DateTimePicker()
        Me.DateFechaEnvioDesdeFactura = New System.Windows.Forms.DateTimePicker()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.DateFechaEmitidaHastaFactura = New System.Windows.Forms.DateTimePicker()
        Me.DateFechaEmitidaDesdeFactura = New System.Windows.Forms.DateTimePicker()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.inputIdFactura = New System.Windows.Forms.TextBox()
        Me.dataGridFacturas = New System.Windows.Forms.DataGridView()
        Me.comboEstadoFactura = New System.Windows.Forms.ComboBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.btnConsultarPedidos = New System.Windows.Forms.Button()
        Me.checkFechaEmitidaDesdeFacturas = New System.Windows.Forms.CheckBox()
        Me.checkFechaEmitidaHastaFacturas = New System.Windows.Forms.CheckBox()
        Me.checkFechaEnvioDesdeFacturas = New System.Windows.Forms.CheckBox()
        Me.checkFechaEnvioHastaFacturas = New System.Windows.Forms.CheckBox()
        Me.checkFechaPagoDesdeFacturas = New System.Windows.Forms.CheckBox()
        Me.checkFechaPagoHastaFacturas = New System.Windows.Forms.CheckBox()
        Me.comboIdPedido = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGenerarFacturas = New System.Windows.Forms.Button()
        CType(Me.dataGridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateFechaPagoHastaFactura
        '
        Me.DateFechaPagoHastaFactura.Enabled = False
        Me.DateFechaPagoHastaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaPagoHastaFactura.Location = New System.Drawing.Point(884, 114)
        Me.DateFechaPagoHastaFactura.Name = "DateFechaPagoHastaFactura"
        Me.DateFechaPagoHastaFactura.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaPagoHastaFactura.TabIndex = 58
        '
        'DateFechaPagoDesdeFactura
        '
        Me.DateFechaPagoDesdeFactura.Enabled = False
        Me.DateFechaPagoDesdeFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaPagoDesdeFactura.Location = New System.Drawing.Point(884, 71)
        Me.DateFechaPagoDesdeFactura.Name = "DateFechaPagoDesdeFactura"
        Me.DateFechaPagoDesdeFactura.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaPagoDesdeFactura.TabIndex = 57
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(741, 116)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(126, 16)
        Me.Label53.TabIndex = 56
        Me.Label53.Text = "Fecha Pago Hasta: "
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(739, 72)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(128, 16)
        Me.Label54.TabIndex = 55
        Me.Label54.Text = "Fecha Pago Desde:"
        '
        'DateFechaEnvioHastaFactura
        '
        Me.DateFechaEnvioHastaFactura.Enabled = False
        Me.DateFechaEnvioHastaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaEnvioHastaFactura.Location = New System.Drawing.Point(523, 114)
        Me.DateFechaEnvioHastaFactura.Name = "DateFechaEnvioHastaFactura"
        Me.DateFechaEnvioHastaFactura.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaEnvioHastaFactura.TabIndex = 54
        '
        'DateFechaEnvioDesdeFactura
        '
        Me.DateFechaEnvioDesdeFactura.Enabled = False
        Me.DateFechaEnvioDesdeFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaEnvioDesdeFactura.Location = New System.Drawing.Point(523, 71)
        Me.DateFechaEnvioDesdeFactura.Name = "DateFechaEnvioDesdeFactura"
        Me.DateFechaEnvioDesdeFactura.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaEnvioDesdeFactura.TabIndex = 53
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(380, 119)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(127, 16)
        Me.Label55.TabIndex = 52
        Me.Label55.Text = "Fecha Envio Hasta: "
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(378, 72)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(129, 16)
        Me.Label56.TabIndex = 51
        Me.Label56.Text = "Fecha Envio Desde:"
        '
        'DateFechaEmitidaHastaFactura
        '
        Me.DateFechaEmitidaHastaFactura.Enabled = False
        Me.DateFechaEmitidaHastaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaEmitidaHastaFactura.Location = New System.Drawing.Point(173, 114)
        Me.DateFechaEmitidaHastaFactura.Name = "DateFechaEmitidaHastaFactura"
        Me.DateFechaEmitidaHastaFactura.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaEmitidaHastaFactura.TabIndex = 50
        '
        'DateFechaEmitidaDesdeFactura
        '
        Me.DateFechaEmitidaDesdeFactura.Enabled = False
        Me.DateFechaEmitidaDesdeFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaEmitidaDesdeFactura.Location = New System.Drawing.Point(173, 71)
        Me.DateFechaEmitidaDesdeFactura.Name = "DateFechaEmitidaDesdeFactura"
        Me.DateFechaEmitidaDesdeFactura.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaEmitidaDesdeFactura.TabIndex = 49
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(30, 119)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(138, 16)
        Me.Label60.TabIndex = 48
        Me.Label60.Text = "Fecha Emitida Hasta: "
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(28, 72)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(140, 16)
        Me.Label61.TabIndex = 47
        Me.Label61.Text = "Fecha Emitida Desde:"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(26, 27)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(71, 16)
        Me.Label62.TabIndex = 46
        Me.Label62.Text = "ID Factura:"
        '
        'inputIdFactura
        '
        Me.inputIdFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdFactura.Location = New System.Drawing.Point(110, 26)
        Me.inputIdFactura.Name = "inputIdFactura"
        Me.inputIdFactura.Size = New System.Drawing.Size(210, 22)
        Me.inputIdFactura.TabIndex = 45
        '
        'dataGridFacturas
        '
        Me.dataGridFacturas.AllowUserToAddRows = False
        Me.dataGridFacturas.AllowUserToDeleteRows = False
        Me.dataGridFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridFacturas.Location = New System.Drawing.Point(27, 174)
        Me.dataGridFacturas.Name = "dataGridFacturas"
        Me.dataGridFacturas.ReadOnly = True
        Me.dataGridFacturas.RowHeadersWidth = 51
        Me.dataGridFacturas.RowTemplate.Height = 24
        Me.dataGridFacturas.Size = New System.Drawing.Size(1288, 576)
        Me.dataGridFacturas.TabIndex = 44
        '
        'comboEstadoFactura
        '
        Me.comboEstadoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboEstadoFactura.FormattingEnabled = True
        Me.comboEstadoFactura.Location = New System.Drawing.Point(440, 27)
        Me.comboEstadoFactura.Name = "comboEstadoFactura"
        Me.comboEstadoFactura.Size = New System.Drawing.Size(234, 24)
        Me.comboEstadoFactura.TabIndex = 43
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(378, 30)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(56, 16)
        Me.Label64.TabIndex = 42
        Me.Label64.Text = "Estado: "
        '
        'btnConsultarPedidos
        '
        Me.btnConsultarPedidos.Location = New System.Drawing.Point(1078, 100)
        Me.btnConsultarPedidos.Name = "btnConsultarPedidos"
        Me.btnConsultarPedidos.Size = New System.Drawing.Size(162, 32)
        Me.btnConsultarPedidos.TabIndex = 70
        Me.btnConsultarPedidos.Text = "Consultar"
        Me.btnConsultarPedidos.UseVisualStyleBackColor = True
        '
        'checkFechaEmitidaDesdeFacturas
        '
        Me.checkFechaEmitidaDesdeFacturas.AutoSize = True
        Me.checkFechaEmitidaDesdeFacturas.Location = New System.Drawing.Point(303, 74)
        Me.checkFechaEmitidaDesdeFacturas.Name = "checkFechaEmitidaDesdeFacturas"
        Me.checkFechaEmitidaDesdeFacturas.Size = New System.Drawing.Size(18, 17)
        Me.checkFechaEmitidaDesdeFacturas.TabIndex = 73
        Me.checkFechaEmitidaDesdeFacturas.UseVisualStyleBackColor = True
        '
        'checkFechaEmitidaHastaFacturas
        '
        Me.checkFechaEmitidaHastaFacturas.AutoSize = True
        Me.checkFechaEmitidaHastaFacturas.Location = New System.Drawing.Point(303, 118)
        Me.checkFechaEmitidaHastaFacturas.Name = "checkFechaEmitidaHastaFacturas"
        Me.checkFechaEmitidaHastaFacturas.Size = New System.Drawing.Size(18, 17)
        Me.checkFechaEmitidaHastaFacturas.TabIndex = 74
        Me.checkFechaEmitidaHastaFacturas.UseVisualStyleBackColor = True
        '
        'checkFechaEnvioDesdeFacturas
        '
        Me.checkFechaEnvioDesdeFacturas.AutoSize = True
        Me.checkFechaEnvioDesdeFacturas.Location = New System.Drawing.Point(658, 75)
        Me.checkFechaEnvioDesdeFacturas.Name = "checkFechaEnvioDesdeFacturas"
        Me.checkFechaEnvioDesdeFacturas.Size = New System.Drawing.Size(18, 17)
        Me.checkFechaEnvioDesdeFacturas.TabIndex = 75
        Me.checkFechaEnvioDesdeFacturas.UseVisualStyleBackColor = True
        '
        'checkFechaEnvioHastaFacturas
        '
        Me.checkFechaEnvioHastaFacturas.AutoSize = True
        Me.checkFechaEnvioHastaFacturas.Location = New System.Drawing.Point(658, 117)
        Me.checkFechaEnvioHastaFacturas.Name = "checkFechaEnvioHastaFacturas"
        Me.checkFechaEnvioHastaFacturas.Size = New System.Drawing.Size(18, 17)
        Me.checkFechaEnvioHastaFacturas.TabIndex = 76
        Me.checkFechaEnvioHastaFacturas.UseVisualStyleBackColor = True
        '
        'checkFechaPagoDesdeFacturas
        '
        Me.checkFechaPagoDesdeFacturas.AutoSize = True
        Me.checkFechaPagoDesdeFacturas.Location = New System.Drawing.Point(1017, 74)
        Me.checkFechaPagoDesdeFacturas.Name = "checkFechaPagoDesdeFacturas"
        Me.checkFechaPagoDesdeFacturas.Size = New System.Drawing.Size(18, 17)
        Me.checkFechaPagoDesdeFacturas.TabIndex = 77
        Me.checkFechaPagoDesdeFacturas.UseVisualStyleBackColor = True
        '
        'checkFechaPagoHastaFacturas
        '
        Me.checkFechaPagoHastaFacturas.AutoSize = True
        Me.checkFechaPagoHastaFacturas.Location = New System.Drawing.Point(1017, 116)
        Me.checkFechaPagoHastaFacturas.Name = "checkFechaPagoHastaFacturas"
        Me.checkFechaPagoHastaFacturas.Size = New System.Drawing.Size(18, 17)
        Me.checkFechaPagoHastaFacturas.TabIndex = 78
        Me.checkFechaPagoHastaFacturas.UseVisualStyleBackColor = True
        '
        'inputIdPedido
        '
        Me.comboIdPedido.FormattingEnabled = True
        Me.comboIdPedido.Location = New System.Drawing.Point(815, 27)
        Me.comboIdPedido.Name = "comboIdPedido"
        Me.comboIdPedido.Size = New System.Drawing.Size(220, 24)
        Me.comboIdPedido.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(741, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Id Pedido:"
        '
        'btnGenerarFacturas
        '
        Me.btnGenerarFacturas.Location = New System.Drawing.Point(1078, 43)
        Me.btnGenerarFacturas.Name = "btnGenerarFacturas"
        Me.btnGenerarFacturas.Size = New System.Drawing.Size(162, 32)
        Me.btnGenerarFacturas.TabIndex = 81
        Me.btnGenerarFacturas.Text = "Generar Facturas"
        Me.btnGenerarFacturas.UseVisualStyleBackColor = True
        '
        'Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1467, 807)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnGenerarFacturas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboIdPedido)
        Me.Controls.Add(Me.checkFechaPagoHastaFacturas)
        Me.Controls.Add(Me.checkFechaPagoDesdeFacturas)
        Me.Controls.Add(Me.checkFechaEnvioHastaFacturas)
        Me.Controls.Add(Me.checkFechaEnvioDesdeFacturas)
        Me.Controls.Add(Me.checkFechaEmitidaHastaFacturas)
        Me.Controls.Add(Me.checkFechaEmitidaDesdeFacturas)
        Me.Controls.Add(Me.btnConsultarPedidos)
        Me.Controls.Add(Me.DateFechaPagoHastaFactura)
        Me.Controls.Add(Me.DateFechaPagoDesdeFactura)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.DateFechaEnvioHastaFactura)
        Me.Controls.Add(Me.DateFechaEnvioDesdeFactura)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.DateFechaEmitidaHastaFactura)
        Me.Controls.Add(Me.DateFechaEmitidaDesdeFactura)
        Me.Controls.Add(Me.Label60)
        Me.Controls.Add(Me.Label61)
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.inputIdFactura)
        Me.Controls.Add(Me.dataGridFacturas)
        Me.Controls.Add(Me.comboEstadoFactura)
        Me.Controls.Add(Me.Label64)
        Me.Name = "Facturas"
        Me.Text = "Facturas"
        CType(Me.dataGridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateFechaPagoHastaFactura As DateTimePicker
    Friend WithEvents DateFechaPagoDesdeFactura As DateTimePicker
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents DateFechaEnvioHastaFactura As DateTimePicker
    Friend WithEvents DateFechaEnvioDesdeFactura As DateTimePicker
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents DateFechaEmitidaHastaFactura As DateTimePicker
    Friend WithEvents DateFechaEmitidaDesdeFactura As DateTimePicker
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents inputIdFactura As TextBox
    Friend WithEvents dataGridFacturas As DataGridView
    Friend WithEvents comboEstadoFactura As ComboBox
    Friend WithEvents Label64 As Label
    Friend WithEvents btnConsultarPedidos As Button
    Friend WithEvents checkFechaEmitidaDesdeFacturas As CheckBox
    Friend WithEvents checkFechaEmitidaHastaFacturas As CheckBox
    Friend WithEvents checkFechaEnvioDesdeFacturas As CheckBox
    Friend WithEvents checkFechaEnvioHastaFacturas As CheckBox
    Friend WithEvents checkFechaPagoDesdeFacturas As CheckBox
    Friend WithEvents checkFechaPagoHastaFacturas As CheckBox
    Friend WithEvents comboIdPedido As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGenerarFacturas As Button
End Class
