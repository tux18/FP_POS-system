Public Class Admin_Form


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Dim main = New Main_Form()
        main.Show()
    End Sub

    Private Sub Admin_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim getuser As String = username.Text
        Dim getpass As String = password.Text


        If getuser.Equals("admin") And getpass.Equals("admin12345") Then
            Dim obj = New Administrator_Main()
            obj.Show()
            Me.Dispose()

        Else
            MessageBox.Show("ERROR: Invalid Username or Password", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If





    End Sub

    Private Sub Admin_Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        Dim back_to_main_form = New Main_Form()
        back_to_main_form.Show()
    End Sub

End Class