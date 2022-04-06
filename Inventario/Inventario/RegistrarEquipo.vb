Public Class RegistrarEquipo
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim marca As String
        Dim regexMarca As String = "^([a-zA-Z]{3,50})$"
        marca = txtMarca.Text
    End Sub
End Class