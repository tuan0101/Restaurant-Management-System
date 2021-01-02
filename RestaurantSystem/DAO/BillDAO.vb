

Public Class BillDAO
    Private Shared inst As BillDAO
    Private Sub New()

    End Sub
    Public Shared Property Instance As BillDAO
        Get
            If (inst Is Nothing) Then
                inst = New BillDAO
            End If

            Return BillDAO.inst
        End Get
        Private Set(ByVal value As BillDAO)
            inst = value
        End Set
    End Property

    Public Function getUnCheckedBillBy(id As Integer) As Integer
        Dim query = "Select * from Bill where TableID = @1 and Status = @2"
        Dim data = DataProvider.Instance.executeQuery(query, {id, "Unchecked"})
        If data.Rows.Count > 0 Then
            Dim bill = New Bill(data.Rows(0))
            Return bill.BillID
        End If
        Return -1
    End Function


    Public Sub insertBill(tableID As Integer)
        Dim query = "insert into Bill ([TableID], [Status], CheckIn, CheckOut)
                    values (@1, @2, @3, @4)"
        Dim data = DataProvider.Instance.executeNonQuery(query, {tableID, "Unchecked", DateTime.Now.ToString(), DBNull.Value})
    End Sub

    Public Function getMaxBillID() As Integer
        Dim query = "select max(ID) from Bill"
        Try
            Return CInt(DataProvider.Instance.executeScalar(query))
        Catch ex As Exception
            Return 1
        End Try
    End Function

    Public Sub pay(billID As Integer, totalPrice As Double)
        Dim query = "update Bill set [Checkout] = @1, Status = @2, TotalPrice = @3 where ID = @4"
        DataProvider.Instance.executeNonQuery(query, {Now.ToString(), "Checked", totalPrice, billID})
    End Sub

    Public Function getBillListByDate(checkin As Date, checkout As Date) As DataTable
        Dim query = "select t.TableName, b.TotalPrice, CheckIn, CheckOut
                 from Bill as b, DiningTable as t where Checkin >= @1 and CheckOut <= @2
                 and b.Status = 'Checked' and t.ID = b.TableID"
        Return DataProvider.Instance.executeQuery(query, {checkin, checkout})
    End Function


    Public Function getTableIDBy(billID As Integer) As Integer
        Dim query = "select TableID from Bill where ID = @1"
        Dim data = DataProvider.Instance.executeScalar(query, {billID})
        Return CInt(data)
    End Function


End Class
