
Imports Entidades

Module Equipo_test

    Sub main()
        Dim modelo As New Modelo("J7")
        Dim marca As New Marca("Samsung")
        Dim e1 As New Equipo(marca, modelo, "1234")
        e1.Vender(Now.AddDays(-10))
        Console.WriteLine("Numero de Serie: " & e1.Serie)
        Console.WriteLine("Fecha de Venta: " & e1.FechaVenta)

        Console.ReadKey()
    End Sub

End Module
