Imports System.Data.OleDb
Imports System.Data

Public Class VentanaBuscarPlatillo
    Dim tablaPlatillosBusqueda As DataTable

    Dim dbPath As String = "D:\restaurantes.mdb"
    Dim strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath


    Private Sub btnBuscar_Click(sender As Object, e As RoutedEventArgs) Handles btnBuscar.Click
        If txtBusqueda.Text = "" Then
            MessageBox.Show("No ha ingresado información válida para la búsqueda")
        Else
            Using conexion3 As New OleDbConnection(strConexion)
                Dim datos3 As New DataSet("Datos3")
                datos3.CaseSensitive = False
                Dim consulta = CStr(txtBusqueda.Text)
                Dim consulta3 As String = "SELECT restaurantes.nombre AS nombreRestaurante, platillos.nombre, platillos.id FROM restaurantes INNER JOIN platillos ON restaurantes.id = platillos.restauranteId WHERE platillos.nombre like '%" + consulta + "%' ;"
                Dim adapter3 As New OleDbDataAdapter(consulta3, conexion3)
                adapter3.Fill(datos3, "platillos")
                dgPlatillosBusqueda.DataContext = datos3
                txtIdPlatillo.DataContext = datos3
                tablaPlatillosBusqueda = datos3.Tables.Item(0)

            End Using
        End If

        
    End Sub

    Private Sub dgPlatillosBusqueda_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles dgPlatillosBusqueda.SelectionChanged
        Try

            Dim filaSeleccionada = dgPlatillosBusqueda.SelectedIndex
            Dim idPlatilloSeleccionado = tablaPlatillosBusqueda.Rows(filaSeleccionada).Item(2).ToString
            txtIdPlatillo.Text = idPlatilloSeleccionado

        Catch ex As Exception

        End Try



    End Sub


    Private Sub dgPlatillosBusqueda_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs) Handles dgPlatillosBusqueda.MouseDoubleClick

        Using conexion3 As New OleDbConnection(strConexion)

            Dim datos3 As New DataSet("Datos3")
            Dim filaSeleccionada = dgPlatillosBusqueda.SelectedIndex

            Try
                Dim ventanaDescrip As New VentanaDescripcionPlatillo
                ventanaDescrip.Owner = Me
                Dim id = CStr(txtIdPlatillo.Text)
                Dim consulta3 As String = "SELECT platillos.id, platillos.nombre AS platillos_nombre, platillos.temperatura, platillos.tipo, categorias.nombre AS categorias_nombre, restaurantes.nombre AS restaurantes_nombre FROM restaurantes INNER JOIN (categorias INNER JOIN platillos ON categorias.[id] = platillos.[categoriaId]) ON restaurantes.[id] = platillos.[restauranteId] where platillos.id=" + id + "; "
                Dim adapter3 As New OleDbDataAdapter(consulta3, conexion3)
                adapter3.Fill(datos3, "platillos")
                ventanaDescrip.dgDescripcionPlatillo.DataContext = datos3
                txtIdPlatillo.Text = ""
                txtBusqueda.Text = ""
                dgPlatillosBusqueda.DataContext = 0
                Me.Hide()
                ventanaDescrip.Show()
            Catch ex As Exception

            End Try
            
           

        End Using

    End Sub

    
   
    Private Sub btnRegresar_Click(sender As Object, e As RoutedEventArgs) Handles btnRegresar.Click

        Owner.Show()
        Me.Close()
    End Sub
End Class
