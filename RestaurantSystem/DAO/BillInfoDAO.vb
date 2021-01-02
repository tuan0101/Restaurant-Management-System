
Public Class BillInfoDAO
    Private Shared inst As BillInfoDAO
    Private Sub New()

    End Sub
    Public Shared Property Instance As BillInfoDAO
        Get
            If (inst Is Nothing) Then
                inst = New BillInfoDAO
            End If

            Return BillInfoDAO.inst
        End Get
        Private Set(ByVal value As BillInfoDAO)
            inst = value
        End Set
    End Property

    Public Function getBillInfoList(billID As Integer) As List(Of BillInfo)
        Dim billInfoList = New List(Of BillInfo)
        Dim query = "select * from BillInfo where BillID = @1"
        Dim data As DataTable = DataProvider.Instance.executeQuery(query, {billID})

        For Each item As DataRow In data.Rows
            Dim info = New BillInfo(item)
            billInfoList.Add(info)
        Next
        Return billInfoList
    End Function

    Public Sub insertBillInfo(BillID As Integer, FoodID As String, Count As Integer)
        Dim query = "insert into BillInfo(BillID, FoodID, Amount) values(@1, @2, @3)"
        DataProvider.Instance.executeNonQuery(query, {BillID, FoodID, Count})
    End Sub


    Public Function getCount(billID As Integer, FoodID As String) As Integer
        Dim query = "select Amount from BillInfo where
                    BillID = @3 and FoodID = @4"
        Dim data = DataProvider.Instance.executeScalar(query, {billID, FoodID})
        Return Convert.ToInt32(data.ToString())

    End Function
    Public Sub updateBillinfo(BillID As Integer, FoodID As String, Count As Integer)
        Dim query = "update BillInfo set BillID = @1, FoodID = @2, Amount = @3 
                    where FoodID = @4 and BillID = @5"
        DataProvider.Instance.executeNonQuery(query, {BillID, FoodID, Count, FoodID, BillID})
    End Sub

    Public Sub deleteBillinfo(BillID As Integer, FoodID As String)
        Dim query = "DELETE * from BillInfo where BillID = @1 and FoodID = @2"
        DataProvider.Instance.executeNonQuery(query, {BillID, FoodID})
        MessageBox.Show("The item is deleted!")
    End Sub

    Public Function checkExistFoodItem(BillID As Integer, FoodID As String) As Boolean
        Dim query = "select * from BillInfo where BillID = @1 and FoodID = @2"
        Dim data = DataProvider.Instance.executeQuery(query, {BillID, FoodID})
        If data.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function
End Class
