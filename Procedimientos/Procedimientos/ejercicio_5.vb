Module ejercicio_5

    Sub main()
        Dim radio, altura As Single

        Do
            Console.WriteLine("Ingrese altura: ")
            altura = Console.ReadLine()
        Loop Until validarValores(altura)

        Do
            Console.WriteLine("Ingrese radio: ")
            radio = Console.ReadLine()
        Loop Until validarValores(radio)


        Console.WriteLine("Cálculo del volumen: " & devolverVolumen(radio, altura))
        Console.ReadKey()

    End Sub

    Private Function devolverVolumen(r As Single, h As Single) As Double
        Return Math.PI * Math.Pow(r, 2) * h
    End Function
    Private Function validarValores(valor As Single) As Boolean
        If valor > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

End Module
