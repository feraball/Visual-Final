Public Class RegistroUsuario

    Private Sub btnCancelar_Click(sender As Object, e As RoutedEventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmRegistroUsuario_Closing(sender As Object, e As ComponentModel.CancelEventArgs) Handles frmRegistroUsuario.Closing
        Me.Owner.IsEnabled = True
    End Sub
End Class
