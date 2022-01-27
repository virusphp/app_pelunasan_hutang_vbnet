<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanPelunasan
    Inherits Syncfusion.Windows.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporanPelunasan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmbJenisBarang = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbValidasi = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBaruTab1 = New System.Windows.Forms.Button()
        Me.btnExcelTab1 = New System.Windows.Forms.Button()
        Me.btnProsesTab1 = New System.Windows.Forms.Button()
        Me.DTPTanggalAkhirTab1 = New System.Windows.Forms.DateTimePicker()
        Me.DTPTanggalAwalTab1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalBayar = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNota = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.GridLaporan = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtTotalBayar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.cmbJenisBarang)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbValidasi)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.cmbSupplier)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnBaruTab1)
        Me.GroupBox1.Controls.Add(Me.btnExcelTab1)
        Me.GroupBox1.Controls.Add(Me.btnProsesTab1)
        Me.GroupBox1.Controls.Add(Me.DTPTanggalAkhirTab1)
        Me.GroupBox1.Controls.Add(Me.DTPTanggalAwalTab1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1247, 64)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(859, 34)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(28, 23)
        Me.Button4.TabIndex = 79
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cmbJenisBarang
        '
        Me.cmbJenisBarang.BackColor = System.Drawing.SystemColors.Info
        Me.cmbJenisBarang.FormattingEnabled = True
        Me.cmbJenisBarang.Location = New System.Drawing.Point(703, 35)
        Me.cmbJenisBarang.Name = "cmbJenisBarang"
        Me.cmbJenisBarang.Size = New System.Drawing.Size(153, 21)
        Me.cmbJenisBarang.TabIndex = 78
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(703, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 20)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Jenis Barang"
        '
        'cmbValidasi
        '
        Me.cmbValidasi.BackColor = System.Drawing.SystemColors.Info
        Me.cmbValidasi.FormattingEnabled = True
        Me.cmbValidasi.Items.AddRange(New Object() {"Sudah", "Belum"})
        Me.cmbValidasi.Location = New System.Drawing.Point(504, 35)
        Me.cmbValidasi.Name = "cmbValidasi"
        Me.cmbValidasi.Size = New System.Drawing.Size(159, 21)
        Me.cmbValidasi.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(504, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 20)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Status Validasi"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(669, 34)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 23)
        Me.Button3.TabIndex = 68
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(890, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 23)
        Me.Button1.TabIndex = 67
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(474, 34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 23)
        Me.Button2.TabIndex = 66
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmbSupplier
        '
        Me.cmbSupplier.BackColor = System.Drawing.SystemColors.Info
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(250, 35)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(218, 21)
        Me.cmbSupplier.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(250, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(218, 20)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Nama Supplier"
        '
        'btnBaruTab1
        '
        Me.btnBaruTab1.Image = CType(resources.GetObject("btnBaruTab1.Image"), System.Drawing.Image)
        Me.btnBaruTab1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBaruTab1.Location = New System.Drawing.Point(1155, 17)
        Me.btnBaruTab1.Name = "btnBaruTab1"
        Me.btnBaruTab1.Size = New System.Drawing.Size(85, 35)
        Me.btnBaruTab1.TabIndex = 8
        Me.btnBaruTab1.Text = "Baru"
        Me.btnBaruTab1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBaruTab1.UseVisualStyleBackColor = True
        '
        'btnExcelTab1
        '
        Me.btnExcelTab1.Image = CType(resources.GetObject("btnExcelTab1.Image"), System.Drawing.Image)
        Me.btnExcelTab1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcelTab1.Location = New System.Drawing.Point(1068, 17)
        Me.btnExcelTab1.Name = "btnExcelTab1"
        Me.btnExcelTab1.Size = New System.Drawing.Size(85, 35)
        Me.btnExcelTab1.TabIndex = 7
        Me.btnExcelTab1.Text = "Ke Excel"
        Me.btnExcelTab1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcelTab1.UseVisualStyleBackColor = True
        '
        'btnProsesTab1
        '
        Me.btnProsesTab1.Image = CType(resources.GetObject("btnProsesTab1.Image"), System.Drawing.Image)
        Me.btnProsesTab1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProsesTab1.Location = New System.Drawing.Point(981, 17)
        Me.btnProsesTab1.Name = "btnProsesTab1"
        Me.btnProsesTab1.Size = New System.Drawing.Size(85, 35)
        Me.btnProsesTab1.TabIndex = 6
        Me.btnProsesTab1.Text = "Proses"
        Me.btnProsesTab1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProsesTab1.UseVisualStyleBackColor = True
        '
        'DTPTanggalAkhirTab1
        '
        Me.DTPTanggalAkhirTab1.CustomFormat = "ddMMMMyyyy"
        Me.DTPTanggalAkhirTab1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTanggalAkhirTab1.Location = New System.Drawing.Point(108, 36)
        Me.DTPTanggalAkhirTab1.Name = "DTPTanggalAkhirTab1"
        Me.DTPTanggalAkhirTab1.Size = New System.Drawing.Size(135, 20)
        Me.DTPTanggalAkhirTab1.TabIndex = 3
        '
        'DTPTanggalAwalTab1
        '
        Me.DTPTanggalAwalTab1.CustomFormat = "ddMMMMyyyy"
        Me.DTPTanggalAwalTab1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTanggalAwalTab1.Location = New System.Drawing.Point(108, 13)
        Me.DTPTanggalAwalTab1.Name = "DTPTanggalAwalTab1"
        Me.DTPTanggalAwalTab1.Size = New System.Drawing.Size(135, 20)
        Me.DTPTanggalAwalTab1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sampai Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dari Tanggal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtTotalBayar)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtNota)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 582)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1247, 60)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(1051, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 20)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Total Bayar"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtTotalBayar
        '
        Me.txtTotalBayar.BackGroundColor = System.Drawing.SystemColors.Info
        Me.txtTotalBayar.BeforeTouchSize = New System.Drawing.Size(87, 20)
        Me.txtTotalBayar.BorderColor = System.Drawing.Color.DimGray
        Me.txtTotalBayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalBayar.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txtTotalBayar.CurrencySymbol = ""
        Me.txtTotalBayar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalBayar.DecimalValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtTotalBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBayar.Location = New System.Drawing.Point(1051, 32)
        Me.txtTotalBayar.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtTotalBayar.Name = "txtTotalBayar"
        Me.txtTotalBayar.NullString = ""
        Me.txtTotalBayar.ReadOnly = True
        Me.txtTotalBayar.Size = New System.Drawing.Size(189, 20)
        Me.txtTotalBayar.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None
        Me.txtTotalBayar.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtTotalBayar.TabIndex = 37
        Me.txtTotalBayar.Text = "0.00"
        Me.txtTotalBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(965, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 20)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Jumlah Faktur"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNota
        '
        Me.txtNota.BackGroundColor = System.Drawing.SystemColors.Info
        Me.txtNota.BeforeTouchSize = New System.Drawing.Size(87, 20)
        Me.txtNota.BorderColor = System.Drawing.Color.DimGray
        Me.txtNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNota.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txtNota.CurrencySymbol = ""
        Me.txtNota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNota.DecimalValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota.Location = New System.Drawing.Point(965, 32)
        Me.txtNota.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtNota.Name = "txtNota"
        Me.txtNota.NullString = ""
        Me.txtNota.ReadOnly = True
        Me.txtNota.Size = New System.Drawing.Size(87, 20)
        Me.txtNota.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None
        Me.txtNota.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtNota.TabIndex = 31
        Me.txtNota.Text = "0.00"
        Me.txtNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GridLaporan
        '
        Me.GridLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridLaporan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.GridLaporan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridLaporan.Location = New System.Drawing.Point(0, 64)
        Me.GridLaporan.Name = "GridLaporan"
        Me.GridLaporan.Size = New System.Drawing.Size(1247, 518)
        Me.GridLaporan.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Validasi"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Column2
        '
        Me.Column2.HeaderText = "Batal"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'FormLaporanPelunasan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 642)
        Me.Controls.Add(Me.GridLaporan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLaporanPelunasan"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Pelunasan Pembayaran Hutang Supplier"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtTotalBayar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBaruTab1 As System.Windows.Forms.Button
    Friend WithEvents btnExcelTab1 As System.Windows.Forms.Button
    Friend WithEvents btnProsesTab1 As System.Windows.Forms.Button
    Friend WithEvents DTPTanggalAkhirTab1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPTanggalAwalTab1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotalBayar As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNota As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents GridLaporan As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cmbValidasi As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cmbJenisBarang As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
