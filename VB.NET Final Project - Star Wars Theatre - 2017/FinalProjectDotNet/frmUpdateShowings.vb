Public Class frmUpdateShowings

#Region "<-- Public Variables"
    Dim myParentForm As frmMain
#End Region

#Region "<-- Constructor -->"
    Public Sub New(parentform As frmMain)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        myParentForm = parentform

    End Sub
#End Region

#Region "<-- frmUpdateShowings Load Event -->"
    Private Sub frmUpdateShowings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each button As Button In Me.pnlButtons.Controls
            button.FlatStyle = FlatStyle.Flat
            button.FlatAppearance.BorderSize = 1
            button.FlatAppearance.MouseDownBackColor = Color.Transparent
            button.FlatAppearance.MouseOverBackColor = Color.Transparent
            button.BackColor = Color.Transparent
            button.ForeColor = Color.White
        Next

        Call populateTitles()

    End Sub
#End Region

#Region "<-- populateTitles() -->"
    Private Sub populateTitles()


        Me.cboTitles.DataSource = Nothing
        Me.cboTitles.ValueMember = "movieID"
        Me.cboTitles.DisplayMember = "movieName"
        Me.cboTitles.DataSource = DBL.Tables.datMovies.getAllRows()
        'Me.cboTitles.SelectedItem = "A New Hope"
        Me.cboTitles.SelectedIndex = 1

    End Sub

#End Region

#Region "<-- populateShowtimes -->"
    Public Sub populateShowtimes()

        Me.cboCurrentTimes.DataSource = Nothing
        Me.cboCurrentTimes.ValueMember = "showingID"
        Me.cboCurrentTimes.DisplayMember = "dateTime"
        Me.cboCurrentTimes.DataSource = DBL.Views.Showings.getShowingsByTitle(CInt(Me.cboTitles.SelectedValue))

    End Sub
#End Region

#Region "<-- cboTitles Index Changed Event -->"
    Private Sub cboTitles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTitles.SelectedIndexChanged

        Call populateShowtimes()

    End Sub


#End Region

#Region "<-- btnCancel Click Event -->"
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Call myParentForm.populateShowingsByTitle()
        Me.Close()

    End Sub


#End Region

#Region "<-- bntEditTime Click Event -->"
    Private Sub btnEditTime_Click(sender As Object, e As EventArgs) Handles btnEditTime.Click

        Dim frmChangeShowing As New frmChangeShowing(CType(Me.cboCurrentTimes.SelectedValue.ToString, Integer), Me)
        frmChangeShowing.Show()

    End Sub

#End Region

#Region "<-- bntAddShow Click Event -->"
    Private Sub btnAddShow_Click(sender As Object, e As EventArgs) Handles btnAddShow.Click

        Dim addingNew As Boolean = True

        Call addNewShow(addingNew)
    End Sub
#End Region

#Region "<-- addNewShow() -->"
    Private Sub addNewShow(addingNew As Boolean)
        Dim frmChangeShowing As New frmChangeShowing(CType(Me.cboCurrentTimes.SelectedValue.ToString, Integer), addingNew, Me)
        frmChangeShowing.Show()
    End Sub
#End Region

End Class