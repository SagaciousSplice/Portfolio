Public Class frmNewFilm

#Region "<-- Public Variables -->"

    Dim myParentForm As frmMain

#End Region

#Region "<-- Constructor -->"
    Public Sub New(parentForm As frmMain)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        myParentForm = parentForm

    End Sub
#End Region

#Region "<-- frmUpdate Load Event -->"
    Private Sub frmNewFilm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call makeButtonsTransparent()

        Call populateFilmNumber()

    End Sub
#End Region

#Region "<-- populateFilmNumber() -->"
    Private Sub populateFilmNumber()

        Me.nubFilmNumber.Minimum = DBL.Tables.datMovies.getLastMovieID + 1
        Me.nubFilmNumber.Value = DBL.Tables.datMovies.getLastMovieID + 1

    End Sub
#End Region

#Region "<-- makeButtonsTransparent() -->"
    Private Sub makeButtonsTransparent()
        For Each button As Button In Me.pnlButtonsNew.Controls
            button.FlatStyle = FlatStyle.Flat
            button.FlatAppearance.BorderSize = 1
            button.FlatAppearance.MouseDownBackColor = Color.Transparent
            button.FlatAppearance.MouseOverBackColor = Color.Transparent
            button.BackColor = Color.Transparent
            button.ForeColor = Color.White
        Next
    End Sub
#End Region

#Region "<-- btnCancel Click Event -->"
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
#End Region

#Region "<-- bntAddFilm Click Event -->"
    Private Sub btnAddFilm_Click(sender As Object, e As EventArgs) Handles btnAddFilm.Click

        Call updateMovieList()

    End Sub
#End Region

#Region "<-- updateMovieList() -->"
    Private Sub updateMovieList()

        Try

            Dim currentRecord As New DBL.Tables.datMovies()

            currentRecord.movieName = Me.txtFilmName.Text.Trim
            currentRecord.displayOrder = CInt(Me.nubFilmNumber.Value)
            currentRecord.isActive = True

            If DBL.Tables.datMovies.insertNewRow(currentRecord) <> 0 Then
                MsgBox("Movie has been added to our databse")
                Call populateFilmNumber()
                Me.txtFilmName.Text = ""
                Call myParentForm.populateTitleSelection()

            End If

        Catch ex As Exception

            Console.WriteLine("Error in updateMovieList")
            Console.WriteLine(Err.Description)

        End Try
    End Sub
#End Region

End Class