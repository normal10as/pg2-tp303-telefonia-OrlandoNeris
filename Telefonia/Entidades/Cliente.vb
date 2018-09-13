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

    Sub New()

    End Sub


End Class
