Public Class SummaryForm

    Private Sub SummaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SubTotalTextBox.Text = VideoBonanza.SubTotalDecimal.ToString("C")
        TaxTextBox.Text = VideoBonanza.CalculatedTaxDecimal.ToString("C")
        TotalAmountTextBox.Text = VideoBonanza.TotalDecimal.ToString("C")

        VideoBonanza.CustomerCount += 1
    End Sub
End Class