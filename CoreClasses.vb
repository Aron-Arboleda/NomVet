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
        Public dateOfNextVisit As String = "N/A"

        Public Sub New(ByVal strName As String, ByVal intAge As Integer, ByVal dateBirthday As Date, ByVal dblWeight As Double, ByVal strType As String, ByVal boolVaccinated As String, ByVal dateOfNextVisit As String)
            Me.strName = strName
            Me.intAge = intAge
            Me.dateBirthday = dateBirthday
            Me.dblWeight = dblWeight
            Me.strType = strType
            Me.boolVaccinated = boolVaccinated
            Me.dateOfNextVisit = dateOfNextVisit
        End Sub
    End Class

    Public Class Appointment
        Public appointmentId As Integer
        Public strProcedure As String
        Public dateAppointment As Date
        Public petOwner As String
        Public pet As String

        Public Sub New(ByVal appointmentId As Integer, ByVal petOwner As String, ByVal pet As String, ByVal strProcedure As String, ByVal dateAppointment As Date)
            Me.appointmentId = appointmentId
            Me.petOwner = petOwner
            Me.pet = pet
            Me.strProcedure = strProcedure
            Me.dateAppointment = dateAppointment
        End Sub
    End Class

    Public Class Session
        Public sessionId As Integer
        Public petOwner As PetOwner
        Public dateMade As Date
        Public petWithProcedureList As List(Of String)

        Public Sub New(ByVal sessionId As Integer, ByVal petOwner As PetOwner, ByVal dateMade As Date, ByVal petWithProcedureList As List(Of String))
            Me.sessionId = sessionId
            Me.petOwner = petOwner
            Me.dateMade = dateMade
            Me.petWithProcedureList = petWithProcedureList
        End Sub

        Public Shared Function ranCode()
            Return Int((100 * Rnd()) + 1)
        End Function

        Public Shared Function createPetProcedure(petName As String, petType As String, petProcedure As String) As String
            Return (petName & "#" & petType & "#" & petProcedure)
        End Function
    End Class

    Public Class NextVisit
        Public petName As String
        Public boolNextVisit As Boolean
        Public dateOfNextVisit As String
        Public vacStatus As String
        Public procedure As String

        Public Sub New(ByVal petName As String, ByVal boolNextVisit As Boolean, ByVal dateOfNextVisit As String, ByVal vacStatus As String, ByVal procedure As String)
            Me.boolNextVisit = boolNextVisit
            Me.petName = petName
            Me.dateOfNextVisit = dateOfNextVisit
            Me.vacStatus = vacStatus
            Me.procedure = procedure
        End Sub
    End Class

End Module
