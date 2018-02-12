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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.DVDRadioButton = New System.Windows.Forms.RadioButton()
        Me.MemberCheckBox = New System.Windows.Forms.CheckBox()
        Me.NewReleaseCheckBox = New System.Windows.Forms.CheckBox()
        Me.EnterTitleLabel = New System.Windows.Forms.Label()
        Me.VHSRadioButton = New System.Windows.Forms.RadioButton()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.OrderCompleteButton = New System.Windows.Forms.Button()
        Me.OrderSummaryButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ItemAmountTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.ItemAmountLabel = New System.Windows.Forms.Label()
        Me.SubTotalLabel = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.VideoBonanzaLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(36, 111)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(559, 26)
        Me.TitleTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.TitleTextBox, "Enter Title")
        '
        'DVDRadioButton
        '
        Me.DVDRadioButton.AutoSize = True
        Me.DVDRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DVDRadioButton.Location = New System.Drawing.Point(62, 158)
        Me.DVDRadioButton.Name = "DVDRadioButton"
        Me.DVDRadioButton.Size = New System.Drawing.Size(62, 24)
        Me.DVDRadioButton.TabIndex = 3
        Me.DVDRadioButton.TabStop = True
        Me.DVDRadioButton.Text = "&DVD"
        Me.ToolTip1.SetToolTip(Me.DVDRadioButton, "DVD")
        Me.DVDRadioButton.UseVisualStyleBackColor = True
        '
        'MemberCheckBox
        '
        Me.MemberCheckBox.AutoSize = True
        Me.MemberCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberCheckBox.Location = New System.Drawing.Point(63, 248)
        Me.MemberCheckBox.Name = "MemberCheckBox"
        Me.MemberCheckBox.Size = New System.Drawing.Size(86, 24)
        Me.MemberCheckBox.TabIndex = 6
        Me.MemberCheckBox.Text = "&Member"
        Me.ToolTip1.SetToolTip(Me.MemberCheckBox, "Member")
        Me.MemberCheckBox.UseVisualStyleBackColor = True
        '
        'NewReleaseCheckBox
        '
        Me.NewReleaseCheckBox.AutoSize = True
        Me.NewReleaseCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewReleaseCheckBox.Location = New System.Drawing.Point(63, 218)
        Me.NewReleaseCheckBox.Name = "NewReleaseCheckBox"
        Me.NewReleaseCheckBox.Size = New System.Drawing.Size(122, 24)
        Me.NewReleaseCheckBox.TabIndex = 5
        Me.NewReleaseCheckBox.Text = "&New Release"
        Me.ToolTip1.SetToolTip(Me.NewReleaseCheckBox, "New Release")
        Me.NewReleaseCheckBox.UseVisualStyleBackColor = True
        '
        'EnterTitleLabel
        '
        Me.EnterTitleLabel.AutoSize = True
        Me.EnterTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterTitleLabel.Location = New System.Drawing.Point(32, 78)
        Me.EnterTitleLabel.Name = "EnterTitleLabel"
        Me.EnterTitleLabel.Size = New System.Drawing.Size(81, 20)
        Me.EnterTitleLabel.TabIndex = 1
        Me.EnterTitleLabel.Text = "Enter Title"
        Me.ToolTip1.SetToolTip(Me.EnterTitleLabel, "Enter Title")
        '
        'VHSRadioButton
        '
        Me.VHSRadioButton.AutoSize = True
        Me.VHSRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VHSRadioButton.Location = New System.Drawing.Point(63, 188)
        Me.VHSRadioButton.Name = "VHSRadioButton"
        Me.VHSRadioButton.Size = New System.Drawing.Size(61, 24)
        Me.VHSRadioButton.TabIndex = 4
        Me.VHSRadioButton.TabStop = True
        Me.VHSRadioButton.Text = "&VHS"
        Me.ToolTip1.SetToolTip(Me.VHSRadioButton, "VHS")
        Me.VHSRadioButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateButton.Location = New System.Drawing.Point(12, 312)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(191, 32)
        Me.CalculateButton.TabIndex = 7
        Me.CalculateButton.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Calculate")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(12, 350)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(191, 32)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "Clea&r"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'OrderCompleteButton
        '
        Me.OrderCompleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderCompleteButton.Location = New System.Drawing.Point(215, 312)
        Me.OrderCompleteButton.Name = "OrderCompleteButton"
        Me.OrderCompleteButton.Size = New System.Drawing.Size(191, 32)
        Me.OrderCompleteButton.TabIndex = 8
        Me.OrderCompleteButton.Text = "&Order Complete"
        Me.ToolTip1.SetToolTip(Me.OrderCompleteButton, "Order Complete")
        Me.OrderCompleteButton.UseVisualStyleBackColor = True
        '
        'OrderSummaryButton
        '
        Me.OrderSummaryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderSummaryButton.Location = New System.Drawing.Point(421, 312)
        Me.OrderSummaryButton.Name = "OrderSummaryButton"
        Me.OrderSummaryButton.Size = New System.Drawing.Size(191, 32)
        Me.OrderSummaryButton.TabIndex = 9
        Me.OrderSummaryButton.Text = "Order &Summary"
        Me.ToolTip1.SetToolTip(Me.OrderSummaryButton, "Order Summary")
        Me.OrderSummaryButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(215, 350)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(191, 32)
        Me.PrintButton.TabIndex = 11
        Me.PrintButton.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "Print")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(421, 350)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(191, 32)
        Me.ExitButton.TabIndex = 12
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ItemAmountTextBox
        '
        Me.ItemAmountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemAmountTextBox.Location = New System.Drawing.Point(399, 186)
        Me.ItemAmountTextBox.Name = "ItemAmountTextBox"
        Me.ItemAmountTextBox.ReadOnly = True
        Me.ItemAmountTextBox.Size = New System.Drawing.Size(196, 26)
        Me.ItemAmountTextBox.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.ItemAmountTextBox, "Item Amount")
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotalTextBox.Location = New System.Drawing.Point(399, 248)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.ReadOnly = True
        Me.SubTotalTextBox.Size = New System.Drawing.Size(196, 26)
        Me.SubTotalTextBox.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.SubTotalTextBox, "Subtotal")
        '
        'ItemAmountLabel
        '
        Me.ItemAmountLabel.AutoSize = True
        Me.ItemAmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemAmountLabel.Location = New System.Drawing.Point(395, 158)
        Me.ItemAmountLabel.Name = "ItemAmountLabel"
        Me.ItemAmountLabel.Size = New System.Drawing.Size(101, 20)
        Me.ItemAmountLabel.TabIndex = 13
        Me.ItemAmountLabel.Text = "Item Amount"
        Me.ToolTip1.SetToolTip(Me.ItemAmountLabel, "Item Amount")
        '
        'SubTotalLabel
        '
        Me.SubTotalLabel.AutoSize = True
        Me.SubTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotalLabel.Location = New System.Drawing.Point(395, 218)
        Me.SubTotalLabel.Name = "SubTotalLabel"
        Me.SubTotalLabel.Size = New System.Drawing.Size(69, 20)
        Me.SubTotalLabel.TabIndex = 15
        Me.SubTotalLabel.Text = "Subtotal"
        Me.ToolTip1.SetToolTip(Me.SubTotalLabel, "Subtotal")
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'VideoBonanzaLabel
        '
        Me.VideoBonanzaLabel.AutoSize = True
        Me.VideoBonanzaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VideoBonanzaLabel.Location = New System.Drawing.Point(171, 9)
        Me.VideoBonanzaLabel.Name = "VideoBonanzaLabel"
        Me.VideoBonanzaLabel.Size = New System.Drawing.Size(235, 37)
        Me.VideoBonanzaLabel.TabIndex = 0
        Me.VideoBonanzaLabel.Text = "Video Bonanza"
        '
        'VideoBonanza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 394)
        Me.Controls.Add(Me.SubTotalLabel)
        Me.Controls.Add(Me.ItemAmountLabel)
        Me.Controls.Add(Me.SubTotalTextBox)
        Me.Controls.Add(Me.ItemAmountTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.OrderSummaryButton)
        Me.Controls.Add(Me.OrderCompleteButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.VHSRadioButton)
        Me.Controls.Add(Me.EnterTitleLabel)
        Me.Controls.Add(Me.NewReleaseCheckBox)
        Me.Controls.Add(Me.MemberCheckBox)
        Me.Controls.Add(Me.DVDRadioButton)
        Me.Controls.Add(Me.VideoBonanzaLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Name = "VideoBonanza"
        Me.Text = "Video Bonanza"
        Me.ToolTip1.SetToolTip(Me, "Video Bonanza")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents EnterTitleLabel As System.Windows.Forms.Label
    Friend WithEvents NewReleaseCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MemberCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DVDRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents VideoBonanzaLabel As System.Windows.Forms.Label
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VHSRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents OrderSummaryButton As System.Windows.Forms.Button
    Friend WithEvents OrderCompleteButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents SubTotalLabel As System.Windows.Forms.Label
    Friend WithEvents ItemAmountLabel As System.Windows.Forms.Label
    Friend WithEvents SubTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemAmountTextBox As System.Windows.Forms.TextBox

End Class
