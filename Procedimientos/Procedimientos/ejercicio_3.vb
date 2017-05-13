Module ejercicio_3
    Sub main()
        Dim numero As Short
        Console.WriteLine("Ingrese un número: ")
        numero = Console.ReadLine()

        For i = 1 To 5 Step 1
            Console.WriteLine("Potencias: " & retornarPotencia(numero, i + 1))
        Next
        Console.ReadKey()
    End Sub

    Private Function retornarPotencia(valor As Short, potencia As Short) As Short
        Return valor ^ potencia
    End Function
End Module
