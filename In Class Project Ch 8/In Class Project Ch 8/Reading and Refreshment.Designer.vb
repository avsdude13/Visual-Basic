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
        Me.CoffeePricesGroupBox = New System.Windows.Forms.GroupBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.FindPriceButton = New System.Windows.Forms.Button()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.TypeLabel = New System.Windows.Forms.Label()
        Me.TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.QualityGroupBox = New System.Windows.Forms.GroupBox()
        Me.FullPoundRadioButton = New System.Windows.Forms.RadioButton()
        Me.HalfPoundRadioButton = New System.Windows.Forms.RadioButton()
        Me.QuarterPoundRadioButton = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.CoffeePricesGroupBox.SuspendLayout()
        Me.QualityGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CoffeePricesGroupBox
        '
        Me.CoffeePricesGroupBox.Controls.Add(Me.PriceTextBox)
        Me.CoffeePricesGroupBox.Controls.Add(Me.ExitButton)
        Me.CoffeePricesGroupBox.Controls.Add(Me.PrintButton)
        Me.CoffeePricesGroupBox.Controls.Add(Me.ClearButton)
        Me.CoffeePricesGroupBox.Controls.Add(Me.FindPriceButton)
        Me.CoffeePricesGroupBox.Controls.Add(Me.PriceLabel)
        Me.CoffeePricesGroupBox.Controls.Add(Me.TypeLabel)
        Me.CoffeePricesGroupBox.Controls.Add(Me.TypeComboBox)
        Me.CoffeePricesGroupBox.Controls.Add(Me.QualityGroupBox)
        Me.CoffeePricesGroupBox.Location = New System.Drawing.Point(12, 22)
        Me.CoffeePricesGroupBox.Name = "CoffeePricesGroupBox"
        Me.CoffeePricesGroupBox.Size = New System.Drawing.Size(492, 187)
        Me.CoffeePricesGroupBox.TabIndex = 0
        Me.CoffeePricesGroupBox.TabStop = False
        Me.CoffeePricesGroupBox.Text = "Coffee Prices"
        Me.ToolTip1.SetToolTip(Me.CoffeePricesGroupBox, "Coffee Prices")
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(310, 80)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(165, 20)
        Me.PriceTextBox.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.PriceTextBox, "Price")
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(376, 148)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(99, 25)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(254, 148)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(99, 25)
        Me.PrintButton.TabIndex = 7
        Me.PrintButton.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "Print")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(137, 148)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(99, 25)
        Me.ClearButton.TabIndex = 6
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'FindPriceButton
        '
        Me.FindPriceButton.Location = New System.Drawing.Point(15, 148)
        Me.FindPriceButton.Name = "FindPriceButton"
        Me.FindPriceButton.Size = New System.Drawing.Size(99, 25)
        Me.FindPriceButton.TabIndex = 5
        Me.FindPriceButton.Text = "&Find Price"
        Me.ToolTip1.SetToolTip(Me.FindPriceButton, "Find Price")
        Me.FindPriceButton.UseVisualStyleBackColor = True
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Location = New System.Drawing.Point(264, 83)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(31, 13)
        Me.PriceLabel.TabIndex = 4
        Me.PriceLabel.Text = "Price"
        Me.ToolTip1.SetToolTip(Me.PriceLabel, "Price")
        '
        'TypeLabel
        '
        Me.TypeLabel.AutoSize = True
        Me.TypeLabel.Location = New System.Drawing.Point(264, 56)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(31, 13)
        Me.TypeLabel.TabIndex = 3
        Me.TypeLabel.Text = "&Type"
        Me.ToolTip1.SetToolTip(Me.TypeLabel, "Type")
        '
        'TypeComboBox
        '
        Me.TypeComboBox.FormattingEnabled = True
        Me.TypeComboBox.Items.AddRange(New Object() {"Regular", "Decaffeinated", "Special Blend"})
        Me.TypeComboBox.Location = New System.Drawing.Point(310, 53)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.Size = New System.Drawing.Size(165, 21)
        Me.TypeComboBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TypeComboBox, "Type")
        '
        'QualityGroupBox
        '
        Me.QualityGroupBox.Controls.Add(Me.FullPoundRadioButton)
        Me.QualityGroupBox.Controls.Add(Me.HalfPoundRadioButton)
        Me.QualityGroupBox.Controls.Add(Me.QuarterPoundRadioButton)
        Me.QualityGroupBox.Location = New System.Drawing.Point(15, 35)
        Me.QualityGroupBox.Name = "QualityGroupBox"
        Me.QualityGroupBox.Size = New System.Drawing.Size(178, 101)
        Me.QualityGroupBox.TabIndex = 0
        Me.QualityGroupBox.TabStop = False
        Me.QualityGroupBox.Text = "Quality"
        Me.ToolTip1.SetToolTip(Me.QualityGroupBox, "Quality")
        '
        'FullPoundRadioButton
        '
        Me.FullPoundRadioButton.AutoSize = True
        Me.FullPoundRadioButton.Location = New System.Drawing.Point(25, 65)
        Me.FullPoundRadioButton.Name = "FullPoundRadioButton"
        Me.FullPoundRadioButton.Size = New System.Drawing.Size(75, 17)
        Me.FullPoundRadioButton.TabIndex = 2
        Me.FullPoundRadioButton.TabStop = True
        Me.FullPoundRadioButton.Text = "Ful&l Pound"
        Me.ToolTip1.SetToolTip(Me.FullPoundRadioButton, "Full Pound")
        Me.FullPoundRadioButton.UseVisualStyleBackColor = True
        '
        'HalfPoundRadioButton
        '
        Me.HalfPoundRadioButton.AutoSize = True
        Me.HalfPoundRadioButton.Location = New System.Drawing.Point(25, 42)
        Me.HalfPoundRadioButton.Name = "HalfPoundRadioButton"
        Me.HalfPoundRadioButton.Size = New System.Drawing.Size(78, 17)
        Me.HalfPoundRadioButton.TabIndex = 1
        Me.HalfPoundRadioButton.TabStop = True
        Me.HalfPoundRadioButton.Text = "&Half Pound"
        Me.ToolTip1.SetToolTip(Me.HalfPoundRadioButton, "Half Pound")
        Me.HalfPoundRadioButton.UseVisualStyleBackColor = True
        '
        'QuarterPoundRadioButton
        '
        Me.QuarterPoundRadioButton.AutoSize = True
        Me.QuarterPoundRadioButton.Location = New System.Drawing.Point(25, 19)
        Me.QuarterPoundRadioButton.Name = "QuarterPoundRadioButton"
        Me.QuarterPoundRadioButton.Size = New System.Drawing.Size(94, 17)
        Me.QuarterPoundRadioButton.TabIndex = 0
        Me.QuarterPoundRadioButton.TabStop = True
        Me.QuarterPoundRadioButton.Text = "&Quarter Pound"
        Me.ToolTip1.SetToolTip(Me.QuarterPoundRadioButton, "Quarter Pound")
        Me.QuarterPoundRadioButton.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'ReadingAndRefreshment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 220)
        Me.Controls.Add(Me.CoffeePricesGroupBox)
        Me.Name = "ReadingAndRefreshment"
        Me.Text = "Reading and Refreshment"
        Me.ToolTip1.SetToolTip(Me, "Reading and Refreshment")
        Me.CoffeePricesGroupBox.ResumeLayout(False)
        Me.CoffeePricesGroupBox.PerformLayout()
        Me.QualityGroupBox.ResumeLayout(False)
        Me.QualityGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CoffeePricesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents QualityGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents FullPoundRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents HalfPoundRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents QuarterPoundRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents FindPriceButton As System.Windows.Forms.Button
    Friend WithEvents PriceLabel As System.Windows.Forms.Label
    Friend WithEvents TypeLabel As System.Windows.Forms.Label
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument

End Class
