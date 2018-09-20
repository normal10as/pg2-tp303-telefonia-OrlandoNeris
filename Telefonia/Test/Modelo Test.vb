
Imports Entidades

Module Modelo_Test


    Sub main()

        Dim modelo1 As Modelo = New Modelo(" Grand Prime ", New Marca("Samsung"))

        Console.WriteLine("Modelo: " & modelo1.Nombre)
        Console.WriteLine("Marca: " & modelo1.Marca.ToString)
        Console.WriteLine("To String: " & modelo1.ToString)

        Console.ReadKey()
    End Sub


End Module
