
Imports Entidades

Module Persona_Test

    Sub main()

        Dim cliente1 As Persona

        cliente1 = New Persona(1234, "Argento", "Jose", 23156616)

        MostrarContenido(cliente1)

        cliente1.Nombre = "fsdbfgasudigusidbgauisfgydudasfsdfdsgsfdgdfgdfgdfhdshsghfghoagvafsjgadhgb"
        cliente1.Apellido = "uifbsuidfbuidsagfiudsfbadsiufvbsdafvb"
        MostrarContenido(cliente1)




        Console.ReadKey()
    End Sub

    Private Sub MostrarContenido(cliente1 As Persona)
        Console.WriteLine()
        Console.WriteLine("Nombre: " & cliente1.Nombre)
        Console.WriteLine("Apellido: " & cliente1.Apellido)
        Console.WriteLine("DNI: " & cliente1.Documento)
        Console.WriteLine("Cuenta: " & cliente1.Cuenta)

    End Sub
End Module
