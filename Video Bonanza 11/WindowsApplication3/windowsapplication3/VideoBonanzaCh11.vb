'Programmer: Matt Kline
'Program: Video Bonanza Ch 11
'Date: 5/2/16

Imports System.IO

Public Class VideoBonanzaCh11
    Private ChangedFile As Boolean

    Private Sub PrintSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintSelectedToolStripMenuItem.Click
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
        Dim ResponseDialogResult As DialogResult

        If ChangedFile Then
            ResponseDialogResult = MessageBox.Show("Save the updated movie categories?",
                                                   "Save List?", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question)
            If ResponseDialogResult = DialogResult.Yes Then
                SaveFileToolStripMenuItem_Click(sender, e)
                Me.Close()
            Else
                Me.Close()
            End If
        Else
            Me.Close()
        End If
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

    Private Sub AddaCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddACategoryToolStripMenuItem.Click
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
                    ChangedFile = True
                End If
            Else
                MessageBox.Show("Enter a movie category to add", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            .Focus()
        End With
    End Sub

    Private Sub RemoveaCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveACategoryToolStripMenuItem.Click
        With MovieTypeComboBox
            If .SelectedIndex <> -1 Then
                .Items.RemoveAt(.SelectedIndex)
                ChangedFile = True
            Else
                MessageBox.Show("First select the movie category to remove",
                                "No selection made", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

    Private Sub ClearCategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearCategoriesToolStripMenuItem.Click
        Dim ResponseDialogResult As DialogResult
        ChangedFile = True

        ResponseDialogResult = MessageBox.Show("Clear the movie categories list?",
                                               "Clear movie categories list", MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question)
        If ResponseDialogResult = DialogResult.Yes Then
            MovieTypeComboBox.Items.Clear()
        End If
    End Sub

    Private Sub DisplayCategoryCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayCategoryCountListToolStripMenuItem.Click
        Dim MessageString As String

        MessageString = "The number of movie categories is " &
                MovieTypeComboBox.Items.Count & "."
        MessageBox.Show(MessageString, "Movie Category Count",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        about.ShowDialog()
    End Sub

    Private Sub ImportCategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportCategoriesToolStripMenuItem.Click
        Dim ResponseDialogResult As DialogResult

        Try
            Dim CategoriesStreamReader As StreamReader = New StreamReader("MovieCategories.txt")

            Do Until CategoriesStreamReader.Peek = -1
                Dim ItemFoundBoolean As Boolean
                Dim ItemIndexInteger As Integer
                Dim CategoryName As String = CategoriesStreamReader.ReadLine()
                Do Until ItemFoundBoolean Or ItemIndexInteger = MovieTypeComboBox.Items.Count
                    If CategoryName = MovieTypeComboBox.Items(ItemIndexInteger).ToString() Then
                        ItemFoundBoolean = True
                        Exit Do
                    Else
                        ItemIndexInteger += 1
                    End If
                Loop
                If ItemFoundBoolean Then
                    Exit Do
                Else
                    MovieTypeComboBox.Items.Add(CategoryName)
                End If
            Loop
            CategoriesStreamReader.Close()

        Catch FileNotFound As Exception
            ResponseDialogResult = MessageBox.Show("Create a new file?", "File Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If ResponseDialogResult = DialogResult.No Then
                Me.Close()
            End If
        End Try

    End Sub

    Private Sub SaveFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveFileToolStripMenuItem.Click
        Dim NumberItemsInteger As Integer

        Dim CategoryStreamWriter As StreamWriter = New StreamWriter("MovieCategories.txt", False)
        NumberItemsInteger = MovieTypeComboBox.Items.Count - 1
        For IndexInteger As Integer = 0 To NumberItemsInteger
            CategoryStreamWriter.WriteLine(MovieTypeComboBox.Items(IndexInteger))
        Next IndexInteger

        CategoryStreamWriter.Close()
        ChangedFile = False
    End Sub
End Class
