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
        Me.BooksButton = New System.Windows.Forms.Button()
        Me.MusicButton = New System.Windows.Forms.Button()
        Me.PeriodicalsButton = New System.Windows.Forms.Button()
        Me.CoffeeBarButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CurrentPromotionLabel = New System.Windows.Forms.Label()
        Me.PromotionCodeLabel = New System.Windows.Forms.Label()
        Me.ProgrammerLabel = New System.Windows.Forms.Label()
        Me.CurrentPromotionTextbox = New System.Windows.Forms.Label()
        Me.PromotionCodeTextbox = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'BooksButton
        '
        Me.BooksButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BooksButton.Location = New System.Drawing.Point(30, 33)
        Me.BooksButton.Name = "BooksButton"
        Me.BooksButton.Size = New System.Drawing.Size(125, 32)
        Me.BooksButton.TabIndex = 0
        Me.BooksButton.Text = "Books"
        Me.BooksButton.UseVisualStyleBackColor = True
        '
        'MusicButton
        '
        Me.MusicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MusicButton.Location = New System.Drawing.Point(30, 80)
        Me.MusicButton.Name = "MusicButton"
        Me.MusicButton.Size = New System.Drawing.Size(125, 32)
        Me.MusicButton.TabIndex = 1
        Me.MusicButton.Text = "Music"
        Me.MusicButton.UseVisualStyleBackColor = True
        '
        'PeriodicalsButton
        '
        Me.PeriodicalsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeriodicalsButton.Location = New System.Drawing.Point(30, 128)
        Me.PeriodicalsButton.Name = "PeriodicalsButton"
        Me.PeriodicalsButton.Size = New System.Drawing.Size(125, 32)
        Me.PeriodicalsButton.TabIndex = 2
        Me.PeriodicalsButton.Text = "Periodicals"
        Me.PeriodicalsButton.UseVisualStyleBackColor = True
        '
        'CoffeeBarButton
        '
        Me.CoffeeBarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoffeeBarButton.Location = New System.Drawing.Point(30, 178)
        Me.CoffeeBarButton.Name = "CoffeeBarButton"
        Me.CoffeeBarButton.Size = New System.Drawing.Size(125, 32)
        Me.CoffeeBarButton.TabIndex = 3
        Me.CoffeeBarButton.Text = "Coffee Bar"
        Me.CoffeeBarButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(30, 262)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(125, 32)
        Me.PrintButton.TabIndex = 4
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(30, 309)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(125, 32)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CurrentPromotionLabel
        '
        Me.CurrentPromotionLabel.AutoSize = True
        Me.CurrentPromotionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentPromotionLabel.Location = New System.Drawing.Point(224, 82)
        Me.CurrentPromotionLabel.Name = "CurrentPromotionLabel"
        Me.CurrentPromotionLabel.Size = New System.Drawing.Size(155, 20)
        Me.CurrentPromotionLabel.TabIndex = 7
        Me.CurrentPromotionLabel.Text = "Current Promotion"
        '
        'PromotionCodeLabel
        '
        Me.PromotionCodeLabel.AutoSize = True
        Me.PromotionCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromotionCodeLabel.Location = New System.Drawing.Point(242, 134)
        Me.PromotionCodeLabel.Name = "PromotionCodeLabel"
        Me.PromotionCodeLabel.Size = New System.Drawing.Size(137, 20)
        Me.PromotionCodeLabel.TabIndex = 8
        Me.PromotionCodeLabel.Text = "Promotion Code"
        '
        'ProgrammerLabel
        '
        Me.ProgrammerLabel.AutoSize = True
        Me.ProgrammerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgrammerLabel.Location = New System.Drawing.Point(677, 338)
        Me.ProgrammerLabel.Name = "ProgrammerLabel"
        Me.ProgrammerLabel.Size = New System.Drawing.Size(225, 20)
        Me.ProgrammerLabel.TabIndex = 9
        Me.ProgrammerLabel.Text = "Programmed By: Matt Kline"
        '
        'CurrentPromotionTextbox
        '
        Me.CurrentPromotionTextbox.AutoEllipsis = True
        Me.CurrentPromotionTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CurrentPromotionTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentPromotionTextbox.Location = New System.Drawing.Point(402, 80)
        Me.CurrentPromotionTextbox.Name = "CurrentPromotionTextbox"
        Me.CurrentPromotionTextbox.Size = New System.Drawing.Size(500, 22)
        Me.CurrentPromotionTextbox.TabIndex = 10
        Me.CurrentPromotionTextbox.Text = "                                                                                 " & _
    "                    "
        '
        'PromotionCodeTextbox
        '
        Me.PromotionCodeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PromotionCodeTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromotionCodeTextbox.Location = New System.Drawing.Point(402, 134)
        Me.PromotionCodeTextbox.Name = "PromotionCodeTextbox"
        Me.PromotionCodeTextbox.Size = New System.Drawing.Size(76, 22)
        Me.PromotionCodeTextbox.TabIndex = 11
        Me.PromotionCodeTextbox.Text = "             "
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'ReadingAndRefreshment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 367)
        Me.Controls.Add(Me.PromotionCodeTextbox)
        Me.Controls.Add(Me.CurrentPromotionTextbox)
        Me.Controls.Add(Me.ProgrammerLabel)
        Me.Controls.Add(Me.PromotionCodeLabel)
        Me.Controls.Add(Me.CurrentPromotionLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.CoffeeBarButton)
        Me.Controls.Add(Me.PeriodicalsButton)
        Me.Controls.Add(Me.MusicButton)
        Me.Controls.Add(Me.BooksButton)
        Me.Name = "ReadingAndRefreshment"
        Me.Text = "Reading and Refreshment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BooksButton As System.Windows.Forms.Button
    Friend WithEvents MusicButton As System.Windows.Forms.Button
    Friend WithEvents PeriodicalsButton As System.Windows.Forms.Button
    Friend WithEvents CoffeeBarButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents CurrentPromotionLabel As System.Windows.Forms.Label
    Friend WithEvents PromotionCodeLabel As System.Windows.Forms.Label
    Friend WithEvents ProgrammerLabel As System.Windows.Forms.Label
    Friend WithEvents CurrentPromotionTextbox As System.Windows.Forms.Label
    Friend WithEvents PromotionCodeTextbox As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
