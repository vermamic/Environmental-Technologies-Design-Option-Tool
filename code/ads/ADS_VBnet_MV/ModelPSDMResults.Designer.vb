<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmModelPSDMResults
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public optType(3) As RadioButton
    Public WithEvents _lblMisc_0 As Label
    Public WithEvents lblSSValue As Label
    Public WithEvents lblSSValueUnits As Label
    Friend WithEvents cmdTreatA As AxThreed.AxSSCommand
    Public WithEvents Command4 As System.Windows.Forms.Button
    Public WithEvents Picture1 As System.Windows.Forms.PictureBox
    Public WithEvents ssframe_SSConc As AxThreed.AxSSFrame
    Public WithEvents cboGrid As System.Windows.Forms.ComboBox
    Public WithEvents cboCompo As System.Windows.Forms.ComboBox
    Public WithEvents cmdTreat As AxThreed.AxSSCommand
    Public WithEvents _lblLegend_0 As System.Windows.Forms.Label
    Public WithEvents _lblLegend_1 As System.Windows.Forms.Label
    Public WithEvents _lblLegend_2 As System.Windows.Forms.Label
    Public WithEvents _lblLegend_3 As System.Windows.Forms.Label
    Public WithEvents _lblLegend_4 As System.Windows.Forms.Label
    Public WithEvents _lblLegend_5 As System.Windows.Forms.Label
    Public WithEvents _lblLegend_6 As System.Windows.Forms.Label
    Public WithEvents _lblData_0 As System.Windows.Forms.Label
    Public WithEvents _lblData_1 As System.Windows.Forms.Label
    Public WithEvents _lblData_2 As System.Windows.Forms.Label
    Public WithEvents _lblData_3 As System.Windows.Forms.Label
    Public WithEvents _lblData_4 As System.Windows.Forms.Label
    Public WithEvents _lblData_5 As System.Windows.Forms.Label
    Public WithEvents _lblData_6 As System.Windows.Forms.Label
    Public WithEvents _lblData_7 As System.Windows.Forms.Label
    Public WithEvents _lblData_8 As System.Windows.Forms.Label
    Public WithEvents _lblData_9 As System.Windows.Forms.Label
    Public WithEvents _lblData_10 As System.Windows.Forms.Label
    Public WithEvents _lblData_11 As System.Windows.Forms.Label
    Public WithEvents _lblLegend_7 As System.Windows.Forms.Label
    Public WithEvents _lblData_12 As System.Windows.Forms.Label
    Public WithEvents _lblData_13 As System.Windows.Forms.Label
    Public WithEvents _lblData_14 As System.Windows.Forms.Label
    Public WithEvents _lblData_15 As System.Windows.Forms.Label
    Public WithEvents lblMTZ As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Frame3D1 As AxThreed.AxSSFrame
    Public WithEvents cmdFile As AxThreed.AxSSCommand
    Public WithEvents cmdExcel As AxThreed.AxSSCommand
    Public WithEvents cmdSave As AxThreed.AxSSCommand
    Public WithEvents CMDialog1 As AxMSComDlg.AxCommonDialog
    Public WithEvents cmdSelect As AxThreed.AxSSCommand
    Public WithEvents cmdPrint As AxThreed.AxSSCommand
    Public WithEvents cmdExit As AxThreed.AxSSCommand
    Public WithEvents cboYAxisType As System.Windows.Forms.ComboBox
    Public WithEvents SSFrame3 As AxThreed.AxSSFrame
    Public WithEvents cmdViewProcessDiagram As AxThreed.AxSSCommand
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents lblData As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents lblLegend As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    Public WithEvents lblMisc As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    '   Public WithEvents optType As Threed.SSOptionArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModelPSDMResults))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Command4 = New System.Windows.Forms.Button()
        Me.Picture1 = New System.Windows.Forms.PictureBox()
        Me.ssframe_SSConc = New AxThreed.AxSSFrame()
        Me.cboGrid = New System.Windows.Forms.ComboBox()
        Me.Frame3D1 = New AxThreed.AxSSFrame()
        Me.cboCompo = New System.Windows.Forms.ComboBox()
        Me._lblLegend_0 = New System.Windows.Forms.Label()
        Me._lblLegend_1 = New System.Windows.Forms.Label()
        Me._lblLegend_2 = New System.Windows.Forms.Label()
        Me._lblLegend_3 = New System.Windows.Forms.Label()
        Me._lblLegend_4 = New System.Windows.Forms.Label()
        Me._lblLegend_5 = New System.Windows.Forms.Label()
        Me._lblLegend_6 = New System.Windows.Forms.Label()
        Me._lblData_0 = New System.Windows.Forms.Label()
        Me._lblData_1 = New System.Windows.Forms.Label()
        Me._lblData_2 = New System.Windows.Forms.Label()
        Me._lblData_3 = New System.Windows.Forms.Label()
        Me._lblData_4 = New System.Windows.Forms.Label()
        Me._lblData_5 = New System.Windows.Forms.Label()
        Me._lblData_6 = New System.Windows.Forms.Label()
        Me._lblData_7 = New System.Windows.Forms.Label()
        Me._lblData_8 = New System.Windows.Forms.Label()
        Me._lblData_9 = New System.Windows.Forms.Label()
        Me._lblData_10 = New System.Windows.Forms.Label()
        Me._lblData_11 = New System.Windows.Forms.Label()
        Me._lblLegend_7 = New System.Windows.Forms.Label()
        Me._lblData_12 = New System.Windows.Forms.Label()
        Me._lblData_13 = New System.Windows.Forms.Label()
        Me._lblData_14 = New System.Windows.Forms.Label()
        Me._lblData_15 = New System.Windows.Forms.Label()
        Me.lblMTZ = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdTreat = New AxThreed.AxSSCommand()
        Me.cmdFile = New AxThreed.AxSSCommand()
        Me.cmdExcel = New AxThreed.AxSSCommand()
        Me.cmdSave = New AxThreed.AxSSCommand()
        Me.CMDialog1 = New AxMSComDlg.AxCommonDialog()
        Me.cmdSelect = New AxThreed.AxSSCommand()
        Me.cmdPrint = New AxThreed.AxSSCommand()
        Me.cmdExit = New AxThreed.AxSSCommand()
        Me.SSFrame3 = New AxThreed.AxSSFrame()
        Me.cboYAxisType = New System.Windows.Forms.ComboBox()
        Me.cmdViewProcessDiagram = New AxThreed.AxSSCommand()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblData = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lblLegend = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.lblMisc = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me._lblMisc_0 = New System.Windows.Forms.Label()
        Me.lblSSValue = New System.Windows.Forms.Label()
        Me.lblSSValueUnits = New System.Windows.Forms.Label()
        Me.cmdTreatA = New AxThreed.AxSSCommand()
        Me.grpBreak = New AxGraphLib.AxGraph()
        Me._optType_0 = New System.Windows.Forms.RadioButton()
        Me._optType_1 = New System.Windows.Forms.RadioButton()
        Me._optType_2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ssframe_SSConc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Frame3D1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame3D1.SuspendLayout()
        CType(Me.cmdTreat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CMDialog1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSFrame3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdViewProcessDiagram, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLegend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMisc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdTreatA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpBreak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Command4
        '
        Me.Command4.BackColor = System.Drawing.SystemColors.Control
        Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command4.Location = New System.Drawing.Point(529, 412)
        Me.Command4.Name = "Command4"
        Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command4.Size = New System.Drawing.Size(174, 22)
        Me.Command4.TabIndex = 50
        Me.Command4.Text = "Print Screen"
        Me.ToolTip1.SetToolTip(Me.Command4, "Click here to print current screen to selected printer")
        Me.Command4.UseVisualStyleBackColor = False
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.Control
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Picture1.Location = New System.Drawing.Point(640, 479)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(84, 57)
        Me.Picture1.TabIndex = 49
        Me.Picture1.TabStop = False
        Me.Picture1.Visible = False
        '
        'ssframe_SSConc
        '
        Me.ssframe_SSConc.Location = New System.Drawing.Point(16, 156)
        Me.ssframe_SSConc.Name = "ssframe_SSConc"
        Me.ssframe_SSConc.OcxState = CType(resources.GetObject("ssframe_SSConc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssframe_SSConc.Size = New System.Drawing.Size(509, 52)
        Me.ssframe_SSConc.TabIndex = 42
        '
        'cboGrid
        '
        Me.cboGrid.BackColor = System.Drawing.SystemColors.Window
        Me.cboGrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboGrid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrid.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrid.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboGrid.Location = New System.Drawing.Point(534, 144)
        Me.cboGrid.Name = "cboGrid"
        Me.cboGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboGrid.Size = New System.Drawing.Size(174, 24)
        Me.cboGrid.TabIndex = 33
        '
        'Frame3D1
        '
        Me.Frame3D1.Controls.Add(Me.cboCompo)
        Me.Frame3D1.Controls.Add(Me._lblLegend_0)
        Me.Frame3D1.Controls.Add(Me._lblLegend_1)
        Me.Frame3D1.Controls.Add(Me._lblLegend_2)
        Me.Frame3D1.Controls.Add(Me._lblLegend_3)
        Me.Frame3D1.Controls.Add(Me._lblLegend_4)
        Me.Frame3D1.Controls.Add(Me._lblLegend_5)
        Me.Frame3D1.Controls.Add(Me._lblLegend_6)
        Me.Frame3D1.Controls.Add(Me._lblData_0)
        Me.Frame3D1.Controls.Add(Me._lblData_1)
        Me.Frame3D1.Controls.Add(Me._lblData_2)
        Me.Frame3D1.Controls.Add(Me._lblData_3)
        Me.Frame3D1.Controls.Add(Me._lblData_4)
        Me.Frame3D1.Controls.Add(Me._lblData_5)
        Me.Frame3D1.Controls.Add(Me._lblData_6)
        Me.Frame3D1.Controls.Add(Me._lblData_7)
        Me.Frame3D1.Controls.Add(Me._lblData_8)
        Me.Frame3D1.Controls.Add(Me._lblData_9)
        Me.Frame3D1.Controls.Add(Me._lblData_10)
        Me.Frame3D1.Controls.Add(Me._lblData_11)
        Me.Frame3D1.Controls.Add(Me._lblLegend_7)
        Me.Frame3D1.Controls.Add(Me._lblData_12)
        Me.Frame3D1.Controls.Add(Me._lblData_13)
        Me.Frame3D1.Controls.Add(Me._lblData_14)
        Me.Frame3D1.Controls.Add(Me._lblData_15)
        Me.Frame3D1.Controls.Add(Me.lblMTZ)
        Me.Frame3D1.Controls.Add(Me.Label2)
        Me.Frame3D1.Location = New System.Drawing.Point(4, 0)
        Me.Frame3D1.Name = "Frame3D1"
        Me.Frame3D1.OcxState = CType(resources.GetObject("Frame3D1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Frame3D1.Size = New System.Drawing.Size(524, 150)
        Me.Frame3D1.TabIndex = 0
        '
        'cboCompo
        '
        Me.cboCompo.BackColor = System.Drawing.SystemColors.Window
        Me.cboCompo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCompo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCompo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCompo.Location = New System.Drawing.Point(6, 20)
        Me.cboCompo.Name = "cboCompo"
        Me.cboCompo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboCompo.Size = New System.Drawing.Size(258, 24)
        Me.cboCompo.TabIndex = 3
        '
        '_lblLegend_0
        '
        Me._lblLegend_0.BackColor = System.Drawing.Color.Transparent
        Me._lblLegend_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblLegend_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLegend_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLegend_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblLegend.SetIndex(Me._lblLegend_0, CType(0, Short))
        Me._lblLegend_0.Location = New System.Drawing.Point(6, 44)
        Me._lblLegend_0.Name = "_lblLegend_0"
        Me._lblLegend_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLegend_0.Size = New System.Drawing.Size(177, 17)
        Me._lblLegend_0.TabIndex = 29
        Me._lblLegend_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblLegend_1
        '
        Me._lblLegend_1.BackColor = System.Drawing.Color.Transparent
        Me._lblLegend_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblLegend_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLegend_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLegend_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblLegend.SetIndex(Me._lblLegend_1, CType(1, Short))
        Me._lblLegend_1.Location = New System.Drawing.Point(182, 44)
        Me._lblLegend_1.Name = "_lblLegend_1"
        Me._lblLegend_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLegend_1.Size = New System.Drawing.Size(81, 17)
        Me._lblLegend_1.TabIndex = 28
        Me._lblLegend_1.Text = "Time (days)"
        Me._lblLegend_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblLegend_2
        '
        Me._lblLegend_2.BackColor = System.Drawing.Color.Transparent
        Me._lblLegend_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblLegend_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLegend_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLegend_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblLegend.SetIndex(Me._lblLegend_2, CType(2, Short))
        Me._lblLegend_2.Location = New System.Drawing.Point(262, 44)
        Me._lblLegend_2.Name = "_lblLegend_2"
        Me._lblLegend_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLegend_2.Size = New System.Drawing.Size(81, 17)
        Me._lblLegend_2.TabIndex = 27
        Me._lblLegend_2.Text = "BVT"
        Me._lblLegend_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblLegend_3
        '
        Me._lblLegend_3.BackColor = System.Drawing.Color.Transparent
        Me._lblLegend_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblLegend_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLegend_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLegend_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblLegend.SetIndex(Me._lblLegend_3, CType(3, Short))
        Me._lblLegend_3.Location = New System.Drawing.Point(342, 44)
        Me._lblLegend_3.Name = "_lblLegend_3"
        Me._lblLegend_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLegend_3.Size = New System.Drawing.Size(81, 17)
        Me._lblLegend_3.TabIndex = 26
        Me._lblLegend_3.Text = "Tr. Capacity"
        Me._lblLegend_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblLegend_4
        '
        Me._lblLegend_4.BackColor = System.Drawing.Color.Transparent
        Me._lblLegend_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblLegend_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLegend_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLegend_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblLegend.SetIndex(Me._lblLegend_4, CType(4, Short))
        Me._lblLegend_4.Location = New System.Drawing.Point(6, 60)
        Me._lblLegend_4.Name = "_lblLegend_4"
        Me._lblLegend_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLegend_4.Size = New System.Drawing.Size(177, 17)
        Me._lblLegend_4.TabIndex = 25
        Me._lblLegend_4.Text = "5% of influent conc."
        Me._lblLegend_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblLegend_5
        '
        Me._lblLegend_5.BackColor = System.Drawing.Color.Transparent
        Me._lblLegend_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblLegend_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLegend_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLegend_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblLegend.SetIndex(Me._lblLegend_5, CType(5, Short))
        Me._lblLegend_5.Location = New System.Drawing.Point(6, 76)
        Me._lblLegend_5.Name = "_lblLegend_5"
        Me._lblLegend_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLegend_5.Size = New System.Drawing.Size(177, 17)
        Me._lblLegend_5.TabIndex = 24
        Me._lblLegend_5.Text = "50% of influent conc."
        Me._lblLegend_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblLegend_6
        '
        Me._lblLegend_6.BackColor = System.Drawing.Color.Transparent
        Me._lblLegend_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblLegend_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLegend_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLegend_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblLegend.SetIndex(Me._lblLegend_6, CType(6, Short))
        Me._lblLegend_6.Location = New System.Drawing.Point(6, 92)
        Me._lblLegend_6.Name = "_lblLegend_6"
        Me._lblLegend_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLegend_6.Size = New System.Drawing.Size(177, 17)
        Me._lblLegend_6.TabIndex = 23
        Me._lblLegend_6.Text = "95% of influent conc."
        Me._lblLegend_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblData_0
        '
        Me._lblData_0.BackColor = System.Drawing.SystemColors.Window
        Me._lblData_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblData_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblData.SetIndex(Me._lblData_0, CType(0, Short))
        Me._lblData_0.Location = New System.Drawing.Point(182, 60)
        Me._lblData_0.Name = "_lblData_0"
        Me._lblData_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_0.Size = New System.Drawing.Size(81, 17)
        Me._lblData_0.TabIndex = 22
        Me._lblData_0.Text = "999.99"
        Me._lblData_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblData_1
        '
        Me._lblData_1.BackColor = System.Drawing.SystemColors.Window
        Me._lblData_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblData_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblData.SetIndex(Me._lblData_1, CType(1, Short))
        Me._lblData_1.Location = New System.Drawing.Point(182, 76)
        Me._lblData_1.Name = "_lblData_1"
        Me._lblData_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_1.Size = New System.Drawing.Size(81, 17)
        Me._lblData_1.TabIndex = 21
        Me._lblData_1.Text = "999.99"
        Me._lblData_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblData_2
        '
        Me._lblData_2.BackColor = System.Drawing.SystemColors.Window
        Me._lblData_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblData_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblData.SetIndex(Me._lblData_2, CType(2, Short))
        Me._lblData_2.Location = New System.Drawing.Point(182, 92)
        Me._lblData_2.Name = "_lblData_2"
        Me._lblData_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_2.Size = New System.Drawing.Size(81, 17)
        Me._lblData_2.TabIndex = 20
        Me._lblData_2.Text = "999.99"
        Me._lblData_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblData_3
        '
        Me._lblData_3.BackColor = System.Drawing.SystemColors.Window
        Me._lblData_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblData_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblData.SetIndex(Me._lblData_3, CType(3, Short))
        Me._lblData_3.Location = New System.Drawing.Point(262, 60)
        Me._lblData_3.Name = "_lblData_3"
        Me._lblData_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_3.Size = New System.Drawing.Size(81, 17)
        Me._lblData_3.TabIndex = 19
        Me._lblData_3.Text = "999.99"
        Me._lblData_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblData_4
        '
        Me._lblData_4.BackColor = System.Drawing.SystemColors.Window
        Me._lblData_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblData_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblData.SetIndex(Me._lblData_4, CType(4, Short))
        Me._lblData_4.Location = New System.Drawing.Point(262, 76)
        Me._lblData_4.Name = "_lblData_4"
        Me._lblData_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_4.Size = New System.Drawing.Size(81, 17)
        Me._lblData_4.TabIndex = 18
        Me._lblData_4.Text = "999.99"
        Me._lblData_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblData_5
        '
        Me._lblData_5.BackColor = System.Drawing.SystemColors.Window
        Me._lblData_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblData_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblData.SetIndex(Me._lblData_5, CType(5, Short))
        Me._lblData_5.Location = New System.Drawing.Point(262, 92)
        Me._lblData_5.Name = "_lblData_5"
        Me._lblData_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_5.Size = New System.Drawing.Size(81, 17)
        Me._lblData_5.TabIndex = 17
        Me._lblData_5.Text = "999.99"
        Me._lblData_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblData_6
        '
        Me._lblData_6.BackColor = System.Drawing.SystemColors.Window
        Me._lblData_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblData_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblData.SetIndex(Me._lblData_6, CType(6, Short))
        Me._lblData_6.Location = New System.Drawing.Point(342, 60)
        Me._lblData_6.Name = "_lblData_6"
        Me._lblData_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_6.Size = New System.Drawing.Size(81, 17)
        Me._lblData_6.TabIndex = 16
        Me._lblData_6.Text = "999.99"
        Me._lblData_6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblData_7
        '
        Me._lblData_7.BackColor = System.Drawing.SystemColors.Window
        Me._lblData_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblData_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblData.SetIndex(Me._lblData_7, CType(7, Short))
        Me._lblData_7.Location = New System.Drawing.Point(342, 76)
        Me._lblData_7.Name = "_lblData_7"
        Me._lblData_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_7.Size = New System.Drawing.Size(81, 17)
        Me._lblData_7.TabIndex = 15
        Me._lblData_7.Text = "999.99"
        Me._lblData_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblData_8
        '
        Me._lblData_8.BackColor = System.Drawing.SystemColors.Window
        Me._lblData_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblData_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblData.SetIndex(Me._lblData_8, CType(8, Short))
        Me._lblData_8.Location = New System.Drawing.Point(342, 92)
        Me._lblData_8.Name = "_lblData_8"
        Me._lblData_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_8.Size = New System.Drawing.Size(81, 17)
        Me._lblData_8.TabIndex = 14
        Me._lblData_8.Text = "999.99"
        Me._lblData_8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblData_9
        '
        Me._lblData_9.BackColor = System.Drawing.SystemColors.Window
        Me._lblData_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblData_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblData.SetIndex(Me._lblData_9, CType(9, Short))
        Me._lblData_9.Location = New System.Drawing.Point(422, 60)
        Me._lblData_9.Name = "_lblData_9"
        Me._lblData_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_9.Size = New System.Drawing.Size(89, 17)
        Me._lblData_9.TabIndex = 13
        Me._lblData_9.Text = "999.99"
        Me._lblData_9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblData_10
        '
        Me._lblData_10.BackColor = System.Drawing.SystemColors.Window
        Me._lblData_10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblData_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblData.SetIndex(Me._lblData_10, CType(10, Short))
        Me._lblData_10.Location = New System.Drawing.Point(422, 76)
        Me._lblData_10.Name = "_lblData_10"
        Me._lblData_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_10.Size = New System.Drawing.Size(89, 17)
        Me._lblData_10.TabIndex = 12
        Me._lblData_10.Text = "999.99"
        Me._lblData_10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblData_11
        '
        Me._lblData_11.BackColor = System.Drawing.SystemColors.Window
        Me._lblData_11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblData_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblData.SetIndex(Me._lblData_11, CType(11, Short))
        Me._lblData_11.Location = New System.Drawing.Point(422, 92)
        Me._lblData_11.Name = "_lblData_11"
        Me._lblData_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_11.Size = New System.Drawing.Size(89, 17)
        Me._lblData_11.TabIndex = 11
        Me._lblData_11.Text = "999.99"
        Me._lblData_11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblLegend_7
        '
        Me._lblLegend_7.BackColor = System.Drawing.Color.Transparent
        Me._lblLegend_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblLegend_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblLegend_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblLegend_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblLegend.SetIndex(Me._lblLegend_7, CType(7, Short))
        Me._lblLegend_7.Location = New System.Drawing.Point(422, 44)
        Me._lblLegend_7.Name = "_lblLegend_7"
        Me._lblLegend_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblLegend_7.Size = New System.Drawing.Size(89, 17)
        Me._lblLegend_7.TabIndex = 10
        Me._lblLegend_7.Text = "C (mg/L)"
        Me._lblLegend_7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblData_12
        '
        Me._lblData_12.BackColor = System.Drawing.SystemColors.Window
        Me._lblData_12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblData_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblData.SetIndex(Me._lblData_12, CType(12, Short))
        Me._lblData_12.Location = New System.Drawing.Point(182, 108)
        Me._lblData_12.Name = "_lblData_12"
        Me._lblData_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_12.Size = New System.Drawing.Size(81, 17)
        Me._lblData_12.TabIndex = 9
        Me._lblData_12.Text = "999.99"
        Me._lblData_12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblData_13
        '
        Me._lblData_13.BackColor = System.Drawing.SystemColors.Window
        Me._lblData_13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblData_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_13.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblData.SetIndex(Me._lblData_13, CType(13, Short))
        Me._lblData_13.Location = New System.Drawing.Point(262, 108)
        Me._lblData_13.Name = "_lblData_13"
        Me._lblData_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_13.Size = New System.Drawing.Size(81, 17)
        Me._lblData_13.TabIndex = 8
        Me._lblData_13.Text = "999.99"
        Me._lblData_13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblData_14
        '
        Me._lblData_14.BackColor = System.Drawing.SystemColors.Window
        Me._lblData_14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblData_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_14.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblData.SetIndex(Me._lblData_14, CType(14, Short))
        Me._lblData_14.Location = New System.Drawing.Point(342, 108)
        Me._lblData_14.Name = "_lblData_14"
        Me._lblData_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_14.Size = New System.Drawing.Size(81, 17)
        Me._lblData_14.TabIndex = 7
        Me._lblData_14.Text = "999.99"
        Me._lblData_14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_lblData_15
        '
        Me._lblData_15.BackColor = System.Drawing.SystemColors.Window
        Me._lblData_15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblData_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblData_15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblData_15.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblData.SetIndex(Me._lblData_15, CType(15, Short))
        Me._lblData_15.Location = New System.Drawing.Point(422, 108)
        Me._lblData_15.Name = "_lblData_15"
        Me._lblData_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblData_15.Size = New System.Drawing.Size(89, 17)
        Me._lblData_15.TabIndex = 6
        Me._lblData_15.Text = "999.99"
        Me._lblData_15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMTZ
        '
        Me.lblMTZ.BackColor = System.Drawing.SystemColors.Window
        Me.lblMTZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMTZ.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMTZ.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMTZ.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblMTZ.Location = New System.Drawing.Point(439, 19)
        Me.lblMTZ.Name = "lblMTZ"
        Me.lblMTZ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMTZ.Size = New System.Drawing.Size(81, 17)
        Me.lblMTZ.TabIndex = 5
        Me.lblMTZ.Text = "lblMTZ"
        Me.lblMTZ.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(268, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(175, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Length of the MTZ (cm):"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdTreat
        '
        Me.cmdTreat.Location = New System.Drawing.Point(14, 111)
        Me.cmdTreat.Name = "cmdTreat"
        Me.cmdTreat.OcxState = CType(resources.GetObject("cmdTreat.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cmdTreat.Size = New System.Drawing.Size(166, 30)
        Me.cmdTreat.TabIndex = 2
        '
        'cmdFile
        '
        Me.cmdFile.Location = New System.Drawing.Point(533, 313)
        Me.cmdFile.Name = "cmdFile"
        Me.cmdFile.OcxState = CType(resources.GetObject("cmdFile.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cmdFile.Size = New System.Drawing.Size(175, 37)
        Me.cmdFile.TabIndex = 30
        '
        'cmdExcel
        '
        Me.cmdExcel.Location = New System.Drawing.Point(534, 166)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.OcxState = CType(resources.GetObject("cmdExcel.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cmdExcel.Size = New System.Drawing.Size(174, 42)
        Me.cmdExcel.TabIndex = 31
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(534, 204)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.OcxState = CType(resources.GetObject("cmdSave.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cmdSave.Size = New System.Drawing.Size(174, 39)
        Me.cmdSave.TabIndex = 32
        '
        'CMDialog1
        '
        Me.CMDialog1.Enabled = True
        Me.CMDialog1.Location = New System.Drawing.Point(0, 0)
        Me.CMDialog1.Name = "CMDialog1"
        Me.CMDialog1.OcxState = CType(resources.GetObject("CMDialog1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CMDialog1.Size = New System.Drawing.Size(40, 40)
        Me.CMDialog1.TabIndex = 51
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(534, 239)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.OcxState = CType(resources.GetObject("cmdSelect.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cmdSelect.Size = New System.Drawing.Size(174, 43)
        Me.cmdSelect.TabIndex = 34
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(534, 279)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.OcxState = CType(resources.GetObject("cmdPrint.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cmdPrint.Size = New System.Drawing.Size(174, 40)
        Me.cmdPrint.TabIndex = 36
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(570, 13)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.OcxState = CType(resources.GetObject("cmdExit.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cmdExit.Size = New System.Drawing.Size(123, 33)
        Me.cmdExit.TabIndex = 37
        Me.cmdExit.TabStop = False
        '
        'SSFrame3
        '
        Me.SSFrame3.Location = New System.Drawing.Point(351, 468)
        Me.SSFrame3.Name = "SSFrame3"
        Me.SSFrame3.OcxState = CType(resources.GetObject("SSFrame3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSFrame3.Size = New System.Drawing.Size(174, 76)
        Me.SSFrame3.TabIndex = 46
        '
        'cboYAxisType
        '
        Me.cboYAxisType.BackColor = System.Drawing.SystemColors.Window
        Me.cboYAxisType.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboYAxisType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYAxisType.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYAxisType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboYAxisType.Location = New System.Drawing.Point(362, 494)
        Me.cboYAxisType.Name = "cboYAxisType"
        Me.cboYAxisType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboYAxisType.Size = New System.Drawing.Size(151, 24)
        Me.cboYAxisType.TabIndex = 47
        '
        'cmdViewProcessDiagram
        '
        Me.cmdViewProcessDiagram.Location = New System.Drawing.Point(534, 347)
        Me.cmdViewProcessDiagram.Name = "cmdViewProcessDiagram"
        Me.cmdViewProcessDiagram.OcxState = CType(resources.GetObject("cmdViewProcessDiagram.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cmdViewProcessDiagram.Size = New System.Drawing.Size(174, 49)
        Me.cmdViewProcessDiagram.TabIndex = 48
        Me.cmdViewProcessDiagram.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(531, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Grid Style:"
        '
        '_lblMisc_0
        '
        Me._lblMisc_0.BackColor = System.Drawing.SystemColors.Control
        Me._lblMisc_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblMisc_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblMisc_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblMisc_0.Location = New System.Drawing.Point(28, 176)
        Me._lblMisc_0.Name = "_lblMisc_0"
        Me._lblMisc_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblMisc_0.Size = New System.Drawing.Size(290, 24)
        Me._lblMisc_0.TabIndex = 53
        Me._lblMisc_0.Text = "Steady State Conc. at Saturation (Cr,ss)"
        Me._lblMisc_0.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSSValue
        '
        Me.lblSSValue.BackColor = System.Drawing.SystemColors.Control
        Me.lblSSValue.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSSValue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSSValue.Location = New System.Drawing.Point(324, 176)
        Me.lblSSValue.Name = "lblSSValue"
        Me.lblSSValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSSValue.Size = New System.Drawing.Size(87, 17)
        Me.lblSSValue.TabIndex = 54
        Me.lblSSValue.Text = "lblSSValue"
        Me.lblSSValue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSSValueUnits
        '
        Me.lblSSValueUnits.BackColor = System.Drawing.SystemColors.Control
        Me.lblSSValueUnits.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSSValueUnits.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSValueUnits.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSSValueUnits.Location = New System.Drawing.Point(417, 176)
        Me.lblSSValueUnits.Name = "lblSSValueUnits"
        Me.lblSSValueUnits.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSSValueUnits.Size = New System.Drawing.Size(85, 17)
        Me.lblSSValueUnits.TabIndex = 55
        Me.lblSSValueUnits.Text = "{u}g/L"
        '
        'cmdTreatA
        '
        Me.cmdTreatA.Location = New System.Drawing.Point(10, 112)
        Me.cmdTreatA.Name = "cmdTreatA"
        Me.cmdTreatA.OcxState = CType(resources.GetObject("cmdTreatA.OcxState"), System.Windows.Forms.AxHost.State)
        Me.cmdTreatA.Size = New System.Drawing.Size(177, 29)
        Me.cmdTreatA.TabIndex = 56
        '
        'grpBreak
        '
        Me.grpBreak.Location = New System.Drawing.Point(17, 214)
        Me.grpBreak.Name = "grpBreak"
        Me.grpBreak.OcxState = CType(resources.GetObject("grpBreak.OcxState"), System.Windows.Forms.AxHost.State)
        Me.grpBreak.Size = New System.Drawing.Size(508, 243)
        Me.grpBreak.TabIndex = 57
        '
        '_optType_0
        '
        Me._optType_0.Checked = True
        Me._optType_0.Location = New System.Drawing.Point(6, 25)
        Me._optType_0.Name = "_optType_0"
        Me._optType_0.Size = New System.Drawing.Size(69, 36)
        Me._optType_0.TabIndex = 59
        Me._optType_0.TabStop = True
        Me._optType_0.Text = "&Time"
        '
        '_optType_1
        '
        Me._optType_1.Location = New System.Drawing.Point(75, 25)
        Me._optType_1.Name = "_optType_1"
        Me._optType_1.Size = New System.Drawing.Size(65, 36)
        Me._optType_1.TabIndex = 60
        Me._optType_1.Text = "&BVT"
        '
        '_optType_2
        '
        Me._optType_2.Location = New System.Drawing.Point(140, 25)
        Me._optType_2.Name = "_optType_2"
        Me._optType_2.Size = New System.Drawing.Size(184, 38)
        Me._optType_2.TabIndex = 61
        Me._optType_2.Text = "Volume Treated by M&ass"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me._optType_0)
        Me.GroupBox1.Controls.Add(Me._optType_1)
        Me.GroupBox1.Controls.Add(Me._optType_2)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 468)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 76)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "X Axis Type"
        '
        'frmModelPSDMResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(736, 613)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpBreak)
        Me.Controls.Add(Me.cmdTreatA)
        Me.Controls.Add(Me.lblSSValueUnits)
        Me.Controls.Add(Me.lblSSValue)
        Me.Controls.Add(Me._lblMisc_0)
        Me.Controls.Add(Me.cboYAxisType)
        Me.Controls.Add(Me.Command4)
        Me.Controls.Add(Me.cmdTreat)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.ssframe_SSConc)
        Me.Controls.Add(Me.cboGrid)
        Me.Controls.Add(Me.Frame3D1)
        Me.Controls.Add(Me.cmdFile)
        Me.Controls.Add(Me.cmdExcel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.CMDialog1)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.SSFrame3)
        Me.Controls.Add(Me.cmdViewProcessDiagram)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(218, 258)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmModelPSDMResults"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Results for the Pore and Surface Diffusion Model (PSDM)"
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ssframe_SSConc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Frame3D1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame3D1.ResumeLayout(False)
        CType(Me.cmdTreat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CMDialog1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSFrame3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdViewProcessDiagram, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLegend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMisc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdTreatA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpBreak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpBreak As AxGraphLib.AxGraph
    Public WithEvents _optType_0 As RadioButton
    Public WithEvents _optType_1 As RadioButton
    Public WithEvents _optType_2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox


#End Region
End Class