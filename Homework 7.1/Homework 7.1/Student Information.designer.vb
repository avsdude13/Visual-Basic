<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentInformation))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviewAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AcceptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddaMajorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveaMajorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayaMajorCountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddHighSchoolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveHighSchoolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayHighSchoolCountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectionGroupBox = New System.Windows.Forms.GroupBox()
        Me.DeansListCheckBox = New System.Windows.Forms.CheckBox()
        Me.SeniorRadioButton = New System.Windows.Forms.RadioButton()
        Me.JuniorRadioButton = New System.Windows.Forms.RadioButton()
        Me.SophomoreRadioButton = New System.Windows.Forms.RadioButton()
        Me.FreshmanRadioButton = New System.Windows.Forms.RadioButton()
        Me.ClassYearLabel = New System.Windows.Forms.Label()
        Me.UnitsCompletedTextBox = New System.Windows.Forms.TextBox()
        Me.StudentNameTextBox = New System.Windows.Forms.TextBox()
        Me.UnitsCompletedLabel = New System.Windows.Forms.Label()
        Me.StudentNameLabel = New System.Windows.Forms.Label()
        Me.MajorListBox = New System.Windows.Forms.ListBox()
        Me.MajorLabel = New System.Windows.Forms.Label()
        Me.HighSchoolComboBox = New System.Windows.Forms.ComboBox()
        Me.HighSchoolLabel = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintAllPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintSelectedPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip.SuspendLayout()
        Me.SelectionGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(521, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintAllToolStripMenuItem, Me.PreviewAllToolStripMenuItem, Me.ToolStripSeparator1, Me.AcceptToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintAllToolStripMenuItem
        '
        Me.PrintAllToolStripMenuItem.Name = "PrintAllToolStripMenuItem"
        Me.PrintAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintAllToolStripMenuItem.Text = "&Print All"
        '
        'PreviewAllToolStripMenuItem
        '
        Me.PreviewAllToolStripMenuItem.Name = "PreviewAllToolStripMenuItem"
        Me.PreviewAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PreviewAllToolStripMenuItem.Text = "Pre&view All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'AcceptToolStripMenuItem
        '
        Me.AcceptToolStripMenuItem.Name = "AcceptToolStripMenuItem"
        Me.AcceptToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AcceptToolStripMenuItem.Text = "&Accept"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddaMajorToolStripMenuItem, Me.RemoveaMajorToolStripMenuItem, Me.DisplayaMajorCountToolStripMenuItem, Me.AddHighSchoolToolStripMenuItem, Me.RemoveHighSchoolToolStripMenuItem, Me.DisplayHighSchoolCountToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'AddaMajorToolStripMenuItem
        '
        Me.AddaMajorToolStripMenuItem.Name = "AddaMajorToolStripMenuItem"
        Me.AddaMajorToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.AddaMajorToolStripMenuItem.Text = "&Add a Major"
        '
        'RemoveaMajorToolStripMenuItem
        '
        Me.RemoveaMajorToolStripMenuItem.Name = "RemoveaMajorToolStripMenuItem"
        Me.RemoveaMajorToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.RemoveaMajorToolStripMenuItem.Text = "&Remove a Major"
        '
        'DisplayaMajorCountToolStripMenuItem
        '
        Me.DisplayaMajorCountToolStripMenuItem.Name = "DisplayaMajorCountToolStripMenuItem"
        Me.DisplayaMajorCountToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.DisplayaMajorCountToolStripMenuItem.Text = "&Display Major Count"
        '
        'AddHighSchoolToolStripMenuItem
        '
        Me.AddHighSchoolToolStripMenuItem.Name = "AddHighSchoolToolStripMenuItem"
        Me.AddHighSchoolToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.AddHighSchoolToolStripMenuItem.Text = "&Add High School"
        '
        'RemoveHighSchoolToolStripMenuItem
        '
        Me.RemoveHighSchoolToolStripMenuItem.Name = "RemoveHighSchoolToolStripMenuItem"
        Me.RemoveHighSchoolToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.RemoveHighSchoolToolStripMenuItem.Text = "&Remove High School"
        '
        'DisplayHighSchoolCountToolStripMenuItem
        '
        Me.DisplayHighSchoolCountToolStripMenuItem.Name = "DisplayHighSchoolCountToolStripMenuItem"
        Me.DisplayHighSchoolCountToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.DisplayHighSchoolCountToolStripMenuItem.Text = "&Display High School Count"
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
        'SelectionGroupBox
        '
        Me.SelectionGroupBox.Controls.Add(Me.DeansListCheckBox)
        Me.SelectionGroupBox.Controls.Add(Me.SeniorRadioButton)
        Me.SelectionGroupBox.Controls.Add(Me.JuniorRadioButton)
        Me.SelectionGroupBox.Controls.Add(Me.SophomoreRadioButton)
        Me.SelectionGroupBox.Controls.Add(Me.FreshmanRadioButton)
        Me.SelectionGroupBox.Controls.Add(Me.ClassYearLabel)
        Me.SelectionGroupBox.Controls.Add(Me.UnitsCompletedTextBox)
        Me.SelectionGroupBox.Controls.Add(Me.StudentNameTextBox)
        Me.SelectionGroupBox.Controls.Add(Me.UnitsCompletedLabel)
        Me.SelectionGroupBox.Controls.Add(Me.StudentNameLabel)
        Me.SelectionGroupBox.Controls.Add(Me.MajorListBox)
        Me.SelectionGroupBox.Controls.Add(Me.MajorLabel)
        Me.SelectionGroupBox.Controls.Add(Me.HighSchoolComboBox)
        Me.SelectionGroupBox.Controls.Add(Me.HighSchoolLabel)
        Me.SelectionGroupBox.Location = New System.Drawing.Point(22, 39)
        Me.SelectionGroupBox.Name = "SelectionGroupBox"
        Me.SelectionGroupBox.Size = New System.Drawing.Size(473, 280)
        Me.SelectionGroupBox.TabIndex = 1
        Me.SelectionGroupBox.TabStop = False
        Me.SelectionGroupBox.Text = "Enter Required Information"
        '
        'DeansListCheckBox
        '
        Me.DeansListCheckBox.AutoSize = True
        Me.DeansListCheckBox.Location = New System.Drawing.Point(254, 241)
        Me.DeansListCheckBox.Name = "DeansListCheckBox"
        Me.DeansListCheckBox.Size = New System.Drawing.Size(76, 17)
        Me.DeansListCheckBox.TabIndex = 13
        Me.DeansListCheckBox.Text = "Deans List"
        Me.DeansListCheckBox.UseVisualStyleBackColor = True
        '
        'SeniorRadioButton
        '
        Me.SeniorRadioButton.AutoSize = True
        Me.SeniorRadioButton.Location = New System.Drawing.Point(34, 241)
        Me.SeniorRadioButton.Name = "SeniorRadioButton"
        Me.SeniorRadioButton.Size = New System.Drawing.Size(55, 17)
        Me.SeniorRadioButton.TabIndex = 8
        Me.SeniorRadioButton.TabStop = True
        Me.SeniorRadioButton.Text = "Senior"
        Me.SeniorRadioButton.UseVisualStyleBackColor = True
        '
        'JuniorRadioButton
        '
        Me.JuniorRadioButton.AutoSize = True
        Me.JuniorRadioButton.Location = New System.Drawing.Point(34, 218)
        Me.JuniorRadioButton.Name = "JuniorRadioButton"
        Me.JuniorRadioButton.Size = New System.Drawing.Size(53, 17)
        Me.JuniorRadioButton.TabIndex = 7
        Me.JuniorRadioButton.TabStop = True
        Me.JuniorRadioButton.Text = "Junior"
        Me.JuniorRadioButton.UseVisualStyleBackColor = True
        '
        'SophomoreRadioButton
        '
        Me.SophomoreRadioButton.AutoSize = True
        Me.SophomoreRadioButton.Location = New System.Drawing.Point(34, 195)
        Me.SophomoreRadioButton.Name = "SophomoreRadioButton"
        Me.SophomoreRadioButton.Size = New System.Drawing.Size(79, 17)
        Me.SophomoreRadioButton.TabIndex = 6
        Me.SophomoreRadioButton.TabStop = True
        Me.SophomoreRadioButton.Text = "Sophomore"
        Me.SophomoreRadioButton.UseVisualStyleBackColor = True
        '
        'FreshmanRadioButton
        '
        Me.FreshmanRadioButton.AutoSize = True
        Me.FreshmanRadioButton.Location = New System.Drawing.Point(34, 172)
        Me.FreshmanRadioButton.Name = "FreshmanRadioButton"
        Me.FreshmanRadioButton.Size = New System.Drawing.Size(71, 17)
        Me.FreshmanRadioButton.TabIndex = 5
        Me.FreshmanRadioButton.TabStop = True
        Me.FreshmanRadioButton.Text = "Freshman"
        Me.FreshmanRadioButton.UseVisualStyleBackColor = True
        '
        'ClassYearLabel
        '
        Me.ClassYearLabel.AutoSize = True
        Me.ClassYearLabel.Location = New System.Drawing.Point(19, 149)
        Me.ClassYearLabel.Name = "ClassYearLabel"
        Me.ClassYearLabel.Size = New System.Drawing.Size(57, 13)
        Me.ClassYearLabel.TabIndex = 4
        Me.ClassYearLabel.Text = "&Class Year"
        '
        'UnitsCompletedTextBox
        '
        Me.UnitsCompletedTextBox.Location = New System.Drawing.Point(34, 114)
        Me.UnitsCompletedTextBox.Name = "UnitsCompletedTextBox"
        Me.UnitsCompletedTextBox.Size = New System.Drawing.Size(187, 20)
        Me.UnitsCompletedTextBox.TabIndex = 3
        '
        'StudentNameTextBox
        '
        Me.StudentNameTextBox.Location = New System.Drawing.Point(34, 56)
        Me.StudentNameTextBox.Name = "StudentNameTextBox"
        Me.StudentNameTextBox.Size = New System.Drawing.Size(187, 20)
        Me.StudentNameTextBox.TabIndex = 1
        '
        'UnitsCompletedLabel
        '
        Me.UnitsCompletedLabel.AutoSize = True
        Me.UnitsCompletedLabel.Location = New System.Drawing.Point(19, 89)
        Me.UnitsCompletedLabel.Name = "UnitsCompletedLabel"
        Me.UnitsCompletedLabel.Size = New System.Drawing.Size(84, 13)
        Me.UnitsCompletedLabel.TabIndex = 2
        Me.UnitsCompletedLabel.Text = "&Units Completed"
        '
        'StudentNameLabel
        '
        Me.StudentNameLabel.AutoSize = True
        Me.StudentNameLabel.Location = New System.Drawing.Point(19, 30)
        Me.StudentNameLabel.Name = "StudentNameLabel"
        Me.StudentNameLabel.Size = New System.Drawing.Size(75, 13)
        Me.StudentNameLabel.TabIndex = 0
        Me.StudentNameLabel.Text = "&Student Name"
        '
        'MajorListBox
        '
        Me.MajorListBox.FormattingEnabled = True
        Me.MajorListBox.Items.AddRange(New Object() {"Accounting", "Business", "Computer Information Systems", "Computer Science", "Marketing", "Physics"})
        Me.MajorListBox.Location = New System.Drawing.Point(276, 56)
        Me.MajorListBox.Name = "MajorListBox"
        Me.MajorListBox.Size = New System.Drawing.Size(171, 95)
        Me.MajorListBox.Sorted = True
        Me.MajorListBox.TabIndex = 10
        '
        'MajorLabel
        '
        Me.MajorLabel.AutoSize = True
        Me.MajorLabel.Location = New System.Drawing.Point(251, 30)
        Me.MajorLabel.Name = "MajorLabel"
        Me.MajorLabel.Size = New System.Drawing.Size(33, 13)
        Me.MajorLabel.TabIndex = 9
        Me.MajorLabel.Text = "&Major"
        '
        'HighSchoolComboBox
        '
        Me.HighSchoolComboBox.FormattingEnabled = True
        Me.HighSchoolComboBox.Items.AddRange(New Object() {"Franklin", "Highland", "Midtown", "West Highland"})
        Me.HighSchoolComboBox.Location = New System.Drawing.Point(276, 195)
        Me.HighSchoolComboBox.Name = "HighSchoolComboBox"
        Me.HighSchoolComboBox.Size = New System.Drawing.Size(171, 21)
        Me.HighSchoolComboBox.Sorted = True
        Me.HighSchoolComboBox.TabIndex = 12
        '
        'HighSchoolLabel
        '
        Me.HighSchoolLabel.AutoSize = True
        Me.HighSchoolLabel.Location = New System.Drawing.Point(251, 172)
        Me.HighSchoolLabel.Name = "HighSchoolLabel"
        Me.HighSchoolLabel.Size = New System.Drawing.Size(65, 13)
        Me.HighSchoolLabel.TabIndex = 11
        Me.HighSchoolLabel.Text = "&High School"
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
        'PrintAllPrintDocument
        '
        '
        'StudentInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 341)
        Me.Controls.Add(Me.SelectionGroupBox)
        Me.Controls.Add(Me.MenuStrip)
        Me.Name = "StudentInformation"
        Me.Text = "Student Information"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.SelectionGroupBox.ResumeLayout(False)
        Me.SelectionGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents HighSchoolComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents HighSchoolLabel As System.Windows.Forms.Label
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviewAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddaMajorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveaMajorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayaMajorCountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintAllPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintSelectedPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents AcceptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddHighSchoolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveHighSchoolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayHighSchoolCountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeansListCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SeniorRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents JuniorRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SophomoreRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FreshmanRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ClassYearLabel As System.Windows.Forms.Label
    Friend WithEvents UnitsCompletedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitsCompletedLabel As System.Windows.Forms.Label
    Friend WithEvents StudentNameLabel As System.Windows.Forms.Label
    Friend WithEvents MajorListBox As System.Windows.Forms.ListBox
    Friend WithEvents MajorLabel As System.Windows.Forms.Label

End Class
