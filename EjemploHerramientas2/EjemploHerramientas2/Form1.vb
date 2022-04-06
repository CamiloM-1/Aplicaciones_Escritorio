Public Class Form1
    Dim horas As String
    Dim minutos As String
    Dim segundos As String
    Dim miniSegundos As String

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Timer1.Enabled = True
        horas = 0
        minutos = 0
        segundos = 0
        miniSegundos = 0
        btnIniciar.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        miniSegundos += 100

        If miniSegundos = 1000 Then
            miniSegundos = 0
            segundos += 1
            If segundos = 60 Then
                segundos = 0
                minutos += 1
                If minutos = 60 Then
                    minutos = 0
                    horas += 1

                End If
            End If
        End If
        txtTiempo.Text = horas + ":" + minutos + ":" + segundos + ":" + miniSegundos
    End Sub

    Private Sub btnDetener_Click(sender As Object, e As EventArgs) Handles btnDetener.Click
        Timer1.Enabled = False
        btnIniciar.Enabled = True
        Label1.Text = txtTiempo.Text
    End Sub

End Class
