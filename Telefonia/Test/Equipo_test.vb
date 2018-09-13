
Imports Entidades

Module Equipo_test

    Sub main()

        Dim e1 As New Equipo("", "", "1234")
        e1.Vender(Now.AddDays(-10))
        Console.WriteLine("Numero de Serie: " & e1.Serie)

        Console.ReadKey()
    End Sub

End Module
