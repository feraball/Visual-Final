Class MainWindow 

    Private ventanaCliente As VentanaCliente

    Dim imagenCorrecto As BitmapImage = New BitmapImage(New Uri("Assets/check.png", UriKind.Relative))
    Dim imagenError As BitmapImage = New BitmapImage(New Uri("Assets/error.png", UriKind.Relative))

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



    Private Sub txtNewPass1_LostFocus(sender As Object, e As RoutedEventArgs) Handles txtNewPass1.LostFocus
        If txtNewPass1.Password = String.Empty Then
            imgPass1.Visibility = Windows.Visibility.Hidden
        End If
    End Sub

    Private Sub txtNewPass2_PreviewKeyUp(sender As Object, e As KeyEventArgs) Handles txtNewPass2.PreviewKeyUp
        imgPass2.Visibility = Windows.Visibility.Visible
        If txtNewPass1.Password = txtNewPass2.Password Then
            imgPass2.Source = imagenCorrecto
        Else
            imgPass2.Source = imagenError
        End If
    End Sub

    Private Sub txtNewPass1_PreviewKeyUp(sender As Object, e As KeyEventArgs) Handles txtNewPass1.PreviewKeyUp
        If Not (txtNewPass1.Password = String.Empty) Then
            imgPass1.Visibility = Windows.Visibility.Visible
            imgPass1.Source = imagenCorrecto
        End If
    End Sub
End Class
