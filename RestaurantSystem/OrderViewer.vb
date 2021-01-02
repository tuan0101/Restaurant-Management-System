Public Class OrderViewer
    Private Sub OrderViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim query = "select ID, Format(Checkin, 'hh:mm am/pm') as CheckInTime from Bill where Status = 'Unchecked'"
        orderListDataGridView.DataSource = DataProvider.Instance.executeQuery(query)

    End Sub





    Private Sub orderListDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles orderListDataGridView.CellClick
        Dim query = "select f.FoodItem, bi.Amount from BillInfo as bi, Bill as b, FoodItems as f
                    where bi.BillID = b.ID and bi.FoodID = f.ID and b.Status = 'Unchecked' and b.TableID = @1"
        Try
            Dim i = orderListDataGridView.CurrentRow.Index
            Dim billID = orderListDataGridView.Item(0, i).Value
            Dim tableID = BillDAO.Instance.getTableIDBy(billID)
            orderInfoDataGridView.DataSource = DataProvider.Instance.executeQuery(query, {tableID})
        Catch ex As Exception
            MessageBox.Show("There is no bill at the moment, please try again!")
        End Try

    End Sub

    Private Sub logOutButton_Click(sender As Object, e As EventArgs) Handles logOutButton.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    'VB bugs
    'Private Sub show1()
    '    orderInfoListview.Clear()
    '    Dim i = orderListDataGridView.CurrentRow.Index
    '    Dim billID = orderListDataGridView.Item(0, i).Value

    '    Dim tableID = BillDAO.Instance.getTableIDBy(billID)
    '    Dim orderList = MenuDAO.Instance.getMenuListBy(tableID)

    '    For Each item As Menu In orderList
    '        Dim lvItem As ListViewItem = New ListViewItem(item.FoodItem.ToString())
    '        lvItem.SubItems.Add(item.Count.ToString())

    '        orderInfoListview.Items.Add(lvItem)
    '    Next
    'End Sub
End Class