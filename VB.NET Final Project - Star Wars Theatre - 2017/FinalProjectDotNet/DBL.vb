

Imports System.Data, System.Data.SqlClient

' Database Code Generated on 2017-04-03 2:09:27 PM by Sarah Powell
Namespace DBL

#Region "<-- Conn Class -->"
    Public Class Conn
        Public Shared Function getConnectionString() As String
            Return My.Settings.dbConn
        End Function
    End Class
#End Region


    Public Class Tables
#Region "<-- datMovies Partial Class -->"
        Partial Public Class datMovies

#Region " -- Constants -- "
            Public Class Fields
                Public Const movieID As String = "movieID"
                Public Const movieName As String = "movieName"
                Public Const displayOrder As String = "displayOrder"
                Public Const isActive As String = "isActive"
            End Class

#End Region

#Region " -- SQLStatements -- "
            Public Class SQLStatements
                Public Const SELECT_ALL As String = "SELECT * FROM datMovies ORDER BY displayOrder ASC"
                Public Const SELECT_1_BY_ID As String = "SELECT TOP 1 * FROM [datMovies] WHERE [movieID] = @Key"
                Public Const INSERT_NEW As String = "INSERT INTO datMovies VALUES(@movieName, @displayOrder, @isActive)"
                Public Const UPDATE_EXISING As String = "UPDATE datMovies Set movieName  = @movieName, displayOrder  = @displayOrder, isActive  = @isActive WHERE movieID = @PK"
                Public Const DELETE_EXISTING As String = "DELETE FROM [datMovies] WHERE [movieID] = @Key"

                Public Const LAST_MOVIEID As String = "SELECT TOP 1 movieID FROM datMovies ORDER BY movieID DESC"



            End Class

#End Region

#Region "-- Properties --"
            Private _movieID As Integer
            Public Property movieID() As Integer
                Get
                    Return _movieID
                End Get
                Set(ByVal value As Integer)
                    _movieID = value
                End Set
            End Property

            Private _movieName As String
            Public Property movieName() As String
                Get
                    Return _movieName
                End Get
                Set(ByVal value As String)
                    _movieName = value
                End Set
            End Property

            Private _displayOrder As Integer
            Public Property displayOrder() As Integer
                Get
                    Return _displayOrder
                End Get
                Set(ByVal value As Integer)
                    _displayOrder = value
                End Set
            End Property

            Private _isActive As Boolean
            Public Property isActive() As Boolean
                Get
                    Return _isActive
                End Get
                Set(ByVal value As Boolean)
                    _isActive = value
                End Set
            End Property

#End Region

#Region " -- Constructors -- "
            Public Sub New(movieID_ As Integer, movieName_ As String, displayOrder_ As Integer, isActive_ As Boolean)
                Dim Row As New datMovies(0)
                movieID = 0
                movieName = movieName_
                displayOrder = displayOrder_
                isActive = isActive_
            End Sub

            Public Sub New(ID As Integer)
                If ID > 0 Then
                    Dim Row As New datMovies(0)
                    Row = getOneRow(ID)
                    movieID = Row.movieID
                    movieName = Row.movieName
                    displayOrder = Row.displayOrder
                    isActive = Row.isActive
                End If
            End Sub
            Public Sub New()
                movieID = 0
                movieName = String.Empty
                displayOrder = 10
                isActive = False
            End Sub

#End Region

