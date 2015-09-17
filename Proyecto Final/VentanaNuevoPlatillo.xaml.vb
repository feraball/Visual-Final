Public Class VentanaNuevoPlatillo
    Private Sub btnCancelar_Click(sender As Object, e As RoutedEventArgs) Handles btnCancelar.Click
        Me.Owner.IsEnabled = True
        Me.Close()
    End Sub
End Class
