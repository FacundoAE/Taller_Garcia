Public Class frmIngresosRepuestos
    Private Sub txbIDIngreso_KeyDown(sender As Object, e As KeyEventArgs) Handles txbIDIngreso.KeyDown
        If e.KeyData = Keys.Enter Then
            wrfm = 2
            Dim frm As New frmIngresos
            AddOwnedForm(frm)
            frm.ShowDialog()
        End If
    End Sub

    Private Sub txbIDCodigoTarea_KeyDown(sender As Object, e As KeyEventArgs) Handles txbIDCodigoRepuesto.KeyDown
        If e.KeyData = Keys.Enter Then
            wrfm = 1
            Dim frm As New frmRepuestos
            AddOwnedForm(frm)
            frm.ShowDialog()
        End If
    End Sub
    Private Sub limpiarTextBox()
        Me.txbIDIngreso.Clear()
        Me.txbIDCodigoRepuesto.Clear()
        Me.txbImporteRepuesto.Clear()
        Me.txbCantidad.Clear()
    End Sub

    Private Sub ADCampos(x As String)
        If x = "activar" Then
            Me.txbIDIngreso.Enabled = True
            Me.txbIDCodigoRepuesto.Enabled = True
            Me.txbImporteRepuesto.Enabled = True
            Me.txbCantidad.Enabled = True
            Me.btnAceptar.Enabled = True
        ElseIf x = "desactivar" Then
            Me.txbIDIngreso.Enabled = False
            Me.txbIDCodigoRepuesto.Enabled = False
            Me.txbImporteRepuesto.Enabled = False
            Me.txbCantidad.Enabled = False
            Me.btnAceptar.Enabled = False
        End If
    End Sub
    Private Sub llenarIngresosRepuestos()
        Dim sql As String = "SELECT * FROM ingresos_respuestos"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("RespuestosTareas")
        adp.Fill(ds.Tables("RespuestosTareas"))
        Me.dgvIngresosRepuestos.DataSource = ds.Tables("RespuestosTareas")
    End Sub

    Private Sub frmIngresosRepuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarIngresosRepuestos()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If flag_abm = 1 Then
            altaIngresosRepuestos()
            limpiarTextBox()
            ADCampos("desactivar")
        ElseIf flag_abm = 2 Then
            modificarIngresosRepuestos()
            limpiarTextBox()
            ADCampos("desactivar")
        ElseIf flag_abm = 3 Then
            bajaIngresosRepuestos()
            limpiarTextBox()
            ADCampos("desactivar")
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

        Me.txbIDIngreso.Text = Me.dgvIngresosRepuestos.CurrentRow.Cells(0).Value.ToString
        Me.txbIDCodigoRepuesto.Text = Me.dgvIngresosRepuestos.CurrentRow.Cells(1).Value.ToString
        Me.txbImporteRepuesto.Text = Me.dgvIngresosRepuestos.CurrentRow.Cells(2).Value.ToString
        Me.txbCantidad.Text = Me.dgvIngresosRepuestos.CurrentRow.Cells(3).Value.ToString

    End Sub
    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        MsgBox("Seleccionaste dar de baja un ingreso tarea", MsgBoxStyle.Information)
        flag_abm = 3
        limpiarTextBox()
        ADCampos("activar")

        Me.txbIDIngreso.Text = Me.dgvIngresosRepuestos.CurrentRow.Cells(0).Value.ToString
        Me.txbIDCodigoRepuesto.Text = Me.dgvIngresosRepuestos.CurrentRow.Cells(1).Value.ToString
        Me.txbImporteRepuesto.Text = Me.dgvIngresosRepuestos.CurrentRow.Cells(2).Value.ToString
        Me.txbCantidad.Text = Me.dgvIngresosRepuestos.CurrentRow.Cells(3).Value.ToString

    End Sub
    Private Sub altaIngresosRepuestos()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"INSERT INTO ingresos_respuestos VALUES({Me.txbIDIngreso.Text},{Me.txbIDCodigoRepuesto.Text},{Replace(Me.txbImporteRepuesto.Text, ",", ".")},{Me.txbCantidad.Text},{Replace(Me.txbImporteRepuesto.Text, ",", ".") * Replace(Me.txbCantidad.Text, ",", ".")})"
        cmd.CommandText = sql

        If Me.txbIDIngreso.Text <> "" And IsNumeric(Me.txbIDIngreso.Text) = True And Me.txbIDCodigoRepuesto.Text <> "" And IsNumeric(Me.txbIDCodigoRepuesto.Text) = True And Me.txbImporteRepuesto.Text <> "" And IsNumeric(Me.txbImporteRepuesto.Text) = True And Me.txbCantidad.Text <> "" And IsNumeric(Me.txbCantidad.Text) = True Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarIngresosRepuestos()
                limpiarTextBox()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Los campos no pueden estar vacios y deben ser numeros", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Private Sub modificarIngresosRepuestos()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"UPDATE ingresos_respuestos SET
importe_rep = {Replace(Me.txbImporteRepuesto.Text, ",", ".")}, cantidad = {Me.txbCantidad.Text}, importe = {Replace(Me.txbImporteRepuesto.Text, ",", ".") * Replace(Me.txbCantidad.Text, ",", ".")}
WHERE id_ingreso = {Me.txbIDIngreso.Text} AND cod_respuesto = {Me.txbIDCodigoRepuesto.Text}"
        cmd.CommandText = sql

        If Me.txbIDIngreso.Text <> "" And IsNumeric(Me.txbIDIngreso.Text) = True And Me.txbIDCodigoRepuesto.Text <> "" And IsNumeric(Me.txbIDCodigoRepuesto.Text) = True And Me.txbImporteRepuesto.Text <> "" And IsNumeric(Me.txbImporteRepuesto.Text) = True And Me.txbCantidad.Text <> "" And IsNumeric(Me.txbCantidad.Text) = True Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarIngresosRepuestos()
                limpiarTextBox()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Los campos no pueden estar vacios y deben ser numeros", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Private Sub bajaIngresosRepuestos()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"DELETE FROM ingresos_respuestos WHERE id_ingreso = {Me.txbIDIngreso.Text} AND cod_respuesto = {Me.txbIDCodigoRepuesto.Text}"
        cmd.CommandText = sql

        If Me.txbIDIngreso.Text <> "" And IsNumeric(Me.txbIDIngreso.Text) = True And Me.txbIDCodigoRepuesto.Text <> "" And IsNumeric(Me.txbIDCodigoRepuesto.Text) = True Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarIngresosRepuestos()
                limpiarTextBox()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Los campos ingreso y codigo repuesto no pueden estar vacios y deben ser numeros", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Class