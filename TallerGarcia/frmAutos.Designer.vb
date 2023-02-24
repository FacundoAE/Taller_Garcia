<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutos
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
        Me.dgvAutos = New System.Windows.Forms.DataGridView()
        Me.txbNroPatente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbMarca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txbModelo = New System.Windows.Forms.TextBox()
        Me.txbColor = New System.Windows.Forms.TextBox()
        Me.txbPropietario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        CType(Me.dgvAutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAutos
        '
        Me.dgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAutos.Location = New System.Drawing.Point(13, 13)
        Me.dgvAutos.Name = "dgvAutos"
        Me.dgvAutos.Size = New System.Drawing.Size(559, 212)
        Me.dgvAutos.TabIndex = 0
        '
        'txbNroPatente
        '
        Me.txbNroPatente.Enabled = False
        Me.txbNroPatente.Location = New System.Drawing.Point(13, 256)
        Me.txbNroPatente.Name = "txbNroPatente"
        Me.txbNroPatente.Size = New System.Drawing.Size(100, 20)
        Me.txbNroPatente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nro Patente"
        '
        'txbMarca
        '
        Me.txbMarca.Enabled = False
        Me.txbMarca.Location = New System.Drawing.Point(15, 310)
        Me.txbMarca.Name = "txbMarca"
        Me.txbMarca.Size = New System.Drawing.Size(100, 20)
        Me.txbMarca.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Marca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Modelo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Color"
        '
        'txbModelo
        '
        Me.txbModelo.Enabled = False
        Me.txbModelo.Location = New System.Drawing.Point(163, 256)
        Me.txbModelo.Name = "txbModelo"
        Me.txbModelo.Size = New System.Drawing.Size(100, 20)
        Me.txbModelo.TabIndex = 7
        '
        'txbColor
        '
        Me.txbColor.Enabled = False
        Me.txbColor.Location = New System.Drawing.Point(163, 309)
        Me.txbColor.Name = "txbColor"
        Me.txbColor.Size = New System.Drawing.Size(100, 20)
        Me.txbColor.TabIndex = 8
        '
        'txbPropietario
        '
        Me.txbPropietario.BackColor = System.Drawing.SystemColors.Highlight
        Me.txbPropietario.Enabled = False
        Me.txbPropietario.Location = New System.Drawing.Point(309, 256)
        Me.txbPropietario.Name = "txbPropietario"
        Me.txbPropietario.Size = New System.Drawing.Size(100, 20)
        Me.txbPropietario.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(306, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Propietario"
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Location = New System.Drawing.Point(309, 291)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 41)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(450, 248)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(122, 23)
        Me.btnAlta.TabIndex = 12
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(450, 277)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(122, 23)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(450, 306)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(122, 23)
        Me.btnBaja.TabIndex = 14
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'frmAutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 341)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txbPropietario)
        Me.Controls.Add(Me.txbColor)
        Me.Controls.Add(Me.txbModelo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbMarca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbNroPatente)
        Me.Controls.Add(Me.dgvAutos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autos"
        CType(Me.dgvAutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAutos As DataGridView
    Friend WithEvents txbNroPatente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txbMarca As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txbModelo As TextBox
    Friend WithEvents txbColor As TextBox
    Friend WithEvents txbPropietario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBaja As Button
End Class
