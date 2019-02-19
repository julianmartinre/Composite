Imports Composite.BE

Public Class PermisoSimple
    Inherits PermisoBase

    'Constructor
    Public Sub New(ByVal id As String, descripcion As String)
        Me.id = id
        Me.descripcion = descripcion
    End Sub

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        If Not obj Is Nothing AndAlso TypeOf obj Is PermisoSimple Then
            Return CType(obj, PermisoSimple).id.Equals(Me.id)
        Else
            Return False
        End If
    End Function

    'Devolver string de permiso con info.
    Public Overrides Function ToString() As String
        Return String.Format("{0} ({1})", Me.descripcion, Me.id)
    End Function

    Public Overrides ReadOnly Property ListaCompleta As List(Of PermisoBase)
        Get
            Dim _lista As List(Of PermisoBase) = New List(Of PermisoBase)
            _lista.Add(Me)
            Return _lista
        End Get
    End Property

    Public Overrides Function Validar(id As String) As Boolean
        Return Me.id.Equals(id)
    End Function

End Class
