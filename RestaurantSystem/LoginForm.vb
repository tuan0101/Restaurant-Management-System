Imports System.Data.OleDb
Imports System.Data

Public Class LoginForm

    Dim connection As New OleDbConnection(My.Settings.Restaurant_DatabaseVer12002_03ConnectionString)


    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        'Empty textbox
        If EmployeeIDTextBox.Text = Nothing Then
            MsgBox("Enter employee number!", MsgBoxStyle.Exclamation)
            'Employee number entered
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            'search for employee number in database
            Dim cmd As New OleDbCommand("select count(*) from EmployeeInfo where EmployeeID=?", connection)
            'insert parameter from textbox1
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = EmployeeIDTextBox.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            'successful login
            If (count > 0) Then
                Select Case EmployeeIDTextBox.Text.Substring(0, 1)
                    Case 1
                        MainScreen.Show()
                    'Number starts with 2 takes user to waiter screen
                    Case 2
                        Dim idNumber = EmployeeIDTextBox.Text.Substring(1, 1)
                        'TableSelection.idNumber = EmployeeIDTextBox.Text.Substring(1, 1)
                        'TableSelection.Show()
                        Using TableSelection As New TableSelection(idNumber)

                            OrderScreen.Refresh()
                            OrderScreen.empID = EmployeeIDTextBox.Text
                            OrderScreen.newOrderButton.Visible = False
                            OrderScreen.carryOutGridView.Visible = False

                            TableSelection.ShowDialog()
                        End Using
                    'Number starts with 3 takes user to carry-out screen
                    Case 3
                        'carry out screen show
                        OrderScreen.Refresh()
                        OrderScreen.empID = EmployeeIDTextBox.Text
                        OrderScreen.backButton.Visible = False
                        OrderScreen.Show()
                    Case Else
                        ' Chef screen
                        OrderViewer.Show()

                End Select

                OrderScreen.empID = EmployeeIDTextBox.Text

                Me.Hide()
            Else
                'Failed login
                EmployeeIDTextBox.SelectionStart = 0
                EmployeeIDTextBox.SelectionLength = EmployeeIDTextBox.Text.Length()
                EmployeeIDTextBox.Select()
                MsgBox("Employee NOT found", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmployeeIDTextBox.Clear()
    End Sub
End Class
