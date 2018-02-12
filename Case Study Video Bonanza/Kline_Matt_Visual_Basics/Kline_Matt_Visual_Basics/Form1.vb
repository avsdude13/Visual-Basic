' Program: Video Bonanza
' Programmer: Matt Kline
' Class: Intro to Visual Basics
' Case Study Video Bonanza
Public Class VideoBonanza

    Private Sub ComedyButton_Click(sender As Object, e As EventArgs) Handles ComedyButton.Click
        LocationLabel.Text = "  The Comedy films are "
        LocationLabel2.Text = "        located in aisle 1"
    End Sub

    Private Sub DramaButton_Click(sender As Object, e As EventArgs) Handles DramaButton.Click
        LocationLabel.Text = "    The Drama films are "
        LocationLabel2.Text = "        located in aisle 1"
    End Sub

    Private Sub ActionButton_Click(sender As Object, e As EventArgs) Handles ActionButton.Click
        LocationLabel.Text = "     The Action films are "
        LocationLabel2.Text = "        located in aisle 1"
    End Sub

    Private Sub SciFiButton_Click(sender As Object, e As EventArgs) Handles SciFiButton.Click
        LocationLabel.Text = "     The Sci-Fi films are "
        LocationLabel2.Text = "        located in aisle 1"
    End Sub

    Private Sub HorrorButton_Click(sender As Object, e As EventArgs) Handles HorrorButton.Click
        LocationLabel.Text = "     The Horror films are "
        LocationLabel2.Text = "        located in aisle 1"
    End Sub

    Private Sub NewReleasesButton_Click(sender As Object, e As EventArgs) Handles NewReleasesButton.Click
        LocationLabel.Text = "The Newly Released films are "
        LocationLabel2.Text = " located against the back wall"
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close() 'This exits the program after the button is pressed
    End Sub
End Class
