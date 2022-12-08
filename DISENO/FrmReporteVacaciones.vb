Public Class FrmReporteVacaciones
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click

        Dim cnx As New SqlClient.SqlConnection(My.Settings.DisenoSistemas)
        cnx.Open()
        Dim reader As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("SELECT * FROM Empleado
                                                    Where numempleado  = '" & txtnumempleado.Text & "'", cnx)
        reader = cmd.ExecuteReader

        If reader.Read Then

            txtnombrecompleto.Text = reader.Item("Nombre") & " " & reader.Item("Apellido")
            txtdepartamento.Text = reader.Item("Departamento")
            txtpuesto.Text = reader.Item("Puesto")
            txtturno.Text = reader.Item("Turno")

        End If

        cnx.Close()
    End Sub

    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click

        My.Forms.FrmReporteVacacionesViewer.vnumempleado = txtnumempleado.Text
        My.Forms.FrmReporteVacacionesViewer.vFechaI = dtpfechainicial.Text
        My.Forms.FrmReporteVacacionesViewer.vFechaFin = dtpfechafin.Text
        My.Forms.FrmReporteVacacionesViewer.vnombrecompleto = txtnombrecompleto.Text
        My.Forms.FrmReporteVacacionesViewer.vdepartamento = txtdepartamento.Text
        My.Forms.FrmReporteVacacionesViewer.vpuesto = txtpuesto.Text
        My.Forms.FrmReporteVacacionesViewer.vturno = txtturno.Text

        FrmReporteVacacionesViewer.ShowDialog()

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Application.Exit()
    End Sub

    Private Sub btnreporteprogramado_Click(sender As Object, e As EventArgs) Handles btnreporteprogramado.Click
        FrmReportenuevo.ShowDialog()
    End Sub

    Private Sub btnexcel_Click(sender As Object, e As EventArgs) Handles btnexcel.Click
        FrmExportarExcel.ShowDialog()
    End Sub
End Class