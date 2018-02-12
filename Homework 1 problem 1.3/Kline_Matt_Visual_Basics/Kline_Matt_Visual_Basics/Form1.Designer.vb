<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proverbs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proverbs))
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Proverb1Button = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Proverb2Button = New System.Windows.Forms.Button()
        Me.Proverb3Button = New System.Windows.Forms.Button()
        Me.Proverb4Button = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'MessageLabel
        '
        Me.MessageLabel.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MessageLabel.Location = New System.Drawing.Point(35, 4)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(625, 128)
        Me.MessageLabel.TabIndex = 0
        Me.MessageLabel.Text = "Click the below buttons to display a proverb"
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'Proverb1Button
        '
        Me.Proverb1Button.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Proverb1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proverb1Button.Location = New System.Drawing.Point(45, 147)
        Me.Proverb1Button.Name = "Proverb1Button"
        Me.Proverb1Button.Size = New System.Drawing.Size(166, 48)
        Me.Proverb1Button.TabIndex = 2
        Me.Proverb1Button.Text = "Proverb 1"
        Me.Proverb1Button.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(494, 212)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(166, 48)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'Proverb2Button
        '
        Me.Proverb2Button.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Proverb2Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proverb2Button.Location = New System.Drawing.Point(266, 147)
        Me.Proverb2Button.Name = "Proverb2Button"
        Me.Proverb2Button.Size = New System.Drawing.Size(166, 48)
        Me.Proverb2Button.TabIndex = 5
        Me.Proverb2Button.Text = "Proverb 2"
        Me.Proverb2Button.UseVisualStyleBackColor = False
        '
        'Proverb3Button
        '
        Me.Proverb3Button.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Proverb3Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proverb3Button.Location = New System.Drawing.Point(494, 147)
        Me.Proverb3Button.Name = "Proverb3Button"
        Me.Proverb3Button.Size = New System.Drawing.Size(166, 48)
        Me.Proverb3Button.TabIndex = 6
        Me.Proverb3Button.Text = "Proverb 3"
        Me.Proverb3Button.UseVisualStyleBackColor = False
        '
        'Proverb4Button
        '
        Me.Proverb4Button.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Proverb4Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proverb4Button.Location = New System.Drawing.Point(45, 212)
        Me.Proverb4Button.Name = "Proverb4Button"
        Me.Proverb4Button.Size = New System.Drawing.Size(166, 48)
        Me.Proverb4Button.TabIndex = 7
        Me.Proverb4Button.Text = "Proverb 4"
        Me.Proverb4Button.UseVisualStyleBackColor = False
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(266, 212)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(166, 48)
        Me.PrintButton.TabIndex = 8
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Proverbs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(699, 272)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.Proverb4Button)
        Me.Controls.Add(Me.Proverb3Button)
        Me.Controls.Add(Me.Proverb2Button)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Proverb1Button)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MessageLabel)
        Me.Name = "Proverbs"
        Me.Text = "Proverbs by Matt Kline"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Proverb1Button As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Proverb2Button As System.Windows.Forms.Button
    Friend WithEvents Proverb3Button As System.Windows.Forms.Button
    Friend WithEvents Proverb4Button As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
