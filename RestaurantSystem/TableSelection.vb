Public Class TableSelection

    Dim idNumber As String
    Dim ButtonName As String

    Public Sub New(idNumberFromLogin As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        idNumber = idNumberFromLogin
    End Sub

    Private Sub TableSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim tableList = saveButton()
        Dim x As Integer = 0

        For i As Integer = 1 To 4
            For j As Integer = 1 To 4

                Dim tableSection As Integer = Convert.ToInt32(tableList(x).Name.Substring(5, 1))

                If idNumber = tableSection Then
                    TableDAO.Instance.changeColorBy(x + 1, tableList(x)) 'table id = x+1
                Else
                    TableDAO.Instance.disableButton(tableList(x))
                End If
                x += 1
            Next
        Next

    End Sub

    Private Sub Table1Button_Click(sender As Object, e As EventArgs) Handles Table1Button1.Click, Table1Button2.Click, Table1Button3.Click, Table1Button4.Click, Table2Button5.Click, Table2Button6.Click, Table2Button7.Click, Table2Button8.Click,
            Table3Button9.Click, Table3Button10.Click, Table3Button11.Click, Table3Button12.Click, Table4Button13.Click, Table4Button14.Click, Table4Button15.Click, Table4Button16.Click

        'Click on table one and
        'show order screen and change table number

        OrderScreen.Show()

        ' Use sender to apply for every button
        OrderScreen.TableNumberLabel.Text = sender.Tag.ToString()
        OrderScreen.tableID = sender.Tag
        OrderScreen.showBill(OrderScreen.tableID)
        Me.Close()
    End Sub

    Private Function saveButton() As List(Of Button)
        Dim tableList As New List(Of Button)
        Dim x = 0
        For i As Integer = 1 To 4
            For j As Integer = 1 To 4
                x += 1
                tableList.Add(CType(Me.Controls.Find(String.Format("Table{0}Button{1}", i, x), True)(0), Button))
            Next
        Next

        Return tableList
    End Function


End Class