Imports System.Data

Public Class FoodItem
    Public Sub New(ID As String, foodName As String, category As String, price As Double)
        Me.FoodID = ID
        Me.FoodName = foodName
        Me.Category = category
        Me.getPrice = price
    End Sub

    Public Sub New(ByVal row As DataRow)
        Me.FoodID = row("ID").ToString()
        Me.FoodName = row("FoodItem").ToString()
        Me.Category = row("Category").ToString()
        Me.getPrice = FormatCurrency(Convert.ToDouble(row("Price").ToString()), 2)
        'Me.getPrice = Format(Convert.ToDouble(row("Price").ToString()), "c")

    End Sub


    Private ID As String
    Private name As String
    Private categrory As String
    Private price As String

    Public Property FoodID As String
        Get
            Return ID
        End Get
        Set(ByVal value As String)
            ID = value
        End Set
    End Property


    Public Property FoodName As String
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property

    Public Property Category As String
        Get
            Return categrory
        End Get
        Set(ByVal value As String)
            categrory = value
        End Set
    End Property

    Public Property getPrice As String
        Get
            Return price
        End Get
        Set(ByVal value As String)
            price = value
        End Set
    End Property
End Class
