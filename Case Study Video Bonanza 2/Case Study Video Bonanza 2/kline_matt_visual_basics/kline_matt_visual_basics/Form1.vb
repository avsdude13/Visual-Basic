' Program: Video Bonanza
' Programmer: Matt Kline
' Class: Intro to Visual Basics
' Case Study Video Bonanza 2
Public Class VideoBonanza

    Private Sub ComedyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ComedyRadioButton.CheckedChanged
        AisleLocationTextBox.Text = "The Comedy films are located in aisle 1"
    End Sub

    Private Sub DramaRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DramaRadioButton.CheckedChanged
        AisleLocationTextBox.Text = "The Drama films are located in aisle 2"
    End Sub

    Private Sub ActionRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ActionRadioButton.CheckedChanged
        AisleLocationTextBox.Text = "The Action films are located in aisle 3"
    End Sub

    Private Sub SciFiRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles HorrorRadioButton.CheckedChanged
        AisleLocationTextBox.Text = "The Sci-Fi films are located in aisle 4"
    End Sub

    Private Sub HorrorRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles HorrorRadioButton.CheckedChanged
        AisleLocationTextBox.Text = "The Horror films are located in aisle 5"
    End Sub

    Private Sub MemberCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles MemberCheckBox.CheckedChanged
        MembersLabel.Visible = MemberCheckBox.Checked
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close() 'This exits the program after the button is pressed
    End Sub
End Class
