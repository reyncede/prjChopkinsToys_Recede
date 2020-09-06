Option Explicit On
Option Infer Off
Option Strict On
Public Class Form1

    Const dblPACK_12_PRICE As Double = 14.99
    Const dblPACK_5_PRICE As Double = 6.99
    Const dblPACK_2_PRICE As Double = 2.5

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim dblShipping As Double
        Double.TryParse(InputBox("Enter Shipping Charge:", "Shipping Charge"), dblShipping)

        Dim dblTotal12 As Double = Val(txt12Qty.Text) * dblPACK_12_PRICE
        Dim dblTotal5 As Double = Val(txt5Qty.Text) * dblPACK_5_PRICE
        Dim dblTotal2 As Double = Val(txt2Qty.Text) * dblPACK_2_PRICE

        txt12Total.Text = dblTotal12.ToString("C2")
        txt5Total.Text = dblTotal5.ToString("C2")
        txt2Total.Text = dblTotal2.ToString("C2")
        txtShipping.Text = dblShipping.ToString("C2")

        Dim intQty12 As Integer
        Dim intQty5 As Integer
        Dim intQty2 As Integer

        Integer.TryParse(txt12Qty.Text, intQty12)
        Integer.TryParse(txt5Qty.Text, intQty5)
        Integer.TryParse(txt2Qty.Text, intQty2)

        txtTotalQty.Text = (intQty12 + intQty5 + intQty2).ToString()
        txtSaleTotal.Text = (dblTotal12 + dblTotal5 + dblTotal2).ToString("C2")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txt12Qty.Clear()
        txt5Qty.Clear()
        txt2Qty.Clear()
        txt12Total.Clear()
        txt5Total.Clear()
        txt2Total.Clear()
        txtTotalQty.Clear()
        txtDate.Clear()
        txtShipping.Clear()
        txtSaleTotal.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

End Class
