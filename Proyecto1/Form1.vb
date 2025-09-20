Public Class ConsultaForm

	Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
		Dim empForm As New EmpleadosForm()
		empForm.ShowDialog()
	End Sub

	Private Sub ImportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarToolStripMenuItem.Click
		Dim impForm As New ImportarForm()
		impForm.ShowDialog()
	End Sub
End Class
