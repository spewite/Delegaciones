<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioTransportistas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioTransportistas))
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindNavigatorTransportistas = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.inputEmpresa = New System.Windows.Forms.TextBox()
        Me.inputTelefono = New System.Windows.Forms.TextBox()
        Me.btnAbajo = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.inputIdTransportista = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BtnAñadir = New System.Windows.Forms.ToolStripButton()
        Me.BtnEliminar = New System.Windows.Forms.ToolStripButton()
        CType(Me.BindNavigatorTransportistas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindNavigatorTransportistas.SuspendLayout()
        Me.SuspendLayout()
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BindNavigatorTransportistas
        '
        Me.BindNavigatorTransportistas.AddNewItem = Nothing
        Me.BindNavigatorTransportistas.CountItem = Me.BindingNavigatorCountItem
        Me.BindNavigatorTransportistas.DeleteItem = Nothing
        Me.BindNavigatorTransportistas.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindNavigatorTransportistas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BtnEditar, Me.BtnAñadir, Me.BtnEliminar})
        Me.BindNavigatorTransportistas.Location = New System.Drawing.Point(0, 0)
        Me.BindNavigatorTransportistas.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindNavigatorTransportistas.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindNavigatorTransportistas.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindNavigatorTransportistas.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindNavigatorTransportistas.Name = "BindNavigatorTransportistas"
        Me.BindNavigatorTransportistas.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindNavigatorTransportistas.Size = New System.Drawing.Size(426, 31)
        Me.BindNavigatorTransportistas.TabIndex = 129
        Me.BindNavigatorTransportistas.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        'inputEmpresa
        '
        Me.inputEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputEmpresa.Location = New System.Drawing.Point(151, 130)
        Me.inputEmpresa.Name = "inputEmpresa"
        Me.inputEmpresa.Size = New System.Drawing.Size(184, 22)
        Me.inputEmpresa.TabIndex = 120
        '
        'inputTelefono
        '
        Me.inputTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputTelefono.Location = New System.Drawing.Point(151, 193)
        Me.inputTelefono.Name = "inputTelefono"
        Me.inputTelefono.Size = New System.Drawing.Size(184, 22)
        Me.inputTelefono.TabIndex = 123
        '
        'btnAbajo
        '
        Me.btnAbajo.Location = New System.Drawing.Point(63, 266)
        Me.btnAbajo.Name = "btnAbajo"
        Me.btnAbajo.Size = New System.Drawing.Size(272, 36)
        Me.btnAbajo.TabIndex = 128
        Me.btnAbajo.Text = "Listo"
        Me.btnAbajo.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(78, 132)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 16)
        Me.Label17.TabIndex = 124
        Me.Label17.Text = "Empresa:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(86, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 16)
        Me.Label11.TabIndex = 116
        Me.Label11.Text = "Telefono: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(43, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 16)
        Me.Label13.TabIndex = 115
        Me.Label13.Text = "Id Transportista:"
        '
        'inputIdTransportista
        '
        Me.inputIdTransportista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdTransportista.Location = New System.Drawing.Point(151, 71)
        Me.inputIdTransportista.Name = "inputIdTransportista"
        Me.inputIdTransportista.Size = New System.Drawing.Size(184, 22)
        Me.inputIdTransportista.TabIndex = 132
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
        'FormularioTransportistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 363)
        Me.Controls.Add(Me.inputIdTransportista)
        Me.Controls.Add(Me.BindNavigatorTransportistas)
        Me.Controls.Add(Me.inputEmpresa)
        Me.Controls.Add(Me.inputTelefono)
        Me.Controls.Add(Me.btnAbajo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormularioTransportistas"
        Me.Text = "Transportistas"
        CType(Me.BindNavigatorTransportistas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindNavigatorTransportistas.ResumeLayout(False)
        Me.BindNavigatorTransportistas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEliminar As ToolStripButton
    Friend WithEvents BtnAñadir As ToolStripButton
    Friend WithEvents BtnEditar As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindNavigatorTransportistas As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents inputEmpresa As TextBox
    Friend WithEvents inputTelefono As TextBox
    Friend WithEvents btnAbajo As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents inputIdTransportista As TextBox
    Private WithEvents Label11 As Label
End Class
