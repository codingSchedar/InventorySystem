Public Class formLOGIN
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtPassword.Text = "test12345" And txtUsername.Text = "wczsantiago" Then
            formMain.ShowDialog()
            Me.Dispose()
        Else
            MessageBox.Show("Invalid Credentials")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class
