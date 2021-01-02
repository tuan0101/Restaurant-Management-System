Imports System.Data.OleDb

Public Class OrderScreen
    ' Used for PayScreen Sub-total
    Dim salesTax As Double
    Dim SubTotalsalesTax As Double
    Dim Total As Double = 0
    ' get this ID from table tag
    Public tableID As Integer
    Public empID As String


    Private Sub OrderScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        FoodItemGridView.RowHeadersWidth = 25

        showBill(tableID)


        loadFunctions()

    End Sub

    Private Sub loadFunctions()
        ' Show the list of Items when load this form
        Dim query = "select FoodItem from FoodItems"
        FoodItemGridView.DataSource = DataProvider.Instance.executeQuery(query)

        ' display carry out order
        If empID.ToString().Substring(0, 1) = 3 Then
            OrderListView.Items.Clear()
            displayOrder()
            getTableIDForCarryOut()
            If tableID > 16 Then
                showBill(tableID)
            End If

        End If
        ' Show employee name on the top
        Dim empName = AccountDAO.Instance.getEmpNameBy(empID)
        userTabPage.Text += " (" + empName + ")"

    End Sub

    Private Sub allButton_Click(sender As Object, e As EventArgs) Handles allButton.Click
        Dim query = "select FoodItem from FoodItems"
        FoodItemGridView.DataSource = DataProvider.Instance.executeQuery(query)
    End Sub

    Private Sub SpecialsButton_Click(sender As Object, e As EventArgs) Handles SpecialsButton.Click
        selectCategory("Specials")
    End Sub


    Private Sub SaladsButton_Click(sender As Object, e As EventArgs) Handles SaladsButton.Click
        selectCategory("Salads")
    End Sub
    Private Sub DessertsButton_Click(sender As Object, e As EventArgs) Handles DessertsButton.Click
        selectCategory("Desserts")
    End Sub

    Private Sub DrinksButton_Click(sender As Object, e As EventArgs) Handles DrinksButton.Click
        selectCategory("Drinks")
    End Sub
    Private Sub AppsButton_Click(sender As Object, e As EventArgs) Handles AppsButton.Click
        selectCategory("Appetizers")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        LoginForm.Show()
        LoginForm.EmployeeIDTextBox.Clear()


    End Sub




    Private Sub selectCategory(ctgry As String)
        Dim query = "select FoodItem from FoodItems where Category=@ctgry"
        FoodItemGridView.DataSource = DataProvider.Instance.executeQuery(query, {ctgry})
    End Sub



    Public Sub showBill(tableID As Integer)
        OrderListView.Items.Clear()

        Dim billInfoList = MenuDAO.Instance.getMenuListBy(tableID)

        Dim total As Double = 0

        For Each item As Menu In billInfoList
            Dim lvItem As ListViewItem = New ListViewItem(item.FoodItem.ToString())
            lvItem.SubItems.Add(item.Count.ToString())
            lvItem.SubItems.Add("$" + item.Price.ToString())
            lvItem.SubItems.Add("$" + item.TotalPrice.ToString())
            total += item.TotalPrice

            OrderListView.Items.Add(lvItem)
        Next
        TotalTextBox.Text = total.ToString("C2")

    End Sub

    Private Sub BillButton_Click(sender As Object, e As EventArgs)
        showBill(tableID)
    End Sub

    Private Sub updateBill(tableID As Integer)
        'tableID = 9
        Dim billID = BillDAO.Instance.getUnCheckedBillBy(tableID)
        Dim i = FoodItemGridView.CurrentRow.Index
        Dim foodItem = FoodItemGridView.Item(0, i).Value
        Dim foodID = FoodItemDAO.Instance.getFoodIDby(foodItem)

        ' Check if the table already has a bill
        If billID = -1 Then
            BillDAO.Instance.insertBill(tableID)
            BillInfoDAO.Instance.insertBillInfo(BillDAO.Instance.getMaxBillID(), foodID, 1)
            changeTableStatusToFull(tableID) 'Change to Full when add a bill
        Else
            ' Check if the foodItem and the bill already there, get Count +1
            If BillInfoDAO.Instance.checkExistFoodItem(billID, foodID) Then
                Dim count = BillInfoDAO.Instance.getCount(billID, foodID)
                BillInfoDAO.Instance.updateBillinfo(billID, foodID, count + 1)
            Else

                BillInfoDAO.Instance.insertBillInfo(billID, foodID, 1)
            End If
        End If
    End Sub


    Private Sub FoodItemGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles FoodItemGridView.CellContentClick
        'Dim value As Object = FoodItemGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        'OrderListBox.Items.Add(value)
        'OrderListBox.Sorted = True
        updateBill(tableID)
        showBill(tableID)
    End Sub

    Private Sub DeleteOrderButton_Click(sender As Object, e As EventArgs) Handles DeleteOrderButton.Click
        Dim billID = BillDAO.Instance.getUnCheckedBillBy(tableID)
        Dim foodItem = ""
        Try
            foodItem = OrderListView.SelectedItems(0).Text
        Catch ex As Exception
            MessageBox.Show("Select the Item to delete first")
        End Try

        If foodItem <> "" Then
            Dim foodID = FoodItemDAO.Instance.getFoodIDby(foodItem)
            Dim count = BillInfoDAO.Instance.getCount(billID, foodID)
            Dim newCount = count - 1
            If newCount > 0 Then
                BillInfoDAO.Instance.updateBillinfo(billID, foodID, newCount)
            Else
                BillInfoDAO.Instance.deleteBillinfo(billID, foodID)
            End If
            showBill(tableID)
        End If


    End Sub

    Private Sub displayOrderButton_Click(sender As Object, e As EventArgs) Handles displayOrderButton.Click
        showBill(tableID)
    End Sub

    Private Sub PayButton_Click_1(sender As Object, e As EventArgs) Handles PayButton.Click
        Dim billID = BillDAO.Instance.getUnCheckedBillBy(tableID)
        Dim total = CType(TotalTextBox.Text, Double)
        Dim totalPrice = getTotal(total) ' after tax
        If billID <> -1 Then
            If (MessageBox.Show("Are you sure to check out this bill", "Confirm",
                    MessageBoxButtons.OKCancel) = DialogResult.OK) Then
                BillDAO.Instance.pay(billID, totalPrice)
                changeTableStatusToEmpty(tableID)
                If tableID > 16 Then
                    TableDAO.Instance.deleteCarryOutTable(tableID)
                    displayOrder()
                    getTableIDForCarryOut()
                End If
                showBill(tableID)
            End If
        End If
        Me.Hide()
        PayScreen.Show()

    End Sub

    Private Sub changeTableStatusToFull(tableID As Integer)
        Dim query = "update DiningTable set [Status] = 'Full' where ID = @1"
        DataProvider.Instance.executeNonQuery(query, {tableID})
    End Sub

    Private Sub changeTableStatusToEmpty(tableID As Integer)
        Dim query = "update DiningTable set [Status] = 'Empty' where ID = @1"
        DataProvider.Instance.executeNonQuery(query, {tableID})
    End Sub

    Private Sub logOutButton_Click(sender As Object, e As EventArgs) Handles logOutButton.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Hide()
        'TableSelection.Show()
        Using TableSelection As New TableSelection(empID.Substring(1, 1)) 'to get ID selection
            TableSelection.ShowDialog()
        End Using
    End Sub

    Private Function getTotal(totalPrice As Double) As Double
        SubTotalsalesTax = totalPrice
        salesTax = SubTotalsalesTax * 0.06
        Total = Math.Round(salesTax + SubTotalsalesTax, 2)

        PayScreen.subTotalLabel.Text = "Sub-Total:" + SubTotalsalesTax.ToString("C2")
        PayScreen.taxLabel.Text = "Tax:          " + salesTax.ToString("C2")
        PayScreen.totalTextBox.Text = Total.ToString("C2")

        Return Total
    End Function




    '' for Carry Out section
    Private Sub displayOrder()
        Dim query = "select TableName as Orders from DiningTable where ID > 16"
        carryOutGridView.DataSource = DataProvider.Instance.executeQuery(query)
    End Sub

    Private Function displayName() As String
        Dim query = "select TableName as Orders from DiningTable where ID = @1"
        Return DataProvider.Instance.executeScalar(query, {tableID}).ToString()
    End Function
    Private Sub newOrderButton_Click(sender As Object, e As EventArgs) Handles newOrderButton.Click
        TableDAO.Instance.insertCarryOut()
        displayOrder()
        OrderListView.Items.Clear()
        ' select the new row when creating a new carry out order
        Dim row = carryOutGridView.Rows.Count - 1
        If row > 0 Then
            carryOutGridView.ClearSelection()
            carryOutGridView.Refresh()
            'carryOutGridView.Rows(row).Selected = True
            carryOutGridView.CurrentCell = carryOutGridView.Rows(row).Cells(0)
        End If
        getTableIDForCarryOut()

        'displayOrder()
    End Sub

    Private Sub carryOutDataGridView(sender As Object, e As DataGridViewCellEventArgs) Handles carryOutGridView.CellContentClick
        getTableIDForCarryOut()
        showBill(tableID)
    End Sub

    Private Sub getTableIDForCarryOut()
        If carryOutGridView.Rows.Count > 0 Then
            Dim i = carryOutGridView.CurrentRow.Index
            Dim tableName = carryOutGridView.Item(0, i).Value
            tableID = TableDAO.Instance.getTableIDBy(tableName)
            TableNumberLabel.Text = displayName()
        End If

    End Sub
End Class