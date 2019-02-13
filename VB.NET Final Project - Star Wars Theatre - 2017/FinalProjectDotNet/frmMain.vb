Public Class frmMain

    Dim capacity As Integer

#Region "<-- Parameterized Constructor -->"
    Public Sub New(screeningCapacity As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        capacity = screeningCapacity

    End Sub
#End Region

#Region "<-- cboTitleSelection Change Event -->"
    Private Sub cboTitleSelection_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboTitleSelection.SelectedValueChanged

        Call populateShowingsByTitle()

    End Sub
#End Region

#Region "<-- frmMain Load Event -->"
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.lblMainFrmInstr.Text = "Please selected a movie from the dropdown list to see its scheduled screenings."
        Me.lblSelectionInst.Text = "To view available seats, select from the list and press the View Seating button."

        'Make buttons transparent
        Call makeButtonsTransparent()

        Call populateTitleSelection()

        Call populateShowingsByTitle()

    End Sub
#End Region

#Region "<-- populateTitleSelection() -->"
    Public Sub populateTitleSelection()

        Me.cboTitleSelection.DataSource = Nothing
        Me.cboTitleSelection.ValueMember = "movieID"
        Me.cboTitleSelection.DisplayMember = "movieName"
        Me.cboTitleSelection.DataSource = DBL.Tables.datMovies.getAllRows()
        Me.cboTitleSelection.SelectedItem = "A New Hope"
        Me.cboTitleSelection.SelectedIndex = 1

    End Sub
#End Region

#Region "<-- populateShowingsByTitle() -->"
    Public Sub populateShowingsByTitle()

        Me.dgvShowings.DataSource = Nothing
        Me.dgvShowings.DataSource = DBL.Views.Showings.getShowingsByTitle(CInt(Me.cboTitleSelection.SelectedValue))

        'Hide unwanted columns
        Me.dgvShowings.RowHeadersVisible = False
        Me.dgvShowings.Columns("movieID").Visible = False
        Me.dgvShowings.Columns("isActive").Visible = False

        'size columns
        Dim column As DataGridViewColumn = dgvShowings.Columns(0)
        column.Width = 60
        column.HeaderCell.Value = "Showing"

        Dim column2 As DataGridViewColumn = dgvShowings.Columns(2)
        column2.Width = 130
        column2.HeaderCell.Value = "Movie Title"

        Dim column3 As DataGridViewColumn = dgvShowings.Columns(3)
        column3.Width = 130
        column3.HeaderCell.Value = "Show Time"

    End Sub
#End Region

#Region "<-- btnViewSeating Click Event"
    Private Sub btnViewSeating_Click(sender As Object, e As EventArgs) Handles btnViewSeating.Click
        'CInt(Me.dgvEnemies.SelectedRows(0).Cells(0).Value.ToString)
        Dim frmSeating As New frmSeating(capacity, CInt(Me.dgvShowings.SelectedRows(0).Cells(0).Value))
        frmSeating.Show()

    End Sub
#End Region

#Region "<-- btnExit Click Event -->"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        confirmClose()
    End Sub
#End Region

#Region "<-- Exit Menu Item Click Event -->"
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        confirmClose()
    End Sub
#End Region

#Region "<-- confirmClose() -->"
    Private Sub confirmClose()

        'Confirm that user wants to close the form
        Dim userResponse As DialogResult = MessageBox.Show("Are you sure you want to exit the program?",
                                                           "Confirm Closure",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Question,
                                                           MessageBoxDefaultButton.Button2)
        'If user confirms to close
        If userResponse = DialogResult.Yes Then
            frmCapacity.Close()
        End If
    End Sub

    Private Sub PosterGalleryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PosterGalleryToolStripMenuItem.Click
        frmPosterGallery.Show()
    End Sub
#End Region

#Region "<-- makeButtonsTransparent() -->"
    Private Sub makeButtonsTransparent()
        For Each button As Button In Me.pnlButtonMain.Controls
            button.FlatStyle = FlatStyle.Flat
            button.FlatAppearance.BorderSize = 1
            button.FlatAppearance.MouseDownBackColor = Color.Transparent
            button.FlatAppearance.MouseOverBackColor = Color.Transparent
            button.BackColor = Color.Transparent
            button.ForeColor = Color.White
        Next
    End Sub


#End Region

#Region "<-- Add Film Menu Item Click Event -->"
    Private Sub AddFilmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFilmToolStripMenuItem.Click

        Dim frmNewfilm As New frmNewFilm(Me)
        frmNewfilm.Show()

    End Sub
#End Region

#Region "<-- Update Showings Menu Click Event -->"
    Private Sub UpdateShowingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateShowingsToolStripMenuItem.Click
        Dim frmUpdateShowings As New frmUpdateShowings(Me)
        frmUpdateShowings.Show()
    End Sub
#End Region


End Class

