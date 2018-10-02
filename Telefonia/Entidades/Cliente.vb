Public MustInherit Class Cliente

    Private _cuenta As UInteger
    Public Property Cuenta As UInteger
        Get
            Return _cuenta
        End Get
        Set(value As UInteger)
            _cuenta = value
        End Set
    End Property

    Private _lineas As List(Of Linea)

    Public Sub addLineas(nuevalinea As Linea)
        _lineas.Add(nuevalinea)
    End Sub

    Public Sub removeLinea(linea As Linea)
        _lineas.Remove(linea)
    End Sub

    Public Function getAllLineas() As List(Of Linea)
        Return _lineas
    End Function

    Sub New(cuenta As UInteger)
        Me.Cuenta = cuenta
        _lineas = New List(Of Linea)
    End Sub

End Class
