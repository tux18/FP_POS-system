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






        If name.Equals("") And contact.Equals("") Then
            MessageBox.Show("ERROR: Input the Name and The Contact Number..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf name.Equals("") Or contact.Equals("") Then
            Dim get_value As String = MessageBox.Show("Do you want to continue even without a Contact Number?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If get_value.Equals("6") Then
                Dim obj As New Main_Menu()
                obj.Show()
                obj.display_name.Text = name
                obj.display_contact.Text = "Not Available"
            End If

        Else
            MessageBox.Show("Sucessfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim newObj As New Main_Menu()
            newObj.Show()
            newObj.display_name.Text = name
            newObj.display_contact.Text = contact

        End If



    End Sub

    Private Sub contact_num_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contact_num.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles clear_btn_cust.Click
        name_cust.Clear()
    End Sub
End Class