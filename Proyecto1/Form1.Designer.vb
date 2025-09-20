<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ImportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
        Friend WithEvents btnConsultar As System.Windows.Forms.Button
        Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        ConsultarToolStripMenuItem = New ToolStripMenuItem()
        EmpleadosToolStripMenuItem = New ToolStripMenuItem()
        ImportarToolStripMenuItem = New ToolStripMenuItem()
        txtCodigo = New TextBox()
        btnConsultar = New Button()
        DataGridView1 = New DataGridView()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ConsultarToolStripMenuItem, EmpleadosToolStripMenuItem, ImportarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(854, 28)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ConsultarToolStripMenuItem
        ' 
        ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        ConsultarToolStripMenuItem.Size = New Size(85, 24)
        ConsultarToolStripMenuItem.Text = "Consultar"
        ' 
        ' EmpleadosToolStripMenuItem
        ' 
        EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        EmpleadosToolStripMenuItem.Size = New Size(97, 24)
        EmpleadosToolStripMenuItem.Text = "Empleados"
        ' 
        ' ImportarToolStripMenuItem
        ' 
        ImportarToolStripMenuItem.Name = "ImportarToolStripMenuItem"
        ImportarToolStripMenuItem.Size = New Size(81, 24)
        ImportarToolStripMenuItem.Text = "Importar"
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Location = New Point(28, 42)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.PlaceholderText = "Código de Marcación"
        txtCodigo.Size = New Size(120, 27)
        txtCodigo.TabIndex = 0
        ' 
        ' btnConsultar
        ' 
        btnConsultar.Location = New Point(158, 42)
        btnConsultar.Name = "btnConsultar"
        btnConsultar.Size = New Size(80, 23)
        btnConsultar.TabIndex = 1
        btnConsultar.Text = "Consultar"
        btnConsultar.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeight = 29
        DataGridView1.Location = New Point(20, 84)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(800, 400)
        DataGridView1.TabIndex = 2
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' ConsultaForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(854, 562)
        Controls.Add(txtCodigo)
        Controls.Add(btnConsultar)
        Controls.Add(DataGridView1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "ConsultaForm"
        Text = "Consulta de Asistencias"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip

End Class
