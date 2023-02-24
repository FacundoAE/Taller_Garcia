Public Class frmMain
    Private Sub EspecialidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspecialidadesToolStripMenuItem.Click
        Dim frmEspecialidades As New frmEspecialidades
        frmEspecialidades.ShowDialog()
    End Sub

    Private Sub PropietariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropietariosToolStripMenuItem.Click
        Dim frmPropietarios As New frmPropietarios
        frmPropietarios.ShowDialog()
    End Sub

    Private Sub RepuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepuestosToolStripMenuItem.Click
        Dim frmRepuestos As New frmRepuestos
        frmRepuestos.ShowDialog()
    End Sub

    Private Sub AutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutosToolStripMenuItem.Click
        Dim frmAutos As New frmAutos
        frmAutos.ShowDialog()
    End Sub

    Private Sub OperariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperariosToolStripMenuItem.Click
        Dim frmOperarios As New frmOperarios
        frmOperarios.ShowDialog()
    End Sub

    Private Sub TareasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TareasToolStripMenuItem.Click
        Dim frmTareas As New frmTareas
        frmTareas.ShowDialog()
    End Sub

    Private Sub IngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosToolStripMenuItem.Click
        Dim frmIngresos As New frmIngresos
        frmIngresos.ShowDialog()
    End Sub

    Private Sub IngresosTareasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosTareasToolStripMenuItem.Click
        Dim frmIngresosTareas As New frmIngresosTareas
        frmIngresosTareas.ShowDialog()
    End Sub

    Private Sub IngresosRepuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosRepuestosToolStripMenuItem.Click
        Dim frmIngresosRepuestos As New frmIngresosRepuestos
        frmIngresosRepuestos.ShowDialog()
    End Sub

    Private Sub PatenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatenteToolStripMenuItem.Click
        Dim frmReportePatente As New frmReportePatente
        frmReportePatente.ShowDialog()
    End Sub

    Private Sub PropietarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropietarioToolStripMenuItem.Click
        Dim frmReportePropietario As New frmReportePropietario
        frmReportePropietario.ShowDialog()
    End Sub

    Private Sub GastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosToolStripMenuItem.Click
        Dim frmReporteGasto As New frmReporteGasto
        frmReporteGasto.ShowDialog()
    End Sub

End Class