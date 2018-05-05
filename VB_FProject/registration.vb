Public Class registration
    Private Sub registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        fname.Focus()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Dim obj = New Main_Form()
        obj.Show()
    End Sub


End Class