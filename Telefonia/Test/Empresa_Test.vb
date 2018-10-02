
Imports Entidades

Module Empresa_Test

    Sub main()

        Dim empresa1 = New Empresa(651561, "los bandeirantes", "25-45486848-1")
        Dim marca1 = New Marca("Samsung")
        Dim modelo1 = New Modelo("j7", marca1)
        Dim equipo1 = New Equipo(modelo1, "545554878")

        Dim linea1 = New Linea(3764, 391393, equipo1)
        Dim linea2 = New Linea(3764, 392393, equipo1)
        Dim linea3 = New Linea(3764, 395493, equipo1)


        empresa1.addLineas(linea1)
        empresa1.addLineas(linea2)
        empresa1.addLineas(linea3)

        Mostrar(empresa1)

        empresa1.removeLinea(linea2)

        Mostrar(empresa1)
        Console.ReadKey()

    End Sub

    Private Sub Mostrar(empresa As Empresa)
        Console.WriteLine("Razon Social: " & empresa.RazonSocial)
        Console.WriteLine("N° de Cuenta: " & empresa.Cuenta)
        Console.WriteLine("Cuit: " & empresa.Cuit)
        Console.WriteLine("ToString: " & empresa.ToString)
        Console.WriteLine("Cantidad de lineas: " & empresa.getAllLineas.Count)
        Console.WriteLine()
        For Each auxlinea In empresa.getAllLineas
            Console.WriteLine("linea: " & auxlinea.ToString)
        Next
    End Sub
End Module
