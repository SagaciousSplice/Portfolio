Public Class frmPosterGallery

    Dim i As Integer = 1

#Region "<-- frmPosterGallery Load Event -->"
    Private Sub frmPosterGallery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region

#Region "<-- Timer On Event -->"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'if in range of number of posters
        If i <= 9 Then
            Me.PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject("Poster" & i), Image)
            'go to posters
            i += 1
        End If

        'otherwise go back to 1
        If i > 9 Then
            i = 1
        End If

    End Sub
#End Region

#Region "<-- tsbOn Click Event -->"
    Private Sub tsbOn_Click(sender As Object, e As EventArgs) Handles tsbOn.Click

        Me.Timer1.Start()

    End Sub
#End Region

#Region "<-- Speed Change Event -->"
    Private Sub tscSpeed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscSpeed.SelectedIndexChanged

        If tscSpeed.Text = "Slow" Then
            Timer1.Interval = 3000
        ElseIf tscSpeed.Text = "Fast" Then
            Timer1.Interval = 1500

        End If
    End Sub
#End Region

#Region "<-- tsbOff Click Event -->"
    Private Sub tsbOff_Click(sender As Object, e As EventArgs) Handles tsbOff.Click
        Timer1.Stop()
    End Sub
#End Region

#Region "<-- btnClose Click Event -->"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'Stop the music before closing
        My.Computer.Audio.Stop()
        Me.Close()
    End Sub
#End Region

#Region "<-- ckbPlayMusic Check Event -->"
    Private Sub chbPlayMusic_CheckedChanged(sender As Object, e As EventArgs) Handles chbPlayMusic.CheckedChanged

        'Play music if box checked
        If Me.chbPlayMusic.Checked Then
            My.Computer.Audio.Play(My.Resources.imperial_march, AudioPlayMode.BackgroundLoop)
        End If

        'End music playback if box is unchecked
        If Me.chbPlayMusic.Checked = False Then
            My.Computer.Audio.Stop()
        End If

    End Sub

#End Region

End Class