Imports System.IO

Public Class FileManipulator
    Public Shared accountsDatabaseFilePath As String = "nomVetAccounts.txt"
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
        Dim procedure = parsedStringsList(6)
        Dim dateAppointment = parsedStringsList(7)
        Dim petObject As New Pet(name, age, bday, weight, type, vaccineStatus, procedure, dateAppointment)
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

    Public Shared Sub SavePet(petOwnerObject As PetOwner, petObject As Pet)
        Using writer As StreamWriter = File.AppendText(petOwnerObject.getUsername + ".txt")
            writer.WriteLine(petObject.strName & "," & petObject.intAge & "," & petObject.dateBirthday & "," & petObject.dblWeight & "," & petObject.strType & "," & petObject.boolVaccinated & "," & petObject.strProcedure & "," & petObject.dateAppointment)
        End Using
    End Sub

    Public Shared Sub SaveBooking(booking As Date)
        Using writer As StreamWriter = File.AppendText("nomVetBookings.txt")
            writer.WriteLine(booking)
        End Using
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
End Class
