Public Class infGasto
    Private Sub infGasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'taller_garciaDataSet.totales' Puede moverla o quitarla según sea necesario.
        Me.totalesTableAdapter.Fill(Me.taller_garciaDataSet.totales, gPropietario, gFechaUno, gFechaDos)

        Me.ReportViewer1.RefreshReport()

        gPropietario = ""
        gFechaUno = ""
        gFechaDos = ""
    End Sub
End Class