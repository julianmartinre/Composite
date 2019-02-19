Imports Composite.BE
Imports Composite.DAL

Public Class UsuarioBLL

    Function TraerUsuario(nombreUsuario As String) As Usuario

        Dim usuarioDAL As New UsuarioDAL
        Return usuarioDAL.TraerUsuario(nombreUsuario)

    End Function

End Class
