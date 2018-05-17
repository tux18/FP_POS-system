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


            ' Make an Invisible label to transfer the old data and retrieve it 
            ' for later use (commonly in DATABASE)
            ' invisible_data.Text = id_cust.Text
        End If
    End Sub
End Class