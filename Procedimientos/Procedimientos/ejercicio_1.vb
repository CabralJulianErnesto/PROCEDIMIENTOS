Module ejercicio_1

    Sub Main()
        horaActual()
        fechaActual()

        Console.WriteLine("Hora actual: " & horaActual())

        Console.ReadKey()
    End Sub

    Private Sub fechaActual()
        Console.WriteLine("Fecha actual: " & Today)
    End Sub
    Private Function horaActual() As String
        Return TimeOfDay
    End Function


End Module