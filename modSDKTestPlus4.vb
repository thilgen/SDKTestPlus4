Public Module modSDKTestPlus4

    Dim CompanyFilename As String
    Dim InXMLFile As String
    Dim OutXMLFile As String
    Dim InXMLString As String
    Dim OutXMLString As String
    Public DisplayFile As String

    Dim booSetDone As Boolean
    Dim booConnected As Boolean
    Dim booSessionBegun As Boolean
    Dim booIsRemote As Boolean

    Dim strTicket As String

    Dim qbXMLCOM As QBXMLRP2Lib.RequestProcessor2
    Public Function OpenConnection(
                   strAppID As String,
                   strAppName As String,
                   lblStatusOutput As TextBox) As String

        Dim strStatus As String

        If booSetDone = False Then
            qbXMLCOM = New QBXMLRP2Lib.RequestProcessor2
            booSetDone = True
        End If

        lblStatusOutput.Text = ""
        lblStatusOutput.ForeColor = Color.DarkRed
        lblStatusOutput.Text = "Starting to Open Connection"
        lblStatusOutput.Refresh()

        On Error GoTo ErrorProcessing

        If frmSDKTestPlus4.ConnPrefsDirty Then
            booIsRemote = False
            Dim connPref As QBXMLRP2Lib.QBXMLRPConnectionType
            connPref = QBXMLRP2Lib.QBXMLRPConnectionType.unknown
            If (frmSDKTestPlus4.ConnLocal.Checked) Then
                connPref = QBXMLRP2Lib.QBXMLRPConnectionType.localQBD
            ElseIf (frmSDKTestPlus4.ConnLocal.Checked) Then
                connPref = QBXMLRP2Lib.QBXMLRPConnectionType.localQBDLaunchUI
            ElseIf (frmSDKTestPlus4.ConnRemote.Checked) Then
                connPref = QBXMLRP2Lib.QBXMLRPConnectionType.remoteQBD
                booIsRemote = True
            ElseIf (frmSDKTestPlus4.ConnQBOE.Checked) Then
                connPref = QBXMLRP2Lib.QBXMLRPConnectionType.remoteQBOE
                booIsRemote = True
            End If
            qbXMLCOM.OpenConnection2(strAppID, strAppName, connPref)
        Else
            qbXMLCOM.OpenConnection(strAppID, strAppName)
        End If

        OpenConnection = Nothing
        booConnected = True
        Exit Function

ErrorProcessing:
        lblStatusOutput.Text = ""
        lblStatusOutput.ForeColor = Color.Red
        lblStatusOutput.Text = Err.Number & "  " & Err.Description
        lblStatusOutput.Refresh()
        OpenConnection = Err.Description
    End Function

    Public Sub CloseConnection(lblStatusOutput As TextBox)
        On Error GoTo ErrorDisplay

        lblStatusOutput.Text = ""
        lblStatusOutput.ForeColor = Color.DarkRed
        lblStatusOutput.Text = "Starting to Close Connection"
        lblStatusOutput.Refresh()

        If booConnected Then
            qbXMLCOM.CloseConnection()
            booConnected = False
        End If

        lblStatusOutput.Text = ""
        lblStatusOutput.ForeColor = Color.DarkRed
        lblStatusOutput.Text = "Not Connected"
        lblStatusOutput.Refresh()

        Exit Sub

ErrorDisplay:
        MsgBox(Err.Description)
    End Sub

    Private Function XMLFileToXMLString(XMLFileName As String) As String
        'Clear out the XML String
        Dim FileNum As Integer
        Dim strInput As String
        Dim XMLString As String
        XMLString = ""

        'Open the file, read each line and concatonate each to
        'the XML String
        FileNum = FreeFile()
        FileOpen(FileNum, XMLFileName, OpenMode.Input)
        Do Until EOF(FileNum)
            strInput = LineInput(FileNum)
            XMLString = XMLString & strInput
        Loop
        FileClose(FileNum)
        Return XMLString
    End Function

    Public Function SendXMLFile(strProcessor As String,
                                strInXMLFile As String,
                                strOutXMLFile As String,
                                lblStatus As TextBox) As String
        Dim strInXML As String

        Dim strOutXML As String

        strInXML = XMLFileToXMLString(strInXMLFile)

        On Error GoTo ErrorDisplay

        lblStatus.ForeColor = Color.LimeGreen
        lblStatus.Text = "Your request is being processed"
        lblStatus.Refresh()

        'Process the XML
        If strProcessor = "RequestProcessor" Then
            strOutXML = qbXMLCOM.ProcessRequest(strTicket, strInXML)
        Else
            strOutXML = qbXMLCOM.ProcessSubscription(strInXML)
        End If

        PrettyPrintXMLToFile(strOutXML, strOutXMLFile)

        lblStatus.Text = ""
        lblStatus.ForeColor = Color.DarkRed
        lblStatus.Text = "Processing complete"
        lblStatus.Refresh()
        SendXMLFile = Nothing
        Exit Function

