Module Module1

    Sub Main()
        Dim persona As Persona = New Persona("Camilo", "Mejia", "3173808514")
        'Dim miMascota As Mascota = New Mascota("Copito", 2, persona)
        Dim miGato As Gato = New Gato("Copito", 2, persona, 3)

        Console.WriteLine(miGato.Owner.LastName)
        Console.WriteLine(miGato.EdadPet)

        Dim mascotas(2) As Mascota

        For i = 0 To 2 Step 1
            Dim nomPersona, apePersona, telPersona, nomMascota As String
            Dim edadMascota As Integer
            Console.WriteLine("Dueño de la Mascota Nombre:")
            nomPersona = Console.ReadLine()
            Console.WriteLine("Dueño de la Mascota Apellido:")
            apePersona = Console.ReadLine()
            Console.WriteLine("Dueño de la Mascota Telefono:")
            telPersona = Console.ReadLine()
            Console.WriteLine("Nombre de la Mascota:")
            nomMascota = Console.ReadLine()
            Console.WriteLine("Edad de la Mascota:")
            edadMascota = Console.ReadLine()

            Dim mascota As New Mascota(nomMascota, edadMascota, New Persona(nomPersona, nomMascota, telPersona))
            mascotas(i) = mascota
        Next
        For Each m As Mascota In mascotas
            Console.WriteLine("~~~~~~~~~~~~~~~~")
            Console.WriteLine(m.Owner.Name & " " & m.Owner.LastName)
            Console.WriteLine(m.NamePet & " " & m.EdadPet)
        Next

    End Sub

End Module
