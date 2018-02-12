'Programmer: Matt Kline
'Program: Reading and Refreshment Chapter 4
'Date: 2/25/16

Public Class ReadingAndRefreshment
    'Variables
    Const TAX_RATE_Decimal As Decimal = 0.08D
    Const CAPPUCCINO_PRICE_Decimal As Decimal = 2D
    Const ESPRESSO_PRICE_Decimal As Decimal = 2.25D
    Const LATTE_PRICE_Decimal As Decimal = 1.75D
    Const ICED_PRICE_Decimal As Decimal = 2.5D
    Private SubTotalDecimal, CalculatedTaxDecimal, TotalDecimal, GrandTotalDecimal As Decimal
    Private CustomerCount As Integer

    Private Sub CalculateSelectionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateSelectionButton.Click, CalculateSelectionToolStripMenuItem.Click
        Dim PriceDecimal, TaxDecimal, ItemAmountDecimal As Decimal
        Dim QuanityInteger As Integer

        'Determine Coffee Selection
        If CappuccinoRadioButton.Checked Then
            PriceDecimal = CAPPUCCINO_PRICE_Decimal
        ElseIf EspressoRadioButton.Checked Then
            PriceDecimal = ESPRESSO_PRICE_Decimal
        ElseIf LatteRadioButton.Checked Then
            PriceDecimal = LATTE_PRICE_Decimal
        ElseIf IcedCappuccinoRadioButton.Checked Or IcedLatteRadioButton.Checked Then
            PriceDecimal = ICED_PRICE_Decimal
        End If

        'Calculate Price
        Try
            QuanityInteger = Integer.Parse(QuantityTextBox.Text)
            ItemAmountDecimal = PriceDecimal * QuanityInteger
            SubTotalDecimal += ItemAmountDecimal

            'Check Takeout CheckBox
            If TakeoutCheckBox.Checked Then
                TaxDecimal = FindTax(SubTotalDecimal)
            Else
                TaxDecimal = 0
            End If

            'Calculations and Output
            TotalDecimal = SubTotalDecimal + TaxDecimal
            ItemAmountTextBox.Text = ItemAmountDecimal.ToString("C")
            SubTotalTextBox.Text = SubTotalDecimal.ToString("C")
            TaxTextBox.Text = TaxDecimal.ToString("C")
            TotalDueTextBox.Text = TotalDecimal.ToString("C")

            TakeoutCheckBox.Enabled = False

            ClearForNextItemButton.Enabled = True

        Catch QuanityException As Exception
            MessageBox.Show("Quanity must be numeric.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            With QuantityTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub

    Private Function FindTax(ByVal AmountDecimal As Decimal) As Decimal
        Return AmountDecimal * TAX_RATE_Decimal
    End Function

    Private Sub ClearForNextItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearForNextItemButton.Click, ClearItemToolStripMenuItem.Click
        CappuccinoRadioButton.Checked = True
        ItemAmountTextBox.Clear()
        With QuantityTextBox
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub NewOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOrderToolStripMenuItem.Click
        Dim ReturnDialogResult As DialogResult
        Dim MessageString As String

        MessageString = "Clear the current order figures?"
        ReturnDialogResult = MessageBox.Show(MessageString, "Clear Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If ReturnDialogResult = Windows.Forms.DialogResult.Yes Then
            ClearForNextItemButton_Click(sender, e)
            SubTotalTextBox.Clear()
            TaxTextBox.Clear()
            TotalDueTextBox.Clear()

            If SubTotalDecimal <> 0 Then
                GrandTotalDecimal += TotalDecimal
                CustomerCount += 1
                SubTotalDecimal = 0
                TotalDecimal = 0
            End If

            With TakeoutCheckBox
                .Enabled = True
                .Checked = False
            End With
            ClearForNextItemButton.Enabled = False
        End If
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        Dim AverageDecimal As Decimal
        Dim MessageString As String

        If TotalDecimal <> 0 Then
            NewOrderToolStripMenuItem_Click(sender, e)
        End If

        If CustomerCount > 0 Then
            AverageDecimal = GrandTotalDecimal / CustomerCount

            MessageString = "Number of Orders: " &
                "Total Sales: " & GrandTotalDecimal.ToString("C") &
                Environment.NewLine & Environment.NewLine &
                "Average Sale: " & AverageDecimal.ToString("C")
            MessageBox.Show(MessageString, "Coffee Sales Summary",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageString = "No sales data to summarize."
            MessageBox.Show(MessageString, "Coffee Sales Summary",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim MessageString As String

        MessageString = "Reading and Refreshment Billing" & Environment.NewLine &
            Environment.NewLine & "Programmed by Matt Kline"
        MessageBox.Show(MessageString, "About Reading and Refreshment Billing", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        With FontDialog1
            .Font = SubTotalTextBox.Font
            .ShowDialog()
            SubTotalTextBox.Font = .Font
            TaxTextBox.Font = .Font
            TotalDueTextBox.Font = .Font
        End With
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        With ColorDialog1
            .Color = SubTotalTextBox.ForeColor
            .ShowDialog()
            SubTotalTextBox.ForeColor = .Color
            TaxTextBox.ForeColor = .Color
            TotalDueTextBox.ForeColor = .Color
        End With
    End Sub
End Class
