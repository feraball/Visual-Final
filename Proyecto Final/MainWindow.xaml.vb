Class MainWindow 
    Private ventanaRegistro As RegistroUsuario

    Private Sub btnSignin_Click(sender As Object, e As RoutedEventArgs) Handles btnSignin.Click
        ventanaRegistro = New RegistroUsuario
        ventanaRegistro.Owner = Me
        ventanaRegistro.Show()
        Me.IsEnabled = False

    End Sub
End Class
