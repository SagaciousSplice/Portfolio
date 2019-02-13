<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPosterGallery
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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.chbPlayMusic = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbOn = New System.Windows.Forms.ToolStripButton()
        Me.tsbOff = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tscSpeed = New System.Windows.Forms.ToolStripComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Black
        Me.SplitContainer1.Panel1.Controls.Add(Me.chbPlayMusic)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnClose)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(944, 595)
        Me.SplitContainer1.SplitterDistance = 530
        Me.SplitContainer1.TabIndex = 0
        '
        'chbPlayMusic
        '
        Me.chbPlayMusic.AutoSize = True
        Me.chbPlayMusic.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.chbPlayMusic.ForeColor = System.Drawing.Color.White
        Me.chbPlayMusic.Location = New System.Drawing.Point(855, 12)
        Me.chbPlayMusic.Name = "chbPlayMusic"
        Me.chbPlayMusic.Size = New System.Drawing.Size(77, 18)
        Me.chbPlayMusic.TabIndex = 2
        Me.chbPlayMusic.Text = "Play Music"
        Me.chbPlayMusic.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.FinalProjectDotNet.My.Resources.Resources.b0a2c360786fc18c1feb10b40c732b171
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(941, 524)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(857, 26)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbOn, Me.tsbOff, Me.ToolStripButton1, Me.tscSpeed})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(944, 61)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbOn
        '
        Me.tsbOn.Image = Global.FinalProjectDotNet.My.Resources.Resources.Vader02
        Me.tsbOn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOn.Name = "tsbOn"
        Me.tsbOn.Size = New System.Drawing.Size(121, 58)
        Me.tsbOn.Text = "Play Slideshow"
        '
        'tsbOff
        '
        Me.tsbOff.Image = Global.FinalProjectDotNet.My.Resources.Resources.Vader02
        Me.tsbOff.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOff.Name = "tsbOff"
        Me.tsbOff.Size = New System.Drawing.Size(123, 58)
        Me.tsbOff.Text = "Stop Slideshow"
        Me.tsbOff.ToolTipText = "Stop Slideshow"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.FinalProjectDotNet.My.Resources.Resources.darth32
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 58)
        Me.ToolStripButton1.Text = "tsbSpeed"
        Me.ToolStripButton1.ToolTipText = "SpeedOptions"
        '
        'tscSpeed
        '
        Me.tscSpeed.Items.AddRange(New Object() {"Fast", "Slow"})
        Me.tscSpeed.Name = "tscSpeed"
        Me.tscSpeed.Size = New System.Drawing.Size(121, 61)
        Me.tscSpeed.Text = "Slow"
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'frmPosterGallery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 595)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPosterGallery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPosterGallery"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbOn As ToolStripButton
    Friend WithEvents tsbOff As ToolStripButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents tscSpeed As ToolStripComboBox
    Friend WithEvents btnClose As Button
    Friend WithEvents chbPlayMusic As CheckBox
End Class
