Imports System.Data.SqlClient

Module connectSQL
    Public conexion As New SqlConnection("Data source = CAMILO\SQLEXPRESS; Initial Catalog = inventario; Integrated Security = True")

    Sub openConnection()
        Try
            If conexion.State = 0 Then
                conexion.Open()
                Console.WriteLine("En conexion:" + conexion.State.ToString)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Sub closeConnection()
        If conexion.State = 1 Then
            conexion.Close()
            Console.WriteLine("Conexion cerrada")
        End If
    End Sub

End Module
