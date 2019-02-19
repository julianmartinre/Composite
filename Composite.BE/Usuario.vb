Public Class Usuario

    Private _nombreUsuario As String
    Public Property nombreUsuario() As String
        Get
            Return _nombreUsuario
        End Get
        Set(ByVal value As String)
            _nombreUsuario = value
        End Set
    End Property

    Private _passwordUsuario As String
    Public Property passwordUsuario() As String
        Get
            Return _passwordUsuario
        End Get
        Set(ByVal value As String)
            _passwordUsuario = value
        End Set
    End Property

    Private _perfilCompuesto As PermisoCompuesto
    Public Property perfilCompuesto() As PermisoCompuesto
        Get
            Return _perfilCompuesto
        End Get
        Set(ByVal value As PermisoCompuesto)
            _perfilCompuesto = value
        End Set
    End Property

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        If Not obj Is Nothing AndAlso TypeOf obj Is Usuario Then
            Return CType(obj, Usuario).nombreUsuario.Equals(Me.nombreUsuario)
        Else
            Return False
        End If
    End Function

End Class
