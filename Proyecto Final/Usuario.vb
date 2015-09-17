Public Class Usuario
    Public Shared ultimaID As Integer

    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
            ultimaID = value
        End Set
    End Property

    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Private _clave As String
    Public Property Clave() As String
        Get
            Return _clave
        End Get
        Set(ByVal value As String)
            _clave = value
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

    Private _tipoUsuario As String
    Public Property tipUsu() As String
        Get
            Return _tipoUsuario
        End Get
        Set(ByVal value As String)
            _tipoUsuario = value
        End Set
    End Property

    Public Sub New(id As String, usuario As String, clave As String, nombre As String, tipoUsuario As String)
        Me._id = id
        Me._nombre = nombre
        Me._usuario = usuario
        Me._clave = clave
        Me._tipoUsuario = tipoUsuario
    End Sub

    Public Sub New(usuario As String, clave As String, nombre As String, tipoUsuario As String)
        Me._tipoUsuario = tipoUsuario
        Me._id = ultimaID + 1
        Me._nombre = nombre
        Me._usuario = usuario
        Me._clave = clave
    End Sub

    Public Sub New()

    End Sub

End Class
