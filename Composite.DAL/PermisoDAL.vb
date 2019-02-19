Imports Composite.BE
Imports System.Data.SqlClient

Public Class PermisoDAL
    Inherits Connection

    Function ListarPermisosPorUsuario(nombreUsuario As String) As PermisoCompuesto

        Dim permiso As New PermisoCompuesto

        Try
            AbrirConec()

            Command = New SqlCommand
            Command.Connection = ConString
            Command.CommandText = "Select Permiso.idPermiso, Permiso.descripcionPermiso From Permiso inner join PermisoUsuario on Permiso.idPermiso = PermisoUsuario.idPermiso where PermisoUsuario.nombreUsuario = '" & nombreUsuario & "'"
            Command.CommandType = CommandType.Text

            Dim reader = Command.ExecuteReader
            While reader.Read
                Dim unPermiso = New PermisoSimple(reader(0), reader(1))
                permiso.Agregar(unPermiso)
            End While
            reader.Close()

            CerrarConec()

            Return permiso
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

End Class
