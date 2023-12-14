<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelGestion = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker6 = New System.Windows.Forms.DateTimePicker()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.ComboBox10 = New System.Windows.Forms.ComboBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.DateFechaPedidoDesde = New System.Windows.Forms.DateTimePicker()
        Me.DateFechaPedidoHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.DateFechaEnvioDesde = New System.Windows.Forms.DateTimePicker()
        Me.DateFechaEnvioHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.DateFechaPagoDesde = New System.Windows.Forms.DateTimePicker()
        Me.DateFechaPagoHasta = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelGestion.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionToolStripMenuItem, Me.PedidosToolStripMenuItem, Me.FacturasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1394, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.GestionToolStripMenuItem.Text = "Gestion"
        '
        'PedidosToolStripMenuItem
        '
        Me.PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
        Me.PedidosToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.PedidosToolStripMenuItem.Text = "Pedidos"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PanelGestion
        '
        Me.PanelGestion.Controls.Add(Me.Panel2)
        Me.PanelGestion.Controls.Add(Me.Panel1)
        Me.PanelGestion.Location = New System.Drawing.Point(12, 31)
        Me.PanelGestion.Name = "PanelGestion"
        Me.PanelGestion.Size = New System.Drawing.Size(1382, 839)
        Me.PanelGestion.TabIndex = 71
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.Panel2.Controls.Add(Me.Label53)
        Me.Panel2.Controls.Add(Me.Label54)
        Me.Panel2.Controls.Add(Me.DateTimePicker3)
        Me.Panel2.Controls.Add(Me.DateTimePicker4)
        Me.Panel2.Controls.Add(Me.Label55)
        Me.Panel2.Controls.Add(Me.Label56)
        Me.Panel2.Controls.Add(Me.DateTimePicker5)
        Me.Panel2.Controls.Add(Me.DateTimePicker6)
        Me.Panel2.Controls.Add(Me.Label60)
        Me.Panel2.Controls.Add(Me.Label61)
        Me.Panel2.Controls.Add(Me.Label62)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.DataGridView6)
        Me.Panel2.Controls.Add(Me.ComboBox10)
        Me.Panel2.Controls.Add(Me.Label64)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1379, 833)
        Me.Panel2.TabIndex = 84
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker5.Location = New System.Drawing.Point(184, 121)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(117, 22)
        Me.DateTimePicker5.TabIndex = 30
        '
        'DateTimePicker6
        '
        Me.DateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker6.Location = New System.Drawing.Point(184, 78)
        Me.DateTimePicker6.Name = "DateTimePicker6"
        Me.DateTimePicker6.Size = New System.Drawing.Size(117, 22)
        Me.DateTimePicker6.TabIndex = 29
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(41, 126)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(137, 16)
        Me.Label60.TabIndex = 28
        Me.Label60.Text = "Fecha Pedido Hasta: "
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(39, 79)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(139, 16)
        Me.Label61.TabIndex = 27
        Me.Label61.Text = "Fecha Pedido Desde:"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(37, 34)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(71, 16)
        Me.Label62.TabIndex = 26
        Me.Label62.Text = "ID Factura:"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(125, 34)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(172, 22)
        Me.TextBox2.TabIndex = 25
        '
        'DataGridView6
        '
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Location = New System.Drawing.Point(38, 181)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.RowHeadersWidth = 51
        Me.DataGridView6.RowTemplate.Height = 24
        Me.DataGridView6.Size = New System.Drawing.Size(1288, 576)
        Me.DataGridView6.TabIndex = 19
        '
        'ComboBox10
        '
        Me.ComboBox10.FormattingEnabled = True
        Me.ComboBox10.Location = New System.Drawing.Point(432, 34)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(116, 24)
        Me.ComboBox10.TabIndex = 18
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(352, 37)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(56, 16)
        Me.Label64.TabIndex = 17
        Me.Label64.Text = "Estado: "
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(352, 79)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(129, 16)
        Me.Label56.TabIndex = 34
        Me.Label56.Text = "Fecha Envio Desde:"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(354, 126)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(127, 16)
        Me.Label55.TabIndex = 35
        Me.Label55.Text = "Fecha Envio Hasta: "
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker4.Location = New System.Drawing.Point(497, 78)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(117, 22)
        Me.DateTimePicker4.TabIndex = 36
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(497, 121)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(117, 22)
        Me.DateTimePicker3.TabIndex = 37
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(632, 79)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(128, 16)
        Me.Label54.TabIndex = 38
        Me.Label54.Text = "Fecha Pago Desde:"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(634, 126)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(126, 16)
        Me.Label53.TabIndex = 39
        Me.Label53.Text = "Fecha Pago Hasta: "
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(777, 78)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(117, 22)
        Me.DateTimePicker2.TabIndex = 40
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(777, 121)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(117, 22)
        Me.DateTimePicker1.TabIndex = 41
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(352, 34)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(74, 16)
        Me.Label48.TabIndex = 17
        Me.Label48.Text = "Comercial: "
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(432, 31)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(116, 24)
        Me.ComboBox5.TabIndex = 18
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(38, 181)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.RowHeadersWidth = 51
        Me.DataGridView5.RowTemplate.Height = 24
        Me.DataGridView5.Size = New System.Drawing.Size(1288, 576)
        Me.DataGridView5.TabIndex = 19
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(613, 37)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(92, 16)
        Me.Label47.TabIndex = 20
        Me.Label47.Text = "Transportista: "
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(711, 32)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(116, 24)
        Me.ComboBox4.TabIndex = 21
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(1051, 75)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox3.TabIndex = 22
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(1051, 119)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox2.TabIndex = 23
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(948, 34)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(116, 24)
        Me.ComboBox1.TabIndex = 24
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(125, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(172, 22)
        Me.TextBox1.TabIndex = 25
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(37, 34)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(70, 16)
        Me.Label45.TabIndex = 26
        Me.Label45.Text = "ID Pedido:"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(39, 79)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(139, 16)
        Me.Label44.TabIndex = 27
        Me.Label44.Text = "Fecha Pedido Desde:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(41, 126)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(137, 16)
        Me.Label43.TabIndex = 28
        Me.Label43.Text = "Fecha Pedido Hasta: "
        '
        'DateFechaPedidoDesde
        '
        Me.DateFechaPedidoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaPedidoDesde.Location = New System.Drawing.Point(184, 78)
        Me.DateFechaPedidoDesde.Name = "DateFechaPedidoDesde"
        Me.DateFechaPedidoDesde.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaPedidoDesde.TabIndex = 29
        '
        'DateFechaPedidoHasta
        '
        Me.DateFechaPedidoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaPedidoHasta.Location = New System.Drawing.Point(184, 121)
        Me.DateFechaPedidoHasta.Name = "DateFechaPedidoHasta"
        Me.DateFechaPedidoHasta.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaPedidoHasta.TabIndex = 30
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(889, 38)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(53, 16)
        Me.Label42.TabIndex = 31
        Me.Label42.Text = "Partner:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(922, 79)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(119, 16)
        Me.Label41.TabIndex = 32
        Me.Label41.Text = "Estado de Pedido:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(921, 122)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(55, 16)
        Me.Label40.TabIndex = 33
        Me.Label40.Text = "Factura:"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(352, 79)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(129, 16)
        Me.Label50.TabIndex = 34
        Me.Label50.Text = "Fecha Envio Desde:"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(354, 126)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(127, 16)
        Me.Label49.TabIndex = 35
        Me.Label49.Text = "Fecha Envio Hasta: "
        '
        'DateFechaEnvioDesde
        '
        Me.DateFechaEnvioDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaEnvioDesde.Location = New System.Drawing.Point(497, 78)
        Me.DateFechaEnvioDesde.Name = "DateFechaEnvioDesde"
        Me.DateFechaEnvioDesde.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaEnvioDesde.TabIndex = 36
        '
        'DateFechaEnvioHasta
        '
        Me.DateFechaEnvioHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaEnvioHasta.Location = New System.Drawing.Point(497, 121)
        Me.DateFechaEnvioHasta.Name = "DateFechaEnvioHasta"
        Me.DateFechaEnvioHasta.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaEnvioHasta.TabIndex = 37
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(632, 79)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(128, 16)
        Me.Label52.TabIndex = 38
        Me.Label52.Text = "Fecha Pago Desde:"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(634, 126)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(126, 16)
        Me.Label51.TabIndex = 39
        Me.Label51.Text = "Fecha Pago Hasta: "
        '
        'DateFechaPagoDesde
        '
        Me.DateFechaPagoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaPagoDesde.Location = New System.Drawing.Point(777, 78)
        Me.DateFechaPagoDesde.Name = "DateFechaPagoDesde"
        Me.DateFechaPagoDesde.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaPagoDesde.TabIndex = 40
        '
        'DateFechaPagoHasta
        '
        Me.DateFechaPagoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFechaPagoHasta.Location = New System.Drawing.Point(777, 121)
        Me.DateFechaPagoHasta.Name = "DateFechaPagoHasta"
        Me.DateFechaPagoHasta.Size = New System.Drawing.Size(117, 22)
        Me.DateFechaPagoHasta.TabIndex = 41
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DateFechaPagoHasta)
        Me.Panel1.Controls.Add(Me.DateFechaPagoDesde)
        Me.Panel1.Controls.Add(Me.Label51)
        Me.Panel1.Controls.Add(Me.Label52)
        Me.Panel1.Controls.Add(Me.DateFechaEnvioHasta)
        Me.Panel1.Controls.Add(Me.DateFechaEnvioDesde)
        Me.Panel1.Controls.Add(Me.Label49)
        Me.Panel1.Controls.Add(Me.Label50)
        Me.Panel1.Controls.Add(Me.Label40)
        Me.Panel1.Controls.Add(Me.Label41)
        Me.Panel1.Controls.Add(Me.Label42)
        Me.Panel1.Controls.Add(Me.DateFechaPedidoHasta)
        Me.Panel1.Controls.Add(Me.DateFechaPedidoDesde)
        Me.Panel1.Controls.Add(Me.Label43)
        Me.Panel1.Controls.Add(Me.Label44)
        Me.Panel1.Controls.Add(Me.Label45)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.ComboBox4)
        Me.Panel1.Controls.Add(Me.Label47)
        Me.Panel1.Controls.Add(Me.DataGridView5)
        Me.Panel1.Controls.Add(Me.ComboBox5)
        Me.Panel1.Controls.Add(Me.Label48)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1379, 833)
        Me.Panel1.TabIndex = 83
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1394, 872)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PanelGestion)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelGestion.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelGestion As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateTimePicker5 As DateTimePicker
    Friend WithEvents DateTimePicker6 As DateTimePicker
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents ComboBox10 As ComboBox
    Friend WithEvents Label64 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateFechaPagoHasta As DateTimePicker
    Friend WithEvents DateFechaPagoDesde As DateTimePicker
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents DateFechaEnvioHasta As DateTimePicker
    Friend WithEvents DateFechaEnvioDesde As DateTimePicker
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents DateFechaPedidoHasta As DateTimePicker
    Friend WithEvents DateFechaPedidoDesde As DateTimePicker
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label47 As Label
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label48 As Label
End Class
