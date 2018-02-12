<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesCalculator))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesCalculatorLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.SalesLabel = New System.Windows.Forms.Label()
        Me.InputName1 = New System.Windows.Forms.TextBox()
        Me.InputName2 = New System.Windows.Forms.TextBox()
        Me.InputName3 = New System.Windows.Forms.TextBox()
        Me.InputName4 = New System.Windows.Forms.TextBox()
        Me.InputSales1 = New System.Windows.Forms.TextBox()
        Me.InputSales2 = New System.Windows.Forms.TextBox()
        Me.InputSales3 = New System.Windows.Forms.TextBox()
        Me.InputSales4 = New System.Windows.Forms.TextBox()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PayLabel = New System.Windows.Forms.Label()
        Me.SalesTotalLabel = New System.Windows.Forms.Label()
        Me.CommissionLabel = New System.Windows.Forms.Label()
        Me.PayTotalTextbox = New System.Windows.Forms.TextBox()
        Me.CommissionTotalTextbox = New System.Windows.Forms.TextBox()
        Me.SalesTotalTextbox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.InputGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(457, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PayToolStripMenuItem, Me.SummaryToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PayToolStripMenuItem
        '
        Me.PayToolStripMenuItem.Name = "PayToolStripMenuItem"
        Me.PayToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PayToolStripMenuItem.Text = "&Pay"
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ToolStripSeparator1, Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ClearToolStripMenuItem.Text = "C&lear"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(109, 6)
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.FontToolStripMenuItem.Text = "&Font..."
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ColorToolStripMenuItem.Text = "&Color..."
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
        'SalesCalculatorLabel
        '
        Me.SalesCalculatorLabel.AutoSize = True
        Me.SalesCalculatorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesCalculatorLabel.Location = New System.Drawing.Point(28, 36)
        Me.SalesCalculatorLabel.Name = "SalesCalculatorLabel"
        Me.SalesCalculatorLabel.Size = New System.Drawing.Size(140, 20)
        Me.SalesCalculatorLabel.TabIndex = 1
        Me.SalesCalculatorLabel.Text = "Sales Calculator"
        Me.ToolTip1.SetToolTip(Me.SalesCalculatorLabel, "Sales Calculator")
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(17, 16)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 16)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name"
        Me.ToolTip1.SetToolTip(Me.NameLabel, "Name")
        '
        'SalesLabel
        '
        Me.SalesLabel.AutoSize = True
        Me.SalesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesLabel.Location = New System.Drawing.Point(217, 16)
        Me.SalesLabel.Name = "SalesLabel"
        Me.SalesLabel.Size = New System.Drawing.Size(43, 16)
        Me.SalesLabel.TabIndex = 1
        Me.SalesLabel.Text = "Sales"
        Me.ToolTip1.SetToolTip(Me.SalesLabel, "Sales")
        '
        'InputName1
        '
        Me.InputName1.Location = New System.Drawing.Point(20, 35)
        Me.InputName1.Name = "InputName1"
        Me.InputName1.Size = New System.Drawing.Size(194, 20)
        Me.InputName1.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.InputName1, "Input Name")
        '
        'InputName2
        '
        Me.InputName2.Location = New System.Drawing.Point(20, 61)
        Me.InputName2.Name = "InputName2"
        Me.InputName2.Size = New System.Drawing.Size(194, 20)
        Me.InputName2.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.InputName2, "Input Name")
        '
        'InputName3
        '
        Me.InputName3.Location = New System.Drawing.Point(20, 87)
        Me.InputName3.Name = "InputName3"
        Me.InputName3.Size = New System.Drawing.Size(194, 20)
        Me.InputName3.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.InputName3, "Input Name")
        '
        'InputName4
        '
        Me.InputName4.Location = New System.Drawing.Point(20, 113)
        Me.InputName4.Name = "InputName4"
        Me.InputName4.Size = New System.Drawing.Size(194, 20)
        Me.InputName4.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.InputName4, "Input Name")
        '
        'InputSales1
        '
        Me.InputSales1.Location = New System.Drawing.Point(220, 35)
        Me.InputSales1.Name = "InputSales1"
        Me.InputSales1.Size = New System.Drawing.Size(194, 20)
        Me.InputSales1.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.InputSales1, "Input Sales")
        '
        'InputSales2
        '
        Me.InputSales2.Location = New System.Drawing.Point(220, 61)
        Me.InputSales2.Name = "InputSales2"
        Me.InputSales2.Size = New System.Drawing.Size(194, 20)
        Me.InputSales2.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.InputSales2, "Input Sales")
        '
        'InputSales3
        '
        Me.InputSales3.Location = New System.Drawing.Point(220, 87)
        Me.InputSales3.Name = "InputSales3"
        Me.InputSales3.Size = New System.Drawing.Size(194, 20)
        Me.InputSales3.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.InputSales3, "Input Sales")
        '
        'InputSales4
        '
        Me.InputSales4.Location = New System.Drawing.Point(220, 113)
        Me.InputSales4.Name = "InputSales4"
        Me.InputSales4.Size = New System.Drawing.Size(194, 20)
        Me.InputSales4.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.InputSales4, "Input Sales")
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.NameLabel)
        Me.InputGroupBox.Controls.Add(Me.SalesLabel)
        Me.InputGroupBox.Controls.Add(Me.InputSales4)
        Me.InputGroupBox.Controls.Add(Me.InputName1)
        Me.InputGroupBox.Controls.Add(Me.InputSales3)
        Me.InputGroupBox.Controls.Add(Me.InputName2)
        Me.InputGroupBox.Controls.Add(Me.InputSales2)
        Me.InputGroupBox.Controls.Add(Me.InputName3)
        Me.InputGroupBox.Controls.Add(Me.InputSales1)
        Me.InputGroupBox.Controls.Add(Me.InputName4)
        Me.InputGroupBox.Location = New System.Drawing.Point(12, 59)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(433, 150)
        Me.InputGroupBox.TabIndex = 2
        Me.InputGroupBox.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PayLabel)
        Me.GroupBox1.Controls.Add(Me.SalesTotalLabel)
        Me.GroupBox1.Controls.Add(Me.CommissionLabel)
        Me.GroupBox1.Controls.Add(Me.PayTotalTextbox)
        Me.GroupBox1.Controls.Add(Me.CommissionTotalTextbox)
        Me.GroupBox1.Controls.Add(Me.SalesTotalTextbox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(221, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 126)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totals"
        Me.ToolTip1.SetToolTip(Me.GroupBox1, "Totals")
        '
        'PayLabel
        '
        Me.PayLabel.AutoSize = True
        Me.PayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayLabel.Location = New System.Drawing.Point(69, 90)
        Me.PayLabel.Name = "PayLabel"
        Me.PayLabel.Size = New System.Drawing.Size(32, 16)
        Me.PayLabel.TabIndex = 4
        Me.PayLabel.Text = "Pay"
        Me.ToolTip1.SetToolTip(Me.PayLabel, "Pay")
        '
        'SalesTotalLabel
        '
        Me.SalesTotalLabel.AutoSize = True
        Me.SalesTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesTotalLabel.Location = New System.Drawing.Point(58, 36)
        Me.SalesTotalLabel.Name = "SalesTotalLabel"
        Me.SalesTotalLabel.Size = New System.Drawing.Size(43, 16)
        Me.SalesTotalLabel.TabIndex = 0
        Me.SalesTotalLabel.Text = "Sales"
        Me.ToolTip1.SetToolTip(Me.SalesTotalLabel, "Sales")
        '
        'CommissionLabel
        '
        Me.CommissionLabel.AutoSize = True
        Me.CommissionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommissionLabel.Location = New System.Drawing.Point(19, 64)
        Me.CommissionLabel.Name = "CommissionLabel"
        Me.CommissionLabel.Size = New System.Drawing.Size(82, 16)
        Me.CommissionLabel.TabIndex = 2
        Me.CommissionLabel.Text = "Commission"
        Me.ToolTip1.SetToolTip(Me.CommissionLabel, "Commission")
        '
        'PayTotalTextbox
        '
        Me.PayTotalTextbox.ForeColor = System.Drawing.SystemColors.MenuText
        Me.PayTotalTextbox.Location = New System.Drawing.Point(107, 87)
        Me.PayTotalTextbox.Name = "PayTotalTextbox"
        Me.PayTotalTextbox.ReadOnly = True
        Me.PayTotalTextbox.Size = New System.Drawing.Size(97, 22)
        Me.PayTotalTextbox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.PayTotalTextbox, "Pay")
        '
        'CommissionTotalTextbox
        '
        Me.CommissionTotalTextbox.ForeColor = System.Drawing.SystemColors.MenuText
        Me.CommissionTotalTextbox.Location = New System.Drawing.Point(107, 61)
        Me.CommissionTotalTextbox.Name = "CommissionTotalTextbox"
        Me.CommissionTotalTextbox.ReadOnly = True
        Me.CommissionTotalTextbox.Size = New System.Drawing.Size(97, 22)
        Me.CommissionTotalTextbox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.CommissionTotalTextbox, "Commission")
        '
        'SalesTotalTextbox
        '
        Me.SalesTotalTextbox.ForeColor = System.Drawing.SystemColors.MenuText
        Me.SalesTotalTextbox.Location = New System.Drawing.Point(107, 33)
        Me.SalesTotalTextbox.Name = "SalesTotalTextbox"
        Me.SalesTotalTextbox.ReadOnly = True
        Me.SalesTotalTextbox.Size = New System.Drawing.Size(97, 22)
        Me.SalesTotalTextbox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.SalesTotalTextbox, "Sales")
        '
        'SalesCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 353)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Controls.Add(Me.SalesCalculatorLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SalesCalculator"
        Me.Text = "Sales Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PayLabel As System.Windows.Forms.Label
    Friend WithEvents SalesTotalLabel As System.Windows.Forms.Label
    Friend WithEvents CommissionLabel As System.Windows.Forms.Label
    Friend WithEvents PayTotalTextbox As System.Windows.Forms.TextBox
    Friend WithEvents CommissionTotalTextbox As System.Windows.Forms.TextBox
    Friend WithEvents SalesTotalTextbox As System.Windows.Forms.TextBox
    Friend WithEvents InputGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents SalesLabel As System.Windows.Forms.Label
    Friend WithEvents InputSales4 As System.Windows.Forms.TextBox
    Friend WithEvents InputName1 As System.Windows.Forms.TextBox
    Friend WithEvents InputSales3 As System.Windows.Forms.TextBox
    Friend WithEvents InputName2 As System.Windows.Forms.TextBox
    Friend WithEvents InputSales2 As System.Windows.Forms.TextBox
    Friend WithEvents InputName3 As System.Windows.Forms.TextBox
    Friend WithEvents InputSales1 As System.Windows.Forms.TextBox
    Friend WithEvents InputName4 As System.Windows.Forms.TextBox
    Friend WithEvents SalesCalculatorLabel As System.Windows.Forms.Label
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

End Class
