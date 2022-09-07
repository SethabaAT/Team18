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
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>                           Variable Declarations                 <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    Private objEnronment() As Environment
    Private EnviroCount As Integer
    Private NumYears As Integer
    Private TotalPopulation() As Integer
    Private Densities() As Double

    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>                     Sub Routines and Functions              <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    ' Used to display in the first grid
    Private Sub PlaceIG1(r As Integer, c As Integer, t As String)
        grdYearsEnviro.Row = r
        grdYearsEnviro.Col = c
        grdYearsEnviro.Text = t
    End Sub

    ' Used to display in the second grid
    Private Sub PlaceIG2(r As Integer, c As Integer, t As String)
        grdDetails.Row = r
        grdDetails.Col = c
        grdDetails.Text = t
    End Sub

    ' Resize the first Grid
    Private Sub ResizeGrid(r As Integer, c As Integer)
        grdYearsEnviro.Rows = r + 1
        grdYearsEnviro.Cols = c + 1
    End Sub

    ' Resize the second grid
    Private Sub ResizeGrid(r As Integer) ' Function Overloading
        grdDetails.Rows = r + 1
    End Sub

    ' We use this sub once: Label both grids
    Private Sub LabelGrid()
        ' The default size
        ResizeGrid(5)
        ResizeGrid(1, 6)

        ' Label the first grid
        PlaceIG1(0, 0, "Name")
        PlaceIG1(0, 1, "Reduction/year")
        PlaceIG1(0, 2, "Total Plants")
        PlaceIG1(0, 3, "Plants Response")
        PlaceIG1(0, 4, "Total animals")
        PlaceIG1(0, 5, "Animal Response")
        PlaceIG1(0, 6, "Density")

        ' Label the second grid
        PlaceIG2(0, 0, "Name")
        PlaceIG2(1, 0, "Pollution Type")
        PlaceIG2(2, 0, "Size")
        PlaceIG2(3, 0, "Total Population")
        PlaceIG2(4, 0, "Density")
    End Sub

    ' Gives the user choices to choose from
    Private Function Choices() As Integer
        ' Returns the option chosen if it is in range
        Dim Choice As Integer = CInt(InputBox("Select a Number " & System.Environment.NewLine &
                                            "1. Settlement" & System.Environment.NewLine &
                                            "2. Wetland " & System.Environment.NewLine &
                                            "3. Forest"))

        If Choice < 1 Or Choice > 3 Then
            Choices()
        End If

        Return Choice
    End Function

    ' This sub helps when you want to create an array of environment objects
    Private Sub CreateEnviroArray()
        For i As Integer = 1 To EnviroCount
            ' Local Variable declarations
            Dim Choice As Integer = Choices()
            Dim Name As String = InputBox("Enter the Environment Name")

            PlaceIG1(i, 0, Name) ' Names will be displayed immediately after being entered

            ' More inputs which are common to all Envoro classes
            Dim Size As Double = CDbl(InputBox("Enter the size of " & Name))
            Dim Plants As Integer = CInt(InputBox("Enter the initial number of Plants in " & Name))
            Dim Animals As Integer = CInt(InputBox("Enter the initial number of animals in " & Name))
            Dim PollutionType As String = InputBox("Enter the Pollution type in " & Name)
            Dim ReductionTarget As Double = CDbl(InputBox("Enter the reduction Target in " & Name))


            '*********************          Depending on the choice, a different class type will be created           **************************
            Select Case Choice
                Case 1 ' Settlement Class
                    Dim objSettlement As Settlement
                    Dim People As Integer = CInt(InputBox("Enter the number of People in " & Name))
                    Dim SettlementType As String = InputBox("Enter the Settlement type for " & Name)

                    objSettlement = New Settlement(NumYears, Name, Size, Plants, Animals, PollutionType, ReductionTarget, People, SettlementType)

                    '' There is some more stuff to add like emmissions blah blah blah 
                    'For y As Integer = 1 To NumYears
                    '    objSettlement.Emissions(y) = CInt(InputBox("Enter the Emmision Count for year " & CStr(y)))
                    'Next

                    objEnronment(i) = objSettlement
                Case 2 ' Wetland Class
                    Dim objWetLand As WetLand
                    Dim WaterBodies As Integer = CInt(InputBox("Enter the number of WaterBodies in " & Name))

                    objWetLand = New WetLand(NumYears, Name, Size, Plants, Animals, PollutionType, ReductionTarget, WaterBodies)

                    ' There are waterbodies stuff to add here
                    For w As Integer = 1 To WaterBodies
                        objWetLand.Waterbodies(w) = New Waterbody
                        objWetLand.Waterbodies(w).Type = InputBox("Enter the type of Water body - " & CStr(w))
                        objWetLand.Waterbodies(w).Volume = CDbl(InputBox("Enter the volume of water body - " & CStr(w)))
                    Next

                    objEnronment(i) = objWetLand
                Case 3 ' Forest Class
                    Dim objForest As Forest
                    Dim WaterBodies As Integer = CInt(InputBox("Enter the number of WaterBodies in " & Name))

                    objForest = New Forest(NumYears, Name, Size, Plants, Animals, PollutionType, ReductionTarget, WaterBodies)

                    ' There are waterbodies stuff to add here
                    For w As Integer = 1 To WaterBodies
                        objForest.Waterbodies(w) = New Waterbody
                        objForest.Waterbodies(w).Type = InputBox("Enter the type of water body - " & CStr(w))
                        objForest.Waterbodies(w).Volume = CDbl(InputBox("Enter the volume of water body - " & CStr(w)))
                    Next

                    objEnronment(i) = objForest
            End Select
            '************************************************************************************************************************************

            ' The Reduction for every environment will be displayed
            PlaceIG1(i, 1, Format(objEnronment(i).ReductionTarget / NumYears, "0.##") & "%")
        Next
    End Sub


    ' When the form loads the grids will be resized and labelled
    Private Sub frmEnvironmental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelGrid()
    End Sub

    ' >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>                           Buttons                            <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    ' Start Button 
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' Get Input from the user
        EnviroCount = CInt(txtEnviroCount.Text)
        NumYears = CInt(txtnYears.Text)

        ' Use the infro to resize the Grid Array
        ResizeGrid(EnviroCount, 6)
        ReDim objEnronment(EnviroCount)
        ReDim TotalPopulation(EnviroCount)
        ReDim Densities(EnviroCount)
    End Sub

    ' Input Button
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        CreateEnviroArray() ' Calls the subRoutine

        For i As Integer = 1 To EnviroCount
            For y As Integer = 1 To NumYears
                ' Input the number of plants and animals in each environment per year
                objEnronment(i).AnimalPop(y) = CInt(InputBox("Enter the number of animals in year " & y))
                objEnronment(i).PlantPop(y) = CInt(InputBox("Enter the number of plants in year " & y))
            Next y
        Next i
    End Sub

    ' Total Population Button
    Private Sub btnTotalPopulation_Click(sender As Object, e As EventArgs) Handles btnTotalPopulation.Click
        'For each environment we calculate the total

        For i As Integer = 1 To EnviroCount
            PlaceIG1(i, 2, CStr(objEnronment(i).PlantTot))
            PlaceIG1(i, 4, CStr(objEnronment(i).AnimalTot))
            TotalPopulation(i) = objEnronment(i).OverallTotalPop ' This line is Polymoorphism
        Next
    End Sub

    ' Calculates the response and display
    Private Sub btnResponse_Click(sender As Object, e As EventArgs) Handles btnResponse.Click
        ' Diplays the response for plants and for animals
        For i As Integer = 1 To EnviroCount
            PlaceIG1(i, 3, objEnronment(i).growth(objEnronment(i).PlantTot))
            PlaceIG1(i, 5, objEnronment(i).growth(objEnronment(i).AnimalTot))
        Next i
    End Sub

    ' Calculates the densities
    Private Sub btnDensity_Click(sender As Object, e As EventArgs) Handles btnDensity.Click
        For i As Integer = 1 To EnviroCount
            Densities(i) = objEnronment(i).Density()
            PlaceIG1(i, 6, CStr(Densities(i)))
        Next i
    End Sub

    ' Show Details 
    Private Sub btnShowDetails_Click(sender As Object, e As EventArgs) Handles btnShowDetails.Click
        Dim Choice As Integer = CInt(InputBox("Select the Enviroment From 1 - " & CStr(EnviroCount)))

        ' Apply DownCasting and then display 
        PlaceIG2(0, 1, objEnronment(Choice).Name)
        PlaceIG2(1, 1, CStr(objEnronment(Choice).PollutionType))
        PlaceIG2(2, 1, CStr(objEnronment(Choice).Size))
        PlaceIG2(3, 1, CStr(TotalPopulation(Choice)))
        PlaceIG2(4, 1, CStr(Densities(Choice)))

        ' DownCasting
        Dim obTemp As Settlement = TryCast(objEnronment(Choice), Settlement)
        Dim obTemp2 As Forest = TryCast(objEnronment(Choice), Forest)
        Dim obTemp3 As WetLand = TryCast(objEnronment(Choice), WetLand)

        If obTemp2 Is Nothing And obTemp3 Is Nothing Then
            ' Get Settlement info
            PlaceIG2(5, 0, "Settlement Type")
            PlaceIG2(5, 1, CStr(obTemp.Settletype()))
        Else
            ' There is total volume in the other two
            PlaceIG2(5, 0, "Total WaterBody (Vol)")

            If obTemp Is Nothing And obTemp2 Is Nothing Then
                ' Get Wetalnd info
                PlaceIG2(5, 1, CStr(obTemp3.TotalVol()))
            Else
                ' Get forest info
                PlaceIG2(5, 1, CStr(obTemp2.TotalVol()))
            End If
        End If

    End Sub


End Class
