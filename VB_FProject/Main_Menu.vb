Imports MySql.Data.MySqlClient

Public Class Main_Menu

    Dim make_connection As String = "datasource=localhost; port=3306; username=root; password=; database=pos_database"
    Dim conn As New MySqlConnection(make_connection)
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable()
    ' Public val1 As String
    ' Public val2 As String
    'Public val3 As String
    ' Function That will Populate the DataGridView
    Private Sub Populate(name As String, qty As String, price As String, status As String)
        Dim row As String() = New String() {name, qty, price, status}
        system_items.Rows.Add(row)

    End Sub

    Public db_tname As String



    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        tooltip.SetToolTip(main_logout, "Log Out")
        display_name.Text = global_name
        display_contact.Text = global_contact
        display_gender.Text = global_gender
        user_name.Text = global_login_user
        global_customer_items = customer_items
        global_system_items = system_items
    End Sub

    Private Sub Main_Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub main_logout_MouseClick(sender As Object, e As MouseEventArgs) Handles main_logout.MouseClick
        Me.Hide()
        Dim main = New Login_Interface()

        main.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles for_processor.Click

        ' The Code Below will fix the adding or displaying in the table
        ' where the problem is continous adding of value in the DataGridView

        system_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
        dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared



        global_table_name = "processor_items"
        change_name.Text = "Processor"

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles for_motherboard.Click
        ' The Code Below will fix the adding or displaying in the table
        ' where the problem is continous adding of value in the DataGridView

        system_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
        dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared

        change_name.Text = "Motherboard"
        global_table_name = "motherboard_items"

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles for_ram.Click
        change_name.Text = "RAM"
        global_table_name = "ram_items"
        ' The Code Below will fix the adding or displaying in the table
        ' where the problem is continous adding of value in the DataGridView

        system_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles for_gpu.Click
        change_name.Text = "Graphics Card"
        global_table_name = "gpu_items"
        ' The Code Below will fix the adding or displaying in the table
        ' where the problem is continous adding of value in the DataGridView

        system_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
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

    Private Sub payment_Click(sender As Object, e As EventArgs) Handles payment.Click
        Dim purchased = New Purchased_Items()
        purchased.ShowDialog()
    End Sub

    Private Sub Customer_btn_Click(sender As Object, e As EventArgs) Handles Customer_btn.Click
        ' Testing
        'Dim customer = New Customer_Info()
        'customer.ShowDialog()

        Dim customer = New Customer()
        customer.Show()
        Me.Dispose()


    End Sub

    Private Sub purchase_Click(sender As Object, e As EventArgs) Handles purchase.Click

        Dim a As Integer
        Dim b As Integer
        Dim get_name As String
        Dim get_qty As Integer
        Dim get_price As Integer
        Dim get_status As String

        Try
            a = system_items.CurrentRow.Index
            Dim p_item = New selected_item

            get_name = system_items.Rows(a).Cells(0).Value
            get_qty = system_items.Rows(a).Cells(1).Value
            get_price = system_items.Rows(a).Cells(2).Value
            get_status = system_items.Rows(a).Cells(3).Value

            p_item.pname.Text = get_name
            p_item.qty.Text = get_qty
            p_item.price.Text = get_price
            p_item.status.Text = get_status


            p_item.Show()

        Catch ex As Exception
            MessageBox.Show("Please Select in the Table to Purchase the item",
                   "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        'MsgBox(db_tname)












    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim obj As New Crud()
        obj.Show()
    End Sub

    Private Sub peripherals_Click(sender As Object, e As EventArgs) Handles peripherals.Click
        change_name.Text = "Peripherals"
        global_table_name = "peripheral_items"
        ' The Code Below will fix the adding or displaying in the table
        ' where the problem is continous adding of value in the DataGridView

        system_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
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



    Private Sub system_items_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles system_items.CellClick



    End Sub
End Class