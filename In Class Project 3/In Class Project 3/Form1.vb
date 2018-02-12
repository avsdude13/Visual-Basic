'Programmer: Matt Kline
'Program: In Class Exercise 3
'Class: Intro to programming: Visual Basics

Public Class ReadingAndRefreshment

    Private QuantitySumInteger, SalesCountInteger As Integer
    Private DiscountSumDecimal, DiscountedPriceSumDecimal As Decimal
    Const DISCOUNT_RATE_Decimal As Decimal = 0.15D

    Private Sub PrintFormButton_Click(sender As Object, e As EventArgs) Handles PrintFormButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim QuanityInteger As Integer
        Dim PriceDecimal, ExtendedPriceDecimal, DiscountDecimal, DiscountedPriceDecimal, AverageDiscountDecimal As Decimal

        Try
            QuanityInteger = Integer.Parse(QuanityTextBox.Text)
            Try
                'Calculations'
                PriceDecimal = Double.Parse(PriceTextBox.Text)
                ExtendedPriceDecimal = QuanityInteger * PriceDecimal
                DiscountDecimal = ExtendedPriceDecimal * DISCOUNT_RATE_Decimal
                DiscountedPriceDecimal = ExtendedPriceDecimal - DiscountDecimal
                QuantitySumInteger += QuanityInteger
                DiscountSumDecimal += DiscountDecimal
                DiscountedPriceSumDecimal += DiscountedPriceDecimal
                SalesCountInteger += 1
                AverageDiscountDecimal = DiscountSumDecimal / SalesCountInteger

                'Display Sales Output'
                ExtendedPriceTextBox.Text = ExtendedPriceDecimal.ToString("C")
                PercentDiscountTextBox.Text = DiscountDecimal.ToString("N")
                DiscountPriceTextBox.Text = DiscountedPriceDecimal.ToString("C")

                'Display Summary Output'
                TotalNumberOfBooksTextBox.Text = SalesCountInteger.ToString()
                TotalDiscountedAmountsTextBox.Text = DiscountedPriceSumDecimal.ToString("C")
                TotalDiscountsGivenTextBox.Text = DiscountSumDecimal.ToString("C")
                AverageDiscountTextBox.Text = AverageDiscountDecimal.ToString("C")

            Catch PriceException As FormatException
                MessageBox.Show("Price must be numberic.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Catch QuanityException As FormatException
            MessageBox.Show("Quanity must be numberic.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With QuanityTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub

    Private Sub ClearSalesButton_Click(sender As Object, e As EventArgs) Handles ClearSalesButton.Click
        QuanityTextBox.Text = ""
        TitleTextBox.Text = ""
        PriceTextBox.Text = ""
        ExtendedPriceTextBox.Text = ""
        PercentDiscountTextBox.Text = ""
        DiscountPriceTextBox.Text = ""
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
