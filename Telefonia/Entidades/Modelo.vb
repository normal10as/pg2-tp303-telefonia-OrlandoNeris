Public Class Modelo

    Private _marca As Marca
    Public Property Marca As Marca
        Get
            Return _marca
        End Get
        Set(value As Marca)
            _marca = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 50 Then
                _nombre = value
            End If
        End Set
    End Property

    Sub New(nombre As String, marca As Marca)
        Me.Nombre = nombre
        Me.Marca = marca
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function



End Class
