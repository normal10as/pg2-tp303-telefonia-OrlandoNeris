

Public Class Persona
    Inherits Cliente

    Private _apellido As String
    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 30 Then
                _apellido = value
            End If
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

    Private _documento As UInteger
    Public Property Documento As UInteger
        Get
            Return _documento
        End Get
        Set(value As UInteger)
            _documento = value
        End Set
    End Property

    Sub New(cuenta As UInteger, apellido As String, nombre As String, documento As UInteger)
        MyBase.New(cuenta)
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Documento = documento
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function

End Class