ErrorDisplay:
        '   MsgBox Err.Description
        lblStatus.Text = ""
        lblStatus.ForeColor = Color.Red
        lblStatus.Text = Err.Number & "  " & Err.Description
        lblStatus.Refresh()
        SendXMLFile = Err.Description
    End Function

    Public Sub PrettyPrintXMLToFile(XMLString As String, XMLFile As String)
        Dim SplitXMLString() As String
        Dim IndentString As String
        Dim FileNum As Integer

        Dim SplitIndex

        IndentString = ""

        FileNum = FreeFile()
        FileOpen(FileNum, XMLFile, OpenMode.Output)

        'Remove the linefeeds from the XML output string
        XMLString = Replace(XMLString, vbLf, vbNullString)

        SplitXMLString = Split(XMLString, "<")

        'We're expecting the first character of the XML output to be "<"
        'which result in an empty first array element, so skip it.
        SplitIndex = LBound(SplitXMLString) + 1

        Do
            If Strings.Left(SplitXMLString(SplitIndex), 1) = "/" Then
                IndentString = Strings.Left(IndentString, Len(IndentString) - 3)
                Print(FileNum, IndentString & "<" & SplitXMLString(SplitIndex))
                SplitIndex = SplitIndex + 1
            ElseIf Strings.Left(SplitXMLString(SplitIndex + 1), 1) = "/" Then
                If InStr(1, Strings.Left(SplitXMLString(SplitIndex), InStr(1, SplitXMLString(SplitIndex), ">")), " ") > 0 Then
                    Print(FileNum, IndentString & "<" & SplitXMLString(SplitIndex))
                    SplitIndex = SplitIndex + 1
                Else
                    Print(FileNum, IndentString & "<" & SplitXMLString(SplitIndex) & "<" & SplitXMLString(SplitIndex + 1))
                    SplitIndex = SplitIndex + 2
                End If
            Else
                Print(FileNum, IndentString & "<" & SplitXMLString(SplitIndex))
                If SplitXMLString(SplitIndex) <> "?xml version=""1.0"" ?>" And SplitXMLString(SplitIndex) <> "!DOCTYPE QBXML PUBLIC '-//INTUIT//DTD QBXML QBD 1.0//EN' >" And Strings.Right(SplitXMLString(SplitIndex), 2) <> "/>" Then
                    IndentString = IndentString & "   "
                End If
                SplitIndex = SplitIndex + 1
            End If
        Loop Until SplitIndex >= UBound(SplitXMLString)

        If Strings.Left(SplitXMLString(UBound(SplitXMLString)), 1) = "/" Then
            IndentString = Strings.Left(IndentString, Len(IndentString) - 3)
        End If

        Print(FileNum, IndentString & "<" & SplitXMLString(UBound(SplitXMLString)))

        FileClose(FileNum)
    End Sub

    Public Function BeginSession(
                       strCompanyFilename As String,
                       strFileMode As String,
                       lblStatusOutput As TextBox) As String

        On Error GoTo ErrSetPrefs
        Dim authFlags As Long

        ' remoteQBD and remoteQBOE don't allow AuthFlags setting
        If (frmSDKTestPlus4.AuthPrefsDirty And Not booIsRemote) Then
            lblStatusOutput.Text = ""
            lblStatusOutput.ForeColor = Color.DarkRed
            lblStatusOutput.Text = "Starting to Set Auth Preferences"
            lblStatusOutput.Refresh()
            Dim prefs As QBXMLRP2Lib.AuthPreferences
            prefs = qbXMLCOM.AuthPreferences
            If (frmSDKTestPlus4.Unattended.Checked) Then
                prefs.PutUnattendedModePref(QBXMLRP2Lib.QBXMLRPUnattendedModePrefType.umpRequired)
            Else
                prefs.PutUnattendedModePref(QBXMLRP2Lib.QBXMLRPUnattendedModePrefType.umpOptional)
            End If

            authFlags = 0
            If (frmSDKTestPlus4.qbEnterprise.Checked) Then
                authFlags = authFlags Or &H8&
            End If

            If (frmSDKTestPlus4.qbPremier.Checked) Then
                authFlags = authFlags Or &H4&
            End If

            If (frmSDKTestPlus4.qbPro.Checked) Then
                authFlags = authFlags Or &H2&
            End If

            If (frmSDKTestPlus4.qbSimple.Checked) Then
                authFlags = authFlags Or &H1&
            End If

            If (frmSDKTestPlus4.qbForceAuthDialog.Checked) Then
                authFlags = authFlags Or &H80000000
            End If

            prefs.PutAuthFlags(authFlags)

            prefs.PutIsReadOnly(frmSDKTestPlus4.ReadOnlyCB.Checked)

            If (frmSDKTestPlus4.pdRequired.Checked) Then
                prefs.PutPersonalDataPref(QBXMLRP2Lib.QBXMLRPPersonalDataPrefType.pdpRequired)
            ElseIf (frmSDKTestPlus4.pdNotNeeded.Checked) Then
                prefs.PutPersonalDataPref(QBXMLRP2Lib.QBXMLRPPersonalDataPrefType.pdpNotNeeded)
            Else
                prefs.PutPersonalDataPref(QBXMLRP2Lib.QBXMLRPPersonalDataPrefType.pdpOptional)
            End If
        End If

        On Error GoTo ErrBeginSession
        lblStatusOutput.Text = ""
        lblStatusOutput.ForeColor = Color.DarkRed
        lblStatusOutput.Text = "Starting to Begin Session"
        lblStatusOutput.Refresh()

        Dim openMode As QBXMLRP2Lib.QBFileMode
        If strFileMode = "Single" Then
            openMode = QBXMLRP2Lib.QBFileMode.qbFileOpenSingleUser
        ElseIf strFileMode = "Multi" Then
            openMode = QBXMLRP2Lib.QBFileMode.qbFileOpenMultiUser
        Else
            openMode = QBXMLRP2Lib.QBFileMode.qbFileOpenDoNotCare
        End If

        strTicket = qbXMLCOM.BeginSession(strCompanyFilename, openMode)

        On Error GoTo ErrGetFileName

        If strCompanyFilename = "" Then
            strCompanyFilename = qbXMLCOM.GetCurrentCompanyFileName(strTicket)
        End If

        lblStatusOutput.Text = ""
        lblStatusOutput.ForeColor = Color.DarkRed
        lblStatusOutput.Text = "Session begun with " & strCompanyFilename
        lblStatusOutput.Refresh()
        booSessionBegun = True
        BeginSession = Nothing
        Exit Function

