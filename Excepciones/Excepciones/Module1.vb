Module Module1

    Sub Main()
        Dim nombres As String
        Dim apellidos As String
        Dim edad As Integer
        Dim miPersona As Persona
        Dim valor As Double

        Try
            Console.WriteLine("Nombre:")
            nombres = Console.ReadLine()
            Console.WriteLine("Apellido:")
            apellidos = Console.ReadLine()
            Console.WriteLine("Edad:")
            edad = Console.ReadLine()
            miPersona = New Persona(nombres, apellidos, edad)
            Console.WriteLine("Valor:")
            valor = Console.ReadLine()
            If valor <= 0 Then
                Throw New Exception("El valor de la compra debe ser mayor a 0")
            End If

        Catch ex As Exception
            Console.WriteLine(ex.Message + " Otro mensaje")
        Finally
            Console.WriteLine("Estoy en el Finally")
        End Try

    End Sub

End Module
