<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NutritionFacts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NutritionFacts))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NutritionFactsLabel = New System.Windows.Forms.Label()
        Me.EnterNutritionInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.GramsOfProteinTextBox = New System.Windows.Forms.TextBox()
        Me.GramsOfCarbsTextBox = New System.Windows.Forms.TextBox()
        Me.GramsOfFatTextBox = New System.Windows.Forms.TextBox()
        Me.GramsOfProtein = New System.Windows.Forms.Label()
        Me.GramsOfFat = New System.Windows.Forms.Label()
        Me.GramsOfCarbsLabel = New System.Windows.Forms.Label()
        Me.NutritionFactsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ItemTotalTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCaloriesTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentCaloriesTextBox = New System.Windows.Forms.TextBox()
        Me.ItemTotalLabel = New System.Windows.Forms.Label()
        Me.TotalCaloriesLabel = New System.Windows.Forms.Label()
        Me.CurrentCaloriesLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.EnterNutritionInfoGroupBox.SuspendLayout()
        Me.NutritionFactsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NutritionFactsLabel
        '
        Me.NutritionFactsLabel.AutoSize = True
        Me.NutritionFactsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NutritionFactsLabel.Location = New System.Drawing.Point(160, 9)
        Me.NutritionFactsLabel.Name = "NutritionFactsLabel"
        Me.NutritionFactsLabel.Size = New System.Drawing.Size(191, 31)
        Me.NutritionFactsLabel.TabIndex = 0
        Me.NutritionFactsLabel.Text = "Nutrition Facts"
        Me.ToolTip1.SetToolTip(Me.NutritionFactsLabel, "Nutrition Facts")
        '
        'EnterNutritionInfoGroupBox
        '
        Me.EnterNutritionInfoGroupBox.Controls.Add(Me.GramsOfProteinTextBox)
        Me.EnterNutritionInfoGroupBox.Controls.Add(Me.GramsOfCarbsTextBox)
        Me.EnterNutritionInfoGroupBox.Controls.Add(Me.GramsOfFatTextBox)
        Me.EnterNutritionInfoGroupBox.Controls.Add(Me.GramsOfProtein)
        Me.EnterNutritionInfoGroupBox.Controls.Add(Me.GramsOfFat)
        Me.EnterNutritionInfoGroupBox.Controls.Add(Me.GramsOfCarbsLabel)
        Me.EnterNutritionInfoGroupBox.Location = New System.Drawing.Point(12, 54)
        Me.EnterNutritionInfoGroupBox.Name = "EnterNutritionInfoGroupBox"
        Me.EnterNutritionInfoGroupBox.Size = New System.Drawing.Size(228, 232)
        Me.EnterNutritionInfoGroupBox.TabIndex = 1
        Me.EnterNutritionInfoGroupBox.TabStop = False
        Me.EnterNutritionInfoGroupBox.Text = "Enter Nutrition Information"
        Me.ToolTip1.SetToolTip(Me.EnterNutritionInfoGroupBox, "Enter Nutrition Information")
        '
        'GramsOfProteinTextBox
        '
        Me.GramsOfProteinTextBox.Location = New System.Drawing.Point(31, 189)
        Me.GramsOfProteinTextBox.Name = "GramsOfProteinTextBox"
        Me.GramsOfProteinTextBox.Size = New System.Drawing.Size(166, 20)
        Me.GramsOfProteinTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.GramsOfProteinTextBox, "Enter Grams of Protein")
        '
        'GramsOfCarbsTextBox
        '
        Me.GramsOfCarbsTextBox.Location = New System.Drawing.Point(31, 121)
        Me.GramsOfCarbsTextBox.Name = "GramsOfCarbsTextBox"
        Me.GramsOfCarbsTextBox.Size = New System.Drawing.Size(166, 20)
        Me.GramsOfCarbsTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.GramsOfCarbsTextBox, "Enter Grams of Carbs")
        '
        'GramsOfFatTextBox
        '
        Me.GramsOfFatTextBox.Location = New System.Drawing.Point(31, 54)
        Me.GramsOfFatTextBox.Name = "GramsOfFatTextBox"
        Me.GramsOfFatTextBox.Size = New System.Drawing.Size(166, 20)
        Me.GramsOfFatTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.GramsOfFatTextBox, "Enter Grams of Fat")
        '
        'GramsOfProtein
        '
        Me.GramsOfProtein.AutoSize = True
        Me.GramsOfProtein.Location = New System.Drawing.Point(18, 163)
        Me.GramsOfProtein.Name = "GramsOfProtein"
        Me.GramsOfProtein.Size = New System.Drawing.Size(85, 13)
        Me.GramsOfProtein.TabIndex = 4
        Me.GramsOfProtein.Text = "Grams of &Protein"
        Me.ToolTip1.SetToolTip(Me.GramsOfProtein, "Grams of Protein")
        '
        'GramsOfFat
        '
        Me.GramsOfFat.AutoSize = True
        Me.GramsOfFat.Location = New System.Drawing.Point(18, 28)
        Me.GramsOfFat.Name = "GramsOfFat"
        Me.GramsOfFat.Size = New System.Drawing.Size(67, 13)
        Me.GramsOfFat.TabIndex = 0
        Me.GramsOfFat.Text = "Grams of &Fat"
        Me.ToolTip1.SetToolTip(Me.GramsOfFat, "Grams of Fat")
        '
        'GramsOfCarbsLabel
        '
        Me.GramsOfCarbsLabel.AutoSize = True
        Me.GramsOfCarbsLabel.Location = New System.Drawing.Point(18, 95)
        Me.GramsOfCarbsLabel.Name = "GramsOfCarbsLabel"
        Me.GramsOfCarbsLabel.Size = New System.Drawing.Size(79, 13)
        Me.GramsOfCarbsLabel.TabIndex = 2
        Me.GramsOfCarbsLabel.Text = "Grams of Car&bs"
        Me.ToolTip1.SetToolTip(Me.GramsOfCarbsLabel, "Grams of Carbs")
        '
        'NutritionFactsGroupBox
        '
        Me.NutritionFactsGroupBox.Controls.Add(Me.ItemTotalTextBox)
        Me.NutritionFactsGroupBox.Controls.Add(Me.TotalCaloriesTextBox)
        Me.NutritionFactsGroupBox.Controls.Add(Me.CurrentCaloriesTextBox)
        Me.NutritionFactsGroupBox.Controls.Add(Me.ItemTotalLabel)
        Me.NutritionFactsGroupBox.Controls.Add(Me.TotalCaloriesLabel)
        Me.NutritionFactsGroupBox.Controls.Add(Me.CurrentCaloriesLabel)
        Me.NutritionFactsGroupBox.Location = New System.Drawing.Point(255, 54)
        Me.NutritionFactsGroupBox.Name = "NutritionFactsGroupBox"
        Me.NutritionFactsGroupBox.Size = New System.Drawing.Size(228, 232)
        Me.NutritionFactsGroupBox.TabIndex = 2
        Me.NutritionFactsGroupBox.TabStop = False
        Me.NutritionFactsGroupBox.Text = "Nutrition Facts"
        Me.ToolTip1.SetToolTip(Me.NutritionFactsGroupBox, "Nutrition Facts")
        '
        'ItemTotalTextBox
        '
        Me.ItemTotalTextBox.Location = New System.Drawing.Point(40, 189)
        Me.ItemTotalTextBox.Name = "ItemTotalTextBox"
        Me.ItemTotalTextBox.ReadOnly = True
        Me.ItemTotalTextBox.Size = New System.Drawing.Size(166, 20)
        Me.ItemTotalTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.ItemTotalTextBox, "Total Items Calculated")
        '
        'TotalCaloriesTextBox
        '
        Me.TotalCaloriesTextBox.Location = New System.Drawing.Point(40, 121)
        Me.TotalCaloriesTextBox.Name = "TotalCaloriesTextBox"
        Me.TotalCaloriesTextBox.ReadOnly = True
        Me.TotalCaloriesTextBox.Size = New System.Drawing.Size(166, 20)
        Me.TotalCaloriesTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.TotalCaloriesTextBox, "Total Calories")
        '
        'CurrentCaloriesTextBox
        '
        Me.CurrentCaloriesTextBox.Location = New System.Drawing.Point(40, 54)
        Me.CurrentCaloriesTextBox.Name = "CurrentCaloriesTextBox"
        Me.CurrentCaloriesTextBox.ReadOnly = True
        Me.CurrentCaloriesTextBox.Size = New System.Drawing.Size(166, 20)
        Me.CurrentCaloriesTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.CurrentCaloriesTextBox, "Calories in Current Item")
        '
        'ItemTotalLabel
        '
        Me.ItemTotalLabel.AutoSize = True
        Me.ItemTotalLabel.Location = New System.Drawing.Point(25, 163)
        Me.ItemTotalLabel.Name = "ItemTotalLabel"
        Me.ItemTotalLabel.Size = New System.Drawing.Size(54, 13)
        Me.ItemTotalLabel.TabIndex = 4
        Me.ItemTotalLabel.Text = "Item Total"
        Me.ToolTip1.SetToolTip(Me.ItemTotalLabel, "Item Total")
        '
        'TotalCaloriesLabel
        '
        Me.TotalCaloriesLabel.AutoSize = True
        Me.TotalCaloriesLabel.Location = New System.Drawing.Point(25, 95)
        Me.TotalCaloriesLabel.Name = "TotalCaloriesLabel"
        Me.TotalCaloriesLabel.Size = New System.Drawing.Size(71, 13)
        Me.TotalCaloriesLabel.TabIndex = 2
        Me.TotalCaloriesLabel.Text = "Total Calories"
        Me.ToolTip1.SetToolTip(Me.TotalCaloriesLabel, "Total Calories")
        '
        'CurrentCaloriesLabel
        '
        Me.CurrentCaloriesLabel.AutoSize = True
        Me.CurrentCaloriesLabel.Location = New System.Drawing.Point(25, 28)
        Me.CurrentCaloriesLabel.Name = "CurrentCaloriesLabel"
        Me.CurrentCaloriesLabel.Size = New System.Drawing.Size(81, 13)
        Me.CurrentCaloriesLabel.TabIndex = 0
        Me.CurrentCaloriesLabel.Text = "Current Calories"
        Me.ToolTip1.SetToolTip(Me.CurrentCaloriesLabel, "Current Calories")
        '
        'CalculateButton
        '
        Me.CalculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateButton.Location = New System.Drawing.Point(13, 298)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(106, 30)
        Me.CalculateButton.TabIndex = 3
        Me.CalculateButton.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Calculate")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(134, 298)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(106, 30)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clea&r"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(255, 298)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(106, 30)
        Me.PrintButton.TabIndex = 5
        Me.PrintButton.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "Print")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(377, 298)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(106, 30)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exit")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'NutritionFacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(495, 341)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.NutritionFactsGroupBox)
        Me.Controls.Add(Me.EnterNutritionInfoGroupBox)
        Me.Controls.Add(Me.NutritionFactsLabel)
        Me.Name = "NutritionFacts"
        Me.Text = "Nutrition Facts"
        Me.EnterNutritionInfoGroupBox.ResumeLayout(False)
        Me.EnterNutritionInfoGroupBox.PerformLayout()
        Me.NutritionFactsGroupBox.ResumeLayout(False)
        Me.NutritionFactsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents NutritionFactsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents EnterNutritionInfoGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GramsOfProtein As System.Windows.Forms.Label
    Friend WithEvents GramsOfFat As System.Windows.Forms.Label
    Friend WithEvents GramsOfCarbsLabel As System.Windows.Forms.Label
    Friend WithEvents NutritionFactsLabel As System.Windows.Forms.Label
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ItemTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCaloriesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CurrentCaloriesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemTotalLabel As System.Windows.Forms.Label
    Friend WithEvents TotalCaloriesLabel As System.Windows.Forms.Label
    Friend WithEvents CurrentCaloriesLabel As System.Windows.Forms.Label
    Friend WithEvents GramsOfProteinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GramsOfCarbsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GramsOfFatTextBox As System.Windows.Forms.TextBox

End Class
