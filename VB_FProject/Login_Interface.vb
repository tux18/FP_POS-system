

Public Class Login_Interface
    Dim main = New Main_Form()


    Private Sub Customer_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Cust_Cancel_Click(sender As Object, e As EventArgs) Handles login_cancel.Click
        Me.Dispose()

        main.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login.Click
        Dim mm = New Main_Menu()
        mm.Show()
        Me.Hide()
    End Sub

    Private Sub Login_Interface_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        Dim back_to_main_form = New Main_Form()
        back_to_main_form.Show()

    End Sub

    Private Sub register_Click(sender As Object, e As EventArgs) Handles register.Click
        Me.Dispose()
        Dim reg = New registration()
        reg.Show()
    End Sub
End Class