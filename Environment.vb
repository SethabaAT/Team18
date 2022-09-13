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
    Implements IEnvironment
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
    Public Property Name As String Implements IEnvironment.Name
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Location As String Implements IEnvironment.Location
        Get
            Return _Location
        End Get
        Set(value As String)
            _Location = value
        End Set
    End Property

    Public Property Size As Double Implements IEnvironment.Size
        Get
            Return _Size
        End Get
        Set(value As Double)
            _Size = value
        End Set
    End Property

    Public Property ReductionTarget As Double Implements IEnvironment.ReductionTarget
        Get
            Return _ReductionTarget
        End Get
        Set(value As Double)
            _ReductionTarget = value
        End Set
    End Property

    Public Property PlantPop(i As Integer) As Integer Implements IEnvironment.Plantpop
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

    Public Property AnimalPop(i As Integer) As Integer Implements IEnvironment.Animalpop
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

    Public Property PollutionType As String Implements IEnvironment.PollutionType
        Get
            Return _PollutionType
        End Get
        Set(value As String)
            _PollutionType = value
        End Set
    End Property

    Public Property nPlants As Integer Implements IEnvironment.nPlants
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

    Public Property nAnimals As Integer Implements IEnvironment.nanimals
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

    'Calculates population for animal and plant
    Public Function AnimalTot() As Integer Implements IEnvironment.AnimalTot
        'total for animal
        Dim total As Integer
        For i As Integer = 1 To _AnimalPop.Length - 1
            total += _AnimalPop(i)
        Next
        Return total
    End Function
    Public Function PlantTot() As Integer Implements IEnvironment.Plantot
        'total for plants
        Dim total As Integer
        For i As Integer = 1 To _PlantPop.Length - 1
            total += _PlantPop(i)
        Next
        Return total
    End Function

    'Utility function for the Response
    Private Function DetermineResponse(originalValue As Integer, totalpopulation As Integer) As String
        Dim response As String = ""

        If originalValue > totalpopulation Then
            response = "Growth"
        Else
            If originalValue = totalpopulation Then
                response = "Stagnant"
            Else
                If originalValue < totalpopulation Then
                    response = "Decline"
                End If
            End If
        End If

        Return response
    End Function

    'determines if population increased or not  
    Public Function growthP() As String Implements IEnvironment.GrowthP
        Return DetermineResponse(_nPlants, PlantTot)
    End Function

    Public Function growthA() As String Implements IEnvironment.GrowthA
        Return DetermineResponse(_nAnimals, AnimalTot)
    End Function

    ' This Function is calculated differently in the settlement 
    Public Overridable Function OverallTotalPop() As Integer Implements IEnvironment.OverallTotalPop
        Return AnimalTot() + PlantTot()
    End Function

    Public Function Density() As Double Implements IEnvironment.Density
        ' Runs the total function then divide by size
        Return OverallTotalPop() / _Size
    End Function

End Class
