Imports System.ComponentModel
Imports System.IO

Public Class ConflictChecker
    Public Shared Function checkForSameUsername(ByVal username As String) As Boolean
        Dim valid As Boolean = True

        If checkIfDatabaseIsEmpty(FileManipulator.accountsDatabaseFilePath) = True Then
            Return valid
        End If

        Dim lines() As String = FileManipulator.readData(FileManipulator.accountsDatabaseFilePath)
        For Each line In lines
            Dim petOwnerObj As PetOwner = FileManipulator.parseAsPetOwner(line)
            If petOwnerObj.getUsername() = username Then
                valid = False
                Return valid
            End If
        Next
        Return valid

    End Function

    Public Shared Function checkForEmptyFields(ByVal fields() As Control) As Boolean
        Dim valid As Boolean = True

        For Each field In fields
            If field.Text = String.Empty Then
                valid = False
                Return valid
            End If
        Next
        Return valid
    End Function

    Public Shared Function checkForInvalidCharacters(ByVal fields() As Control, ByVal delimiter As String) As Boolean
        Dim valid As Boolean = True

        For Each field In fields
            If field.Text.Contains(delimiter) Then
                valid = False
                Return valid
            End If
        Next
        Return valid
    End Function

    Public Shared Function checkIfDatabaseIsEmpty(filepath As String) As Boolean
        Dim Empty As Boolean = False

        Dim data As String = File.ReadAllText(filepath)
        If data = String.Empty Or data = "" Then
            Empty = True
        End If
        Return Empty
    End Function

    Public Shared Function checkCredentialsAndGetPetOwner(username As String, password As String) As PetOwner
        Dim lines() As String = FileManipulator.readData(FileManipulator.accountsDatabaseFilePath)
        Dim petOwnerObject As PetOwner = FileManipulator.findPetOwner(lines, username, password)
        Return petOwnerObject
    End Function

    Public Shared Function checkIfControlsTextIsEmpty(inputControls As List(Of Control)) As Boolean
        Dim emptyFields As Boolean = False

        For Each control As Control In inputControls
            If control.Text = "" Then
                emptyFields = True
                Exit For
            End If
        Next

        Return emptyFields
    End Function

    Public Shared Function checkIfErrorMessagesAreActive(nextVisitPanels As List(Of SessionNextVisitPanel)) As Boolean
        Dim errorMessagesAreActive As Boolean = False

        For Each nvPanel As SessionNextVisitPanel In nextVisitPanels
            If nvPanel.lblErrorMessage.Visible = True Then
                errorMessagesAreActive = True
                Exit For
            End If
        Next

        Return errorMessagesAreActive
    End Function

End Class
