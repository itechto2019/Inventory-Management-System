Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Module AuthenticationModule
    Dim loginAttempt = 0
    Public now = DateTime.Now
    Function toMD5(password As String) As String
        Using hasher As SHA256 = SHA256.Create()
            Dim dbytes As Byte() = hasher.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim stringMake As New StringBuilder()
            For i As Integer = 0 To dbytes.Length - 1
                stringMake.Append(dbytes(i).ToString("X2"))
            Next i

            Return stringMake.ToString()
        End Using
    End Function
    Public Sub loggedIn()
        Try
            DbConnect()
            Dim sql = "insert into historys (title, description, created_at, updated_at) values ('Login' , 'Admin logged In',@created_at,@updated_at)"
            Dim mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Parameters.Add("@created_at", MySqlDbType.DateTime).Value = DateTime.Now()
                .Parameters.Add("@updated_at", MySqlDbType.DateTime).Value = DateTime.Now()
                .Prepare()
                .ExecuteNonQuery()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub loggedOut()
        Try
            DbConnect()
            Dim sql = "insert into historys (title, description, created_at, updated_at) values ('Logged out' , 'Admin logged out',@created_at,@updated_at)"
            Dim mysqlCommand = New MySqlCommand
            With mysqlCommand
                .CommandText = sql
                .Connection = connection
                .Parameters.Add("@created_at", MySqlDbType.DateTime).Value = DateTime.Now()
                .Parameters.Add("@updated_at", MySqlDbType.DateTime).Value = DateTime.Now()
                .Prepare()
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub login(username, password)
        Try
            DbConnect()
            If isLoggedIn = False And loginAttempt < 3 Then
                loginForm.errorPanel.Visible = False
                loginForm.errorMessage.Text = ""
                Dim sql = "select * from users where username=@username and password=@password"
                Dim mysqlCommand = New MySqlCommand
                Dim data As MySqlDataReader
                With mysqlCommand
                    .CommandText = sql
                    .Connection = connection
                    .Parameters.Add("@username", MySqlDbType.VarChar).Value = username
                    .Parameters.Add("@password", MySqlDbType.VarChar).Value = toMD5(password)
                    .Prepare()
                End With
                Dim result = mysqlCommand.ExecuteScalar
                data = mysqlCommand.ExecuteReader

                If result Then
                    MessageBox.Show("Login successful.", "User validation")
                    loginForm.txtUsername.Text = ""
                    loginForm.txtPassword.Text = ""
                    dashboard.Show()
                    loginForm.Hide()
                    isLoggedIn = True
                    loginAttempt = 0
                    While data.Read()
                        dashboard.lblUser.Text = data("username")
                        loggedIn()
                    End While
                Else
                    loginAttempt += 1
                    loginForm.errorPanel.Visible = True
                    loginForm.errorMessage.Text = "Attempt: " & loginAttempt & " Incorrect credentials"
                End If
            ElseIf isLoggedIn = True Then
                dashboard.Show()
                loginForm.Hide()
                loginAttempt = 0
                loginForm.errorPanel.Visible = True
                registerForm.errorPanel.BackColor = Color.FromArgb(107, 203, 119)

                loginForm.errorMessage.Text = "You're already logged in"
            Else
                loginForm.errorPanel.Visible = True
                loginForm.loginButton.Enabled = False
                loginForm.errorMessage.Text = "Attempt: " & loginAttempt & " Too many login attempts!."
                MessageBox.Show("Too many login attempts!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                loginForm.Dispose()
            End If
        Catch ex As Exception
            MsgBox("Something wen't wrong in the server. Please comeback later." + ex.Message)
        End Try
    End Sub
    Public Sub register(username, password, confirmPassword)
        Try
            DbConnect()
            If isLoggedIn = False Then
                Dim sql = "INSERT INTO users (username,password,role) values(@username,@password,@role)"
                Dim admin = "select username from users where role='admin'"
                Dim mysqlCommand = New MySqlCommand
                If password = confirmPassword Then
                    With mysqlCommand
                        .CommandText = admin
                        .Connection = connection
                        .Prepare()
                    End With
                    Dim checkIsAdmin = mysqlCommand.ExecuteNonQuery
                    If checkIsAdmin Then
                        With mysqlCommand
                            .CommandText = sql
                            .Connection = connection
                            .Parameters.AddWithValue("@username", username)
                            .Parameters.AddWithValue("@password", toMD5(password))
                            .Parameters.AddWithValue("@role", "user")
                            .Prepare()
                        End With
                        Dim result = mysqlCommand.ExecuteNonQueryAsync
                        If result.Result Then
                            registerForm.errorPanel.Visible = True
                            registerForm.errorPanel.BackColor = Color.FromArgb(107, 203, 119)
                            registerForm.errorMessage.Text = "Registration complete."
                            loginForm.Show()
                            registerForm.Dispose()
                        End If
                    Else
                        With mysqlCommand
                            .CommandText = sql
                            .Connection = connection
                            .Parameters.AddWithValue("@username", username)
                            .Parameters.AddWithValue("@password", toMD5(password))
                            .Parameters.AddWithValue("@role", "admin")
                            .Prepare()
                        End With
                        Dim result = mysqlCommand.ExecuteNonQueryAsync
                        If result.Result Then
                            registerForm.errorPanel.Visible = True
                            registerForm.errorPanel.BackColor = Color.FromArgb(107, 203, 119)
                            registerForm.errorMessage.Text = "Registration complete."
                            loginForm.Show()
                            registerForm.Dispose()
                        End If
                    End If
                Else
                    registerForm.txtConfirm.Focus()
                    registerForm.errorPanel.Visible = True
                    registerForm.errorMessage.Text = "Password doesn't match!"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'registerForm.errorPanel.Visible = True
            'registerForm.errorMessage.Text = "Username is already taken."
            'registerForm.txtUsername.Focus()
            'registerForm.txtUsername.Clear()
        End Try
    End Sub
End Module