#Region "-- Generic Methods --"
            Public Shared Function getOneRow(PK As Integer) As datMovies
                Dim returnRow As New datMovies(0)
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.SELECT_1_BY_ID
                command.Parameters.AddWithValue("@Key", PK)
                Try
                    connDB.Open()
                    Dim dR As IDataReader = command.ExecuteReader
                    If dR.Read() Then
                        returnRow.movieID = PK
                        If Not IsDBNull(dR(Fields.movieName)) Then returnRow.movieName = CStr(dR(Fields.movieName))
                        If Not IsDBNull(dR(Fields.displayOrder)) Then returnRow.displayOrder = CInt(dR(Fields.displayOrder))
                        If Not IsDBNull(dR(Fields.isActive)) Then returnRow.isActive = CBool(dR(Fields.isActive))
                    End If
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnRow
            End Function
            Public Shared Function getAllRows() As Generic.List(Of datMovies)
                Dim returnRows As New Generic.List(Of datMovies)
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.SELECT_ALL
                Try
                    connDB.Open()
                    Dim dR As IDataReader = command.ExecuteReader
                    Do While dR.Read()
                        Dim Row As New datMovies(0)
                        If Not IsDBNull(dR(Fields.movieID)) Then Row.movieID = CInt(dR(Fields.movieID))
                        If Not IsDBNull(dR(Fields.movieName)) Then Row.movieName = CStr(dR(Fields.movieName))
                        If Not IsDBNull(dR(Fields.displayOrder)) Then Row.displayOrder = CInt(dR(Fields.displayOrder))
                        If Not IsDBNull(dR(Fields.isActive)) Then Row.isActive = CBool(dR(Fields.isActive))
                        returnRows.Add(Row)
                    Loop
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnRows
            End Function
            Public Shared Function insertNewRow(Row As datMovies) As Integer
                Dim ReturnValue As Boolean = False
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.INSERT_NEW
                command.Parameters.AddWithValue("@movieName", Row.movieName)
                command.Parameters.AddWithValue("@displayOrder", Row.displayOrder)
                command.Parameters.AddWithValue("@isActive", Row.isActive)
                Try
                    connDB.Open()
                    ReturnValue = (command.ExecuteNonQuery = 1)
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return CInt(ReturnValue)
            End Function
            Public Shared Function updateExistingRow(Row As datMovies) As Boolean
                Dim ReturnValue As Boolean = False
                If Row.movieID > 0 Then
                    Dim connDB As New SqlConnection
                    connDB.ConnectionString = Conn.getConnectionString

                    Dim command As New SqlCommand
                    command.Connection = connDB
                    command.CommandType = CommandType.Text
                    command.CommandText = SQLStatements.UPDATE_EXISING
                    command.Parameters.AddWithValue("@PK", Row.movieID)
                    command.Parameters.AddWithValue("@movieName", Row.movieName)
                    command.Parameters.AddWithValue("@displayOrder", Row.displayOrder)
                    command.Parameters.AddWithValue("@isActive", Row.isActive)
                    Try
                        connDB.Open()
                        If command.ExecuteNonQuery > 0 Then ReturnValue = True
                    Catch ex As Exception
                        Console.WriteLine(Err.Description)
                    End Try
                Else
                    If insertNewRow(Row) > 0 Then ReturnValue = True
                End If
                Return ReturnValue
            End Function
            Public Shared Function deleteRow(PK As Integer) As Boolean
                Dim returnValue As Boolean = False

                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.DELETE_EXISTING
                command.Parameters.AddWithValue("@Key", PK)
                Try
                    connDB.Open()
                    returnValue = command.ExecuteNonQuery() > 0
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnValue
            End Function

            Public Shared Function getLastMovieID() As Integer

                Dim movieID As Integer

                Dim myConn As New SqlConnection
                myConn.ConnectionString = Conn.getConnectionString

                Dim myCommand As New SqlCommand
                myCommand.Connection = myConn
                myCommand.CommandType = CommandType.Text
                myCommand.CommandText = DBL.Tables.datMovies.SQLStatements.LAST_MOVIEID

                Try
                    myConn.Open()
                    Dim DR As IDataReader
                    DR = myCommand.ExecuteReader()

                    If DR.Read() Then

                        movieID = CInt(DR("movieID"))

                    End If

                    myConn.Close()
                    myCommand = Nothing
                    DR.Close()

                Catch ex As Exception

                    Console.WriteLine("Error in getLastMovieID()")
                    Console.WriteLine(Err.Description)

                End Try

                Return movieID

            End Function


            Public Shared Function isShowtimeValid(time As Date) As Boolean

                Dim isTimeValid As Boolean

                Dim myConn As New SqlConnection
                myConn.ConnectionString = Conn.getConnectionString

                Dim myCommand As New SqlCommand
                myCommand.Connection = myConn
                myCommand.CommandType = CommandType.Text
                myCommand.CommandText = DBL.Tables.datMovies.SQLStatements.SELECT_ALL


            End Function

