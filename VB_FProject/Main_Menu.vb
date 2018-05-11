Imports MySql.Data.MySqlClient

Public Class Main_Menu

    Dim make_connection As String = "datasource=localhost; port=3306; username=root; password=; database=pos_database"
    Dim conn As New MySqlConnection(make_connection)
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable()


    ' Function That will Populate the DataGridView
    Private Sub Populate(name As String, qty As String, price As String, status As String)
        Dim row As String() = New String() {name, qty, price, status}
        system_items.Rows.Add(row)

    End Sub



    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        tooltip.SetToolTip(main_logout, "Log Out")
        tooltip.SetToolTip(info, "Information About the System")

    End Sub

    Private Sub Main_Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub main_logout_MouseClick(sender As Object, e As MouseEventArgs) Handles main_logout.MouseClick
        Me.Hide()
        Dim main = New Main_Form()

        main.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles for_processor.Click

        ' The Code Below will fix the adding or displaying in the table
        ' where the problem is continous adding of value in the DataGridView

        system_items.Rows.Clear() ' The DataGridView will Clear all the Remaining Data
        dt.Rows.Clear() ' Data Table that holds the value from Data Source will be cleared




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

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles for_gpu.Click
        change_name.Text = "Graphics Card"
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
        customer.ShowDialog()


    End Sub

    Private Sub purchase_Click(sender As Object, e As EventArgs) Handles purchase.Click

    End Sub


End Class