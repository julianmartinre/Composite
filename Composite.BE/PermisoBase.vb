Public MustInherit Class PermisoBase

    Private _id As String
    Public Property id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Private _descripcion As String
    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    'Validar permisos
    Public MustOverride Function Validar(ByVal id As String) As Boolean

    Public MustOverride ReadOnly Property ListaCompleta As List(Of PermisoBase)

End Class
