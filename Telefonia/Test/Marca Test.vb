
Imports Entidades

Module Marca_Test

    Sub main()

        Dim marca1 As Marca = New Marca("Samsung")

        Console.WriteLine("Marca: " & marca1.Nombre)
        Console.WriteLine("To String: " & marca1.ToString)

        Console.ReadKey()
    End Sub

End Module
