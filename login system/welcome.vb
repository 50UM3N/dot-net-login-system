Public Class welcome
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        con.Close()
        login.Show()
        Close()
    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        login.Close()
        Close()
    End Sub

    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picture.Visible = False
        picture.Location = New Point(36, 131)
        Label2.Text = dr.GetString(0)
        Label3.Text = dr.GetString(1)
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        If picture.Visible = False Then
            picture.Visible = True
        ElseIf picture.Visible = True Then
            picture.Visible = False
        End If
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        PictureBox2.Image = My.Resources.pomeranian
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        PictureBox2.Image = My.Resources.poodle
    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        PictureBox2.Image = My.Resources.pug
    End Sub

    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles GunaButton6.Click
        PictureBox2.Image = My.Resources.beagle
    End Sub
End Class