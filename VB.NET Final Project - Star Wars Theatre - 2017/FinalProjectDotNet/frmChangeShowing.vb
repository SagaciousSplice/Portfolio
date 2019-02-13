Public Class frmChangeShowing

#Region "<-- Public Variables"
    Dim myParentForm As frmUpdateShowings
    Dim showingID As Integer
#End Region

#Region "<-- Constructor -->"
    Public Sub New(showing As Integer, parentForm As frmUpdateShowings)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        myParentForm = parentForm
        showingID = showing

        btnAdd.Visible = False
        btnChange.Visible = True

    End Sub

    Public Sub New(showing As Integer, addingNew As Boolean, parentForm As frmUpdateShowings)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        myParentForm = parentForm
        showingID = showing

        btnAdd.Visible = True
        btnChange.Visible = False

    End Sub

#End Region

#Region "<-- btnChange Click Event -->"
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        Call updateTime()

    End Sub
#End Region

#Region "<-- updateTime() -->"
    Private Sub updateTime()
        Try
            If DBL.Tables.datMovieTimes.isValidShowtime(Me.MaskedTextBox1.Text) Then
                MsgBox("That showing is available")

                Dim currentRecord As New DBL.Tables.datMovieTimes

                currentRecord.showingID = showingID
                currentRecord.movieID = DBL.Tables.datMovieTimes.getOneRow(showingID).movieID
                currentRecord.dateTime = CDate(Me.MaskedTextBox1.Text)
                currentRecord.isActive = DBL.Tables.datMovieTimes.getOneRow(showingID).isActive

                If DBL.Tables.datMovieTimes.updateExistingRow(currentRecord) Then

                    MsgBox("Showtime successfully updated")
                    Call myParentForm.populateShowtimes()
                    Me.Close()

                Else
                    MsgBox("Showtime NOT successfully updated")

                End If

            Else
                MsgBox("That time is already taken")
            End If


        Catch ex As Exception

            Console.WriteLine("Error in updateTime()")
            Console.WriteLine(Err.Description)

        End Try
    End Sub
#End Region

#Region "<-- btnAdd Click Event -->"
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Call addShowtime()

    End Sub
#End Region

#Region "<-- addShowtime() -->"
    Private Sub addShowtime()
        Try
            If DBL.Tables.datMovieTimes.isValidShowtime(Me.MaskedTextBox1.Text) Then
                MsgBox("That showing is available")

                Dim currentRecord As New DBL.Tables.datMovieTimes

                currentRecord.showingID = showingID
                currentRecord.movieID = DBL.Tables.datMovieTimes.getOneRow(showingID).movieID
                currentRecord.dateTime = CDate(Me.MaskedTextBox1.Text)
                currentRecord.isActive = DBL.Tables.datMovieTimes.getOneRow(showingID).isActive

                If DBL.Tables.datMovieTimes.insertNewRow(currentRecord) <> 0 Then

                    MsgBox("Showtime successfully updated")
                    Call myParentForm.populateShowtimes()
                    Me.Close()

                Else
                    MsgBox("Showtime NOT successfully updated")

                End If

            Else
                MsgBox("That time is already taken")
            End If


        Catch ex As Exception

            Console.WriteLine("Error in updateTime()")
            Console.WriteLine(Err.Description)

        End Try
    End Sub
#End Region

End Class