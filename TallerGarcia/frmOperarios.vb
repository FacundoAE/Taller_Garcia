Public Class frmOperarios
    Private Sub limpiarTextBox()
        Me.txbId.Clear()
        Me.txbNombre.Clear()
        Me.txbImporte.Clear()
        Me.txbEspecialidad.Clear()
    End Sub
    Private Sub ADCampos(x As String)
        If x = "activar" Then
            Me.txbId.Enabled = True
            Me.txbNombre.Enabled = True
            Me.txbImporte.Enabled = True
            Me.txbEspecialidad.Enabled = True
            Me.btnAceptar.Enabled = True
        ElseIf x = "desactivar" Then
            Me.txbId.Enabled = False
            Me.txbNombre.Enabled = False
            Me.txbImporte.Enabled = False
            Me.txbEspecialidad.Enabled = False
            Me.btnAceptar.Enabled = False
        End If
    End Sub
    Private Sub llenarOperarios()
        Dim sql As String = "SELECT id_operario AS ID, nombre_operario AS Nombre,
        especialidad, importe_hora 
        FROM operarios INNER JOIN especialidades ON operarios.id_especialidad = especialidades.id_especialidad"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("Operarios")
        adp.Fill(ds.Tables("Operarios"))
        Me.dgvOperarios.DataSource = ds.Tables("Operarios")

    End Sub
    Private Sub frmOperarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarOperarios()
    End Sub
    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        MsgBox("Seleccionaste dar de alta un operario", MsgBoxStyle.Information)
        flag_abm = 1
        limpiarTextBox()
        ADCampos("activar")
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        MsgBox("Seleccionaste modificar un operario", MsgBoxStyle.Information)
        flag_abm = 2
        limpiarTextBox()
        ADCampos("activar")

        Me.txbId.Text = Me.dgvOperarios.CurrentRow.Cells(0).Value.ToString
        Me.txbNombre.Text = Me.dgvOperarios.CurrentRow.Cells(1).Value.ToString
        Me.txbImporte.Text = Me.dgvOperarios.CurrentRow.Cells(3).Value.ToString
    End Sub
    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        MsgBox("Seleccionaste dar de baja un operario", MsgBoxStyle.Information)
        flag_abm = 3
        limpiarTextBox()
        ADCampos("activar")

        Me.txbId.Text = Me.dgvOperarios.CurrentRow.Cells(0).Value.ToString
        Me.txbNombre.Text = Me.dgvOperarios.CurrentRow.Cells(1).Value.ToString
        Me.txbImporte.Text = Me.dgvOperarios.CurrentRow.Cells(3).Value.ToString
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If flag_abm = 1 Then
            altaOperario()
            limpiarTextBox()
            ADCampos("desactivar")
        ElseIf flag_abm = 2 Then
            modificarOperario()
            limpiarTextBox()
            ADCampos("desactivar")
        ElseIf flag_abm = 3 Then
            bajaOperario()
            limpiarTextBox()
            ADCampos("desactivar")
        End If
    End Sub

    Private Sub txbEspecialidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txbEspecialidad.KeyDown
        If e.KeyData = Keys.Enter Then
            wrfm = 1
            Dim frm As New frmEspecialidades
            AddOwnedForm(frm)
            frm.ShowDialog()
        End If
    End Sub

    Private Sub altaOperario()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"INSERT INTO operarios VALUES({Me.txbId.Text},'{Me.txbNombre.Text}',{Me.txbEspecialidad.Text},{Me.txbImporte.Text})"
        cmd.CommandText = sql

        If Me.txbId.Text <> "" And Me.txbNombre.Text <> "" And Me.txbImporte.Text <> "" And Me.txbEspecialidad.Text <> "" Then
            If IsNumeric(Me.txbId.Text) = True And IsNumeric(Me.txbEspecialidad.Text) = True Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarOperarios()
                    limpiarTextBox()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("Los campos ID y especialidad deben ser un numero", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Los campos no pueden estar vacios", MsgBoxStyle.Critical, "Error")
        End If

    End Sub
    Private Sub modificarOperario()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"UPDATE operarios SET id_operario = 
        {Me.txbId.Text}, nombre_operario ='{Me.txbNombre.Text}',
        id_especialidad = {Me.txbEspecialidad.Text}, importe_hora = {Replace(Me.txbImporte.Text, ",", ".")}"
        cmd.CommandText = sql

        If Me.txbId.Text <> "" And Me.txbNombre.Text <> "" And Me.txbImporte.Text <> "" And Me.txbEspecialidad.Text <> "" Then
            If IsNumeric(Me.txbId.Text) = True And IsNumeric(Me.txbEspecialidad.Text) = True Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarOperarios()
                    limpiarTextBox()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("Los campos ID y especialidad deben ser un numero", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Los campos no pueden estar vacios", MsgBoxStyle.Critical, "Error")
        End If

    End Sub
    Private Sub bajaOperario()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"DELETE FROM operarios WHERE id_operario = {Me.txbId.Text}"
        cmd.CommandText = sql

        If Me.txbId.Text <> "" Then
            If IsNumeric(Me.txbId.Text) = True Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarOperarios()
                    limpiarTextBox()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("Los campos ID y especialidad deben ser un numero", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Los campos no pueden estar vacios", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

End Class