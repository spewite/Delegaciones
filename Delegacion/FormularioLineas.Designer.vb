<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioLineas
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioLineas))
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
        Me.btnAbajo = New System.Windows.Forms.Button()
        Me.inputDescuento = New System.Windows.Forms.TextBox()
        Me.inputCantidad = New System.Windows.Forms.TextBox()
        Me.inputIdLinea = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.inputPrecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboArticulo = New System.Windows.Forms.ComboBox()
        Me.comboIdPedido = New System.Windows.Forms.ComboBox()
        CType(Me.BindNavigatorArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindNavigatorArticulo.SuspendLayout()
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
        Me.BindNavigatorArticulo.Size = New System.Drawing.Size(415, 27)
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
        'btnAbajo
        '
        Me.btnAbajo.Location = New System.Drawing.Point(45, 437)
        Me.btnAbajo.Name = "btnAbajo"
        Me.btnAbajo.Size = New System.Drawing.Size(316, 36)
        Me.btnAbajo.TabIndex = 108
        Me.btnAbajo.Text = "Listo"
        Me.btnAbajo.UseVisualStyleBackColor = True
        '
        'inputDescuento
        '
        Me.inputDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputDescuento.Enabled = False
        Me.inputDescuento.Location = New System.Drawing.Point(149, 315)
        Me.inputDescuento.Name = "inputDescuento"
        Me.inputDescuento.Size = New System.Drawing.Size(184, 22)
        Me.inputDescuento.TabIndex = 95
        '
        'inputCantidad
        '
        Me.inputCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputCantidad.Enabled = False
        Me.inputCantidad.Location = New System.Drawing.Point(149, 252)
        Me.inputCantidad.Name = "inputCantidad"
        Me.inputCantidad.Size = New System.Drawing.Size(184, 22)
        Me.inputCantidad.TabIndex = 93
        '
        'inputIdLinea
        '
        Me.inputIdLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdLinea.Enabled = False
        Me.inputIdLinea.Location = New System.Drawing.Point(149, 59)
        Me.inputIdLinea.Name = "inputIdLinea"
        Me.inputIdLinea.Size = New System.Drawing.Size(184, 22)
        Me.inputIdLinea.TabIndex = 87
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(67, 316)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 16)
        Me.Label18.TabIndex = 106
        Me.Label18.Text = "Descuento:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(78, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Cantidad:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(72, 126)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 16)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "ID Pedido:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(80, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 16)
        Me.Label14.TabIndex = 88
        Me.Label14.Text = "ID Linea: "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(85, 190)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 16)
        Me.Label16.TabIndex = 86
        Me.Label16.Text = "Articulo: "
        '
        'inputPrecio
        '
        Me.inputPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPrecio.Enabled = False
        Me.inputPrecio.Location = New System.Drawing.Point(149, 378)
        Me.inputPrecio.Name = "inputPrecio"
        Me.inputPrecio.Size = New System.Drawing.Size(184, 22)
        Me.inputPrecio.TabIndex = 111
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "Precio: "
        '
        'comboArticulo
        '
        Me.comboArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboArticulo.FormattingEnabled = True
        Me.comboArticulo.Location = New System.Drawing.Point(149, 187)
        Me.comboArticulo.Name = "comboArticulo"
        Me.comboArticulo.Size = New System.Drawing.Size(184, 24)
        Me.comboArticulo.TabIndex = 113
        '
        'comboIdPedido
        '
        Me.comboIdPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboIdPedido.FormattingEnabled = True
        Me.comboIdPedido.Location = New System.Drawing.Point(149, 122)
        Me.comboIdPedido.Name = "comboIdPedido"
        Me.comboIdPedido.Size = New System.Drawing.Size(184, 24)
        Me.comboIdPedido.TabIndex = 114
        '
        'FormularioLineas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 509)
        Me.Controls.Add(Me.comboIdPedido)
        Me.Controls.Add(Me.comboArticulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inputPrecio)
        Me.Controls.Add(Me.BindNavigatorArticulo)
        Me.Controls.Add(Me.btnAbajo)
        Me.Controls.Add(Me.inputDescuento)
        Me.Controls.Add(Me.inputCantidad)
        Me.Controls.Add(Me.inputIdLinea)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.Name = "FormularioLineas"
        CType(Me.BindNavigatorArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindNavigatorArticulo.ResumeLayout(False)
        Me.BindNavigatorArticulo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents BtnAñadir As ToolStripButton
    Friend WithEvents BtnEliminar As ToolStripButton
    Friend WithEvents btnAbajo As Button
    Friend WithEvents inputDescuento As TextBox
    Friend WithEvents inputCantidad As TextBox
    Friend WithEvents inputIdLinea As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents inputPrecio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents comboArticulo As ComboBox
    Friend WithEvents comboIdPedido As ComboBox
End Class
