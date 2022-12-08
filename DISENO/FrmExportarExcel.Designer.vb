<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExportarExcel
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
        Me.btnexportarexcel = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnexportar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnexportarexcel
        '
        Me.btnexportarexcel.Location = New System.Drawing.Point(218, 151)
        Me.btnexportarexcel.Name = "btnexportarexcel"
        Me.btnexportarexcel.Size = New System.Drawing.Size(379, 152)
        Me.btnexportarexcel.TabIndex = 0
        Me.btnexportarexcel.Text = "Exporta a Excel "
        Me.btnexportarexcel.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox1.Location = New System.Drawing.Point(303, 79)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(209, 30)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Exportar con consulta"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox2.Location = New System.Drawing.Point(214, 345)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(387, 30)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "Exportar con procedimiento de almacenado"
        '
        'btnexportar
        '
        Me.btnexportar.Location = New System.Drawing.Point(219, 417)
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(376, 155)
        Me.btnexportar.TabIndex = 3
        Me.btnexportar.Text = "Exportar a Excel"
        Me.btnexportar.UseVisualStyleBackColor = True
        '
        'FrmExportarExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 650)
        Me.Controls.Add(Me.btnexportar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnexportarexcel)
        Me.Name = "FrmExportarExcel"
        Me.Text = "FrmExportarExcel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnexportarexcel As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnexportar As Button
End Class
