<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIngresos
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
        Me.dgvIngresos = New System.Windows.Forms.DataGridView()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txbPatente = New System.Windows.Forms.TextBox()
        Me.lblPatente = New System.Windows.Forms.Label()
        Me.txbDia = New System.Windows.Forms.TextBox()
        Me.txbHora = New System.Windows.Forms.TextBox()
        Me.lblDia = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblMinutos = New System.Windows.Forms.Label()
        Me.txbMinutos = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txbID = New System.Windows.Forms.TextBox()
        Me.txbMes = New System.Windows.Forms.TextBox()
        Me.txbAnio = New System.Windows.Forms.TextBox()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.lblAnio = New System.Windows.Forms.Label()
        CType(Me.dgvIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvIngresos
        '
        Me.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngresos.Location = New System.Drawing.Point(13, 13)
        Me.dgvIngresos.Name = "dgvIngresos"
        Me.dgvIngresos.Size = New System.Drawing.Size(709, 212)
        Me.dgvIngresos.TabIndex = 0
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(597, 306)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(122, 23)
        Me.btnBaja.TabIndex = 32
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(597, 277)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(122, 23)
        Me.btnModificar.TabIndex = 31
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(597, 248)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(122, 23)
        Me.btnAlta.TabIndex = 30
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Location = New System.Drawing.Point(456, 288)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 41)
        Me.btnAceptar.TabIndex = 33
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txbPatente
        '
        Me.txbPatente.BackColor = System.Drawing.SystemColors.Highlight
        Me.txbPatente.Enabled = False
        Me.txbPatente.Location = New System.Drawing.Point(456, 262)
        Me.txbPatente.Name = "txbPatente"
        Me.txbPatente.ReadOnly = True
        Me.txbPatente.Size = New System.Drawing.Size(100, 20)
        Me.txbPatente.TabIndex = 34
        '
        'lblPatente
        '
        Me.lblPatente.AutoSize = True
        Me.lblPatente.Location = New System.Drawing.Point(456, 243)
        Me.lblPatente.Name = "lblPatente"
        Me.lblPatente.Size = New System.Drawing.Size(44, 13)
        Me.lblPatente.TabIndex = 35
        Me.lblPatente.Text = "Patente"
        '
        'txbDia
        '
        Me.txbDia.Enabled = False
        Me.txbDia.Location = New System.Drawing.Point(13, 308)
        Me.txbDia.Name = "txbDia"
        Me.txbDia.Size = New System.Drawing.Size(57, 20)
        Me.txbDia.TabIndex = 38
        '
        'txbHora
        '
        Me.txbHora.Enabled = False
        Me.txbHora.Location = New System.Drawing.Point(303, 309)
        Me.txbHora.Name = "txbHora"
        Me.txbHora.Size = New System.Drawing.Size(50, 20)
        Me.txbHora.TabIndex = 39
        '
        'lblDia
        '
        Me.lblDia.AutoSize = True
        Me.lblDia.Location = New System.Drawing.Point(10, 289)
        Me.lblDia.Name = "lblDia"
        Me.lblDia.Size = New System.Drawing.Size(25, 13)
        Me.lblDia.TabIndex = 40
        Me.lblDia.Text = "Día"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(303, 289)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(30, 13)
        Me.lblHora.TabIndex = 41
        Me.lblHora.Text = "Hora"
        '
        'lblMinutos
        '
        Me.lblMinutos.AutoSize = True
        Me.lblMinutos.Location = New System.Drawing.Point(356, 289)
        Me.lblMinutos.Name = "lblMinutos"
        Me.lblMinutos.Size = New System.Drawing.Size(44, 13)
        Me.lblMinutos.TabIndex = 42
        Me.lblMinutos.Text = "Minutos"
        '
        'txbMinutos
        '
        Me.txbMinutos.Enabled = False
        Me.txbMinutos.Location = New System.Drawing.Point(359, 309)
        Me.txbMinutos.Name = "txbMinutos"
        Me.txbMinutos.Size = New System.Drawing.Size(50, 20)
        Me.txbMinutos.TabIndex = 43
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(12, 235)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(18, 13)
        Me.lblId.TabIndex = 36
        Me.lblId.Text = "ID"
        '
        'txbID
        '
        Me.txbID.Enabled = False
        Me.txbID.Location = New System.Drawing.Point(13, 251)
        Me.txbID.Name = "txbID"
        Me.txbID.Size = New System.Drawing.Size(100, 20)
        Me.txbID.TabIndex = 37
        '
        'txbMes
        '
        Me.txbMes.Enabled = False
        Me.txbMes.Location = New System.Drawing.Point(89, 309)
        Me.txbMes.Name = "txbMes"
        Me.txbMes.Size = New System.Drawing.Size(57, 20)
        Me.txbMes.TabIndex = 44
        '
        'txbAnio
        '
        Me.txbAnio.Enabled = False
        Me.txbAnio.Location = New System.Drawing.Point(163, 309)
        Me.txbAnio.Name = "txbAnio"
        Me.txbAnio.Size = New System.Drawing.Size(57, 20)
        Me.txbAnio.TabIndex = 45
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(86, 289)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(27, 13)
        Me.lblMes.TabIndex = 46
        Me.lblMes.Text = "Mes"
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Location = New System.Drawing.Point(160, 289)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(26, 13)
        Me.lblAnio.TabIndex = 47
        Me.lblAnio.Text = "Año"
        '
        'frmIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 341)
        Me.Controls.Add(Me.lblAnio)
        Me.Controls.Add(Me.lblMes)
        Me.Controls.Add(Me.txbAnio)
        Me.Controls.Add(Me.txbMes)
        Me.Controls.Add(Me.txbMinutos)
        Me.Controls.Add(Me.lblMinutos)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblDia)
        Me.Controls.Add(Me.txbHora)
        Me.Controls.Add(Me.txbDia)
        Me.Controls.Add(Me.txbID)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblPatente)
        Me.Controls.Add(Me.txbPatente)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.dgvIngresos)
        Me.Name = "frmIngresos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresos"
        CType(Me.dgvIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvIngresos As DataGridView
    Friend WithEvents btnBaja As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txbPatente As TextBox
    Friend WithEvents lblPatente As Label
    Friend WithEvents txbDia As TextBox
    Friend WithEvents txbHora As TextBox
    Friend WithEvents lblDia As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents lblMinutos As Label
    Friend WithEvents txbMinutos As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents txbID As TextBox
    Friend WithEvents txbMes As TextBox
    Friend WithEvents txbAnio As TextBox
    Friend WithEvents lblMes As Label
    Friend WithEvents lblAnio As Label
End Class
