Imports MySql.Data.MySqlClient

Module connectMYSQL
    Dim conexionMySQL As String = "server = baseinventario.mysql.database.azure.com; port = 3306; database = inventario; user id = inventario; password = Admin1234;"
    Public Mysqlconecction As MySqlConnection = New MySqlConnection(conexionMySQL)

    Sub openConnMySQL()
        Try
            If Mysqlconecction.State = 0 Then
                Mysqlconecction.Open()
                'MsgBox("Hay conexión con MYSQL")
            End If
        Catch ex As Exception
            Console.WriteLine("Error MySQL: " + ex.Message)
        End Try
    End Sub
    Sub closeConnMySQL()
        Mysqlconecction.Close()
        Console.WriteLine("Cerrar conexion MySQL")
    End Sub
End Module
