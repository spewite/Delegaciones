<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioPartners
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioPartners))
        Me.BtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindNavigatorPartner = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BtnAñadir = New System.Windows.Forms.ToolStripButton()
        Me.inputCorreo = New System.Windows.Forms.TextBox()
        Me.inputTelefono = New System.Windows.Forms.TextBox()
        Me.inputDireccion = New System.Windows.Forms.TextBox()
        Me.btnAbajo = New System.Windows.Forms.Button()
        Me.inputNombre = New System.Windows.Forms.TextBox()
        Me.inputIdPartner = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.inputCif = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.comboZonaPartners = New System.Windows.Forms.ComboBox()
        CType(Me.BindNavigatorPartner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindNavigatorPartner.SuspendLayout()
        Me.SuspendLayout()
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
        'BtnEditar
        '
        Me.BtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEditar.Image = Global.Delegacion.My.Resources.Resources.editar
        Me.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(29, 28)
        Me.BtnEditar.Text = "Editar"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
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
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
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
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
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
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 28)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindNavigatorPartner
        '
        Me.BindNavigatorPartner.AddNewItem = Nothing
        Me.BindNavigatorPartner.CountItem = Me.BindingNavigatorCountItem
        Me.BindNavigatorPartner.DeleteItem = Nothing
        Me.BindNavigatorPartner.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindNavigatorPartner.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BtnEditar, Me.BtnAñadir, Me.BtnEliminar})
        Me.BindNavigatorPartner.Location = New System.Drawing.Point(0, 0)
        Me.BindNavigatorPartner.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindNavigatorPartner.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindNavigatorPartner.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindNavigatorPartner.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindNavigatorPartner.Name = "BindNavigatorPartner"
        Me.BindNavigatorPartner.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindNavigatorPartner.Size = New System.Drawing.Size(812, 27)
        Me.BindNavigatorPartner.TabIndex = 105
        Me.BindNavigatorPartner.Text = "BindingNavigator1"
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
        'inputCorreo
        '
        Me.inputCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputCorreo.Location = New System.Drawing.Point(130, 304)
        Me.inputCorreo.Name = "inputCorreo"
        Me.inputCorreo.Size = New System.Drawing.Size(163, 22)
        Me.inputCorreo.TabIndex = 96
        '
        'inputTelefono
        '
        Me.inputTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputTelefono.Location = New System.Drawing.Point(130, 260)
        Me.inputTelefono.Name = "inputTelefono"
        Me.inputTelefono.Size = New System.Drawing.Size(163, 22)
        Me.inputTelefono.TabIndex = 97
        '
        'inputDireccion
        '
        Me.inputDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputDireccion.Location = New System.Drawing.Point(130, 220)
        Me.inputDireccion.Name = "inputDireccion"
        Me.inputDireccion.Size = New System.Drawing.Size(163, 22)
        Me.inputDireccion.TabIndex = 94
        '
        'btnAbajo
        '
        Me.btnAbajo.Location = New System.Drawing.Point(45, 393)
        Me.btnAbajo.Name = "btnAbajo"
        Me.btnAbajo.Size = New System.Drawing.Size(253, 36)
        Me.btnAbajo.TabIndex = 104
        Me.btnAbajo.Text = "Listo"
        Me.btnAbajo.UseVisualStyleBackColor = True
        '
        'inputNombre
        '
        Me.inputNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNombre.Enabled = False
        Me.inputNombre.Location = New System.Drawing.Point(130, 138)
        Me.inputNombre.Name = "inputNombre"
        Me.inputNombre.Size = New System.Drawing.Size(163, 22)
        Me.inputNombre.TabIndex = 91
        '
        'inputIdPartner
        '
        Me.inputIdPartner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdPartner.Enabled = False
        Me.inputIdPartner.Location = New System.Drawing.Point(130, 51)
        Me.inputIdPartner.Name = "inputIdPartner"
        Me.inputIdPartner.ReadOnly = True
        Me.inputIdPartner.Size = New System.Drawing.Size(163, 22)
        Me.inputIdPartner.TabIndex = 87
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(54, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "Telefono:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(91, 185)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 16)
        Me.Label18.TabIndex = 102
        Me.Label18.Text = "CIF:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(53, 222)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 16)
        Me.Label12.TabIndex = 101
        Me.Label12.Text = "Direccion:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(70, 307)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 16)
        Me.Label17.TabIndex = 98
        Me.Label17.Text = "Correo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(63, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "Nombre:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(54, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 16)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "Id Partner:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(65, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 16)
        Me.Label16.TabIndex = 86
        Me.Label16.Text = "Id Zona:"
        '
        'inputCif
        '
        Me.inputCif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputCif.Enabled = False
        Me.inputCif.Location = New System.Drawing.Point(130, 179)
        Me.inputCif.Name = "inputCif"
        Me.inputCif.Size = New System.Drawing.Size(163, 22)
        Me.inputCif.TabIndex = 93
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(484, 30)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(261, 359)
        Me.TextBox1.TabIndex = 106
        '
        'comboZonaPartners
        '
        Me.comboZonaPartners.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboZonaPartners.FormattingEnabled = True
        Me.comboZonaPartners.Location = New System.Drawing.Point(130, 90)
        Me.comboZonaPartners.Name = "comboZonaPartners"
        Me.comboZonaPartners.Size = New System.Drawing.Size(163, 24)
        Me.comboZonaPartners.TabIndex = 107
        '
        'FormularioPartners
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 456)
        Me.Controls.Add(Me.comboZonaPartners)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BindNavigatorPartner)
        Me.Controls.Add(Me.inputCorreo)
        Me.Controls.Add(Me.inputTelefono)
        Me.Controls.Add(Me.inputDireccion)
        Me.Controls.Add(Me.btnAbajo)
        Me.Controls.Add(Me.inputNombre)
        Me.Controls.Add(Me.inputIdPartner)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.inputCif)
        Me.Name = "FormularioPartners"
        Me.Text = "FormularioPartners"
        CType(Me.BindNavigatorPartner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindNavigatorPartner.ResumeLayout(False)
        Me.BindNavigatorPartner.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEliminar As ToolStripButton
    Friend WithEvents BtnEditar As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindNavigatorPartner As BindingNavigator
    Friend WithEvents BtnAñadir As ToolStripButton
    Friend WithEvents inputCorreo As TextBox
    Friend WithEvents inputTelefono As TextBox
    Friend WithEvents inputDireccion As TextBox
    Friend WithEvents btnAbajo As Button
    Friend WithEvents inputNombre As TextBox
    Friend WithEvents inputIdPartner As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents inputCif As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents comboZonaPartners As ComboBox
End Class
