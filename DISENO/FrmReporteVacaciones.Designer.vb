<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteVacaciones
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdepartamento = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtturno = New System.Windows.Forms.TextBox()
        Me.txtpuesto = New System.Windows.Forms.TextBox()
        Me.txtnombrecompleto = New System.Windows.Forms.TextBox()
        Me.txtnumempleado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpfechafin = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechainicial = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btngenerar = New System.Windows.Forms.Button()
        Me.btnreporteprogramado = New System.Windows.Forms.Button()
        Me.btnexcel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdepartamento)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.txtturno)
        Me.GroupBox1.Controls.Add(Me.txtpuesto)
        Me.GroupBox1.Controls.Add(Me.txtnombrecompleto)
        Me.GroupBox1.Controls.Add(Me.txtnumempleado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 174)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de empleado"
        '
        'txtdepartamento
        '
        Me.txtdepartamento.Enabled = False
        Me.txtdepartamento.Location = New System.Drawing.Point(116, 81)
        Me.txtdepartamento.Name = "txtdepartamento"
        Me.txtdepartamento.Size = New System.Drawing.Size(304, 20)
        Me.txtdepartamento.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Departamento"
        '
        'btnbuscar
        '
        Me.btnbuscar.Image = Global.DISENO.My.Resources.Resources.Buscar
        Me.btnbuscar.Location = New System.Drawing.Point(214, 15)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(30, 30)
        Me.btnbuscar.TabIndex = 8
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'txtturno
        '
        Me.txtturno.Enabled = False
        Me.txtturno.Location = New System.Drawing.Point(116, 137)
        Me.txtturno.Name = "txtturno"
        Me.txtturno.Size = New System.Drawing.Size(92, 20)
        Me.txtturno.TabIndex = 7
        '
        'txtpuesto
        '
        Me.txtpuesto.Enabled = False
        Me.txtpuesto.Location = New System.Drawing.Point(116, 112)
        Me.txtpuesto.Name = "txtpuesto"
        Me.txtpuesto.Size = New System.Drawing.Size(304, 20)
        Me.txtpuesto.TabIndex = 6
        '
        'txtnombrecompleto
        '
        Me.txtnombrecompleto.Enabled = False
        Me.txtnombrecompleto.Location = New System.Drawing.Point(116, 51)
        Me.txtnombrecompleto.Name = "txtnombrecompleto"
        Me.txtnombrecompleto.Size = New System.Drawing.Size(304, 20)
        Me.txtnombrecompleto.TabIndex = 5
        '
        'txtnumempleado
        '
        Me.txtnumempleado.Location = New System.Drawing.Point(116, 18)
        Me.txtnumempleado.Name = "txtnumempleado"
        Me.txtnumempleado.Size = New System.Drawing.Size(92, 20)
        Me.txtnumempleado.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Turno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Puesto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Completo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NumEmpleado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(128, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Generar Reporte de Vacaciones"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpfechafin)
        Me.GroupBox2.Controls.Add(Me.dtpfechainicial)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(433, 75)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rango de Fechasa a Generar"
        '
        'dtpfechafin
        '
        Me.dtpfechafin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechafin.Location = New System.Drawing.Point(305, 40)
        Me.dtpfechafin.Name = "dtpfechafin"
        Me.dtpfechafin.Size = New System.Drawing.Size(96, 20)
        Me.dtpfechafin.TabIndex = 7
        '
        'dtpfechainicial
        '
        Me.dtpfechainicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechainicial.Location = New System.Drawing.Point(104, 40)
        Me.dtpfechainicial.Name = "dtpfechainicial"
        Me.dtpfechainicial.Size = New System.Drawing.Size(96, 20)
        Me.dtpfechainicial.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(235, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Hasta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Desde"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnexcel)
        Me.Panel1.Controls.Add(Me.btnreporteprogramado)
        Me.Panel1.Controls.Add(Me.btnsalir)
        Me.Panel1.Controls.Add(Me.btngenerar)
        Me.Panel1.Location = New System.Drawing.Point(27, 312)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 44)
        Me.Panel1.TabIndex = 3
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(335, 11)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 1
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(22, 11)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 23)
        Me.btngenerar.TabIndex = 0
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseVisualStyleBackColor = True
        '
        'btnreporteprogramado
        '
        Me.btnreporteprogramado.Location = New System.Drawing.Point(108, 11)
        Me.btnreporteprogramado.Name = "btnreporteprogramado"
        Me.btnreporteprogramado.Size = New System.Drawing.Size(113, 23)
        Me.btnreporteprogramado.TabIndex = 2
        Me.btnreporteprogramado.Text = "ReporteProgramado"
        Me.btnreporteprogramado.UseVisualStyleBackColor = True
        '
        'btnexcel
        '
        Me.btnexcel.Location = New System.Drawing.Point(232, 11)
        Me.btnexcel.Name = "btnexcel"
        Me.btnexcel.Size = New System.Drawing.Size(92, 23)
        Me.btnexcel.TabIndex = 3
        Me.btnexcel.Text = "ExportarExcel"
        Me.btnexcel.UseVisualStyleBackColor = True
        '
        'FrmReporteVacaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 368)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmReporteVacaciones"
        Me.Text = "Reporte de Vacaciones.:."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtturno As TextBox
    Friend WithEvents txtpuesto As TextBox
    Friend WithEvents txtnombrecompleto As TextBox
    Friend WithEvents txtnumempleado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnbuscar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpfechafin As DateTimePicker
    Friend WithEvents dtpfechainicial As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnsalir As Button
    Friend WithEvents btngenerar As Button
    Friend WithEvents txtdepartamento As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnreporteprogramado As Button
    Friend WithEvents btnexcel As Button
End Class
