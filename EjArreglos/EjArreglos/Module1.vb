Module Module1

    Sub Main()
        Dim opt As Integer
        Console.WriteLine("Digite una opción:")
        Console.WriteLine("1) Generar y rellenar un arreglo unidimensional, pedir la longitud del arreglo al usuario y debe contener valores pares partiendo desde el 2" & vbCrLf &
                          "2) Generar y rellenar un arreglo unidimensional, los valores a llenar será el resultado de la tabla de multiplicar del que desee el usuario" & vbCrLf &
                          "3) Generar y rellenar una matriz cuadrada de dimensión o longitud dada por el usuario, llenarla con número impares" & vbCrLf &
                          "4) Dada una matriz de dimensiones dadas por el usuario, llenarla con un valor único que daría el usuario y multiplicado por su posición" & vbCrLf &
                          "5) Generar una matriz cuadrada mostrar solo la diagonal principal con elementos 0(DP)" & vbCrLf &
                          "6) Generar una matriz cuadrada mostrar solo la diagonal trasversa con elementos 0 (DT)" & vbCrLf &
                          "7) Generar una matriz cuadrada mostrar solo la diagonal principal y trasversa" & vbCrLf &
                          "8) Generar una matriz cuadrada mostrar solo las puntas de la matriz con elementos 0" & vbCrLf &
                          "9) Generar una matriz cuadrada dibujar un cuadrado con 0" & vbCrLf &
                          "10) Generar una matriz cuadrada NxN(solo valores impares y mayores a 3) y generar el sgte relleno: N=5")
        opt = Console.ReadLine()
        Select Case opt
            Case 1
                punto1()
            Case 2
                punto2()
            Case 3
                punto3()
            Case 4
                punto4()
            Case 5
                punto5()
            Case 6
                punto6()
            Case 7
                punto7()
            Case 8
                punto8()
            Case 9
                punto9()
            Case 10
                punto10()
            Case Else
                Console.WriteLine("Opcion no valida")
        End Select
    End Sub

    Sub punto1()
        'Generar y rellenar un arreglo unidimensional, pedir la longitud del arreglo al usuario y debe contener valores pares partiendo desde el 2
        Dim tam As Integer
        Dim aux As Integer
        Do
            Console.WriteLine("Digita el tamaño del arreglo")
            tam = Console.ReadLine()
            If (tam <= 2) Then
                Console.WriteLine("El tamaño del arreglo debe ser mayor a 2")
            End If
        Loop While (tam <= 2)
        Dim myArray(tam) As Double
        aux = 2
        For i = 0 To myArray.GetUpperBound(0) - 1
            myArray(i) += aux
            aux += 2
        Next
        Console.WriteLine("Arreglo")
        For i = 0 To myArray.GetUpperBound(0) - 1
            Console.WriteLine(myArray(i))
        Next
    End Sub

    Sub punto2()
        'Generar y rellenar un arreglo unidimensional, los valores a llenar será el resultado de la tabla de multiplicar del que desee el usuario
        Dim tam As Integer
        Dim multi As Integer
        Do
            Console.WriteLine("Digita el tamaño del arreglo")
            tam = Console.ReadLine()
            If (tam <= 2) Then
                Console.WriteLine("El tamaño del arreglo debe ser mayor a 2")
            End If
        Loop While (tam <= 2)
        Console.WriteLine("Digite el multiplo")
        multi = Console.ReadLine()
        Dim myArray(tam) As Double
        For i = 0 To myArray.GetUpperBound(0) - 1
            myArray(i) = multi * (i + 1)
        Next
        Console.WriteLine("Arreglo")
        For i = 0 To myArray.GetUpperBound(0) - 1
            Console.WriteLine(myArray(i))
        Next
    End Sub

    Sub punto3()
        'Generar y rellenar una matriz cuadrada de dimensión o longitud dada por el usuario, llenarla con número impares
        Dim tam As Integer
        Dim aux As Integer
        Do
            Console.WriteLine("Digita la dimensión de la matriz")
            tam = Console.ReadLine()
            If (tam <= 1) Then
                Console.WriteLine("La dimensión de la matriz debe ser mayor a 2 o igual a 2")
            End If
        Loop While (tam <= 1)
        aux = 1
        Dim matriz(tam, tam) As Integer
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                matriz(i, j) = aux
                aux += 2
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub punto4()
        'Dada una matriz de dimensiones dadas por el usuario, llenarla con un valor único que daría el usuario y multiplicado por su posición
        Dim tam As Integer
        Dim multi As Integer
        Do
            Console.WriteLine("Digita la dimensión de la matriz")
            tam = Console.ReadLine()
            If (tam <= 1) Then
                Console.WriteLine("La dimensión de la matriz debe ser mayor a 2 o igual a 2")
            End If
        Loop While (tam <= 1)
        Console.WriteLine("Digite el multiplo")
        multi = Console.ReadLine()
        Dim matriz(tam, tam) As String
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                matriz(i, j) = multi * i & "," & multi * j
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub punto5()
        'Generar una matriz cuadrada mostrar solo la diagonal principal con elementos 0(DP)
        Dim matriz(6, 6) As String
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                If (i = j) Then
                    matriz(i, j) = "0"
                End If
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub punto6()
        'Generar una matriz cuadrada mostrar solo la diagonal trasversa con elementos 0 (DT)
        Dim matriz(6, 6) As String
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                If (i + j = matriz.GetUpperBound(0) - 1) Then
                    matriz(i, j) = "0"
                End If
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub punto7()
        'Generar una matriz cuadrada mostrar solo la diagonal principal y trasversa
        Dim matriz(6, 6) As String
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                If (i = j) Then
                    matriz(i, j) = "X"
                ElseIf (i + j = matriz.GetUpperBound(0) - 1) Then
                    matriz(i, j) = "X"
                End If
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub punto8()
        'Generar una matriz cuadrada mostrar solo las puntas de la matriz con elementos 0
        Dim matriz(6, 6) As String
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                If (i = 0 Or i = matriz.GetUpperBound(0) - 1) And (j = 0 Or j = matriz.GetUpperBound(1) - 1) Then
                    matriz(i, j) = "0"
                End If
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub punto9()
        'Generar una matriz cuadrada dibujar un cuadrado con 0
        Dim matriz(6, 6) As String
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                If (i = 0 Or i = matriz.GetUpperBound(0) - 1 Or j = 0 Or j = matriz.GetUpperBound(1) - 1) Then
                    matriz(i, j) = "0"
                Else
                    matriz(i, j) = " "
                End If
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub punto10()
        'Generar una matriz cuadrada NxN(solo valores impares y mayores a 3) y generar el sgte relleno: N=5
        Dim tam As Integer
        Dim x As Integer
        Do
            Console.WriteLine("Digita la dimensión de la matriz")
            tam = Console.ReadLine()
            If (tam <= 3 Or tam Mod 2 = 0) Then
                Console.WriteLine("La dimensión debe ser impar y mayor a 3")
            End If
        Loop While (tam <= 3 Or tam Mod 2 = 0)
        Dim matriz(tam, tam) As Integer
        x = tam / 2 + 1
        For i = 0 To x
            For j = i + 1 To tam - 1 - (i + 1)
                matriz(i, j) = 1
                matriz(tam - i - 1, j) = 1
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                If (matriz(i, j) <> 1) Then
                    matriz(i, j) = tam - 1
                End If
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

End Module
