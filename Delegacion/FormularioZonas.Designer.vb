<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioZonas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioZonas))
        Me.inputIdZona = New System.Windows.Forms.TextBox()
        Me.BindNavigatorZonas = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.inputZona = New System.Windows.Forms.TextBox()
        Me.btnAbajo = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.BindNavigatorZonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindNavigatorZonas.SuspendLayout()
        Me.SuspendLayout()
        '
        'inputIdZona
        '
        Me.inputIdZona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdZona.Location = New System.Drawing.Point(150, 86)
        Me.inputIdZona.Name = "inputIdZona"
        Me.inputIdZona.Size = New System.Drawing.Size(184, 22)
        Me.inputIdZona.TabIndex = 140
        '
        'BindNavigatorZonas
        '
        Me.BindNavigatorZonas.AddNewItem = Nothing
        Me.BindNavigatorZonas.CountItem = Me.BindingNavigatorCountItem
        Me.BindNavigatorZonas.DeleteItem = Nothing
        Me.BindNavigatorZonas.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindNavigatorZonas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BtnEditar, Me.BtnAñadir, Me.BtnEliminar})
        Me.BindNavigatorZonas.Location = New System.Drawing.Point(0, 0)
        Me.BindNavigatorZonas.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindNavigatorZonas.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindNavigatorZonas.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindNavigatorZonas.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindNavigatorZonas.Name = "BindNavigatorZonas"
        Me.BindNavigatorZonas.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindNavigatorZonas.Size = New System.Drawing.Size(428, 31)
        Me.BindNavigatorZonas.TabIndex = 139
        Me.BindNavigatorZonas.Text = "BindingNavigator1"
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
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
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
        'inputZona
        '
        Me.inputZona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputZona.Location = New System.Drawing.Point(150, 145)
        Me.inputZona.Name = "inputZona"
        Me.inputZona.Size = New System.Drawing.Size(184, 22)
        Me.inputZona.TabIndex = 135
        '
        'btnAbajo
        '
        Me.btnAbajo.Location = New System.Drawing.Point(62, 229)
        Me.btnAbajo.Name = "btnAbajo"
        Me.btnAbajo.Size = New System.Drawing.Size(272, 36)
        Me.btnAbajo.TabIndex = 138
        Me.btnAbajo.Text = "Listo"
        Me.btnAbajo.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(77, 147)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 16)
        Me.Label17.TabIndex = 137
        Me.Label17.Text = "Zona:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(63, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 16)
        Me.Label13.TabIndex = 133
        Me.Label13.Text = "Id Zona:"
        '
        'FormularioZonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 374)
        Me.Controls.Add(Me.inputIdZona)
        Me.Controls.Add(Me.BindNavigatorZonas)
        Me.Controls.Add(Me.inputZona)
        Me.Controls.Add(Me.btnAbajo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label13)
        Me.Name = "FormularioZonas"
        Me.Text = "Zonas"
        CType(Me.BindNavigatorZonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindNavigatorZonas.ResumeLayout(False)
        Me.BindNavigatorZonas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inputIdZona As TextBox
    Friend WithEvents BindNavigatorZonas As BindingNavigator
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
    Friend WithEvents inputZona As TextBox
    Friend WithEvents btnAbajo As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
End Class
