Module Module1

    Sub Main()
        Dim opc As Integer
        Console.WriteLine("Digita una opción:" & vbCrLf &
                          "1) Math" & vbCrLf &
                          "2) String")
        opc = Console.ReadLine()
        Select Case opc
            Case 1
                Math1()
            Case 2
                Str()
        End Select
    End Sub

    Sub Math1()
        Dim numeros() As Decimal = {-15, 0, 24, 2.5, -1.5, -102}

        For Each num As Decimal In numeros
            Console.WriteLine("Numero: {0} , Abs: {1}", num, Math.Abs(num))
        Next
    End Sub

    Sub Str()
        Dim str As String = "aaa"
        Console.WriteLine("String inicial: '{0}'", str)
        str = str.Replace("a", "d")
        Console.WriteLine("String final: '{0}'", str)
    End Sub

End Module