#End Region
        End Class
#End Region

#Region "<-- datMovieTimes Partial Class -->"
        Partial Public Class datMovieTimes

#Region " -- Constants -- "
            Public Class Fields
                Public Const showingID As String = "showingID"
                Public Const movieID As String = "movieID"
                Public Const dateTime As String = "dateTime"
                Public Const isActive As String = "isActive"
            End Class

#End Region

#Region " -- SQLStatements -- "
            Public Class SQLStatements
                Public Const SELECT_ALL As String = "SELECT * FROM datMovieTimes"
                Public Const SELECT_1_BY_ID As String = "SELECT showingID, movieID, dateTime, isActive FROM datMovieTimes WHERE showingID = @showingID"

                Public Const INSERT_NEW As String = "INSERT INTO datMovieTimes VALUES(@movieID, @dateTime, @isActive)"
                Public Const UPDATE_EXISING As String = "UPDATE datMovieTimes Set movieID  = @movieID, dateTime  = @dateTime, isActive  = @isActive WHERE showingID = @PK"
                Public Const DELETE_EXISTING As String = "DELETE FROM datMovieTimes WHERE showingID = @Key"

                Public Const SELECT_ALL_BY_DATETIME As String = "SELECT showingID, movieID, dateTime, isActive FROM datMovieTimes WHERE showingID = @showingIID"

                Public Const GET_SHOWINGS_BY_TITLE As String = "SELECT showingID, movieID, dateTime, isActive FROM datMovieTimes WHERE movieID = @movieID"

                Public Const GET_SHOWING_DATETIMES_AT_1 As String = "SELECT dateTime FROM datMovieTimes WHERE dateTime = @dateTime"


            End Class

#End Region

#Region "-- Properties --"
            Private _showingID As Integer
            Public Property showingID() As Integer
                Get
                    Return _showingID
                End Get
                Set(ByVal value As Integer)
                    _showingID = value
                End Set
            End Property

            Private _movieID As Integer
            Public Property movieID() As Integer
                Get
                    Return _movieID
                End Get
                Set(ByVal value As Integer)
                    _movieID = value
                End Set
            End Property

            Private _dateTime As DateTime
            Public Property dateTime() As DateTime
                Get
                    Return _dateTime
                End Get
                Set(ByVal value As DateTime)
                    _dateTime = value
                End Set
            End Property

            Private _isActive As Boolean
            Public Property isActive() As Boolean
                Get
                    Return _isActive
                End Get
                Set(ByVal value As Boolean)
                    _isActive = value
                End Set
            End Property

#End Region

#Region " -- Constructors -- "
            Public Sub New(showingID_ As Integer, movieID_ As Integer, dateTime_ As DateTime, isActive_ As Boolean)
                Dim Row As New datMovieTimes(0)
                showingID = 0
                movieID = movieID_
                dateTime = dateTime_
                isActive = isActive_
            End Sub

            Public Sub New(ID As Integer)
                If ID > 0 Then
                    Dim Row As New datMovieTimes(0)
                    Row = getOneRow(ID)
                    showingID = Row.showingID
                    movieID = Row.movieID
                    dateTime = Row.dateTime
                    isActive = Row.isActive
                End If
            End Sub
            Public Sub New()
                showingID = 0
                movieID = 0
                dateTime = Now
                isActive = True
            End Sub

#End Region

