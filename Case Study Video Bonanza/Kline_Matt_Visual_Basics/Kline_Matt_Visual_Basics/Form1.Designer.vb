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
        Me.ComedyButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DramaButton = New System.Windows.Forms.Button()
        Me.ActionButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ProgrammerLabel = New System.Windows.Forms.Label()
        Me.SciFiButton = New System.Windows.Forms.Button()
        Me.HorrorButton = New System.Windows.Forms.Button()
        Me.NewReleasesButton = New System.Windows.Forms.Button()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.LocationLabel2 = New System.Windows.Forms.Label()
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
        'ComedyButton
        '
        Me.ComedyButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ComedyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComedyButton.Location = New System.Drawing.Point(45, 89)
        Me.ComedyButton.Name = "ComedyButton"
        Me.ComedyButton.Size = New System.Drawing.Size(130, 30)
        Me.ComedyButton.TabIndex = 2
        Me.ComedyButton.Text = "Comedy"
        Me.ComedyButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(479, 251)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(166, 48)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'DramaButton
        '
        Me.DramaButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.DramaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DramaButton.Location = New System.Drawing.Point(45, 125)
        Me.DramaButton.Name = "DramaButton"
        Me.DramaButton.Size = New System.Drawing.Size(130, 30)
        Me.DramaButton.TabIndex = 5
        Me.DramaButton.Text = "Drama"
        Me.DramaButton.UseVisualStyleBackColor = False
        '
        'ActionButton
        '
        Me.ActionButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ActionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActionButton.Location = New System.Drawing.Point(45, 161)
        Me.ActionButton.Name = "ActionButton"
        Me.ActionButton.Size = New System.Drawing.Size(130, 30)
        Me.ActionButton.TabIndex = 6
        Me.ActionButton.Text = "Action"
        Me.ActionButton.UseVisualStyleBackColor = False
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(237, 251)
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
        'SciFiButton
        '
        Me.SciFiButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SciFiButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SciFiButton.Location = New System.Drawing.Point(45, 197)
        Me.SciFiButton.Name = "SciFiButton"
        Me.SciFiButton.Size = New System.Drawing.Size(130, 30)
        Me.SciFiButton.TabIndex = 10
        Me.SciFiButton.Text = "Sci-Fi"
        Me.SciFiButton.UseVisualStyleBackColor = False
        '
        'HorrorButton
        '
        Me.HorrorButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.HorrorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HorrorButton.Location = New System.Drawing.Point(45, 233)
        Me.HorrorButton.Name = "HorrorButton"
        Me.HorrorButton.Size = New System.Drawing.Size(130, 30)
        Me.HorrorButton.TabIndex = 11
        Me.HorrorButton.Text = "Horror"
        Me.HorrorButton.UseVisualStyleBackColor = False
        '
        'NewReleasesButton
        '
        Me.NewReleasesButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.NewReleasesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewReleasesButton.Location = New System.Drawing.Point(45, 269)
        Me.NewReleasesButton.Name = "NewReleasesButton"
        Me.NewReleasesButton.Size = New System.Drawing.Size(130, 30)
        Me.NewReleasesButton.TabIndex = 12
        Me.NewReleasesButton.Text = "New Releases"
        Me.NewReleasesButton.UseVisualStyleBackColor = False
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LocationLabel.Location = New System.Drawing.Point(239, 105)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(0, 37)
        Me.LocationLabel.TabIndex = 13
        '
        'LocationLabel2
        '
        Me.LocationLabel2.AutoSize = True
        Me.LocationLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LocationLabel2.Location = New System.Drawing.Point(239, 161)
        Me.LocationLabel2.Name = "LocationLabel2"
        Me.LocationLabel2.Size = New System.Drawing.Size(0, 37)
        Me.LocationLabel2.TabIndex = 16
        '
        'VideoBonanza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(726, 339)
        Me.Controls.Add(Me.LocationLabel2)
        Me.Controls.Add(Me.LocationLabel)
        Me.Controls.Add(Me.NewReleasesButton)
        Me.Controls.Add(Me.HorrorButton)
        Me.Controls.Add(Me.SciFiButton)
        Me.Controls.Add(Me.ProgrammerLabel)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ActionButton)
        Me.Controls.Add(Me.DramaButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ComedyButton)
        Me.Controls.Add(Me.MessageLabel)
        Me.Name = "VideoBonanza"
        Me.Text = "Video Bonanza"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents ComedyButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents DramaButton As System.Windows.Forms.Button
    Friend WithEvents ActionButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ProgrammerLabel As System.Windows.Forms.Label
    Friend WithEvents NewReleasesButton As System.Windows.Forms.Button
    Friend WithEvents HorrorButton As System.Windows.Forms.Button
    Friend WithEvents SciFiButton As System.Windows.Forms.Button
    Friend WithEvents LocationLabel As System.Windows.Forms.Label
    Friend WithEvents LocationLabel2 As System.Windows.Forms.Label

End Class
