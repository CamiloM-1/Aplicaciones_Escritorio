Module Module1

    Sub Main()
        Dim opcion As Integer
        Console.WriteLine("Digite una opción:")
        Console.WriteLine("1) Determinar si un número es positivo y par.")
        Console.WriteLine("2) Calcular el cubo de un número entero ingresado por el usuario solo sí, el número es múltiplo de 3 y 5.")
        Console.WriteLine("3) Calcular el cuadrado de un número entero ingresado por el usuario solo sí, el número es múltiplo de 4 y 16.")
        Console.WriteLine("4) Realizar un algoritmo que permita dar una ponderación cualitativa, según una nota cuantitativa:" & vbCrLf &
                          "   - Rango:  0 y 40: Pésimo, Aplazado sin oportunidad" & vbCrLf &
                          "   - Rango:  41 y 45: Deficiente, Aplazado a reparación" & vbCrLf &
                          "   - Rango: 46 y 50: Bajo, Aplazado repetir examen" & vbCrLf &
                          "   - Rango 51 y 60: Regular, No aplazado – Remedial" & vbCrLf &
                          "   - Rango 61 y 70: Bien" & vbCrLf &
                          "   - Rango 71 y 80: Muy Bien" & vbCrLf &
                          "   - Rango 81 y 100: Excelente")
        Console.WriteLine("5) Calcular el pago por galones de gasolina de una estación de servicio, según el tipo de gasolina:" & vbCrLf &
                          "   - Gasolina Premium Extra:  1 litro: 5.000 pesos" & vbCrLf &
                          "   - Gasolina Premium:  1 litro: 3.900 pesos" & vbCrLf &
                          "   - Gasolina Corriente: 1 litro 3.200 pesos" & vbCrLf &
                          "   Se debe mostrar la cantidad de gasolina expresada en galones y litros, el cliente pide en galones.")
        Console.WriteLine("6) Calcular el monto a pagar por el servicio de internet según el nivel del cliente y la cantidad de MB:" & vbCrLf &
                          "   Cada MB tiene un precio de:" & vbCrLf &
                          "   - Nivel 1: 5000 mil pesos" & vbCrLf &
                          "   - Nivel 2: 7000 mil pesos" & vbCrLf &
                          "   - Nivel 3: 9000 mil pesos" & vbCrLf &
                          "   - Nivel 4: 15000 mil pesos" & vbCrLf &
                          "   - Nivel 5: 22000 mil pesos" & vbCrLf &
                          "   - Nivel 6: 30000 mil pesos" & vbCrLf &
                          "   Todos los demás niveles 35000 mil pesos")
        Console.WriteLine("7) Calcular el sueldo a pagar de un trabajador dado que se debe ingresar la cantidad de horas trabajadas y el valor de la hora en pesos.")
        Console.WriteLine("8) Calcular el interés a pagar por un dinero, colocado a generar interés diario. Se debe ingresar la cantidad de dinero, los días que lleva generando interés y el interés. Se debe imprimir el interés y la cantidad de dinero más el interés.")
        Console.WriteLine("9) Leer dos números enteros y determinar ¿cuál de los dos es positivo?")
        Console.WriteLine("10) Realizar un pseudocódigo que sume 3 números e imprima la suma.")
        Console.WriteLine("11) Realizar un pseudocódigo que sume 3 números impares e imprima la suma.")
        Console.WriteLine("12) Dado una compra realizada calcular: el iva e imprimir: la compra sin iva, el iva en pesos y el monto con el iva. Tomar en cuenta que el iva es el 19%.")
        opcion = Console.ReadLine()
        Select Case opcion
            Case 1
                Punto1()
            Case 2
                Punto2()
            Case 3
                Punto3()
            Case 4
                Punto4()
            Case 5
                Punto5()
            Case 6
                Punto6()
            Case 7
                Punto7()
            Case 8
                Punto8()
            Case 9
                Punto9()
            Case 10
                Punto10()
            Case 11
                Punto11()
            Case 12
                Punto12()
            Case Else
                Console.WriteLine("Opción no valida")

        End Select
    End Sub

    Sub Punto1()
        Console.WriteLine("1) Determinar si un número es positivo y par.")
        Dim numero As Integer
        Console.WriteLine("Digite un número")
        numero = Console.ReadLine()
        If (numero Mod 2 = 0 And numero > 0) Then
            Console.WriteLine("El número {0} es positivo y par ", numero)
        Else
            Console.WriteLine("El número {0} no es positivo y par ", numero)
        End If
    End Sub

    Sub Punto2()
        Console.WriteLine("2) Calcular el cubo de un número entero ingresado por el usuario solo sí, el número es múltiplo de 3 y 5.")
        Dim numero As Integer
        Dim potencia As Integer
        Console.WriteLine("Digite un número")
        numero = Console.ReadLine()
        If (numero Mod 3 = 0 And numero Mod 5 = 0) Then
            potencia = numero ^ 3
            Console.WriteLine("El numero {0} es múltiplo de 3 y 5", numero)
            Console.WriteLine("La potencia del numero {0} es {1}", numero, potencia)
        Else
            Console.WriteLine("El numero {0} no es múltiplo de 3 y 5", numero)
        End If
    End Sub

    Sub Punto3()
        Console.WriteLine("3) Calcular el cuadrado de un número entero ingresado por el usuario solo sí, el número es múltiplo de 4 y 16.")
        Dim numero As Integer
        Dim potencia As Integer
        Console.WriteLine("Digite un número")
        numero = Console.ReadLine()
        If (numero Mod 4 = 0 And numero Mod 16 = 0) Then
            potencia = numero ^ 2
            Console.WriteLine("El numero {0} es múltiplo de 4 y 16", numero)
            Console.WriteLine("La potencia del numero {0} es {1}", numero, potencia)
        Else
            Console.WriteLine("El numero {0} no es múltiplo de 4 y 16", numero)
        End If
    End Sub

    Sub Punto4()
        Console.WriteLine("4) Realizar un algoritmo que permita dar una ponderación cualitativa, según una nota cuantitativa:" & vbCrLf &
                          "   - Rango:  0 y 40: Pésimo, Aplazado sin oportunidad" & vbCrLf &
                          "   - Rango:  41 y 45: Deficiente, Aplazado a reparación" & vbCrLf &
                          "   - Rango: 46 y 50: Bajo, Aplazado repetir examen" & vbCrLf &
                          "   - Rango 51 y 60: Regular, No aplazado – Remedial" & vbCrLf &
                          "   - Rango 61 y 70: Bien" & vbCrLf &
                          "   - Rango 71 y 80: Muy Bien" & vbCrLf &
                          "   - Rango 81 y 100: Excelente")
        Dim nota As Double
        Console.WriteLine("Digite la nota del estudiante")
        nota = Console.ReadLine()
        If (nota >= 0 And nota <= 40) Then
            Console.WriteLine("Pésimo, Aplazado sin oportunidad")
        ElseIf (nota >= 41 And nota <= 45) Then
            Console.WriteLine("Deficiente, Aplazado a reparación")
        ElseIf (nota >= 46 And nota <= 50) Then
            Console.WriteLine("Bajo, Aplazado repetir examen")
        ElseIf (nota >= 51 And nota <= 60) Then
            Console.WriteLine("Regular, No aplazado - Remedial")
        ElseIf (nota >= 61 And nota <= 70) Then
            Console.WriteLine("Bien")
        ElseIf (nota >= 71 And nota <= 80) Then
            Console.WriteLine("Muy Bien")
        ElseIf (nota >= 81 And nota <= 100) Then
            Console.WriteLine("Excelente")
        Else
            Console.WriteLine("La nota no esta en el rango permitido")
        End If
    End Sub

    Sub Punto5()
        Console.WriteLine("5) Calcular el pago por galones de gasolina de una estación de servicio, según el tipo de gasolina:" & vbCrLf &
                          "   - Gasolina Premium Extra:  1 litro: 5.000 pesos" & vbCrLf &
                          "   - Gasolina Premium:  1 litro: 3.900 pesos" & vbCrLf &
                          "   - Gasolina Corriente: 1 litro 3.200 pesos" & vbCrLf &
                          "   Se debe mostrar la cantidad de gasolina expresada en galones y litros, el cliente pide en galones.")
        Dim galones As Double
        Dim cant As Double
        Dim valor As Double
        Dim tipo As String
        Const tipo1 As String = "Premium Extra"
        Const tipo2 As String = "Premium"
        Const tipo3 As String = "Corriente"
        Console.WriteLine("Que tipo de Gasolina desea")
        Console.WriteLine(tipo1)
        Console.WriteLine(tipo2)
        Console.WriteLine(tipo3)
        tipo = Console.ReadLine()
        Console.WriteLine("Digite la cantidad de galones")
        galones = Console.ReadLine()
        cant = galones * 3.7854
        If (tipo.ToLower = tipo1.ToLower And galones > 0) Then
            valor = cant * 5000
            Console.WriteLine("Usted pidio {0} galones de gasolina {1} lo que equivale a {2} Litros", galones, tipo1, cant)
            Console.WriteLine("El valor de la gasolina es de {0}", valor)
        ElseIf (tipo.ToLower = tipo2.ToLower And galones > 0) Then
            valor = cant * 3900
            Console.WriteLine("Usted pidio {0} galones de gasolina {1} lo que equivale a {2} Litros", galones, tipo2, cant)
            Console.WriteLine("El valor de la gasolina es de {0}", valor)
        ElseIf (tipo.ToLower = tipo3.ToLower And galones > 0) Then
            valor = cant * 3200
            Console.WriteLine("Usted pidio {0} galones de gasolina {1} lo que equivale a {2} Litros", galones, tipo3, cant)
            Console.WriteLine("El valor de la gasolina es de {0}", valor)
        Else
            Console.WriteLine("No se encontro el tipo de gasolina o la cantidad de galones es negativa")
        End If
    End Sub

    Sub Punto6()
        Console.WriteLine("6) Calcular el monto a pagar por el servicio de internet según el nivel del cliente y la cantidad de MB:" & vbCrLf &
                          "   Cada MB tiene un precio de:" & vbCrLf &
                          "   - Nivel 1: 5000 mil pesos" & vbCrLf &
                          "   - Nivel 2: 7000 mil pesos" & vbCrLf &
                          "   - Nivel 3: 9000 mil pesos" & vbCrLf &
                          "   - Nivel 4: 15000 mil pesos" & vbCrLf &
                          "   - Nivel 5: 22000 mil pesos" & vbCrLf &
                          "   - Nivel 6: 30000 mil pesos" & vbCrLf &
                          "   Todos los demás niveles 35000 mil pesos")
        Dim nivel As Integer
        Dim cant As Integer
        Dim valor As Double
        Console.WriteLine("Digite el nivel de su servicio a internet")
        nivel = Console.ReadLine()
        Console.WriteLine("Digite la cantidad de MB contratadas")
        cant = Console.ReadLine()
        If (nivel = 1 And cant > 0) Then
            valor = cant * 5000
            Console.WriteLine("El valor a pagar es {0} por el nivel {1} de internet", valor, nivel)
        ElseIf (nivel = 2 And cant > 0) Then
            valor = cant * 7000
            Console.WriteLine("El valor a pagar es {0} por el nivel {1} de internet", valor, nivel)
        ElseIf (nivel = 3 And cant > 0) Then
            valor = cant * 9000
            Console.WriteLine("El valor a pagar es {0} por el nivel {1} de internet", valor, nivel)
        ElseIf (nivel = 4 And cant > 0) Then
            valor = cant * 15000
            Console.WriteLine("El valor a pagar es {0} por el nivel {1} de internet", valor, nivel)
        ElseIf (nivel = 5 And cant > 0) Then
            valor = cant * 22000
            Console.WriteLine("El valor a pagar es {0} por el nivel {1} de internet", valor, nivel)
        ElseIf (nivel = 6 And cant > 0) Then
            valor = cant * 30000
            Console.WriteLine("El valor a pagar es {0} por el nivel {1} de internet", valor, nivel)
        ElseIf (nivel >= 6 And cant > 0) Then
            valor = cant * 35000
            Console.WriteLine("El valor a pagar es {0} por el nivel {1} de internet", valor, nivel)
        Else
            Console.WriteLine("El nivel y la cantidad de MB no puede ser menor de 1")
        End If
    End Sub

    Sub Punto7()
        Console.WriteLine("7) Calcular el sueldo a pagar de un trabajador dado que se debe ingresar la cantidad de horas trabajadas y el valor de la hora en pesos.")
        Dim horas As Double
        Dim valor As Double
        Dim pago As Double
        Console.WriteLine("Digite la cantidad de horas trabajadas")
        horas = Console.ReadLine()
        Console.WriteLine("Digite el valor de la hora en pesos")
        valor = Console.ReadLine()
        pago = horas * valor
        Console.WriteLine("El valor a pagar es: {0}", pago)
    End Sub

    Sub Punto8()
        Console.WriteLine("8) Calcular el interés a pagar por un dinero, colocado a generar interés diario. Se debe ingresar la cantidad de dinero, los días que lleva generando interés y el interés. Se debe imprimir el interés y la cantidad de dinero más el interés.")
        Dim dinero As Double
        Dim cantD As Integer
        Dim interes As Double
        Dim pago As Double
        Console.WriteLine("Digite la cantidad de dinero")
        dinero = Console.ReadLine()
        Console.WriteLine("Digite la cantidad de días")
        cantD = Console.ReadLine()
        Console.WriteLine("Digita la tase de interés")
        interes = Console.ReadLine()
        If (dinero > 0 And cantD > 0 And interes > 0) Then
            pago = (dinero * cantD) * (interes / 100)
            Console.WriteLine("La cantidad de dinero a generar interes es {0}", dinero)
            Console.WriteLine("La cantidad de días son {0} y la tasa de interes es {1}", cantD, interes)
            Console.WriteLine("El interes a pagar es {0}", pago)
        End If
    End Sub

    Sub Punto9()
        Console.WriteLine("9) Leer dos números enteros y determinar ¿cuál de los dos es positivo?")
        Dim numero1 As Double
        Dim numero2 As Double
        Console.WriteLine("Digite el primer número")
        numero1 = Console.ReadLine()
        Console.WriteLine("Digite el segundo número")
        numero2 = Console.ReadLine()
        If (numero1 > 0 And numero2 > 0) Then
            Console.WriteLine("Los dos números {0} y {1} son positivos", numero1, numero2)
        ElseIf (numero1 > 0) Then
            Console.WriteLine("El primer número {0} es positivo", numero1)
        ElseIf (numero2 > 0) Then
            Console.WriteLine("El segundo número {0} es positivo", numero2)
        Else
            Console.WriteLine("Los números no son positivos")
        End If
    End Sub

    Sub Punto10()
        Console.WriteLine("10) Realizar un pseudocódigo que sume 3 números e imprima la suma.")
        Dim numero1 As Double
        Dim numero2 As Double
        Dim numero3 As Double
        Dim suma As Double
        Console.WriteLine("Digite el primer número")
        numero1 = Console.ReadLine()
        Console.WriteLine("Digite el segundo número")
        numero2 = Console.ReadLine()
        Console.WriteLine("Digite el tercer número")
        numero3 = Console.ReadLine()
        suma = numero1 + numero2 + numero3
        Console.WriteLine("La suma es {0}", suma)
    End Sub

    Sub Punto11()
        Console.WriteLine("11) Realizar un pseudocódigo que sume 3 números impares e imprima la suma.")
        Dim numero As Double
        Dim suma As Double
        For i As Integer = 0 To 2 Step 1
            Console.WriteLine("Digite el numero {0}", (i + 1))
            numero = Console.ReadLine()
            If (numero Mod 2 <> 0) Then
                suma += numero
            Else
                Console.WriteLine("El numero no puede ser par")
                i -= 1
            End If
        Next
        Console.WriteLine("La suma es: {0}", suma)
    End Sub

    Sub Punto12()
        Console.WriteLine("12) Dado una compra realizada calcular: el iva e imprimir: la compra sin iva, el iva en pesos y el monto con el iva. Tomar en cuenta que el iva es el 19%.")
        Dim cantP As Integer
        Dim valor As Double
        Dim subtotal As Double
        Dim total As Double
        Const iva As Double = 0.19
        Dim valorI
        Console.WriteLine("Digite la cantidad de productos")
        cantP = Console.ReadLine()
        For i As Integer = 1 To cantP Step 1
            Console.WriteLine("Digite el valor del producto {0}", i)
            valor = Console.ReadLine()
            subtotal += valor
        Next
        valorI = subtotal * iva
        total = subtotal + valorI
        Console.WriteLine("El subtotal de la compra es {0}", subtotal)
        Console.WriteLine("El valor del iva es {0}", valorI)
        Console.WriteLine("El total de la compra es {0}", total)
    End Sub
End Module
