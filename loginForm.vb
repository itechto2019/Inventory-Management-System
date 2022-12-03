Public Class loginForm
    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Call login(txtUsername.Text, txtPassword.Text)
    End Sub

    Private Sub linkRegister_Click(sender As Object, e As EventArgs) Handles linkRegister.Click
        registerForm.Show()
        registerForm.Activate()
        Me.Hide()

    End Sub

End Class
