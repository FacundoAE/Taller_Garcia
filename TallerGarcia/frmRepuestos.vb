Public Class frmRepuestos
    Private Sub anchoPantalla(x As Integer)
        Me.Width = x
        Me.CenterToScreen()
    End Sub
    Private Sub limpiarTextBox()
        Me.txbCodigoRepuesto.Clear()
        Me.txbDescripcionRepuesto.Clear()
        Me.txbImporteRepuesto.Clear()
    End Sub
    Private Sub llenarRepuestos()
        Dim sql As String = "SELECT cod_repuesto AS Codigo, descripcion_rep AS Descripcion, importe_rep AS Importe FROM repuestos"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("Repuestos")
        adp.Fill(ds.Tables("Repuestos"))
        Me.dgvRepuestos.DataSource = ds.Tables("Repuestos")
    End Sub

    Private Sub frmRepuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarRepuestos()
        anchoPantalla(490)
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        MsgBox("Seleccionaste dar de alta una especialidad", MsgBoxStyle.Information)
        anchoPantalla(650)
        flag_abm = 1
        limpiarTextBox()
        Me.txbDescripcionRepuesto.Enabled = True
        Me.txbImporteRepuesto.Enabled = True
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        MsgBox("Seleccionaste modificar una especialidad", MsgBoxStyle.Information)
        anchoPantalla(650)
        flag_abm = 2
        limpiarTextBox()
        Me.txbDescripcionRepuesto.Enabled = True
        Me.txbImporteRepuesto.Enabled = True
        Me.txbCodigoRepuesto.Text = Me.dgvRepuestos.CurrentRow.Cells(0).Value.ToString
        Me.txbDescripcionRepuesto.Text = Me.dgvRepuestos.CurrentRow.Cells(1).Value.ToString
        Me.txbImporteRepuesto.Text = Me.dgvRepuestos.CurrentRow.Cells(2).Value.ToString
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        MsgBox("Seleccionaste dar de baja una especialidad", MsgBoxStyle.Information)
        anchoPantalla(650)
        flag_abm = 3
        limpiarTextBox()
        Me.txbDescripcionRepuesto.Enabled = False
        Me.txbImporteRepuesto.Enabled = False
        Me.txbCodigoRepuesto.Text = Me.dgvRepuestos.CurrentRow.Cells(0).Value.ToString
        Me.txbDescripcionRepuesto.Text = Me.dgvRepuestos.CurrentRow.Cells(1).Value.ToString
        Me.txbImporteRepuesto.Text = Me.dgvRepuestos.CurrentRow.Cells(2).Value.ToString
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If flag_abm = 1 Then
            altaRepuesto()
            anchoPantalla(490)
            limpiarTextBox()
        ElseIf flag_abm = 2 Then
            modificarRepuesto()
            anchoPantalla(490)
            limpiarTextBox()
        ElseIf flag_abm = 3 Then
            bajaRepuesto()
            anchoPantalla(490)
            limpiarTextBox()
        End If
    End Sub

    Private Sub altaRepuesto()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "INSERT INTO repuestos VALUES(" & Me.txbCodigoRepuesto.Text & ",'" & Me.txbDescripcionRepuesto.Text & "','" & Me.txbImporteRepuesto.Text & "')"
        cmd.CommandText = sql

        If Me.txbCodigoRepuesto.Text <> "" And IsNumeric(Me.txbCodigoRepuesto.Text) = True Then
            If Me.txbDescripcionRepuesto.Text <> "" And IsNumeric(Me.txbDescripcionRepuesto.Text) = False Then
                If Me.txbImporteRepuesto.Text <> "" And IsNumeric(Me.txbImporteRepuesto.Text) Then
                    Try
                        cmd.ExecuteNonQuery()
                        Console.Beep()
                        llenarRepuestos()
                        limpiarTextBox()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Else
                    MsgBox("El campo importe no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("El campo descripcion no puede estar vacio, ni ser un numero.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("El campo código no puede estar vacio y debe ser un numero.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub
    Private Sub modificarRepuesto()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "UPDATE repuestos SET descripcion_rep = '" & Me.txbDescripcionRepuesto.Text &
            "', importe_rep = '" & Replace(Me.txbImporteRepuesto.Text, ",", ".") & "' WHERE cod_repuesto = " & Me.txbCodigoRepuesto.Text
        cmd.CommandText = sql

        If Me.txbCodigoRepuesto.Text <> "" And IsNumeric(Me.txbCodigoRepuesto.Text) = True Then
            If Me.txbDescripcionRepuesto.Text <> "" And IsNumeric(Me.txbDescripcionRepuesto.Text) = False Then
                If Me.txbImporteRepuesto.Text <> "" And IsNumeric(Me.txbImporteRepuesto.Text) Then
                    Try
                        cmd.ExecuteNonQuery()
                        Console.Beep()
                        llenarRepuestos()
                        limpiarTextBox()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Else
                    MsgBox("El campo importe no puede estar vacio.", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("El campo descripcion no puede estar vacio, ni ser un numero.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("El campo código no puede estar vacio y debe ser un numero.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub
    Private Sub bajaRepuesto()

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "DELETE FROM repuestos WHERE cod_repuesto = " & Me.txbCodigoRepuesto.Text
        cmd.CommandText = sql

        If Me.txbCodigoRepuesto.Text <> "" And IsNumeric(Me.txbCodigoRepuesto.Text) = True Then
            Dim seguridad = MsgBox("Vas a dar de baja | Código: " & Me.txbCodigoRepuesto.Text & " Descripción: " & Me.txbDescripcionRepuesto.Text & " Importe: " & Me.txbImporteRepuesto.Text, vbOKCancel, "Seguridad")

            If seguridad = vbOKCancel Then
                Try
                    cmd.ExecuteNonQuery()
                    Console.Beep()
                    llenarRepuestos()
                    limpiarTextBox()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If

        Else
            MsgBox("El código no puede estar vacio.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub dgvRepuestos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvRepuestos.KeyDown
        If wrfm = 1 Then
            If e.KeyCode = Keys.Enter Then
                Dim frm As frmIngresosRepuestos = CType(Owner, frmIngresosRepuestos)
                frm.txbIDCodigoRepuesto.Text = Me.dgvRepuestos.CurrentRow.Cells(0).Value.ToString
                wrfm = 0
                Me.Close()
            End If
        End If
    End Sub
End Class