' *****************************************************************
' Team Number: 18
' Team Member 1 Details: Maheso, MV (222058372)
' Team Member 2 Details: Mabunda, XM (222030885)
' Team Member 3 Details: Sethaba, AT (216031663)
' Team Member 4 Details: Mosiane, K (222018434)
' Practical: Team Project
' Class name: Settlement
' *****************************************************************

'Option statements
Option Strict On
Option Explicit On
Option Infer Off

Public Class Settlement
    Inherits Environment

    Private _SettleType As String
    Private _nPeople As Integer
    Private _Emissions() As Double 'percentage

    Public Sub New(nYears As Integer, n As String, s As Double, nPl As Integer, nA As Integer, pT As String, rT As Double, nP As Integer, sT As String)
        MyBase.New(nYears, n, s, nPl, nA, pT, rT)

        ReDim _Emissions(nYears)
        _nPeople = nP
        _SettleType = sT
    End Sub

    'property methods
    Public Property Settletype As String
        Get
            Return _SettleType
        End Get
        Set(value As String)
            _SettleType = value
        End Set
    End Property

    Public Property nPeople As Integer
        Get
            Return _nPeople
        End Get
        Set(value As Integer)
            'validates to make sure its positive
            If value < 0 Then
                _nPeople = 0
            Else
                _nPeople = value
            End If
        End Set
    End Property

    Public Property Emissions(x As Integer) As Double
        Get
            Return _Emissions(x)
        End Get
        Set(value As Double)
            _Emissions(x) = value
        End Set
    End Property

    Public Function TotEmissions() As Double
        Dim total As Double
        For i As Integer = 1 To _Emissions.Length - 1 '  _Emissions.Length -1....(Valencia)maybe
            total += _Emissions(i)
        Next i
        Return total
    End Function

    ' Add People to the Plants and animals
    Public Overrides Function OverallTotalPop() As Integer
        Return MyBase.OverallTotalPop() + _nPeople
    End Function
End Class
