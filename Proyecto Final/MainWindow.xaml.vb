Imports System.Data.OleDb
Imports System.Data

Class MainWindow
    Private ventanaUser As VentanaUsuario
    Dim imagenCorrecto As BitmapImage = New BitmapImage(New Uri("Assets/check.png", UriKind.Relative))
    Dim imagenError As BitmapImage = New BitmapImage(New Uri("Assets/error.png", UriKind.Relative))

    Public datos As New DataSet("Datos")
    'Dim dbPath As String = "D:\restaurantes.mdb"
    Dim dbPath As String = "C:\Users\Carlos Leon\Desktop\VISUAL FINAL\restaurantes.mdb"
    Dim strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath

    Private Sub frmLogin_Loaded(sender As Object, e As RoutedEventArgs) Handles frmLogin.Loaded
        Using conexion As New OleDbConnection(strConexion)
            Dim consulta As String = "SELECT * FROM usuarios;"
            Dim adapter As New OleDbDataAdapter(consulta, conexion)
            adapter.Fill(datos, "usuarios")
        End Using
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As RoutedEventArgs) Handles btnLogin.Click

        For Each fila As DataRow In datos.Tables("usuarios").Rows
            If fila.Item(1) = txtUser.Text And fila.Item(2) = txtPass.Password Then
                ventanaUser = New VentanaUsuario
                ventanaUser.tipUsu = fila.Item(4)
                ventanaUser.Owner = Me
                ventanaUser.Show()
                Me.Hide()
                Exit Sub
            End If
        Next

        MessageBox.Show("El usuario y/o contraseña es/son incorrectos", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error)
        txtUser.Text = ""
        txtPass.Password = ""
        txtUser_LostFocus(txtUser, New RoutedEventArgs)
        txtPass_LostFocus(txtPass, New RoutedEventArgs)
        txtUser.Focus()
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


    Private Sub btnRegistrar_Click(sender As Object, e As RoutedEventArgs) Handles btnRegistrar.Click
        If txtNewPass1.Password = txtNewPass2.Password Then
            datos.Tables("usuarios").Rows.Add(datos.Tables("usuarios").Rows.Count + 1, txtNewUser.Text, txtNewPass2.Password, txtNewName.Text, 3)

            Using conexion As New OleDbConnection(strConexion)
                Dim consulta As String = "SELECT * FROM usuarios;"
                Dim adapter As New OleDbDataAdapter(consulta, conexion)

                Dim personaCmdBuilder = New OleDbCommandBuilder(adapter)

                Try
                    adapter.Update(datos.Tables("usuarios"))
                    MessageBox.Show("Cliente Agregado Correctamente!", "Nuevo Cliente", MessageBoxButton.OK, MessageBoxImage.Information)
                    tabContenedor.SelectedIndex = 0
                Catch ex As Exception
                    MessageBox.Show("Error al guardar")
                End Try
            End Using
        End If
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtUser.TextChanged

    End Sub
End Class
