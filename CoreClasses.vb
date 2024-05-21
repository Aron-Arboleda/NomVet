Imports System.IO

Public Module CoreClasses
    Public Class PetOwner
        Private strUsername As String
        Private strPassword As String
        Public strName As String
        Public intAge As Integer
        Public strSex As String
        Public strAddress As String
        Public petsList As List(Of Pet)

        Public Sub New(ByVal strUsername As String, ByVal strPassword As String, ByVal strName As String, ByVal intAge As Integer, ByVal strSex As String, ByVal strAddress As String, ByVal petsList As List(Of Pet))
            Me.strUsername = strUsername
            Me.strPassword = strPassword
            Me.strName = strName
            Me.intAge = intAge
            Me.strSex = strSex
            Me.strAddress = strAddress
            Me.petsList = petsList
        End Sub

        Public Function getUsername()
            Return strUsername
        End Function

        Public Function getPassword()
            Return strPassword
        End Function

    End Class

    Public Class Pet
        Public strName As String
        Public intAge As Integer
        Public dateBirthday As Date
        Public dblWeight As Double
        Public strType As String
        Public boolVaccinated As String

        Public Sub New(ByVal strName As String, ByVal intAge As Integer, ByVal dateBirthday As Date, ByVal dblWeight As Double, ByVal strType As String, ByVal boolVaccinated As String)
            Me.strName = strName
            Me.intAge = intAge
            Me.dateBirthday = dateBirthday
            Me.dblWeight = dblWeight
            Me.strType = strType
            Me.boolVaccinated = boolVaccinated
        End Sub
    End Class

    Public Class Appointment
        Public strProcedure As String
        Public dateAppointment As Date
        Public petOwner As String
        Public pet As String

        Public Sub New(ByVal petOwner As String, ByVal pet As String, ByVal strProcedure As String, ByVal dateAppointment As Date)
            Me.petOwner = petOwner
            Me.pet = pet
            Me.strProcedure = strProcedure
            Me.dateAppointment = dateAppointment
        End Sub
    End Class

    Public Class Session
        Public petOwner As PetOwner
        Public dateMade As Date

        Public Sub New(ByVal petOwner As PetOwner, ByVal dateMade As Date)
            Me.petOwner = petOwner
            Me.dateMade = dateMade
        End Sub
    End Class

End Module
