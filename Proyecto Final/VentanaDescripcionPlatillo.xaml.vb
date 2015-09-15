Imports System.Data.OleDb
Imports System.Data

Public Class VentanaDescripcionPlatillo

    Private Sub frmDescripPlatillo_Loaded(sender As Object, e As RoutedEventArgs) Handles frmDescripPlatillo.Loaded
        Dim dbPath As String = "D:\restaurantes.mdb"
        Dim strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath
        Using conexion3 As New OleDbConnection(strConexion)
            Dim datos3 As New DataSet("Datos3")
            Dim id = txtIdPlati.Text
            'Dim consulta3 As String = "SELECT platillos.id, platillos.nombre AS platillos_nombre, platillos.temperatura, platillos.tipo, categorias.nombre AS categorias_nombre, restaurantes.nombre AS restaurantes_nombre FROM restaurantes INNER JOIN (categorias INNER JOIN platillos ON categorias.[id] = platillos.[categoriaId]) ON restaurantes.[id] = platillos.[restauranteId] ; "
            Dim consulta3 As String = "SELECT platillos.id, platillos.nombre AS platillos_nombre, platillos.temperatura, platillos.tipo, categorias.nombre AS categorias_nombre, restaurantes.nombre AS restaurantes_nombre FROM restaurantes INNER JOIN (categorias INNER JOIN platillos ON categorias.[id] = platillos.[categoriaId]) ON restaurantes.[id] = platillos.[restauranteId] where platillos.id=" + id + "; "
            Dim adapter3 As New OleDbDataAdapter(consulta3, conexion3)

            adapter3.Fill(datos3, "platillos")
            dgDescripcionPlatillo.DataContext = datos3


          


        End Using
    End Sub


    Private Sub dgDescripcionPlatillo_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles dgDescripcionPlatillo.SelectionChanged

    End Sub
End Class
