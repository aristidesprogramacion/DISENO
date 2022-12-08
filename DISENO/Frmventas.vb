Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Frmventas
    Private Sub Frmventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsReporteVacaciones.SP_ReporteVacaciones' table. You can move, or remove it, as needed.
        'Me.SP_ReporteVacacionesTableAdapter.Fill(Me.DsReporteVacaciones.SP_ReporteVacaciones)

        Dim datasetvaciones As New DataTable
        Using con As New SqlConnection(My.Settings.DisenoSistemas)
            con.Open()

            Dim sqlcommand As New SqlCommand("SP_ReporteVacaciones", con)
            sqlcommand.CommandType = CommandType.StoredProcedure
            sqlcommand.Parameters.AddWithValue("@numempleado", 241180)
            sqlcommand.Parameters.AddWithValue("@FechaI", "2022 - 2 - 7")
            sqlcommand.Parameters.AddWithValue("@FechaFin", "2022 - 2 - 28")
            sqlcommand.CommandTimeout = 0
            Dim ta As New SqlDataAdapter(sqlcommand)
            ta.Fill(datasetvaciones)

        End Using

        Dim datasetventas As New DataTable
        Using con2 As New SqlConnection(My.Settings.DisenoSistemas)
            con2.Open()

            Dim sqlcommand2 As New SqlCommand("SP_Reporteventas", con2)
            sqlcommand2.CommandType = CommandType.StoredProcedure
            sqlcommand2.Parameters.AddWithValue("@bandera", 1)
            sqlcommand2.Parameters.AddWithValue("@numfactura", 1)
            sqlcommand2.CommandTimeout = 0
            Dim ta2 As New SqlDataAdapter(sqlcommand2)
            ta2.Fill(datasetventas)

        End Using



        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportEmbeddedResource = "DisenoSistemas.RptReporteventas.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", datasetvaciones))
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", datasetventas))

        End With
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class