Imports System.IO

Public Class frmParkVale

    Dim TrainingCost1 As Integer
    Dim TrainingCost2 As Integer


    Private Sub frmParkVale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'adds todays date to the todays date label
        lblToday.Text = Today.Date

        Dim number As Integer

        Randomize()
        'number from 0 to 50 will be generated
        number = Int(Rnd() * 5000) + 1

        lblMembershipNo.Text = number

        'Options to choose for activity 1 combobox

        cboActivity.Items.Add("Personal Trainer £10")
        cboActivity.Items.Add("Aromatherapy £75")
        cboActivity.Items.Add("Reflexology £40")
        cboActivity.Items.Add("Aerobics £60")
        cboActivity.Items.Add("Sunbeds £50")
        cboActivity.Items.Add("None")

        'Options to choose for activity 2 combobox

        cboActivity2.Items.Add("Yoga £70")
        cboActivity2.Items.Add("Spa £80")
        cboActivity2.Items.Add("Zumba £40")
        cboActivity2.Items.Add("Pilates £60")
        cboActivity2.Items.Add("Squash Courts £30")
        cboActivity2.Items.Add("None")

        'Sets the default cos as 0 for the training costs

        txtActivity.Text = 0
        txtStandardFee.Text = 0


    End Sub



    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click

        Dim paymentplan As String = ""

        'checks selected membership plan

        If optMonthly.Checked = True Then
            paymentplan = optMonthly.Text

        ElseIf optSixMonthly.Checked = True Then
            paymentplan = optSixMonthly.Text

        ElseIf optAnnual.Checked = True Then
            paymentplan = optAnnual.Text
        End If

        lstMemberDetailsList.Items.Clear()

        'Checks to see if activity 1 is selected and if so which one
        Dim activity1 As String = ""

        If cboActivity.SelectedItem = "Personal Trainer £10" Then
            activity1 = "Personal Trainer"
        ElseIf cboActivity.SelectedItem = "Aromatherapy £75" Then
            activity1 = "Aromatherapy"
        ElseIf cboActivity.SelectedItem = "Reflexology £40" Then
            activity1 = "Reflexology"
        ElseIf cboActivity.SelectedItem = "Aerobics £60" Then
            activity1 = "Areobics"
        ElseIf cboActivity.SelectedItem = "Sunbeds £50" Then
            activity1 = "Sunbeds"
        ElseIf cboActivity.SelectedItem = "None" Then
            activity1 = "None"
        Else
            activity1 = ""
        End If

        'Checks to see if activity 2 is selected and if so which one
        Dim activity2 As String = ""

        If cboActivity2.SelectedItem = "Yoga £70" Then
            activity2 = "Yoga"
        ElseIf cboActivity2.SelectedItem = "Spa £80" Then
            activity2 = "Spa"
        ElseIf cboActivity2.SelectedItem = "Zumba £40" Then
            activity2 = "Zumba"
        ElseIf cboActivity2.SelectedItem = "Pilates £60" Then
            activity2 = "Pilates"
        ElseIf cboActivity2.SelectedItem = "Squash Courts £30" Then
            activity2 = "Squash Courts"
        ElseIf cboActivity2.SelectedItem = "None" Then
            activity2 = "None"
        Else
            activity2 = ""
        End If

        'Adds the text in the textboxes and labels to the list

        lstMemberDetailsList.Items.Add(" Today's date: " + lblToday.Text)
        lstMemberDetailsList.Items.Add("")
        lstMemberDetailsList.Items.Add(" Membership Number: " + lblMembershipNo.Text)
        lstMemberDetailsList.Items.Add("")
        lstMemberDetailsList.Items.Add(" Title: " + txtTitle.Text)
        lstMemberDetailsList.Items.Add("")
        lstMemberDetailsList.Items.Add(" Full Name: " + txtCustomerName.Text + " " + txtSurname.Text)
        lstMemberDetailsList.Items.Add("")
        lstMemberDetailsList.Items.Add(" Address: " + txtAddress.Text)
        lstMemberDetailsList.Items.Add("")
        lstMemberDetailsList.Items.Add(" Town: " + txtTown.Text)
        lstMemberDetailsList.Items.Add("")
        lstMemberDetailsList.Items.Add(" PostCode: " + txtPostCode.Text)
        lstMemberDetailsList.Items.Add("")
        lstMemberDetailsList.Items.Add(" Telephone Number: " + txtTelephone.Text)
        lstMemberDetailsList.Items.Add("")
        lstMemberDetailsList.Items.Add(" Mobile Number: " + txtMobile.Text)
        lstMemberDetailsList.Items.Add("")
        lstMemberDetailsList.Items.Add(" Your Membership Details:")
        lstMemberDetailsList.Items.Add("")
        lstMemberDetailsList.Items.Add(" Membership Lenght: " + paymentplan)
        lstMemberDetailsList.Items.Add(" Cost: £ " + txtStandardFee.Text)
        lstMemberDetailsList.Items.Add("")
        lstMemberDetailsList.Items.Add(" Activity 1 added: " + activity1)

        lstMemberDetailsList.Items.Add("")
        lstMemberDetailsList.Items.Add(" Activity 2 added: " + activity2)

        lstMemberDetailsList.Items.Add("")
        lstMemberDetailsList.Items.Add(" Total Membership Cost: £ " + txtTotalCost.Text)
        lstMemberDetailsList.Items.Add("")
        lstMemberDetailsList.Items.Add(" Membership Summary ")
        lstMemberDetailsList.Items.Add("")
        lstMemberDetailsList.Items.Add(" Membership Numver: " + lblMembershipNo.Text)
        lstMemberDetailsList.Items.Add(" Membership Lenght " + paymentplan + ", £" + txtStandardFee.Text)
        lstMemberDetailsList.Items.Add(" Activity 1 added: " + activity1)
        lstMemberDetailsList.Items.Add(" Activity 2 added: " + activity2)
        lstMemberDetailsList.Items.Add(" Total Membership Cost: £" + txtTotalCost.Text)
        lstMemberDetailsList.Items.Add(" Today's date: " + lblToday.Text)
        lstMemberDetailsList.Items.Add("")

    End Sub

    Private Sub optMonthly_CheckedChanged(sender As Object, e As EventArgs) Handles optMonthly.CheckedChanged

        'sets the value of the standard membership value

        If optMonthly.Checked = True Then
            txtStandardFee.Text = 40

        End If
    End Sub

    Private Sub optSixMonthly_CheckedChanged(sender As Object, e As EventArgs) Handles optSixMonthly.CheckedChanged

        'sets the value of the standard membership value

        If optSixMonthly.Checked = True Then
            txtStandardFee.Text = 120

        End If

    End Sub

    Private Sub optAnnual_CheckedChanged(sender As Object, e As EventArgs) Handles optAnnual.CheckedChanged

        'sets the value of the standard membership value

        If optAnnual.Checked = True Then
            txtStandardFee.Text = 200

        End If

    End Sub

    Private Sub cboActivity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboActivity.SelectedIndexChanged
        'this sets the value of choosen activities from activity combobox depending
        'on what option item is selected

        If cboActivity.SelectedItem = "Personal Trainer £10" Then
            TrainingCost1 = 10
        End If

        If cboActivity.SelectedItem = "Aromatherapy £75" Then
            TrainingCost1 = 75
        End If

        If cboActivity.SelectedItem = "Reflexology £40" Then
            TrainingCost1 = 40
        End If

        If cboActivity.SelectedItem = "Aerobics £60" Then
            TrainingCost1 = 60
        End If

        If cboActivity.SelectedItem = "Sunbeds £50" Then
            TrainingCost1 = 50
        End If

        If cboActivity.SelectedItem = "None" Then
            TrainingCost1 = 0
        End If

        'this calculates the total training cost
        Dim TrainingCostTotal As Integer = 0
        Dim cost1 As Integer = Val(TrainingCost1)
        Dim cost2 As Integer = Val(TrainingCost2)

        TrainingCostTotal = cost1 + cost2

        txtActivity.Text = TrainingCostTotal

    End Sub

    Private Sub cboActivity2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboActivity2.SelectedIndexChanged
        'this sets the value of choosen activities from activity2 combobox depending
        'on what option item is selected

        If cboActivity2.SelectedItem = "Yoga £70" Then
            TrainingCost2 = 70
        End If

        If cboActivity2.SelectedItem = "Spa £80" Then
            TrainingCost2 = 80
        End If

        If cboActivity2.SelectedItem = "Zumba £40" Then
            TrainingCost2 = 40
        End If

        If cboActivity2.SelectedItem = "Pilates £60" Then
            TrainingCost2 = 60
        End If

        If cboActivity2.SelectedItem = "Squash Courts £30" Then
            TrainingCost2 = 30
        End If

        If cboActivity2.SelectedItem = "None" Then
            TrainingCost2 = 0
        End If


        'this calculates the total training cost
        Dim TrainingCostTotal As Integer = 0
        Dim cost1 As Integer = Val(TrainingCost1)
        Dim cost2 As Integer = Val(TrainingCost2)

        TrainingCostTotal = cost1 + cost2

        txtActivity.Text = TrainingCostTotal

    End Sub

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        'Calculates the total cost of membership
        Dim TotalMembershipCost As Integer = 0
        Dim StandardCost As Integer = Val(txtStandardFee.Text)
        Dim TrainingCost As Integer = Val(txtActivity.Text)

        TotalMembershipCost = StandardCost + TrainingCost

        txtTotalCost.Text = TotalMembershipCost

    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click

        'This resets all of the fields in the form
        Dim FormOpen As New frmParkVale
        FormOpen.Show()
        Me.Close()

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        'This closes the form and moves the user back to the login form
        frmLogin.Show()
        Me.Close()

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        'This saves the text in the listbox to a text file
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Using StreamWriter As New IO.StreamWriter(SaveFileDialog1.FileName)
                For Each str As String In lstMemberDetailsList.Items
                    StreamWriter.WriteLine(str)
                Next
            End Using
        End If

    End Sub
End Class

