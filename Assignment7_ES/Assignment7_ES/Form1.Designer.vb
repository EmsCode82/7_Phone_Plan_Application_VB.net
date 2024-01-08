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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMonthlySubtotal = New System.Windows.Forms.Label()
        Me.rad800 = New System.Windows.Forms.RadioButton()
        Me.rad1500 = New System.Windows.Forms.RadioButton()
        Me.radUnlimitedTalk = New System.Windows.Forms.RadioButton()
        Me.chkUnlimitedText = New System.Windows.Forms.CheckBox()
        Me.chkVideoChat = New System.Windows.Forms.CheckBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblMonthyTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radSimsongAG = New System.Windows.Forms.RadioButton()
        Me.radiPoundXV = New System.Windows.Forms.RadioButton()
        Me.radCustomerPhone = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(107, 405)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(188, 405)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(269, 405)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMonthlySubtotal
        '
        Me.lblMonthlySubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMonthlySubtotal.Location = New System.Drawing.Point(142, 27)
        Me.lblMonthlySubtotal.Name = "lblMonthlySubtotal"
        Me.lblMonthlySubtotal.Size = New System.Drawing.Size(137, 38)
        Me.lblMonthlySubtotal.TabIndex = 3
        Me.lblMonthlySubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rad800
        '
        Me.rad800.AutoSize = True
        Me.rad800.Location = New System.Drawing.Point(18, 33)
        Me.rad800.Name = "rad800"
        Me.rad800.Size = New System.Drawing.Size(83, 17)
        Me.rad800.TabIndex = 6
        Me.rad800.TabStop = True
        Me.rad800.Text = "800 Minutes"
        Me.rad800.UseVisualStyleBackColor = True
        '
        'rad1500
        '
        Me.rad1500.AutoSize = True
        Me.rad1500.Location = New System.Drawing.Point(18, 69)
        Me.rad1500.Name = "rad1500"
        Me.rad1500.Size = New System.Drawing.Size(89, 17)
        Me.rad1500.TabIndex = 7
        Me.rad1500.TabStop = True
        Me.rad1500.Text = "1500 Minutes"
        Me.rad1500.UseVisualStyleBackColor = True
        '
        'radUnlimitedTalk
        '
        Me.radUnlimitedTalk.AutoSize = True
        Me.radUnlimitedTalk.Location = New System.Drawing.Point(18, 107)
        Me.radUnlimitedTalk.Name = "radUnlimitedTalk"
        Me.radUnlimitedTalk.Size = New System.Drawing.Size(92, 17)
        Me.radUnlimitedTalk.TabIndex = 8
        Me.radUnlimitedTalk.TabStop = True
        Me.radUnlimitedTalk.Text = "Unlimited Talk"
        Me.radUnlimitedTalk.UseVisualStyleBackColor = True
        '
        'chkUnlimitedText
        '
        Me.chkUnlimitedText.AutoSize = True
        Me.chkUnlimitedText.Location = New System.Drawing.Point(24, 51)
        Me.chkUnlimitedText.Name = "chkUnlimitedText"
        Me.chkUnlimitedText.Size = New System.Drawing.Size(93, 17)
        Me.chkUnlimitedText.TabIndex = 12
        Me.chkUnlimitedText.Text = "Unlimited Text"
        Me.chkUnlimitedText.UseVisualStyleBackColor = True
        '
        'chkVideoChat
        '
        Me.chkVideoChat.AutoSize = True
        Me.chkVideoChat.Location = New System.Drawing.Point(24, 89)
        Me.chkVideoChat.Name = "chkVideoChat"
        Me.chkVideoChat.Size = New System.Drawing.Size(78, 17)
        Me.chkVideoChat.TabIndex = 13
        Me.chkVideoChat.Text = "Video Chat"
        Me.chkVideoChat.UseVisualStyleBackColor = True
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(142, 85)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(137, 38)
        Me.lblTax.TabIndex = 14
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMonthyTotal
        '
        Me.lblMonthyTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMonthyTotal.Location = New System.Drawing.Point(142, 143)
        Me.lblMonthyTotal.Name = "lblMonthyTotal"
        Me.lblMonthyTotal.Size = New System.Drawing.Size(137, 38)
        Me.lblMonthyTotal.TabIndex = 15
        Me.lblMonthyTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Monthly Subtotal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Tax"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Monthly Total"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTax)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblMonthlySubtotal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblMonthyTotal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 208)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Monthly Totals"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rad800)
        Me.GroupBox2.Controls.Add(Me.rad1500)
        Me.GroupBox2.Controls.Add(Me.radUnlimitedTalk)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(129, 156)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Plans"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radSimsongAG)
        Me.GroupBox3.Controls.Add(Me.radiPoundXV)
        Me.GroupBox3.Controls.Add(Me.radCustomerPhone)
        Me.GroupBox3.Location = New System.Drawing.Point(163, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(129, 156)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Phones"
        '
        'radSimsongAG
        '
        Me.radSimsongAG.AutoSize = True
        Me.radSimsongAG.Location = New System.Drawing.Point(18, 33)
        Me.radSimsongAG.Name = "radSimsongAG"
        Me.radSimsongAG.Size = New System.Drawing.Size(83, 17)
        Me.radSimsongAG.TabIndex = 6
        Me.radSimsongAG.Text = "Simsong AG"
        Me.radSimsongAG.UseVisualStyleBackColor = True
        '
        'radiPoundXV
        '
        Me.radiPoundXV.AutoSize = True
        Me.radiPoundXV.Location = New System.Drawing.Point(18, 69)
        Me.radiPoundXV.Name = "radiPoundXV"
        Me.radiPoundXV.Size = New System.Drawing.Size(75, 17)
        Me.radiPoundXV.TabIndex = 7
        Me.radiPoundXV.Text = "iPound XV"
        Me.radiPoundXV.UseVisualStyleBackColor = True
        '
        'radCustomerPhone
        '
        Me.radCustomerPhone.AutoSize = True
        Me.radCustomerPhone.Checked = True
        Me.radCustomerPhone.Location = New System.Drawing.Point(18, 107)
        Me.radCustomerPhone.Name = "radCustomerPhone"
        Me.radCustomerPhone.Size = New System.Drawing.Size(103, 17)
        Me.radCustomerPhone.TabIndex = 8
        Me.radCustomerPhone.TabStop = True
        Me.radCustomerPhone.Text = "Customer Phone"
        Me.radCustomerPhone.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chkUnlimitedText)
        Me.GroupBox4.Controls.Add(Me.chkVideoChat)
        Me.GroupBox4.Location = New System.Drawing.Point(308, 29)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(129, 156)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Options"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 456)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "Form1"
        Me.Text = "EZ Phones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMonthlySubtotal As Label
    Friend WithEvents rad800 As RadioButton
    Friend WithEvents rad1500 As RadioButton
    Friend WithEvents radUnlimitedTalk As RadioButton
    Friend WithEvents chkUnlimitedText As CheckBox
    Friend WithEvents chkVideoChat As CheckBox
    Friend WithEvents lblTax As Label
    Friend WithEvents lblMonthyTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radSimsongAG As RadioButton
    Friend WithEvents radiPoundXV As RadioButton
    Friend WithEvents radCustomerPhone As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
End Class
