Imports System.Text.RegularExpressions
Public Class Customer_Info





    Private Sub Customer_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub accept_input_Click(sender As Object, e As EventArgs) Handles accept_input.Click

        Dim name As String = name_cust.Text
        Dim contact As String = contact_num.Text


    End Sub

    Private Sub contact_num_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contact_num.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        name_cust.Clear()
    End Sub
End Class