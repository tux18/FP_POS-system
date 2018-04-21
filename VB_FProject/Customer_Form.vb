

Public Class Customer_Form
    Dim main = New Main_Form()


    Private Sub Customer_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Cust_Cancel_Click(sender As Object, e As EventArgs) Handles Cust_Cancel.Click
        Me.Close()

        main.Show()
    End Sub


End Class