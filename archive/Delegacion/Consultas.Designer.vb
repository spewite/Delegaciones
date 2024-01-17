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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.inputIdPedidos = New System.Windows.Forms.TextBox()
        Me.comboPartnerPedidos = New System.Windows.Forms.ComboBox()
        Me.comboFacturaPedidos = New System.Windows.Forms.ComboBox()
        Me.comboEstadoPedidos = New System.Windows.Forms.ComboBox()
        Me.comboTransportistaPedidos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dataGridPedidos = New System.Windows.Forms.DataGridView()
        Me.comboComercialPedidos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.articulosTab = New System.Windows.Forms.TabPage()
        Me.inputBajoMinimoArticulos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.inputSobreMaximoArticulos = New System.Windows.Forms.TextBox()
        Me.inputExistenciasArticulos = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.inputPrCostArticulos = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.inputPrVentArticulos = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.inputProveedorArticulos = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.inputDescripcionArticulos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inputNombreArticulos = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.inputIdArticulo = New System.Windows.Forms.TextBox()
        Me.comboSubCategoriaArticulos = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.comboCategoriaArticulos = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.partnersTab = New System.Windows.Forms.TabPage()
        Me.comboZonaPartners = New System.Windows.Forms.ComboBox()
        Me.inputFechaRegistroPartner = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.inputCorreoPartner = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.inputTelefonoPartner = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.inputDireccionPartner = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.inputCifPartner = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.inputNombrePartner = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.inputIdPartner = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.comercialesTab = New System.Windows.Forms.TabPage()
        Me.inputBajoMinimoComercial = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.inputSobreMaximoComercial = New System.Windows.Forms.TextBox()
        Me.inputExistenciasComercial = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.inputPrCostComercial = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.inputPrVentComercial = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.inputTelefonoComercial = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.inputApellidosComercial = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.inputNombreComercial = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.inputIdComercial = New System.Windows.Forms.TextBox()
        Me.comboZona2Comerciales = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.comboZonaComerciales = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.facturasTab = New System.Windows.Forms.TabPage()
        Me.transportistasTab = New System.Windows.Forms.TabPage()
        Me.zonasTab = New System.Windows.Forms.TabPage()
        Me.categoriasSubcategoriasTab = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.pedidosTab.SuspendLayout()
        CType(Me.dataGridPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.articulosTab.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.partnersTab.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.comercialesTab.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Location = New System.Drawing.Point(40, 26)
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
        Me.pedidosTab.Controls.Add(Me.Label5)
        Me.pedidosTab.Controls.Add(Me.Label4)
        Me.pedidosTab.Controls.Add(Me.Label)
        Me.pedidosTab.Controls.Add(Me.inputIdPedidos)
        Me.pedidosTab.Controls.Add(Me.comboPartnerPedidos)
        Me.pedidosTab.Controls.Add(Me.comboFacturaPedidos)
        Me.pedidosTab.Controls.Add(Me.comboEstadoPedidos)
        Me.pedidosTab.Controls.Add(Me.comboTransportistaPedidos)
        Me.pedidosTab.Controls.Add(Me.Label2)
        Me.pedidosTab.Controls.Add(Me.dataGridPedidos)
        Me.pedidosTab.Controls.Add(Me.comboComercialPedidos)
        Me.pedidosTab.Controls.Add(Me.Label1)
        Me.pedidosTab.Location = New System.Drawing.Point(4, 25)
        Me.pedidosTab.Name = "pedidosTab"
        Me.pedidosTab.Padding = New System.Windows.Forms.Padding(3)
        Me.pedidosTab.Size = New System.Drawing.Size(991, 554)
        Me.pedidosTab.TabIndex = 2
        Me.pedidosTab.Text = "Pedidos"
        Me.pedidosTab.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(887, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "benito"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(587, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Factura:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(588, 80)
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
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(55, 29)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(70, 16)
        Me.Label.TabIndex = 9
        Me.Label.Text = "ID Pedido:"
        '
        'inputIdPedidos
        '
        Me.inputIdPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdPedidos.Location = New System.Drawing.Point(143, 29)
        Me.inputIdPedidos.Name = "inputIdPedidos"
        Me.inputIdPedidos.Size = New System.Drawing.Size(172, 22)
        Me.inputIdPedidos.TabIndex = 8
        '
        'comboPartnerPedidos
        '
        Me.comboPartnerPedidos.FormattingEnabled = True
        Me.comboPartnerPedidos.Location = New System.Drawing.Point(448, 119)
        Me.comboPartnerPedidos.Name = "comboPartnerPedidos"
        Me.comboPartnerPedidos.Size = New System.Drawing.Size(116, 24)
        Me.comboPartnerPedidos.TabIndex = 7
        '
        'comboIdFacturaPedidos
        '
        Me.comboFacturaPedidos.FormattingEnabled = True
        Me.comboFacturaPedidos.Location = New System.Drawing.Point(717, 120)
        Me.comboFacturaPedidos.Name = "comboFacturaPedidos"
        Me.comboFacturaPedidos.Size = New System.Drawing.Size(121, 24)
        Me.comboFacturaPedidos.TabIndex = 6
        '
        'comboEstadoPedidos
        '
        Me.comboEstadoPedidos.FormattingEnabled = True
        Me.comboEstadoPedidos.Location = New System.Drawing.Point(717, 76)
        Me.comboEstadoPedidos.Name = "comboEstadoPedidos"
        Me.comboEstadoPedidos.Size = New System.Drawing.Size(121, 24)
        Me.comboEstadoPedidos.TabIndex = 5
        '
        'comboTransportistaPedidos
        '
        Me.comboTransportistaPedidos.FormattingEnabled = True
        Me.comboTransportistaPedidos.Location = New System.Drawing.Point(448, 74)
        Me.comboTransportistaPedidos.Name = "comboTransportistaPedidos"
        Me.comboTransportistaPedidos.Size = New System.Drawing.Size(116, 24)
        Me.comboTransportistaPedidos.TabIndex = 4
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
        'comboComercialPedidos
        '
        Me.comboComercialPedidos.FormattingEnabled = True
        Me.comboComercialPedidos.Location = New System.Drawing.Point(448, 29)
        Me.comboComercialPedidos.Name = "comboComercialPedidos"
        Me.comboComercialPedidos.Size = New System.Drawing.Size(116, 24)
        Me.comboComercialPedidos.TabIndex = 1
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
        Me.articulosTab.Controls.Add(Me.inputBajoMinimoArticulos)
        Me.articulosTab.Controls.Add(Me.Label9)
        Me.articulosTab.Controls.Add(Me.inputSobreMaximoArticulos)
        Me.articulosTab.Controls.Add(Me.inputExistenciasArticulos)
        Me.articulosTab.Controls.Add(Me.Label18)
        Me.articulosTab.Controls.Add(Me.inputPrCostArticulos)
        Me.articulosTab.Controls.Add(Me.Label12)
        Me.articulosTab.Controls.Add(Me.inputPrVentArticulos)
        Me.articulosTab.Controls.Add(Me.Label17)
        Me.articulosTab.Controls.Add(Me.inputProveedorArticulos)
        Me.articulosTab.Controls.Add(Me.Label10)
        Me.articulosTab.Controls.Add(Me.inputDescripcionArticulos)
        Me.articulosTab.Controls.Add(Me.Label3)
        Me.articulosTab.Controls.Add(Me.inputNombreArticulos)
        Me.articulosTab.Controls.Add(Me.Label11)
        Me.articulosTab.Controls.Add(Me.Label13)
        Me.articulosTab.Controls.Add(Me.Label14)
        Me.articulosTab.Controls.Add(Me.inputIdArticulo)
        Me.articulosTab.Controls.Add(Me.comboSubCategoriaArticulos)
        Me.articulosTab.Controls.Add(Me.Label15)
        Me.articulosTab.Controls.Add(Me.DataGridView1)
        Me.articulosTab.Controls.Add(Me.comboCategoriaArticulos)
        Me.articulosTab.Controls.Add(Me.Label16)
        Me.articulosTab.Location = New System.Drawing.Point(4, 25)
        Me.articulosTab.Name = "articulosTab"
        Me.articulosTab.Size = New System.Drawing.Size(991, 554)
        Me.articulosTab.TabIndex = 3
        Me.articulosTab.Text = "Articulos"
        Me.articulosTab.UseVisualStyleBackColor = True
        '
        'inputBajoMinimoArticulos
        '
        Me.inputBajoMinimoArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputBajoMinimoArticulos.Location = New System.Drawing.Point(770, 115)
        Me.inputBajoMinimoArticulos.Name = "inputBajoMinimoArticulos"
        Me.inputBajoMinimoArticulos.Size = New System.Drawing.Size(83, 22)
        Me.inputBajoMinimoArticulos.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(657, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 16)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Bajo Minimo"
        '
        'inputSobreMaximoArticulos
        '
        Me.inputSobreMaximoArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputSobreMaximoArticulos.Location = New System.Drawing.Point(563, 115)
        Me.inputSobreMaximoArticulos.Name = "inputSobreMaximoArticulos"
        Me.inputSobreMaximoArticulos.Size = New System.Drawing.Size(83, 22)
        Me.inputSobreMaximoArticulos.TabIndex = 45
        '
        'inputExistenciasArticulos
        '
        Me.inputExistenciasArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputExistenciasArticulos.Location = New System.Drawing.Point(326, 115)
        Me.inputExistenciasArticulos.Name = "inputExistenciasArticulos"
        Me.inputExistenciasArticulos.Size = New System.Drawing.Size(83, 22)
        Me.inputExistenciasArticulos.TabIndex = 44
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(222, 117)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 16)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Existencias"
        '
        'inputPrCostArticulos
        '
        Me.inputPrCostArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPrCostArticulos.Location = New System.Drawing.Point(133, 113)
        Me.inputPrCostArticulos.Name = "inputPrCostArticulos"
        Me.inputPrCostArticulos.Size = New System.Drawing.Size(83, 22)
        Me.inputPrCostArticulos.TabIndex = 42
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(55, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 16)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "PrCost"
        '
        'inputPrVentArticulos
        '
        Me.inputPrVentArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPrVentArticulos.Location = New System.Drawing.Point(770, 73)
        Me.inputPrVentArticulos.Name = "inputPrVentArticulos"
        Me.inputPrVentArticulos.Size = New System.Drawing.Size(83, 22)
        Me.inputPrVentArticulos.TabIndex = 40
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(657, 73)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 16)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "PrVent:"
        '
        'inputProveedorArticulos
        '
        Me.inputProveedorArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputProveedorArticulos.Location = New System.Drawing.Point(563, 71)
        Me.inputProveedorArticulos.Name = "inputProveedorArticulos"
        Me.inputProveedorArticulos.Size = New System.Drawing.Size(83, 22)
        Me.inputProveedorArticulos.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(447, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 16)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Proveedor:"
        '
        'inputDescripcionArticulos
        '
        Me.inputDescripcionArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputDescripcionArticulos.Location = New System.Drawing.Point(326, 71)
        Me.inputDescripcionArticulos.Name = "inputDescripcionArticulos"
        Me.inputDescripcionArticulos.Size = New System.Drawing.Size(83, 22)
        Me.inputDescripcionArticulos.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Descripción:"
        '
        'inputNombreArticulos
        '
        Me.inputNombreArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNombreArticulos.Location = New System.Drawing.Point(133, 71)
        Me.inputNombreArticulos.Name = "inputNombreArticulos"
        Me.inputNombreArticulos.Size = New System.Drawing.Size(83, 22)
        Me.inputNombreArticulos.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(447, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 16)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Sobre Maximo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(55, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 16)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Nombre:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(55, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 16)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "ID Articulo:"
        '
        'inputIdArticulo
        '
        Me.inputIdArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdArticulo.Location = New System.Drawing.Point(133, 26)
        Me.inputIdArticulo.Name = "inputIdArticulo"
        Me.inputIdArticulo.Size = New System.Drawing.Size(79, 22)
        Me.inputIdArticulo.TabIndex = 25
        '
        'comboSubCategoriaArticulos
        '
        Me.comboSubCategoriaArticulos.FormattingEnabled = True
        Me.comboSubCategoriaArticulos.Location = New System.Drawing.Point(563, 25)
        Me.comboSubCategoriaArticulos.Name = "comboSubCategoriaArticulos"
        Me.comboSubCategoriaArticulos.Size = New System.Drawing.Size(116, 24)
        Me.comboSubCategoriaArticulos.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(447, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 16)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "SubCategoria:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(56, 176)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(797, 346)
        Me.DataGridView1.TabIndex = 19
        '
        'comboCategoriaArticulos
        '
        Me.comboCategoriaArticulos.FormattingEnabled = True
        Me.comboCategoriaArticulos.Location = New System.Drawing.Point(326, 24)
        Me.comboCategoriaArticulos.Name = "comboCategoriaArticulos"
        Me.comboCategoriaArticulos.Size = New System.Drawing.Size(100, 24)
        Me.comboCategoriaArticulos.TabIndex = 18
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(222, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 16)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Categoria:"
        '
        'partnersTab
        '
        Me.partnersTab.Controls.Add(Me.comboZonaPartners)
        Me.partnersTab.Controls.Add(Me.inputFechaRegistroPartner)
        Me.partnersTab.Controls.Add(Me.Label20)
        Me.partnersTab.Controls.Add(Me.inputCorreoPartner)
        Me.partnersTab.Controls.Add(Me.Label21)
        Me.partnersTab.Controls.Add(Me.inputTelefonoPartner)
        Me.partnersTab.Controls.Add(Me.Label22)
        Me.partnersTab.Controls.Add(Me.inputDireccionPartner)
        Me.partnersTab.Controls.Add(Me.Label23)
        Me.partnersTab.Controls.Add(Me.inputCifPartner)
        Me.partnersTab.Controls.Add(Me.Label25)
        Me.partnersTab.Controls.Add(Me.inputNombrePartner)
        Me.partnersTab.Controls.Add(Me.Label28)
        Me.partnersTab.Controls.Add(Me.Label27)
        Me.partnersTab.Controls.Add(Me.Label24)
        Me.partnersTab.Controls.Add(Me.inputIdPartner)
        Me.partnersTab.Controls.Add(Me.DataGridView2)
        Me.partnersTab.Location = New System.Drawing.Point(4, 25)
        Me.partnersTab.Name = "partnersTab"
        Me.partnersTab.Padding = New System.Windows.Forms.Padding(3)
        Me.partnersTab.Size = New System.Drawing.Size(991, 554)
        Me.partnersTab.TabIndex = 1
        Me.partnersTab.Text = "Partners"
        Me.partnersTab.UseVisualStyleBackColor = True
        '
        'comboZonaPartners
        '
        Me.comboZonaPartners.FormattingEnabled = True
        Me.comboZonaPartners.Location = New System.Drawing.Point(421, 27)
        Me.comboZonaPartners.Name = "comboZonaPartners"
        Me.comboZonaPartners.Size = New System.Drawing.Size(100, 24)
        Me.comboZonaPartners.TabIndex = 64
        '
        'inputFechaRegistroPartner
        '
        Me.inputFechaRegistroPartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputFechaRegistroPartner.Location = New System.Drawing.Point(326, 108)
        Me.inputFechaRegistroPartner.Name = "inputFechaRegistroPartner"
        Me.inputFechaRegistroPartner.Size = New System.Drawing.Size(83, 22)
        Me.inputFechaRegistroPartner.TabIndex = 60
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(222, 110)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(99, 16)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Fecha Registro"
        '
        'inputCorreoPartner
        '
        Me.inputCorreoPartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputCorreoPartner.Location = New System.Drawing.Point(133, 106)
        Me.inputCorreoPartner.Name = "inputCorreoPartner"
        Me.inputCorreoPartner.Size = New System.Drawing.Size(83, 22)
        Me.inputCorreoPartner.TabIndex = 58
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(55, 108)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 16)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "Correo"
        '
        'inputTelefonoPartner
        '
        Me.inputTelefonoPartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputTelefonoPartner.Location = New System.Drawing.Point(770, 66)
        Me.inputTelefonoPartner.Name = "inputTelefonoPartner"
        Me.inputTelefonoPartner.Size = New System.Drawing.Size(83, 22)
        Me.inputTelefonoPartner.TabIndex = 56
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(657, 66)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(61, 16)
        Me.Label22.TabIndex = 55
        Me.Label22.Text = "Telefono"
        '
        'inputDireccionPartner
        '
        Me.inputDireccionPartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputDireccionPartner.Location = New System.Drawing.Point(563, 64)
        Me.inputDireccionPartner.Name = "inputDireccionPartner"
        Me.inputDireccionPartner.Size = New System.Drawing.Size(83, 22)
        Me.inputDireccionPartner.TabIndex = 54
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(447, 66)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 16)
        Me.Label23.TabIndex = 53
        Me.Label23.Text = "Direccion"
        '
        'inputCifPartner
        '
        Me.inputCifPartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputCifPartner.Location = New System.Drawing.Point(326, 64)
        Me.inputCifPartner.Name = "inputCifPartner"
        Me.inputCifPartner.Size = New System.Drawing.Size(83, 22)
        Me.inputCifPartner.TabIndex = 52
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(222, 66)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(30, 16)
        Me.Label25.TabIndex = 51
        Me.Label25.Text = "CIF:"
        '
        'inputNombrePartner
        '
        Me.inputNombrePartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNombrePartner.Location = New System.Drawing.Point(133, 64)
        Me.inputNombrePartner.Name = "inputNombrePartner"
        Me.inputNombrePartner.Size = New System.Drawing.Size(83, 22)
        Me.inputNombrePartner.TabIndex = 50
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(55, 66)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(59, 16)
        Me.Label28.TabIndex = 48
        Me.Label28.Text = "Nombre:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(350, 29)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(57, 16)
        Me.Label27.TabIndex = 35
        Me.Label27.Text = "ID Zona:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(55, 29)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(69, 16)
        Me.Label24.TabIndex = 26
        Me.Label24.Text = "ID Partner:"
        '
        'inputIdPartner
        '
        Me.inputIdPartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdPartner.Location = New System.Drawing.Point(133, 27)
        Me.inputIdPartner.Name = "inputIdPartner"
        Me.inputIdPartner.Size = New System.Drawing.Size(172, 22)
        Me.inputIdPartner.TabIndex = 25
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(56, 176)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(797, 346)
        Me.DataGridView2.TabIndex = 19
        '
        'comercialesTab
        '
        Me.comercialesTab.Controls.Add(Me.inputBajoMinimoComercial)
        Me.comercialesTab.Controls.Add(Me.Label19)
        Me.comercialesTab.Controls.Add(Me.inputSobreMaximoComercial)
        Me.comercialesTab.Controls.Add(Me.inputExistenciasComercial)
        Me.comercialesTab.Controls.Add(Me.Label26)
        Me.comercialesTab.Controls.Add(Me.inputPrCostComercial)
        Me.comercialesTab.Controls.Add(Me.Label29)
        Me.comercialesTab.Controls.Add(Me.inputPrVentComercial)
        Me.comercialesTab.Controls.Add(Me.Label30)
        Me.comercialesTab.Controls.Add(Me.inputTelefonoComercial)
        Me.comercialesTab.Controls.Add(Me.Label31)
        Me.comercialesTab.Controls.Add(Me.inputApellidosComercial)
        Me.comercialesTab.Controls.Add(Me.Label32)
        Me.comercialesTab.Controls.Add(Me.inputNombreComercial)
        Me.comercialesTab.Controls.Add(Me.Label33)
        Me.comercialesTab.Controls.Add(Me.Label34)
        Me.comercialesTab.Controls.Add(Me.Label35)
        Me.comercialesTab.Controls.Add(Me.inputIdComercial)
        Me.comercialesTab.Controls.Add(Me.comboZona2Comerciales)
        Me.comercialesTab.Controls.Add(Me.Label36)
        Me.comercialesTab.Controls.Add(Me.DataGridView3)
        Me.comercialesTab.Controls.Add(Me.comboZonaComerciales)
        Me.comercialesTab.Controls.Add(Me.Label37)
        Me.comercialesTab.Location = New System.Drawing.Point(4, 25)
        Me.comercialesTab.Name = "comercialesTab"
        Me.comercialesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.comercialesTab.Size = New System.Drawing.Size(991, 554)
        Me.comercialesTab.TabIndex = 0
        Me.comercialesTab.Text = "Comerciales"
        Me.comercialesTab.UseVisualStyleBackColor = True
        '
        'inputBajoMinimoComercial
        '
        Me.inputBajoMinimoComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputBajoMinimoComercial.Location = New System.Drawing.Point(770, 115)
        Me.inputBajoMinimoComercial.Name = "inputBajoMinimoComercial"
        Me.inputBajoMinimoComercial.Size = New System.Drawing.Size(83, 22)
        Me.inputBajoMinimoComercial.TabIndex = 70
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(657, 117)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 16)
        Me.Label19.TabIndex = 69
        Me.Label19.Text = "Bajo Minimo"
        '
        'inputSobreMaximoComercial
        '
        Me.inputSobreMaximoComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputSobreMaximoComercial.Location = New System.Drawing.Point(563, 115)
        Me.inputSobreMaximoComercial.Name = "inputSobreMaximoComercial"
        Me.inputSobreMaximoComercial.Size = New System.Drawing.Size(83, 22)
        Me.inputSobreMaximoComercial.TabIndex = 68
        '
        'inputExistenciasComercial
        '
        Me.inputExistenciasComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputExistenciasComercial.Location = New System.Drawing.Point(326, 115)
        Me.inputExistenciasComercial.Name = "inputExistenciasComercial"
        Me.inputExistenciasComercial.Size = New System.Drawing.Size(83, 22)
        Me.inputExistenciasComercial.TabIndex = 67
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(222, 117)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(75, 16)
        Me.Label26.TabIndex = 66
        Me.Label26.Text = "Existencias"
        '
        'inputPrCostComercial
        '
        Me.inputPrCostComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPrCostComercial.Location = New System.Drawing.Point(133, 113)
        Me.inputPrCostComercial.Name = "inputPrCostComercial"
        Me.inputPrCostComercial.Size = New System.Drawing.Size(83, 22)
        Me.inputPrCostComercial.TabIndex = 65
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(55, 115)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(47, 16)
        Me.Label29.TabIndex = 64
        Me.Label29.Text = "PrCost"
        '
        'inputPrVentComercial
        '
        Me.inputPrVentComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPrVentComercial.Location = New System.Drawing.Point(770, 73)
        Me.inputPrVentComercial.Name = "inputPrVentComercial"
        Me.inputPrVentComercial.Size = New System.Drawing.Size(83, 22)
        Me.inputPrVentComercial.TabIndex = 63
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(657, 73)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(50, 16)
        Me.Label30.TabIndex = 62
        Me.Label30.Text = "PrVent:"
        '
        'inputTelefonoComercial
        '
        Me.inputTelefonoComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputTelefonoComercial.Location = New System.Drawing.Point(563, 71)
        Me.inputTelefonoComercial.Name = "inputTelefonoComercial"
        Me.inputTelefonoComercial.Size = New System.Drawing.Size(83, 22)
        Me.inputTelefonoComercial.TabIndex = 61
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(447, 73)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(61, 16)
        Me.Label31.TabIndex = 60
        Me.Label31.Text = "Telefono"
        '
        'inputApellidosComercial
        '
        Me.inputApellidosComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputApellidosComercial.Location = New System.Drawing.Point(326, 71)
        Me.inputApellidosComercial.Name = "inputApellidosComercial"
        Me.inputApellidosComercial.Size = New System.Drawing.Size(83, 22)
        Me.inputApellidosComercial.TabIndex = 59
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(222, 73)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(67, 16)
        Me.Label32.TabIndex = 58
        Me.Label32.Text = "Apellidos:"
        '
        'inputNombreComercial
        '
        Me.inputNombreComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNombreComercial.Location = New System.Drawing.Point(133, 71)
        Me.inputNombreComercial.Name = "inputNombreComercial"
        Me.inputNombreComercial.Size = New System.Drawing.Size(83, 22)
        Me.inputNombreComercial.TabIndex = 57
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(447, 117)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(94, 16)
        Me.Label33.TabIndex = 56
        Me.Label33.Text = "Sobre Maximo"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(55, 73)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(59, 16)
        Me.Label34.TabIndex = 55
        Me.Label34.Text = "Nombre:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(55, 29)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(87, 16)
        Me.Label35.TabIndex = 54
        Me.Label35.Text = "ID Comercial:"
        '
        'inputIdComercial
        '
        Me.inputIdComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdComercial.Location = New System.Drawing.Point(133, 26)
        Me.inputIdComercial.Name = "inputIdComercial"
        Me.inputIdComercial.Size = New System.Drawing.Size(79, 22)
        Me.inputIdComercial.TabIndex = 53
        '
        'comboZona2Comerciales
        '
        Me.comboZona2Comerciales.FormattingEnabled = True
        Me.comboZona2Comerciales.Location = New System.Drawing.Point(563, 25)
        Me.comboZona2Comerciales.Name = "comboZona2Comerciales"
        Me.comboZona2Comerciales.Size = New System.Drawing.Size(116, 24)
        Me.comboZona2Comerciales.TabIndex = 52
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(447, 28)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(48, 16)
        Me.Label36.TabIndex = 51
        Me.Label36.Text = "Zona2:"
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(56, 176)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(797, 346)
        Me.DataGridView3.TabIndex = 50
        '
        'comboZonaComerciales
        '
        Me.comboZonaComerciales.FormattingEnabled = True
        Me.comboZonaComerciales.Location = New System.Drawing.Point(326, 24)
        Me.comboZonaComerciales.Name = "comboZonaComerciales"
        Me.comboZonaComerciales.Size = New System.Drawing.Size(100, 24)
        Me.comboZonaComerciales.TabIndex = 49
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(222, 29)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(41, 16)
        Me.Label37.TabIndex = 48
        Me.Label37.Text = "Zona:"
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
        'Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1225, 711)
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
        Me.partnersTab.ResumeLayout(False)
        Me.partnersTab.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.comercialesTab.ResumeLayout(False)
        Me.comercialesTab.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents comboComercialPedidos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label As Label
    Friend WithEvents inputIdPedidos As TextBox
    Friend WithEvents comboPartnerPedidos As ComboBox
    Friend WithEvents comboFacturaPedidos As ComboBox
    Friend WithEvents comboEstadoPedidos As ComboBox
    Friend WithEvents comboTransportistaPedidos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents inputIdArticulo As TextBox
    Friend WithEvents comboSubCategoriaArticulos As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents comboCategoriaArticulos As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents inputNombreArticulos As TextBox
    Friend WithEvents inputPrCostArticulos As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents inputPrVentArticulos As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents inputProveedorArticulos As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents inputDescripcionArticulos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents inputBajoMinimoArticulos As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents inputSobreMaximoArticulos As TextBox
    Friend WithEvents inputExistenciasArticulos As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents inputIdPartner As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents inputFechaRegistroPartner As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents inputCorreoPartner As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents inputTelefonoPartner As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents inputDireccionPartner As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents inputCifPartner As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents inputNombrePartner As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents comboZonaPartners As ComboBox
    Friend WithEvents inputBajoMinimoComercial As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents inputSobreMaximoComercial As TextBox
    Friend WithEvents inputExistenciasComercial As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents inputPrCostComercial As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents inputPrVentComercial As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents inputTelefonoComercial As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents inputApellidosComercial As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents inputNombreComercial As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents inputIdComercial As TextBox
    Friend WithEvents comboZona2Comerciales As ComboBox
    Friend WithEvents Label36 As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents comboZonaComerciales As ComboBox
    Friend WithEvents Label37 As Label
End Class
