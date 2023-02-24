<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIngresosRepuestos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.txbImporteRepuesto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbIDCodigoRepuesto = New System.Windows.Forms.TextBox()
        Me.txbIDIngreso = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.dgvIngresosRepuestos = New System.Windows.Forms.DataGridView()
        Me.txbCantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvIngresosRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(532, 330)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(75, 31)
        Me.btnBaja.TabIndex = 22
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(532, 292)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 32)
        Me.btnModificar.TabIndex = 21
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(532, 254)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(75, 32)
        Me.btnAlta.TabIndex = 20
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'txbImporteRepuesto
        '
        Me.txbImporteRepuesto.Enabled = False
        Me.txbImporteRepuesto.Location = New System.Drawing.Point(12, 346)
        Me.txbImporteRepuesto.Name = "txbImporteRepuesto"
        Me.txbImporteRepuesto.Size = New System.Drawing.Size(147, 20)
        Me.txbImporteRepuesto.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Importe Repuesto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Código Repuesto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ID Ingreso"
        '
        'txbIDCodigoRepuesto
        '
        Me.txbIDCodigoRepuesto.BackColor = System.Drawing.SystemColors.Highlight
        Me.txbIDCodigoRepuesto.Enabled = False
        Me.txbIDCodigoRepuesto.Location = New System.Drawing.Point(166, 290)
        Me.txbIDCodigoRepuesto.Name = "txbIDCodigoRepuesto"
        Me.txbIDCodigoRepuesto.ReadOnly = True
        Me.txbIDCodigoRepuesto.Size = New System.Drawing.Size(147, 20)
        Me.txbIDCodigoRepuesto.TabIndex = 15
        '
        'txbIDIngreso
        '
        Me.txbIDIngreso.BackColor = System.Drawing.SystemColors.Highlight
        Me.txbIDIngreso.Enabled = False
        Me.txbIDIngreso.Location = New System.Drawing.Point(12, 290)
        Me.txbIDIngreso.Name = "txbIDIngreso"
        Me.txbIDIngreso.ReadOnly = True
        Me.txbIDIngreso.Size = New System.Drawing.Size(147, 20)
        Me.txbIDIngreso.TabIndex = 14
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Location = New System.Drawing.Point(12, 409)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(147, 40)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'dgvIngresosRepuestos
        '
        Me.dgvIngresosRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngresosRepuestos.Location = New System.Drawing.Point(12, 12)
        Me.dgvIngresosRepuestos.Name = "dgvIngresosRepuestos"
        Me.dgvIngresosRepuestos.Size = New System.Drawing.Size(595, 236)
        Me.dgvIngresosRepuestos.TabIndex = 12
        '
        'txbCantidad
        '
        Me.txbCantidad.Enabled = False
        Me.txbCantidad.Location = New System.Drawing.Point(166, 346)
        Me.txbCantidad.Name = "txbCantidad"
        Me.txbCantidad.Size = New System.Drawing.Size(144, 20)
        Me.txbCantidad.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Cantidad"
        '
        'frmIngresosRepuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 461)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txbCantidad)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.txbImporteRepuesto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbIDCodigoRepuesto)
        Me.Controls.Add(Me.txbIDIngreso)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvIngresosRepuestos)
        Me.Name = "frmIngresosRepuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresos Repuestos"
        CType(Me.dgvIngresosRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBaja As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents txbImporteRepuesto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txbIDCodigoRepuesto As TextBox
    Friend WithEvents txbIDIngreso As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents dgvIngresosRepuestos As DataGridView
    Friend WithEvents txbCantidad As TextBox
    Friend WithEvents Label4 As Label
End Class
