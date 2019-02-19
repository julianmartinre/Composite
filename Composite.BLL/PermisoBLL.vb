Imports Composite.BE
Imports Composite.DAL

Public Class PermisoBLL

    Function ListarPermisosPorUsuario(nombreUsuario As String) As PermisoCompuesto

        Dim permisoDAL As New PermisoDAL
        Return permisoDAL.ListarPermisosPorUsuario(nombreUsuario)

    End Function

End Class
