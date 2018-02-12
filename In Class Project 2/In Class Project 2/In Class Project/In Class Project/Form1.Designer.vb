<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReadingAndRefreshmentLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReadingAndRefreshmentLogin))
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.UserIDLabel = New System.Windows.Forms.Label()
        Me.ProgrammerLabel = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.UsernameTextbox = New System.Windows.Forms.TextBox()
        Me.UserIDTextbox = New System.Windows.Forms.MaskedTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.WelcomeRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.BooksButton = New System.Windows.Forms.RadioButton()
        Me.MusicButton = New System.Windows.Forms.RadioButton()
        Me.PeriodicalsButton = New System.Windows.Forms.RadioButton()
        Me.CoffeeBarButton = New System.Windows.Forms.RadioButton()
        Me.ImagesBox = New System.Windows.Forms.PictureBox()
        Me.PromotionTextBox = New System.Windows.Forms.TextBox()
        Me.PromotionLabel = New System.Windows.Forms.Label()
        Me.ImageVisableCheckBox = New System.Windows.Forms.CheckBox()
        Me.DepartmentsGroup = New System.Windows.Forms.GroupBox()
        Me.LoginGroup = New System.Windows.Forms.GroupBox()
        CType(Me.ImagesBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DepartmentsGroup.SuspendLayout()
        Me.LoginGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(791, 362)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(95, 25)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(15, 28)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(49, 16)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Name"
        '
        'UserIDLabel
        '
        Me.UserIDLabel.AutoSize = True
        Me.UserIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDLabel.Location = New System.Drawing.Point(15, 61)
        Me.UserIDLabel.Name = "UserIDLabel"
        Me.UserIDLabel.Size = New System.Drawing.Size(83, 16)
        Me.UserIDLabel.TabIndex = 8
        Me.UserIDLabel.Text = "Member &ID"
        '
        'ProgrammerLabel
        '
        Me.ProgrammerLabel.AutoSize = True
        Me.ProgrammerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgrammerLabel.Location = New System.Drawing.Point(661, 399)
        Me.ProgrammerLabel.Name = "ProgrammerLabel"
        Me.ProgrammerLabel.Size = New System.Drawing.Size(225, 20)
        Me.ProgrammerLabel.TabIndex = 5
        Me.ProgrammerLabel.Text = "Programmed By: Matt Kline"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(791, 331)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(95, 25)
        Me.PrintButton.TabIndex = 3
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'LoginButton
        '
        Me.LoginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.Location = New System.Drawing.Point(791, 300)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(95, 25)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "&Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLabel.Location = New System.Drawing.Point(33, 9)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(853, 55)
        Me.WelcomeLabel.TabIndex = 6
        Me.WelcomeLabel.Text = "Welcome to Reading and Refreshment"
        '
        'UsernameTextbox
        '
        Me.UsernameTextbox.Location = New System.Drawing.Point(106, 22)
        Me.UsernameTextbox.Name = "UsernameTextbox"
        Me.UsernameTextbox.Size = New System.Drawing.Size(126, 26)
        Me.UsernameTextbox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.UsernameTextbox, "Enter member name")
        '
        'UserIDTextbox
        '
        Me.UserIDTextbox.Location = New System.Drawing.Point(109, 55)
        Me.UserIDTextbox.Mask = "00000"
        Me.UserIDTextbox.Name = "UserIDTextbox"
        Me.UserIDTextbox.Size = New System.Drawing.Size(55, 26)
        Me.UserIDTextbox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.UserIDTextbox, "Limit of 5 characters")
        Me.UserIDTextbox.ValidatingType = GetType(Integer)
        '
        'WelcomeRichTextBox
        '
        Me.WelcomeRichTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeRichTextBox.Location = New System.Drawing.Point(632, 188)
        Me.WelcomeRichTextBox.Name = "WelcomeRichTextBox"
        Me.WelcomeRichTextBox.Size = New System.Drawing.Size(254, 95)
        Me.WelcomeRichTextBox.TabIndex = 1
        Me.WelcomeRichTextBox.Text = ""
        Me.WelcomeRichTextBox.Visible = False
        '
        'BooksButton
        '
        Me.BooksButton.AutoSize = True
        Me.BooksButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BooksButton.Location = New System.Drawing.Point(6, 21)
        Me.BooksButton.Name = "BooksButton"
        Me.BooksButton.Size = New System.Drawing.Size(70, 20)
        Me.BooksButton.TabIndex = 0
        Me.BooksButton.TabStop = True
        Me.BooksButton.Text = "&Books"
        Me.BooksButton.UseVisualStyleBackColor = True
        '
        'MusicButton
        '
        Me.MusicButton.AutoSize = True
        Me.MusicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MusicButton.Location = New System.Drawing.Point(6, 47)
        Me.MusicButton.Name = "MusicButton"
        Me.MusicButton.Size = New System.Drawing.Size(66, 20)
        Me.MusicButton.TabIndex = 1
        Me.MusicButton.TabStop = True
        Me.MusicButton.Text = "&Music"
        Me.MusicButton.UseVisualStyleBackColor = True
        '
        'PeriodicalsButton
        '
        Me.PeriodicalsButton.AutoSize = True
        Me.PeriodicalsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeriodicalsButton.Location = New System.Drawing.Point(6, 73)
        Me.PeriodicalsButton.Name = "PeriodicalsButton"
        Me.PeriodicalsButton.Size = New System.Drawing.Size(105, 20)
        Me.PeriodicalsButton.TabIndex = 2
        Me.PeriodicalsButton.TabStop = True
        Me.PeriodicalsButton.Text = "Perio&dicals"
        Me.PeriodicalsButton.UseVisualStyleBackColor = True
        '
        'CoffeeBarButton
        '
        Me.CoffeeBarButton.AutoSize = True
        Me.CoffeeBarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoffeeBarButton.Location = New System.Drawing.Point(6, 99)
        Me.CoffeeBarButton.Name = "CoffeeBarButton"
        Me.CoffeeBarButton.Size = New System.Drawing.Size(99, 20)
        Me.CoffeeBarButton.TabIndex = 3
        Me.CoffeeBarButton.TabStop = True
        Me.CoffeeBarButton.Text = "&Coffee Bar"
        Me.CoffeeBarButton.UseVisualStyleBackColor = True
        '
        'ImagesBox
        '
        Me.ImagesBox.ErrorImage = Nothing
        Me.ImagesBox.Location = New System.Drawing.Point(43, 224)
        Me.ImagesBox.Name = "ImagesBox"
        Me.ImagesBox.Size = New System.Drawing.Size(206, 132)
        Me.ImagesBox.TabIndex = 24
        Me.ImagesBox.TabStop = False
        Me.ImagesBox.Visible = False
        '
        'PromotionTextBox
        '
        Me.PromotionTextBox.Location = New System.Drawing.Point(43, 399)
        Me.PromotionTextBox.Name = "PromotionTextBox"
        Me.PromotionTextBox.Size = New System.Drawing.Size(304, 20)
        Me.PromotionTextBox.TabIndex = 9
        Me.PromotionTextBox.Visible = False
        '
        'PromotionLabel
        '
        Me.PromotionLabel.AutoSize = True
        Me.PromotionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromotionLabel.Location = New System.Drawing.Point(46, 371)
        Me.PromotionLabel.Name = "PromotionLabel"
        Me.PromotionLabel.Size = New System.Drawing.Size(119, 16)
        Me.PromotionLabel.TabIndex = 8
        Me.PromotionLabel.Text = "Promotion Code"
        Me.PromotionLabel.Visible = False
        '
        'ImageVisableCheckBox
        '
        Me.ImageVisableCheckBox.AutoSize = True
        Me.ImageVisableCheckBox.Location = New System.Drawing.Point(274, 339)
        Me.ImageVisableCheckBox.Name = "ImageVisableCheckBox"
        Me.ImageVisableCheckBox.Size = New System.Drawing.Size(88, 17)
        Me.ImageVisableCheckBox.TabIndex = 10
        Me.ImageVisableCheckBox.Text = "Image &Visible"
        Me.ToolTip1.SetToolTip(Me.ImageVisableCheckBox, "Check to view image")
        Me.ImageVisableCheckBox.UseVisualStyleBackColor = True
        Me.ImageVisableCheckBox.Visible = False
        '
        'DepartmentsGroup
        '
        Me.DepartmentsGroup.Controls.Add(Me.BooksButton)
        Me.DepartmentsGroup.Controls.Add(Me.MusicButton)
        Me.DepartmentsGroup.Controls.Add(Me.PeriodicalsButton)
        Me.DepartmentsGroup.Controls.Add(Me.CoffeeBarButton)
        Me.DepartmentsGroup.Enabled = False
        Me.DepartmentsGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentsGroup.Location = New System.Drawing.Point(43, 78)
        Me.DepartmentsGroup.Name = "DepartmentsGroup"
        Me.DepartmentsGroup.Size = New System.Drawing.Size(206, 130)
        Me.DepartmentsGroup.TabIndex = 7
        Me.DepartmentsGroup.TabStop = False
        Me.DepartmentsGroup.Text = "Departments"
        Me.ToolTip1.SetToolTip(Me.DepartmentsGroup, "Select Department")
        '
        'LoginGroup
        '
        Me.LoginGroup.Controls.Add(Me.UsernameLabel)
        Me.LoginGroup.Controls.Add(Me.UserIDLabel)
        Me.LoginGroup.Controls.Add(Me.UsernameTextbox)
        Me.LoginGroup.Controls.Add(Me.UserIDTextbox)
        Me.LoginGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginGroup.Location = New System.Drawing.Point(632, 78)
        Me.LoginGroup.Name = "LoginGroup"
        Me.LoginGroup.Size = New System.Drawing.Size(254, 104)
        Me.LoginGroup.TabIndex = 0
        Me.LoginGroup.TabStop = False
        Me.LoginGroup.Text = "Elite Members Login Below"
        '
        'ReadingAndRefreshmentLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 432)
        Me.Controls.Add(Me.LoginGroup)
        Me.Controls.Add(Me.DepartmentsGroup)
        Me.Controls.Add(Me.ImageVisableCheckBox)
        Me.Controls.Add(Me.PromotionLabel)
        Me.Controls.Add(Me.PromotionTextBox)
        Me.Controls.Add(Me.ImagesBox)
        Me.Controls.Add(Me.WelcomeRichTextBox)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.ProgrammerLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Name = "ReadingAndRefreshmentLogin"
        Me.Text = "Reading and Refreshment"
        CType(Me.ImagesBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DepartmentsGroup.ResumeLayout(False)
        Me.DepartmentsGroup.PerformLayout()
        Me.LoginGroup.ResumeLayout(False)
        Me.LoginGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents UserIDLabel As System.Windows.Forms.Label
    Friend WithEvents ProgrammerLabel As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents WelcomeLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextbox As System.Windows.Forms.TextBox
    Friend WithEvents UserIDTextbox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CoffeeBarButton As System.Windows.Forms.RadioButton
    Friend WithEvents PeriodicalsButton As System.Windows.Forms.RadioButton
    Friend WithEvents MusicButton As System.Windows.Forms.RadioButton
    Friend WithEvents BooksButton As System.Windows.Forms.RadioButton
    Friend WithEvents WelcomeRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents DepartmentsGroup As System.Windows.Forms.GroupBox
    Friend WithEvents ImageVisableCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PromotionLabel As System.Windows.Forms.Label
    Friend WithEvents PromotionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImagesBox As System.Windows.Forms.PictureBox
    Friend WithEvents LoginGroup As System.Windows.Forms.GroupBox

End Class
