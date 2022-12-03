Public Class registerForm
    Private Sub registerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub linkLogin_Click(sender As Object, e As EventArgs) Handles linkLogin.Click
        loginForm.Show()
        loginForm.Activate()
        Me.Hide()
    End Sub

    Private Sub registerButton_Click(sender As Object, e As EventArgs) Handles registerButton.Click
        Call register(txtUsername.Text, txtPassword.Text, txtConfirm.Text)
    End Sub
End Class