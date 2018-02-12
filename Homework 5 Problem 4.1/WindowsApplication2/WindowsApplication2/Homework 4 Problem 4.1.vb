'Programmer: Matt Kline
'Program: Homework 5 Problem 4.1
'Date: 3/1/16

Public Class LynetteRifleBeautySalon
    Const TAX_RATE_Decimal As Decimal = 0.08D
    Const MAKEOVER_Decimal As Decimal = 125D
    Const HAIR_STYLING_Decimal As Decimal = 60D
    Const MANICURE_Decimal As Decimal = 35D
    Const PERMENENT_MAKEUP_Decimal As Decimal = 200D
    Private SubTotalDecimal, CalculatedTaxDecimal, MemberDiscountDecimal, CalculatedDiscountDecimal, AfterDiscountSubtotal, TotalDecimal As Decimal
    Private ServicesCount As Integer = 0

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        If MakeoverCheckBox.Checked = True Then
            SubTotalDecimal += MAKEOVER_Decimal
            ServicesCount += 1
        End If

        If HairStylingCheckBox.Checked = True Then
            SubTotalDecimal += HAIR_STYLING_Decimal
            ServicesCount += 1
        End If

        If ManicureCheckBox.Checked = True Then
            SubTotalDecimal += MANICURE_Decimal
            ServicesCount += 1
        End If

        If PermenentMakeupCheckBox.Checked = True Then
            SubTotalDecimal += PERMENENT_MAKEUP_Decimal
            ServicesCount += 1
        End If

        If NoDiscountRadioButton.Checked = True Then
            MemberDiscountDecimal = 0
        ElseIf TenPercentRadioButton.Checked = True Then
            MemberDiscountDecimal = 0.1
        ElseIf TwentyPercentRadioButton.Checked = True Then
            MemberDiscountDecimal = 0.2
        End If

        CalculatedDiscountDecimal = SubTotalDecimal * MemberDiscountDecimal
        AfterDiscountSubtotal = SubTotalDecimal - CalculatedDiscountDecimal
        TotalDecimal = AfterDiscountSubtotal + (AfterDiscountSubtotal * TAX_RATE_Decimal)

        'Output
        ServiceCostTextBox.Text = SubTotalDecimal.ToString("C")
        NumberOfServicesTextBox.Text = ServicesCount.ToString("C")
        SubtotalTextBox.Text = AfterDiscountSubtotal.ToString("C")
        TotalDueTextBox.Text = TotalDecimal.ToString("C")
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ServicesCount = 0
        SubTotalDecimal = 0

        MakeoverCheckBox.Checked = False
        HairStylingCheckBox.Checked = False
        ManicureCheckBox.Checked = False
        PermenentMakeupCheckBox.Checked = False
        NoDiscountRadioButton.Checked = True
        ServiceCostTextBox.Clear()
        NumberOfServicesTextBox.Clear()
        SubtotalTextBox.Clear()
        TotalDueTextBox.Clear()
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
