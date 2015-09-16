Imports System.Data.OleDb
Imports System.Data

Public Class VentanaDescripcionPlatillo

    Private Sub frmDescripPlatillo_Loaded(sender As Object, e As RoutedEventArgs) Handles frmDescripPlatillo.Loaded
       
    End Sub


    Private Sub dgDescripcionPlatillo_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles dgDescripcionPlatillo.SelectionChanged

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As RoutedEventArgs) Handles btnRegresar.Click
        Owner.Show()

        Me.Close()

    End Sub
End Class
