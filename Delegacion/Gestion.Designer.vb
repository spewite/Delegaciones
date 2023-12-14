<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion
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
        Me.articulosTab = New System.Windows.Forms.TabPage()
        Me.inputBajoMinimoArticulos = New System.Windows.Forms.TextBox()
        Me.inputSobreMaximoArticulos = New System.Windows.Forms.TextBox()
        Me.inputExistenciasArticulos = New System.Windows.Forms.TextBox()
        Me.inputPrCostArticulos = New System.Windows.Forms.TextBox()
        Me.inputPrVentArticulos = New System.Windows.Forms.TextBox()
        Me.inputProveedorArticulos = New System.Windows.Forms.TextBox()
        Me.inputDescripcionArticulos = New System.Windows.Forms.TextBox()
        Me.inputNombreArticulos = New System.Windows.Forms.TextBox()
        Me.inputIdArticulo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.comboSubCategoriaArticulos = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.comboCategoriaArticulos = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.partnersTab = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.comboZonaPartners = New System.Windows.Forms.ComboBox()
        Me.inputFechaRegistroPartner = New System.Windows.Forms.TextBox()
        Me.inputCorreoPartner = New System.Windows.Forms.TextBox()
        Me.inputTelefonoPartner = New System.Windows.Forms.TextBox()
        Me.inputDireccionPartner = New System.Windows.Forms.TextBox()
        Me.inputCifPartner = New System.Windows.Forms.TextBox()
        Me.inputNombrePartner = New System.Windows.Forms.TextBox()
        Me.inputIdPartner = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.comercialesTab = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.inputBajoMinimoComercial = New System.Windows.Forms.TextBox()
        Me.inputSobreMaximoComercial = New System.Windows.Forms.TextBox()
        Me.inputExistenciasComercial = New System.Windows.Forms.TextBox()
        Me.inputPrCostComercial = New System.Windows.Forms.TextBox()
        Me.inputPrVentComercial = New System.Windows.Forms.TextBox()
        Me.inputTelefonoComercial = New System.Windows.Forms.TextBox()
        Me.inputApellidosComercial = New System.Windows.Forms.TextBox()
        Me.inputNombreComercial = New System.Windows.Forms.TextBox()
        Me.inputIdComercial = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.comboZona2Comerciales = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.comboZonaComerciales = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.transportistasTab = New System.Windows.Forms.TabPage()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.inputTelefonoTransportista = New System.Windows.Forms.TextBox()
        Me.inputNombreTransportista = New System.Windows.Forms.TextBox()
        Me.inputIdTransportista = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.articulosTab.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.partnersTab.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.comercialesTab.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.transportistasTab.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.articulosTab)
        Me.TabControl1.Controls.Add(Me.partnersTab)
        Me.TabControl1.Controls.Add(Me.comercialesTab)
        Me.TabControl1.Controls.Add(Me.transportistasTab)
        Me.TabControl1.Location = New System.Drawing.Point(2, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1382, 817)
        Me.TabControl1.TabIndex = 2
        '
        'articulosTab
        '
        Me.articulosTab.Controls.Add(Me.Button1)
        Me.articulosTab.Controls.Add(Me.inputBajoMinimoArticulos)
        Me.articulosTab.Controls.Add(Me.inputSobreMaximoArticulos)
        Me.articulosTab.Controls.Add(Me.inputExistenciasArticulos)
        Me.articulosTab.Controls.Add(Me.inputPrCostArticulos)
        Me.articulosTab.Controls.Add(Me.inputPrVentArticulos)
        Me.articulosTab.Controls.Add(Me.inputProveedorArticulos)
        Me.articulosTab.Controls.Add(Me.inputDescripcionArticulos)
        Me.articulosTab.Controls.Add(Me.inputNombreArticulos)
        Me.articulosTab.Controls.Add(Me.inputIdArticulo)
        Me.articulosTab.Controls.Add(Me.Label9)
        Me.articulosTab.Controls.Add(Me.Label18)
        Me.articulosTab.Controls.Add(Me.Label12)
        Me.articulosTab.Controls.Add(Me.Label17)
        Me.articulosTab.Controls.Add(Me.Label10)
        Me.articulosTab.Controls.Add(Me.Label3)
        Me.articulosTab.Controls.Add(Me.Label11)
        Me.articulosTab.Controls.Add(Me.Label13)
        Me.articulosTab.Controls.Add(Me.Label14)
        Me.articulosTab.Controls.Add(Me.comboSubCategoriaArticulos)
        Me.articulosTab.Controls.Add(Me.Label15)
        Me.articulosTab.Controls.Add(Me.DataGridView1)
        Me.articulosTab.Controls.Add(Me.comboCategoriaArticulos)
        Me.articulosTab.Controls.Add(Me.Label16)
        Me.articulosTab.Location = New System.Drawing.Point(4, 25)
        Me.articulosTab.Name = "articulosTab"
        Me.articulosTab.Size = New System.Drawing.Size(1374, 788)
        Me.articulosTab.TabIndex = 3
        Me.articulosTab.Text = "Articulos"
        Me.articulosTab.UseVisualStyleBackColor = True
        '
        'inputBajoMinimoArticulos
        '
        Me.inputBajoMinimoArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputBajoMinimoArticulos.Location = New System.Drawing.Point(785, 116)
        Me.inputBajoMinimoArticulos.Name = "inputBajoMinimoArticulos"
        Me.inputBajoMinimoArticulos.Size = New System.Drawing.Size(83, 22)
        Me.inputBajoMinimoArticulos.TabIndex = 47
        '
        'inputSobreMaximoArticulos
        '
        Me.inputSobreMaximoArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputSobreMaximoArticulos.Location = New System.Drawing.Point(578, 116)
        Me.inputSobreMaximoArticulos.Name = "inputSobreMaximoArticulos"
        Me.inputSobreMaximoArticulos.Size = New System.Drawing.Size(83, 22)
        Me.inputSobreMaximoArticulos.TabIndex = 45
        '
        'inputExistenciasArticulos
        '
        Me.inputExistenciasArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputExistenciasArticulos.Location = New System.Drawing.Point(341, 116)
        Me.inputExistenciasArticulos.Name = "inputExistenciasArticulos"
        Me.inputExistenciasArticulos.Size = New System.Drawing.Size(83, 22)
        Me.inputExistenciasArticulos.TabIndex = 44
        '
        'inputPrCostArticulos
        '
        Me.inputPrCostArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPrCostArticulos.Location = New System.Drawing.Point(148, 114)
        Me.inputPrCostArticulos.Name = "inputPrCostArticulos"
        Me.inputPrCostArticulos.Size = New System.Drawing.Size(83, 22)
        Me.inputPrCostArticulos.TabIndex = 42
        '
        'inputPrVentArticulos
        '
        Me.inputPrVentArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPrVentArticulos.Location = New System.Drawing.Point(785, 74)
        Me.inputPrVentArticulos.Name = "inputPrVentArticulos"
        Me.inputPrVentArticulos.Size = New System.Drawing.Size(83, 22)
        Me.inputPrVentArticulos.TabIndex = 40
        '
        'inputProveedorArticulos
        '
        Me.inputProveedorArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputProveedorArticulos.Location = New System.Drawing.Point(578, 72)
        Me.inputProveedorArticulos.Name = "inputProveedorArticulos"
        Me.inputProveedorArticulos.Size = New System.Drawing.Size(83, 22)
        Me.inputProveedorArticulos.TabIndex = 38
        '
        'inputDescripcionArticulos
        '
        Me.inputDescripcionArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputDescripcionArticulos.Location = New System.Drawing.Point(341, 72)
        Me.inputDescripcionArticulos.Name = "inputDescripcionArticulos"
        Me.inputDescripcionArticulos.Size = New System.Drawing.Size(83, 22)
        Me.inputDescripcionArticulos.TabIndex = 36
        '
        'inputNombreArticulos
        '
        Me.inputNombreArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNombreArticulos.Location = New System.Drawing.Point(148, 72)
        Me.inputNombreArticulos.Name = "inputNombreArticulos"
        Me.inputNombreArticulos.Size = New System.Drawing.Size(83, 22)
        Me.inputNombreArticulos.TabIndex = 34
        '
        'inputIdArticulo
        '
        Me.inputIdArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdArticulo.Location = New System.Drawing.Point(148, 27)
        Me.inputIdArticulo.Name = "inputIdArticulo"
        Me.inputIdArticulo.Size = New System.Drawing.Size(79, 22)
        Me.inputIdArticulo.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(672, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 16)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Bajo Minimo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(237, 118)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 16)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Existencias"
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
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(672, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 16)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "PrVent:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(462, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 16)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Proveedor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(237, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Descripción:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(462, 118)
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
        'comboSubCategoriaArticulos
        '
        Me.comboSubCategoriaArticulos.FormattingEnabled = True
        Me.comboSubCategoriaArticulos.Location = New System.Drawing.Point(578, 26)
        Me.comboSubCategoriaArticulos.Name = "comboSubCategoriaArticulos"
        Me.comboSubCategoriaArticulos.Size = New System.Drawing.Size(116, 24)
        Me.comboSubCategoriaArticulos.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(462, 29)
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
        Me.DataGridView1.Size = New System.Drawing.Size(1294, 590)
        Me.DataGridView1.TabIndex = 19
        '
        'comboCategoriaArticulos
        '
        Me.comboCategoriaArticulos.FormattingEnabled = True
        Me.comboCategoriaArticulos.Location = New System.Drawing.Point(341, 25)
        Me.comboCategoriaArticulos.Name = "comboCategoriaArticulos"
        Me.comboCategoriaArticulos.Size = New System.Drawing.Size(100, 24)
        Me.comboCategoriaArticulos.TabIndex = 18
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(237, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 16)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Categoria:"
        '
        'partnersTab
        '
        Me.partnersTab.Controls.Add(Me.Button2)
        Me.partnersTab.Controls.Add(Me.DataGridView2)
        Me.partnersTab.Controls.Add(Me.comboZonaPartners)
        Me.partnersTab.Controls.Add(Me.inputFechaRegistroPartner)
        Me.partnersTab.Controls.Add(Me.inputCorreoPartner)
        Me.partnersTab.Controls.Add(Me.inputTelefonoPartner)
        Me.partnersTab.Controls.Add(Me.inputDireccionPartner)
        Me.partnersTab.Controls.Add(Me.inputCifPartner)
        Me.partnersTab.Controls.Add(Me.inputNombrePartner)
        Me.partnersTab.Controls.Add(Me.inputIdPartner)
        Me.partnersTab.Controls.Add(Me.Label20)
        Me.partnersTab.Controls.Add(Me.Label21)
        Me.partnersTab.Controls.Add(Me.Label22)
        Me.partnersTab.Controls.Add(Me.Label23)
        Me.partnersTab.Controls.Add(Me.Label25)
        Me.partnersTab.Controls.Add(Me.Label28)
        Me.partnersTab.Controls.Add(Me.Label27)
        Me.partnersTab.Controls.Add(Me.Label24)
        Me.partnersTab.Location = New System.Drawing.Point(4, 25)
        Me.partnersTab.Name = "partnersTab"
        Me.partnersTab.Padding = New System.Windows.Forms.Padding(3)
        Me.partnersTab.Size = New System.Drawing.Size(1374, 788)
        Me.partnersTab.TabIndex = 1
        Me.partnersTab.Text = "Partners"
        Me.partnersTab.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(56, 176)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(1294, 590)
        Me.DataGridView2.TabIndex = 65
        '
        'comboZonaPartners
        '
        Me.comboZonaPartners.FormattingEnabled = True
        Me.comboZonaPartners.Location = New System.Drawing.Point(436, 27)
        Me.comboZonaPartners.Name = "comboZonaPartners"
        Me.comboZonaPartners.Size = New System.Drawing.Size(100, 24)
        Me.comboZonaPartners.TabIndex = 64
        '
        'inputFechaRegistroPartner
        '
        Me.inputFechaRegistroPartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputFechaRegistroPartner.Location = New System.Drawing.Point(341, 117)
        Me.inputFechaRegistroPartner.Name = "inputFechaRegistroPartner"
        Me.inputFechaRegistroPartner.Size = New System.Drawing.Size(83, 22)
        Me.inputFechaRegistroPartner.TabIndex = 60
        '
        'inputCorreoPartner
        '
        Me.inputCorreoPartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputCorreoPartner.Location = New System.Drawing.Point(148, 115)
        Me.inputCorreoPartner.Name = "inputCorreoPartner"
        Me.inputCorreoPartner.Size = New System.Drawing.Size(83, 22)
        Me.inputCorreoPartner.TabIndex = 58
        '
        'inputTelefonoPartner
        '
        Me.inputTelefonoPartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputTelefonoPartner.Location = New System.Drawing.Point(785, 75)
        Me.inputTelefonoPartner.Name = "inputTelefonoPartner"
        Me.inputTelefonoPartner.Size = New System.Drawing.Size(83, 22)
        Me.inputTelefonoPartner.TabIndex = 56
        '
        'inputDireccionPartner
        '
        Me.inputDireccionPartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputDireccionPartner.Location = New System.Drawing.Point(578, 73)
        Me.inputDireccionPartner.Name = "inputDireccionPartner"
        Me.inputDireccionPartner.Size = New System.Drawing.Size(83, 22)
        Me.inputDireccionPartner.TabIndex = 54
        '
        'inputCifPartner
        '
        Me.inputCifPartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputCifPartner.Location = New System.Drawing.Point(341, 73)
        Me.inputCifPartner.Name = "inputCifPartner"
        Me.inputCifPartner.Size = New System.Drawing.Size(83, 22)
        Me.inputCifPartner.TabIndex = 52
        '
        'inputNombrePartner
        '
        Me.inputNombrePartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNombrePartner.Location = New System.Drawing.Point(148, 73)
        Me.inputNombrePartner.Name = "inputNombrePartner"
        Me.inputNombrePartner.Size = New System.Drawing.Size(83, 22)
        Me.inputNombrePartner.TabIndex = 50
        '
        'inputIdPartner
        '
        Me.inputIdPartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdPartner.Location = New System.Drawing.Point(148, 27)
        Me.inputIdPartner.Name = "inputIdPartner"
        Me.inputIdPartner.Size = New System.Drawing.Size(172, 22)
        Me.inputIdPartner.TabIndex = 25
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(237, 119)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(99, 16)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Fecha Registro"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(55, 115)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 16)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "Correo"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(672, 75)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(61, 16)
        Me.Label22.TabIndex = 55
        Me.Label22.Text = "Telefono"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(462, 75)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 16)
        Me.Label23.TabIndex = 53
        Me.Label23.Text = "Direccion"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(237, 75)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(30, 16)
        Me.Label25.TabIndex = 51
        Me.Label25.Text = "CIF:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(55, 73)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(59, 16)
        Me.Label28.TabIndex = 48
        Me.Label28.Text = "Nombre:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(365, 29)
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
        'comercialesTab
        '
        Me.comercialesTab.Controls.Add(Me.Button3)
        Me.comercialesTab.Controls.Add(Me.DataGridView3)
        Me.comercialesTab.Controls.Add(Me.inputBajoMinimoComercial)
        Me.comercialesTab.Controls.Add(Me.inputSobreMaximoComercial)
        Me.comercialesTab.Controls.Add(Me.inputExistenciasComercial)
        Me.comercialesTab.Controls.Add(Me.inputPrCostComercial)
        Me.comercialesTab.Controls.Add(Me.inputPrVentComercial)
        Me.comercialesTab.Controls.Add(Me.inputTelefonoComercial)
        Me.comercialesTab.Controls.Add(Me.inputApellidosComercial)
        Me.comercialesTab.Controls.Add(Me.inputNombreComercial)
        Me.comercialesTab.Controls.Add(Me.inputIdComercial)
        Me.comercialesTab.Controls.Add(Me.Label19)
        Me.comercialesTab.Controls.Add(Me.Label26)
        Me.comercialesTab.Controls.Add(Me.Label29)
        Me.comercialesTab.Controls.Add(Me.Label30)
        Me.comercialesTab.Controls.Add(Me.Label31)
        Me.comercialesTab.Controls.Add(Me.Label32)
        Me.comercialesTab.Controls.Add(Me.Label33)
        Me.comercialesTab.Controls.Add(Me.Label34)
        Me.comercialesTab.Controls.Add(Me.Label35)
        Me.comercialesTab.Controls.Add(Me.comboZona2Comerciales)
        Me.comercialesTab.Controls.Add(Me.Label36)
        Me.comercialesTab.Controls.Add(Me.comboZonaComerciales)
        Me.comercialesTab.Controls.Add(Me.Label37)
        Me.comercialesTab.Location = New System.Drawing.Point(4, 25)
        Me.comercialesTab.Name = "comercialesTab"
        Me.comercialesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.comercialesTab.Size = New System.Drawing.Size(1374, 788)
        Me.comercialesTab.TabIndex = 0
        Me.comercialesTab.Text = "Comerciales"
        Me.comercialesTab.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(56, 176)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(1294, 590)
        Me.DataGridView3.TabIndex = 71
        '
        'inputBajoMinimoComercial
        '
        Me.inputBajoMinimoComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputBajoMinimoComercial.Location = New System.Drawing.Point(785, 116)
        Me.inputBajoMinimoComercial.Name = "inputBajoMinimoComercial"
        Me.inputBajoMinimoComercial.Size = New System.Drawing.Size(83, 22)
        Me.inputBajoMinimoComercial.TabIndex = 70
        '
        'inputSobreMaximoComercial
        '
        Me.inputSobreMaximoComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputSobreMaximoComercial.Location = New System.Drawing.Point(578, 116)
        Me.inputSobreMaximoComercial.Name = "inputSobreMaximoComercial"
        Me.inputSobreMaximoComercial.Size = New System.Drawing.Size(83, 22)
        Me.inputSobreMaximoComercial.TabIndex = 68
        '
        'inputExistenciasComercial
        '
        Me.inputExistenciasComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputExistenciasComercial.Location = New System.Drawing.Point(341, 116)
        Me.inputExistenciasComercial.Name = "inputExistenciasComercial"
        Me.inputExistenciasComercial.Size = New System.Drawing.Size(83, 22)
        Me.inputExistenciasComercial.TabIndex = 67
        '
        'inputPrCostComercial
        '
        Me.inputPrCostComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPrCostComercial.Location = New System.Drawing.Point(148, 114)
        Me.inputPrCostComercial.Name = "inputPrCostComercial"
        Me.inputPrCostComercial.Size = New System.Drawing.Size(83, 22)
        Me.inputPrCostComercial.TabIndex = 65
        '
        'inputPrVentComercial
        '
        Me.inputPrVentComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPrVentComercial.Location = New System.Drawing.Point(785, 74)
        Me.inputPrVentComercial.Name = "inputPrVentComercial"
        Me.inputPrVentComercial.Size = New System.Drawing.Size(83, 22)
        Me.inputPrVentComercial.TabIndex = 63
        '
        'inputTelefonoComercial
        '
        Me.inputTelefonoComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputTelefonoComercial.Location = New System.Drawing.Point(578, 72)
        Me.inputTelefonoComercial.Name = "inputTelefonoComercial"
        Me.inputTelefonoComercial.Size = New System.Drawing.Size(83, 22)
        Me.inputTelefonoComercial.TabIndex = 61
        '
        'inputApellidosComercial
        '
        Me.inputApellidosComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputApellidosComercial.Location = New System.Drawing.Point(341, 72)
        Me.inputApellidosComercial.Name = "inputApellidosComercial"
        Me.inputApellidosComercial.Size = New System.Drawing.Size(83, 22)
        Me.inputApellidosComercial.TabIndex = 59
        '
        'inputNombreComercial
        '
        Me.inputNombreComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNombreComercial.Location = New System.Drawing.Point(148, 72)
        Me.inputNombreComercial.Name = "inputNombreComercial"
        Me.inputNombreComercial.Size = New System.Drawing.Size(83, 22)
        Me.inputNombreComercial.TabIndex = 57
        '
        'inputIdComercial
        '
        Me.inputIdComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdComercial.Location = New System.Drawing.Point(148, 27)
        Me.inputIdComercial.Name = "inputIdComercial"
        Me.inputIdComercial.Size = New System.Drawing.Size(79, 22)
        Me.inputIdComercial.TabIndex = 53
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(672, 118)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 16)
        Me.Label19.TabIndex = 69
        Me.Label19.Text = "Bajo Minimo"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(237, 118)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(75, 16)
        Me.Label26.TabIndex = 66
        Me.Label26.Text = "Existencias"
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
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(672, 74)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(50, 16)
        Me.Label30.TabIndex = 62
        Me.Label30.Text = "PrVent:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(462, 74)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(61, 16)
        Me.Label31.TabIndex = 60
        Me.Label31.Text = "Telefono"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(237, 74)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(67, 16)
        Me.Label32.TabIndex = 58
        Me.Label32.Text = "Apellidos:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(462, 118)
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
        'comboZona2Comerciales
        '
        Me.comboZona2Comerciales.FormattingEnabled = True
        Me.comboZona2Comerciales.Location = New System.Drawing.Point(578, 26)
        Me.comboZona2Comerciales.Name = "comboZona2Comerciales"
        Me.comboZona2Comerciales.Size = New System.Drawing.Size(116, 24)
        Me.comboZona2Comerciales.TabIndex = 52
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(462, 29)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(48, 16)
        Me.Label36.TabIndex = 51
        Me.Label36.Text = "Zona2:"
        '
        'comboZonaComerciales
        '
        Me.comboZonaComerciales.FormattingEnabled = True
        Me.comboZonaComerciales.Location = New System.Drawing.Point(341, 25)
        Me.comboZonaComerciales.Name = "comboZonaComerciales"
        Me.comboZonaComerciales.Size = New System.Drawing.Size(100, 24)
        Me.comboZonaComerciales.TabIndex = 49
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(237, 30)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(41, 16)
        Me.Label37.TabIndex = 48
        Me.Label37.Text = "Zona:"
        '
        'transportistasTab
        '
        Me.transportistasTab.Controls.Add(Me.DataGridView4)
        Me.transportistasTab.Controls.Add(Me.Label39)
        Me.transportistasTab.Controls.Add(Me.inputTelefonoTransportista)
        Me.transportistasTab.Controls.Add(Me.inputNombreTransportista)
        Me.transportistasTab.Controls.Add(Me.inputIdTransportista)
        Me.transportistasTab.Controls.Add(Me.Label38)
        Me.transportistasTab.Controls.Add(Me.Label46)
        Me.transportistasTab.Location = New System.Drawing.Point(4, 25)
        Me.transportistasTab.Name = "transportistasTab"
        Me.transportistasTab.Size = New System.Drawing.Size(1374, 788)
        Me.transportistasTab.TabIndex = 6
        Me.transportistasTab.Text = "Transportistas"
        Me.transportistasTab.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(56, 176)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.Size = New System.Drawing.Size(1294, 590)
        Me.DataGridView4.TabIndex = 82
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(493, 29)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(64, 16)
        Me.Label39.TabIndex = 81
        Me.Label39.Text = "Telefono:"
        '
        'inputTelefonoTransportista
        '
        Me.inputTelefonoTransportista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputTelefonoTransportista.Location = New System.Drawing.Point(574, 27)
        Me.inputTelefonoTransportista.Name = "inputTelefonoTransportista"
        Me.inputTelefonoTransportista.Size = New System.Drawing.Size(79, 22)
        Me.inputTelefonoTransportista.TabIndex = 80
        '
        'inputNombreTransportista
        '
        Me.inputNombreTransportista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNombreTransportista.Location = New System.Drawing.Point(358, 27)
        Me.inputNombreTransportista.Name = "inputNombreTransportista"
        Me.inputNombreTransportista.Size = New System.Drawing.Size(79, 22)
        Me.inputNombreTransportista.TabIndex = 78
        '
        'inputIdTransportista
        '
        Me.inputIdTransportista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdTransportista.Location = New System.Drawing.Point(166, 28)
        Me.inputIdTransportista.Name = "inputIdTransportista"
        Me.inputIdTransportista.Size = New System.Drawing.Size(79, 22)
        Me.inputIdTransportista.TabIndex = 76
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(276, 30)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(59, 16)
        Me.Label38.TabIndex = 79
        Me.Label38.Text = "Nombre:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(55, 29)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(105, 16)
        Me.Label46.TabIndex = 77
        Me.Label46.Text = "ID Transportista:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1095, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1125, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 66
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1071, 65)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 72
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1555, 813)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Gestion"
        Me.RightToLeftLayout = True
        Me.Text = "Gestion"
        Me.TabControl1.ResumeLayout(False)
        Me.articulosTab.ResumeLayout(False)
        Me.articulosTab.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.partnersTab.ResumeLayout(False)
        Me.partnersTab.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.comercialesTab.ResumeLayout(False)
        Me.comercialesTab.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.transportistasTab.ResumeLayout(False)
        Me.transportistasTab.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents articulosTab As TabPage
    Friend WithEvents inputBajoMinimoArticulos As TextBox
    Friend WithEvents inputSobreMaximoArticulos As TextBox
    Friend WithEvents inputExistenciasArticulos As TextBox
    Friend WithEvents inputPrCostArticulos As TextBox
    Friend WithEvents inputPrVentArticulos As TextBox
    Friend WithEvents inputProveedorArticulos As TextBox
    Friend WithEvents inputDescripcionArticulos As TextBox
    Friend WithEvents inputNombreArticulos As TextBox
    Friend WithEvents inputIdArticulo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents comboSubCategoriaArticulos As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents comboCategoriaArticulos As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents partnersTab As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents comboZonaPartners As ComboBox
    Friend WithEvents inputFechaRegistroPartner As TextBox
    Friend WithEvents inputCorreoPartner As TextBox
    Friend WithEvents inputTelefonoPartner As TextBox
    Friend WithEvents inputDireccionPartner As TextBox
    Friend WithEvents inputCifPartner As TextBox
    Friend WithEvents inputNombrePartner As TextBox
    Friend WithEvents inputIdPartner As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents comercialesTab As TabPage
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents inputBajoMinimoComercial As TextBox
    Friend WithEvents inputSobreMaximoComercial As TextBox
    Friend WithEvents inputExistenciasComercial As TextBox
    Friend WithEvents inputPrCostComercial As TextBox
    Friend WithEvents inputPrVentComercial As TextBox
    Friend WithEvents inputTelefonoComercial As TextBox
    Friend WithEvents inputApellidosComercial As TextBox
    Friend WithEvents inputNombreComercial As TextBox
    Friend WithEvents inputIdComercial As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents comboZona2Comerciales As ComboBox
    Friend WithEvents Label36 As Label
    Friend WithEvents comboZonaComerciales As ComboBox
    Friend WithEvents Label37 As Label
    Friend WithEvents transportistasTab As TabPage
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Label39 As Label
    Friend WithEvents inputTelefonoTransportista As TextBox
    Friend WithEvents inputNombreTransportista As TextBox
    Friend WithEvents inputIdTransportista As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
