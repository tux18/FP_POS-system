Imports MySql.Data.MySqlClient




Public Class Customer


    Dim make_connection As String = "datasource=localhost; port=3306; username=root; password=; database=pos_database"
    Dim conn As New MySqlConnection(make_connection)
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader

    ' Function That will Populate the DataGridView
    Private Sub Populate(parm1 As String, parm2 As String, parm3 As String, parm4 As String, parm5 As String)
        Dim row As String() = New String() {parm1, parm2, parm3, parm4, parm5}
        customer_list.Rows.Add(row)

    End Sub


    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()


        Dim dt As New DataTable()

        Try
            Dim query As String = "select * from customer"

            Dim ds As New DataSet()
            cmd = New MySqlCommand(query, conn)
            'adt.Fill(ds, "processor_items")

            Dim adt = New MySqlDataAdapter(cmd)
            adt.Fill(dt)

            For Each row In dt.Rows
                'Call the Function Populate here
                Populate(row(0), row(1), row(2), row(3), row(4))
            Next
            'system_items.DataSource = ds.Tables(0)

            conn.Close()
            conn.Dispose()
        Catch ex As Exception
            MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub

    Private Sub Customer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        Main_Menu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cancel_cust.Click
        Me.Dispose() ' Cancel Button
        Main_Menu.Show()
    End Sub


    Private Sub customer_list_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles customer_list.CellClick
        ' PROBLEM: Instead of Using CellClick Action -> im using a CellContentClick ->
        ' -> this will be work when you start clicking the STRING VALUE of each Cell ---
        ' -- But not working in the Spaces of Every Cell in the Table
        ' FIX: CellClick Action
        If e.RowIndex >= 0 Then

            id_cust.Text = customer_list.Rows(e.RowIndex).Cells(0).Value
            fullname.Text = customer_list.Rows(e.RowIndex).Cells(1).Value
            c_gender.Text = customer_list.Rows(e.RowIndex).Cells(2).Value
            c_contact_number.Text = customer_list.Rows(e.RowIndex).Cells(3).Value
            full_address.Text = customer_list.Rows(e.RowIndex).Cells(4).Value

            ' Make an Invisible label to transfer the old data and retrieve it 
            ' for later use (commonly in DATABASE)
            invisible_data.Text = id_cust.Text
        End If

    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        id_cust.Clear()
        fullname.Clear()
        full_address.Clear()
        c_contact_number.Clear()
        c_gender.Text = ""

    End Sub

    Private Sub add_cust_Click(sender As Object, e As EventArgs) Handles add_cust.Click
        ' PROBLEM: Unhandle ERROR when database or the application is not connected into Database
        ' No MessageBox will inform the user

        ' ADD CUSTOMER
        Dim dt As New DataTable()
        Dim get_id = id_cust.Text
        Dim get_name = fullname.Text
        Dim get_contact = c_contact_number.Text
        Dim get_address = full_address.Text
        Dim get_gender = c_gender.Text
        Dim checked As String



        conn.Open()

        If get_id.Equals("") And get_name.Equals("") And get_contact.Equals("") And get_address.Equals("") _
                And get_gender.Equals("") Then
            MessageBox.Show("ERROR: Please Fill out the Fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            id_cust.Focus()

        Else

            Try
                Dim query As String = "INSERT INTO customer (cust_id,full_name,gender,contact_num,address) VALUE (" & "'" & get_id & "'" & "," & "'" & get_name & "'" & "," & "'" & get_gender _
                   & "'" & "," & "'" & get_contact & "'" & "," & "'" & get_address & "'" & ")"

                cmd = New MySqlCommand(query, conn)
                cmd.ExecuteNonQuery() ' Execute the query

                checked = MessageBox.Show("Successfully Added", "Adding Items", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If checked.Equals("1") Then
                    id_cust.Clear()
                    fullname.Clear()
                    full_address.Clear()
                    c_contact_number.Clear()
                    c_gender.Text = ""
                    customer_list.Refresh()
                End If


                conn.Close()
                conn.Dispose()
            Catch ex As MySqlException
                MessageBox.Show("The Data is already inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            customer_list.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
            dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

            ' Update The DataGridView Table(customer_list)
            Try
                Dim query As String = "select * from customer"

                Dim ds As New DataSet()
                cmd = New MySqlCommand(query, conn)
                'adt.Fill(ds, "processor_items")

                Dim adt = New MySqlDataAdapter(cmd)
                adt.Fill(dt)

                For Each row In dt.Rows
                    'Call the Function Populate here
                    Populate(row(0), row(1), row(2), row(3), row(4))
                Next
                'system_items.DataSource = ds.Tables(0)

                conn.Close()
                conn.Dispose()
            Catch ex As Exception
                MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try




        End If


        conn.Close()
        conn.Dispose()


        'MessageBox.Show("asd", "Database ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Me.Dispose()
        'Dim obj As New Customer()
        'obj.Show()



    End Sub

    Private Sub update_cust_Click(sender As Object, e As EventArgs) Handles update_cust.Click
        ' UPDATE CUSTOMER
        Dim dt As New DataTable()
        Dim checked As String
        Dim get_id = id_cust.Text
        Dim get_name = fullname.Text
        Dim get_contact = c_contact_number.Text
        Dim get_address = full_address.Text
        Dim get_gender = c_gender.Text




        If get_id.Equals("") And get_name.Equals("") And get_contact.Equals("") And get_address.Equals("") _
              And get_gender.Equals("") Then
            MessageBox.Show("ERROR: Please Fill out the Fields or Select in the Table", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            id_cust.Focus()

        Else
            Try
                conn.Open()
                Dim query As String = "UPDATE customer SET cust_id = " & "'" & get_id & "'" & "," & "full_name = " & "'" & get_name & "'" _
                    & "," & "gender = " & "'" & get_gender & "'" & "," & "contact_num = " & "'" & get_contact & "'" & "," &
                    "address = " & "'" & get_address & "'" & " WHERE cust_id = " & "'" & invisible_data.Text & "'"
                ' MessageBox.Show(query, "Updating Items", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmd = New MySqlCommand(query, conn)
                cmd.ExecuteNonQuery() ' Execute the query

                checked = MessageBox.Show("Successfully Updated", "Updating Items", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If checked.Equals("1") Then
                    id_cust.Clear()
                    fullname.Clear()
                    full_address.Clear()
                    c_contact_number.Clear()
                    c_gender.Text = ""
                    customer_list.Refresh()
                End If
                customer_list.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
                dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared
                conn.Close()
                conn.Dispose()
            Catch ex As MySqlException
                MessageBox.Show("ERROR: Update Failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

            ' Update The DataGridView Table(customer_list)
            Try
                Dim query As String = "select * from customer"

                Dim ds As New DataSet()
                cmd = New MySqlCommand(query, conn)
                'adt.Fill(ds, "processor_items")

                Dim adt = New MySqlDataAdapter(cmd)
                adt.Fill(dt)

                For Each row In dt.Rows
                    'Call the Function Populate here
                    Populate(row(0), row(1), row(2), row(3), row(4))
                Next
                'system_items.DataSource = ds.Tables(0)

                conn.Close()
                conn.Dispose()
            Catch ex As Exception
                MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

        End If


    End Sub


    Private Sub delete_cust_Click(sender As Object, e As EventArgs) Handles delete_cust.Click
        ' DELETE 

        Dim dt As New DataTable()
        Dim checked As String
        Dim get_id = id_cust.Text
        Dim get_name = fullname.Text
        Dim get_contact = c_contact_number.Text
        Dim get_address = full_address.Text
        Dim get_gender = c_gender.Text


        If get_id.Equals("") And get_name.Equals("") And get_contact.Equals("") And get_address.Equals("") _
             And get_gender.Equals("") Then
            MessageBox.Show("ERROR: Please Fill out the Fields or Select in the Table", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            id_cust.Focus()

        Else
            Try
                conn.Open()
                Dim query As String = "DELETE FROM customer WHERE cust_id = " & "'" & invisible_data.Text & "'"
                ' MessageBox.Show(query, "Updating Items", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmd = New MySqlCommand(query, conn)
                cmd.ExecuteNonQuery() ' Execute the query

                checked = MessageBox.Show("Successfully Deleted", "Deleting Items", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If checked.Equals("1") Then
                    id_cust.Clear()
                    fullname.Clear()
                    full_address.Clear()
                    c_contact_number.Clear()
                    c_gender.Text = ""
                    customer_list.Refresh()
                End If
                customer_list.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
                dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared
                conn.Close()
                conn.Dispose()
            Catch ex As MySqlException
                MessageBox.Show("ERROR: Delete Failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

            ' Update The DataGridView Table(customer_list)
            Try
                Dim query As String = "select * from customer"

                Dim ds As New DataSet()
                cmd = New MySqlCommand(query, conn)
                'adt.Fill(ds, "processor_items")

                Dim adt = New MySqlDataAdapter(cmd)
                adt.Fill(dt)

                For Each row In dt.Rows
                    'Call the Function Populate here
                    Populate(row(0), row(1), row(2), row(3), row(4))
                Next
                'system_items.DataSource = ds.Tables(0)

                conn.Close()
                conn.Dispose()
            Catch ex As Exception
                MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

        End If

    End Sub

    Private Sub select_cust_Click(sender As Object, e As EventArgs) Handles select_cust.Click
        Dim get_id = id_cust.Text
        Dim get_name = fullname.Text
        Dim get_contact = c_contact_number.Text
        Dim get_address = full_address.Text
        Dim get_gender = c_gender.Text

        If get_id.Equals("") And get_name.Equals("") And get_contact.Equals("") And get_address.Equals("") _
             And get_gender.Equals("") Then
            MessageBox.Show("Select in the table to fill the data in the Fields", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Show()
        Else
            global_name = fullname.Text
            global_contact = c_contact_number.Text
            global_gender = c_gender.Text
            Main_Menu.Show()
            Me.Dispose()
        End If





    End Sub
End Class