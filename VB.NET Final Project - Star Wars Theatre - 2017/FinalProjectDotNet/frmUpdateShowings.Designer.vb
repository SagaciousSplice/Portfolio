<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateShowings
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
        Me.cboTitles = New System.Windows.Forms.ComboBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCurrentTimes = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddShow = New System.Windows.Forms.Button()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnEditTime = New System.Windows.Forms.Button()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboTitles
        '
        Me.cboTitles.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cboTitles.FormattingEnabled = True
        Me.cboTitles.Location = New System.Drawing.Point(35, 123)
        Me.cboTitles.Name = "cboTitles"
        Me.cboTitles.Size = New System.Drawing.Size(262, 24)
        Me.cboTitles.TabIndex = 0
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblInstructions.ForeColor = System.Drawing.Color.White
        Me.lblInstructions.Location = New System.Drawing.Point(32, 83)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(266, 37)
        Me.lblInstructions.TabIndex = 1
        Me.lblInstructions.Text = "Select the movie you would like to edit show times for:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select the showtime you would like to edit:"
        '
        'cboCurrentTimes
        '
        Me.cboCurrentTimes.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cboCurrentTimes.FormattingEnabled = True
        Me.cboCurrentTimes.Location = New System.Drawing.Point(35, 197)
        Me.cboCurrentTimes.Name = "cboCurrentTimes"
        Me.cboCurrentTimes.Size = New System.Drawing.Size(262, 24)
        Me.cboCurrentTimes.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Impact", 30.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(306, 54)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Edit Showtimes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(203, 15)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddShow
        '
        Me.btnAddShow.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnAddShow.ForeColor = System.Drawing.Color.White
        Me.btnAddShow.Location = New System.Drawing.Point(102, 15)
        Me.btnAddShow.Name = "btnAddShow"
        Me.btnAddShow.Size = New System.Drawing.Size(90, 23)
        Me.btnAddShow.TabIndex = 2
        Me.btnAddShow.Text = "Add A Time"
        Me.btnAddShow.UseVisualStyleBackColor = True
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnEditTime)
        Me.pnlButtons.Controls.Add(Me.btnCancel)
        Me.pnlButtons.Controls.Add(Me.btnAddShow)
        Me.pnlButtons.Location = New System.Drawing.Point(21, 227)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(298, 56)
        Me.pnlButtons.TabIndex = 5
        '
        'btnEditTime
        '
        Me.btnEditTime.Location = New System.Drawing.Point(6, 15)
        Me.btnEditTime.Name = "btnEditTime"
        Me.btnEditTime.Size = New System.Drawing.Size(90, 23)
        Me.btnEditTime.TabIndex = 4
        Me.btnEditTime.Text = "Edit Time"
        Me.btnEditTime.UseVisualStyleBackColor = True
        '
        'frmUpdateShowings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(331, 297)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.cboCurrentTimes)
        Me.Controls.Add(Me.cboTitles)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "frmUpdateShowings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUpdateShowings"
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboTitles As ComboBox
    Friend WithEvents lblInstructions As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboCurrentTimes As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAddShow As Button
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnEditTime As Button
End Class
