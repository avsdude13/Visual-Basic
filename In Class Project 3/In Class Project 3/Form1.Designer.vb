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
        Me.EntryGroup = New System.Windows.Forms.GroupBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.QuanityTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QuanityLabel = New System.Windows.Forms.Label()
        Me.DiscountGroup = New System.Windows.Forms.GroupBox()
        Me.DiscountPriceLabel = New System.Windows.Forms.Label()
        Me.PercentDiscountLabel = New System.Windows.Forms.Label()
        Me.ExtendedPriceLabel = New System.Windows.Forms.Label()
        Me.PercentDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountPriceTextBox = New System.Windows.Forms.TextBox()
        Me.ExtendedPriceTextBox = New System.Windows.Forms.TextBox()
        Me.SummaryGroup = New System.Windows.Forms.GroupBox()
        Me.AverageDiscount = New System.Windows.Forms.Label()
        Me.TotalDiscountedAmounts = New System.Windows.Forms.Label()
        Me.TotalDiscountsGivenLabel = New System.Windows.Forms.Label()
        Me.AverageDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.TotalDiscountedAmountsTextBox = New System.Windows.Forms.TextBox()
        Me.TotalDiscountsGivenTextBox = New System.Windows.Forms.TextBox()
        Me.TotalNumberOfBooksTextBox = New System.Windows.Forms.TextBox()
        Me.TotalNumberOfBooks = New System.Windows.Forms.Label()
        Me.BookSalesLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintFormButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearSalesButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.EntryGroup.SuspendLayout()
        Me.DiscountGroup.SuspendLayout()
        Me.SummaryGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'EntryGroup
        '
        Me.EntryGroup.Controls.Add(Me.PriceTextBox)
        Me.EntryGroup.Controls.Add(Me.TitleTextBox)
        Me.EntryGroup.Controls.Add(Me.QuanityTextBox)
        Me.EntryGroup.Controls.Add(Me.Label2)
        Me.EntryGroup.Controls.Add(Me.Label1)
        Me.EntryGroup.Controls.Add(Me.QuanityLabel)
        Me.EntryGroup.Location = New System.Drawing.Point(12, 37)
        Me.EntryGroup.Name = "EntryGroup"
        Me.EntryGroup.Size = New System.Drawing.Size(478, 97)
        Me.EntryGroup.TabIndex = 1
        Me.EntryGroup.TabStop = False
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(108, 68)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.PriceTextBox, "Enter Price")
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(108, 42)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(344, 20)
        Me.TitleTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.TitleTextBox, "Enter Title")
        '
        'QuanityTextBox
        '
        Me.QuanityTextBox.Location = New System.Drawing.Point(108, 16)
        Me.QuanityTextBox.Name = "QuanityTextBox"
        Me.QuanityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuanityTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.QuanityTextBox, "Enter Quanity")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "&Price"
        Me.ToolTip1.SetToolTip(Me.Label2, "Price")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Title"
        Me.ToolTip1.SetToolTip(Me.Label1, "Title")
        '
        'QuanityLabel
        '
        Me.QuanityLabel.AutoSize = True
        Me.QuanityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuanityLabel.Location = New System.Drawing.Point(20, 16)
        Me.QuanityLabel.Name = "QuanityLabel"
        Me.QuanityLabel.Size = New System.Drawing.Size(63, 20)
        Me.QuanityLabel.TabIndex = 0
        Me.QuanityLabel.Text = "&Quanity"
        Me.ToolTip1.SetToolTip(Me.QuanityLabel, "Quanity")
        '
        'DiscountGroup
        '
        Me.DiscountGroup.Controls.Add(Me.DiscountPriceLabel)
        Me.DiscountGroup.Controls.Add(Me.PercentDiscountLabel)
        Me.DiscountGroup.Controls.Add(Me.ExtendedPriceLabel)
        Me.DiscountGroup.Controls.Add(Me.PercentDiscountTextBox)
        Me.DiscountGroup.Controls.Add(Me.DiscountPriceTextBox)
        Me.DiscountGroup.Controls.Add(Me.ExtendedPriceTextBox)
        Me.DiscountGroup.Location = New System.Drawing.Point(12, 140)
        Me.DiscountGroup.Name = "DiscountGroup"
        Me.DiscountGroup.Size = New System.Drawing.Size(478, 102)
        Me.DiscountGroup.TabIndex = 2
        Me.DiscountGroup.TabStop = False
        '
        'DiscountPriceLabel
        '
        Me.DiscountPriceLabel.AutoSize = True
        Me.DiscountPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountPriceLabel.Location = New System.Drawing.Point(267, 72)
        Me.DiscountPriceLabel.Name = "DiscountPriceLabel"
        Me.DiscountPriceLabel.Size = New System.Drawing.Size(94, 16)
        Me.DiscountPriceLabel.TabIndex = 4
        Me.DiscountPriceLabel.Text = "Discount Price"
        Me.ToolTip1.SetToolTip(Me.DiscountPriceLabel, "Discount Price")
        '
        'PercentDiscountLabel
        '
        Me.PercentDiscountLabel.AutoSize = True
        Me.PercentDiscountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PercentDiscountLabel.Location = New System.Drawing.Point(267, 46)
        Me.PercentDiscountLabel.Name = "PercentDiscountLabel"
        Me.PercentDiscountLabel.Size = New System.Drawing.Size(89, 16)
        Me.PercentDiscountLabel.TabIndex = 2
        Me.PercentDiscountLabel.Text = "15% Discount"
        Me.ToolTip1.SetToolTip(Me.PercentDiscountLabel, "15% Discount")
        '
        'ExtendedPriceLabel
        '
        Me.ExtendedPriceLabel.AutoSize = True
        Me.ExtendedPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtendedPriceLabel.Location = New System.Drawing.Point(267, 20)
        Me.ExtendedPriceLabel.Name = "ExtendedPriceLabel"
        Me.ExtendedPriceLabel.Size = New System.Drawing.Size(99, 16)
        Me.ExtendedPriceLabel.TabIndex = 0
        Me.ExtendedPriceLabel.Text = "Extended Price"
        Me.ToolTip1.SetToolTip(Me.ExtendedPriceLabel, "Extended Price")
        '
        'PercentDiscountTextBox
        '
        Me.PercentDiscountTextBox.Location = New System.Drawing.Point(372, 45)
        Me.PercentDiscountTextBox.Name = "PercentDiscountTextBox"
        Me.PercentDiscountTextBox.ReadOnly = True
        Me.PercentDiscountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PercentDiscountTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.PercentDiscountTextBox, "15% Discount is")
        '
        'DiscountPriceTextBox
        '
        Me.DiscountPriceTextBox.Location = New System.Drawing.Point(372, 71)
        Me.DiscountPriceTextBox.Name = "DiscountPriceTextBox"
        Me.DiscountPriceTextBox.ReadOnly = True
        Me.DiscountPriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DiscountPriceTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.DiscountPriceTextBox, "Discount Price is")
        '
        'ExtendedPriceTextBox
        '
        Me.ExtendedPriceTextBox.Location = New System.Drawing.Point(372, 19)
        Me.ExtendedPriceTextBox.Name = "ExtendedPriceTextBox"
        Me.ExtendedPriceTextBox.ReadOnly = True
        Me.ExtendedPriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ExtendedPriceTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ExtendedPriceTextBox, "Extended Price is")
        '
        'SummaryGroup
        '
        Me.SummaryGroup.Controls.Add(Me.AverageDiscount)
        Me.SummaryGroup.Controls.Add(Me.TotalDiscountedAmounts)
        Me.SummaryGroup.Controls.Add(Me.TotalDiscountsGivenLabel)
        Me.SummaryGroup.Controls.Add(Me.AverageDiscountTextBox)
        Me.SummaryGroup.Controls.Add(Me.TotalDiscountedAmountsTextBox)
        Me.SummaryGroup.Controls.Add(Me.TotalDiscountsGivenTextBox)
        Me.SummaryGroup.Controls.Add(Me.TotalNumberOfBooksTextBox)
        Me.SummaryGroup.Controls.Add(Me.TotalNumberOfBooks)
        Me.SummaryGroup.Location = New System.Drawing.Point(12, 248)
        Me.SummaryGroup.Name = "SummaryGroup"
        Me.SummaryGroup.Size = New System.Drawing.Size(478, 125)
        Me.SummaryGroup.TabIndex = 3
        Me.SummaryGroup.TabStop = False
        Me.SummaryGroup.Text = "Summary"
        '
        'AverageDiscount
        '
        Me.AverageDiscount.AutoSize = True
        Me.AverageDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AverageDiscount.Location = New System.Drawing.Point(201, 98)
        Me.AverageDiscount.Name = "AverageDiscount"
        Me.AverageDiscount.Size = New System.Drawing.Size(115, 16)
        Me.AverageDiscount.TabIndex = 6
        Me.AverageDiscount.Text = "Average Discount"
        Me.ToolTip1.SetToolTip(Me.AverageDiscount, "Average Discount")
        '
        'TotalDiscountedAmounts
        '
        Me.TotalDiscountedAmounts.AutoSize = True
        Me.TotalDiscountedAmounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalDiscountedAmounts.Location = New System.Drawing.Point(201, 72)
        Me.TotalDiscountedAmounts.Name = "TotalDiscountedAmounts"
        Me.TotalDiscountedAmounts.Size = New System.Drawing.Size(165, 16)
        Me.TotalDiscountedAmounts.TabIndex = 4
        Me.TotalDiscountedAmounts.Text = "Total Discounted Amounts"
        Me.ToolTip1.SetToolTip(Me.TotalDiscountedAmounts, "Total Discounted Amounts")
        '
        'TotalDiscountsGivenLabel
        '
        Me.TotalDiscountsGivenLabel.AutoSize = True
        Me.TotalDiscountsGivenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalDiscountsGivenLabel.Location = New System.Drawing.Point(201, 46)
        Me.TotalDiscountsGivenLabel.Name = "TotalDiscountsGivenLabel"
        Me.TotalDiscountsGivenLabel.Size = New System.Drawing.Size(139, 16)
        Me.TotalDiscountsGivenLabel.TabIndex = 2
        Me.TotalDiscountsGivenLabel.Text = "Total Discounts Given"
        Me.ToolTip1.SetToolTip(Me.TotalDiscountsGivenLabel, "Total Discounts Given")
        '
        'AverageDiscountTextBox
        '
        Me.AverageDiscountTextBox.Location = New System.Drawing.Point(372, 97)
        Me.AverageDiscountTextBox.Name = "AverageDiscountTextBox"
        Me.AverageDiscountTextBox.ReadOnly = True
        Me.AverageDiscountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AverageDiscountTextBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.AverageDiscountTextBox, "Average Discount is")
        '
        'TotalDiscountedAmountsTextBox
        '
        Me.TotalDiscountedAmountsTextBox.Location = New System.Drawing.Point(372, 71)
        Me.TotalDiscountedAmountsTextBox.Name = "TotalDiscountedAmountsTextBox"
        Me.TotalDiscountedAmountsTextBox.ReadOnly = True
        Me.TotalDiscountedAmountsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalDiscountedAmountsTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.TotalDiscountedAmountsTextBox, "Total Discounted Amounts is")
        '
        'TotalDiscountsGivenTextBox
        '
        Me.TotalDiscountsGivenTextBox.Location = New System.Drawing.Point(372, 45)
        Me.TotalDiscountsGivenTextBox.Name = "TotalDiscountsGivenTextBox"
        Me.TotalDiscountsGivenTextBox.ReadOnly = True
        Me.TotalDiscountsGivenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalDiscountsGivenTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.TotalDiscountsGivenTextBox, "Total Discounts Given is")
        '
        'TotalNumberOfBooksTextBox
        '
        Me.TotalNumberOfBooksTextBox.Location = New System.Drawing.Point(372, 19)
        Me.TotalNumberOfBooksTextBox.Name = "TotalNumberOfBooksTextBox"
        Me.TotalNumberOfBooksTextBox.ReadOnly = True
        Me.TotalNumberOfBooksTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalNumberOfBooksTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TotalNumberOfBooksTextBox, "Total Number of Books is")
        '
        'TotalNumberOfBooks
        '
        Me.TotalNumberOfBooks.AutoSize = True
        Me.TotalNumberOfBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalNumberOfBooks.Location = New System.Drawing.Point(201, 20)
        Me.TotalNumberOfBooks.Name = "TotalNumberOfBooks"
        Me.TotalNumberOfBooks.Size = New System.Drawing.Size(146, 16)
        Me.TotalNumberOfBooks.TabIndex = 0
        Me.TotalNumberOfBooks.Text = "Total Number of Books"
        Me.ToolTip1.SetToolTip(Me.TotalNumberOfBooks, "Total Number of Books")
        '
        'BookSalesLabel
        '
        Me.BookSalesLabel.AutoSize = True
        Me.BookSalesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookSalesLabel.Location = New System.Drawing.Point(197, 9)
        Me.BookSalesLabel.Name = "BookSalesLabel"
        Me.BookSalesLabel.Size = New System.Drawing.Size(131, 25)
        Me.BookSalesLabel.TabIndex = 0
        Me.BookSalesLabel.Text = "Book Sales"
        Me.ToolTip1.SetToolTip(Me.BookSalesLabel, "Book Sales")
        '
        'PrintFormButton
        '
        Me.PrintFormButton.Location = New System.Drawing.Point(12, 379)
        Me.PrintFormButton.Name = "PrintFormButton"
        Me.PrintFormButton.Size = New System.Drawing.Size(99, 23)
        Me.PrintFormButton.TabIndex = 4
        Me.PrintFormButton.Text = "Print &Form"
        Me.ToolTip1.SetToolTip(Me.PrintFormButton, "Print Form")
        Me.PrintFormButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(138, 379)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(99, 23)
        Me.CalculateButton.TabIndex = 5
        Me.CalculateButton.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Calculate")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearSalesButton
        '
        Me.ClearSalesButton.Location = New System.Drawing.Point(269, 379)
        Me.ClearSalesButton.Name = "ClearSalesButton"
        Me.ClearSalesButton.Size = New System.Drawing.Size(99, 23)
        Me.ClearSalesButton.TabIndex = 6
        Me.ClearSalesButton.Text = "Clear &Sales"
        Me.ToolTip1.SetToolTip(Me.ClearSalesButton, "Clear Sales")
        Me.ClearSalesButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(391, 379)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(99, 23)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'ReadingAndRefreshment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 415)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearSalesButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.PrintFormButton)
        Me.Controls.Add(Me.BookSalesLabel)
        Me.Controls.Add(Me.SummaryGroup)
        Me.Controls.Add(Me.DiscountGroup)
        Me.Controls.Add(Me.EntryGroup)
        Me.Name = "ReadingAndRefreshment"
        Me.Text = "Reading and Refreshment"
        Me.EntryGroup.ResumeLayout(False)
        Me.EntryGroup.PerformLayout()
        Me.DiscountGroup.ResumeLayout(False)
        Me.DiscountGroup.PerformLayout()
        Me.SummaryGroup.ResumeLayout(False)
        Me.SummaryGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EntryGroup As System.Windows.Forms.GroupBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuanityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QuanityLabel As System.Windows.Forms.Label
    Friend WithEvents DiscountGroup As System.Windows.Forms.GroupBox
    Friend WithEvents DiscountPriceLabel As System.Windows.Forms.Label
    Friend WithEvents PercentDiscountLabel As System.Windows.Forms.Label
    Friend WithEvents ExtendedPriceLabel As System.Windows.Forms.Label
    Friend WithEvents PercentDiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscountPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExtendedPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SummaryGroup As System.Windows.Forms.GroupBox
    Friend WithEvents AverageDiscount As System.Windows.Forms.Label
    Friend WithEvents TotalDiscountedAmounts As System.Windows.Forms.Label
    Friend WithEvents TotalDiscountsGivenLabel As System.Windows.Forms.Label
    Friend WithEvents AverageDiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalDiscountedAmountsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalDiscountsGivenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalNumberOfBooksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalNumberOfBooks As System.Windows.Forms.Label
    Friend WithEvents BookSalesLabel As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ClearSalesButton As System.Windows.Forms.Button
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents PrintFormButton As System.Windows.Forms.Button

End Class
