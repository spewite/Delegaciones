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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.articulosTab = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBorrarArticulos = New System.Windows.Forms.Button()
        Me.btnAltaArticulos = New System.Windows.Forms.Button()
        Me.btnConsultarArticulos = New System.Windows.Forms.Button()
        Me.inputBajoMinimoArticulos = New System.Windows.Forms.TextBox()
        Me.inputSobreMaximoArticulos = New System.Windows.Forms.TextBox()
        Me.inputExistenciasArticulo = New System.Windows.Forms.TextBox()
        Me.inputPrCostArticulos = New System.Windows.Forms.TextBox()
        Me.inputPrVentArticulos = New System.Windows.Forms.TextBox()
        Me.inputProveedorArticulo = New System.Windows.Forms.TextBox()
        Me.inputDescripcionArticulo = New System.Windows.Forms.TextBox()
        Me.inputIdArticulo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dataGridArticulos = New System.Windows.Forms.DataGridView()
        Me.comboCategoriaArticulos = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.partnersTab = New System.Windows.Forms.TabPage()
        Me.inputFechaRegistroPartnersDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inputFechaRegistroPartnersHasta = New System.Windows.Forms.DateTimePicker()
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
        Me.inputDNIComerciales = New System.Windows.Forms.TextBox()
        Me.labeldni = New System.Windows.Forms.Label()
        Me.inputDireccionComerciales = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.inputCorreoComerciales = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAltaComerciales = New System.Windows.Forms.Button()
        Me.btnBorrarComerciales = New System.Windows.Forms.Button()
        Me.btnConsultarComerciales = New System.Windows.Forms.Button()
        Me.dataGridComerciales = New System.Windows.Forms.DataGridView()
        Me.inputTelefonoComerciales = New System.Windows.Forms.TextBox()
        Me.inputApellidosComerciales = New System.Windows.Forms.TextBox()
        Me.inputNombreComerciales = New System.Windows.Forms.TextBox()
        Me.inputIdComerciales = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.comboZona2Comerciales = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.comboZonaComerciales = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.transportistasTab = New System.Windows.Forms.TabPage()
        Me.btnAltaTransportista = New System.Windows.Forms.Button()
        Me.btnBorrarTransportista = New System.Windows.Forms.Button()
        Me.btnConsultarTransportista = New System.Windows.Forms.Button()
        Me.dataGridTransportistas = New System.Windows.Forms.DataGridView()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.inputTelefonoTransportistas = New System.Windows.Forms.TextBox()
        Me.inputEmpresaTransportistas = New System.Windows.Forms.TextBox()
        Me.inputIdTransportistas = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Delegacion.DataSet1()
        Me.checkFechaRegistroDesdePartners = New System.Windows.Forms.CheckBox()
        Me.checkFechaRegistroHastaPartners = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.articulosTab.SuspendLayout()
        CType(Me.dataGridArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.partnersTab.SuspendLayout()
        CType(Me.dataGridPartners, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.comercialesTab.SuspendLayout()
        CType(Me.dataGridComerciales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.transportistasTab.SuspendLayout()
        CType(Me.dataGridTransportistas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.articulosTab.BackColor = System.Drawing.SystemColors.Control
        Me.articulosTab.Controls.Add(Me.Label1)
        Me.articulosTab.Controls.Add(Me.btnBorrarArticulos)
        Me.articulosTab.Controls.Add(Me.btnAltaArticulos)
        Me.articulosTab.Controls.Add(Me.btnConsultarArticulos)
        Me.articulosTab.Controls.Add(Me.inputBajoMinimoArticulos)
        Me.articulosTab.Controls.Add(Me.inputSobreMaximoArticulos)
        Me.articulosTab.Controls.Add(Me.inputExistenciasArticulo)
        Me.articulosTab.Controls.Add(Me.inputPrCostArticulos)
        Me.articulosTab.Controls.Add(Me.inputPrVentArticulos)
        Me.articulosTab.Controls.Add(Me.inputProveedorArticulo)
        Me.articulosTab.Controls.Add(Me.inputDescripcionArticulo)
        Me.articulosTab.Controls.Add(Me.inputIdArticulo)
        Me.articulosTab.Controls.Add(Me.Label9)
        Me.articulosTab.Controls.Add(Me.Label18)
        Me.articulosTab.Controls.Add(Me.Label12)
        Me.articulosTab.Controls.Add(Me.Label17)
        Me.articulosTab.Controls.Add(Me.Label10)
        Me.articulosTab.Controls.Add(Me.Label11)
        Me.articulosTab.Controls.Add(Me.Label14)
        Me.articulosTab.Controls.Add(Me.dataGridArticulos)
        Me.articulosTab.Controls.Add(Me.comboCategoriaArticulos)
        Me.articulosTab.Controls.Add(Me.Label16)
        Me.articulosTab.Location = New System.Drawing.Point(4, 25)
        Me.articulosTab.Name = "articulosTab"
        Me.articulosTab.Size = New System.Drawing.Size(1418, 951)
        Me.articulosTab.TabIndex = 3
        Me.articulosTab.Text = "Articulos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Descripción:"
        '
        'btnBorrarArticulos
        '
        Me.btnBorrarArticulos.Location = New System.Drawing.Point(1248, 65)
        Me.btnBorrarArticulos.Name = "btnBorrarArticulos"
        Me.btnBorrarArticulos.Size = New System.Drawing.Size(162, 32)
        Me.btnBorrarArticulos.TabIndex = 50
        Me.btnBorrarArticulos.Text = "Borrar"
        Me.btnBorrarArticulos.UseVisualStyleBackColor = True
        '
        'btnAltaArticulos
        '
        Me.btnAltaArticulos.Location = New System.Drawing.Point(1248, 107)
        Me.btnAltaArticulos.Name = "btnAltaArticulos"
        Me.btnAltaArticulos.Size = New System.Drawing.Size(162, 32)
        Me.btnAltaArticulos.TabIndex = 49
        Me.btnAltaArticulos.Text = "Alta"
        Me.btnAltaArticulos.UseVisualStyleBackColor = True
        '
        'btnConsultarArticulos
        '
        Me.btnConsultarArticulos.Location = New System.Drawing.Point(1248, 24)
        Me.btnConsultarArticulos.Name = "btnConsultarArticulos"
        Me.btnConsultarArticulos.Size = New System.Drawing.Size(162, 32)
        Me.btnConsultarArticulos.TabIndex = 48
        Me.btnConsultarArticulos.Text = "Consultar"
        Me.btnConsultarArticulos.UseVisualStyleBackColor = True
        '
        'inputBajoMinimoArticulos
        '
        Me.inputBajoMinimoArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputBajoMinimoArticulos.Location = New System.Drawing.Point(900, 117)
        Me.inputBajoMinimoArticulos.Name = "inputBajoMinimoArticulos"
        Me.inputBajoMinimoArticulos.Size = New System.Drawing.Size(252, 22)
        Me.inputBajoMinimoArticulos.TabIndex = 47
        '
        'inputSobreMaximoArticulos
        '
        Me.inputSobreMaximoArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputSobreMaximoArticulos.Location = New System.Drawing.Point(519, 117)
        Me.inputSobreMaximoArticulos.Name = "inputSobreMaximoArticulos"
        Me.inputSobreMaximoArticulos.Size = New System.Drawing.Size(252, 22)
        Me.inputSobreMaximoArticulos.TabIndex = 45
        '
        'inputExistenciasArticulo
        '
        Me.inputExistenciasArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputExistenciasArticulo.Location = New System.Drawing.Point(519, 69)
        Me.inputExistenciasArticulo.Name = "inputExistenciasArticulo"
        Me.inputExistenciasArticulo.Size = New System.Drawing.Size(252, 22)
        Me.inputExistenciasArticulo.TabIndex = 44
        '
        'inputPrCostArticulos
        '
        Me.inputPrCostArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPrCostArticulos.Location = New System.Drawing.Point(900, 26)
        Me.inputPrCostArticulos.Name = "inputPrCostArticulos"
        Me.inputPrCostArticulos.Size = New System.Drawing.Size(252, 22)
        Me.inputPrCostArticulos.TabIndex = 42
        '
        'inputPrVentArticulos
        '
        Me.inputPrVentArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPrVentArticulos.Location = New System.Drawing.Point(900, 71)
        Me.inputPrVentArticulos.Name = "inputPrVentArticulos"
        Me.inputPrVentArticulos.Size = New System.Drawing.Size(252, 22)
        Me.inputPrVentArticulos.TabIndex = 40
        '
        'inputProveedorArticulo
        '
        Me.inputProveedorArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputProveedorArticulo.Location = New System.Drawing.Point(145, 116)
        Me.inputProveedorArticulo.Name = "inputProveedorArticulo"
        Me.inputProveedorArticulo.Size = New System.Drawing.Size(252, 22)
        Me.inputProveedorArticulo.TabIndex = 38
        '
        'inputDescripcionArticulo
        '
        Me.inputDescripcionArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputDescripcionArticulo.Location = New System.Drawing.Point(145, 70)
        Me.inputDescripcionArticulo.Name = "inputDescripcionArticulo"
        Me.inputDescripcionArticulo.Size = New System.Drawing.Size(252, 22)
        Me.inputDescripcionArticulo.TabIndex = 34
        '
        'inputIdArticulo
        '
        Me.inputIdArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdArticulo.Location = New System.Drawing.Point(145, 25)
        Me.inputIdArticulo.Name = "inputIdArticulo"
        Me.inputIdArticulo.Size = New System.Drawing.Size(252, 22)
        Me.inputIdArticulo.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(810, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 16)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Bajo Minimo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(435, 71)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 16)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Existencias"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(804, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 16)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Precio Coste:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(806, 73)
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(416, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 16)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Sobre Maximo"
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
        Me.comboCategoriaArticulos.Location = New System.Drawing.Point(519, 23)
        Me.comboCategoriaArticulos.Name = "comboCategoriaArticulos"
        Me.comboCategoriaArticulos.Size = New System.Drawing.Size(252, 24)
        Me.comboCategoriaArticulos.TabIndex = 18
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(435, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 16)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Categoria:"
        '
        'partnersTab
        '
        Me.partnersTab.BackColor = System.Drawing.SystemColors.Control
        Me.partnersTab.Controls.Add(Me.checkFechaRegistroHastaPartners)
        Me.partnersTab.Controls.Add(Me.checkFechaRegistroDesdePartners)
        Me.partnersTab.Controls.Add(Me.inputFechaRegistroPartnersDesde)
        Me.partnersTab.Controls.Add(Me.Label3)
        Me.partnersTab.Controls.Add(Me.inputFechaRegistroPartnersHasta)
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
        Me.partnersTab.Size = New System.Drawing.Size(1418, 951)
        Me.partnersTab.TabIndex = 1
        Me.partnersTab.Text = "Partners"
        '
        'inputFechaRegistroPartnersDesde
        '
        Me.inputFechaRegistroPartnersDesde.CustomFormat = ""
        Me.inputFechaRegistroPartnersDesde.Enabled = False
        Me.inputFechaRegistroPartnersDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.inputFechaRegistroPartnersDesde.Location = New System.Drawing.Point(588, 71)
        Me.inputFechaRegistroPartnersDesde.Name = "inputFechaRegistroPartnersDesde"
        Me.inputFechaRegistroPartnersDesde.Size = New System.Drawing.Size(157, 22)
        Me.inputFechaRegistroPartnersDesde.TabIndex = 77
        Me.inputFechaRegistroPartnersDesde.Value = New Date(2023, 12, 16, 19, 57, 19, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(434, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 16)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Fecha Registro Desde: "
        '
        'inputFechaRegistroPartnersHasta
        '
        Me.inputFechaRegistroPartnersHasta.CustomFormat = ""
        Me.inputFechaRegistroPartnersHasta.Enabled = False
        Me.inputFechaRegistroPartnersHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.inputFechaRegistroPartnersHasta.Location = New System.Drawing.Point(588, 117)
        Me.inputFechaRegistroPartnersHasta.Name = "inputFechaRegistroPartnersHasta"
        Me.inputFechaRegistroPartnersHasta.Size = New System.Drawing.Size(157, 22)
        Me.inputFechaRegistroPartnersHasta.TabIndex = 75
        Me.inputFechaRegistroPartnersHasta.Value = New Date(2023, 12, 16, 19, 57, 19, 0)
        '
        'btnBorrarPartners
        '
        Me.btnBorrarPartners.Location = New System.Drawing.Point(1248, 67)
        Me.btnBorrarPartners.Name = "btnBorrarPartners"
        Me.btnBorrarPartners.Size = New System.Drawing.Size(162, 32)
        Me.btnBorrarPartners.TabIndex = 74
        Me.btnBorrarPartners.Text = "Borrar"
        Me.btnBorrarPartners.UseVisualStyleBackColor = True
        '
        'btnAltaPartners
        '
        Me.btnAltaPartners.Location = New System.Drawing.Point(1248, 108)
        Me.btnAltaPartners.Name = "btnAltaPartners"
        Me.btnAltaPartners.Size = New System.Drawing.Size(162, 32)
        Me.btnAltaPartners.TabIndex = 73
        Me.btnAltaPartners.Text = "Alta"
        Me.btnAltaPartners.UseVisualStyleBackColor = True
        '
        'btnConsultarPartners
        '
        Me.btnConsultarPartners.Location = New System.Drawing.Point(1248, 25)
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
        Me.inputCorreoPartners.Size = New System.Drawing.Size(254, 22)
        Me.inputCorreoPartners.TabIndex = 71
        '
        'inputNombrePartners
        '
        Me.inputNombrePartners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNombrePartners.Location = New System.Drawing.Point(142, 70)
        Me.inputNombrePartners.Name = "inputNombrePartners"
        Me.inputNombrePartners.Size = New System.Drawing.Size(254, 22)
        Me.inputNombrePartners.TabIndex = 69
        '
        'inputIdPartner
        '
        Me.inputIdPartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdPartner.Location = New System.Drawing.Point(142, 25)
        Me.inputIdPartner.Name = "inputIdPartner"
        Me.inputIdPartner.Size = New System.Drawing.Size(254, 22)
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
        Me.comboZonaPartners.Location = New System.Drawing.Point(588, 25)
        Me.comboZonaPartners.Name = "comboZonaPartners"
        Me.comboZonaPartners.Size = New System.Drawing.Size(190, 24)
        Me.comboZonaPartners.TabIndex = 64
        '
        'inputTelefonoPartners
        '
        Me.inputTelefonoPartners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputTelefonoPartners.Location = New System.Drawing.Point(907, 120)
        Me.inputTelefonoPartners.Name = "inputTelefonoPartners"
        Me.inputTelefonoPartners.Size = New System.Drawing.Size(254, 22)
        Me.inputTelefonoPartners.TabIndex = 56
        '
        'inputDireccionPartners
        '
        Me.inputDireccionPartners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputDireccionPartners.Location = New System.Drawing.Point(905, 73)
        Me.inputDireccionPartners.Name = "inputDireccionPartners"
        Me.inputDireccionPartners.Size = New System.Drawing.Size(256, 22)
        Me.inputDireccionPartners.TabIndex = 54
        '
        'inputCifPartners
        '
        Me.inputCifPartners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputCifPartners.Location = New System.Drawing.Point(905, 25)
        Me.inputCifPartners.Name = "inputCifPartners"
        Me.inputCifPartners.Size = New System.Drawing.Size(256, 22)
        Me.inputCifPartners.TabIndex = 52
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(434, 119)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(144, 16)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Fecha Registro Hasta: "
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
        Me.Label22.Location = New System.Drawing.Point(837, 122)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(61, 16)
        Me.Label22.TabIndex = 55
        Me.Label22.Text = "Telefono"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(834, 76)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 16)
        Me.Label23.TabIndex = 53
        Me.Label23.Text = "Direccion"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(868, 27)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(30, 16)
        Me.Label25.TabIndex = 51
        Me.Label25.Text = "CIF:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(522, 30)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(57, 16)
        Me.Label27.TabIndex = 35
        Me.Label27.Text = "ID Zona:"
        '
        'comercialesTab
        '
        Me.comercialesTab.BackColor = System.Drawing.SystemColors.Control
        Me.comercialesTab.Controls.Add(Me.inputDNIComerciales)
        Me.comercialesTab.Controls.Add(Me.labeldni)
        Me.comercialesTab.Controls.Add(Me.inputDireccionComerciales)
        Me.comercialesTab.Controls.Add(Me.Label6)
        Me.comercialesTab.Controls.Add(Me.inputCorreoComerciales)
        Me.comercialesTab.Controls.Add(Me.Label5)
        Me.comercialesTab.Controls.Add(Me.btnAltaComerciales)
        Me.comercialesTab.Controls.Add(Me.btnBorrarComerciales)
        Me.comercialesTab.Controls.Add(Me.btnConsultarComerciales)
        Me.comercialesTab.Controls.Add(Me.dataGridComerciales)
        Me.comercialesTab.Controls.Add(Me.inputTelefonoComerciales)
        Me.comercialesTab.Controls.Add(Me.inputApellidosComerciales)
        Me.comercialesTab.Controls.Add(Me.inputNombreComerciales)
        Me.comercialesTab.Controls.Add(Me.inputIdComerciales)
        Me.comercialesTab.Controls.Add(Me.Label31)
        Me.comercialesTab.Controls.Add(Me.Label32)
        Me.comercialesTab.Controls.Add(Me.Label34)
        Me.comercialesTab.Controls.Add(Me.Label35)
        Me.comercialesTab.Controls.Add(Me.comboZona2Comerciales)
        Me.comercialesTab.Controls.Add(Me.Label36)
        Me.comercialesTab.Controls.Add(Me.comboZonaComerciales)
        Me.comercialesTab.Controls.Add(Me.Label37)
        Me.comercialesTab.Location = New System.Drawing.Point(4, 25)
        Me.comercialesTab.Name = "comercialesTab"
        Me.comercialesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.comercialesTab.Size = New System.Drawing.Size(1418, 951)
        Me.comercialesTab.TabIndex = 0
        Me.comercialesTab.Text = "Comerciales"
        '
        'inputDNIComerciales
        '
        Me.inputDNIComerciales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputDNIComerciales.Location = New System.Drawing.Point(898, 122)
        Me.inputDNIComerciales.Name = "inputDNIComerciales"
        Me.inputDNIComerciales.Size = New System.Drawing.Size(278, 22)
        Me.inputDNIComerciales.TabIndex = 80
        '
        'labeldni
        '
        Me.labeldni.AutoSize = True
        Me.labeldni.Location = New System.Drawing.Point(856, 124)
        Me.labeldni.Name = "labeldni"
        Me.labeldni.Size = New System.Drawing.Size(33, 16)
        Me.labeldni.TabIndex = 79
        Me.labeldni.Text = "DNI:"
        '
        'inputDireccionComerciales
        '
        Me.inputDireccionComerciales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputDireccionComerciales.Location = New System.Drawing.Point(898, 75)
        Me.inputDireccionComerciales.Name = "inputDireccionComerciales"
        Me.inputDireccionComerciales.Size = New System.Drawing.Size(278, 22)
        Me.inputDireccionComerciales.TabIndex = 78
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(825, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 16)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Direccion:"
        '
        'inputCorreoComerciales
        '
        Me.inputCorreoComerciales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputCorreoComerciales.Location = New System.Drawing.Point(898, 31)
        Me.inputCorreoComerciales.Name = "inputCorreoComerciales"
        Me.inputCorreoComerciales.Size = New System.Drawing.Size(278, 22)
        Me.inputCorreoComerciales.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(841, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Correo:"
        '
        'btnAltaComerciales
        '
        Me.btnAltaComerciales.Location = New System.Drawing.Point(1248, 108)
        Me.btnAltaComerciales.Name = "btnAltaComerciales"
        Me.btnAltaComerciales.Size = New System.Drawing.Size(162, 31)
        Me.btnAltaComerciales.TabIndex = 74
        Me.btnAltaComerciales.Text = "Alta"
        Me.btnAltaComerciales.UseVisualStyleBackColor = True
        '
        'btnBorrarComerciales
        '
        Me.btnBorrarComerciales.Location = New System.Drawing.Point(1248, 67)
        Me.btnBorrarComerciales.Name = "btnBorrarComerciales"
        Me.btnBorrarComerciales.Size = New System.Drawing.Size(162, 31)
        Me.btnBorrarComerciales.TabIndex = 73
        Me.btnBorrarComerciales.Text = "Borrar"
        Me.btnBorrarComerciales.UseVisualStyleBackColor = True
        '
        'btnConsultarComerciales
        '
        Me.btnConsultarComerciales.Location = New System.Drawing.Point(1248, 25)
        Me.btnConsultarComerciales.Name = "btnConsultarComerciales"
        Me.btnConsultarComerciales.Size = New System.Drawing.Size(162, 31)
        Me.btnConsultarComerciales.TabIndex = 72
        Me.btnConsultarComerciales.Text = "Consultar"
        Me.btnConsultarComerciales.UseVisualStyleBackColor = True
        '
        'dataGridComerciales
        '
        Me.dataGridComerciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridComerciales.Location = New System.Drawing.Point(56, 176)
        Me.dataGridComerciales.Name = "dataGridComerciales"
        Me.dataGridComerciales.RowHeadersWidth = 51
        Me.dataGridComerciales.RowTemplate.Height = 24
        Me.dataGridComerciales.Size = New System.Drawing.Size(1294, 590)
        Me.dataGridComerciales.TabIndex = 71
        '
        'inputTelefonoComerciales
        '
        Me.inputTelefonoComerciales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputTelefonoComerciales.Location = New System.Drawing.Point(507, 120)
        Me.inputTelefonoComerciales.Name = "inputTelefonoComerciales"
        Me.inputTelefonoComerciales.Size = New System.Drawing.Size(278, 22)
        Me.inputTelefonoComerciales.TabIndex = 61
        '
        'inputApellidosComerciales
        '
        Me.inputApellidosComerciales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputApellidosComerciales.Location = New System.Drawing.Point(148, 118)
        Me.inputApellidosComerciales.Name = "inputApellidosComerciales"
        Me.inputApellidosComerciales.Size = New System.Drawing.Size(278, 22)
        Me.inputApellidosComerciales.TabIndex = 59
        '
        'inputNombreComerciales
        '
        Me.inputNombreComerciales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNombreComerciales.Location = New System.Drawing.Point(148, 72)
        Me.inputNombreComerciales.Name = "inputNombreComerciales"
        Me.inputNombreComerciales.Size = New System.Drawing.Size(278, 22)
        Me.inputNombreComerciales.TabIndex = 57
        '
        'inputIdComerciales
        '
        Me.inputIdComerciales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdComerciales.Location = New System.Drawing.Point(148, 27)
        Me.inputIdComerciales.Name = "inputIdComerciales"
        Me.inputIdComerciales.Size = New System.Drawing.Size(278, 22)
        Me.inputIdComerciales.TabIndex = 53
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(440, 124)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(61, 16)
        Me.Label31.TabIndex = 60
        Me.Label31.Text = "Telefono"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(44, 120)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(67, 16)
        Me.Label32.TabIndex = 58
        Me.Label32.Text = "Apellidos:"
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
        Me.comboZona2Comerciales.Location = New System.Drawing.Point(507, 72)
        Me.comboZona2Comerciales.Name = "comboZona2Comerciales"
        Me.comboZona2Comerciales.Size = New System.Drawing.Size(278, 24)
        Me.comboZona2Comerciales.TabIndex = 52
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(454, 78)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(48, 16)
        Me.Label36.TabIndex = 51
        Me.Label36.Text = "Zona2:"
        '
        'comboZonaComerciales
        '
        Me.comboZonaComerciales.FormattingEnabled = True
        Me.comboZonaComerciales.Location = New System.Drawing.Point(507, 30)
        Me.comboZonaComerciales.Name = "comboZonaComerciales"
        Me.comboZonaComerciales.Size = New System.Drawing.Size(278, 24)
        Me.comboZonaComerciales.TabIndex = 49
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(461, 33)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(41, 16)
        Me.Label37.TabIndex = 48
        Me.Label37.Text = "Zona:"
        '
        'transportistasTab
        '
        Me.transportistasTab.BackColor = System.Drawing.SystemColors.Control
        Me.transportistasTab.Controls.Add(Me.btnAltaTransportista)
        Me.transportistasTab.Controls.Add(Me.btnBorrarTransportista)
        Me.transportistasTab.Controls.Add(Me.btnConsultarTransportista)
        Me.transportistasTab.Controls.Add(Me.dataGridTransportistas)
        Me.transportistasTab.Controls.Add(Me.Label39)
        Me.transportistasTab.Controls.Add(Me.inputTelefonoTransportistas)
        Me.transportistasTab.Controls.Add(Me.inputEmpresaTransportistas)
        Me.transportistasTab.Controls.Add(Me.inputIdTransportistas)
        Me.transportistasTab.Controls.Add(Me.Label38)
        Me.transportistasTab.Controls.Add(Me.Label46)
        Me.transportistasTab.Location = New System.Drawing.Point(4, 25)
        Me.transportistasTab.Name = "transportistasTab"
        Me.transportistasTab.Size = New System.Drawing.Size(1418, 951)
        Me.transportistasTab.TabIndex = 6
        Me.transportistasTab.Text = "Transportistas"
        '
        'btnAltaTransportista
        '
        Me.btnAltaTransportista.Location = New System.Drawing.Point(537, 118)
        Me.btnAltaTransportista.Name = "btnAltaTransportista"
        Me.btnAltaTransportista.Size = New System.Drawing.Size(162, 31)
        Me.btnAltaTransportista.TabIndex = 85
        Me.btnAltaTransportista.Text = "Alta"
        Me.btnAltaTransportista.UseVisualStyleBackColor = True
        '
        'btnBorrarTransportista
        '
        Me.btnBorrarTransportista.Location = New System.Drawing.Point(537, 74)
        Me.btnBorrarTransportista.Name = "btnBorrarTransportista"
        Me.btnBorrarTransportista.Size = New System.Drawing.Size(162, 31)
        Me.btnBorrarTransportista.TabIndex = 84
        Me.btnBorrarTransportista.Text = "Borrar"
        Me.btnBorrarTransportista.UseVisualStyleBackColor = True
        '
        'btnConsultarTransportista
        '
        Me.btnConsultarTransportista.Location = New System.Drawing.Point(537, 29)
        Me.btnConsultarTransportista.Name = "btnConsultarTransportista"
        Me.btnConsultarTransportista.Size = New System.Drawing.Size(162, 31)
        Me.btnConsultarTransportista.TabIndex = 83
        Me.btnConsultarTransportista.Text = "Consultar"
        Me.btnConsultarTransportista.UseVisualStyleBackColor = True
        '
        'dataGridTransportistas
        '
        Me.dataGridTransportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridTransportistas.Location = New System.Drawing.Point(56, 176)
        Me.dataGridTransportistas.Name = "dataGridTransportistas"
        Me.dataGridTransportistas.RowHeadersWidth = 51
        Me.dataGridTransportistas.RowTemplate.Height = 24
        Me.dataGridTransportistas.Size = New System.Drawing.Size(1294, 590)
        Me.dataGridTransportistas.TabIndex = 82
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(97, 132)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(64, 16)
        Me.Label39.TabIndex = 81
        Me.Label39.Text = "Telefono:"
        '
        'inputTelefonoTransportistas
        '
        Me.inputTelefonoTransportistas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputTelefonoTransportistas.Location = New System.Drawing.Point(173, 128)
        Me.inputTelefonoTransportistas.Name = "inputTelefonoTransportistas"
        Me.inputTelefonoTransportistas.Size = New System.Drawing.Size(303, 22)
        Me.inputTelefonoTransportistas.TabIndex = 80
        '
        'inputEmpresaTransportistas
        '
        Me.inputEmpresaTransportistas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputEmpresaTransportistas.Location = New System.Drawing.Point(173, 78)
        Me.inputEmpresaTransportistas.Name = "inputEmpresaTransportistas"
        Me.inputEmpresaTransportistas.Size = New System.Drawing.Size(303, 22)
        Me.inputEmpresaTransportistas.TabIndex = 78
        '
        'inputIdTransportistas
        '
        Me.inputIdTransportistas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdTransportistas.Location = New System.Drawing.Point(173, 28)
        Me.inputIdTransportistas.Name = "inputIdTransportistas"
        Me.inputIdTransportistas.Size = New System.Drawing.Size(303, 22)
        Me.inputIdTransportistas.TabIndex = 76
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(101, 80)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(65, 16)
        Me.Label38.TabIndex = 79
        Me.Label38.Text = "Empresa:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(59, 29)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(105, 16)
        Me.Label46.TabIndex = 77
        Me.Label46.Text = "ID Transportista:"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.DataSet1
        Me.BindingSource1.Position = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'checkFechaRegistroDesdePartners
        '
        Me.checkFechaRegistroDesdePartners.AutoSize = True
        Me.checkFechaRegistroDesdePartners.Location = New System.Drawing.Point(760, 73)
        Me.checkFechaRegistroDesdePartners.Name = "checkFechaRegistroDesdePartners"
        Me.checkFechaRegistroDesdePartners.Size = New System.Drawing.Size(18, 17)
        Me.checkFechaRegistroDesdePartners.TabIndex = 78
        Me.checkFechaRegistroDesdePartners.UseVisualStyleBackColor = True
        '
        'checkFechaRegistroHastaPartners
        '
        Me.checkFechaRegistroHastaPartners.AutoSize = True
        Me.checkFechaRegistroHastaPartners.Location = New System.Drawing.Point(760, 119)
        Me.checkFechaRegistroHastaPartners.Name = "checkFechaRegistroHastaPartners"
        Me.checkFechaRegistroHastaPartners.Size = New System.Drawing.Size(18, 17)
        Me.checkFechaRegistroHastaPartners.TabIndex = 79
        Me.checkFechaRegistroHastaPartners.UseVisualStyleBackColor = True
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
        CType(Me.dataGridComerciales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.transportistasTab.ResumeLayout(False)
        Me.transportistasTab.PerformLayout()
        CType(Me.dataGridTransportistas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents articulosTab As TabPage
    Friend WithEvents inputBajoMinimoArticulos As TextBox
    Friend WithEvents inputSobreMaximoArticulos As TextBox
    Friend WithEvents inputExistenciasArticulo As TextBox
    Friend WithEvents inputPrCostArticulos As TextBox
    Friend WithEvents inputPrVentArticulos As TextBox
    Friend WithEvents inputProveedorArticulo As TextBox
    Friend WithEvents inputDescripcionArticulo As TextBox
    Friend WithEvents inputIdArticulo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
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
    Friend WithEvents dataGridComerciales As DataGridView
    Friend WithEvents inputTelefonoComerciales As TextBox
    Friend WithEvents inputApellidosComerciales As TextBox
    Friend WithEvents inputNombreComerciales As TextBox
    Friend WithEvents inputIdComerciales As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents comboZona2Comerciales As ComboBox
    Friend WithEvents Label36 As Label
    Friend WithEvents comboZonaComerciales As ComboBox
    Friend WithEvents Label37 As Label
    Friend WithEvents transportistasTab As TabPage
    Friend WithEvents dataGridTransportistas As DataGridView
    Friend WithEvents Label39 As Label
    Friend WithEvents inputTelefonoTransportistas As TextBox
    Friend WithEvents inputEmpresaTransportistas As TextBox
    Friend WithEvents inputIdTransportistas As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents btnConsultarArticulos As Button
    Friend WithEvents btnConsultarComerciales As Button
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
    Friend WithEvents inputFechaRegistroPartnersHasta As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents inputFechaRegistroPartnersDesde As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents btnAltaComerciales As Button
    Friend WithEvents btnBorrarComerciales As Button
    Friend WithEvents inputDNIComerciales As TextBox
    Friend WithEvents labeldni As Label
    Friend WithEvents inputDireccionComerciales As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents inputCorreoComerciales As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAltaTransportista As Button
    Friend WithEvents btnBorrarTransportista As Button
    Friend WithEvents btnConsultarTransportista As Button
    Friend WithEvents checkFechaRegistroHastaPartners As CheckBox
    Friend WithEvents checkFechaRegistroDesdePartners As CheckBox
End Class
