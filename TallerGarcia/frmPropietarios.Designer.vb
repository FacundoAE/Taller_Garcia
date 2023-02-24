<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPropietarios
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
        Me.lblTelefonoPropietario = New System.Windows.Forms.Label()
        Me.lblNombrePropietario = New System.Windows.Forms.Label()
        Me.txbTelefonoPropietario = New System.Windows.Forms.TextBox()
        Me.txbNombrePropietario = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.dgvPropietarios = New System.Windows.Forms.DataGridView()
        Me.txbIdPropietario = New System.Windows.Forms.TextBox()
        Me.lblIDPropietario = New System.Windows.Forms.Label()
        CType(Me.dgvPropietarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTelefonoPropietario
        '
        Me.lblTelefonoPropietario.AutoSize = True
        Me.lblTelefonoPropietario.Location = New System.Drawing.Point(497, 167)
        Me.lblTelefonoPropietario.Name = "lblTelefonoPropietario"
        Me.lblTelefonoPropietario.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefonoPropietario.TabIndex = 17
        Me.lblTelefonoPropietario.Text = "Telefono"
        '
        'lblNombrePropietario
        '
        Me.lblNombrePropietario.AutoSize = True
        Me.lblNombrePropietario.Location = New System.Drawing.Point(497, 121)
        Me.lblNombrePropietario.Name = "lblNombrePropietario"
        Me.lblNombrePropietario.Size = New System.Drawing.Size(44, 13)
        Me.lblNombrePropietario.TabIndex = 16
        Me.lblNombrePropietario.Text = "Nombre"
        '
        'txbTelefonoPropietario
        '
        Me.txbTelefonoPropietario.Location = New System.Drawing.Point(497, 186)
        Me.txbTelefonoPropietario.Name = "txbTelefonoPropietario"
        Me.txbTelefonoPropietario.Size = New System.Drawing.Size(117, 20)
        Me.txbTelefonoPropietario.TabIndex = 15
        '
        'txbNombrePropietario
        '
        Me.txbNombrePropietario.Location = New System.Drawing.Point(497, 140)
        Me.txbNombrePropietario.Name = "txbNombrePropietario"
        Me.txbNombrePropietario.Size = New System.Drawing.Size(117, 20)
        Me.txbNombrePropietario.TabIndex = 14
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
        Me.btnAceptar.Location = New System.Drawing.Point(497, 231)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 23)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'dgvPropietarios
        '
        Me.dgvPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPropietarios.Location = New System.Drawing.Point(12, 12)
        Me.dgvPropietarios.Name = "dgvPropietarios"
        Me.dgvPropietarios.Size = New System.Drawing.Size(450, 242)
        Me.dgvPropietarios.TabIndex = 9
        '
        'txbIdPropietario
        '
        Me.txbIdPropietario.Location = New System.Drawing.Point(497, 95)
        Me.txbIdPropietario.Name = "txbIdPropietario"
        Me.txbIdPropietario.Size = New System.Drawing.Size(117, 20)
        Me.txbIdPropietario.TabIndex = 18
        '
        'lblIDPropietario
        '
        Me.lblIDPropietario.AutoSize = True
        Me.lblIDPropietario.Location = New System.Drawing.Point(497, 76)
        Me.lblIDPropietario.Name = "lblIDPropietario"
        Me.lblIDPropietario.Size = New System.Drawing.Size(18, 13)
        Me.lblIDPropietario.TabIndex = 19
        Me.lblIDPropietario.Text = "ID"
        '
        'frmPropietarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 311)
        Me.Controls.Add(Me.lblIDPropietario)
        Me.Controls.Add(Me.txbIdPropietario)
        Me.Controls.Add(Me.lblTelefonoPropietario)
        Me.Controls.Add(Me.lblNombrePropietario)
        Me.Controls.Add(Me.txbTelefonoPropietario)
        Me.Controls.Add(Me.txbNombrePropietario)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvPropietarios)
        Me.Name = "frmPropietarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Propietarios"
        CType(Me.dgvPropietarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTelefonoPropietario As Label
    Friend WithEvents lblNombrePropietario As Label
    Friend WithEvents txbTelefonoPropietario As TextBox
    Friend WithEvents txbNombrePropietario As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBaja As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents dgvPropietarios As DataGridView
    Friend WithEvents txbIdPropietario As TextBox
    Friend WithEvents lblIDPropietario As Label
End Class
