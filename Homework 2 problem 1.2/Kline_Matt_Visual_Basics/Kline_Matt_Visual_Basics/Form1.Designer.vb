<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Greetings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Greetings))
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GreetingButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MessageLabel
        '
        Me.MessageLabel.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MessageLabel.Location = New System.Drawing.Point(46, 9)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(625, 186)
        Me.MessageLabel.TabIndex = 0
        Me.MessageLabel.Text = "Click the below buttons to display a different greeting, print or exit the progra" & _
    "m" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(505, 198)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(166, 48)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'GreetingButton
        '
        Me.GreetingButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GreetingButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GreetingButton.Location = New System.Drawing.Point(35, 198)
        Me.GreetingButton.Name = "GreetingButton"
        Me.GreetingButton.Size = New System.Drawing.Size(166, 48)
        Me.GreetingButton.TabIndex = 5
        Me.GreetingButton.Text = "Greeting"
        Me.GreetingButton.UseVisualStyleBackColor = False
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(276, 198)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(166, 48)
        Me.PrintButton.TabIndex = 6
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
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(516, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Programmer: Matt Kline"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Greetings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(708, 284)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.GreetingButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MessageLabel)
        Me.Name = "Greetings"
        Me.Text = "Greetings by Matt Kline"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents GreetingButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
