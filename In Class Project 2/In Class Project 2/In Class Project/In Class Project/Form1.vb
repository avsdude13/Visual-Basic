' Programmer: Matt Kline
' Program: Reading and Refreshment Login
' Project: Hands on Number 2
' Date: 2/11/16

Public Class ReadingAndRefreshmentLogin

    Private Sub BooksButton_CheckedChanged(sender As Object, e As EventArgs) Handles BooksButton.CheckedChanged
        ImagesBox.Image = My.Resources.Books
        PromotionTextBox.Text = "Buy two, get the second one for half price."
    End Sub

    Private Sub MusicButton_CheckedChanged(sender As Object, e As EventArgs) Handles MusicButton.CheckedChanged
        ImagesBox.Image = My.Resources.Music
        PromotionTextBox.Text = "Get a free MP3 download With purchase of a CD."
    End Sub

    Private Sub PeriodicalsButton_CheckedChanged(sender As Object, e As EventArgs) Handles PeriodicalsButton.CheckedChanged
        ImagesBox.Image = My.Resources.Periodicals
        PromotionTextBox.Text = "Elite members receive 10' off every purchase."
    End Sub

    Private Sub CoffeeBarButton_CheckedChanged(sender As Object, e As EventArgs) Handles CoffeeBarButton.CheckedChanged
        ImagesBox.Image = My.Resources.Coffee
        PromotionTextBox.Text = "Celebrate the season with 20% off specialty drinks."
    End Sub

    Private Sub ImageVisableCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ImageVisableCheckBox.CheckedChanged
        ImagesBox.Visible = ImageVisableCheckBox.Checked
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        LoginGroup.Visible = False
        LoginButton.Enabled = True
        DepartmentsGroup.Enabled = True
        PromotionTextBox.Visible = True
        ImageVisableCheckBox.Visible = True
        WelcomeRichTextBox.Visible = True

        WelcomeRichTextBox.Text = "Welcome Member" & Environment.NewLine & UsernameTextbox.Text & Environment.NewLine & UserIDTextbox.Text
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
