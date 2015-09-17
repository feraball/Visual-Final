Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.Win32

Public Class VentanaUsuario

    Private ventanaPrincipal As MainWindow
    Public usuarioActivo As Usuario

    'Private _tipoUsuario As String
    'Public Property tipUsu() As String
    '    Get
    '        Return _tipoUsuario
    '    End Get
    '    Set(ByVal value As String)
    '        _tipoUsuario = value
    '    End Set
    'End Property

    Dim dbPath As String = "D:\restaurantes.mdb"
    'Dim dbPath As String = "C:\Users\Carlos Leon\Desktop\VISUAL FINAL\restaurantes.mdb"
    Dim adapter2 As New OleDbDataAdapter
    Dim dbPath2 As String = ""

    Dim datos As New DataSet("Datos")
    Dim consulta As String
    Dim strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath
    Private Sub mitSalir_Click(sender As Object, e As RoutedEventArgs) Handles menu_Salir.Click
        End
    End Sub

    Private Sub mitNewPlatillo_Click(sender As Object, e As RoutedEventArgs) Handles menu_NewPlatillo.Click
        Dim ventanaNuevoPlatillo As New VentanaNuevoPlatillo
        ventanaNuevoPlatillo.Owner = Me
        ventanaNuevoPlatillo.Show()
        Me.IsEnabled = False
    End Sub



    Private Sub frmVentanaUsuario_Loaded(sender As Object, e As RoutedEventArgs) Handles frmVentanaUsuario.Loaded


        'dtgRestaurantes.Visibility = Windows.Visibility.Hidden
        verificarTipoUsuario()

        'Using conexion As New OleDbConnection(strConexion)
        '    Dim consulta As String = "SELECT u.nombre, tu.tipo FROM usuarios u INNER JOIN tipoUsuario tu ON u.rol = tu.id;"
        '    Dim adapter As New OleDbDataAdapter(consulta, conexion)

        '    Dim datos2 As New DataSet("Datos")
        '    adapter.Fill(datos2, "usuarios")

        '    dtgGrillaDatos.DataContext = datos2
        'End Using
    End Sub

    Private Sub mitAcercaDe_Click(sender As Object, e As RoutedEventArgs) Handles mitAcercaDe.Click
        Dim contenido As String = "Catálogo de Delicias" & vbNewLine & "Versión 0.3" & vbNewLine & "Fernando Balladares, Carlos León & Kenneth Moreira"
        MessageBox.Show(contenido, "Acerca de...", MessageBoxButton.OK, MessageBoxImage.Information)
    End Sub

    Private Sub menu_listarRestaurantes_Click(sender As Object, e As RoutedEventArgs) Handles menu_listarRestaurantes.Click
        leerRestaurante()
        lbl_listaResta.Visibility = Windows.Visibility.Visible
        dtgGrillaDatos.Visibility = Windows.Visibility.Hidden
        dtgRestaurantes.Visibility = Windows.Visibility.Visible
        dtgRestaurantes.DataContext = datos
    End Sub

    Private Sub leerRestaurante()
        If usuarioActivo.tipUsu = "Administrador" Then
            consulta = "SELECT r.id, r.nombre, r.direccion, r.telefono, r.duenio, u.nombre as nombreasis FROM restaurantes r INNER JOIN usuarios u ON r.asistenteId = u.id;"
        Else
            consulta = "SELECT r.nombre FROM restaurantes r WHERE r.asistenteId = " & usuarioActivo.Id
        End If

        Using conexion As New OleDbConnection(strConexion)

            Dim comando As OleDbCommand = New OleDbCommand(consulta, conexion)
            adapter2.SelectCommand = comando

            adapter2.Fill(datos, "restaurantes")

        End Using
    End Sub

    Private Sub menu_cerrarSesion_Click(sender As Object, e As RoutedEventArgs) Handles menu_cerrarSesion.Click

        ventanaPrincipal = Owner
        ventanaPrincipal.txtUser.Text = "Usuario"
        ventanaPrincipal.txtPass.Password = "Visual"
        ventanaPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub verificarTipoUsuario()
        Select Case usuarioActivo.tipUsu
            Case "Administrador"
                menu_importarXml.IsEnabled = True
                menu_listarRestaurantes.IsEnabled = True
                dtgRestaurantes.Visibility = Visibility.Visible
            Case "Asistente de Restaurante"
                menu_NewPlatillo.IsEnabled = True
                menu_listarPlatillos.IsEnabled = True
                menu_listarCategorias.IsEnabled = True

            Case "Cliente"
                menu_buscarPlatillo.IsEnabled = True
                menu_listarCategorias.IsEnabled = True

                lblRestaurante.Visibility = Windows.Visibility.Collapsed
                lblRestauranteUsuario.Visibility = Windows.Visibility.Collapsed
                cbxCategorias.Visibility = Windows.Visibility.Collapsed
                txtBuscar.Visibility = Windows.Visibility.Collapsed
                dtgGrillaDatos.Visibility = Windows.Visibility.Collapsed
                lbl_newBD.Visibility = Windows.Visibility.Collapsed
                imgCatalogoDelicias.Visibility = Windows.Visibility.Visible
        End Select
    End Sub

    Private Sub frmVentanaUsuario_Closed(sender As Object, e As EventArgs) Handles frmVentanaUsuario.Closed
        End
    End Sub

    Private Sub dtgRestaurantes_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles dtgRestaurantes.SelectionChanged
        Dim fila As DataRowView = sender.SelectedItem
        'MessageBox.Show(fila("FirstName") & " - " & fila("EmployeeID"))

        Dim ventanaPlatillos As New VentanaPlatilosPorRestaurante
        ventanaPlatillos.Owner = Me

        Dim resta As New Restaurante(fila("id"))
        ventanaPlatillos.DataContext = resta


        ventanaPlatillos.Show()
        Me.Hide()
    End Sub

    Private Sub menu_buscarPlatillo_Click(sender As Object, e As RoutedEventArgs) Handles menu_buscarPlatillo.Click
        Dim ventanaBuscar As New VentanaBuscarPlatillo
        ventanaBuscar.Owner = Me
        ventanaBuscar.Show()

    End Sub

    Private Sub menu_listarCategorias_Click(sender As Object, e As RoutedEventArgs) Handles menu_listarCategorias.Click
        cbxCategorias.Items.Clear()
        Try
            datos.Tables("categorias").Clear()
            datos.Tables("platillos").Clear()
        Catch ex As Exception

        End Try

        Select Case usuarioActivo.tipUsu
            Case "Asistente de Restaurante"
                cbxCategorias.IsEnabled = True
                lbl_listaResta.Visibility = Visibility.Visible
                lbl_listaResta.Content = "Lista de Platillos por Categoría en Mi Restaurante"

                dtgGrillaDatos.IsEnabled = False
                dtgGrillaDatos.Visibility = Visibility.Visible

                Using conexion As New OleDbConnection(strConexion)
                    consulta = "SELECT * FROM categorias"
                    Dim adapter As New OleDbDataAdapter(consulta, conexion)
                    adapter.Fill(datos, "categorias")

                    For Each row As DataRow In datos.Tables("categorias").Rows
                        cbxCategorias.Items.Add(row.Item(1))
                    Next
                End Using

            'cbxCategorias.SelectedIndex = 0

            Case "Cliente"
                Dim ventanaClienteList As New VentanaClienteListar
                ventanaClienteList.Owner = Me
                ventanaClienteList.Show()
        End Select

    End Sub


    Private Sub menu_importarXml_Click(sender As Object, e As RoutedEventArgs) Handles menu_importarXml.Click

        Dim openFile As New OpenFileDialog
        openFile.Filter = "Archivos de imágen (.mdb)|*.mdb|All Files (*.*)|*.*"
        openFile.Title = "Seleccione la Imagen a Mostrar"

        If (openFile.ShowDialog() = True) Then

            dbPath2 = openFile.FileName

        End If
        lbl_newBD.Content = dbPath2
        llenarDatosBaseNueva()

    End Sub


    Private Sub llenarDatosBaseNueva()

        Dim strConexion2 As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath2

        lbl_listaResta.Visibility = Windows.Visibility.Hidden
        dtgGrillaDatos.Visibility = Windows.Visibility.Hidden

        Using conexion As New OleDbConnection(strConexion2)
            Dim consulta As String = "SELECT r.id, r.nombre, r.direccion, r.telefono, r.duenio, u.nombre as nombreasis FROM restaurantes r INNER JOIN usuarios u ON r.asistenteId = u.id;"
            Dim comando2 As OleDbCommand = New OleDbCommand(consulta, conexion)
            adapter2.SelectCommand = comando2

            'Dim datos As New DataSet("Datos")
            adapter2.Fill(datos, "restaurantes")



            dtgRestaurantes.Visibility = Windows.Visibility.Visible
            dtgRestaurantes.DataContext = datos
            guardarBase()
        End Using

    End Sub
    Private Sub guardarBase()


    End Sub


    Friend Sub AsignarUsuario(id As String, usuario As String, clave As String, nombre As String, tipoUsuario As String)
        usuarioActivo = New Usuario(id, usuario, clave, nombre, tipoUsuario)
        lblNombreUsuario.Content = usuarioActivo.Nombre
        lblTipoUsuario.Content = usuarioActivo.tipUsu
        If usuarioActivo.tipUsu = "Asistente de Restaurante" Then
            leerRestaurante()
            lblRestauranteUsuario.Content = datos.Tables("restaurantes").Rows(0).Item(0)
        Else
            lblRestauranteUsuario.Content = "No asociado"
        End If

    End Sub

    Private Sub cargarPlatillos(consulta As String)
        Try
            datos.Tables("platillos").Clear()
        Catch ex As Exception
        End Try

        Using conexion As New OleDbConnection(strConexion)

            Dim adapter As New OleDbDataAdapter(consulta, conexion)
            adapter.Fill(datos, "platillos")

            dtgGrillaDatos.DataContext = datos
        End Using
    End Sub

    Private Sub menu_listarPlatillos_Click(sender As Object, e As RoutedEventArgs) Handles menu_listarPlatillos.Click
        cbxCategorias.IsEnabled = False
        cbxCategorias.Items.Clear()
        lbl_listaResta.Visibility = Visibility.Visible
        lbl_listaResta.Content = "Lista de Todos los Platillos en Mi Restaurante"

        consulta = "SELECT p.nombre FROM restaurantes r INNER JOIN platillos p ON r.id = p.restauranteId WHERE (r.asistenteId = " & usuarioActivo.Id.ToString & ")"
        cargarPlatillos(consulta)

    End Sub

    Private Sub cbxCategorias_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles cbxCategorias.SelectionChanged
        dtgGrillaDatos.IsEnabled = True

        Dim catID As Integer = cbxCategorias.SelectedIndex() + 1

        consulta = "SELECT p.nombre FROM restaurantes r INNER JOIN platillos p ON r.id = p.restauranteId WHERE (r.asistenteId = " & usuarioActivo.Id.ToString & ") AND (p.categoriaId = " & catID.ToString & ")"
        cargarPlatillos(consulta)

    End Sub

    Private Sub dtgGrillaDatos_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles dtgGrillaDatos.SelectionChanged

    End Sub
End Class
