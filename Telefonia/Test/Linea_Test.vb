
Imports Entidades

Module Linea_Test

    Sub main()
        Dim marca1 As New Marca("Samsung")
        Dim modelo1 As New Modelo("J7", marca1)
        Dim equipo1 As New Equipo(modelo1, "56565494")
        Dim linea1 As New Linea(3746, 391393, equipo1)

        Console.WriteLine()

        linea1.Reactivar()
        MostrarOLinea(linea1)

        Console.WriteLine()

        linea1.Suspender()
        MostrarOLinea(Linea1)

        Console.ReadKey()
    End Sub

    Private Sub MostrarOLinea(Linea As Linea)
        Console.WriteLine("Codigo de area: " & Linea.CodigoArea)
        Console.WriteLine("Numero : " & Linea.Numero)
        Console.WriteLine("ToString: " & Linea.ToString)
        Console.WriteLine("Marca : " & Linea.Equipo.Modelo.Marca.ToString)
        Console.WriteLine("Modelo: " & Linea.Equipo.Modelo.ToString)
        Console.WriteLine("Equipo: " & Linea.Equipo.ToString)
        Console.WriteLine("Fecha de Venta: " & Linea.Equipo.FechaVenta.ToString)

    End Sub
End Module
