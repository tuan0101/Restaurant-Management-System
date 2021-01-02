

Public Class Bill
    Public Sub New(ID As Integer, CheckIn As Date, CheckOut As Date, Status As String, TableID As Integer)
        Me.BillID = ID
        Me.CheckIn = CheckIn
        Me.CheckOut = CheckOut
        Me.Status = Status
        Me.TableID = TableID
    End Sub

    Public Sub New(ByVal row As DataRow)
        Me.BillID = CInt(row("ID"))
        Me.CheckIn = CType(row("CheckIn"), DateTime?)
        Dim checkOutTemp = row("CheckOut")
        If (checkOutTemp.ToString() <> "") Then
            Me.CheckOut = CType(checkOutTemp, DateTime?)
        End If


        Me.Status = row("Status").ToString()
        Me.TableID = CInt(row("TableID"))
    End Sub

    Private _id As Integer
    Private _checkIn As Date?
    Private _checkOut As Date?
    Private _status As String
    Private _tableID As Integer


    Public Property BillID As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property


    Public Property CheckIn As Date
        Get
            Return _checkIn
        End Get
        Set(ByVal value As Date)
            _checkIn = value
        End Set
    End Property

    Public Property CheckOut As Date
        Get
            Return _checkOut
        End Get
        Set(ByVal value As Date)
            _checkOut = value
        End Set
    End Property

    Public Property Status As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property

    Public Property TableID As String
        Get
            Return _tableID
        End Get
        Set(ByVal value As String)
            _tableID = value
        End Set
    End Property
End Class
