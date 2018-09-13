﻿Public Class Linea

    Private _codigoArea As UShort
    Public Property CodigoArea As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            _codigoArea = value
        End Set
    End Property

    Private _numero As UInteger
    Public Property Numero As UInteger
        Get
            Return _numero
        End Get
        Set(value As UInteger)
            _numero = value
        End Set
    End Property

    Private _estado As Boolean
    Public ReadOnly Property Estado As String
        Get
            Return If(_estado, "(Activada)", "(Suspendida)")
        End Get
    End Property

    Sub New(codigoarea As UShort, numero As UInteger)
        Me.CodigoArea = codigoarea
        Me.Numero = numero
        Me._estado = True
    End Sub

    Public Sub Suspender()
        _estado = False
    End Sub

    Public Sub Reactivar()
        _estado = True
    End Sub

    Public Overrides Function ToString() As String
        Return " " & CodigoArea & " - " & Numero & "  Estado: " & Estado
    End Function

End Class