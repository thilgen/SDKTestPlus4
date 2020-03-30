<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSDKTestPlus4
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
        Me.ReadOnlyCB = New System.Windows.Forms.CheckBox()
        Me.AuthFlagsFrame = New System.Windows.Forms.GroupBox()
        Me.qbEnterprise = New System.Windows.Forms.CheckBox()
        Me.qbPremier = New System.Windows.Forms.CheckBox()
        Me.qbPro = New System.Windows.Forms.CheckBox()
        Me.qbSimple = New System.Windows.Forms.CheckBox()
        Me.qbForceAuthDialog = New System.Windows.Forms.CheckBox()
        Me.lblStatus = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApplicationName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CompanyFile = New System.Windows.Forms.TextBox()
        Me.RequestBrowse = New System.Windows.Forms.Button()
        Me.CompanyBrowse = New System.Windows.Forms.Button()
        Me.RequestFile = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ConnFrame = New System.Windows.Forms.GroupBox()
        Me.ConnQBOE = New System.Windows.Forms.RadioButton()
        Me.ConnLocalUI = New System.Windows.Forms.RadioButton()
        Me.ConnRemote = New System.Windows.Forms.RadioButton()
        Me.ConnLocal = New System.Windows.Forms.RadioButton()
        Me.ConnNone = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.SessionPrefsFrame = New System.Windows.Forms.GroupBox()
        Me.Unattended = New System.Windows.Forms.CheckBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optMultiUser = New System.Windows.Forms.RadioButton()
        Me.optSingleUser = New System.Windows.Forms.RadioButton()
        Me.optDontCare = New System.Windows.Forms.RadioButton()
        Me.pdFrame = New System.Windows.Forms.GroupBox()
        Me.pdRequired = New System.Windows.Forms.RadioButton()
        Me.pdOptional = New System.Windows.Forms.RadioButton()
        Me.pdNotNeeded = New System.Windows.Forms.RadioButton()
        Me.cmdViewInput = New System.Windows.Forms.Button()
        Me.cmdViewOutput = New System.Windows.Forms.Button()
        Me.cmdOpenConnection = New System.Windows.Forms.Button()
        Me.cmdBeginSession = New System.Windows.Forms.Button()
        Me.cmdProcessSubscription = New System.Windows.Forms.Button()
        Me.cmdSendXML = New System.Windows.Forms.Button()
        Me.cmdEndSession = New System.Windows.Forms.Button()
        Me.cmdCloseConnection = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.AuthFlagsFrame.SuspendLayout()
        Me.ConnFrame.SuspendLayout()
        Me.SessionPrefsFrame.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.pdFrame.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReadOnlyCB
        '
        Me.ReadOnlyCB.AutoSize = True
        Me.ReadOnlyCB.Enabled = False
        Me.ReadOnlyCB.Location = New System.Drawing.Point(112, 16)
        Me.ReadOnlyCB.Name = "ReadOnlyCB"
        Me.ReadOnlyCB.Size = New System.Drawing.Size(74, 17)
        Me.ReadOnlyCB.TabIndex = 25
        Me.ReadOnlyCB.Text = "Read-only"
        Me.ReadOnlyCB.UseVisualStyleBackColor = True
        '
        'AuthFlagsFrame
        '
        Me.AuthFlagsFrame.Controls.Add(Me.qbEnterprise)
        Me.AuthFlagsFrame.Controls.Add(Me.qbPremier)
        Me.AuthFlagsFrame.Controls.Add(Me.qbPro)
        Me.AuthFlagsFrame.Controls.Add(Me.qbSimple)
        Me.AuthFlagsFrame.Controls.Add(Me.qbForceAuthDialog)
        Me.AuthFlagsFrame.Location = New System.Drawing.Point(16, 120)
        Me.AuthFlagsFrame.Name = "AuthFlagsFrame"
        Me.AuthFlagsFrame.Size = New System.Drawing.Size(129, 137)
        Me.AuthFlagsFrame.TabIndex = 35
        Me.AuthFlagsFrame.TabStop = False
        Me.AuthFlagsFrame.Text = "AuthFlags"
        '
        'qbEnterprise
        '
        Me.qbEnterprise.AutoSize = True
        Me.qbEnterprise.Checked = True
        Me.qbEnterprise.CheckState = System.Windows.Forms.CheckState.Checked
        Me.qbEnterprise.Location = New System.Drawing.Point(8, 16)
        Me.qbEnterprise.Name = "qbEnterprise"
        Me.qbEnterprise.Size = New System.Drawing.Size(91, 17)
        Me.qbEnterprise.TabIndex = 36
        Me.qbEnterprise.Text = "QB Enterprise"
        Me.qbEnterprise.UseVisualStyleBackColor = True
        '
        'qbPremier
        '
        Me.qbPremier.AutoSize = True
        Me.qbPremier.Checked = True
        Me.qbPremier.CheckState = System.Windows.Forms.CheckState.Checked
        Me.qbPremier.Location = New System.Drawing.Point(8, 40)
        Me.qbPremier.Name = "qbPremier"
        Me.qbPremier.Size = New System.Drawing.Size(79, 17)
        Me.qbPremier.TabIndex = 37
        Me.qbPremier.Text = "QB Premier"
        Me.qbPremier.UseVisualStyleBackColor = True
        '
        'qbPro
        '
        Me.qbPro.AutoSize = True
        Me.qbPro.Checked = True
        Me.qbPro.CheckState = System.Windows.Forms.CheckState.Checked
        Me.qbPro.Location = New System.Drawing.Point(8, 64)
        Me.qbPro.Name = "qbPro"
        Me.qbPro.Size = New System.Drawing.Size(60, 17)
        Me.qbPro.TabIndex = 38
        Me.qbPro.Text = "QB Pro"
        Me.qbPro.UseVisualStyleBackColor = True
        '
        'qbSimple
        '
        Me.qbSimple.AutoSize = True
        Me.qbSimple.Location = New System.Drawing.Point(8, 88)
        Me.qbSimple.Name = "qbSimple"
        Me.qbSimple.Size = New System.Drawing.Size(100, 17)
        Me.qbSimple.TabIndex = 39
        Me.qbSimple.Text = "QB Simple Start"
        Me.qbSimple.UseVisualStyleBackColor = True
        '
        'qbForceAuthDialog
        '
        Me.qbForceAuthDialog.AutoSize = True
        Me.qbForceAuthDialog.Location = New System.Drawing.Point(8, 112)
        Me.qbForceAuthDialog.Name = "qbForceAuthDialog"
        Me.qbForceAuthDialog.Size = New System.Drawing.Size(108, 17)
        Me.qbForceAuthDialog.TabIndex = 40
        Me.qbForceAuthDialog.Text = "Force auth dialog"
        Me.qbForceAuthDialog.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(16, 400)
        Me.lblStatus.Multiline = True
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(497, 121)
        Me.lblStatus.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Application Name:"
        '
        'txtApplicationName
        '
        Me.txtApplicationName.Location = New System.Drawing.Point(103, 12)
        Me.txtApplicationName.Name = "txtApplicationName"
        Me.txtApplicationName.Size = New System.Drawing.Size(100, 20)
        Me.txtApplicationName.TabIndex = 43
        Me.txtApplicationName.Text = "SDKTest Plus 4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Company File: (leave blank to use current open file)"
        '
        'CompanyFile
        '
        Me.CompanyFile.Location = New System.Drawing.Point(16, 53)
        Me.CompanyFile.Name = "CompanyFile"
        Me.CompanyFile.Size = New System.Drawing.Size(497, 20)
        Me.CompanyFile.TabIndex = 45
        '
        'RequestBrowse
        '
        Me.RequestBrowse.Location = New System.Drawing.Point(521, 88)
        Me.RequestBrowse.Name = "RequestBrowse"
        Me.RequestBrowse.Size = New System.Drawing.Size(113, 25)
        Me.RequestBrowse.TabIndex = 16
        Me.RequestBrowse.Text = "Browse..."
        Me.RequestBrowse.UseVisualStyleBackColor = True
        '
        'CompanyBrowse
        '
        Me.CompanyBrowse.Location = New System.Drawing.Point(521, 48)
        Me.CompanyBrowse.Name = "CompanyBrowse"
        Me.CompanyBrowse.Size = New System.Drawing.Size(113, 25)
        Me.CompanyBrowse.TabIndex = 13
        Me.CompanyBrowse.Text = "Browse..."
        Me.CompanyBrowse.UseVisualStyleBackColor = True
        '
        'RequestFile
        '
        Me.RequestFile.Location = New System.Drawing.Point(16, 93)
        Me.RequestFile.Name = "RequestFile"
        Me.RequestFile.Size = New System.Drawing.Size(497, 20)
        Me.RequestFile.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Request File:"
        '
        'ConnFrame
        '
        Me.ConnFrame.Controls.Add(Me.ConnQBOE)
        Me.ConnFrame.Controls.Add(Me.ConnLocalUI)
        Me.ConnFrame.Controls.Add(Me.ConnRemote)
        Me.ConnFrame.Controls.Add(Me.ConnLocal)
        Me.ConnFrame.Controls.Add(Me.ConnNone)
        Me.ConnFrame.Location = New System.Drawing.Point(168, 120)
        Me.ConnFrame.Name = "ConnFrame"
        Me.ConnFrame.Size = New System.Drawing.Size(105, 137)
        Me.ConnFrame.TabIndex = 517
        Me.ConnFrame.TabStop = False
        Me.ConnFrame.Text = "Connection Type"
        '
        'ConnQBOE
        '
        Me.ConnQBOE.AutoSize = True
        Me.ConnQBOE.Location = New System.Drawing.Point(8, 112)
        Me.ConnQBOE.Name = "ConnQBOE"
        Me.ConnQBOE.Size = New System.Drawing.Size(55, 17)
        Me.ConnQBOE.TabIndex = 21
        Me.ConnQBOE.Text = "QBOE"
        Me.ConnQBOE.UseVisualStyleBackColor = True
        '
        'ConnLocalUI
        '
        Me.ConnLocalUI.AutoSize = True
        Me.ConnLocalUI.Location = New System.Drawing.Point(8, 88)
        Me.ConnLocalUI.Name = "ConnLocalUI"
        Me.ConnLocalUI.Size = New System.Drawing.Size(87, 17)
        Me.ConnLocalUI.TabIndex = 22
        Me.ConnLocalUI.Text = "Local with UI"
        Me.ConnLocalUI.UseVisualStyleBackColor = True
        '
        'ConnRemote
        '
        Me.ConnRemote.AutoSize = True
        Me.ConnRemote.Location = New System.Drawing.Point(8, 64)
        Me.ConnRemote.Name = "ConnRemote"
        Me.ConnRemote.Size = New System.Drawing.Size(80, 17)
        Me.ConnRemote.TabIndex = 20
        Me.ConnRemote.Text = "Remote QB"
        Me.ConnRemote.UseVisualStyleBackColor = True
        '
        'ConnLocal
        '
        Me.ConnLocal.AutoSize = True
        Me.ConnLocal.Location = New System.Drawing.Point(8, 40)
        Me.ConnLocal.Name = "ConnLocal"
        Me.ConnLocal.Size = New System.Drawing.Size(69, 17)
        Me.ConnLocal.TabIndex = 19
        Me.ConnLocal.Text = "Local QB"
        Me.ConnLocal.UseVisualStyleBackColor = True
        '
        'ConnNone
        '
        Me.ConnNone.AutoSize = True
        Me.ConnNone.Checked = True
        Me.ConnNone.Location = New System.Drawing.Point(8, 16)
        Me.ConnNone.Name = "ConnNone"
        Me.ConnNone.Size = New System.Drawing.Size(61, 17)
        Me.ConnNone.TabIndex = 18
        Me.ConnNone.TabStop = True
        Me.ConnNone.Text = "No Pref"
        Me.ConnNone.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Status:"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(519, 483)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(113, 38)
        Me.cmdExit.TabIndex = 51
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'SessionPrefsFrame
        '
        Me.SessionPrefsFrame.Controls.Add(Me.Unattended)
        Me.SessionPrefsFrame.Controls.Add(Me.ReadOnlyCB)
        Me.SessionPrefsFrame.Controls.Add(Me.Frame1)
        Me.SessionPrefsFrame.Controls.Add(Me.pdFrame)
        Me.SessionPrefsFrame.Location = New System.Drawing.Point(296, 120)
        Me.SessionPrefsFrame.Name = "SessionPrefsFrame"
        Me.SessionPrefsFrame.Size = New System.Drawing.Size(217, 137)
        Me.SessionPrefsFrame.TabIndex = 23
        Me.SessionPrefsFrame.TabStop = False
        Me.SessionPrefsFrame.Text = "Session Prefs"
        '
        'Unattended
        '
        Me.Unattended.AutoSize = True
        Me.Unattended.Enabled = False
        Me.Unattended.Location = New System.Drawing.Point(8, 16)
        Me.Unattended.Name = "Unattended"
        Me.Unattended.Size = New System.Drawing.Size(82, 17)
        Me.Unattended.TabIndex = 24
        Me.Unattended.Text = "Unattended"
        Me.Unattended.UseVisualStyleBackColor = True
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.optMultiUser)
        Me.Frame1.Controls.Add(Me.optSingleUser)
        Me.Frame1.Controls.Add(Me.optDontCare)
        Me.Frame1.Location = New System.Drawing.Point(112, 40)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(97, 89)
        Me.Frame1.TabIndex = 30
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "File Mode"
        '
        'optMultiUser
        '
        Me.optMultiUser.AutoSize = True
        Me.optMultiUser.Enabled = False
        Me.optMultiUser.Location = New System.Drawing.Point(8, 16)
        Me.optMultiUser.Name = "optMultiUser"
        Me.optMultiUser.Size = New System.Drawing.Size(72, 17)
        Me.optMultiUser.TabIndex = 32
        Me.optMultiUser.TabStop = True
        Me.optMultiUser.Text = "Multi-User"
        Me.optMultiUser.UseVisualStyleBackColor = True
        '
        'optSingleUser
        '
        Me.optSingleUser.AutoSize = True
        Me.optSingleUser.Enabled = False
        Me.optSingleUser.Location = New System.Drawing.Point(8, 40)
        Me.optSingleUser.Name = "optSingleUser"
        Me.optSingleUser.Size = New System.Drawing.Size(79, 17)
        Me.optSingleUser.TabIndex = 31
        Me.optSingleUser.TabStop = True
        Me.optSingleUser.Text = "Single User"
        Me.optSingleUser.UseVisualStyleBackColor = True
        '
        'optDontCare
        '
        Me.optDontCare.AutoSize = True
        Me.optDontCare.Enabled = False
        Me.optDontCare.Location = New System.Drawing.Point(8, 64)
        Me.optDontCare.Name = "optDontCare"
        Me.optDontCare.Size = New System.Drawing.Size(75, 17)
        Me.optDontCare.TabIndex = 33
        Me.optDontCare.TabStop = True
        Me.optDontCare.Text = "Don't Care"
        Me.optDontCare.UseVisualStyleBackColor = True
        '
        'pdFrame
        '
        Me.pdFrame.Controls.Add(Me.pdRequired)
        Me.pdFrame.Controls.Add(Me.pdOptional)
        Me.pdFrame.Controls.Add(Me.pdNotNeeded)
        Me.pdFrame.Location = New System.Drawing.Point(8, 40)
        Me.pdFrame.Name = "pdFrame"
        Me.pdFrame.Size = New System.Drawing.Size(97, 89)
        Me.pdFrame.TabIndex = 26
        Me.pdFrame.TabStop = False
        Me.pdFrame.Text = "Personal Data"
        '
        'pdRequired
        '
        Me.pdRequired.AutoSize = True
        Me.pdRequired.Enabled = False
        Me.pdRequired.Location = New System.Drawing.Point(8, 16)
        Me.pdRequired.Name = "pdRequired"
        Me.pdRequired.Size = New System.Drawing.Size(68, 17)
        Me.pdRequired.TabIndex = 27
        Me.pdRequired.TabStop = True
        Me.pdRequired.Text = "Required"
        Me.pdRequired.UseVisualStyleBackColor = True
        '
        'pdOptional
        '
        Me.pdOptional.AutoSize = True
        Me.pdOptional.Enabled = False
        Me.pdOptional.Location = New System.Drawing.Point(8, 40)
        Me.pdOptional.Name = "pdOptional"
        Me.pdOptional.Size = New System.Drawing.Size(64, 17)
        Me.pdOptional.TabIndex = 28
        Me.pdOptional.TabStop = True
        Me.pdOptional.Text = "Optional"
        Me.pdOptional.UseVisualStyleBackColor = True
        '
        'pdNotNeeded
        '
        Me.pdNotNeeded.AutoSize = True
        Me.pdNotNeeded.Enabled = False
        Me.pdNotNeeded.Location = New System.Drawing.Point(8, 64)
        Me.pdNotNeeded.Name = "pdNotNeeded"
        Me.pdNotNeeded.Size = New System.Drawing.Size(83, 17)
        Me.pdNotNeeded.TabIndex = 29
        Me.pdNotNeeded.TabStop = True
        Me.pdNotNeeded.Text = "Not Needed"
        Me.pdNotNeeded.UseVisualStyleBackColor = True
        '
        'cmdViewInput
        '
        Me.cmdViewInput.Location = New System.Drawing.Point(521, 202)
        Me.cmdViewInput.Name = "cmdViewInput"
        Me.cmdViewInput.Size = New System.Drawing.Size(113, 23)
        Me.cmdViewInput.TabIndex = 53
        Me.cmdViewInput.Text = "View Input"
        Me.cmdViewInput.UseVisualStyleBackColor = True
        '
        'cmdViewOutput
        '
        Me.cmdViewOutput.Location = New System.Drawing.Point(521, 234)
        Me.cmdViewOutput.Name = "cmdViewOutput"
        Me.cmdViewOutput.Size = New System.Drawing.Size(113, 23)
        Me.cmdViewOutput.TabIndex = 54
        Me.cmdViewOutput.Text = "View Output"
        Me.cmdViewOutput.UseVisualStyleBackColor = True
        '
        'cmdOpenConnection
        '
        Me.cmdOpenConnection.Location = New System.Drawing.Point(15, 276)
        Me.cmdOpenConnection.Name = "cmdOpenConnection"
        Me.cmdOpenConnection.Size = New System.Drawing.Size(113, 38)
        Me.cmdOpenConnection.TabIndex = 518
        Me.cmdOpenConnection.Text = "Open Connection"
        Me.cmdOpenConnection.UseVisualStyleBackColor = True
        '
        'cmdBeginSession
        '
        Me.cmdBeginSession.Location = New System.Drawing.Point(183, 276)
        Me.cmdBeginSession.Name = "cmdBeginSession"
        Me.cmdBeginSession.Size = New System.Drawing.Size(113, 38)
        Me.cmdBeginSession.TabIndex = 519
        Me.cmdBeginSession.Text = "Begin Session"
        Me.cmdBeginSession.UseVisualStyleBackColor = True
        '
        'cmdProcessSubscription
        '
        Me.cmdProcessSubscription.Location = New System.Drawing.Point(183, 328)
        Me.cmdProcessSubscription.Name = "cmdProcessSubscription"
        Me.cmdProcessSubscription.Size = New System.Drawing.Size(113, 38)
        Me.cmdProcessSubscription.TabIndex = 520
        Me.cmdProcessSubscription.Text = "Send XML to Sub Processor"
        Me.cmdProcessSubscription.UseVisualStyleBackColor = True
        '
        'cmdSendXML
        '
        Me.cmdSendXML.Location = New System.Drawing.Point(351, 276)
        Me.cmdSendXML.Name = "cmdSendXML"
        Me.cmdSendXML.Size = New System.Drawing.Size(113, 38)
        Me.cmdSendXML.TabIndex = 521
        Me.cmdSendXML.Text = "Send XML to Request Processor"
        Me.cmdSendXML.UseVisualStyleBackColor = True
        '
        'cmdEndSession
        '
        Me.cmdEndSession.Location = New System.Drawing.Point(519, 276)
        Me.cmdEndSession.Name = "cmdEndSession"
        Me.cmdEndSession.Size = New System.Drawing.Size(113, 38)
        Me.cmdEndSession.TabIndex = 522
        Me.cmdEndSession.Text = "End Session"
        Me.cmdEndSession.UseVisualStyleBackColor = True
        '
        'cmdCloseConnection
        '
        Me.cmdCloseConnection.Location = New System.Drawing.Point(519, 328)
        Me.cmdCloseConnection.Name = "cmdCloseConnection"
        Me.cmdCloseConnection.Size = New System.Drawing.Size(113, 38)
        Me.cmdCloseConnection.TabIndex = 523
        Me.cmdCloseConnection.Text = "Close Connection"
        Me.cmdCloseConnection.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'frmSDKTestPlus4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 531)
        Me.Controls.Add(Me.cmdCloseConnection)
        Me.Controls.Add(Me.cmdEndSession)
        Me.Controls.Add(Me.cmdSendXML)
        Me.Controls.Add(Me.cmdProcessSubscription)
        Me.Controls.Add(Me.cmdBeginSession)
        Me.Controls.Add(Me.cmdOpenConnection)
        Me.Controls.Add(Me.cmdViewOutput)
        Me.Controls.Add(Me.cmdViewInput)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ConnFrame)
        Me.Controls.Add(Me.RequestFile)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CompanyBrowse)
        Me.Controls.Add(Me.RequestBrowse)
        Me.Controls.Add(Me.CompanyFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtApplicationName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.AuthFlagsFrame)
        Me.Controls.Add(Me.SessionPrefsFrame)
        Me.Location = New System.Drawing.Point(194, 146)
        Me.Name = "frmSDKTestPlus4"
        Me.Text = "Form1"
        Me.AuthFlagsFrame.ResumeLayout(False)
        Me.AuthFlagsFrame.PerformLayout()
        Me.ConnFrame.ResumeLayout(False)
        Me.ConnFrame.PerformLayout()
        Me.SessionPrefsFrame.ResumeLayout(False)
        Me.SessionPrefsFrame.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.pdFrame.ResumeLayout(False)
        Me.pdFrame.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReadOnlyCB As CheckBox
    Friend WithEvents AuthFlagsFrame As GroupBox
    Friend WithEvents qbEnterprise As CheckBox
    Friend WithEvents qbPremier As CheckBox
    Friend WithEvents qbPro As CheckBox
    Friend WithEvents qbSimple As CheckBox
    Friend WithEvents qbForceAuthDialog As CheckBox
    Friend WithEvents lblStatus As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtApplicationName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CompanyFile As TextBox
    Friend WithEvents RequestBrowse As Button
    Friend WithEvents CompanyBrowse As Button
    Friend WithEvents RequestFile As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ConnFrame As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdExit As Button
    Friend WithEvents SessionPrefsFrame As GroupBox
    Friend WithEvents Unattended As CheckBox
    Friend WithEvents pdFrame As GroupBox
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents cmdViewInput As Button
    Friend WithEvents cmdViewOutput As Button
    Friend WithEvents ConnQBOE As RadioButton
    Friend WithEvents ConnLocalUI As RadioButton
    Friend WithEvents ConnRemote As RadioButton
    Friend WithEvents ConnLocal As RadioButton
    Friend WithEvents ConnNone As RadioButton
    Friend WithEvents optDontCare As RadioButton
    Friend WithEvents optSingleUser As RadioButton
    Friend WithEvents optMultiUser As RadioButton
    Friend WithEvents pdNotNeeded As RadioButton
    Friend WithEvents pdOptional As RadioButton
    Friend WithEvents pdRequired As RadioButton
    Friend WithEvents cmdOpenConnection As Button
    Friend WithEvents cmdBeginSession As Button
    Friend WithEvents cmdProcessSubscription As Button
    Friend WithEvents cmdSendXML As Button
    Friend WithEvents cmdEndSession As Button
    Friend WithEvents cmdCloseConnection As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
