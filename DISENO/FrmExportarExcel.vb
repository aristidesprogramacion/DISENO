
Imports System.Data.SqlClient
Public Class FrmExportarExcel
    Private Sub FrmExportarExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub exportexcel() 'Archivo contiene todas las irregulares digitadas en el rango de fecha sin importar si el lote esta abierto o cerrado.
        'Export to Excel process

        Dim cn As New SqlConnection(My.Settings.DisenoSistemas)
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        Dim cmd As New SqlCommand

        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Productos"
        'cmd.Parameters.AddWithValue("@estilo", style)
        'cmd.Parameters.AddWithValue("@year", Year)
        'cmd.Parameters.AddWithValue("@sewplant", sewplant)
        'cmd.Parameters.AddWithValue("@cutplant", cutplant)

        cmd.CommandTimeout = 3500
        cmd.ExecuteNonQuery()
        Da.SelectCommand = cmd
        Da.Fill(Ds)
        cn.Close()

        'Export to Excel process
        Dim Excel As Object = CreateObject("Excel.Application")
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = Excel.Workbooks.Add(System.Reflection.Missing.Value)
        With Excel
            .SheetsInNewWorkbook = 1
            .Workbooks.Add()
            .Worksheets(1).Select()

            Dim i As Integer = 1
            For col = 0 To Ds.Tables(0).Columns.Count - 1
                .Cells(1, i).value = Ds.Tables(0).Columns(col).ColumnName
                .Cells(1, i).EntireRow.Font.Bold = True
                i += 1
            Next
            i = 2
            Dim j As Integer = 1
            For col = 0 To Ds.Tables(0).Columns.Count - 1
                i = 2
                For row = 0 To Ds.Tables(0).Rows.Count - 1
                    .Cells(i, j).Value = Ds.Tables(0).Rows(row).ItemArray(col)
                    i += 1
                Next
                j += 1
            Next
            .Application.DisplayAlerts = False


            Dim saveDialog As New SaveFileDialog()
            saveDialog.FileName = "" ' Default file name
            saveDialog.DefaultExt = ".xls" ' Default file extension
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"

            If saveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                .ActiveCell.Worksheet.SaveAs(saveDialog.FileName)
                .Workbooks.Close()
            End If

            '.Excel.Quit()
        End With
    End Sub

    Sub exportexcel1() 'Archivo contiene todas las irregulares digitadas en el rango de fecha sin importar si el lote esta abierto o cerrado.
        'Export to Excel process

        Dim cn As New SqlConnection(My.Settings.DisenoSistemas)
        Dim Ds As New DataSet
        Dim Da As New SqlDataAdapter
        Dim cmd As New SqlCommand

        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SP_ReporteVacaciones"
        cmd.Parameters.AddWithValue("@numempleado", "241180")
        cmd.Parameters.AddWithValue("@FechaI", "2021-01-01")
        cmd.Parameters.AddWithValue("@FechaFin", "2022-03-20")
        'cmd.Parameters.AddWithValue("@cutplant", cutplant)

        cmd.CommandTimeout = 3500
        cmd.ExecuteNonQuery()
        Da.SelectCommand = cmd
        Da.Fill(Ds)
        cn.Close()

        'Export to Excel process
        Dim Excel As Object = CreateObject("Excel.Application")
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = Excel.Workbooks.Add(System.Reflection.Missing.Value)
        With Excel
            .SheetsInNewWorkbook = 1
            .Workbooks.Add()
            .Worksheets(1).Select()

            Dim i As Integer = 1
            For col = 0 To Ds.Tables(0).Columns.Count - 1
                .Cells(1, i).value = Ds.Tables(0).Columns(col).ColumnName
                .Cells(1, i).EntireRow.Font.Bold = True
                i += 1
            Next
            i = 2
            Dim j As Integer = 1
            For col = 0 To Ds.Tables(0).Columns.Count - 1
                i = 2
                For row = 0 To Ds.Tables(0).Rows.Count - 1
                    .Cells(i, j).Value = Ds.Tables(0).Rows(row).ItemArray(col)
                    i += 1
                Next
                j += 1
            Next
            .Application.DisplayAlerts = False


            Dim saveDialog As New SaveFileDialog()
            saveDialog.FileName = "" ' Default file name
            saveDialog.DefaultExt = ".xls" ' Default file extension
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"

            If saveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                .ActiveCell.Worksheet.SaveAs(saveDialog.FileName)
                .Workbooks.Close()
            End If

            '.Excel.Quit()
        End With
    End Sub

    Private Sub btnexportarexcel_Click(sender As Object, e As EventArgs) Handles btnexportarexcel.Click
        exportexcel()
    End Sub

    Private Sub btnexportar_Click(sender As Object, e As EventArgs) Handles btnexportar.Click
        exportexcel1()
    End Sub
End Class