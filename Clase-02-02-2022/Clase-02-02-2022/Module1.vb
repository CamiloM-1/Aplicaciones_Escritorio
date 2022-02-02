Module Module1

    Sub Main()
        'Dim tam As Integer

        'Do
        '    Console.WriteLine("Ingrese el tamaño del arreglo:")
        '    tam = Console.ReadLine()
        'Loop While (tam <= 2)

        'Dim myArray(tam) As Double

        'Dim matriz(4, 5) As Double

        'For i = 0 To 3
        '    For j = 0 To 4
        '        matriz(i, j) = Int((80 - 100) * Rnd() + 100)
        '    Next
        'Next

        'For i = 0 To matriz.GetUpperBound(0) - 1
        '    For j = 0 To matriz.GetUpperBound(1) - 1
        '        Console.Write(matriz(i, j) & " ")
        '    Next
        '    Console.WriteLine()
        'Next


        'Dim r1 As Integer = myArray.Length
        'Console.WriteLine("r1: {0}", r1)
        'Dim r2 As Integer = myArray.GetLength(0)
        'Console.WriteLine("r2: {0}", r2)
        'Dim r3 As Integer = myArray.GetUpperBound(0)
        'Console.WriteLine("r3: {0}", r3)

        'For i = 0 To myArray.GetLength(0) - 2
        '    myArray(i) = i * 2
        'Next
        'For i = 0 To myArray.GetLength(0) - 2
        '    Console.WriteLine(myArray(i) & " ")
        'Next
        'Console.WriteLine("****************************")
        'For i = 0 To myArray.GetUpperBound(0) - 1
        '    myArray(i) = i + 2
        'Next
        'For i = 0 To myArray.GetUpperBound(0) - 1
        '    Console.WriteLine(myArray(i) & " ")
        'Next
        proSuma(3, 6)
        Console.WriteLine("La resta es: {0}", proResta(4, 5))
    End Sub

    Sub proSuma(num1 As Double, num2 As Double)
        Dim suma As Double
        suma = num1 + num2
        Console.WriteLine("La suma es: {0}", suma)
    End Sub

    Function proResta(num1 As Double, num2 As Double) As Double
        Return num1 - num2
    End Function
End Module
