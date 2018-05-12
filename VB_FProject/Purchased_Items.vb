Public Class Purchased_Items
    Private Sub Purchased_Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Purchased_Items_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles money_bill.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        money_bill.Clear()
    End Sub

    Private Sub purchase_Click(sender As Object, e As EventArgs) Handles purchase.Click
        Dim obj As New Generate_Receipt
        obj.ShowDialog()
    End Sub
End Class