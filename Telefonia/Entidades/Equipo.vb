
Imports Entidades

Public Class Equipo

    Private _marcaequipo As Marca
    Public Property marcaEquipo As Marca
        Get
            Return _marcaequipo
        End Get
        Set(value As Marca)
            _marcaequipo = value
        End Set
    End Property

    Private _modeloequipo As Modelo
    Public Property modeloEquipo As Modelo
        Get
            Return _modeloequipo
        End Get
        Set(value As Modelo)
            _modeloequipo = value
        End Set
    End Property

    Private _serie As String
    Public Property Serie As String
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

    Sub New(marca As Marca, modelo As Modelo, serie As String)
        Me.Serie = serie
        Me.marcaEquipo = marca
        Me.modeloEquipo = modelo
    End Sub

    Public Sub Vender(fecha As Date)
        _fechaVenta = fecha
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Serie
    End Function

End Class
