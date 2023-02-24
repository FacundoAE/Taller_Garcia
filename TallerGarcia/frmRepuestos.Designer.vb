<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepuestos
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
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txbImporteRepuesto = New System.Windows.Forms.TextBox()
        Me.txbDescripcionRepuesto = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.dgvRepuestos = New System.Windows.Forms.DataGridView()
        Me.txbCodigoRepuesto = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        CType(Me.dgvRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Location = New System.Drawing.Point(489, 167)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(42, 13)
        Me.lblImporte.TabIndex = 17
        Me.lblImporte.Text = "Importe"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(489, 121)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 16
        Me.lblDescripcion.Text = "Descripción"
        '
        'txbImporteRepuesto
        '
        Me.txbImporteRepuesto.Location = New System.Drawing.Point(489, 186)
        Me.txbImporteRepuesto.Name = "txbImporteRepuesto"
        Me.txbImporteRepuesto.Size = New System.Drawing.Size(117, 20)
        Me.txbImporteRepuesto.TabIndex = 15
        '
        'txbDescripcionRepuesto
        '
        Me.txbDescripcionRepuesto.Location = New System.Drawing.Point(489, 137)
        Me.txbDescripcionRepuesto.Name = "txbDescripcionRepuesto"
        Me.txbDescripcionRepuesto.Size = New System.Drawing.Size(117, 20)
        Me.txbDescripcionRepuesto.TabIndex = 14
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(201, 276)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(387, 276)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(75, 23)
        Me.btnBaja.TabIndex = 12
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(12, 276)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(75, 23)
        Me.btnAlta.TabIndex = 11
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(489, 231)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 23)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'dgvRepuestos
        '
        Me.dgvRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRepuestos.Location = New System.Drawing.Point(12, 12)
        Me.dgvRepuestos.Name = "dgvRepuestos"
        Me.dgvRepuestos.Size = New System.Drawing.Size(450, 242)
        Me.dgvRepuestos.TabIndex = 9
        '
        'txbCodigoRepuesto
        '
        Me.txbCodigoRepuesto.Location = New System.Drawing.Point(489, 95)
        Me.txbCodigoRepuesto.Name = "txbCodigoRepuesto"
        Me.txbCodigoRepuesto.Size = New System.Drawing.Size(117, 20)
        Me.txbCodigoRepuesto.TabIndex = 18
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(489, 78)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 19
        Me.lblCodigo.Text = "Código"
        '
        'frmRepuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 311)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txbCodigoRepuesto)
        Me.Controls.Add(Me.lblImporte)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txbImporteRepuesto)
        Me.Controls.Add(Me.txbDescripcionRepuesto)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvRepuestos)
        Me.Name = "frmRepuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Repuestos"
        CType(Me.dgvRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblImporte As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txbImporteRepuesto As TextBox
    Friend WithEvents txbDescripcionRepuesto As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBaja As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents dgvRepuestos As DataGridView
    Friend WithEvents txbCodigoRepuesto As TextBox
    Friend WithEvents lblCodigo As Label
End Class
