Public Class frmReporteGasto
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.txbPropietario.Text <> "" Then
            If Me.d1.Text <> "" And Me.m1.Text <> "" And Me.a1.Text <> "" And Me.d2.Text <> "" And Me.m2.Text <> "" And Me.a2.Text <> "" Then
                gPropietario = Me.txbPropietario.Text
                gFechaUno = $"{Me.d1.Text}/{Me.m1.Text}/{Me.a1.Text}"
                gFechaDos = $"{Me.d2.Text}/{Me.m2.Text}/{Me.a2.Text}"
                Dim infGasto As New infGasto
                infGasto.ShowDialog()
            Else
                MsgBox("Debes ingresar todos los campos")
            End If
        Else
            MsgBox("Debes ingresar un propietario")
        End If
    End Sub
    Private Sub txbPropietario_KeyDown(sender As Object, e As KeyEventArgs) Handles txbPropietario.KeyDown
        If e.KeyData = Keys.Enter Then
            wrfm = 3
            Dim frm As New frmPropietarios
            AddOwnedForm(frm)
            frm.ShowDialog()
        End If
    End Sub

    Private Sub frmReporteGasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class