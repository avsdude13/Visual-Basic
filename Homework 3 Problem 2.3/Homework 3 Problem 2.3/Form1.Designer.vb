<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeatherReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WeatherReport))
        Me.SunnyPicBox = New System.Windows.Forms.PictureBox()
        Me.SnowyPicBox = New System.Windows.Forms.PictureBox()
        Me.RainyPicBox = New System.Windows.Forms.PictureBox()
        Me.CloudyPicBox = New System.Windows.Forms.PictureBox()
        Me.EnterNameLabel = New System.Windows.Forms.Label()
        Me.MessageTextBox = New System.Windows.Forms.TextBox()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ChooseGroup = New System.Windows.Forms.GroupBox()
        Me.CloudyButton = New System.Windows.Forms.RadioButton()
        Me.RainyButton = New System.Windows.Forms.RadioButton()
        Me.SnowyButton = New System.Windows.Forms.RadioButton()
        Me.SunnyButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EnterTextBox = New System.Windows.Forms.TextBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SunnyPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SnowyPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RainyPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloudyPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChooseGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'SunnyPicBox
        '
        Me.SunnyPicBox.Image = Global.WindowsApplication1.My.Resources.Resources.Sunny
        Me.SunnyPicBox.Location = New System.Drawing.Point(225, 71)
        Me.SunnyPicBox.Name = "SunnyPicBox"
        Me.SunnyPicBox.Size = New System.Drawing.Size(108, 90)
        Me.SunnyPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SunnyPicBox.TabIndex = 0
        Me.SunnyPicBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.SunnyPicBox, "Sunny")
        Me.SunnyPicBox.Visible = False
        '
        'SnowyPicBox
        '
        Me.SnowyPicBox.Image = Global.WindowsApplication1.My.Resources.Resources.Snowy
        Me.SnowyPicBox.Location = New System.Drawing.Point(339, 71)
        Me.SnowyPicBox.Name = "SnowyPicBox"
        Me.SnowyPicBox.Size = New System.Drawing.Size(108, 90)
        Me.SnowyPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SnowyPicBox.TabIndex = 1
        Me.SnowyPicBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.SnowyPicBox, "Snowy")
        Me.SnowyPicBox.Visible = False
        '
        'RainyPicBox
        '
        Me.RainyPicBox.Image = Global.WindowsApplication1.My.Resources.Resources.Rainy
        Me.RainyPicBox.Location = New System.Drawing.Point(225, 167)
        Me.RainyPicBox.Name = "RainyPicBox"
        Me.RainyPicBox.Size = New System.Drawing.Size(108, 90)
        Me.RainyPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RainyPicBox.TabIndex = 2
        Me.RainyPicBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.RainyPicBox, "Rainy")
        Me.RainyPicBox.Visible = False
        '
        'CloudyPicBox
        '
        Me.CloudyPicBox.Image = Global.WindowsApplication1.My.Resources.Resources.Cloudy
        Me.CloudyPicBox.Location = New System.Drawing.Point(339, 167)
        Me.CloudyPicBox.Name = "CloudyPicBox"
        Me.CloudyPicBox.Size = New System.Drawing.Size(108, 90)
        Me.CloudyPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CloudyPicBox.TabIndex = 3
        Me.CloudyPicBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.CloudyPicBox, "Cloudy")
        Me.CloudyPicBox.Visible = False
        '
        'EnterNameLabel
        '
        Me.EnterNameLabel.AutoSize = True
        Me.EnterNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterNameLabel.Location = New System.Drawing.Point(56, 85)
        Me.EnterNameLabel.Name = "EnterNameLabel"
        Me.EnterNameLabel.Size = New System.Drawing.Size(148, 20)
        Me.EnterNameLabel.TabIndex = 0
        Me.EnterNameLabel.Text = "&Enter name here:"
        '
        'MessageTextBox
        '
        Me.MessageTextBox.Enabled = False
        Me.MessageTextBox.Location = New System.Drawing.Point(52, 25)
        Me.MessageTextBox.Name = "MessageTextBox"
        Me.MessageTextBox.Size = New System.Drawing.Size(395, 20)
        Me.MessageTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.MessageTextBox, "Weather Report")
        Me.MessageTextBox.Visible = False
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(225, 274)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(108, 35)
        Me.PrintButton.TabIndex = 3
        Me.PrintButton.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "Print")
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(339, 274)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(108, 35)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit")
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'ChooseGroup
        '
        Me.ChooseGroup.Controls.Add(Me.CloudyButton)
        Me.ChooseGroup.Controls.Add(Me.RainyButton)
        Me.ChooseGroup.Controls.Add(Me.SnowyButton)
        Me.ChooseGroup.Controls.Add(Me.SunnyButton)
        Me.ChooseGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChooseGroup.Location = New System.Drawing.Point(52, 158)
        Me.ChooseGroup.Name = "ChooseGroup"
        Me.ChooseGroup.Size = New System.Drawing.Size(167, 151)
        Me.ChooseGroup.TabIndex = 2
        Me.ChooseGroup.TabStop = False
        Me.ChooseGroup.Text = "Choose"
        '
        'CloudyButton
        '
        Me.CloudyButton.AutoSize = True
        Me.CloudyButton.Location = New System.Drawing.Point(8, 115)
        Me.CloudyButton.Name = "CloudyButton"
        Me.CloudyButton.Size = New System.Drawing.Size(81, 24)
        Me.CloudyButton.TabIndex = 3
        Me.CloudyButton.TabStop = True
        Me.CloudyButton.Text = "&Cloudy"
        Me.ToolTip1.SetToolTip(Me.CloudyButton, "Cloudy")
        Me.CloudyButton.UseVisualStyleBackColor = True
        '
        'RainyButton
        '
        Me.RainyButton.AutoSize = True
        Me.RainyButton.Location = New System.Drawing.Point(8, 85)
        Me.RainyButton.Name = "RainyButton"
        Me.RainyButton.Size = New System.Drawing.Size(72, 24)
        Me.RainyButton.TabIndex = 2
        Me.RainyButton.TabStop = True
        Me.RainyButton.Text = "&Rainy"
        Me.ToolTip1.SetToolTip(Me.RainyButton, "Rainy")
        Me.RainyButton.UseVisualStyleBackColor = True
        '
        'SnowyButton
        '
        Me.SnowyButton.AutoSize = True
        Me.SnowyButton.Location = New System.Drawing.Point(8, 55)
        Me.SnowyButton.Name = "SnowyButton"
        Me.SnowyButton.Size = New System.Drawing.Size(79, 24)
        Me.SnowyButton.TabIndex = 1
        Me.SnowyButton.TabStop = True
        Me.SnowyButton.Text = "S&nowy"
        Me.ToolTip1.SetToolTip(Me.SnowyButton, "Snowy")
        Me.SnowyButton.UseVisualStyleBackColor = True
        '
        'SunnyButton
        '
        Me.SunnyButton.AutoSize = True
        Me.SunnyButton.Location = New System.Drawing.Point(8, 25)
        Me.SunnyButton.Name = "SunnyButton"
        Me.SunnyButton.Size = New System.Drawing.Size(77, 24)
        Me.SunnyButton.TabIndex = 0
        Me.SunnyButton.TabStop = True
        Me.SunnyButton.Text = "&Sunny"
        Me.ToolTip1.SetToolTip(Me.SunnyButton, "Sunny")
        Me.SunnyButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(374, 317)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Programmer: Matt Kline"
        '
        'EnterTextBox
        '
        Me.EnterTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterTextBox.Location = New System.Drawing.Point(52, 119)
        Me.EnterTextBox.Name = "EnterTextBox"
        Me.EnterTextBox.Size = New System.Drawing.Size(167, 22)
        Me.EnterTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.EnterTextBox, "Enter Name Here")
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'WeatherReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(502, 339)
        Me.Controls.Add(Me.EnterTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChooseGroup)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.MessageTextBox)
        Me.Controls.Add(Me.EnterNameLabel)
        Me.Controls.Add(Me.CloudyPicBox)
        Me.Controls.Add(Me.RainyPicBox)
        Me.Controls.Add(Me.SnowyPicBox)
        Me.Controls.Add(Me.SunnyPicBox)
        Me.Name = "WeatherReport"
        Me.Text = "Weather Report"
        CType(Me.SunnyPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SnowyPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RainyPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloudyPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChooseGroup.ResumeLayout(False)
        Me.ChooseGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SunnyPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents SnowyPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents RainyPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents CloudyPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents EnterNameLabel As System.Windows.Forms.Label
    Friend WithEvents MessageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ChooseGroup As System.Windows.Forms.GroupBox
    Friend WithEvents CloudyButton As System.Windows.Forms.RadioButton
    Friend WithEvents RainyButton As System.Windows.Forms.RadioButton
    Friend WithEvents SnowyButton As System.Windows.Forms.RadioButton
    Friend WithEvents SunnyButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EnterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
