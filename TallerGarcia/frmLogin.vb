Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        Me.txbUsuario.Select()
    End Sub
    Private Sub login_us()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "select id_usuario,usuario,psw from usuarios where usuario = '" & Me.txbUsuario.Text & "'"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader()

        Try
            If dr.HasRows Then
                While dr.Read
                    Me.lblcompruebausuario.text = dr(1).ToString
                    Me.lblcompruebacontrasena.text = dr(2).ToString
                End While
                Me.txbContrasena.Enabled = True
            Else
                MsgBox("usuario inexistente", MsgBoxStyle.Critical, "error de acceso")
                Me.txbUsuario.Clear()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub login_psw()
        If Me.txbContrasena.Text = Me.lblcompruebacontrasena.Text Then
            Me.btnAceptar.Enabled = True
        Else
            MsgBox("Los datos ingresados no son correctos", MsgBoxStyle.Critical, "Error de acceso")
            Me.txbUsuario.Clear()
            Me.txbContrasena.Clear()
            Me.txbUsuario.Focus()
            Me.btnAceptar.Enabled = False
            Me.txbContrasena.Enabled = False
        End If
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim frm As New frmMain
        frm.Show()
        Me.Close()
    End Sub

    Private Sub txbUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txbUsuario.KeyDown
        If e.KeyData = Keys.Enter Then
            login_us()
            Me.txbContrasena.Focus()
        End If
    End Sub
    Private Sub txbContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles txbContrasena.KeyDown
        If e.KeyData = Keys.Enter Then
            login_psw()
            Me.btnAceptar.Focus()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim frm As New frmMain
        frm.Show()
        Me.Close()
    End Sub
End Class