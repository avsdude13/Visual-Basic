<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncomeSurveyForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IncomeSurveyForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintAllInListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintAboveAverageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPovertyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FamilySizeLabel = New System.Windows.Forms.Label()
        Me.FamilySizeTextBox = New System.Windows.Forms.TextBox()
        Me.IncomeSurveyLabel = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.IncomeTextBox = New System.Windows.Forms.TextBox()
        Me.IncomeLabel = New System.Windows.Forms.Label()
        Me.PrintAll = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintBelowPoverty = New System.Drawing.Printing.PrintDocument()
        Me.PrintAboveAverage = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(390, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterDataToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'EnterDataToolStripMenuItem
        '
        Me.EnterDataToolStripMenuItem.Name = "EnterDataToolStripMenuItem"
        Me.EnterDataToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.EnterDataToolStripMenuItem.Text = "&Enter Data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(125, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintAllInListToolStripMenuItem, Me.PrintPovertyToolStripMenuItem, Me.PrintAboveAverageToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'PrintAllInListToolStripMenuItem
        '
        Me.PrintAllInListToolStripMenuItem.Name = "PrintAllInListToolStripMenuItem"
        Me.PrintAllInListToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.PrintAllInListToolStripMenuItem.Text = "&Print All in List"
        '
        'PrintAboveAverageToolStripMenuItem
        '
        Me.PrintAboveAverageToolStripMenuItem.Name = "PrintAboveAverageToolStripMenuItem"
        Me.PrintAboveAverageToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.PrintAboveAverageToolStripMenuItem.Text = "Print Above &Average"
        '
        'PrintPovertyToolStripMenuItem
        '
        Me.PrintPovertyToolStripMenuItem.Name = "PrintPovertyToolStripMenuItem"
        Me.PrintPovertyToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.PrintPovertyToolStripMenuItem.Text = "Print &Below Poverty"
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
        'FamilySizeLabel
        '
        Me.FamilySizeLabel.AutoSize = True
        Me.FamilySizeLabel.Location = New System.Drawing.Point(21, 125)
        Me.FamilySizeLabel.Name = "FamilySizeLabel"
        Me.FamilySizeLabel.Size = New System.Drawing.Size(59, 13)
        Me.FamilySizeLabel.TabIndex = 4
        Me.FamilySizeLabel.Text = "Family Size"
        '
        'FamilySizeTextBox
        '
        Me.FamilySizeTextBox.Location = New System.Drawing.Point(43, 150)
        Me.FamilySizeTextBox.Name = "FamilySizeTextBox"
        Me.FamilySizeTextBox.Size = New System.Drawing.Size(309, 20)
        Me.FamilySizeTextBox.TabIndex = 5
        '
        'IncomeSurveyLabel
        '
        Me.IncomeSurveyLabel.AutoSize = True
        Me.IncomeSurveyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncomeSurveyLabel.Location = New System.Drawing.Point(120, 34)
        Me.IncomeSurveyLabel.Name = "IncomeSurveyLabel"
        Me.IncomeSurveyLabel.Size = New System.Drawing.Size(154, 25)
        Me.IncomeSurveyLabel.TabIndex = 1
        Me.IncomeSurveyLabel.Text = "Income Survey"
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(43, 91)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(309, 20)
        Me.IDTextBox.TabIndex = 3
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Location = New System.Drawing.Point(21, 66)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(95, 13)
        Me.IDLabel.TabIndex = 2
        Me.IDLabel.Text = "Identification Code"
        '
        'IncomeTextBox
        '
        Me.IncomeTextBox.Location = New System.Drawing.Point(43, 208)
        Me.IncomeTextBox.Name = "IncomeTextBox"
        Me.IncomeTextBox.Size = New System.Drawing.Size(309, 20)
        Me.IncomeTextBox.TabIndex = 7
        '
        'IncomeLabel
        '
        Me.IncomeLabel.AutoSize = True
        Me.IncomeLabel.Location = New System.Drawing.Point(21, 183)
        Me.IncomeLabel.Name = "IncomeLabel"
        Me.IncomeLabel.Size = New System.Drawing.Size(42, 13)
        Me.IncomeLabel.TabIndex = 6
        Me.IncomeLabel.Text = "Income"
        '
        'PrintAll
        '
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
        'PrintBelowPoverty
        '
        '
        'PrintAboveAverage
        '
        '
        'IncomeSurveyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 246)
        Me.Controls.Add(Me.IncomeTextBox)
        Me.Controls.Add(Me.IncomeLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.IncomeSurveyLabel)
        Me.Controls.Add(Me.FamilySizeTextBox)
        Me.Controls.Add(Me.FamilySizeLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "IncomeSurveyForm"
        Me.Text = "Income Survey"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnterDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FamilySizeLabel As System.Windows.Forms.Label
    Friend WithEvents FamilySizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IncomeSurveyLabel As System.Windows.Forms.Label
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDLabel As System.Windows.Forms.Label
    Friend WithEvents IncomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IncomeLabel As System.Windows.Forms.Label
    Friend WithEvents PrintAll As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintBelowPoverty As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintAboveAverage As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintAboveAverageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPovertyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintAllInListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
