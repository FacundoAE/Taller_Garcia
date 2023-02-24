<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txbContrasena = New System.Windows.Forms.TextBox()
        Me.txbUsuario = New System.Windows.Forms.TextBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblcompruebausuario = New System.Windows.Forms.Label()
        Me.lblcompruebacontrasena = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Location = New System.Drawing.Point(13, 300)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(259, 49)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txbContrasena
        '
        Me.txbContrasena.Enabled = False
        Me.txbContrasena.Location = New System.Drawing.Point(13, 260)
        Me.txbContrasena.Name = "txbContrasena"
        Me.txbContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbContrasena.Size = New System.Drawing.Size(259, 20)
        Me.txbContrasena.TabIndex = 1
        '
        'txbUsuario
        '
        Me.txbUsuario.Location = New System.Drawing.Point(12, 209)
        Me.txbUsuario.Name = "txbUsuario"
        Me.txbUsuario.Size = New System.Drawing.Size(259, 20)
        Me.txbUsuario.TabIndex = 2
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Location = New System.Drawing.Point(11, 242)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(61, 13)
        Me.lblContrasena.TabIndex = 3
        Me.lblContrasena.Text = "Contraseña"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(11, 190)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 4
        Me.lblUsuario.Text = "Usuario"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TallerGarcia.My.Resources.Resources.iconoTaller
        Me.PictureBox1.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 164)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lblcompruebausuario
        '
        Me.lblcompruebausuario.AutoSize = True
        Me.lblcompruebausuario.Location = New System.Drawing.Point(357, 71)
        Me.lblcompruebausuario.Name = "lblcompruebausuario"
        Me.lblcompruebausuario.Size = New System.Drawing.Size(10, 13)
        Me.lblcompruebausuario.TabIndex = 6
        Me.lblcompruebausuario.Text = "-"
        '
        'lblcompruebacontrasena
        '
        Me.lblcompruebacontrasena.AutoSize = True
        Me.lblcompruebacontrasena.Location = New System.Drawing.Point(357, 95)
        Me.lblcompruebacontrasena.Name = "lblcompruebacontrasena"
        Me.lblcompruebacontrasena.Size = New System.Drawing.Size(10, 13)
        Me.lblcompruebacontrasena.TabIndex = 7
        Me.lblcompruebacontrasena.Text = "-"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 361)
        Me.Controls.Add(Me.lblcompruebacontrasena)
        Me.Controls.Add(Me.lblcompruebausuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblContrasena)
        Me.Controls.Add(Me.txbUsuario)
        Me.Controls.Add(Me.txbContrasena)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents txbContrasena As TextBox
    Friend WithEvents txbUsuario As TextBox
    Friend WithEvents lblContrasena As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblcompruebausuario As Label
    Friend WithEvents lblcompruebacontrasena As Label
End Class
