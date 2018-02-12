' Programmer: Matt Kline
' Program: Reading and Refreshment
' Date: 2/4/16

Public Class ReadingAndRefreshment

    Private Sub BooksButton_Click(sender As Object, e As EventArgs) Handles BooksButton.Click
        CurrentPromotionTextbox.Text = "Buy two, get the second one for half price          "
        PromotionCodeTextbox.Text = "B608"
    End Sub

    Private Sub MusicButton_Click(sender As Object, e As EventArgs) Handles MusicButton.Click
        CurrentPromotionTextbox.Text = "Get a free MP3 download with the purchase of a CD   "
        PromotionCodeTextbox.Text = "M608"
    End Sub

    Private Sub PeriodicalsButton_Click(sender As Object, e As EventArgs) Handles PeriodicalsButton.Click
        CurrentPromotionTextbox.Text = "Elite members receive 10% off every purchase        "
        PromotionCodeTextbox.Text = "P608"
    End Sub

    Private Sub CoffeeBarButton_Click(sender As Object, e As EventArgs) Handles CoffeeBarButton.Click
        CurrentPromotionTextbox.Text = "Celebrate the season with 20% off specialized drinks"
        PromotionCodeTextbox.Text = "C608"
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
