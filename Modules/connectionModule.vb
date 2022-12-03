Imports MySql.Data.MySqlClient

Module connectionModule
    Public connection As MySqlConnection
    Public mysqlDataAdapter As MySqlDataAdapter
    Public mysqlReader As MySqlDataReader
    Public isLoggedIn = False

    Public Sub DbConnect()
        Try
            connection = New MySqlConnection
            connection.ConnectionString = "server=localhost;user=root;password=;database=inventory_management_system"
            connection.Open()
        Catch e As Exception
            MsgBox("Something wen't wrong in the server. Please Comeback later")
            connection.Close()
        End Try
    End Sub

End Module
