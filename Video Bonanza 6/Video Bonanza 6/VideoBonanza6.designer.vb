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
        Me.ItemAmountTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.ItemAmountLabel = New System.Windows.Forms.Label()
        Me.SubTotalLabel = New System.Windows.Forms.Label()
        Me.VideoBonanzaLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearForNextItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderCompleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.MenuStrip1.SuspendLayout()
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
        'ItemAmountTextBox
        '
        Me.ItemAmountTextBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ItemAmountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemAmountTextBox.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ItemAmountTextBox.Location = New System.Drawing.Point(399, 186)
        Me.ItemAmountTextBox.Name = "ItemAmountTextBox"
        Me.ItemAmountTextBox.ReadOnly = True
        Me.ItemAmountTextBox.Size = New System.Drawing.Size(196, 26)
        Me.ItemAmountTextBox.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.ItemAmountTextBox, "Item Amount")
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SubTotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotalTextBox.ForeColor = System.Drawing.SystemColors.InfoText
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
        'VideoBonanzaLabel
        '
        Me.VideoBonanzaLabel.AutoSize = True
        Me.VideoBonanzaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VideoBonanzaLabel.Location = New System.Drawing.Point(184, 24)
        Me.VideoBonanzaLabel.Name = "VideoBonanzaLabel"
        Me.VideoBonanzaLabel.Size = New System.Drawing.Size(235, 37)
        Me.VideoBonanzaLabel.TabIndex = 0
        Me.VideoBonanzaLabel.Text = "Video Bonanza"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(626, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SummaryToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.ClearForNextItemToolStripMenuItem, Me.OrderCompleteToolStripMenuItem, Me.ToolStripSeparator2, Me.ColorToolStripMenuItem, Me.FontToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CalculateToolStripMenuItem.Text = "C&alculate"
        '
        'ClearForNextItemToolStripMenuItem
        '
        Me.ClearForNextItemToolStripMenuItem.Name = "ClearForNextItemToolStripMenuItem"
        Me.ClearForNextItemToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ClearForNextItemToolStripMenuItem.Text = "C&lear for Next Item"
        '
        'OrderCompleteToolStripMenuItem
        '
        Me.OrderCompleteToolStripMenuItem.Name = "OrderCompleteToolStripMenuItem"
        Me.OrderCompleteToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.OrderCompleteToolStripMenuItem.Text = "&Order Complete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(170, 6)
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ColorToolStripMenuItem.Text = "&Color..."
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.FontToolStripMenuItem.Text = "&Font..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'VideoBonanza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 302)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.SubTotalLabel)
        Me.Controls.Add(Me.ItemAmountLabel)
        Me.Controls.Add(Me.SubTotalTextBox)
        Me.Controls.Add(Me.ItemAmountTextBox)
        Me.Controls.Add(Me.VHSRadioButton)
        Me.Controls.Add(Me.EnterTitleLabel)
        Me.Controls.Add(Me.NewReleaseCheckBox)
        Me.Controls.Add(Me.MemberCheckBox)
        Me.Controls.Add(Me.DVDRadioButton)
        Me.Controls.Add(Me.VideoBonanzaLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VideoBonanza"
        Me.Text = "Video Bonanza"
        Me.ToolTip1.SetToolTip(Me, "Video Bonanza")
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents EnterTitleLabel As System.Windows.Forms.Label
    Friend WithEvents NewReleaseCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MemberCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DVDRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents VideoBonanzaLabel As System.Windows.Forms.Label
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VHSRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SubTotalLabel As System.Windows.Forms.Label
    Friend WithEvents ItemAmountLabel As System.Windows.Forms.Label
    Friend WithEvents SubTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearForNextItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderCompleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