#Region "-- Generic Methods --"
            Public Shared Function getOneRow(showingID As Integer) As datMovieTimes

                Dim returnRow As New datMovieTimes

                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString()

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = DBL.Tables.datMovieTimes.SQLStatements.SELECT_1_BY_ID
                command.Parameters.AddWithValue("@showingID", showingID)
                Try
                    connDB.Open()
                    Dim dR As IDataReader
                    dR = command.ExecuteReader()

                    If dR.Read() Then
                        returnRow.showingID = CInt(dR("showingID"))
                        returnRow.movieID = CInt(dR("movieID"))
                        returnRow.dateTime = CDate(dR("dateTime"))
                        returnRow.isActive = CBool(dR("isActive"))
                    End If

                    dR.Close()
                    dR = Nothing
                    connDB.Close()


                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try

                Return returnRow

            End Function

            Public Shared Function getAllRows() As Generic.List(Of datMovieTimes)
                Dim returnRows As New Generic.List(Of datMovieTimes)
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.SELECT_ALL
                Try
                    connDB.Open()
                    Dim dR As IDataReader = command.ExecuteReader
                    Do While dR.Read()
                        Dim Row As New datMovieTimes(0)
                        If Not IsDBNull(dR(Fields.showingID)) Then Row.showingID = CInt(dR(Fields.showingID))
                        If Not IsDBNull(dR(Fields.movieID)) Then Row.movieID = CInt(dR(Fields.movieID))
                        If Not IsDBNull(dR(Fields.dateTime)) Then Row.dateTime = CDate(dR(Fields.dateTime))
                        If Not IsDBNull(dR(Fields.isActive)) Then Row.isActive = CBool(dR(Fields.isActive))
                        returnRows.Add(Row)
                    Loop
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnRows
            End Function
            Public Shared Function insertNewRow(Row As datMovieTimes) As Integer
                Dim ReturnValue As Boolean = False
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.INSERT_NEW
                command.Parameters.AddWithValue("@movieID", Row.movieID)
                command.Parameters.AddWithValue("@dateTime", Row.dateTime)
                command.Parameters.AddWithValue("@isActive", Row.isActive)
                Try
                    connDB.Open()
                    ReturnValue = (command.ExecuteNonQuery = 1)
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return CInt(ReturnValue)
            End Function
            Public Shared Function updateExistingRow(Row As datMovieTimes) As Boolean
                Dim ReturnValue As Boolean = False
                If Row.showingID > 0 Then
                    Dim connDB As New SqlConnection
                    connDB.ConnectionString = Conn.getConnectionString

                    Dim command As New SqlCommand
                    command.Connection = connDB
                    command.CommandType = CommandType.Text
                    command.CommandText = SQLStatements.UPDATE_EXISING
                    command.Parameters.AddWithValue("@PK", Row.showingID)
                    command.Parameters.AddWithValue("@movieID", Row.movieID)
                    command.Parameters.AddWithValue("@dateTime", Row.dateTime)
                    command.Parameters.AddWithValue("@isActive", Row.isActive)
                    Try
                        connDB.Open()
                        If command.ExecuteNonQuery > 0 Then ReturnValue = True
                    Catch ex As Exception
                        Console.WriteLine(Err.Description)
                    End Try
                Else
                    If insertNewRow(Row) > 0 Then ReturnValue = True
                End If
                Return ReturnValue
            End Function
            Public Shared Function deleteRow(PK As Integer) As Boolean
                Dim returnValue As Boolean = False
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.DELETE_EXISTING
                command.Parameters.AddWithValue("@Key", PK)
                Try
                    connDB.Open()
                    returnValue = command.ExecuteNonQuery() > 0
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnValue
            End Function

            Public Shared Function isValidShowtime(proposedTime As String) As Boolean
                Dim validShowtime As Boolean

                Dim myConn As New SqlConnection
                myConn.ConnectionString = DBL.Conn.getConnectionString()

                Dim myCommand As New SqlCommand
                myCommand.Connection = myConn
                myCommand.CommandType = CommandType.Text
                myCommand.CommandText = DBL.Tables.datMovieTimes.SQLStatements.GET_SHOWING_DATETIMES_AT_1
                myCommand.Parameters.AddWithValue("@dateTime", proposedTime)

                Try

                    myConn.Open()

                    Dim DR As IDataReader
                    DR = myCommand.ExecuteReader()

                    If DR.Read Then
                        validShowtime = False
                    Else
                        validShowtime = True
                    End If

                    myConn.Close()
                    myCommand = Nothing
                    DR.Close()

                Catch ex As Exception

                    Console.WriteLine("Error in isValidShowtime")
                    Console.WriteLine(Err.Description)
                End Try

                Return validShowtime

            End Function


