Public Class frmReportePropietario
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.txbPropietario.Text <> "" Then
            nroPropietario = Me.txbPropietario.Text
            Dim infPropietario As New infPropietario
            infPropietario.ShowDialog()
        Else
            MsgBox("Debes ingresar un propietario")
        End If
    End Sub

    Private Sub txbPatente_KeyDown(sender As Object, e As KeyEventArgs) Handles txbPropietario.KeyDown
        If e.KeyData = Keys.Enter Then
            wrfm = 2
            Dim frm As New frmPropietarios
            AddOwnedForm(frm)
            frm.ShowDialog()
        End If
    End Sub
End Class