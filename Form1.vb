Option Strict On
Option Explicit On
Option Infer Off
' *****************************************************************
' Team Number: 18
' Team Member 1 Details: Maheso, MV (222058372)
' Team Member 2 Details: Mabunda, XM (222030885)
' Team Member 3 Details: Surname, Initials (Student #)
' Team Member 4 Details: Mosiane, K (222018434)
' Practical: Team Project
' Class name: Environment
' *****************************************************************

'Option statements
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices.ComTypes

Public Class frmEnvironmental
    Private objEnronment() As Environment
    Private EnviroCount As Integer
    Private NumYears As Integer
    Private Densities() As Double
    Private Responses() As String

    '>>>>>>>>>>>>>>>>>>>                          Sub Routines and Functions              <<<<<<<<<<<<<<<<<<<<<<<<
    Private Sub PlaceIG1(r As Integer, c As Integer, t As String)
        grdYearsEnviro.Row = r
        grdYearsEnviro.Col = c
        grdYearsEnviro.Text = t
    End Sub


    Private Sub PlaceIG2(r As Integer, c As Integer, t As String)
        grdDetails.Row = r
        grdDetails.Col = c
        grdDetails.Text = t
    End Sub

    Private Sub ResizeGrid(r As Integer, c As Integer)
        grdYearsEnviro.Rows = r + 1
        grdYearsEnviro.Cols = c + 1
    End Sub

    Private Sub ResizeGrid(r As Integer) ' Function Overloading
        grdDetails.Rows = r + 1
    End Sub

    Private Sub LabelGrid()
        ' The default size
        ResizeGrid(5)

        ' Label
        PlaceIG2(0, 0, "Name")
        PlaceIG2(1, 0, "Pollution Type")
        PlaceIG2(2, 0, "Total Population")
        PlaceIG2(3, 0, "Density")
        PlaceIG2(4, 0, "Response")

    End Sub


    ' Returns the option chosen if it is in range
    Private Function Choices() As Integer
        Dim Choice As Integer = CInt(InputBox("Select a Number " & System.Environment.NewLine &
                                            "1. Settlement" & System.Environment.NewLine &
                                            "2. Wetland " & System.Environment.NewLine &
                                            "3. Forest"))

        If Choice < 1 Or Choice > 3 Then
            Choices()
        End If

        Return Choice
    End Function

    Private Sub frmEnvironmental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelGrid()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        EnviroCount = CInt(txtEnviroCount.Text)
        NumYears = CInt(txtnYears.Text)

        ReDim objEnronment(EnviroCount)

        ' These two variables can be made in the Class
        ReDim Densities(EnviroCount)
        ReDim Responses(EnviroCount)

        ResizeGrid(NumYears, EnviroCount)

        For i As Integer = 1 To EnviroCount

            Dim Choice As Integer = Choices()

            Dim Name As String = InputBox("Enter the Environment Name")

            PlaceIG1(0, i, Name)

            Dim Size As Double = CDbl(InputBox("Enter the size of Enviroment"))
            Dim Plants As Integer = CInt(InputBox("Enter the number of Plants"))
            Dim Animals As Integer = CInt(InputBox("Enter the number of animals"))
            Dim PollutionType As String = InputBox("Enter the Pollution type")
            Dim ReductionTarget As Double = CDbl(InputBox("Enter the reduction Target"))

            ' Depending on the choice something different happens
            Select Case Choice
                Case 1
                    Dim objSettlement As Settlement
                    Dim People As Integer = CInt(InputBox("Enter the number of People"))
                    Dim SettlementType As String = InputBox("Enter the Settlement type")

                    objSettlement = New Settlement(NumYears, Name, Size, Plants, Animals, PollutionType, ReductionTarget, People, SettlementType)

                    ' There is some more stuff to add like emmissions blah blah blah 
                    For y As Integer = 1 To NumYears
                        objSettlement.Emissions(y) = CInt(InputBox("Enter the Emmision Count for year " & CStr(y)))
                    Next


                    objEnronment(i) = objSettlement
                Case 2
                    Dim objWetLand As WetLand
                    Dim WaterBodies As Integer = CInt(InputBox("Enter the number of WaterBodies"))

                    objWetLand = New WetLand(NumYears, Name, Size, Plants, Animals, PollutionType, ReductionTarget, WaterBodies)

                    ' There are waterbodies stuff to add here
                    For w As Integer = 1 To WaterBodies
                        objWetLand.Waterbodies(w) = New Waterbody
                        objWetLand.Waterbodies(w).Type = InputBox("Enter the type of water body" & CStr(w))
                        objWetLand.Waterbodies(w).Type = InputBox("Enter the type of water body" & CStr(w))
                        objWetLand.Waterbodies(w).Volume = CDbl(InputBox("Enter the volume of water body" & CStr(w)))
                    Next

                    objEnronment(i) = objWetLand
                Case 3
                    Dim objForest As Forest
                    Dim WaterBodies As Integer = CInt(InputBox("Enter the number of WaterBodies"))

                    ' Add waterbody details here

                    objForest = New Forest(NumYears, Name, Size, Plants, Animals, PollutionType, ReductionTarget, WaterBodies)

                    ' There are waterbodies stuff to add here
                    For w As Integer = 1 To WaterBodies
                        objForest.Waterbodies(w) = New Waterbody
                        objForest.Waterbodies(w).Type = InputBox("Enter the type of water body" & CStr(w))
                        objForest.Waterbodies(w).Type = InputBox("Enter the type of water body" & CStr(w))
                        objForest.Waterbodies(w).Volume = CDbl(InputBox("Enter the volume of water body" & CStr(w)))
                    Next

                    objEnronment(i) = objForest
            End Select
        Next
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click

        ' Probably some details here


        For i As Integer = 1 To EnviroCount

            For y As Integer = 1 To NumYears
                objEnronment(i).AnimalPop(y) = CInt(InputBox("Enter the number of animals in year "))
                objEnronment(i).PlantPop(y) = CInt(InputBox("Enter the number of plants in year "))

                ' Diplay the addition of both
                PlaceIG1(y, 0, "Year: " & CStr(y))
                PlaceIG1(y, i, CStr(objEnronment(i).AnimalPop(y) + objEnronment(i).PlantPop(y)))
            Next

        Next
    End Sub

    Private Sub btnTotalPopulation_Click(sender As Object, e As EventArgs) Handles btnTotalPopulation.Click
        For i As Integer = 1 To EnviroCount
            objEnronment(i).TotPop() ' Polymorphism 

            Dim OriginalPop As Integer = objEnronment(i).nAnimals + objEnronment(i).nPlants
            Responses(i) = objEnronment(i).growth(OriginalPop)
        Next
    End Sub

    Private Sub btnDensity_Click(sender As Object, e As EventArgs) Handles btnDensity.Click
        For i As Integer = 1 To EnviroCount
            Densities(i) = objEnronment(i).Density()
        Next
    End Sub

    Private Sub btnShowDetails_Click(sender As Object, e As EventArgs) Handles btnShowDetails.Click
        Dim Choice As Integer = CInt(InputBox("Select the Environment you want to see"))

        ' Apply DownCasting and then display 

        PlaceIG2(0, 1, objEnronment(Choice).Name)
        PlaceIG2(1, 1, CStr(objEnronment(Choice).PollutionType))
        PlaceIG2(2, 1, CStr(objEnronment(Choice).TotalPopulation))
        PlaceIG2(3, 1, CStr(Densities(Choice)))
        PlaceIG2(4, 1, CStr(Responses(Choice)))

        ' DownCasting
        Dim obTemp As Settlement = TryCast(objEnronment(Choice), Settlement)
        Dim obTemp2 As Forest = TryCast(objEnronment(Choice), Forest)
        Dim obTemp3 As WetLand = TryCast(objEnronment(Choice), WetLand)

        If obTemp Is Nothing And obTemp2 Is Nothing Then
            ' Get Wetalnd info
            PlaceIG2(5, 0, "Total Vol")
            PlaceIG2(5, 1, CStr(obTemp3.TotalVol()))
        Else
            If obTemp2 Is Nothing And obTemp3 Is Nothing Then
                ' Get Settlement info
                PlaceIG2(5, 0, "Total Emi")
                PlaceIG2(5, 1, CStr(obTemp.TotEmissions()))
            Else
                ' Get foret info
                PlaceIG2(5, 0, "Total Vol")
                PlaceIG2(5, 1, CStr(obTemp2.TotalVol()))
            End If
        End If

    End Sub


End Class