#End Region
        End Class
#End Region

#Region "<-- datTicketsSold Partial Class -->"
        Partial Public Class datTicketsSold

#Region " -- Constants -- "
            Public Class Fields
                Public Const ticketID As String = "ticketID"
                Public Const showingID As String = "showingID"
                Public Const seatNo As String = "seatNo"
                Public Const isPaid As String = "isPaid"
                Public Const Attendee As String = "Attendee"
            End Class

#End Region

#Region " -- SQLStatements -- "
            Public Class SQLStatements
                Public Const SELECT_ALL As String = "SELECT * FROM datTicketsSold"
                Public Const SELECT_1_BY_ID As String = "SELECT TOP 1 * FROM datTicketsSold WHERE ticketID = @Key"
                Public Const INSERT_NEW As String = "INSERT INTO datTicketsSold VALUES(@showingID, @seatNo, @isPaid, @Attendee)"
                Public Const UPDATE_EXISING As String = "UPDATE datTicketsSold Set showingID  = @showingID, seatNo  = @seatNo, isPaid  = @isPaid, Attendee  = @Attendee WHERE ticketID = @PK"
                Public Const DELETE_EXISTING As String = "DELETE FROM datTicketsSold WHERE ticketID = @Key"
                'Added by Sarah Powell
                Public Const GET_TICKETS_BY_SHOWINGID As String = "SELECT ticketID, showingID, seatNo, isPaid, Attendee FROM datTicketsSold WHERE showingID = @showingID AND seatNo = @seatNo"
                Public Const GET_ATTENDEE_BY_SEAT As String = "SELECT Attendee FROM datTicketsSold WHERE seatNo = @SeatNo AND showingID = @showingID"
                Public Const GET_TICKETID_BY_SEAT_AND_SHOWING As String = "SELECT ticketID FROM datTicketsSold WHERE showingID = @showingID AND seatNo = @seatNo"

            End Class

#End Region

#Region "-- Properties --"
            Private _ticketID As Integer
            Public Property ticketID() As Integer
                Get
                    Return _ticketID
                End Get
                Set(ByVal value As Integer)
                    _ticketID = value
                End Set
            End Property

            Private _showingID As Integer
            Public Property showingID() As Integer
                Get
                    Return _showingID
                End Get
                Set(ByVal value As Integer)
                    _showingID = value
                End Set
            End Property

            Private _seatNo As Integer
            Public Property seatNo() As Integer
                Get
                    Return _seatNo
                End Get
                Set(ByVal value As Integer)
                    _seatNo = value
                End Set
            End Property

            Private _isPaid As Boolean
            Public Property isPaid() As Boolean
                Get
                    Return _isPaid
                End Get
                Set(ByVal value As Boolean)
                    _isPaid = value
                End Set
            End Property

            Private _Attendee As String
            Public Property Attendee() As String
                Get
                    Return _Attendee
                End Get
                Set(ByVal value As String)
                    _Attendee = value
                End Set
            End Property

#End Region

#Region " -- Constructors -- "
            Public Sub New(ticketID_ As Integer, showingID_ As Integer, seatNo_ As Integer, isPaid_ As Boolean, Attendee_ As String)
                Dim Row As New datTicketsSold(0)
                ticketID = 0
                showingID = showingID_
                seatNo = seatNo_
                isPaid = isPaid_
                Attendee = Attendee_
            End Sub

            Public Sub New(ID As Integer)
                If ID > 0 Then
                    Dim Row As New datTicketsSold(0)
                    Row = getOneRow(ID)
                    ticketID = Row.ticketID
                    showingID = Row.showingID
                    seatNo = Row.seatNo
                    isPaid = Row.isPaid
                    Attendee = Row.Attendee
                End If
            End Sub
            Public Sub New()
                ticketID = 0
                showingID = 0
                seatNo = 0
                isPaid = True
                Attendee = String.Empty
            End Sub

