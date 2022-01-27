<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRekapHutang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRekapHutang))
        Me.GradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.cmdProses = New System.Windows.Forms.Button()
        Me.cmdBaru = New System.Windows.Forms.Button()
        Me.cmdExport = New System.Windows.Forms.Button()
        Me.cmdKeluar = New System.Windows.Forms.Button()
        Me.gridPasien = New System.Windows.Forms.DataGridView()
        Me.GradientPanel4 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel1.SuspendLayout()
        Me.Panel31.SuspendLayout()
        CType(Me.gridPasien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradientPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GradientPanel1
        '
        Me.GradientPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GradientPanel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GradientPanel1.BackgroundImage = CType(resources.GetObject("GradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GradientPanel1.Controls.Add(Me.Panel31)
        Me.GradientPanel1.Controls.Add(Me.gridPasien)
        Me.GradientPanel1.IgnoreThemeBackground = True
        Me.GradientPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GradientPanel1.Location = New System.Drawing.Point(2, 59)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.Size = New System.Drawing.Size(1212, 551)
        Me.GradientPanel1.TabIndex = 48
        Me.GradientPanel1.ThemesEnabled = True
        '
        'Panel31
        '
        Me.Panel31.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel31.BackColor = System.Drawing.Color.Transparent
        Me.Panel31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel31.Controls.Add(Me.cmdProses)
        Me.Panel31.Controls.Add(Me.cmdBaru)
        Me.Panel31.Controls.Add(Me.cmdExport)
        Me.Panel31.Controls.Add(Me.cmdKeluar)
        Me.Panel31.Location = New System.Drawing.Point(6, 3)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(1197, 48)
        Me.Panel31.TabIndex = 261
        '
        'cmdProses
        '
        Me.cmdProses.Image = CType(resources.GetObject("cmdProses.Image"), System.Drawing.Image)
        Me.cmdProses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdProses.Location = New System.Drawing.Point(87, 4)
        Me.cmdProses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdProses.Name = "cmdProses"
        Me.cmdProses.Size = New System.Drawing.Size(78, 38)
        Me.cmdProses.TabIndex = 257
        Me.cmdProses.Text = "Proses"
        Me.cmdProses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdProses.UseVisualStyleBackColor = True
        '
        'cmdBaru
        '
        Me.cmdBaru.Image = CType(resources.GetObject("cmdBaru.Image"), System.Drawing.Image)
        Me.cmdBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBaru.Location = New System.Drawing.Point(3, 4)
        Me.cmdBaru.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdBaru.Name = "cmdBaru"
        Me.cmdBaru.Size = New System.Drawing.Size(78, 38)
        Me.cmdBaru.TabIndex = 256
        Me.cmdBaru.Text = "Baru"
        Me.cmdBaru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdBaru.UseVisualStyleBackColor = True
        '
        'cmdExport
        '
        Me.cmdExport.Image = CType(resources.GetObject("cmdExport.Image"), System.Drawing.Image)
        Me.cmdExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExport.Location = New System.Drawing.Point(171, 4)
        Me.cmdExport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(78, 38)
        Me.cmdExport.TabIndex = 255
        Me.cmdExport.Text = "Export"
        Me.cmdExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'cmdKeluar
        '
        Me.cmdKeluar.Image = CType(resources.GetObject("cmdKeluar.Image"), System.Drawing.Image)
        Me.cmdKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdKeluar.Location = New System.Drawing.Point(255, 4)
        Me.cmdKeluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdKeluar.Name = "cmdKeluar"
        Me.cmdKeluar.Size = New System.Drawing.Size(78, 39)
        Me.cmdKeluar.TabIndex = 19
        Me.cmdKeluar.Text = "Keluar"
        Me.cmdKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdKeluar.UseVisualStyleBackColor = True
        '
        'gridPasien
        '
        Me.gridPasien.AllowUserToAddRows = False
        Me.gridPasien.AllowUserToDeleteRows = False
        Me.gridPasien.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridPasien.ColumnHeadersHeight = 40
        Me.gridPasien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.gridPasien.Location = New System.Drawing.Point(6, 57)
        Me.gridPasien.Name = "gridPasien"
        Me.gridPasien.ReadOnly = True
        Me.gridPasien.RowHeadersWidth = 5
        Me.gridPasien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridPasien.Size = New System.Drawing.Size(1197, 486)
        Me.gridPasien.TabIndex = 260
        '
        'GradientPanel4
        '
        Me.GradientPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GradientPanel4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GradientPanel4.BackgroundImage = CType(resources.GetObject("GradientPanel4.BackgroundImage"), System.Drawing.Image)
        Me.GradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GradientPanel4.Controls.Add(Me.Label3)
        Me.GradientPanel4.Controls.Add(Me.Label4)
        Me.GradientPanel4.Controls.Add(Me.PictureBox2)
        Me.GradientPanel4.IgnoreThemeBackground = True
        Me.GradientPanel4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GradientPanel4.Location = New System.Drawing.Point(2, 3)
        Me.GradientPanel4.Name = "GradientPanel4"
        Me.GradientPanel4.Size = New System.Drawing.Size(1212, 54)
        Me.GradientPanel4.TabIndex = 47
        Me.GradientPanel4.ThemesEnabled = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 15)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Menu ini digunakan untuk rekap hutang farmasi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, -2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(291, 25)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Laporan Rekap Hutang Farmasi"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 51)
        Me.PictureBox2.TabIndex = 95
        Me.PictureBox2.TabStop = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Detail Pembayaran"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 70
        '
        'FormRekapHutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SI_Pelunasan_Hutang_Farmasi.My.Resources.Resources.BackgroundForm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1218, 614)
        Me.Controls.Add(Me.GradientPanel1)
        Me.Controls.Add(Me.GradientPanel4)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormRekapHutang"
        Me.Text = "Rekap Hutang"
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel1.ResumeLayout(False)
        Me.Panel31.ResumeLayout(False)
        CType(Me.gridPasien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradientPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel4.ResumeLayout(False)
        Me.GradientPanel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents Panel31 As Panel
    Friend WithEvents cmdProses As Button
    Friend WithEvents cmdBaru As Button
    Friend WithEvents cmdExport As Button
    Friend WithEvents cmdKeluar As Button
    Friend WithEvents gridPasien As DataGridView
    Friend WithEvents GradientPanel4 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Column1 As DataGridViewButtonColumn
End Class
