<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultas
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pedidosTab = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fechaPedidoHasta = New System.Windows.Forms.DateTimePicker()
        Me.fechaPedidoDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inputIdPedido = New System.Windows.Forms.TextBox()
        Me.comboPartner = New System.Windows.Forms.ComboBox()
        Me.comboFactura = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.comboTransportista = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dataGridPedidos = New System.Windows.Forms.DataGridView()
        Me.comboComercial = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.articulosTab = New System.Windows.Forms.TabPage()
        Me.partnersTab = New System.Windows.Forms.TabPage()
        Me.comercialesTab = New System.Windows.Forms.TabPage()
        Me.facturasTab = New System.Windows.Forms.TabPage()
        Me.transportistasTab = New System.Windows.Forms.TabPage()
        Me.zonasTab = New System.Windows.Forms.TabPage()
        Me.categoriasSubcategoriasTab = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.pedidosTab.SuspendLayout()
        CType(Me.dataGridPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.pedidosTab)
        Me.TabControl1.Controls.Add(Me.articulosTab)
        Me.TabControl1.Controls.Add(Me.partnersTab)
        Me.TabControl1.Controls.Add(Me.comercialesTab)
        Me.TabControl1.Controls.Add(Me.facturasTab)
        Me.TabControl1.Controls.Add(Me.transportistasTab)
        Me.TabControl1.Controls.Add(Me.zonasTab)
        Me.TabControl1.Controls.Add(Me.categoriasSubcategoriasTab)
        Me.TabControl1.Location = New System.Drawing.Point(40, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(999, 583)
        Me.TabControl1.TabIndex = 0
        '
        'pedidosTab
        '
        Me.pedidosTab.Controls.Add(Me.Button1)
        Me.pedidosTab.Controls.Add(Me.Label8)
        Me.pedidosTab.Controls.Add(Me.Label7)
        Me.pedidosTab.Controls.Add(Me.Label6)
        Me.pedidosTab.Controls.Add(Me.fechaPedidoHasta)
        Me.pedidosTab.Controls.Add(Me.fechaPedidoDesde)
        Me.pedidosTab.Controls.Add(Me.Label5)
        Me.pedidosTab.Controls.Add(Me.Label4)
        Me.pedidosTab.Controls.Add(Me.Label3)
        Me.pedidosTab.Controls.Add(Me.inputIdPedido)
        Me.pedidosTab.Controls.Add(Me.comboPartner)
        Me.pedidosTab.Controls.Add(Me.comboFactura)
        Me.pedidosTab.Controls.Add(Me.ComboBox1)
        Me.pedidosTab.Controls.Add(Me.comboTransportista)
        Me.pedidosTab.Controls.Add(Me.Label2)
        Me.pedidosTab.Controls.Add(Me.dataGridPedidos)
        Me.pedidosTab.Controls.Add(Me.comboComercial)
        Me.pedidosTab.Controls.Add(Me.Label1)
        Me.pedidosTab.Location = New System.Drawing.Point(4, 25)
        Me.pedidosTab.Name = "pedidosTab"
        Me.pedidosTab.Padding = New System.Windows.Forms.Padding(3)
        Me.pedidosTab.Size = New System.Drawing.Size(991, 554)
        Me.pedidosTab.TabIndex = 2
        Me.pedidosTab.Text = "Pedidos"
        Me.pedidosTab.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(657, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Factura:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(592, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Estado de Pedido:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(389, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Partner:"
        '
        'fechaPedidoHasta
        '
        Me.fechaPedidoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaPedidoHasta.Location = New System.Drawing.Point(198, 119)
        Me.fechaPedidoHasta.Name = "fechaPedidoHasta"
        Me.fechaPedidoHasta.Size = New System.Drawing.Size(117, 22)
        Me.fechaPedidoHasta.TabIndex = 13
        '
        'fechaPedidoDesde
        '
        Me.fechaPedidoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaPedidoDesde.Location = New System.Drawing.Point(198, 76)
        Me.fechaPedidoDesde.Name = "fechaPedidoDesde"
        Me.fechaPedidoDesde.Size = New System.Drawing.Size(117, 22)
        Me.fechaPedidoDesde.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fecha Pedido Hasta: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Fecha Pedido Desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ID Pedido:"
        '
        'inputIdPedido
        '
        Me.inputIdPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdPedido.Location = New System.Drawing.Point(143, 29)
        Me.inputIdPedido.Name = "inputIdPedido"
        Me.inputIdPedido.Size = New System.Drawing.Size(172, 22)
        Me.inputIdPedido.TabIndex = 8
        '
        'comboPartner
        '
        Me.comboPartner.FormattingEnabled = True
        Me.comboPartner.Location = New System.Drawing.Point(448, 119)
        Me.comboPartner.Name = "comboPartner"
        Me.comboPartner.Size = New System.Drawing.Size(116, 24)
        Me.comboPartner.TabIndex = 7
        '
        'comboFactura
        '
        Me.comboFactura.FormattingEnabled = True
        Me.comboFactura.Location = New System.Drawing.Point(721, 106)
        Me.comboFactura.Name = "comboFactura"
        Me.comboFactura.Size = New System.Drawing.Size(121, 24)
        Me.comboFactura.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(721, 52)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 5
        '
        'comboTransportista
        '
        Me.comboTransportista.FormattingEnabled = True
        Me.comboTransportista.Location = New System.Drawing.Point(448, 74)
        Me.comboTransportista.Name = "comboTransportista"
        Me.comboTransportista.Size = New System.Drawing.Size(116, 24)
        Me.comboTransportista.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(350, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Transportista: "
        '
        'dataGridPedidos
        '
        Me.dataGridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridPedidos.Location = New System.Drawing.Point(56, 176)
        Me.dataGridPedidos.Name = "dataGridPedidos"
        Me.dataGridPedidos.RowHeadersWidth = 51
        Me.dataGridPedidos.RowTemplate.Height = 24
        Me.dataGridPedidos.Size = New System.Drawing.Size(797, 346)
        Me.dataGridPedidos.TabIndex = 2
        '
        'comboComercial
        '
        Me.comboComercial.FormattingEnabled = True
        Me.comboComercial.Location = New System.Drawing.Point(448, 29)
        Me.comboComercial.Name = "comboComercial"
        Me.comboComercial.Size = New System.Drawing.Size(116, 24)
        Me.comboComercial.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(368, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Comercial: "
        '
        'articulosTab
        '
        Me.articulosTab.Location = New System.Drawing.Point(4, 25)
        Me.articulosTab.Name = "articulosTab"
        Me.articulosTab.Size = New System.Drawing.Size(991, 554)
        Me.articulosTab.TabIndex = 3
        Me.articulosTab.Text = "Articulos"
        Me.articulosTab.UseVisualStyleBackColor = True
        '
        'partnersTab
        '
        Me.partnersTab.Location = New System.Drawing.Point(4, 25)
        Me.partnersTab.Name = "partnersTab"
        Me.partnersTab.Padding = New System.Windows.Forms.Padding(3)
        Me.partnersTab.Size = New System.Drawing.Size(991, 554)
        Me.partnersTab.TabIndex = 1
        Me.partnersTab.Text = "Partners"
        Me.partnersTab.UseVisualStyleBackColor = True
        '
        'comercialesTab
        '
        Me.comercialesTab.Location = New System.Drawing.Point(4, 25)
        Me.comercialesTab.Name = "comercialesTab"
        Me.comercialesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.comercialesTab.Size = New System.Drawing.Size(991, 554)
        Me.comercialesTab.TabIndex = 0
        Me.comercialesTab.Text = "Comerciales"
        Me.comercialesTab.UseVisualStyleBackColor = True
        '
        'facturasTab
        '
        Me.facturasTab.Location = New System.Drawing.Point(4, 25)
        Me.facturasTab.Name = "facturasTab"
        Me.facturasTab.Size = New System.Drawing.Size(991, 554)
        Me.facturasTab.TabIndex = 4
        Me.facturasTab.Text = "Facturas"
        Me.facturasTab.UseVisualStyleBackColor = True
        '
        'transportistasTab
        '
        Me.transportistasTab.Location = New System.Drawing.Point(4, 25)
        Me.transportistasTab.Name = "transportistasTab"
        Me.transportistasTab.Size = New System.Drawing.Size(991, 554)
        Me.transportistasTab.TabIndex = 6
        Me.transportistasTab.Text = "Transportistas"
        Me.transportistasTab.UseVisualStyleBackColor = True
        '
        'zonasTab
        '
        Me.zonasTab.Location = New System.Drawing.Point(4, 25)
        Me.zonasTab.Name = "zonasTab"
        Me.zonasTab.Size = New System.Drawing.Size(991, 554)
        Me.zonasTab.TabIndex = 5
        Me.zonasTab.Text = "Zonas"
        Me.zonasTab.UseVisualStyleBackColor = True
        '
        'categoriasSubcategoriasTab
        '
        Me.categoriasSubcategoriasTab.Location = New System.Drawing.Point(4, 25)
        Me.categoriasSubcategoriasTab.Name = "categoriasSubcategoriasTab"
        Me.categoriasSubcategoriasTab.Size = New System.Drawing.Size(991, 554)
        Me.categoriasSubcategoriasTab.TabIndex = 7
        Me.categoriasSubcategoriasTab.Text = "Categorias y subcategorias"
        Me.categoriasSubcategoriasTab.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(892, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1347, 674)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Consultas"
        Me.Text = "Consultas"
        Me.TabControl1.ResumeLayout(False)
        Me.pedidosTab.ResumeLayout(False)
        Me.pedidosTab.PerformLayout()
        CType(Me.dataGridPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents comercialesTab As TabPage
    Friend WithEvents partnersTab As TabPage
    Friend WithEvents pedidosTab As TabPage
    Friend WithEvents articulosTab As TabPage
    Friend WithEvents facturasTab As TabPage
    Friend WithEvents transportistasTab As TabPage
    Friend WithEvents zonasTab As TabPage
    Friend WithEvents categoriasSubcategoriasTab As TabPage
    Friend WithEvents dataGridPedidos As DataGridView
    Friend WithEvents comboComercial As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents inputIdPedido As TextBox
    Friend WithEvents comboPartner As ComboBox
    Friend WithEvents comboFactura As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents comboTransportista As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents fechaPedidoDesde As DateTimePicker
    Friend WithEvents fechaPedidoHasta As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
