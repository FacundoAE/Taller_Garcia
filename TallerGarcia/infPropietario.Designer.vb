<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class infPropietario
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
        Me.propietarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.propietarioTableAdapter = New TallerGarcia.taller_garciaDataSetTableAdapters.propietarioTableAdapter()
        CType(Me.taller_garciaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.propietarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.propietarioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TallerGarcia.InformePropietario.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(378, 316)
        Me.ReportViewer1.TabIndex = 0
        '
        'taller_garciaDataSet
        '
        Me.taller_garciaDataSet.DataSetName = "taller_garciaDataSet"
        Me.taller_garciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'propietarioBindingSource
        '
        Me.propietarioBindingSource.DataMember = "propietario"
        Me.propietarioBindingSource.DataSource = Me.taller_garciaDataSet
        '
        'propietarioTableAdapter
        '
        Me.propietarioTableAdapter.ClearBeforeFill = True
        '
        'infPropietario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 316)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "infPropietario"
        Me.Text = "Informe Propietario"
        CType(Me.taller_garciaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.propietarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents propietarioBindingSource As BindingSource
    Friend WithEvents taller_garciaDataSet As taller_garciaDataSet
    Friend WithEvents propietarioTableAdapter As taller_garciaDataSetTableAdapters.propietarioTableAdapter
End Class
