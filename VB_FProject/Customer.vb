Imports MySql.Data.MySqlClient

Public Class Customer

    ' Function That will Populate the DataGridView
    Private Sub Populate(parm1 As String, parm2 As String, parm3 As String, parm4 As String, parm5 As String)
        Dim row As String() = New String() {parm1, parm2, parm3, parm4, parm5}
        customer_list.Rows.Add(row)

    End Sub


    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Dim make_connection As String = "datasource=localhost; port=3306; username=root; password=; database=pos_database"
        Dim conn As New MySqlConnection(make_connection)
        Dim cmd As New MySqlCommand
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
        Catch ex As Exception
            MessageBox.Show("ERROR: Not Connected into Database", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub

    Private Sub Customer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cancel_cust.Click
        Me.Dispose() ' Cancel Button
    End Sub


    Private Sub customer_list_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles customer_list.CellClick
        ' Fix the text only by clicking it inside the cell in datagridview to trigger the event
        ' FIX: CellClick Action
        If e.RowIndex >= 0 Then

            id_cust.Text = customer_list.Rows(e.RowIndex).Cells(0).Value
            fullname.Text = customer_list.Rows(e.RowIndex).Cells(1).Value
            c_gender.Text = customer_list.Rows(e.RowIndex).Cells(2).Value
            c_contact_number.Text = customer_list.Rows(e.RowIndex).Cells(3).Value
            full_address.Text = customer_list.Rows(e.RowIndex).Cells(4).Value

        End If

    End Sub
End Class