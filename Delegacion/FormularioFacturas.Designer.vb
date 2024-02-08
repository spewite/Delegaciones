<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioFacturas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioFacturas))
        Me.inputIdFactura = New System.Windows.Forms.TextBox()
        Me.btnAbajo = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindNavigatorFacturas = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.inputFechaEmitida = New System.Windows.Forms.DateTimePicker()
        Me.inputFechaEnvio = New System.Windows.Forms.DateTimePicker()
        Me.inputFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comboEstado = New System.Windows.Forms.ComboBox()
        Me.checkFechaEmitida = New System.Windows.Forms.CheckBox()
        Me.checkFechaEnvio = New System.Windows.Forms.CheckBox()
        Me.checkFechaPago = New System.Windows.Forms.CheckBox()
        Me.dataGridPedidos = New System.Windows.Forms.DataGridView()
        CType(Me.BindNavigatorFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindNavigatorFacturas.SuspendLayout()
        CType(Me.dataGridPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inputIdFactura
        '
        Me.inputIdFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputIdFactura.Enabled = False
        Me.inputIdFactura.Location = New System.Drawing.Point(115, 51)
        Me.inputIdFactura.Name = "inputIdFactura"
        Me.inputIdFactura.Size = New System.Drawing.Size(184, 22)
        Me.inputIdFactura.TabIndex = 140
        '
        'btnAbajo
        '
        Me.btnAbajo.Location = New System.Drawing.Point(674, 43)
        Me.btnAbajo.Name = "btnAbajo"
        Me.btnAbajo.Size = New System.Drawing.Size(305, 37)
        Me.btnAbajo.TabIndex = 138
        Me.btnAbajo.Text = "Listo"
        Me.btnAbajo.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(317, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 16)
        Me.Label11.TabIndex = 134
        Me.Label11.Text = "Fecha Emitida:"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
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
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindNavigatorFacturas
        '
        Me.BindNavigatorFacturas.AddNewItem = Nothing
        Me.BindNavigatorFacturas.CountItem = Me.BindingNavigatorCountItem
        Me.BindNavigatorFacturas.DeleteItem = Nothing
        Me.BindNavigatorFacturas.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindNavigatorFacturas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BtnEditar})
        Me.BindNavigatorFacturas.Location = New System.Drawing.Point(0, 0)
        Me.BindNavigatorFacturas.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindNavigatorFacturas.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindNavigatorFacturas.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindNavigatorFacturas.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindNavigatorFacturas.Name = "BindNavigatorFacturas"
        Me.BindNavigatorFacturas.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindNavigatorFacturas.Size = New System.Drawing.Size(1475, 27)
        Me.BindNavigatorFacturas.TabIndex = 139
        Me.BindNavigatorFacturas.Text = "BindingNavigator1"
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
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(39, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 16)
        Me.Label13.TabIndex = 133
        Me.Label13.Text = "Id Factura:"
        '
        'inputFechaEmitida
        '
        Me.inputFechaEmitida.CustomFormat = ""
        Me.inputFechaEmitida.Enabled = False
        Me.inputFechaEmitida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.inputFechaEmitida.Location = New System.Drawing.Point(420, 100)
        Me.inputFechaEmitida.Name = "inputFechaEmitida"
        Me.inputFechaEmitida.Size = New System.Drawing.Size(184, 22)
        Me.inputFechaEmitida.TabIndex = 142
        Me.inputFechaEmitida.Value = New Date(2023, 12, 16, 19, 57, 19, 0)
        '
        'inputFechaEnvio
        '
        Me.inputFechaEnvio.CustomFormat = ""
        Me.inputFechaEnvio.Enabled = False
        Me.inputFechaEnvio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.inputFechaEnvio.Location = New System.Drawing.Point(420, 51)
        Me.inputFechaEnvio.Name = "inputFechaEnvio"
        Me.inputFechaEnvio.Size = New System.Drawing.Size(184, 22)
        Me.inputFechaEnvio.TabIndex = 143
        Me.inputFechaEnvio.Value = New Date(2023, 12, 16, 19, 57, 19, 0)
        '
        'inputFechaPago
        '
        Me.inputFechaPago.CustomFormat = ""
        Me.inputFechaPago.Enabled = False
        Me.inputFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.inputFechaPago.Location = New System.Drawing.Point(762, 98)
        Me.inputFechaPago.Name = "inputFechaPago"
        Me.inputFechaPago.Size = New System.Drawing.Size(184, 22)
        Me.inputFechaPago.TabIndex = 144
        Me.inputFechaPago.Value = New Date(2023, 12, 16, 19, 57, 19, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(328, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "Fecha Envio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(671, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Fecha Pago:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 147
        Me.Label3.Text = "Estado:"
        '
        'comboEstado
        '
        Me.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboEstado.FormattingEnabled = True
        Me.comboEstado.Items.AddRange(New Object() {"", "Pagado", "Por Pagar"})
        Me.comboEstado.Location = New System.Drawing.Point(115, 101)
        Me.comboEstado.Name = "comboEstado"
        Me.comboEstado.Size = New System.Drawing.Size(184, 24)
        Me.comboEstado.TabIndex = 148
        '
        'checkFechaEmitida
        '
        Me.checkFechaEmitida.AutoSize = True
        Me.checkFechaEmitida.Location = New System.Drawing.Point(619, 103)
        Me.checkFechaEmitida.Name = "checkFechaEmitida"
        Me.checkFechaEmitida.Size = New System.Drawing.Size(18, 17)
        Me.checkFechaEmitida.TabIndex = 149
        Me.checkFechaEmitida.UseVisualStyleBackColor = True
        '
        'checkFechaEnvio
        '
        Me.checkFechaEnvio.AutoSize = True
        Me.checkFechaEnvio.Location = New System.Drawing.Point(619, 54)
        Me.checkFechaEnvio.Name = "checkFechaEnvio"
        Me.checkFechaEnvio.Size = New System.Drawing.Size(18, 17)
        Me.checkFechaEnvio.TabIndex = 150
        Me.checkFechaEnvio.UseVisualStyleBackColor = True
        '
        'checkFechaPago
        '
        Me.checkFechaPago.AutoSize = True
        Me.checkFechaPago.Location = New System.Drawing.Point(961, 100)
        Me.checkFechaPago.Name = "checkFechaPago"
        Me.checkFechaPago.Size = New System.Drawing.Size(18, 17)
        Me.checkFechaPago.TabIndex = 151
        Me.checkFechaPago.UseVisualStyleBackColor = True
        '
        'dataGridPedidos
        '
        Me.dataGridPedidos.AllowUserToAddRows = False
        Me.dataGridPedidos.AllowUserToDeleteRows = False
        Me.dataGridPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridPedidos.Location = New System.Drawing.Point(36, 159)
        Me.dataGridPedidos.Name = "dataGridPedidos"
        Me.dataGridPedidos.RowHeadersWidth = 51
        Me.dataGridPedidos.RowTemplate.Height = 24
        Me.dataGridPedidos.Size = New System.Drawing.Size(1392, 407)
        Me.dataGridPedidos.TabIndex = 152
        '
        'FormularioFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1475, 613)
        Me.Controls.Add(Me.dataGridPedidos)
        Me.Controls.Add(Me.checkFechaPago)
        Me.Controls.Add(Me.checkFechaEnvio)
        Me.Controls.Add(Me.checkFechaEmitida)
        Me.Controls.Add(Me.comboEstado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inputFechaPago)
        Me.Controls.Add(Me.inputFechaEnvio)
        Me.Controls.Add(Me.inputFechaEmitida)
        Me.Controls.Add(Me.inputIdFactura)
        Me.Controls.Add(Me.btnAbajo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BindNavigatorFacturas)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormularioFacturas"
        Me.Text = "Factura"
        CType(Me.BindNavigatorFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindNavigatorFacturas.ResumeLayout(False)
        Me.BindNavigatorFacturas.PerformLayout()
        CType(Me.dataGridPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inputIdFactura As TextBox
    Friend WithEvents btnAbajo As Button
    Private WithEvents Label11 As Label
    Friend WithEvents BtnEditar As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindNavigatorFacturas As BindingNavigator
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Label13 As Label
    Friend WithEvents inputFechaEmitida As DateTimePicker
    Friend WithEvents inputFechaEnvio As DateTimePicker
    Friend WithEvents inputFechaPago As DateTimePicker
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Friend WithEvents comboEstado As ComboBox
    Friend WithEvents checkFechaEmitida As CheckBox
    Friend WithEvents checkFechaEnvio As CheckBox
    Friend WithEvents checkFechaPago As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dataGridPedidos As DataGridView
End Class
