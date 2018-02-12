Public Class SalesCalculator

    Private Sub PayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayToolStripMenuItem.Click

    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click

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
