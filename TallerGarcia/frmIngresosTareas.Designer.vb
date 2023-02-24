<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresosTareas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvIngresosTareas = New System.Windows.Forms.DataGridView()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txbIDIngreso = New System.Windows.Forms.TextBox()
        Me.txbIDCodigoTarea = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbImporte = New System.Windows.Forms.TextBox()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        CType(Me.dgvIngresosTareas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvIngresosTareas
        '
        Me.dgvIngresosTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngresosTareas.Location = New System.Drawing.Point(13, 13)
        Me.dgvIngresosTareas.Name = "dgvIngresosTareas"
        Me.dgvIngresosTareas.Size = New System.Drawing.Size(350, 236)
        Me.dgvIngresosTareas.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Location = New System.Drawing.Point(369, 209)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(240, 40)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txbIDIngreso
        '
        Me.txbIDIngreso.BackColor = System.Drawing.SystemColors.Highlight
        Me.txbIDIngreso.Enabled = False
        Me.txbIDIngreso.Location = New System.Drawing.Point(369, 90)
        Me.txbIDIngreso.Name = "txbIDIngreso"
        Me.txbIDIngreso.ReadOnly = True
        Me.txbIDIngreso.Size = New System.Drawing.Size(240, 20)
        Me.txbIDIngreso.TabIndex = 2
        '
        'txbIDCodigoTarea
        '
        Me.txbIDCodigoTarea.BackColor = System.Drawing.SystemColors.Highlight
        Me.txbIDCodigoTarea.Enabled = False
        Me.txbIDCodigoTarea.Location = New System.Drawing.Point(369, 137)
        Me.txbIDCodigoTarea.Name = "txbIDCodigoTarea"
        Me.txbIDCodigoTarea.ReadOnly = True
        Me.txbIDCodigoTarea.Size = New System.Drawing.Size(240, 20)
        Me.txbIDCodigoTarea.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(369, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID Ingreso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(369, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Código Tarea"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(369, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Importe"
        '
        'txbImporte
        '
        Me.txbImporte.Enabled = False
        Me.txbImporte.Location = New System.Drawing.Point(369, 183)
        Me.txbImporte.Name = "txbImporte"
        Me.txbImporte.Size = New System.Drawing.Size(240, 20)
        Me.txbImporte.TabIndex = 8
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(372, 12)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(75, 32)
        Me.btnAlta.TabIndex = 9
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(453, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 32)
        Me.btnModificar.TabIndex = 10
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(534, 13)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(75, 31)
        Me.btnBaja.TabIndex = 11
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'frmIngresosTareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 261)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.txbImporte)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbIDCodigoTarea)
        Me.Controls.Add(Me.txbIDIngreso)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvIngresosTareas)
        Me.Name = "frmIngresosTareas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresos Tareas"
        CType(Me.dgvIngresosTareas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvIngresosTareas As DataGridView
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txbIDIngreso As TextBox
    Friend WithEvents txbIDCodigoTarea As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txbImporte As TextBox
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBaja As Button
End Class
