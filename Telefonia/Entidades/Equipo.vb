
Imports Entidades

Public Class Equipo

    Private _serie As String
    Public Property Modelo As String
        Get
            Return _serie
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 15 Then
                _serie = value
            End If
        End Set
    End Property

    Private _fechaVenta As Date
    Public ReadOnly Property FechaVenta As Date
        Get
            Return _fechaVenta
        End Get
    End Property

    Sub New(marca As String, modelo As String, serie As String)

    End Sub




End Class
