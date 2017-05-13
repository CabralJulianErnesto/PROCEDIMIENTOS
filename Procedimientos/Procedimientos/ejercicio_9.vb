Module Ejercicio_9
    Sub main()
        Dim elegir As Single
        Console.WriteLine("1- Calcular área de un Cuadrado. 2-Calcular área de un rectángulo. 3-Calcular área de un trapecio.")

        elegir = Console.ReadLine()

        Select Case elegir
            Case 1
                Console.WriteLine("Ingrese el valor del lado: ")
                Dim lado As Integer = Console.ReadLine()

                Console.WriteLine("área de un cuadrado: " & resolverArea(lado))
            Case 2
                Console.WriteLine("Ingrese el valor de la base: ")
                Dim base As Integer = Console.ReadLine()
                Console.WriteLine("Ingrese el valor de la altura: ")
                Dim altura As Integer = Console.ReadLine()

                Console.WriteLine("área de un rectángulo: " & resolverArea(base, altura))
            Case 3
                Console.WriteLine("Ingrese el valor de la base: ")
                Dim base As Integer = Console.ReadLine()
                Console.WriteLine("Ingrese el valor de la base_: ")
                Dim base_ As Integer = Console.ReadLine()
                Console.WriteLine("Ingrese el valor de la altura: ")
                Dim h As Integer = Console.ReadLine()

                Console.WriteLine("área de un trapeccio: " & resolverArea(base, base_, h))
        End Select

        Console.ReadKey()

    End Sub

    Private Function resolverArea(lado As Integer) As Integer
        Return Math.Pow(lado, 2)
    End Function
    Private Function resolverArea(base As Integer, altura As Integer) As Integer
        Return base * altura
    End Function
    Private Function resolverArea(base As Integer, base_ As Integer, h As Integer)
        Return (base + base_ / 2) * h
    End Function

End Module
