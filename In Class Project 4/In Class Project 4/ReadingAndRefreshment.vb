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

    Private Sub CalculateSelectionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateSelectionButton.Click
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
                TaxDecimal = SubTotalDecimal * TAX_RATE_Decimal
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
            NewOrderButton.Enabled = True

        Catch QuanityException As Exception
            MessageBox.Show("Quanity must be numeric.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            With QuantityTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub

    Private Sub ClearForNextItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearForNextItemButton.Click
        CappuccinoRadioButton.Checked = True
        ItemAmountTextBox.Clear()
        With QuantityTextBox
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub NewOrderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOrderButton.Click
        Dim ReturnDialogResult As DialogResult
        Dim MessageString As String

        MessageString = "Clear the current order figures?"
        ReturnDialogResult = MessageBox.Show(MessageString, "Clear Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If ReturnDialogResult = Windows.Forms.DialogResult.Yes Then
            ClearButton_Click(sender, e)
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
            NewOrderButton.Enabled = False
        End If
    End Sub

    Private Sub SummaryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryButton.Click

    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
