Public Class frmSeating

    Dim capacity As Integer
    Dim showingID As Integer
    Dim labels() As Label


#Region "<-- Constructor -->"
    Public Sub New(screeningCapacity As Integer, showing As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        capacity = screeningCapacity
        showingID = showing


        ReDim labels(capacity)

    End Sub
#End Region

#Region "<-- frmSeating Load Event -->"
    Private Sub frmSeating_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'make buttons transparent
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.FlatAppearance.BorderSize = 1
        btnExit.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnExit.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnExit.BackColor = Color.Transparent
        btnExit.ForeColor = Color.White

        Call refreshSeating()


    End Sub
#End Region

#Region "<-- btnExit Click Event -->"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
#End Region

#Region "<-- Seat Label Click Event -->"
    Private Sub Label_Click(sender As Object, e As EventArgs)

        Dim seat As New Label
        seat = CType(sender, Label)
        Dim seatNo As Integer = CInt(seat.Text)
        Dim seatColor As String = seat.BackColor.Name

        Dim frmSeatDetails As New frmSeatDetails(seatNo, showingID, seatColor, Me, capacity)
        frmSeatDetails.Show()
        Me.Close()
        'make it the active one so you can't switch back until you want to and there can't be more than one
        'udemy might help


    End Sub
#End Region

#Region "<-- refreshSeating() -->"
    Public Sub refreshSeating()
        For i As Integer = 1 To capacity
            labels(i) = New Label
            labels(i).Name = "Seat " & i.ToString
            labels(i).Text = i.ToString
            labels(i).BackColor = Color.Gray
            labels(i).ForeColor = Color.White
            labels(i).Height = 25
            labels(i).Width = 25
            labels(i).TextAlign = ContentAlignment.MiddleCenter
            labels(i).Visible = True


            'query database for info on seat status
            'if this seat is reserved or sold for this seating
            If DBL.Tables.datTicketsSold.anyTicketsSold(showingID, i) Then

                'If isPaid is true, then paid coloring
                If DBL.Tables.datTicketsSold.isTicketPaid(showingID, i) Then

                    labels(i).BackColor = Color.Red
                    labels(i).ForeColor = Color.White

                Else

                    'If Not, Then reserved coloring
                    labels(i).BackColor = Color.Blue
                    labels(i).ForeColor = Color.White
                End If
            End If

            AddHandler labels(i).Click, AddressOf Label_Click

            Me.Controls.Add(labels(i))

        Next

        Dim rowcounter As Integer = 1
        Dim colcounter As Integer = 0
        For i = 1 To capacity
            colcounter += 1
            If rowcounter > 10 Then rowcounter = 1
            If colcounter > 10 Then
                colcounter = 1
                rowcounter += 1
            End If

            labels(i).Top = 30 * rowcounter
            labels(i).Left = 30 * colcounter
        Next
    End Sub
#End Region

End Class