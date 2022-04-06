Module Module1

    Sub Main()

        Dim dateInMay As New System.DateTime(2019, 5, 31, 12, 14, 1)
        Dim someDateAndTime As Date = #2/5/2022 12:14:01 PM#

        Dim dia, diaSemana, mes, año, mesNombre, fechaHoy As String

        Console.WriteLine("*********Fechas*********")
        Console.WriteLine(dateInMay)
        Console.WriteLine(someDateAndTime)
        dia = Day(Now)
        Console.WriteLine(dia)
        diaSemana = Weekday(Now)
        Console.WriteLine(diaSemana)
        mes = Month(Now)
        Console.WriteLine(mes)
        mesNombre = MonthName(mes)
        Console.WriteLine(mesNombre)
        año = Year(Now)
        Console.WriteLine(año)

        'Format
        fechaHoy = Format(Now, "dd-MM-yyyy hh:mm:ss")
        Console.WriteLine(fechaHoy)

    End Sub

End Module
