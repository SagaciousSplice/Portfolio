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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cboTitleSelection = New System.Windows.Forms.ComboBox()
        Me.dgvShowings = New System.Windows.Forms.DataGridView()
        Me.lblMainFormHeader = New System.Windows.Forms.Label()
        Me.lblMainFrmInstr = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSelectionInst = New System.Windows.Forms.Label()
        Me.btnViewSeating = New System.Windows.Forms.Button()
        Me.pnlButtonMain = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateShowingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PosterGalleryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpireArtworkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFilmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvShowings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlButtonMain.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboTitleSelection
        '
        Me.cboTitleSelection.FormattingEnabled = True
        Me.cboTitleSelection.Location = New System.Drawing.Point(75, 149)
        Me.cboTitleSelection.Name = "cboTitleSelection"
        Me.cboTitleSelection.Size = New System.Drawing.Size(267, 21)
        Me.cboTitleSelection.TabIndex = 0
        '
        'dgvShowings
        '
        Me.dgvShowings.AllowUserToAddRows = False
        Me.dgvShowings.AllowUserToDeleteRows = False
        Me.dgvShowings.AllowUserToResizeColumns = False
        Me.dgvShowings.AllowUserToResizeRows = False
        Me.dgvShowings.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvShowings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvShowings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowings.Location = New System.Drawing.Point(19, 176)
        Me.dgvShowings.Name = "dgvShowings"
        Me.dgvShowings.ReadOnly = True
        Me.dgvShowings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShowings.Size = New System.Drawing.Size(323, 178)
        Me.dgvShowings.TabIndex = 1
        '
        'lblMainFormHeader
        '
        Me.lblMainFormHeader.AutoSize = True
        Me.lblMainFormHeader.Font = New System.Drawing.Font("Impact", 35.0!)
        Me.lblMainFormHeader.ForeColor = System.Drawing.Color.White
        Me.lblMainFormHeader.Location = New System.Drawing.Point(8, 27)
        Me.lblMainFormHeader.Name = "lblMainFormHeader"
        Me.lblMainFormHeader.Size = New System.Drawing.Size(337, 59)
        Me.lblMainFormHeader.TabIndex = 2
        Me.lblMainFormHeader.Text = "Movie Showings"
        Me.lblMainFormHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMainFrmInstr
        '
        Me.lblMainFrmInstr.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblMainFrmInstr.ForeColor = System.Drawing.Color.White
        Me.lblMainFrmInstr.Location = New System.Drawing.Point(19, 99)
        Me.lblMainFrmInstr.Name = "lblMainFrmInstr"
        Me.lblMainFrmInstr.Size = New System.Drawing.Size(323, 41)
        Me.lblMainFrmInstr.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(22, 149)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(47, 21)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Title:"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSelectionInst
        '
        Me.lblSelectionInst.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblSelectionInst.ForeColor = System.Drawing.Color.White
        Me.lblSelectionInst.Location = New System.Drawing.Point(16, 366)
        Me.lblSelectionInst.Name = "lblSelectionInst"
        Me.lblSelectionInst.Size = New System.Drawing.Size(363, 41)
        Me.lblSelectionInst.TabIndex = 3
        '
        'btnViewSeating
        '
        Me.btnViewSeating.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnViewSeating.Location = New System.Drawing.Point(92, 22)
        Me.btnViewSeating.Name = "btnViewSeating"
        Me.btnViewSeating.Size = New System.Drawing.Size(111, 31)
        Me.btnViewSeating.TabIndex = 5
        Me.btnViewSeating.Text = "View Seating"
        Me.btnViewSeating.UseVisualStyleBackColor = True
        '
        'pnlButtonMain
        '
        Me.pnlButtonMain.Controls.Add(Me.btnExit)
        Me.pnlButtonMain.Controls.Add(Me.btnViewSeating)
        Me.pnlButtonMain.Location = New System.Drawing.Point(25, 410)
        Me.pnlButtonMain.Name = "pnlButtonMain"
        Me.pnlButtonMain.Size = New System.Drawing.Size(569, 64)
        Me.pnlButtonMain.TabIndex = 6
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnExit.Location = New System.Drawing.Point(455, 22)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 31)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ExtrasToolStripMenuItem, Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(606, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddFilmToolStripMenuItem, Me.UpdateShowingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'UpdateShowingsToolStripMenuItem
        '
        Me.UpdateShowingsToolStripMenuItem.Name = "UpdateShowingsToolStripMenuItem"
        Me.UpdateShowingsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.UpdateShowingsToolStripMenuItem.Text = "Update Showings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ExtrasToolStripMenuItem
        '
        Me.ExtrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PosterGalleryToolStripMenuItem, Me.EmpireArtworkToolStripMenuItem})
        Me.ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem"
        Me.ExtrasToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ExtrasToolStripMenuItem.Text = "Extras"
        '
        'PosterGalleryToolStripMenuItem
        '
        Me.PosterGalleryToolStripMenuItem.Name = "PosterGalleryToolStripMenuItem"
        Me.PosterGalleryToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.PosterGalleryToolStripMenuItem.Text = "Poster Gallery"
        '
        'EmpireArtworkToolStripMenuItem
        '
        Me.EmpireArtworkToolStripMenuItem.Name = "EmpireArtworkToolStripMenuItem"
        Me.EmpireArtworkToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.EmpireArtworkToolStripMenuItem.Text = "Empire Artwork"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AddFilmToolStripMenuItem
        '
        Me.AddFilmToolStripMenuItem.Name = "AddFilmToolStripMenuItem"
        Me.AddFilmToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AddFilmToolStripMenuItem.Text = "Add Film"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnViewSeating
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.FinalProjectDotNet.My.Resources.Resources.deathstar
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(606, 478)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlButtonMain)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblSelectionInst)
        Me.Controls.Add(Me.lblMainFrmInstr)
        Me.Controls.Add(Me.lblMainFormHeader)
        Me.Controls.Add(Me.dgvShowings)
        Me.Controls.Add(Me.cboTitleSelection)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movie Showings"
        CType(Me.dgvShowings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtonMain.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboTitleSelection As ComboBox
    Friend WithEvents dgvShowings As DataGridView
    Friend WithEvents lblMainFormHeader As Label
    Friend WithEvents lblMainFrmInstr As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSelectionInst As Label
    Friend WithEvents btnViewSeating As Button
    Friend WithEvents pnlButtonMain As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExtrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PosterGalleryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpireArtworkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateShowingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddFilmToolStripMenuItem As ToolStripMenuItem
End Class
