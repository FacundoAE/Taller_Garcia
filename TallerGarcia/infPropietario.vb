Public Class infPropietario
    Private Sub infPropietario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'taller_garciaDataSet.propietario' Puede moverla o quitarla según sea necesario.
        Me.propietarioTableAdapter.Fill(Me.taller_garciaDataSet.propietario, nroPropietario)

        Me.ReportViewer1.RefreshReport()

        nroPropietario = ""
    End Sub
End Class