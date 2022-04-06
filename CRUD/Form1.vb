Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Configuration

Public Class FormInventario
    Dim conn As New MySqlConnection
    Dim objConexion As New conexion

    Dim cmd As MySqlCommand

    Private Sub FormInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        conn = objConexion.AbrirCon

        Dim query As String = "select * from inventario"
        Dim adpt As New MySqlDataAdapter(query, conn)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        GridDatosInv.DataSource = ds.Tables(0)

        conn.Close()
        conn.Dispose()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        conn = objConexion.AbrirCon
        Try
            cmd = conn.CreateCommand
            cmd.CommandText = "insert into inventario(codigo,articulo,descripcion,costo,venta,existencias,observacion)values(@cod,@art,@des,@cos,@ven,@exis,@obs);"
            cmd.Parameters.AddWithValue("@cod", txtCodigo.Text)
            cmd.Parameters.AddWithValue("@art", txtNombre.Text)
            cmd.Parameters.AddWithValue("@des", txtDescrip.Text)
            cmd.Parameters.AddWithValue("@cos", txtCost.Text)
            cmd.Parameters.AddWithValue("@ven", txtVenta.Text)
            cmd.Parameters.AddWithValue("@exis", txtCant.Text)
            cmd.Parameters.AddWithValue("@obs", txtObs.Text)

            cmd.ExecuteNonQuery()

            conn.Close()
            conn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub GridDatosInv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridDatosInv.CellContentClick
        Dim row As DataGridViewRow = GridDatosInv.CurrentRow
        Try
            txtCodigo.Text = row.Cells(0).Value.ToString
            txtNombre.Text = row.Cells(1).Value.ToString
            txtDescrip.Text = row.Cells(2).Value.ToString
            txtCost.Text = row.Cells(3).Value.ToString
            txtVenta.Text = row.Cells(4).Value.ToString
            txtCant.Text = row.Cells(5).Value.ToString
            txtObs.Text = row.Cells(6).Value.ToString
        Catch ex As Exception

        End Try
    End Sub
End Class
