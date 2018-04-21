Public Class Main_Form
    Private Sub customer_Click(sender As Object, e As EventArgs) Handles customer.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub help_btn_Click(sender As Object, e As EventArgs) Handles help_btn.Click
        MessageBox.Show("CUSTOMER: - If you want to buy an item select this button " + vbNewLine +
                        "ADMINISTRATOR: - NOTE: This is for Administrator Only", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
