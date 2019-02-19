Imports Composite.BE
Imports System.Data.SqlClient

Public Class UsuarioDAL
    Inherits Connection

    Function TraerUsuario(nombreUsuario As String) As Usuario

        AbrirConec()

        Dim query = "Select * from Usuario Where nombreUsuario = '" & nombreUsuario & "'"

        Dim unUsuario As New Usuario

        Try
            Command = New SqlCommand
            Command.Connection = ConString
            Command.CommandText = query
            Command.CommandType = CommandType.Text

            Dim reader = Command.ExecuteReader

            While reader.Read

                unUsuario.nombreUsuario = reader(0)
                unUsuario.passwordUsuario = reader(1)

            End While
            reader.Close()

        Catch ex As Exception
            MsgBox(ex)
        End Try

        Return unUsuario

    End Function

End Class
