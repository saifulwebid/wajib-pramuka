<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.mstMain = New System.Windows.Forms.MenuStrip()
        Me.sstMain = New System.Windows.Forms.StatusStrip()
        Me.mnuDatabase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDatabaseBuka = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDatabaseTutup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDatabaseSimpan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDatabaseBackup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDatabaseRestore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDatabaseBaru = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDatabaseCleanSemester = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDatabaseCleanTahunan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDatabaseAuthentication = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuInduk = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIndukKelas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIndukGudep = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIndukAmbalan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIndukPembina = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIndukSiswa = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIndukSK = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTransaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransaksiKegiatan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransaksiKehadiran = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransaksiKasus = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOlah = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLaporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBantuan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTentang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mstMain
        '
        Me.mstMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDatabase, Me.mnuInduk, Me.mnuTransaksi, Me.mnuOlah, Me.mnuLaporan, Me.mnuBantuan})
        Me.mstMain.Location = New System.Drawing.Point(0, 0)
        Me.mstMain.Name = "mstMain"
        Me.mstMain.Size = New System.Drawing.Size(726, 24)
        Me.mstMain.TabIndex = 1
        Me.mstMain.Text = "MenuStrip1"
        '
        'sstMain
        '
        Me.sstMain.Location = New System.Drawing.Point(0, 371)
        Me.sstMain.Name = "sstMain"
        Me.sstMain.Size = New System.Drawing.Size(726, 22)
        Me.sstMain.TabIndex = 2
        Me.sstMain.Text = "StatusStrip1"
        '
        'mnuDatabase
        '
        Me.mnuDatabase.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDatabaseBaru, Me.mnuDatabaseBuka, Me.mnuDatabaseTutup, Me.mnuDatabaseSimpan, Me.ToolStripSeparator1, Me.mnuDatabaseBackup, Me.mnuDatabaseRestore, Me.ToolStripSeparator2, Me.mnuDatabaseCleanSemester, Me.mnuDatabaseCleanTahunan, Me.ToolStripSeparator4, Me.mnuDatabaseAuthentication, Me.ToolStripSeparator3, Me.mnuQuit})
        Me.mnuDatabase.Name = "mnuDatabase"
        Me.mnuDatabase.Size = New System.Drawing.Size(67, 20)
        Me.mnuDatabase.Text = "Database"
        '
        'mnuDatabaseBuka
        '
        Me.mnuDatabaseBuka.Name = "mnuDatabaseBuka"
        Me.mnuDatabaseBuka.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuDatabaseBuka.Size = New System.Drawing.Size(288, 22)
        Me.mnuDatabaseBuka.Text = "Buka database..."
        '
        'mnuDatabaseTutup
        '
        Me.mnuDatabaseTutup.Name = "mnuDatabaseTutup"
        Me.mnuDatabaseTutup.Size = New System.Drawing.Size(288, 22)
        Me.mnuDatabaseTutup.Text = "Tutup database"
        '
        'mnuDatabaseSimpan
        '
        Me.mnuDatabaseSimpan.Name = "mnuDatabaseSimpan"
        Me.mnuDatabaseSimpan.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuDatabaseSimpan.Size = New System.Drawing.Size(288, 22)
        Me.mnuDatabaseSimpan.Text = "Simpan database sebagai..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(285, 6)
        '
        'mnuDatabaseBackup
        '
        Me.mnuDatabaseBackup.Name = "mnuDatabaseBackup"
        Me.mnuDatabaseBackup.Size = New System.Drawing.Size(288, 22)
        Me.mnuDatabaseBackup.Text = "Backup database..."
        '
        'mnuDatabaseRestore
        '
        Me.mnuDatabaseRestore.Name = "mnuDatabaseRestore"
        Me.mnuDatabaseRestore.Size = New System.Drawing.Size(288, 22)
        Me.mnuDatabaseRestore.Text = "Restore database..."
        '
        'mnuDatabaseBaru
        '
        Me.mnuDatabaseBaru.Name = "mnuDatabaseBaru"
        Me.mnuDatabaseBaru.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuDatabaseBaru.Size = New System.Drawing.Size(288, 22)
        Me.mnuDatabaseBaru.Text = "Buat database baru..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(285, 6)
        '
        'mnuDatabaseCleanSemester
        '
        Me.mnuDatabaseCleanSemester.Name = "mnuDatabaseCleanSemester"
        Me.mnuDatabaseCleanSemester.Size = New System.Drawing.Size(288, 22)
        Me.mnuDatabaseCleanSemester.Text = "Bersihkan data semester..."
        '
        'mnuDatabaseCleanTahunan
        '
        Me.mnuDatabaseCleanTahunan.Name = "mnuDatabaseCleanTahunan"
        Me.mnuDatabaseCleanTahunan.Size = New System.Drawing.Size(288, 22)
        Me.mnuDatabaseCleanTahunan.Text = "Bersihkan data tahunan..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(285, 6)
        '
        'mnuQuit
        '
        Me.mnuQuit.Name = "mnuQuit"
        Me.mnuQuit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuQuit.Size = New System.Drawing.Size(288, 22)
        Me.mnuQuit.Text = "Keluar aplikasi"
        '
        'mnuDatabaseAuthentication
        '
        Me.mnuDatabaseAuthentication.Name = "mnuDatabaseAuthentication"
        Me.mnuDatabaseAuthentication.Size = New System.Drawing.Size(288, 22)
        Me.mnuDatabaseAuthentication.Text = "Atur autentikasi pengguna..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(285, 6)
        '
        'mnuInduk
        '
        Me.mnuInduk.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuIndukKelas, Me.ToolStripSeparator5, Me.mnuIndukGudep, Me.mnuIndukAmbalan, Me.ToolStripSeparator6, Me.mnuIndukPembina, Me.mnuIndukSiswa, Me.ToolStripSeparator7, Me.mnuIndukSK})
        Me.mnuInduk.Name = "mnuInduk"
        Me.mnuInduk.Size = New System.Drawing.Size(76, 20)
        Me.mnuInduk.Text = "Data Induk"
        '
        'mnuIndukKelas
        '
        Me.mnuIndukKelas.Name = "mnuIndukKelas"
        Me.mnuIndukKelas.Size = New System.Drawing.Size(180, 22)
        Me.mnuIndukKelas.Text = "Kelas..."
        '
        'mnuIndukGudep
        '
        Me.mnuIndukGudep.Name = "mnuIndukGudep"
        Me.mnuIndukGudep.Size = New System.Drawing.Size(180, 22)
        Me.mnuIndukGudep.Text = "Gugusdepan..."
        '
        'mnuIndukAmbalan
        '
        Me.mnuIndukAmbalan.Name = "mnuIndukAmbalan"
        Me.mnuIndukAmbalan.Size = New System.Drawing.Size(180, 22)
        Me.mnuIndukAmbalan.Text = "Ambalan..."
        '
        'mnuIndukPembina
        '
        Me.mnuIndukPembina.Name = "mnuIndukPembina"
        Me.mnuIndukPembina.Size = New System.Drawing.Size(180, 22)
        Me.mnuIndukPembina.Text = "Pembina Pramuka..."
        '
        'mnuIndukSiswa
        '
        Me.mnuIndukSiswa.Name = "mnuIndukSiswa"
        Me.mnuIndukSiswa.Size = New System.Drawing.Size(180, 22)
        Me.mnuIndukSiswa.Text = "Peserta didik..."
        '
        'mnuIndukSK
        '
        Me.mnuIndukSK.Name = "mnuIndukSK"
        Me.mnuIndukSK.Size = New System.Drawing.Size(180, 22)
        Me.mnuIndukSK.Text = "SKU dan SKK..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(177, 6)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(177, 6)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(177, 6)
        '
        'mnuTransaksi
        '
        Me.mnuTransaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTransaksiKegiatan, Me.mnuTransaksiKehadiran, Me.mnuTransaksiKasus})
        Me.mnuTransaksi.Name = "mnuTransaksi"
        Me.mnuTransaksi.Size = New System.Drawing.Size(91, 20)
        Me.mnuTransaksi.Text = "Transaksional"
        '
        'mnuTransaksiKegiatan
        '
        Me.mnuTransaksiKegiatan.Name = "mnuTransaksiKegiatan"
        Me.mnuTransaksiKegiatan.Size = New System.Drawing.Size(240, 22)
        Me.mnuTransaksiKegiatan.Text = "Kelola kegiatan..."
        '
        'mnuTransaksiKehadiran
        '
        Me.mnuTransaksiKehadiran.Name = "mnuTransaksiKehadiran"
        Me.mnuTransaksiKehadiran.Size = New System.Drawing.Size(240, 22)
        Me.mnuTransaksiKehadiran.Text = "Kelola kehadiran peserta didik..."
        '
        'mnuTransaksiKasus
        '
        Me.mnuTransaksiKasus.Name = "mnuTransaksiKasus"
        Me.mnuTransaksiKasus.Size = New System.Drawing.Size(240, 22)
        Me.mnuTransaksiKasus.Text = "Kelola kasus peserta didik..."
        '
        'mnuOlah
        '
        Me.mnuOlah.Name = "mnuOlah"
        Me.mnuOlah.Size = New System.Drawing.Size(71, 20)
        Me.mnuOlah.Text = "Olah Data"
        '
        'mnuLaporan
        '
        Me.mnuLaporan.Name = "mnuLaporan"
        Me.mnuLaporan.Size = New System.Drawing.Size(62, 20)
        Me.mnuLaporan.Text = "Laporan"
        '
        'mnuBantuan
        '
        Me.mnuBantuan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTentang})
        Me.mnuBantuan.Name = "mnuBantuan"
        Me.mnuBantuan.Size = New System.Drawing.Size(63, 20)
        Me.mnuBantuan.Text = "Bantuan"
        '
        'mnuTentang
        '
        Me.mnuTentang.Name = "mnuTentang"
        Me.mnuTentang.Size = New System.Drawing.Size(160, 22)
        Me.mnuTentang.Text = "Tentang aplikasi"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 393)
        Me.Controls.Add(Me.sstMain)
        Me.Controls.Add(Me.mstMain)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mstMain
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mstMain.ResumeLayout(False)
        Me.mstMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mstMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuDatabase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDatabaseBaru As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDatabaseBuka As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDatabaseTutup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDatabaseSimpan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuDatabaseBackup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDatabaseRestore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuDatabaseCleanSemester As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDatabaseCleanTahunan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuQuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sstMain As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuDatabaseAuthentication As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInduk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuIndukKelas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuIndukGudep As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuIndukAmbalan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuIndukPembina As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuIndukSiswa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuIndukSK As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTransaksi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTransaksiKegiatan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTransaksiKehadiran As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTransaksiKasus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOlah As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLaporan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBantuan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTentang As System.Windows.Forms.ToolStripMenuItem
End Class
