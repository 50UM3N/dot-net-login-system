Imports MySql.Data.MySqlClient
Public Class login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        main()
    End Sub
    Private Sub clean()
        textUsername.ForeColor = Color.DimGray
        textUsername.Text = "Username/E-mail"
        textPassword.ForeColor = Color.DimGray
        textPassword.PasswordChar = ""
        textPassword.Text = "Password"
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSignup.LinkClicked
        signup.Show()
        Me.Hide()
    End Sub

    Private Sub GunaTextBox1_GotFocus(sender As Object, e As EventArgs) Handles textUsername.GotFocus
        If textUsername.Text = "Username/E-mail" Then
            textUsername.Text = ""
            textUsername.ForeColor = ColorTranslator.FromHtml("#EA1646")
        End If
    End Sub

    Private Sub GunaTextBox1_LostFocus(sender As Object, e As EventArgs) Handles textUsername.LostFocus
        If textUsername.Text = "" Then
            textUsername.Text = "Username/E-mail"
            textUsername.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub GunaTextBox2_GotFocus(sender As Object, e As EventArgs) Handles textPassword.GotFocus
        If textPassword.Text = "Password" Then
            textPassword.Text = ""
            textPassword.PasswordChar = "*"
            textPassword.ForeColor = ColorTranslator.FromHtml("#EA1646")
        End If
    End Sub

    Private Sub GunaTextBox2_LostFocus(sender As Object, e As EventArgs) Handles textPassword.LostFocus
        If textPassword.Text = "" Then
            textPassword.PasswordChar = Nothing
            textPassword.Text = "Password"
            textPassword.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'con.Open()
        'cmd = con.CreateCommand()
        'cmd.CommandType = CommandType.Text
        'cmd.CommandText = "select * from users"
        'cmd.ExecuteNonQuery()
        'da = New MySqlDataAdapter(cmd)
        'da.Fill(dt)
        'DataGridView1.DataSource = dt
        'con.Close()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If textUsername.Text <> "Username/E-mail" Then
            If textPassword.PasswordChar = "*" Then
                con.Open()
                cmd = con.CreateCommand
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "select * from users where uname='" + textUsername.Text + "' and pwd='" + textPassword.Text + "'"
                cmd.ExecuteNonQuery()
                dr = cmd.ExecuteReader ' this helps to read data from mysql server
                If dr.HasRows Then  ' check that it has any row 
                    dr.Read()
                    welcome.Show()
                    clean()
                    Me.Hide()
                Else
                    message.Text = "Invalid Cradentials"
                    con.Close()
                    clean()
                End If
            Else
                message.Text = "Enter *Password"
                con.Close()
                clean()
            End If
        Else
            message.Text = "Enter *Username"
            con.Close()
            clean()
        End If
    End Sub

End Class
