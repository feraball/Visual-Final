Imports System.Data.OleDb
Imports System.Data

Public Class VentanaUsuario


    Private Sub mitSalir_Click(sender As Object, e As RoutedEventArgs) Handles mitSalir.Click
        End
    End Sub

    Private Sub mitNewPlatillo_Click(sender As Object, e As RoutedEventArgs) Handles mitNewPlatillo.Click

    End Sub

    Private Sub mitCerrar_Click(sender As Object, e As RoutedEventArgs) Handles mitCerrar.Click

    End Sub

    Private Sub frmVentanaUsuario_Loaded(sender As Object, e As RoutedEventArgs) Handles frmVentanaUsuario.Loaded
        Dim dbPath As String = "D:\restaurantes.mdb"
        Dim strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath


        Using conexion As New OleDbConnection(strConexion)
            Dim consulta As String = "SELECT u.nombre, tu.tipo FROM usuarios u INNER JOIN tipoUsuario tu ON u.rol = tu.id;"
            Dim adapter As New OleDbDataAdapter(consulta, conexion)

            Dim datos As New DataSet("Datos")
            adapter.Fill(datos, "usuarios")

            dtgGrillaDatos.DataContext = datos
        End Using
    End Sub

    Private Sub mitAcercaDe_Click(sender As Object, e As RoutedEventArgs) Handles mitAcercaDe.Click
        Dim contenido As String = "Catálogo de Delicias" & vbNewLine & "Versión 0.3" & vbNewLine & "Fernando Balladares, Carlos León & Kenneth Moreira"
        MessageBox.Show(contenido, "Acerca de...", MessageBoxButton.OK, MessageBoxImage.Information)
    End Sub
End Class
