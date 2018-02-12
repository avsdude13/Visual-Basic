'Program: Homework 7 Problem 6.2
'Programmer: Matt Kline
'Date: March 15, 2016

Public Class Job_Information
    Const TAX_RATE_Decimal = 0.08
    Const HOURLY_LABOR_Decimal = 50

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        'Variables
        Dim JobNumberInteger As Integer
        Dim PartsTotalDecimal, HoursTotalDecimal, SalesTaxTotalDecimal, SubtotalDecimal, TotalBalanceDueDecimal As Decimal
        Dim CustomerNameString As String

        'Get Input from user
        Try
            JobNumberInteger = Integer.Parse(JobNumberTextBox.Text)
            Try
                PartsTotalDecimal = Decimal.Parse(PartsTotalTextBox.Text)
                Try
                    HoursTotalDecimal = Decimal.Parse(HoursOfLaborTextBox.Text)

                    CustomerNameString = CustomerNameTextBox.Text

                    If CustomerNameString = "" Then
                        MessageBox.Show("Please enter a Customer Name.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        With CustomerNameTextBox
                            .Focus()
                            .SelectAll()
                        End With
                    End If

                Catch NumberFormat As Exception
                    MessageBox.Show("Please enter a Hours as a numeric value.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    With HoursOfLaborTextBox
                        .Focus()
                        .SelectAll()
                    End With
                End Try
            Catch NumberFormat As Exception
                MessageBox.Show("Please enter Parts Total as a numeric value.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With PartsTotalTextBox
                    .Focus()
                    .SelectAll()
                End With
            End Try
        Catch NumberFormat As Exception
            MessageBox.Show("Please enter a Job Number as a numeric value.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With JobNumberTextBox
                .Focus()
                .SelectAll()
            End With
        End Try

        'Calculations
        SubtotalDecimal = (HoursTotalDecimal * HOURLY_LABOR_Decimal) + PartsTotalDecimal
        SalesTaxTotalDecimal = PartsTotalDecimal * TAX_RATE_Decimal
        TotalBalanceDueDecimal = SubtotalDecimal + SalesTaxTotalDecimal

        'Output
        PartsTextBox.Text = PartsTotalDecimal.ToString("C")
        LaborTextBox.Text = HoursTotalDecimal.ToString
        SubtotalTextBox.Text = SubtotalDecimal.ToString("C")
        SalesTaxTextBox.Text = SalesTaxTotalDecimal.ToString("C")
        TotalTextBox.Text = TotalBalanceDueDecimal.ToString("C")
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        JobNumberTextBox.Clear()
        CustomerNameTextBox.Clear()
        PartsTotalTextBox.Clear()
        HoursOfLaborTextBox.Clear()
        PartsTextBox.Clear()
        LaborTextBox.Clear()
        SubtotalTextBox.Clear()
        SalesTaxTextBox.Clear()
        HoursOfLaborTextBox.Clear()
        TotalTextBox.Clear()

        With JobNumberTextBox
            .Focus()
        End With
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub
End Class