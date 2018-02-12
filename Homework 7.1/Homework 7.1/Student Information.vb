'Programmer: Matt Kline
'Program: Homework 7.1
'Date: 4/5/16

Public Class StudentInformation

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

    Private Sub AcceptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcceptToolStripMenuItem.Click
        StudentNameTextBox.Clear()
        UnitsCompletedTextBox.Clear()
        FreshmanRadioButton.Checked = False
        SophomoreRadioButton.Checked = False
        JuniorRadioButton.Checked = False
        SeniorRadioButton.Checked = False
        MajorListBox.SelectedIndex = 0
        HighSchoolComboBox.SelectedIndex = 0
        DeansListCheckBox.Checked = False
        StudentNameTextBox.Focus()
    End Sub

    Private Sub PrintAllPrintDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintAllPrintDocument.PrintPage
        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintlocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintlocationSingle As Single = e.MarginBounds.Top
        Dim PrintlineString As String

        Using HeadingFont
            e.Graphics.DrawString("Student Information by Matt Kline", HeadingFont, Brushes.Black, HorizontalPrintlocationSingle, VerticalPrintlocationSingle)
        End Using

        VerticalPrintlocationSingle += LineHeightSingle * 2
        PrintlineString = "Student: " & StudentNameTextBox.Text
        e.Graphics.DrawString(PrintlineString, PrintFont, Brushes.Black, HorizontalPrintlocationSingle, VerticalPrintlocationSingle)
        VerticalPrintlocationSingle += LineHeightSingle
        PrintlineString = "Units Completed: " & UnitsCompletedTextBox.Text
        e.Graphics.DrawString(PrintlineString, PrintFont, Brushes.Black, HorizontalPrintlocationSingle, VerticalPrintlocationSingle)
        VerticalPrintlocationSingle += LineHeightSingle
        PrintlineString = "Major: " & MajorListBox.Text
        e.Graphics.DrawString(PrintlineString, PrintFont, Brushes.Black, HorizontalPrintlocationSingle, VerticalPrintlocationSingle)
        VerticalPrintlocationSingle += LineHeightSingle
        PrintlineString = "High School: " & HighSchoolComboBox.Text
        e.Graphics.DrawString(PrintlineString, PrintFont, Brushes.Black, HorizontalPrintlocationSingle, VerticalPrintlocationSingle)
        VerticalPrintlocationSingle += LineHeightSingle
        PrintlineString = "Deans List: " & DeansListCheckBox.Checked
        e.Graphics.DrawString(PrintlineString, PrintFont, Brushes.Black, HorizontalPrintlocationSingle, VerticalPrintlocationSingle)
    End Sub

    Private Sub AddaMajorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddaMajorToolStripMenuItem.Click
        With MajorListBox
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
                MessageBox.Show("Enter a major to add", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            .Focus()
        End With
    End Sub

    Private Sub RemoveaMajorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveaMajorToolStripMenuItem.Click
        With MajorListBox
            If .SelectedIndex <> -1 Then
                .Items.RemoveAt(.SelectedIndex)
            Else
                MessageBox.Show("First select the major to remove",
                                "No selection made", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

    Private Sub DisplayMajorCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayaMajorCountToolStripMenuItem.Click
        Dim MessageString As String

        MessageString = "The number of majors is " &
                MajorListBox.Items.Count & "."
        MessageBox.Show(MessageString, "Major Count",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AddaHighSchoolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddHighSchoolToolStripMenuItem.Click
        With HighSchoolComboBox
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
                MessageBox.Show("Enter a high school to add", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            .Focus()
        End With
    End Sub

    Private Sub RemoveaHighSchoolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveHighSchoolToolStripMenuItem.Click
        With HighSchoolComboBox
            If .SelectedIndex <> -1 Then
                .Items.RemoveAt(.SelectedIndex)
            Else
                MessageBox.Show("First select the high school to remove",
                                "No selection made", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

    Private Sub DisplayHighSchoolCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayHighSchoolCountToolStripMenuItem.Click
        Dim MessageString As String

        MessageString = "The number of high schools is " &
                HighSchoolComboBox.Items.Count & "."
        MessageBox.Show(MessageString, "High School Count",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        about.ShowDialog()
    End Sub
End Class
