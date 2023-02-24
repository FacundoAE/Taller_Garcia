Public Class frmAutos
    Private Sub limpiarTextBox()
        Me.txbNroPatente.Clear()
        Me.txbMarca.Clear()
        Me.txbModelo.Clear()
        Me.txbColor.Clear()
        Me.txbPropietario.Clear()
    End Sub

    Private Sub ADCampos(x As String)
        If x = "activar" Then
            Me.txbNroPatente.Enabled = True
            Me.txbMarca.Enabled = True
            Me.txbModelo.Enabled = True
            Me.txbColor.Enabled = True
            Me.txbPropietario.Enabled = True
            Me.btnAceptar.Enabled = True
        ElseIf x = "desactivar" Then
            Me.txbNroPatente.Enabled = False
            Me.txbMarca.Enabled = False
            Me.txbModelo.Enabled = False
            Me.txbColor.Enabled = False
            Me.txbPropietario.Enabled = False
            Me.btnAceptar.Enabled = False
        End If
    End Sub

    Private Sub llenarAutos()
        Dim sql As String = "SELECT nro_patente AS patente, marca, modelo, color, nombre_prop As Propietario, telefono_prop Telefono FROM autos
            INNER JOIN propietarios ON autos.id_propietario = propietarios.id_propietario"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("Autos")
        adp.Fill(ds.Tables("Autos"))
        Me.dgvAutos.DataSource = ds.Tables("Autos")

    End Sub

    Private Sub frmAutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarAutos()
    End Sub
    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        MsgBox("Seleccionaste dar de alta una especialidad", MsgBoxStyle.Information)
        flag_abm = 1
        limpiarTextBox()
        ADCampos("activar")
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        MsgBox("Seleccionaste modificar una especialidad", MsgBoxStyle.Information)
        flag_abm = 2
        limpiarTextBox()
        ADCampos("activar")
        Me.txbNroPatente.Text = Me.dgvAutos.CurrentRow.Cells(0).Value.ToString
        Me.txbMarca.Text = Me.dgvAutos.CurrentRow.Cells(1).Value.ToString
        Me.txbModelo.Text = Me.dgvAutos.CurrentRow.Cells(2).Value.ToString
        Me.txbColor.Text = Me.dgvAutos.CurrentRow.Cells(3).Value.ToString
    End Sub
    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        MsgBox("Seleccionaste dar de baja una especialidad", MsgBoxStyle.Information)
        flag_abm = 3
        limpiarTextBox()
        ADCampos("activar")
        Me.txbNroPatente.Text = Me.dgvAutos.CurrentRow.Cells(0).Value.ToString
        Me.txbMarca.Text = Me.dgvAutos.CurrentRow.Cells(1).Value.ToString
        Me.txbModelo.Text = Me.dgvAutos.CurrentRow.Cells(2).Value.ToString
        Me.txbColor.Text = Me.dgvAutos.CurrentRow.Cells(3).Value.ToString
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If flag_abm = 1 Then
            altaAuto()
            limpiarTextBox()
            ADCampos("desactivar")
        ElseIf flag_abm = 2 Then
            modificarAuto()
            limpiarTextBox()
            ADCampos("desactivar")
        ElseIf flag_abm = 3 Then
            bajaAuto()
            limpiarTextBox()
            ADCampos("desactivar")
        End If
    End Sub

    Private Sub altaAuto()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"INSERT INTO autos VALUES('{Me.txbNroPatente.Text}','" &
        Me.txbMarca.Text & "','" & Me.txbModelo.Text & "','" & Me.txbColor.Text & "'," &
            Me.txbPropietario.Text & ")"
        cmd.CommandText = sql

        If Me.txbNroPatente.Text <> "" And Me.txbMarca.Text <> "" And Me.txbModelo.Text <> "" And Me.txbColor.Text <> "" And Me.txbPropietario.Text <> "" Then
            If Me.txbPropietario.Text <> "" And IsNumeric(Me.txbPropietario.Text) = True Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarAutos()
                    limpiarTextBox()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("El campo propietario no puede estar vacío y debe ser un numero", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Los campos no pueden estar vacios", MsgBoxStyle.Critical, "Error")
        End If

    End Sub
    Private Sub modificarAuto()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"UPDATE autos SET marca = '{Me.txbMarca.Text}', modelo = '{Me.txbModelo.Text}', color = '{Me.txbColor.Text}' 
            WHERE nro_patente = '{Me.txbNroPatente.Text}' AND id_propietario = {Me.txbPropietario.Text}"
        cmd.CommandText = sql

        If Me.txbNroPatente.Text <> "" And Me.txbMarca.Text <> "" And Me.txbModelo.Text <> "" And Me.txbColor.Text <> "" And Me.txbPropietario.Text <> "" Then
            If Me.txbPropietario.Text <> "" And IsNumeric(Me.txbPropietario.Text) = True Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarAutos()
                    limpiarTextBox()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("El campo propietario no puede estar vacío y debe ser un numero", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Los campos no pueden estar vacios", MsgBoxStyle.Critical, "Error")
        End If

    End Sub
    Private Sub bajaAuto()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = $"DELETE FROM autos WHERE nro_patente = '{Me.txbNroPatente.Text}' AND id_propietario = {Me.txbPropietario.Text}"
        cmd.CommandText = sql

        If Me.txbNroPatente.Text <> "" And Me.txbMarca.Text <> "" And Me.txbModelo.Text <> "" And Me.txbColor.Text <> "" And Me.txbPropietario.Text <> "" Then
            If Me.txbPropietario.Text <> "" And IsNumeric(Me.txbPropietario.Text) = True Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarAutos()
                    limpiarTextBox()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("El campo propietario no puede estar vacío y debe ser un numero", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Los campos no pueden estar vacios", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub txbPropietario_KeyDown(sender As Object, e As KeyEventArgs) Handles txbPropietario.KeyDown
        If e.KeyData = Keys.Enter Then
            wrfm = 1
            Dim frm As New frmPropietarios
            AddOwnedForm(frm)
            frm.ShowDialog()
        End If
    End Sub

    Private Sub dgvAutos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvAutos.KeyDown
        If wrfm = 1 Then
            If e.KeyCode = Keys.Enter Then
                Dim frm As frmIngresos = CType(Owner, frmIngresos)
                frm.txbPatente.Text = Me.dgvAutos.CurrentRow.Cells(0).Value.ToString
                wrfm = 0
                Me.Close()
            End If
        ElseIf wrfm = 2 Then
            If e.KeyCode = Keys.Enter Then
                Dim frm As frmReportePatente = CType(Owner, frmReportePatente)
                frm.txbPatente.Text = Me.dgvAutos.CurrentRow.Cells(0).Value.ToString
                wrfm = 0
                Me.Close()
            End If
        End If
    End Sub

End Class