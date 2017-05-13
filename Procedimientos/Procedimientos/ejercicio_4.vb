Module ejercicio_4

    Private Function validarValores(valor1 As Short, valor2 As Short) As Boolean
        If valor1 > 0 And valor2 > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function hipotenusa(A As UShort, B As UShort) As Single
        Return Math.Sqrt((A ^ 2) + (B ^ 2))
    End Function

    Sub main()
        Dim ladoA As UShort
        Dim ladoB As UShort
        Do
            Console.WriteLine("Ingres el lado A: ")
            ladoA = Console.ReadLine()
            Console.WriteLine("Ingrese el lado B: ")
            ladoB = Console.ReadLine()
        Loop Until validarValores(ladoA, ladoB)

        Console.WriteLine("El cuadrado de la hipotenusa es: " & hipotenusa(ladoA, ladoB))
        Console.ReadKey()
    End Sub
End Module
