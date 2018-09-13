
Imports Entidades

Module Linea_Test

    Sub main()

        Dim Linea1 As New Linea(3764, 391393)
        Linea1.Reactivar()
        Console.WriteLine("Codigo de area: " & Linea1.CodigoArea)
        Console.WriteLine("Numero : " & Linea1.Numero)
        Console.WriteLine("ToString: " & Linea1.ToString)

        Linea1.suspender()
        Console.WriteLine("Codigo de area: " & Linea1.CodigoArea)
        Console.WriteLine("Numero : " & Linea1.Numero)
        Console.WriteLine("ToString: " & Linea1.ToString)

        Console.ReadKey()
    End Sub

End Module
