Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO

Public Class Purchased_Items

    Dim calculate As Integer

    Private Sub Purchased_Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        total_value.Text = global_overall_total

    End Sub

    Private Sub Purchased_Items_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles money_bill.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        money_bill.Clear()
        dynamic_pay.Text = "0.00"
    End Sub

    Private Sub purchase_Click(sender As Object, e As EventArgs) Handles purchase.Click

        If calculate > CInt(total_value.Text) Then

            Dim obj As New Generate_Receipt
            obj.ShowDialog()
        Else
            MessageBox.Show("Insufficient Funds..", "Lack of Funds", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub

    Private Sub money_bill_TextChanged(sender As Object, e As EventArgs) Handles money_bill.TextChanged

        dynamic_pay.Text = money_bill.Text
        Try
            calculate = CInt(dynamic_pay.Text) - CInt(total_value.Text)
            change.Text = Math.Abs(calculate)

        Catch ex As Exception

        End Try

    End Sub
End Class