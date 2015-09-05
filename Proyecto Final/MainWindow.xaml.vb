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
            txtUser.Foreground = Brushes.White
        End If

    End Sub

    Private Sub txtUser_LostFocus(sender As Object, e As RoutedEventArgs) Handles txtUser.LostFocus
        If txtUser.Text = String.Empty Then
            txtUser.Text = "usuario"
            txtUser.Foreground = New SolidColorBrush(Color.FromRgb(150, 150, 150))
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
            txtPass.Foreground = Brushes.White
        End If
    End Sub

    Private Sub txtPass_LostFocus(sender As Object, e As RoutedEventArgs) Handles txtPass.LostFocus
        If txtPass.Password = String.Empty Then
            txtPass.Password = "visual"
            txtPass.Foreground = New SolidColorBrush(Color.FromRgb(150, 150, 150))
        End If
    End Sub

    Private Sub txtPass_PreviewKeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.PreviewKeyDown
        If e.Key = Key.Space Then
            e.Handled = True
        End If
    End Sub



    Private Sub txtNewPass2_PreviewKeyUp(sender As Object, e As KeyEventArgs) Handles txtNewPass2.PreviewKeyUp
        If Not (txtNewPass2.Password = String.Empty) Then
            imgPass2.Visibility = Windows.Visibility.Visible
            If txtNewPass1.Password = txtNewPass2.Password Then
                imgPass2.Source = imagenCorrecto
            Else
                imgPass2.Source = imagenError
            End If
        Else
            imgPass2.Visibility = Windows.Visibility.Hidden
        End If

    End Sub

    Private Sub txtNewPass1_PreviewKeyUp(sender As Object, e As KeyEventArgs) Handles txtNewPass1.PreviewKeyUp
        If Not (txtNewPass1.Password = String.Empty) Then
            imgPass1.Visibility = Windows.Visibility.Visible
            imgPass1.Source = imagenCorrecto
            txtNewPass2.IsEnabled = True
        Else
            imgPass1.Visibility = Windows.Visibility.Hidden
            txtNewPass2.IsEnabled = False
        End If

    End Sub

    Private Sub txtNewUser_PreviewKeyDown(sender As Object, e As KeyEventArgs) Handles txtNewUser.PreviewKeyDown
        If e.Key = Key.Space Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNewPass1_PreviewKeyDown(sender As Object, e As KeyEventArgs) Handles txtNewPass1.PreviewKeyDown
        If e.Key = Key.Space Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNewPass2_PreviewKeyDown(sender As Object, e As KeyEventArgs) Handles txtNewPass2.PreviewKeyDown
        If e.Key = Key.Space Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As RoutedEventArgs) Handles btnCancelar.Click
        txtNewUser.Text = String.Empty
        txtNewPass1.Password = String.Empty
        txtNewPass2.Password = String.Empty
        txtNewPass2.IsEnabled = False
        imgPass1.Visibility = Windows.Visibility.Hidden
        imgPass2.Visibility = Windows.Visibility.Hidden
        txtNewName.Text = String.Empty
    End Sub
End Class
