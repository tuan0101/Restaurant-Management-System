Public Class TableDAO
    Private Shared inst As TableDAO
    Private Sub New()

    End Sub
    Public Shared Property Instance As TableDAO
        Get
            If (inst Is Nothing) Then
                inst = New TableDAO
            End If

            Return TableDAO.inst
        End Get
        Private Set(ByVal value As TableDAO)
            inst = value
        End Set
    End Property

    Public Sub changeColorBy(tableID As Integer, bt As Button)
        Dim query = "select Status from DiningTable where ID = @1"
        Dim data = DataProvider.Instance.executeScalar(query, {tableID})
        Dim status = data.ToString()

        bt.FlatStyle = FlatStyle.Flat
        bt.FlatAppearance.BorderSize = 5


        If status = "Empty" Then
            bt.FlatAppearance.BorderColor = Color.Blue
        Else
            bt.FlatAppearance.BorderColor = Color.Red
        End If

    End Sub

    Public Sub disableButton(bt As Button)
        bt.Enabled = False
    End Sub

    Public Function getMaxTableID() As Integer
        Dim query = "select max(ID) from DiningTable"
        Return CInt(DataProvider.Instance.executeScalar(query))
    End Function
    Public Sub insertCarryOut()
        Dim maxID = getMaxTableID() + 1
        Dim coNumber = maxID - 16
        Dim query = "insert into DiningTable (ID, TableName, Status)
                      values (@1, @2, 'Empty')"
        DataProvider.Instance.executeNonQuery(query, {maxID, String.Format("CarryOut {0}", coNumber)})
    End Sub

    Public Function getTableIDBy(tableName As String) As Integer
        Dim query = "select ID from DiningTable where TableName = @1"
        Dim data = DataProvider.Instance.executeScalar(query, {tableName})
        Return CInt(data)
    End Function

    Public Sub deleteCarryOutTable(tableID As Integer)
        Dim query = "delete * from DiningTable where ID = @1"
        DataProvider.Instance.executeNonQuery(query, {tableID})
    End Sub
End Class
