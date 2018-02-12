<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReadingAndRefreshment
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReadingAndRefreshment))
        Me.OrderInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.ItemAmountTextBox = New System.Windows.Forms.TextBox()
        Me.ItemAmountLabel = New System.Windows.Forms.Label()
        Me.ClearForNextItemButton = New System.Windows.Forms.Button()
        Me.CalculateSelectionButton = New System.Windows.Forms.Button()
        Me.TakeoutCheckBox = New System.Windows.Forms.CheckBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.CoffeeSelectionsGroupBox = New System.Windows.Forms.GroupBox()
        Me.IcedCappuccinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.IcedLatteRadioButton = New System.Windows.Forms.RadioButton()
        Me.LatteRadioButton = New System.Windows.Forms.RadioButton()
        Me.EspressoRadioButton = New System.Windows.Forms.RadioButton()
        Me.CappuccinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.ReadingAndRefreshmentLabel = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BalanceGroupBox = New System.Windows.Forms.GroupBox()
        Me.TotalDueTextBox = New System.Windows.Forms.TextBox()
        Me.TaxTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.TotalDueLabel = New System.Windows.Forms.Label()
        Me.TaxLabel = New System.Windows.Forms.Label()
        Me.SubTotalLabel = New System.Windows.Forms.Label()
        Me.NewOrderButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.OrderInformationGroupBox.SuspendLayout()
        Me.CoffeeSelectionsGroupBox.SuspendLayout()
        Me.BalanceGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'OrderInformationGroupBox
        '
        Me.OrderInformationGroupBox.Controls.Add(Me.ItemAmountTextBox)
        Me.OrderInformationGroupBox.Controls.Add(Me.ItemAmountLabel)
        Me.OrderInformationGroupBox.Controls.Add(Me.ClearForNextItemButton)
        Me.OrderInformationGroupBox.Controls.Add(Me.CalculateSelectionButton)
        Me.OrderInformationGroupBox.Controls.Add(Me.TakeoutCheckBox)
        Me.OrderInformationGroupBox.Controls.Add(Me.QuantityTextBox)
        Me.OrderInformationGroupBox.Controls.Add(Me.QuantityLabel)
        Me.OrderInformationGroupBox.Controls.Add(Me.CoffeeSelectionsGroupBox)
        Me.OrderInformationGroupBox.Location = New System.Drawing.Point(12, 37)
        Me.OrderInformationGroupBox.Name = "OrderInformationGroupBox"
        Me.OrderInformationGroupBox.Size = New System.Drawing.Size(514, 185)
        Me.OrderInformationGroupBox.TabIndex = 0
        Me.OrderInformationGroupBox.TabStop = False
        Me.OrderInformationGroupBox.Text = "Order Information"
        '
        'ItemAmountTextBox
        '
        Me.ItemAmountTextBox.Location = New System.Drawing.Point(44, 150)
        Me.ItemAmountTextBox.Name = "ItemAmountTextBox"
        Me.ItemAmountTextBox.ReadOnly = True
        Me.ItemAmountTextBox.Size = New System.Drawing.Size(130, 20)
        Me.ItemAmountTextBox.TabIndex = 7
        '
        'ItemAmountLabel
        '
        Me.ItemAmountLabel.AutoSize = True
        Me.ItemAmountLabel.Location = New System.Drawing.Point(27, 134)
        Me.ItemAmountLabel.Name = "ItemAmountLabel"
        Me.ItemAmountLabel.Size = New System.Drawing.Size(66, 13)
        Me.ItemAmountLabel.TabIndex = 6
        Me.ItemAmountLabel.Text = "Item Amount"
        '
        'ClearForNextItemButton
        '
        Me.ClearForNextItemButton.Enabled = False
        Me.ClearForNextItemButton.Location = New System.Drawing.Point(30, 94)
        Me.ClearForNextItemButton.Name = "ClearForNextItemButton"
        Me.ClearForNextItemButton.Size = New System.Drawing.Size(144, 23)
        Me.ClearForNextItemButton.TabIndex = 5
        Me.ClearForNextItemButton.Text = "Clea&r for Next Item"
        Me.ClearForNextItemButton.UseVisualStyleBackColor = True
        '
        'CalculateSelectionButton
        '
        Me.CalculateSelectionButton.Location = New System.Drawing.Point(30, 65)
        Me.CalculateSelectionButton.Name = "CalculateSelectionButton"
        Me.CalculateSelectionButton.Size = New System.Drawing.Size(144, 23)
        Me.CalculateSelectionButton.TabIndex = 4
        Me.CalculateSelectionButton.Text = "&Calculate Selection"
        Me.CalculateSelectionButton.UseVisualStyleBackColor = True
        '
        'TakeoutCheckBox
        '
        Me.TakeoutCheckBox.AutoSize = True
        Me.TakeoutCheckBox.Location = New System.Drawing.Point(30, 42)
        Me.TakeoutCheckBox.Name = "TakeoutCheckBox"
        Me.TakeoutCheckBox.Size = New System.Drawing.Size(72, 17)
        Me.TakeoutCheckBox.TabIndex = 3
        Me.TakeoutCheckBox.Text = "Ta&keout?"
        Me.TakeoutCheckBox.UseVisualStyleBackColor = True
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(76, 16)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(37, 20)
        Me.QuantityTextBox.TabIndex = 2
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Location = New System.Drawing.Point(27, 19)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(46, 13)
        Me.QuantityLabel.TabIndex = 1
        Me.QuantityLabel.Text = "&Quantity"
        '
        'CoffeeSelectionsGroupBox
        '
        Me.CoffeeSelectionsGroupBox.Controls.Add(Me.IcedCappuccinoRadioButton)
        Me.CoffeeSelectionsGroupBox.Controls.Add(Me.IcedLatteRadioButton)
        Me.CoffeeSelectionsGroupBox.Controls.Add(Me.LatteRadioButton)
        Me.CoffeeSelectionsGroupBox.Controls.Add(Me.EspressoRadioButton)
        Me.CoffeeSelectionsGroupBox.Controls.Add(Me.CappuccinoRadioButton)
        Me.CoffeeSelectionsGroupBox.Location = New System.Drawing.Point(311, 19)
        Me.CoffeeSelectionsGroupBox.Name = "CoffeeSelectionsGroupBox"
        Me.CoffeeSelectionsGroupBox.Size = New System.Drawing.Size(186, 146)
        Me.CoffeeSelectionsGroupBox.TabIndex = 0
        Me.CoffeeSelectionsGroupBox.TabStop = False
        Me.CoffeeSelectionsGroupBox.Text = "Coffee Selections"
        '
        'IcedCappuccinoRadioButton
        '
        Me.IcedCappuccinoRadioButton.AutoSize = True
        Me.IcedCappuccinoRadioButton.Location = New System.Drawing.Point(22, 115)
        Me.IcedCappuccinoRadioButton.Name = "IcedCappuccinoRadioButton"
        Me.IcedCappuccinoRadioButton.Size = New System.Drawing.Size(106, 17)
        Me.IcedCappuccinoRadioButton.TabIndex = 4
        Me.IcedCappuccinoRadioButton.TabStop = True
        Me.IcedCappuccinoRadioButton.Text = "Iced Ca&ppuccino"
        Me.IcedCappuccinoRadioButton.UseVisualStyleBackColor = True
        '
        'IcedLatteRadioButton
        '
        Me.IcedLatteRadioButton.AutoSize = True
        Me.IcedLatteRadioButton.Location = New System.Drawing.Point(22, 92)
        Me.IcedLatteRadioButton.Name = "IcedLatteRadioButton"
        Me.IcedLatteRadioButton.Size = New System.Drawing.Size(73, 17)
        Me.IcedLatteRadioButton.TabIndex = 3
        Me.IcedLatteRadioButton.TabStop = True
        Me.IcedLatteRadioButton.Text = "&Iced Latte"
        Me.IcedLatteRadioButton.UseVisualStyleBackColor = True
        '
        'LatteRadioButton
        '
        Me.LatteRadioButton.AutoSize = True
        Me.LatteRadioButton.Location = New System.Drawing.Point(22, 69)
        Me.LatteRadioButton.Name = "LatteRadioButton"
        Me.LatteRadioButton.Size = New System.Drawing.Size(49, 17)
        Me.LatteRadioButton.TabIndex = 2
        Me.LatteRadioButton.TabStop = True
        Me.LatteRadioButton.Text = "La&tte"
        Me.LatteRadioButton.UseVisualStyleBackColor = True
        '
        'EspressoRadioButton
        '
        Me.EspressoRadioButton.AutoSize = True
        Me.EspressoRadioButton.Location = New System.Drawing.Point(22, 46)
        Me.EspressoRadioButton.Name = "EspressoRadioButton"
        Me.EspressoRadioButton.Size = New System.Drawing.Size(68, 17)
        Me.EspressoRadioButton.TabIndex = 1
        Me.EspressoRadioButton.TabStop = True
        Me.EspressoRadioButton.Text = "Express&o"
        Me.EspressoRadioButton.UseVisualStyleBackColor = True
        '
        'CappuccinoRadioButton
        '
        Me.CappuccinoRadioButton.AutoSize = True
        Me.CappuccinoRadioButton.Location = New System.Drawing.Point(22, 23)
        Me.CappuccinoRadioButton.Name = "CappuccinoRadioButton"
        Me.CappuccinoRadioButton.Size = New System.Drawing.Size(82, 17)
        Me.CappuccinoRadioButton.TabIndex = 0
        Me.CappuccinoRadioButton.TabStop = True
        Me.CappuccinoRadioButton.Text = "C&appuccino"
        Me.CappuccinoRadioButton.UseVisualStyleBackColor = True
        '
        'ReadingAndRefreshmentLabel
        '
        Me.ReadingAndRefreshmentLabel.AutoSize = True
        Me.ReadingAndRefreshmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReadingAndRefreshmentLabel.Location = New System.Drawing.Point(125, 9)
        Me.ReadingAndRefreshmentLabel.Name = "ReadingAndRefreshmentLabel"
        Me.ReadingAndRefreshmentLabel.Size = New System.Drawing.Size(262, 25)
        Me.ReadingAndRefreshmentLabel.TabIndex = 1
        Me.ReadingAndRefreshmentLabel.Text = "Reading and Refreshment"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'BalanceGroupBox
        '
        Me.BalanceGroupBox.Controls.Add(Me.TotalDueTextBox)
        Me.BalanceGroupBox.Controls.Add(Me.TaxTextBox)
        Me.BalanceGroupBox.Controls.Add(Me.SubTotalTextBox)
        Me.BalanceGroupBox.Controls.Add(Me.TotalDueLabel)
        Me.BalanceGroupBox.Controls.Add(Me.TaxLabel)
        Me.BalanceGroupBox.Controls.Add(Me.SubTotalLabel)
        Me.BalanceGroupBox.Location = New System.Drawing.Point(12, 228)
        Me.BalanceGroupBox.Name = "BalanceGroupBox"
        Me.BalanceGroupBox.Size = New System.Drawing.Size(514, 118)
        Me.BalanceGroupBox.TabIndex = 2
        Me.BalanceGroupBox.TabStop = False
        Me.BalanceGroupBox.Text = "Balance Due"
        '
        'TotalDueTextBox
        '
        Me.TotalDueTextBox.Location = New System.Drawing.Point(153, 77)
        Me.TotalDueTextBox.Name = "TotalDueTextBox"
        Me.TotalDueTextBox.ReadOnly = True
        Me.TotalDueTextBox.Size = New System.Drawing.Size(130, 20)
        Me.TotalDueTextBox.TabIndex = 12
        '
        'TaxTextBox
        '
        Me.TaxTextBox.Location = New System.Drawing.Point(153, 53)
        Me.TaxTextBox.Name = "TaxTextBox"
        Me.TaxTextBox.ReadOnly = True
        Me.TaxTextBox.Size = New System.Drawing.Size(130, 20)
        Me.TaxTextBox.TabIndex = 11
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.Location = New System.Drawing.Point(153, 29)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.ReadOnly = True
        Me.SubTotalTextBox.Size = New System.Drawing.Size(130, 20)
        Me.SubTotalTextBox.TabIndex = 8
        '
        'TotalDueLabel
        '
        Me.TotalDueLabel.AutoSize = True
        Me.TotalDueLabel.Location = New System.Drawing.Point(41, 80)
        Me.TotalDueLabel.Name = "TotalDueLabel"
        Me.TotalDueLabel.Size = New System.Drawing.Size(54, 13)
        Me.TotalDueLabel.TabIndex = 10
        Me.TotalDueLabel.Text = "Total Due"
        '
        'TaxLabel
        '
        Me.TaxLabel.AutoSize = True
        Me.TaxLabel.Location = New System.Drawing.Point(41, 56)
        Me.TaxLabel.Name = "TaxLabel"
        Me.TaxLabel.Size = New System.Drawing.Size(83, 13)
        Me.TaxLabel.TabIndex = 9
        Me.TaxLabel.Text = "Tax (If Takeout)"
        '
        'SubTotalLabel
        '
        Me.SubTotalLabel.AutoSize = True
        Me.SubTotalLabel.Location = New System.Drawing.Point(41, 32)
        Me.SubTotalLabel.Name = "SubTotalLabel"
        Me.SubTotalLabel.Size = New System.Drawing.Size(53, 13)
        Me.SubTotalLabel.TabIndex = 8
        Me.SubTotalLabel.Text = "Sub Total"
        '
        'NewOrderButton
        '
        Me.NewOrderButton.Enabled = False
        Me.NewOrderButton.Location = New System.Drawing.Point(12, 352)
        Me.NewOrderButton.Name = "NewOrderButton"
        Me.NewOrderButton.Size = New System.Drawing.Size(124, 23)
        Me.NewOrderButton.TabIndex = 8
        Me.NewOrderButton.Text = "&New Order"
        Me.NewOrderButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(142, 352)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(124, 23)
        Me.SummaryButton.TabIndex = 9
        Me.SummaryButton.Text = "&Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(402, 352)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(124, 23)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(272, 352)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(124, 23)
        Me.PrintButton.TabIndex = 11
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ReadingAndRefreshment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 388)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.NewOrderButton)
        Me.Controls.Add(Me.BalanceGroupBox)
        Me.Controls.Add(Me.ReadingAndRefreshmentLabel)
        Me.Controls.Add(Me.OrderInformationGroupBox)
        Me.Name = "ReadingAndRefreshment"
        Me.Text = "Reading and Refreshment"
        Me.OrderInformationGroupBox.ResumeLayout(False)
        Me.OrderInformationGroupBox.PerformLayout()
        Me.CoffeeSelectionsGroupBox.ResumeLayout(False)
        Me.CoffeeSelectionsGroupBox.PerformLayout()
        Me.BalanceGroupBox.ResumeLayout(False)
        Me.BalanceGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OrderInformationGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ItemAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemAmountLabel As System.Windows.Forms.Label
    Friend WithEvents ClearForNextItemButton As System.Windows.Forms.Button
    Friend WithEvents CalculateSelectionButton As System.Windows.Forms.Button
    Friend WithEvents TakeoutCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityLabel As System.Windows.Forms.Label
    Friend WithEvents CoffeeSelectionsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents IcedCappuccinoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents IcedLatteRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LatteRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents EspressoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CappuccinoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ReadingAndRefreshmentLabel As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents SummaryButton As System.Windows.Forms.Button
    Friend WithEvents NewOrderButton As System.Windows.Forms.Button
    Friend WithEvents BalanceGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TotalDueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalDueLabel As System.Windows.Forms.Label
    Friend WithEvents TaxLabel As System.Windows.Forms.Label
    Friend WithEvents SubTotalLabel As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintButton As System.Windows.Forms.Button

End Class
