
Imports Microsoft.Reporting.WinForms
Public Class FrmReporteVacacionesViewer

    Public vnumempleado As String = ""
    Public vFechaI As String = ""
    Public vFechaFin As String = ""
    Public vnombrecompleto As String = ""
    Public vdepartamento As String = ""
    Public vpuesto As String = ""
    Public vturno As String = ""



    Private Sub FrmReporteVacacionesViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsReporteVacaciones.SP_ReporteVacaciones' table. You can move, or remove it, as needed.

        Dim pNumEmpleado As New ReportParameter("pNumEmpleado", vnumempleado)
        Dim pNombreCompleto As New ReportParameter("pNombreCompleto", vnombrecompleto)
        Dim pDepartamento As New ReportParameter("pDepartamento", vdepartamento)
        Dim pPuesto As New ReportParameter("pPuesto", vpuesto)
        Dim pTurno As New ReportParameter("pTurno", vturno)


        Me.SP_ReporteVacacionesTableAdapter.Fill(Me.DsReporteVacaciones.SP_ReporteVacaciones, numempleado:=vnumempleado, FechaI:=vFechaI, FechaFin:=vFechaFin)

        'Mandar datos al reporte
        Me.ReportViewer1.LocalReport.GetParameters()
        Me.ReportViewer1.LocalReport.SetParameters(pNumEmpleado)

        Me.ReportViewer1.LocalReport.GetParameters()
        Me.ReportViewer1.LocalReport.SetParameters(pNombreCompleto)

        Me.ReportViewer1.LocalReport.GetParameters()
        Me.ReportViewer1.LocalReport.SetParameters(pDepartamento)

        Me.ReportViewer1.LocalReport.GetParameters()
        Me.ReportViewer1.LocalReport.SetParameters(pPuesto)

        Me.ReportViewer1.LocalReport.GetParameters()
        Me.ReportViewer1.LocalReport.SetParameters(pTurno)

        'Darle formato al ReportViewer
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.PageWidth

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class