<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class infGasto
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.taller_garciaDataSet = New TallerGarcia.taller_garciaDataSet()
        Me.totalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.totalesTableAdapter = New TallerGarcia.taller_garciaDataSetTableAdapters.totalesTableAdapter()
        CType(Me.taller_garciaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.totalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.totalesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TallerGarcia.informeGasto.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(486, 296)
        Me.ReportViewer1.TabIndex = 0
        '
        'taller_garciaDataSet
        '
        Me.taller_garciaDataSet.DataSetName = "taller_garciaDataSet"
        Me.taller_garciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'totalesBindingSource
        '
        Me.totalesBindingSource.DataMember = "totales"
        Me.totalesBindingSource.DataSource = Me.taller_garciaDataSet
        '
        'totalesTableAdapter
        '
        Me.totalesTableAdapter.ClearBeforeFill = True
        '
        'infGasto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 296)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "infGasto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe Gasto"
        CType(Me.taller_garciaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.totalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents totalesBindingSource As BindingSource
    Friend WithEvents taller_garciaDataSet As taller_garciaDataSet
    Friend WithEvents totalesTableAdapter As taller_garciaDataSetTableAdapters.totalesTableAdapter
End Class
