Module Module1

    Sub Main()
        Dim cad1 As String
        Dim cad2 As String
        Dim cad3 As String
        Dim cad4 As String
        cad1 = "Hola mundo de estudiantes UE"
        cad2 = "Estamos en un mundo Contaminado "
        cad3 = "Hay que cuidar el planeta"
        cad4 = "Estamos en un"

        'Mayusculas
        Console.WriteLine(cad1.ToUpper)
        Console.WriteLine(UCase(cad1))

        'Minúsculas
        Console.WriteLine(cad1.ToLower)

        'Substring
        Console.WriteLine((cad2.Substring(0, cad4.Length) & " hermoso").ToUpper)

        'Equals
        Console.WriteLine(cad2.Equals(cad3))

        'Len y Length
        Console.WriteLine(Len(cad2) & " " & cad2.Length)

    End Sub

End Module
