Class MainWindow 
    Private ventanaRegistro As RegistroUsuario
    Private ventanaCliente As VentanaCliente

    Private Sub btnSignin_Click(sender As Object, e As RoutedEventArgs) Handles btnSignin.Click
        ventanaRegistro = New RegistroUsuario
        ventanaRegistro.Owner = Me
        ventanaRegistro.Show()
        Me.IsEnabled = False

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As RoutedEventArgs) Handles btnLogin.Click
        ventanaCliente = New VentanaCliente
        ventanaCliente.Owner = Me
        ventanaCliente.Show()
        Me.Hide()

    End Sub


    Private Sub txtUser_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtUser.GotFocus
        If txtUser.Text = "usuario" Then
            txtUser.Text = String.Empty
        End If

    End Sub

    Private Sub txtUser_LostFocus(sender As Object, e As RoutedEventArgs) Handles txtUser.LostFocus
        If txtUser.Text = String.Empty Then
            txtUser.Text = "usuario"
        End If
    End Sub

    Private Sub txtUser_PreviewKeyDown(sender As Object, e As KeyEventArgs) Handles txtUser.PreviewKeyDown
        If e.Key = Key.Space Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPass_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtPass.GotFocus
        If txtPass.Password = "visual" Then
            txtPass.Password = String.Empty
        End If
    End Sub

    Private Sub txtPass_LostFocus(sender As Object, e As RoutedEventArgs) Handles txtPass.LostFocus
        If txtPass.Password = String.Empty Then
            txtPass.Password = "visual"
        End If
    End Sub

    Private Sub txtPass_PreviewKeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.PreviewKeyDown
        If e.Key = Key.Space Then
            e.Handled = True
        End If
    End Sub
End Class
