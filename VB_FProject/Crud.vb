Imports MySql.Data.MySqlClient

Public Class Crud

    Dim make_connection As String = "datasource=localhost; port=3306; username=root; password=; database=pos_database"
    Dim conn As New MySqlConnection(make_connection)
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable()



    Private Sub Populate(name As String, qty As String, price As String, status As String)
        Dim row As String() = New String() {name, qty, price, status}
        change_items.Rows.Add(row)

    End Sub



    Private Sub Crud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

    Private Sub Crud_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        Main_Menu.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Dispose()
        Main_Menu.Show()
    End Sub

    Private Sub for_processor_Click(sender As Object, e As EventArgs) Handles for_processor.Click

        p_name.Text = ""
        p_qty.Text = ""
        p_price.Text = ""
        p_status.Text = ""



        ' The Code Below will fix the adding or displaying in the table
        ' where the problem is continous adding of value in the DataGridView

        change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
        dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared




        current_selection.Text = "Processor"

        Try
            Dim query As String = "select * from processor_items"

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

    Private Sub for_motherboard_Click(sender As Object, e As EventArgs) Handles for_motherboard.Click

        p_name.Text = ""
        p_qty.Text = ""
        p_price.Text = ""
        p_status.Text = ""

        change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
        dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

        current_selection.Text = "Motherboard"


        Try
            Dim query As String = "select * from motherboard_items"

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

    Private Sub for_ram_Click(sender As Object, e As EventArgs) Handles for_ram.Click

        p_name.Text = ""
        p_qty.Text = ""
        p_price.Text = ""
        p_status.Text = ""
        current_selection.Text = "RAM"

        ' The Code Below will fix the adding or displaying in the table
        ' where the problem is continous adding of value in the DataGridView

        change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
        dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared






        Try
            Dim query As String = "select * from ram_items"

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

    Private Sub for_gpu_Click(sender As Object, e As EventArgs) Handles for_gpu.Click
        p_name.Text = ""
        p_qty.Text = ""
        p_price.Text = ""
        p_status.Text = ""
        current_selection.Text = "Graphics Card"

        ' The Code Below will fix the adding or displaying in the table
        ' where the problem is continous adding of value in the DataGridView

        change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
        dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

        Try
            Dim query As String = "select * from gpu_items"

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

    Private Sub for_peripherals_Click(sender As Object, e As EventArgs) Handles for_peripherals.Click

        p_name.Text = ""
        p_qty.Text = ""
        p_price.Text = ""
        p_status.Text = ""

        current_selection.Text = "Peripherals"

        ' The Code Below will fix the adding or displaying in the table
        ' where the problem is continous adding of value in the DataGridView

        change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
        dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

        Try
            Dim query As String = "select * from peripheral_items"

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

    Private Sub change_items_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles change_items.CellClick
        If e.RowIndex >= 0 Then

            p_name.Text = change_items.Rows(e.RowIndex).Cells(0).Value
            p_qty.Text = change_items.Rows(e.RowIndex).Cells(1).Value
            p_price.Text = change_items.Rows(e.RowIndex).Cells(2).Value
            p_status.Text = change_items.Rows(e.RowIndex).Cells(3).Value

            invisible_data.Text = p_name.Text
            ' Make an Invisible label to transfer the old data a    nd retrieve it 
            ' for later use (commonly in DATABASE)
            ' invisible_data.Text = id_cust.Text
        End If
    End Sub

    Private Sub p_add_Click(sender As Object, e As EventArgs) Handles p_add.Click
        Dim dt As New DataTable()
        Dim get_name As String = p_name.Text
        Dim get_qty As String = p_qty.Text
        Dim get_price As String = p_price.Text
        Dim get_status As String = p_status.Text
        Dim checked As String = ""
        conn.Open()


        If current_selection.Text.Equals("Processor") Then
            ' PROCESSOR
            If get_name.Equals("") And get_qty.Equals("") And get_status.Equals("") Then
                MessageBox.Show("ERROR: Please Input the Fields", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p_name.Focus()
            Else
                Try
                    Dim query As String = "INSERT INTO processor_items (item_name,qty,price,status) VALUE (" & "'" & get_name & "'" & "," & "'" & get_qty & "'" & "," & "'" & get_price _
                       & "'" & "," & "'" & get_status & "')"

                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery() ' Execute the query

                    checked = MessageBox.Show("Successfully Added", "Adding Items", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If checked.Equals("1") Then
                        p_name.Clear()
                        p_qty.Clear()
                        p_price.Clear()
                        p_status.Text = ""

                    End If


                    conn.Close()
                    conn.Dispose()
                Catch ex As MySqlException
                    MessageBox.Show("The Data is already inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
                dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

                ' Update The DataGridView Table(customer_list)
                Try
                    Dim query As String = "select * from processor_items"

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
                    conn.Dispose()
                Catch ex As Exception
                    MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try



            End If

        ElseIf current_selection.Text.Equals("Motherboard") Then
            '  ############## MOTHERBOARD ################

            If get_name.Equals("") And get_qty.Equals("") And get_status.Equals("") Then
                MessageBox.Show("ERROR: Please Input the Fields", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p_name.Focus()
            Else
                Try
                    Dim query As String = "INSERT INTO motherboard_items (item_name,qty,price,status) VALUE (" & "'" & get_name & "'" & "," & "'" & get_qty & "'" & "," & "'" & get_price _
                       & "'" & "," & "'" & get_status & "')"

                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery() ' Execute the query

                    checked = MessageBox.Show("Successfully Added", "Adding Items", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If checked.Equals("1") Then
                        p_name.Clear()
                        p_qty.Clear()
                        p_price.Clear()
                        p_status.Text = ""

                    End If


                    conn.Close()
                    conn.Dispose()
                Catch ex As MySqlException
                    MessageBox.Show("The Data is already inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
                dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

                ' Update The DataGridView Table(customer_list)
                Try
                    Dim query As String = "select * from motherboard_items"

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
                    conn.Dispose()
                Catch ex As Exception
                    MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try



            End If

        ElseIf current_selection.Text.Equals("RAM") Then
            ' ########### RAM ###############

            If get_name.Equals("") And get_qty.Equals("") And get_status.Equals("") Then
                MessageBox.Show("ERROR: Please Input the Fields", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p_name.Focus()
            Else
                Try
                    Dim query As String = "INSERT INTO ram_items (item_name,qty,price,status) VALUE (" & "'" & get_name & "'" & "," & "'" & get_qty & "'" & "," & "'" & get_price _
                       & "'" & "," & "'" & get_status & "')"

                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery() ' Execute the query

                    checked = MessageBox.Show("Successfully Added", "Adding Items", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If checked.Equals("1") Then
                        p_name.Clear()
                        p_qty.Clear()
                        p_price.Clear()
                        p_status.Text = ""

                    End If


                    conn.Close()
                    conn.Dispose()
                Catch ex As MySqlException
                    MessageBox.Show("The Data is already inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
                dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

                ' Update The DataGridView Table(customer_list)
                Try
                    Dim query As String = "select * from ram_items"

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
                    conn.Dispose()
                Catch ex As Exception
                    MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try



            End If
        ElseIf current_selection.Text.Equals("Graphics Card") Then
            ' ########### Graphics Card ###############

            If get_name.Equals("") And get_qty.Equals("") And get_status.Equals("") Then
                MessageBox.Show("ERROR: Please Input the Fields", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p_name.Focus()
            Else
                Try
                    Dim query As String = "INSERT INTO gpu_items (item_name,qty,price,status) VALUE (" & "'" & get_name & "'" & "," & "'" & get_qty & "'" & "," & "'" & get_price _
                       & "'" & "," & "'" & get_status & "')"

                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery() ' Execute the query

                    checked = MessageBox.Show("Successfully Added", "Adding Items", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If checked.Equals("1") Then
                        p_name.Clear()
                        p_qty.Clear()
                        p_price.Clear()
                        p_status.Text = ""

                    End If


                    conn.Close()
                    conn.Dispose()
                Catch ex As MySqlException
                    MessageBox.Show("The Data is already inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
                dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

                ' Update The DataGridView Table(customer_list)
                Try
                    Dim query As String = "select * from gpu_items"

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
                    conn.Dispose()
                Catch ex As Exception
                    MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try



            End If

        ElseIf current_selection.Text.Equals("Peripherals") Then
            ' ########### PERIPHERALS ###############

            If get_name.Equals("") And get_qty.Equals("") And get_status.Equals("") Then
                MessageBox.Show("ERROR: Please Input the Fields", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p_name.Focus()
            Else
                Try
                    Dim query As String = "INSERT INTO peripheral_items (item_name,qty,price,status) VALUE (" & "'" & get_name & "'" & "," & "'" & get_qty & "'" & "," & "'" & get_price _
                       & "'" & "," & "'" & get_status & "')"

                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery() ' Execute the query

                    checked = MessageBox.Show("Successfully Added", "Adding Items", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If checked.Equals("1") Then
                        p_name.Clear()
                        p_qty.Clear()
                        p_price.Clear()
                        p_status.Text = ""

                    End If


                    conn.Close()
                    conn.Dispose()
                Catch ex As MySqlException
                    MessageBox.Show("The Data is already inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
                dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

                ' Update The DataGridView Table(customer_list)
                Try
                    Dim query As String = "select * from peripheral_items"

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
                    conn.Dispose()
                Catch ex As Exception
                    MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try



            End If

        End If

        conn.Close()
    End Sub

    Private Sub p_delete_Click(sender As Object, e As EventArgs) Handles p_delete.Click
        ' DELETE

        Dim dt As New DataTable()
        Dim get_name As String = p_name.Text
        Dim get_qty As String = p_qty.Text
        Dim get_price As String = p_price.Text
        Dim get_status As String = p_status.Text
        Dim checked As String = ""
        conn.Open()


        If current_selection.Text.Equals("Processor") Then

            ' ########### Processor ###############

            If get_name.Equals("") And get_qty.Equals("") And get_status.Equals("") Then
                MessageBox.Show("ERROR: Please Input the Fields", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p_name.Focus()
            Else
                Try
                    Dim query As String = "DELETE FROM processor_items WHERE item_name = " & "'" & invisible_data.Text & "'"

                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery() ' Execute the query

                    checked = MessageBox.Show("Successfully Deleted", "Deleting Items", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If checked.Equals("1") Then
                        p_name.Clear()
                        p_qty.Clear()
                        p_price.Clear()
                        p_status.Text = ""

                    End If


                    conn.Close()
                    conn.Dispose()
                Catch ex As MySqlException
                    MessageBox.Show("The Data is already Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
                dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

                ' Update The DataGridView Table(customer_list)
                Try
                    Dim query As String = "select * from processor_items"

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
                    conn.Dispose()
                Catch ex As Exception
                    MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try



            End If


        ElseIf current_selection.Text.Equals("Motherboard") Then

            ' ########### MOTHERBOARD ###############

            If get_name.Equals("") And get_qty.Equals("") And get_status.Equals("") Then
                MessageBox.Show("ERROR: Please Input the Fields", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p_name.Focus()
            Else
                Try
                    Dim query As String = "DELETE FROM motherboard_items WHERE item_name = " & "'" & invisible_data.Text & "'"

                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery() ' Execute the query

                    checked = MessageBox.Show("Successfully Deleted", "Deleting Items", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If checked.Equals("1") Then
                        p_name.Clear()
                        p_qty.Clear()
                        p_price.Clear()
                        p_status.Text = ""

                    End If


                    conn.Close()
                    conn.Dispose()
                Catch ex As MySqlException
                    MessageBox.Show("The Data is already Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
                dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

                ' Update The DataGridView Table(customer_list)
                Try
                    Dim query As String = "select * from motherboard_items"

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
                    conn.Dispose()
                Catch ex As Exception
                    MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try



            End If






        ElseIf current_selection.Text.Equals("RAM") Then

            ' ########### MOTHERBOARD ###############

            If get_name.Equals("") And get_qty.Equals("") And get_status.Equals("") Then
                MessageBox.Show("ERROR: Please Input the Fields", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p_name.Focus()
            Else
                Try
                    Dim query As String = "DELETE FROM ram_items WHERE item_name = " & "'" & invisible_data.Text & "'"

                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery() ' Execute the query

                    checked = MessageBox.Show("Successfully Deleted", "Deleting Items", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If checked.Equals("1") Then
                        p_name.Clear()
                        p_qty.Clear()
                        p_price.Clear()
                        p_status.Text = ""

                    End If


                    conn.Close()
                    conn.Dispose()
                Catch ex As MySqlException
                    MessageBox.Show("The Data is already Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
                dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

                ' Update The DataGridView Table(customer_list)
                Try
                    Dim query As String = "select * from ram_items"

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
                    conn.Dispose()
                Catch ex As Exception
                    MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try



            End If






        ElseIf current_selection.Text.Equals("Graphics Card") Then

            ' ########### GPU ###############

            If get_name.Equals("") And get_qty.Equals("") And get_status.Equals("") Then
                MessageBox.Show("ERROR: Please Input the Fields", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p_name.Focus()
            Else
                Try
                    Dim query As String = "DELETE FROM gpu_items WHERE item_name = " & "'" & invisible_data.Text & "'"

                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery() ' Execute the query

                    checked = MessageBox.Show("Successfully Deleted", "Deleting Items", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If checked.Equals("1") Then
                        p_name.Clear()
                        p_qty.Clear()
                        p_price.Clear()
                        p_status.Text = ""

                    End If


                    conn.Close()
                    conn.Dispose()
                Catch ex As MySqlException
                    MessageBox.Show("The Data is already Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
                dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

                ' Update The DataGridView Table(customer_list)
                Try
                    Dim query As String = "select * from gpu_items"

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
                    conn.Dispose()
                Catch ex As Exception
                    MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try



            End If





        ElseIf current_selection.Text.Equals("Peripherals") Then

            ' ########### Peripherals ###############

            If get_name.Equals("") And get_qty.Equals("") And get_status.Equals("") Then
                MessageBox.Show("ERROR: Please Input the Fields", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p_name.Focus()
            Else
                Try
                    Dim query As String = "DELETE FROM peripheral_items WHERE item_name = " & "'" & invisible_data.Text & "'"

                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery() ' Execute the query

                    checked = MessageBox.Show("Successfully Deleted", "Deleting Items", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If checked.Equals("1") Then
                        p_name.Clear()
                        p_qty.Clear()
                        p_price.Clear()
                        p_status.Text = ""

                    End If


                    conn.Close()
                    conn.Dispose()
                Catch ex As MySqlException
                    MessageBox.Show("The Data is already Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
                dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

                ' Update The DataGridView Table(customer_list)
                Try
                    Dim query As String = "select * from peripheral_items"

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
                    conn.Dispose()
                Catch ex As Exception
                    MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End If
        End If


        conn.Close()
    End Sub

    Private Sub p_update_Click(sender As Object, e As EventArgs) Handles p_update.Click

        Dim dt As New DataTable()
        Dim get_name As String = p_name.Text
        Dim get_qty As String = p_qty.Text
        Dim get_price As String = p_price.Text
        Dim get_status As String = p_status.Text
        Dim checked As String = ""
        conn.Open()

        If current_selection.Text.Equals("Processor") Then

            ' ########### PROCESSOR ###############

            If get_name.Equals("") And get_qty.Equals("") And get_status.Equals("") Then
                MessageBox.Show("ERROR: Please Input the Fields", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p_name.Focus()
            Else
                Try
                    Dim query As String = "UPDATE processor_items SET item_name = " & "'" & get_name & "'" & "," & "qty = " & "'" & get_qty & "'" _
                    & "," & "price = " & "'" & get_price & "'" & "," & "status = " & "'" & get_status & "'" & "WHERE item_name = " & "'" & invisible_data.Text & "'"

                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery() ' Execute the query

                    checked = MessageBox.Show("Successfully Updated", "Updating Items", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If checked.Equals("1") Then
                        p_name.Clear()
                        p_qty.Clear()
                        p_price.Clear()
                        p_status.Text = ""

                    End If


                    conn.Close()
                    conn.Dispose()
                Catch ex As MySqlException
                    MessageBox.Show("The Data is already Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
                dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

                ' Update The DataGridView Table(customer_list)
                Try
                    Dim query As String = "select * from processor_items"

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
                    conn.Dispose()
                Catch ex As Exception
                    MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End If


        ElseIf current_selection.Text.Equals("Motherboard") Then

            ' ########### PROCESSOR ###############

            If get_name.Equals("") And get_qty.Equals("") And get_status.Equals("") Then
                MessageBox.Show("ERROR: Please Input the Fields", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p_name.Focus()
            Else
                Try
                    Dim query As String = "UPDATE motherboard_items SET item_name = " & "'" & get_name & "'" & "," & "qty = " & "'" & get_qty & "'" _
                    & "," & "price = " & "'" & get_price & "'" & "," & "status = " & "'" & get_status & "'" & "WHERE item_name = " & "'" & invisible_data.Text & "'"

                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery() ' Execute the query

                    checked = MessageBox.Show("Successfully Updated", "Updating Items", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If checked.Equals("1") Then
                        p_name.Clear()
                        p_qty.Clear()
                        p_price.Clear()
                        p_status.Text = ""

                    End If


                    conn.Close()
                    conn.Dispose()
                Catch ex As MySqlException
                    MessageBox.Show("The Data is already Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
                dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

                ' Update The DataGridView Table(customer_list)
                Try
                    Dim query As String = "select * from motherboard_items"

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
                    conn.Dispose()
                Catch ex As Exception
                    MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End If





        ElseIf current_selection.Text.Equals("RAM") Then
            ' ########### PROCESSOR ###############

            If get_name.Equals("") And get_qty.Equals("") And get_status.Equals("") Then
                MessageBox.Show("ERROR: Please Input the Fields", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p_name.Focus()
            Else
                Try
                    Dim query As String = "UPDATE ram_items SET item_name = " & "'" & get_name & "'" & "," & "qty = " & "'" & get_qty & "'" _
                    & "," & "price = " & "'" & get_price & "'" & "," & "status = " & "'" & get_status & "'" & "WHERE item_name = " & "'" & invisible_data.Text & "'"

                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery() ' Execute the query

                    checked = MessageBox.Show("Successfully Updated", "Updating Items", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If checked.Equals("1") Then
                        p_name.Clear()
                        p_qty.Clear()
                        p_price.Clear()
                        p_status.Text = ""

                    End If


                    conn.Close()
                    conn.Dispose()
                Catch ex As MySqlException
                    MessageBox.Show("The Data is already Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
                dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

                ' Update The DataGridView Table(customer_list)
                Try
                    Dim query As String = "select * from ram_items"

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
                    conn.Dispose()
                Catch ex As Exception
                    MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End If

        ElseIf current_selection.Text.Equals("Graphics Card") Then
            ' ########### PROCESSOR ###############

            If get_name.Equals("") And get_qty.Equals("") And get_status.Equals("") Then
                MessageBox.Show("ERROR: Please Input the Fields", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p_name.Focus()
            Else
                Try
                    Dim query As String = "UPDATE gpu_items SET item_name = " & "'" & get_name & "'" & "," & "qty = " & "'" & get_qty & "'" _
                    & "," & "price = " & "'" & get_price & "'" & "," & "status = " & "'" & get_status & "'" & "WHERE item_name = " & "'" & invisible_data.Text & "'"

                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery() ' Execute the query

                    checked = MessageBox.Show("Successfully Updated", "Updating Items", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If checked.Equals("1") Then
                        p_name.Clear()
                        p_qty.Clear()
                        p_price.Clear()
                        p_status.Text = ""

                    End If


                    conn.Close()
                    conn.Dispose()
                Catch ex As MySqlException
                    MessageBox.Show("The Data is already Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
                dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

                ' Update The DataGridView Table(customer_list)
                Try
                    Dim query As String = "select * from gpu_items"

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
                    conn.Dispose()
                Catch ex As Exception
                    MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End If
        ElseIf current_selection.Text.Equals("Peripherals") Then
            ' ########### PROCESSOR ###############

            If get_name.Equals("") And get_qty.Equals("") And get_status.Equals("") Then
                MessageBox.Show("ERROR: Please Input the Fields", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
                p_name.Focus()
            Else
                Try
                    Dim query As String = "UPDATE peripheral_items SET item_name = " & "'" & get_name & "'" & "," & "qty = " & "'" & get_qty & "'" _
                    & "," & "price = " & "'" & get_price & "'" & "," & "status = " & "'" & get_status & "'" & "WHERE item_name = " & "'" & invisible_data.Text & "'"

                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery() ' Execute the query

                    checked = MessageBox.Show("Successfully Updated", "Updating Items", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If checked.Equals("1") Then
                        p_name.Clear()
                        p_qty.Clear()
                        p_price.Clear()
                        p_status.Text = ""

                    End If


                    conn.Close()
                    conn.Dispose()
                Catch ex As MySqlException
                    MessageBox.Show("The Data is already Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                change_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
                dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

                ' Update The DataGridView Table(customer_list)
                Try
                    Dim query As String = "select * from peripheral_items"

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
                    conn.Dispose()
                Catch ex As Exception
                    MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End If
        End If

        conn.Close()
    End Sub
End Class