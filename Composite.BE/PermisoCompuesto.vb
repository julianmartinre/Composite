Imports Composite.BE

Public Class PermisoCompuesto
    Inherits PermisoBase

    Private _lista As List(Of PermisoBase) = New List(Of PermisoBase)

    Public Sub Agregar(ByVal permiso As PermisoBase)
        If Not permiso Is Nothing Then
            If Not Me._lista.Contains(permiso) Then
                Me._lista.Add(permiso)
            Else
                'nada...
            End If
        Else
            'nada.. 
        End If
    End Sub

    Public Function Quitar(ByVal permiso As PermisoBase)
        Return Me._lista.Remove(permiso)
    End Function

    Public Function Hijos() As List(Of PermisoBase)
        Return Me._lista
    End Function

    Public ReadOnly Property Lista As List(Of PermisoBase)
        Get
            Return Me._lista
        End Get
    End Property

    Public Overrides Function Validar(ByVal id As String) As Boolean
        Dim resultado As Boolean
        Dim i As Integer = 0
        Do While resultado = False And i < Me.Lista.Count
            resultado = (resultado Or Me.Lista(i).Validar(id))
            'i = i + 1
            i += 1
        Loop

        Return resultado
    End Function

    Public Overrides ReadOnly Property ListaCompleta As System.Collections.Generic.List(Of PermisoBase)
        Get
            Dim _lista As List(Of PermisoBase) = New List(Of PermisoBase)

            For Each _permiso As PermisoBase In Me.Lista
                _lista.AddRange(_permiso.ListaCompleta)
            Next

            Return _lista
        End Get
    End Property

End Class
