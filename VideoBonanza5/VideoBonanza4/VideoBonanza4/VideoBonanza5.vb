'Programmer: Matt Kline
'Program: Video Bonanza Chapter 5
'Date: 3/6/16

Public Class VideoBonanza
    Const TAX_RATE_Decimal As Decimal = 0.08D
    Const MEMBER_DISCOUNT_Decmial As Decimal = 0.1D
    Const DVD_OLD_PRICE_Decimal As Decimal = 2.5D
    Const DVD_NEW_PRICE_Decimal As Decimal = 3D
    Const VHS_OLD_PRICE_Decimal As Decimal = 1.8D
    Const VHS_NEW_PRICE_Decimal As Decimal = 2D
    Private SubTotalDecimal, CalculatedTaxDecimal, MemberDiscountDecimal, TotalDecimal As Decimal
    Private CustomerCount As Integer

    Private Sub CalculateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateToolStripMenuItem.Click
        Dim PriceDecimal As Decimal
        Dim TitleString As String

        TitleString = TitleTextBox.Text

        'Check type of movie
        If DVDRadioButton.Checked And NewReleaseCheckBox.Checked Then       'Movie is DVD and new
            PriceDecimal = DVD_NEW_PRICE_Decimal
        ElseIf DVDRadioButton.Checked Then      'Movie is just DVD
            PriceDecimal = DVD_OLD_PRICE_Decimal
        ElseIf VHSRadioButton.Checked And NewReleaseCheckBox.Checked Then       'Movie is VHS and new
            PriceDecimal = VHS_NEW_PRICE_Decimal
        ElseIf VHSRadioButton.Checked Then        'Movie is just VHS
            PriceDecimal = VHS_OLD_PRICE_Decimal
        Else
            MessageBox.Show("Please select a video type", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            With TitleTextBox
                .Focus()
            End With
        End If

        'Calculate Price
        If MemberCheckBox.Checked Then
            MemberDiscountDecimal = (MEMBER_DISCOUNT_Decmial * PriceDecimal)        'If customer is a member give 10% discount
        End If
        PriceDecimal -= MemberDiscountDecimal
        SubTotalDecimal += PriceDecimal
        CalculatedTaxDecimal = SubTotalDecimal * TAX_RATE_Decimal
        TotalDecimal = SubTotalDecimal + CalculatedTaxDecimal

        'Check if all variables were entered and output
        If TitleString = "" Then
            MessageBox.Show("Please enter a title", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            With TitleTextBox
                .Focus()
                .SelectAll()
            End With
        Else
            ItemAmountTextBox.Text = PriceDecimal.ToString("C")
            SubTotalTextBox.Text = SubTotalDecimal.ToString("C")
        End If
    End Sub
    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        MessageBox.Show("Order Summary:                 " + Environment.NewLine + "     Subtotal: " + SubTotalDecimal.ToString("C") + Environment.NewLine + "     Tax: " + CalculatedTaxDecimal.ToString("C") + Environment.NewLine + "     Total: " + TotalDecimal.ToString("C"))

        CustomerCount += 1

        MemberCheckBox.Checked = False
        ItemAmountTextBox.Clear()
        SubTotalTextBox.Clear()
        SubTotalDecimal = 0
        CalculatedTaxDecimal = 0
        MemberDiscountDecimal = 0
        TotalDecimal = 0
    End Sub

    Private Sub OrderCompleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderCompleteToolStripMenuItem.Click
        Dim ReturnDialogResult As DialogResult
        Dim MessageString As String

        MessageString = "Are you sure you are finished?"
        ReturnDialogResult = MessageBox.Show(MessageString, "Complete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If ReturnDialogResult = Windows.Forms.DialogResult.Yes Then
            ClearForNextItemToolStripMenuItem_Click(sender, e)
        End If
    End Sub

    Private Sub ClearForNextItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearForNextItemToolStripMenuItem.Click
        NewReleaseCheckBox.Checked = False
        TitleTextBox.Clear()
        DVDRadioButton.Checked = False
        VHSRadioButton.Checked = False
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        With ColorDialog1
            .Color = SubTotalTextBox.ForeColor
            .ShowDialog()
            SubTotalTextBox.ForeColor = .Color
            ItemAmountTextBox.ForeColor = .Color
        End With
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        With FontDialog1
            .Font = SubTotalTextBox.Font
            .ShowDialog()
            SubTotalTextBox.Font = .Font
            ItemAmountTextBox.Font = .Font
        End With
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim MessageString As String

        MessageString = "Reading and Relaxation Billing" & Environment.NewLine & Environment.NewLine & "Programmed By: Matt Kline"

        MessageBox.Show(MessageString, "About Reading and Refreshment Billing", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
