

Public Class BillInfo

    Public Sub New(BillID As Integer, FoodID As String, Count As Integer)
        Me.BillID = BillID
        Me.FoodID = FoodID
        Me.Count = Count
    End Sub

    Public Sub New(ByVal row As DataRow)
        Me.BillID = CInt(row("BillID"))
        Me.FoodID = row("FoodID").ToString()
        Me.Count = CInt(row("Amount"))
        ' Do not use Count as a field name in any table
        ' Because it conflicts with VB syntax
    End Sub

    Private _billID As Integer
    Private _foodID As String
    Private _count As Integer

    Public Property BillID As Integer
        Get
            Return _billID
        End Get
        Set(ByVal value As Integer)
            _billID = value
        End Set
    End Property


    Public Property FoodID As String
        Get
            Return _foodID
        End Get
        Set(ByVal value As String)
            _foodID = value
        End Set
    End Property

    Public Property Count As Integer
        Get
            Return _count
        End Get
        Set(ByVal value As Integer)
            _count = value
        End Set
    End Property
End Class
