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
        Me.Dispose()
        Dim main = New Main_Form()
        main.Show()
    End Sub
End Class