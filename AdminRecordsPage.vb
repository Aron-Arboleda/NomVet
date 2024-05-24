Public Class AdminRecordsPage

    Public Sub loadAdminRecordsPage()
        loadAccountsDatabase()
        loadBookingsDatabase()
        loadSessionsDatabase()
    End Sub

    Private Sub loadAccountsDatabase()
        With lstDatabaseAccounts
            .Items.Clear()

            .View = View.Details
            .GridLines = True
            .FullRowSelect = True

            .Columns.Clear()
            .Columns.Add("Username", 100)
            .Columns.Add("Password", 100)
            .Columns.Add("Name", 60)
            .Columns.Add("Age", 60)
            .Columns.Add("Sex", 60)
            .Columns.Add("Address", 140)

            list = FileManipulator.ReadPetOwners()
            counter = 0
            For Each row As PetOwner In list
                .Items.Add(row.getUsername())
                .Items(counter).SubItems.Add(row.getPassword())
                .Items(counter).SubItems.Add(row.strName)
                .Items(counter).SubItems.Add(row.intAge)
                .Items(counter).SubItems.Add(row.strSex)
                .Items(counter).SubItems.Add(row.strAddress)
                counter += 1
            Next
        End With
    End Sub

    Private Sub loadBookingsDatabase()
        With lstDatabaseBookings
            .Items.Clear()

            .View = View.Details
            .GridLines = True
            .FullRowSelect = True

            .Columns.Clear()
            .Columns.Add("ID", 60)
            .Columns.Add("Owner Name", 120)
            .Columns.Add("Pet Name", 100)
            .Columns.Add("Procedure", 120)
            .Columns.Add("Date", 120)

            list = FileManipulator.ReadBookings()
            counter = 0
            For Each row As Appointment In list
                .Items.Add(row.appointmentId)
                .Items(counter).SubItems.Add(row.petOwner)
                .Items(counter).SubItems.Add(row.pet)
                .Items(counter).SubItems.Add(row.strProcedure)
                .Items(counter).SubItems.Add(row.dateAppointment)
                counter += 1
            Next
        End With
    End Sub

    Private Sub loadSessionsDatabase()
        With lstDatabaseSessions
            .Items.Clear()

            .View = View.Details
            .GridLines = True
            .FullRowSelect = True

            .Columns.Clear()
            .Columns.Add("ID", 40)
            .Columns.Add("Pet Owner", 80)
            .Columns.Add("Date of Session", 120)

            Dim sessionsList As List(Of Session) = FileManipulator.ReadSessions()
            counter = 0
            For Each session In sessionsList
                .Items.Add(session.sessionCodeId)
                .Items(counter).SubItems.Add(session.petOwner.strName)
                .Items(counter).SubItems.Add(session.dateMade.Date)
                counter += 1
            Next
        End With
    End Sub
End Class