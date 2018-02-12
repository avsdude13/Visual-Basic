'Program Homework 11.4
'Programmer Matt Kline
'Date 5/3/16

Imports System.IO

Public Class TextEditor
    Private ChangedFile As Boolean

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        RichTextBox.Clear()
        ChangedFile = True
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim ResponseDialogResult As DialogResult

        With RichTextBox
            Try
                If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                    Dim StreamReader As New System.IO.StreamReader(OpenFileDialog1.FileName)
                    RichTextBox.Text = StreamReader.ReadToEnd()
                    StreamReader.Close()
                End If

            Catch FileNotFound As Exception
                ResponseDialogResult = MessageBox.Show("Create a new file?", "File Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If ResponseDialogResult = DialogResult.No Then
                    Me.Close()
                End If
            End Try
        End With
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim StreamWriter As New System.IO.StreamWriter(SaveFileDialog1.FileName)
            StreamWriter.WriteLine(RichTextBox.Text)
            StreamWriter.Close()
            ChangedFile = False
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim ResponseDialogResult As DialogResult

        If ChangedFile Then
            ResponseDialogResult = MessageBox.Show("Save the File",
                                                   "Save the File?", MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question)
            If ResponseDialogResult = DialogResult.Yes Then
                SaveToolStripMenuItem_Click(sender, e)
                Me.Close()
            Else
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        With FontDialog1
            .Font = RichTextBox.Font
            .ShowDialog()
            RichTextBox.Font = .Font
        End With
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        about.ShowDialog()
    End Sub
End Class
