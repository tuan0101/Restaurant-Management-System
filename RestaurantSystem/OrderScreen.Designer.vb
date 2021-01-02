<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderScreen
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
        Me.components = New System.ComponentModel.Container()
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
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.userTabPage = New System.Windows.Forms.TabPage()
        Me.carryOutGridView = New System.Windows.Forms.DataGridView()
        Me.newOrderButton = New System.Windows.Forms.Button()
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
        Me.SpecialsButton = New System.Windows.Forms.Button()
        Me.DrinksButton = New System.Windows.Forms.Button()
        Me.DessertsButton = New System.Windows.Forms.Button()
        Me.SaladsButton = New System.Windows.Forms.Button()
        Me.AppsButton = New System.Windows.Forms.Button()
        Me.TableNumberLabel = New System.Windows.Forms.Label()
        Me.PayButton = New System.Windows.Forms.Button()
        Me.allButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLabel = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TabControl.SuspendLayout()
        Me.userTabPage.SuspendLayout()
        CType(Me.carryOutGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodItemGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.userTabPage)
        Me.TabControl.Location = New System.Drawing.Point(12, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(775, 436)
        Me.TabControl.TabIndex = 0
        '
        'userTabPage
        '
        Me.userTabPage.Controls.Add(Me.carryOutGridView)
        Me.userTabPage.Controls.Add(Me.newOrderButton)
        Me.userTabPage.Controls.Add(Me.backButton)
        Me.userTabPage.Controls.Add(Me.displayOrderButton)
        Me.userTabPage.Controls.Add(Me.DeleteOrderButton)
        Me.userTabPage.Controls.Add(Me.TotalTextBox)
        Me.userTabPage.Controls.Add(Me.Label1)
        Me.userTabPage.Controls.Add(Me.OrderListView)
        Me.userTabPage.Controls.Add(Me.FoodItemGridView)
        Me.userTabPage.Controls.Add(Me.logOutButton)
        Me.userTabPage.Controls.Add(Me.SpecialsButton)
        Me.userTabPage.Controls.Add(Me.DrinksButton)
        Me.userTabPage.Controls.Add(Me.DessertsButton)
        Me.userTabPage.Controls.Add(Me.SaladsButton)
        Me.userTabPage.Controls.Add(Me.AppsButton)
        Me.userTabPage.Controls.Add(Me.TableNumberLabel)
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
        'carryOutGridView
        '
        Me.carryOutGridView.AccessibleDescription = "f"
        Me.carryOutGridView.AllowDrop = True
        Me.carryOutGridView.AllowUserToAddRows = False
        Me.carryOutGridView.AllowUserToDeleteRows = False
        Me.carryOutGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.carryOutGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.carryOutGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.carryOutGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.carryOutGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.carryOutGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.carryOutGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.carryOutGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.carryOutGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.carryOutGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.carryOutGridView.ColumnHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Sitka Small", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.carryOutGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.carryOutGridView.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.carryOutGridView.Location = New System.Drawing.Point(327, 45)
        Me.carryOutGridView.MultiSelect = False
        Me.carryOutGridView.Name = "carryOutGridView"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.carryOutGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.carryOutGridView.RowHeadersWidth = 10
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.carryOutGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.carryOutGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.carryOutGridView.RowTemplate.Height = 10
        Me.carryOutGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.carryOutGridView.Size = New System.Drawing.Size(104, 294)
        Me.carryOutGridView.StandardTab = True
        Me.carryOutGridView.TabIndex = 54
        '
        'newOrderButton
        '
        Me.newOrderButton.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newOrderButton.Location = New System.Drawing.Point(327, 13)
        Me.newOrderButton.Name = "newOrderButton"
        Me.newOrderButton.Size = New System.Drawing.Size(153, 26)
        Me.newOrderButton.TabIndex = 53
        Me.newOrderButton.Text = "Create New Order"
        Me.newOrderButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.newOrderButton.UseVisualStyleBackColor = True
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
        Me.displayOrderButton.Location = New System.Drawing.Point(188, 13)
        Me.displayOrderButton.Name = "displayOrderButton"
        Me.displayOrderButton.Size = New System.Drawing.Size(122, 26)
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
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FoodItemGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.FoodItemGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FoodItemGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FoodItemGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.FoodItemGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.FoodItemGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FoodItemGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FoodItemGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.FoodItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FoodItemGridView.ColumnHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FoodItemGridView.DefaultCellStyle = DataGridViewCellStyle8
        Me.FoodItemGridView.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.FoodItemGridView.Location = New System.Drawing.Point(518, 45)
        Me.FoodItemGridView.MultiSelect = False
        Me.FoodItemGridView.Name = "FoodItemGridView"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.FoodItemGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.FoodItemGridView.RowHeadersWidth = 10
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FoodItemGridView.RowsDefaultCellStyle = DataGridViewCellStyle10
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
        'SpecialsButton
        '
        Me.SpecialsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialsButton.Location = New System.Drawing.Point(437, 127)
        Me.SpecialsButton.Name = "SpecialsButton"
        Me.SpecialsButton.Size = New System.Drawing.Size(75, 23)
        Me.SpecialsButton.TabIndex = 35
        Me.SpecialsButton.Text = "Specials"
        Me.SpecialsButton.UseVisualStyleBackColor = True
        '
        'DrinksButton
        '
        Me.DrinksButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrinksButton.Location = New System.Drawing.Point(437, 251)
        Me.DrinksButton.Name = "DrinksButton"
        Me.DrinksButton.Size = New System.Drawing.Size(75, 23)
        Me.DrinksButton.TabIndex = 34
        Me.DrinksButton.Text = "Drinks"
        Me.DrinksButton.UseVisualStyleBackColor = True
        '
        'DessertsButton
        '
        Me.DessertsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DessertsButton.Location = New System.Drawing.Point(437, 210)
        Me.DessertsButton.Name = "DessertsButton"
        Me.DessertsButton.Size = New System.Drawing.Size(75, 23)
        Me.DessertsButton.TabIndex = 33
        Me.DessertsButton.Text = "Desserts"
        Me.DessertsButton.UseVisualStyleBackColor = True
        '
        'SaladsButton
        '
        Me.SaladsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaladsButton.Location = New System.Drawing.Point(437, 168)
        Me.SaladsButton.Name = "SaladsButton"
        Me.SaladsButton.Size = New System.Drawing.Size(75, 23)
        Me.SaladsButton.TabIndex = 32
        Me.SaladsButton.Text = "Salads"
        Me.SaladsButton.UseVisualStyleBackColor = True
        '
        'AppsButton
        '
        Me.AppsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppsButton.Location = New System.Drawing.Point(437, 83)
        Me.AppsButton.Name = "AppsButton"
        Me.AppsButton.Size = New System.Drawing.Size(75, 23)
        Me.AppsButton.TabIndex = 31
        Me.AppsButton.Text = "Apertizers"
        Me.AppsButton.UseVisualStyleBackColor = True
        '
        'TableNumberLabel
        '
        Me.TableNumberLabel.AutoSize = True
        Me.TableNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableNumberLabel.Location = New System.Drawing.Point(75, 10)
        Me.TableNumberLabel.Name = "TableNumberLabel"
        Me.TableNumberLabel.Size = New System.Drawing.Size(17, 16)
        Me.TableNumberLabel.TabIndex = 30
        Me.TableNumberLabel.Text = "X"
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
        Me.allButton.Location = New System.Drawing.Point(437, 45)
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
        Me.Label2.Location = New System.Drawing.Point(513, 4)
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
        Me.TableLabel.Size = New System.Drawing.Size(69, 24)
        Me.TableLabel.TabIndex = 26
        Me.TableLabel.Text = "Table:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'OrderScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "OrderScreen"
        Me.Text = "OrderScreen"
        Me.TabControl.ResumeLayout(False)
        Me.userTabPage.ResumeLayout(False)
        Me.userTabPage.PerformLayout()
        CType(Me.carryOutGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodItemGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents userTabPage As TabPage
    Friend WithEvents FoodItemGridView As DataGridView
    Friend WithEvents logOutButton As Button
    Friend WithEvents SpecialsButton As Button
    Friend WithEvents DrinksButton As Button
    Friend WithEvents DessertsButton As Button
    Friend WithEvents SaladsButton As Button
    Friend WithEvents AppsButton As Button
    Friend WithEvents TableNumberLabel As Label
    Friend WithEvents PayButton As Button
    Friend WithEvents allButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLabel As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OrderListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents DeleteOrderButton As Button
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents displayOrderButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents newOrderButton As Button
    Friend WithEvents carryOutGridView As DataGridView
End Class
