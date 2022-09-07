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
    Private _nVehicles As Integer
    Private _SanitationRate As Integer
    Private _nRenewables As Integer ' Variable for renewable energy
    Private _RecycleReports As Integer 'Recycle Reports
    Private _Emissions() As Double 'percentage
    Private _nIndustryActivities As Integer


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

    Public Property SanitationRate As Integer
        Get
            Return _SanitationRate
        End Get
        Set(value As Integer)
            'validates to make sure its positive
            If value < 0 Then
                _SanitationRate = 0
            Else
                _SanitationRate = value
            End If
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

    Public Property nVehicles As Integer
        Get
            Return _nVehicles
        End Get
        Set(value As Integer)
            If value < 0 Then
                _nVehicles = 0
            Else
                _nVehicles = value
            End If
        End Set
    End Property

    Public Property nIndustryActivities As Integer
        Get
            Return _nIndustryActivities
        End Get
        Set(value As Integer)
            If value < 0 Then
                _nIndustryActivities = 0
            Else
                _nIndustryActivities = value
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


    ' Overriding
    Public Overrides Sub TotPop()
        MyBase.TotPop()
        ' Add people to the animals and plants
        _TotalPopulation += _nPeople
    End Sub

End Class
