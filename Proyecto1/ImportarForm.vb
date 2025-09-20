Public Class ImportarForm
    Inherits Form
    Public Sub New()
        Me.Text = "Importar Asistencias"
        Me.Size = New Size(400, 200)
        Dim lblArchivo As New Label With {.Text = "Archivo .dat:", .Location = New Point(20, 30)}
        Dim txtArchivo As New TextBox With {.Location = New Point(100, 30), .Width = 200}
        Dim btnExaminar As New Button With {.Text = "Examinar", .Location = New Point(310, 28)}
        Dim btnImportar As New Button With {.Text = "Importar", .Location = New Point(150, 70)}
        Me.Controls.Add(lblArchivo)
        Me.Controls.Add(txtArchivo)
        Me.Controls.Add(btnExaminar)
        Me.Controls.Add(btnImportar)
        ' La lógica de importación se agregará después
    End Sub
End Class
