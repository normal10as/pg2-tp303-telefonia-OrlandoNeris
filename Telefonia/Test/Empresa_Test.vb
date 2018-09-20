
Imports Entidades

Module Empresa_Test

    Sub main()

        Dim empresa1 = New Empresa(651561, "los bandeirantes", "25-45486848-1")

        Console.WriteLine("Razon Social: " & empresa1.RazonSocial)
        Console.WriteLine("N° de Cuenta: " & empresa1.Cuenta)
        Console.WriteLine("Cuit: " & empresa1.Cuit)
        Console.WriteLine("ToString: " & empresa1.ToString)

        Console.ReadKey()

    End Sub


End Module
