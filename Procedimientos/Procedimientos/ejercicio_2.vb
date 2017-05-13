Module ejercicio_2
    Sub main()
        Dim fecha As Date
        Dim dias As Short
        Console.WriteLine("Ingresa una fecha: ")
        fecha = Console.ReadLine()
        Console.WriteLine("Ingrese la cantidad de días a sumar: ")
        dias = Console.ReadLine()

        Console.WriteLine("fecha nueva: " & sumarDias(fecha, dias))
        Console.ReadKey()
    End Sub

    Private Function sumarDias(fecha As Date, valor As Short) As Date
        Return fecha.AddDays(valor)
    End Function
End Module
