Public Class signup
    Private Sub clean()
        textName.ForeColor = Color.DimGray
        textUsername.ForeColor = Color.DimGray
        textPassword.ForeColor = Color.DimGray
        textCPassword.ForeColor = Color.DimGray
        textName.Text = "Name"
        textUsername.Text = "Username"
        textPassword.PasswordChar = Nothing
        textPassword.Text = "Password"
        textCPassword.PasswordChar = Nothing
        textCPassword.Text = "Confirm Password"
    End Sub
    Private Sub GunaTextBox1_GotFocus(sender As Object, e As EventArgs) Handles textName.GotFocus
        If textName.Text = "Name" Then
            textName.Text = ""
            textName.ForeColor = ColorTranslator.FromHtml("#EA1646")
        End If
    End Sub

    Private Sub GunaTextBox1_LostFocus(sender As Object, e As EventArgs) Handles textName.LostFocus
        If textName.Text = "" Then
            textName.Text = "Name"
            textName.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub GunaTextBox2_GotFocus(sender As Object, e As EventArgs) Handles textUsername.GotFocus
        If textUsername.Text = "Username" Then
            textUsername.Text = ""
            textUsername.ForeColor = ColorTranslator.FromHtml("#EA1646")
        End If
    End Sub

    Private Sub GunaTextBox2_LostFocus(sender As Object, e As EventArgs) Handles textUsername.LostFocus
        If textUsername.Text = "" Then
            textUsername.Text = "Username"
            textUsername.ForeColor = Color.DimGray
        End If
    End Sub
    Private Sub GunaTextBox3_GotFocus(sender As Object, e As EventArgs) Handles textPassword.GotFocus
        If textPassword.Text = "Password" Then
            textPassword.Text = ""
            textPassword.PasswordChar = "*"
            textPassword.ForeColor = ColorTranslator.FromHtml("#EA1646")
        End If
    End Sub

    Private Sub GunaTextBox3_LostFocus(sender As Object, e As EventArgs) Handles textPassword.LostFocus
        If textPassword.Text = "" Then
            textPassword.PasswordChar = Nothing
            textPassword.Text = "Password"
            textPassword.ForeColor = Color.DimGray
        End If
    End Sub
    Private Sub GunaTextBox4_GotFocus(sender As Object, e As EventArgs) Handles textCPassword.GotFocus
        If textCPassword.Text = "Confirm Password" Then
            textCPassword.Text = ""
            textCPassword.PasswordChar = "*"
            textCPassword.ForeColor = ColorTranslator.FromHtml("#EA1646")
        End If
    End Sub

    Private Sub GunaTextBox4_LostFocus(sender As Object, e As EventArgs) Handles textCPassword.LostFocus
        If textCPassword.Text = "" Then
            textCPassword.PasswordChar = Nothing
            textCPassword.Text = "Confirm Password"
            textCPassword.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        login.Close()
        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLogin.LinkClicked
        login.Show()
        Me.Close()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        If textName.Text <> "Name" Then
            If textUsername.Text <> "Username" Then
                If textPassword.PasswordChar = "*" Then
                    If textCPassword.PasswordChar = "*" Then
                        If textPassword.Text = textCPassword.Text Then
                            con.Open()
                            cmd = con.CreateCommand
                            cmd.CommandType = CommandType.Text
                            cmd.CommandText = "insert into users values('" + textName.Text + "','" + textUsername.Text + "','" + textPassword.Text + "')"
                            cmd.ExecuteReader()
                            MsgBox("Inserted")
                            clean()
                        Else
                            message.Text = "Password Not matched"
                        End If
                    Else
                        message.Text = "Retype the password"
                    End If
                Else
                    message.Text = "Enter *Password"
                    clean()
                End If
            Else
                message.Text = "Enter *Username"
                clean()
            End If
        Else
            message.Text = "Enter *Name"
            clean()
        End If
    End Sub
End Class