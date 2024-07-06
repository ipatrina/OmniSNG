Imports System.Collections.Specialized
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Xml

Public Class Dispatch

    Public Property Remark As String

    Public Shared Authorization As String = ""
    Public Shared CarrierRecentList As New List(Of String)
    Public Shared DataTable As New NameValueCollection
    Public Shared DispatchConfiguration As New NameValueCollection
    Public Shared GetWebpageProxy As New WebProxy()
    Public Shared LogMessage As String = ""
    Public Shared Range As String = ""
    Public Shared RemarkWithRange As String = ""
    Public Shared SearchExpire As Integer = 120
    Public Shared SearchHistory As New List(Of String)
    Public Shared SearchRestart As Integer = 0
    Public Shared SearchRestartOverride As Boolean = False
    Public Shared SearchSR As String = ""
    Public Shared Slave As Boolean = False

    Public Sub AddExclude(Carrier As String, AdapterReset As Boolean, DeletePVR As Boolean)
        Try
            For Each _loc_1 In Carrier.Split(",")
                Dim _loc_2 As String = _loc_1.Trim().Replace("！", "!").Replace("？", "?").Replace("?!", "?").Replace("!!", "!").ToUpper()
                If _loc_2.Length > 2 Then
                    If Not LstExclude.Items.Contains(_loc_2) Then LstExclude.Items.Add(_loc_2)
                    If AdapterReset Then
                        For _loc_3 As Integer = 0 To LsvAdapter.Items.Count - 1
                            If Not LsvAdapter.Items(_loc_3).SubItems(2).Text.EndsWith("Disabled") Then
                                If CarrierCompare(_loc_2.Replace("!", ""), LsvAdapter.Items(_loc_3).SubItems(3).Text) Then
                                    SetData("Instruction", _loc_3, GetResetInstruction(_loc_3, DeletePVR), True)
                                End If
                            End If
                        Next
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub APIClient(Index As String)
        Try
            Dim URL As String = GetData("URL", Index)
            If Not URL.EndsWith("/") Then URL &= "/"
            Dim Instruction As String = ""
            While True
                Try
                    Dim _loc_2 As String = GetData("Instruction", Index)
                    If _loc_2.Length > 0 Then
                        SetData("Instruction", Index, "")
                        Instruction = _loc_2
                    End If

                    Dim _loc_3 As Byte() = GetWebpage(URL & _loc_2, GetDispatchConfiguration("Authorization" & (Index + 1).ToString()))
                    If _loc_3.Length > 32 Then
                        Instruction = ""
                        SetData("Response", Index, Encoding.UTF8.GetString(_loc_3))
                    End If

                    Thread.Sleep(500)
                Catch ex As Exception
                    Thread.Sleep(5000)
                End Try
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnExcludeAdd_Click(sender As Object, e As EventArgs) Handles BtnExcludeAdd.Click
        Try
            AddExclude(TxtExclude.Text, True, ChkExcludeDelete.Checked)
            TxtExclude.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnExcludeAddTemporary_Click(sender As Object, e As EventArgs) Handles BtnExcludeAddTemporary.Click
        Try
            TxtExclude.Text &= "!"
            BtnExcludeAdd_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnExcludeRemove_Click(sender As Object, e As EventArgs) Handles BtnExcludeRemove.Click
        Try
            LstExclude.Items.RemoveAt(LstExclude.SelectedIndex)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles BtnHistory.Click
        Try
            If SearchHistory.Count > 0 Then
                Dim _loc_1 As String = ""
                For _loc_2 As Integer = 1 To SearchHistory.Count
                    _loc_1 &= "[" & _loc_2.ToString().PadLeft(2, "0") & "] " & SearchHistory(_loc_2 - 1) & vbCrLf & vbCrLf
                Next
                MsgBox(_loc_1.Trim(), vbInformation, GetTranslation("启动记录"))
            Else
                MsgBox(GetTranslation("当前无启动记录。"), vbInformation, GetTranslation("启动记录"))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnHistoryClean_Click(sender As Object, e As EventArgs) Handles BtnHistoryClean.Click
        Try
            SearchHistory.Clear()
            MsgBox(GetTranslation("已清空启动记录。"), vbInformation, GetTranslation("清空记录"))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnSR_Click(sender As Object, e As EventArgs) Handles BtnSR.Click
        Try
            Dim _loc_1 As String = InputBox(GetTranslation("符号率范围") & " (ksps)", GetTranslation("符号率选项"), SearchSR)
            SearchSR = MainUI.GetSegmentedString(_loc_1)
        Catch ex As Exception

        End Try
    End Sub

    Public Function CarrierCompare(param1 As String, param2 As String) As Boolean
        Try
            Dim _loc_1 As String = param1.Split(" ")(0).Trim().ToUpper()
            Dim _loc_2 As String = param2.Split(" ")(0).Trim().ToUpper()

            If _loc_1.Length = 0 Or _loc_2.Length = 0 Then
                Return False
            End If

            If Not IsNumeric(_loc_1.Substring(0, 1)) Or Not IsNumeric(_loc_2.Substring(0, 1)) Then
                Return False
            End If

            Dim _loc_3 As String = ""
            Dim _loc_4 As String = ""

            Dim _loc_5 As String = ""
            Dim _loc_6 As String = ""

            Dim _loc_7 As String = ""
            Dim _loc_8 As String = ""

            For _loc_11 As Integer = 1 To _loc_1.Length
                If Not IsNumeric(_loc_1.Substring(0, _loc_11)) Then
                    _loc_3 = _loc_1.Substring(0, _loc_11 - 1)
                    _loc_5 = _loc_1.Substring(_loc_11 - 1, 1).ToUpper()
                    _loc_7 = _loc_1.Substring(_loc_11)
                    Exit For
                End If
            Next

            For _loc_12 As Integer = 1 To _loc_2.Length
                If Not IsNumeric(_loc_2.Substring(0, _loc_12)) Then
                    _loc_4 = _loc_2.Substring(0, _loc_12 - 1)
                    _loc_6 = _loc_2.Substring(_loc_12 - 1, 1).ToUpper()
                    _loc_8 = _loc_2.Substring(_loc_12)
                    Exit For
                End If
            Next

            If _loc_5 = _loc_6 Then
                If Math.Abs(Int(_loc_3) - Int(_loc_4)) <= MainUI.BLScan2Step / 2 Then
                    If _loc_7.Length = 0 Or _loc_8.Length = 0 Then
                        Return True
                    Else
                        If Math.Abs(Int(_loc_7) - Int(_loc_8)) <= MainUI.BLScan2Step / 2 Then
                            Return True
                        End If
                    End If
                End If
            End If

            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function CarrierExclude(param1 As String)
        Try
            For Each _loc_1 As String In LstExclude.Items
                If CarrierCompare(param1, _loc_1.Replace("!", "")) Then
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function CarrierRecent(param1 As String, Optional param2 As Boolean = False) As Boolean
        Try
            Dim _loc_1 As String = param1.Split(" ")(0).Replace("!", "").Trim()
            Dim _loc_4 As Integer = 0
            If param2 Then
                CarrierRecentList.Insert(0, MainUI.Time() & vbTab & _loc_1)
                _loc_4 = 1
            End If
            For _loc_2 As Integer = CarrierRecentList.Count - 1 To _loc_4 Step -1
                If CarrierCompare(_loc_1, CarrierRecentList(_loc_2).Split(vbTab)(1)) Then
                    Dim _loc_3 As String = CarrierRecentList(_loc_2).Split(vbTab)(0)
                    If param2 Then CarrierRecentList.RemoveAt(_loc_2)
                    If MainUI.Time() > Convert.ToInt64(_loc_3) + SearchExpire Then
                        Return False
                    Else
                        Return True
                    End If
                End If
            Next
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub ChkSearchOverride_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSearchOverride.CheckedChanged
        Try
            If ChkSearchOverride.Checked = False Then
                For _loc_1 As Integer = 0 To LsvAdapter.Items.Count - 1
                    SetData("Search", _loc_1, "0")
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function CWSimplify(ControlWord As String) As String
        Try
            If ControlWord.Length = 16 Then
                Dim _loc_4 As String = ControlWord.Substring(0, 6) & ControlWord.Substring(8, 6)
                Dim _loc_1 As String = Hex(Int(MainUI.HexToBytes(_loc_4.Substring(0, 2))(0) + Int(MainUI.HexToBytes(_loc_4.Substring(2, 2))(0)) + Int(MainUI.HexToBytes(_loc_4.Substring(4, 2))(0)))).PadLeft(2, "0")
                Dim _loc_2 As String = Hex(Int(MainUI.HexToBytes(_loc_4.Substring(6, 2))(0) + Int(MainUI.HexToBytes(_loc_4.Substring(8, 2))(0)) + Int(MainUI.HexToBytes(_loc_4.Substring(10, 2))(0)))).PadLeft(2, "0")
                Dim _loc_3 As String = _loc_4.Substring(0, 6) + _loc_1.Substring(_loc_1.Length - 2, 2) + _loc_4.Substring(6, 6) + _loc_2.Substring(_loc_2.Length - 2, 2)
                If _loc_3 = ControlWord Then ControlWord = _loc_4
            End If
            Return ControlWord
        Catch ex As Exception
            Return ControlWord
        End Try
    End Function

    Private Sub Dispatch_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            e.Cancel = 1

            Dim _loc_1 As Boolean = False
            For _loc_2 As Integer = 0 To LsvAdapter.Items.Count - 1
                If LsvAdapter.Items(_loc_2).SubItems(2).Text.EndsWith("Started") Or LsvAdapter.Items(_loc_2).SubItems(2).Text.EndsWith("Dispatched") Then
                    _loc_1 = True
                    Exit For
                End If
            Next

            If _loc_1 And False Then
                If MsgBox(GetTranslation("您确定要关闭调度控制器吗？"), vbQuestion + vbYesNo, Remark) = vbYes Then
                    MainUI.Dispose()
                    End
                End If
            Else
                MainUI.Dispose()
                End
            End If
        Catch ex As Exception
            MainUI.Dispose()
            End
        End Try
    End Sub

    Private Sub Dispatch_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            RemarkWithRange = Remark
            Text = Remark & " - " & MainUI.ApplicationTitle
            If False And Not LoadConfig(Remark) Then
                MsgBox(GetTranslation("无法配置控制器参数。"), vbCritical, "OmniSNG - " & Remark)
                MainUI.Dispose()
                End
            End If
        Catch ex As Exception
            MainUI.Dispose()
            End
        End Try

        Try
            If MainUI.GlobalLanguage = "en-US" Then
                ClhAdapterIndex.Text = "No"
                ClhAdapterStatus.Text = "Status"
                ClhAdapterCarrier.Text = "Carrier"
                ClhAdapterServiceName.Text = "Service"
                ClhAdapterLock.Text = "Lock"
                ClhAdapterBER.Text = "BER"
                ClhAdapterSNR.Text = "SNR"
                ClhAdapterDuration.Text = "Duration"
                ClhAdapterLength.Text = "Length"
                ClhAdapterCorrupt.Text = "Corrupt"
                ClhAdapterControlWord.Text = "Control Word"
                ClhAdapterStream.Text = "Stream"
                ClhAdapterCSAStream.Text = "Dsc Stm"
                ClhAdapterVersion.Text = "Version"
                ClhAdapterDevice.Text = "Dev"

                LblSearch.Text = "Carriers"
                ClhSearchCarrier.Text = "Carrier"
                ClhSearchAdapter.Text = "Dlg"
                ClhSearchStatus.Text = "Status"

                LblExclude.Text = "Exclusions"
                ChkExcludeDelete.Text = "Del. PVR"

                ChkDispatch.Text = "Dispatch"
                ChkSearchOverride.Text = "Override Search"
                BtnSR.Text = "Dlg. SR Ranges"
                BtnHistory.Text = "Dlg. History"
                BtnHistoryClean.Text = "Clear History"
                BtnExcludeRemove.Text = "Remove Excl."
                BtnExcludeAdd.Text = "Add Exclusion"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function GetAdapterIndex(param1 As String) As Integer
        Try
            For _loc_4 As Integer = 0 To LsvAdapter.Items.Count - 1
                If CarrierCompare(param1, LsvAdapter.Items(_loc_4).SubItems(3).Text) And Not (LsvAdapter.Items(_loc_4).SubItems(8).Text = "" Or LsvAdapter.Items(_loc_4).SubItems(8).Text = "00:00:00") Then
                    Return _loc_4
                End If
            Next
            Return -1
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function GetData(Key As String, Index As String) As String
        Try
            If Not DataTable(Key & Index) = "" Then Return DataTable(Key & Index)
            Return ""
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function GetDispatchConfiguration(param1 As String) As String
        Try
            If Not DispatchConfiguration(param1) = "" Then Return DispatchConfiguration(param1)
            Return ""
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function GetResetInstruction(AdapterIndex As Integer, DeletePVR As Boolean) As String
        Try
            Dim _loc_1 As String = If(DeletePVR, "?Delete=1,Reset=1", "?Reset=1")
            If GetLong(GetData("Search", AdapterIndex), 0) > 0 Then Return _loc_1 & ",Search=1"
            Return _loc_1
        Catch ex As Exception
            Return "?Reset=1"
        End Try
    End Function

    Private Function GetTranslation(Message As String) As String
        Try
            If MainUI.GlobalLanguage = "en-US" Then
                If Message = "启动记录" Then
                    Return "Delegation history"
                ElseIf Message = "当前无启动记录。" Then
                    Return "There is currently no delegation history."
                ElseIf Message = "清空记录" Then
                    Return "Clear history"
                ElseIf Message = "已清空启动记录。" Then
                    Return "Delegation history has been cleared."
                ElseIf Message = "符号率选项" Then
                    Return "Delegation options"
                ElseIf Message = "符号率范围" Then
                    Return "Symbol Rate ranges"
                ElseIf Message = "无法配置控制器参数。" Then
                    Return "Unable to configure the controller."
                End If
            End If
            Return Message
        Catch ex As Exception
            Return Message
        End Try
    End Function

    Public Function GetWebpage(URL As String, Optional AuthorizationOverride As String = "") As Byte()
        Try
            Dim httpReq As System.Net.HttpWebRequest
            Dim httpResp As System.Net.HttpWebResponse
            Dim httpURL As New System.Uri(URL)
            httpReq = CType(WebRequest.Create(httpURL), HttpWebRequest)
            httpReq.Method = "GET"
            httpReq.AllowAutoRedirect = True
            httpReq.Timeout = 10000
            httpReq.KeepAlive = False
            httpReq.ServicePoint.ConnectionLimit = Integer.MaxValue
            httpReq.Proxy = GetWebpageProxy
            If Not AuthorizationOverride = "" Then
                httpReq.Headers.Add("Authorization", "Basic " & Convert.ToBase64String(Encoding.UTF8.GetBytes(AuthorizationOverride)))
            ElseIf Not Authorization = "" Then
                httpReq.Headers.Add("Authorization", "Basic " & Convert.ToBase64String(Encoding.UTF8.GetBytes(Authorization)))
            End If
            httpResp = CType(httpReq.GetResponse(), HttpWebResponse)
            Dim reader As New BinaryReader(httpResp.GetResponseStream)
            Dim returnBuffer As Byte() = reader.ReadBytes(1048576)
            Return returnBuffer
        Catch ex As Exception
            Return New Byte() {}
        End Try
    End Function

    Public Function GetXMLData(XML As String, Key As String) As String
        Try
            Dim _loc_1 As New XmlDocument()
            _loc_1.LoadXml(XML)
            Dim _loc_2 As XmlNode = _loc_1.SelectSingleNode("//" & Key)

            If _loc_2 IsNot Nothing Then
                If _loc_2.InnerText = "-1" Then Return ""
                Return _loc_2.InnerText
            Else
                Return ""
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function GetXMLDataList(XML As String, Key As String) As List(Of String)
        Dim _loc_1 As New List(Of String)()
        Try
            Dim _loc_2 As New XmlDocument()
            _loc_2.LoadXml(XML)
            Dim _loc_3 As XmlNodeList = _loc_2.SelectNodes("//" & Key)

            For Each _loc_4 As XmlNode In _loc_3
                _loc_1.Add(_loc_4.InnerText)
            Next
            Return _loc_1
        Catch ex As Exception
            Return _loc_1
        End Try
    End Function

    Public Function LoadConfig(Remark As String) As Boolean
        Try
            Dim _loc_10 As String = Application.StartupPath & "\" & Remark & ".cfg"
            Dim _loc_12 As String = Application.StartupPath & "\common.cfg"
            If My.Computer.FileSystem.FileExists(_loc_10) Or My.Computer.FileSystem.FileExists(_loc_12) Then
                Dim _loc_3 As New List(Of String)()

                If My.Computer.FileSystem.FileExists(_loc_12) Then
                    Dim _loc_21 As New FileStream(_loc_12, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                    Dim _loc_22 As New StreamReader(_loc_21)
                    While Not _loc_22.EndOfStream
                        _loc_3.Add(_loc_22.ReadLine().Trim())
                    End While
                    _loc_22.Close()
                    _loc_21.Close()
                End If

                If My.Computer.FileSystem.FileExists(_loc_10) Then
                    Dim _loc_1 As New FileStream(_loc_10, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                    Dim _loc_2 As New StreamReader(_loc_1)
                    While Not _loc_2.EndOfStream
                        _loc_3.Add(_loc_2.ReadLine().Trim())
                    End While
                    _loc_2.Close()
                    _loc_1.Close()
                End If

                DispatchConfiguration = New NameValueCollection
                Dim _loc_5 As New Regex("[ ]{2,}", RegexOptions.None)
                For Each _loc_6 As String In _loc_3
                    If Not _loc_6 = "" And Not _loc_6.StartsWith("#") And _loc_6.Contains("=") Then
                        Dim _loc_7 As String = _loc_5.Replace(_loc_6, " ")
                        Dim _loc_8 As String = _loc_7.Substring(0, _loc_7.IndexOf("="))
                        Dim _loc_9 As String = _loc_7.Substring(_loc_8.Length + 1).Trim()
                        _loc_8 = _loc_8.Trim().ToUpper()
                        If _loc_8 = "SEARCHSR" Or _loc_8 = "SR" Then
                            SearchSR = _loc_9
                        ElseIf _loc_8 = "SEARCHSTEP" Or _loc_8 = "STEP" Then
                            MainUI.BLScan2Step = Int(_loc_9)
                        ElseIf _loc_8 = "SEARCHEXPIRE" Or _loc_8 = "EXPIRE" Then
                            SearchExpire = Int(_loc_9)
                        ElseIf _loc_8 = "SEARCHOVERRIDE" Then
                            ChkSearchOverride.Checked = MainUI.StringToBool(_loc_9)
                        ElseIf _loc_8 = "SEARCHRESTART" Then
                            SearchRestart = Int(_loc_9)
                        ElseIf _loc_8 = "SEARCHRESTARTOVERRIDE" Then
                            SearchRestartOverride = MainUI.StringToBool(_loc_9)
                        ElseIf _loc_8 = "DISPATCH" Then
                            ChkDispatch.Checked = MainUI.StringToBool(_loc_9)
                        ElseIf _loc_8 = "SLAVE" Then
                            Slave = MainUI.StringToBool(_loc_9)
                            ChkDispatch.Checked = False
                        ElseIf _loc_8 = "DELETE" Then
                            ChkExcludeDelete.Checked = MainUI.StringToBool(_loc_9)
                        ElseIf _loc_8 = "EXCLUDE" Then
                            AddExclude(_loc_9, False, False)
                        ElseIf _loc_8 = "POSITION" Then
                            Dim _loc_11 As String() = _loc_9.Split(",")
                            If _loc_11.Length > 1 Then
                                Left = Int(_loc_11(0))
                                Top = Int(_loc_11(1))
                            End If
                        ElseIf _loc_8 = "PROXY" Then
                            If _loc_9.Contains(":") Then GetWebpageProxy.Address = New Uri(_loc_9)
                        ElseIf _loc_8 = "LOG" Then
                            Try
                                If Not My.Computer.FileSystem.DirectoryExists(_loc_9) Then My.Computer.FileSystem.CreateDirectory(_loc_9)
                            Catch ex As Exception

                            End Try
                            If My.Computer.FileSystem.DirectoryExists(_loc_9) And Remark.Length > 0 Then
                                Dim _loc_15 As String = _loc_9 & "\" & Remark & ".log"
                                Dim _loc_16 As New Thread(AddressOf LogDaemon)
                                _loc_16.Start(_loc_15)
                            End If
                        ElseIf _loc_8 = "AUTHORIZATION" Then
                            Authorization = _loc_9
                        ElseIf _loc_8 = "ADAPTER" Then
                            Dim _loc_14 As String() = _loc_9.Split(" ")
                            LsvAdapter.Items.Add("")
                            LsvAdapter.Items(LsvAdapter.Items.Count - 1).Checked = True
                            LsvAdapter.Items(LsvAdapter.Items.Count - 1).SubItems.Add(LsvAdapter.Items.Count)
                            LsvAdapter.Items(LsvAdapter.Items.Count - 1).SubItems.Add("★ Initialized")
                            For _loc_17 As Integer = 4 To LsvAdapter.Columns.Count
                                LsvAdapter.Items(LsvAdapter.Items.Count - 1).SubItems.Add("")
                            Next
                            SetData("URL", (LsvAdapter.Items.Count - 1).ToString(), _loc_14(0))
                            If Not Slave Then SetData("Instruction", (LsvAdapter.Items.Count - 1).ToString(), "?Remark=" & Remark, True)
                            If _loc_14.Count > 1 Then SetData("PolChar", (LsvAdapter.Items.Count - 1).ToString(), _loc_14(1))
                            Dim _loc_13 As New Thread(AddressOf APIClient)
                            _loc_13.Start(LsvAdapter.Items.Count - 1)
                            TmrDispatch.Enabled = True
                        Else
                            DispatchConfiguration.Add(_loc_8, _loc_9)
                        End If
                    End If
                Next
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function GetDouble(SourceString As String, DefaultValue As Double) As Double
        Try
            Dim _loc_1 As Double
            If Not Double.TryParse(SourceString, _loc_1) Then
                _loc_1 = DefaultValue
            End If
            Return _loc_1
        Catch ex As Exception
            Return DefaultValue
        End Try
    End Function

    Public Function GetLong(SourceString As String, DefaultValue As Long) As Long
        Try
            Dim _loc_1 As Long
            If Not Long.TryParse(SourceString, _loc_1) Then
                _loc_1 = DefaultValue
            End If
            Return _loc_1
        Catch ex As Exception
            Return DefaultValue
        End Try
    End Function

    Public Function GetSRInclusion(SearchParameter As MainUI.SEARCH_PARAMETER, Policy As String) As Boolean
        Try
            If Policy.Length < 1 Then Return False
            For Each _loc_1 In Policy.Split(",")
                Dim _loc_2 As String = _loc_1.Trim()
                If _loc_2.Length > 1 Then
                    Dim _loc_4 As String() = _loc_2.Split("-")
                    Dim _loc_5 As Integer = Int(_loc_4(0))
                    Dim _loc_6 As Integer = _loc_5
                    If _loc_4.Length > 1 Then _loc_6 = Int(_loc_4(1))
                    If _loc_5 > _loc_6 Then
                        Dim _loc_7 As Integer = _loc_5
                        _loc_5 = _loc_6
                        _loc_6 = _loc_7
                    End If
                    If Math.Round(SearchParameter.SR / 1000) >= _loc_5 - Math.Round(MainUI.BLScan2Step / 2) And Math.Round(SearchParameter.SR / 1000) <= _loc_6 + Math.Round(MainUI.BLScan2Step / 2) Then
                        Return True
                    End If
                End If
            Next
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub LogDaemon(LogPath As String)
        Try
            While True
                Try
                    If LogMessage.Length > 0 Then
                        Dim _loc_1 As String = LogMessage
                        LogMessage = ""
                        My.Computer.FileSystem.WriteAllText(LogPath, _loc_1, True)
                    End If
                Catch ex As Exception

                End Try
                Thread.Sleep(10000)
            End While
        Catch ex As Exception

        End Try
    End Sub

    Public Sub LogRecord(Message As String)
        Try
            If LogMessage.Length > 1048576 Then LogMessage = ""
            LogMessage &= "[" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "] " & Message & vbCrLf & vbCrLf
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LstExclude_KeyDown(sender As Object, e As KeyEventArgs) Handles LstExclude.KeyDown
        Try
            If e.KeyCode = Keys.Delete Then
                If LstExclude.SelectedIndex >= 0 Then
                    LstExclude.Items.RemoveAt(LstExclude.SelectedIndex)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LstExclude_MouseDown(sender As Object, e As MouseEventArgs) Handles LstExclude.MouseDown
        Try
            If e.Button = MouseButtons.Right Then
                Dim _loc_1 As String = ""
                For Each _loc_2 As String In LstExclude.Items
                    _loc_1 &= _loc_2.Split(" ")(0) & ","
                Next
                If _loc_1.Length > 0 Then Clipboard.SetText(_loc_1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LsvAdapter_MouseDown(sender As Object, e As MouseEventArgs) Handles LsvAdapter.MouseDown
        Try
            If e.Button = MouseButtons.Right Then
                If LsvAdapter.SelectedItems.Count > 0 Then
                    Dim _loc_3 As String = InputBox("[ 示例 ]" & vbCrLf & vbCrLf & "设置转发器: Carrier=12500H8000" & vbCrLf & vbCrLf & "设置控制字: CW=1234ABCD5678" & vbCrLf & vbCrLf & "设置搜索: Search=12250-12750H" & vbCrLf & vbCrLf & "设置别名: Remark=AP9" & vbCrLf & vbCrLf & "锁定: Lock=1" & vbCrLf & vbCrLf & "排除: Exclude=1" & vbCrLf & vbCrLf & "重置任务: Reset=1", "设备选项 (" & (LsvAdapter.SelectedItems(0).Index + 1).ToString() & ")", GetData("Instruction", LsvAdapter.SelectedItems(0).Index.ToString()).Replace("?", ""))
                    SetData("Instruction", LsvAdapter.SelectedItems(0).Index.ToString(), "?" & _loc_3)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LsvAdapter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LsvAdapter.SelectedIndexChanged
        Try
            If LsvAdapter.SelectedItems.Count > 0 Then
                Dim _loc_1 As String = LsvAdapter.SelectedItems(0).SubItems(3).Text.Split(" ")(0)
                If _loc_1.Length > 0 Then
                    If IsNumeric(_loc_1.Substring(0, 1)) Then
                        TxtExclude.Text = _loc_1
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LsvSearch_MouseDown(sender As Object, e As MouseEventArgs) Handles LsvSearch.MouseDown
        Try
            If e.Button = MouseButtons.Right Then
                Dim _loc_1 As String = Application.StartupPath & "\" & Remark & ".cfg"
                If My.Computer.FileSystem.FileExists(_loc_1) Then
                    Process.Start(_loc_1)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LsvSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LsvSearch.SelectedIndexChanged
        Try
            If LsvSearch.SelectedItems.Count > 0 Then
                Dim _loc_1 As String = LsvSearch.SelectedItems(0).SubItems(0).Text.Split(" ")(0)
                If _loc_1.Length > 0 Then
                    If IsNumeric(_loc_1.Substring(0, 1)) Then
                        TxtExclude.Text = _loc_1
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function SearchInsert(param1 As String) As Boolean
        Try
            Dim _loc_1 As Boolean = True

            If _loc_1 Then
                For _loc_12 As Integer = 0 To LsvSearch.Items.Count - 1
                    If CarrierCompare(param1, LsvSearch.Items(_loc_12).SubItems(0).Text) Then
                        _loc_1 = False
                        Exit For
                    End If
                Next
            End If

            Dim _loc_11 As Boolean = CarrierRecent(param1, True)
            If _loc_1 Then
                Dim SearchParameter As MainUI.SEARCH_PARAMETER = MainUI.GetSearchParameter(param1.Split(" ")(0), 0, 0)

                LsvSearch.Items.Add(param1)

                Dim _loc_3 As String = ""
                Dim _loc_5 As String = ""

                Dim _loc_4 As Integer = GetAdapterIndex(param1)
                If _loc_4 >= 0 Then
                    _loc_3 = (_loc_4 + 1).ToString()
                    _loc_5 = LsvAdapter.Items(_loc_4).SubItems(2).Text
                End If

                If _loc_3.Length = 0 And CarrierExclude(param1) Then
                    _loc_5 = "× Skipped"
                End If

                If _loc_5.Length = 0 Then
                    If GetSRInclusion(SearchParameter, SearchSR) Then
                        _loc_5 = "◇ Pending"
                        If _loc_11 = False Then
                            Dim _loc_6 As String = "New Carrier"
                            If Remark.Length > 0 Then _loc_6 = Remark
                            SendNotification(_loc_6, param1)
                            LogRecord("[New Carrier] " & param1)
                        End If
                    End If
                End If

                LsvSearch.Items(LsvSearch.Items.Count - 1).SubItems.Add(_loc_3)
                LsvSearch.Items(LsvSearch.Items.Count - 1).SubItems.Add(_loc_5)

                Return True
            End If

            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub SendNotification(Title As String, Message As String)
        Try
            NicToast.Visible = True
            NicToast.ShowBalloonTip(5000, Title, Message, ToolTipIcon.Info)
            NicToast.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Public Sub SetData(Key As String, Index As String, Value As String, Optional SafeSet As Boolean = False)
        Try
            If SafeSet And GetData(Key, Index).Length > 0 Then Exit Try
            DataTable.Set(Key & Index, Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TmrDispatch_Tick(sender As Object, e As EventArgs) Handles TmrDispatch.Tick
        Try
            Dim _loc_40 As Boolean = True    'Assume all adapters are idle at the beginning
            For _loc_1 As Integer = 0 To LsvAdapter.Items.Count - 1
                Dim _loc_2 As String = GetData("Response", _loc_1)
                SetData("Response", _loc_1, "")

                Dim _loc_21 As String = ""
                Dim _loc_22 As String = "★ Initialized"

                If LsvAdapter.Items(_loc_1).Checked = False Then
                    LsvAdapter.Items(_loc_1).SubItems(2).Text = "☆ Disabled"
                End If

                'XML report received
                If _loc_2.Length > 0 Then
                    SetData("Time", _loc_1, MainUI.Time().ToString())

                    'Timestamp
                    Dim _loc_11 As Long = GetLong(GetXMLData(_loc_2, "time"), -1)

                    'Column 2: Status
                    Dim _loc_3 As String = GetXMLData(_loc_2, "mode")

                    'Column 3: Carrier
                    Dim _loc_34 As String = GetXMLData(_loc_2, "carrier")
                    If _loc_34.Length > 0 Then LsvAdapter.Items(_loc_1).SubItems(3).Text = _loc_34

                    'Column 4: Service Name
                    LsvAdapter.Items(_loc_1).SubItems(4).Text = GetXMLData(_loc_2, "servicename")

                    'Column 5: Lock                
                    LsvAdapter.Items(_loc_1).SubItems(5).Text = GetXMLData(_loc_2, "lock")

                    'Column 6: BER
                    Dim _loc_4 As Double = GetDouble(GetXMLData(_loc_2, "ber"), -1)
                    If _loc_4 < 0 Then
                        LsvAdapter.Items(_loc_1).SubItems(6).Text = ""
                    Else
                        LsvAdapter.Items(_loc_1).SubItems(6).Text = MainUI.GetBERRatio(_loc_4)
                    End If

                    'Column 7: SNR
                    LsvAdapter.Items(_loc_1).SubItems(7).Text = GetXMLData(_loc_2, "snr")

                    'Column 8: Duration
                    Dim _loc_5 As Long = GetLong(GetXMLData(_loc_2, "duration"), -1)
                    If _loc_5 < 0 Then
                        LsvAdapter.Items(_loc_1).SubItems(8).Text = ""
                    Else
                        Dim _loc_7 As TimeSpan = TimeSpan.FromSeconds(_loc_5)
                        LsvAdapter.Items(_loc_1).SubItems(8).Text = String.Format("{0:D2}:{1:D2}:{2:D2}", _loc_7.Hours, _loc_7.Minutes, _loc_7.Seconds)
                    End If

                    'Column 9: Length
                    Dim _loc_6 As Long = GetLong(GetXMLData(_loc_2, "length"), -1)
                    If _loc_6 < 0 Then
                        LsvAdapter.Items(_loc_1).SubItems(9).Text = ""
                    Else
                        LsvAdapter.Items(_loc_1).SubItems(9).Text = MainUI.FileSizeToString(_loc_6)
                    End If

                    'Column 10: Corrupt
                    LsvAdapter.Items(_loc_1).SubItems(10).Text = GetXMLData(_loc_2, "corrupt")

                    'Column 11: Control Word
                    LsvAdapter.Items(_loc_1).SubItems(11).Text = CWSimplify(GetXMLData(_loc_2, "cw"))

                    'Column 12: Stream
                    LsvAdapter.Items(_loc_1).SubItems(12).Text = GetXMLData(_loc_2, "stream")

                    'Column 13: CSA Stream
                    LsvAdapter.Items(_loc_1).SubItems(13).Text = GetXMLData(_loc_2, "csastream")

                    'Column 14: Version
                    LsvAdapter.Items(_loc_1).SubItems(14).Text = GetXMLData(_loc_2, "version")

                    'Column 15: DVB Device
                    LsvAdapter.Items(_loc_1).SubItems(15).Text = GetXMLData(_loc_2, "device")

                    'Change status value
                    If _loc_3.Length > 0 Then _loc_22 = "☉ Connected"
                    Dim _loc_35 As Boolean = MainUI.StringToBool(GetXMLData(_loc_2, "standby"))
                    Dim _loc_38 As Boolean = _loc_6 > 0    'Prepare to reverse the idle flag
                    If _loc_38 Or _loc_35 Then _loc_22 = "● Started"
                    If SearchRestartOverride Then _loc_38 = False

                    'Check and update BER historical data to determine if a relock is needed
                    Dim _loc_24 As Boolean = False
                    If _loc_4 >= 0.001 And LsvAdapter.Items(_loc_1).SubItems(2).Text.EndsWith("Started") Then
                        If GetLong(GetData("LastBER", _loc_1), 0) = 0 And _loc_11 > 0 Then SetData("LastBER", _loc_1, _loc_11)
                        If _loc_11 - GetLong(GetData("LastBER", _loc_1), 0) >= 10 Then _loc_24 = True
                    Else
                        SetData("LastBER", _loc_1, "0")
                    End If

                    'If Data length >= 0 and Timestamp > 0, that is to check if the task started, record Lasts and change status value
                    If _loc_6 >= 0 And _loc_11 > 0 Then
                        Dim _loc_7 As Long = GetLong(GetData("LastTime", _loc_1), -1)
                        Dim _loc_8 As Long = GetLong(GetData("LastLength", _loc_1), -1)

                        'Last Time and Last Length are present
                        If _loc_7 >= 0 And _loc_8 >= 0 Then
                            'If data length not increased in 10 seconds, it means the task ends.
                            If _loc_11 - _loc_7 >= 10 And _loc_6 = _loc_8 And _loc_35 = False Then
                                _loc_22 = "○ Available"
                                _loc_38 = False    'Do not reverse the idle flag yet
                                If _loc_6 > 0 Or GetLong(GetData("Search", _loc_1), 0) > 0 Then _loc_21 = GetResetInstruction(_loc_1, False)
                                'This is the case when a relock is needed
                            ElseIf _loc_24 Then
                                If _loc_6 > 0 Then _loc_21 = "?Lock=1"
                                SetData("LastBER", _loc_1, "0")
                            End If
                            If Not _loc_6 = _loc_8 And _loc_11 > 0 Then SetData("LastTime", _loc_1, _loc_11)
                        ElseIf _loc_11 > 0 Then
                            SetData("LastTime", _loc_1, _loc_11)
                        End If
                        SetData("LastLength", _loc_1, _loc_6.ToString())
                    End If

                    'Handle if adapter is in search mode
                    If _loc_3 = "search" Then
                        If ChkSearchOverride.Checked Then
                            _loc_22 = "○ Available"
                        Else
                            _loc_22 = "● Started"
                        End If
                        LsvAdapter.Items(_loc_1).SubItems(3).Text = "🔍 Carrier Search"
                        Dim _loc_19 As String = GetXMLData(_loc_2, "range")
                        If _loc_19.Length > 0 Then RemarkWithRange = Remark & " (" & _loc_19 & ")"

                        Dim _loc_15 As Long = GetLong(GetData("LastSearch", "-1"), 0)
                        Dim _loc_36 As Long = _loc_11 - _loc_15
                        If _loc_15 > 0 And _loc_36 >= 0 Then LblSearchUpdate.Text = Math.Floor(_loc_36 / 60).ToString().PadLeft(2, "0") & ":" & (_loc_36 Mod 60).ToString().PadLeft(2, "0")

                        'Handle if XML list of carriers received
                        Dim _loc_17 As List(Of String) = GetXMLDataList(_loc_2, "carrier")
                        If _loc_17.Count > 0 And LsvAdapter.Items(_loc_1).Checked Then
                            Dim _loc_13 As Long = GetLong(GetXMLData(_loc_2, "tag"), 0)

                            'Handle if result is newer than stored
                            If _loc_13 - _loc_15 > 0 Then
                                _loc_38 = True
                                SetData("LastSearch", "-1", _loc_13.ToString())

                                If LsvSearch.Items.Count > 0 Then
                                    For _loc_16 As Integer = LsvSearch.Items.Count - 1 To 0 Step -1
                                        Dim _loc_14 As Integer = GetLong(LsvSearch.Items(_loc_16).SubItems(1).Text, -1)
                                        If _loc_14 > 0 Then
                                            If LsvAdapter.Items(_loc_14 - 1).SubItems(2).Text.EndsWith("Dispatched") Then _loc_14 = -2
                                        End If
                                        If Not ((LsvSearch.Items(_loc_16).SubItems(2).Text.EndsWith("Dispatched") And _loc_14 = -2) Or (LsvSearch.Items(_loc_16).SubItems(2).Text.EndsWith("Pending") And GetAdapterIndex(LsvSearch.Items(_loc_16).SubItems(0).Text) < 0)) Then
                                            LsvSearch.Items.RemoveAt(_loc_16)
                                        End If
                                    Next
                                End If

                                For Each _loc_18 As String In _loc_17
                                    SearchInsert(_loc_18)
                                Next

                                If LstExclude.Items.Count > 0 Then
                                    For _loc_29 As Integer = LstExclude.Items.Count - 1 To 0 Step -1
                                        If LstExclude.Items(_loc_29).ToString().EndsWith("!") And Not CarrierRecent(LstExclude.Items(_loc_29).ToString()) Then
                                            LstExclude.Items.RemoveAt(_loc_29)
                                        End If
                                    Next
                                End If
                            End If
                        End If
                    End If

                    'Exclude current carrier requested by the adapter
                    If MainUI.StringToBool(GetXMLData(_loc_2, "exclude")) Then
                        AddExclude(LsvAdapter.Items(_loc_1).SubItems(3).Text.Split(" ")(0) & "!", Not Slave, False)
                        _loc_21 = ""
                        _loc_22 = "× Aborted"
                        'Exclude current carrier if hit by a Service Name match
                    ElseIf LstExclude.Items.Count > 0 Then
                        For Each _loc_33 As String In LstExclude.Items
                            If _loc_33.EndsWith("?") And _loc_33.Length > 2 Then
                                If _loc_33.Substring(0, _loc_33.Length - 1).ToLower().Trim() = LsvAdapter.Items(_loc_1).SubItems(4).Text.ToLower().Trim() And LsvAdapter.Items(_loc_1).SubItems(2).Text.EndsWith("Started") Then
                                    AddExclude(LsvAdapter.Items(_loc_1).SubItems(3).Text.Split(" ")(0) & "!", Not Slave, ChkExcludeDelete.Checked)
                                    _loc_21 = ""
                                    _loc_22 = "× Aborted"
                                    Exit For
                                End If
                            End If
                        Next
                    End If

                    'Set instructions generated by the AI
                    If Not _loc_21 = "" And ChkDispatch.Checked And LsvAdapter.Items(_loc_1).Checked Then
                        SetData("Instruction", _loc_1, _loc_21, True)
                    End If

                    'Set Status for Listview Adapter
                    If Not (LsvAdapter.Items(_loc_1).SubItems(2).Text.EndsWith("Dispatched") And (Not (_loc_22.EndsWith("Started") Or _loc_22.EndsWith("Available")) Or _loc_3 = "search")) And LsvAdapter.Items(_loc_1).Checked Then
                        LsvAdapter.Items(_loc_1).SubItems(2).Text = _loc_22
                    End If

                    'Reverse the idle flag to Busy
                    If _loc_38 Then _loc_40 = False

                    'XML report empty but adapter enabled, may need to set Offline or Initialized status
                ElseIf LsvAdapter.Items(_loc_1).Checked Then
                    Dim _loc_23 As Long
                    If Not Long.TryParse(GetData("Time", _loc_1), _loc_23) Then
                        _loc_23 = 0
                    End If
                    If _loc_23 > 0 And MainUI.Time() - Convert.ToInt64(_loc_23) > 10 Then
                        LsvAdapter.Items(_loc_1).SubItems(2).Text = "▽ Offline"
                    ElseIf LsvAdapter.Items(_loc_1).SubItems(2).Text.EndsWith("Disabled") Then
                        LsvAdapter.Items(_loc_1).SubItems(2).Text = _loc_22
                    End If
                End If
            Next

            'Find available adapters and assign tasks for Pending status carriers in Listview Search
            For _loc_31 As Integer = 0 To LsvSearch.Items.Count - 1
                If LsvSearch.Items(_loc_31).SubItems(2).Text.EndsWith("Pending") Then
                    If GetAdapterIndex(LsvSearch.Items(_loc_31).SubItems(0).Text) < 0 Then
                        Dim _loc_28 As String = LsvSearch.Items(_loc_31).SubItems(0).Text.Split(" ")(0)
                        If Not CarrierRecent(_loc_28) Or CarrierExclude(_loc_28) Then
                            LsvSearch.Items(_loc_31).SubItems(2).Text = "× Aborted"
                        ElseIf ChkDispatch.Checked Then
                            For _loc_32 As Integer = 0 To LsvAdapter.Items.Count - 1
                                If LsvAdapter.Items(_loc_32).SubItems(2).Text.EndsWith("Available") Then
                                    SetData("Instruction", _loc_32, If(Slave, "?", "?Remark=" & Remark & ",") & "Carrier=" & MainUI.ReplacePol(_loc_28, GetData("PolChar", _loc_32)))
                                    LsvSearch.Items(_loc_31).SubItems(1).Text = (_loc_32 + 1).ToString()
                                    LsvSearch.Items(_loc_31).SubItems(2).Text = "◆ Dispatched"
                                    LsvAdapter.Items(_loc_32).SubItems(2).Text = "◆ Dispatched"
                                    SetData("LastTime", _loc_32, MainUI.Time() + 15)
                                    If LsvAdapter.Items(_loc_32).SubItems(3).Text.EndsWith("Carrier Search") Then SetData("Search", _loc_32, "1")
                                    LogRecord("[Adapter " & (_loc_32 + 1).ToString() & "] " & LsvSearch.Items(_loc_31).SubItems(0).Text)
                                    SearchHistory.Add(LsvSearch.Items(_loc_31).SubItems(0).Text & " [Adapter " & (_loc_32 + 1).ToString() & "] [" & Date.Now.ToString("yyyy-MM-dd HH:mm:ss") & "]")
                                    If SearchHistory.Count > 20 Then SearchHistory.RemoveAt(0)
                                    Exit For
                                End If
                            Next
                        End If
                    Else
                        LsvSearch.Items(_loc_31).SubItems(2).Text = "● Started"
                    End If
                End If
            Next

            'Handle search mode adapters restart requirements
            If SearchRestart > 0 Then
                If _loc_40 Then
                    Dim _loc_39 As Long = GetLong(GetData("LastIdle", "-1"), 0)
                    If _loc_39 = 0 Then
                        SetData("LastIdle", "-1", MainUI.Time())
                    ElseIf MainUI.Time() - _loc_39 > SearchRestart * 60 Then
                        For _loc_37 As Integer = 0 To LsvAdapter.Items.Count - 1
                            If LsvAdapter.Items(_loc_37).SubItems(3).Text.EndsWith("Carrier Search") And LsvAdapter.Items(_loc_37).Checked And ChkDispatch.Checked Then
                                SetData("Instruction", _loc_37, "?Restart=1")
                            End If
                        Next
                        SetData("LastIdle", "-1", 0)
                    End If
                Else
                    SetData("LastIdle", "-1", 0)
                End If
            End If

            'Set window headings
            Dim _loc_25 As Integer = 0
            Dim _loc_26 As Integer = 0
            For _loc_27 As Integer = 0 To LsvAdapter.Items.Count - 1
                If LsvAdapter.Items(_loc_27).SubItems(2).Text.EndsWith("Started") Or LsvAdapter.Items(_loc_27).SubItems(2).Text.EndsWith("Dispatched") Then _loc_25 += 1
                If LsvAdapter.Items(_loc_27).Checked Then _loc_26 += 1
            Next
            Text = RemarkWithRange & " [" & _loc_25.ToString() & "/" & _loc_26.ToString() & "] - " & MainUI.ApplicationTitle
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtExclude_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtExclude.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                BtnExcludeAddTemporary_Click(sender, e)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtExclude_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtExclude.KeyPress
        Try
            If Char.IsLower(e.KeyChar) Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class