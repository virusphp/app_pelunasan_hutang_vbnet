<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLaporanHutang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLaporanHutang))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.cmbValidasi = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rTglFaktur = New System.Windows.Forms.RadioButton()
        Me.rTglTerima = New System.Windows.Forms.RadioButton()
        Me.rTglInput = New System.Windows.Forms.RadioButton()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmbJenisBarang = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DTPTanggalAkhirTab1 = New System.Windows.Forms.DateTimePicker()
        Me.DTPTanggalAwalTab1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbStatusFaktur = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnBaruTab1 = New System.Windows.Forms.Button()
        Me.btnExcelTab1 = New System.Windows.Forms.Button()
        Me.btnProsesTab1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalSisaHutang = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalBayar = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotalRetur = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotalHargaBeli = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNota = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.GridLaporan = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtTotalSisaHutang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalBayar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalRetur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalHargaBeli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.cmbValidasi)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.rTglFaktur)
        Me.GroupBox1.Controls.Add(Me.rTglTerima)
        Me.GroupBox1.Controls.Add(Me.rTglInput)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.cmbJenisBarang)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.DTPTanggalAkhirTab1)
        Me.GroupBox1.Controls.Add(Me.DTPTanggalAwalTab1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmbSupplier)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbStatusFaktur)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.btnBaruTab1)
        Me.GroupBox1.Controls.Add(Me.btnExcelTab1)
        Me.GroupBox1.Controls.Add(Me.btnProsesTab1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1110, 108)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(1063, 75)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(28, 23)
        Me.Button6.TabIndex = 83
        Me.Button6.UseVisualStyleBackColor = True
        '
        'cmbValidasi
        '
        Me.cmbValidasi.BackColor = System.Drawing.SystemColors.Info
        Me.cmbValidasi.FormattingEnabled = True
        Me.cmbValidasi.Items.AddRange(New Object() {"Sudah", "Belum"})
        Me.cmbValidasi.Location = New System.Drawing.Point(943, 76)
        Me.cmbValidasi.Name = "cmbValidasi"
        Me.cmbValidasi.Size = New System.Drawing.Size(115, 21)
        Me.cmbValidasi.TabIndex = 82
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(849, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 20)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Status Validasi"
        '
        'rTglFaktur
        '
        Me.rTglFaktur.AutoSize = True
        Me.rTglFaktur.Location = New System.Drawing.Point(210, 55)
        Me.rTglFaktur.Name = "rTglFaktur"
        Me.rTglFaktur.Size = New System.Drawing.Size(97, 17)
        Me.rTglFaktur.TabIndex = 80
        Me.rTglFaktur.TabStop = True
        Me.rTglFaktur.Text = "Tanggal Faktur"
        Me.rTglFaktur.UseVisualStyleBackColor = True
        '
        'rTglTerima
        '
        Me.rTglTerima.AutoSize = True
        Me.rTglTerima.Location = New System.Drawing.Point(112, 55)
        Me.rTglTerima.Name = "rTglTerima"
        Me.rTglTerima.Size = New System.Drawing.Size(99, 17)
        Me.rTglTerima.TabIndex = 79
        Me.rTglTerima.TabStop = True
        Me.rTglTerima.Text = "Tanggal Terima"
        Me.rTglTerima.UseVisualStyleBackColor = True
        '
        'rTglInput
        '
        Me.rTglInput.AutoSize = True
        Me.rTglInput.Location = New System.Drawing.Point(16, 55)
        Me.rTglInput.Name = "rTglInput"
        Me.rTglInput.Size = New System.Drawing.Size(91, 17)
        Me.rTglInput.TabIndex = 78
        Me.rTglInput.TabStop = True
        Me.rTglInput.Text = "Tanggal Input"
        Me.rTglInput.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(717, 22)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(28, 23)
        Me.Button5.TabIndex = 77
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(810, 75)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(28, 23)
        Me.Button4.TabIndex = 76
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cmbJenisBarang
        '
        Me.cmbJenisBarang.BackColor = System.Drawing.SystemColors.Info
        Me.cmbJenisBarang.FormattingEnabled = True
        Me.cmbJenisBarang.Location = New System.Drawing.Point(654, 76)
        Me.cmbJenisBarang.Name = "cmbJenisBarang"
        Me.cmbJenisBarang.Size = New System.Drawing.Size(153, 21)
        Me.cmbJenisBarang.TabIndex = 75
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(576, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Jenis Barang"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(536, 76)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 23)
        Me.Button3.TabIndex = 73
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DTPTanggalAkhirTab1
        '
        Me.DTPTanggalAkhirTab1.Location = New System.Drawing.Point(369, 78)
        Me.DTPTanggalAkhirTab1.Name = "DTPTanggalAkhirTab1"
        Me.DTPTanggalAkhirTab1.Size = New System.Drawing.Size(163, 20)
        Me.DTPTanggalAkhirTab1.TabIndex = 72
        '
        'DTPTanggalAwalTab1
        '
        Me.DTPTanggalAwalTab1.Location = New System.Drawing.Point(107, 78)
        Me.DTPTanggalAwalTab1.Name = "DTPTanggalAwalTab1"
        Me.DTPTanggalAwalTab1.Size = New System.Drawing.Size(163, 20)
        Me.DTPTanggalAwalTab1.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(276, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Sampai Tanggal"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(14, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Dari Tanggal"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(673, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 23)
        Me.Button2.TabIndex = 63
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(272, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 23)
        Me.Button1.TabIndex = 62
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbSupplier
        '
        Me.cmbSupplier.BackColor = System.Drawing.SystemColors.Info
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(400, 23)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(271, 21)
        Me.cmbSupplier.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(308, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Nama Supplier"
        '
        'cmbStatusFaktur
        '
        Me.cmbStatusFaktur.BackColor = System.Drawing.SystemColors.Info
        Me.cmbStatusFaktur.FormattingEnabled = True
        Me.cmbStatusFaktur.Items.AddRange(New Object() {"SELURUH", "OK", "REVISI"})
        Me.cmbStatusFaktur.Location = New System.Drawing.Point(106, 23)
        Me.cmbStatusFaktur.Name = "cmbStatusFaktur"
        Me.cmbStatusFaktur.Size = New System.Drawing.Size(163, 21)
        Me.cmbStatusFaktur.TabIndex = 58
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Location = New System.Drawing.Point(14, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 20)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Status Faktur"
        '
        'btnBaruTab1
        '
        Me.btnBaruTab1.Image = CType(resources.GetObject("btnBaruTab1.Image"), System.Drawing.Image)
        Me.btnBaruTab1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBaruTab1.Location = New System.Drawing.Point(1019, 16)
        Me.btnBaruTab1.Name = "btnBaruTab1"
        Me.btnBaruTab1.Size = New System.Drawing.Size(85, 35)
        Me.btnBaruTab1.TabIndex = 7
        Me.btnBaruTab1.Text = "Baru"
        Me.btnBaruTab1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBaruTab1.UseVisualStyleBackColor = True
        '
        'btnExcelTab1
        '
        Me.btnExcelTab1.Image = CType(resources.GetObject("btnExcelTab1.Image"), System.Drawing.Image)
        Me.btnExcelTab1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcelTab1.Location = New System.Drawing.Point(932, 16)
        Me.btnExcelTab1.Name = "btnExcelTab1"
        Me.btnExcelTab1.Size = New System.Drawing.Size(85, 35)
        Me.btnExcelTab1.TabIndex = 6
        Me.btnExcelTab1.Text = "Ke Excel"
        Me.btnExcelTab1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcelTab1.UseVisualStyleBackColor = True
        '
        'btnProsesTab1
        '
        Me.btnProsesTab1.Image = CType(resources.GetObject("btnProsesTab1.Image"), System.Drawing.Image)
        Me.btnProsesTab1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProsesTab1.Location = New System.Drawing.Point(845, 16)
        Me.btnProsesTab1.Name = "btnProsesTab1"
        Me.btnProsesTab1.Size = New System.Drawing.Size(85, 35)
        Me.btnProsesTab1.TabIndex = 4
        Me.btnProsesTab1.Text = "Proses"
        Me.btnProsesTab1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProsesTab1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtTotalSisaHutang)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtTotalBayar)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtTotalRetur)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtTotalHargaBeli)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtNota)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 577)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1110, 60)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(905, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 20)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Total Sisa Hutang"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtTotalSisaHutang
        '
        Me.txtTotalSisaHutang.BackGroundColor = System.Drawing.SystemColors.Info
        Me.txtTotalSisaHutang.BeforeTouchSize = New System.Drawing.Size(205, 20)
        Me.txtTotalSisaHutang.BorderColor = System.Drawing.Color.DimGray
        Me.txtTotalSisaHutang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalSisaHutang.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txtTotalSisaHutang.CurrencySymbol = ""
        Me.txtTotalSisaHutang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalSisaHutang.DecimalValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtTotalSisaHutang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSisaHutang.Location = New System.Drawing.Point(905, 29)
        Me.txtTotalSisaHutang.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtTotalSisaHutang.Name = "txtTotalSisaHutang"
        Me.txtTotalSisaHutang.NullString = ""
        Me.txtTotalSisaHutang.ReadOnly = True
        Me.txtTotalSisaHutang.Size = New System.Drawing.Size(189, 20)
        Me.txtTotalSisaHutang.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None
        Me.txtTotalSisaHutang.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtTotalSisaHutang.TabIndex = 39
        Me.txtTotalSisaHutang.Text = "0.00"
        Me.txtTotalSisaHutang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(717, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 20)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Total Bayar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtTotalBayar
        '
        Me.txtTotalBayar.BackGroundColor = System.Drawing.SystemColors.Info
        Me.txtTotalBayar.BeforeTouchSize = New System.Drawing.Size(205, 20)
        Me.txtTotalBayar.BorderColor = System.Drawing.Color.DimGray
        Me.txtTotalBayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalBayar.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txtTotalBayar.CurrencySymbol = ""
        Me.txtTotalBayar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalBayar.DecimalValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtTotalBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBayar.Location = New System.Drawing.Point(717, 29)
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
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(529, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(189, 20)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Total Retur"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtTotalRetur
        '
        Me.txtTotalRetur.BackGroundColor = System.Drawing.SystemColors.Info
        Me.txtTotalRetur.BeforeTouchSize = New System.Drawing.Size(205, 20)
        Me.txtTotalRetur.BorderColor = System.Drawing.Color.DimGray
        Me.txtTotalRetur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalRetur.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txtTotalRetur.CurrencySymbol = ""
        Me.txtTotalRetur.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalRetur.DecimalValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtTotalRetur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalRetur.Location = New System.Drawing.Point(529, 29)
        Me.txtTotalRetur.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtTotalRetur.Name = "txtTotalRetur"
        Me.txtTotalRetur.NullString = ""
        Me.txtTotalRetur.ReadOnly = True
        Me.txtTotalRetur.Size = New System.Drawing.Size(189, 20)
        Me.txtTotalRetur.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None
        Me.txtTotalRetur.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtTotalRetur.TabIndex = 35
        Me.txtTotalRetur.Text = "0.00"
        Me.txtTotalRetur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(341, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(189, 20)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Total Harga Beli"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtTotalHargaBeli
        '
        Me.txtTotalHargaBeli.BackGroundColor = System.Drawing.SystemColors.Info
        Me.txtTotalHargaBeli.BeforeTouchSize = New System.Drawing.Size(205, 20)
        Me.txtTotalHargaBeli.BorderColor = System.Drawing.Color.DimGray
        Me.txtTotalHargaBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalHargaBeli.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txtTotalHargaBeli.CurrencySymbol = ""
        Me.txtTotalHargaBeli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalHargaBeli.DecimalValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtTotalHargaBeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHargaBeli.Location = New System.Drawing.Point(341, 29)
        Me.txtTotalHargaBeli.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtTotalHargaBeli.Name = "txtTotalHargaBeli"
        Me.txtTotalHargaBeli.NullString = ""
        Me.txtTotalHargaBeli.ReadOnly = True
        Me.txtTotalHargaBeli.Size = New System.Drawing.Size(189, 20)
        Me.txtTotalHargaBeli.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.None
        Me.txtTotalHargaBeli.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.txtTotalHargaBeli.TabIndex = 33
        Me.txtTotalHargaBeli.Text = "0.00"
        Me.txtTotalHargaBeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(255, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 20)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Jumlah Nota"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNota
        '
        Me.txtNota.BackGroundColor = System.Drawing.SystemColors.Info
        Me.txtNota.BeforeTouchSize = New System.Drawing.Size(205, 20)
        Me.txtNota.BorderColor = System.Drawing.Color.DimGray
        Me.txtNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNota.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txtNota.CurrencySymbol = ""
        Me.txtNota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNota.DecimalValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.txtNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota.Location = New System.Drawing.Point(255, 29)
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
        Me.GridLaporan.Location = New System.Drawing.Point(0, 108)
        Me.GridLaporan.Name = "GridLaporan"
        Me.GridLaporan.Size = New System.Drawing.Size(1110, 469)
        Me.GridLaporan.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Validasi"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Batal"
        Me.Column2.Name = "Column2"
        '
        'formLaporanHutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 637)
        Me.Controls.Add(Me.GridLaporan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formLaporanHutang"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Hutang Kepada Supplier"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtTotalSisaHutang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalBayar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalRetur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalHargaBeli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBaruTab1 As System.Windows.Forms.Button
    Friend WithEvents btnExcelTab1 As System.Windows.Forms.Button
    Friend WithEvents btnProsesTab1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbStatusFaktur As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GridLaporan As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotalRetur As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotalHargaBeli As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNota As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotalSisaHutang As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotalBayar As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents cmbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DTPTanggalAkhirTab1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPTanggalAwalTab1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbJenisBarang As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents rTglFaktur As System.Windows.Forms.RadioButton
    Friend WithEvents rTglTerima As System.Windows.Forms.RadioButton
    Friend WithEvents rTglInput As System.Windows.Forms.RadioButton
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents cmbValidasi As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewButtonColumn

End Class
