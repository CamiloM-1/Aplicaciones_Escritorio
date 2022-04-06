Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'openConnection()
        'closeConnection()
        openConnMySQL()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As String = txtUsuario.Text
        Dim pass As String = txtPass.Text
        Dim query As String = "SELECT usu_usuario, usu_contra FROM inv_usuario WHERE usu_usuario = @user AND usu_contra = @passwr;"
        Dim command As New MySqlCommand(query, Mysqlconecction)
        command.Parameters.Add("@user", MySqlDbType.VarChar).Value = user
        command.Parameters.Add("@passwr", MySqlDbType.VarChar).Value = pass

        Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(command)
        Dim table As DataTable = New DataTable()

        adapter.Fill(table)
        If table.Rows.Count > 0 Then
            closeConnMySQL()
            Principal.Show()
            Me.Hide()
        Else
            MsgBox("Error de Credenciales, Intente una vez más")
        End If

    End Sub

    Private Sub txtUsuario_LostFocus(sender As Object, e As EventArgs) Handles txtUsuario.LostFocus
        Dim user As String = txtUsuario.Text
        Dim rgxUser As String = "^([a-zA-Z0-9]{4,15})$"
        Dim regex As Regex = New Regex(rgxUser)
        If Not regex.IsMatch(user) Then
            MsgBox("Caracteres no permitidos")
            pbGood.Visible = False
        Else
            Button1.Enabled = True
            pbGood.Visible = True
        End If
    End Sub
End Class