' Programmer: Matt Kline
' Program: Homework 4 Problem 3.1
' Date 2-22-16

Public Class NutritionFacts
    Private TotalCaloriesInteger, ItemTotalInteger As Integer
    Const FAT_CALORIES_CONSTANT_Decimal As Integer = 8
    Const PROTEIN_CALORIES_CONSTANT_Decimal As Integer = 4
    Const CARBS_CALORIES_CONSTANT_Decimal As Integer = 4

    Private Sub PrintFormButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim CurrentCaloriesInteger, GramsOfFatInteger, GramsOfCarbsInteger, GramsOfProteinInteger As Integer

        Try
            GramsOfFatInteger = Integer.Parse(GramsOfFatTextBox.Text)
            Try
                GramsOfCarbsInteger = Integer.Parse(GramsOfCarbsTextBox.Text)
                Try
                    GramsOfProteinInteger = Integer.Parse(GramsOfProteinTextBox.Text)
                    'Calculations'
                    CurrentCaloriesInteger = GramsOfFatInteger * FAT_CALORIES_CONSTANT_Decimal
                    CurrentCaloriesInteger += GramsOfCarbsInteger * CARBS_CALORIES_CONSTANT_Decimal
                    CurrentCaloriesInteger += GramsOfProteinInteger * PROTEIN_CALORIES_CONSTANT_Decimal

                    TotalCaloriesInteger += CurrentCaloriesInteger

                    ItemTotalInteger += 1

                    'Display Nutrition Facts Summary Output'
                    CurrentCaloriesTextBox.Text = CurrentCaloriesInteger.ToString("N")
                    TotalCaloriesTextBox.Text = TotalCaloriesInteger.ToString("N")
                    ItemTotalTextBox.Text = ItemTotalInteger.ToString("N")

                Catch GramsOfProteinException As FormatException
                    MessageBox.Show("Grams must be numberic.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    With GramsOfProteinTextBox
                        .Focus()
                        .SelectAll()
                    End With
                End Try
            Catch GramsOfCarbsException As FormatException
                MessageBox.Show("Grams must be numberic.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With GramsOfCarbsTextBox
                    .Focus()
                    .SelectAll()
                End With
            End Try
        Catch GramsOfFatException As FormatException
            MessageBox.Show("Grams must be numberic.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With GramsOfFatTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        GramsOfFatTextBox.Text = ""
        GramsOfCarbsTextBox.Text = ""
        GramsOfProteinTextBox.Text = ""
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
