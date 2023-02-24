<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTareas
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
        Me.txbHoras = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbCodigoTarea = New System.Windows.Forms.TextBox()
        Me.dgvTareas = New System.Windows.Forms.DataGridView()
        CType(Me.dgvTareas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'txbHoras
        '
        Me.txbHoras.Enabled = False
        Me.txbHoras.Location = New System.Drawing.Point(163, 254)
        Me.txbHoras.Name = "txbHoras"
        Me.txbHoras.Size = New System.Drawing.Size(100, 20)
        Me.txbHoras.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Horas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Descripción"
        '
        'txbDescripcion
        '
        Me.txbDescripcion.Enabled = False
        Me.txbDescripcion.Location = New System.Drawing.Point(15, 308)
        Me.txbDescripcion.Name = "txbDescripcion"
        Me.txbDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.txbDescripcion.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Código Tarea"
        '
        'txbCodigoTarea
        '
        Me.txbCodigoTarea.Enabled = False
        Me.txbCodigoTarea.Location = New System.Drawing.Point(13, 254)
        Me.txbCodigoTarea.Name = "txbCodigoTarea"
        Me.txbCodigoTarea.Size = New System.Drawing.Size(100, 20)
        Me.txbCodigoTarea.TabIndex = 16
        '
        'dgvTareas
        '
        Me.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTareas.Location = New System.Drawing.Point(13, 11)
        Me.dgvTareas.Name = "dgvTareas"
        Me.dgvTareas.Size = New System.Drawing.Size(559, 212)
        Me.dgvTareas.TabIndex = 15
        '
        'frmTareas
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
        Me.Controls.Add(Me.txbHoras)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbDescripcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbCodigoTarea)
        Me.Controls.Add(Me.dgvTareas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmTareas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tareas"
        CType(Me.dgvTareas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBaja As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txbEspecialidad As TextBox
    Friend WithEvents txbHoras As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txbDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txbCodigoTarea As TextBox
    Friend WithEvents dgvTareas As DataGridView
End Class
