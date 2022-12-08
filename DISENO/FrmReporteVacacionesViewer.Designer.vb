<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteVacacionesViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SP_ReporteVacacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsReporteVacaciones = New DISENO.DsReporteVacaciones()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SP_ReporteVacacionesTableAdapter = New DISENO.DsReporteVacacionesTableAdapters.SP_ReporteVacacionesTableAdapter()
        CType(Me.SP_ReporteVacacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsReporteVacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SP_ReporteVacacionesBindingSource
        '
        Me.SP_ReporteVacacionesBindingSource.DataMember = "SP_ReporteVacaciones"
        Me.SP_ReporteVacacionesBindingSource.DataSource = Me.DsReporteVacaciones
        '
        'DsReporteVacaciones
        '
        Me.DsReporteVacaciones.DataSetName = "DsReporteVacaciones"
        Me.DsReporteVacaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DsVacaciones"
        ReportDataSource1.Value = Me.SP_ReporteVacacionesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DISENO.RptVacaciones.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(634, 356)
        Me.ReportViewer1.TabIndex = 0
        '
        'SP_ReporteVacacionesTableAdapter
        '
        Me.SP_ReporteVacacionesTableAdapter.ClearBeforeFill = True
        '
        'FrmReporteVacacionesViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 356)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporteVacacionesViewer"
        Me.Text = "Reporte de Vacaciones.:."
        CType(Me.SP_ReporteVacacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsReporteVacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_ReporteVacacionesBindingSource As BindingSource
    Friend WithEvents DsReporteVacaciones As DsReporteVacaciones
    Friend WithEvents SP_ReporteVacacionesTableAdapter As DsReporteVacacionesTableAdapters.SP_ReporteVacacionesTableAdapter
End Class
