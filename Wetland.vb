' *****************************************************************
' Team Number: 18
' Team Member 1 Details: Maheso, MV (222058372)
' Team Member 2 Details: Mabunda, XM (222030885)
' Team Member 3 Details: Sethaba, AT (216031663)
' Team Member 4 Details: Mosiane, K (222018434)
' Practical: Team Project
' Class name: Wetland
' *****************************************************************


'Option statements
Option Strict On
Option Explicit On
Option Infer Off

Public Class WetLand
    Inherits Environment
    Private _Waterbodies() As Waterbody


    'constructor
    Public Sub New(nYears As Integer, n As String, s As Double, nPl As Integer, nA As Integer, pT As String, rT As Double, nWaterbody As Integer)
        MyBase.New(nYears, n, s, nPl, nA, pT, rT)

        ReDim _Waterbodies(nWaterbody)
        For i As Integer = 1 To nWaterbody
            _Waterbodies(i) = New Waterbody
        Next i
    End Sub

    'property method
    Public Property Waterbodies(x As Integer) As Waterbody
        Get
            Return _Waterbodies(x)
        End Get
        Set(value As Waterbody)
            _Waterbodies(x) = value
        End Set
    End Property

    'Calculates total volume
    Public Function TotalVol() As Double
        Dim total As Double = 0
        For i As Integer = 1 To _Waterbodies.Length - 1
            total += _Waterbodies(i).Volume
        Next
        Return total
    End Function
End Class