ErrSetPrefs:
        lblStatusOutput.Text = ""
        lblStatusOutput.ForeColor = Color.Red
        lblStatusOutput.Text = Err.Number & " " & Err.Description
        lblStatusOutput.Refresh()
        BeginSession = Err.Description
        Exit Function

ErrBeginSession:
        lblStatusOutput.Text = ""
        lblStatusOutput.ForeColor = Color.Red
        lblStatusOutput.Text = Err.Number & "  " & Err.Description
        lblStatusOutput.Refresh()
        BeginSession = Err.Description
        Exit Function

ErrGetFileName:
        lblStatusOutput.Text = ""
        lblStatusOutput.ForeColor = Color.Red
        lblStatusOutput.Text = Err.Number & "  " & Err.Description
        lblStatusOutput.Refresh()
        BeginSession = Err.Description
        Exit Function

    End Function

    Public Sub EndSession(lblStatusOutput As TextBox)

        On Error GoTo ErrorDisplay

        lblStatusOutput.Text = ""
        lblStatusOutput.ForeColor = Color.DarkRed
        lblStatusOutput.Text = "Starting to End Session"
        lblStatusOutput.Refresh()

        If booSessionBegun Then
            qbXMLCOM.EndSession(strTicket)
            booSessionBegun = False
        End If

        lblStatusOutput.Text = ""
        lblStatusOutput.ForeColor = Color.DarkRed
        lblStatusOutput.Text = "Session Ended"
        lblStatusOutput.Refresh()
        Exit Sub

ErrorDisplay:
        MsgBox(Err.Description)
    End Sub


End Module
