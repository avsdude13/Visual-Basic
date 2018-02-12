' Program: Proverbs
' Programmer: Matt Kline
' Class: Intro to Visual Basics
' Homework 1 Problem 1.3
Public Class Proverbs

    Private Sub Proverb1Button_Click(sender As Object, e As EventArgs) Handles Proverb1Button.Click
        MessageLabel.Text = "A penny saved is a penny earned" 'This displays the first proverb after the button is pressed
    End Sub

    Private Sub Proverb2Button_Click(sender As Object, e As EventArgs) Handles Proverb2Button.Click
        MessageLabel.Text = "Treat others as you would like to be treated" 'This displays the second proverb after the button is pressed
    End Sub

    Private Sub Proverb3Button_Click(sender As Object, e As EventArgs) Handles Proverb3Button.Click
        MessageLabel.Text = "The early bird gets the worm" 'This displays the third proverb after the button is pressed
    End Sub

    Private Sub Proverb4Button_Click(sender As Object, e As EventArgs) Handles Proverb4Button.Click
        MessageLabel.Text = "Do to others as they would have do onto you" 'This displays the fourth proverb after the button is pressed
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close() 'This exits the program after the button is pressed
    End Sub
End Class
