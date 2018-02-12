<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoBonanza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VideoBonanza))
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ProgrammerLabel = New System.Windows.Forms.Label()
        Me.ComedyRadioButton = New System.Windows.Forms.RadioButton()
        Me.DramaRadioButton = New System.Windows.Forms.RadioButton()
        Me.ActionRadioButton = New System.Windows.Forms.RadioButton()
        Me.SciFiRadioButton = New System.Windows.Forms.RadioButton()
        Me.HorrorRadioButton = New System.Windows.Forms.RadioButton()
        Me.MemberCheckBox = New System.Windows.Forms.CheckBox()
        Me.MembersLabel = New System.Windows.Forms.Label()
        Me.AisleLocationTextBox = New System.Windows.Forms.RichTextBox()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MessageLabel
        '
        Me.MessageLabel.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MessageLabel.Location = New System.Drawing.Point(35, 4)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(625, 82)
        Me.MessageLabel.TabIndex = 0
        Me.MessageLabel.Text = "Welcome to Video Bonanza"
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(259, 269)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(166, 48)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit")
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(45, 269)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(166, 48)
        Me.PrintButton.TabIndex = 8
        Me.PrintButton.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "Print")
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
        'ProgrammerLabel
        '
        Me.ProgrammerLabel.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgrammerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProgrammerLabel.Location = New System.Drawing.Point(540, 303)
        Me.ProgrammerLabel.Name = "ProgrammerLabel"
        Me.ProgrammerLabel.Size = New System.Drawing.Size(174, 27)
        Me.ProgrammerLabel.TabIndex = 9
        Me.ProgrammerLabel.Text = "Programmer: Matt Kline"
        Me.ProgrammerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComedyRadioButton
        '
        Me.ComedyRadioButton.AutoSize = True
        Me.ComedyRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComedyRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ComedyRadioButton.Location = New System.Drawing.Point(45, 89)
        Me.ComedyRadioButton.Name = "ComedyRadioButton"
        Me.ComedyRadioButton.Size = New System.Drawing.Size(85, 24)
        Me.ComedyRadioButton.TabIndex = 17
        Me.ComedyRadioButton.TabStop = True
        Me.ComedyRadioButton.Text = "&Comedy"
        Me.ToolTip1.SetToolTip(Me.ComedyRadioButton, "Comedy")
        Me.ComedyRadioButton.UseVisualStyleBackColor = True
        '
        'DramaRadioButton
        '
        Me.DramaRadioButton.AutoSize = True
        Me.DramaRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DramaRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DramaRadioButton.Location = New System.Drawing.Point(45, 119)
        Me.DramaRadioButton.Name = "DramaRadioButton"
        Me.DramaRadioButton.Size = New System.Drawing.Size(75, 24)
        Me.DramaRadioButton.TabIndex = 18
        Me.DramaRadioButton.TabStop = True
        Me.DramaRadioButton.Text = "&Drama"
        Me.ToolTip1.SetToolTip(Me.DramaRadioButton, "Drama")
        Me.DramaRadioButton.UseVisualStyleBackColor = True
        '
        'ActionRadioButton
        '
        Me.ActionRadioButton.AutoSize = True
        Me.ActionRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActionRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ActionRadioButton.Location = New System.Drawing.Point(45, 149)
        Me.ActionRadioButton.Name = "ActionRadioButton"
        Me.ActionRadioButton.Size = New System.Drawing.Size(72, 24)
        Me.ActionRadioButton.TabIndex = 19
        Me.ActionRadioButton.TabStop = True
        Me.ActionRadioButton.Text = "&Action"
        Me.ToolTip1.SetToolTip(Me.ActionRadioButton, "Action")
        Me.ActionRadioButton.UseVisualStyleBackColor = True
        '
        'SciFiRadioButton
        '
        Me.SciFiRadioButton.AutoSize = True
        Me.SciFiRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SciFiRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SciFiRadioButton.Location = New System.Drawing.Point(45, 179)
        Me.SciFiRadioButton.Name = "SciFiRadioButton"
        Me.SciFiRadioButton.Size = New System.Drawing.Size(67, 24)
        Me.SciFiRadioButton.TabIndex = 20
        Me.SciFiRadioButton.TabStop = True
        Me.SciFiRadioButton.Text = "&Sci-Fi"
        Me.ToolTip1.SetToolTip(Me.SciFiRadioButton, "Sci-Fi")
        Me.SciFiRadioButton.UseVisualStyleBackColor = True
        '
        'HorrorRadioButton
        '
        Me.HorrorRadioButton.AutoSize = True
        Me.HorrorRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HorrorRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HorrorRadioButton.Location = New System.Drawing.Point(45, 209)
        Me.HorrorRadioButton.Name = "HorrorRadioButton"
        Me.HorrorRadioButton.Size = New System.Drawing.Size(72, 24)
        Me.HorrorRadioButton.TabIndex = 21
        Me.HorrorRadioButton.TabStop = True
        Me.HorrorRadioButton.Text = "&Horror"
        Me.ToolTip1.SetToolTip(Me.HorrorRadioButton, "Horror")
        Me.HorrorRadioButton.UseVisualStyleBackColor = True
        '
        'MemberCheckBox
        '
        Me.MemberCheckBox.AutoSize = True
        Me.MemberCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemberCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MemberCheckBox.Location = New System.Drawing.Point(45, 239)
        Me.MemberCheckBox.Name = "MemberCheckBox"
        Me.MemberCheckBox.Size = New System.Drawing.Size(86, 24)
        Me.MemberCheckBox.TabIndex = 22
        Me.MemberCheckBox.Text = "&Member"
        Me.ToolTip1.SetToolTip(Me.MemberCheckBox, "Click to view member details")
        Me.MemberCheckBox.UseVisualStyleBackColor = True
        '
        'MembersLabel
        '
        Me.MembersLabel.AutoSize = True
        Me.MembersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MembersLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MembersLabel.Location = New System.Drawing.Point(212, 227)
        Me.MembersLabel.Name = "MembersLabel"
        Me.MembersLabel.Size = New System.Drawing.Size(273, 20)
        Me.MembersLabel.TabIndex = 23
        Me.MembersLabel.Text = "All Members Receive a 10% Discount"
        Me.ToolTip1.SetToolTip(Me.MembersLabel, "Member Details")
        Me.MembersLabel.Visible = False
        '
        'AisleLocationTextBox
        '
        Me.AisleLocationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AisleLocationTextBox.Location = New System.Drawing.Point(200, 93)
        Me.AisleLocationTextBox.Name = "AisleLocationTextBox"
        Me.AisleLocationTextBox.Size = New System.Drawing.Size(297, 113)
        Me.AisleLocationTextBox.TabIndex = 24
        Me.AisleLocationTextBox.Text = ""
        Me.ToolTip1.SetToolTip(Me.AisleLocationTextBox, "Ailse Location")
        '
        'Picture
        '
        Me.Picture.Image = Global.Kline_Matt_Visual_Basics.My.Resources.Resources.video
        Me.Picture.Location = New System.Drawing.Point(503, 93)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(214, 170)
        Me.Picture.TabIndex = 25
        Me.Picture.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Picture, "Video Bonanza")
        '
        'VideoBonanza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(726, 339)
        Me.Controls.Add(Me.Picture)
        Me.Controls.Add(Me.AisleLocationTextBox)
        Me.Controls.Add(Me.MembersLabel)
        Me.Controls.Add(Me.MemberCheckBox)
        Me.Controls.Add(Me.HorrorRadioButton)
        Me.Controls.Add(Me.SciFiRadioButton)
        Me.Controls.Add(Me.ActionRadioButton)
        Me.Controls.Add(Me.DramaRadioButton)
        Me.Controls.Add(Me.ComedyRadioButton)
        Me.Controls.Add(Me.ProgrammerLabel)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.MessageLabel)
        Me.Name = "VideoBonanza"
        Me.Text = "Video Bonanza"
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ProgrammerLabel As System.Windows.Forms.Label
    Friend WithEvents ComedyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DramaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ActionRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MemberCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HorrorRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SciFiRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MembersLabel As System.Windows.Forms.Label
    Friend WithEvents AisleLocationTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Picture As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
