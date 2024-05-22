Public Class Payment_Page

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Rcd_Page.childForm(SessionHandlingPage)
        SessionHandlingPage.loadSessionHandlingPage()
    End Sub

    Private Sub btnPayAndShowReceipt_Click(sender As Object, e As EventArgs) Handles btnPayAndShowReceipt.Click
        'Dim dblPayment As Double = txtPayment.Text
        'If dblPayment >= Booking_Page.totalFee Then
        '    loadReceipt()
        '    FileManipulator.SavePet(activeAccount, Booking_Page.tempPetObject)
        '    'FileManipulator.SaveBooking(Booking_Page.tempPetObject.appointment.dateAppointment)
        '    NavigatorPage.childForm(Receipt_Page)
        'Else
        '    MsgBox("Insufficient funds", vbCritical)
        'End If
        Rcd_Page.childForm(WalkInReceiptPage)
        WalkInReceiptPage.loadWalkInReceiptPage()
    End Sub

    Public Sub loadPaymentPage()
        billRowsPanel.Controls.Clear()

        lblPetOwner.Text = SessionHandlingPage.selectedSession.petOwner.strName

        Dim total As Double = 0
        For Each petProcedureString In SessionHandlingPage.selectedSession.petWithProcedureList
            billRowsPanel.Controls.Add(New BillingRowPanel(petProcedureString))
            petType = petProcedureString.Split("#"c)(1)
            petProc = petProcedureString.Split("#"c)(2)
            total += computeTotalBill(petType, petProc)
        Next

        lblTotalFee.Text = ToPesoFormat(total)
    End Sub

    Public Sub loadReceipt()
        Receipt_Page.lblMessage.Text = "Hi " & activeAccount.strName & ", Your appoinment has been confirmed!"
        Receipt_Page.lblPetOwnerName.Text = activeAccount.strName
        Receipt_Page.lblPetOwnerAddress.Text = activeAccount.strAddress
        Receipt_Page.lblPetName.Text = Booking_Page.tempPetObject.strName
        Receipt_Page.lblPetType.Text = Booking_Page.tempPetObject.strType
        Receipt_Page.lblDateOfAppointment.Text = 'Booking_Page.tempPetObject.appointment.dateAppointment
        Receipt_Page.lblPetType2.Text = Booking_Page.tempPetObject.strType
        Receipt_Page.lblPetType3.Text = Booking_Page.tempPetObject.strType
        Receipt_Page.lblCheckupFee.Text = Me.lblCheckupFee.Text
        'Receipt_Page.lblVaccineFee.Text = Me.lblVaccineFee.Text
        Receipt_Page.lblTotalFee.Text = Me.lblTotalFee.Text
        Receipt_Page.lblAmountPaid.Text = "₱" & Me.txtPayment.Text
        Receipt_Page.lblChange.Text = "₱" & (Val(Me.txtPayment.Text) - Booking_Page.totalFee)
    End Sub

End Class