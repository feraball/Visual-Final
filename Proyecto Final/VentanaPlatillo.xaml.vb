Public Class VentanaPlatillo
    Private Sub btnCancelar_Click(sender As Object, e As RoutedEventArgs) Handles btnCancelar.Click
        Me.Owner.IsEnabled = True
        Me.Close()
    End Sub

    Private Sub frmNuevoPlatillo_Closing(sender As Object, e As ComponentModel.CancelEventArgs) Handles frmPlatillo.Closing
        Me.Owner.IsEnabled = True
        Me.Close()
    End Sub
End Class
