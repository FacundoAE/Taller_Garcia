Public Class frmIngresosTareas
    Private Sub limpiarTextBox()
        Me.txbIDIngreso.Clear()
        Me.txbIDCodigoTarea.Clear()
        Me.txbImporte.Clear()
    End Sub
    Private Sub ADCampos(x As String)
        If x = "activar" Then
            Me.txbIDCodigoTarea.Enabled = True
            Me.txbIDIngreso.Enabled = True
            Me.txbImporte.Enabled = True
            Me.btnAceptar.Enabled = True
        ElseIf x = "desactivar" Then
            Me.txbIDCodigoTarea.Enabled = False
            Me.txbIDIngreso.Enabled = False
            Me.txbImporte.Enabled = False
            Me.btnAceptar.Enabled = False
        End If
    End Sub
    Private Sub llenarIngresosTareas()
        Dim sql As String = "SELECT * FROM ingresos_tareas"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("IngresosTareas")
        adp.Fill(ds.Tables("IngresosTareas"))
        Me.dgvIngresosTareas.DataSource = ds.Tables("IngresosTareas")

    End Sub

    Private Sub txbID_KeyDown(sender As Object, e As KeyEventArgs) Handles txbIDIngreso.KeyDown
        If e.KeyData = Keys.Enter Then
            wrfm = 1
            Dim frm As New frmIngresos
            AddOwnedForm(frm)
            frm.ShowDialog()
        End If
    End Sub
    Private Sub txbCodigoTarea_KeyDown(sender As Object, e As KeyEventArgs) Handles txbIDCodigoTarea.KeyDown
        If e.KeyData = Keys.Enter Then
            wrfm = 1
            Dim frm As New frmTareas
            AddOwnedForm(frm)
            frm.ShowDialog()
        End If
    End Sub
    Private Sub frmIngresosTareas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarIngresosTareas()
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If flag_abm = 1 Then
            altaIngresosTareas()
            limpiarTextBox()
            ADCampos("desactivar")
        ElseIf flag_abm = 2 Then
            modificarIngresosTareas()
            limpiarTextBox()
            ADCampos("desactivar")
        ElseIf flag_abm = 3 Then
            bajaIngresosTareas()
            limpiarTextBox()
            ADCampos("desactivar")
        End If
    End Sub
    Private Sub altaIngresosTareas()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"INSERT INTO ingresos_tareas VALUES({Me.txbIDIngreso.Text},{Me.txbIDCodigoTarea.Text},{Replace(Me.txbImporte.Text, ",", ".")})"
        cmd.CommandText = sql

        If Me.txbIDIngreso.Text <> "" And IsNumeric(Me.txbIDIngreso.Text) = True And Me.txbIDCodigoTarea.Text <> "" And IsNumeric(Me.txbIDCodigoTarea.Text) = True And Me.txbImporte.Text <> "" And IsNumeric(Me.txbImporte.Text) = True Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarIngresosTareas()
                limpiarTextBox()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Los campos no pueden estar vacios y deben ser numeros", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Private Sub modificarIngresosTareas()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"UPDATE ingresos_tareas SET importe = {Replace(Me.txbImporte.Text, ",", ".")} WHERE id_ingreso = {Me.txbIDIngreso.Text} AND cod_tarea = {Me.txbIDCodigoTarea.Text}"
        cmd.CommandText = sql

        If Me.txbIDIngreso.Text <> "" And IsNumeric(Me.txbIDIngreso.Text) = True And Me.txbIDCodigoTarea.Text <> "" And IsNumeric(Me.txbIDCodigoTarea.Text) = True And Me.txbImporte.Text <> "" And IsNumeric(Me.txbImporte.Text) = True Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarIngresosTareas()
                limpiarTextBox()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Los campos no pueden estar vacios y deben ser numeros", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Private Sub bajaIngresosTareas()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"DELETE FROM ingresos_tareas WHERE id_ingreso = {Me.txbIDIngreso.Text} AND cod_tarea = {Me.txbIDCodigoTarea.Text}"
        cmd.CommandText = sql

        If Me.txbIDIngreso.Text <> "" And IsNumeric(Me.txbIDIngreso.Text) = True And Me.txbIDCodigoTarea.Text <> "" And IsNumeric(Me.txbIDCodigoTarea.Text) = True Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarIngresosTareas()
                limpiarTextBox()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Los campos no pueden estar vacios y deben ser numeros", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        MsgBox("Seleccionaste dar de alta un ingreso tarea", MsgBoxStyle.Information)
        flag_abm = 1
        limpiarTextBox()
        ADCampos("activar")
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        MsgBox("Seleccionaste modificar un ingreso tarea", MsgBoxStyle.Information)
        flag_abm = 2
        limpiarTextBox()
        ADCampos("activar")

        Me.txbIDIngreso.Text = Me.dgvIngresosTareas.CurrentRow.Cells(0).Value.ToString
        Me.txbIDCodigoTarea.Text = Me.dgvIngresosTareas.CurrentRow.Cells(1).Value.ToString
        Me.txbImporte.Text = Me.dgvIngresosTareas.CurrentRow.Cells(2).Value.ToString

    End Sub
    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        MsgBox("Seleccionaste dar de baja un ingreso tarea", MsgBoxStyle.Information)
        flag_abm = 3
        limpiarTextBox()
        ADCampos("activar")
        Me.txbImporte.Enabled = False

        Me.txbIDIngreso.Text = Me.dgvIngresosTareas.CurrentRow.Cells(0).Value.ToString
        Me.txbIDCodigoTarea.Text = Me.dgvIngresosTareas.CurrentRow.Cells(1).Value.ToString
        Me.txbImporte.Text = Me.dgvIngresosTareas.CurrentRow.Cells(2).Value.ToString
    End Sub
End Class