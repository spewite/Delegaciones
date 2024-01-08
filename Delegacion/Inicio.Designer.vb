<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartnersToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartnersToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.GestionToolStripMenuItem, Me.PedidosToolStripMenuItem, Me.FacturasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1492, 30)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarToolStripMenuItem1, Me.ExportarToolStripMenuItem1})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ImportarToolStripMenuItem1
        '
        Me.ImportarToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PedidosToolStripMenuItem2, Me.PartnersToolStripMenuItem2, Me.ArticulosToolStripMenuItem2})
        Me.ImportarToolStripMenuItem1.Name = "ImportarToolStripMenuItem1"
        Me.ImportarToolStripMenuItem1.Size = New System.Drawing.Size(150, 26)
        Me.ImportarToolStripMenuItem1.Text = "Importar"
        '
        'PedidosToolStripMenuItem2
        '
        Me.PedidosToolStripMenuItem2.Name = "PedidosToolStripMenuItem2"
        Me.PedidosToolStripMenuItem2.Size = New System.Drawing.Size(150, 26)
        Me.PedidosToolStripMenuItem2.Text = "Pedidos"
        '
        'PartnersToolStripMenuItem2
        '
        Me.PartnersToolStripMenuItem2.Name = "PartnersToolStripMenuItem2"
        Me.PartnersToolStripMenuItem2.Size = New System.Drawing.Size(150, 26)
        Me.PartnersToolStripMenuItem2.Text = "Partners"
        '
        'ArticulosToolStripMenuItem2
        '
        Me.ArticulosToolStripMenuItem2.Name = "ArticulosToolStripMenuItem2"
        Me.ArticulosToolStripMenuItem2.Size = New System.Drawing.Size(150, 26)
        Me.ArticulosToolStripMenuItem2.Text = "Articulos"
        '
        'ExportarToolStripMenuItem1
        '
        Me.ExportarToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticulosToolStripMenuItem3, Me.PartnersToolStripMenuItem3})
        Me.ExportarToolStripMenuItem1.Name = "ExportarToolStripMenuItem1"
        Me.ExportarToolStripMenuItem1.Size = New System.Drawing.Size(150, 26)
        Me.ExportarToolStripMenuItem1.Text = "Exportar"
        '
        'ArticulosToolStripMenuItem3
        '
        Me.ArticulosToolStripMenuItem3.Name = "ArticulosToolStripMenuItem3"
        Me.ArticulosToolStripMenuItem3.Size = New System.Drawing.Size(150, 26)
        Me.ArticulosToolStripMenuItem3.Text = "Articulos"
        '
        'PartnersToolStripMenuItem3
        '
        Me.PartnersToolStripMenuItem3.Name = "PartnersToolStripMenuItem3"
        Me.PartnersToolStripMenuItem3.Size = New System.Drawing.Size(150, 26)
        Me.PartnersToolStripMenuItem3.Text = "Partners"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.GestionToolStripMenuItem.Text = "Gestion"
        '
        'PedidosToolStripMenuItem
        '
        Me.PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
        Me.PedidosToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.PedidosToolStripMenuItem.Text = "Pedidos"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1492, 891)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Inicio"
        Me.Text = "Delegaciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents PartnersToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ExportarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents PartnersToolStripMenuItem3 As ToolStripMenuItem
End Class
