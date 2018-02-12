<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LynetteRifleBeautySalon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LynetteRifleBeautySalon))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TypeOfServiceGroupBox = New System.Windows.Forms.GroupBox()
        Me.DiscountRateGroupBox = New System.Windows.Forms.GroupBox()
        Me.OrderInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.LynetteRifleBeautySalonLabel = New System.Windows.Forms.Label()
        Me.NoDiscountRadioButton = New System.Windows.Forms.RadioButton()
        Me.TenPercentRadioButton = New System.Windows.Forms.RadioButton()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.TwentyPercentRadioButton = New System.Windows.Forms.RadioButton()
        Me.MakeoverCheckBox = New System.Windows.Forms.CheckBox()
        Me.HairStylingCheckBox = New System.Windows.Forms.CheckBox()
        Me.ManicureCheckBox = New System.Windows.Forms.CheckBox()
        Me.PermenentMakeupCheckBox = New System.Windows.Forms.CheckBox()
        Me.ServiceCostLabel = New System.Windows.Forms.Label()
        Me.SubtotalLabel = New System.Windows.Forms.Label()
        Me.NumberOfServicesLabel = New System.Windows.Forms.Label()
        Me.TotalDueLabel = New System.Windows.Forms.Label()
        Me.ServiceCostTextBox = New System.Windows.Forms.TextBox()
        Me.NumberOfServicesTextBox = New System.Windows.Forms.TextBox()
        Me.SubtotalTextBox = New System.Windows.Forms.TextBox()
        Me.TotalDueTextBox = New System.Windows.Forms.TextBox()
        Me.TypeOfServiceGroupBox.SuspendLayout()
        Me.DiscountRateGroupBox.SuspendLayout()
        Me.OrderInformationGroupBox.SuspendLayout()
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
        'TypeOfServiceGroupBox
        '
        Me.TypeOfServiceGroupBox.Controls.Add(Me.PermenentMakeupCheckBox)
        Me.TypeOfServiceGroupBox.Controls.Add(Me.ManicureCheckBox)
        Me.TypeOfServiceGroupBox.Controls.Add(Me.HairStylingCheckBox)
        Me.TypeOfServiceGroupBox.Controls.Add(Me.MakeoverCheckBox)
        Me.TypeOfServiceGroupBox.Location = New System.Drawing.Point(30, 79)
        Me.TypeOfServiceGroupBox.Name = "TypeOfServiceGroupBox"
        Me.TypeOfServiceGroupBox.Size = New System.Drawing.Size(200, 120)
        Me.TypeOfServiceGroupBox.TabIndex = 1
        Me.TypeOfServiceGroupBox.TabStop = False
        Me.TypeOfServiceGroupBox.Text = "Type of Service"
        Me.ToolTip1.SetToolTip(Me.TypeOfServiceGroupBox, "Type of Service")
        '
        'DiscountRateGroupBox
        '
        Me.DiscountRateGroupBox.Controls.Add(Me.TwentyPercentRadioButton)
        Me.DiscountRateGroupBox.Controls.Add(Me.TenPercentRadioButton)
        Me.DiscountRateGroupBox.Controls.Add(Me.NoDiscountRadioButton)
        Me.DiscountRateGroupBox.Location = New System.Drawing.Point(30, 205)
        Me.DiscountRateGroupBox.Name = "DiscountRateGroupBox"
        Me.DiscountRateGroupBox.Size = New System.Drawing.Size(200, 90)
        Me.DiscountRateGroupBox.TabIndex = 2
        Me.DiscountRateGroupBox.TabStop = False
        Me.DiscountRateGroupBox.Text = "Discount Rate"
        Me.ToolTip1.SetToolTip(Me.DiscountRateGroupBox, "Discount Rate")
        '
        'OrderInformationGroupBox
        '
        Me.OrderInformationGroupBox.Controls.Add(Me.TotalDueTextBox)
        Me.OrderInformationGroupBox.Controls.Add(Me.SubtotalTextBox)
        Me.OrderInformationGroupBox.Controls.Add(Me.NumberOfServicesTextBox)
        Me.OrderInformationGroupBox.Controls.Add(Me.ServiceCostTextBox)
        Me.OrderInformationGroupBox.Controls.Add(Me.TotalDueLabel)
        Me.OrderInformationGroupBox.Controls.Add(Me.NumberOfServicesLabel)
        Me.OrderInformationGroupBox.Controls.Add(Me.SubtotalLabel)
        Me.OrderInformationGroupBox.Controls.Add(Me.ServiceCostLabel)
        Me.OrderInformationGroupBox.Location = New System.Drawing.Point(253, 79)
        Me.OrderInformationGroupBox.Name = "OrderInformationGroupBox"
        Me.OrderInformationGroupBox.Size = New System.Drawing.Size(212, 216)
        Me.OrderInformationGroupBox.TabIndex = 5
        Me.OrderInformationGroupBox.TabStop = False
        Me.OrderInformationGroupBox.Text = "Total"
        Me.ToolTip1.SetToolTip(Me.OrderInformationGroupBox, "Order Information")
        '
        'LynetteRifleBeautySalonLabel
        '
        Me.LynetteRifleBeautySalonLabel.AutoSize = True
        Me.LynetteRifleBeautySalonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LynetteRifleBeautySalonLabel.Location = New System.Drawing.Point(74, 25)
        Me.LynetteRifleBeautySalonLabel.Name = "LynetteRifleBeautySalonLabel"
        Me.LynetteRifleBeautySalonLabel.Size = New System.Drawing.Size(334, 31)
        Me.LynetteRifleBeautySalonLabel.TabIndex = 0
        Me.LynetteRifleBeautySalonLabel.Text = "Lynette Rifle Beauty Salon"
        Me.ToolTip1.SetToolTip(Me.LynetteRifleBeautySalonLabel, "Lynette Rifle Beauty Salon")
        '
        'NoDiscountRadioButton
        '
        Me.NoDiscountRadioButton.AutoSize = True
        Me.NoDiscountRadioButton.Location = New System.Drawing.Point(25, 19)
        Me.NoDiscountRadioButton.Name = "NoDiscountRadioButton"
        Me.NoDiscountRadioButton.Size = New System.Drawing.Size(84, 17)
        Me.NoDiscountRadioButton.TabIndex = 0
        Me.NoDiscountRadioButton.TabStop = True
        Me.NoDiscountRadioButton.Text = "No Discount"
        Me.ToolTip1.SetToolTip(Me.NoDiscountRadioButton, "No Discount")
        Me.NoDiscountRadioButton.UseVisualStyleBackColor = True
        '
        'TenPercentRadioButton
        '
        Me.TenPercentRadioButton.AutoSize = True
        Me.TenPercentRadioButton.Location = New System.Drawing.Point(25, 42)
        Me.TenPercentRadioButton.Name = "TenPercentRadioButton"
        Me.TenPercentRadioButton.Size = New System.Drawing.Size(62, 17)
        Me.TenPercentRadioButton.TabIndex = 1
        Me.TenPercentRadioButton.TabStop = True
        Me.TenPercentRadioButton.Text = "10% Off"
        Me.ToolTip1.SetToolTip(Me.TenPercentRadioButton, "10% Off")
        Me.TenPercentRadioButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(30, 312)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 3
        Me.CalculateButton.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Calculate")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(144, 312)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clea&r"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(263, 312)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 6
        Me.PrintButton.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "Print")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(390, 312)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'TwentyPercentRadioButton
        '
        Me.TwentyPercentRadioButton.AutoSize = True
        Me.TwentyPercentRadioButton.Location = New System.Drawing.Point(25, 65)
        Me.TwentyPercentRadioButton.Name = "TwentyPercentRadioButton"
        Me.TwentyPercentRadioButton.Size = New System.Drawing.Size(62, 17)
        Me.TwentyPercentRadioButton.TabIndex = 2
        Me.TwentyPercentRadioButton.TabStop = True
        Me.TwentyPercentRadioButton.Text = "20% Off"
        Me.ToolTip1.SetToolTip(Me.TwentyPercentRadioButton, "20% Off")
        Me.TwentyPercentRadioButton.UseVisualStyleBackColor = True
        '
        'MakeoverCheckBox
        '
        Me.MakeoverCheckBox.AutoSize = True
        Me.MakeoverCheckBox.Location = New System.Drawing.Point(25, 19)
        Me.MakeoverCheckBox.Name = "MakeoverCheckBox"
        Me.MakeoverCheckBox.Size = New System.Drawing.Size(74, 17)
        Me.MakeoverCheckBox.TabIndex = 0
        Me.MakeoverCheckBox.Text = "&Makeover"
        Me.ToolTip1.SetToolTip(Me.MakeoverCheckBox, "Makeover")
        Me.MakeoverCheckBox.UseVisualStyleBackColor = True
        '
        'HairStylingCheckBox
        '
        Me.HairStylingCheckBox.AutoSize = True
        Me.HairStylingCheckBox.Location = New System.Drawing.Point(25, 42)
        Me.HairStylingCheckBox.Name = "HairStylingCheckBox"
        Me.HairStylingCheckBox.Size = New System.Drawing.Size(79, 17)
        Me.HairStylingCheckBox.TabIndex = 1
        Me.HairStylingCheckBox.Text = "&Hair Styling"
        Me.ToolTip1.SetToolTip(Me.HairStylingCheckBox, "HairStyling")
        Me.HairStylingCheckBox.UseVisualStyleBackColor = True
        '
        'ManicureCheckBox
        '
        Me.ManicureCheckBox.AutoSize = True
        Me.ManicureCheckBox.Location = New System.Drawing.Point(25, 65)
        Me.ManicureCheckBox.Name = "ManicureCheckBox"
        Me.ManicureCheckBox.Size = New System.Drawing.Size(70, 17)
        Me.ManicureCheckBox.TabIndex = 2
        Me.ManicureCheckBox.Text = "M&anicure"
        Me.ToolTip1.SetToolTip(Me.ManicureCheckBox, "Manicure")
        Me.ManicureCheckBox.UseVisualStyleBackColor = True
        '
        'PermenentMakeupCheckBox
        '
        Me.PermenentMakeupCheckBox.AutoSize = True
        Me.PermenentMakeupCheckBox.Location = New System.Drawing.Point(25, 88)
        Me.PermenentMakeupCheckBox.Name = "PermenentMakeupCheckBox"
        Me.PermenentMakeupCheckBox.Size = New System.Drawing.Size(119, 17)
        Me.PermenentMakeupCheckBox.TabIndex = 3
        Me.PermenentMakeupCheckBox.Text = "Permenen&t Makeup"
        Me.ToolTip1.SetToolTip(Me.PermenentMakeupCheckBox, "Permenent Makeup")
        Me.PermenentMakeupCheckBox.UseVisualStyleBackColor = True
        '
        'ServiceCostLabel
        '
        Me.ServiceCostLabel.AutoSize = True
        Me.ServiceCostLabel.Location = New System.Drawing.Point(20, 23)
        Me.ServiceCostLabel.Name = "ServiceCostLabel"
        Me.ServiceCostLabel.Size = New System.Drawing.Size(67, 13)
        Me.ServiceCostLabel.TabIndex = 0
        Me.ServiceCostLabel.Text = "Service Cost"
        Me.ToolTip1.SetToolTip(Me.ServiceCostLabel, "Service Cost")
        '
        'SubtotalLabel
        '
        Me.SubtotalLabel.AutoSize = True
        Me.SubtotalLabel.Location = New System.Drawing.Point(20, 107)
        Me.SubtotalLabel.Name = "SubtotalLabel"
        Me.SubtotalLabel.Size = New System.Drawing.Size(46, 13)
        Me.SubtotalLabel.TabIndex = 4
        Me.SubtotalLabel.Text = "Subtotal"
        Me.ToolTip1.SetToolTip(Me.SubtotalLabel, "Subtotal")
        '
        'NumberOfServicesLabel
        '
        Me.NumberOfServicesLabel.AutoSize = True
        Me.NumberOfServicesLabel.Location = New System.Drawing.Point(20, 65)
        Me.NumberOfServicesLabel.Name = "NumberOfServicesLabel"
        Me.NumberOfServicesLabel.Size = New System.Drawing.Size(100, 13)
        Me.NumberOfServicesLabel.TabIndex = 2
        Me.NumberOfServicesLabel.Text = "Number of Services"
        Me.ToolTip1.SetToolTip(Me.NumberOfServicesLabel, "Number of Services")
        '
        'TotalDueLabel
        '
        Me.TotalDueLabel.AutoSize = True
        Me.TotalDueLabel.Location = New System.Drawing.Point(18, 149)
        Me.TotalDueLabel.Name = "TotalDueLabel"
        Me.TotalDueLabel.Size = New System.Drawing.Size(54, 13)
        Me.TotalDueLabel.TabIndex = 6
        Me.TotalDueLabel.Text = "Total Due"
        Me.ToolTip1.SetToolTip(Me.TotalDueLabel, "Total Due")
        '
        'ServiceCostTextBox
        '
        Me.ServiceCostTextBox.Location = New System.Drawing.Point(32, 39)
        Me.ServiceCostTextBox.Name = "ServiceCostTextBox"
        Me.ServiceCostTextBox.ReadOnly = True
        Me.ServiceCostTextBox.Size = New System.Drawing.Size(161, 20)
        Me.ServiceCostTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ServiceCostTextBox, "Service Cost")
        '
        'NumberOfServicesTextBox
        '
        Me.NumberOfServicesTextBox.Location = New System.Drawing.Point(32, 81)
        Me.NumberOfServicesTextBox.Name = "NumberOfServicesTextBox"
        Me.NumberOfServicesTextBox.ReadOnly = True
        Me.NumberOfServicesTextBox.Size = New System.Drawing.Size(161, 20)
        Me.NumberOfServicesTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.NumberOfServicesTextBox, "Number of Services")
        '
        'SubtotalTextBox
        '
        Me.SubtotalTextBox.Location = New System.Drawing.Point(32, 123)
        Me.SubtotalTextBox.Name = "SubtotalTextBox"
        Me.SubtotalTextBox.ReadOnly = True
        Me.SubtotalTextBox.Size = New System.Drawing.Size(161, 20)
        Me.SubtotalTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.SubtotalTextBox, "Subtotal")
        '
        'TotalDueTextBox
        '
        Me.TotalDueTextBox.Location = New System.Drawing.Point(32, 165)
        Me.TotalDueTextBox.Name = "TotalDueTextBox"
        Me.TotalDueTextBox.ReadOnly = True
        Me.TotalDueTextBox.Size = New System.Drawing.Size(161, 20)
        Me.TotalDueTextBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.TotalDueTextBox, "Total Due")
        '
        'LynetteRifleBeautySalon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 355)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.LynetteRifleBeautySalonLabel)
        Me.Controls.Add(Me.OrderInformationGroupBox)
        Me.Controls.Add(Me.DiscountRateGroupBox)
        Me.Controls.Add(Me.TypeOfServiceGroupBox)
        Me.Name = "LynetteRifleBeautySalon"
        Me.Text = "Lynette Rifle Beauty Salon "
        Me.TypeOfServiceGroupBox.ResumeLayout(False)
        Me.TypeOfServiceGroupBox.PerformLayout()
        Me.DiscountRateGroupBox.ResumeLayout(False)
        Me.DiscountRateGroupBox.PerformLayout()
        Me.OrderInformationGroupBox.ResumeLayout(False)
        Me.OrderInformationGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LynetteRifleBeautySalonLabel As System.Windows.Forms.Label
    Friend WithEvents OrderInformationGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DiscountRateGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TypeOfServiceGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents TotalDueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubtotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumberOfServicesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ServiceCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalDueLabel As System.Windows.Forms.Label
    Friend WithEvents NumberOfServicesLabel As System.Windows.Forms.Label
    Friend WithEvents SubtotalLabel As System.Windows.Forms.Label
    Friend WithEvents ServiceCostLabel As System.Windows.Forms.Label
    Friend WithEvents TwentyPercentRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TenPercentRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents NoDiscountRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PermenentMakeupCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ManicureCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HairStylingCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MakeoverCheckBox As System.Windows.Forms.CheckBox

End Class
