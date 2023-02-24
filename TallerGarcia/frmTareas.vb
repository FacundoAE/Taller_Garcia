Public Class frmTareas
    Private Sub limpiarTextBox()
        Me.txbCodigoTarea.Clear()
        Me.txbDescripcion.Clear()
        Me.txbHoras.Clear()
        Me.txbEspecialidad.Clear()
    End Sub
    Private Sub ADCampos(x As String)
        If x = "activar" Then
            Me.txbCodigoTarea.Enabled = True
            Me.txbDescripcion.Enabled = True
            Me.txbHoras.Enabled = True
            Me.txbEspecialidad.Enabled = True
            Me.btnAceptar.Enabled = True
        ElseIf x = "desactivar" Then
            Me.txbCodigoTarea.Enabled = False
            Me.txbDescripcion.Enabled = False
            Me.txbHoras.Enabled = False
            Me.txbEspecialidad.Enabled = False
            Me.btnAceptar.Enabled = False
        End If
    End Sub
    Private Sub llenarTareas()
        Dim sql As String = "SELECT cod_tarea AS Codigo, descripcion_tarea AS Descripcion,
horas_tarea AS Horas, especialidad AS Especialidad FROM tareas
INNER JOIN especialidades ON tareas.id_especialidad = especialidades.id_especialidad"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("Tareas")
        adp.Fill(ds.Tables("Tareas"))
        Me.dgvTareas.DataSource = ds.Tables("Tareas")

    End Sub

    Private Sub frmTareas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarTareas()
    End Sub

    Private Sub txbEspecialidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txbEspecialidad.KeyDown
        If e.KeyData = Keys.Enter Then
            wrfm = 2
            Dim frm As New frmEspecialidades
            AddOwnedForm(frm)
            frm.ShowDialog()
        End If
    End Sub
    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        MsgBox("Seleccionaste dar de alta una tarea", MsgBoxStyle.Information)
        flag_abm = 1
        limpiarTextBox()
        ADCampos("activar")
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        MsgBox("Seleccionaste modificar una tarea", MsgBoxStyle.Information)
        flag_abm = 2
        limpiarTextBox()
        ADCampos("activar")

        Me.txbCodigoTarea.Text = Me.dgvTareas.CurrentRow.Cells(0).Value.ToString
        Me.txbDescripcion.Text = Me.dgvTareas.CurrentRow.Cells(1).Value.ToString
        Me.txbHoras.Text = Me.dgvTareas.CurrentRow.Cells(2).Value.ToString

    End Sub
    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        MsgBox("Seleccionaste dar de baja una tarea", MsgBoxStyle.Information)
        flag_abm = 3
        limpiarTextBox()
        ADCampos("activar")

        Me.txbCodigoTarea.Text = Me.dgvTareas.CurrentRow.Cells(0).Value.ToString
        Me.txbDescripcion.Text = Me.dgvTareas.CurrentRow.Cells(1).Value.ToString
        Me.txbHoras.Text = Me.dgvTareas.CurrentRow.Cells(2).Value.ToString
    End Sub

    Private Sub altaTarea()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"INSERT INTO tareas VALUES({Me.txbCodigoTarea.Text},'{Me.txbDescripcion.Text}',{Replace(Me.txbHoras.Text, ",", ".")},{Me.txbEspecialidad.Text})"
        cmd.CommandText = sql

        If Me.txbCodigoTarea.Text <> "" And Me.txbEspecialidad.Text <> "" And Me.txbDescripcion.Text <> "" And Me.txbHoras.Text <> "" Then
            If IsNumeric(Me.txbCodigoTarea.Text) = True And IsNumeric(Me.txbEspecialidad.Text) = True And IsNumeric(Me.txbHoras.Text) = True Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarTareas()
                    limpiarTextBox()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("Código de tarea, especialidad y horas deben ser un numero", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Los campos no pueden estar vacios", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub modificarTarea()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"UPDATE tareas SET descripcion_tarea = '{Me.txbDescripcion.Text}', horas_tarea = {Replace(Me.txbHoras.Text, ",", ".")}, id_especialidad = {Me.txbEspecialidad.Text} WHERE cod_tarea = {Me.txbCodigoTarea.Text}"
        cmd.CommandText = sql

        If Me.txbCodigoTarea.Text <> "" And Me.txbEspecialidad.Text <> "" And Me.txbDescripcion.Text <> "" And Me.txbHoras.Text <> "" Then
            If IsNumeric(Me.txbCodigoTarea.Text) = True And IsNumeric(Me.txbEspecialidad.Text) = True And IsNumeric(Me.txbHoras.Text) = True Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarTareas()
                    limpiarTextBox()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("Código de tarea, especialidad y horas deben ser un numero", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Los campos no pueden estar vacios", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub bajaTarea()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"DELETE FROM tareas WHERE cod_tarea = {Me.txbCodigoTarea.Text}"
        cmd.CommandText = sql

        If Me.txbCodigoTarea.Text <> "" Then
            If IsNumeric(Me.txbCodigoTarea.Text) = True Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarTareas()
                    limpiarTextBox()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("Código de tarea, especialidad y horas deben ser un numero", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Los campos no pueden estar vacios", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If flag_abm = 1 Then
            altaTarea()
            limpiarTextBox()
            ADCampos("desactivar")
        ElseIf flag_abm = 2 Then
            modificarTarea()
            limpiarTextBox()
            ADCampos("desactivar")
        ElseIf flag_abm = 3 Then
            bajaTarea()
            limpiarTextBox()
            ADCampos("desactivar")
        End If
    End Sub
    Private Sub dgvTareas_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvTareas.KeyDown
        If wrfm = 1 Then
            If e.KeyCode = Keys.Enter Then
                Dim frm As frmIngresosTareas = CType(Owner, frmIngresosTareas)
                frm.txbIDCodigoTarea.Text = Me.dgvTareas.CurrentRow.Cells(0).Value.ToString
                wrfm = 0
                Me.Close()
            End If
        End If
    End Sub
End Class