

Public Class FoodItemDAO
    'Private Shared ReadOnly inst As New Lazy(Of FoodItemDAO)(Function() New FoodItemDAO(),
    '    System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)
    Private Shared inst As FoodItemDAO
    Private Sub New()

    End Sub
    Public Shared Property Instance As FoodItemDAO
        Get
            If (inst Is Nothing) Then
                inst = New FoodItemDAO
            End If

            Return FoodItemDAO.inst
        End Get
        Private Set(ByVal value As FoodItemDAO)
            inst = value
        End Set
    End Property

    Public Function getListFood() As List(Of FoodItem)
        Dim list As List(Of FoodItem) = New List(Of FoodItem)()
        Dim query As String = "select * from FoodItems"
        Dim data As DataTable = DataProvider.Instance.executeQuery(query)

        For Each item As DataRow In data.Rows
            Dim foodItem As FoodItem = New FoodItem(item)
            list.Add(foodItem)
        Next

        Return list
    End Function

    Public Function getCategoryList() As List(Of String)
        'Dim list As List(Of String) = New List(Of String)()
        Dim query As String = "select * from FoodItems"
        Dim list = DataProvider.Instance.excuteReader(query, "Category")
        Return list
    End Function

    Public Function insertFoodItem(id As String, name As String, category As String, price As String) As Boolean
        Dim query = "insert into FoodItems (ID, FoodItem, Category, Price) 
                        values (@1, @2, @3, @4)"
        Dim result = DataProvider.Instance.executeNonQuery(query, {id, name, category, price})
        Return result > 0
    End Function

    Public Function changeFoodItem(id As String, name As String, category As String, price As String) As Boolean
        Dim query = "update FoodItems set FoodItem = @1, Category = @2, Price = @3 
                        where ID = @4"
        Dim result = DataProvider.Instance.executeNonQuery(query, {name, category, price, id})
        Return result > 0
    End Function

    Public Function deleteFoodItem(id As String) As Boolean
        Dim query = "delete * from FoodItems where ID = @1"
        Dim result = DataProvider.Instance.executeNonQuery(query, {id})
        Return result > 0
    End Function

    Public Function searchFoodItem(name As String) As List(Of FoodItem)
        Dim list As List(Of FoodItem) = New List(Of FoodItem)()
        'Dim query As String = String.Format("select * from FoodItems where FoodItem like N'{0}'", name)
        Dim query As String = "select * from FoodItems where FoodItem like @1"
        Dim data As DataTable = DataProvider.Instance.executeQuery(query, {"%" & name & "%"})
        For Each item As DataRow In data.Rows
            Dim foodItem As FoodItem = New FoodItem(item)
            list.Add(foodItem)
        Next
        Return list
    End Function

    Public Function getFoodIDby(foodItem As String) As String
        Dim query = "select ID from FoodItems where FoodItem = @1"
        Dim item = DataProvider.Instance.executeScalar(query, {foodItem})
        Return item.ToString()
    End Function
End Class
