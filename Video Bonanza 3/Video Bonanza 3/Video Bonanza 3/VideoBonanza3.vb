' Programmer: Matt Kline
' Program: Video Bonanza Chapter 3
' Date 2-22-16

Public Class VideoBonanza
    Private CustomersServedInteger As Integer
    Private IncomeDecimal As Decimal
    Const DISCOUNT_RATE_Decimal As Decimal = 0.1D
    Const MOVIE_PRICE_Decimal As Decimal = 1.8D

    Private Sub PrintFormButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim QuanityInteger, MemberNumberInteger As Integer
        Dim DiscountDecimal, TotalPriceBeforeDiscountDecimal, TotalPriceDecimal As Decimal

        Try
            MemberNumberInteger = Integer.Parse(MemberNumberTextBox.Text)
            Try
                QuanityInteger = Integer.Parse(NumberOfMoviesTextBox.Text)

                'Calculations'
                TotalPriceBeforeDiscountDecimal = QuanityInteger * MOVIE_PRICE_Decimal
                DiscountDecimal = TotalPriceBeforeDiscountDecimal * DISCOUNT_RATE_Decimal
                TotalPriceDecimal = TotalPriceBeforeDiscountDecimal - DiscountDecimal
                CustomersServedInteger += 1
                IncomeDecimal += TotalPriceDecimal

                'Display Order Summary Output'
                PricePerMovieTextBox.Text = MOVIE_PRICE_Decimal.ToString("C")
                DiscountTextBox.Text = DiscountDecimal.ToString("C")
                TotalTextBox.Text = TotalPriceDecimal.ToString("C")

                'Display Company Totals Output'
                CustomersServedTextBox.Text = CustomersServedInteger.ToString("N")
                IncomeTextBox.Text = IncomeDecimal.ToString("C")

            Catch NumberOfMoviesException As FormatException
                MessageBox.Show("Quanity must be numberic.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With NumberOfMoviesTextBox
                    .Focus()
                    .SelectAll()
                End With
            End Try
        Catch MemberNumberException As FormatException
            MessageBox.Show("Member Number must be numberic.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With MemberNumberTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        MemberNumberTextBox.Text = ""
        NumberOfMoviesTextBox.Text = ""
        PricePerMovieTextBox.Text = ""
        DiscountTextBox.Text = ""
        TotalTextBox.Text = ""
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
