<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.grpCharges = New System.Windows.Forms.GroupBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblDepositAmount = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblBase = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAddPanels = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRefund = New System.Windows.Forms.Label()
        Me.txtPanels = New System.Windows.Forms.TextBox()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.chkInstallation = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grpCharges.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 84)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "First Name:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Last Name:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(242, 50)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(134, 20)
        Me.txtPhone.TabIndex = 7
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(82, 50)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(134, 20)
        Me.txtLastName.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(239, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Phone:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(82, 27)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(134, 20)
        Me.txtFirstName.TabIndex = 9
        '
        'grpCharges
        '
        Me.grpCharges.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grpCharges.Controls.Add(Me.lblBalance)
        Me.grpCharges.Controls.Add(Me.lblDepositAmount)
        Me.grpCharges.Controls.Add(Me.lblTotal)
        Me.grpCharges.Controls.Add(Me.lblBase)
        Me.grpCharges.Controls.Add(Me.Label5)
        Me.grpCharges.Controls.Add(Me.btnClose)
        Me.grpCharges.Controls.Add(Me.btnClear)
        Me.grpCharges.Controls.Add(Me.Label1)
        Me.grpCharges.Controls.Add(Me.lblAddPanels)
        Me.grpCharges.Controls.Add(Me.Label4)
        Me.grpCharges.Controls.Add(Me.Label2)
        Me.grpCharges.Controls.Add(Me.lblRefund)
        Me.grpCharges.Location = New System.Drawing.Point(12, 230)
        Me.grpCharges.Name = "grpCharges"
        Me.grpCharges.Size = New System.Drawing.Size(393, 145)
        Me.grpCharges.TabIndex = 0
        Me.grpCharges.TabStop = False
        Me.grpCharges.Text = "Charges"
        Me.grpCharges.Visible = False
        '
        'lblBalance
        '
        Me.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBalance.Location = New System.Drawing.Point(150, 114)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(100, 20)
        Me.lblBalance.TabIndex = 14
        Me.lblBalance.Visible = False
        '
        'lblDepositAmount
        '
        Me.lblDepositAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDepositAmount.Location = New System.Drawing.Point(150, 92)
        Me.lblDepositAmount.Name = "lblDepositAmount"
        Me.lblDepositAmount.Size = New System.Drawing.Size(100, 20)
        Me.lblDepositAmount.TabIndex = 13
        Me.lblDepositAmount.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(150, 70)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 20)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Visible = False
        '
        'lblBase
        '
        Me.lblBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBase.Location = New System.Drawing.Point(150, 26)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(100, 20)
        Me.lblBase.TabIndex = 11
        Me.lblBase.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Base charge for 2 panels:"
        Me.Label5.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(272, 71)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 35)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        Me.btnClose.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(272, 27)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 35)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total cost:"
        Me.Label1.Visible = False
        '
        'lblAddPanels
        '
        Me.lblAddPanels.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddPanels.Location = New System.Drawing.Point(150, 48)
        Me.lblAddPanels.Name = "lblAddPanels"
        Me.lblAddPanels.Size = New System.Drawing.Size(100, 20)
        Me.lblAddPanels.TabIndex = 0
        Me.lblAddPanels.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Deposit amount:"
        Me.Label4.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Additional panels:"
        Me.Label2.Visible = False
        '
        'lblRefund
        '
        Me.lblRefund.AutoSize = True
        Me.lblRefund.Location = New System.Drawing.Point(74, 115)
        Me.lblRefund.Name = "lblRefund"
        Me.lblRefund.Size = New System.Drawing.Size(70, 13)
        Me.lblRefund.TabIndex = 3
        Me.lblRefund.Text = "Balance due:"
        Me.lblRefund.Visible = False
        '
        'txtPanels
        '
        Me.txtPanels.Location = New System.Drawing.Point(128, 27)
        Me.txtPanels.Name = "txtPanels"
        Me.txtPanels.Size = New System.Drawing.Size(66, 20)
        Me.txtPanels.TabIndex = 6
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(128, 52)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(66, 20)
        Me.txtDeposit.TabIndex = 10
        '
        'chkInstallation
        '
        Me.chkInstallation.AutoSize = True
        Me.chkInstallation.Location = New System.Drawing.Point(19, 82)
        Me.chkInstallation.Name = "chkInstallation"
        Me.chkInstallation.Size = New System.Drawing.Size(138, 17)
        Me.chkInstallation.TabIndex = 11
        Me.chkInstallation.Text = "Express installation (5%)"
        Me.chkInstallation.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox3.Controls.Add(Me.chkInstallation)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtDeposit)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtPanels)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 108)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(216, 105)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Installation Options"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Number of Panels:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(37, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Deposit Amount:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(254, 125)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(134, 38)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate Charges"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(415, 387)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpCharges)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Solar Panel Installation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpCharges.ResumeLayout(False)
        Me.grpCharges.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents grpCharges As GroupBox
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblDepositAmount As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblBase As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAddPanels As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRefund As Label
    Friend WithEvents txtPanels As TextBox
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents chkInstallation As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnCalculate As Button
End Class
