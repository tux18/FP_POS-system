Public Class Main_Menu
    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub main_logout_Paint(sender As Object, e As PaintEventArgs) Handles main_logout.Paint

    End Sub

    Private Sub Main_Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class