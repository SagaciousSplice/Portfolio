<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSeating
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAvailColor = New System.Windows.Forms.Label()
        Me.lblPaidColor = New System.Windows.Forms.Label()
        Me.lblReservColor = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gpbLegend = New System.Windows.Forms.GroupBox()
        Me.gpbLegend.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(337, 392)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAvailColor
        '
        Me.lblAvailColor.BackColor = System.Drawing.Color.Gray
        Me.lblAvailColor.Location = New System.Drawing.Point(12, 27)
        Me.lblAvailColor.Name = "lblAvailColor"
        Me.lblAvailColor.Size = New System.Drawing.Size(20, 20)
        Me.lblAvailColor.TabIndex = 2
        '
        'lblPaidColor
        '
        Me.lblPaidColor.BackColor = System.Drawing.Color.Red
        Me.lblPaidColor.Location = New System.Drawing.Point(107, 27)
        Me.lblPaidColor.Name = "lblPaidColor"
        Me.lblPaidColor.Size = New System.Drawing.Size(20, 20)
        Me.lblPaidColor.TabIndex = 2
        '
        'lblReservColor
        '
        Me.lblReservColor.BackColor = System.Drawing.Color.Blue
        Me.lblReservColor.Location = New System.Drawing.Point(177, 27)
        Me.lblReservColor.Name = "lblReservColor"
        Me.lblReservColor.Size = New System.Drawing.Size(20, 20)
        Me.lblReservColor.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(36, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Available"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(131, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Paid"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(200, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Reserved"
        '
        'gpbLegend
        '
        Me.gpbLegend.BackColor = System.Drawing.Color.Transparent
        Me.gpbLegend.Controls.Add(Me.Label7)
        Me.gpbLegend.Controls.Add(Me.Label6)
        Me.gpbLegend.Controls.Add(Me.Label5)
        Me.gpbLegend.Controls.Add(Me.lblReservColor)
        Me.gpbLegend.Controls.Add(Me.lblPaidColor)
        Me.gpbLegend.Controls.Add(Me.lblAvailColor)
        Me.gpbLegend.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.gpbLegend.ForeColor = System.Drawing.Color.White
        Me.gpbLegend.Location = New System.Drawing.Point(20, 353)
        Me.gpbLegend.Name = "gpbLegend"
        Me.gpbLegend.Size = New System.Drawing.Size(281, 62)
        Me.gpbLegend.TabIndex = 4
        Me.gpbLegend.TabStop = False
        Me.gpbLegend.Text = "Legend"
        '
        'frmSeating
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(428, 440)
        Me.ControlBox = False
        Me.Controls.Add(Me.gpbLegend)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmSeating"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSeating"
        Me.gpbLegend.ResumeLayout(False)
        Me.gpbLegend.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblAvailColor As Label
    Friend WithEvents lblPaidColor As Label
    Friend WithEvents lblReservColor As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents gpbLegend As GroupBox
End Class
