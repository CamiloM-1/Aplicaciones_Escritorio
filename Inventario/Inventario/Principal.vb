Public Class Principal

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        'RegistrarEquipo.Show()
        Dim fRegistro As New RegistrarEquipo
        fRegistro.MdiParent = Me
        fRegistro.Show()
    End Sub
End Class
