Imports System.Data.SqlClient

Public Class Connection
    Public ConString As SqlConnection
    Public Command As SqlCommand
    Private Shared mConnection As SqlConnection

    Sub AbrirConec()

        Try
            ConString = New SqlConnection("Data Source=DESKTOP-44COCL5;Initial Catalog=Composite;Integrated Security=True")
            ConString.Open()

        Catch ex As SqlException
            MsgBox("Error al conectarse a la BD ", ex.Message)
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Sub CerrarConec()

        Try
            ConString.Close()
            ConString = Nothing
        Catch ex As SqlException
            MsgBox(ex)
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

End Class
