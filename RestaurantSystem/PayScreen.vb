Public Class PayScreen
    Dim inputNumber As Double = 0
    Dim salesTax As Decimal
    Dim SubTotalsalesTax As Decimal
    Dim Total As Decimal = 0

    Dim Discount As Decimal

    Dim creditCardNumber As String
    Dim creditCardExp As String
    Dim discountInput As String


    'Using Exit to Go back to OrderScreen
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Hide()
        OrderScreen.Show()
    End Sub

    Private Sub keyPadBackBtn_Click(sender As Object, e As EventArgs) Handles keyPadBackBtn.Click
        If keyPadInputTextBox.Text < " " Then

            keyPadInputTextBox.Text = Mid(keyPadInputTextBox.Text, 1, Len(keyPadInputTextBox.Text) - 1 + 1)

        Else

            keyPadInputTextBox.Text = Mid(keyPadInputTextBox.Text, 1, Len(keyPadInputTextBox.Text) - 1)

        End If
    End Sub


    'Cash button gives a message box showing the change owed 
    Private Sub cashBtn_Click(sender As Object, e As EventArgs) Handles cashBtn.Click
        Dim changeCash As Decimal = 0
        Dim keyPadInputDecimal As Decimal
        keyPadInputDecimal = Decimal.Parse(keyPadInputTextBox.Text)

        Total = totalTextBox.Text
        If keyPadInputDecimal > Total Then
            changeCash = keyPadInputDecimal - Total
            MessageBox.Show("Change:" + changeCash.ToString("C"))
            Me.Close()
            OrderScreen.Show()
        ElseIf keyPadInputDecimal <= Total Then
            Total = Total - keyPadInputDecimal
            totalLabel.Text = "Total : " + Total.ToString("C")

        End If

    End Sub
    'Credit Card Process (need to add a procedure to collect the data entered to send back to access file)
    Private Sub creditBtn_Click(sender As Object, e As EventArgs) Handles creditBtn.Click
        Dim input As Integer
        creditCardNumber = InputBox("Enter Card Number: ")
        Dim ValidInput As Boolean = Integer.TryParse(creditCardNumber, input)

        If ValidInput = False Then
            MsgBox("Please Enter a valid Credit Card Number", MsgBoxStyle.Exclamation)
        Else
            creditCardExp = InputBox("Enter Expiration:")
            Dim ValidInputExp As Boolean = Integer.TryParse(creditCardExp, input)
            If ValidInputExp = False Then
                MsgBox("Please Enter a valid Expiration Date", MsgBoxStyle.Exclamation)
            Else
                MessageBox.Show("CreditCard Processed")
                Me.Close()
                'TableSelection.Show()
            End If
        End If
    End Sub

    Private Sub discountBtn_Click(sender As Object, e As EventArgs) Handles discountBtn.Click
        Dim input As Integer
        Dim divDiscount As Decimal
        Dim finalDiscount As Decimal
        discountInput = InputBox("Enter Discount %: ")
        Dim ValidInput As Boolean = Double.TryParse(discountInput, input)
        If ValidInput = False Then
            MsgBox("Please Enter a valid Credit Card Number", MsgBoxStyle.Exclamation)
        Else
            divDiscount = totalTextBox.Text / 100
            finalDiscount = divDiscount * discountInput
            totalTextBox.Text = totalTextBox.Text - finalDiscount
            MsgBox("Discount Applied: Savings of " + finalDiscount.ToString("C2"))
        End If
    End Sub

    Private Sub keyPadInputTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles keyPadInputTextBox.KeyPress
        'Allow textbox to accept only numbers and the Backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles keyPadZeroBtn.Click, keyPadTwoBtn.Click, keyPadThreeBtn.Click, keyPadSixBtn.Click, keyPadSevenBtn.Click, keyPadOneBtn.Click, keyPadNineBtn.Click, keyPadFourBtn.Click, keyPadFiveBtn.Click, keyPadEightBtn.Click
        Dim b As Button = sender
        If keyPadInputTextBox.Text = "0" Then
            keyPadInputTextBox.Text = b.Text
        Else
            keyPadInputTextBox.Text = keyPadInputTextBox.Text + b.Text
        End If
    End Sub

    Private Sub keyPadDecimalBtn_Click(sender As Object, e As EventArgs) Handles keyPadDecimalBtn.Click
        If InStr(keyPadInputTextBox.Text, ".") = 0 Then
            keyPadInputTextBox.Text = keyPadInputTextBox.Text + "."
        End If
    End Sub

    Private Sub fiveDollarBtn_Click(sender As Object, e As EventArgs) Handles fiveDollarBtn.Click
        Dim changeCash As Decimal = 0
        Dim keyPadInputDecimal As Decimal = 5

        chargeCash(keyPadInputDecimal, changeCash)

    End Sub

    Private Sub tenDollarBtn_Click(sender As Object, e As EventArgs) Handles tenDollarBtn.Click
        Dim changeCash As Decimal = 0
        Dim keyPadInputDecimal As Decimal = 10

        chargeCash(keyPadInputDecimal, changeCash)

    End Sub

    Private Sub fiveteenDollarBtn_Click(sender As Object, e As EventArgs) Handles fiveteenDollarBtn.Click
        Dim changeCash As Decimal = 0
        Dim keyPadInputDecimal As Decimal = 15

        chargeCash(keyPadInputDecimal, changeCash)

    End Sub

    Private Sub twentyDollarBtn_Click(sender As Object, e As EventArgs) Handles twentyDollarBtn.Click
        Dim changeCash As Decimal = 0
        Dim keyPadInputDecimal As Decimal = 20

        chargeCash(keyPadInputDecimal, changeCash)

    End Sub

    Private Sub fiftyDollarBtn_Click(sender As Object, e As EventArgs) Handles fiftyDollarBtn.Click
        Dim changeCash As Decimal = 0
        Dim keyPadInputDecimal As Decimal = 50
        chargeCash(keyPadInputDecimal, changeCash)

    End Sub

    Private Sub hundredDollarBtn_Click(sender As Object, e As EventArgs) Handles hundredDollarBtn.Click
        Dim changeCash As Decimal = 0
        Dim keyPadInputDecimal As Decimal = 100

        chargeCash(keyPadInputDecimal, changeCash)

    End Sub

    Private Sub voidBtn_Click(sender As Object, e As EventArgs) Handles voidBtn.Click
        Total = totalTextBox.Text
        MessageBox.Show("The Amount of " + Total.ToString + " has been voided")
        OrderScreen.Show()
    End Sub

    Private Sub chargeCash(keyPadInputDecimal As Decimal, changeCash As Decimal)
        Total = totalTextBox.Text
        If keyPadInputDecimal > Total Then

            changeCash = keyPadInputDecimal - Total
            MessageBox.Show("Change:" + changeCash.ToString("C"))
            Me.Close()
            OrderScreen.Show()
        ElseIf keyPadInputDecimal <= Total Then
            Total = Total - keyPadInputDecimal
            totalTextBox.Text = Total
        End If
    End Sub

    Private Sub PayScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class