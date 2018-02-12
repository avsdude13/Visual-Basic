'Programmer: Matt Kline
'Program: Homework 6 Problem 5.3
'Date: 3/8/16

Public Class SalesCalculator
    Private TotalSalesDecimal, TotalCommisionDecimal, TotalPayDecimal As Decimal

    Private Sub PayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayToolStripMenuItem.Click
        Dim SalesName1, SalesName2, SalesName3, SalesName4 As String
        Dim Sales1Decimal, Sales2Decimal, Sales3Decimal, Sales4Decimal As Decimal

        'Receiving Inputs
        If InputName1.Text <> "" Then
            Try
                SalesName1 = InputName1.Text
            Catch InvalidInput As Exception
                MessageBox.Show("Please enter a Sales name.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With InputName1
                    .Focus()
                    .SelectAll()
                End With
            End Try
        End If

        If InputName2.Text <> "" Then
            Try
                SalesName2 = InputName2.Text
            Catch InvalidInput As Exception
                MessageBox.Show("Please enter a Sales name.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With InputName2
                    .Focus()
                    .SelectAll()
                End With
            End Try
        End If

        If InputName3.Text <> "" Then
            Try
                SalesName3 = InputName3.Text
            Catch InvalidInput As Exception
                MessageBox.Show("Please enter a Sales name.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With InputName3
                    .Focus()
                    .SelectAll()
                End With
            End Try
        End If

        If InputName4.Text <> "" Then
            Try
                SalesName4 = InputName4.Text
            Catch InvalidInput As Exception
                MessageBox.Show("Please enter a Sales name.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With InputName4
                    .Focus()
                    .SelectAll()
                End With
            End Try
        End If

        If InputSales1.Text <> "" Then
            Try
                Sales1Decimal = Decimal.Parse(InputSales1.Text)
                CalculatePay(Sales1Decimal)
            Catch NonValidNumber As Exception
                MessageBox.Show("Sales must be numberic.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With InputSales1
                    .Focus()
                    .SelectAll()
                End With
            End Try
        End If

        If InputSales2.Text <> "" Then
            Try
                Sales2Decimal = Decimal.Parse(InputSales2.Text)
                CalculatePay(Sales2Decimal)
            Catch NonValidNumber As Exception
                MessageBox.Show("Sales must be numberic.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With InputSales1
                    .Focus()
                    .SelectAll()
                End With
            End Try
        End If

        If InputSales3.Text <> "" Then
            Try
                Sales3Decimal = Decimal.Parse(InputSales3.Text)
                CalculatePay(Sales3Decimal)
            Catch NonValidNumber As Exception
                MessageBox.Show("Sales must be numberic.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With InputName3
                    .Focus()
                    .SelectAll()
                End With
            End Try
        End If

        If InputSales4.Text <> "" Then
            Try
                Sales4Decimal = Decimal.Parse(InputSales4.Text)
                CalculatePay(Sales4Decimal)
            Catch NonValidNumber As Exception
                MessageBox.Show("Sales must be numberic.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With InputName4
                    .Focus()
                    .SelectAll()
                End With
            End Try
        End If

        'Output
        SalesTotalTextbox.Text = TotalSalesDecimal.ToString("C")
        CommissionTotalTextbox.Text = TotalCommisionDecimal.ToString("C")
        PayTotalTextbox.Text = TotalPayDecimal.ToString("C")
    End Sub

    Private Function CalculatePay(Sales As Decimal) As Decimal
        Const COMMISION_RATE_Decimal As Decimal = 0.15D
        Const BASE_PAY_Decimal As Decimal = 250D
        Const QUOTA_Decimal As Decimal = 1000D
        Dim CalculatedPay As Decimal
        Dim Commision As Decimal

        If Sales >= QUOTA_Decimal Then
            Commision = Sales * COMMISION_RATE_Decimal
        Else : Commision = 0
        End If

        CalculatedPay = BASE_PAY_Decimal + Commision
        TotalSalesDecimal += Sales
        TotalCommisionDecimal += Commision
        TotalPayDecimal += CalculatedPay

        Return CalculatedPay
    End Function

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        Dim MessageString As String
        MessageString = "Sales Summary:" + Environment.NewLine +
                        "     Sales: " + TotalSalesDecimal.ToString("C") + Environment.NewLine +
                        "     Commision: " + TotalCommisionDecimal.ToString("C") + Environment.NewLine +
                        "     Pay: " + TotalPayDecimal.ToString("C")
        MessageBox.Show(MessageString, "Sales Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ClearToolStripMenuItem_Click(sender, e)

        With InputName1
            .Focus()
        End With
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        InputName1.Clear()
        InputName2.Clear()
        InputName3.Clear()
        InputName4.Clear()
        InputSales1.Clear()
        InputSales2.Clear()
        InputSales3.Clear()
        InputSales4.Clear()

        SalesTotalTextbox.Clear()
        CommissionTotalTextbox.Clear()
        PayTotalTextbox.Clear()
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        With FontDialog1
            .Font = SalesTotalTextbox.Font
            .ShowDialog()
            CommissionTotalTextbox.Font = .Font
            PayTotalTextbox.Font = .Font
        End With
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        With ColorDialog1
            .Color = SalesTotalTextbox.ForeColor
            .ShowDialog()
            CommissionTotalTextbox.ForeColor = .Color
            PayTotalTextbox.ForeColor = .Color
        End With
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim MessageString As String

        MessageString = "Sales Calculator" & Environment.NewLine & Environment.NewLine & "Programmed By: Matt Kline"

        MessageBox.Show(MessageString, "About Reading and Refreshment Billing", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
