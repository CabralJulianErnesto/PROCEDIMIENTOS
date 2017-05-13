Module ejercicio_6

    Private Function calcularSumatoria(ByRef calculoSumatoria As Integer, N As UInt16) As Integer
        calculoSumatoria += Math.Pow(N, 2)
        Return calculoSumatoria
    End Function

    Private Function validarValores(valor As Single) As Boolean
        If valor > 0 And valor = Int(valor) Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub main()
        Dim num As Integer
        Dim sumatoria As Integer

        Do
            Console.WriteLine("Ingrese número: ")
            num = Console.ReadLine()

        Loop Until validarValores(num)

        For i = 1 To num
            Console.WriteLine("La sumatoria es: " & calcularSumatoria(sumatoria, i))
        Next

        Console.ReadKey()
    End Sub

End Module
