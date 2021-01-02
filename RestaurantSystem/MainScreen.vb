Public Class MainScreen

    Dim foodList As BindingSource = New BindingSource
    Dim accountList As BindingSource = New BindingSource
#Region "Events"
    Private Sub logoutButton_Click(sender As Object, e As EventArgs)
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.CenterToParent()
        loadFunctions()
    End Sub
#End Region

#Region "Methods"
    Private Sub loadFunctions()
        FoodItemDataGridView.DataSource = foodList
        AccountDataGridView.DataSource = accountList
        loadAccountList()
        loadFoodList()
        addFoodBinding()
        loadCategory()
        addAccountBinding()

    End Sub
    Private Sub addAccountBinding()
        accountIDTextBox.DataBindings.Add(New Binding("Text", AccountDataGridView.DataSource,
                                            "EmployeeID", True, DataSourceUpdateMode.Never))
        accountFNTextBox.DataBindings.Add(New Binding("Text", AccountDataGridView.DataSource,
                                            "EmployeeFName", True, DataSourceUpdateMode.Never))
        accountLNTextBox.DataBindings.Add(New Binding("Text", AccountDataGridView.DataSource,
                                            "EmployeeLName", True, DataSourceUpdateMode.Never))
        accountTypeTextBox.DataBindings.Add(New Binding("Text", AccountDataGridView.DataSource,
                                            "Type", True, DataSourceUpdateMode.Never))
    End Sub
    Private Sub loadAccountList()
        accountList.DataSource = AccountDAO.Instance.getListAccount()
    End Sub

    Private Sub loadFoodList()

        foodList.DataSource = FoodItemDAO.Instance.getListFood()
    End Sub

    Private Sub addFoodBinding()
        'FoodName is the name of a function in FoodItem class
        'FoodItem is the field name in the database
        FoodNameTextBox.DataBindings.Add(New Binding("Text", FoodItemDataGridView.DataSource,
                                          "FoodName", True, DataSourceUpdateMode.Never))
        PriceTextBox.DataBindings.Add(New Binding("Text", FoodItemDataGridView.DataSource,
                                           "getPrice", True, DataSourceUpdateMode.Never))
        CategoryComboBox.DataBindings.Add(New Binding("Text", FoodItemDataGridView.DataSource,
                                           "Category", True, DataSourceUpdateMode.Never))
        FoodIDTextBox.DataBindings.Add(New Binding("Text", FoodItemDataGridView.DataSource,
                                           "FoodID", True, DataSourceUpdateMode.Never))
    End Sub

    Function searchFoodItem(name As String) As List(Of FoodItem)
        Dim foodList As List(Of FoodItem) = FoodItemDAO.Instance.searchFoodItem(name)
        Return foodList
    End Function

#End Region

#Region "Events"


    Private Sub loadCategory()
        'CategoryComboBox.DataSource = FoodItemDAO.Instance.getCategoryList1()
        For Each item In FoodItemDAO.Instance.getCategoryList()
            CategoryComboBox.Items.Add(item)
        Next
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        loadFoodList()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim id = FoodIDTextBox.Text
        Dim name = FoodNameTextBox.Text
        Dim category = CategoryComboBox.Text
        Dim price = PriceTextBox.Text

        If (FoodItemDAO.Instance.insertFoodItem(id, name, category, price)) Then
            MessageBox.Show("Add the item successfully!")
            loadFoodList()
        Else
            MessageBox.Show("Failed to add the item!!!")
        End If
        loadFoodList()
    End Sub

    Private Sub ChangeButton_Click(sender As Object, e As EventArgs) Handles ChangeButton.Click
        Dim id = FoodIDTextBox.Text
        Dim name = FoodNameTextBox.Text
        Dim category = CategoryComboBox.Text
        Dim price = PriceTextBox.Text

        If (FoodItemDAO.Instance.changeFoodItem(id, name, category, price)) Then
            MessageBox.Show("Update the item successfully!")
            loadFoodList()
        Else
            MessageBox.Show("Failed to update the item!!!")
        End If
        loadFoodList()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim id = FoodIDTextBox.Text
        If FoodItemDAO.Instance.deleteFoodItem(id) Then
            MessageBox.Show("Delete the item successfully!")
            loadFoodList()
        Else
            MessageBox.Show("Failed to delete the item!!!")
        End If
        loadFoodList()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        foodList.DataSource = searchFoodItem(SearchTextBox.Text)
    End Sub

    Private Sub addEmpButton_Click(sender As Object, e As EventArgs) Handles addEmpButton.Click
        Dim id = accountIDTextBox.Text
        Dim fName = accountFNTextBox.Text
        Dim lName = accountLNTextBox.Text
        Dim type = accountTypeTextBox.Text

        If (AccountDAO.Instance.insertEmp(id, fName, lName, type)) Then
            MessageBox.Show("Add the employee successfully!")
            loadFoodList()
        Else
            MessageBox.Show("Failed to add the employee!!!")
        End If
        loadAccountList()
    End Sub

    Private Sub dspEmpButton_Click(sender As Object, e As EventArgs) Handles dspEmpButton.Click
        loadAccountList()
    End Sub

    Private Sub changeEmpButton_Click(sender As Object, e As EventArgs) Handles changeEmpButton.Click
        Dim id = accountIDTextBox.Text
        Dim fName = accountFNTextBox.Text
        Dim lName = accountLNTextBox.Text
        Dim type = accountTypeTextBox.Text

        If (AccountDAO.Instance.changeEmp(id, fName, lName, type)) Then
            MessageBox.Show("Update the employee successfully!")
            loadFoodList()
        Else
            MessageBox.Show("Failed to update the employee!!!")
        End If
        'refresh the screen after making a change.
        loadAccountList()
    End Sub

    Private Sub delEmpButton_Click(sender As Object, e As EventArgs) Handles delEmpButton.Click
        Dim id = accountIDTextBox.Text
        If AccountDAO.Instance.deleteEmp(id) Then
            MessageBox.Show("Delete the employee successfully!")
            loadFoodList()
        Else
            MessageBox.Show("Failed to delete the employee!!!")
        End If
        'Take effect after deleting
        loadAccountList()
    End Sub

    Private Sub logOutButton_Click_1(sender As Object, e As EventArgs) Handles logOutButton.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub reportButton_Click(sender As Object, e As EventArgs) Handles reportButton.Click
        loadBillListBy(DateTimePicker1.Value, DateTimePicker2.Value)
        sumTextBox.Text = (From row As DataGridViewRow In billDataGridView.Rows
                           Where row.Cells(1).FormattedValue.ToString() <> String.Empty
                           Select Convert.ToDouble(row.Cells(1).FormattedValue)).Sum().ToString("C2")
    End Sub

    Private Sub loadBillListBy(checkin As Date, checkout As Date)
        billDataGridView.DataSource = BillDAO.Instance.getBillListByDate(checkin, checkout)
    End Sub






#End Region
End Class