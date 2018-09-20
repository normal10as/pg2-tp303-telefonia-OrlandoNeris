Public MustInherit Class Plan

    Private _credito As UInteger
    Public Property Credito As UInteger
        Get
            Return _credito
        End Get
        Set(value As UInteger)
            _credito = value
        End Set
    End Property

    Private _precio As Decimal
    Public Property Precio As Decimal
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            _precio = value
        End Set
    End Property

    Public Sub NuevoConsumo(valor As UInteger)
        If valor - _credito Then

    End Sub

    Public Function getDisponible() As UInteger
        Return 0
    End Function

End Class
