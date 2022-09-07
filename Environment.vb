' *****************************************************************
' Team Number: 18
' Team Member 1 Details: Maheso, MV (222058372)
' Team Member 2 Details: Mabunda, XM (222030885)
' Team Member 3 Details: Sethaba, AT (216031663)
' Team Member 4 Details: Mosiane, K (222018434)
' Practical: Team Project
' Class name: Environment
' *****************************************************************


'Option statements
Option Strict On
Option Explicit On
Option Infer Off

Public MustInherit Class Environment
    ' I have changed the members to protected
    Protected _Name As String
    Protected _Location As String
    Protected _Size As Double
    Protected _nPlants As Integer
    Protected _nAnimals As Integer
    Protected _PlantPop() As Integer
    Protected _AnimalPop() As Integer
    Protected _PollutionType As String
    Protected _ReductionTarget As Double

    Protected _TotalPopulation As Integer


    'constructors
    Public Sub New(nYears As Integer, n As String, s As Double, nPl As Integer, nA As Integer, pT As String, rT As Double)
        ' Resize
        ReDim _PlantPop(nYears)
        ReDim _AnimalPop(nYears)

        _Name = n
        _Size = s
        _nPlants = nPl
        _nAnimals = nA
        _PollutionType = pT
        _ReductionTarget = rT
    End Sub

    'Property methods
    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Location As String
        Get
            Return _Location
        End Get
        Set(value As String)
            _Location = value
        End Set
    End Property

    Public Property Size As Double
        Get
            Return _Size
        End Get
        Set(value As Double)
            _Size = value
        End Set
    End Property

    Public Property ReductionTarget As Double
        Get
            Return _ReductionTarget
        End Get
        Set(value As Double)
            _ReductionTarget = value
        End Set
    End Property

    Public Property PlantPop(i As Integer) As Integer
        Get
            Return _PlantPop(i)
        End Get
        Set(value As Integer)
            If value < 0 Then
                'validates that value isnt negative
                _PlantPop(i) = 0
            Else
                _PlantPop(i) = value
            End If
        End Set
    End Property

    Public Property AnimalPop(i As Integer) As Integer
        Get
            Return _AnimalPop(i)
        End Get
        Set(value As Integer)
            'validates that value isnt negative
            If value < 0 Then
                _AnimalPop(i) = 0
            Else
                _AnimalPop(i) = value
            End If
        End Set
    End Property

    Public Property PollutionType As String
        Get
            Return _PollutionType
        End Get
        Set(value As String)
            _PollutionType = value
        End Set
    End Property

    Public Property nPlants As Integer
        Get
            Return _nPlants
        End Get
        Set(value As Integer)
            'validates that value isnt negative
            If value < 0 Then
                _nPlants = 0
            Else
                _nPlants = value
            End If
        End Set
    End Property

    Public Property nAnimals As Integer
        Get
            Return _nAnimals
        End Get
        Set(value As Integer)
            'validates that value isnt negative
            If value < 0 Then
                _nAnimals = 0
            Else
                _nAnimals = value
            End If
        End Set
    End Property


    Public ReadOnly Property TotalPopulation As Integer
        Get
            Return _TotalPopulation
        End Get
    End Property

    'Calculates population for animal and plant
    Public Overridable Sub TotPop()
        _TotalPopulation = 0

        For i As Integer = 1 To _AnimalPop.Length - 1
            _TotalPopulation += (AnimalPop(i) + _PlantPop(i))
        Next i
    End Sub

    'determines if population increased or not      not sure though... (Karabo)
    Public Overridable Function growth(originalValue As Integer) As String
        Dim Response As String

        If originalValue > _TotalPopulation Then
            Response = "Growth"
        Else
            If originalValue = _TotalPopulation Then
                Response = "Stagnant"
                Return Response
            End If
            Response = "Decline"

        End If
        Return Response

    End Function

    'totalplants/size
    Public Function Density() As Double
        ' Runs the total function then 
        Return _TotalPopulation / _Size
    End Function
End Class
