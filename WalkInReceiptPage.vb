Public Class WalkInReceiptPage

    Public Sub loadWalkInReceiptPage()
        receiptRowsPanel.Controls.Clear()

        Dim sessionReference As Session = SessionHandlingPage.selectedSession
        lblPetOwner.Text = sessionReference.petOwner.strName
        lblSessionDate.Text = Date.Now.ToString("MMMM dd, yyyy")

        Dim total As Double = 0
        For Each petProcedureString In sessionReference.petWithProcedureList
            receiptRowsPanel.Controls.Add(New ReceiptRowPanel(petProcedureString))
            petType = petProcedureString.Split("#"c)(1)
            petProc = petProcedureString.Split("#"c)(3)
            total += computeTotalBill(petType, petProc)
        Next

        Dim amountPaid = Val(Payment_Page.txtPayment.Text)
        Dim change = amountPaid - total

        lblTotal.Text = ToPesoFormat(total)
        lblAmountPaid.Text = ToPesoFormat(amountPaid)
        lblChange.Text = ToPesoFormat(change)
    End Sub

    Private Sub btnBackToSessionPage_Click(sender As Object, e As EventArgs) Handles btnBackToSessionPage.Click
        Rcd_Page.childForm(SessionHandlingPage)
        SessionHandlingPage.loadSessionHandlingPage()
    End Sub
End Class