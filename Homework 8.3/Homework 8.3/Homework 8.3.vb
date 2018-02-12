'Programer: Matt Kline
'Program: Ch 8 Hands On
'Date: 4/12/16

Public Class ConcertTickets

    Private SalesTrackerArray(80) As TicketSales
    Private SectionString() As String =
        {"Orchesta", "Mezzanine", "General", "Balcony"}
    Private PriceDecimal() As Decimal =
        {40D, 27.5D, 15D, 10D}
    Private ColumnInteger, QuantityInteger As Integer
    Private SalePriceDecimal, TotalSalePriceDecimal As Decimal
    Private SectionNameString As String
    Private OrchestaCount, MezzanineCount, GeneralCount, BalconyCount, TotalCount As Integer
    Private TicketCountArray() As Integer =
        {OrchestaCount, MezzanineCount, GeneralCount, BalconyCount}

    Structure TicketSales
        Dim SectionString As String
        Dim QuantityInteger As Integer
        Dim PriceDecimal As Decimal
        Dim TotalPrice As Decimal
    End Structure

    Private Sub FindPriceButton_Click(sender As Object, e As EventArgs) Handles FindPriceButton.Click
        ColumnInteger = SeatingListBox.SelectedIndex
        If ColumnInteger <> -1 Then
            SalePriceDecimal = PriceDecimal(ColumnInteger)
            QuantityInteger = Integer.Parse(QuantityTextBox.Text)
            TotalSalePriceDecimal = SalePriceDecimal * QuantityInteger
            SectionNameString = SectionString(ColumnInteger)
        Else
            MessageBox.Show("Select a section.", "Selection Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If (TicketCountArray(ColumnInteger) + QuantityInteger) > 20 Then
            SalesTrackerArray(TotalCount).SectionString = SectionNameString
            SalesTrackerArray(TotalCount).QuantityInteger = QuantityInteger
            SalesTrackerArray(TotalCount).PriceDecimal = SalePriceDecimal
            SalesTrackerArray(TotalCount).TotalPrice = TotalSalePriceDecimal
            PriceTextBox.Text = SalePriceDecimal.ToString("C")
            TotalPriceTextBox.Text = TotalSalePriceDecimal.ToString("C")
            TotalCount += QuantityInteger
        Else
            MessageBox.Show("There are not enough tickets available. Please select a fewer amount.", "Cannot complete purchase", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        QuantityTextBox.Clear()
        SeatingListBox.SelectedIndex = -1
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

        PrintLineString = "Ticket Sales"
        e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, Column2Horizonta1Locationsingle, VerticalPrintLocationSingle)
        PrintLineString = "By Matt Kline"
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, Column2Horizonta1Locationsingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 2

        For Each SectionString As TicketSales In SalesTrackerArray
            If SalesTrackerArray(TotalCount).SectionString <> "" Then
                e.Graphics.DrawString(SalesTrackerArray(TotalCount).SectionString, PrintFont, Brushes.Black, Column1HorizontalLocationSingle, VerticalPrintLocationSingle)
                e.Graphics.DrawString(SalesTrackerArray(TotalCount).QuantityInteger.ToString, PrintFont, Brushes.Black, Column1HorizontalLocationSingle, VerticalPrintLocationSingle)
                FormattedPriceString = FormatNumber(SalesTrackerArray(TotalCount).TotalPrice)
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
End Class
