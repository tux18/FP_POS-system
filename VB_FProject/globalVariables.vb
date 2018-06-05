Module globalVariables
    Public global_name As String = "Customer Name"
    Public global_contact As String = "Contact Number"
    Public global_gender As String = "Gender"
    Public global_login_user As String = "User Name"
    Public global_status_admin As String = ""
    Public global_table_name As String = ""
    Public global_overall_total As Integer ' This will handle to overall total of purchased items
    ' MAKE THE GLOBAL Object of DATAGRIDVIEW to ACCESS IT TO ANY FORM
    Public global_customer_items As Object
    Public global_system_items As Object
    ' GLOBAL SELECTION FOR system_items
    Public global_pname As String = ""
    Public global_qty As String = ""
    Public global_price As String = ""
    Public global_status As String = ""

End Module
