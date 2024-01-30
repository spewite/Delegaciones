<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioComerciales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioComerciales))
        Me.BindNavigatorComerciales = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.inputDNI = New System.Windows.Forms.TextBox()
        Me.inputDireccion = New System.Windows.Forms.TextBox()
        Me.inputCorreo = New System.Windows.Forms.TextBox()
        Me.inputTelefono = New System.Windows.Forms.TextBox()
        Me.btnAbajo = New System.Windows.Forms.Button()
        Me.inputApellidos = New System.Windows.Forms.TextBox()
        Me.inputNombre = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.comboIdComercial = New System.Windows.Forms.ComboBox()
        Me.comboZona = New System.Windows.Forms.ComboBox()
        CType(Me.BindNavigatorComerciales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindNavigatorComerciales.SuspendLayout()
        Me.SuspendLayout()
        '
        'BindNavigatorComerciales
        '
        Me.BindNavigatorComerciales.AddNewItem = Nothing
        Me.BindNavigatorComerciales.CountItem = Me.BindingNavigatorCountItem
        Me.BindNavigatorComerciales.DeleteItem = Nothing
        Me.BindNavigatorComerciales.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindNavigatorComerciales.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BtnEditar, Me.BtnAñadir, Me.BtnEliminar})
        Me.BindNavigatorComerciales.Location = New System.Drawing.Point(0, 0)
        Me.BindNavigatorComerciales.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindNavigatorComerciales.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindNavigatorComerciales.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindNavigatorComerciales.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindNavigatorComerciales.Name = "BindNavigatorComerciales"
        Me.BindNavigatorComerciales.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindNavigatorComerciales.Size = New System.Drawing.Size(408, 27)
        Me.BindNavigatorComerciales.TabIndex = 111
        Me.BindNavigatorComerciales.Text = "BindingNavigator1"
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
        'inputDNI
        '
        Me.inputDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputDNI.Location = New System.Drawing.Point(147, 370)
        Me.inputDNI.Name = "inputDNI"
        Me.inputDNI.Size = New System.Drawing.Size(184, 22)
        Me.inputDNI.TabIndex = 101
        '
        'inputDireccion
        '
        Me.inputDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputDireccion.Location = New System.Drawing.Point(147, 326)
        Me.inputDireccion.Name = "inputDireccion"
        Me.inputDireccion.Size = New System.Drawing.Size(184, 22)
        Me.inputDireccion.TabIndex = 98
        '
        'inputCorreo
        '
        Me.inputCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputCorreo.Location = New System.Drawing.Point(147, 282)
        Me.inputCorreo.Name = "inputCorreo"
        Me.inputCorreo.Size = New System.Drawing.Size(184, 22)
        Me.inputCorreo.TabIndex = 100
        '
        'inputTelefono
        '
        Me.inputTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputTelefono.Location = New System.Drawing.Point(147, 238)
        Me.inputTelefono.Name = "inputTelefono"
        Me.inputTelefono.Size = New System.Drawing.Size(184, 22)
        Me.inputTelefono.TabIndex = 97
        '
        'btnAbajo
        '
        Me.btnAbajo.Location = New System.Drawing.Point(66, 432)
        Me.btnAbajo.Name = "btnAbajo"
        Me.btnAbajo.Size = New System.Drawing.Size(272, 36)
        Me.btnAbajo.TabIndex = 109
        Me.btnAbajo.Text = "Listo"
        Me.btnAbajo.UseVisualStyleBackColor = True
        '
        'inputApellidos
        '
        Me.inputApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputApellidos.Enabled = False
        Me.inputApellidos.Location = New System.Drawing.Point(147, 194)
        Me.inputApellidos.Name = "inputApellidos"
        Me.inputApellidos.Size = New System.Drawing.Size(184, 22)
        Me.inputApellidos.TabIndex = 96
        '
        'inputNombre
        '
        Me.inputNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNombre.Enabled = False
        Me.inputNombre.Location = New System.Drawing.Point(147, 150)
        Me.inputNombre.Name = "inputNombre"
        Me.inputNombre.Size = New System.Drawing.Size(184, 22)
        Me.inputNombre.TabIndex = 94
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(90, 284)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 16)
        Me.Label9.TabIndex = 108
        Me.Label9.Text = "Correo:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(71, 196)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 16)
        Me.Label18.TabIndex = 107
        Me.Label18.Text = "Apellidos: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(77, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 104
        Me.Label12.Text = "Telefono:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(74, 328)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 16)
        Me.Label17.TabIndex = 102
        Me.Label17.Text = "Dirección:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(82, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "Nombre:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(108, 372)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 16)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "DNI:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(56, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 16)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "Id Comercial:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(100, 108)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 16)
        Me.Label16.TabIndex = 87
        Me.Label16.Text = "Zona:"
        '
        'comboIdComercial
        '
        Me.comboIdComercial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboIdComercial.FormattingEnabled = True
        Me.comboIdComercial.Location = New System.Drawing.Point(147, 61)
        Me.comboIdComercial.Name = "comboIdComercial"
        Me.comboIdComercial.Size = New System.Drawing.Size(184, 24)
        Me.comboIdComercial.TabIndex = 112
        '
        'comboZona
        '
        Me.comboZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboZona.FormattingEnabled = True
        Me.comboZona.Location = New System.Drawing.Point(147, 105)
        Me.comboZona.Name = "comboZona"
        Me.comboZona.Size = New System.Drawing.Size(184, 24)
        Me.comboZona.TabIndex = 113
        '
        'FormularioComerciales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 492)
        Me.Controls.Add(Me.comboZona)
        Me.Controls.Add(Me.comboIdComercial)
        Me.Controls.Add(Me.BindNavigatorComerciales)
        Me.Controls.Add(Me.inputDNI)
        Me.Controls.Add(Me.inputDireccion)
        Me.Controls.Add(Me.inputCorreo)
        Me.Controls.Add(Me.inputTelefono)
        Me.Controls.Add(Me.btnAbajo)
        Me.Controls.Add(Me.inputApellidos)
        Me.Controls.Add(Me.inputNombre)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label16)
        Me.Name = "FormularioComerciales"
        Me.Text = "Comerciales"
        CType(Me.BindNavigatorComerciales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindNavigatorComerciales.ResumeLayout(False)
        Me.BindNavigatorComerciales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindNavigatorComerciales As BindingNavigator
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
    Friend WithEvents inputDNI As TextBox
    Friend WithEvents inputDireccion As TextBox
    Friend WithEvents inputCorreo As TextBox
    Friend WithEvents inputTelefono As TextBox
    Friend WithEvents btnAbajo As Button
    Friend WithEvents inputApellidos As TextBox
    Friend WithEvents inputNombre As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents comboIdComercial As ComboBox
    Friend WithEvents comboZona As ComboBox
End Class
