Public Class WeatherReport

    Private Sub SunnyButton_CheckedChanged(sender As Object, e As EventArgs) Handles SunnyButton.CheckedChanged
        MessageTextBox.Text = "The weather is looking Sunny today, " & EnterTextBox.Text
        MessageTextBox.Visible = True
        SunnyPicBox.Visible = True
        SnowyPicBox.Visible = False
        RainyPicBox.Visible = False
        CloudyPicBox.Visible = False
    End Sub

    Private Sub SnowyButton_CheckedChanged(sender As Object, e As EventArgs) Handles SnowyButton.CheckedChanged
        MessageTextBox.Text = "The weather is looking Snowy today, " & EnterTextBox.Text
        MessageTextBox.Visible = True
        SunnyPicBox.Visible = False
        SnowyPicBox.Visible = True
        RainyPicBox.Visible = False
        CloudyPicBox.Visible = False
    End Sub

    Private Sub RainyButton_CheckedChanged(sender As Object, e As EventArgs) Handles RainyButton.CheckedChanged
        MessageTextBox.Text = "The weather is looking Rainy today, " & EnterTextBox.Text
        MessageTextBox.Visible = True
        SunnyPicBox.Visible = False
        SnowyPicBox.Visible = False
        RainyPicBox.Visible = True
        CloudyPicBox.Visible = False
    End Sub

    Private Sub CloudyButton_CheckedChanged(sender As Object, e As EventArgs) Handles CloudyButton.CheckedChanged
        MessageTextBox.Text = "The weather is looking Cloudy today, " & EnterTextBox.Text
        MessageTextBox.Visible = True
        SunnyPicBox.Visible = False
        SnowyPicBox.Visible = False
        RainyPicBox.Visible = False
        CloudyPicBox.Visible = True
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
