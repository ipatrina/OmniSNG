<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainUI
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainUI))
        Me.TabMain = New System.Windows.Forms.TabControl()
        Me.TapDevice = New System.Windows.Forms.TabPage()
        Me.BtnDeviceSelect = New System.Windows.Forms.Button()
        Me.BtnDeviceSearch = New System.Windows.Forms.Button()
        Me.LstDevice = New System.Windows.Forms.ListBox()
        Me.TapSetting = New System.Windows.Forms.TabPage()
        Me.BtnTaskRemove = New System.Windows.Forms.Button()
        Me.BtnTaskTransfer = New System.Windows.Forms.Button()
        Me.BtnTaskRecord = New System.Windows.Forms.Button()
        Me.LstTask = New System.Windows.Forms.ListBox()
        Me.TxtLOFSW = New System.Windows.Forms.TextBox()
        Me.TxtLOF = New System.Windows.Forms.TextBox()
        Me.LblLOFSW = New System.Windows.Forms.Label()
        Me.LblLOF = New System.Windows.Forms.Label()
        Me.BtnCarrier = New System.Windows.Forms.Button()
        Me.TxtCarrier = New System.Windows.Forms.TextBox()
        Me.LblCarrier = New System.Windows.Forms.Label()
        Me.TapInfo = New System.Windows.Forms.TabPage()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.LblCorruptValue = New System.Windows.Forms.Label()
        Me.LblCorrupt = New System.Windows.Forms.Label()
        Me.LblPacketValue = New System.Windows.Forms.Label()
        Me.LblPacket = New System.Windows.Forms.Label()
        Me.LblSNRValue = New System.Windows.Forms.Label()
        Me.LblSNR = New System.Windows.Forms.Label()
        Me.LblBERValue = New System.Windows.Forms.Label()
        Me.LblBER = New System.Windows.Forms.Label()
        Me.LblLockParameter = New System.Windows.Forms.Label()
        Me.LblLock = New System.Windows.Forms.Label()
        Me.TapService = New System.Windows.Forms.TabPage()
        Me.LsvService = New System.Windows.Forms.ListView()
        Me.ClhEnable = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhServiceID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhServiceName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhServiceProvider = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TapDescramble = New System.Windows.Forms.TabPage()
        Me.TxtDescrambleFileOutput = New System.Windows.Forms.TextBox()
        Me.BtnDescrambleFileOutput = New System.Windows.Forms.Button()
        Me.LblDescrambleFileOutput = New System.Windows.Forms.Label()
        Me.LblDescramblePercentage = New System.Windows.Forms.Label()
        Me.LblDescrambleRemainValue = New System.Windows.Forms.Label()
        Me.TxtDescrambleFileInput = New System.Windows.Forms.TextBox()
        Me.LblDescrambleRemain = New System.Windows.Forms.Label()
        Me.BtnDescrambleFileInput = New System.Windows.Forms.Button()
        Me.LblDescrambleProgressValue = New System.Windows.Forms.Label()
        Me.LblDescrambleFileInput = New System.Windows.Forms.Label()
        Me.LblDescrambleProgress = New System.Windows.Forms.Label()
        Me.BtnControlWord = New System.Windows.Forms.Button()
        Me.TxtControlWord = New System.Windows.Forms.TextBox()
        Me.LblControlWord = New System.Windows.Forms.Label()
        Me.TapSearch = New System.Windows.Forms.TabPage()
        Me.BtnBLScan2Clear = New System.Windows.Forms.Button()
        Me.ChkAutoBLScan2 = New System.Windows.Forms.CheckBox()
        Me.LstBLScan2 = New System.Windows.Forms.ListBox()
        Me.BtnBLScan2 = New System.Windows.Forms.Button()
        Me.TxtBLScan2 = New System.Windows.Forms.TextBox()
        Me.LblBLScan2 = New System.Windows.Forms.Label()
        Me.TapAdministration = New System.Windows.Forms.TabPage()
        Me.CboRemark = New System.Windows.Forms.ComboBox()
        Me.BtnRemark = New System.Windows.Forms.Button()
        Me.LblRemark = New System.Windows.Forms.Label()
        Me.ChkSetEscalation = New System.Windows.Forms.CheckBox()
        Me.ChkGetEscalation = New System.Windows.Forms.CheckBox()
        Me.LblAPIEnabled = New System.Windows.Forms.Label()
        Me.LblAPI = New System.Windows.Forms.Label()
        Me.LblHeading = New System.Windows.Forms.Label()
        Me.LblDevice = New System.Windows.Forms.Label()
        Me.TmrSignalInfo = New System.Windows.Forms.Timer(Me.components)
        Me.PicBadge = New System.Windows.Forms.PictureBox()
        Me.FbdRecord = New System.Windows.Forms.FolderBrowserDialog()
        Me.BgwBLScan2 = New System.ComponentModel.BackgroundWorker()
        Me.BgwFFDecsa = New System.ComponentModel.BackgroundWorker()
        Me.OfdDescrambleFile = New System.Windows.Forms.OpenFileDialog()
        Me.SfdDescrambleFile = New System.Windows.Forms.SaveFileDialog()
        Me.TabMain.SuspendLayout()
        Me.TapDevice.SuspendLayout()
        Me.TapSetting.SuspendLayout()
        Me.TapInfo.SuspendLayout()
        Me.TapService.SuspendLayout()
        Me.TapDescramble.SuspendLayout()
        Me.TapSearch.SuspendLayout()
        Me.TapAdministration.SuspendLayout()
        CType(Me.PicBadge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabMain
        '
        Me.TabMain.Controls.Add(Me.TapDevice)
        Me.TabMain.Controls.Add(Me.TapSetting)
        Me.TabMain.Controls.Add(Me.TapInfo)
        Me.TabMain.Controls.Add(Me.TapService)
        Me.TabMain.Controls.Add(Me.TapDescramble)
        Me.TabMain.Controls.Add(Me.TapSearch)
        Me.TabMain.Controls.Add(Me.TapAdministration)
        Me.TabMain.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabMain.Location = New System.Drawing.Point(12, 49)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.SelectedIndex = 0
        Me.TabMain.Size = New System.Drawing.Size(600, 380)
        Me.TabMain.TabIndex = 999
        '
        'TapDevice
        '
        Me.TapDevice.Controls.Add(Me.BtnDeviceSelect)
        Me.TapDevice.Controls.Add(Me.BtnDeviceSearch)
        Me.TapDevice.Controls.Add(Me.LstDevice)
        Me.TapDevice.Location = New System.Drawing.Point(4, 29)
        Me.TapDevice.Name = "TapDevice"
        Me.TapDevice.Padding = New System.Windows.Forms.Padding(3)
        Me.TapDevice.Size = New System.Drawing.Size(592, 347)
        Me.TapDevice.TabIndex = 0
        Me.TapDevice.Text = "[1] 设备"
        Me.TapDevice.UseVisualStyleBackColor = True
        '
        'BtnDeviceSelect
        '
        Me.BtnDeviceSelect.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnDeviceSelect.Location = New System.Drawing.Point(189, 299)
        Me.BtnDeviceSelect.Name = "BtnDeviceSelect"
        Me.BtnDeviceSelect.Size = New System.Drawing.Size(104, 39)
        Me.BtnDeviceSelect.TabIndex = 1101
        Me.BtnDeviceSelect.Text = "选择 (&E)"
        Me.BtnDeviceSelect.UseVisualStyleBackColor = True
        '
        'BtnDeviceSearch
        '
        Me.BtnDeviceSearch.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnDeviceSearch.Location = New System.Drawing.Point(300, 299)
        Me.BtnDeviceSearch.Name = "BtnDeviceSearch"
        Me.BtnDeviceSearch.Size = New System.Drawing.Size(104, 39)
        Me.BtnDeviceSearch.TabIndex = 1201
        Me.BtnDeviceSearch.Text = "检索 (&D)"
        Me.BtnDeviceSearch.UseVisualStyleBackColor = True
        '
        'LstDevice
        '
        Me.LstDevice.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LstDevice.FormattingEnabled = True
        Me.LstDevice.ItemHeight = 21
        Me.LstDevice.Location = New System.Drawing.Point(6, 12)
        Me.LstDevice.Name = "LstDevice"
        Me.LstDevice.Size = New System.Drawing.Size(580, 277)
        Me.LstDevice.TabIndex = 1001
        '
        'TapSetting
        '
        Me.TapSetting.Controls.Add(Me.BtnTaskRemove)
        Me.TapSetting.Controls.Add(Me.BtnTaskTransfer)
        Me.TapSetting.Controls.Add(Me.BtnTaskRecord)
        Me.TapSetting.Controls.Add(Me.LstTask)
        Me.TapSetting.Controls.Add(Me.TxtLOFSW)
        Me.TapSetting.Controls.Add(Me.TxtLOF)
        Me.TapSetting.Controls.Add(Me.LblLOFSW)
        Me.TapSetting.Controls.Add(Me.LblLOF)
        Me.TapSetting.Controls.Add(Me.BtnCarrier)
        Me.TapSetting.Controls.Add(Me.TxtCarrier)
        Me.TapSetting.Controls.Add(Me.LblCarrier)
        Me.TapSetting.Location = New System.Drawing.Point(4, 29)
        Me.TapSetting.Name = "TapSetting"
        Me.TapSetting.Size = New System.Drawing.Size(592, 347)
        Me.TapSetting.TabIndex = 2
        Me.TapSetting.Text = "[2] 参数"
        Me.TapSetting.UseVisualStyleBackColor = True
        '
        'BtnTaskRemove
        '
        Me.BtnTaskRemove.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnTaskRemove.Location = New System.Drawing.Point(383, 302)
        Me.BtnTaskRemove.Name = "BtnTaskRemove"
        Me.BtnTaskRemove.Size = New System.Drawing.Size(162, 39)
        Me.BtnTaskRemove.TabIndex = 2921
        Me.BtnTaskRemove.Text = "移除任务 (&X)"
        Me.BtnTaskRemove.UseVisualStyleBackColor = True
        '
        'BtnTaskTransfer
        '
        Me.BtnTaskTransfer.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnTaskTransfer.Location = New System.Drawing.Point(215, 302)
        Me.BtnTaskTransfer.Name = "BtnTaskTransfer"
        Me.BtnTaskTransfer.Size = New System.Drawing.Size(162, 39)
        Me.BtnTaskTransfer.TabIndex = 2911
        Me.BtnTaskTransfer.Text = "添加传输任务 (&T)"
        Me.BtnTaskTransfer.UseVisualStyleBackColor = True
        '
        'BtnTaskRecord
        '
        Me.BtnTaskRecord.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnTaskRecord.Location = New System.Drawing.Point(47, 302)
        Me.BtnTaskRecord.Name = "BtnTaskRecord"
        Me.BtnTaskRecord.Size = New System.Drawing.Size(162, 39)
        Me.BtnTaskRecord.TabIndex = 2901
        Me.BtnTaskRecord.Text = "添加存储任务 (&R)"
        Me.BtnTaskRecord.UseVisualStyleBackColor = True
        '
        'LstTask
        '
        Me.LstTask.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LstTask.FormattingEnabled = True
        Me.LstTask.ItemHeight = 21
        Me.LstTask.Location = New System.Drawing.Point(19, 102)
        Me.LstTask.Name = "LstTask"
        Me.LstTask.Size = New System.Drawing.Size(554, 193)
        Me.LstTask.TabIndex = 2801
        '
        'TxtLOFSW
        '
        Me.TxtLOFSW.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtLOFSW.Location = New System.Drawing.Point(444, 60)
        Me.TxtLOFSW.Name = "TxtLOFSW"
        Me.TxtLOFSW.Size = New System.Drawing.Size(127, 29)
        Me.TxtLOFSW.TabIndex = 2311
        Me.TxtLOFSW.Text = "11700"
        Me.TxtLOFSW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtLOF
        '
        Me.TxtLOF.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtLOF.Location = New System.Drawing.Point(151, 60)
        Me.TxtLOF.Name = "TxtLOF"
        Me.TxtLOF.Size = New System.Drawing.Size(127, 29)
        Me.TxtLOF.TabIndex = 2211
        Me.TxtLOF.Text = "9750/10600"
        Me.TxtLOF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblLOFSW
        '
        Me.LblLOFSW.AutoSize = True
        Me.LblLOFSW.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblLOFSW.Location = New System.Drawing.Point(309, 63)
        Me.LblLOFSW.Name = "LblLOFSW"
        Me.LblLOFSW.Size = New System.Drawing.Size(129, 21)
        Me.LblLOFSW.TabIndex = 2301
        Me.LblLOFSW.Text = "本振切换 (MHz):"
        '
        'LblLOF
        '
        Me.LblLOF.AutoSize = True
        Me.LblLOF.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblLOF.Location = New System.Drawing.Point(16, 63)
        Me.LblLOF.Name = "LblLOF"
        Me.LblLOF.Size = New System.Drawing.Size(129, 21)
        Me.LblLOF.TabIndex = 2201
        Me.LblLOF.Text = "本振频率 (MHz):"
        '
        'BtnCarrier
        '
        Me.BtnCarrier.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnCarrier.Location = New System.Drawing.Point(453, 8)
        Me.BtnCarrier.Name = "BtnCarrier"
        Me.BtnCarrier.Size = New System.Drawing.Size(120, 41)
        Me.BtnCarrier.TabIndex = 2021
        Me.BtnCarrier.Text = "锁定 (&S)"
        Me.BtnCarrier.UseVisualStyleBackColor = True
        '
        'TxtCarrier
        '
        Me.TxtCarrier.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtCarrier.Location = New System.Drawing.Point(89, 9)
        Me.TxtCarrier.Name = "TxtCarrier"
        Me.TxtCarrier.Size = New System.Drawing.Size(351, 39)
        Me.TxtCarrier.TabIndex = 2011
        Me.TxtCarrier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblCarrier
        '
        Me.LblCarrier.AutoSize = True
        Me.LblCarrier.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblCarrier.Location = New System.Drawing.Point(14, 17)
        Me.LblCarrier.Name = "LblCarrier"
        Me.LblCarrier.Size = New System.Drawing.Size(69, 25)
        Me.LblCarrier.TabIndex = 2001
        Me.LblCarrier.Text = "转发器"
        '
        'TapInfo
        '
        Me.TapInfo.Controls.Add(Me.BtnStop)
        Me.TapInfo.Controls.Add(Me.LblCorruptValue)
        Me.TapInfo.Controls.Add(Me.LblCorrupt)
        Me.TapInfo.Controls.Add(Me.LblPacketValue)
        Me.TapInfo.Controls.Add(Me.LblPacket)
        Me.TapInfo.Controls.Add(Me.LblSNRValue)
        Me.TapInfo.Controls.Add(Me.LblSNR)
        Me.TapInfo.Controls.Add(Me.LblBERValue)
        Me.TapInfo.Controls.Add(Me.LblBER)
        Me.TapInfo.Controls.Add(Me.LblLockParameter)
        Me.TapInfo.Controls.Add(Me.LblLock)
        Me.TapInfo.Location = New System.Drawing.Point(4, 29)
        Me.TapInfo.Name = "TapInfo"
        Me.TapInfo.Size = New System.Drawing.Size(592, 347)
        Me.TapInfo.TabIndex = 3
        Me.TapInfo.Text = "[3] 信息"
        Me.TapInfo.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.BackColor = System.Drawing.Color.Red
        Me.BtnStop.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStop.ForeColor = System.Drawing.Color.White
        Me.BtnStop.Location = New System.Drawing.Point(513, 10)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(55, 50)
        Me.BtnStop.TabIndex = 3201
        Me.BtnStop.Text = "■"
        Me.BtnStop.UseVisualStyleBackColor = False
        '
        'LblCorruptValue
        '
        Me.LblCorruptValue.AutoSize = True
        Me.LblCorruptValue.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblCorruptValue.Location = New System.Drawing.Point(472, 296)
        Me.LblCorruptValue.Name = "LblCorruptValue"
        Me.LblCorruptValue.Size = New System.Drawing.Size(24, 28)
        Me.LblCorruptValue.TabIndex = 3811
        Me.LblCorruptValue.Text = "0"
        '
        'LblCorrupt
        '
        Me.LblCorrupt.AutoSize = True
        Me.LblCorrupt.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblCorrupt.Location = New System.Drawing.Point(377, 296)
        Me.LblCorrupt.Name = "LblCorrupt"
        Me.LblCorrupt.Size = New System.Drawing.Size(89, 28)
        Me.LblCorrupt.TabIndex = 3801
        Me.LblCorrupt.Text = "Corrupt"
        '
        'LblPacketValue
        '
        Me.LblPacketValue.AutoSize = True
        Me.LblPacketValue.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblPacketValue.Location = New System.Drawing.Point(99, 296)
        Me.LblPacketValue.Name = "LblPacketValue"
        Me.LblPacketValue.Size = New System.Drawing.Size(24, 28)
        Me.LblPacketValue.TabIndex = 3711
        Me.LblPacketValue.Text = "0"
        '
        'LblPacket
        '
        Me.LblPacket.AutoSize = True
        Me.LblPacket.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblPacket.Location = New System.Drawing.Point(14, 296)
        Me.LblPacket.Name = "LblPacket"
        Me.LblPacket.Size = New System.Drawing.Size(79, 28)
        Me.LblPacket.TabIndex = 3701
        Me.LblPacket.Text = "Packet"
        '
        'LblSNRValue
        '
        Me.LblSNRValue.AutoSize = True
        Me.LblSNRValue.Font = New System.Drawing.Font("微软雅黑", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblSNRValue.Location = New System.Drawing.Point(90, 176)
        Me.LblSNRValue.Name = "LblSNRValue"
        Me.LblSNRValue.Size = New System.Drawing.Size(264, 83)
        Me.LblSNRValue.TabIndex = 3511
        Me.LblSNRValue.Text = "0.00 dB"
        '
        'LblSNR
        '
        Me.LblSNR.AutoSize = True
        Me.LblSNR.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblSNR.Location = New System.Drawing.Point(14, 204)
        Me.LblSNR.Name = "LblSNR"
        Me.LblSNR.Size = New System.Drawing.Size(55, 28)
        Me.LblSNR.TabIndex = 3501
        Me.LblSNR.Text = "SNR"
        '
        'LblBERValue
        '
        Me.LblBERValue.AutoSize = True
        Me.LblBERValue.Font = New System.Drawing.Font("微软雅黑", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblBERValue.Location = New System.Drawing.Point(90, 74)
        Me.LblBERValue.Name = "LblBERValue"
        Me.LblBERValue.Size = New System.Drawing.Size(206, 83)
        Me.LblBERValue.TabIndex = 3311
        Me.LblBERValue.Text = "100%"
        '
        'LblBER
        '
        Me.LblBER.AutoSize = True
        Me.LblBER.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblBER.Location = New System.Drawing.Point(14, 103)
        Me.LblBER.Name = "LblBER"
        Me.LblBER.Size = New System.Drawing.Size(51, 28)
        Me.LblBER.TabIndex = 3301
        Me.LblBER.Tag = ""
        Me.LblBER.Text = "BER"
        '
        'LblLockParameter
        '
        Me.LblLockParameter.BackColor = System.Drawing.Color.Transparent
        Me.LblLockParameter.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblLockParameter.Location = New System.Drawing.Point(90, 15)
        Me.LblLockParameter.Name = "LblLockParameter"
        Me.LblLockParameter.Size = New System.Drawing.Size(400, 40)
        Me.LblLockParameter.TabIndex = 3111
        Me.LblLockParameter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblLock
        '
        Me.LblLock.AutoSize = True
        Me.LblLock.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblLock.Location = New System.Drawing.Point(14, 21)
        Me.LblLock.Name = "LblLock"
        Me.LblLock.Size = New System.Drawing.Size(58, 28)
        Me.LblLock.TabIndex = 3101
        Me.LblLock.Text = "Lock"
        '
        'TapService
        '
        Me.TapService.Controls.Add(Me.LsvService)
        Me.TapService.Location = New System.Drawing.Point(4, 29)
        Me.TapService.Name = "TapService"
        Me.TapService.Size = New System.Drawing.Size(592, 347)
        Me.TapService.TabIndex = 7
        Me.TapService.Text = "[4] 服务"
        Me.TapService.UseVisualStyleBackColor = True
        '
        'LsvService
        '
        Me.LsvService.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LsvService.CheckBoxes = True
        Me.LsvService.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClhEnable, Me.ClhServiceID, Me.ClhServiceName, Me.ClhServiceProvider})
        Me.LsvService.Font = New System.Drawing.Font("微软雅黑", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsvService.FullRowSelect = True
        Me.LsvService.HideSelection = False
        Me.LsvService.Location = New System.Drawing.Point(6, 12)
        Me.LsvService.Name = "LsvService"
        Me.LsvService.Size = New System.Drawing.Size(580, 322)
        Me.LsvService.TabIndex = 1002
        Me.LsvService.UseCompatibleStateImageBehavior = False
        Me.LsvService.View = System.Windows.Forms.View.Details
        '
        'ClhEnable
        '
        Me.ClhEnable.Text = ""
        Me.ClhEnable.Width = 30
        '
        'ClhServiceID
        '
        Me.ClhServiceID.Text = "服务 ID"
        Me.ClhServiceID.Width = 70
        '
        'ClhServiceName
        '
        Me.ClhServiceName.Text = "服务名"
        Me.ClhServiceName.Width = 220
        '
        'ClhServiceProvider
        '
        Me.ClhServiceProvider.Text = "服务提供商"
        Me.ClhServiceProvider.Width = 220
        '
        'TapDescramble
        '
        Me.TapDescramble.AllowDrop = True
        Me.TapDescramble.Controls.Add(Me.TxtDescrambleFileOutput)
        Me.TapDescramble.Controls.Add(Me.BtnDescrambleFileOutput)
        Me.TapDescramble.Controls.Add(Me.LblDescrambleFileOutput)
        Me.TapDescramble.Controls.Add(Me.LblDescramblePercentage)
        Me.TapDescramble.Controls.Add(Me.LblDescrambleRemainValue)
        Me.TapDescramble.Controls.Add(Me.TxtDescrambleFileInput)
        Me.TapDescramble.Controls.Add(Me.LblDescrambleRemain)
        Me.TapDescramble.Controls.Add(Me.BtnDescrambleFileInput)
        Me.TapDescramble.Controls.Add(Me.LblDescrambleProgressValue)
        Me.TapDescramble.Controls.Add(Me.LblDescrambleFileInput)
        Me.TapDescramble.Controls.Add(Me.LblDescrambleProgress)
        Me.TapDescramble.Controls.Add(Me.BtnControlWord)
        Me.TapDescramble.Controls.Add(Me.TxtControlWord)
        Me.TapDescramble.Controls.Add(Me.LblControlWord)
        Me.TapDescramble.Location = New System.Drawing.Point(4, 29)
        Me.TapDescramble.Name = "TapDescramble"
        Me.TapDescramble.Size = New System.Drawing.Size(592, 347)
        Me.TapDescramble.TabIndex = 5
        Me.TapDescramble.Text = "[5] 解扰"
        Me.TapDescramble.UseVisualStyleBackColor = True
        '
        'TxtDescrambleFileOutput
        '
        Me.TxtDescrambleFileOutput.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtDescrambleFileOutput.Location = New System.Drawing.Point(111, 276)
        Me.TxtDescrambleFileOutput.MaxLength = 1073741824
        Me.TxtDescrambleFileOutput.Name = "TxtDescrambleFileOutput"
        Me.TxtDescrambleFileOutput.ReadOnly = True
        Me.TxtDescrambleFileOutput.Size = New System.Drawing.Size(421, 29)
        Me.TxtDescrambleFileOutput.TabIndex = 5703
        '
        'BtnDescrambleFileOutput
        '
        Me.BtnDescrambleFileOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnDescrambleFileOutput.Location = New System.Drawing.Point(538, 275)
        Me.BtnDescrambleFileOutput.Name = "BtnDescrambleFileOutput"
        Me.BtnDescrambleFileOutput.Size = New System.Drawing.Size(35, 31)
        Me.BtnDescrambleFileOutput.TabIndex = 5705
        Me.BtnDescrambleFileOutput.Text = "..."
        Me.BtnDescrambleFileOutput.UseVisualStyleBackColor = True
        '
        'LblDescrambleFileOutput
        '
        Me.LblDescrambleFileOutput.AutoSize = True
        Me.LblDescrambleFileOutput.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblDescrambleFileOutput.Location = New System.Drawing.Point(15, 281)
        Me.LblDescrambleFileOutput.Name = "LblDescrambleFileOutput"
        Me.LblDescrambleFileOutput.Size = New System.Drawing.Size(90, 21)
        Me.LblDescrambleFileOutput.TabIndex = 5701
        Me.LblDescrambleFileOutput.Text = "输出文件："
        '
        'LblDescramblePercentage
        '
        Me.LblDescramblePercentage.Font = New System.Drawing.Font("微软雅黑", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblDescramblePercentage.ForeColor = System.Drawing.Color.MediumBlue
        Me.LblDescramblePercentage.Location = New System.Drawing.Point(19, 77)
        Me.LblDescramblePercentage.Name = "LblDescramblePercentage"
        Me.LblDescramblePercentage.Size = New System.Drawing.Size(554, 138)
        Me.LblDescramblePercentage.TabIndex = 5301
        Me.LblDescramblePercentage.Text = "0%"
        Me.LblDescramblePercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDescrambleRemainValue
        '
        Me.LblDescrambleRemainValue.AutoSize = True
        Me.LblDescrambleRemainValue.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblDescrambleRemainValue.Location = New System.Drawing.Point(486, 238)
        Me.LblDescrambleRemainValue.Name = "LblDescrambleRemainValue"
        Me.LblDescrambleRemainValue.Size = New System.Drawing.Size(88, 25)
        Me.LblDescrambleRemainValue.TabIndex = 5603
        Me.LblDescrambleRemainValue.Text = "00:00:00"
        '
        'TxtDescrambleFileInput
        '
        Me.TxtDescrambleFileInput.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtDescrambleFileInput.Location = New System.Drawing.Point(111, 312)
        Me.TxtDescrambleFileInput.MaxLength = 1073741824
        Me.TxtDescrambleFileInput.Name = "TxtDescrambleFileInput"
        Me.TxtDescrambleFileInput.ReadOnly = True
        Me.TxtDescrambleFileInput.Size = New System.Drawing.Size(421, 29)
        Me.TxtDescrambleFileInput.TabIndex = 5803
        '
        'LblDescrambleRemain
        '
        Me.LblDescrambleRemain.AutoSize = True
        Me.LblDescrambleRemain.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblDescrambleRemain.Location = New System.Drawing.Point(430, 238)
        Me.LblDescrambleRemain.Name = "LblDescrambleRemain"
        Me.LblDescrambleRemain.Size = New System.Drawing.Size(50, 25)
        Me.LblDescrambleRemain.TabIndex = 5601
        Me.LblDescrambleRemain.Text = "剩余"
        '
        'BtnDescrambleFileInput
        '
        Me.BtnDescrambleFileInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnDescrambleFileInput.Location = New System.Drawing.Point(538, 311)
        Me.BtnDescrambleFileInput.Name = "BtnDescrambleFileInput"
        Me.BtnDescrambleFileInput.Size = New System.Drawing.Size(35, 31)
        Me.BtnDescrambleFileInput.TabIndex = 5805
        Me.BtnDescrambleFileInput.Text = "&..."
        Me.BtnDescrambleFileInput.UseVisualStyleBackColor = True
        '
        'LblDescrambleProgressValue
        '
        Me.LblDescrambleProgressValue.AutoSize = True
        Me.LblDescrambleProgressValue.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblDescrambleProgressValue.Location = New System.Drawing.Point(70, 238)
        Me.LblDescrambleProgressValue.Name = "LblDescrambleProgressValue"
        Me.LblDescrambleProgressValue.Size = New System.Drawing.Size(116, 25)
        Me.LblDescrambleProgressValue.TabIndex = 5503
        Me.LblDescrambleProgressValue.Text = "0 MB/0 MB"
        '
        'LblDescrambleFileInput
        '
        Me.LblDescrambleFileInput.AutoSize = True
        Me.LblDescrambleFileInput.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblDescrambleFileInput.Location = New System.Drawing.Point(15, 317)
        Me.LblDescrambleFileInput.Name = "LblDescrambleFileInput"
        Me.LblDescrambleFileInput.Size = New System.Drawing.Size(90, 21)
        Me.LblDescrambleFileInput.TabIndex = 5801
        Me.LblDescrambleFileInput.Text = "输入文件："
        '
        'LblDescrambleProgress
        '
        Me.LblDescrambleProgress.AutoSize = True
        Me.LblDescrambleProgress.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblDescrambleProgress.Location = New System.Drawing.Point(14, 238)
        Me.LblDescrambleProgress.Name = "LblDescrambleProgress"
        Me.LblDescrambleProgress.Size = New System.Drawing.Size(50, 25)
        Me.LblDescrambleProgress.TabIndex = 5501
        Me.LblDescrambleProgress.Text = "进度"
        '
        'BtnControlWord
        '
        Me.BtnControlWord.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnControlWord.Location = New System.Drawing.Point(453, 8)
        Me.BtnControlWord.Name = "BtnControlWord"
        Me.BtnControlWord.Size = New System.Drawing.Size(120, 41)
        Me.BtnControlWord.TabIndex = 5121
        Me.BtnControlWord.Text = "设置 (&K)"
        Me.BtnControlWord.UseVisualStyleBackColor = True
        '
        'TxtControlWord
        '
        Me.TxtControlWord.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtControlWord.Location = New System.Drawing.Point(89, 9)
        Me.TxtControlWord.Name = "TxtControlWord"
        Me.TxtControlWord.Size = New System.Drawing.Size(351, 39)
        Me.TxtControlWord.TabIndex = 5111
        Me.TxtControlWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblControlWord
        '
        Me.LblControlWord.AutoSize = True
        Me.LblControlWord.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblControlWord.Location = New System.Drawing.Point(14, 17)
        Me.LblControlWord.Name = "LblControlWord"
        Me.LblControlWord.Size = New System.Drawing.Size(69, 25)
        Me.LblControlWord.TabIndex = 5101
        Me.LblControlWord.Text = "控制字"
        '
        'TapSearch
        '
        Me.TapSearch.Controls.Add(Me.BtnBLScan2Clear)
        Me.TapSearch.Controls.Add(Me.ChkAutoBLScan2)
        Me.TapSearch.Controls.Add(Me.LstBLScan2)
        Me.TapSearch.Controls.Add(Me.BtnBLScan2)
        Me.TapSearch.Controls.Add(Me.TxtBLScan2)
        Me.TapSearch.Controls.Add(Me.LblBLScan2)
        Me.TapSearch.Location = New System.Drawing.Point(4, 29)
        Me.TapSearch.Name = "TapSearch"
        Me.TapSearch.Size = New System.Drawing.Size(592, 347)
        Me.TapSearch.TabIndex = 4
        Me.TapSearch.Text = "[6] 搜索"
        Me.TapSearch.UseVisualStyleBackColor = True
        '
        'BtnBLScan2Clear
        '
        Me.BtnBLScan2Clear.Location = New System.Drawing.Point(453, 303)
        Me.BtnBLScan2Clear.Name = "BtnBLScan2Clear"
        Me.BtnBLScan2Clear.Size = New System.Drawing.Size(120, 32)
        Me.BtnBLScan2Clear.TabIndex = 4571
        Me.BtnBLScan2Clear.Text = "清空列表 (&W)"
        Me.BtnBLScan2Clear.UseVisualStyleBackColor = True
        '
        'ChkAutoBLScan2
        '
        Me.ChkAutoBLScan2.AutoSize = True
        Me.ChkAutoBLScan2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ChkAutoBLScan2.Location = New System.Drawing.Point(19, 307)
        Me.ChkAutoBLScan2.Name = "ChkAutoBLScan2"
        Me.ChkAutoBLScan2.Size = New System.Drawing.Size(93, 25)
        Me.ChkAutoBLScan2.TabIndex = 4501
        Me.ChkAutoBLScan2.Text = "自动搜索"
        Me.ChkAutoBLScan2.UseVisualStyleBackColor = True
        '
        'LstBLScan2
        '
        Me.LstBLScan2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LstBLScan2.FormattingEnabled = True
        Me.LstBLScan2.ItemHeight = 21
        Me.LstBLScan2.Location = New System.Drawing.Point(19, 59)
        Me.LstBLScan2.Name = "LstBLScan2"
        Me.LstBLScan2.Size = New System.Drawing.Size(554, 235)
        Me.LstBLScan2.TabIndex = 4201
        '
        'BtnBLScan2
        '
        Me.BtnBLScan2.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnBLScan2.Location = New System.Drawing.Point(453, 8)
        Me.BtnBLScan2.Name = "BtnBLScan2"
        Me.BtnBLScan2.Size = New System.Drawing.Size(120, 41)
        Me.BtnBLScan2.TabIndex = 4121
        Me.BtnBLScan2.Text = "搜索 (&F)"
        Me.BtnBLScan2.UseVisualStyleBackColor = True
        '
        'TxtBLScan2
        '
        Me.TxtBLScan2.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtBLScan2.Location = New System.Drawing.Point(108, 9)
        Me.TxtBLScan2.Name = "TxtBLScan2"
        Me.TxtBLScan2.Size = New System.Drawing.Size(332, 39)
        Me.TxtBLScan2.TabIndex = 4111
        Me.TxtBLScan2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblBLScan2
        '
        Me.LblBLScan2.AutoSize = True
        Me.LblBLScan2.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblBLScan2.Location = New System.Drawing.Point(14, 17)
        Me.LblBLScan2.Name = "LblBLScan2"
        Me.LblBLScan2.Size = New System.Drawing.Size(88, 25)
        Me.LblBLScan2.TabIndex = 4101
        Me.LblBLScan2.Text = "频率范围"
        '
        'TapAdministration
        '
        Me.TapAdministration.Controls.Add(Me.CboRemark)
        Me.TapAdministration.Controls.Add(Me.BtnRemark)
        Me.TapAdministration.Controls.Add(Me.LblRemark)
        Me.TapAdministration.Controls.Add(Me.ChkSetEscalation)
        Me.TapAdministration.Controls.Add(Me.ChkGetEscalation)
        Me.TapAdministration.Controls.Add(Me.LblAPIEnabled)
        Me.TapAdministration.Controls.Add(Me.LblAPI)
        Me.TapAdministration.Location = New System.Drawing.Point(4, 29)
        Me.TapAdministration.Name = "TapAdministration"
        Me.TapAdministration.Size = New System.Drawing.Size(592, 347)
        Me.TapAdministration.TabIndex = 6
        Me.TapAdministration.Text = "[7] 管理"
        Me.TapAdministration.UseVisualStyleBackColor = True
        '
        'CboRemark
        '
        Me.CboRemark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboRemark.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CboRemark.FormattingEnabled = True
        Me.CboRemark.Location = New System.Drawing.Point(108, 13)
        Me.CboRemark.Name = "CboRemark"
        Me.CboRemark.Size = New System.Drawing.Size(332, 33)
        Me.CboRemark.TabIndex = 6111
        '
        'BtnRemark
        '
        Me.BtnRemark.Enabled = False
        Me.BtnRemark.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnRemark.Location = New System.Drawing.Point(453, 8)
        Me.BtnRemark.Name = "BtnRemark"
        Me.BtnRemark.Size = New System.Drawing.Size(120, 41)
        Me.BtnRemark.TabIndex = 6121
        Me.BtnRemark.Text = "管理 (&G)"
        Me.BtnRemark.UseVisualStyleBackColor = True
        '
        'LblRemark
        '
        Me.LblRemark.AutoSize = True
        Me.LblRemark.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblRemark.Location = New System.Drawing.Point(14, 17)
        Me.LblRemark.Name = "LblRemark"
        Me.LblRemark.Size = New System.Drawing.Size(88, 25)
        Me.LblRemark.TabIndex = 6101
        Me.LblRemark.Text = "卫星别名"
        '
        'ChkSetEscalation
        '
        Me.ChkSetEscalation.AutoSize = True
        Me.ChkSetEscalation.Checked = True
        Me.ChkSetEscalation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkSetEscalation.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ChkSetEscalation.Location = New System.Drawing.Point(19, 150)
        Me.ChkSetEscalation.Name = "ChkSetEscalation"
        Me.ChkSetEscalation.Size = New System.Drawing.Size(157, 25)
        Me.ChkSetEscalation.TabIndex = 6611
        Me.ChkSetEscalation.Text = "使能远程参数下发"
        Me.ChkSetEscalation.UseVisualStyleBackColor = True
        '
        'ChkGetEscalation
        '
        Me.ChkGetEscalation.AutoSize = True
        Me.ChkGetEscalation.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ChkGetEscalation.Location = New System.Drawing.Point(19, 116)
        Me.ChkGetEscalation.Name = "ChkGetEscalation"
        Me.ChkGetEscalation.Size = New System.Drawing.Size(157, 25)
        Me.ChkGetEscalation.TabIndex = 6601
        Me.ChkGetEscalation.Text = "使能远程管理鉴权"
        Me.ChkGetEscalation.UseVisualStyleBackColor = True
        '
        'LblAPIEnabled
        '
        Me.LblAPIEnabled.AutoSize = True
        Me.LblAPIEnabled.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblAPIEnabled.ForeColor = System.Drawing.Color.Red
        Me.LblAPIEnabled.Location = New System.Drawing.Point(148, 77)
        Me.LblAPIEnabled.Name = "LblAPIEnabled"
        Me.LblAPIEnabled.Size = New System.Drawing.Size(69, 26)
        Me.LblAPIEnabled.TabIndex = 6511
        Me.LblAPIEnabled.Text = "未使能"
        '
        'LblAPI
        '
        Me.LblAPI.AutoSize = True
        Me.LblAPI.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblAPI.Location = New System.Drawing.Point(14, 77)
        Me.LblAPI.Name = "LblAPI"
        Me.LblAPI.Size = New System.Drawing.Size(126, 25)
        Me.LblAPI.TabIndex = 6501
        Me.LblAPI.Text = "远程管理状态"
        '
        'LblHeading
        '
        Me.LblHeading.AutoSize = True
        Me.LblHeading.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblHeading.Location = New System.Drawing.Point(58, 11)
        Me.LblHeading.Name = "LblHeading"
        Me.LblHeading.Size = New System.Drawing.Size(117, 28)
        Me.LblHeading.TabIndex = 101
        Me.LblHeading.Text = "OmniSNG"
        '
        'LblDevice
        '
        Me.LblDevice.Location = New System.Drawing.Point(181, 5)
        Me.LblDevice.Name = "LblDevice"
        Me.LblDevice.Size = New System.Drawing.Size(431, 40)
        Me.LblDevice.TabIndex = 201
        Me.LblDevice.Text = "(请选择设备)"
        Me.LblDevice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TmrSignalInfo
        '
        Me.TmrSignalInfo.Interval = 500
        '
        'PicBadge
        '
        Me.PicBadge.BackColor = System.Drawing.Color.Transparent
        Me.PicBadge.Image = CType(resources.GetObject("PicBadge.Image"), System.Drawing.Image)
        Me.PicBadge.Location = New System.Drawing.Point(12, 5)
        Me.PicBadge.Name = "PicBadge"
        Me.PicBadge.Size = New System.Drawing.Size(40, 40)
        Me.PicBadge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicBadge.TabIndex = 239
        Me.PicBadge.TabStop = False
        '
        'BgwBLScan2
        '
        '
        'BgwFFDecsa
        '
        Me.BgwFFDecsa.WorkerReportsProgress = True
        '
        'OfdDescrambleFile
        '
        Me.OfdDescrambleFile.Filter = "TS 传输流|*.ts|所有文件|*.*"
        '
        'SfdDescrambleFile
        '
        Me.SfdDescrambleFile.Filter = "TS 传输流|*.ts|所有文件|*.*"
        '
        'MainUI
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.PicBadge)
        Me.Controls.Add(Me.LblDevice)
        Me.Controls.Add(Me.LblHeading)
        Me.Controls.Add(Me.TabMain)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "MainUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "OmniSNG"
        Me.TabMain.ResumeLayout(False)
        Me.TapDevice.ResumeLayout(False)
        Me.TapSetting.ResumeLayout(False)
        Me.TapSetting.PerformLayout()
        Me.TapInfo.ResumeLayout(False)
        Me.TapInfo.PerformLayout()
        Me.TapService.ResumeLayout(False)
        Me.TapDescramble.ResumeLayout(False)
        Me.TapDescramble.PerformLayout()
        Me.TapSearch.ResumeLayout(False)
        Me.TapSearch.PerformLayout()
        Me.TapAdministration.ResumeLayout(False)
        Me.TapAdministration.PerformLayout()
        CType(Me.PicBadge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabMain As TabControl
    Friend WithEvents TapDevice As TabPage
    Friend WithEvents LblHeading As Label
    Friend WithEvents LblDevice As Label
    Friend WithEvents LstDevice As ListBox
    Friend WithEvents BtnDeviceSearch As Button
    Friend WithEvents TapSetting As TabPage
    Friend WithEvents LblCarrier As Label
    Friend WithEvents BtnCarrier As Button
    Friend WithEvents TxtCarrier As TextBox
    Friend WithEvents LblLOF As Label
    Friend WithEvents LblLOFSW As Label
    Friend WithEvents TxtLOFSW As TextBox
    Friend WithEvents TxtLOF As TextBox
    Friend WithEvents TapInfo As TabPage
    Friend WithEvents LblLock As Label
    Friend WithEvents LblLockParameter As Label
    Friend WithEvents TmrSignalInfo As Timer
    Friend WithEvents LblBER As Label
    Friend WithEvents LblBERValue As Label
    Friend WithEvents LblSNRValue As Label
    Friend WithEvents LblSNR As Label
    Friend WithEvents LblPacket As Label
    Friend WithEvents LblPacketValue As Label
    Friend WithEvents LblCorruptValue As Label
    Friend WithEvents LblCorrupt As Label
    Friend WithEvents PicBadge As PictureBox
    Friend WithEvents LstTask As ListBox
    Friend WithEvents BtnDeviceSelect As Button
    Friend WithEvents BtnTaskRecord As Button
    Friend WithEvents BtnTaskTransfer As Button
    Friend WithEvents BtnTaskRemove As Button
    Friend WithEvents BtnStop As Button
    Friend WithEvents FbdRecord As FolderBrowserDialog
    Friend WithEvents TapSearch As TabPage
    Friend WithEvents BtnBLScan2 As Button
    Friend WithEvents TxtBLScan2 As TextBox
    Friend WithEvents LblBLScan2 As Label
    Friend WithEvents LstBLScan2 As ListBox
    Friend WithEvents ChkAutoBLScan2 As CheckBox
    Friend WithEvents BgwBLScan2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnBLScan2Clear As Button
    Friend WithEvents TapDescramble As TabPage
    Friend WithEvents BtnControlWord As Button
    Friend WithEvents TxtControlWord As TextBox
    Friend WithEvents LblControlWord As Label
    Friend WithEvents TxtDescrambleFileInput As TextBox
    Friend WithEvents BtnDescrambleFileInput As Button
    Friend WithEvents LblDescrambleFileInput As Label
    Friend WithEvents LblDescrambleRemainValue As Label
    Friend WithEvents LblDescrambleRemain As Label
    Friend WithEvents LblDescrambleProgressValue As Label
    Friend WithEvents LblDescrambleProgress As Label
    Friend WithEvents LblDescramblePercentage As Label
    Friend WithEvents BgwFFDecsa As System.ComponentModel.BackgroundWorker
    Friend WithEvents OfdDescrambleFile As OpenFileDialog
    Friend WithEvents TxtDescrambleFileOutput As TextBox
    Friend WithEvents BtnDescrambleFileOutput As Button
    Friend WithEvents LblDescrambleFileOutput As Label
    Friend WithEvents SfdDescrambleFile As SaveFileDialog
    Friend WithEvents TapAdministration As TabPage
    Friend WithEvents LblAPI As Label
    Friend WithEvents LblAPIEnabled As Label
    Friend WithEvents ChkSetEscalation As CheckBox
    Friend WithEvents ChkGetEscalation As CheckBox
    Friend WithEvents LblRemark As Label
    Friend WithEvents BtnRemark As Button
    Friend WithEvents CboRemark As ComboBox
    Friend WithEvents TapService As TabPage
    Public WithEvents LsvService As ListView
    Friend WithEvents ClhServiceID As ColumnHeader
    Friend WithEvents ClhServiceName As ColumnHeader
    Friend WithEvents ClhServiceProvider As ColumnHeader
    Friend WithEvents ClhEnable As ColumnHeader
End Class
