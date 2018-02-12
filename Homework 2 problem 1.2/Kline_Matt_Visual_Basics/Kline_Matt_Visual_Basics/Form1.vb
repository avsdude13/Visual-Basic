' Program: Display Greeting
' Programmer: Matt Kline
' Class: Intro to Visual Basics
' Homework 1 Problem 1.2

Public Class Greetings
    Private Sub GreetingButton_Click(sender As Object, e As EventArgs) Handles GreetingButton.Click
        MessageLabel.Text = "Hello from Metropolitan State University of Denver located in Denver Colorado." 'This displays a greeting after the button is pressed
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close() 'This exits the program after the button is pressed
    End Sub
End Class
