'Program: Homework 7 Problem 6.2
'Programmer: Matt Kline
'Date: March 15, 2016

Public Class Job_Information

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        JobNumberTextBox.Clear()
        CustomerNameTextBox.Clear()
        PatrsTotalTextBox.Clear()
        HoursOfLaborTextBox.Clear()
        PartsTextBox.Clear()
        LaborTextBox.Clear()
        SubtotalTextBox.Clear()
        SalesTaxTextBox.Clear()
        HoursOfLaborTextBox.Clear()

        With JobNumberTextBox
            .Focus()
        End With
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub
End Class