#End Region

#Region "-- Generic Methods --"
            Public Shared Function getOneRow(PK As Integer) As datTicketsSold
                Dim returnRow As New datTicketsSold(0)
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.SELECT_1_BY_ID
                command.Parameters.AddWithValue("@Key", PK)
                Try
                    connDB.Open()
                    Dim dR As IDataReader = command.ExecuteReader
                    If dR.Read() Then
                        returnRow.ticketID = PK
                        If Not IsDBNull(dR(Fields.showingID)) Then returnRow.showingID = CInt(dR(Fields.showingID))
                        If Not IsDBNull(dR(Fields.seatNo)) Then returnRow.seatNo = CInt(dR(Fields.seatNo))
                        If Not IsDBNull(dR(Fields.isPaid)) Then returnRow.isPaid = CBool(dR(Fields.isPaid))
                        If Not IsDBNull(dR(Fields.Attendee)) Then returnRow.Attendee = CStr(dR(Fields.Attendee))
                    End If
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnRow
            End Function
            Public Shared Function getAllRows() As Generic.List(Of datTicketsSold)
                Dim returnRows As New Generic.List(Of datTicketsSold)
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.SELECT_ALL
                Try
                    connDB.Open()
                    Dim dR As IDataReader = command.ExecuteReader
                    Do While dR.Read()
                        Dim Row As New datTicketsSold(0)
                        If Not IsDBNull(dR(Fields.ticketID)) Then Row.ticketID = CInt(dR(Fields.ticketID))
                        If Not IsDBNull(dR(Fields.showingID)) Then Row.showingID = CInt(dR(Fields.showingID))
                        If Not IsDBNull(dR(Fields.seatNo)) Then Row.seatNo = CInt(dR(Fields.seatNo))
                        If Not IsDBNull(dR(Fields.isPaid)) Then Row.isPaid = CBool(dR(Fields.isPaid))
                        If Not IsDBNull(dR(Fields.Attendee)) Then Row.Attendee = CStr(dR(Fields.Attendee))
                        returnRows.Add(Row)
                    Loop
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnRows
            End Function
            Public Shared Function insertNewRow(Row As datTicketsSold) As Integer
                Dim ReturnValue As Boolean = False
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.INSERT_NEW
                command.Parameters.AddWithValue("@showingID", Row.showingID)
                command.Parameters.AddWithValue("@seatNo", Row.seatNo)
                command.Parameters.AddWithValue("@isPaid", Row.isPaid)
                command.Parameters.AddWithValue("@Attendee", Row.Attendee)
                Try
                    connDB.Open()
                    ReturnValue = (command.ExecuteNonQuery = 1)
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return CInt(ReturnValue)
            End Function
            Public Shared Function updateExistingRow(Row As datTicketsSold) As Boolean
                Dim ReturnValue As Boolean = False
                If Row.ticketID > 0 Then
                    Dim connDB As New SqlConnection
                    connDB.ConnectionString = Conn.getConnectionString

                    Dim command As New SqlCommand
                    command.Connection = connDB
                    command.CommandType = CommandType.Text
                    command.CommandText = SQLStatements.UPDATE_EXISING
                    command.Parameters.AddWithValue("@PK", Row.ticketID)
                    command.Parameters.AddWithValue("@showingID", Row.showingID)
                    command.Parameters.AddWithValue("@seatNo", Row.seatNo)
                    command.Parameters.AddWithValue("@isPaid", Row.isPaid)
                    command.Parameters.AddWithValue("@Attendee", Row.Attendee)
                    Try
                        connDB.Open()
                        If command.ExecuteNonQuery > 0 Then ReturnValue = True
                    Catch ex As Exception
                        Console.WriteLine(Err.Description)
                    End Try
                Else
                    If insertNewRow(Row) > 0 Then ReturnValue = True
                End If
                Return ReturnValue
            End Function
            Public Shared Function deleteRow(PK As Integer) As Boolean
                Dim returnValue As Boolean = False
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.DELETE_EXISTING
                command.Parameters.AddWithValue("@Key", PK)
                Try
                    connDB.Open()
                    returnValue = command.ExecuteNonQuery() > 0
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnValue
            End Function
