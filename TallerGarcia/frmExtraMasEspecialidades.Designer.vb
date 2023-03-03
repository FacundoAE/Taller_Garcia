<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExtraMasEspecialidades
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.taller_garciaDataSet2 = New TallerGarcia.taller_garciaDataSet2()
        Me.extraespecialidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.extraespecialidadesTableAdapter = New TallerGarcia.taller_garciaDataSet2TableAdapters.extraespecialidadesTableAdapter()
        CType(Me.taller_garciaDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.extraespecialidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Más especialidades en el taller por operarios"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet2"
        ReportDataSource1.Value = Me.extraespecialidadesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TallerGarcia.infExtraEspecialidades.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(16, 38)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(556, 161)
        Me.ReportViewer1.TabIndex = 1
        '
        'taller_garciaDataSet2
        '
        Me.taller_garciaDataSet2.DataSetName = "taller_garciaDataSet2"
        Me.taller_garciaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'extraespecialidadesBindingSource
        '
        Me.extraespecialidadesBindingSource.DataMember = "extraespecialidades"
        Me.extraespecialidadesBindingSource.DataSource = Me.taller_garciaDataSet2
        '
        'extraespecialidadesTableAdapter
        '
        Me.extraespecialidadesTableAdapter.ClearBeforeFill = True
        '
        'frmExtraMasEspecialidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 211)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmExtraMasEspecialidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Más Especialidades"
        CType(Me.taller_garciaDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.extraespecialidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents extraespecialidadesBindingSource As BindingSource
    Friend WithEvents taller_garciaDataSet2 As taller_garciaDataSet2
    Friend WithEvents extraespecialidadesTableAdapter As taller_garciaDataSet2TableAdapters.extraespecialidadesTableAdapter
End Class
