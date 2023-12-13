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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.comboIdPedido = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fechaPedidoHasta = New System.Windows.Forms.DateTimePicker()
        Me.fechaPedidoDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.comboIdArticulo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.pedidosTab.SuspendLayout()
        CType(Me.dataGridPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.articulosTab.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.pedidosTab)
        Me.TabControl1.Controls.Add(Me.articulosTab)
        Me.TabControl1.Controls.Add(Me.partnersTab)
        Me.TabControl1.Controls.Add(Me.comercialesTab)
        Me.TabControl1.Controls.Add(Me.facturasTab)
        Me.TabControl1.Controls.Add(Me.transportistasTab)
        Me.TabControl1.Controls.Add(Me.zonasTab)
        Me.TabControl1.Controls.Add(Me.categoriasSubcategoriasTab)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1068, 622)
        Me.TabControl1.TabIndex = 0
        '
        'pedidosTab
        '
        Me.pedidosTab.Controls.Add(Me.Button1)
        Me.pedidosTab.Controls.Add(Me.comboIdPedido)
        Me.pedidosTab.Controls.Add(Me.Label8)
        Me.pedidosTab.Controls.Add(Me.Label7)
        Me.pedidosTab.Controls.Add(Me.Label6)
        Me.pedidosTab.Controls.Add(Me.fechaPedidoHasta)
        Me.pedidosTab.Controls.Add(Me.fechaPedidoDesde)
        Me.pedidosTab.Controls.Add(Me.Label5)
        Me.pedidosTab.Controls.Add(Me.Label4)
        Me.pedidosTab.Controls.Add(Me.Label3)
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
        Me.pedidosTab.Padding = New System.Windows.Forms.Padding(3, 3, 3, 20)
        Me.pedidosTab.Size = New System.Drawing.Size(1060, 593)
        Me.pedidosTab.TabIndex = 2
        Me.pedidosTab.Text = "Pedidos"
        Me.pedidosTab.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(778, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 27)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'comboIdPedido
        '
        Me.comboIdPedido.FormattingEnabled = True
        Me.comboIdPedido.Location = New System.Drawing.Point(131, 27)
        Me.comboIdPedido.Name = "comboIdPedido"
        Me.comboIdPedido.Size = New System.Drawing.Size(184, 24)
        Me.comboIdPedido.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(707, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Factura:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(643, 33)
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
        Me.Label3.Location = New System.Drawing.Point(55, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ID Pedido:"
        '
        'comboPartner
        '
        Me.comboPartner.FormattingEnabled = True
        Me.comboPartner.Location = New System.Drawing.Point(448, 119)
        Me.comboPartner.Name = "comboPartner"
        Me.comboPartner.Size = New System.Drawing.Size(159, 24)
        Me.comboPartner.TabIndex = 7
        '
        'comboFactura
        '
        Me.comboFactura.FormattingEnabled = True
        Me.comboFactura.Location = New System.Drawing.Point(778, 71)
        Me.comboFactura.Name = "comboFactura"
        Me.comboFactura.Size = New System.Drawing.Size(159, 24)
        Me.comboFactura.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(778, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(159, 24)
        Me.ComboBox1.TabIndex = 5
        '
        'comboTransportista
        '
        Me.comboTransportista.FormattingEnabled = True
        Me.comboTransportista.Location = New System.Drawing.Point(448, 74)
        Me.comboTransportista.Name = "comboTransportista"
        Me.comboTransportista.Size = New System.Drawing.Size(159, 24)
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
        Me.dataGridPedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridPedidos.Location = New System.Drawing.Point(56, 189)
        Me.dataGridPedidos.Margin = New System.Windows.Forms.Padding(20)
        Me.dataGridPedidos.Name = "dataGridPedidos"
        Me.dataGridPedidos.RowHeadersWidth = 51
        Me.dataGridPedidos.RowTemplate.Height = 24
        Me.dataGridPedidos.Size = New System.Drawing.Size(947, 384)
        Me.dataGridPedidos.TabIndex = 2
        '
        'comboComercial
        '
        Me.comboComercial.FormattingEnabled = True
        Me.comboComercial.Location = New System.Drawing.Point(448, 29)
        Me.comboComercial.Name = "comboComercial"
        Me.comboComercial.Size = New System.Drawing.Size(159, 24)
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
        Me.articulosTab.Controls.Add(Me.Button2)
        Me.articulosTab.Controls.Add(Me.comboIdArticulo)
        Me.articulosTab.Controls.Add(Me.Label9)
        Me.articulosTab.Controls.Add(Me.Label10)
        Me.articulosTab.Controls.Add(Me.Label11)
        Me.articulosTab.Controls.Add(Me.Label12)
        Me.articulosTab.Controls.Add(Me.Label13)
        Me.articulosTab.Controls.Add(Me.Label14)
        Me.articulosTab.Controls.Add(Me.ComboBox3)
        Me.articulosTab.Controls.Add(Me.ComboBox4)
        Me.articulosTab.Controls.Add(Me.ComboBox5)
        Me.articulosTab.Controls.Add(Me.ComboBox6)
        Me.articulosTab.Controls.Add(Me.Label15)
        Me.articulosTab.Controls.Add(Me.DataGridView1)
        Me.articulosTab.Controls.Add(Me.ComboBox7)
        Me.articulosTab.Controls.Add(Me.Label16)
        Me.articulosTab.Location = New System.Drawing.Point(4, 25)
        Me.articulosTab.Name = "articulosTab"
        Me.articulosTab.Size = New System.Drawing.Size(1060, 593)
        Me.articulosTab.TabIndex = 3
        Me.articulosTab.Text = "Articulos"
        Me.articulosTab.UseVisualStyleBackColor = True
        '
        'partnersTab
        '
        Me.partnersTab.Location = New System.Drawing.Point(4, 25)
        Me.partnersTab.Name = "partnersTab"
        Me.partnersTab.Padding = New System.Windows.Forms.Padding(3)
        Me.partnersTab.Size = New System.Drawing.Size(1060, 593)
        Me.partnersTab.TabIndex = 1
        Me.partnersTab.Text = "Partners"
        Me.partnersTab.UseVisualStyleBackColor = True
        '
        'comercialesTab
        '
        Me.comercialesTab.Location = New System.Drawing.Point(4, 25)
        Me.comercialesTab.Name = "comercialesTab"
        Me.comercialesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.comercialesTab.Size = New System.Drawing.Size(1060, 593)
        Me.comercialesTab.TabIndex = 0
        Me.comercialesTab.Text = "Comerciales"
        Me.comercialesTab.UseVisualStyleBackColor = True
        '
        'facturasTab
        '
        Me.facturasTab.Location = New System.Drawing.Point(4, 25)
        Me.facturasTab.Name = "facturasTab"
        Me.facturasTab.Size = New System.Drawing.Size(1060, 593)
        Me.facturasTab.TabIndex = 4
        Me.facturasTab.Text = "Facturas"
        Me.facturasTab.UseVisualStyleBackColor = True
        '
        'transportistasTab
        '
        Me.transportistasTab.Location = New System.Drawing.Point(4, 25)
        Me.transportistasTab.Name = "transportistasTab"
        Me.transportistasTab.Size = New System.Drawing.Size(1060, 593)
        Me.transportistasTab.TabIndex = 6
        Me.transportistasTab.Text = "Transportistas"
        Me.transportistasTab.UseVisualStyleBackColor = True
        '
        'zonasTab
        '
        Me.zonasTab.Location = New System.Drawing.Point(4, 25)
        Me.zonasTab.Name = "zonasTab"
        Me.zonasTab.Size = New System.Drawing.Size(1060, 593)
        Me.zonasTab.TabIndex = 5
        Me.zonasTab.Text = "Zonas"
        Me.zonasTab.UseVisualStyleBackColor = True
        '
        'categoriasSubcategoriasTab
        '
        Me.categoriasSubcategoriasTab.Location = New System.Drawing.Point(4, 25)
        Me.categoriasSubcategoriasTab.Name = "categoriasSubcategoriasTab"
        Me.categoriasSubcategoriasTab.Size = New System.Drawing.Size(1060, 593)
        Me.categoriasSubcategoriasTab.TabIndex = 7
        Me.categoriasSubcategoriasTab.Text = "Categorias y subcategorias"
        Me.categoriasSubcategoriasTab.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(780, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 27)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'comboIdArticulo
        '
        Me.comboIdArticulo.FormattingEnabled = True
        Me.comboIdArticulo.Location = New System.Drawing.Point(133, 23)
        Me.comboIdArticulo.Name = "comboIdArticulo"
        Me.comboIdArticulo.Size = New System.Drawing.Size(184, 24)
        Me.comboIdArticulo.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(709, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Factura:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(645, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Estado de Pedido:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(391, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 16)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Partner:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(57, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Fecha Pedido Hasta: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(55, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Categoria: "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(57, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 16)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "ID Articulo:"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(450, 115)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(159, 24)
        Me.ComboBox3.TabIndex = 26
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(780, 67)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(159, 24)
        Me.ComboBox4.TabIndex = 25
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(780, 26)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(159, 24)
        Me.ComboBox5.TabIndex = 24
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(450, 70)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(159, 24)
        Me.ComboBox6.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(352, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 16)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Transportista: "
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(58, 185)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(947, 384)
        Me.DataGridView1.TabIndex = 21
        '
        'ComboBox7
        '
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(450, 25)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(159, 24)
        Me.ComboBox7.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(370, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 16)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Comercial: "
        '
        'Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1068, 622)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Consultas"
        Me.Text = "Consultas"
        Me.TabControl1.ResumeLayout(False)
        Me.pedidosTab.ResumeLayout(False)
        Me.pedidosTab.PerformLayout()
        CType(Me.dataGridPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.articulosTab.ResumeLayout(False)
        Me.articulosTab.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents comboIdPedido As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents comboIdArticulo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents Label16 As Label
End Class
