Imports System.Data.OleDb
Imports System.Data

Public Class VentanaClienteListar

    Dim tablaPlatillosPorCategoria As DataTable
    Dim numPlatOfreciods As Integer = 0
    Dim dbPath As String = "D:\restaurantes.mdb"
    Dim strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath

    Private Sub dgCategorias_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles dgCategorias.SelectionChanged
        cbCategorias.SelectedIndex = dgCategorias.SelectedIndex

    End Sub

    Private Sub frmListar_Loaded(sender As Object, e As RoutedEventArgs) Handles frmListar.Loaded
       
        Using conexion As New OleDbConnection(strConexion)
            Dim datos As New DataSet("Datos")
            Dim consulta As String = "SELECT * FROM categorias ;"
            Dim adapter As New OleDbDataAdapter(consulta, conexion)
            adapter.Fill(datos, "categorias")
            dgCategorias.DataContext = datos

            Dim tablaCategoria As DataTable = datos.Tables.Item(0)
            For i = 0 To tablaCategoria.Rows.Count - 1
                cbCategorias.Items.Add(tablaCategoria.Rows(i).Item(1))
            Next

            Dim textNumeroPlatillosOfrecidos As New DataGridTextColumn()
            textNumeroPlatillosOfrecidos.Header = "Número platillos ofrecidos"
            textNumeroPlatillosOfrecidos.IsReadOnly = True
            dgCategorias.Columns.Add(textNumeroPlatillosOfrecidos)

        End Using

    End Sub

    Private Sub cbCategorias_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles cbCategorias.SelectionChanged
        Using conexion2 As New OleDbConnection(strConexion)
            Dim datos2 As New DataSet("Datos2")

            Dim itemSeleccionado = cbCategorias.SelectedIndex + 1
            Dim consulta2 As String = "SELECT restaurantes.nombre as nombreRestaurante, platillos.nombre, platillos.id AS platillos_id FROM restaurantes INNER JOIN platillos ON restaurantes.id = platillos.restauranteId where platillos.categoriaId =" + itemSeleccionado.ToString + ";"
            Dim adapter2 As New OleDbDataAdapter(consulta2, conexion2)

            adapter2.Fill(datos2, "platillos")

            dgPlatillosPorCategoria.DataContext = datos2
            txtIdPlatillo.DataContext = datos2
            tablaPlatillosPorCategoria = datos2.Tables.Item(0)

        End Using
    End Sub

    Private Sub dgPlatillosPorCategoria_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles dgPlatillosPorCategoria.SelectionChanged
        Try
            Dim filaSeleccionada = dgPlatillosPorCategoria.SelectedIndex
            Dim idPlatilloSeleccionado = tablaPlatillosPorCategoria.Rows(filaSeleccionada).Item(2).ToString
            txtIdPlatillo.Text = idPlatilloSeleccionado
        Catch ex As Exception

        End Try


    End Sub


    Private Sub dgPlatillosPorCategoria_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs) Handles dgPlatillosPorCategoria.MouseDoubleClick
        Using conexion3 As New OleDbConnection(strConexion)

            Dim datos3 As New DataSet("Datos3")
            Dim filaSeleccionada = dgPlatillosPorCategoria.SelectedIndex

            Try
                Dim ventanaDescrip As New VentanaDescripcionPlatillo
                ventanaDescrip.Owner = Me
                Dim id = CStr(txtIdPlatillo.Text)
                Dim consulta3 As String = "SELECT platillos.id, platillos.nombre AS platillos_nombre, platillos.temperatura, platillos.tipo, categorias.nombre AS categorias_nombre, restaurantes.nombre AS restaurantes_nombre FROM restaurantes INNER JOIN (categorias INNER JOIN platillos ON categorias.[id] = platillos.[categoriaId]) ON restaurantes.[id] = platillos.[restauranteId] where platillos.id=" + id + "; "
                Dim adapter3 As New OleDbDataAdapter(consulta3, conexion3)
                adapter3.Fill(datos3, "platillos")
                ventanaDescrip.dgDescripcionPlatillo.DataContext = datos3
                txtIdPlatillo.Text = ""
                dgPlatillosPorCategoria.DataContext = 0
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
