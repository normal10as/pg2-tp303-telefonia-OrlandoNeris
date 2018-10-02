Public Class Empresa
    Inherits Cliente

    Private _razonSocial As String
    Public Property RazonSocial As String
        Get
            Return _razonSocial
        End Get
        Set(value As String)
            If value <> "" And value.Length <= 80 Then
                _razonSocial = value
            End If
        End Set
    End Property

    Private _cuit As String
    Public Property Cuit As String
        Get
            Return _cuit
        End Get
        Set(value As String)
            If value <> "" And value.Length <= 15 Then
                _cuit = value
            End If
        End Set
    End Property

    Sub New(cuenta As UInteger, razonsocial As String, cuit As String)
        MyBase.New(cuenta)
        Me.RazonSocial = razonsocial
        Me.Cuit = cuit
    End Sub

    Public Overrides Function ToString() As String
        Return "Razon Social: " & RazonSocial & "   Cuenta: " & Cuenta

    End Function

End Class
