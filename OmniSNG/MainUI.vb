Imports Microsoft.VisualBasic.CompilerServices
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.IO
Imports System.Management
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Web

Public Class MainUI

    <DllImport("FFDecsa_v2.dll", EntryPoint:="decrypt_packets@8", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function decrypt_packets(ByRef cluster As CSA_CLUSTER, ByRef csa_keys_t As CSA_KEYS_T) As Integer
    End Function

    <DllImport("FFDecsa_v2.dll", EntryPoint:="get_internal_parallelism@0", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Function get_internal_parallelism() As Integer
    End Function

    <DllImport("FFDecsa_v2.dll", EntryPoint:="set_control_words@12", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Sub set_control_words(even As Byte(), odd As Byte(), ByRef csa_keys_t As CSA_KEYS_T)
    End Sub

    <DllImport("kernel32.dll")>
    Public Shared Function GetSystemDefaultLangID() As UShort
    End Function

    <DllImport("SDTParse.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Sub dvbpsi_decoder_delete(p_decoder As IntPtr)
    End Sub

    <DllImport("SDTParse.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function dvbpsi_decoder_new(Optional i_section_max_size As Integer = 4096) As IntPtr
    End Function

    <DllImport("SDTParse.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function dvbpsi_DecodeServiceDr(p_descriptor As IntPtr) As IntPtr
    End Function

    <DllImport("SDTParse.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function decode_sdt(p_decoder As IntPtr, p_data As IntPtr, callback As DvbpsiSdtCallbackFunction, callback_priv As IntPtr) As Boolean
    End Function

    <DllImport("SDTParse.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Sub dvbpsi_sdt_delete(p_sdt As IntPtr)
    End Sub

    <UnmanagedFunctionPointer(CallingConvention.Cdecl)>
    Public Delegate Sub DvbpsiSdtCallbackFunction(p_sdt As IntPtr, priv As IntPtr)

    <DllImport("SDTParse.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Sub freestr8(ptr As IntPtr)
    End Sub

    <DllImport("SDTParse.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function getstr8(p As Byte(), len As Int32) As IntPtr
    End Function

    <DllImport("StreamReader.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function BLScanEx(freq As Integer, freq_range As Integer, pol As Integer, lof1 As Integer, lof2 As Integer, lofsw As Integer, minsr As Integer, std As Integer, ByRef Result As SEARCH_RESULT) As Boolean
    End Function

    <DllImport("StreamReader.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function BLScan2(freq_start As Integer, freq_stop As Integer, pol As Integer, lof1 As Integer, lof2 As Integer, lofsw As Integer, <MarshalAs(UnmanagedType.LPArray, SizeConst:=1000)> <Out()> pSearchResult As SEARCH_RESULT(), ByRef pTpNum As Integer, lpFunc As BLScan2CallbackFunction) As UInteger
    End Function

    <UnmanagedFunctionPointer(CallingConvention.StdCall)>
    Public Delegate Sub BLScan2CallbackFunction(pTrp As IntPtr)

    <DllImport("StreamReader.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function CheckForDVBExEx(int32 As CheckForDVBCallbackFunction) As Boolean
    End Function

    <UnmanagedFunctionPointer(CallingConvention.StdCall)>
    Public Delegate Function CheckForDVBCallbackFunction(index As Integer, name As String, type As Integer) As Boolean

    <DllImport("StreamReader.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function DelFilter(flt As Integer) As Boolean
    End Function

    <DllImport("StreamReader.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function GetSignalEx(ByRef pSNR As Single, ByRef pBER As Single) As Boolean
    End Function

    <DllImport("StreamReader.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function RFScan(freq As UInteger, pol As UInteger, lof1 As UInteger, lof2 As UInteger, lofsw As UInteger, ByRef pRFLevel As Double) As Boolean
    End Function

    <DllImport("StreamReader.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function MISSel(bEnable As Boolean, MISFilter As Byte, Optional MISFilterMask As Byte = &HFF) As Boolean
    End Function

    <DllImport("StreamReader.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function PLSSel(PLSMode As Byte, Code As Integer) As Boolean
    End Function

    <DllImport("StreamReader.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SendDiSEqC(DiSEqCType As Integer, data As Byte) As Boolean
    End Function

    <DllImport("StreamReader.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetChannelEx(freq As Integer, symb As Integer, pol As Integer, fec As Integer, lof1 As Integer, lof2 As Integer, lofsw As Integer, modulation As Integer) As Boolean
    End Function

    <DllImport("StreamReader.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetFilter(pid As UShort, lpFunc As SetFilterCallbackFunction, CallBackType As Integer, size As UInteger, ByRef lpFilter_num As UInteger) As Boolean
    End Function

    <DllImport("StreamReader.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SignalInfo(ByRef Result As SEARCH_RESULT) As Boolean
    End Function

    <UnmanagedFunctionPointer(CallingConvention.StdCall)>
    Public Delegate Sub SetFilterCallbackFunction(dataPtr As IntPtr, len As UInteger)

    <DllImport("StreamReader.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function StartDVBEx(index As Integer) As Boolean
    End Function

    <DllImport("StreamReader.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function StopDVB() As Boolean
    End Function

    Public Structure CSA_CLUSTER
        Public param1 As IntPtr
        Public param2 As IntPtr
        Public param3 As Integer
    End Structure

    Public Structure CSA_KEYS_T
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4096)>
        Public param As Byte()
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Public Structure DVBPSI_DESCRIPTOR_T
        Public i_tag As Byte              'descriptor_tag
        Public i_length As Byte           'descriptor_length
        Public p_data As IntPtr           'content
        Public p_next As IntPtr           '(dvbpsi_descriptor_t*) Next element Of the list
        Public p_decoded As IntPtr        'decoded descriptor
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Public Structure DVBPSI_SDT_SERVICE_T
        Public i_service_id As UInt16           'service_id
        <MarshalAs(UnmanagedType.I1)>
        Public b_eit_schedule As Boolean        'EIT schedule flag
        <MarshalAs(UnmanagedType.I1)>
        Public b_eit_present As Boolean         'EIT present/following flag
        Public i_running_status As Byte         'Running status
        <MarshalAs(UnmanagedType.I1)>
        Public b_free_ca As Boolean             'Free CA mode flag
        Public i_descriptors_length As UInt16   'Descriptors Loop length
        Public p_first_descriptor As IntPtr     '(dvbpsi_descriptor_t*) First Of the following DVB descriptors
        Public p_next As IntPtr                 '(dvbpsi_sdt_service_t*) Next element Of the list
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Public Structure DVBPSI_SDT_T
        'PSI table members
        Public i_table_id As Byte         'table id
        Public i_extension As UInt16      'subtable id, here transport_stream_id
        'Table specific
        Public i_version As Byte          'version_number
        Public b_current_next As Byte     'current_next_indicator
        Public i_network_id As UInt16     'original network id
        Public p_first_service As IntPtr  '(dvbpsi_sdt_service_t*) service description list
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Public Structure DVBPSI_SERVICE_DR_T
        Public i_service_type As Byte                            'service_type
        Public i_service_provider_name_length As Byte            'length Of the i_service_provider_name array
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=252)>
        Public i_service_provider_name As Byte()                 'name Of the service provider
        Public i_service_name_length As Byte                     'length Of the i_service_name array
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=252)>
        Public i_service_name As Byte()                          'name Of the service
    End Structure

    Public Structure SEARCH_PARAMETER
        Public Freq As Integer
        Public SR As Integer
        Public Lof1 As Integer
        Public Lof2 As Integer
        Public LofSW As Integer
        Public Pol As Integer
        Public PolChar As String
    End Structure

    Public Structure SEARCH_RESULT
        Public Lock As Boolean
        Public Freq As UInteger
        Public Pol As Integer
        Public SR As UInteger
        Public StdType As UInteger
        Public ModType As UInteger
        Public FEC As UInteger
        Public Inversion As UInteger
        Public RollOff As UInteger
        Public Pilot As UInteger
        Public Frame As UInteger
        Public CodingType As UInteger
        Public StreamType As UInteger
        Public MIS As UInteger
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)>
        Public MIS_Array As Byte()
        Public ISSYI As Byte
        Public NPD As Byte
        Public PLS As UInteger
        Public CW As UInteger
        Public BitRate As UInteger
        Public RFLevel As Integer
        Public SNR As Double
        Public BER As Double
        Public preBER As Double
    End Structure

    Public Shared AdapterConfiguration As New NameValueCollection
    Public Shared APICredentials As String = ""
    Public Shared APIDaemonAvailable As Boolean = True
    Public Shared ApplicationTitle As String = My.Application.Info.Title
    Public Shared ApplicationStartTime As Long = Time()
    Public Shared AvailableCSAPVR As String = ""
    Public Shared AvailableCSAStream As String = ""
    Public Shared AvailablePVR As String = ""
    Public Shared AvailableStream As String = ""
    Public Shared BERCount As Long = -1
    Public Shared BLScan2Current As String = ""
    Public Shared BLScan2FreqFilter As String = ""
    Public Shared BLScan2FirstPass As Boolean = False
    Public Shared BLScan2Pol As String = ""
    Public Shared BLScan2Queue As New List(Of String)
    Public Shared BLScan2Range As String = ""
    Public Shared BLScan2Result As New List(Of String)
    Public Shared BLScan2Step As Integer = 6
    Public Shared BufferAvailable As Long = -1
    Public Shared BufferCache As New MemoryStream
    Public Shared BufferCount As Long = 0
    Public Shared BufferDelete As Long = -1
    Public Shared BufferId As Long = 0
    Public Shared BufferLength As Integer = 96256
    Public Shared BufferRing As New List(Of Byte())
    Public Shared BufferSize As Integer = 256
    Public Shared BufferStopwatch As New Stopwatch
    Public Shared BufferValid As Long = -5
    Public Shared CarrierCurrent As String = ""
    Public Shared CarrierCurrentWithRemark As String = ""
    Public Shared CarrierExclude As Boolean = False
    Public Shared CarrierStandby As Boolean = False
    Public Shared ClientSignature As String = ""
    Public Shared CSABufferAvailable As Long = -1
    Public Shared CSABufferRing As New List(Of Byte())
    Public Shared CSAControlWord As String = ""
    Public Shared CSAControlWordIsSet As Boolean = False
    Public Shared CSAFileCancel As Boolean = False
    Public Shared CSAFileLength As Long = 0
    Public Shared CSAFileOffset As Long = 0
    Public Shared CSAFileRead As FileStream
    Public Shared CSAFileReader As BinaryReader
    Public Shared CSAFileStopwatch As New Stopwatch
    Public Shared CSAFileWrite As FileStream
    Public Shared CSAFileWriter As BinaryWriter
    Public Shared CSAKeys As New CSA_KEYS_T
    Public Shared CSAParallelSize As Integer = 0
    Public Shared DispatchInstruction As String = ""
    Public Shared DVBDeviceCurrent As Integer = -1
    Public Shared DVBDeviceNameCurrent As String = ""
    Public Shared DVBDevices As New List(Of String)
    Public Shared FilterCurrent As UInteger = Int32.MaxValue
    Public Shared FreqExclusiveTemporary As String = ""
    Public Shared GetEscalation As Boolean = False
    Public Shared GlobalLanguage As String = "zh-CN"
    Public Shared LogEnabled As Boolean = False
    Public Shared LogMessage As String = ""
    Public Shared LogPathCurrent As String = ""
    Public Shared MainUIHandle As MainUI
    Public Shared ModeParameters As String = ""
    Public Shared PLSConfigured As Boolean = False
    Public Shared PositionAdaptationAvailable As Boolean = True
    Public Shared RandomGenerator As New Random()
    Public Shared Remark As String = ""
    Public Shared SDTServices As New List(Of String())
    Public Shared SDTServicesHash As String = ""
    Public Shared SearchParameterCurrent As SEARCH_PARAMETER = Nothing
    Public Shared SendDiSEqCAvailable As Boolean = True
    Public Shared SetEscalation As Boolean = False
    Public Shared SetFilterCallbackHandle As SetFilterCallbackFunction
    Public Shared SetFilterCallbackLock As Object = RuntimeHelpers.GetObjectValue(New Object())
    Public Shared Signal As SEARCH_RESULT = Nothing
    Public Shared TraversalBinary As String = Application.StartupPath & "\frpc.exe"
    Public Shared TraversalConfig As String = Application.StartupPath & "\frpc.toml"
    Public Shared TraversalDaemons As New List(Of Integer)
    Public Shared TSPacketSize As Integer = 188
    Public Shared VersionStrings As String() = Application.ProductVersion.ToString.Split(".")

    Public Delegate Sub DispatchInstructionHandlerDelegate(param1 As String)

    Public Sub AddTask(TaskName As String)
        Try
            If TaskName.ToUpper().StartsWith("[TCP]") Then
                Dim _loc_1 As New Regex("\[TCP\]\s?(\d+\+)")
                Dim _loc_2 As Match = _loc_1.Match(TaskName.ToUpper())
                If _loc_2.Success Then
                    TaskName = TaskName.Replace(_loc_2.Groups(1).Value, RoundPort(_loc_2.Groups(1).Value, DVBDeviceCurrent))
                End If
            End If

            If Not LstTask.Items.Contains(TaskName) Then
                LstTask.Items.Add(TaskName)
                If BufferAvailable > -1 Then StartTask(TaskName)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Class APIClient
        Dim ClientSocket As TcpClient

        Public Sub StartClient(param1 As TcpClient)
            Try
                ClientSocket = param1
                ClientSocket.ReceiveBufferSize = 1 * 1024 * 1024
                ClientSocket.SendBufferSize = 1 * 1024 * 1024
                Dim _loc_1 As New Thread(AddressOf HTTPResponse)
                _loc_1.Start()
            Catch ex As Exception

            End Try
        End Sub

        Private Sub HTTPResponse()
            Try
                Dim ReceiveBuffer(1500) As Byte
                Dim _loc_1 As NetworkStream = ClientSocket.GetStream()
                _loc_1.Read(ReceiveBuffer, 0, ReceiveBuffer.Length)
                Dim _loc_2 As String = Encoding.UTF8.GetString(ReceiveBuffer)
                Dim _loc_3 As String = "<mode>initialization</mode>"
                Dim _loc_4 As String = GetHTTPResponseOrHeader("400 Bad Request")

                Try
                    Dim _loc_5 As String = New Regex("^[A-Z]+\s(.*?)\sHTTP/1\.1").Match(_loc_2).Groups(1).Value.Trim()
                    If _loc_5.Contains("?") Then
                        _loc_5 = HttpUtility.UrlDecode(_loc_5.Split("?")(1))
                    Else
                        _loc_5 = ""
                    End If

                    Dim _loc_6 As String = New Regex("(?<=Authorization:\sBasic\s)(.*?)(?=\r\n)", RegexOptions.IgnoreCase).Match(_loc_2).Value.Trim()
                    Dim _loc_7 As String = ""
                    If Not String.IsNullOrEmpty(_loc_6) Then
                        _loc_7 = Encoding.ASCII.GetString(Convert.FromBase64String(_loc_6))
                    End If

                    Dim _loc_8 As Integer = 403

                    If _loc_5 = "" Then
                        If Not GetEscalation Or APICredentials = "" Then
                            _loc_8 = 200
                        ElseIf _loc_7 = APICredentials Then
                            _loc_8 = 200
                        Else
                            _loc_8 = 401
                        End If
                    Else
                        If SetEscalation Or APICredentials = "" Then
                            _loc_5 = ""
                            _loc_8 = 200
                        ElseIf _loc_7 = APICredentials Then
                            _loc_8 = 200
                        Else
                            _loc_8 = 401
                        End If
                    End If

                    If _loc_8 = 200 Then
                        If _loc_5.ToLower() = "log" Then
                            If My.Computer.FileSystem.FileExists(LogPathCurrent) Then
                                Dim _loc_13 As Long = My.Computer.FileSystem.GetFileInfo(LogPathCurrent).Length
                                Dim _loc_11 As Long = _loc_13 - 102400
                                If _loc_11 < 0 Then _loc_11 = 0
                                Using _loc_12 As New FileStream(LogPathCurrent, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                                    _loc_12.Seek(_loc_11, SeekOrigin.Begin)
                                    Dim _loc_14(_loc_13 - _loc_11 - 1) As Byte
                                    _loc_12.Read(_loc_14, 0, _loc_14.Length)
                                    Dim _loc_15 As String = Encoding.UTF8.GetString(_loc_14)
                                    Dim _loc_16 As Integer = If(_loc_11 = 0, 0, _loc_15.IndexOf(vbLf))
                                    If _loc_16 >= 0 Then
                                        _loc_4 = GetHTTPResponseOrHeader("200 OK", "text/plain; charset=UTF-8") & _loc_15.Substring(_loc_16 + 1).Trim()
                                    Else
                                        _loc_4 = GetHTTPResponseOrHeader("404 Not Found")
                                    End If
                                End Using
                            Else
                                _loc_4 = GetHTTPResponseOrHeader("404 Not Found")
                            End If
                        Else
                            If Not _loc_5 = "" Then
                                MainUIHandle.Invoke(New DispatchInstructionHandlerDelegate(AddressOf MainUIHandle.DispatchInstructionHandler), _loc_5)
                            End If

                            If Not ModeParameters = "" Then _loc_3 = ModeParameters
                            _loc_4 = GetHTTPResponseOrHeader("200 OK", "application/xml") &
                                     "<?xml version=""1.0"" encoding=""UTF-8""?>" &
                                     "<adapter>" &
                                     "<time>" & Time() & "</time>" &
                                     "<server>" & ApplicationTitle & "</server>" &
                                     "<version>" & VersionStrings(0) & "." & VersionStrings(1) & "." & VersionStrings(2) & "</version>" &
                                     "<date>20" & VersionStrings(3).Substring(0, 2) & "." & VersionStrings(3).Substring(2, 2) & "</date>" &
                                     "<device>" & DVBDeviceCurrent & "</device>" &
                                     "<devicename>" & SecurityElement.Escape(DVBDeviceNameCurrent) & "</devicename>" &
                                     "<remark>" & Remark & "</remark>" &
                                     _loc_3 &
                                     "</adapter>"
                        End If
                    ElseIf _loc_8 = 401 Then
                        _loc_4 = GetHTTPResponseOrHeader("401 Unauthorized")
                    Else
                        _loc_4 = GetHTTPResponseOrHeader("403 Forbidden")
                    End If
                Catch ex As Exception
                    _loc_4 &= vbCrLf & "<!-- " & ex.ToString() & " -->"
                End Try

                Dim ResponseBuffer As Byte() = Encoding.UTF8.GetBytes(_loc_4)
                _loc_1.Write(ResponseBuffer, 0, ResponseBuffer.Length)
                _loc_1.Flush()
                _loc_1.Close()
            Catch ex As Exception

            Finally
                ClientSocket.Close()
            End Try
        End Sub
    End Class

    Public Sub APIDaemon(Port As String)
        Try
            Traversal(Int(Port))
            Dim ServerSocket As New TcpListener(IPAddress.IPv6Any, Int(Port))
            ServerSocket.Server.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only, False)
            Try
                Dim ClientSocket As TcpClient
                ServerSocket.Start()
                While APIDaemonAvailable = False
                    ClientSocket = ServerSocket.AcceptTcpClient()
                    Dim _loc_1 As New APIClient
                    _loc_1.StartClient(ClientSocket)
                End While
            Catch ex As Exception

            Finally
                ServerSocket.Stop()
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BgwBLScan2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BgwBLScan2.DoWork
        Try
            BLScan2Result.Clear()

            Dim _loc_1 As String = BLScan2Current.Split("-")(0)
            Dim _loc_2 As String = BLScan2Current.Split("-")(1)
            Dim _loc_3 As String = _loc_2.Substring(_loc_2.Length - 1)
            Dim _loc_4 As Integer = Int(_loc_2.Substring(0, _loc_2.Length - 1)) * 1000
            Dim SearchParameter As SEARCH_PARAMETER = GetSearchParameter(_loc_1 & _loc_3, TxtLOF.Text, TxtLOFSW.Text)

            Dim Signal2 As SEARCH_RESULT() = New SEARCH_RESULT(499) {}
            BLScan2(SearchParameter.Freq, _loc_4, SearchParameter.Pol, SearchParameter.Lof1, SearchParameter.Lof2, SearchParameter.LofSW, Signal2, 0, AddressOf BLScan2Callback)
            Dim _loc_6 As Boolean = StringToBool(GetAdapterConfiguration("SearchReverse"))
            Dim _loc_7 As Integer = 0
            Do Until Signal2(_loc_7).Lock = False
                _loc_7 += 1
            Loop
            If _loc_7 > 0 Then
                For _loc_8 As Integer = 0 To _loc_7 - 1
                    Dim _loc_5 As Integer = _loc_8
                    If _loc_6 Then _loc_5 = _loc_7 - 1 - _loc_8
                    BLScan2Result.Add(GetLockString(Signal2(_loc_5), Math.Round(Signal2(_loc_5).Freq / 1000) & SearchParameter.PolChar & RoundSR(Math.Round(Signal2(_loc_5).SR / 1000))))
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BgwBLScan2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BgwBLScan2.RunWorkerCompleted
        Try
            If BLScan2FirstPass Then
                LstBLScan2.Items.Clear()
                BLScan2FirstPass = False
            End If

            For Each _loc_1 In BLScan2Result
                Dim _loc_3 As String = ReplacePol(_loc_1, BLScan2Pol)
                Dim SearchParameter As SEARCH_PARAMETER = GetSearchParameter(_loc_3.Split(" ")(0), 0, 0)
                If Not GetFreqExclusion(SearchParameter, BLScan2FreqFilter) Then
                    LstBLScan2.Items.Add(_loc_3)
                End If
            Next
        Catch ex As Exception

        Finally
            BLScan2Result.Clear()
            BtnBLScan2.BackColor = Color.Transparent
            BLScan2Next()
        End Try
    End Sub

    <Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions>
    Private Sub BgwFFDecsa_DoWork(sender As Object, e As DoWorkEventArgs) Handles BgwFFDecsa.DoWork
        Try
            Dim CSAFileInput As String = TxtDescrambleFileInput.Text
            Dim CSAFileOutput As String = TxtDescrambleFileOutput.Text
            If CSAFileOutput.Length = 0 Or Not CSAFileOutput.Contains("\") Then
                CSAFileOutput = Path.GetDirectoryName(CSAFileInput) & "\" & Path.GetFileNameWithoutExtension(CSAFileInput) & "_[" & CSAControlWord & "]" & Path.GetExtension(CSAFileInput)
            End If

            Dim FFDecsaWorker As BackgroundWorker = TryCast(sender, BackgroundWorker)
            Dim CSABufferSize As Integer = TSPacketSize * CSAParallelSize
            Dim CSAFileBuffer As Byte() = New Byte() {}
            CSAFileCancel = False
            CSAFileRead = New FileStream(CSAFileInput, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            CSAFileReader = New BinaryReader(CSAFileRead)
            CSAFileWrite = New FileStream(CSAFileOutput, FileMode.Create)
            CSAFileWriter = New BinaryWriter(CSAFileWrite)
            CSAFileLength = 0
            CSAFileLength = New FileInfo(CSAFileInput).Length
            CSAFileOffset = 0

            CSAFileStopwatch.Reset()
            CSAFileStopwatch.Start()
            Dim CSARound As Long = 0
            Do
                If CSAFileCancel Then Exit Sub
                CSAFileOffset = CSAFileReader.BaseStream.Position
                CSAFileBuffer = CSAFileReader.ReadBytes(CSABufferSize)
                If CSAFileBuffer.Length < TSPacketSize Then Exit Do
                If CSAFileBuffer(0) = &H47 Then
                    Dim _loc_1 As IntPtr = Marshal.AllocHGlobal(CSABufferSize)
                    Try
                        Marshal.Copy(CSAFileBuffer, 0, _loc_1, CSAFileBuffer.Length)
                        Dim _loc_2 As IntPtr = _loc_1 + CSABufferSize
                        Dim _loc_3 As New CSA_CLUSTER With {
                            .param1 = _loc_1,
                            .param2 = _loc_2,
                            .param3 = 0
                        }
                        Dim _loc_4 As Integer = decrypt_packets(_loc_3, CSAKeys)
                        Marshal.Copy(_loc_1, CSAFileBuffer, 0, CSAFileBuffer.Length)
                        CSAFileWriter.Write(CSAFileBuffer)
                    Catch ex As Exception

                    Finally
                        Marshal.FreeHGlobal(_loc_1)
                    End Try
                Else
                    CSAFileReader.BaseStream.Position = CSAFileOffset + 1
                End If

                CSARound += 1
                If CSARound Mod (128000 / CSAParallelSize) = 0 Then
                    FFDecsaWorker.ReportProgress(Int(CSAFileOffset / CSAFileLength * 100))
                End If
            Loop Until CSAFileOffset >= CSAFileLength

            CSAFileOffset = CSAFileLength
            FFDecsaWorker.ReportProgress(100)
        Catch ex As Exception

        Finally
            CSAFileStopwatch.Stop()
            CSAFileRead.Close()
            CSAFileReader.Close()
            CSAFileWrite.Close()
            CSAFileWriter.Close()
        End Try
    End Sub

    Private Sub BgwFFDecsa_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BgwFFDecsa.ProgressChanged
        Try
            LblDescramblePercentage.Text = e.ProgressPercentage & "%"

            Dim _loc_1 As TimeSpan = TimeSpan.FromMilliseconds((CSAFileLength - CSAFileOffset) / (CSAFileOffset / CSAFileStopwatch.ElapsedMilliseconds))
            If Not e.ProgressPercentage > 100 Then LblDescrambleRemainValue.Text = String.Format("{0}:{1}:{2}", _loc_1.Hours.ToString().PadLeft(2, "0"), _loc_1.Minutes.ToString().PadLeft(2, "0"), _loc_1.Seconds.ToString().PadLeft(2, "0"))
            LblDescrambleProgressValue.Text = FileSizeToString(CSAFileOffset) & "/" & FileSizeToString(CSAFileLength) & " (" & FileSizeToString(Convert.ToInt64(CSAFileOffset / CSAFileStopwatch.ElapsedMilliseconds * 1000)) & "/s)"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BgwFFDecsa_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BgwFFDecsa.RunWorkerCompleted
        Try
            BtnControlWord.BackColor = Color.Transparent
        Catch ex As Exception

        End Try
    End Sub

    Public Sub BLScan2Callback(pTrp As IntPtr)
        Try

        Catch ex As Exception

        End Try
    End Sub

    Public Sub BLScan2Next()
        Try
            If DispatchInstruction.Length > 0 Then
                ChkAutoBLScan2.Checked = False
                DispatchInstructionHandler(DispatchInstruction)
                Exit Sub
            End If

            If BLScan2Queue.Count > 0 Then
                BLScan2Current = BLScan2Queue(0)
                BLScan2Queue.RemoveAt(0)
                If BLScan2Current.Length > 1 Then
                    BtnBLScan2.BackColor = Color.LawnGreen
                    BgwBLScan2.RunWorkerAsync()
                Else
                    ChkAutoBLScan2.Checked = False
                End If
            Else
                Try
                    If Not Remark = "" Then Text = Remark

                    ModeParameters = "<mode>search</mode><range>" & BLScan2Range & "</range><tag>" & Time() & "</tag>"
                    If LstBLScan2.Items.Count > 0 Then
                        For Each _loc_1 As String In LstBLScan2.Items
                            Dim _loc_2 As Integer = _loc_1.IndexOf(" ")
                            ModeParameters &= "<carrier>" & _loc_1 & "</carrier>"
                        Next
                    End If
                Catch ex As Exception

                End Try

                If ChkAutoBLScan2.Checked Then
                    BLScan2Start()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub BLScan2Reset()
        Try
            BLScan2FreqFilter = ""
            BLScan2Pol = ""
            BLScan2Range = ""
        Catch ex As Exception

        End Try
    End Sub

    Public Sub BLScan2Start()
        Try
            BLScan2Queue.Clear()
            TxtBLScan2.Text = TxtBLScan2.Text.ToUpper()
            For Each _loc_1 In TxtBLScan2.Text.Split(",")
                If _loc_1.Length > 1 Then BLScan2Queue.Add(_loc_1)
            Next

            Dim _loc_2 As String() = TxtBLScan2.Text.Split(",")
            For _loc_3 As Integer = 0 To _loc_2.Length - 1
                _loc_2(_loc_3) = ReplacePol(_loc_2(_loc_3), GetAdapterConfiguration("Pol"))
            Next
            BLScan2Range = String.Join(",", _loc_2)

            BLScan2FirstPass = True
            BLScan2Next()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnBLScan2_Click(sender As Object, e As EventArgs) Handles BtnBLScan2.Click
        Try
            BtnBLScan2Handler()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnBLScan2Clear_Click(sender As Object, e As EventArgs) Handles BtnBLScan2Clear.Click
        Try
            LstBLScan2.Items.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub BtnBLScan2Handler()
        Try
            If DVBDeviceCurrent < 0 Then Exit Sub
            TabMain.SelectedIndex = TapSearch.TabIndex
            If Not StringToBool(GetAdapterConfiguration("NoAutoSearch")) Then ChkAutoBLScan2.Checked = True
            If Not BgwBLScan2.IsBusy Then
                ResetStream()
                ResetSignalInfo()
                BLScan2Start()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnCarrier_Click(sender As Object, e As EventArgs) Handles BtnCarrier.Click
        Try
            BtnCarrierHandler()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub BtnCarrierHandler()
        Try
            If Not BgwBLScan2.IsBusy And Not BgwFFDecsa.IsBusy Then
                TabMain.SelectedIndex = TapSetting.TabIndex
                LockCarrier()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnControlWord_Click(sender As Object, e As EventArgs) Handles BtnControlWord.Click
        Try
            BtnControlWordHandler()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub BtnControlWordHandler()
        Try
            If TxtControlWord.Text.Trim().Length = 0 Then
                CSAControlWord = ""
                CSAControlWordIsSet = False
                Exit Sub
            End If

            If BgwFFDecsa.IsBusy Then
                CSAFileCancel = True
                BtnControlWord.BackColor = Color.Transparent
            Else
                If My.Computer.FileSystem.FileExists(TxtDescrambleFileInput.Text) And Not BufferAvailable > -1 Then
                    DescrambleFile()
                Else
                    SetControlWord()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnDescrambleFileInput_Click(sender As Object, e As EventArgs) Handles BtnDescrambleFileInput.Click
        Try
            If OfdDescrambleFile.ShowDialog = DialogResult.OK Then
                TxtDescrambleFileInput.Text = OfdDescrambleFile.FileName
                DescrambleFile()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnDescrambleFileOutput_Click(sender As Object, e As EventArgs) Handles BtnDescrambleFileOutput.Click
        Try
            If SfdDescrambleFile.ShowDialog = DialogResult.OK Then
                TxtDescrambleFileOutput.Text = SfdDescrambleFile.FileName
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnDeviceSearch_Click(sender As Object, e As EventArgs) Handles BtnDeviceSearch.Click
        Try
            If BgwBLScan2.IsBusy Then Exit Sub
            DVBDeviceCurrent = -1
            DVBDeviceNameCurrent = ""
            TmrSignalInfo.Enabled = False
            StopDVB()
            ResetStream()
            ResetSignalInfo()
        Catch ex As Exception

        End Try

        Try
            LblDevice.Text = GetTranslation("(请选择设备)")
            DVBDevices.Clear()
            LstDevice.Items.Clear()
            If CheckForDVBExEx(AddressOf CheckForDVBCallback) Then
                For Each DVBDevice In DVBDevices
                    LstDevice.Items.Add("[" & DVBDevice.Split(vbTab)(0) & "] " & DVBDevice.Split(vbTab)(1) & " (" & GetStdType(DVBDevice.Split(vbTab)(2)) & ")")
                Next
            Else
                LblDevice.Text = GetTranslation("(无可用设备)")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnDeviceSelect_Click(sender As Object, e As EventArgs) Handles BtnDeviceSelect.Click
        Try
            BtnDeviceSelectHandler()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnDeviceSelectHandler()
        Try
            If BgwBLScan2.IsBusy Then Exit Try
            Dim SelectedIndex As Integer = LstDevice.SelectedIndex
            Dim DeviceName As String = DVBDevices(SelectedIndex).Split(vbTab)(1) & " [" & DVBDevices(SelectedIndex).Split(vbTab)(0) & "]"
            DVBDeviceNameCurrent = DVBDevices(SelectedIndex).Split(vbTab)(1)
            StopDVB()
            ResetStream()
            ResetSignalInfo()
            If StartDVBEx(SelectedIndex) Then
                SendDiSEqCAvailable = True
                DVBDeviceCurrent = SelectedIndex
                LblDevice.Text = DeviceName
                LoadConfig(SelectedIndex, True)
                If TabMain.SelectedIndex = TapDevice.TabIndex Then TabMain.SelectedIndex = TapSetting.TabIndex
            Else
                MsgBox("启动设备 " & DeviceName & " 失败！", vbExclamation, "")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnRemark_Click(sender As Object, e As EventArgs) Handles BtnRemark.Click
        Try
            Process.Start(Application.ExecutablePath, CboRemark.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        Try
            If BufferCount > 100 * 1024 * 1024 And LblLockParameter.BackColor = Color.LawnGreen Then
                If MsgBox("任务正在进行，您确定要结束任务吗？", vbQuestion + vbYesNo, Text) = vbNo Then
                    Exit Sub
                End If
            End If
            ResetStream(False)
            TabMain.SelectedIndex = TapSetting.TabIndex
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnTaskRecord_Click(sender As Object, e As EventArgs) Handles BtnTaskRecord.Click
        Try
            If FbdRecord.ShowDialog() = DialogResult.OK Then
                AddTask("[REC] " & FbdRecord.SelectedPath)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnTaskRemove_Click(sender As Object, e As EventArgs) Handles BtnTaskRemove.Click
        Try
            LstTask.Items.RemoveAt(LstTask.SelectedIndex)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnTaskTransfer_Click(sender As Object, e As EventArgs) Handles BtnTaskTransfer.Click
        Try
            Dim _loc_1 As String = InputBox("HTTP服务端口号" & vbCrLf & vbCrLf & vbCrLf & "(端口号追加""!""输出解扰流)", "TCP网络串流")
            If _loc_1.Length > 0 Then
                AddTask("[TCP] " & _loc_1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function BytesToHex(param1 As Byte()) As String
        Return BitConverter.ToString(param1).Replace("-", "").ToUpper
    End Function

    Public Function CheckForDVBCallback(index As Integer, name As String, type As Integer) As Boolean
        Try
            DVBDevices.Add(index.ToString() & vbTab & name & vbTab & type.ToString())
            Return True
        Catch ex As Exception
            Return True
        End Try
    End Function

    Private Sub ChkGetEscalation_CheckedChanged(sender As Object, e As EventArgs) Handles ChkGetEscalation.CheckedChanged
        Try
            If ChkGetEscalation.Checked Then
                GetEscalation = True
            Else
                GetEscalation = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ChkSetEscalation_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSetEscalation.CheckedChanged
        Try
            If ChkSetEscalation.Checked Then
                SetEscalation = False
            Else
                SetEscalation = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    <Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions>
    Public Sub CSADaemon()
        Try
            Dim _loc_1 As Long = BufferId
            Dim _loc_2 As Boolean = CSAControlWordIsSet
            Dim _loc_3 As Integer = TSPacketSize * CSAParallelSize
            Dim _loc_4 As Long = BufferAvailable + 1
            Dim _loc_5 As Long = _loc_4

            While _loc_1 = BufferId
                If _loc_2 Then
                    While _loc_4 <= BufferAvailable And BufferAvailable >= _loc_5
                        If BufferAvailable >= _loc_4 + BufferSize Then _loc_4 = BufferAvailable
                        Try
                            CSABufferRing(_loc_4 Mod BufferSize) = New Byte(BufferRing(_loc_4 Mod BufferSize).Length - 1) {}
                            Array.Copy(BufferRing(_loc_4 Mod BufferSize), CSABufferRing(_loc_4 Mod BufferSize), BufferRing(_loc_4 Mod BufferSize).Length)
                            Dim CSABufferScrambled As Byte() = New Byte(BufferRing(_loc_4 Mod BufferSize).Length - 1) {}
                            Array.Copy(BufferRing(_loc_4 Mod BufferSize), CSABufferScrambled, BufferRing(_loc_4 Mod BufferSize).Length)
                            For _loc_10 As Integer = 0 To BufferLength - _loc_3 Step _loc_3
                                Dim _loc_11 As IntPtr = Marshal.AllocHGlobal(_loc_3)
                                Try
                                    Marshal.Copy(CSABufferScrambled, _loc_10, _loc_11, _loc_3)
                                    Dim _loc_12 As IntPtr = _loc_11 + _loc_3
                                    Dim _loc_13 As New CSA_CLUSTER With {
                                        .param1 = _loc_11,
                                        .param2 = _loc_12,
                                        .param3 = 0
                                    }
                                    Dim _loc_14 As Integer = decrypt_packets(_loc_13, CSAKeys)
                                    Marshal.Copy(_loc_11, CSABufferRing(_loc_4 Mod BufferSize), _loc_10, TSPacketSize * _loc_14)
                                Catch ex As Exception

                                Finally
                                    Marshal.FreeHGlobal(_loc_11)
                                End Try
                            Next
                        Catch ex As Exception

                        Finally
                            CSABufferAvailable = _loc_4
                            _loc_4 += 1
                        End Try
                    End While
                    If _loc_4 > BufferAvailable Then Threading.Thread.Sleep(10)
                Else
                    Thread.Sleep(100)
                    If CSAControlWordIsSet Then _loc_2 = True
                    _loc_3 = TSPacketSize * CSAParallelSize
                    _loc_4 = BufferAvailable + 1
                    _loc_5 = _loc_4
                End If
            End While
        Catch ex As Exception

        End Try
    End Sub

    Public Sub CSAPVRDaemon(RecFile As String)
        Try
            Dim _loc_3 As Long = BufferId
            Dim _loc_6 As Integer = 0
            While BufferId = _loc_3 And _loc_6 <= 10
                If BufferValid = BufferId Then
                    If CSABufferAvailable < 0 Then
                        Thread.Sleep(100)
                    Else
                        If Not My.Computer.FileSystem.DirectoryExists(RecFile) Then My.Computer.FileSystem.CreateDirectory(RecFile)
                        Dim FilenamePrefix As String = "REC"
                        If CarrierCurrent.Length > 0 Then FilenamePrefix = ReplacePol(CarrierCurrent, GetAdapterConfiguration("Pol"))
                        Dim _loc_7 As String = CSAControlWord
                        Dim _loc_8 As String = "[Descrambled]"
                        If _loc_7.Length > 0 Then _loc_8 = "[" & _loc_7 & "]"
                        Dim _loc_11 As String = GetPVRFileName(FilenamePrefix)
                        Dim _loc_1 As New IO.FileStream(RecFile & "\" & Path.GetFileNameWithoutExtension(_loc_11) & "_" & _loc_8 & Path.GetExtension(_loc_11), IO.FileMode.Create)
                        Dim _loc_2 As New IO.BinaryWriter(_loc_1)
                        Try
                            AvailableCSAPVR = _loc_1.Name
                            Dim _loc_4 As Long = CSABufferAvailable + 1
                            Dim _loc_5 As Long = _loc_4
                            While BufferId = _loc_3 And CSAControlWord = _loc_7
                                While _loc_4 <= CSABufferAvailable And CSABufferAvailable >= _loc_5
                                    If CSABufferAvailable >= _loc_4 + BufferSize Then _loc_4 = CSABufferAvailable
                                    _loc_2.Write(CSABufferRing(_loc_4 Mod BufferSize))
                                    _loc_4 += 1
                                End While
                                If _loc_4 > CSABufferAvailable Then Threading.Thread.Sleep(10)
                            End While
                        Catch ex As Exception
                            _loc_6 += 1
                        Finally
                            Dim _loc_12 As String = _loc_1.Name
                            _loc_2.Close()
                            _loc_1.Close()
                            If BufferDelete = _loc_3 Or New FileInfo(_loc_12).Length = 0 Then File.Delete(_loc_12)
                        End Try
                    End If
                Else
                    Thread.Sleep(100)
                End If
            End While
        Catch ex As Exception

        End Try
    End Sub

    Public Sub DescrambleFile()
        Try
            If BgwFFDecsa.IsBusy Or BufferAvailable > -1 Or APIDaemonAvailable = False Then
                MsgBox("实例已被使用，请使用新实例解扰文件！", vbExclamation, Text)
                Exit Sub
            End If

            LblDescramblePercentage.Text = "0%"
            LblDescrambleProgressValue.Text = "0 MB/0 MB"
            LblDescrambleRemainValue.Text = "00:00:00"

            If TxtControlWord.Text.Length < 12 And TxtDescrambleFileInput.Text.Contains("_") Then
                Dim _loc_1 As String() = TxtDescrambleFileInput.Text.Split("_")
                Dim _loc_2 As String = _loc_1(_loc_1.Length - 1).Split(".")(0).ToUpper()
                If _loc_2.Length = 12 Or _loc_2.Length = 16 Then TxtControlWord.Text = _loc_2
            End If

            SetControlWord()
            If CSAControlWordIsSet And CSAParallelSize >= 32 And Not BgwFFDecsa.IsBusy Then
                BgwFFDecsa.RunWorkerAsync()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub DispatchInstructionHandler(Instruction As String)
        Try
            DispatchInstruction = ""
            If SetEscalation Then Exit Sub

            Dim _loc_11 As Boolean = False
            For Each _loc_12 As String In Instruction.Split(",")
                Dim _loc_13 As Integer = _loc_12.IndexOf("=")
                If _loc_13 > 1 Then
                    Dim _loc_14 As String = _loc_12.Substring(0, _loc_13).Trim().ToUpper()
                    Dim _loc_15 As String = _loc_12.Substring(_loc_13 + 1).Trim()
                    If _loc_14 = "REMARK" Then
                        Remark = _loc_15
                    Else
                        _loc_11 = True
                    End If
                ElseIf _loc_12.Trim().Length > 1 Then
                    _loc_11 = True
                End If
            Next

            If _loc_11 And BgwBLScan2.IsBusy Then
                DispatchInstruction = Instruction
            ElseIf _loc_11 Then
                RecordLog("[Dispatch] " & Instruction, True)
                For Each _loc_2 As String In Instruction.Split(",")
                    Dim _loc_6 As String = _loc_2.Trim()
                    Dim _loc_3 As Integer = _loc_6.IndexOf("=")
                    If _loc_3 = -1 Then
                        If _loc_6.StartsWith("!") Then
                            _loc_6 = _loc_6.Substring(1) & "=0"
                        Else
                            _loc_6 &= "=1"
                        End If
                        _loc_3 = _loc_6.IndexOf("=")
                    End If
                    If _loc_3 > 1 Then
                        Dim _loc_4 As String = _loc_6.Substring(0, _loc_3).Trim().ToUpper()
                        Dim _loc_5 As String = _loc_6.Substring(_loc_3 + 1).Trim()
                        If _loc_4 = "CARRIER" Then
                            If Regex.Match(_loc_5, "\d").Success Then
                                TxtCarrier.Text = _loc_5
                                LockCarrier()
                            End If
                        ElseIf _loc_4 = "CW" Then
                            TxtControlWord.Text = _loc_5
                            BtnControlWordHandler()
                        ElseIf _loc_4 = "DELETE" Then
                            BufferDelete = If(StringToBool(_loc_5), BufferId, -1)
                        ElseIf _loc_4 = "LOCK" Then
                            If StringToBool(_loc_5) And Not IsNothing(SearchParameterCurrent) Then
                                SetChannelEx(SearchParameterCurrent.Freq, SearchParameterCurrent.SR, SearchParameterCurrent.Pol, 0, SearchParameterCurrent.Lof1, SearchParameterCurrent.Lof2, SearchParameterCurrent.LofSW, 0)
                                RecordLog("[Lock] " & CarrierCurrentWithRemark)
                            End If
                        ElseIf _loc_4 = "RESET" Then
                            If StringToBool(_loc_5) Then ResetStream(False)
                        ElseIf _loc_4 = "RESTART" Then
                            Restart()
                        ElseIf _loc_4 = "SEARCH" Then
                            If Not StringToBool(_loc_5) Then TxtBLScan2.Text = _loc_5
                            BtnBLScan2Handler()
                        ElseIf _loc_4 = "STANDBY" Then
                            CarrierStandby = StringToBool(_loc_5)
                        ElseIf _loc_4 = "EXCLUDE" Then
                            CarrierExclude = StringToBool(_loc_5)
                        ElseIf _loc_4 = "GETESC" Then
                            ChkGetEscalation.Checked = StringToBool(_loc_5)
                        ElseIf _loc_4 = "SETESC" Then
                            ChkSetEscalation.Checked = Not StringToBool(_loc_5)
                        End If
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function FileSizeToString(param1 As Long) As String
        Dim _loc_1() As String = {"B", "KB", "MB", "GB", "TB", "PB", "EB"}
        If param1 = 0 Then
            Return "0 " + _loc_1(0)
        End If
        Dim _loc_2 As Long = Math.Abs(param1)
        Dim _loc_3 As Integer = Convert.ToInt32(Math.Floor(Math.Log(_loc_2, 1024)))
        Return (Math.Sign(param1) * Math.Round(_loc_2 / Math.Pow(1024, _loc_3), 2)).ToString() & " " & _loc_1(_loc_3)
    End Function

    Public Function GetAdapterConfiguration(param1 As String) As String
        Try
            If Not AdapterConfiguration(param1) = "" Then Return AdapterConfiguration(param1)
            Return ""
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function GetBERRatio(BER As Double) As String
        Try
            If BER > 1 Then BER = 1
            If BER <= 0 Then
                Return "0%"
            Else
                Dim _loc_1 As Integer = (100 - Math.Floor(Math.Log10(1 / BER) * 10))
                If _loc_1 <= 0 Then _loc_1 = 1
                Return _loc_1 & "%"
            End If
        Catch ex As Exception
            Return "100%"
        End Try
    End Function

    Public Function GetBufferDuration() As String
        Try
            Dim _loc_1 As TimeSpan = TimeSpan.FromTicks(BufferStopwatch.ElapsedTicks)
            Return String.Format("{0}:{1}:{2}", _loc_1.Hours.ToString().PadLeft(2, "0"), _loc_1.Minutes.ToString().PadLeft(2, "0"), _loc_1.Seconds.ToString().PadLeft(2, "0"))
        Catch ex As Exception
            Return "00:00:00"
        End Try
    End Function

    Public Function GetBufferDurationSeconds() As Integer
        Try
            Return BufferStopwatch.Elapsed.TotalSeconds
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function GetFreqExclusion(SearchParameter As SEARCH_PARAMETER, Policy As String) As Boolean
        Try
            For Each _loc_1 In Policy.Split(",")
                Dim _loc_2 As String = _loc_1.Trim()
                If _loc_2.Length > 1 Then
                    Dim _loc_3 As String = _loc_2.Substring(_loc_2.Length - 1)
                    If _loc_3.ToUpper() = SearchParameter.PolChar.ToUpper() Then
                        Dim _loc_4 As String() = _loc_2.Substring(0, _loc_2.Length - 1).Split("-")
                        Dim _loc_5 As Integer = Int(_loc_4(0))
                        Dim _loc_6 As Integer = _loc_5
                        If _loc_4.Length > 1 Then _loc_6 = Int(_loc_4(1))
                        If _loc_5 > _loc_6 Then
                            Dim _loc_7 As Integer = _loc_5
                            _loc_5 = _loc_6
                            _loc_6 = _loc_7
                        End If

                        If Math.Round(SearchParameter.Freq / 1000) >= _loc_5 - Math.Round(BLScan2Step / 2) And Math.Round(SearchParameter.Freq / 1000) <= _loc_6 + Math.Round(BLScan2Step / 2) Then
                            Return True
                        End If
                    End If
                End If
            Next
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function GetHTTPResponseOrHeader(Status As String, Optional ContentType As String = "text/html; charset=UTF-8") As String
        Dim _loc_1 As String = ApplicationTitle & "/" & VersionStrings(0) & "." & VersionStrings(1) & "." & VersionStrings(2)
        Dim _loc_2 As String = "HTTP/1.1 " & Status & vbCrLf &
                          "Access-Control-Allow-Headers: *" & vbCrLf &
                          "Access-Control-Allow-Methods: GET, OPTIONS" & vbCrLf &
                          "Access-Control-Allow-Origin: *" & vbCrLf &
                          "Cache-Control: no-cache" & vbCrLf &
                          "Connection: close" & vbCrLf &
                          "Content-Type: " & ContentType & vbCrLf &
                          "Server: " & _loc_1 & vbCrLf &
                          If(Status.StartsWith("401"), "WWW-Authenticate: Basic realm=""Authentication Required""" & vbCrLf, "") & vbCrLf
        If Status.StartsWith("2") Then Return _loc_2
        Return _loc_2 & "<html><head><title>" & Status & "</title></head><body><center><h1>" & Status & "</h1></center><hr><center>" & _loc_1 & "</center></body></html>"
    End Function

    Public Function GetISI(Signal As SEARCH_RESULT) As Integer
        Try
            If Signal.MIS > 0 Then
                Return Int(Signal.MIS_Array(Signal.MIS - 1))
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function GetLockString(Signal As SEARCH_RESULT, Optional CarrierOverride As String = "") As String
        Try
            If CarrierOverride.Length = 0 Then CarrierOverride = CarrierCurrent
            Return (CarrierOverride & " " & GetViterbirateType(Signal.FEC) & " " & GetModType(Signal.ModType)).Trim()
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function GetModType(type As Integer) As String
        Dim ModType As String = ""
        Select Case type
            Case 1
                ModType = "DVB-S QPSK"
            Case 2
                ModType = "DVB-S2 8-PSK"
            Case 3
                ModType = "DVB-S2 16-APSK"
            Case 4
                ModType = "DVB-S2 32-APSK"
            Case 5
                ModType = "DVB-S2 QPSK"
            Case 27
                ModType = "DVB-S2X VL-SNR"
            Case 28
                ModType = "DVB-S2X 64-APSK"
            Case 29
                ModType = "DVB-S2X 128-APSK"
            Case 30
                ModType = "DVB-S2X 256-APSK"
            Case 31
                ModType = "DVB-S2X 8-APSK-L"
            Case 32
                ModType = "DVB-S2X 16-APSK-L"
            Case 33
                ModType = "DVB-S2X 32-APSK-L"
            Case 34
                ModType = "DVB-S2X 64-APSK-L"
            Case 35
                ModType = "DVB-S2X 256-APSK-L"
            Case 36
                ModType = "DVB-S2X 1024-APSK"
        End Select
        Return ModType
    End Function

    Public Function GetPol(Pol As Integer, CircularPolarization As Boolean) As String
        If CircularPolarization = False Then
            If Pol >= 1 Then
                Return "V"
            Else
                Return "H"
            End If
        Else
            If Pol >= 1 Then
                Return "R"
            Else
                Return "L"
            End If
        End If
    End Function

    Public Function GetPVRFileName(param1 As String) As String
        Try
            Dim _loc_1 As String = GetAdapterConfiguration("Extension")
            Dim _loc_3 As String = ""
            If Not Remark = "" Then _loc_3 = Remark & "_"

            If _loc_1 = "" Then
                Return param1 & "_" & _loc_3 & Format(Now(), "yyyyMMdd_HHmmss") & ".ts"
            Else
                Return param1 & "_" & _loc_3 & Format(Now(), "yyyyMMdd_HHmmss") & "." & _loc_1
            End If
        Catch ex As Exception
            Return param1 & "_" & Format(Now(), "yyyyMMdd_HHmmss") & ".ts"
        End Try
    End Function

    Public Shared Function GetRndString(StringLength As Integer) As String
        Try
            Dim _loc_1 As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
            Dim _loc_3 As New StringBuilder
            For _loc_4 As Integer = 1 To StringLength
                _loc_3.Append(_loc_1.Substring(RandomGenerator.Next(0, _loc_1.Length), 1))
            Next
            Return _loc_3.ToString()
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Shared Function GetSDTDescriptors(p_descriptor As IntPtr) As List(Of Tuple(Of String, String))
        Dim _loc_1 As New List(Of Tuple(Of String, String))
        While p_descriptor <> IntPtr.Zero
            Dim _loc_2 As DVBPSI_DESCRIPTOR_T = Marshal.PtrToStructure(p_descriptor, GetType(DVBPSI_DESCRIPTOR_T))
            While True
                If _loc_2.i_tag = &H48 Then
                    Dim d = dvbpsi_DecodeServiceDr(p_descriptor)
                    If d = IntPtr.Zero Then Exit While
                    Dim p_decoded As DVBPSI_SERVICE_DR_T = Marshal.PtrToStructure(d, GetType(DVBPSI_SERVICE_DR_T))
                    Dim ServiceNameData As IntPtr = getstr8(p_decoded.i_service_name, p_decoded.i_service_name_length)
                    If ServiceNameData = IntPtr.Zero Then Exit While
                    Dim ServiceProviderData As IntPtr = getstr8(p_decoded.i_service_provider_name, p_decoded.i_service_provider_name_length)
                    If ServiceProviderData = IntPtr.Zero Then
                        freestr8(ServiceNameData)
                        Exit While
                    End If
                    Dim ServiceName As String = NativeUtf8ToString(ServiceNameData)
                    Dim ServiceProvider As String = NativeUtf8ToString(ServiceProviderData)
                    _loc_1.Add(Tuple.Create(ServiceName, ServiceProvider))
                    freestr8(ServiceNameData)
                    freestr8(ServiceProviderData)
                End If
                Exit While
            End While
            p_descriptor = _loc_2.p_next
        End While
        Return _loc_1
    End Function

    Public Shared Function GetSDTServiceInfo(p_sdt As IntPtr) As List(Of ServiceInfo)
        Dim _loc_1 As New List(Of ServiceInfo)
        Dim p_service As IntPtr
        Dim _loc_2 As DVBPSI_SDT_T = Marshal.PtrToStructure(p_sdt, GetType(DVBPSI_SDT_T))
        p_service = _loc_2.p_first_service
        While p_service <> IntPtr.Zero
            Dim _loc_3 As DVBPSI_SDT_SERVICE_T = Marshal.PtrToStructure(p_service, GetType(DVBPSI_SDT_SERVICE_T))
            Dim _loc_4 = GetSDTDescriptors(_loc_3.p_first_descriptor)
            _loc_1.Add(New ServiceInfo With {.ServiceId = _loc_3.i_service_id, .Names = _loc_4})
            p_service = _loc_3.p_next
        End While
        dvbpsi_sdt_delete(p_sdt)
        Return _loc_1
    End Function

    Public Function GetSearchParameter(Carrier As String, LOF As String, LOFSW As String) As SEARCH_PARAMETER
        Try
            Dim SearchParameter As New SEARCH_PARAMETER With {
                .Pol = -1
            }
            If Carrier.ToUpper().Contains("H") Or Carrier.ToUpper().Contains("L") Then SearchParameter.Pol = 0
            If Carrier.ToUpper().Contains("V") Or Carrier.ToUpper().Contains("R") Then SearchParameter.Pol = 1
            SearchParameter.Lof1 = 0
            SearchParameter.Lof2 = 0
            SearchParameter.LofSW = 0
            If LOF.Contains("/") Then
                SearchParameter.Lof1 = Int(LOF.Split("/")(0)) * 1000
                SearchParameter.Lof2 = Int(LOF.Split("/")(1)) * 1000
                SearchParameter.LofSW = Int(LOFSW) * 1000

                If SearchParameter.LofSW > 12750000 Then
                    If SearchParameter.Pol <= 0 And Not Carrier.ToUpper().Contains("B") Then
                        SearchParameter.Lof2 = SearchParameter.Lof1
                    End If
                    SearchParameter.Lof1 = 0
                    SearchParameter.LofSW = 0
                    If SearchParameter.Pol >= 0 Then SearchParameter.Pol = 0
                End If
            Else
                SearchParameter.Lof2 = Int(LOF) * 1000
            End If

            SearchParameter.PolChar = "N"
            SearchParameter.Freq = 0
            SearchParameter.SR = 0
            For _loc_1 As Integer = 1 To Carrier.Length
                If Not IsNumeric(Carrier.Substring(0, _loc_1)) Then
                    SearchParameter.PolChar = Carrier.ToUpper().Substring(_loc_1 - 1, 1)
                    SearchParameter.Freq = Int(Carrier.Substring(0, _loc_1 - 1)) * 1000
                    If Carrier.Length > _loc_1 Then SearchParameter.SR = Int(Carrier.Substring(_loc_1)) * 1000
                    Exit For
                End If
            Next
            Return SearchParameter
        Catch ex As Exception
            Return New SEARCH_PARAMETER
        End Try
    End Function

    Public Function GetSegmentedString(Input As String) As String
        Try
            Return Input.Replace(" ", ",").Replace(".", ",").Replace(";", ",").Replace("&", ",").Replace("_", ",").Replace("\", ",").Replace("/", ",").Replace("，", ",").Replace("；", ",").Replace("、", ",").Trim()
        Catch ex As Exception
            Return Input
        End Try
    End Function

    Public Shared Function GetServiceInfo(p_decoder As IntPtr, dataPtr As IntPtr) As List(Of ServiceInfo)
        Dim _loc_1 As List(Of ServiceInfo) = Nothing
        Dim _loc_2 As DvbpsiSdtCallbackFunction =
            Sub(p_sdt As IntPtr, priv As IntPtr)
                _loc_1 = GetSDTServiceInfo(p_sdt)
            End Sub
        decode_sdt(p_decoder, dataPtr, _loc_2, IntPtr.Zero)
        Return _loc_1
    End Function

    Public Function GetStdType(type As Integer) As String
        Dim DeviceType As String = "Unknown"
        Select Case type
            Case 1
                DeviceType = "DVB-S"
            Case 2
                DeviceType = "DVB-S2"
            Case 7
                DeviceType = "DVB-T"
            Case 8
                DeviceType = "DVB-T2"
            Case 9
                DeviceType = "DVB-C"
            Case 10
                DeviceType = "DVB-C2"
            Case 11
                DeviceType = "ATSC"
            Case 12
                DeviceType = "ISDB-T"
            Case 12
                DeviceType = "ISDB-S"
        End Select
        Return DeviceType
    End Function

    Private Function GetTranslation(Message As String) As String
        Try
            If GlobalLanguage = "en-US" Then
                If Message = "(请选择设备)" Then
                    Return "(Please select a device)"
                ElseIf Message = "(无可用设备)" Then
                    Return "(No available device)"
                ElseIf Message = "(无)" Then
                    Return "(none)"
                ElseIf Message = "使能" Then
                    Return "Enabled"
                ElseIf Message = "窗体位置" Then
                    Return "Form position"
                ElseIf Message = "当前窗体位置" Then
                    Return "Current form position"
                ElseIf Message = "关于" Then
                    Return "About"
                End If
            End If
            Return Message
        Catch ex As Exception
            Return Message
        End Try
    End Function

    Public Function GetTraversalConfig(Port As Integer) As String
        Return Path.GetTempPath() & "\frpc_tcp_" & Port.ToString() & ".toml"
    End Function

    Public Function GetViterbirateType(FEC As Integer) As String
        Dim ViterbirateType As String = ""
        Select Case FEC
            Case 1
                ViterbirateType = "1/2"
            Case 2
                ViterbirateType = "2/3"
            Case 3
                ViterbirateType = "3/4"
            Case 4
                ViterbirateType = "4/5"
            Case 5
                ViterbirateType = "5/6"
            Case 6
                ViterbirateType = "6/7"
            Case 7
                ViterbirateType = "7/8"
            Case 8
                ViterbirateType = "8/9"
            Case 9
                ViterbirateType = "9/10"
            Case 10
                ViterbirateType = "1/4"
            Case 11
                ViterbirateType = "1/3"
            Case 12
                ViterbirateType = "2/5"
            Case 13
                ViterbirateType = "3/5"
            Case 14
                ViterbirateType = "5/9"
            Case 15
                ViterbirateType = "7/9"
            Case 16
                ViterbirateType = "8/15"
            Case 17
                ViterbirateType = "11/15"
            Case 18
                ViterbirateType = "13/18"
            Case 19
                ViterbirateType = "9/20"
            Case 20
                ViterbirateType = "11/20"
            Case 21
                ViterbirateType = "23/36"
            Case 22
                ViterbirateType = "25/36"
            Case 23
                ViterbirateType = "13/45"
            Case 24
                ViterbirateType = "26/45"
            Case 25
                ViterbirateType = "28/45"
            Case 26
                ViterbirateType = "32/45"
            Case 27
                ViterbirateType = "77/90"
        End Select
        Return ViterbirateType
    End Function

    Public Function GetWebpage(URL As String, Optional IgnoreSize As Boolean = True, Optional GetStatusCode As Boolean = False) As Byte()
        Try
            Dim httpReq As System.Net.HttpWebRequest
            Dim httpResp As System.Net.HttpWebResponse
            Dim httpURL As New System.Uri(URL)
            httpReq = CType(WebRequest.Create(httpURL), HttpWebRequest)
            httpReq.Method = "GET"
            httpReq.AllowAutoRedirect = True
            httpReq.Timeout = 10000
            httpReq.KeepAlive = True
            httpReq.ServicePoint.ConnectionLimit = Integer.MaxValue
            httpResp = CType(httpReq.GetResponse(), HttpWebResponse)
            Dim ContentLengthHeader As String = httpResp.Headers("Content-Length")
            Dim reader As New BinaryReader(httpResp.GetResponseStream)
            Dim returnBuffer As Byte() = reader.ReadBytes(1048576)
            If GetStatusCode Then
                Return Encoding.UTF8.GetBytes(httpResp.StatusCode)
            End If
            If returnBuffer.Length = ContentLengthHeader Or IgnoreSize Then
                Return returnBuffer
            Else
                Return New Byte() {}
            End If
        Catch ex As Exception
            Return New Byte() {}
        End Try
    End Function

    Public Function HexToBytes(param1 As String) As Byte()
        Return Enumerable.Range(0, param1.Length).Where(Function(x) x Mod 2 = 0).[Select](Function(x) Convert.ToByte(param1.Substring(x, 2), 16)).ToArray()
    End Function

    Public Class HTTPClient
        Dim ClientSocket As TcpClient
        Dim ClientBufferId As String
        ReadOnly ClientBufferTimeout As Integer = 6000
        Dim CSABuffer As Boolean = False

        Public Sub StartClient(param1 As TcpClient, param2 As Long, param3 As Boolean)
            Try
                ClientSocket = param1
                ClientBufferId = param2
                CSABuffer = param3
                ClientSocket.ReceiveBufferSize = 1 * 1024 * 1024
                ClientSocket.SendBufferSize = TSPacketSize * 50 * 1024
                Dim _loc_1 As New Thread(AddressOf HTTPResponse)
                _loc_1.Start()
            Catch ex As Exception

            End Try
        End Sub

        Private Sub HTTPResponse()
            Try
                Dim ReceiveBuffer(65535) As Byte
                Dim _loc_1 As NetworkStream = ClientSocket.GetStream()

                While ClientBufferId = BufferId
                    Try
                        If Not ClientSocket.Connected Then Exit While
                        Dim _loc_2 As Integer = _loc_1.Read(ReceiveBuffer, 0, ReceiveBuffer.Length)
                        If _loc_2 > 4 Then
                            Dim _loc_6 As Boolean = False
                            If ReceiveBuffer(_loc_2 - 4) = &HD And ReceiveBuffer(_loc_2 - 3) = &HA And ReceiveBuffer(_loc_2 - 2) = &HD And ReceiveBuffer(_loc_2 - 1) = &HA Then _loc_6 = True

                            If ClientSignature = "" Or BytesToHex(ReceiveBuffer).Contains(BytesToHex(Encoding.UTF8.GetBytes(ClientSignature))) Then
                                If _loc_6 Then
                                    Dim _loc_3 As Byte() = Encoding.UTF8.GetBytes(GetHTTPResponseOrHeader("200 OK", "video/mp2t"))
                                    _loc_1.Write(_loc_3, 0, _loc_3.Length)
                                End If
                            Else
                                If _loc_6 Then
                                    Dim _loc_7 As Byte() = Encoding.UTF8.GetBytes(GetHTTPResponseOrHeader("403 Forbidden"))
                                    _loc_1.Write(_loc_7, 0, _loc_7.Length)
                                End If
                                Exit Try
                            End If

                            Dim _loc_4 As Long = BufferAvailable + 1
                            If CSABuffer And CSAControlWordIsSet Then _loc_4 = CSABufferAvailable + 1
                            Dim _loc_5 As Long = _loc_4
                            Dim _loc_8 As Integer = 0

                            If CSABuffer Then
                                While ClientBufferId = BufferId
                                    If Not ClientSocket.Connected Or _loc_8 >= ClientBufferTimeout Then Exit While
                                    If CSAControlWordIsSet Then
                                        While _loc_4 <= CSABufferAvailable And CSABufferAvailable >= _loc_5
                                            If CSABufferAvailable >= _loc_4 + BufferSize Then _loc_4 = CSABufferAvailable
                                            _loc_1.Write(CSABufferRing(_loc_4 Mod BufferSize), 0, CSABufferRing(_loc_4 Mod BufferSize).Length)
                                            _loc_4 += 1
                                            _loc_8 = 0
                                        End While
                                        If _loc_4 > CSABufferAvailable Then
                                            _loc_8 += 1
                                            Thread.Sleep(10)
                                        End If
                                    Else
                                        While _loc_4 <= BufferAvailable And BufferAvailable >= _loc_5
                                            If BufferAvailable >= _loc_4 + BufferSize Then _loc_4 = BufferAvailable
                                            _loc_1.Write(BufferRing(_loc_4 Mod BufferSize), 0, BufferRing(_loc_4 Mod BufferSize).Length)
                                            _loc_4 += 1
                                            _loc_8 = 0
                                        End While
                                        If _loc_4 > BufferAvailable Then
                                            _loc_8 += 1
                                            Thread.Sleep(10)
                                        End If
                                    End If
                                End While
                            Else
                                While ClientBufferId = BufferId
                                    If Not ClientSocket.Connected Or _loc_8 >= ClientBufferTimeout Then Exit While
                                    While _loc_4 <= BufferAvailable And BufferAvailable >= _loc_5
                                        If BufferAvailable >= _loc_4 + BufferSize Then _loc_4 = BufferAvailable
                                        _loc_1.Write(BufferRing(_loc_4 Mod BufferSize), 0, BufferRing(_loc_4 Mod BufferSize).Length)
                                        _loc_4 += 1
                                        _loc_8 = 0
                                    End While
                                    If _loc_4 > BufferAvailable Then
                                        _loc_8 += 1
                                        Thread.Sleep(10)
                                    End If
                                End While
                            End If
                        End If
                    Catch ex As Exception

                    Finally
                        _loc_1.Flush()
                        _loc_1.Close()
                        ClientSocket.Close()
                    End Try
                End While
            Catch ex As Exception

            End Try
        End Sub

        Private Function BytesToHex(param1 As Byte()) As String
            Return BitConverter.ToString(param1).Replace("-", "").ToUpper
        End Function
    End Class

    Public Sub HTTPDaemon(Port As String)
        Try
            Dim _loc_3 As Boolean = False
            If Port.EndsWith("!") Or Port.ToUpper().EndsWith("D") Then
                Port = Port.Substring(0, Port.Length - 1)
                _loc_3 = True
            End If

            Traversal(Int(Port))
            Dim ServerSocket As New TcpListener(IPAddress.IPv6Any, Int(Port))
            ServerSocket.Server.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only, False)
            Try
                Dim _loc_1 As Long = BufferId
                Dim ClientSocket As TcpClient
                ServerSocket.Start()
                If _loc_3 Then
                    AvailableCSAStream = Port
                Else
                    AvailableStream = Port
                End If
                While _loc_1 = BufferId
                    ClientSocket = ServerSocket.AcceptTcpClient()
                    _loc_1 = BufferId
                    Dim _loc_2 As New HTTPClient
                    _loc_2.StartClient(ClientSocket, _loc_1, _loc_3)
                End While
            Catch ex As Exception

            Finally
                ServerSocket.Stop()
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LblBERValue_DoubleClick(sender As Object, e As EventArgs) Handles LblBERValue.DoubleClick
        Try
            If BufferValid < -3 Then BufferValid = -10
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LblDescrambleFileInput_Click(sender As Object, e As EventArgs) Handles LblDescrambleFileInput.Click
        Try
            Process.Start("explorer.exe", New IO.FileInfo(TxtDescrambleFileInput.Text).DirectoryName)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LblDescrambleFileOutput_Click(sender As Object, e As EventArgs) Handles LblDescrambleFileOutput.Click
        Try
            Process.Start("explorer.exe", New IO.FileInfo(TxtDescrambleFileOutput.Text).DirectoryName)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LblHeading_MouseClick(sender As Object, e As MouseEventArgs) Handles LblHeading.MouseClick
        Try
            If e.Button = MouseButtons.Right Then
                MsgBox(GetTranslation("当前窗体位置") & " (" & Left & ", " & Top & ")", vbInformation, GetTranslation("窗体位置"))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LblLockParameter_Click(sender As Object, e As EventArgs) Handles LblLockParameter.Click
        Try
            If Signal.MIS > 0 And False Then
                Dim _loc_1 As String = ""
                For _loc_2 As Integer = 0 To Signal.MIS_Array.Length - 1
                    _loc_1 &= "[" & Int(_loc_2 + 1).ToString.PadLeft(2, "0") & "]  " & Int(Signal.MIS_Array(_loc_2)) & vbCrLf
                Next
                MsgBox(_loc_1.Trim(), vbInformation, "Input Stream Identifier (ISI)")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub LockCarrier()
        Try
            ResetStream()
            LblLockParameter.Text = ""
            ChkAutoBLScan2.Checked = False

            Dim LockInput As String = GetSegmentedString(TxtCarrier.Text).Replace(",", "").Replace("！", "!").Replace("？", "?").ToUpper().Trim()
            TxtCarrier.Text = LockInput

            Dim Streaming As Boolean = True
            If LockInput.EndsWith("!") Then
                Streaming = False
                LockInput = LockInput.Substring(0, LockInput.Length - 1)
            End If

            Dim Standby As Boolean = False
            If LockInput.EndsWith("?") Then
                Standby = True
                LockInput = LockInput.Substring(0, LockInput.Length - 1)
            End If

            Dim CarrierInput As String = ""
            Dim PLSInput As String = ""
            Dim MISInput As String = ""
            Dim InputMode As String = "CARRIER"
            Dim PLSMode As Integer = 0
            For _loc_1 As Integer = 0 To LockInput.Length - 1
                Dim _loc_2 As String = LockInput.Substring(_loc_1, 1)
                If _loc_2 = "R" Then
                    InputMode = "PLS"
                    PLSInput = ""
                    PLSMode = 0
                ElseIf _loc_2 = "P" Or _loc_2 = "G" Then
                    InputMode = "PLS"
                    PLSInput = ""
                    PLSMode = 1
                ElseIf _loc_2 = "C" Then
                    InputMode = "PLS"
                    PLSInput = ""
                    PLSMode = 2
                ElseIf _loc_2 = "M" Or _loc_2 = "I" Or _loc_2 = "S" Then
                    InputMode = "MIS"
                    MISInput = ""
                Else
                    If InputMode = "CARRIER" Then
                        CarrierInput &= _loc_2
                    ElseIf InputMode = "PLS" Then
                        PLSInput &= _loc_2
                    ElseIf InputMode = "MIS" Then
                        MISInput &= _loc_2
                    End If
                End If
            Next

            If PLSInput.Length > 0 Then
                PLSSel(PLSMode, Int(PLSInput))
                PLSConfigured = True
            Else
                If PLSConfigured Then PLSSel(1, 0)
            End If

            Dim SearchParameter As SEARCH_PARAMETER = GetSearchParameter(CarrierInput, TxtLOF.Text, TxtLOFSW.Text)
            Dim LockOK As Boolean = False
            If SearchParameter.SR > 0 Then
                LockOK = SetChannelEx(SearchParameter.Freq, SearchParameter.SR, SearchParameter.Pol, 0, SearchParameter.Lof1, SearchParameter.Lof2, SearchParameter.LofSW, 0)
                SearchParameterCurrent = SearchParameter
            Else
                Dim Signal As SEARCH_RESULT = Nothing
                LockOK = BLScanEx(SearchParameter.Freq, 1000, SearchParameter.Pol, SearchParameter.Lof1, SearchParameter.Lof2, SearchParameter.LofSW, 1000000, 0, Signal)
                If LockOK Then SearchParameter.SR = Signal.SR
                SearchParameterCurrent = Nothing
            End If

            If LockOK Then
                If MISInput.Length > 0 Then MISSel(True, Int(MISInput))
                CarrierCurrent = ReplacePol(Int(SearchParameter.Freq / 1000) & SearchParameter.PolChar & RoundSR(Int(SearchParameter.SR / 1000)), GetAdapterConfiguration("Pol"))
                CarrierCurrentWithRemark = CarrierCurrent
                Dim _loc_4 As String = Remark
                If Not _loc_4 = "" Then CarrierCurrentWithRemark = CarrierCurrent & " " & _loc_4
                Text = CarrierCurrentWithRemark
                LblLockParameter.Text = CarrierCurrent

                Dim _loc_1 As String = GetAdapterConfiguration("Log")
                If Not _loc_1 = "" Then
                    Try
                        If Not My.Computer.FileSystem.DirectoryExists(_loc_1.Trim()) Then My.Computer.FileSystem.CreateDirectory(_loc_1.Trim())
                    Catch ex As Exception

                    End Try

                    Dim _loc_2 As String = ""
                    If My.Computer.FileSystem.DirectoryExists(_loc_1.Trim()) Then _loc_2 = _loc_1.Trim() & "\adapter" & DVBDeviceCurrent & ".log"

                    LogEnabled = True
                    RecordLog("[Lock] " & CarrierCurrentWithRemark)

                    If Not _loc_2 = "" Then
                        LogPathCurrent = _loc_2
                        Dim _loc_3 As New Thread(AddressOf LogDaemon)
                        _loc_3.Start(_loc_2)
                    End If
                End If

                TabMain.SelectedIndex = TapInfo.TabIndex
                TmrSignalInfo.Enabled = True
                If Streaming Then StartStream()
                If Standby Then CarrierStandby = True
            Else
                MsgBox("设置转发器失败！", vbExclamation, "")
            End If
        Catch ex As Exception
            MsgBox("转发器参数输入不正确！", vbExclamation, "")
        End Try
    End Sub

    Public Function RoundPort(Port As String, Increment As Integer) As String
        Try
            If Port.EndsWith("+") And Increment >= 0 Then Return (Int(Port.Substring(0, Port.Length - 1)) + Increment).ToString()
            Return Port
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function RoundSR(SR As Integer) As Integer
        Try
            If StringToBool(GetAdapterConfiguration("NoRound")) Then Return SR
            If SR >= 13331 And SR <= 13334 Then Return 13333
            If SR >= 28783 And SR <= 28801 Then Return 28800
            If SR >= 1998 Then
                For _loc_1 As Integer = -1 To 2
                    If (SR + _loc_1) Mod 10 = 0 Then
                        Return SR + _loc_1
                    End If
                Next
            End If
            Return SR
        Catch ex As Exception
            Return SR
        End Try
    End Function

    Public Sub LoadConfig(ConfigIndex As Integer, Optional LNBPowerReset As Boolean = False)
        Try
            BLScan2Reset()
            Remark = ""

            Dim _loc_10 As String = Application.StartupPath & "\adapter" & ConfigIndex & ".cfg"
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

                AdapterConfiguration = New NameValueCollection
                Dim _loc_5 As New Regex("[ ]{2,}", RegexOptions.None)
                For Each _loc_6 As String In _loc_3
                    If Not _loc_6 = "" And Not _loc_6.StartsWith("#") And _loc_6.Contains("=") Then
                        Dim _loc_7 As String = _loc_5.Replace(_loc_6, " ")
                        Dim _loc_8 As String = _loc_7.Substring(0, _loc_7.IndexOf("="))
                        Dim _loc_9 As String = _loc_7.Substring(_loc_8.Length + 1).Trim()
                        _loc_8 = _loc_8.Trim().ToUpper()
                        If _loc_8 = "CARRIER" Then
                            TxtCarrier.Text = _loc_9
                        ElseIf _loc_8 = "LOF" Then
                            TxtLOF.Text = _loc_9
                        ElseIf _loc_8 = "LOFSW" Then
                            TxtLOFSW.Text = _loc_9
                        ElseIf _loc_8 = "CW" Then
                            TxtControlWord.Text = _loc_9
                        ElseIf _loc_8 = "CWSET" Then
                            If StringToBool(_loc_9) Then SetControlWord()
                        ElseIf _loc_8 = "TASK" Then
                            AddTask(_loc_9)
                        ElseIf _loc_8 = "REMARK" Then
                            Remark = _loc_9
                            Dim _loc_15 As Integer = -1
                            For _loc_16 As Integer = 0 To CboRemark.Items.Count - 1
                                If CboRemark.Items(_loc_16).ToString() = _loc_9 Then
                                    _loc_15 = _loc_16
                                    Exit For
                                End If
                            Next
                            If _loc_15 <> -1 Then CboRemark.SelectedIndex = _loc_15
                        ElseIf _loc_8 = "RANGE" Or _loc_8 = "SEARCHRANGE" Then
                            TxtBLScan2.Text = _loc_9
                        ElseIf _loc_8 = "BLOCK" Then
                            If Int(_loc_9) >= 128 Then BufferSize = Int(_loc_9)
                        ElseIf _loc_8 = "SEARCHFREQFILTER" Then
                            BLScan2FreqFilter = _loc_9
                        ElseIf _loc_8 = "SEARCHPOL" Then
                            BLScan2Pol = _loc_9.ToUpper()
                        ElseIf _loc_8 = "SEARCHSTEP" Then
                            BLScan2Step = Int(_loc_9)
                        ElseIf _loc_8 = "DISEQC" Then
                            Dim _loc_11 As String() = _loc_9.Split(",")
                            If _loc_11.Length > 1 And SendDiSEqCAvailable Then
                                If SendDiSEqC(Int(_loc_11(0)), Int(_loc_11(1))) Then SendDiSEqCAvailable = False
                            End If
                        ElseIf _loc_8 = "POSITION" Then
                            Dim _loc_11 As String() = _loc_9.Split(",")
                            If _loc_11.Length > 1 And PositionAdaptationAvailable Then
                                Left = Int(_loc_11(0))
                                Top = Int(_loc_11(1))
                                PositionAdaptationAvailable = False
                            End If
                        ElseIf _loc_8 = "ADMINISTRATION" Then
                            Dim _loc_14 As String = RoundPort(_loc_9, ConfigIndex)
                            If Int(_loc_14) > 0 Then
                                APIDaemonAvailable = False
                                Dim _loc_13 As New Thread(AddressOf APIDaemon)
                                _loc_13.Start(_loc_14)
                                LblAPIEnabled.ForeColor = Color.Green
                                LblAPIEnabled.Text = GetTranslation("使能") & " (" & _loc_14 & ")"
                            End If
                        ElseIf _loc_8 = "AUTHORIZATION" Then
                            APICredentials = _loc_9
                        ElseIf _loc_8 = "CLIENTSIGNATURE" Then
                            ClientSignature = _loc_9
                        ElseIf _loc_8 = "GETESCALATION" Then
                            ChkGetEscalation.Checked = True
                        ElseIf _loc_8 = "SETESCALATION" Then
                            ChkSetEscalation.Checked = True
                        Else
                            AdapterConfiguration.Add(_loc_8, _loc_9)
                        End If
                    End If
                Next

                If LNBPowerReset Then SetLNBPowerOff()
                If StringToBool(GetAdapterConfiguration("SEARCH")) Then
                    BtnBLScan2Handler()
                ElseIf StringToBool(GetAdapterConfiguration("LOCK")) Then
                    BtnCarrierHandler()
                End If
            Else
                If LNBPowerReset Then SetLNBPowerOff()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub LogDaemon(LogPath As String)
        Try
            Dim _loc_2 As String = BufferId
            While BufferId = _loc_2
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

    Private Sub LstBLScan2_DoubleClick(sender As Object, e As EventArgs) Handles LstBLScan2.DoubleClick
        Try
            If Not BgwBLScan2.IsBusy Then
                Dim SelectedIndex As Integer = LstBLScan2.SelectedIndex
                Dim _loc_1 As String = LstBLScan2.Items(SelectedIndex).Split(" ")(0)
                If _loc_1.Length > 1 Then
                    TxtCarrier.Text = _loc_1
                    LockCarrier()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LstBLScan2_MouseDown(sender As Object, e As MouseEventArgs) Handles LstBLScan2.MouseDown
        Try
            If e.Button = MouseButtons.Right And LstBLScan2.Items.Count > 0 Then
                Dim _loc_1 As String = ""
                If StringToBool(GetAdapterConfiguration("ClipboardFreq")) Then
                    For Each _loc_2 As String In LstBLScan2.Items
                        For _loc_3 As Integer = 1 To _loc_2.Length - 1
                            If Not IsNumeric(_loc_2.Substring(0, _loc_3)) Then
                                _loc_1 &= _loc_2.Substring(0, _loc_3) & ","
                                Exit For
                            End If
                        Next
                    Next
                ElseIf StringToBool(GetAdapterConfiguration("ClipboardCarrier")) Then
                    For Each _loc_2 As String In LstBLScan2.Items
                        _loc_1 &= _loc_2.Split(" ")(0) & ","
                    Next
                Else
                    For Each _loc_2 As String In LstBLScan2.Items
                        _loc_1 &= _loc_2 & vbCrLf
                    Next
                End If
                If _loc_1.Length > 0 Then Clipboard.SetText(_loc_1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LstDevice_DoubleClick(sender As Object, e As EventArgs) Handles LstDevice.DoubleClick
        Try
            BtnDeviceSelectHandler()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LstDevice_KeyDown(sender As Object, e As KeyEventArgs) Handles LstDevice.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                BtnDeviceSelectHandler()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LstDevice_MouseDown(sender As Object, e As MouseEventArgs) Handles LstDevice.MouseDown
        Try
            If e.Button = System.Windows.Forms.MouseButtons.Right And LstDevice.SelectedIndex >= 0 Then
                Dim _loc_1 As String = Application.StartupPath & "\adapter" & LstDevice.SelectedIndex & ".cfg"
                If My.Computer.FileSystem.FileExists(_loc_1) Then
                    Process.Start(_loc_1)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LstTask_DoubleClick(sender As Object, e As EventArgs) Handles LstTask.DoubleClick
        Try
            Dim _loc_1 As String = LstTask.Items(LstTask.SelectedIndex)
            Dim _loc_2 As String = _loc_1.Split("]")(1).Trim()
            If My.Computer.FileSystem.DirectoryExists(_loc_2) Then
                Process.Start("explorer.exe", _loc_2)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MainUI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            e.Cancel = 1
            Dim _loc_1 As Boolean = False
            If BufferAvailable > -1 Then
                If MsgBox("任务正在进行，您确定要结束任务并退出程序吗？", vbQuestion + vbYesNo, Text) = vbYes Then
                    TraversalTerminateAll()
                    Dispose()
                    End
                End If
            Else
                TraversalTerminateAll()
                Dispose()
                End
            End If
        Catch ex As Exception
            TraversalTerminateAll()
            Dispose()
            End
        End Try
    End Sub

    Private Sub MainUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MainUIHandle = Me

            TapDevice.TabIndex = 0
            TapSetting.TabIndex = 1
            TapInfo.TabIndex = 2
            TapService.TabIndex = 3
            TapDescramble.TabIndex = 4
            TapSearch.TabIndex = 5
            TapAdministration.TabIndex = 6

            If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\FFDecsa_v2.dll") Then
                MsgBox("由于找不到 FFDecsa_v2.dll，无法继续执行代码。重新安装程序可能会解决此问题。", vbCritical, "OmniSNG - 系统错误")
                End
            End If

            If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\SDTParse.dll") Then
                MsgBox("由于找不到 SDTParse.dll，无法继续执行代码。重新安装程序可能会解决此问题。", vbCritical, "OmniSNG - 系统错误")
                End
            End If

            If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\StreamReader.dll") Then
                MsgBox("由于找不到 StreamReader.dll，无法继续执行代码。重新安装程序可能会解决此问题。", vbCritical, "OmniSNG - 系统错误")
                End
            End If

            Try
                Dim SystemDefaultLangID As UShort = GetSystemDefaultLangID()
                If Not (SystemDefaultLangID = 1028 Or SystemDefaultLangID = 2052 Or SystemDefaultLangID = 3076 Or SystemDefaultLangID = 4100 Or SystemDefaultLangID = 5124) Then GlobalLanguage = "en-US"

                If GlobalLanguage = "en-US" Then
                    TapDevice.Text = "[1] Device"
                    BtnDeviceSelect.Text = "Select (&E)"
                    BtnDeviceSearch.Text = "Lookup (&D)"

                    TapSetting.Text = "[2] Setup"
                    LblCarrier.Text = "Carrier"
                    BtnCarrier.Text = "Lock (&S)"
                    LblLOF.Text = "LOF (MHz):"
                    LblLOFSW.Text = "LOF Sw. (MHz):"
                    BtnTaskRecord.Text = "Add Recording (&R)"
                    BtnTaskTransfer.Text = "Add Streaming (&T)"
                    BtnTaskRemove.Text = "Remove Task (&X)"

                    TapInfo.Text = "[3] Info"

                    TapService.Text = "[4] Service"
                    ClhServiceID.Text = "ID"
                    ClhServiceName.Text = "Service Name"
                    ClhServiceProvider.Text = "Service Provider"

                    TapDescramble.Text = "[5] Descrambler"
                    LblControlWord.Text = "  CW  "
                    BtnControlWord.Text = "Set (&K)"
                    LblDescrambleProgress.Text = "Prog."
                    LblDescrambleRemain.Text = "Rem."
                    LblDescrambleFileOutput.Text = "File output:"
                    LblDescrambleFileInput.Text = "File input:"

                    TapSearch.Text = "[6] Search"
                    LblBLScan2.Text = " Range "
                    BtnBLScan2.Text = "Search (&F)"
                    ChkAutoBLScan2.Text = "Automatic search"
                    BtnBLScan2Clear.Text = "Clear list (&W)"

                    TapAdministration.Text = "[7] Manage"
                    LblRemark.Text = "Remark"
                    BtnRemark.Text = "Go (&G)"
                    LblAPI.Text = "Remote Acc."
                    LblAPIEnabled.Text = "Disabled"
                    ChkGetEscalation.Text = "Enable remote access authentication"
                    ChkSetEscalation.Text = "Enable remote command dispatch"
                End If
            Catch ex As Exception

            End Try

            Try
                For Each RemarkFile In Directory.GetFiles(Application.StartupPath, "*.cfg")
                    Dim RemarkFileName As String = Path.GetFileNameWithoutExtension(RemarkFile)
                    If Not RemarkFileName.StartsWith("adapter") And Not RemarkFileName.StartsWith("common") And Not RemarkFileName.StartsWith("descrambler") Then
                        CboRemark.Items.Add(RemarkFileName)
                    End If
                Next
            Catch ex As Exception

            Finally
                If CboRemark.Items.Count = 0 Then
                    CboRemark.Items.Add(GetTranslation("(无)"))
                Else
                    BtnRemark.Enabled = True
                End If
                CboRemark.SelectedIndex = 0
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MainUI_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            If Command.Length > 0 And My.Computer.FileSystem.FileExists(Application.StartupPath & "\" & Command() & ".cfg") Then
                ShowDispatch(Command)
            Else
                BtnDeviceSearch_Click(sender, e)
                If LstDevice.Items.Count > 0 Then
                    If IsNumeric(Command) Then
                        LstDevice.SelectedIndex = Math.Floor(Int(Command))
                        LstDevice_DoubleClick(sender, e)
                    End If
                Else
                    TabMain.SelectedIndex = TapDescramble.TabIndex
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Function NativeUtf8ToString(nativeUtf8 As IntPtr) As String
        Try
            Dim Len As Integer = 0
            While Marshal.ReadByte(nativeUtf8, Len) <> 0
                Len += 1
            End While
            If Len = 0 Then Return ""
            Dim Buffer As Byte() = New Byte(Len - 1) {}
            Marshal.Copy(nativeUtf8, Buffer, 0, Len)
            Dim Result = Encoding.UTF8.GetString(Buffer)
            Return Result
        Catch
            Return ""
        End Try
    End Function

    Private Sub PicBadge_MouseClick(sender As Object, e As MouseEventArgs) Handles PicBadge.MouseClick
        Try
            If e.Button = MouseButtons.Right Then
                MsgBox("此软件包含的第三方软件由权利持有人保留一切权利。" & vbCrLf & "软件： StreamReaderEx for BDA Tuners" & vbCrLf & "版权声明： " & vbCrLf & vbTab & "Copyright (C) 2010-2023 CrazyCat" & vbCrLf & vbCrLf & "此软件包含的开源软件由权利持有人发放许可证。" & vbCrLf & "软件： FFDecsa (Altx)" & vbCrLf & "许可证： GPL v2 License" & vbCrLf & "许可证文本： https://www.gnu.org/licenses/gpl-2.0.txt" & vbCrLf & "版权声明： " & vbCrLf & vbTab & "Copyright (C) 2003-2004 fatih89r" & vbCrLf & vbTab & "Copyright (C) 2004-2015 altxro" & vbCrLf & vbCrLf & "软件： libdvbpsi" & vbCrLf & "许可证： LGPL v2.1" & vbCrLf & "许可证文本： https://www.gnu.org/licenses/lgpl-2.1.txt" & vbCrLf & "版权声明： " & vbCrLf & vbTab & "Copyright (C) 2001-2011 VideoLAN", vbInformation, "第三方软件使用声明")
            Else
                Dim VersionStrings As String() = Application.ProductVersion.ToString.Split(".")
                MsgBox("OmniSNG" & vbCrLf & vbCrLf & "多功能数字卫星新闻采集信号接收系统" & vbCrLf & vbCrLf & "软件版本：" & VersionStrings(0) & "." & VersionStrings(1) & "." & VersionStrings(2) & vbCrLf & "更新时间：20" & VersionStrings(3).Substring(0, 2) & "年" & Int(VersionStrings(3).Substring(2, 2)) & "月" & vbCrLf & vbCrLf & "Copyright © 2022-20" & VersionStrings(3).Substring(0, 2) & " 版权所有", vbInformation, GetTranslation("关于"))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub PVRDaemon(RecFile As String)
        Try
            Dim _loc_6 As Integer = 0
            Dim _loc_3 As Long = BufferId
            While BufferId = _loc_3 And _loc_6 <= 10
                If BufferValid = BufferId Then
                    If Not My.Computer.FileSystem.DirectoryExists(RecFile) Then My.Computer.FileSystem.CreateDirectory(RecFile)
                    Dim FilenamePrefix As String = "REC"
                    If CarrierCurrent.Length > 0 Then FilenamePrefix = ReplacePol(CarrierCurrent, GetAdapterConfiguration("Pol"))
                    Dim _loc_1 As New IO.FileStream(RecFile & "\" & GetPVRFileName(FilenamePrefix), IO.FileMode.Create)
                    Dim _loc_2 As New IO.BinaryWriter(_loc_1)
                    Try
                        AvailablePVR = _loc_1.Name
                        Dim _loc_4 As Long = BufferAvailable + 1
                        Dim _loc_5 As Long = _loc_4
                        While BufferId = _loc_3
                            While _loc_4 <= BufferAvailable And BufferAvailable >= _loc_5
                                If BufferAvailable >= _loc_4 + BufferSize Then
                                    _loc_4 = BufferAvailable
                                End If
                                _loc_2.Write(BufferRing(_loc_4 Mod BufferSize))
                                _loc_4 += 1
                            End While
                            If _loc_4 > BufferAvailable Then Threading.Thread.Sleep(10)
                        End While
                    Catch ex As Exception
                        _loc_6 += 1
                    Finally
                        Dim _loc_12 As String = _loc_1.Name
                        _loc_2.Close()
                        _loc_1.Close()
                        If BufferDelete = _loc_3 Or New FileInfo(_loc_12).Length = 0 Then File.Delete(_loc_12)
                    End Try
                Else
                    Thread.Sleep(100)
                End If
            End While
        Catch ex As Exception

        End Try
    End Sub

    Public Sub RecordLog(Message As String, Optional ForceRecord As Boolean = False)
        Try
            If LogMessage.Length > 1048576 Then LogMessage = ""
            If LogEnabled Or ForceRecord Then
                LogMessage &= "[" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "] " & Message & vbCrLf & vbCrLf
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function ReplacePol(Input As String, PolChar As String) As String
        Try
            If PolChar.Length = 0 Then Return Input
            PolChar = PolChar.ToUpper()
            For _loc_1 As Integer = 1 To Input.Length
                If Not IsNumeric(Input.Substring(0, _loc_1).Replace("-", "0")) Then
                    Dim _loc_2 As String = Input.Substring(_loc_1 - 1, 1).ToUpper()
                    Dim _loc_3 As String = ""
                    For Each _loc_4 As String In PolChar.Split(",")
                        If _loc_4.Length = 1 Then
                            _loc_3 = _loc_4
                        ElseIf _loc_4.Length > 1 Then
                            If _loc_2 = _loc_4.Substring(1, 1) Then
                                _loc_3 = _loc_4.Substring(0, 1)
                            End If
                        End If
                        If _loc_3.Length > 0 Then
                            Return Input.Substring(0, _loc_1 - 1) & _loc_3 & Input.Substring(_loc_1)
                        End If
                    Next
                End If
            Next
            Return Input
        Catch ex As Exception
            Return Input
        End Try
    End Function

    Public Sub ReportDaemon(URL As String)
        Try
            Dim ReportAttempt As Integer = 0
            Dim _loc_2 As Long = BufferId
            While BufferId = _loc_2 And ReportAttempt < 10
                Try
                    Dim _loc_1 As Byte() = GetWebpage(URL, True, True)
                    If Encoding.UTF8.GetString(_loc_1).StartsWith("20") Then
                        Exit Sub
                    Else
                        ReportAttempt += 1
                        Thread.Sleep(10000)
                    End If
                Catch ex As Exception

                End Try
            End While
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ResetSignalInfo()
        Try
            TmrSignalInfo.Enabled = False
            CarrierCurrent = ""
            CarrierCurrentWithRemark = ""
            SearchParameterCurrent = Nothing
            ModeParameters = ""
            LblLockParameter.Text = ""
            LblLockParameter.BackColor = Color.Transparent
            LblBERValue.Text = "100%"
            LblSNRValue.Text = "0.00 dB"
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ResetStream(Optional ResetServiceList As Boolean = True)
        Try
            If Not Text = ApplicationTitle And Not Text.Contains("[") And BufferStopwatch.IsRunning Then Text &= " [停止]"
            DelFilter(FilterCurrent)
            AvailableCSAPVR = ""
            AvailablePVR = ""
            BufferId += 1
            BufferAvailable = -1
            BufferCount = 0
            BufferStopwatch.Reset()
            BufferValid = -5
            CarrierExclude = False
            CarrierStandby = False
            CSABufferAvailable = -1
            CSAControlWord = ""
            CSAControlWordIsSet = False
            BtnControlWord.BackColor = Color.Transparent
            LogEnabled = False
            LogMessage = ""
            LogPathCurrent = ""
            If BufferRing.Count <= BufferSize Then
                BufferRing.Clear()
                CSABufferRing.Clear()
                For _loc_1 As Integer = 1 To BufferSize
                    BufferRing.Add(New Byte() {})
                    CSABufferRing.Add(New Byte() {})
                Next
            End If
            If ResetServiceList Then
                SDTServices.Clear()
                SDTServicesHash = ""
                LsvService.Items.Clear()
            End If
            LblPacketValue.Text = "0"
            LblCorruptValue.Text = "0"
            BERCount = -1
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Restart()
        Try
            If DVBDeviceCurrent >= 0 And Time() - ApplicationStartTime > 10 Then
                Dim _loc_1 As Integer = DVBDeviceCurrent
                StopDVB()
                ResetStream()
                ResetSignalInfo()
                TraversalTerminateAll()
                Process.Start(Application.ExecutablePath, _loc_1.ToString())
                Dispose()
                End
            End If
        Catch ex As Exception

        End Try
    End Sub

    <Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions>
    Public Sub SDTDaemon()
        Try
            Dim _loc_3 As Long = BufferId
            While BufferId = _loc_3
                Dim _loc_1 As IntPtr = dvbpsi_decoder_new(4096)
                Dim _loc_2 As IntPtr = Marshal.AllocHGlobal(TSPacketSize)
                Try
                    Dim _loc_4 As Long = BufferAvailable + 1
                    Dim _loc_5 As Long = _loc_4
                    While BufferId = _loc_3
                        While _loc_4 <= BufferAvailable And BufferAvailable >= _loc_5
                            If BufferAvailable >= _loc_4 + BufferSize Then
                                _loc_4 = BufferAvailable
                            End If
                            Dim _loc_6 As Byte() = BufferRing(_loc_4 Mod BufferSize)
                            For _loc_7 As Integer = 0 To _loc_6.Length - TSPacketSize Step TSPacketSize
                                If ((_loc_6(_loc_7 + 1) And &H1F) << 8 Or _loc_6(_loc_7 + 2)) = &H11 Then
                                    Marshal.Copy(_loc_6, _loc_7, _loc_2, TSPacketSize)
                                    Dim _loc_8 As List(Of ServiceInfo) = GetServiceInfo(_loc_1, _loc_2)
                                    If _loc_8 IsNot Nothing Then
                                        Dim _loc_10 As New List(Of String())
                                        For _loc_9 As Integer = 0 To _loc_8.Count - 1
                                            _loc_10.Add(New String() {_loc_8(_loc_9).ServiceId, _loc_8(_loc_9).Names(0).Item1, _loc_8(_loc_9).Names(0).Item2})
                                        Next
                                        SDTServices = _loc_10
                                        Thread.Sleep(5000)
                                        _loc_4 = BufferAvailable
                                        Exit While
                                    End If
                                End If
                            Next
                            _loc_4 += 1
                        End While
                        If _loc_4 > BufferAvailable Then Threading.Thread.Sleep(10)
                    End While
                Catch ex As Exception

                Finally
                    Marshal.FreeHGlobal(_loc_2)
                    dvbpsi_decoder_delete(_loc_1)
                    Thread.Sleep(100)
                End Try
            End While
        Catch ex As Exception

        End Try
    End Sub

    Public Sub SendControlWord(ControlWord As String)
        Try
            Dim _loc_1 As String = Application.StartupPath & "\descrambler.cfg"
            If My.Computer.FileSystem.FileExists(_loc_1) Then
                Dim _loc_2 As String = My.Computer.FileSystem.ReadAllText(_loc_1).Trim()
                Dim _loc_3 As Integer = _loc_2.ToUpper().IndexOf("CWSEND=")
                If _loc_3 > -1 Then
                    Dim _loc_4 As String = _loc_2.Substring(_loc_3 + 7)
                    Dim _loc_5 As String = ""
                    If CarrierCurrentWithRemark.Length > 0 And BufferAvailable > -1 Then
                        _loc_5 = CarrierCurrentWithRemark
                    ElseIf My.Computer.FileSystem.FileExists(TxtDescrambleFileInput.Text) Then
                        _loc_5 = Path.GetFileNameWithoutExtension(TxtDescrambleFileInput.Text)
                    ElseIf TxtCarrier.Text.Length > 0 Then
                        _loc_5 = TxtCarrier.Text.ToUpper().Trim()
                    End If
                    If _loc_5.Length > 0 Then
                        Dim _loc_6 As New Thread(AddressOf ReportDaemon)
                        _loc_6.Start(_loc_4 & "Tag=" & _loc_5 & ",CW=" & ControlWord)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Class ServiceInfo
        Public ServiceId As UInt16
        Public Names As List(Of Tuple(Of String, String))
    End Class

    Public Sub SetControlWord()
        Try
            Dim ControlWord As String = TxtControlWord.Text.Replace(" ", "").Replace(".", "").Replace("[", "").Replace("]", "").Replace("。", "F").ToUpper().Trim()
            Dim _loc_4 As MatchCollection = Regex.Matches(ControlWord, "#CW:([0-9a-fA-F]{16})")
            If _loc_4.Count > 0 Then ControlWord = _loc_4(0).Groups(1).Value.ToUpper()
            TxtControlWord.Text = ControlWord

            If ControlWord.Length = 12 Then
                Dim _loc_1 As String = Hex(Int(HexToBytes(ControlWord.Substring(0, 2))(0) + Int(HexToBytes(ControlWord.Substring(2, 2))(0)) + Int(HexToBytes(ControlWord.Substring(4, 2))(0)))).PadLeft(2, "0")
                Dim _loc_2 As String = Hex(Int(HexToBytes(ControlWord.Substring(6, 2))(0) + Int(HexToBytes(ControlWord.Substring(8, 2))(0)) + Int(HexToBytes(ControlWord.Substring(10, 2))(0)))).PadLeft(2, "0")
                Dim _loc_3 As String = ControlWord.Substring(0, 6) + _loc_1.Substring(_loc_1.Length - 2, 2) + ControlWord.Substring(6, 6) + _loc_2.Substring(_loc_2.Length - 2, 2)
                ControlWord = _loc_3
            End If

            If ControlWord.Length = 16 Then
                CSAParallelSize = get_internal_parallelism()
                If CSAParallelSize > 0 Then
                    set_control_words(HexToBytes(ControlWord), HexToBytes(ControlWord), CSAKeys)
                    CSAControlWord = ControlWord
                    CSAControlWordIsSet = True
                    BtnControlWord.BackColor = Color.LawnGreen
                    SendControlWord(ControlWord)
                    Exit Sub
                End If
            End If

            BtnControlWord.BackColor = Color.Transparent
            MsgBox("设置控制字失败！", vbExclamation, "")
        Catch ex As Exception
            BtnControlWord.BackColor = Color.Transparent
            MsgBox("设置控制字失败！", vbExclamation, "")
        End Try
    End Sub

    Public Sub SetFilterCallBack(dataPtr As IntPtr, len As UInteger)
        Try
            Dim _loc_1 As Object = SetFilterCallbackLock
            ObjectFlowControl.CheckForSyncLockOnValueType(_loc_1)
            SyncLock _loc_1
                If len >= BufferLength Then
                    Dim _loc_2 As Integer = (BufferAvailable + 1) Mod BufferSize
                    BufferRing(_loc_2) = New Byte(len - 1) {}
                    Marshal.Copy(dataPtr, BufferRing(_loc_2), 0, len)
                    BufferAvailable += 1
                    BufferCount += len
                Else
                    Dim _loc_3 As Byte() = New Byte(len - 1) {}
                    Marshal.Copy(dataPtr, _loc_3, 0, len)
                    BufferCache.Write(_loc_3, 0, _loc_3.Length)
                End If
                If BufferCache.Length >= BufferLength Then
                    Dim _loc_4 As Integer = (BufferAvailable + 1) Mod BufferSize
                    BufferRing(_loc_4) = New Byte(BufferCache.Length - 1) {}
                    BufferCache.Position = 0
                    BufferCache.Read(BufferRing(_loc_4), 0, BufferRing(_loc_4).Length)
                    BufferCache = New MemoryStream
                    BufferAvailable += 1
                    BufferCount += BufferRing(_loc_4).Length
                End If
            End SyncLock
        Catch ex As Exception

        End Try
    End Sub

    Public Sub SetLNBPowerOff()
        Try
            If StringToBool(GetAdapterConfiguration("MandatoryPower")) Then Exit Try
            SetChannelEx(10700000, 10000000, -1, 0, 9750000, 10600000, 11700000, 0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ShowDispatch(Remark As String)
        Try
            Hide()
            Dispatch.Remark = Remark
            Dispatch.Show()
        Catch ex As Exception

        End Try
    End Sub

    Public Function StartStream() As Boolean
        Try
            SetFilterCallbackHandle = AddressOf SetFilterCallBack
            If SetFilter(8192, SetFilterCallbackHandle, 2, 1, FilterCurrent) Then
                BufferStopwatch.Start()
                Dim _loc_1 As New Thread(AddressOf CSADaemon)
                _loc_1.Start()
                Dim _loc_2 As New Thread(AddressOf SDTDaemon)
                _loc_2.Start()
                For Each _loc_3 As String In LstTask.Items
                    StartTask(_loc_3)
                Next
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub StartTask(Task As String)
        Try
            If Task.ToUpper().StartsWith("[TCP]") Then
                Dim _loc_1 As New Thread(AddressOf HTTPDaemon)
                _loc_1.Start(Task.Substring(5).Trim())
            ElseIf Task.ToUpper().StartsWith("[REC]") Then
                Dim _loc_2 As New Thread(AddressOf PVRDaemon)
                _loc_2.Start(Task.Substring(5).Trim())
                _loc_2 = New Thread(AddressOf CSAPVRDaemon)
                _loc_2.Start(Task.Substring(5).Trim())
            ElseIf Task.ToUpper().StartsWith("[EXE]") Then
                Dim _loc_3 As String = Task.Substring(5).Trim()
                Dim _loc_4 As Integer = _loc_3.IndexOf(",")
                If _loc_4 > 1 Then
                    Process.Start(_loc_3.Substring(0, _loc_4).Trim(), _loc_3.Substring(_loc_4 + 1).Trim())
                Else
                    Process.Start(_loc_3)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function StringToBool(Input As String) As Boolean
        Try
            If Input.StartsWith("1") Or Input.ToLower().StartsWith("t") Or Input.ToLower().StartsWith("y") Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub TapDescramble_DragDrop(sender As Object, e As DragEventArgs) Handles TapDescramble.DragDrop
        Try
            Dim DragFilePath As String() = e.Data.GetData(DataFormats.FileDrop)
            If My.Computer.FileSystem.FileExists(DragFilePath(0)) Then
                TxtDescrambleFileInput.Text = DragFilePath(0)
                DescrambleFile()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TapDescramble_DragEnter(sender As Object, e As DragEventArgs) Handles TapDescramble.DragEnter
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) = True Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.None
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Function Time() As Long
        Return (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
    End Function

    Private Sub TmrSignalInfo_Tick(sender As Object, e As EventArgs) Handles TmrSignalInfo.Tick
        Try
            If DVBDeviceCurrent < 0 Then Exit Try
            Dim ServiceName As String = ""
            If LsvService.Items.Count > 0 Then ServiceName = LsvService.Items(0).SubItems(2).Text.Trim()
            If ServiceName.Length > 0 And BufferStopwatch.IsRunning Then
                Text = ServiceName & " - " & GetBufferDuration()
            ElseIf CarrierCurrent.Length > 0 And BufferStopwatch.IsRunning Then
                Text = CarrierCurrentWithRemark & " - " & GetBufferDuration()
            End If
            SignalInfo(Signal)
            Dim LockString As String = "No"
            If Signal.Lock Then
                LblLockParameter.BackColor = Color.LawnGreen
                LblLockParameter.Text = GetLockString(Signal)
                LockString = "Yes"
            Else
                LblLockParameter.BackColor = Color.Transparent
            End If
            If Not Text.Contains("(") Then
                Dim ISI As Integer = GetISI(Signal)
                If ISI > 0 Then
                    CarrierCurrentWithRemark &= " (" & ISI.ToString() & ")"
                    Text = CarrierCurrentWithRemark
                End If
            End If
            Dim BERScaled As String = GetBERRatio(Signal.BER)
            LblBERValue.Text = BERScaled
            Dim PacketValue As String = Math.Floor(BufferCount / TSPacketSize) & " (" & FileSizeToString(BufferCount) & ")"
            LblPacketValue.Text = PacketValue
            Dim SNRFormated As String = FormatNumber(Signal.SNR, 2, vbTrue) & " dB"
            If (Not BufferValid = BufferId And Signal.BER = 0) Or BufferValid = -10 Then
                If BufferValid >= -3 Or BufferValid = -10 Then
                    BufferValid = BufferId
                Else
                    BufferValid += 1
                End If
            End If
            If Signal.BER <= 0.0000001 Then
                LblBERValue.BackColor = Color.Transparent
                LblBERValue.ForeColor = Color.Black
                If BERCount < 0 Then BERCount = 0
            Else
                LblBERValue.BackColor = Color.Red
                LblBERValue.ForeColor = Color.White
                If BERCount >= 0 Then
                    BERCount += 1
                    LblCorruptValue.Text = BERCount
                    If LogEnabled And BufferAvailable > -1 Then RecordLog("[" & GetBufferDuration() & "] " & CarrierCurrentWithRemark & "  BER: " & BERScaled & "  SNR: " & SNRFormated & "  Corrupt: " & BERCount & "  Packet: " & PacketValue)
                End If
            End If
            If Signal.SNR >= -100 And Signal.SNR < 1000 Then LblSNRValue.Text = SNRFormated
            Dim Services As String = ""
            If SDTServices.Count > 0 Then
                Dim ServicesHash As String = ""
                For Each Service In SDTServices
                    If Service.Count >= 3 Then
                        ServicesHash &= Service(0) & Service(1) & Service(2)
                        Services &= "<service><serviceid>" & Service(0) & "</serviceid><servicename>" & SecurityElement.Escape(Service(1)) & "</servicename><serviceprovider>" & SecurityElement.Escape(Service(2)) & "</serviceprovider></service>"
                    End If
                Next
                If Not ServicesHash = SDTServicesHash Then
                    LsvService.Items.Clear()
                    For Each Service In SDTServices
                        If Service.Count >= 3 Then
                            LsvService.Items.Add("")
                            LsvService.Items(LsvService.Items.Count - 1).Checked = False
                            LsvService.Items(LsvService.Items.Count - 1).SubItems.Add(Service(0))
                            LsvService.Items(LsvService.Items.Count - 1).SubItems.Add(Service(1))
                            LsvService.Items(LsvService.Items.Count - 1).SubItems.Add(Service(2))
                            If LogEnabled Then RecordLog("[Service] ID: " & Service(0) & "  Name: " & Service(1) & "  Provider: " & Service(2))
                        End If
                    Next
                    SDTServicesHash = ServicesHash
                End If
            End If
            ModeParameters = "<mode>reception</mode><task>" & BufferId & "</task><duration>" & GetBufferDurationSeconds() & "</duration><carrier>" & LblLockParameter.Text & "</carrier><lock>" & LockString & "</lock><ber>" & Signal.BER & "</ber><snr>" & SNRFormated & "</snr><length>" & BufferCount & "</length><corrupt>" & BERCount & "</corrupt><pvr>" & AvailablePVR & "</pvr><csapvr>" & AvailableCSAPVR & "</csapvr><stream>" & AvailableStream & "</stream><csastream>" & AvailableCSAStream & "</csastream><cw>" & CSAControlWord & "</cw>" & Services & "<standby>" & If(CarrierStandby, "Yes", "No") & "</standby><exclude>" & If(CarrierExclude, "Yes", "No") & "</exclude>"
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Traversal(Port As Integer)
        Try
            If My.Computer.FileSystem.FileExists(TraversalBinary) And My.Computer.FileSystem.FileExists(TraversalConfig) And Not TraversalDaemons.Contains(Port) Then
                If TraversalTerminate(Port) Then Thread.Sleep(5000)
                TraversalDaemons.Add(Port)
                Dim _loc_7 As New Thread(AddressOf TraversalDaemon)
                _loc_7.Start(Port)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub TraversalDaemon(Port As Integer)
        Try
            Dim _loc_1 As String = My.Computer.FileSystem.ReadAllText(TraversalConfig).Replace("{localPort}", Port.ToString()).Replace("{random}", Time() & GetRndString(4))
            Dim _loc_2 As Match = Regex.Match(_loc_1, "\{localPort\+(\d+)\}")
            If _loc_2.Success Then _loc_1 = _loc_1.Replace(_loc_2.Value, (Int(_loc_2.Groups(1).Value) + Port).ToString())
            _loc_2 = Regex.Match(_loc_1, "\{localPort\-(\d+)\}")
            If _loc_2.Success Then _loc_1 = _loc_1.Replace(_loc_2.Value, (Port - Int(_loc_2.Groups(1).Value)).ToString())
            My.Computer.FileSystem.WriteAllText(GetTraversalConfig(Port), _loc_1, False, Encoding.Default)

            While True
                Dim _loc_6 As New Process()
                _loc_6.StartInfo.FileName = "frpc.exe"
                _loc_6.StartInfo.Arguments = "-c " & Chr(34) & GetTraversalConfig(Port) & Chr(34)
                _loc_6.StartInfo.CreateNoWindow = True
                _loc_6.StartInfo.UseShellExecute = False
                If TraversalDaemons.Contains(Port) Then
                    _loc_6.Start()
                    _loc_6.WaitForExit()
                End If
                _loc_6.Close()
                Thread.Sleep(5000)
            End While
        Catch ex As Exception

        Finally
            TraversalDaemons.Remove(Port)
        End Try
    End Sub

    Public Function TraversalTerminate(Port As Integer)
        Try
            For Each _loc_3 As Process In Process.GetProcesses()
                If _loc_3.ProcessName = "frpc" Then
                    For Each _loc_4 As ManagementObject In New ManagementObjectSearcher("SELECT CommandLine FROM Win32_Process WHERE ProcessId = " & _loc_3.Id).Get()
                        If _loc_4("CommandLine") IsNot Nothing Then
                            If _loc_4("CommandLine").ToString().Replace(Chr(34), "").EndsWith("frpc_tcp_" & Port.ToString() & ".toml") Then
                                _loc_3.Kill()
                                Return True
                            End If
                        End If
                    Next
                End If
            Next
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub TraversalTerminateAll()
        Try
            If TraversalDaemons.Count > 0 Then
                For _loc_1 As Integer = TraversalDaemons.Count - 1 To 0 Step -1
                    Dim Port As Integer = TraversalDaemons(_loc_1)
                    TraversalDaemons.Remove(port)
                    TraversalTerminate(Port)
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtBLScan2_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBLScan2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                BtnBLScan2Handler()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtBLScan2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBLScan2.KeyPress
        Try
            If Char.IsLower(e.KeyChar) Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            ElseIf e.KeyChar = "/" Then
                e.KeyChar = "H"c
            ElseIf e.KeyChar = "*" Then
                e.KeyChar = "V"c
            ElseIf e.KeyChar = "+" Then
                e.KeyChar = "A"c
            ElseIf e.KeyChar = "." Then
                e.KeyChar = "B"c
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtBLScan2_TextChanged(sender As Object, e As EventArgs) Handles TxtBLScan2.TextChanged
        Try
            ChkAutoBLScan2.Checked = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtCarrier_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCarrier.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                BtnCarrierHandler()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtCarrier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCarrier.KeyPress
        Try
            If Char.IsLower(e.KeyChar) Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            ElseIf e.KeyChar = "/" Then
                e.KeyChar = "H"c
            ElseIf e.KeyChar = "*" Then
                e.KeyChar = "V"c
            ElseIf e.KeyChar = "-" Then
                e.KeyChar = "!"c
            ElseIf e.KeyChar = "=" Then
                e.KeyChar = "?"c
            ElseIf e.KeyChar = "+" Then
                e.KeyChar = "A"c
            ElseIf e.KeyChar = "." Then
                e.KeyChar = "B"c
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtControlWord_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtControlWord.KeyDown
        Try
            If e.KeyCode = Keys.Enter And TxtControlWord.Text.Length >= 12 Then
                e.SuppressKeyPress = True
                BtnControlWordHandler()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtControlWord_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtControlWord.KeyPress
        Try
            If Char.IsLower(e.KeyChar) Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            ElseIf e.KeyChar = "-" Then
                e.KeyChar = "A"c
            ElseIf e.KeyChar = "*" Or e.KeyChar = "=" Then
                e.KeyChar = "B"c
            ElseIf e.KeyChar = "/" Or e.KeyChar = "_" Or e.KeyChar = "[" Then
                e.KeyChar = "C"c
            ElseIf e.KeyChar = "+" Or e.KeyChar = "]" Then
                e.KeyChar = "D"c
            ElseIf (e.KeyChar = Chr(13) And TxtControlWord.Text.Length < 12) Or e.KeyChar = "\" Then
                e.KeyChar = "E"c
            ElseIf e.KeyChar = "." Or e.KeyChar = "'" Then
                e.KeyChar = "F"c
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtControlWord_TextChanged(sender As Object, e As EventArgs) Handles TxtControlWord.TextChanged
        Try
            BtnControlWord.BackColor = Color.Transparent
        Catch ex As Exception

        End Try
    End Sub

End Class
