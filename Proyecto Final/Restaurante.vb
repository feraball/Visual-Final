Public Class Restaurante

    Private _id As String
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property


    Private _direccion As String
    Public Property Direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Private _telefono As String
    Public Property Telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Private _dueno As String
    Public Property Dueno() As String
        Get
            Return _dueno
        End Get
        Set(ByVal value As String)
            _dueno = value
        End Set
    End Property


    Private _asistenteid As Integer
    Public Property AsistenteId() As Integer
        Get
            Return _asistenteid
        End Get
        Set(ByVal value As Integer)
            _asistenteid = value
        End Set
    End Property

    Public Sub New(id As String, nombre As String, direccion As String, telefono As String, dueno As String, asistenteid As Integer)
        Me._id = id
        Me._nombre = nombre
        Me._asistenteid = asistenteid
        Me._direccion = direccion
        Me._telefono = telefono
        Me._dueno = dueno

    End Sub

    Public Sub New(id As String)
        Me._id = id
    End Sub


End Class
