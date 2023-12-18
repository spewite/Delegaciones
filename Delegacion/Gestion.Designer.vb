<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gestion
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.articulosTab = New System.Windows.Forms.TabPage()
        Me.btnBorrarArticulos = New System.Windows.Forms.Button()
        Me.btnAltaArticulos = New System.Windows.Forms.Button()
        Me.btnConsultarArticulos = New System.Windows.Forms.Button()
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
        Me.dataGridArticulos = New System.Windows.Forms.DataGridView()
        Me.comboCategoriaArticulos = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.partnersTab = New System.Windows.Forms.TabPage()
        Me.inputFechaRegistroPartners = New System.Windows.Forms.DateTimePicker()
        Me.btnBorrarPartners = New System.Windows.Forms.Button()
        Me.btnAltaPartners = New System.Windows.Forms.Button()
        Me.btnConsultarPartners = New System.Windows.Forms.Button()
        Me.inputCorreoPartners = New System.Windows.Forms.TextBox()
        Me.inputNombrePartners = New System.Windows.Forms.TextBox()
        Me.inputIdPartner = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dataGridPartners = New System.Windows.Forms.DataGridView()
        Me.comboZonaPartners = New System.Windows.Forms.ComboBox()
        Me.inputTelefonoPartners = New System.Windows.Forms.TextBox()
        Me.inputDireccionPartners = New System.Windows.Forms.TextBox()
        Me.inputCifPartners = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.comercialesTab = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
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
        Me.TabControl1.SuspendLayout()
        Me.articulosTab.SuspendLayout()
        CType(Me.dataGridArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.partnersTab.SuspendLayout()
        CType(Me.dataGridPartners, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1426, 980)
        Me.TabControl1.TabIndex = 2
        '
        'articulosTab
        '
        Me.articulosTab.Controls.Add(Me.btnBorrarArticulos)
        Me.articulosTab.Controls.Add(Me.btnAltaArticulos)
        Me.articulosTab.Controls.Add(Me.btnConsultarArticulos)
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
        Me.articulosTab.Controls.Add(Me.dataGridArticulos)
        Me.articulosTab.Controls.Add(Me.comboCategoriaArticulos)
        Me.articulosTab.Controls.Add(Me.Label16)
        Me.articulosTab.Location = New System.Drawing.Point(4, 25)
        Me.articulosTab.Name = "articulosTab"
        Me.articulosTab.Size = New System.Drawing.Size(1418, 951)
        Me.articulosTab.TabIndex = 3
        Me.articulosTab.Text = "Articulos"
        Me.articulosTab.UseVisualStyleBackColor = True
        '
        'btnBorrarArticulos
        '
        Me.btnBorrarArticulos.Location = New System.Drawing.Point(1184, 66)
        Me.btnBorrarArticulos.Name = "btnBorrarArticulos"
        Me.btnBorrarArticulos.Size = New System.Drawing.Size(162, 32)
        Me.btnBorrarArticulos.TabIndex = 50
        Me.btnBorrarArticulos.Text = "Borrar"
        Me.btnBorrarArticulos.UseVisualStyleBackColor = True
        '
        'btnAltaArticulos
        '
        Me.btnAltaArticulos.Location = New System.Drawing.Point(1184, 108)
        Me.btnAltaArticulos.Name = "btnAltaArticulos"
        Me.btnAltaArticulos.Size = New System.Drawing.Size(162, 32)
        Me.btnAltaArticulos.TabIndex = 49
        Me.btnAltaArticulos.Text = "Alta"
        Me.btnAltaArticulos.UseVisualStyleBackColor = True
        '
        'btnConsultarArticulos
        '
        Me.btnConsultarArticulos.Location = New System.Drawing.Point(1184, 25)
        Me.btnConsultarArticulos.Name = "btnConsultarArticulos"
        Me.btnConsultarArticulos.Size = New System.Drawing.Size(162, 32)
        Me.btnConsultarArticulos.TabIndex = 48
        Me.btnConsultarArticulos.Text = "Consultar"
        Me.btnConsultarArticulos.UseVisualStyleBackColor = True
        '
        'inputBajoMinimoArticulos
        '
        Me.inputBajoMinimoArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputBajoMinimoArticulos.Location = New System.Drawing.Point(699, 118)
        Me.inputBajoMinimoArticulos.Name = "inputBajoMinimoArticulos"
        Me.inputBajoMinimoArticulos.Size = New System.Drawing.Size(145, 22)
        Me.inputBajoMinimoArticulos.TabIndex = 47
        '
        'inputSobreMaximoArticulos
        '
        Me.inputSobreMaximoArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputSobreMaximoArticulos.Location = New System.Drawing.Point(412, 118)
        Me.inputSobreMaximoArticulos.Name = "inputSobreMaximoArticulos"
        Me.inputSobreMaximoArticulos.Size = New System.Drawing.Size(145, 22)
        Me.inputSobreMaximoArticulos.TabIndex = 45
        '
        'inputExistenciasArticulos
        '
        Me.inputExistenciasArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputExistenciasArticulos.Location = New System.Drawing.Point(412, 70)
        Me.inputExistenciasArticulos.Name = "inputExistenciasArticulos"
        Me.inputExistenciasArticulos.Size = New System.Drawing.Size(145, 22)
        Me.inputExistenciasArticulos.TabIndex = 44
        '
        'inputPrCostArticulos
        '
        Me.inputPrCostArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPrCostArticulos.Location = New System.Drawing.Point(699, 27)
        Me.inputPrCostArticulos.Name = "inputPrCostArticulos"
        Me.inputPrCostArticulos.Size = New System.Drawing.Size(145, 22)
        Me.inputPrCostArticulos.TabIndex = 42
        '
        'inputPrVentArticulos
        '
        Me.inputPrVentArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPrVentArticulos.Location = New System.Drawing.Point(699, 72)
        Me.inputPrVentArticulos.Name = "inputPrVentArticulos"
        Me.inputPrVentArticulos.Size = New System.Drawing.Size(145, 22)
        Me.inputPrVentArticulos.TabIndex = 40
        '
        'inputProveedorArticulos
        '
        Me.inputProveedorArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputProveedorArticulos.Location = New System.Drawing.Point(142, 116)
        Me.inputProveedorArticulos.Name = "inputProveedorArticulos"
        Me.inputProveedorArticulos.Size = New System.Drawing.Size(145, 22)
        Me.inputProveedorArticulos.TabIndex = 38
        '
        'inputDescripcionArticulos
        '
        Me.inputDescripcionArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputDescripcionArticulos.Location = New System.Drawing.Point(881, 43)
        Me.inputDescripcionArticulos.Multiline = True
        Me.inputDescripcionArticulos.Name = "inputDescripcionArticulos"
        Me.inputDescripcionArticulos.Size = New System.Drawing.Size(261, 97)
        Me.inputDescripcionArticulos.TabIndex = 36
        '
        'inputNombreArticulos
        '
        Me.inputNombreArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNombreArticulos.Location = New System.Drawing.Point(142, 70)
        Me.inputNombreArticulos.Name = "inputNombreArticulos"
        Me.inputNombreArticulos.Size = New System.Drawing.Size(145, 22)
        Me.inputNombreArticulos.TabIndex = 34
        '
        'inputIdArticulo
        '
        Me.inputIdArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdArticulo.Location = New System.Drawing.Point(142, 25)
        Me.inputIdArticulo.Name = "inputIdArticulo"
        Me.inputIdArticulo.Size = New System.Drawing.Size(145, 22)
        Me.inputIdArticulo.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(612, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 16)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Bajo Minimo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(331, 72)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 16)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Existencias"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(606, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 16)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Precio Coste:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(608, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 16)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Precio venta:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(62, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 16)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Proveedor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(882, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Descripción:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(312, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 16)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Sobre Maximo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(77, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 16)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Nombre:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(66, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 16)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "ID Articulo:"
        '
        'dataGridArticulos
        '
        Me.dataGridArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridArticulos.Location = New System.Drawing.Point(56, 176)
        Me.dataGridArticulos.Name = "dataGridArticulos"
        Me.dataGridArticulos.RowHeadersWidth = 51
        Me.dataGridArticulos.RowTemplate.Height = 24
        Me.dataGridArticulos.Size = New System.Drawing.Size(1294, 590)
        Me.dataGridArticulos.TabIndex = 19
        '
        'comboCategoriaArticulos
        '
        Me.comboCategoriaArticulos.FormattingEnabled = True
        Me.comboCategoriaArticulos.Location = New System.Drawing.Point(412, 24)
        Me.comboCategoriaArticulos.Name = "comboCategoriaArticulos"
        Me.comboCategoriaArticulos.Size = New System.Drawing.Size(145, 24)
        Me.comboCategoriaArticulos.TabIndex = 18
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(331, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 16)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Categoria:"
        '
        'partnersTab
        '
        Me.partnersTab.Controls.Add(Me.inputFechaRegistroPartners)
        Me.partnersTab.Controls.Add(Me.btnBorrarPartners)
        Me.partnersTab.Controls.Add(Me.btnAltaPartners)
        Me.partnersTab.Controls.Add(Me.btnConsultarPartners)
        Me.partnersTab.Controls.Add(Me.inputCorreoPartners)
        Me.partnersTab.Controls.Add(Me.inputNombrePartners)
        Me.partnersTab.Controls.Add(Me.inputIdPartner)
        Me.partnersTab.Controls.Add(Me.Label2)
        Me.partnersTab.Controls.Add(Me.Label4)
        Me.partnersTab.Controls.Add(Me.dataGridPartners)
        Me.partnersTab.Controls.Add(Me.comboZonaPartners)
        Me.partnersTab.Controls.Add(Me.inputTelefonoPartners)
        Me.partnersTab.Controls.Add(Me.inputDireccionPartners)
        Me.partnersTab.Controls.Add(Me.inputCifPartners)
        Me.partnersTab.Controls.Add(Me.Label20)
        Me.partnersTab.Controls.Add(Me.Label21)
        Me.partnersTab.Controls.Add(Me.Label22)
        Me.partnersTab.Controls.Add(Me.Label23)
        Me.partnersTab.Controls.Add(Me.Label25)
        Me.partnersTab.Controls.Add(Me.Label27)
        Me.partnersTab.Location = New System.Drawing.Point(4, 25)
        Me.partnersTab.Name = "partnersTab"
        Me.partnersTab.Padding = New System.Windows.Forms.Padding(3)
        Me.partnersTab.Size = New System.Drawing.Size(1775, 1196)
        Me.partnersTab.TabIndex = 1
        Me.partnersTab.Text = "Partners"
        Me.partnersTab.UseVisualStyleBackColor = True
        '
        'inputFechaRegistroPartners
        '
        Me.inputFechaRegistroPartners.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.inputFechaRegistroPartners.Location = New System.Drawing.Point(429, 117)
        Me.inputFechaRegistroPartners.Name = "inputFechaRegistroPartners"
        Me.inputFechaRegistroPartners.Size = New System.Drawing.Size(145, 22)
        Me.inputFechaRegistroPartners.TabIndex = 75
        Me.inputFechaRegistroPartners.Value = New Date(2023, 12, 16, 19, 57, 19, 0)
        '
        'btnBorrarPartners
        '
        Me.btnBorrarPartners.Location = New System.Drawing.Point(1179, 66)
        Me.btnBorrarPartners.Name = "btnBorrarPartners"
        Me.btnBorrarPartners.Size = New System.Drawing.Size(162, 32)
        Me.btnBorrarPartners.TabIndex = 74
        Me.btnBorrarPartners.Text = "Borrar"
        Me.btnBorrarPartners.UseVisualStyleBackColor = True
        '
        'btnAltaPartners
        '
        Me.btnAltaPartners.Location = New System.Drawing.Point(1179, 107)
        Me.btnAltaPartners.Name = "btnAltaPartners"
        Me.btnAltaPartners.Size = New System.Drawing.Size(162, 32)
        Me.btnAltaPartners.TabIndex = 73
        Me.btnAltaPartners.Text = "Alta"
        Me.btnAltaPartners.UseVisualStyleBackColor = True
        '
        'btnConsultarPartners
        '
        Me.btnConsultarPartners.Location = New System.Drawing.Point(1179, 24)
        Me.btnConsultarPartners.Name = "btnConsultarPartners"
        Me.btnConsultarPartners.Size = New System.Drawing.Size(162, 32)
        Me.btnConsultarPartners.TabIndex = 72
        Me.btnConsultarPartners.Text = "Consultar"
        Me.btnConsultarPartners.UseVisualStyleBackColor = True
        '
        'inputCorreoPartners
        '
        Me.inputCorreoPartners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputCorreoPartners.Location = New System.Drawing.Point(142, 116)
        Me.inputCorreoPartners.Name = "inputCorreoPartners"
        Me.inputCorreoPartners.Size = New System.Drawing.Size(145, 22)
        Me.inputCorreoPartners.TabIndex = 71
        '
        'inputNombrePartners
        '
        Me.inputNombrePartners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNombrePartners.Location = New System.Drawing.Point(142, 70)
        Me.inputNombrePartners.Name = "inputNombrePartners"
        Me.inputNombrePartners.Size = New System.Drawing.Size(145, 22)
        Me.inputNombrePartners.TabIndex = 69
        '
        'inputIdPartner
        '
        Me.inputIdPartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdPartner.Location = New System.Drawing.Point(142, 25)
        Me.inputIdPartner.Name = "inputIdPartner"
        Me.inputIdPartner.Size = New System.Drawing.Size(145, 22)
        Me.inputIdPartner.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "ID Partner:"
        '
        'dataGridPartners
        '
        Me.dataGridPartners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridPartners.Location = New System.Drawing.Point(56, 176)
        Me.dataGridPartners.Name = "dataGridPartners"
        Me.dataGridPartners.RowHeadersWidth = 51
        Me.dataGridPartners.RowTemplate.Height = 24
        Me.dataGridPartners.Size = New System.Drawing.Size(1294, 590)
        Me.dataGridPartners.TabIndex = 65
        '
        'comboZonaPartners
        '
        Me.comboZonaPartners.FormattingEnabled = True
        Me.comboZonaPartners.Location = New System.Drawing.Point(429, 23)
        Me.comboZonaPartners.Name = "comboZonaPartners"
        Me.comboZonaPartners.Size = New System.Drawing.Size(145, 24)
        Me.comboZonaPartners.TabIndex = 64
        '
        'inputTelefonoPartners
        '
        Me.inputTelefonoPartners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputTelefonoPartners.Location = New System.Drawing.Point(429, 71)
        Me.inputTelefonoPartners.Name = "inputTelefonoPartners"
        Me.inputTelefonoPartners.Size = New System.Drawing.Size(145, 22)
        Me.inputTelefonoPartners.TabIndex = 56
        '
        'inputDireccionPartners
        '
        Me.inputDireccionPartners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputDireccionPartners.Location = New System.Drawing.Point(688, 74)
        Me.inputDireccionPartners.Name = "inputDireccionPartners"
        Me.inputDireccionPartners.Size = New System.Drawing.Size(272, 22)
        Me.inputDireccionPartners.TabIndex = 54
        '
        'inputCifPartners
        '
        Me.inputCifPartners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputCifPartners.Location = New System.Drawing.Point(688, 26)
        Me.inputCifPartners.Name = "inputCifPartners"
        Me.inputCifPartners.Size = New System.Drawing.Size(134, 22)
        Me.inputCifPartners.TabIndex = 52
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(324, 119)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(99, 16)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Fecha Registro"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(88, 119)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 16)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "Correo"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(359, 73)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(61, 16)
        Me.Label22.TabIndex = 55
        Me.Label22.Text = "Telefono"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(617, 77)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 16)
        Me.Label23.TabIndex = 53
        Me.Label23.Text = "Direccion"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(651, 28)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(30, 16)
        Me.Label25.TabIndex = 51
        Me.Label25.Text = "CIF:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(358, 27)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(57, 16)
        Me.Label27.TabIndex = 35
        Me.Label27.Text = "ID Zona:"
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
        Me.comercialesTab.Size = New System.Drawing.Size(1775, 1196)
        Me.comercialesTab.TabIndex = 0
        Me.comercialesTab.Text = "Comerciales"
        Me.comercialesTab.UseVisualStyleBackColor = True
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
        Me.transportistasTab.Size = New System.Drawing.Size(1775, 1196)
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
        'Gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1426, 980)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Gestion"
        Me.RightToLeftLayout = True
        Me.Text = "Gestion"
        Me.TabControl1.ResumeLayout(False)
        Me.articulosTab.ResumeLayout(False)
        Me.articulosTab.PerformLayout()
        CType(Me.dataGridArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.partnersTab.ResumeLayout(False)
        Me.partnersTab.PerformLayout()
        CType(Me.dataGridPartners, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dataGridArticulos As DataGridView
    Friend WithEvents comboCategoriaArticulos As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents partnersTab As TabPage
    Friend WithEvents dataGridPartners As DataGridView
    Friend WithEvents comboZonaPartners As ComboBox
    Friend WithEvents inputTelefonoPartners As TextBox
    Friend WithEvents inputDireccionPartners As TextBox
    Friend WithEvents inputCifPartners As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label27 As Label
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
    Friend WithEvents btnConsultarArticulos As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnBorrarArticulos As Button
    Friend WithEvents btnAltaArticulos As Button
    Friend WithEvents inputCorreoPartners As TextBox
    Friend WithEvents inputNombrePartners As TextBox
    Friend WithEvents inputIdPartner As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnConsultarPartners As Button
    Friend WithEvents btnBorrarPartners As Button
    Friend WithEvents btnAltaPartners As Button
    Friend WithEvents inputFechaRegistroPartners As DateTimePicker
End Class
