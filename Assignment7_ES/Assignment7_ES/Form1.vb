Public Class Form1

    '#1 Declare Constant Variables

    Const dblUnlimitedText As Double = 10
    Const dblVideoChat As Double = 15
    Const dbl800 As Double = 19.99
    Const dbl1500 As Double = 29.99
    Const dblUnlimitedTalk As Double = 39.99
    Const dblSimsongAG As Double = 29.99
    Const dbliPoundXV As Double = 39.99

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Close the program
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear output labels and reset totals to 0

        lblMonthlySubtotal.ResetText()
        lblTax.ResetText()
        lblMonthyTotal.ResetText()
        chkUnlimitedText.Checked = False
        chkVideoChat.Checked = False
        rad800.Checked = False
        rad1500.Checked = False
        radUnlimitedTalk.Checked = False
        radSimsongAG.Checked = False
        radiPoundXV.Checked = False
        radCustomerPhone.Checked = True

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        '#1 Declare Variables for Plans, Phones, and Options

        'Inputs

        'Dim blnPlan As Boolean
        'Dim blnPhone As Boolean
        'Dim blnOptions As Boolean

        'Outputs and Subtotals

        Dim dblMonthlySubtotal As Double
        Dim dblTax As Double
        Dim dblMonthlyTotal As Double


        '#2 Get Inputs, #3 Do Calculations For Monthly Subtotal, Tax, and Monthly Total

        ' Options
        If chkUnlimitedText.Checked Then
            dblMonthlySubtotal = dblMonthlySubtotal + dblUnlimitedText
        End If

        If chkVideoChat.Checked Then
            dblMonthlySubtotal = dblMonthlySubtotal + dblVideoChat
        End If


        'Plans
        If rad800.Checked Then
            dblMonthlySubtotal = dblMonthlySubtotal + dbl800
        ElseIf rad1500.Checked Then
            dblMonthlySubtotal = dblMonthlySubtotal + dbl1500
        ElseIf radUnlimitedTalk.Checked Then
            dblMonthlySubtotal = dblMonthlySubtotal + dblUnlimitedTalk
        End If


        'Phones
        If radSimsongAG.Checked Then
            dblMonthlySubtotal = dblMonthlySubtotal + dblSimsongAG
        Else
            If radiPoundXV.Checked Then
                dblMonthlySubtotal = dblMonthlySubtotal + dbliPoundXV
            End If
        End If


        'Tax
        dblTax = dblMonthlySubtotal * 0.075


        'Monthly Total
        dblMonthlyTotal = dblMonthlySubtotal + dblTax


        '#4 Display Outputs
        lblMonthlySubtotal.Text = FormatCurrency(dblMonthlySubtotal)
        lblTax.Text = FormatCurrency(dblTax)
        lblMonthyTotal.Text = FormatCurrency(dblMonthlyTotal)

    End Sub
End Class
