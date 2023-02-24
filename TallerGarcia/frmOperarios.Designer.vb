<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperarios
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
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txbEspecialidad = New System.Windows.Forms.TextBox()
        Me.txbImporte = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbId = New System.Windows.Forms.TextBox()
        Me.dgvOperarios = New System.Windows.Forms.DataGridView()
        CType(Me.dgvOperarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(450, 304)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(122, 23)
        Me.btnBaja.TabIndex = 29
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(450, 275)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(122, 23)
        Me.btnModificar.TabIndex = 28
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(450, 246)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(122, 23)
        Me.btnAlta.TabIndex = 27
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Location = New System.Drawing.Point(309, 289)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 41)
        Me.btnAceptar.TabIndex = 26
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(306, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Especialidad"
        '
        'txbEspecialidad
        '
        Me.txbEspecialidad.BackColor = System.Drawing.SystemColors.Highlight
        Me.txbEspecialidad.Enabled = False
        Me.txbEspecialidad.Location = New System.Drawing.Point(309, 254)
        Me.txbEspecialidad.Name = "txbEspecialidad"
        Me.txbEspecialidad.Size = New System.Drawing.Size(100, 20)
        Me.txbEspecialidad.TabIndex = 24
        '
        'txbImporte
        '
        Me.txbImporte.Enabled = False
        Me.txbImporte.Location = New System.Drawing.Point(163, 254)
        Me.txbImporte.Name = "txbImporte"
        Me.txbImporte.Size = New System.Drawing.Size(100, 20)
        Me.txbImporte.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Importe por hora"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nombre"
        '
        'txbNombre
        '
        Me.txbNombre.Enabled = False
        Me.txbNombre.Location = New System.Drawing.Point(12, 309)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(100, 20)
        Me.txbNombre.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "ID"
        '
        'txbId
        '
        Me.txbId.Enabled = False
        Me.txbId.Location = New System.Drawing.Point(13, 254)
        Me.txbId.Name = "txbId"
        Me.txbId.Size = New System.Drawing.Size(100, 20)
        Me.txbId.TabIndex = 16
        '
        'dgvOperarios
        '
        Me.dgvOperarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOperarios.Location = New System.Drawing.Point(13, 11)
        Me.dgvOperarios.Name = "dgvOperarios"
        Me.dgvOperarios.Size = New System.Drawing.Size(559, 212)
        Me.dgvOperarios.TabIndex = 15
        '
        'frmOperarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 341)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txbEspecialidad)
        Me.Controls.Add(Me.txbImporte)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbId)
        Me.Controls.Add(Me.dgvOperarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmOperarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operarios"
        CType(Me.dgvOperarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBaja As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txbEspecialidad As TextBox
    Friend WithEvents txbImporte As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txbNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txbId As TextBox
    Friend WithEvents dgvOperarios As DataGridView
End Class
