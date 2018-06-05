Imports MySql.Data.MySqlClient


Public Class Login_Interface
    Dim main = New Main_Form()
    Dim make_connection As String = "datasource=localhost; port=3306; username=root; password=; database=pos_database"
    Dim conn As New MySqlConnection(make_connection)
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader



    Private Sub Customer_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        ' The Code will provide a Focus() Like
        Me.Show()
        user_name.Select()

    End Sub

    Private Sub Cust_Cancel_Click(sender As Object, e As EventArgs) Handles login_cancel.Click
        Me.Dispose()

        main.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login.Click
        Dim getuser As String = user_name.Text
        Dim getpass As String = password.Text

        Dim block As Boolean = False
        Dim flag As Boolean = True
        Try
            conn.Open()
            ' Retrieve the user and password in database 
            Dim query As String = "SELECT username,password,fname,lname,status FROM accounts"
            'Dim get_name_query As String = "SELECT fname From accounts"
            cmd = New MySqlCommand(query, conn)

            reader = cmd.ExecuteReader

            While reader.Read
                If reader.GetString("username").Equals(getuser) And reader.GetString("password").Equals(getpass) And reader.GetString("status").Equals("unblock") Then
                    MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    global_login_user = reader.GetString("fname") + " " + reader.GetString("lname")
                    'reader.GetString("fname") -> this will retrieve the name in the Database
                    Dim mm = New Main_Menu()
                    mm.Show()
                    flag = False

                    Exit While
                ElseIf reader.GetString("username").Equals(getuser) And reader.GetString("password").Equals(getpass) And reader.GetString("status").Equals("block") Then
                    flag = True
                    block = True
                    Exit While
                ElseIf reader.GetString("username").Equals(getuser) And reader.GetString("password").Equals(getpass) Then
                    flag = True
                    block = False
                    Exit While
                End If
            End While

            ' Close and Dispose the Connection

            conn.Close()
            conn.Dispose()
        Catch ex As MySqlException
            MessageBox.Show("ERROR: Not Connected Into Database", "Database ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
            Dim obj As New Login_Interface
            obj.Show()
        End Try



        If flag.Equals(True) Then

            If block.Equals(True) Then
                MessageBox.Show("This username has been BLOCK", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Dispose()
                Dim obj As New Login_Interface
                obj.Show()
            ElseIf block.Equals(False) Then
                MessageBox.Show("ERROR: Invalid Username or Password", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error
                                         )
                Me.Dispose()
                Dim obj As New Login_Interface
                obj.Show()
            End If




        End If






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