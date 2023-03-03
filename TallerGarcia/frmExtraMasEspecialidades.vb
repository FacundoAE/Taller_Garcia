Public Class frmExtraMasEspecialidades
    Private Sub frmExtraMasEspecialidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'taller_garciaDataSet2.extraespecialidades' Puede moverla o quitarla según sea necesario.
        Me.extraespecialidadesTableAdapter.Fill(Me.taller_garciaDataSet2.extraespecialidades)

        Me.ReportViewer1.RefreshReport
    End Sub
End Class