'Programmer: Matt Kline
'Program: Video Bonanza Chapter 4
'Date: 2/28/16

Public Class VideoBonanza
    Const TAX_RATE_Decimal As Decimal = 0.08D
    Const MEMBER_DISCOUNT_Decmial As Decimal = 0.1D
    Const DVD_OLD_PRICE_Decimal As Decimal = 2.5D
    Const DVD_NEW_PRICE_Decimal As Decimal = 3D
    Const VHS_OLD_PRICE_Decimal As Decimal = 1.8D
    Const VHS_NEW_PRICE_Decimal As Decimal = 2D
    Private SubTotalDecimal, CalculatedTaxDecimal, MemberDiscountDecimal, TotalDecimal As Decimal
    Private CustomerCount As Integer

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim PriceDecimal As Decimal
        Dim TitleString As String

        TitleString = TitleTextBox.Text

        'Check type of movie
        If DVDRadioButton.Checked And NewReleaseCheckBox.Checked Then       'Movie is DVD and new
            PriceDecimal = DVD_NEW_PRICE_Decimal
        ElseIf DVDRadioButton.Checked Then      'Movie is just DVD
            PriceDecimal = DVD_OLD_PRICE_Decimal
        ElseIf VHSRadioButton.Checked And NewReleaseCheckBox.Checked Then       'Movie is VHS and new
            PriceDecimal = VHS_NEW_PRICE_Decimal
        ElseIf VHSRadioButton.Checked Then        'Movie is just VHS
            PriceDecimal = VHS_OLD_PRICE_Decimal
        Else
            MessageBox.Show("Please select a video type", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            With TitleTextBox
                .Focus()
            End With
        End If

        'Calculate Price
        If MemberCheckBox.Checked Then
            MemberDiscountDecimal = (MEMBER_DISCOUNT_Decmial * PriceDecimal)        'If customer is a member give 10% discount
        End If
        PriceDecimal -= MemberDiscountDecimal
        SubTotalDecimal += PriceDecimal
        CalculatedTaxDecimal = SubTotalDecimal * TAX_RATE_Decimal
        TotalDecimal = SubTotalDecimal + CalculatedTaxDecimal

        'Check if all variables were entered and output
        If TitleString = "" Then
            MessageBox.Show("Please enter a title", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            With TitleTextBox
                .Focus()
                .SelectAll()
            End With
        Else
            ItemAmountTextBox.Text = PriceDecimal.ToString("C")
            SubTotalTextBox.Text = SubTotalDecimal.ToString("C")
        End If
    End Sub

    Private Sub OrderSummaryButton_Click(sender As Object, e As EventArgs) Handles OrderSummaryButton.Click
        MessageBox.Show("Order Summary:                 " + Environment.NewLine + "     Subtotal: " + SubTotalDecimal.ToString("C") + Environment.NewLine + "     Tax: " + CalculatedTaxDecimal.ToString("C") + Environment.NewLine + "     Total: " + TotalDecimal.ToString("C"))

        CustomerCount += 1

        CalculateButton.Visible = True
        ClearButton.Visible = True
        MemberCheckBox.Checked = False
        ItemAmountTextBox.Clear()
        SubTotalTextBox.Clear()
        SubTotalDecimal = 0
        CalculatedTaxDecimal = 0
        MemberDiscountDecimal = 0
        TotalDecimal = 0
    End Sub

    Private Sub OrderCompleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderCompleteButton.Click
        Dim ReturnDialogResult As DialogResult
        Dim MessageString As String

        MessageString = "Are you sure you are finished?"
        ReturnDialogResult = MessageBox.Show(MessageString, "Complete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If ReturnDialogResult = Windows.Forms.DialogResult.Yes Then
            ClearButton_Click(sender, e)
            CalculateButton.Visible = False
            ClearButton.Visible = False
        End If
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        NewReleaseCheckBox.Checked = False
        TitleTextBox.Clear()
        DVDRadioButton.Checked = False
        VHSRadioButton.Checked = False
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
