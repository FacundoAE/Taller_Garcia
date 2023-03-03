Public Class frmExtraTareasMasDemandadas
    Private Sub frmExtraTareasMasDemandadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'taller_garciaDataSet2.extratareas' Puede moverla o quitarla según sea necesario.
        Me.extratareasTableAdapter.Fill(Me.taller_garciaDataSet2.extratareas)

        Me.ReportViewer1.RefreshReport
    End Sub
End Class