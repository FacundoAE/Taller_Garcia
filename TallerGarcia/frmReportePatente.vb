Public Class frmReportePatente
    Private Sub txbPatente_KeyDown(sender As Object, e As KeyEventArgs) Handles txbPatente.KeyDown
        If e.KeyData = Keys.Enter Then
            wrfm = 2
            Dim frm As New frmAutos
            AddOwnedForm(frm)
            frm.ShowDialog()
        End If
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.txbPatente.Text <> "" Then
            nroPatente = Me.txbPatente.Text
            Dim infPatente As New infPatente
            infPatente.ShowDialog()
        Else
            MsgBox("Debes ingresar una patente")
        End If
    End Sub

End Class