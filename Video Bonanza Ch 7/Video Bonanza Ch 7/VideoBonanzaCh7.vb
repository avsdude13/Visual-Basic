'Programmer: Matt Kline
'Program: Video Bonanza Ch 7
'Date: 4/4/16

Public Class VideoBonanzaCh7

    Private Sub PrintSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintSelectedFlavorsToolStripMenuItem.Click
        If MovieTypeComboBox.SelectedIndex <> -1 Then
            PrintSelectedPrintDocument.Print()
        Else
            MessageBox.Show("Select a movie category", "Print Selection",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub PreviewSelectedToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PreviewSelectedToolStripMenuItem.Click
        If MovieTypeComboBox.SelectedIndex <> -1 Then
            PrintPreviewDialog1.Document = PrintSelectedPrintDocument
            PrintPreviewDialog1.ShowDialog()
        Else
            MessageBox.Show("Select a movie category", "Print Selection",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub PrintAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintAllToolStripMenuItem.Click
        PrintAllPrintDocument.Print()
    End Sub

    Private Sub PreviewAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviewAllToolStripMenuItem.Click
        PrintPreviewDialog1.Document = PrintAllPrintDocument
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PrintAllPrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintAllPrintDocument.PrintPage
        Dim PrintFont As New Font("Arial", 12)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String

        Using HeadingFont As New Font("Arial", 14, FontStyle.Bold)
            e.Graphics.DrawString("Movie Categories", HeadingFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        End Using

        For ListIndexInteger As Integer = 0 To MovieTypeComboBox.Items.Count - 1
            VerticalPrintLocationSingle += LineHeightSingle

            PrintLineString = MovieTypeComboBox.Items(ListIndexInteger).ToString()
            e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        Next ListIndexInteger
    End Sub

    Private Sub PrintSelectedPrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintSelectedPrintDocument.PrintPage
        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintlocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintlocationSingle As Single = e.MarginBounds.Top
        Dim PrintlineString As String

        PrintlineString = "Print Selected Item' "
        e.Graphics.DrawString(PrintlineString, HeadingFont, Brushes.Black, HorizontalPrintlocationSingle, VerticalPrintlocationSingle)
        PrintlineString = "by Matt Kline"
        VerticalPrintlocationSingle += LineHeightSingle
        e.Graphics.DrawString(PrintlineString, HeadingFont, Brushes.Black, HorizontalPrintlocationSingle, VerticalPrintlocationSingle)
        VerticalPrintlocationSingle += LineHeightSingle * 2
        PrintlineString = "Movie Categories: " & MovieTypeComboBox.Text
        e.Graphics.DrawString(PrintlineString, PrintFont, Brushes.Black, HorizontalPrintlocationSingle, VerticalPrintlocationSingle)
    End Sub

    Private Sub AddaCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCoffeeFlavorToolStripMenuItem.Click
        With MovieTypeComboBox
            If .Text <> "" Then
                Dim ItemFoundBoolean As Boolean
                Dim ItemIndexInteger As Integer
                Do Until ItemFoundBoolean Or ItemIndexInteger = .Items.Count
                    If .Text = .Items(ItemIndexInteger).ToString() Then
                        ItemFoundBoolean = True
                        Exit Do
                    Else
                        ItemIndexInteger += 1
                    End If
                Loop
                If ItemFoundBoolean Then
                    MessageBox.Show("Duplicate Item.", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    .Items.Add(.Text)
                    .Text = ""
                End If
            Else
                MessageBox.Show("Enter a movie category to add", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            .Focus()
        End With
    End Sub

    Private Sub RemoveaCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveCoffeeFlavorToolStripMenuItem.Click
        With MovieTypeComboBox
            If .SelectedIndex <> -1 Then
                .Items.RemoveAt(.SelectedIndex)
            Else
                MessageBox.Show("First select the movie category to remove",
                                "No selection made", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

    Private Sub ClearCategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearCoffeeListToolStripMenuItem.Click
        Dim ResponseDialogResult As DialogResult

        ResponseDialogResult = MessageBox.Show("Clear the movie categories list?",
                                               "Clear movie categories list", MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question)
        If ResponseDialogResult = DialogResult.Yes Then
            MovieTypeComboBox.Items.Clear()
        End If
    End Sub

    Private Sub DisplayCategoryCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CountCoffeeListToolStripMenuItem.Click
        Dim MessageString As String

        MessageString = "The number of movie categories is " &
                MovieTypeComboBox.Items.Count & "."
        MessageBox.Show(MessageString, "Movie Category Count",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        about.ShowDialog()
    End Sub
End Class
