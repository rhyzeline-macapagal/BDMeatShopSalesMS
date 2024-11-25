Imports MySqlConnector

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtuname.Text = "" OrElse txtpword.Text = "" Then
            MessageBox.Show("Please fill in all fields!", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                Dim login As String
                login = "SELECT `password` FROM `accounts` WHERE `username` = '" & txtuname.Text & "' And `password` = '" & txtpword.Text & "'"
                query = New MySqlCommand(login, con)
                MessageBox.Show("Login Successful", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Homepage.Show()
                Me.Hide()
            Catch ex As Exception
                ' Handle exceptions here
                MessageBox.Show("Login Failed, Please Try Again.", "System Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End Try
        End If
    End Sub

    Private Sub lbluname_Click(sender As Object, e As EventArgs) Handles lbluname.Click

    End Sub

    Private Sub lblpword_Click(sender As Object, e As EventArgs) Handles lblpword.Click

    End Sub

    Private Sub txtuname_TextChanged(sender As Object, e As EventArgs) Handles txtuname.TextChanged

    End Sub



End Class
