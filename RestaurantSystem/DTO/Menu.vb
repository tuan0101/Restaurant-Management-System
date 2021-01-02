

Public Class Menu
    Public Sub New(FoodItem As String, Count As String, Price As Double, Optional TotalPrice As Double = 0)
        Me._foodItem = FoodItem
        Me._count = Count
        Me._price = Price
        Me._totalPrice = TotalPrice
    End Sub

    Public Sub New(ByVal row As DataRow)
        Me._foodItem = row("FoodItem").ToString()
        Me._count = CInt(row("Amount"))
        Me._price = CType(row("Price"), Double)
        Me._totalPrice = CType(row("TotalPrice"), Double)
    End Sub

    Private _foodItem As String
    Private _count As Integer
    Private _price As Double
    Private _totalPrice As Double

    Public Property FoodItem As String
        Get
            Return _foodItem
        End Get
        Set(ByVal value As String)
            _foodItem = value
        End Set
    End Property


    Public Property Count As String
        Get
            Return _count
        End Get
        Set(ByVal value As String)
            _count = value
        End Set
    End Property

    Public Property Price As String
        Get
            Return _price
        End Get
        Set(ByVal value As String)
            _price = value
        End Set
    End Property
    Public Property TotalPrice As String
        Get
            Return _totalPrice
        End Get
        Set(ByVal value As String)
            _totalPrice = value
        End Set
    End Property
End Class
