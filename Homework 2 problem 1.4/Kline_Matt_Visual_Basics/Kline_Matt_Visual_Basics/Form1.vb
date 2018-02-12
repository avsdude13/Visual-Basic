' Program: My Fake Company
' Programmer: Matt Kline
' Class: Intro to Visual Basics
' Homework 1 Problem 1.3
Public Class CompanyInfo

    Private Sub CompanyInfoButton_Click(sender As Object, e As EventArgs) Handles CompanyInfoButton.Click
        MessageLabel.Text = "My Fake Company 123 Main St Denver CO 80219" 'This displays the company info after the button is pressed
    End Sub

    Private Sub CallUsButton_Click(sender As Object, e As EventArgs) Handles CallUsButton.Click
        MessageLabel.Text = "Reach us between 6am-10pm at 303-123-4567" 'This displays the phone number and contact time after the button is pressed
    End Sub

    Private Sub DepartmentListButton_Click(sender As Object, e As EventArgs) Handles DepartmentListButton.Click
        MessageLabel.Text = "Sales ext 1 Receiving ext 2 Manager ext 3 Operator ext #" 'This displays department info after the button is pressed
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close() 'This exits the program after the button is pressed
    End Sub
End Class
