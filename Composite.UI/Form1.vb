Imports Composite.BE
Imports Composite.BLL

Public Class Form1

    Dim unUsuario As New Usuario

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim permisoBLL As New PermisoBLL
        unUsuario.perfilCompuesto = permisoBLL.ListarPermisosPorUsuario("admin")

        validarPermisos()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim permisoBLL As New PermisoBLL
        unUsuario.perfilCompuesto = permisoBLL.ListarPermisosPorUsuario("gerente")

        validarPermisos()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Dim permisoBLL As New PermisoBLL
        unUsuario.perfilCompuesto = permisoBLL.ListarPermisosPorUsuario("empleado")

        validarPermisos()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Dim permisoBLL As New PermisoBLL
        unUsuario.perfilCompuesto = permisoBLL.ListarPermisosPorUsuario("julian")

        validarPermisos()

    End Sub

    Sub validarPermisos()

        btnAdministrar.Enabled = unUsuario.perfilCompuesto.Validar("btnAdministrar")
        btnNuevoTurno.Enabled = unUsuario.perfilCompuesto.Validar("btnNuevoTurno")
        btnActualizarTurno.Enabled = unUsuario.perfilCompuesto.Validar("btnActualizarTurno")
        btnInformes.Enabled = unUsuario.perfilCompuesto.Validar("btnInformes")
        btnClientes.Enabled = unUsuario.perfilCompuesto.Validar("btnClientes")
        btnEmpleados.Enabled = unUsuario.perfilCompuesto.Validar("btnEmpleados")

    End Sub

End Class
