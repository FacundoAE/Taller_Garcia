Public Class frmPropietarios
    Private Sub anchoPantalla(x As Integer)
        Me.Width = x
        Me.CenterToScreen()
    End Sub
    Private Sub limpiarTextBox()
        Me.txbIdPropietario.Clear()
        Me.txbNombrePropietario.Clear()
        Me.txbTelefonoPropietario.Clear()
    End Sub
    Private Sub llenarPropietarios()
        Dim sql As String = "SELECT id_propietario AS ID, nombre_prop AS Nombre, telefono_prop AS Telefono FROM propietarios"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("Propietarios")
        adp.Fill(ds.Tables("Propietarios"))
        Me.dgvPropietarios.DataSource = ds.Tables("Propietarios")

    End Sub
    Private Sub frmPropietarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarPropietarios()
        anchoPantalla(490)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If flag_abm = 1 Then
            altaPropietario()
            anchoPantalla(490)
            limpiarTextBox()
        ElseIf flag_abm = 2 Then
            modificarPropietario()
            anchoPantalla(490)
            limpiarTextBox()
        ElseIf flag_abm = 3 Then
            bajaPropietario()
            anchoPantalla(490)
            limpiarTextBox()
        End If
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        MsgBox("Seleccionaste dar de alta una especialidad", MsgBoxStyle.Information)
        anchoPantalla(650)
        flag_abm = 1
        limpiarTextBox()
        Me.txbNombrePropietario.Enabled = True
        Me.txbTelefonoPropietario.Enabled = True
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        MsgBox("Seleccionaste modificar una especialidad", MsgBoxStyle.Information)
        anchoPantalla(650)
        flag_abm = 2
        limpiarTextBox()
        Me.txbNombrePropietario.Enabled = True
        Me.txbTelefonoPropietario.Enabled = True
        Me.txbIdPropietario.Text = Me.dgvPropietarios.CurrentRow.Cells(0).Value.ToString
        Me.txbNombrePropietario.Text = Me.dgvPropietarios.CurrentRow.Cells(1).Value.ToString
        Me.txbTelefonoPropietario.Text = Me.dgvPropietarios.CurrentRow.Cells(2).Value.ToString
    End Sub
    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        MsgBox("Seleccionaste dar de baja una especialidad", MsgBoxStyle.Information)
        anchoPantalla(650)
        flag_abm = 3
        limpiarTextBox()
        Me.txbNombrePropietario.Enabled = False
        Me.txbTelefonoPropietario.Enabled = False
        Me.txbIdPropietario.Text = Me.dgvPropietarios.CurrentRow.Cells(0).Value.ToString
        Me.txbNombrePropietario.Text = Me.dgvPropietarios.CurrentRow.Cells(1).Value.ToString
        Me.txbTelefonoPropietario.Text = Me.dgvPropietarios.CurrentRow.Cells(2).Value.ToString
    End Sub

    Private Sub altaPropietario()
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "INSERT INTO propietarios VALUES(" & Me.txbIdPropietario.Text & ",'" & Me.txbNombrePropietario.Text & "','" & Me.txbTelefonoPropietario.Text & "')"
        cmd.CommandText = sql

        If Me.txbIdPropietario.Text <> "" And IsNumeric(Me.txbIdPropietario.Text) = True Then
            If Me.txbNombrePropietario.Text <> "" And IsNumeric(Me.txbNombrePropietario.Text) = False Then
                If Me.txbTelefonoPropietario.Text <> "" Then
                    Try
                        cmd.ExecuteNonQuery()
                        Console.Beep()
                        llenarPropietarios()
                        limpiarTextBox()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Else
                    MsgBox("El campo telefono no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                End If
            Else
                    MsgBox("El campo nombre no puede estar vacio, ni ser un numero.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("El campo id no puede estar vacio y debe ser un numero.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Private Sub modificarPropietario()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "UPDATE propietarios SET nombre_prop = '" & Me.txbNombrePropietario.Text &
            "', telefono_prop = '" & Me.txbTelefonoPropietario.Text & "' WHERE id_propietario = " & Me.txbIdPropietario.Text
        cmd.CommandText = sql

        If Me.txbIdPropietario.Text <> "" And IsNumeric(Me.txbIdPropietario.Text) = True Then
            If Me.txbNombrePropietario.Text <> "" And IsNumeric(Me.txbNombrePropietario.Text) = False Then
                If Me.txbTelefonoPropietario.Text <> "" Then
                    Try
                        cmd.ExecuteNonQuery()
                        Console.Beep()
                        llenarPropietarios()
                        limpiarTextBox()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Else
                    MsgBox("El campo telefono no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("El campo nombre no puede estar vacio, ni ser un numero.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("El campo id no puede estar vacio y debe ser un numero.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub
    Private Sub bajaPropietario()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "DELETE FROM propietarios WHERE id_propietario = " & Me.txbIdPropietario.Text
        cmd.CommandText = sql

        If Me.txbIdPropietario.Text <> "" And IsNumeric(Me.txbIdPropietario.Text) = True Then
            Dim seguridad = MsgBox("Vas a dar de baja a ID: " & Me.txbIdPropietario.Text & " Nombre: " & Me.txbNombrePropietario.Text & " Telefono: " & Me.txbTelefonoPropietario.Text, vbOKCancel, "Seguridad")

            If seguridad = vbOKCancel Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarPropietarios()
                    limpiarTextBox()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If

        Else
            MsgBox("El id no puede estar vacios.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub dgvPropietarios_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvPropietarios.KeyDown
        If wrfm = 1 Then
            If e.KeyCode = Keys.Enter Then
                Dim frm As frmAutos = CType(Owner, frmAutos)
                frm.txbPropietario.Text = Me.dgvPropietarios.CurrentRow.Cells(0).Value.ToString
                wrfm = 0
                Me.Close()
            End If
        ElseIf wrfm = 2 Then
            If e.KeyCode = Keys.Enter Then
                Dim frm As frmReportePropietario = CType(Owner, frmReportePropietario)
                frm.txbPropietario.Text = Me.dgvPropietarios.CurrentRow.Cells(0).Value.ToString
                wrfm = 0
                Me.Close()
            End If
        ElseIf wrfm = 3 Then
            If e.KeyCode = Keys.Enter Then
                Dim frm As frmReporteGasto = CType(Owner, frmReporteGasto)
                frm.txbPropietario.Text = Me.dgvPropietarios.CurrentRow.Cells(0).Value.ToString
                wrfm = 0
                Me.Close()
            End If
        End If
    End Sub
End Class