#End Region

#Region "<-- Custom Methods -->"
            'Added by Sarah Powell
            ''' <summary>
            ''' gets boolean that returns if any tickets in showing are reserved or paid for
            ''' </summary>
            ''' <param name="showingID"></param>
            ''' <param name="seatNo"></param>
            ''' <returns></returns>
            Public Shared Function anyTicketsSold(showingID As Integer, seatNo As Integer) As Boolean

                Dim anySold As Boolean

                Dim myConn As New SqlConnection
                myConn.ConnectionString = DBL.Conn.getConnectionString()

                Dim myCommand As New SqlCommand
                myCommand.Connection = myConn
                myCommand.CommandType = CommandType.Text
                myCommand.CommandText = DBL.Tables.datTicketsSold.SQLStatements.GET_TICKETS_BY_SHOWINGID
                myCommand.Parameters.AddWithValue("@showingID", showingID)
                myCommand.Parameters.AddWithValue("@seatNo", seatNo)

                Try

                    myConn.Open()

                    Dim DR As IDataReader
                    DR = myCommand.ExecuteReader()

                    Dim sales As datTicketsSold

                    If DR.Read Then
                        anySold = True
                    Else
                        anySold = False
                    End If

                    myConn.Close()
                    myCommand = Nothing
                    DR.Close()

                Catch ex As Exception
                    Console.WriteLine("Error in anyTicketsSold")
                    Console.WriteLine(Err.Description)
                End Try

                Return anySold

            End Function

            'Added by Sarah Powell
            ''' <summary>
            ''' gets boolean representing if the seat is paid for
            ''' </summary>
            ''' <param name="showingID"></param>
            ''' <param name="seatNo"></param>
            ''' <returns></returns>
            Public Shared Function isTicketPaid(showingID As Integer, seatNo As Integer) As Boolean

                Dim isPaidFor As Boolean

                Dim myConn As New SqlConnection
                myConn.ConnectionString = DBL.Conn.getConnectionString()

                Dim myCommand As New SqlCommand
                myCommand.Connection = myConn
                myCommand.CommandType = CommandType.Text
                myCommand.CommandText = DBL.Tables.datTicketsSold.SQLStatements.GET_TICKETS_BY_SHOWINGID
                myCommand.Parameters.AddWithValue("@showingID", showingID)
                myCommand.Parameters.AddWithValue("@seatNo", seatNo)

                Try

                    myConn.Open()

                    Dim DR As IDataReader
                    DR = myCommand.ExecuteReader()

                    Dim sales As datTicketsSold

                    If DR.Read Then
                        sales = New datTicketsSold
                        sales.isPaid = CBool(DR("isPaid"))
                        If sales.isPaid = False Then
                            isPaidFor = False
                        Else
                            isPaidFor = True
                        End If
                    End If

                    myConn.Close()
                    myCommand = Nothing
                    DR.Close()

                Catch ex As Exception
                    Console.WriteLine("Error in isTicketReserved")
                    Console.WriteLine(Err.Description)
                End Try

                Return isPaidFor

            End Function
            ''' <summary>
            ''' Get the Attendee name by seat and showing data
            ''' </summary>
            ''' <param name="seatNo"></param>
            ''' <param name="showingID"></param>
            ''' <returns></returns>
            Public Shared Function getAttendeeBySeat(seatNo As Integer, showingID As Integer) As String

                Dim name As String

                Dim myConn As New SqlConnection
                myConn.ConnectionString = DBL.Conn.getConnectionString()

                Dim myCommand As New SqlCommand
                myCommand.Connection = myConn
                myCommand.CommandType = CommandType.Text
                myCommand.CommandText = DBL.Tables.datTicketsSold.SQLStatements.GET_ATTENDEE_BY_SEAT
                myCommand.Parameters.AddWithValue("@seatNo", seatNo)
                myCommand.Parameters.AddWithValue("@showingID", showingID)

                Try

                    myConn.Open()

                    Dim DR As IDataReader
                    DR = myCommand.ExecuteReader()

                    If DR.Read Then
                        name = CStr(DR("Attendee"))
                    End If

                    myConn.Close()
                    myCommand = Nothing
                    DR.Close()

                Catch ex As Exception

                    Console.WriteLine("Error in getAttendeeBySeat")
                    Console.WriteLine(Err.Description)

                End Try

                Return name

            End Function

            Public Shared Function getTicketIdBySeatAndShowing(seatNo As Integer, showingID As Integer) As Integer

                Dim ticketNum As Integer

                Dim myConn As New SqlConnection
                myConn.ConnectionString = DBL.Conn.getConnectionString()

                Dim myCommand As New SqlCommand
                myCommand.Connection = myConn
                myCommand.CommandType = CommandType.Text
                myCommand.CommandText = DBL.Tables.datTicketsSold.SQLStatements.GET_TICKETID_BY_SEAT_AND_SHOWING
                myCommand.Parameters.AddWithValue("@seatNo", seatNo)
                myCommand.Parameters.AddWithValue("@showingID", showingID)

                Try

                    myConn.Open()

                    Dim DR As IDataReader
                    DR = myCommand.ExecuteReader()

                    If DR.Read Then
                        ticketNum = CInt(DR("ticketID"))
                    End If

                    myConn.Close()
                    myCommand = Nothing
                    DR.Close()

                Catch ex As Exception

                    Console.WriteLine("Error in getTicketIdBySeatAndShowing")
                    Console.WriteLine(Err.Description)

                End Try

                Return ticketNum

            End Function

