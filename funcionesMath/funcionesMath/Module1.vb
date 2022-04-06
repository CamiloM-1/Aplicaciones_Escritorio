Module Module1

    Sub Main()

        Dim num1 As Double = 3.898989
        Dim num2 As Double = 9.89

        'Número Pi
        Console.WriteLine(Math.PI)

        'Euler
        Console.WriteLine(Math.E)

        'Potencia
        Console.WriteLine(Math.Pow(num1, 3))

        'Raiz cuadrada
        Console.WriteLine(Math.Sqrt(num2))

        'Redondeo 0-4 abajo 5-9 arriba
        Console.WriteLine(Math.Round(Math.Sqrt(num2), 2))


    End Sub

End Module
