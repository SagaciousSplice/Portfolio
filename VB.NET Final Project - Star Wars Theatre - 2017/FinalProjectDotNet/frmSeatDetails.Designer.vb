<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSeatDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSeatDetails = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancelReservation = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.lblTrooperId = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.txtTrooperId = New System.Windows.Forms.TextBox()
        Me.lblSeatNo = New System.Windows.Forms.Label()
        Me.lblSeatNoOut = New System.Windows.Forms.Label()
        Me.lblShowTime = New System.Windows.Forms.Label()
        Me.lblShowTimeOut = New System.Windows.Forms.Label()
        Me.lblPaidReserved = New System.Windows.Forms.Label()
        Me.cboPaidStatus = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTitleOut = New System.Windows.Forms.Label()
        Me.lblTrooperIdOut = New System.Windows.Forms.Label()
        Me.lblPaidOut = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.FinalProjectDotNet.My.Resources.Resources.thumb_1920_35223
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(156, 191)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 157)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblSeatDetails
        '
        Me.lblSeatDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblSeatDetails.Font = New System.Drawing.Font("Arial", 30.0!)
        Me.lblSeatDetails.ForeColor = System.Drawing.Color.White
        Me.lblSeatDetails.Location = New System.Drawing.Point(74, 9)
        Me.lblSeatDetails.Name = "lblSeatDetails"
        Me.lblSeatDetails.Size = New System.Drawing.Size(232, 43)
        Me.lblSeatDetails.TabIndex = 1
        Me.lblSeatDetails.Text = "Seat Details"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(3, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(85, 23)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancelReservation
        '
        Me.btnCancelReservation.Location = New System.Drawing.Point(94, 3)
        Me.btnCancelReservation.Name = "btnCancelReservation"
        Me.btnCancelReservation.Size = New System.Drawing.Size(111, 23)
        Me.btnCancelReservation.TabIndex = 2
        Me.btnCancelReservation.Text = "Cancel Reservation"
        Me.btnCancelReservation.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(237, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(59, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.Transparent
        Me.pnlButtons.Controls.Add(Me.btnCancel)
        Me.pnlButtons.Controls.Add(Me.btnCancelReservation)
        Me.pnlButtons.Controls.Add(Me.btnUpdate)
        Me.pnlButtons.ForeColor = System.Drawing.Color.Black
        Me.pnlButtons.Location = New System.Drawing.Point(12, 351)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(316, 30)
        Me.pnlButtons.TabIndex = 3
        '
        'lblTrooperId
        '
        Me.lblTrooperId.AutoSize = True
        Me.lblTrooperId.BackColor = System.Drawing.Color.Transparent
        Me.lblTrooperId.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblTrooperId.ForeColor = System.Drawing.Color.White
        Me.lblTrooperId.Location = New System.Drawing.Point(19, 244)
        Me.lblTrooperId.Name = "lblTrooperId"
        Me.lblTrooperId.Size = New System.Drawing.Size(79, 16)
        Me.lblTrooperId.TabIndex = 4
        Me.lblTrooperId.Text = "Trooper ID:"
        '
        'lblInstructions
        '
        Me.lblInstructions.BackColor = System.Drawing.Color.Transparent
        Me.lblInstructions.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblInstructions.ForeColor = System.Drawing.Color.White
        Me.lblInstructions.Location = New System.Drawing.Point(15, 56)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(348, 61)
        Me.lblInstructions.TabIndex = 4
        '
        'txtTrooperId
        '
        Me.txtTrooperId.Location = New System.Drawing.Point(133, 242)
        Me.txtTrooperId.Name = "txtTrooperId"
        Me.txtTrooperId.Size = New System.Drawing.Size(100, 20)
        Me.txtTrooperId.TabIndex = 5
        '
        'lblSeatNo
        '
        Me.lblSeatNo.AutoSize = True
        Me.lblSeatNo.BackColor = System.Drawing.Color.Transparent
        Me.lblSeatNo.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblSeatNo.ForeColor = System.Drawing.Color.White
        Me.lblSeatNo.Location = New System.Drawing.Point(19, 124)
        Me.lblSeatNo.Name = "lblSeatNo"
        Me.lblSeatNo.Size = New System.Drawing.Size(94, 16)
        Me.lblSeatNo.TabIndex = 4
        Me.lblSeatNo.Text = "Seat Number:"
        '
        'lblSeatNoOut
        '
        Me.lblSeatNoOut.BackColor = System.Drawing.Color.Transparent
        Me.lblSeatNoOut.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblSeatNoOut.ForeColor = System.Drawing.Color.White
        Me.lblSeatNoOut.Location = New System.Drawing.Point(133, 124)
        Me.lblSeatNoOut.Name = "lblSeatNoOut"
        Me.lblSeatNoOut.Size = New System.Drawing.Size(94, 16)
        Me.lblSeatNoOut.TabIndex = 4
        '
        'lblShowTime
        '
        Me.lblShowTime.AutoSize = True
        Me.lblShowTime.BackColor = System.Drawing.Color.Transparent
        Me.lblShowTime.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblShowTime.ForeColor = System.Drawing.Color.White
        Me.lblShowTime.Location = New System.Drawing.Point(19, 204)
        Me.lblShowTime.Name = "lblShowTime"
        Me.lblShowTime.Size = New System.Drawing.Size(80, 16)
        Me.lblShowTime.TabIndex = 4
        Me.lblShowTime.Text = "Show Time:"
        '
        'lblShowTimeOut
        '
        Me.lblShowTimeOut.BackColor = System.Drawing.Color.Transparent
        Me.lblShowTimeOut.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblShowTimeOut.ForeColor = System.Drawing.Color.White
        Me.lblShowTimeOut.Location = New System.Drawing.Point(133, 204)
        Me.lblShowTimeOut.Name = "lblShowTimeOut"
        Me.lblShowTimeOut.Size = New System.Drawing.Size(230, 16)
        Me.lblShowTimeOut.TabIndex = 4
        '
        'lblPaidReserved
        '
        Me.lblPaidReserved.AutoSize = True
        Me.lblPaidReserved.BackColor = System.Drawing.Color.Transparent
        Me.lblPaidReserved.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblPaidReserved.ForeColor = System.Drawing.Color.White
        Me.lblPaidReserved.Location = New System.Drawing.Point(19, 284)
        Me.lblPaidReserved.Name = "lblPaidReserved"
        Me.lblPaidReserved.Size = New System.Drawing.Size(105, 16)
        Me.lblPaidReserved.TabIndex = 4
        Me.lblPaidReserved.Text = "Paid/Reserved:"
        '
        'cboPaidStatus
        '
        Me.cboPaidStatus.FormattingEnabled = True
        Me.cboPaidStatus.Items.AddRange(New Object() {"Reserved", "Paid"})
        Me.cboPaidStatus.Location = New System.Drawing.Point(133, 282)
        Me.cboPaidStatus.Name = "cboPaidStatus"
        Me.cboPaidStatus.Size = New System.Drawing.Size(121, 21)
        Me.cboPaidStatus.TabIndex = 6
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(19, 164)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(38, 16)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Title:"
        '
        'lblTitleOut
        '
        Me.lblTitleOut.BackColor = System.Drawing.Color.Transparent
        Me.lblTitleOut.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblTitleOut.ForeColor = System.Drawing.Color.White
        Me.lblTitleOut.Location = New System.Drawing.Point(133, 164)
        Me.lblTitleOut.Name = "lblTitleOut"
        Me.lblTitleOut.Size = New System.Drawing.Size(230, 16)
        Me.lblTitleOut.TabIndex = 4
        '
        'lblTrooperIdOut
        '
        Me.lblTrooperIdOut.BackColor = System.Drawing.Color.Transparent
        Me.lblTrooperIdOut.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblTrooperIdOut.ForeColor = System.Drawing.Color.White
        Me.lblTrooperIdOut.Location = New System.Drawing.Point(130, 242)
        Me.lblTrooperIdOut.Name = "lblTrooperIdOut"
        Me.lblTrooperIdOut.Size = New System.Drawing.Size(100, 20)
        Me.lblTrooperIdOut.TabIndex = 4
        Me.lblTrooperIdOut.Text = "Trooper ID:"
        '
        'lblPaidOut
        '
        Me.lblPaidOut.BackColor = System.Drawing.Color.Transparent
        Me.lblPaidOut.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblPaidOut.ForeColor = System.Drawing.Color.White
        Me.lblPaidOut.Location = New System.Drawing.Point(133, 283)
        Me.lblPaidOut.Name = "lblPaidOut"
        Me.lblPaidOut.Size = New System.Drawing.Size(100, 20)
        Me.lblPaidOut.TabIndex = 4
        Me.lblPaidOut.Text = "Trooper ID:"
        '
        'frmSeatDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(375, 394)
        Me.Controls.Add(Me.cboPaidStatus)
        Me.Controls.Add(Me.txtTrooperId)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblTitleOut)
        Me.Controls.Add(Me.lblShowTimeOut)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblShowTime)
        Me.Controls.Add(Me.lblSeatNoOut)
        Me.Controls.Add(Me.lblSeatNo)
        Me.Controls.Add(Me.lblPaidReserved)
        Me.Controls.Add(Me.lblPaidOut)
        Me.Controls.Add(Me.lblTrooperIdOut)
        Me.Controls.Add(Me.lblTrooperId)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.lblSeatDetails)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmSeatDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSeatDetails"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblSeatDetails As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancelReservation As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents lblTrooperId As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents txtTrooperId As TextBox
    Friend WithEvents lblSeatNo As Label
    Friend WithEvents lblSeatNoOut As Label
    Friend WithEvents lblShowTime As Label
    Friend WithEvents lblShowTimeOut As Label
    Friend WithEvents lblPaidReserved As Label
    Friend WithEvents cboPaidStatus As ComboBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTitleOut As Label
    Friend WithEvents lblTrooperIdOut As Label
    Friend WithEvents lblPaidOut As Label
End Class
