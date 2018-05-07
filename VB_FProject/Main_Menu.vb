Public Class Main_Menu

    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        tooltip.SetToolTip(main_logout, "Log Out")
        tooltip.SetToolTip(info, "Information About the System")

    End Sub

    Private Sub Main_Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub main_logout_MouseClick(sender As Object, e As MouseEventArgs) Handles main_logout.MouseClick
        Me.Hide()
        Dim main = New Main_Form()

        main.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles for_processor.Click
        change_name.Text = "Processor"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles for_motherboard.Click
        change_name.Text = "Motherboard"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles for_ram.Click
        change_name.Text = "RAM"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles for_gpu.Click
        change_name.Text = "Graphics Card"
    End Sub

    Private Sub payment_Click(sender As Object, e As EventArgs) Handles payment.Click
        Dim purchased = New Purchased_Items()
        purchased.Show()
    End Sub

    Private Sub Customer_btn_Click(sender As Object, e As EventArgs) Handles Customer_btn.Click
        Dim customer = New Customer_Info()
        customer.Show()
    End Sub
End Class