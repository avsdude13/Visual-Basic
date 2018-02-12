' Program: Hello World Languages
' Programmer: Matt Kline
' Class: Intro to Visual Basics
' Homework 1 Problem 1.1

Public Class HelloForm

    Private Sub FrenchButton_Click(sender As Object, e As EventArgs) Handles FrenchButton.Click
        MessageLabel.Text = "Bonjour tout le monde" 'This displays Hello World after the button is pressed in French
    End Sub

    Private Sub ItalianButton_Click(sender As Object, e As EventArgs) Handles ItalianButton.Click
        MessageLabel.Text = "Ciao Mondo" 'This displays Hello World after the button is pressed in Italian
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close() 'This exits the program after the button is pressed
    End Sub
End Class
