<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoBonanzaCh11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VideoBonanzaCh11))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviewSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviewAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddACategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveACategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearCategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayCategoryCountListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectionGroupBox = New System.Windows.Forms.GroupBox()
        Me.MovieTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.CoffeeFlavorLabel = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintAllPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintSelectedPrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.ImportCategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SelectionGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(305, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSelectedToolStripMenuItem, Me.PreviewSelectedToolStripMenuItem, Me.PrintAllToolStripMenuItem, Me.PreviewAllToolStripMenuItem, Me.ToolStripSeparator1, Me.SaveFileToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintSelectedToolStripMenuItem
        '
        Me.PrintSelectedToolStripMenuItem.Name = "PrintSelectedToolStripMenuItem"
        Me.PrintSelectedToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.PrintSelectedToolStripMenuItem.Text = "Print &Selected"
        '
        'PreviewSelectedToolStripMenuItem
        '
        Me.PreviewSelectedToolStripMenuItem.Name = "PreviewSelectedToolStripMenuItem"
        Me.PreviewSelectedToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.PreviewSelectedToolStripMenuItem.Text = "Pre&view Selected"
        '
        'PrintAllToolStripMenuItem
        '
        Me.PrintAllToolStripMenuItem.Name = "PrintAllToolStripMenuItem"
        Me.PrintAllToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.PrintAllToolStripMenuItem.Text = "&Print All"
        '
        'PreviewAllToolStripMenuItem
        '
        Me.PreviewAllToolStripMenuItem.Name = "PreviewAllToolStripMenuItem"
        Me.PreviewAllToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.PreviewAllToolStripMenuItem.Text = "Pre&view All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(159, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportCategoriesToolStripMenuItem, Me.AddACategoryToolStripMenuItem, Me.RemoveACategoryToolStripMenuItem, Me.ClearCategoriesToolStripMenuItem, Me.DisplayCategoryCountListToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'AddACategoryToolStripMenuItem
        '
        Me.AddACategoryToolStripMenuItem.Name = "AddACategoryToolStripMenuItem"
        Me.AddACategoryToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AddACategoryToolStripMenuItem.Text = "&Add a Category"
        '
        'RemoveACategoryToolStripMenuItem
        '
        Me.RemoveACategoryToolStripMenuItem.Name = "RemoveACategoryToolStripMenuItem"
        Me.RemoveACategoryToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.RemoveACategoryToolStripMenuItem.Text = "&Remove a Category"
        '
        'ClearCategoriesToolStripMenuItem
        '
        Me.ClearCategoriesToolStripMenuItem.Name = "ClearCategoriesToolStripMenuItem"
        Me.ClearCategoriesToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ClearCategoriesToolStripMenuItem.Text = "&Clear Categories"
        '
        'DisplayCategoryCountListToolStripMenuItem
        '
        Me.DisplayCategoryCountListToolStripMenuItem.Name = "DisplayCategoryCountListToolStripMenuItem"
        Me.DisplayCategoryCountListToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.DisplayCategoryCountListToolStripMenuItem.Text = "&Display Category Count"
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
        Me.SelectionGroupBox.Controls.Add(Me.MovieTypeComboBox)
        Me.SelectionGroupBox.Controls.Add(Me.CoffeeFlavorLabel)
        Me.SelectionGroupBox.Location = New System.Drawing.Point(22, 39)
        Me.SelectionGroupBox.Name = "SelectionGroupBox"
        Me.SelectionGroupBox.Size = New System.Drawing.Size(265, 116)
        Me.SelectionGroupBox.TabIndex = 1
        Me.SelectionGroupBox.TabStop = False
        Me.SelectionGroupBox.Text = "Select Movie Type"
        '
        'MovieTypeComboBox
        '
        Me.MovieTypeComboBox.FormattingEnabled = True
        Me.MovieTypeComboBox.Location = New System.Drawing.Point(19, 63)
        Me.MovieTypeComboBox.Name = "MovieTypeComboBox"
        Me.MovieTypeComboBox.Size = New System.Drawing.Size(231, 21)
        Me.MovieTypeComboBox.Sorted = True
        Me.MovieTypeComboBox.TabIndex = 2
        '
        'CoffeeFlavorLabel
        '
        Me.CoffeeFlavorLabel.AutoSize = True
        Me.CoffeeFlavorLabel.Location = New System.Drawing.Point(16, 35)
        Me.CoffeeFlavorLabel.Name = "CoffeeFlavorLabel"
        Me.CoffeeFlavorLabel.Size = New System.Drawing.Size(68, 13)
        Me.CoffeeFlavorLabel.TabIndex = 0
        Me.CoffeeFlavorLabel.Text = "&Movie Types"
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
        'PrintSelectedPrintDocument
        '
        '
        'ImportCategoriesToolStripMenuItem
        '
        Me.ImportCategoriesToolStripMenuItem.Name = "ImportCategoriesToolStripMenuItem"
        Me.ImportCategoriesToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ImportCategoriesToolStripMenuItem.Text = "&Import Categories"
        '
        'SaveFileToolStripMenuItem
        '
        Me.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem"
        Me.SaveFileToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SaveFileToolStripMenuItem.Text = "&Save File"
        '
        'VideoBonanzaCh11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 171)
        Me.Controls.Add(Me.SelectionGroupBox)
        Me.Controls.Add(Me.MenuStrip)
        Me.Name = "VideoBonanzaCh11"
        Me.Text = "Movie Categories"
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
    Friend WithEvents MovieTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CoffeeFlavorLabel As System.Windows.Forms.Label
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviewAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddACategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveACategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearCategoriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayCategoryCountListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintAllPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintSelectedPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PreviewSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportCategoriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
