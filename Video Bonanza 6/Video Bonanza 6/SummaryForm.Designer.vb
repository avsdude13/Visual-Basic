<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.TotalAmountTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.TotalAmountLabel = New System.Windows.Forms.Label()
        Me.SubTotalLabel = New System.Windows.Forms.Label()
        Me.SummaryLabel = New System.Windows.Forms.Label()
        Me.TaxTotalLabel = New System.Windows.Forms.Label()
        Me.TaxTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TotalAmountTextBox
        '
        Me.TotalAmountTextBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TotalAmountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmountTextBox.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TotalAmountTextBox.Location = New System.Drawing.Point(50, 188)
        Me.TotalAmountTextBox.Name = "TotalAmountTextBox"
        Me.TotalAmountTextBox.ReadOnly = True
        Me.TotalAmountTextBox.Size = New System.Drawing.Size(196, 26)
        Me.TotalAmountTextBox.TabIndex = 15
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SubTotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotalTextBox.ForeColor = System.Drawing.SystemColors.InfoText
        Me.SubTotalTextBox.Location = New System.Drawing.Point(50, 84)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.ReadOnly = True
        Me.SubTotalTextBox.Size = New System.Drawing.Size(196, 26)
        Me.SubTotalTextBox.TabIndex = 17
        '
        'TotalAmountLabel
        '
        Me.TotalAmountLabel.AutoSize = True
        Me.TotalAmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmountLabel.Location = New System.Drawing.Point(24, 165)
        Me.TotalAmountLabel.Name = "TotalAmountLabel"
        Me.TotalAmountLabel.Size = New System.Drawing.Size(104, 20)
        Me.TotalAmountLabel.TabIndex = 18
        Me.TotalAmountLabel.Text = "Total Amount"
        '
        'SubTotalLabel
        '
        Me.SubTotalLabel.AutoSize = True
        Me.SubTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotalLabel.Location = New System.Drawing.Point(24, 61)
        Me.SubTotalLabel.Name = "SubTotalLabel"
        Me.SubTotalLabel.Size = New System.Drawing.Size(69, 20)
        Me.SubTotalLabel.TabIndex = 19
        Me.SubTotalLabel.Text = "Subtotal"
        '
        'SummaryLabel
        '
        Me.SummaryLabel.AutoSize = True
        Me.SummaryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SummaryLabel.Location = New System.Drawing.Point(144, 9)
        Me.SummaryLabel.Name = "SummaryLabel"
        Me.SummaryLabel.Size = New System.Drawing.Size(102, 25)
        Me.SummaryLabel.TabIndex = 20
        Me.SummaryLabel.Text = "Summary"
        '
        'TaxTotalLabel
        '
        Me.TaxTotalLabel.AutoSize = True
        Me.TaxTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaxTotalLabel.Location = New System.Drawing.Point(24, 113)
        Me.TaxTotalLabel.Name = "TaxTotalLabel"
        Me.TaxTotalLabel.Size = New System.Drawing.Size(34, 20)
        Me.TaxTotalLabel.TabIndex = 21
        Me.TaxTotalLabel.Text = "Tax"
        '
        'TaxTextBox
        '
        Me.TaxTextBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaxTextBox.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TaxTextBox.Location = New System.Drawing.Point(50, 136)
        Me.TaxTextBox.Name = "TaxTextBox"
        Me.TaxTextBox.ReadOnly = True
        Me.TaxTextBox.Size = New System.Drawing.Size(196, 26)
        Me.TaxTextBox.TabIndex = 22
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 235)
        Me.Controls.Add(Me.TaxTextBox)
        Me.Controls.Add(Me.TaxTotalLabel)
        Me.Controls.Add(Me.SummaryLabel)
        Me.Controls.Add(Me.SubTotalLabel)
        Me.Controls.Add(Me.TotalAmountLabel)
        Me.Controls.Add(Me.SubTotalTextBox)
        Me.Controls.Add(Me.TotalAmountTextBox)
        Me.Name = "SummaryForm"
        Me.Text = "Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TotalAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalAmountLabel As System.Windows.Forms.Label
    Friend WithEvents SubTotalLabel As System.Windows.Forms.Label
    Friend WithEvents SummaryLabel As System.Windows.Forms.Label
    Friend WithEvents TaxTotalLabel As System.Windows.Forms.Label
    Friend WithEvents TaxTextBox As System.Windows.Forms.TextBox
End Class
