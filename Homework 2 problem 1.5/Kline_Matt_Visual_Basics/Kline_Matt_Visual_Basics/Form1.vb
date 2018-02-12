' Program: My Fake Company
' Programmer: Matt Kline
' Class: Intro to Visual Basics
' Homework 1 Problem 1.3
Public Class CompanyInfo

    Private Sub SoupOfTheDayButton_Click(sender As Object, e As EventArgs) Handles SoupOfTheDayButton.Click
        MessageLabel.Text = "The Soup of the Day is Cream of Chicken with Roasted Carrots" 'This displays the Soup of the Day after the button is pressed
    End Sub

    Private Sub SpecialButton_Click(sender As Object, e As EventArgs) Handles SpecialButton.Click
        MessageLabel.Text = "The Chef's Special today is the Grilled Veggy Burger" 'This displays the Chef's Special after the button is pressed
    End Sub

    Private Sub DailyFishButton_Click(sender As Object, e As EventArgs) Handles DailyFishButton.Click
        MessageLabel.Text = "The Fish of the Day is the Rainbow Cod" 'This displays Fish of the day info after the button is pressed
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close() 'This exits the program after the button is pressed
    End Sub
End Class
