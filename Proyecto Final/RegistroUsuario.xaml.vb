Public Class RegistroUsuario
    Dim imagenCorrecto As BitmapImage = New BitmapImage(New Uri("Assets/check.png", UriKind.Relative))
    Dim imagenError As BitmapImage = New BitmapImage(New Uri("Assets/error.png", UriKind.Relative))

    Private Sub btnCancelar_Click(sender As Object, e As RoutedEventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmRegistroUsuario_Closing(sender As Object, e As ComponentModel.CancelEventArgs) Handles frmRegistroUsuario.Closing
        Me.Owner.IsEnabled = True
    End Sub

    Private Sub txtPass1_LostFocus(sender As Object, e As RoutedEventArgs) Handles txtPass1.LostFocus
        If txtPass1.Password = String.Empty Then
            imgPass1.Visibility = Windows.Visibility.Hidden
        End If
    End Sub

    Private Sub txtPass2_PreviewKeyUp(sender As Object, e As KeyEventArgs) Handles txtPass2.PreviewKeyUp
        imgPass2.Visibility = Windows.Visibility.Visible
        If txtPass1.Password = txtPass2.Password Then
            imgPass2.Source = imagenCorrecto
        Else
            imgPass2.Source = imagenError
        End If
    End Sub

    Private Sub txtPass1_PreviewKeyUp(sender As Object, e As KeyEventArgs) Handles txtPass1.PreviewKeyUp
        If Not (txtPass1.Password = String.Empty) Then
            imgPass1.Visibility = Windows.Visibility.Visible
            imgPass1.Source = imagenCorrecto
        End If
    End Sub
End Class
