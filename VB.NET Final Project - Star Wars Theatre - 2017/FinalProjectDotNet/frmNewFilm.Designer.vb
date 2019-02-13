<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewFilm
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
        Me.lblFilmName = New System.Windows.Forms.Label()
        Me.txtFilmName = New System.Windows.Forms.TextBox()
        Me.lblFilmNumber = New System.Windows.Forms.Label()
        Me.nubFilmNumber = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddFilm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlButtonsNew = New System.Windows.Forms.Panel()
        CType(Me.nubFilmNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlButtonsNew.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFilmName
        '
        Me.lblFilmName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblFilmName.ForeColor = System.Drawing.Color.White
        Me.lblFilmName.Location = New System.Drawing.Point(19, 91)
        Me.lblFilmName.Name = "lblFilmName"
        Me.lblFilmName.Size = New System.Drawing.Size(100, 23)
        Me.lblFilmName.TabIndex = 0
        Me.lblFilmName.Text = "Film Name:"
        '
        'txtFilmName
        '
        Me.txtFilmName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtFilmName.ForeColor = System.Drawing.Color.Black
        Me.txtFilmName.Location = New System.Drawing.Point(125, 91)
        Me.txtFilmName.Name = "txtFilmName"
        Me.txtFilmName.Size = New System.Drawing.Size(287, 23)
        Me.txtFilmName.TabIndex = 1
        '
        'lblFilmNumber
        '
        Me.lblFilmNumber.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblFilmNumber.ForeColor = System.Drawing.Color.White
        Me.lblFilmNumber.Location = New System.Drawing.Point(19, 134)
        Me.lblFilmNumber.Name = "lblFilmNumber"
        Me.lblFilmNumber.Size = New System.Drawing.Size(100, 23)
        Me.lblFilmNumber.TabIndex = 0
        Me.lblFilmNumber.Text = "Film Number:"
        '
        'nubFilmNumber
        '
        Me.nubFilmNumber.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.nubFilmNumber.ForeColor = System.Drawing.Color.Black
        Me.nubFilmNumber.Location = New System.Drawing.Point(125, 134)
        Me.nubFilmNumber.Name = "nubFilmNumber"
        Me.nubFilmNumber.Size = New System.Drawing.Size(120, 23)
        Me.nubFilmNumber.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Impact", 40.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(438, 63)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Add a New Film"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddFilm
        '
        Me.btnAddFilm.Location = New System.Drawing.Point(28, 20)
        Me.btnAddFilm.Name = "btnAddFilm"
        Me.btnAddFilm.Size = New System.Drawing.Size(75, 23)
        Me.btnAddFilm.TabIndex = 4
        Me.btnAddFilm.Text = "Add Film"
        Me.btnAddFilm.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(212, 19)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'pnlButtonsNew
        '
        Me.pnlButtonsNew.Controls.Add(Me.btnCancel)
        Me.pnlButtonsNew.Controls.Add(Me.btnAddFilm)
        Me.pnlButtonsNew.Location = New System.Drawing.Point(45, 193)
        Me.pnlButtonsNew.Name = "pnlButtonsNew"
        Me.pnlButtonsNew.Size = New System.Drawing.Size(312, 56)
        Me.pnlButtonsNew.TabIndex = 6
        '
        'frmNewFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(456, 261)
        Me.Controls.Add(Me.pnlButtonsNew)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nubFilmNumber)
        Me.Controls.Add(Me.txtFilmName)
        Me.Controls.Add(Me.lblFilmNumber)
        Me.Controls.Add(Me.lblFilmName)
        Me.Name = "frmNewFilm"
        Me.Text = "frmNewFilm"
        CType(Me.nubFilmNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtonsNew.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFilmName As Label
    Friend WithEvents txtFilmName As TextBox
    Friend WithEvents lblFilmNumber As Label
    Friend WithEvents nubFilmNumber As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddFilm As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents pnlButtonsNew As Panel
End Class
