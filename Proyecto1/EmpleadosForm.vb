Public Class EmpleadosForm
    Inherits Form
    Public Sub New()
        Me.Text = "Empleados"
        Me.Size = New Size(400, 300)
        ' Ejemplo de campos básicos para empleados
        Dim lblC As New Label With {.Text = "Código:", .Location = New Point(20, 30)}
        Dim txtCodigo As New TextBox With {.Location = New Point(100, 30), .Width = 200}
        Dim lblNombre As New Label With {.Text = "Nombre:", .Location = New Point(20, 70)}
        Dim txtNombre As New TextBox With {.Location = New Point(100, 70), .Width = 200}
        Dim lblApellido As New Label With {.Text = "Apellido:", .Location = New Point(20, 110)}
        Dim txtApellido As New TextBox With {.Location = New Point(100, 110), .Width = 200}
        Dim btnGuardar As New Button With {.Text = "Guardar", .Location = New Point(150, 160)}
        Me.Controls.Add(lblCodigo)
        Me.Controls.Add(txtCodigo)
        Me.Controls.Add(lblNombre)
        Me.Controls.Add(txtNombre)
        Me.Controls.Add(lblApellido)
        Me.Controls.Add(txtApellido)
        Me.Controls.Add(btnGuardar)
        ' Aquí puedes agregar más campos según la estructura de la tabla empleado
    End Sub

    Private Sub InitializeComponent()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' EmpleadosForm
        ' 
        ClientSize = New Size(724, 491)
        Controls.Add(Label1)
        Name = "EmpleadosForm"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
End Class
