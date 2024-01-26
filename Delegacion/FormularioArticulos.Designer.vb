<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioArticulos))
        Me.inputExistenciasArticulos = New System.Windows.Forms.TextBox()
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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnAbajo = New System.Windows.Forms.Button()
        Me.inputCategoriaArticulos = New System.Windows.Forms.TextBox()
        Me.inputPrCostArticulos = New System.Windows.Forms.TextBox()
        Me.inputBajoMinimoArticulos = New System.Windows.Forms.TextBox()
        Me.inputSobreMaximoArticulos = New System.Windows.Forms.TextBox()
        Me.inputPrVentArticulos = New System.Windows.Forms.TextBox()
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
        Me.btnEliminarFoto = New System.Windows.Forms.Button()
        Me.btnEditarFoto = New System.Windows.Forms.Button()
        Me.pictureboxArticulos = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.BindNavigatorArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindNavigatorArticulo.SuspendLayout()
        CType(Me.pictureboxArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inputExistenciasArticulos
        '
        Me.inputExistenciasArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputExistenciasArticulos.Enabled = False
        Me.inputExistenciasArticulos.Location = New System.Drawing.Point(297, 219)
        Me.inputExistenciasArticulos.Name = "inputExistenciasArticulos"
        Me.inputExistenciasArticulos.Size = New System.Drawing.Size(148, 22)
        Me.inputExistenciasArticulos.TabIndex = 57
        '
        'inputProveedorArticulos
        '
        Me.inputProveedorArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputProveedorArticulos.Enabled = False
        Me.inputProveedorArticulos.Location = New System.Drawing.Point(297, 178)
        Me.inputProveedorArticulos.Name = "inputProveedorArticulos"
        Me.inputProveedorArticulos.Size = New System.Drawing.Size(148, 22)
        Me.inputProveedorArticulos.TabIndex = 56
        '
        'inputDescripcionArticulos
        '
        Me.inputDescripcionArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputDescripcionArticulos.Enabled = False
        Me.inputDescripcionArticulos.Location = New System.Drawing.Point(36, 372)
        Me.inputDescripcionArticulos.Multiline = True
        Me.inputDescripcionArticulos.Name = "inputDescripcionArticulos"
        Me.inputDescripcionArticulos.Size = New System.Drawing.Size(406, 121)
        Me.inputDescripcionArticulos.TabIndex = 62
        '
        'inputNombreArticulos
        '
        Me.inputNombreArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNombreArticulos.Enabled = False
        Me.inputNombreArticulos.Location = New System.Drawing.Point(297, 91)
        Me.inputNombreArticulos.Name = "inputNombreArticulos"
        Me.inputNombreArticulos.Size = New System.Drawing.Size(148, 22)
        Me.inputNombreArticulos.TabIndex = 53
        '
        'inputIdArticulo
        '
        Me.inputIdArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdArticulo.Enabled = False
        Me.inputIdArticulo.Location = New System.Drawing.Point(297, 50)
        Me.inputIdArticulo.Name = "inputIdArticulo"
        Me.inputIdArticulo.Size = New System.Drawing.Size(148, 22)
        Me.inputIdArticulo.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 311)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 16)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Bajo Minimo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(206, 222)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 16)
        Me.Label18.TabIndex = 65
        Me.Label18.Text = "Existencias: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(33, 271)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 16)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Precio coste:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(251, 272)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 16)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "Precio venta:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(210, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 16)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Proveedor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 352)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Descripción"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(242, 313)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 16)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Sobre Maximo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(221, 93)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 16)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Nombre:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(209, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 16)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "ID Articulo:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(214, 137)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 16)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Categoria:"
        '
        'btnAbajo
        '
        Me.btnAbajo.Location = New System.Drawing.Point(36, 530)
        Me.btnAbajo.Name = "btnAbajo"
        Me.btnAbajo.Size = New System.Drawing.Size(409, 36)
        Me.btnAbajo.TabIndex = 70
        Me.btnAbajo.Text = "Listo"
        Me.btnAbajo.UseVisualStyleBackColor = True
        '
        'inputCategoriaArticulos
        '
        Me.inputCategoriaArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputCategoriaArticulos.Location = New System.Drawing.Point(297, 136)
        Me.inputCategoriaArticulos.Name = "inputCategoriaArticulos"
        Me.inputCategoriaArticulos.Size = New System.Drawing.Size(148, 22)
        Me.inputCategoriaArticulos.TabIndex = 54
        '
        'inputPrCostArticulos
        '
        Me.inputPrCostArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPrCostArticulos.Location = New System.Drawing.Point(127, 271)
        Me.inputPrCostArticulos.Name = "inputPrCostArticulos"
        Me.inputPrCostArticulos.Size = New System.Drawing.Size(100, 22)
        Me.inputPrCostArticulos.TabIndex = 58
        '
        'inputBajoMinimoArticulos
        '
        Me.inputBajoMinimoArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputBajoMinimoArticulos.Location = New System.Drawing.Point(127, 310)
        Me.inputBajoMinimoArticulos.Name = "inputBajoMinimoArticulos"
        Me.inputBajoMinimoArticulos.Size = New System.Drawing.Size(100, 22)
        Me.inputBajoMinimoArticulos.TabIndex = 60
        '
        'inputSobreMaximoArticulos
        '
        Me.inputSobreMaximoArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputSobreMaximoArticulos.Location = New System.Drawing.Point(345, 312)
        Me.inputSobreMaximoArticulos.Name = "inputSobreMaximoArticulos"
        Me.inputSobreMaximoArticulos.Size = New System.Drawing.Size(100, 22)
        Me.inputSobreMaximoArticulos.TabIndex = 61
        '
        'inputPrVentArticulos
        '
        Me.inputPrVentArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPrVentArticulos.Location = New System.Drawing.Point(345, 270)
        Me.inputPrVentArticulos.Name = "inputPrVentArticulos"
        Me.inputPrVentArticulos.Size = New System.Drawing.Size(100, 22)
        Me.inputPrVentArticulos.TabIndex = 59
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
        Me.BindNavigatorArticulo.Size = New System.Drawing.Size(706, 31)
        Me.BindNavigatorArticulo.TabIndex = 85
        Me.BindNavigatorArticulo.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 28)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'BtnEditar
        '
        Me.BtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEditar.Image = Global.Delegacion.My.Resources.Resources.editar
        Me.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(29, 28)
        Me.BtnEditar.Text = "Editar"
        '
        'BtnAñadir
        '
        Me.BtnAñadir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAñadir.Image = CType(resources.GetObject("BtnAñadir.Image"), System.Drawing.Image)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.RightToLeftAutoMirrorImage = True
        Me.BtnAñadir.Size = New System.Drawing.Size(29, 28)
        Me.BtnAñadir.Text = "Agregar nuevo"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.RightToLeftAutoMirrorImage = True
        Me.BtnEliminar.Size = New System.Drawing.Size(29, 28)
        Me.BtnEliminar.Text = "Eliminar"
        '
        'btnEliminarFoto
        '
        Me.btnEliminarFoto.BackgroundImage = CType(resources.GetObject("btnEliminarFoto.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarFoto.Location = New System.Drawing.Point(42, 56)
        Me.btnEliminarFoto.Name = "btnEliminarFoto"
        Me.btnEliminarFoto.Size = New System.Drawing.Size(31, 31)
        Me.btnEliminarFoto.TabIndex = 64
        Me.btnEliminarFoto.UseVisualStyleBackColor = True
        '
        'btnEditarFoto
        '
        Me.btnEditarFoto.BackgroundImage = Global.Delegacion.My.Resources.Resources.editar
        Me.btnEditarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditarFoto.Location = New System.Drawing.Point(154, 57)
        Me.btnEditarFoto.Name = "btnEditarFoto"
        Me.btnEditarFoto.Size = New System.Drawing.Size(31, 31)
        Me.btnEditarFoto.TabIndex = 65
        Me.btnEditarFoto.UseVisualStyleBackColor = True
        '
        'pictureboxArticulos
        '
        Me.pictureboxArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureboxArticulos.Location = New System.Drawing.Point(37, 52)
        Me.pictureboxArticulos.Name = "pictureboxArticulos"
        Me.pictureboxArticulos.Size = New System.Drawing.Size(153, 187)
        Me.pictureboxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureboxArticulos.TabIndex = 72
        Me.pictureboxArticulos.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(502, 137)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 292)
        Me.TextBox1.TabIndex = 86
        '
        'FormularioArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 598)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BindNavigatorArticulo)
        Me.Controls.Add(Me.btnEliminarFoto)
        Me.Controls.Add(Me.btnEditarFoto)
        Me.Controls.Add(Me.inputPrVentArticulos)
        Me.Controls.Add(Me.inputSobreMaximoArticulos)
        Me.Controls.Add(Me.inputBajoMinimoArticulos)
        Me.Controls.Add(Me.inputPrCostArticulos)
        Me.Controls.Add(Me.inputCategoriaArticulos)
        Me.Controls.Add(Me.pictureboxArticulos)
        Me.Controls.Add(Me.btnAbajo)
        Me.Controls.Add(Me.inputExistenciasArticulos)
        Me.Controls.Add(Me.inputProveedorArticulos)
        Me.Controls.Add(Me.inputDescripcionArticulos)
        Me.Controls.Add(Me.inputNombreArticulos)
        Me.Controls.Add(Me.inputIdArticulo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormularioArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.BindNavigatorArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindNavigatorArticulo.ResumeLayout(False)
        Me.BindNavigatorArticulo.PerformLayout()
        CType(Me.pictureboxArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inputExistenciasArticulos As TextBox
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
    Friend WithEvents Label16 As Label
    Friend WithEvents btnAbajo As Button
    Friend WithEvents pictureboxArticulos As PictureBox
    Friend WithEvents inputCategoriaArticulos As TextBox
    Friend WithEvents inputPrCostArticulos As TextBox
    Friend WithEvents inputBajoMinimoArticulos As TextBox
    Friend WithEvents inputSobreMaximoArticulos As TextBox
    Friend WithEvents inputPrVentArticulos As TextBox
    Friend WithEvents btnEditarFoto As Button
    Friend WithEvents btnEliminarFoto As Button
    Friend WithEvents BindNavigatorArticulo As BindingNavigator
    Friend WithEvents BtnAñadir As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BtnEliminar As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BtnEditar As ToolStripButton
    Friend WithEvents TextBox1 As TextBox
End Class
