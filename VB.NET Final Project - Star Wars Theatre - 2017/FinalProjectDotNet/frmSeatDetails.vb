Public Class frmSeatDetails

#Region "<-- Public Variables -->"
    Dim showingID As Integer
    Dim seatColour As String
    Dim seatNo As Integer
    Dim myParentForm As frmSeating
    Dim screeningCapacity As Integer
#End Region

#Region "<-- Constructor -->"
    Public Sub New(seatNum As Integer, showID As Integer, seatCol As String, parentForm As frmSeating, capacity As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        showingID = showID
        seatColour = seatCol
        seatNo = seatNum
        myParentForm = parentForm
        screeningCapacity = capacity

        Call makeButtonsTransparent()

        'If not available
        If DBL.Tables.datTicketsSold.anyTicketsSold(showingID, seatNo) Then
            'If paid for
            If DBL.Tables.datTicketsSold.isTicketPaid(showingID, seatNo) Then
                Call paidControls()
            Else 'If reserved
                Call reservedControls()
            End If

        Else 'If available
            Call availableControls()
        End If


    End Sub
#End Region

#Region "<-- makeButtonsTransparent() -->"
    Private Sub makeButtonsTransparent()

        For Each button As Button In Me.pnlButtons.Controls
            button.FlatStyle = FlatStyle.Flat
            button.FlatAppearance.BorderSize = 1
            button.FlatAppearance.MouseDownBackColor = Color.Transparent
            button.FlatAppearance.MouseOverBackColor = Color.Transparent
            button.BackColor = Color.Transparent
            button.ForeColor = Color.White
        Next
    End Sub
#End Region

#Region "<-- availableControls() -->"
    Private Sub availableControls()

        'Show appropriate instructions
        Me.lblInstructions.Text = "Please enter the trooper's designation and the payment status and click the Update button."

        'Hide the Cancel Reservation Button
        Me.btnCancelReservation.Visible = False
        Me.btnCancel.Text = "Cancel"

        'Fill in seat number and showing details
        Me.lblSeatNoOut.Text = CStr(seatNo)

        'Use the showing ID to get the movie ID, then use movieID to get the movie title
        Me.lblTitleOut.Text = CStr(DBL.Tables.datMovies.getOneRow(CInt(DBL.Tables.datMovieTimes.getOneRow(showingID).movieID)).movieName)

        'Display the date and time of selected showing
        Me.lblShowTimeOut.Text = CStr(DBL.Tables.datMovieTimes.getOneRow(showingID).dateTime)

        'Set visibility for last two controls
        Me.lblTrooperIdOut.Visible = False
        Me.txtTrooperId.Visible = True
        Me.txtTrooperId.Text = ""

        Me.cboPaidStatus.Visible = True
        Me.lblPaidOut.Visible = False
        Me.cboPaidStatus.Text = ""
    End Sub
#End Region

#Region "<-- reservedControls() -->"
    Private Sub reservedControls()

        'button Visiblity
        Me.btnCancelReservation.Visible = True
        Me.btnCancel.Text = "Cancel"

        'Show appropriate instructions
        Me.lblInstructions.Text = "If marking reservation as Paid, please select Paid from the options and click Update. If cancelling reservation, please click Cancel Reservation."

        'Fill in seat number and showing details
        Me.lblSeatNoOut.Text = CStr(seatNo)

        'Use the showing ID to get the movie ID, then use movieID to get the movie title
        Me.lblTitleOut.Text = CStr(DBL.Tables.datMovies.getOneRow(CInt(DBL.Tables.datMovieTimes.getOneRow(showingID).movieID)).movieName)

        'Display the date and time of selected showing
        Me.lblShowTimeOut.Text = CStr(DBL.Tables.datMovieTimes.getOneRow(showingID).dateTime)

        'Display trooper id as label 
        Me.txtTrooperId.Visible = False
        Me.lblTrooperIdOut.Visible = True
        Me.lblTrooperIdOut.Text = DBL.Tables.datTicketsSold.getAttendeeBySeat(seatNo, showingID)

        'Defaulf cbo to Reserved
        Me.lblPaidOut.Visible = False
        Me.cboPaidStatus.Visible = True
        Me.cboPaidStatus.Text = "Reserved"
    End Sub
#End Region

#Region "<-- paidControls() -->"
    Private Sub paidControls()
        'Show appropriate instructions
        Me.lblInstructions.Text = "Here are the details for this seat purchase."

        'Update button visibility
        Me.btnUpdate.Visible = False
        Me.btnCancelReservation.Visible = False
        Me.btnCancel.Text = "OK"

        'Fill in seat number and showing details
        Me.lblSeatNoOut.Text = CStr(seatNo)

        'Use the showing ID to get the movie ID, then use movieID to get the movie title
        Me.lblTitleOut.Text = CStr(DBL.Tables.datMovies.getOneRow(CInt(DBL.Tables.datMovieTimes.getOneRow(showingID).movieID)).movieName)

        'Display the date and time of selected showing
        Me.lblShowTimeOut.Text = CStr(DBL.Tables.datMovieTimes.getOneRow(showingID).dateTime)

        'Display trooper id
        Me.txtTrooperId.Visible = False
        Me.lblTrooperIdOut.Visible = True
        Me.lblTrooperIdOut.Text = DBL.Tables.datTicketsSold.getAttendeeBySeat(seatNo, showingID)

        'Defaulf cbo to Reserved
        Me.cboPaidStatus.Visible = False
        Me.lblPaidOut.Visible = True
        Me.lblPaidOut.Text = "Paid"

    End Sub
#End Region

#Region "<-- availableUpdate() -->"
    Private Sub availableUpdate()
        Try

            Dim currentRecord As New DBL.Tables.datTicketsSold()

            'use current values to create record
            currentRecord.showingID = showingID
            currentRecord.seatNo = seatNo

            If Me.cboPaidStatus.Text = "Reserved" Then
                currentRecord.isPaid = False
            ElseIf cboPaidStatus.Text = "Paid" Then
                currentRecord.isPaid = True
            End If

            currentRecord.Attendee = Me.txtTrooperId.Text.Trim

            'try to add it

            If DBL.Tables.datTicketsSold.insertNewRow(currentRecord) <> 0 Then
                MsgBox("Seat has been reserved for trooper " & currentRecord.Attendee)
                Call reservedControls()

            End If

        Catch ex As Exception

            Console.WriteLine("Error in btnUpdate New Ticket")
            Console.WriteLine(Err.Description)
            MsgBox("There was an error updating the seat details.")

        End Try
    End Sub
#End Region

#Region "<-- reservationUpdate() -->"
    Private Sub reservationUpdate()

        Try

            Dim currentRecord As New DBL.Tables.datTicketsSold()

            'use current values to create record
            currentRecord.ticketID = DBL.Tables.datTicketsSold.getTicketIdBySeatAndShowing(seatNo, showingID)
            currentRecord.showingID = showingID
            currentRecord.seatNo = seatNo

            If Me.cboPaidStatus.Text = "Reserved" Then
                currentRecord.isPaid = False
            ElseIf cboPaidStatus.Text = "Paid" Then
                currentRecord.isPaid = True
            End If

            currentRecord.Attendee = Me.txtTrooperId.Text.Trim

            'try to add it

            If DBL.Tables.datTicketsSold.updateExistingRow(currentRecord) Then

                MsgBox("Seat has been paid for by trooper " & currentRecord.Attendee)
                Call paidControls()

            End If

        Catch ex As Exception

            Console.WriteLine("Error in reservationUpdate")
            Console.WriteLine(Err.Description)
            MsgBox("There was an error updating the seat details.")

        End Try
    End Sub
#End Region

#Region "<-- cancelReservation() -->"
    Private Sub cancelReservation()

        Try

            Dim currentRecord As New DBL.Tables.datTicketsSold()

            'use current values to create record
            currentRecord.ticketID = DBL.Tables.datTicketsSold.getTicketIdBySeatAndShowing(seatNo, showingID)
            currentRecord.showingID = showingID
            currentRecord.seatNo = seatNo

            If Me.cboPaidStatus.Text = "Reserved" Then
                currentRecord.isPaid = False
            ElseIf cboPaidStatus.Text = "Paid" Then
                currentRecord.isPaid = True
            End If

            currentRecord.Attendee = Me.lblTrooperIdOut.Text

            If DBL.Tables.datTicketsSold.deleteRow(currentRecord.ticketID) Then

                MsgBox("Reservation has been successfully cancelled")
                Call availableControls()

            End If

        Catch ex As Exception

            Console.WriteLine("Error in cancelReservation")
            Console.WriteLine(Err.Description)

        End Try

    End Sub
#End Region

#Region "<-- btnUpdate Click Event -->"
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'If seat available
        If DBL.Tables.datTicketsSold.anyTicketsSold(showingID, seatNo) = False Then

            Call availableUpdate()

        Else 'If seat reserved (this button is unvailable if seat is paid for)

            Call reservationUpdate()

        End If

    End Sub
#End Region

#Region "<-- bntCancelReservation Click Event -->"
    Private Sub btnCancelReservation_Click(sender As Object, e As EventArgs) Handles btnCancelReservation.Click

        Call cancelReservation()

    End Sub
#End Region

#Region "<-- btnCancel Click Event -->"
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        'Add confirmation later
        Dim frmSeating As New frmSeating(screeningCapacity, showingID)
        frmSeating.Show()
        Me.Close()

    End Sub
#End Region

End Class