#End Region
        End Class
#End Region

    End Class

#Region "<-- Views -->"

    Public Class Views

#Region "<-- Showings -->"
        Partial Public Class Showings

#Region "<-- Properties -->"

            Public Property showingID As Integer
            Public Property movieID As Integer
            Public Property movieName As String
            Public Property dateTime As Date
            Public Property isActive As Boolean

#End Region

#Region "<-- SQL Statements -->"
            Public Class SQLStatements


            End Class
#End Region

#Region "<-- Showings Methods -->"
            'Added by Sarah Powell
            Public Shared Function getShowingsByTitle(movieID As Integer) As List(Of Showings)

                    Dim returnShowings As New List(Of Showings)

                    Dim myConn As New SqlConnection
                    myConn.ConnectionString = DBL.Conn.getConnectionString()

                    Dim myCommand As New SqlCommand
                    myCommand.Connection = myConn
                    myCommand.CommandType = CommandType.Text
                myCommand.CommandText = DBL.Tables.datMovieTimes.SQLStatements.GET_SHOWINGS_BY_TITLE
                myCommand.Parameters.AddWithValue("@movieID", movieID)

                Try

                        myConn.Open()

                        Dim DR As IDataReader
                        DR = myCommand.ExecuteReader()

                        Dim showings As Showings

                        Do While DR.Read
                            showings = New Showings
                            showings.showingID = CInt(DR("showingID"))
                            showings.movieID = CInt(DR("movieID"))
                            showings.movieName = DBL.Tables.datMovies.getOneRow(CInt(showings.movieID)).movieName
                            showings.dateTime = CDate(DR("dateTime"))
                            showings.isActive = CBool(DR("isActive"))
                            returnShowings.Add(showings)
                        Loop

                        myConn.Close()
                        myCommand = Nothing
                        DR.Close()
                    Catch ex As Exception

                        Console.WriteLine("Error in getShowingsByTitle()")
                        Console.WriteLine(Err.Description)

                    End Try

                    'loop through showings in the list
                    For Each showings In returnShowings
                        'at movieID add movie name

                    Next

                    Return returnShowings

                End Function

#End Region


        End Class 'end Showings
#End Region

        End Class 'end Views
#End Region
End Namespace


