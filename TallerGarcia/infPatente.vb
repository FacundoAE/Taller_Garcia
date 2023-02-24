Public Class infPatente
    Private Sub infPatente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'taller_garciaDataSet.patente' Puede moverla o quitarla según sea necesario.
        Me.patenteTableAdapter.Fill(Me.taller_garciaDataSet.patente, nroPatente)

        Me.ReportViewer1.RefreshReport()

        nroPatente = ""
    End Sub
End Class