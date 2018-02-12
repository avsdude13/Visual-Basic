' Program: Homework 3 Problem 2.1
' Programmer: Matt Kline
' Class: Intro to Visual Basics

Public Class LightBulb
    Private Sub RedButton_CheckedChanged(sender As Object, e As EventArgs) Handles RedButton.CheckedChanged
        ColoredNameTextBox.ForeColor = Color.Red()
        ColoredNameTextBox.Text = "Welcome " & NameDialogueBox.Text
    End Sub

    Private Sub BlueButton_CheckedChanged(sender As Object, e As EventArgs) Handles BlueButton.CheckedChanged
        ColoredNameTextBox.ForeColor = Color.Blue
        ColoredNameTextBox.Text = "Welcome " & NameDialogueBox.Text
    End Sub

    Private Sub GreenButton_CheckedChanged(sender As Object, e As EventArgs) Handles GreenButton.CheckedChanged
        ColoredNameTextBox.ForeColor = Color.Green
        ColoredNameTextBox.Text = "Welcome " & NameDialogueBox.Text
    End Sub

    Private Sub PurpleButton_CheckedChanged(sender As Object, e As EventArgs) Handles PurpleButton.CheckedChanged
        ColoredNameTextBox.ForeColor = Color.Purple
        ColoredNameTextBox.Text = "Welcome " & NameDialogueBox.Text
    End Sub

    Private Sub OrangeButton_CheckedChanged(sender As Object, e As EventArgs) Handles OrangeButton.CheckedChanged
        ColoredNameTextBox.ForeColor = Color.Orange
        ColoredNameTextBox.Text = "Welcome " & NameDialogueBox.Text
    End Sub

    Private Sub YellowButton_CheckedChanged(sender As Object, e As EventArgs) Handles YellowButton.CheckedChanged
        ColoredNameTextBox.ForeColor = Color.Yellow
        ColoredNameTextBox.Text = "Welcome " & NameDialogueBox.Text
    End Sub

    Private Sub LightOffPicture_Click(sender As Object, e As EventArgs) Handles LightOffPicture.Click
        LightOnPicture.Visible = True
        LightOffPicture.Visible = False
    End Sub

    Private Sub LightOnPicture_Click(sender As Object, e As EventArgs) Handles LightOffPicture.Click
        LightOffPicture.Visible = True
        LightOnPicture.Visible = False
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
