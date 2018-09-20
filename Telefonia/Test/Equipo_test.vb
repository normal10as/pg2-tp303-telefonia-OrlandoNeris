
Imports Entidades

Module Equipo_test

    Sub main()

        Dim marca As New Marca("Samsung")
        Dim modelo As New Modelo("J7", marca)
        Dim e1 As New Equipo(modelo, "1234")

        e1.Vender(Now.AddDays(-10))

        Console.WriteLine("Numero de Serie: " & e1.Serie)
        Console.WriteLine("Fecha de Venta: " & e1.FechaVenta)
        Console.WriteLine("Marca: " & e1.Modelo.Marca.ToString)
        Console.WriteLine("Modelo: " & e1.Modelo.ToString)

        Console.ReadKey()

    End Sub

End Module
