Module Module1

    Sub Main()
        Dim miPersona1 As Persona = New Persona()
        Dim miPersona2 As Persona

        miPersona2 = New Persona("Camilo", "Mejia", 24, "Masculino")

        Dim nom As String = miPersona2.Nombre()
        Console.WriteLine(nom)
        miPersona2.Nombre() = "Juan"
        Console.WriteLine(miPersona2.Nombre())

        Persona.contador = 4
        Persona.Contando()
        Console.WriteLine(Persona.contador)

        Dim miPersona3 As Persona1 = New Persona1("Camilo", "Mejia", 24)
        Console.WriteLine(miPersona3.nombre)
        miPersona3.printing()
        miPersona3.age(15)


    End Sub

End Module
