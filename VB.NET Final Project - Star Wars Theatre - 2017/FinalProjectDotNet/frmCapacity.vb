Public Class frmCapacity
    Private Sub frmCapacity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDone.FlatStyle = FlatStyle.Flat
        btnDone.FlatAppearance.BorderSize = 1
        btnDone.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnDone.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnDone.BackColor = Color.Transparent
        btnDone.ForeColor = Color.White
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click

        Dim frmMain As New frmMain(CInt(Me.NumericUpDown1.Value))
        frmMain.Show()
        Me.Hide()

    End Sub
End Class