' Program: Homework 8.1
' Programmer: Matt Kline
' Date 4/26

Public Class IncomeSurveyForm

    Private Income(10) As IncomeSurvey
    Private IDNumber, FamilyMemberCount, ColumnInteger As Integer
    Private AnnualIncome As Decimal
    Private validentry As Boolean
    Private TotalCount As Integer = 0
    Private BelowPovertyCount As Integer = 0
    Private AboveAverageCount As Integer = 0
    Const POVERTYLINE As Integer = 12000

    Structure IncomeSurvey
        Dim IDNumberInteger As Integer
        Dim FamilyMemberInteger As Integer
        Dim AnnualIncomeDecimal As Decimal
    End Structure

    Function Clear() As Boolean
        Dim done As Boolean
        IDTextBox.Clear()
        FamilySizeTextBox.Clear()
        IncomeTextBox.Clear()
        With IDTextBox
            .Focus()
        End With
        done = True
        Return done
    End Function

    Private Sub EnterDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterDataToolStripMenuItem.Click
        validentry = True
        Try
            IDNumber = Integer.Parse(IDTextBox.Text)
            Try
                FamilyMemberCount = Integer.Parse(FamilySizeTextBox.Text)
                Try
                    AnnualIncome = Integer.Parse(IncomeTextBox.Text)
                Catch NumberFormat As Exception
                    MessageBox.Show("Enter Income as an integer.", "Selection Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    With IncomeTextBox
                        .Focus()
                        .SelectAll()
                        validentry = False
                    End With
                End Try
            Catch NumberFormat As Exception
                MessageBox.Show("Enter Family Members as an integer.", "Selection Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With FamilySizeTextBox
                    .Focus()
                    .SelectAll()
                    validentry = False
                End With
            End Try
        Catch NumberFormat As Exception
            MessageBox.Show("Enter ID Number as an integer.", "Selection Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With IDTextBox
                .Focus()
                .SelectAll()
                validentry = False
            End With
        End Try

        If validentry Then
            Income(TotalCount).IDNumberInteger = IDNumber
            Income(TotalCount).FamilyMemberInteger = FamilyMemberCount
            Income(TotalCount).AnnualIncomeDecimal = AnnualIncome
            TotalCount += 1
            If AnnualIncome <= POVERTYLINE Then
                BelowPovertyCount += 1
            Else
                AboveAverageCount += 1
            End If
            Clear()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim ResponseDialogResult As DialogResult

        ResponseDialogResult = MessageBox.Show("Print the report?", "Terminate the Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ResponseDialogResult = Windows.Forms.DialogResult.Yes Then
            PrintAllInListToolStripMenuItem_Click(sender, e)
        End If
        Me.Close()
    End Sub

    Private Sub PrintAllInListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintAllInListToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintAll
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintPovertyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPovertyToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintBelowPoverty
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintAboveAverageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintAboveAverageToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintAboveAverage
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintAll_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintAll.PrintPage
        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim Column1HorizontalLocationSingle As Single = 300
        Dim Column2Horizonta1Locationsingle As Single = 365
        Dim Column3Horizonta1Locationsingle As Single = e.MarginBounds.Left
        Dim Column4Horizonta1Locationsingle As Single = 150
        Dim Column5Horizonta1Locationsingle As Single = 300
        Dim Column6Horizonta1Locationsingle As Single = 450

        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim FontSizeF As New SizeF

        e.Graphics.DrawString("Poverty Guidelines for 2008", HeadingFont, Brushes.Black, Column1HorizontalLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString("By Matt Kline", PrintFont, Brushes.Black, Column2Horizonta1Locationsingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 2

        e.Graphics.DrawString("There are " + TotalCount.ToString + " Surveys in the list. The list is as follows", PrintFont, Brushes.Black, Column3Horizonta1Locationsingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle

        For Each IncomeSurveyData As IncomeSurvey In Income
            If IncomeSurveyData.IDNumberInteger > 0 Then
                e.Graphics.DrawString("ID Number: " + IncomeSurveyData.IDNumberInteger.ToString, PrintFont, Brushes.Black, Column4Horizonta1Locationsingle, VerticalPrintLocationSingle)
                e.Graphics.DrawString("Family Size: " + IncomeSurveyData.FamilyMemberInteger.ToString, PrintFont, Brushes.Black, Column5Horizonta1Locationsingle, VerticalPrintLocationSingle)
                e.Graphics.DrawString("Income: $" + FormatNumber(IncomeSurveyData.AnnualIncomeDecimal), PrintFont, Brushes.Black, Column6Horizonta1Locationsingle, VerticalPrintLocationSingle)
                VerticalPrintLocationSingle += LineHeightSingle
            End If
        Next
    End Sub

    Private Sub PrintBelowPoverty_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintBelowPoverty.PrintPage
        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim Column1HorizontalLocationSingle As Single = 300
        Dim Column2Horizonta1Locationsingle As Single = 365
        Dim Column3Horizonta1Locationsingle As Single = e.MarginBounds.Left
        Dim Column4Horizonta1Locationsingle As Single = 150
        Dim Column5Horizonta1Locationsingle As Single = 300
        Dim Column6Horizonta1Locationsingle As Single = 450

        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim FontSizeF As New SizeF

        e.Graphics.DrawString("Poverty Guidelines for 2008", HeadingFont, Brushes.Black, Column1HorizontalLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString("By Matt Kline", PrintFont, Brushes.Black, Column2Horizonta1Locationsingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 2

        e.Graphics.DrawString("There are " + TotalCount.ToString + " Surveys in the list. Of those " + BelowPovertyCount.ToString + " are below the poverty line", PrintFont, Brushes.Black, Column3Horizonta1Locationsingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle

        For Each IncomeSurveyData As IncomeSurvey In Income
            If IncomeSurveyData.IDNumberInteger > 0 And IncomeSurveyData.AnnualIncomeDecimal <= POVERTYLINE Then
                e.Graphics.DrawString("ID Number: " + IncomeSurveyData.IDNumberInteger.ToString, PrintFont, Brushes.Black, Column4Horizonta1Locationsingle, VerticalPrintLocationSingle)
                e.Graphics.DrawString("Family Size: " + IncomeSurveyData.FamilyMemberInteger.ToString, PrintFont, Brushes.Black, Column5Horizonta1Locationsingle, VerticalPrintLocationSingle)
                e.Graphics.DrawString("Income: $" + FormatNumber(IncomeSurveyData.AnnualIncomeDecimal), PrintFont, Brushes.Black, Column6Horizonta1Locationsingle, VerticalPrintLocationSingle)
                VerticalPrintLocationSingle += LineHeightSingle
            End If
        Next
    End Sub

    Private Sub PrintAboveAverage_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintAboveAverage.PrintPage
        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim Column1HorizontalLocationSingle As Single = 300
        Dim Column2Horizonta1Locationsingle As Single = 365
        Dim Column3Horizonta1Locationsingle As Single = e.MarginBounds.Left
        Dim Column4Horizonta1Locationsingle As Single = 150
        Dim Column5Horizonta1Locationsingle As Single = 300
        Dim Column6Horizonta1Locationsingle As Single = 450

        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim FontSizeF As New SizeF

        e.Graphics.DrawString("Poverty Guidelines for 2008", HeadingFont, Brushes.Black, Column1HorizontalLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString("By Matt Kline", PrintFont, Brushes.Black, Column2Horizonta1Locationsingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 2

        e.Graphics.DrawString("There are " + TotalCount.ToString + " Surveys in the list. Of those " + AboveAverageCount.ToString + " are above average income.", PrintFont, Brushes.Black, Column3Horizonta1Locationsingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle

        For Each IncomeSurveyData As IncomeSurvey In Income
            If IncomeSurveyData.IDNumberInteger > 0 And IncomeSurveyData.AnnualIncomeDecimal > POVERTYLINE Then
                e.Graphics.DrawString("ID Number: " + IncomeSurveyData.IDNumberInteger.ToString, PrintFont, Brushes.Black, Column4Horizonta1Locationsingle, VerticalPrintLocationSingle)
                e.Graphics.DrawString("Family Size: " + IncomeSurveyData.FamilyMemberInteger.ToString, PrintFont, Brushes.Black, Column5Horizonta1Locationsingle, VerticalPrintLocationSingle)
                e.Graphics.DrawString("Income: $" + FormatNumber(IncomeSurveyData.AnnualIncomeDecimal), PrintFont, Brushes.Black, Column6Horizonta1Locationsingle, VerticalPrintLocationSingle)
                VerticalPrintLocationSingle += LineHeightSingle
            End If
        Next
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
End Class
