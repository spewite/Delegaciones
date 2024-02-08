<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioPedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioPedidos))
        Me.BindNavigatorArticulo = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BtnAñadir = New System.Windows.Forms.ToolStripButton()
        Me.BtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.inputIdPedido = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.comboComercial = New System.Windows.Forms.ComboBox()
        Me.comboPartner = New System.Windows.Forms.ComboBox()
        Me.comboTransportista = New System.Windows.Forms.ComboBox()
        Me.comboEstadoPedido = New System.Windows.Forms.ComboBox()
        Me.btnAbajo = New System.Windows.Forms.Button()
        Me.inputFechaPedido = New System.Windows.Forms.DateTimePicker()
        Me.inputFechaEnvio = New System.Windows.Forms.DateTimePicker()
        Me.inputFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.btnAñadirLinea = New System.Windows.Forms.Button()
        Me.btnEliminarLinea = New System.Windows.Forms.Button()
        Me.btnImportarPedidos = New System.Windows.Forms.Button()
        Me.dataGridLineas = New System.Windows.Forms.DataGridView()
        Me.comboIdFactura = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.BindNavigatorArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindNavigatorArticulo.SuspendLayout()
        CType(Me.dataGridLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindNavigatorArticulo
        '
        Me.BindNavigatorArticulo.AddNewItem = Nothing
        Me.BindNavigatorArticulo.CountItem = Me.BindingNavigatorCountItem
        Me.BindNavigatorArticulo.DeleteItem = Nothing
        Me.BindNavigatorArticulo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindNavigatorArticulo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BtnEditar, Me.BtnAñadir, Me.BtnEliminar})
        Me.BindNavigatorArticulo.Location = New System.Drawing.Point(0, 0)
        Me.BindNavigatorArticulo.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindNavigatorArticulo.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindNavigatorArticulo.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindNavigatorArticulo.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindNavigatorArticulo.Name = "BindNavigatorArticulo"
        Me.BindNavigatorArticulo.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindNavigatorArticulo.Size = New System.Drawing.Size(1538, 27)
        Me.BindNavigatorArticulo.TabIndex = 110
        Me.BindNavigatorArticulo.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BtnEditar
        '
        Me.BtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEditar.Image = Global.Delegacion.My.Resources.Resources.editar
        Me.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(29, 24)
        Me.BtnEditar.Text = "Editar"
        '
        'BtnAñadir
        '
        Me.BtnAñadir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAñadir.Image = CType(resources.GetObject("BtnAñadir.Image"), System.Drawing.Image)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.RightToLeftAutoMirrorImage = True
        Me.BtnAñadir.Size = New System.Drawing.Size(29, 24)
        Me.BtnAñadir.Text = "Agregar nuevo"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.RightToLeftAutoMirrorImage = True
        Me.BtnEliminar.Size = New System.Drawing.Size(29, 24)
        Me.BtnEliminar.Text = "Eliminar"
        '
        'inputIdPedido
        '
        Me.inputIdPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdPedido.Enabled = False
        Me.inputIdPedido.Location = New System.Drawing.Point(135, 52)
        Me.inputIdPedido.Name = "inputIdPedido"
        Me.inputIdPedido.Size = New System.Drawing.Size(173, 22)
        Me.inputIdPedido.TabIndex = 87
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "Estado Pedido:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(630, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 16)
        Me.Label12.TabIndex = 103
        Me.Label12.Text = "Transportista:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(937, 55)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 16)
        Me.Label17.TabIndex = 101
        Me.Label17.Text = "Fecha Pedido:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(337, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 16)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Comercial:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(935, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 16)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Fecha Envio:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(55, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 16)
        Me.Label14.TabIndex = 88
        Me.Label14.Text = "ID Pedido:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(355, 55)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 16)
        Me.Label16.TabIndex = 86
        Me.Label16.Text = "Partner:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(1235, 103)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 16)
        Me.Label18.TabIndex = 106
        Me.Label18.Text = "Fecha Pago: "
        '
        'comboComercial
        '
        Me.comboComercial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboComercial.FormattingEnabled = True
        Me.comboComercial.Location = New System.Drawing.Point(419, 96)
        Me.comboComercial.Name = "comboComercial"
        Me.comboComercial.Size = New System.Drawing.Size(173, 24)
        Me.comboComercial.TabIndex = 113
        '
        'comboPartner
        '
        Me.comboPartner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboPartner.FormattingEnabled = True
        Me.comboPartner.Location = New System.Drawing.Point(419, 51)
        Me.comboPartner.Name = "comboPartner"
        Me.comboPartner.Size = New System.Drawing.Size(173, 24)
        Me.comboPartner.TabIndex = 114
        '
        'comboTransportista
        '
        Me.comboTransportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboTransportista.FormattingEnabled = True
        Me.comboTransportista.Location = New System.Drawing.Point(724, 51)
        Me.comboTransportista.Name = "comboTransportista"
        Me.comboTransportista.Size = New System.Drawing.Size(173, 24)
        Me.comboTransportista.TabIndex = 115
        '
        'comboEstadoPedido
        '
        Me.comboEstadoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboEstadoPedido.FormattingEnabled = True
        Me.comboEstadoPedido.Location = New System.Drawing.Point(135, 96)
        Me.comboEstadoPedido.Name = "comboEstadoPedido"
        Me.comboEstadoPedido.Size = New System.Drawing.Size(173, 24)
        Me.comboEstadoPedido.TabIndex = 116
        '
        'btnAbajo
        '
        Me.btnAbajo.Location = New System.Drawing.Point(1239, 44)
        Me.btnAbajo.Name = "btnAbajo"
        Me.btnAbajo.Size = New System.Drawing.Size(262, 37)
        Me.btnAbajo.TabIndex = 108
        Me.btnAbajo.Text = "Listo"
        Me.btnAbajo.UseVisualStyleBackColor = True
        '
        'inputFechaPedido
        '
        Me.inputFechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.inputFechaPedido.Location = New System.Drawing.Point(1038, 52)
        Me.inputFechaPedido.Name = "inputFechaPedido"
        Me.inputFechaPedido.Size = New System.Drawing.Size(173, 22)
        Me.inputFechaPedido.TabIndex = 117
        '
        'inputFechaEnvio
        '
        Me.inputFechaEnvio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.inputFechaEnvio.Location = New System.Drawing.Point(1039, 97)
        Me.inputFechaEnvio.Name = "inputFechaEnvio"
        Me.inputFechaEnvio.Size = New System.Drawing.Size(173, 22)
        Me.inputFechaEnvio.TabIndex = 118
        '
        'inputFechaPago
        '
        Me.inputFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.inputFechaPago.Location = New System.Drawing.Point(1326, 100)
        Me.inputFechaPago.Name = "inputFechaPago"
        Me.inputFechaPago.Size = New System.Drawing.Size(173, 22)
        Me.inputFechaPago.TabIndex = 119
        '
        'btnAñadirLinea
        '
        Me.btnAñadirLinea.Location = New System.Drawing.Point(46, 678)
        Me.btnAñadirLinea.Name = "btnAñadirLinea"
        Me.btnAñadirLinea.Size = New System.Drawing.Size(447, 36)
        Me.btnAñadirLinea.TabIndex = 120
        Me.btnAñadirLinea.Text = "Añadir Línea"
        Me.btnAñadirLinea.UseVisualStyleBackColor = True
        '
        'btnEliminarLinea
        '
        Me.btnEliminarLinea.Location = New System.Drawing.Point(535, 678)
        Me.btnEliminarLinea.Name = "btnEliminarLinea"
        Me.btnEliminarLinea.Size = New System.Drawing.Size(447, 36)
        Me.btnEliminarLinea.TabIndex = 121
        Me.btnEliminarLinea.Text = "Eliminar Línea(s)"
        Me.btnEliminarLinea.UseVisualStyleBackColor = True
        '
        'btnImportarPedidos
        '
        Me.btnImportarPedidos.Location = New System.Drawing.Point(1038, 678)
        Me.btnImportarPedidos.Name = "btnImportarPedidos"
        Me.btnImportarPedidos.Size = New System.Drawing.Size(461, 36)
        Me.btnImportarPedidos.TabIndex = 122
        Me.btnImportarPedidos.Text = "Importar Pedidos"
        Me.btnImportarPedidos.UseVisualStyleBackColor = True
        '
        'dataGridLineas
        '
        Me.dataGridLineas.AllowUserToAddRows = False
        Me.dataGridLineas.AllowUserToDeleteRows = False
        Me.dataGridLineas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridLineas.Location = New System.Drawing.Point(46, 158)
        Me.dataGridLineas.Name = "dataGridLineas"
        Me.dataGridLineas.ReadOnly = True
        Me.dataGridLineas.RowHeadersWidth = 51
        Me.dataGridLineas.RowTemplate.Height = 24
        Me.dataGridLineas.Size = New System.Drawing.Size(1453, 493)
        Me.dataGridLineas.TabIndex = 112
        '
        'comboIdFactura
        '
        Me.comboIdFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboIdFactura.FormattingEnabled = True
        Me.comboIdFactura.Location = New System.Drawing.Point(724, 95)
        Me.comboIdFactura.Name = "comboIdFactura"
        Me.comboIdFactura.Size = New System.Drawing.Size(173, 24)
        Me.comboIdFactura.TabIndex = 124
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(650, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "ID Factura:"
        '
        'FormularioPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1538, 733)
        Me.Controls.Add(Me.comboIdFactura)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImportarPedidos)
        Me.Controls.Add(Me.btnEliminarLinea)
        Me.Controls.Add(Me.btnAñadirLinea)
        Me.Controls.Add(Me.inputFechaPago)
        Me.Controls.Add(Me.inputFechaEnvio)
        Me.Controls.Add(Me.inputFechaPedido)
        Me.Controls.Add(Me.comboEstadoPedido)
        Me.Controls.Add(Me.comboTransportista)
        Me.Controls.Add(Me.comboPartner)
        Me.Controls.Add(Me.comboComercial)
        Me.Controls.Add(Me.dataGridLineas)
        Me.Controls.Add(Me.BindNavigatorArticulo)
        Me.Controls.Add(Me.btnAbajo)
        Me.Controls.Add(Me.inputIdPedido)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormularioPedidos"
        Me.Text = "Pedidos"
        CType(Me.BindNavigatorArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindNavigatorArticulo.ResumeLayout(False)
        Me.BindNavigatorArticulo.PerformLayout()
        CType(Me.dataGridLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAñadir As ToolStripButton
    Friend WithEvents BindNavigatorArticulo As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BtnEditar As ToolStripButton
    Friend WithEvents BtnEliminar As ToolStripButton
    Friend WithEvents inputIdPedido As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents comboComercial As ComboBox
    Friend WithEvents comboPartner As ComboBox
    Friend WithEvents comboTransportista As ComboBox
    Friend WithEvents comboEstadoPedido As ComboBox
    Friend WithEvents btnAbajo As Button
    Friend WithEvents inputFechaPedido As DateTimePicker
    Friend WithEvents inputFechaEnvio As DateTimePicker
    Friend WithEvents inputFechaPago As DateTimePicker
    Friend WithEvents btnAñadirLinea As Button
    Friend WithEvents btnEliminarLinea As Button
    Friend WithEvents btnImportarPedidos As Button
    Friend WithEvents dataGridLineas As DataGridView
    Friend WithEvents comboIdFactura As ComboBox
    Friend WithEvents Label1 As Label
End Class
