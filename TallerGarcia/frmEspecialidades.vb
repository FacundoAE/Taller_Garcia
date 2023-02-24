Public Class frmEspecialidades
    Private Sub anchoPantalla(x As Integer)
        Me.Width = x
        Me.CenterToScreen()
    End Sub
    Private Sub limpiarTextBox()
        Me.txbIdEspecialidad.Clear()
        Me.txbEspecialidad.Clear()
    End Sub
    Private Sub llenarEspecialidades()
        Dim sql As String = "SELECT id_especialidad AS ID, especialidad AS Especialidad FROM especialidades"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("Especialidades")
        adp.Fill(ds.Tables("Especialidades"))
        Me.dgvEspecialidades.DataSource = ds.Tables("Especialidades")

    End Sub

    Private Sub altaEspecialidad()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "INSERT INTO especialidades VALUES(" & Me.txbIdEspecialidad.Text & ",'" & Me.txbEspecialidad.Text & "')"
        cmd.CommandText = sql

        If Me.txbIdEspecialidad.Text <> "" And IsNumeric(Me.txbIdEspecialidad.Text) = True Then
            If Me.txbEspecialidad.Text <> "" And IsNumeric(Me.txbEspecialidad.Text) = False Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarEspecialidades()
                    limpiarTextBox()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("El campo especialidad no puede estar vacio, ni ser un numero.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("El campo id no puede estar vacio y debe ser un numero.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub modificarEspecialidad()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "UPDATE especialidades SET especialidad = '" & Me.txbEspecialidad.Text &
            "' WHERE id_especialidad = " & Me.txbIdEspecialidad.Text
        cmd.CommandText = sql

        If Me.txbIdEspecialidad.Text <> "" And IsNumeric(Me.txbIdEspecialidad.Text) = True Then
            If Me.txbEspecialidad.Text <> "" And IsNumeric(Me.txbEspecialidad.Text) = False Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarEspecialidades()
                    limpiarTextBox()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("El campo especialidad no puede estar vacio, ni ser un numero.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("El campo id no puede estar vacio y debe ser un numero.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub bajaEspecialidad()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "DELETE FROM especialidades WHERE id_especialidad = " & Me.txbIdEspecialidad.Text
        cmd.CommandText = sql

        If Me.txbIdEspecialidad.Text <> "" Then
            Dim seguridad = MsgBox("Vas a dar de baja a ID: " & Me.txbIdEspecialidad.Text & " Especialidad: " & Me.txbEspecialidad.Text, vbOKCancel, "Seguridad")

            If seguridad = vbOKCancel Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarEspecialidades()
                    limpiarTextBox()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If

        Else
            MsgBox("El campo especialidad y la id no pueden estar vacios.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub frmEspecialidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarEspecialidades()
        anchoPantalla(490)
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        MsgBox("Seleccionaste dar de alta una especialidad", MsgBoxStyle.Information)
        anchoPantalla(650)
        flag_abm = 1
        limpiarTextBox()
        Me.txbEspecialidad.Enabled = True
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        MsgBox("Seleccionaste modificar una especialidad", MsgBoxStyle.Information)
        anchoPantalla(650)
        flag_abm = 2
        limpiarTextBox()
        Me.txbEspecialidad.Enabled = True
        Me.txbIdEspecialidad.Text = Me.dgvEspecialidades.CurrentRow.Cells(0).Value.ToString
        Me.txbEspecialidad.Text = Me.dgvEspecialidades.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        MsgBox("Seleccionaste dar de baja una especialidad", MsgBoxStyle.Information)
        anchoPantalla(650)
        flag_abm = 3
        limpiarTextBox()
        Me.txbEspecialidad.Enabled = False
        Me.txbIdEspecialidad.Text = Me.dgvEspecialidades.CurrentRow.Cells(0).Value.ToString
        Me.txbEspecialidad.Text = Me.dgvEspecialidades.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If flag_abm = 1 Then
            altaEspecialidad()
            anchoPantalla(490)
            limpiarTextBox()
        ElseIf flag_abm = 2 Then
            modificarEspecialidad()
            anchoPantalla(490)
            limpiarTextBox()
        ElseIf flag_abm = 3 Then
            bajaEspecialidad()
            anchoPantalla(490)
            limpiarTextBox()
        End If
    End Sub

    Private Sub dgvEspecialidades_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvEspecialidades.KeyDown
        If wrfm = 1 Then
            If e.KeyCode = Keys.Enter Then
                Dim frm As frmOperarios = CType(Owner, frmOperarios)
                frm.txbEspecialidad.Text = Me.dgvEspecialidades.CurrentRow.Cells(0).Value.ToString
                wrfm = 0
                Me.Close()
            End If
        ElseIf wrfm = 2 Then
            If e.KeyCode = Keys.Enter Then
                Dim frm As frmTareas = CType(Owner, frmTareas)
                frm.txbEspecialidad.Text = Me.dgvEspecialidades.CurrentRow.Cells(0).Value.ToString
                wrfm = 0
                Me.Close()
            End If
        End If
    End Sub

End Class