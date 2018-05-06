Public Class Main_Form



    Private Sub customer_Click(sender As Object, e As EventArgs) Handles customer.Click
        Dim cust = New Login_Interface()
        cust.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()


    End Sub

    Private Sub help_btn_Click(sender As Object, e As EventArgs) Handles help_btn.Click
        MessageBox.Show("USER: - A Authorize User that has been registered or apply for this job " + vbNewLine +
                        "ADMINISTRATION: - NOTE: This is for Administrator Only", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Main_Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' This Code below will fully exit the FORM while clicking the X button in the Title bar
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub admin_Click(sender As Object, e As EventArgs) Handles admin.Click
        Me.Hide()

        Dim admin_form = New Admin_Form()
        admin_form.Show()

    End Sub
End Class
