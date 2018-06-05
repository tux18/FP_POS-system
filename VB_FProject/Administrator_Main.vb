Imports MySql.Data.MySqlClient
Public Class Administrator_Main



    Dim make_connection As String = "datasource=localhost; port=3306; username=root; password=; database=pos_database"
    Dim conn As New MySqlConnection(make_connection)
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable()


    Private Sub Populate(username As String, password As String, fname As String, lname As String, status As String)
        Dim row As String() = New String() {username, password, fname, lname, status}
        account_holder.Rows.Add(row)

    End Sub


    Private Sub Administrator_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.MaximizeBox = False
        Me.MinimizeBox = False



        Try
            Dim query As String = "select * from accounts"

            Dim ds As New DataSet()
            cmd = New MySqlCommand(query, conn)


            Dim adt = New MySqlDataAdapter(cmd)
            adt.Fill(dt)

            For Each row In dt.Rows
                'Call the Function Populate here
                Populate(row(0), row(1), row(2), row(3), row(4))
            Next
            'system_items.DataSource = ds.Tables(0)

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try




    End Sub

    Private Sub Administrator_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        Dim obj = New Main_Form()
        obj.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim obj = New Main_Form()
        obj.Show()
        Me.Dispose()


    End Sub

    Private Sub unblock_Click(sender As Object, e As EventArgs) Handles unblock.Click

        Dim index As Integer = account_holder.CurrentRow.Index
        Dim get_username = account_holder.Rows(index).Cells(0).Value



        Try
            conn.Open()
            Dim query As String = "UPDATE accounts SET status = 'unblock' WHERE username = " & "'" & get_username & "'"
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            account_holder.Rows(index).Cells(4).Value = "unblock"
            MessageBox.Show("The User is Successfully Unblock", "UNBLOCK",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub block_Click(sender As Object, e As EventArgs) Handles block.Click


        Dim index As Integer = account_holder.CurrentRow.Index
        Dim get_username = account_holder.Rows(index).Cells(0).Value
        Try
            conn.Open()
            Dim query As String = "UPDATE accounts SET status = 'block' WHERE username = " & "'" & get_username & "'"
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            account_holder.Rows(index).Cells(4).Value = "block"
            MessageBox.Show("The User is Successfully Block", "BLOCK",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim index As Integer = account_holder.CurrentRow.Index
        Dim get_username = account_holder.Rows(index).Cells(0).Value
        Try
            conn.Open()
            Dim query As String = "DELETE FROM accounts WHERE username = " & "'" & get_username & "'"
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            account_holder.Rows.RemoveAt(index)
            MessageBox.Show("Successfully Delete....", "DELETION",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub
End Class