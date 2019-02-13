<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeShowing
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
        Me.lblNewDateTime = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.lblFormatExample = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNewDateTime
        '
        Me.lblNewDateTime.AutoSize = True
        Me.lblNewDateTime.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblNewDateTime.ForeColor = System.Drawing.Color.White
        Me.lblNewDateTime.Location = New System.Drawing.Point(13, 46)
        Me.lblNewDateTime.Name = "lblNewDateTime"
        Me.lblNewDateTime.Size = New System.Drawing.Size(134, 16)
        Me.lblNewDateTime.TabIndex = 0
        Me.lblNewDateTime.Text = "New Date and Time:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.MaskedTextBox1.ForeColor = System.Drawing.Color.Black
        Me.MaskedTextBox1.Location = New System.Drawing.Point(153, 43)
        Me.MaskedTextBox1.Mask = "0000/00/00 90:00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(128, 23)
        Me.MaskedTextBox1.TabIndex = 1
        '
        'lblFormatExample
        '
        Me.lblFormatExample.AutoSize = True
        Me.lblFormatExample.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblFormatExample.ForeColor = System.Drawing.Color.White
        Me.lblFormatExample.Location = New System.Drawing.Point(156, 69)
        Me.lblFormatExample.Name = "lblFormatExample"
        Me.lblFormatExample.Size = New System.Drawing.Size(122, 16)
        Me.lblFormatExample.TabIndex = 0
        Me.lblFormatExample.Text = "yyyy/mm/dd hr:mn"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(290, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter the new date and time of the showing:"
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(19, 96)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 3
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(231, 96)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(19, 96)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmChangeShowing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(321, 131)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.lblFormatExample)
        Me.Controls.Add(Me.lblNewDateTime)
        Me.Name = "frmChangeShowing"
        Me.Text = "frmChangeShowing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNewDateTime As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents lblFormatExample As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnChange As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
End Class
