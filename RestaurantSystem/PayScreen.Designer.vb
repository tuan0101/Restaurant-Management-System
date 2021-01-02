<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PayScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayScreen))
        Me.keyPadDecimalBtn = New System.Windows.Forms.Button()
        Me.keyPadZeroBtn = New System.Windows.Forms.Button()
        Me.fiveDollarBtn = New System.Windows.Forms.Button()
        Me.cashBtn = New System.Windows.Forms.Button()
        Me.creditBtn = New System.Windows.Forms.Button()
        Me.voidBtn = New System.Windows.Forms.Button()
        Me.keyPadInputTextBox = New System.Windows.Forms.TextBox()
        Me.discountBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.keyPadBackBtn = New System.Windows.Forms.Button()
        Me.keyPadSevenBtn = New System.Windows.Forms.Button()
        Me.keyPadFourBtn = New System.Windows.Forms.Button()
        Me.keyPadFiveBtn = New System.Windows.Forms.Button()
        Me.keyPadSixBtn = New System.Windows.Forms.Button()
        Me.keyPadNineBtn = New System.Windows.Forms.Button()
        Me.keyPadEightBtn = New System.Windows.Forms.Button()
        Me.keyPadOneBtn = New System.Windows.Forms.Button()
        Me.keyPadTwoBtn = New System.Windows.Forms.Button()
        Me.keyPadThreeBtn = New System.Windows.Forms.Button()
        Me.fiftyDollarBtn = New System.Windows.Forms.Button()
        Me.twentyDollarBtn = New System.Windows.Forms.Button()
        Me.fiveteenDollarBtn = New System.Windows.Forms.Button()
        Me.tenDollarBtn = New System.Windows.Forms.Button()
        Me.hundredDollarBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.subTotalLabel = New System.Windows.Forms.Label()
        Me.taxLabel = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.totalGroupBox = New System.Windows.Forms.GroupBox()
        Me.totalTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.totalGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'keyPadDecimalBtn
        '
        Me.keyPadDecimalBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyPadDecimalBtn.Location = New System.Drawing.Point(7, 292)
        Me.keyPadDecimalBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.keyPadDecimalBtn.Name = "keyPadDecimalBtn"
        Me.keyPadDecimalBtn.Size = New System.Drawing.Size(75, 44)
        Me.keyPadDecimalBtn.TabIndex = 4
        Me.keyPadDecimalBtn.Text = "."
        Me.keyPadDecimalBtn.UseVisualStyleBackColor = True
        '
        'keyPadZeroBtn
        '
        Me.keyPadZeroBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyPadZeroBtn.Location = New System.Drawing.Point(100, 292)
        Me.keyPadZeroBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.keyPadZeroBtn.Name = "keyPadZeroBtn"
        Me.keyPadZeroBtn.Size = New System.Drawing.Size(75, 44)
        Me.keyPadZeroBtn.TabIndex = 5
        Me.keyPadZeroBtn.Text = "0"
        Me.keyPadZeroBtn.UseVisualStyleBackColor = True
        '
        'fiveDollarBtn
        '
        Me.fiveDollarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fiveDollarBtn.Location = New System.Drawing.Point(292, 96)
        Me.fiveDollarBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.fiveDollarBtn.Name = "fiveDollarBtn"
        Me.fiveDollarBtn.Size = New System.Drawing.Size(76, 37)
        Me.fiveDollarBtn.TabIndex = 15
        Me.fiveDollarBtn.Text = "5"
        Me.fiveDollarBtn.UseVisualStyleBackColor = True
        '
        'cashBtn
        '
        Me.cashBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cashBtn.Location = New System.Drawing.Point(7, 345)
        Me.cashBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.cashBtn.Name = "cashBtn"
        Me.cashBtn.Size = New System.Drawing.Size(112, 37)
        Me.cashBtn.TabIndex = 18
        Me.cashBtn.Text = "Cash "
        Me.cashBtn.UseVisualStyleBackColor = True
        '
        'creditBtn
        '
        Me.creditBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creditBtn.Location = New System.Drawing.Point(174, 346)
        Me.creditBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.creditBtn.Name = "creditBtn"
        Me.creditBtn.Size = New System.Drawing.Size(190, 37)
        Me.creditBtn.TabIndex = 20
        Me.creditBtn.Text = "Credit/Debit"
        Me.creditBtn.UseVisualStyleBackColor = True
        '
        'voidBtn
        '
        Me.voidBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voidBtn.Location = New System.Drawing.Point(7, 388)
        Me.voidBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.voidBtn.Name = "voidBtn"
        Me.voidBtn.Size = New System.Drawing.Size(112, 39)
        Me.voidBtn.TabIndex = 21
        Me.voidBtn.Text = "Void"
        Me.voidBtn.UseVisualStyleBackColor = True
        '
        'keyPadInputTextBox
        '
        Me.keyPadInputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyPadInputTextBox.Location = New System.Drawing.Point(10, 7)
        Me.keyPadInputTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.keyPadInputTextBox.Multiline = True
        Me.keyPadInputTextBox.Name = "keyPadInputTextBox"
        Me.keyPadInputTextBox.Size = New System.Drawing.Size(359, 53)
        Me.keyPadInputTextBox.TabIndex = 22
        Me.keyPadInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'discountBtn
        '
        Me.discountBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discountBtn.Location = New System.Drawing.Point(174, 388)
        Me.discountBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.discountBtn.Name = "discountBtn"
        Me.discountBtn.Size = New System.Drawing.Size(190, 38)
        Me.discountBtn.TabIndex = 23
        Me.discountBtn.Text = "Discount"
        Me.discountBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.Location = New System.Drawing.Point(540, 17)
        Me.exitBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(86, 51)
        Me.exitBtn.TabIndex = 24
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'keyPadBackBtn
        '
        Me.keyPadBackBtn.BackgroundImage = CType(resources.GetObject("keyPadBackBtn.BackgroundImage"), System.Drawing.Image)
        Me.keyPadBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.keyPadBackBtn.Location = New System.Drawing.Point(202, 295)
        Me.keyPadBackBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.keyPadBackBtn.Name = "keyPadBackBtn"
        Me.keyPadBackBtn.Size = New System.Drawing.Size(73, 46)
        Me.keyPadBackBtn.TabIndex = 25
        Me.keyPadBackBtn.UseVisualStyleBackColor = True
        '
        'keyPadSevenBtn
        '
        Me.keyPadSevenBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyPadSevenBtn.Location = New System.Drawing.Point(4, 236)
        Me.keyPadSevenBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.keyPadSevenBtn.Name = "keyPadSevenBtn"
        Me.keyPadSevenBtn.Size = New System.Drawing.Size(75, 44)
        Me.keyPadSevenBtn.TabIndex = 29
        Me.keyPadSevenBtn.Text = "7"
        Me.keyPadSevenBtn.UseVisualStyleBackColor = True
        '
        'keyPadFourBtn
        '
        Me.keyPadFourBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyPadFourBtn.Location = New System.Drawing.Point(4, 178)
        Me.keyPadFourBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.keyPadFourBtn.Name = "keyPadFourBtn"
        Me.keyPadFourBtn.Size = New System.Drawing.Size(75, 44)
        Me.keyPadFourBtn.TabIndex = 30
        Me.keyPadFourBtn.Text = "4"
        Me.keyPadFourBtn.UseVisualStyleBackColor = True
        '
        'keyPadFiveBtn
        '
        Me.keyPadFiveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyPadFiveBtn.Location = New System.Drawing.Point(100, 173)
        Me.keyPadFiveBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.keyPadFiveBtn.Name = "keyPadFiveBtn"
        Me.keyPadFiveBtn.Size = New System.Drawing.Size(75, 44)
        Me.keyPadFiveBtn.TabIndex = 31
        Me.keyPadFiveBtn.Text = "5"
        Me.keyPadFiveBtn.UseVisualStyleBackColor = True
        '
        'keyPadSixBtn
        '
        Me.keyPadSixBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyPadSixBtn.Location = New System.Drawing.Point(223, 176)
        Me.keyPadSixBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.keyPadSixBtn.Name = "keyPadSixBtn"
        Me.keyPadSixBtn.Size = New System.Drawing.Size(75, 44)
        Me.keyPadSixBtn.TabIndex = 32
        Me.keyPadSixBtn.Text = "6"
        Me.keyPadSixBtn.UseVisualStyleBackColor = True
        '
        'keyPadNineBtn
        '
        Me.keyPadNineBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyPadNineBtn.Location = New System.Drawing.Point(202, 236)
        Me.keyPadNineBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.keyPadNineBtn.Name = "keyPadNineBtn"
        Me.keyPadNineBtn.Size = New System.Drawing.Size(75, 44)
        Me.keyPadNineBtn.TabIndex = 33
        Me.keyPadNineBtn.Text = "9"
        Me.keyPadNineBtn.UseVisualStyleBackColor = True
        '
        'keyPadEightBtn
        '
        Me.keyPadEightBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyPadEightBtn.Location = New System.Drawing.Point(100, 236)
        Me.keyPadEightBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.keyPadEightBtn.Name = "keyPadEightBtn"
        Me.keyPadEightBtn.Size = New System.Drawing.Size(75, 44)
        Me.keyPadEightBtn.TabIndex = 34
        Me.keyPadEightBtn.Text = "8"
        Me.keyPadEightBtn.UseVisualStyleBackColor = True
        '
        'keyPadOneBtn
        '
        Me.keyPadOneBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyPadOneBtn.Location = New System.Drawing.Point(7, 118)
        Me.keyPadOneBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.keyPadOneBtn.Name = "keyPadOneBtn"
        Me.keyPadOneBtn.Size = New System.Drawing.Size(75, 44)
        Me.keyPadOneBtn.TabIndex = 35
        Me.keyPadOneBtn.Text = "1"
        Me.keyPadOneBtn.UseVisualStyleBackColor = True
        '
        'keyPadTwoBtn
        '
        Me.keyPadTwoBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyPadTwoBtn.Location = New System.Drawing.Point(100, 118)
        Me.keyPadTwoBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.keyPadTwoBtn.Name = "keyPadTwoBtn"
        Me.keyPadTwoBtn.Size = New System.Drawing.Size(75, 44)
        Me.keyPadTwoBtn.TabIndex = 36
        Me.keyPadTwoBtn.Text = "2"
        Me.keyPadTwoBtn.UseVisualStyleBackColor = True
        '
        'keyPadThreeBtn
        '
        Me.keyPadThreeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyPadThreeBtn.Location = New System.Drawing.Point(223, 117)
        Me.keyPadThreeBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.keyPadThreeBtn.Name = "keyPadThreeBtn"
        Me.keyPadThreeBtn.Size = New System.Drawing.Size(75, 44)
        Me.keyPadThreeBtn.TabIndex = 37
        Me.keyPadThreeBtn.Text = "3"
        Me.keyPadThreeBtn.UseVisualStyleBackColor = True
        '
        'fiftyDollarBtn
        '
        Me.fiftyDollarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fiftyDollarBtn.Location = New System.Drawing.Point(292, 265)
        Me.fiftyDollarBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.fiftyDollarBtn.Name = "fiftyDollarBtn"
        Me.fiftyDollarBtn.Size = New System.Drawing.Size(75, 36)
        Me.fiftyDollarBtn.TabIndex = 38
        Me.fiftyDollarBtn.Text = "50"
        Me.fiftyDollarBtn.UseVisualStyleBackColor = True
        '
        'twentyDollarBtn
        '
        Me.twentyDollarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.twentyDollarBtn.Location = New System.Drawing.Point(292, 227)
        Me.twentyDollarBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.twentyDollarBtn.Name = "twentyDollarBtn"
        Me.twentyDollarBtn.Size = New System.Drawing.Size(78, 36)
        Me.twentyDollarBtn.TabIndex = 39
        Me.twentyDollarBtn.Text = "20"
        Me.twentyDollarBtn.UseVisualStyleBackColor = True
        '
        'fiveteenDollarBtn
        '
        Me.fiveteenDollarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fiveteenDollarBtn.Location = New System.Drawing.Point(292, 186)
        Me.fiveteenDollarBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.fiveteenDollarBtn.Name = "fiveteenDollarBtn"
        Me.fiveteenDollarBtn.Size = New System.Drawing.Size(76, 36)
        Me.fiveteenDollarBtn.TabIndex = 40
        Me.fiveteenDollarBtn.Text = "15"
        Me.fiveteenDollarBtn.UseVisualStyleBackColor = True
        '
        'tenDollarBtn
        '
        Me.tenDollarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tenDollarBtn.Location = New System.Drawing.Point(292, 137)
        Me.tenDollarBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.tenDollarBtn.Name = "tenDollarBtn"
        Me.tenDollarBtn.Size = New System.Drawing.Size(76, 44)
        Me.tenDollarBtn.TabIndex = 41
        Me.tenDollarBtn.Text = "10"
        Me.tenDollarBtn.UseVisualStyleBackColor = True
        '
        'hundredDollarBtn
        '
        Me.hundredDollarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hundredDollarBtn.Location = New System.Drawing.Point(292, 306)
        Me.hundredDollarBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.hundredDollarBtn.Name = "hundredDollarBtn"
        Me.hundredDollarBtn.Size = New System.Drawing.Size(76, 36)
        Me.hundredDollarBtn.TabIndex = 42
        Me.hundredDollarBtn.Text = "100"
        Me.hundredDollarBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.keyPadOneBtn)
        Me.GroupBox1.Controls.Add(Me.keyPadNineBtn)
        Me.GroupBox1.Controls.Add(Me.keyPadBackBtn)
        Me.GroupBox1.Controls.Add(Me.tenDollarBtn)
        Me.GroupBox1.Controls.Add(Me.hundredDollarBtn)
        Me.GroupBox1.Controls.Add(Me.fiveteenDollarBtn)
        Me.GroupBox1.Controls.Add(Me.keyPadTwoBtn)
        Me.GroupBox1.Controls.Add(Me.twentyDollarBtn)
        Me.GroupBox1.Controls.Add(Me.keyPadInputTextBox)
        Me.GroupBox1.Controls.Add(Me.keyPadFourBtn)
        Me.GroupBox1.Controls.Add(Me.fiveDollarBtn)
        Me.GroupBox1.Controls.Add(Me.fiftyDollarBtn)
        Me.GroupBox1.Controls.Add(Me.keyPadSevenBtn)
        Me.GroupBox1.Controls.Add(Me.keyPadDecimalBtn)
        Me.GroupBox1.Controls.Add(Me.keyPadZeroBtn)
        Me.GroupBox1.Controls.Add(Me.keyPadEightBtn)
        Me.GroupBox1.Controls.Add(Me.keyPadFiveBtn)
        Me.GroupBox1.Controls.Add(Me.creditBtn)
        Me.GroupBox1.Controls.Add(Me.discountBtn)
        Me.GroupBox1.Controls.Add(Me.cashBtn)
        Me.GroupBox1.Controls.Add(Me.voidBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(21, -6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(372, 436)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(315, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 31)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "$"
        '
        'subTotalLabel
        '
        Me.subTotalLabel.AutoSize = True
        Me.subTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subTotalLabel.Location = New System.Drawing.Point(4, 29)
        Me.subTotalLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.subTotalLabel.Name = "subTotalLabel"
        Me.subTotalLabel.Size = New System.Drawing.Size(150, 31)
        Me.subTotalLabel.TabIndex = 44
        Me.subTotalLabel.Text = "Sub-Total:"
        '
        'taxLabel
        '
        Me.taxLabel.AutoSize = True
        Me.taxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxLabel.Location = New System.Drawing.Point(4, 84)
        Me.taxLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.taxLabel.Name = "taxLabel"
        Me.taxLabel.Size = New System.Drawing.Size(71, 31)
        Me.taxLabel.TabIndex = 45
        Me.taxLabel.Text = "Tax:"
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel.Location = New System.Drawing.Point(4, 162)
        Me.totalLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(89, 31)
        Me.totalLabel.TabIndex = 46
        Me.totalLabel.Text = "Total:"
        '
        'totalGroupBox
        '
        Me.totalGroupBox.Controls.Add(Me.totalTextBox)
        Me.totalGroupBox.Controls.Add(Me.subTotalLabel)
        Me.totalGroupBox.Controls.Add(Me.totalLabel)
        Me.totalGroupBox.Controls.Add(Me.taxLabel)
        Me.totalGroupBox.Location = New System.Drawing.Point(398, 188)
        Me.totalGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.totalGroupBox.Name = "totalGroupBox"
        Me.totalGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.totalGroupBox.Size = New System.Drawing.Size(249, 231)
        Me.totalGroupBox.TabIndex = 47
        Me.totalGroupBox.TabStop = False
        '
        'totalTextBox
        '
        Me.totalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalTextBox.Location = New System.Drawing.Point(139, 152)
        Me.totalTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.totalTextBox.Multiline = True
        Me.totalTextBox.Name = "totalTextBox"
        Me.totalTextBox.Size = New System.Drawing.Size(84, 41)
        Me.totalTextBox.TabIndex = 49
        '
        'PayScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(656, 453)
        Me.Controls.Add(Me.totalGroupBox)
        Me.Controls.Add(Me.keyPadThreeBtn)
        Me.Controls.Add(Me.keyPadSixBtn)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PayScreen"
        Me.Text = "PayScreen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.totalGroupBox.ResumeLayout(False)
        Me.totalGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents keyPadDecimalBtn As Button
    Friend WithEvents keyPadZeroBtn As Button
    Friend WithEvents fiveDollarBtn As Button
    Friend WithEvents cashBtn As Button
    Friend WithEvents creditBtn As Button
    Friend WithEvents voidBtn As Button
    Friend WithEvents keyPadInputTextBox As TextBox
    Friend WithEvents discountBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents keyPadBackBtn As Button
    Friend WithEvents keyPadSevenBtn As Button
    Friend WithEvents keyPadFourBtn As Button
    Friend WithEvents keyPadFiveBtn As Button
    Friend WithEvents keyPadSixBtn As Button
    Friend WithEvents keyPadNineBtn As Button
    Friend WithEvents keyPadEightBtn As Button
    Friend WithEvents keyPadOneBtn As Button
    Friend WithEvents keyPadTwoBtn As Button
    Friend WithEvents keyPadThreeBtn As Button
    Friend WithEvents fiftyDollarBtn As Button
    Friend WithEvents twentyDollarBtn As Button
    Friend WithEvents fiveteenDollarBtn As Button
    Friend WithEvents tenDollarBtn As Button
    Friend WithEvents hundredDollarBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents subTotalLabel As Label
    Friend WithEvents taxLabel As Label
    Friend WithEvents totalLabel As Label
    Friend WithEvents totalGroupBox As GroupBox
    Friend WithEvents totalTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
