<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Job_Information
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
        Me.JobNumberLabel = New System.Windows.Forms.Label()
        Me.CustomerNameLabel = New System.Windows.Forms.Label()
        Me.PartsTotalLabel = New System.Windows.Forms.Label()
        Me.HoursOfLaborLabel = New System.Windows.Forms.Label()
        Me.JobNumberTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.PartsTotalTextBox = New System.Windows.Forms.TextBox()
        Me.HoursOfLaborTextBox = New System.Windows.Forms.TextBox()
        Me.SalesTaxTextBox = New System.Windows.Forms.TextBox()
        Me.SubtotalTextBox = New System.Windows.Forms.TextBox()
        Me.LaborTextBox = New System.Windows.Forms.TextBox()
        Me.PartsTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.JobInformationLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'JobNumberLabel
        '
        Me.JobNumberLabel.AutoSize = True
        Me.JobNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JobNumberLabel.Location = New System.Drawing.Point(25, 46)
        Me.JobNumberLabel.Name = "JobNumberLabel"
        Me.JobNumberLabel.Size = New System.Drawing.Size(95, 20)
        Me.JobNumberLabel.TabIndex = 1
        Me.JobNumberLabel.Text = "Job Number"
        Me.ToolTip1.SetToolTip(Me.JobNumberLabel, "Job Number")
        '
        'CustomerNameLabel
        '
        Me.CustomerNameLabel.AutoSize = True
        Me.CustomerNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerNameLabel.Location = New System.Drawing.Point(25, 72)
        Me.CustomerNameLabel.Name = "CustomerNameLabel"
        Me.CustomerNameLabel.Size = New System.Drawing.Size(124, 20)
        Me.CustomerNameLabel.TabIndex = 3
        Me.CustomerNameLabel.Text = "Customer Name"
        Me.ToolTip1.SetToolTip(Me.CustomerNameLabel, "Customer Name")
        '
        'PartsTotalLabel
        '
        Me.PartsTotalLabel.AutoSize = True
        Me.PartsTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartsTotalLabel.Location = New System.Drawing.Point(25, 98)
        Me.PartsTotalLabel.Name = "PartsTotalLabel"
        Me.PartsTotalLabel.Size = New System.Drawing.Size(85, 20)
        Me.PartsTotalLabel.TabIndex = 5
        Me.PartsTotalLabel.Text = "Parts Total"
        Me.ToolTip1.SetToolTip(Me.PartsTotalLabel, "Parts Total")
        '
        'HoursOfLaborLabel
        '
        Me.HoursOfLaborLabel.AutoSize = True
        Me.HoursOfLaborLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoursOfLaborLabel.Location = New System.Drawing.Point(25, 122)
        Me.HoursOfLaborLabel.Name = "HoursOfLaborLabel"
        Me.HoursOfLaborLabel.Size = New System.Drawing.Size(115, 20)
        Me.HoursOfLaborLabel.TabIndex = 7
        Me.HoursOfLaborLabel.Text = "Hours of Labor"
        Me.ToolTip1.SetToolTip(Me.HoursOfLaborLabel, "Hours of Labor")
        '
        'JobNumberTextBox
        '
        Me.JobNumberTextBox.Location = New System.Drawing.Point(159, 46)
        Me.JobNumberTextBox.Name = "JobNumberTextBox"
        Me.JobNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.JobNumberTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.JobNumberTextBox, "Job Number")
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(159, 72)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CustomerNameTextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.CustomerNameTextBox, "Customer Name")
        '
        'PartsTotalTextBox
        '
        Me.PartsTotalTextBox.Location = New System.Drawing.Point(159, 98)
        Me.PartsTotalTextBox.Name = "PartsTotalTextBox"
        Me.PartsTotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PartsTotalTextBox.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.PartsTotalTextBox, "Parts Total")
        '
        'HoursOfLaborTextBox
        '
        Me.HoursOfLaborTextBox.Location = New System.Drawing.Point(159, 124)
        Me.HoursOfLaborTextBox.Name = "HoursOfLaborTextBox"
        Me.HoursOfLaborTextBox.Size = New System.Drawing.Size(200, 20)
        Me.HoursOfLaborTextBox.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.HoursOfLaborTextBox, "Hours of Labor")
        '
        'SalesTaxTextBox
        '
        Me.SalesTaxTextBox.Location = New System.Drawing.Point(159, 246)
        Me.SalesTaxTextBox.Name = "SalesTaxTextBox"
        Me.SalesTaxTextBox.ReadOnly = True
        Me.SalesTaxTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SalesTaxTextBox.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.SalesTaxTextBox, "Sales Tax")
        '
        'SubtotalTextBox
        '
        Me.SubtotalTextBox.Location = New System.Drawing.Point(159, 220)
        Me.SubtotalTextBox.Name = "SubtotalTextBox"
        Me.SubtotalTextBox.ReadOnly = True
        Me.SubtotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SubtotalTextBox.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.SubtotalTextBox, "Subtotal")
        '
        'LaborTextBox
        '
        Me.LaborTextBox.Location = New System.Drawing.Point(159, 194)
        Me.LaborTextBox.Name = "LaborTextBox"
        Me.LaborTextBox.ReadOnly = True
        Me.LaborTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LaborTextBox.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.LaborTextBox, "Labor")
        '
        'PartsTextBox
        '
        Me.PartsTextBox.Location = New System.Drawing.Point(159, 168)
        Me.PartsTextBox.Name = "PartsTextBox"
        Me.PartsTextBox.ReadOnly = True
        Me.PartsTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PartsTextBox.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.PartsTextBox, "Parts")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Sales Tax"
        Me.ToolTip1.SetToolTip(Me.Label1, "Sales Tax")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Subtotal"
        Me.ToolTip1.SetToolTip(Me.Label2, "Subtotal")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Labor"
        Me.ToolTip1.SetToolTip(Me.Label3, "Labor")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Parts"
        Me.ToolTip1.SetToolTip(Me.Label4, "Parts")
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(159, 272)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TotalTextBox.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.TotalTextBox, "Total")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Total"
        Me.ToolTip1.SetToolTip(Me.Label5, "Total")
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(52, 311)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 19
        Me.CalculateButton.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Calculate")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(156, 311)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 20
        Me.ClearButton.Text = "Clea&r"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(261, 311)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 21
        Me.OKButton.Text = "&OK"
        Me.ToolTip1.SetToolTip(Me.OKButton, "OK")
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'JobInformationLabel
        '
        Me.JobInformationLabel.AutoSize = True
        Me.JobInformationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JobInformationLabel.Location = New System.Drawing.Point(123, 9)
        Me.JobInformationLabel.Name = "JobInformationLabel"
        Me.JobInformationLabel.Size = New System.Drawing.Size(135, 20)
        Me.JobInformationLabel.TabIndex = 0
        Me.JobInformationLabel.Text = "Job Information"
        Me.ToolTip1.SetToolTip(Me.JobInformationLabel, "Job Information")
        '
        'Job_Information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 346)
        Me.Controls.Add(Me.JobInformationLabel)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SalesTaxTextBox)
        Me.Controls.Add(Me.SubtotalTextBox)
        Me.Controls.Add(Me.LaborTextBox)
        Me.Controls.Add(Me.PartsTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.HoursOfLaborTextBox)
        Me.Controls.Add(Me.PartsTotalTextBox)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Controls.Add(Me.JobNumberTextBox)
        Me.Controls.Add(Me.HoursOfLaborLabel)
        Me.Controls.Add(Me.PartsTotalLabel)
        Me.Controls.Add(Me.CustomerNameLabel)
        Me.Controls.Add(Me.JobNumberLabel)
        Me.Name = "Job_Information"
        Me.Text = "Job Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JobNumberLabel As System.Windows.Forms.Label
    Friend WithEvents CustomerNameLabel As System.Windows.Forms.Label
    Friend WithEvents PartsTotalLabel As System.Windows.Forms.Label
    Friend WithEvents HoursOfLaborLabel As System.Windows.Forms.Label
    Friend WithEvents JobNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PartsTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HoursOfLaborTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalesTaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubtotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LaborTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PartsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents JobInformationLabel As System.Windows.Forms.Label
End Class
