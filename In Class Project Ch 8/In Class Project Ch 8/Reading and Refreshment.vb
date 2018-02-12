'Programer: Matt Kline
'Program: Ch 8 Hands On
'Date: 4/12/16

Public Class ReadingAndRefreshment

    Structure CoffeeSales
        Dim TypeString As String
        Dim QuantityString As String
        Dim PriceDecimal As Decimal
    End Structure

    Private TransactionCoffeeSales(20) As CoffeeSales
    Private NumberTransactionsInteger As Integer
    Private PriceDecimal(,) As Decimal =
        {{2.6D, 2.9D, 3.25D}, {4.9D, 5.6D, 6.1D}, {8.75D, 9.75D, 11.25D}}
    Private SelectedButtonString As String

    Private Sub FindPriceButton_Click(sender As Object, e As EventArgs) Handles FindPriceButton.Click
        Dim RowInteger, ColumnInteger As Integer
        Dim SalePriceDecimal As Decimal

        If NumberTransactionsInteger < 20 Then
            ColumnInteger = TypeComboBox.SelectedIndex
            If ColumnInteger <> -1 Then
                Select Case SelectedButtonString
                    Case "FullPoundRadioButton"
                        RowInteger = 2
                        TransactionCoffeeSales(NumberTransactionsInteger).QuantityString = "Full Pound"
                    Case "HalfPoundRadioButton"
                        RowInteger = 1
                        TransactionCoffeeSales(NumberTransactionsInteger).QuantityString = "Half Pound"
                    Case Else
                        RowInteger = 0
                        TransactionCoffeeSales(NumberTransactionsInteger).QuantityString = "Quarter Pound"
                End Select

                SalePriceDecimal = PriceDecimal(RowInteger, ColumnInteger)
                PriceTextBox.Text = SalePriceDecimal.ToString("C")
                TransactionCoffeeSales(NumberTransactionsInteger).TypeString = TypeComboBox.Text
                TransactionCoffeeSales(NumberTransactionsInteger).PriceDecimal = SalePriceDecimal
                NumberTransactionsInteger += 1
            Else
                MessageBox.Show("Select the coffee type.", "Selection Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Sorry, only 20 transactions are allowed.")
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        QuarterPoundRadioButton.Checked = False
        HalfPoundRadioButton.Checked = False
        FullPoundRadioButton.Checked = False
        TypeComboBox.SelectedIndex = -1
        PriceTextBox.Clear()
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim Column1HorizontalLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim Column2Horizonta1Locationsingle As Single = 300
        Dim Column3HorizontalLocationSingle As Single
        Dim PrintLineString As String
        Dim FontSizeF As New SizeF
        Dim FormattedPriceString As String

        PrintLineString = "Reading and Refreshment Coffee Sales"
        e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, Column2Horizonta1Locationsingle, VerticalPrintLocationSingle)
        PrintLineString = "By Matt Kline"
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, Column2Horizonta1Locationsingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 2

        For Each IndividualCoffeeSales As CoffeeSales In TransactionCoffeeSales
            If IndividualCoffeeSales.QuantityString <> "" Then
                e.Graphics.DrawString(IndividualCoffeeSales.QuantityString, PrintFont, Brushes.Black, Column1HorizontalLocationSingle, VerticalPrintLocationSingle)
                e.Graphics.DrawString(IndividualCoffeeSales.TypeString, PrintFont, Brushes.Black, Column1HorizontalLocationSingle, VerticalPrintLocationSingle)
                FormattedPriceString = FormatNumber(IndividualCoffeeSales.PriceDecimal)
                FontSizeF = e.Graphics.MeasureString(FormattedPriceString, PrintFont)
                Column3HorizontalLocationSingle = 550 - FontSizeF.Width
                e.Graphics.DrawString(FormattedPriceString, PrintFont, Brushes.Black, Column3HorizontalLocationSingle, VerticalPrintLocationSingle)
                VerticalPrintLocationSingle += LineHeightSingle * 2
            End If
        Next
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim ResponseDialogResult As DialogResult

        ResponseDialogResult = MessageBox.Show("Print the report?", "Terminate the Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ResponseDialogResult = Windows.Forms.DialogResult.Yes Then
            PrintButton_Click(sender, e)
        End If
        Me.Close()
    End Sub

    Private Sub QuarterPoundRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles QuarterPoundRadioButton.CheckedChanged, HalfPoundRadioButton.CheckedChanged, FullPoundRadioButton.CheckedChanged
        SelectedButtonString = CType(sender, RadioButton).Name
    End Sub
End Class
