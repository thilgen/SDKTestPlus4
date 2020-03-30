Public Class frmSDKTestPlus4

    Dim strCompanyFilename As String
    Dim strInXMLFile As String
    Dim strOutXMLFile As String
    Dim strError As String
    Dim strAppName As String
    Dim strOldDrive As String
    Public AuthPrefsDirty As Boolean
    Public ConnPrefsDirty As Boolean

    Public DisplayFile As String

    Private Sub FileError(FileType As String)
        MsgBox("You must select " & FileType & " file.", vbExclamation, "Beta qbXML Test")
    End Sub

    Private Sub Clear_Status_Area()
        lblStatus.Text = ""
        lblStatus.Refresh
    End Sub

    Private Sub EnableAuthFlagsSettings(EnableOrDisable As Boolean)
        AuthFlagsFrame.Enabled = EnableOrDisable
        qbEnterprise.Enabled = EnableOrDisable
        qbPremier.Enabled = EnableOrDisable
        qbPro.Enabled = EnableOrDisable
        qbSimple.Enabled = EnableOrDisable
        qbForceAuthDialog.Enabled = EnableOrDisable
    End Sub

    Public Sub showURL(iFname As String)
        Dim IE1 As New SHDocVw.InternetExplorer
        IE1.Visible = True
        IE1.Navigate(iFname)
    End Sub

    Private Sub cmdCloseConnection_Click()
        CloseConnection(lblStatus)
        cmdBeginSession.Enabled = False
        cmdOpenConnection.Enabled = True
        cmdCloseConnection.Enabled = False
        cmdProcessSubscription.Enabled = False
        txtApplicationName.Enabled = True
    End Sub

    Private Sub cmdEndSession_Click()
        EndSession(lblStatus)
        cmdBeginSession.Enabled = True
        cmdCloseConnection.Enabled = True
        cmdEndSession.Enabled = False
        cmdSendXML.Enabled = False
        sessionPrefsControl(True)
    End Sub

    Private Sub cmdExit_Click()
        End
    End Sub

    Private Sub sessionPrefsControl(state As Boolean)
        SessionPrefsFrame.Enabled = state
        Unattended.Enabled = state
        ReadOnlyCB.Enabled = state
        pdRequired.Enabled = state
        pdOptional.Enabled = state
        pdNotNeeded.Enabled = state
        optDontCare.Enabled = state
        optMultiUser.Enabled = state
        optSingleUser.Enabled = state
    End Sub

    Private Sub cmdProcessSubscription_Click()
        strOutXMLFile = CurDir() & "\SubscriptionResponse.xml"

        strError = SendXMLFile("SubscriptionProcessor", CompanyBrowse.Text,
                         strOutXMLFile, lblStatus)
        If strError = "" Then
            cmdViewOutput.Enabled = True
        End If
    End Sub

    Private Sub cmdSendXML_Click()
        strOutXMLFile = CurDir() & "\QBResponse.xml"
        strError = SendXMLFile("RequestProcessor", CompanyBrowse.Text, strOutXMLFile, lblStatus)
        If strError = "" Then
            cmdViewOutput.Enabled = True
        End If
    End Sub

    'Private Sub optUseCurrentFile_Click()
    '    lstCompanyFile.Refresh
    'End Sub

    Private Sub ConnLocal_Click()
        ConnPrefsDirty = True
        EnableAuthFlagsSettings(True)
    End Sub

    Private Sub ConnLocalUI_Click()
        ConnPrefsDirty = True
        EnableAuthFlagsSettings(True)
    End Sub

    Private Sub ConnNone_Click()
        ConnPrefsDirty = True
        EnableAuthFlagsSettings(True)
    End Sub

    Private Sub ConnQBOE_Click()
        ConnPrefsDirty = True
        EnableAuthFlagsSettings(False)
    End Sub

    Private Sub ConnRemote_Click()
        ConnPrefsDirty = True
        EnableAuthFlagsSettings(False)
    End Sub

    Private Sub Form_Load()
        If (qbEnterprise.Checked Or qbPremier.Checked Or qbPro.Checked Or qbSimple.Checked) Then
            AuthPrefsDirty = True
        Else
            AuthPrefsDirty = False
        End If
        ConnPrefsDirty = False
    End Sub

    Private Sub pdNotNeeded_Click()
        AuthPrefsDirty = True
    End Sub

    Private Sub pdOptional_Click()
        AuthPrefsDirty = True
    End Sub

    Private Sub pdRequired_Click()
        AuthPrefsDirty = True
    End Sub

    Private Sub ReadOnly_Click()
        AuthPrefsDirty = True
    End Sub

    Private Sub RequestFile_Change()
        cmdSendXML.Enabled = (Not CompanyBrowse.Text = "")
        cmdProcessSubscription.Enabled = (Not CompanyBrowse.Text = "")
        cmdViewInput.Enabled = (Not CompanyBrowse.Text = "")
    End Sub

    Private Sub Unattended_Click()
        AuthPrefsDirty = True
    End Sub

    Private Sub CompanyBrowse_Click(sender As Object, e As EventArgs) Handles CompanyBrowse.Click
        OpenFileDialog.Filter = "QuickBooks Files|*.qbw"
        OpenFileDialog.InitialDirectory = "c:\program files\Intuit"
        If DialogResult.OK = OpenFileDialog.ShowDialog() Then
            CompanyFile.Text = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub RequestBrowse_Click(sender As Object, e As EventArgs) Handles RequestBrowse.Click
        OpenFileDialog.Filter = "XML Files|*.xml;*.qbxml"
        OpenFileDialog.InitialDirectory = "../../../../xmlfiles"
        If DialogResult.OK = OpenFileDialog.ShowDialog() Then
            RequestFile.Text = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub cmdOpenConnection_Click(sender As Object, e As EventArgs) Handles cmdOpenConnection.Click
        If txtApplicationName.Text = "" Then
            MsgBox("You must supply an application name before opening a connection")
            Exit Sub
        End If

        strAppName = txtApplicationName.Text
        strError = OpenConnection("", strAppName, lblStatus)

        If strError = "" Then
            cmdBeginSession.Enabled = True
            cmdCloseConnection.Enabled = True
            cmdOpenConnection.Enabled = False
            txtApplicationName.Enabled = False
            cmdProcessSubscription.Enabled = (Not CompanyBrowse.Text = "")
            sessionPrefsControl(True)
            lblStatus.Text = "OpenConnection call successful"
            lblStatus.Refresh()
        End If
    End Sub

    Private Sub cmdBeginSession_Click(sender As Object, e As EventArgs) Handles cmdBeginSession.Click
        Dim strFileMode As String

        If optSingleUser.Checked Then
            strFileMode = "Single"
        ElseIf optMultiUser.Checked Then
            strFileMode = "Multi"
        Else
            strFileMode = "DoNotCare"
        End If

        strError = BeginSession(CompanyFile.Text, strFileMode, lblStatus)

        If strError = "" Then
            cmdBeginSession.Enabled = False
            cmdCloseConnection.Enabled = False
            cmdEndSession.Enabled = True
            sessionPrefsControl(False)
            cmdSendXML.Enabled = (Not CompanyBrowse.Text = "")
        End If
    End Sub

    Private Sub cmdProcessSubscription_Click(sender As Object, e As EventArgs) Handles cmdProcessSubscription.Click
        strOutXMLFile = CurDir() & "\SubscriptionResponse.xml"

        strError = SendXMLFile("SubscriptionProcessor", CompanyBrowse.Text,
                         strOutXMLFile, lblStatus)
        If strError = "" Then
            cmdViewOutput.Enabled = True
        End If
    End Sub

    Private Sub cmdSendXML_Click(sender As Object, e As EventArgs) Handles cmdSendXML.Click
        strOutXMLFile = CurDir() & "\QBResponse.xml"
        strError = SendXMLFile("RequestProcessor", RequestFile.Text, strOutXMLFile, lblStatus)
        If strError = "" Then
            cmdViewOutput.Enabled = True
        End If
    End Sub

    Private Sub cmdViewInput_Click(sender As Object, e As EventArgs) Handles cmdViewInput.Click
        showURL(RequestFile.Text)
    End Sub

    Private Sub cmdViewOutput_Click(sender As Object, e As EventArgs) Handles cmdViewOutput.Click
        showURL(strOutXMLFile)
    End Sub

    Private Sub cmdEndSession_Click(sender As Object, e As EventArgs) Handles cmdEndSession.Click
        EndSession(lblStatus)
        cmdBeginSession.Enabled = True
        cmdCloseConnection.Enabled = True
        cmdEndSession.Enabled = False
        cmdSendXML.Enabled = False
        sessionPrefsControl(True)
    End Sub

    Private Sub cmdCloseConnection_Click(sender As Object, e As EventArgs) Handles cmdCloseConnection.Click
        CloseConnection(lblStatus)
        cmdBeginSession.Enabled = False
        cmdOpenConnection.Enabled = True
        cmdCloseConnection.Enabled = False
        cmdProcessSubscription.Enabled = False
        txtApplicationName.Enabled = True
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        End
    End Sub
End Class
