Imports System.Data
Imports System.Data.OleDb

Public Class VentanaPlatillo

    Public resId As Integer
    Dim datos As New DataSet("Datos")
    Dim dbPath As String = "D:\restaurantes.mdb"
    Dim strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath

    Private Sub frmPlatillo_Loaded(sender As Object, e As RoutedEventArgs) Handles frmPlatillo.Loaded
        Using conexion As New OleDbConnection(strConexion)
            Dim consulta As String = "SELECT * FROM platillos"
            Dim adapter As New OleDbDataAdapter(consulta, conexion)
            adapter.Fill(datos, "platillos")
        End Using
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As RoutedEventArgs) Handles btnCancelar.Click
        Me.Owner.IsEnabled = True
        Me.Close()
    End Sub

    Private Sub frmPlatillo_Closing(sender As Object, e As ComponentModel.CancelEventArgs) Handles frmPlatillo.Closing
        Me.Owner.IsEnabled = True
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As RoutedEventArgs) Handles btnRegistrar.Click
        datos.Tables("platillos").Rows.Add(datos.Tables("platillos").Rows.Count + 1, txtNombre.Text, cbxTemperatura.SelectedItem, cbxTipo.SelectedItem, cbxCategorias.SelectedIndex, resId)
        Using conexion As New OleDbConnection(strConexion)
        Dim consulta As String = "SELECT * FROM platillos;"
            Dim adapter As New OleDbDataAdapter(consulta, conexion)

            Dim cmdBuilder = New OleDbCommandBuilder(adapter)

            Try
                adapter.Update(datos.Tables("platillos"))
                MessageBox.Show("Platillos Agregado Correctamente!", "Nuevo Platillo", MessageBoxButton.OK, MessageBoxImage.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error al agregar")
            End Try
        End Using
    End Sub


End Class
