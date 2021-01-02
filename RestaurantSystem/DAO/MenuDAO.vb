
Public Class MenuDAO
    Private Shared inst As MenuDAO
    Private Sub New()

    End Sub
    Public Shared Property Instance As MenuDAO
        Get
            If (inst Is Nothing) Then
                inst = New MenuDAO
            End If

            Return MenuDAO.inst
        End Get
        Private Set(ByVal value As MenuDAO)
            inst = value
        End Set
    End Property

    Public Function getMenuListBy(tableID As Integer) As List(Of Menu)
        Dim menuList = New List(Of Menu)
        Dim query = "select f.FoodItem, bi.Amount, f.Price, f.Price*bi.Amount as TotalPrice from BillInfo as bi, Bill as b, FoodItems as f
                    where bi.BillID = b.ID and bi.FoodID = f.ID and b.Status = 'Unchecked' and b.TableID = @1"
        Dim data = DataProvider.Instance.executeQuery(query, {tableID})

        For Each item As DataRow In data.Rows
            Dim menu = New Menu(item)
            menuList.Add(menu)
        Next
        Return menuList
    End Function
End Class
