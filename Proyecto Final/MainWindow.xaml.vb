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
End Class
