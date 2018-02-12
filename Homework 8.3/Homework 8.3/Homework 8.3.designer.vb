<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConcertTickets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConcertTickets))
        Me.ConcertTicketsGroupBox = New System.Windows.Forms.GroupBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.SeatingAreaLabel = New System.Windows.Forms.Label()
        Me.SeatingListBox = New System.Windows.Forms.ListBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.FindPriceButton = New System.Windows.Forms.Button()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TotalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ConcertTicketsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ConcertTicketsGroupBox
        '
        Me.ConcertTicketsGroupBox.Controls.Add(Me.TotalPriceTextBox)
        Me.ConcertTicketsGroupBox.Controls.Add(Me.Label1)
        Me.ConcertTicketsGroupBox.Controls.Add(Me.QuantityTextBox)
        Me.ConcertTicketsGroupBox.Controls.Add(Me.SeatingAreaLabel)
        Me.ConcertTicketsGroupBox.Controls.Add(Me.SeatingListBox)
        Me.ConcertTicketsGroupBox.Controls.Add(Me.PriceTextBox)
        Me.ConcertTicketsGroupBox.Controls.Add(Me.ExitButton)
        Me.ConcertTicketsGroupBox.Controls.Add(Me.PrintButton)
        Me.ConcertTicketsGroupBox.Controls.Add(Me.ClearButton)
        Me.ConcertTicketsGroupBox.Controls.Add(Me.FindPriceButton)
        Me.ConcertTicketsGroupBox.Controls.Add(Me.PriceLabel)
        Me.ConcertTicketsGroupBox.Controls.Add(Me.QuantityLabel)
        Me.ConcertTicketsGroupBox.Location = New System.Drawing.Point(12, 22)
        Me.ConcertTicketsGroupBox.Name = "ConcertTicketsGroupBox"
        Me.ConcertTicketsGroupBox.Size = New System.Drawing.Size(492, 223)
        Me.ConcertTicketsGroupBox.TabIndex = 0
        Me.ConcertTicketsGroupBox.TabStop = False
        Me.ConcertTicketsGroupBox.Text = "Concert Tickets"
        Me.ToolTip1.SetToolTip(Me.ConcertTicketsGroupBox, "Concert Tickets")
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(231, 49)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(165, 20)
        Me.QuantityTextBox.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.QuantityTextBox, "Price")
        '
        'SeatingAreaLabel
        '
        Me.SeatingAreaLabel.AutoSize = True
        Me.SeatingAreaLabel.Location = New System.Drawing.Point(21, 37)
        Me.SeatingAreaLabel.Name = "SeatingAreaLabel"
        Me.SeatingAreaLabel.Size = New System.Drawing.Size(68, 13)
        Me.SeatingAreaLabel.TabIndex = 10
        Me.SeatingAreaLabel.Text = "Seating Area"
        Me.ToolTip1.SetToolTip(Me.SeatingAreaLabel, "Seating Area")
        '
        'SeatingListBox
        '
        Me.SeatingListBox.FormattingEnabled = True
        Me.SeatingListBox.Items.AddRange(New Object() {"Orchestra", "Mezzanine", "General", "Balcony"})
        Me.SeatingListBox.Location = New System.Drawing.Point(35, 62)
        Me.SeatingListBox.Name = "SeatingListBox"
        Me.SeatingListBox.Size = New System.Drawing.Size(133, 82)
        Me.SeatingListBox.TabIndex = 0
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(231, 90)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(165, 20)
        Me.PriceTextBox.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.PriceTextBox, "Price")
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(375, 174)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(99, 25)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(253, 174)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(99, 25)
        Me.PrintButton.TabIndex = 7
        Me.PrintButton.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "Print")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(136, 174)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(99, 25)
        Me.ClearButton.TabIndex = 6
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'FindPriceButton
        '
        Me.FindPriceButton.Location = New System.Drawing.Point(14, 174)
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
        Me.PriceLabel.Location = New System.Drawing.Point(211, 74)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(31, 13)
        Me.PriceLabel.TabIndex = 4
        Me.PriceLabel.Text = "Price"
        Me.ToolTip1.SetToolTip(Me.PriceLabel, "Price")
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Location = New System.Drawing.Point(211, 24)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(46, 13)
        Me.QuantityLabel.TabIndex = 3
        Me.QuantityLabel.Text = "&Quantity"
        Me.ToolTip1.SetToolTip(Me.QuantityLabel, "Quantity")
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
        'PrintDocument1
        '
        '
        'TotalPriceTextBox
        '
        Me.TotalPriceTextBox.Location = New System.Drawing.Point(231, 135)
        Me.TotalPriceTextBox.Name = "TotalPriceTextBox"
        Me.TotalPriceTextBox.ReadOnly = True
        Me.TotalPriceTextBox.Size = New System.Drawing.Size(165, 20)
        Me.TotalPriceTextBox.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.TotalPriceTextBox, "Price")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(211, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Total Price"
        Me.ToolTip1.SetToolTip(Me.Label1, "Price")
        '
        'ConcertTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 255)
        Me.Controls.Add(Me.ConcertTicketsGroupBox)
        Me.Name = "ConcertTickets"
        Me.Text = "Concert Tickets"
        Me.ToolTip1.SetToolTip(Me, "Concert Tickets")
        Me.ConcertTicketsGroupBox.ResumeLayout(False)
        Me.ConcertTicketsGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ConcertTicketsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents FindPriceButton As System.Windows.Forms.Button
    Friend WithEvents PriceLabel As System.Windows.Forms.Label
    Friend WithEvents QuantityLabel As System.Windows.Forms.Label
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SeatingAreaLabel As System.Windows.Forms.Label
    Friend WithEvents SeatingListBox As System.Windows.Forms.ListBox
    Friend WithEvents TotalPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
