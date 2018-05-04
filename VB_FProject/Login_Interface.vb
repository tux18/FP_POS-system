

Public Class Login_Interface
    Dim main = New Main_Form()


    Private Sub Customer_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Cust_Cancel_Click(sender As Object, e As EventArgs) Handles login_cancel.Click
        Me.Close()

        main.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login.Click
        Dim mm = New Main_Menu()
        mm.Show()
        Me.Hide()
    End Sub


End Class