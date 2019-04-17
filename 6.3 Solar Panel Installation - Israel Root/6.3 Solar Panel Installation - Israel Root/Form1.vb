
Public Class Form1

    Private decPanel As Decimal 'to hold Panel Amount
    Private decBase As Decimal 'to hold the base price
    Private decDue As Decimal 'Hold Deposit
    Private decphone As Integer



    Private Function ValidateInputFields() As Boolean
        'Try to convert each of the input fields. Return false if 
        'any field is invalid, and display a suitable error message.

        If Not Decimal.TryParse(txtPanels.Text, decPanel) Then
            MessageBox.Show("Panel Amount must be numeric")
            Return False
        End If
        If Not Decimal.TryParse(txtDeposit.Text, decDue) Then
            MessageBox.Show("Deposit Amount must be numeric")
            Return False
        End If
        If Not Integer.TryParse(txtPhone.Text, decphone) Then
            MessageBox.Show("Phone Number must be numeric")

            Return False
        End If
        If txtFirstName.Text = "" Then
            MessageBox.Show("First Name feild cannot be empty")

        ElseIf txtLastName.Text = "" Then
            MessageBox.Show("Last Name feild cannot be empty")
            Return False
        End If
        If decPanel < 1 Then
            MessageBox.Show("Panels must be a number between 1 and 1000")

        End If
        If decPanel > 1000 Then
            MessageBox.Show("Panels must be a number between 1 and 1000")
        End If

        If decDue <= 0 Then
            MessageBox.Show("Deposit amount must be greater than 0")
        End If

        decBase = 2000
        Return True
    End Function

    Function CalculateSale() As Decimal

        'Calculate and return the sale price
        Dim Total As Decimal

        If CInt(txtPanels.Text) >= 2 Then
            Total = decBase + ((decPanel - 2) * 300)

        Else
            Total = decBase

        End If
        Return Total

    End Function


    Function Additionalpanels() As Decimal

        'Calculate and return the sale price
        Dim Panels As Decimal

        If CInt(txtPanels.Text) > 2 Then
            Panels = (decPanel - 2) * 300

        Else
            Panels = 0

        End If
        Return Panels

    End Function

    Function BalanceDue() As Decimal

        'Calculate and return the sale price
        Dim Baldue As Decimal
        If chkInstallation.Checked = True Then
            Baldue = Express() - decDue
        Else
            Baldue = CalculateSale() - decDue


        End If
        Return Baldue
    End Function

    Function Express() As Decimal

        'Calculate and return the sale price
        Dim five As Decimal

        five = CDec(CalculateSale() + (CalculateSale() * 0.05))

        Return five
    End Function


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click


        Dim TotalCost As Decimal
        Dim addpanels As Decimal
        Dim TotalDue As Decimal



        'If the input is valid, display the sale price.
        If ValidateInputFields() Then



            If chkInstallation.Checked = True Then

                    lblBase.Text = decBase.ToString("c")

                    lblDepositAmount.Text = decDue.ToString("c")
                    'Display GroupBox
                    grpCharges.Show()
                    Label1.Visible = True
                    Label2.Visible = True
                lblRefund.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                lblBase.Visible = True
                lblAddPanels.Visible = True
                lblTotal.Visible = True
                lblDepositAmount.Visible = True
                lblBalance.Visible = True
                btnClear.Visible = True
                btnClose.Visible = True


                TotalDue = BalanceDue()
                addpanels = Additionalpanels()
                TotalCost = Express()

                lblTotal.Text = TotalCost.ToString("c")
                lblBalance.Text = TotalDue.ToString("c")
                lblAddPanels.Text = addpanels.ToString("c")

            Else
                lblBase.Text = decBase.ToString("c")
                lblDepositAmount.Text = decDue.ToString("c")

                'Display GroupBox
                grpCharges.Show()
                Label1.Visible = True
                Label2.Visible = True
                lblRefund.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                lblBase.Visible = True
                lblAddPanels.Visible = True
                lblTotal.Visible = True
                lblDepositAmount.Visible = True
                lblBalance.Visible = True
                btnClear.Visible = True
                btnClose.Visible = True
                TotalDue = BalanceDue()
                addpanels = Additionalpanels()
                TotalCost = CalculateSale()

                lblTotal.Text = TotalCost.ToString("c")
                lblBalance.Text = TotalDue.ToString("c")
                lblAddPanels.Text = addpanels.ToString("c")

            End If

        End If
        If lblDepositAmount.Text > lblTotal.Text Then
            lblRefund.Text = "        Refund:"
        Else
            lblRefund.Text = "Balance due:"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        grpCharges.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        lblRefund.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        lblBase.Visible = False
        lblAddPanels.Visible = False
        lblTotal.Visible = False
        lblDepositAmount.Visible = False
        lblBalance.Visible = False
        btnClear.Visible = False
        btnClose.Visible = False

        lblBalance.Text = String.Empty
        lblBase.Text = String.Empty
        lblDepositAmount.Text = String.Empty
        lblTotal.Text = String.Empty
        lblAddPanels.Text = String.Empty

        chkInstallation.Checked = False
        txtDeposit.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtPanels.Clear()
        txtPhone.Clear()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class













