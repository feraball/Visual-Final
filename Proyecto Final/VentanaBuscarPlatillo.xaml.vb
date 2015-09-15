Imports System.Data.OleDb
Imports System.Data

Public Class VentanaBuscarPlatillo

    Private Sub btnBuscar_Click(sender As Object, e As RoutedEventArgs) Handles btnBuscar.Click
        Dim dbPath As String = "D:\restaurantes.mdb"
        Dim strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath
        Using conexion3 As New OleDbConnection(strConexion)
            Dim datos3 As New DataSet("Datos3")
            datos3.CaseSensitive = False
            Dim consulta = CStr(txtBusqueda.Text)
            Dim consulta3 As String = "SELECT restaurantes.nombre AS nombreRestaurante, platillos.nombre, platillos.id FROM restaurantes INNER JOIN platillos ON restaurantes.id = platillos.restauranteId WHERE platillos.nombre like '%" + consulta + "%' ;"

            Dim adapter3 As New OleDbDataAdapter(consulta3, conexion3)

            adapter3.Fill(datos3, "platillos")

            dgPlatillosBusqueda.DataContext = datos3


        End Using
    End Sub

    Private Sub dgPlatillosBusqueda_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs) Handles dgPlatillosBusqueda.MouseDoubleClick
        Dim ventanaDecripBusqueda As New VentanaDescripcionPlatillo
        ventanaDecripBusqueda.Owner = Me
        ventanaDecripBusqueda.Show()

    End Sub

    Private Sub dgPlatillosBusqueda_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles dgPlatillosBusqueda.SelectionChanged

    End Sub
End Class
