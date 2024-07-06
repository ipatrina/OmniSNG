<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dispatch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dispatch))
        Me.TmrDispatch = New System.Windows.Forms.Timer(Me.components)
        Me.NicToast = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.LsvAdapter = New System.Windows.Forms.ListView()
        Me.ClhAdapterEnable = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhAdapterIndex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhAdapterStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhAdapterCarrier = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhAdapterServiceName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhAdapterLock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhAdapterBER = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhAdapterSNR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhAdapterDuration = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhAdapterLength = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhAdapterCorrupt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhAdapterControlWord = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhAdapterStream = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhAdapterCSAStream = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhAdapterVersion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhAdapterDevice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChkDispatch = New System.Windows.Forms.CheckBox()
        Me.LsvSearch = New System.Windows.Forms.ListView()
        Me.ClhSearchCarrier = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhSearchAdapter = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhSearchStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LblSearch = New System.Windows.Forms.Label()
        Me.LblExclude = New System.Windows.Forms.Label()
        Me.LstExclude = New System.Windows.Forms.ListBox()
        Me.BtnExcludeAdd = New System.Windows.Forms.Button()
        Me.BtnExcludeRemove = New System.Windows.Forms.Button()
        Me.BtnSR = New System.Windows.Forms.Button()
        Me.BtnHistory = New System.Windows.Forms.Button()
        Me.BtnHistoryClean = New System.Windows.Forms.Button()
        Me.ChkSearchOverride = New System.Windows.Forms.CheckBox()
        Me.TxtExclude = New System.Windows.Forms.TextBox()
        Me.BtnExcludeAddTemporary = New System.Windows.Forms.Button()
        Me.ChkExcludeDelete = New System.Windows.Forms.CheckBox()
        Me.LblSearchUpdate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TmrDispatch
        '
        Me.TmrDispatch.Interval = 1000
        '
        'NicToast
        '
        Me.NicToast.Icon = CType(resources.GetObject("NicToast.Icon"), System.Drawing.Icon)
        Me.NicToast.Text = "OmniSNG"
        '
        'LsvAdapter
        '
        Me.LsvAdapter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LsvAdapter.CheckBoxes = True
        Me.LsvAdapter.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClhAdapterEnable, Me.ClhAdapterIndex, Me.ClhAdapterStatus, Me.ClhAdapterCarrier, Me.ClhAdapterServiceName, Me.ClhAdapterLock, Me.ClhAdapterBER, Me.ClhAdapterSNR, Me.ClhAdapterDuration, Me.ClhAdapterLength, Me.ClhAdapterCorrupt, Me.ClhAdapterControlWord, Me.ClhAdapterStream, Me.ClhAdapterCSAStream, Me.ClhAdapterVersion, Me.ClhAdapterDevice})
        Me.LsvAdapter.Font = New System.Drawing.Font("微软雅黑", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsvAdapter.FullRowSelect = True
        Me.LsvAdapter.HideSelection = False
        Me.LsvAdapter.Location = New System.Drawing.Point(12, 12)
        Me.LsvAdapter.Name = "LsvAdapter"
        Me.LsvAdapter.Size = New System.Drawing.Size(984, 240)
        Me.LsvAdapter.TabIndex = 1001
        Me.LsvAdapter.UseCompatibleStateImageBehavior = False
        Me.LsvAdapter.View = System.Windows.Forms.View.Details
        '
        'ClhAdapterEnable
        '
        Me.ClhAdapterEnable.Text = ""
        Me.ClhAdapterEnable.Width = 25
        '
        'ClhAdapterIndex
        '
        Me.ClhAdapterIndex.Text = "顺序"
        Me.ClhAdapterIndex.Width = 45
        '
        'ClhAdapterStatus
        '
        Me.ClhAdapterStatus.Text = "状态"
        Me.ClhAdapterStatus.Width = 110
        '
        'ClhAdapterCarrier
        '
        Me.ClhAdapterCarrier.Text = "转发器"
        Me.ClhAdapterCarrier.Width = 260
        '
        'ClhAdapterServiceName
        '
        Me.ClhAdapterServiceName.Text = "服务名"
        Me.ClhAdapterServiceName.Width = 100
        '
        'ClhAdapterLock
        '
        Me.ClhAdapterLock.Text = "锁定"
        Me.ClhAdapterLock.Width = 50
        '
        'ClhAdapterBER
        '
        Me.ClhAdapterBER.Text = "误码率"
        '
        'ClhAdapterSNR
        '
        Me.ClhAdapterSNR.Text = "信噪比"
        Me.ClhAdapterSNR.Width = 90
        '
        'ClhAdapterDuration
        '
        Me.ClhAdapterDuration.Text = "工作时间"
        Me.ClhAdapterDuration.Width = 75
        '
        'ClhAdapterLength
        '
        Me.ClhAdapterLength.Text = "数据长度"
        Me.ClhAdapterLength.Width = 95
        '
        'ClhAdapterCorrupt
        '
        Me.ClhAdapterCorrupt.Text = "错误计数"
        Me.ClhAdapterCorrupt.Width = 75
        '
        'ClhAdapterControlWord
        '
        Me.ClhAdapterControlWord.Text = "控制字"
        Me.ClhAdapterControlWord.Width = 175
        '
        'ClhAdapterStream
        '
        Me.ClhAdapterStream.Text = "数据流"
        Me.ClhAdapterStream.Width = 75
        '
        'ClhAdapterCSAStream
        '
        Me.ClhAdapterCSAStream.Text = "解扰流"
        Me.ClhAdapterCSAStream.Width = 75
        '
        'ClhAdapterVersion
        '
        Me.ClhAdapterVersion.Text = "版本"
        Me.ClhAdapterVersion.Width = 75
        '
        'ClhAdapterDevice
        '
        Me.ClhAdapterDevice.Text = "设备"
        Me.ClhAdapterDevice.Width = 50
        '
        'ChkDispatch
        '
        Me.ChkDispatch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ChkDispatch.Checked = True
        Me.ChkDispatch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkDispatch.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ChkDispatch.Location = New System.Drawing.Point(846, 257)
        Me.ChkDispatch.Name = "ChkDispatch"
        Me.ChkDispatch.Size = New System.Drawing.Size(150, 42)
        Me.ChkDispatch.TabIndex = 9001
        Me.ChkDispatch.Text = "启用调度 (&P)"
        Me.ChkDispatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkDispatch.UseVisualStyleBackColor = False
        '
        'LsvSearch
        '
        Me.LsvSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LsvSearch.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClhSearchCarrier, Me.ClhSearchAdapter, Me.ClhSearchStatus})
        Me.LsvSearch.Font = New System.Drawing.Font("微软雅黑", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsvSearch.FullRowSelect = True
        Me.LsvSearch.HideSelection = False
        Me.LsvSearch.Location = New System.Drawing.Point(12, 296)
        Me.LsvSearch.Name = "LsvSearch"
        Me.LsvSearch.Size = New System.Drawing.Size(510, 256)
        Me.LsvSearch.TabIndex = 2101
        Me.LsvSearch.UseCompatibleStateImageBehavior = False
        Me.LsvSearch.View = System.Windows.Forms.View.Details
        '
        'ClhSearchCarrier
        '
        Me.ClhSearchCarrier.Text = "转发器"
        Me.ClhSearchCarrier.Width = 325
        '
        'ClhSearchAdapter
        '
        Me.ClhSearchAdapter.Text = "委派"
        Me.ClhSearchAdapter.Width = 50
        '
        'ClhSearchStatus
        '
        Me.ClhSearchStatus.Text = "状态"
        Me.ClhSearchStatus.Width = 125
        '
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblSearch.Location = New System.Drawing.Point(8, 267)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Size = New System.Drawing.Size(90, 21)
        Me.LblSearch.TabIndex = 2001
        Me.LblSearch.Text = "转发器列表"
        '
        'LblExclude
        '
        Me.LblExclude.AutoSize = True
        Me.LblExclude.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblExclude.Location = New System.Drawing.Point(526, 267)
        Me.LblExclude.Name = "LblExclude"
        Me.LblExclude.Size = New System.Drawing.Size(58, 21)
        Me.LblExclude.TabIndex = 4001
        Me.LblExclude.Text = "排除项"
        '
        'LstExclude
        '
        Me.LstExclude.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LstExclude.FormattingEnabled = True
        Me.LstExclude.ItemHeight = 21
        Me.LstExclude.Location = New System.Drawing.Point(530, 296)
        Me.LstExclude.Name = "LstExclude"
        Me.LstExclude.Size = New System.Drawing.Size(309, 214)
        Me.LstExclude.TabIndex = 4101
        '
        'BtnExcludeAdd
        '
        Me.BtnExcludeAdd.Location = New System.Drawing.Point(846, 516)
        Me.BtnExcludeAdd.Name = "BtnExcludeAdd"
        Me.BtnExcludeAdd.Size = New System.Drawing.Size(150, 36)
        Me.BtnExcludeAdd.TabIndex = 9731
        Me.BtnExcludeAdd.Text = "添加排除项 (&E)"
        Me.BtnExcludeAdd.UseVisualStyleBackColor = True
        '
        'BtnExcludeRemove
        '
        Me.BtnExcludeRemove.Location = New System.Drawing.Point(846, 474)
        Me.BtnExcludeRemove.Name = "BtnExcludeRemove"
        Me.BtnExcludeRemove.Size = New System.Drawing.Size(150, 36)
        Me.BtnExcludeRemove.TabIndex = 9711
        Me.BtnExcludeRemove.Text = "移除排除项 (&D)"
        Me.BtnExcludeRemove.UseVisualStyleBackColor = True
        '
        'BtnSR
        '
        Me.BtnSR.Location = New System.Drawing.Point(846, 348)
        Me.BtnSR.Name = "BtnSR"
        Me.BtnSR.Size = New System.Drawing.Size(150, 36)
        Me.BtnSR.TabIndex = 9301
        Me.BtnSR.Text = "符号率选项 (&S)"
        Me.BtnSR.UseVisualStyleBackColor = True
        '
        'BtnHistory
        '
        Me.BtnHistory.Location = New System.Drawing.Point(846, 390)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(150, 36)
        Me.BtnHistory.TabIndex = 9501
        Me.BtnHistory.Text = "启动记录 (&H)"
        Me.BtnHistory.UseVisualStyleBackColor = True
        '
        'BtnHistoryClean
        '
        Me.BtnHistoryClean.Location = New System.Drawing.Point(846, 432)
        Me.BtnHistoryClean.Name = "BtnHistoryClean"
        Me.BtnHistoryClean.Size = New System.Drawing.Size(150, 36)
        Me.BtnHistoryClean.TabIndex = 9511
        Me.BtnHistoryClean.Text = "清空记录 (&C)"
        Me.BtnHistoryClean.UseVisualStyleBackColor = True
        '
        'ChkSearchOverride
        '
        Me.ChkSearchOverride.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkSearchOverride.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ChkSearchOverride.Location = New System.Drawing.Point(846, 305)
        Me.ChkSearchOverride.Name = "ChkSearchOverride"
        Me.ChkSearchOverride.Size = New System.Drawing.Size(150, 37)
        Me.ChkSearchOverride.TabIndex = 9101
        Me.ChkSearchOverride.Text = "覆盖搜索 (&A)"
        Me.ChkSearchOverride.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkSearchOverride.UseVisualStyleBackColor = False
        '
        'TxtExclude
        '
        Me.TxtExclude.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtExclude.Location = New System.Drawing.Point(530, 518)
        Me.TxtExclude.Name = "TxtExclude"
        Me.TxtExclude.Size = New System.Drawing.Size(268, 33)
        Me.TxtExclude.TabIndex = 4201
        Me.TxtExclude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnExcludeAddTemporary
        '
        Me.BtnExcludeAddTemporary.Location = New System.Drawing.Point(804, 516)
        Me.BtnExcludeAddTemporary.Name = "BtnExcludeAddTemporary"
        Me.BtnExcludeAddTemporary.Size = New System.Drawing.Size(36, 36)
        Me.BtnExcludeAddTemporary.TabIndex = 4211
        Me.BtnExcludeAddTemporary.Text = "!"
        Me.BtnExcludeAddTemporary.UseVisualStyleBackColor = True
        '
        'ChkExcludeDelete
        '
        Me.ChkExcludeDelete.AutoSize = True
        Me.ChkExcludeDelete.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ChkExcludeDelete.Location = New System.Drawing.Point(747, 266)
        Me.ChkExcludeDelete.Name = "ChkExcludeDelete"
        Me.ChkExcludeDelete.Size = New System.Drawing.Size(93, 25)
        Me.ChkExcludeDelete.TabIndex = 4011
        Me.ChkExcludeDelete.Text = "删除文件"
        Me.ChkExcludeDelete.UseVisualStyleBackColor = True
        '
        'LblSearchUpdate
        '
        Me.LblSearchUpdate.AutoSize = True
        Me.LblSearchUpdate.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblSearchUpdate.ForeColor = System.Drawing.Color.SlateBlue
        Me.LblSearchUpdate.Location = New System.Drawing.Point(104, 267)
        Me.LblSearchUpdate.Name = "LblSearchUpdate"
        Me.LblSearchUpdate.Size = New System.Drawing.Size(55, 22)
        Me.LblSearchUpdate.TabIndex = 2011
        Me.LblSearchUpdate.Text = "00:00"
        Me.LblSearchUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Dispatch
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.LblSearchUpdate)
        Me.Controls.Add(Me.ChkExcludeDelete)
        Me.Controls.Add(Me.BtnExcludeAddTemporary)
        Me.Controls.Add(Me.TxtExclude)
        Me.Controls.Add(Me.ChkSearchOverride)
        Me.Controls.Add(Me.BtnHistoryClean)
        Me.Controls.Add(Me.BtnHistory)
        Me.Controls.Add(Me.BtnSR)
        Me.Controls.Add(Me.BtnExcludeRemove)
        Me.Controls.Add(Me.BtnExcludeAdd)
        Me.Controls.Add(Me.LstExclude)
        Me.Controls.Add(Me.LblExclude)
        Me.Controls.Add(Me.LblSearch)
        Me.Controls.Add(Me.LsvSearch)
        Me.Controls.Add(Me.ChkDispatch)
        Me.Controls.Add(Me.LsvAdapter)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "Dispatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OmniSNG"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NicToast As NotifyIcon
    Public WithEvents LsvAdapter As ListView
    Friend WithEvents ClhAdapterEnable As ColumnHeader
    Friend WithEvents ClhAdapterIndex As ColumnHeader
    Friend WithEvents ClhAdapterStatus As ColumnHeader
    Friend WithEvents ClhAdapterCarrier As ColumnHeader
    Friend WithEvents ClhAdapterLock As ColumnHeader
    Friend WithEvents ClhAdapterBER As ColumnHeader
    Friend WithEvents ClhAdapterSNR As ColumnHeader
    Friend WithEvents ClhAdapterDuration As ColumnHeader
    Friend WithEvents ClhAdapterLength As ColumnHeader
    Friend WithEvents ClhAdapterCorrupt As ColumnHeader
    Friend WithEvents ClhAdapterControlWord As ColumnHeader
    Friend WithEvents ClhAdapterVersion As ColumnHeader
    Friend WithEvents ClhAdapterDevice As ColumnHeader
    Friend WithEvents ChkDispatch As CheckBox
    Public WithEvents LsvSearch As ListView
    Friend WithEvents ClhSearchCarrier As ColumnHeader
    Friend WithEvents ClhSearchAdapter As ColumnHeader
    Friend WithEvents ClhSearchStatus As ColumnHeader
    Friend WithEvents LblSearch As Label
    Friend WithEvents LblExclude As Label
    Friend WithEvents LstExclude As ListBox
    Friend WithEvents BtnExcludeAdd As Button
    Friend WithEvents BtnExcludeRemove As Button
    Friend WithEvents ClhAdapterStream As ColumnHeader
    Friend WithEvents ClhAdapterCSAStream As ColumnHeader
    Friend WithEvents TmrDispatch As Timer
    Friend WithEvents BtnSR As Button
    Friend WithEvents BtnHistory As Button
    Friend WithEvents BtnHistoryClean As Button
    Friend WithEvents ChkSearchOverride As CheckBox
    Friend WithEvents TxtExclude As TextBox
    Friend WithEvents BtnExcludeAddTemporary As Button
    Friend WithEvents ClhAdapterServiceName As ColumnHeader
    Friend WithEvents ChkExcludeDelete As CheckBox
    Friend WithEvents LblSearchUpdate As Label
End Class
