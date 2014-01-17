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
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TutupDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanDatabaseSebagaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BackupDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuatDatabaseBaruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BersihkanDataSemesterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BersihkanDataTahunanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.KeluarAplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AturAutentikasiPenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataIndukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GugusdepanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AmbalanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembinaPramukaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesertaDidikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SKUDanSKKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.TransaksionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KegiatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KehadiranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengolahanDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenyusunanLaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BantuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangAplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mstMain
        '
        Me.mstMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.DataIndukToolStripMenuItem, Me.TransaksionalToolStripMenuItem, Me.PengolahanDataToolStripMenuItem, Me.PenyusunanLaporanToolStripMenuItem, Me.BantuanToolStripMenuItem})
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
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuatDatabaseBaruToolStripMenuItem, Me.BukaDatabaseToolStripMenuItem, Me.TutupDatabaseToolStripMenuItem, Me.SimpanDatabaseSebagaiToolStripMenuItem, Me.ToolStripSeparator1, Me.BackupDatabaseToolStripMenuItem, Me.RestoreDatabaseToolStripMenuItem, Me.ToolStripSeparator2, Me.BersihkanDataSemesterToolStripMenuItem, Me.BersihkanDataTahunanToolStripMenuItem, Me.ToolStripSeparator4, Me.AturAutentikasiPenggunaToolStripMenuItem, Me.ToolStripSeparator3, Me.KeluarAplikasiToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(67, 20)
        Me.ToolStripMenuItem1.Text = "Database"
        '
        'BukaDatabaseToolStripMenuItem
        '
        Me.BukaDatabaseToolStripMenuItem.Name = "BukaDatabaseToolStripMenuItem"
        Me.BukaDatabaseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.BukaDatabaseToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.BukaDatabaseToolStripMenuItem.Text = "Buka database..."
        '
        'TutupDatabaseToolStripMenuItem
        '
        Me.TutupDatabaseToolStripMenuItem.Name = "TutupDatabaseToolStripMenuItem"
        Me.TutupDatabaseToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.TutupDatabaseToolStripMenuItem.Text = "Tutup database"
        '
        'SimpanDatabaseSebagaiToolStripMenuItem
        '
        Me.SimpanDatabaseSebagaiToolStripMenuItem.Name = "SimpanDatabaseSebagaiToolStripMenuItem"
        Me.SimpanDatabaseSebagaiToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SimpanDatabaseSebagaiToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.SimpanDatabaseSebagaiToolStripMenuItem.Text = "Simpan database sebagai..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(285, 6)
        '
        'BackupDatabaseToolStripMenuItem
        '
        Me.BackupDatabaseToolStripMenuItem.Name = "BackupDatabaseToolStripMenuItem"
        Me.BackupDatabaseToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.BackupDatabaseToolStripMenuItem.Text = "Backup database..."
        '
        'RestoreDatabaseToolStripMenuItem
        '
        Me.RestoreDatabaseToolStripMenuItem.Name = "RestoreDatabaseToolStripMenuItem"
        Me.RestoreDatabaseToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.RestoreDatabaseToolStripMenuItem.Text = "Restore database..."
        '
        'BuatDatabaseBaruToolStripMenuItem
        '
        Me.BuatDatabaseBaruToolStripMenuItem.Name = "BuatDatabaseBaruToolStripMenuItem"
        Me.BuatDatabaseBaruToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.BuatDatabaseBaruToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.BuatDatabaseBaruToolStripMenuItem.Text = "Buat database baru..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(285, 6)
        '
        'BersihkanDataSemesterToolStripMenuItem
        '
        Me.BersihkanDataSemesterToolStripMenuItem.Name = "BersihkanDataSemesterToolStripMenuItem"
        Me.BersihkanDataSemesterToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.BersihkanDataSemesterToolStripMenuItem.Text = "Bersihkan data semester..."
        '
        'BersihkanDataTahunanToolStripMenuItem
        '
        Me.BersihkanDataTahunanToolStripMenuItem.Name = "BersihkanDataTahunanToolStripMenuItem"
        Me.BersihkanDataTahunanToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.BersihkanDataTahunanToolStripMenuItem.Text = "Bersihkan data tahunan..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(285, 6)
        '
        'KeluarAplikasiToolStripMenuItem
        '
        Me.KeluarAplikasiToolStripMenuItem.Name = "KeluarAplikasiToolStripMenuItem"
        Me.KeluarAplikasiToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.KeluarAplikasiToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.KeluarAplikasiToolStripMenuItem.Text = "Keluar aplikasi"
        '
        'AturAutentikasiPenggunaToolStripMenuItem
        '
        Me.AturAutentikasiPenggunaToolStripMenuItem.Name = "AturAutentikasiPenggunaToolStripMenuItem"
        Me.AturAutentikasiPenggunaToolStripMenuItem.Size = New System.Drawing.Size(288, 22)
        Me.AturAutentikasiPenggunaToolStripMenuItem.Text = "Atur autentikasi pengguna..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(285, 6)
        '
        'DataIndukToolStripMenuItem
        '
        Me.DataIndukToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KelasToolStripMenuItem, Me.ToolStripSeparator5, Me.GugusdepanToolStripMenuItem, Me.AmbalanToolStripMenuItem, Me.ToolStripSeparator6, Me.PembinaPramukaToolStripMenuItem, Me.PesertaDidikToolStripMenuItem, Me.ToolStripSeparator7, Me.SKUDanSKKToolStripMenuItem})
        Me.DataIndukToolStripMenuItem.Name = "DataIndukToolStripMenuItem"
        Me.DataIndukToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.DataIndukToolStripMenuItem.Text = "Data Induk"
        '
        'KelasToolStripMenuItem
        '
        Me.KelasToolStripMenuItem.Name = "KelasToolStripMenuItem"
        Me.KelasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.KelasToolStripMenuItem.Text = "Kelas..."
        '
        'GugusdepanToolStripMenuItem
        '
        Me.GugusdepanToolStripMenuItem.Name = "GugusdepanToolStripMenuItem"
        Me.GugusdepanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GugusdepanToolStripMenuItem.Text = "Gugusdepan..."
        '
        'AmbalanToolStripMenuItem
        '
        Me.AmbalanToolStripMenuItem.Name = "AmbalanToolStripMenuItem"
        Me.AmbalanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AmbalanToolStripMenuItem.Text = "Ambalan..."
        '
        'PembinaPramukaToolStripMenuItem
        '
        Me.PembinaPramukaToolStripMenuItem.Name = "PembinaPramukaToolStripMenuItem"
        Me.PembinaPramukaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PembinaPramukaToolStripMenuItem.Text = "Pembina Pramuka..."
        '
        'PesertaDidikToolStripMenuItem
        '
        Me.PesertaDidikToolStripMenuItem.Name = "PesertaDidikToolStripMenuItem"
        Me.PesertaDidikToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PesertaDidikToolStripMenuItem.Text = "Peserta didik..."
        '
        'SKUDanSKKToolStripMenuItem
        '
        Me.SKUDanSKKToolStripMenuItem.Name = "SKUDanSKKToolStripMenuItem"
        Me.SKUDanSKKToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SKUDanSKKToolStripMenuItem.Text = "SKU dan SKK..."
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
        'TransaksionalToolStripMenuItem
        '
        Me.TransaksionalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KegiatanToolStripMenuItem, Me.KehadiranToolStripMenuItem, Me.KasusToolStripMenuItem})
        Me.TransaksionalToolStripMenuItem.Name = "TransaksionalToolStripMenuItem"
        Me.TransaksionalToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.TransaksionalToolStripMenuItem.Text = "Transaksional"
        '
        'KegiatanToolStripMenuItem
        '
        Me.KegiatanToolStripMenuItem.Name = "KegiatanToolStripMenuItem"
        Me.KegiatanToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.KegiatanToolStripMenuItem.Text = "Kelola kegiatan..."
        '
        'KehadiranToolStripMenuItem
        '
        Me.KehadiranToolStripMenuItem.Name = "KehadiranToolStripMenuItem"
        Me.KehadiranToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.KehadiranToolStripMenuItem.Text = "Kelola kehadiran peserta didik..."
        '
        'KasusToolStripMenuItem
        '
        Me.KasusToolStripMenuItem.Name = "KasusToolStripMenuItem"
        Me.KasusToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.KasusToolStripMenuItem.Text = "Kelola kasus peserta didik..."
        '
        'PengolahanDataToolStripMenuItem
        '
        Me.PengolahanDataToolStripMenuItem.Name = "PengolahanDataToolStripMenuItem"
        Me.PengolahanDataToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.PengolahanDataToolStripMenuItem.Text = "Olah Data"
        '
        'PenyusunanLaporanToolStripMenuItem
        '
        Me.PenyusunanLaporanToolStripMenuItem.Name = "PenyusunanLaporanToolStripMenuItem"
        Me.PenyusunanLaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.PenyusunanLaporanToolStripMenuItem.Text = "Laporan"
        '
        'BantuanToolStripMenuItem
        '
        Me.BantuanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TentangAplikasiToolStripMenuItem})
        Me.BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        Me.BantuanToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.BantuanToolStripMenuItem.Text = "Bantuan"
        '
        'TentangAplikasiToolStripMenuItem
        '
        Me.TentangAplikasiToolStripMenuItem.Name = "TentangAplikasiToolStripMenuItem"
        Me.TentangAplikasiToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.TentangAplikasiToolStripMenuItem.Text = "Tentang aplikasi"
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
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuatDatabaseBaruToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BukaDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TutupDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpanDatabaseSebagaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BackupDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BersihkanDataSemesterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BersihkanDataTahunanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KeluarAplikasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sstMain As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AturAutentikasiPenggunaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataIndukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KelasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GugusdepanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AmbalanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PembinaPramukaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PesertaDidikToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SKUDanSKKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksionalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KegiatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KehadiranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KasusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengolahanDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenyusunanLaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TentangAplikasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
