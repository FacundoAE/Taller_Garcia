Public Class frmIngresos
    Private Sub llenarIngresos()
        Dim sql As String = "SELECT id_ingreso,
        REPLACE(CONVERT(NVARCHAR,fecha_ing,104),'.' ,'/') AS Fecha, CONVERT(VARCHAR,fecha_ing,8) As Hora,
        nro_patente FROM ingresos"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("Ingresos")
        adp.Fill(ds.Tables("Ingresos"))
        Me.dgvIngresos.DataSource = ds.Tables("Ingresos")

    End Sub
    Private Sub limpiarTextBox()
        Me.txbID.Clear()
        Me.txbDia.Clear()
        Me.txbMes.Clear()
        Me.txbAnio.Clear()
        Me.txbHora.Clear()
        Me.txbMinutos.Clear()
        Me.txbPatente.Clear()
    End Sub
    Private Sub ADCampos(x As String)
        If x = "activar" Then
            Me.txbDia.Enabled = True
            Me.txbMes.Enabled = True
            Me.txbAnio.Enabled = True
            Me.txbHora.Enabled = True
            Me.txbPatente.Enabled = True
            Me.btnAceptar.Enabled = True
            Me.txbMinutos.Enabled = True
        ElseIf x = "desactivar" Then
            Me.txbDia.Enabled = False
            Me.txbMes.Enabled = False
            Me.txbAnio.Enabled = False
            Me.txbHora.Enabled = False
            Me.txbPatente.Enabled = False
            Me.btnAceptar.Enabled = False
            Me.txbMinutos.Enabled = False
        End If
    End Sub
    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        MsgBox("Seleccionaste dar de alta un ingreso", MsgBoxStyle.Information)
        flag_abm = 1
        limpiarTextBox()
        ADCampos("activar")
        Me.txbDia.Text = Now.Day
        Me.txbMes.Text = Now.Month
        Me.txbAnio.Text = Now.Year
        Me.txbHora.Text = Now.Hour
        Me.txbMinutos.Text = Now.Minute
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        MsgBox("Seleccionaste modificar un ingreso", MsgBoxStyle.Information)
        flag_abm = 2
        limpiarTextBox()
        ADCampos("activar")

        Dim Fecha As String = Me.dgvIngresos.CurrentRow.Cells(1).Value.ToString
        Dim Hora As String = Me.dgvIngresos.CurrentRow.Cells(2).Value.ToString

        Fecha.Split()
        Hora.Split()

        Me.txbID.Text = Me.dgvIngresos.CurrentRow.Cells(0).Value.ToString
        Me.txbDia.Text = Fecha(0) & Fecha(1)
        Me.txbMes.Text = Fecha(3) & Fecha(4)
        Me.txbAnio.Text = Fecha(6) & Fecha(7) & Fecha(8) & Fecha(9)
        Me.txbHora.Text = Hora(0) & Hora(1)
        Me.txbMinutos.Text = Hora(3) & Hora(4)
        Me.txbPatente.Text = Me.dgvIngresos.CurrentRow.Cells(3).Value.ToString
    End Sub
    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        MsgBox("Seleccionaste dar de baja un ingreso", MsgBoxStyle.Information)
        flag_abm = 3
        limpiarTextBox()
        ADCampos("activar")

        Me.txbDia.Visible = False
        Me.txbMes.Visible = False
        Me.txbAnio.Visible = False
        Me.txbHora.Visible = False
        Me.txbMinutos.Visible = False
        Me.lblDia.Visible = False
        Me.lblMes.Visible = False
        Me.lblAnio.Visible = False
        Me.lblHora.Visible = False
        Me.lblMinutos.Visible = False

        Me.txbID.Text = Me.dgvIngresos.CurrentRow.Cells(0).Value.ToString
        Me.txbPatente.Text = Me.dgvIngresos.CurrentRow.Cells(3).Value.ToString
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If flag_abm = 1 Then
            altaIngreso()
            limpiarTextBox()
            ADCampos("desactivar")
        ElseIf flag_abm = 2 Then
            modificarIngreso()
            limpiarTextBox()
            ADCampos("desactivar")
        ElseIf flag_abm = 3 Then
            bajaIngreso()
            limpiarTextBox()
            ADCampos("desactivar")
        End If
    End Sub
    Private Sub frmIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarIngresos()
    End Sub
    Private Sub txbPatente_KeyDown(sender As Object, e As KeyEventArgs) Handles txbPatente.KeyDown
        If e.KeyData = Keys.Enter Then
            wrfm = 1
            Dim frm As New frmAutos
            AddOwnedForm(frm)
            frm.ShowDialog()
        End If
    End Sub
    Private Sub altaIngreso()

        Dim FechayHora As String = $"{Me.txbAnio.Text}-{Me.txbMes.Text}-{Me.txbDia.Text} {Me.txbHora.Text}:{Me.txbMinutos.Text}:00"

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"INSERT INTO ingresos VALUES(CONVERT(DATETIME,'{FechayHora}',20),'{Me.txbPatente.Text}')"
        cmd.CommandText = sql

        If Me.txbDia.Text <> "" And Me.txbMes.Text <> "" And Me.txbAnio.Text <> "" And Me.txbHora.Text <> "" And Me.txbMinutos.Text <> "" And Me.txbPatente.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarIngresos()
                limpiarTextBox()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Los campos no pueden estar vacios", MsgBoxStyle.Critical, "Error")
        End If

    End Sub
    Private Sub modificarIngreso()

        Dim FechayHora As String = $"{Me.txbAnio.Text}-{Me.txbMes.Text}-{Me.txbDia.Text} {Me.txbHora.Text}:{Me.txbMinutos.Text}:00"

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"UPDATE ingresos SET fecha_ing = CONVERT(DATETIME,'{FechayHora}',20), nro_patente = '{Me.txbPatente.Text}' WHERE id_ingreso = {Me.txbID.Text}"
        cmd.CommandText = sql

        If Me.txbDia.Text <> "" And Me.txbMes.Text <> "" And Me.txbAnio.Text <> "" And Me.txbHora.Text <> "" And Me.txbMinutos.Text <> "" And Me.txbPatente.Text <> "" Then
            Try
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarIngresos()
                limpiarTextBox()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Los campos no pueden estar vacios", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Private Sub bajaIngreso()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"DELETE FROM ingresos WHERE id_ingreso = {Me.txbID.Text} AND nro_patente = '{Me.txbPatente.Text}'"
        cmd.CommandText = sql

        If Me.txbID.Text <> "" Then
            If IsNumeric(Me.txbID.Text) = True Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarIngresos()
                    limpiarTextBox()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("El campo ID debe ser un numero", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("El campo ID no puede estar vacio", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub dgvIngresos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvIngresos.KeyDown
        If wrfm = 1 Then
            If e.KeyCode = Keys.Enter Then
                Dim frm As frmIngresosTareas = CType(Owner, frmIngresosTareas)
                frm.txbIDIngreso.Text = Me.dgvIngresos.CurrentRow.Cells(0).Value.ToString
                wrfm = 0
                Me.Close()
            End If
        ElseIf wrfm = 2 Then
            If e.KeyCode = Keys.Enter Then
                Dim frm As frmIngresosRepuestos = CType(Owner, frmIngresosRepuestos)
                frm.txbIDIngreso.Text = Me.dgvIngresos.CurrentRow.Cells(0).Value.ToString
                wrfm = 0
                Me.Close()
            End If
        End If
    End Sub

End Class