' *****************************************************************
' Team Number: 18
' Team Member 1 Details: Maheso, MV (222058372)
' Team Member 2 Details: Mabunda, XM (222030885)
' Team Member 3 Details: Sethaba, AT (216031663)
' Team Member 4 Details: Mosiane, K (222018434)
' Practical: Team Project
' Class name: Waterbody
' *****************************************************************

'Option statements
Option Strict On
Option Explicit On
Option Infer Off

Public Class Waterbody
    Private _Type As String
    Private _Volume As Double


    Const DefVolume As Double = 50
    Const DefType As String = " "

    ' Default constructor with default values
    Public Sub New()
        _Type = DefType
        _Volume = DefVolume
    End Sub

    ' Parameterized constructor
    Public Sub New(t As String, v As Double)
        _Type = t
        _Volume = v
    End Sub

    'property methods
    Public Property Type As String
        Get
            Return _Type
        End Get
        Set(value As String)
            _Type = value
        End Set
    End Property

    Public Property Volume As Double
        Get
            Return _Volume
        End Get
        Set(value As Double)
            _Volume = value
        End Set
    End Property

End Class
