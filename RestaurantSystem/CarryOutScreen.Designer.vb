<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarryOutScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.userTabPage = New System.Windows.Forms.TabPage()
        Me.newOrdereButton = New System.Windows.Forms.Button()
        Me.carryOutDataGridView = New System.Windows.Forms.DataGridView()
        Me.backButton = New System.Windows.Forms.Button()
        Me.displayOrderButton = New System.Windows.Forms.Button()
        Me.DeleteOrderButton = New System.Windows.Forms.Button()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FoodItemGridView = New System.Windows.Forms.DataGridView()
        Me.logOutButton = New System.Windows.Forms.Button()
        Me.FoodOptionsListBox = New System.Windows.Forms.ListBox()
        Me.SpecialsButton = New System.Windows.Forms.Button()
        Me.DrinksButton = New System.Windows.Forms.Button()
        Me.DessertsButton = New System.Windows.Forms.Button()
        Me.SaladsButton = New System.Windows.Forms.Button()
        Me.AppsButton = New System.Windows.Forms.Button()
        Me.PayButton = New System.Windows.Forms.Button()
        Me.allButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLabel = New System.Windows.Forms.Label()
        Me.carryOutTab = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ClogOutButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.orderListDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabControl.SuspendLayout()
        Me.userTabPage.SuspendLayout()
        CType(Me.carryOutDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodItemGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.carryOutTab.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.orderListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.userTabPage)
        Me.TabControl.Controls.Add(Me.carryOutTab)
        Me.TabControl.Location = New System.Drawing.Point(13, 7)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(775, 436)
        Me.TabControl.TabIndex = 1
        '
        'userTabPage
        '
        Me.userTabPage.Controls.Add(Me.newOrdereButton)
        Me.userTabPage.Controls.Add(Me.carryOutDataGridView)
        Me.userTabPage.Controls.Add(Me.backButton)
        Me.userTabPage.Controls.Add(Me.displayOrderButton)
        Me.userTabPage.Controls.Add(Me.DeleteOrderButton)
        Me.userTabPage.Controls.Add(Me.TotalTextBox)
        Me.userTabPage.Controls.Add(Me.Label1)
        Me.userTabPage.Controls.Add(Me.OrderListView)
        Me.userTabPage.Controls.Add(Me.FoodItemGridView)
        Me.userTabPage.Controls.Add(Me.logOutButton)
        Me.userTabPage.Controls.Add(Me.FoodOptionsListBox)
        Me.userTabPage.Controls.Add(Me.SpecialsButton)
        Me.userTabPage.Controls.Add(Me.DrinksButton)
        Me.userTabPage.Controls.Add(Me.DessertsButton)
        Me.userTabPage.Controls.Add(Me.SaladsButton)
        Me.userTabPage.Controls.Add(Me.AppsButton)
        Me.userTabPage.Controls.Add(Me.PayButton)
        Me.userTabPage.Controls.Add(Me.allButton)
        Me.userTabPage.Controls.Add(Me.Label2)
        Me.userTabPage.Controls.Add(Me.TableLabel)
        Me.userTabPage.Location = New System.Drawing.Point(4, 22)
        Me.userTabPage.Name = "userTabPage"
        Me.userTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.userTabPage.Size = New System.Drawing.Size(767, 410)
        Me.userTabPage.TabIndex = 0
        Me.userTabPage.Text = "UserName"
        Me.userTabPage.UseVisualStyleBackColor = True
        '
        'newOrdereButton
        '
        Me.newOrdereButton.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newOrdereButton.Location = New System.Drawing.Point(327, 13)
        Me.newOrdereButton.Name = "newOrdereButton"
        Me.newOrdereButton.Size = New System.Drawing.Size(153, 26)
        Me.newOrdereButton.TabIndex = 51
        Me.newOrdereButton.Text = "Create New Order"
        Me.newOrdereButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.newOrdereButton.UseVisualStyleBackColor = True
        '
        'carryOutDataGridView
        '
        Me.carryOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.carryOutDataGridView.Location = New System.Drawing.Point(327, 45)
        Me.carryOutDataGridView.Name = "carryOutDataGridView"
        Me.carryOutDataGridView.Size = New System.Drawing.Size(75, 294)
        Me.carryOutDataGridView.TabIndex = 50
        '
        'backButton
        '
        Me.backButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backButton.Location = New System.Drawing.Point(545, 351)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(89, 27)
        Me.backButton.TabIndex = 48
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'displayOrderButton
        '
        Me.displayOrderButton.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayOrderButton.Location = New System.Drawing.Point(157, 13)
        Me.displayOrderButton.Name = "displayOrderButton"
        Me.displayOrderButton.Size = New System.Drawing.Size(153, 26)
        Me.displayOrderButton.TabIndex = 47
        Me.displayOrderButton.Text = "Display Orders"
        Me.displayOrderButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.displayOrderButton.UseVisualStyleBackColor = True
        '
        'DeleteOrderButton
        '
        Me.DeleteOrderButton.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteOrderButton.Location = New System.Drawing.Point(16, 355)
        Me.DeleteOrderButton.Name = "DeleteOrderButton"
        Me.DeleteOrderButton.Size = New System.Drawing.Size(105, 26)
        Me.DeleteOrderButton.TabIndex = 46
        Me.DeleteOrderButton.Text = "Delete (1)"
        Me.DeleteOrderButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DeleteOrderButton.UseVisualStyleBackColor = True
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTextBox.ForeColor = System.Drawing.Color.Blue
        Me.TotalTextBox.Location = New System.Drawing.Point(211, 354)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 27)
        Me.TotalTextBox.TabIndex = 45
        Me.TotalTextBox.Text = "0"
        Me.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 354)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 24)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Total"
        '
        'OrderListView
        '
        Me.OrderListView.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.OrderListView.AllowColumnReorder = True
        Me.OrderListView.AllowDrop = True
        Me.OrderListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.OrderListView.GridLines = True
        Me.OrderListView.Location = New System.Drawing.Point(16, 45)
        Me.OrderListView.Name = "OrderListView"
        Me.OrderListView.Size = New System.Drawing.Size(294, 306)
        Me.OrderListView.TabIndex = 40
        Me.OrderListView.UseCompatibleStateImageBehavior = False
        Me.OrderListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "FoodItem"
        Me.ColumnHeader1.Width = 143
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Count"
        Me.ColumnHeader2.Width = 43
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Price"
        Me.ColumnHeader3.Width = 44
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "TotalPrice"
        Me.ColumnHeader4.Width = 61
        '
        'FoodItemGridView
        '
        Me.FoodItemGridView.AccessibleDescription = "f"
        Me.FoodItemGridView.AllowDrop = True
        Me.FoodItemGridView.AllowUserToAddRows = False
        Me.FoodItemGridView.AllowUserToDeleteRows = False
        Me.FoodItemGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FoodItemGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.FoodItemGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FoodItemGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FoodItemGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.FoodItemGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.FoodItemGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FoodItemGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FoodItemGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.FoodItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FoodItemGridView.ColumnHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FoodItemGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.FoodItemGridView.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.FoodItemGridView.Location = New System.Drawing.Point(497, 45)
        Me.FoodItemGridView.MultiSelect = False
        Me.FoodItemGridView.Name = "FoodItemGridView"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.FoodItemGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.FoodItemGridView.RowHeadersWidth = 10
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FoodItemGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.FoodItemGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FoodItemGridView.RowTemplate.Height = 10
        Me.FoodItemGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FoodItemGridView.Size = New System.Drawing.Size(243, 294)
        Me.FoodItemGridView.StandardTab = True
        Me.FoodItemGridView.TabIndex = 38
        '
        'logOutButton
        '
        Me.logOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOutButton.Location = New System.Drawing.Point(651, 351)
        Me.logOutButton.Name = "logOutButton"
        Me.logOutButton.Size = New System.Drawing.Size(89, 27)
        Me.logOutButton.TabIndex = 37
        Me.logOutButton.Text = "Log Out"
        Me.logOutButton.UseVisualStyleBackColor = True
        '
        'FoodOptionsListBox
        '
        Me.FoodOptionsListBox.Font = New System.Drawing.Font("Sitka Small", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoodOptionsListBox.FormattingEnabled = True
        Me.FoodOptionsListBox.ItemHeight = 29
        Me.FoodOptionsListBox.Location = New System.Drawing.Point(497, 45)
        Me.FoodOptionsListBox.MultiColumn = True
        Me.FoodOptionsListBox.Name = "FoodOptionsListBox"
        Me.FoodOptionsListBox.Size = New System.Drawing.Size(212, 294)
        Me.FoodOptionsListBox.TabIndex = 36
        '
        'SpecialsButton
        '
        Me.SpecialsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialsButton.Location = New System.Drawing.Point(416, 127)
        Me.SpecialsButton.Name = "SpecialsButton"
        Me.SpecialsButton.Size = New System.Drawing.Size(75, 23)
        Me.SpecialsButton.TabIndex = 35
        Me.SpecialsButton.Text = "Specials"
        Me.SpecialsButton.UseVisualStyleBackColor = True
        '
        'DrinksButton
        '
        Me.DrinksButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrinksButton.Location = New System.Drawing.Point(416, 251)
        Me.DrinksButton.Name = "DrinksButton"
        Me.DrinksButton.Size = New System.Drawing.Size(75, 23)
        Me.DrinksButton.TabIndex = 34
        Me.DrinksButton.Text = "Drinks"
        Me.DrinksButton.UseVisualStyleBackColor = True
        '
        'DessertsButton
        '
        Me.DessertsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DessertsButton.Location = New System.Drawing.Point(416, 210)
        Me.DessertsButton.Name = "DessertsButton"
        Me.DessertsButton.Size = New System.Drawing.Size(75, 23)
        Me.DessertsButton.TabIndex = 33
        Me.DessertsButton.Text = "Desserts"
        Me.DessertsButton.UseVisualStyleBackColor = True
        '
        'SaladsButton
        '
        Me.SaladsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaladsButton.Location = New System.Drawing.Point(416, 168)
        Me.SaladsButton.Name = "SaladsButton"
        Me.SaladsButton.Size = New System.Drawing.Size(75, 23)
        Me.SaladsButton.TabIndex = 32
        Me.SaladsButton.Text = "Salads"
        Me.SaladsButton.UseVisualStyleBackColor = True
        '
        'AppsButton
        '
        Me.AppsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppsButton.Location = New System.Drawing.Point(416, 83)
        Me.AppsButton.Name = "AppsButton"
        Me.AppsButton.Size = New System.Drawing.Size(75, 23)
        Me.AppsButton.TabIndex = 31
        Me.AppsButton.Text = "Apertizers"
        Me.AppsButton.UseVisualStyleBackColor = True
        '
        'PayButton
        '
        Me.PayButton.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayButton.Location = New System.Drawing.Point(327, 355)
        Me.PayButton.Name = "PayButton"
        Me.PayButton.Size = New System.Drawing.Size(82, 26)
        Me.PayButton.TabIndex = 29
        Me.PayButton.Text = "Pay"
        Me.PayButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.PayButton.UseVisualStyleBackColor = True
        '
        'allButton
        '
        Me.allButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allButton.Location = New System.Drawing.Point(416, 45)
        Me.allButton.Name = "allButton"
        Me.allButton.Size = New System.Drawing.Size(75, 23)
        Me.allButton.TabIndex = 28
        Me.allButton.Text = "All"
        Me.allButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(492, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 25)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Food Items"
        '
        'TableLabel
        '
        Me.TableLabel.AutoSize = True
        Me.TableLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLabel.Location = New System.Drawing.Point(12, 4)
        Me.TableLabel.Name = "TableLabel"
        Me.TableLabel.Size = New System.Drawing.Size(98, 24)
        Me.TableLabel.TabIndex = 26
        Me.TableLabel.Text = "Carry Out"
        '
        'carryOutTab
        '
        Me.carryOutTab.Controls.Add(Me.Panel1)
        Me.carryOutTab.Location = New System.Drawing.Point(4, 22)
        Me.carryOutTab.Name = "carryOutTab"
        Me.carryOutTab.Padding = New System.Windows.Forms.Padding(3)
        Me.carryOutTab.Size = New System.Drawing.Size(767, 410)
        Me.carryOutTab.TabIndex = 1
        Me.carryOutTab.Text = "Carry Out"
        Me.carryOutTab.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ClogOutButton)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.orderListDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(-4, -7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(775, 425)
        Me.Panel1.TabIndex = 43
        '
        'ClogOutButton
        '
        Me.ClogOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClogOutButton.Location = New System.Drawing.Point(665, 11)
        Me.ClogOutButton.Name = "ClogOutButton"
        Me.ClogOutButton.Size = New System.Drawing.Size(89, 27)
        Me.ClogOutButton.TabIndex = 46
        Me.ClogOutButton.Text = "Log Out"
        Me.ClogOutButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(375, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 24)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Order Information"
        '
        'DataGridView1
        '
        Me.DataGridView1.AccessibleDescription = "f"
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeight = 25
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(379, 47)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.RowHeadersWidth = 10
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowTemplate.Height = 10
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(375, 337)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 24)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Unpaid Carry Out Orders"
        '
        'orderListDataGridView
        '
        Me.orderListDataGridView.AccessibleDescription = "f"
        Me.orderListDataGridView.AllowDrop = True
        Me.orderListDataGridView.AllowUserToAddRows = False
        Me.orderListDataGridView.AllowUserToDeleteRows = False
        Me.orderListDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.orderListDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.orderListDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.orderListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.orderListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.orderListDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.orderListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.orderListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.orderListDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.orderListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.orderListDataGridView.DefaultCellStyle = DataGridViewCellStyle13
        Me.orderListDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.orderListDataGridView.Location = New System.Drawing.Point(18, 47)
        Me.orderListDataGridView.MultiSelect = False
        Me.orderListDataGridView.Name = "orderListDataGridView"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.orderListDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.orderListDataGridView.RowHeadersWidth = 10
        DataGridViewCellStyle15.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.orderListDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.orderListDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.orderListDataGridView.RowTemplate.Height = 10
        Me.orderListDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.orderListDataGridView.Size = New System.Drawing.Size(293, 337)
        Me.orderListDataGridView.StandardTab = True
        Me.orderListDataGridView.TabIndex = 40
        '
        'CarryOutScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "CarryOutScreen"
        Me.Text = "CarryOutScreen"
        Me.TabControl.ResumeLayout(False)
        Me.userTabPage.ResumeLayout(False)
        Me.userTabPage.PerformLayout()
        CType(Me.carryOutDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodItemGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.carryOutTab.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.orderListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents userTabPage As TabPage
    Friend WithEvents backButton As Button
    Friend WithEvents displayOrderButton As Button
    Friend WithEvents DeleteOrderButton As Button
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OrderListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents FoodItemGridView As DataGridView
    Friend WithEvents logOutButton As Button
    Friend WithEvents FoodOptionsListBox As ListBox
    Friend WithEvents SpecialsButton As Button
    Friend WithEvents DrinksButton As Button
    Friend WithEvents DessertsButton As Button
    Friend WithEvents SaladsButton As Button
    Friend WithEvents AppsButton As Button
    Friend WithEvents PayButton As Button
    Friend WithEvents allButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLabel As Label
    Friend WithEvents carryOutTab As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ClogOutButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents orderListDataGridView As DataGridView
    Friend WithEvents carryOutDataGridView As DataGridView
    Friend WithEvents newOrdereButton As Button
End Class
