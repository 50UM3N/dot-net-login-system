Imports MySql.Data
Imports MySql.Data.MySqlClient
Module SQL
    Public con As New MySqlConnection 'for mysql connection
    Public cmd As New MySqlCommand 'for mysql quary
    Public dr As MySqlDataReader ' data reader for sql data
    ' above tw lines are used when we show the data on data grid
    'Public dt As New DataTable() 'for get the date in the data table
    'Public da As MySqlDataAdapter 'data adapter request a set of data from server
    Sub main()
        con.ConnectionString = "server=localhost;user=root;database=vb.net;"
        Try
            con.Open() 'opening connection
            MsgBox("Connected...")
            con.Close() 'closing connection
        Catch ex As MySqlException 'mysql exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
