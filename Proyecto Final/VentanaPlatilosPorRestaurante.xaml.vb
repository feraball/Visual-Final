Imports System.Data.OleDb
Imports System.Data

Public Class VentanaPlatilosPorRestaurante

    Dim dbPath As String = "C:\Users\Carlos Leon\Desktop\VISUAL FINAL\restaurantes.mdb"
    Dim strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub frmVentanaPlatillos_Loaded(sender As Object, e As RoutedEventArgs) Handles frmVentanaPlatillos.Loaded
        Dim id = CStr(txt_restaId.Text)
        Using conexion As New OleDbConnection(strConexion)
            Dim consulta As String = "SELECT p.nombre, p.temperatura, p.tipo, c.nombre as nombrecate FROM platillos p INNER JOIN categorias c ON p.categoriaId = c.id where p.restauranteId = " + id + ";"
            Dim adapter As New OleDbDataAdapter(consulta, conexion)

            Dim datos As New DataSet("Datos")
            adapter.Fill(datos, "platillos")

            dtgPlatillosPorResta.DataContext = datos
        End Using

     


    End Sub

    Private Sub frmVentanaPlatillos_Closing(sender As Object, e As ComponentModel.CancelEventArgs) Handles frmVentanaPlatillos.Closing
        End
    End Sub
End Class
