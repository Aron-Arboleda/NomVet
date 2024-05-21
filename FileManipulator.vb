Imports System.IO

Public Class FileManipulator
    Public Shared accountsDatabaseFilePath As String = "nomVetAccounts.txt"
    Public Shared bookingsDatabaseFilePath As String = "nomVetBookings.txt"
    Public Shared sessionsDatabaseFilePath As String = "nomVetSessions.txt"

    Public Shared Function ValidateLogin(username As String, password As String) As Boolean
        Dim validLogin As Boolean = False

        Dim lines() As String = readData(accountsDatabaseFilePath)
        Dim petOwnerObject As PetOwner = findPetOwner(lines, username, password)
        If Not (petOwnerObject Is Nothing) Then
            validLogin = True
            activeAccount = petOwnerObject
        End If

        Return validLogin
    End Function

    Public Shared Function findPetOwner(lines() As String, username As String, password As String) As PetOwner
        Dim petOwnerObject As PetOwner
        For Each line As String In lines
            petOwnerObject = parseAsPetOwner(line)
            If petOwnerObject.getUsername = username AndAlso petOwnerObject.getPassword = password Then
                Return petOwnerObject
            End If
        Next
        Return Nothing
    End Function

    Public Shared Function findPetOwnerWithName(lines() As String, petOwnerName As String) As PetOwner
        Dim petOwnerObject As PetOwner
        For Each line As String In lines
            petOwnerObject = parseAsPetOwner(line)
            If petOwnerObject.strName = petOwnerName Then
                Return petOwnerObject
            End If
        Next
        Return Nothing
    End Function

    Public Shared Function readData(fileName As String)
        Dim lines() As String = {}
        If File.Exists(fileName) Then
            lines = File.ReadAllLines(fileName)
        Else
            MessageBox.Show("No database file found.")
        End If
        Return lines
    End Function

    Public Shared Function parseAsPetOwner(line As String) As PetOwner
        Dim parsedStringsList() As String = line.Split(","c)
        Dim username = parsedStringsList(0)
        Dim password = parsedStringsList(1)
        Dim name = parsedStringsList(2)
        Dim age = parsedStringsList(3)
        Dim sex = parsedStringsList(4)
        Dim address = parsedStringsList(5)
        Dim petOwnerObject As New PetOwner(username, password, name, age, sex, address, New List(Of Pet))
        Return petOwnerObject
    End Function

    Public Shared Function parseAsPet(line As String) As Pet
        Dim parsedStringsList() As String = line.Split(","c)
        Dim name = parsedStringsList(0)
        Dim age = parsedStringsList(1)
        Dim bday = parsedStringsList(2)
        Dim weight = parsedStringsList(3)
        Dim type = parsedStringsList(4)
        Dim vaccineStatus = parsedStringsList(5)
        Dim petObject As New Pet(name, age, bday, weight, type, vaccineStatus)
        Return petObject
    End Function
    Public Shared Sub createDataBaseFile(filename As String)
        Dim databaseFilePath As String = filename

        If Not File.Exists(databaseFilePath) Then
            File.Create(databaseFilePath).Dispose()
        End If
    End Sub

    Public Shared Sub SaveUser(petOwnerObject As PetOwner)
        'creating user's own database for pets
        Dim petOwnerFileName As String = petOwnerObject.getUsername & ".txt"
        createDataBaseFile(petOwnerFileName)

        'saving to accounts database
        Using writer As StreamWriter = File.AppendText(accountsDatabaseFilePath)
            writer.WriteLine(petOwnerObject.getUsername & "," & petOwnerObject.getPassword & "," & petOwnerObject.strName & "," & petOwnerObject.intAge & "," & petOwnerObject.strSex & "," & petOwnerObject.strAddress)
        End Using
    End Sub

    Public Shared Sub ClearPets(petOwnerObject As PetOwner)
        File.WriteAllText(petOwnerObject.getUsername + ".txt", String.Empty)
    End Sub
    Public Shared Sub SavePet(petOwnerObject As PetOwner, petObject As Pet)
        Using writer As StreamWriter = File.AppendText(petOwnerObject.getUsername + ".txt")
            writer.WriteLine(petObject.strName & "," & petObject.intAge & "," & petObject.dateBirthday & "," & petObject.dblWeight & "," & petObject.strType & "," & petObject.boolVaccinated)
        End Using
    End Sub

    'Public Shared Sub SaveAppointment(petOwnerObject As PetOwner, petObject As Pet)
    '    Using writer As StreamWriter = File.AppendText(petOwnerObject.getUsername + ".txt")
    '        writer.WriteLine(petObject.strName & "," & petObject.intAge & "," & petObject.dateBirthday & "," & petObject.dblWeight & "," & petObject.strType & "," & petObject.boolVaccinated & "," & petObject.appointment.strProcedure & "," & petObject.appointment.dateAppointment)
    '    End Using
    'End Sub

    Public Shared Sub SaveBooking(appointment As Appointment)
        Using writer As StreamWriter = File.AppendText(bookingsDatabaseFilePath)
            writer.WriteLine(appointment.petOwner & "," & appointment.pet & "," & appointment.strProcedure & "," & appointment.dateAppointment)
        End Using
    End Sub

    Public Shared Function ReadBookings() As List(Of Appointment)
        Dim lines() As String = readData(bookingsDatabaseFilePath)
        Dim bookingsList As New List(Of Appointment)
        For Each line As String In lines
            Dim bookingObject As Appointment = parseAsBooking(line)
            If bookingObject.petOwner = activeAccount.strName Then
                bookingsList.Add(bookingObject)
            End If
        Next
        Return bookingsList
    End Function

    Public Shared Function getListOfPetsName(ByVal bookingLists As List(Of Appointment)) As List(Of String)
        Dim petsNameLists As New List(Of String)
        For Each book In bookingLists
            petsNameLists.Add(book.pet)
        Next
        Return petsNameLists
    End Function

    Public Shared Function parseAsBooking(line As String) As Appointment
        Dim parsedStringsList() As String = line.Split(","c)
        Dim petOwnerName As String = parsedStringsList(0)
        Dim petName = parsedStringsList(1)
        Dim procedure = parsedStringsList(2)
        Dim dateOfAppointment = parsedStringsList(3)
        Dim bookingObject As New Appointment(petOwnerName, petName, procedure, dateOfAppointment)
        Return bookingObject
    End Function

    Public Shared Sub SavePetOwner(petOwner As PetOwner)
        Dim petOwnerFileName As String = petOwner.getUsername & ".txt"
        createDataBaseFile(petOwnerFileName)

        Using writer As StreamWriter = File.AppendText(accountsDatabaseFilePath)
            writer.WriteLine(petOwner.getUsername() & "," & petOwner.getPassword() & "," & petOwner.strName & "," & petOwner.intAge & "," & petOwner.strSex & "," & petOwner.strAddress)
        End Using

        For Each pet In petOwner.petsList
            SavePet(petOwner, pet)
        Next
    End Sub

    Public Shared Function ReadPetOwners()
        Dim petOwnersList As New List(Of String)
        Using reader As New System.IO.StreamReader(accountsDatabaseFilePath)
            Dim line As String
            Do While reader.Peek() >= 0
                line = reader.ReadLine()
                petOwnersList.Add(line)
            Loop
        End Using
        Return petOwnersList
    End Function

    Public Shared Function ReadPets(activeAccount As PetOwner)
        Dim lines() As String = readData(activeAccount.getUsername() & ".txt")
        Dim petsList As New List(Of Pet)
        For Each line As String In lines
            Dim petObject As Pet = parseAsPet(line)
            petsList.Add(petObject)
        Next
        Return petsList
    End Function

    Public Shared Sub SaveSession(ByVal session As Session)
        Using writer As StreamWriter = File.AppendText(sessionsDatabaseFilePath)
            Dim str As String = ""
            str &= session.petWithProcedureList.Item(0)
            For i = 1 To session.petWithProcedureList.Count - 1
                str &= ("%" & session.petWithProcedureList.Item(i))
            Next
            writer.WriteLine(session.petOwner.strName & "," & session.dateMade.Date & "," & str)
        End Using
    End Sub

    Public Shared Function ReadSessions() As List(Of Session)
        Dim lines() As String = readData(sessionsDatabaseFilePath)
        Dim sessionsList As New List(Of Session)
        If (lines.Length > 0) Then
            For Each line As String In lines
                Dim sessionObject As Session = parseAsSession(line)
                sessionsList.Add(sessionObject)
            Next
        End If
        Return sessionsList
    End Function

    Public Shared Function parseAsSession(line As String) As Session
        Dim parsedStringsList() As String = line.Split(","c)
        Dim petOwnerName As String = parsedStringsList(0)
        Dim dateMade As String = parsedStringsList(1)
        Dim petsList As List(Of String) = parsedStringsList(2).Split("%"c).ToList()

        Dim lines() As String = readData(accountsDatabaseFilePath)
        Dim petOwnerObject As PetOwner = findPetOwnerWithName(lines, petOwnerName)

        Dim sessionObject As New Session(petOwnerObject, dateMade, petsList)
        Return sessionObject
    End Function
End Class
