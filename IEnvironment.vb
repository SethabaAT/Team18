' *****************************************************************
' Team Number: 18
' Team Member 1 Details: Maheso, MV (222058372)
' Team Member 2 Details: Mabunda, XM (222030885)
' Team Member 3 Details: Sethaba, AT (Student #)
' Team Member 4 Details: Mosiane, K (222018434)
' Practical: Team Project
' Class name: IEnvironment
' *****************************************************************

Public Interface IEnvironment
    Property Name As String
    Property Location As String
    Property Size As Double
    Property nPlants As Integer
    Property nanimals As Integer
    Property Plantpop(x As Integer) As Integer
    Property Animalpop(x As Integer) As Integer
    Property PollutionType As String
    Property ReductionTarget As Double
    Function AnimalTot() As Integer
    Function Plantot() As Integer
    Function Growth(Value As Integer) As String
    Function OverallTotalPop() As Integer
    Function Density() As Double
End Interface

