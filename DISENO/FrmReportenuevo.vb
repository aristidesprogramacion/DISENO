
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class FrmReportenuevo
    Private Sub FrmReportenuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim datasetvacaciones As New DataTable
        Using con As New SqlConnection(My.Settings.DisenoSistemas)
            con.Open()
            Dim _sqlcommand As New SqlCommand("SP_ReporteNuevo", con)
            _sqlcommand.CommandType = CommandType.StoredProcedure
            _sqlcommand.Parameters.AddWithValue("@bandera", 1)
            _sqlcommand.Parameters.AddWithValue("@numempleado", 241180)
            _sqlcommand.Parameters.AddWithValue("@FechaI", "2022 - 2 - 7")
            _sqlcommand.Parameters.AddWithValue("@FechaFin", "2022 - 2 - 28")
            _sqlcommand.CommandTimeout = 0
            Dim ta As New SqlDataAdapter(_sqlcommand)
            ta.Fill(datasetvacaciones)
        End Using

        Dim datasetventas As New DataTable
        Using con2 As New SqlConnection(My.Settings.DisenoSistemas)
            con2.Open()
            Dim _sqlcommand2 As New SqlCommand("SP_Reporteventas", con2)
            _sqlcommand2.CommandType = CommandType.StoredProcedure
            _sqlcommand2.Parameters.AddWithValue("@bandera", 2)
            _sqlcommand2.Parameters.AddWithValue("@numfactura", 1)
            _sqlcommand2.CommandTimeout = 0
            Dim ta2 As New SqlDataAdapter(_sqlcommand2)
            ta2.Fill(datasetventas)
        End Using

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportEmbeddedResource = "DISENO.RptReporteNuevo.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", datasetvacaciones))
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", datasetventas))
        End With

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class