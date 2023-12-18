<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturasEdit
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
        Me.comboEstadoFactura = New System.Windows.Forms.ComboBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateFechaPagoHastaFactura
        '
        Me.DateFechaPagoHastaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaPagoHastaFactura.Location = New System.Drawing.Point(172, 331)
        Me.DateFechaPagoHastaFactura.Name = "DateFechaPagoHastaFactura"
        Me.DateFechaPagoHastaFactura.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaPagoHastaFactura.TabIndex = 74
        '
        'DateFechaPagoDesdeFactura
        '
        Me.DateFechaPagoDesdeFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaPagoDesdeFactura.Location = New System.Drawing.Point(172, 288)
        Me.DateFechaPagoDesdeFactura.Name = "DateFechaPagoDesdeFactura"
        Me.DateFechaPagoDesdeFactura.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaPagoDesdeFactura.TabIndex = 73
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(29, 336)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(126, 16)
        Me.Label53.TabIndex = 72
        Me.Label53.Text = "Fecha Pago Hasta: "
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(27, 289)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(128, 16)
        Me.Label54.TabIndex = 71
        Me.Label54.Text = "Fecha Pago Desde:"
        '
        'DateFechaEnvioHastaFactura
        '
        Me.DateFechaEnvioHastaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaEnvioHastaFactura.Location = New System.Drawing.Point(170, 232)
        Me.DateFechaEnvioHastaFactura.Name = "DateFechaEnvioHastaFactura"
        Me.DateFechaEnvioHastaFactura.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaEnvioHastaFactura.TabIndex = 70
        '
        'DateFechaEnvioDesdeFactura
        '
        Me.DateFechaEnvioDesdeFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaEnvioDesdeFactura.Location = New System.Drawing.Point(170, 189)
        Me.DateFechaEnvioDesdeFactura.Name = "DateFechaEnvioDesdeFactura"
        Me.DateFechaEnvioDesdeFactura.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaEnvioDesdeFactura.TabIndex = 69
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(27, 237)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(127, 16)
        Me.Label55.TabIndex = 68
        Me.Label55.Text = "Fecha Envio Hasta: "
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(25, 190)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(129, 16)
        Me.Label56.TabIndex = 67
        Me.Label56.Text = "Fecha Envio Desde:"
        '
        'DateFechaEmitidaHastaFactura
        '
        Me.DateFechaEmitidaHastaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaEmitidaHastaFactura.Location = New System.Drawing.Point(159, 106)
        Me.DateFechaEmitidaHastaFactura.Name = "DateFechaEmitidaHastaFactura"
        Me.DateFechaEmitidaHastaFactura.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaEmitidaHastaFactura.TabIndex = 66
        '
        'DateFechaEmitidaDesdeFactura
        '
        Me.DateFechaEmitidaDesdeFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaEmitidaDesdeFactura.Location = New System.Drawing.Point(159, 63)
        Me.DateFechaEmitidaDesdeFactura.Name = "DateFechaEmitidaDesdeFactura"
        Me.DateFechaEmitidaDesdeFactura.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaEmitidaDesdeFactura.TabIndex = 65
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(16, 111)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(138, 16)
        Me.Label60.TabIndex = 64
        Me.Label60.Text = "Fecha Emitida Hasta: "
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(14, 64)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(140, 16)
        Me.Label61.TabIndex = 63
        Me.Label61.Text = "Fecha Emitida Desde:"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(12, 19)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(71, 16)
        Me.Label62.TabIndex = 62
        Me.Label62.Text = "ID Factura:"
        '
        'inputIdFactura
        '
        Me.inputIdFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdFactura.Location = New System.Drawing.Point(100, 19)
        Me.inputIdFactura.Name = "inputIdFactura"
        Me.inputIdFactura.Size = New System.Drawing.Size(172, 22)
        Me.inputIdFactura.TabIndex = 61
        '
        'comboEstadoFactura
        '
        Me.comboEstadoFactura.FormattingEnabled = True
        Me.comboEstadoFactura.Location = New System.Drawing.Point(105, 145)
        Me.comboEstadoFactura.Name = "comboEstadoFactura"
        Me.comboEstadoFactura.Size = New System.Drawing.Size(116, 24)
        Me.comboEstadoFactura.TabIndex = 60
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(25, 148)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(56, 16)
        Me.Label64.TabIndex = 59
        Me.Label64.Text = "Estado: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(382, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "Listo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FacturasEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 416)
        Me.Controls.Add(Me.Button1)
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
        Me.Controls.Add(Me.comboEstadoFactura)
        Me.Controls.Add(Me.Label64)
        Me.Name = "FacturasEdit"
        Me.Text = "FacturasEdit"
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
    Friend WithEvents comboEstadoFactura As ComboBox
    Friend WithEvents Label64 As Label
    Friend WithEvents Button1 As Button
End Class
