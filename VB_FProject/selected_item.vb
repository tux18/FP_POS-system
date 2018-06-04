Imports MySql.Data.MySqlClient

Public Class selected_item

    Dim make_connection As String = "datasource=localhost; port=3306; username=root; password=; database=pos_database"
    Dim conn As New MySqlConnection(make_connection)
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable()

    Private Sub Populate(name As String, qty As String, price As String, status As String)
        Dim row As String() = New String() {name, qty, price, status}
        global_system_items.Rows.Add(row)

    End Sub

    Private Sub refreshTable()
        ' The Code Below will fix the adding or displaying in the table
        ' where the problem is continous adding of value in the DataGridView

        global_system_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
        dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

        Try
            conn.Open()
            Dim query As String = "select * from " & global_table_name

            Dim ds As New DataSet()
            cmd = New MySqlCommand(query, conn)
            'adt.Fill(ds, "processor_items")

            Dim adt = New MySqlDataAdapter(cmd)
            adt.Fill(dt)

            For Each row In dt.Rows
                'Call the Function Populate here

                Populate(row(0), row(1), row(2), row(3))


            Next
            'system_items.DataSource = ds.Tables(0)

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub



    Private Sub selected_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub btn_purchase_Click(sender As Object, e As EventArgs) Handles btn_purchase.Click

        Dim obj = New Main_Menu

        Dim st As String = status.Text

        If st.Equals("Out of Stock") Then
            MessageBox.Show("THIS ITEM IS OUT OF STOCK", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Try
                conn.Open()
                Dim quantity As Integer = CInt(qty.Text)

                Dim total As Integer
                Dim user_input As Integer = CInt(enter_qty.Text)
                Dim total_amount As Integer
                Dim get_price As Integer = CInt(price.Text)
                If user_input <= quantity Then
                    total = user_input - quantity
                    'MessageBox.Show(total, "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Dim query As String = "UPDATE " & global_table_name & " SET qty=" & "'" & Math.Abs(total) & "'" & " WHERE item_name = " & "'" & pname.Text & "'"
                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery()
                    total_amount = get_price * user_input

                    global_customer_items.Rows.Add(New String() {pname.Text, CStr(user_input), CStr(total_amount)})

                    global_overall_total += CInt(total_amount)


                    If total.Equals(0) Then
                        Dim query1 As String = "UPDATE " & global_table_name & " 
                               SET status=" & "'" & "Out of Stock" & "'" & " WHERE item_name = " & "'" & pname.Text & "'"
                        cmd = New MySqlCommand(query1, conn)
                        cmd.ExecuteNonQuery()
                    End If


                Else
                        MessageBox.Show("Quantity Overflow", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If


                conn.Close()
                conn.Dispose()
                refreshTable()
                Me.Dispose()
            Catch ex As Exception
                MessageBox.Show("Input the missing Fields", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            'Dim query1 As String = "UPDATE " & global_table_name & " 
            '       SET status=" & "'" & "Out of Stock" & "'" & " WHERE item_name = " & "'" & pname.Text & "'"
            'cmd = New MySqlCommand(query, conn)
            'cmd.ExecuteNonQuery()

        End If

    End Sub
End Class