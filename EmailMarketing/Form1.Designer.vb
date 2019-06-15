<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CargaClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientePorExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientePorAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesPorODBCConexiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 398)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(943, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(148, 17)
        Me.ToolStripStatusLabel1.Text = "Bienvenido Braulio Castillo"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargaClientesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(943, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CargaClientesToolStripMenuItem
        '
        Me.CargaClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientePorExcelToolStripMenuItem, Me.ClientePorAccessToolStripMenuItem, Me.ClientesPorODBCConexiónToolStripMenuItem})
        Me.CargaClientesToolStripMenuItem.Name = "CargaClientesToolStripMenuItem"
        Me.CargaClientesToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.CargaClientesToolStripMenuItem.Text = "Modulo Carga"
        '
        'ClientePorExcelToolStripMenuItem
        '
        Me.ClientePorExcelToolStripMenuItem.Name = "ClientePorExcelToolStripMenuItem"
        Me.ClientePorExcelToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ClientePorExcelToolStripMenuItem.Text = "Cliente por Excel"
        '
        'ClientePorAccessToolStripMenuItem
        '
        Me.ClientePorAccessToolStripMenuItem.Name = "ClientePorAccessToolStripMenuItem"
        Me.ClientePorAccessToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ClientePorAccessToolStripMenuItem.Text = "Cliente por Access"
        '
        'ClientesPorODBCConexiónToolStripMenuItem
        '
        Me.ClientesPorODBCConexiónToolStripMenuItem.Name = "ClientesPorODBCConexiónToolStripMenuItem"
        Me.ClientesPorODBCConexiónToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.ClientesPorODBCConexiónToolStripMenuItem.Text = "Clientes por ODBC Conexión"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 420)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CargaClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientePorExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientePorAccessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesPorODBCConexiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
