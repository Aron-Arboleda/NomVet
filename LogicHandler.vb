Module LogicHandler
    Public Function computeTotalBill(ByVal petType As String, ByVal petProcedure As String) As Double
        Dim checkupFee As Double
        Dim vaccineFee As Double
        If petProcedure = "Both" Then
            If petType = "Feline" Then
                checkupFee = 500.0
                vaccineFee = 1000.0
            ElseIf petType = "Canine" Then
                checkupFee = 400.0
                vaccineFee = 1500.0
            ElseIf petType = "Reptile" Then
                checkupFee = 600.0
                vaccineFee = 2000.0
            End If
        ElseIf petProcedure = "Check-Up" Then
            If petType = "Feline" Then
                checkupFee = 500.0
            ElseIf petType = "Canine" Then
                checkupFee = 400.0
            ElseIf petType = "Reptile" Then
                checkupFee = 600.0
            End If
        ElseIf petProcedure = "Vaccine" Then
            If petType = "Feline" Then
                vaccineFee = 1000.0
            ElseIf petType = "Canine" Then
                vaccineFee = 1500.0
            ElseIf petType = "Reptile" Then
                vaccineFee = 2000.0
            End If
        End If
        Dim totalFee As Double = checkupFee + vaccineFee
        Return totalFee
    End Function
End Module

