<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel6 = New Panel()
        Label11 = New Label()
        Panel14 = New Panel()
        LblStatusPc4 = New Label()
        LblTimer04 = New Label()
        BtnStopPc4 = New Button()
        Panel15 = New Panel()
        Label10 = New Label()
        Panel12 = New Panel()
        LblStatusPc3 = New Label()
        LblTimer03 = New Label()
        BtnStopPc3 = New Button()
        Panel13 = New Panel()
        Label9 = New Label()
        Panel10 = New Panel()
        LblStatusPc2 = New Label()
        LblTimer02 = New Label()
        BtnStopPc2 = New Button()
        Panel11 = New Panel()
        Label8 = New Label()
        Panel7 = New Panel()
        LblTimer01 = New Label()
        BtnStopPc1 = New Button()
        LblStatusPc1 = New Label()
        Panel8 = New Panel()
        Label7 = New Label()
        DataGridViewLogs = New DataGridView()
        ClmPC = New DataGridViewTextBoxColumn()
        ClmActivity = New DataGridViewTextBoxColumn()
        ClmTime = New DataGridViewTextBoxColumn()
        ClmPrice = New DataGridViewTextBoxColumn()
        Panel9 = New Panel()
        Label12 = New Label()
        Panel16 = New Panel()
        GroupBox1 = New GroupBox()
        LblTimeAdded = New Label()
        Label16 = New Label()
        Label15 = New Label()
        TextBoxAmount = New TextBox()
        Label14 = New Label()
        BtnAddTime = New Button()
        Label6 = New Label()
        RadioBtnPc04 = New RadioButton()
        RadioBtnPc03 = New RadioButton()
        RadioBtnPc02 = New RadioButton()
        RadioBtnPc01 = New RadioButton()
        TimerMain = New Timer(components)
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        Panel6.SuspendLayout()
        Panel14.SuspendLayout()
        Panel15.SuspendLayout()
        Panel12.SuspendLayout()
        Panel13.SuspendLayout()
        Panel10.SuspendLayout()
        Panel11.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        CType(DataGridViewLogs, ComponentModel.ISupportInitialize).BeginInit()
        Panel9.SuspendLayout()
        Panel16.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(52), CByte(61), CByte(138))
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-2, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1017, 56)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1014, 56)
        Label1.TabIndex = 0
        Label1.Text = "COMPSHOP MANAGEMENT SYSTEM"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(73), CByte(73), CByte(73))
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(Label11)
        Panel6.Controls.Add(Panel14)
        Panel6.Controls.Add(Panel12)
        Panel6.Controls.Add(Panel10)
        Panel6.Controls.Add(Panel7)
        Panel6.Location = New Point(10, 72)
        Panel6.Margin = New Padding(3, 2, 3, 2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(468, 408)
        Panel6.TabIndex = 3
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(16, 10)
        Label11.Name = "Label11"
        Label11.Size = New Size(132, 22)
        Label11.TabIndex = 4
        Label11.Text = "PC MONITOR"
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.FromArgb(CByte(54), CByte(69), CByte(79))
        Panel14.BorderStyle = BorderStyle.FixedSingle
        Panel14.Controls.Add(LblStatusPc4)
        Panel14.Controls.Add(LblTimer04)
        Panel14.Controls.Add(BtnStopPc4)
        Panel14.Controls.Add(Panel15)
        Panel14.Location = New Point(249, 227)
        Panel14.Margin = New Padding(3, 2, 3, 2)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(204, 167)
        Panel14.TabIndex = 3
        ' 
        ' LblStatusPc4
        ' 
        LblStatusPc4.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblStatusPc4.ForeColor = Color.FromArgb(CByte(56), CByte(232), CByte(62))
        LblStatusPc4.Location = New Point(3, 51)
        LblStatusPc4.Name = "LblStatusPc4"
        LblStatusPc4.Size = New Size(199, 17)
        LblStatusPc4.TabIndex = 5
        LblStatusPc4.Text = "● AVAILABLE"
        LblStatusPc4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblTimer04
        ' 
        LblTimer04.Font = New Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTimer04.Location = New Point(0, 77)
        LblTimer04.Name = "LblTimer04"
        LblTimer04.Size = New Size(204, 25)
        LblTimer04.TabIndex = 6
        LblTimer04.Text = "00:00:00"
        LblTimer04.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnStopPc4
        ' 
        BtnStopPc4.FlatStyle = FlatStyle.System
        BtnStopPc4.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnStopPc4.ForeColor = Color.Red
        BtnStopPc4.Location = New Point(14, 116)
        BtnStopPc4.Margin = New Padding(3, 2, 3, 2)
        BtnStopPc4.Name = "BtnStopPc4"
        BtnStopPc4.Size = New Size(175, 38)
        BtnStopPc4.TabIndex = 2
        BtnStopPc4.Text = "◼   STOP"
        BtnStopPc4.UseVisualStyleBackColor = True
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.FromArgb(CByte(209), CByte(228), CByte(255))
        Panel15.Controls.Add(Label10)
        Panel15.Location = New Point(0, 0)
        Panel15.Margin = New Padding(3, 2, 3, 2)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(204, 34)
        Panel15.TabIndex = 0
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.FromArgb(CByte(52), CByte(52), CByte(52))
        Label10.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(0, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(204, 34)
        Label10.TabIndex = 0
        Label10.Text = "PC 04"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.FromArgb(CByte(54), CByte(69), CByte(79))
        Panel12.BorderStyle = BorderStyle.FixedSingle
        Panel12.Controls.Add(LblStatusPc3)
        Panel12.Controls.Add(LblTimer03)
        Panel12.Controls.Add(BtnStopPc3)
        Panel12.Controls.Add(Panel13)
        Panel12.Location = New Point(16, 227)
        Panel12.Margin = New Padding(3, 2, 3, 2)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(204, 167)
        Panel12.TabIndex = 3
        ' 
        ' LblStatusPc3
        ' 
        LblStatusPc3.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblStatusPc3.ForeColor = Color.FromArgb(CByte(56), CByte(232), CByte(62))
        LblStatusPc3.Location = New Point(0, 51)
        LblStatusPc3.Name = "LblStatusPc3"
        LblStatusPc3.Size = New Size(202, 17)
        LblStatusPc3.TabIndex = 6
        LblStatusPc3.Text = "● AVAILABLE"
        LblStatusPc3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblTimer03
        ' 
        LblTimer03.Font = New Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTimer03.Location = New Point(0, 77)
        LblTimer03.Name = "LblTimer03"
        LblTimer03.Size = New Size(204, 25)
        LblTimer03.TabIndex = 5
        LblTimer03.Text = "00:00:00"
        LblTimer03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnStopPc3
        ' 
        BtnStopPc3.FlatStyle = FlatStyle.System
        BtnStopPc3.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnStopPc3.ForeColor = Color.Red
        BtnStopPc3.Location = New Point(14, 116)
        BtnStopPc3.Margin = New Padding(3, 2, 3, 2)
        BtnStopPc3.Name = "BtnStopPc3"
        BtnStopPc3.Size = New Size(175, 38)
        BtnStopPc3.TabIndex = 2
        BtnStopPc3.Text = "◼   STOP"
        BtnStopPc3.UseVisualStyleBackColor = True
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.FromArgb(CByte(209), CByte(228), CByte(255))
        Panel13.Controls.Add(Label9)
        Panel13.Location = New Point(0, 0)
        Panel13.Margin = New Padding(3, 2, 3, 2)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(204, 34)
        Panel13.TabIndex = 0
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.FromArgb(CByte(52), CByte(52), CByte(52))
        Label9.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(0, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(204, 34)
        Label9.TabIndex = 0
        Label9.Text = "PC 03"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(54), CByte(69), CByte(79))
        Panel10.BorderStyle = BorderStyle.FixedSingle
        Panel10.Controls.Add(LblStatusPc2)
        Panel10.Controls.Add(LblTimer02)
        Panel10.Controls.Add(BtnStopPc2)
        Panel10.Controls.Add(Panel11)
        Panel10.Location = New Point(249, 49)
        Panel10.Margin = New Padding(3, 2, 3, 2)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(204, 167)
        Panel10.TabIndex = 3
        ' 
        ' LblStatusPc2
        ' 
        LblStatusPc2.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblStatusPc2.ForeColor = Color.FromArgb(CByte(56), CByte(232), CByte(62))
        LblStatusPc2.Location = New Point(-1, 48)
        LblStatusPc2.Name = "LblStatusPc2"
        LblStatusPc2.Size = New Size(203, 17)
        LblStatusPc2.TabIndex = 4
        LblStatusPc2.Text = "● AVAILABLE"
        LblStatusPc2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblTimer02
        ' 
        LblTimer02.Font = New Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTimer02.Location = New Point(-1, 78)
        LblTimer02.Name = "LblTimer02"
        LblTimer02.Size = New Size(204, 25)
        LblTimer02.TabIndex = 4
        LblTimer02.Text = "00:00:00"
        LblTimer02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnStopPc2
        ' 
        BtnStopPc2.BackColor = Color.FromArgb(CByte(73), CByte(73), CByte(73))
        BtnStopPc2.FlatStyle = FlatStyle.System
        BtnStopPc2.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnStopPc2.ForeColor = Color.White
        BtnStopPc2.Location = New Point(13, 118)
        BtnStopPc2.Margin = New Padding(3, 2, 3, 2)
        BtnStopPc2.Name = "BtnStopPc2"
        BtnStopPc2.Size = New Size(175, 38)
        BtnStopPc2.TabIndex = 2
        BtnStopPc2.Text = "◼   STOP"
        BtnStopPc2.UseVisualStyleBackColor = False
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(52), CByte(52), CByte(52))
        Panel11.Controls.Add(Label8)
        Panel11.Location = New Point(-1, -1)
        Panel11.Margin = New Padding(3, 2, 3, 2)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(204, 35)
        Panel11.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(0, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(204, 35)
        Label8.TabIndex = 1
        Label8.Text = "PC 02"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(54), CByte(69), CByte(79))
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(LblTimer01)
        Panel7.Controls.Add(BtnStopPc1)
        Panel7.Controls.Add(LblStatusPc1)
        Panel7.Controls.Add(Panel8)
        Panel7.Location = New Point(16, 49)
        Panel7.Margin = New Padding(3, 2, 3, 2)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(204, 167)
        Panel7.TabIndex = 0
        ' 
        ' LblTimer01
        ' 
        LblTimer01.Font = New Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTimer01.Location = New Point(0, 78)
        LblTimer01.Name = "LblTimer01"
        LblTimer01.Size = New Size(204, 25)
        LblTimer01.TabIndex = 3
        LblTimer01.Text = "00:00:00"
        LblTimer01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnStopPc1
        ' 
        BtnStopPc1.BackColor = Color.White
        BtnStopPc1.BackgroundImageLayout = ImageLayout.Zoom
        BtnStopPc1.FlatStyle = FlatStyle.System
        BtnStopPc1.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnStopPc1.ForeColor = Color.Red
        BtnStopPc1.Location = New Point(14, 118)
        BtnStopPc1.Margin = New Padding(3, 2, 3, 2)
        BtnStopPc1.Name = "BtnStopPc1"
        BtnStopPc1.Size = New Size(175, 38)
        BtnStopPc1.TabIndex = 2
        BtnStopPc1.Text = "◼   STOP"
        BtnStopPc1.UseVisualStyleBackColor = False
        ' 
        ' LblStatusPc1
        ' 
        LblStatusPc1.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblStatusPc1.ForeColor = Color.FromArgb(CByte(56), CByte(232), CByte(62))
        LblStatusPc1.Location = New Point(3, 48)
        LblStatusPc1.Name = "LblStatusPc1"
        LblStatusPc1.Size = New Size(199, 17)
        LblStatusPc1.TabIndex = 1
        LblStatusPc1.Text = "● AVAILABLE"
        LblStatusPc1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(52), CByte(52), CByte(52))
        Panel8.Controls.Add(Label7)
        Panel8.Location = New Point(0, 0)
        Panel8.Margin = New Padding(3, 2, 3, 2)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(204, 35)
        Panel8.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(204, 35)
        Label7.TabIndex = 0
        Label7.Text = "PC 01"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DataGridViewLogs
        ' 
        DataGridViewLogs.BackgroundColor = Color.FromArgb(CByte(54), CByte(69), CByte(79))
        DataGridViewLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewLogs.Columns.AddRange(New DataGridViewColumn() {ClmPC, ClmActivity, ClmTime, ClmPrice})
        DataGridViewLogs.Location = New Point(3, 38)
        DataGridViewLogs.Margin = New Padding(3, 2, 3, 2)
        DataGridViewLogs.Name = "DataGridViewLogs"
        DataGridViewLogs.ReadOnly = True
        DataGridViewLogs.RowHeadersWidth = 51
        DataGridViewLogs.Size = New Size(508, 141)
        DataGridViewLogs.TabIndex = 4
        ' 
        ' ClmPC
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        ClmPC.DefaultCellStyle = DataGridViewCellStyle1
        ClmPC.HeaderText = "PC"
        ClmPC.MinimumWidth = 6
        ClmPC.Name = "ClmPC"
        ClmPC.ReadOnly = True
        ClmPC.Resizable = DataGridViewTriState.False
        ClmPC.Width = 60
        ' 
        ' ClmActivity
        ' 
        ClmActivity.HeaderText = "Activity"
        ClmActivity.MinimumWidth = 6
        ClmActivity.Name = "ClmActivity"
        ClmActivity.ReadOnly = True
        ClmActivity.Resizable = DataGridViewTriState.False
        ClmActivity.Width = 180
        ' 
        ' ClmTime
        ' 
        ClmTime.HeaderText = "Time"
        ClmTime.MinimumWidth = 6
        ClmTime.Name = "ClmTime"
        ClmTime.ReadOnly = True
        ClmTime.Resizable = DataGridViewTriState.False
        ClmTime.Width = 105
        ' 
        ' ClmPrice
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight
        ClmPrice.DefaultCellStyle = DataGridViewCellStyle2
        ClmPrice.HeaderText = "Price"
        ClmPrice.MinimumWidth = 6
        ClmPrice.Name = "ClmPrice"
        ClmPrice.ReadOnly = True
        ClmPrice.Width = 110
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(Label12)
        Panel9.Controls.Add(DataGridViewLogs)
        Panel9.ForeColor = Color.Black
        Panel9.Location = New Point(484, 291)
        Panel9.Margin = New Padding(3, 2, 3, 2)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(513, 189)
        Panel9.TabIndex = 5
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Location = New Point(3, 8)
        Label12.Name = "Label12"
        Label12.Size = New Size(148, 22)
        Label12.TabIndex = 5
        Label12.Text = "RECENT LOGS"
        ' 
        ' Panel16
        ' 
        Panel16.BackColor = Color.FromArgb(CByte(54), CByte(69), CByte(79))
        Panel16.Controls.Add(GroupBox1)
        Panel16.Controls.Add(BtnAddTime)
        Panel16.Controls.Add(Label6)
        Panel16.Controls.Add(RadioBtnPc04)
        Panel16.Controls.Add(RadioBtnPc03)
        Panel16.Controls.Add(RadioBtnPc02)
        Panel16.Controls.Add(RadioBtnPc01)
        Panel16.Location = New Point(484, 72)
        Panel16.Margin = New Padding(3, 2, 3, 2)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(513, 214)
        Panel16.TabIndex = 6
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(LblTimeAdded)
        GroupBox1.Controls.Add(Label16)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(TextBoxAmount)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(18, 82)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(431, 86)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "ADD TIME"
        ' 
        ' LblTimeAdded
        ' 
        LblTimeAdded.Location = New Point(176, 52)
        LblTimeAdded.Name = "LblTimeAdded"
        LblTimeAdded.Size = New Size(79, 17)
        LblTimeAdded.TabIndex = 4
        LblTimeAdded.Text = "----"
        LblTimeAdded.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(59, 52)
        Label16.Name = "Label16"
        Label16.Size = New Size(46, 18)
        Label16.TabIndex = 3
        Label16.Text = "Time:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(150, 25)
        Label15.Name = "Label15"
        Label15.Size = New Size(19, 18)
        Label15.TabIndex = 2
        Label15.Text = "₱"
        ' 
        ' TextBoxAmount
        ' 
        TextBoxAmount.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxAmount.Location = New Point(176, 20)
        TextBoxAmount.Margin = New Padding(3, 2, 3, 2)
        TextBoxAmount.Name = "TextBoxAmount"
        TextBoxAmount.Size = New Size(79, 26)
        TextBoxAmount.TabIndex = 1
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(34, 25)
        Label14.Name = "Label14"
        Label14.Size = New Size(105, 18)
        Label14.TabIndex = 0
        Label14.Text = "Enter Amount:"
        ' 
        ' BtnAddTime
        ' 
        BtnAddTime.BackColor = Color.FromArgb(CByte(42), CByte(111), CByte(250))
        BtnAddTime.FlatStyle = FlatStyle.System
        BtnAddTime.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnAddTime.ForeColor = Color.White
        BtnAddTime.Location = New Point(157, 172)
        BtnAddTime.Margin = New Padding(3, 2, 3, 2)
        BtnAddTime.Name = "BtnAddTime"
        BtnAddTime.Size = New Size(151, 30)
        BtnAddTime.TabIndex = 7
        BtnAddTime.Text = "+   ADD TIME"
        BtnAddTime.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(3, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(123, 22)
        Label6.TabIndex = 4
        Label6.Text = "PC DETAILS"
        ' 
        ' RadioBtnPc04
        ' 
        RadioBtnPc04.AutoSize = True
        RadioBtnPc04.BackColor = Color.White
        RadioBtnPc04.Font = New Font("Arial", 13.8F)
        RadioBtnPc04.ForeColor = Color.Black
        RadioBtnPc04.Location = New Point(364, 42)
        RadioBtnPc04.Margin = New Padding(3, 2, 3, 2)
        RadioBtnPc04.Name = "RadioBtnPc04"
        RadioBtnPc04.Size = New Size(82, 26)
        RadioBtnPc04.TabIndex = 3
        RadioBtnPc04.TabStop = True
        RadioBtnPc04.Text = "PC 04"
        RadioBtnPc04.UseVisualStyleBackColor = False
        ' 
        ' RadioBtnPc03
        ' 
        RadioBtnPc03.AutoSize = True
        RadioBtnPc03.BackColor = Color.White
        RadioBtnPc03.Font = New Font("Arial", 13.8F)
        RadioBtnPc03.ForeColor = Color.Black
        RadioBtnPc03.Location = New Point(250, 42)
        RadioBtnPc03.Margin = New Padding(3, 2, 3, 2)
        RadioBtnPc03.Name = "RadioBtnPc03"
        RadioBtnPc03.Size = New Size(82, 26)
        RadioBtnPc03.TabIndex = 2
        RadioBtnPc03.TabStop = True
        RadioBtnPc03.Text = "PC 03"
        RadioBtnPc03.UseVisualStyleBackColor = False
        ' 
        ' RadioBtnPc02
        ' 
        RadioBtnPc02.AutoSize = True
        RadioBtnPc02.BackColor = Color.White
        RadioBtnPc02.Font = New Font("Arial", 13.8F)
        RadioBtnPc02.ForeColor = Color.Black
        RadioBtnPc02.Location = New Point(145, 42)
        RadioBtnPc02.Margin = New Padding(3, 2, 3, 2)
        RadioBtnPc02.Name = "RadioBtnPc02"
        RadioBtnPc02.Size = New Size(82, 26)
        RadioBtnPc02.TabIndex = 1
        RadioBtnPc02.TabStop = True
        RadioBtnPc02.Text = "PC 02"
        RadioBtnPc02.UseVisualStyleBackColor = False
        ' 
        ' RadioBtnPc01
        ' 
        RadioBtnPc01.AutoSize = True
        RadioBtnPc01.BackColor = Color.White
        RadioBtnPc01.Font = New Font("Arial", 13.8F)
        RadioBtnPc01.ForeColor = Color.Black
        RadioBtnPc01.Location = New Point(42, 42)
        RadioBtnPc01.Margin = New Padding(3, 2, 3, 2)
        RadioBtnPc01.Name = "RadioBtnPc01"
        RadioBtnPc01.Size = New Size(82, 26)
        RadioBtnPc01.TabIndex = 0
        RadioBtnPc01.TabStop = True
        RadioBtnPc01.Text = "PC 01"
        RadioBtnPc01.UseVisualStyleBackColor = False
        ' 
        ' TimerMain
        ' 
        TimerMain.Interval = 1000
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(52), CByte(61), CByte(138))
        Panel2.Location = New Point(-2, 494)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1017, 18)
        Panel2.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(52), CByte(52), CByte(52))
        ClientSize = New Size(1010, 509)
        Controls.Add(Panel2)
        Controls.Add(Panel16)
        Controls.Add(Panel9)
        Controls.Add(Panel6)
        Controls.Add(Panel1)
        ForeColor = Color.White
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel14.ResumeLayout(False)
        Panel15.ResumeLayout(False)
        Panel12.ResumeLayout(False)
        Panel13.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        CType(DataGridViewLogs, ComponentModel.ISupportInitialize).EndInit()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel16.ResumeLayout(False)
        Panel16.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents BtnStopPc1 As Button
    Friend WithEvents LblStatusPc1 As Label
    Friend WithEvents DataGridViewLogs As DataGridView
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents BtnStopPc4 As Button
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents BtnStopPc3 As Button
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents BtnStopPc2 As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents RadioBtnPc04 As RadioButton
    Friend WithEvents RadioBtnPc03 As RadioButton
    Friend WithEvents RadioBtnPc02 As RadioButton
    Friend WithEvents RadioBtnPc01 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LblTimer01 As Label
    Friend WithEvents TimerMain As Timer
    Friend WithEvents LblTimer04 As Label
    Friend WithEvents LblTimer03 As Label
    Friend WithEvents LblTimer02 As Label
    Friend WithEvents BtnAddTime As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxAmount As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents LblTimeAdded As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblStatusPc2 As Label
    Friend WithEvents LblStatusPc3 As Label
    Friend WithEvents LblStatusPc4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ClmPC As DataGridViewTextBoxColumn
    Friend WithEvents ClmActivity As DataGridViewTextBoxColumn
    Friend WithEvents ClmTime As DataGridViewTextBoxColumn
    Friend WithEvents ClmPrice As DataGridViewTextBoxColumn


End Class
