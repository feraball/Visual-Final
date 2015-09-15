Imports System.Data.OleDb
Imports System.Data

Public Class VentanaUsuario

    Private ventanaPrincipal As MainWindow

    Private _tipoUsuario As String
    Public Property tipUsu() As String
        Get
            Return _tipoUsuario
        End Get
        Set(ByVal value As String)
            _tipoUsuario = value
        End Set
    End Property

    Dim dbPath As String = "D:\restaurantes.mdb"
    ' Dim dbPath As String = "C:\Users\Carlos Leon\Desktop\VISUAL FINAL\restaurantes.mdb"
    Dim strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath
    Private Sub mitSalir_Click(sender As Object, e As RoutedEventArgs) Handles menu_Salir.Click
        End
    End Sub

    Private Sub mitNewPlatillo_Click(sender As Object, e As RoutedEventArgs) Handles menu_NewPlatillo.Click

    End Sub



    Private Sub frmVentanaUsuario_Loaded(sender As Object, e As RoutedEventArgs) Handles frmVentanaUsuario.Loaded


        dtgRestaurantes.Visibility = Windows.Visibility.Hidden
        lbl_listaResta.Visibility = Windows.Visibility.Hidden
        verificarTipoUsuario()



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

    Private Sub menu_listarRestaurantes_Click(sender As Object, e As RoutedEventArgs) Handles menu_listarRestaurantes.Click
        dtgRestaurantes.Visibility = Windows.Visibility.Visible
        lbl_listaResta.Visibility = Windows.Visibility.Visible
        Using conexion As New OleDbConnection(strConexion)
            Dim consulta As String = "SELECT r.id, r.nombre, r.direccion, r.telefono, r.duenio, u.nombre as nombreasis FROM restaurantes r INNER JOIN usuarios u ON r.asistenteId = u.id;"
            Dim adapter As New OleDbDataAdapter(consulta, conexion)

            Dim datos As New DataSet("Datos")
            adapter.Fill(datos, "restaurantes")

            dtgGrillaDatos.Visibility = Windows.Visibility.Hidden
            dtgRestaurantes.DataContext = datos
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
        If (tipUsu = 1) Then
            dtgRestaurantes.Visibility = Windows.Visibility.Hidden
            lbl_listaResta.Visibility = Windows.Visibility.Hidden

            menu_NewPlatillo.IsEnabled = False
            menu_buscarPlatillo.IsEnabled = False
            menu_listarCategorias.IsEnabled = False
            menu_listarPlatillos.IsEnabled = False
            menu_editarPlatillo.IsEnabled = False

        End If
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

    Private Sub menu_MenuEditar_Click(sender As Object, e As RoutedEventArgs) Handles menu_MenuEditar.Click

    End Sub

    Private Sub menu_listarCategorias_Click(sender As Object, e As RoutedEventArgs) Handles menu_Listar.Click
        Dim ventanaClienteList As New VentanaClienteListar
        ventanaClienteList.Owner = Me
        ventanaClienteList.Show()


    End Sub

    Private Sub dtgGrillaDatos_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles dtgGrillaDatos.SelectionChanged

    End Sub
End Class
