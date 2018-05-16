Imports MySql.Data.MySqlClient

Public Class registration

    Dim main = New Main_Form()
    Dim make_connection As String = "datasource=localhost; port=3306; username=root; password=; database=pos_database"
    Dim conn As New MySqlConnection(make_connection)
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader


    Private Sub registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        pass.Focus()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Dim obj = New Login_Interface()
        obj.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub registration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()

        Dim back_to_main_form = New Main_Form()
        back_to_main_form.Show()
    End Sub

    Private Sub register_Click(sender As Object, e As EventArgs) Handles register.Click
        Dim getuser As String = user.Text
        Dim getpass As String = pass.Text
        Dim getfname As String = fname.Text
        Dim getlname As String = lname.Text
        Dim checked As String

        Try
            conn.Open()

            If getuser.Equals("") And getpass.Equals("") And getfname.Equals("") And getlname.Equals("") Then
                MessageBox.Show("ERROR: Please Fill out the Fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                user.Focus()
            Else
                Dim query As String = "INSERT INTO accounts (username,password,fname,lname) VALUE (" & "'" & getuser & "'" & "," & "'" & getpass & "'" & "," & "'" & getfname _
                    & "'" & "," & "'" & getlname & "'" & ")"

                cmd = New MySqlCommand(query, conn)
                cmd.ExecuteNonQuery() ' Execute the query

                checked = MessageBox.Show("Successfully Registered", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If checked.Equals("1") Then
                    user.Clear()
                    pass.Clear()
                    fname.Clear()
                    lname.Clear()

                End If

            End If

            conn.Close()
            conn.Dispose()
        Catch ex As MySqlException
            MessageBox.Show("ERROR: Not Connected Into Database", "Database ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
            Dim obj As New registration()
            obj.Show()
        End Try




    End Sub
End Class