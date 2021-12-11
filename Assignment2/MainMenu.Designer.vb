<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmParkVale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lblParkVale = New System.Windows.Forms.Label()
        Me.lblCustomerTitle = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblTown = New System.Windows.Forms.Label()
        Me.lblPostCode = New System.Windows.Forms.Label()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtTown = New System.Windows.Forms.TextBox()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.lblTrainingPlan = New System.Windows.Forms.Label()
        Me.lblStandardFee = New System.Windows.Forms.Label()
        Me.cboActivity = New System.Windows.Forms.ComboBox()
        Me.cboActivity2 = New System.Windows.Forms.ComboBox()
        Me.optMonthly = New System.Windows.Forms.RadioButton()
        Me.lblMemType = New System.Windows.Forms.Label()
        Me.optSixMonthly = New System.Windows.Forms.RadioButton()
        Me.optAnnual = New System.Windows.Forms.RadioButton()
        Me.txtStandardFee = New System.Windows.Forms.TextBox()
        Me.txtActivity = New System.Windows.Forms.TextBox()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.lblMemberNo = New System.Windows.Forms.Label()
        Me.lblMembershipNo = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblToday = New System.Windows.Forms.Label()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.lblStandardFeeUp = New System.Windows.Forms.Label()
        Me.lblActivityUp = New System.Windows.Forms.Label()
        Me.lblTotalCostUp = New System.Windows.Forms.Label()
        Me.lstMemberDetailsList = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbLogo
        '
        Me.pbLogo.BackgroundImage = Global.Assignment2.My.Resources.Resources.Health_Club_logo
        Me.pbLogo.Location = New System.Drawing.Point(13, 13)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(174, 59)
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'lblParkVale
        '
        Me.lblParkVale.AutoSize = True
        Me.lblParkVale.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblParkVale.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParkVale.Location = New System.Drawing.Point(466, 24)
        Me.lblParkVale.Name = "lblParkVale"
        Me.lblParkVale.Size = New System.Drawing.Size(332, 37)
        Me.lblParkVale.TabIndex = 1
        Me.lblParkVale.Text = "Park Vale Health Club"
        '
        'lblCustomerTitle
        '
        Me.lblCustomerTitle.AutoSize = True
        Me.lblCustomerTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerTitle.Location = New System.Drawing.Point(416, 72)
        Me.lblCustomerTitle.Name = "lblCustomerTitle"
        Me.lblCustomerTitle.Size = New System.Drawing.Size(111, 20)
        Me.lblCustomerTitle.TabIndex = 2
        Me.lblCustomerTitle.Text = "Customer Title"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(554, 72)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(124, 20)
        Me.lblCustomerName.TabIndex = 3
        Me.lblCustomerName.Text = "Customer Name"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(709, 72)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(147, 20)
        Me.lblSurname.TabIndex = 4
        Me.lblSurname.Text = "Customer Surname"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(469, 130)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(147, 19)
        Me.lblAddress.TabIndex = 5
        Me.lblAddress.Text = "Customer Address"
        '
        'lblTown
        '
        Me.lblTown.AutoSize = True
        Me.lblTown.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTown.Location = New System.Drawing.Point(681, 130)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(129, 19)
        Me.lblTown.TabIndex = 6
        Me.lblTown.Text = "Customer Town"
        '
        'lblPostCode
        '
        Me.lblPostCode.AutoSize = True
        Me.lblPostCode.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostCode.Location = New System.Drawing.Point(336, 193)
        Me.lblPostCode.Name = "lblPostCode"
        Me.lblPostCode.Size = New System.Drawing.Size(142, 16)
        Me.lblPostCode.TabIndex = 7
        Me.lblPostCode.Text = "Customer Post Code"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelephone.Location = New System.Drawing.Point(495, 193)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(197, 16)
        Me.lblTelephone.TabIndex = 8
        Me.lblTelephone.Text = "Customer Telephone Number"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobile.Location = New System.Drawing.Point(698, 193)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(170, 16)
        Me.lblMobile.TabIndex = 9
        Me.lblMobile.Text = "Customer Mobile Number"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(440, 95)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(59, 20)
        Me.txtTitle.TabIndex = 10
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(570, 95)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(96, 20)
        Me.txtCustomerName.TabIndex = 11
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(713, 95)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(143, 20)
        Me.txtSurname.TabIndex = 12
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(450, 152)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(179, 20)
        Me.txtAddress.TabIndex = 13
        '
        'txtTown
        '
        Me.txtTown.Location = New System.Drawing.Point(685, 152)
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(125, 20)
        Me.txtTown.TabIndex = 14
        '
        'txtPostCode
        '
        Me.txtPostCode.Location = New System.Drawing.Point(360, 215)
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(96, 20)
        Me.txtPostCode.TabIndex = 15
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(545, 212)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(96, 20)
        Me.txtTelephone.TabIndex = 16
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(735, 215)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(96, 20)
        Me.txtMobile.TabIndex = 17
        '
        'lblTrainingPlan
        '
        Me.lblTrainingPlan.AutoSize = True
        Me.lblTrainingPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrainingPlan.Location = New System.Drawing.Point(698, 255)
        Me.lblTrainingPlan.Name = "lblTrainingPlan"
        Me.lblTrainingPlan.Size = New System.Drawing.Size(170, 18)
        Me.lblTrainingPlan.TabIndex = 18
        Me.lblTrainingPlan.Text = "Choose Training Plan"
        '
        'lblStandardFee
        '
        Me.lblStandardFee.AutoSize = True
        Me.lblStandardFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStandardFee.Location = New System.Drawing.Point(511, 255)
        Me.lblStandardFee.Name = "lblStandardFee"
        Me.lblStandardFee.Size = New System.Drawing.Size(167, 18)
        Me.lblStandardFee.TabIndex = 19
        Me.lblStandardFee.Text = "Standard Joining Fee"
        '
        'cboActivity
        '
        Me.cboActivity.FormattingEnabled = True
        Me.cboActivity.Location = New System.Drawing.Point(724, 286)
        Me.cboActivity.Name = "cboActivity"
        Me.cboActivity.Size = New System.Drawing.Size(121, 21)
        Me.cboActivity.TabIndex = 20
        '
        'cboActivity2
        '
        Me.cboActivity2.FormattingEnabled = True
        Me.cboActivity2.Location = New System.Drawing.Point(724, 328)
        Me.cboActivity2.Name = "cboActivity2"
        Me.cboActivity2.Size = New System.Drawing.Size(121, 21)
        Me.cboActivity2.TabIndex = 21
        '
        'optMonthly
        '
        Me.optMonthly.AutoSize = True
        Me.optMonthly.Location = New System.Drawing.Point(377, 286)
        Me.optMonthly.Name = "optMonthly"
        Me.optMonthly.Size = New System.Drawing.Size(62, 17)
        Me.optMonthly.TabIndex = 22
        Me.optMonthly.TabStop = True
        Me.optMonthly.Text = "Monthly"
        Me.optMonthly.UseVisualStyleBackColor = True
        '
        'lblMemType
        '
        Me.lblMemType.AutoSize = True
        Me.lblMemType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemType.Location = New System.Drawing.Point(342, 255)
        Me.lblMemType.Name = "lblMemType"
        Me.lblMemType.Size = New System.Drawing.Size(136, 18)
        Me.lblMemType.TabIndex = 23
        Me.lblMemType.Text = "Membership type"
        '
        'optSixMonthly
        '
        Me.optSixMonthly.AutoSize = True
        Me.optSixMonthly.Location = New System.Drawing.Point(377, 318)
        Me.optSixMonthly.Name = "optSixMonthly"
        Me.optSixMonthly.Size = New System.Drawing.Size(69, 17)
        Me.optSixMonthly.TabIndex = 24
        Me.optSixMonthly.TabStop = True
        Me.optSixMonthly.Text = "6 Months"
        Me.optSixMonthly.UseVisualStyleBackColor = True
        '
        'optAnnual
        '
        Me.optAnnual.AutoSize = True
        Me.optAnnual.Location = New System.Drawing.Point(377, 350)
        Me.optAnnual.Name = "optAnnual"
        Me.optAnnual.Size = New System.Drawing.Size(58, 17)
        Me.optAnnual.TabIndex = 25
        Me.optAnnual.TabStop = True
        Me.optAnnual.Text = "Annual"
        Me.optAnnual.UseVisualStyleBackColor = True
        '
        'txtStandardFee
        '
        Me.txtStandardFee.Location = New System.Drawing.Point(545, 302)
        Me.txtStandardFee.Name = "txtStandardFee"
        Me.txtStandardFee.Size = New System.Drawing.Size(100, 20)
        Me.txtStandardFee.TabIndex = 26
        '
        'txtActivity
        '
        Me.txtActivity.Location = New System.Drawing.Point(545, 350)
        Me.txtActivity.Name = "txtActivity"
        Me.txtActivity.Size = New System.Drawing.Size(100, 20)
        Me.txtActivity.TabIndex = 27
        Me.txtActivity.Text = " "
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(545, 399)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCost.TabIndex = 28
        '
        'lblMemberNo
        '
        Me.lblMemberNo.AutoSize = True
        Me.lblMemberNo.Location = New System.Drawing.Point(46, 79)
        Me.lblMemberNo.Name = "lblMemberNo"
        Me.lblMemberNo.Size = New System.Drawing.Size(104, 13)
        Me.lblMemberNo.TabIndex = 29
        Me.lblMemberNo.Text = "Membership Number"
        '
        'lblMembershipNo
        '
        Me.lblMembershipNo.AutoSize = True
        Me.lblMembershipNo.Location = New System.Drawing.Point(79, 98)
        Me.lblMembershipNo.Name = "lblMembershipNo"
        Me.lblMembershipNo.Size = New System.Drawing.Size(39, 13)
        Me.lblMembershipNo.TabIndex = 30
        Me.lblMembershipNo.Text = "Label1"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(66, 130)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(68, 13)
        Me.lblDate.TabIndex = 31
        Me.lblDate.Text = "Today's date"
        '
        'lblToday
        '
        Me.lblToday.AutoSize = True
        Me.lblToday.Location = New System.Drawing.Point(69, 152)
        Me.lblToday.Name = "lblToday"
        Me.lblToday.Size = New System.Drawing.Size(39, 13)
        Me.lblToday.TabIndex = 32
        Me.lblToday.Text = "Label1"
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Location = New System.Drawing.Point(527, 441)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(139, 72)
        Me.cmdCalculate.TabIndex = 34
        Me.cmdCalculate.Text = "Calculate Membership"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(12, 469)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(96, 44)
        Me.cmdAdd.TabIndex = 35
        Me.cmdAdd.Text = "Add Member Details"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(147, 469)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(96, 44)
        Me.cmdSave.TabIndex = 36
        Me.cmdSave.Text = "Save Details"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(701, 481)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(80, 32)
        Me.cmdClear.TabIndex = 37
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(794, 481)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 32)
        Me.cmdExit.TabIndex = 38
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'lblStandardFeeUp
        '
        Me.lblStandardFeeUp.AutoSize = True
        Me.lblStandardFeeUp.Location = New System.Drawing.Point(542, 286)
        Me.lblStandardFeeUp.Name = "lblStandardFeeUp"
        Me.lblStandardFeeUp.Size = New System.Drawing.Size(71, 13)
        Me.lblStandardFeeUp.TabIndex = 39
        Me.lblStandardFeeUp.Text = "Standard Fee"
        '
        'lblActivityUp
        '
        Me.lblActivityUp.AutoSize = True
        Me.lblActivityUp.Location = New System.Drawing.Point(542, 334)
        Me.lblActivityUp.Name = "lblActivityUp"
        Me.lblActivityUp.Size = New System.Drawing.Size(62, 13)
        Me.lblActivityUp.TabIndex = 40
        Me.lblActivityUp.Text = "Activity Fee"
        '
        'lblTotalCostUp
        '
        Me.lblTotalCostUp.AutoSize = True
        Me.lblTotalCostUp.Location = New System.Drawing.Point(542, 383)
        Me.lblTotalCostUp.Name = "lblTotalCostUp"
        Me.lblTotalCostUp.Size = New System.Drawing.Size(55, 13)
        Me.lblTotalCostUp.TabIndex = 41
        Me.lblTotalCostUp.Text = "Total Cost"
        '
        'lstMemberDetailsList
        '
        Me.lstMemberDetailsList.FormattingEnabled = True
        Me.lstMemberDetailsList.Location = New System.Drawing.Point(14, 193)
        Me.lstMemberDetailsList.Name = "lstMemberDetailsList"
        Me.lstMemberDetailsList.Size = New System.Drawing.Size(229, 264)
        Me.lstMemberDetailsList.TabIndex = 42
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmParkVale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment2.My.Resources.Resources.login_background
        Me.ClientSize = New System.Drawing.Size(886, 525)
        Me.Controls.Add(Me.lstMemberDetailsList)
        Me.Controls.Add(Me.lblTotalCostUp)
        Me.Controls.Add(Me.lblActivityUp)
        Me.Controls.Add(Me.lblStandardFeeUp)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.lblToday)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblMembershipNo)
        Me.Controls.Add(Me.lblMemberNo)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.txtActivity)
        Me.Controls.Add(Me.txtStandardFee)
        Me.Controls.Add(Me.optAnnual)
        Me.Controls.Add(Me.optSixMonthly)
        Me.Controls.Add(Me.lblMemType)
        Me.Controls.Add(Me.optMonthly)
        Me.Controls.Add(Me.cboActivity2)
        Me.Controls.Add(Me.cboActivity)
        Me.Controls.Add(Me.lblStandardFee)
        Me.Controls.Add(Me.lblTrainingPlan)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.txtTelephone)
        Me.Controls.Add(Me.txtPostCode)
        Me.Controls.Add(Me.txtTown)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblMobile)
        Me.Controls.Add(Me.lblTelephone)
        Me.Controls.Add(Me.lblPostCode)
        Me.Controls.Add(Me.lblTown)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.lblCustomerTitle)
        Me.Controls.Add(Me.lblParkVale)
        Me.Controls.Add(Me.pbLogo)
        Me.Name = "frmParkVale"
        Me.Text = "Form1"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents lblParkVale As Label
    Friend WithEvents lblCustomerTitle As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblTown As Label
    Friend WithEvents lblPostCode As Label
    Friend WithEvents lblTelephone As Label
    Friend WithEvents lblMobile As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtTown As TextBox
    Friend WithEvents txtPostCode As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents lblTrainingPlan As Label
    Friend WithEvents lblStandardFee As Label
    Friend WithEvents cboActivity As ComboBox
    Friend WithEvents cboActivity2 As ComboBox
    Friend WithEvents optMonthly As RadioButton
    Friend WithEvents lblMemType As Label
    Friend WithEvents optSixMonthly As RadioButton
    Friend WithEvents optAnnual As RadioButton
    Friend WithEvents txtStandardFee As TextBox
    Friend WithEvents txtActivity As TextBox
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents lblMemberNo As Label
    Friend WithEvents lblMembershipNo As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblToday As Label
    Friend WithEvents cmdCalculate As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents lblStandardFeeUp As Label
    Friend WithEvents lblActivityUp As Label
    Friend WithEvents lblTotalCostUp As Label
    Friend WithEvents lstMemberDetailsList As ListBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
