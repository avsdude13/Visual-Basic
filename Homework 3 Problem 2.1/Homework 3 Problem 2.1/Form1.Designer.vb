<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LightBulb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LightBulb))
        Me.LightOnPicture = New System.Windows.Forms.PictureBox()
        Me.NameDialogueBox = New System.Windows.Forms.TextBox()
        Me.LightOffPicture = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RedButton = New System.Windows.Forms.RadioButton()
        Me.PurpleButton = New System.Windows.Forms.RadioButton()
        Me.OrangeButton = New System.Windows.Forms.RadioButton()
        Me.BlueButton = New System.Windows.Forms.RadioButton()
        Me.GreenButton = New System.Windows.Forms.RadioButton()
        Me.YellowButton = New System.Windows.Forms.RadioButton()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.ColorLabel = New System.Windows.Forms.Label()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ProgrammerLabel = New System.Windows.Forms.Label()
        Me.ColoredNameTextBox = New System.Windows.Forms.TextBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.LightOnPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LightOffPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LightOnPicture
        '
        Me.LightOnPicture.Image = Global.WindowsApplication1.My.Resources.Resources.LightOn
        Me.LightOnPicture.Location = New System.Drawing.Point(221, 12)
        Me.LightOnPicture.Name = "LightOnPicture"
        Me.LightOnPicture.Size = New System.Drawing.Size(190, 262)
        Me.LightOnPicture.TabIndex = 0
        Me.LightOnPicture.TabStop = False
        Me.ToolTip1.SetToolTip(Me.LightOnPicture, "Click to Turn off")
        Me.LightOnPicture.Visible = False
        '
        'NameDialogueBox
        '
        Me.NameDialogueBox.Location = New System.Drawing.Point(449, 104)
        Me.NameDialogueBox.Name = "NameDialogueBox"
        Me.NameDialogueBox.Size = New System.Drawing.Size(181, 20)
        Me.NameDialogueBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.NameDialogueBox, "Enter Name")
        '
        'LightOffPicture
        '
        Me.LightOffPicture.Image = Global.WindowsApplication1.My.Resources.Resources.LightOff
        Me.LightOffPicture.Location = New System.Drawing.Point(221, 12)
        Me.LightOffPicture.Name = "LightOffPicture"
        Me.LightOffPicture.Size = New System.Drawing.Size(190, 262)
        Me.LightOffPicture.TabIndex = 2
        Me.LightOffPicture.TabStop = False
        Me.ToolTip1.SetToolTip(Me.LightOffPicture, "Click to Turn on")
        '
        'RedButton
        '
        Me.RedButton.AutoSize = True
        Me.RedButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedButton.Location = New System.Drawing.Point(60, 70)
        Me.RedButton.Name = "RedButton"
        Me.RedButton.Size = New System.Drawing.Size(57, 24)
        Me.RedButton.TabIndex = 3
        Me.RedButton.TabStop = True
        Me.RedButton.Text = "&Red"
        Me.ToolTip1.SetToolTip(Me.RedButton, "Red")
        Me.RedButton.UseVisualStyleBackColor = True
        '
        'PurpleButton
        '
        Me.PurpleButton.AutoSize = True
        Me.PurpleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurpleButton.Location = New System.Drawing.Point(60, 160)
        Me.PurpleButton.Name = "PurpleButton"
        Me.PurpleButton.Size = New System.Drawing.Size(72, 24)
        Me.PurpleButton.TabIndex = 4
        Me.PurpleButton.TabStop = True
        Me.PurpleButton.Text = "&Purple"
        Me.ToolTip1.SetToolTip(Me.PurpleButton, "Purple")
        Me.PurpleButton.UseVisualStyleBackColor = True
        '
        'OrangeButton
        '
        Me.OrangeButton.AutoSize = True
        Me.OrangeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrangeButton.Location = New System.Drawing.Point(60, 190)
        Me.OrangeButton.Name = "OrangeButton"
        Me.OrangeButton.Size = New System.Drawing.Size(80, 24)
        Me.OrangeButton.TabIndex = 5
        Me.OrangeButton.TabStop = True
        Me.OrangeButton.Text = "&Orange"
        Me.ToolTip1.SetToolTip(Me.OrangeButton, "Orange")
        Me.OrangeButton.UseVisualStyleBackColor = True
        '
        'BlueButton
        '
        Me.BlueButton.AutoSize = True
        Me.BlueButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlueButton.Location = New System.Drawing.Point(60, 100)
        Me.BlueButton.Name = "BlueButton"
        Me.BlueButton.Size = New System.Drawing.Size(59, 24)
        Me.BlueButton.TabIndex = 6
        Me.BlueButton.TabStop = True
        Me.BlueButton.Text = "&Blue"
        Me.ToolTip1.SetToolTip(Me.BlueButton, "Blue")
        Me.BlueButton.UseVisualStyleBackColor = True
        '
        'GreenButton
        '
        Me.GreenButton.AutoSize = True
        Me.GreenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GreenButton.Location = New System.Drawing.Point(60, 130)
        Me.GreenButton.Name = "GreenButton"
        Me.GreenButton.Size = New System.Drawing.Size(72, 24)
        Me.GreenButton.TabIndex = 7
        Me.GreenButton.TabStop = True
        Me.GreenButton.Text = "&Green"
        Me.ToolTip1.SetToolTip(Me.GreenButton, "Green")
        Me.GreenButton.UseVisualStyleBackColor = True
        '
        'YellowButton
        '
        Me.YellowButton.AutoSize = True
        Me.YellowButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YellowButton.Location = New System.Drawing.Point(62, 220)
        Me.YellowButton.Name = "YellowButton"
        Me.YellowButton.Size = New System.Drawing.Size(73, 24)
        Me.YellowButton.TabIndex = 11
        Me.YellowButton.TabStop = True
        Me.YellowButton.Text = "&Yellow"
        Me.ToolTip1.SetToolTip(Me.YellowButton, "Yellow")
        Me.YellowButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(499, 212)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(95, 28)
        Me.ExitButton.TabIndex = 13
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(471, 70)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(141, 20)
        Me.NameLabel.TabIndex = 8
        Me.NameLabel.Text = "&Enter Name Below"
        '
        'ColorLabel
        '
        Me.ColorLabel.AutoSize = True
        Me.ColorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorLabel.Location = New System.Drawing.Point(41, 40)
        Me.ColorLabel.Name = "ColorLabel"
        Me.ColorLabel.Size = New System.Drawing.Size(141, 20)
        Me.ColorLabel.TabIndex = 9
        Me.ColorLabel.Text = "Select Name Color"
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(499, 160)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(95, 28)
        Me.PrintButton.TabIndex = 12
        Me.PrintButton.Text = "Prin&t"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ProgrammerLabel
        '
        Me.ProgrammerLabel.AutoSize = True
        Me.ProgrammerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgrammerLabel.Location = New System.Drawing.Point(461, 258)
        Me.ProgrammerLabel.Name = "ProgrammerLabel"
        Me.ProgrammerLabel.Size = New System.Drawing.Size(169, 16)
        Me.ProgrammerLabel.TabIndex = 14
        Me.ProgrammerLabel.Text = "Programmed By: Matt Kline"
        '
        'ColoredNameTextBox
        '
        Me.ColoredNameTextBox.Enabled = False
        Me.ColoredNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColoredNameTextBox.Location = New System.Drawing.Point(128, 297)
        Me.ColoredNameTextBox.Name = "ColoredNameTextBox"
        Me.ColoredNameTextBox.Size = New System.Drawing.Size(367, 26)
        Me.ColoredNameTextBox.TabIndex = 15
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'LightBulb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 335)
        Me.Controls.Add(Me.ColoredNameTextBox)
        Me.Controls.Add(Me.ProgrammerLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.YellowButton)
        Me.Controls.Add(Me.ColorLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.GreenButton)
        Me.Controls.Add(Me.BlueButton)
        Me.Controls.Add(Me.OrangeButton)
        Me.Controls.Add(Me.PurpleButton)
        Me.Controls.Add(Me.RedButton)
        Me.Controls.Add(Me.LightOffPicture)
        Me.Controls.Add(Me.NameDialogueBox)
        Me.Controls.Add(Me.LightOnPicture)
        Me.Name = "LightBulb"
        Me.Text = "Light Bulb"
        CType(Me.LightOnPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LightOffPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LightOnPicture As System.Windows.Forms.PictureBox
    Friend WithEvents NameDialogueBox As System.Windows.Forms.TextBox
    Friend WithEvents LightOffPicture As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents RedButton As System.Windows.Forms.RadioButton
    Friend WithEvents PurpleButton As System.Windows.Forms.RadioButton
    Friend WithEvents OrangeButton As System.Windows.Forms.RadioButton
    Friend WithEvents BlueButton As System.Windows.Forms.RadioButton
    Friend WithEvents GreenButton As System.Windows.Forms.RadioButton
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents ColorLabel As System.Windows.Forms.Label
    Friend WithEvents YellowButton As System.Windows.Forms.RadioButton
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ProgrammerLabel As System.Windows.Forms.Label
    Friend WithEvents ColoredNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
