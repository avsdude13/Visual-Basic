<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoBonanza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VideoBonanza))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.MemberLabel = New System.Windows.Forms.Label()
        Me.NumberOfMoviesTextBox = New System.Windows.Forms.TextBox()
        Me.NumberOfMoviesLabel = New System.Windows.Forms.Label()
        Me.MemberNumberTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.PricePerMovieTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.CustomersServedTextBox = New System.Windows.Forms.TextBox()
        Me.IncomeTextBox = New System.Windows.Forms.TextBox()
        Me.CustomersServedLabel = New System.Windows.Forms.Label()
        Me.TotalIncomeLabel = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.PricePerMovieLabel = New System.Windows.Forms.Label()
        Me.DiscountLabel = New System.Windows.Forms.Label()
        Me.VideoBonanzaLabel = New System.Windows.Forms.Label()
        Me.TotalSummaryGroupBox = New System.Windows.Forms.GroupBox()
        Me.CompanyTotalsGroupBox = New System.Windows.Forms.GroupBox()
        Me.InputGroupBox.SuspendLayout()
        Me.TotalSummaryGroupBox.SuspendLayout()
        Me.CompanyTotalsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.MemberLabel)
        Me.InputGroupBox.Controls.Add(Me.NumberOfMoviesTextBox)
        Me.InputGroupBox.Controls.Add(Me.NumberOfMoviesLabel)
        Me.InputGroupBox.Controls.Add(Me.MemberNumberTextBox)
        Me.InputGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputGroupBox.Location = New System.Drawing.Point(12, 49)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(461, 97)
        Me.InputGroupBox.TabIndex = 1
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "Enter Information Here"
        Me.ToolTip1.SetToolTip(Me.InputGroupBox, "Enter Information Here")
        '
        'MemberLabel
        '
        Me.MemberLabel.AutoSize = True
        Me.MemberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberLabel.Location = New System.Drawing.Point(21, 31)
        Me.MemberLabel.Name = "MemberLabel"
        Me.MemberLabel.Size = New System.Drawing.Size(109, 16)
        Me.MemberLabel.TabIndex = 0
        Me.MemberLabel.Text = "&Member Number"
        Me.ToolTip1.SetToolTip(Me.MemberLabel, "Member Number")
        '
        'NumberOfMoviesTextBox
        '
        Me.NumberOfMoviesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfMoviesTextBox.Location = New System.Drawing.Point(149, 60)
        Me.NumberOfMoviesTextBox.Name = "NumberOfMoviesTextBox"
        Me.NumberOfMoviesTextBox.Size = New System.Drawing.Size(199, 22)
        Me.NumberOfMoviesTextBox.TabIndex = 3
        '
        'NumberOfMoviesLabel
        '
        Me.NumberOfMoviesLabel.AutoSize = True
        Me.NumberOfMoviesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfMoviesLabel.Location = New System.Drawing.Point(8, 63)
        Me.NumberOfMoviesLabel.Name = "NumberOfMoviesLabel"
        Me.NumberOfMoviesLabel.Size = New System.Drawing.Size(119, 16)
        Me.NumberOfMoviesLabel.TabIndex = 2
        Me.NumberOfMoviesLabel.Text = "&Number Of Movies"
        Me.ToolTip1.SetToolTip(Me.NumberOfMoviesLabel, "Number Of Movies")
        '
        'MemberNumberTextBox
        '
        Me.MemberNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberNumberTextBox.Location = New System.Drawing.Point(149, 28)
        Me.MemberNumberTextBox.Name = "MemberNumberTextBox"
        Me.MemberNumberTextBox.Size = New System.Drawing.Size(199, 22)
        Me.MemberNumberTextBox.TabIndex = 1
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.Location = New System.Drawing.Point(355, 45)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.ReadOnly = True
        Me.DiscountTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DiscountTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.DiscountTextBox, "Discount Given")
        '
        'PricePerMovieTextBox
        '
        Me.PricePerMovieTextBox.Location = New System.Drawing.Point(355, 19)
        Me.PricePerMovieTextBox.Name = "PricePerMovieTextBox"
        Me.PricePerMovieTextBox.ReadOnly = True
        Me.PricePerMovieTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PricePerMovieTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.PricePerMovieTextBox, "Price per Movie")
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(355, 71)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TotalTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.TotalTextBox, "Discount Given")
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(253, 345)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(96, 28)
        Me.PrintButton.TabIndex = 6
        Me.PrintButton.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "Print")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(377, 345)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(96, 28)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(130, 345)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(96, 28)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "Clea&r"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateButton.Location = New System.Drawing.Point(12, 345)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(96, 28)
        Me.CalculateButton.TabIndex = 4
        Me.CalculateButton.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Calculate")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'CustomersServedTextBox
        '
        Me.CustomersServedTextBox.Location = New System.Drawing.Point(355, 19)
        Me.CustomersServedTextBox.Name = "CustomersServedTextBox"
        Me.CustomersServedTextBox.ReadOnly = True
        Me.CustomersServedTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CustomersServedTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.CustomersServedTextBox, "Customers Served")
        '
        'IncomeTextBox
        '
        Me.IncomeTextBox.Location = New System.Drawing.Point(355, 45)
        Me.IncomeTextBox.Name = "IncomeTextBox"
        Me.IncomeTextBox.ReadOnly = True
        Me.IncomeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IncomeTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.IncomeTextBox, "Income")
        '
        'CustomersServedLabel
        '
        Me.CustomersServedLabel.AutoSize = True
        Me.CustomersServedLabel.Location = New System.Drawing.Point(229, 22)
        Me.CustomersServedLabel.Name = "CustomersServedLabel"
        Me.CustomersServedLabel.Size = New System.Drawing.Size(119, 16)
        Me.CustomersServedLabel.TabIndex = 0
        Me.CustomersServedLabel.Text = "Customers Served"
        Me.ToolTip1.SetToolTip(Me.CustomersServedLabel, "Customers Served")
        '
        'TotalIncomeLabel
        '
        Me.TotalIncomeLabel.AutoSize = True
        Me.TotalIncomeLabel.Location = New System.Drawing.Point(296, 48)
        Me.TotalIncomeLabel.Name = "TotalIncomeLabel"
        Me.TotalIncomeLabel.Size = New System.Drawing.Size(52, 16)
        Me.TotalIncomeLabel.TabIndex = 2
        Me.TotalIncomeLabel.Text = "Income"
        Me.ToolTip1.SetToolTip(Me.TotalIncomeLabel, "Income")
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(309, 74)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(39, 16)
        Me.TotalLabel.TabIndex = 4
        Me.TotalLabel.Text = "Total"
        Me.ToolTip1.SetToolTip(Me.TotalLabel, "Total")
        '
        'PricePerMovieLabel
        '
        Me.PricePerMovieLabel.AutoSize = True
        Me.PricePerMovieLabel.Location = New System.Drawing.Point(250, 22)
        Me.PricePerMovieLabel.Name = "PricePerMovieLabel"
        Me.PricePerMovieLabel.Size = New System.Drawing.Size(103, 16)
        Me.PricePerMovieLabel.TabIndex = 0
        Me.PricePerMovieLabel.Text = "Price Per Movie"
        Me.ToolTip1.SetToolTip(Me.PricePerMovieLabel, "Price Per Movie")
        '
        'DiscountLabel
        '
        Me.DiscountLabel.AutoSize = True
        Me.DiscountLabel.Location = New System.Drawing.Point(259, 48)
        Me.DiscountLabel.Name = "DiscountLabel"
        Me.DiscountLabel.Size = New System.Drawing.Size(89, 16)
        Me.DiscountLabel.TabIndex = 2
        Me.DiscountLabel.Text = "10% Discount"
        Me.ToolTip1.SetToolTip(Me.DiscountLabel, "10% Discount")
        '
        'VideoBonanzaLabel
        '
        Me.VideoBonanzaLabel.AutoSize = True
        Me.VideoBonanzaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VideoBonanzaLabel.Location = New System.Drawing.Point(162, 9)
        Me.VideoBonanzaLabel.Name = "VideoBonanzaLabel"
        Me.VideoBonanzaLabel.Size = New System.Drawing.Size(171, 25)
        Me.VideoBonanzaLabel.TabIndex = 0
        Me.VideoBonanzaLabel.Text = "Video Bonanza"
        Me.ToolTip1.SetToolTip(Me.VideoBonanzaLabel, "Video Bonanza")
        '
        'TotalSummaryGroupBox
        '
        Me.TotalSummaryGroupBox.Controls.Add(Me.TotalLabel)
        Me.TotalSummaryGroupBox.Controls.Add(Me.TotalTextBox)
        Me.TotalSummaryGroupBox.Controls.Add(Me.PricePerMovieTextBox)
        Me.TotalSummaryGroupBox.Controls.Add(Me.DiscountTextBox)
        Me.TotalSummaryGroupBox.Controls.Add(Me.PricePerMovieLabel)
        Me.TotalSummaryGroupBox.Controls.Add(Me.DiscountLabel)
        Me.TotalSummaryGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSummaryGroupBox.Location = New System.Drawing.Point(12, 152)
        Me.TotalSummaryGroupBox.Name = "TotalSummaryGroupBox"
        Me.TotalSummaryGroupBox.Size = New System.Drawing.Size(461, 100)
        Me.TotalSummaryGroupBox.TabIndex = 2
        Me.TotalSummaryGroupBox.TabStop = False
        Me.TotalSummaryGroupBox.Text = "Order Summary"
        Me.ToolTip1.SetToolTip(Me.TotalSummaryGroupBox, "Order Summary")
        '
        'CompanyTotalsGroupBox
        '
        Me.CompanyTotalsGroupBox.Controls.Add(Me.CustomersServedTextBox)
        Me.CompanyTotalsGroupBox.Controls.Add(Me.IncomeTextBox)
        Me.CompanyTotalsGroupBox.Controls.Add(Me.CustomersServedLabel)
        Me.CompanyTotalsGroupBox.Controls.Add(Me.TotalIncomeLabel)
        Me.CompanyTotalsGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanyTotalsGroupBox.Location = New System.Drawing.Point(12, 258)
        Me.CompanyTotalsGroupBox.Name = "CompanyTotalsGroupBox"
        Me.CompanyTotalsGroupBox.Size = New System.Drawing.Size(461, 72)
        Me.CompanyTotalsGroupBox.TabIndex = 3
        Me.CompanyTotalsGroupBox.TabStop = False
        Me.CompanyTotalsGroupBox.Text = "Company Totals"
        Me.ToolTip1.SetToolTip(Me.CompanyTotalsGroupBox, "Company Totals")
        '
        'VideoBonanza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(485, 385)
        Me.Controls.Add(Me.CompanyTotalsGroupBox)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.TotalSummaryGroupBox)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Controls.Add(Me.VideoBonanzaLabel)
        Me.Name = "VideoBonanza"
        Me.Text = "Video Bonanza"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.TotalSummaryGroupBox.ResumeLayout(False)
        Me.TotalSummaryGroupBox.PerformLayout()
        Me.CompanyTotalsGroupBox.ResumeLayout(False)
        Me.CompanyTotalsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents InputGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MemberLabel As System.Windows.Forms.Label
    Friend WithEvents NumberOfMoviesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumberOfMoviesLabel As System.Windows.Forms.Label
    Friend WithEvents MemberNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents VideoBonanzaLabel As System.Windows.Forms.Label
    Friend WithEvents TotalSummaryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PricePerMovieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PricePerMovieLabel As System.Windows.Forms.Label
    Friend WithEvents DiscountLabel As System.Windows.Forms.Label
    Friend WithEvents CompanyTotalsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CustomersServedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IncomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomersServedLabel As System.Windows.Forms.Label
    Friend WithEvents TotalIncomeLabel As System.Windows.Forms.Label
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox

End Class
