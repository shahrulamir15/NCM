<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.listProfiles = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.allSetting = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ipConfigure = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.listWifi = New System.Windows.Forms.ComboBox()
        Me.inputDNS1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnActivate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.autoIP = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.inputGateway = New System.Windows.Forms.TextBox()
        Me.inputSubnet = New System.Windows.Forms.TextBox()
        Me.inputIP = New System.Windows.Forms.TextBox()
        Me.listNetwork = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LabelNetwork = New System.Windows.Forms.Label()
        Me.adminCheck = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CurrentConfigure = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cComputerName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cDns2 = New System.Windows.Forms.Label()
        Me.cDns1 = New System.Windows.Forms.Label()
        Me.cGateway = New System.Windows.Forms.Label()
        Me.cSubnet = New System.Windows.Forms.Label()
        Me.cIP = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.inputDNS2 = New System.Windows.Forms.TextBox()
        Me.allSetting.SuspendLayout()
        Me.ipConfigure.SuspendLayout()
        Me.CurrentConfigure.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnProfile
        '
        Me.btnProfile.Location = New System.Drawing.Point(451, 19)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(133, 33)
        Me.btnProfile.TabIndex = 15
        Me.btnProfile.Text = "New Profiles"
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'listProfiles
        '
        Me.listProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listProfiles.FormattingEnabled = True
        Me.listProfiles.Location = New System.Drawing.Point(124, 24)
        Me.listProfiles.Name = "listProfiles"
        Me.listProfiles.Size = New System.Drawing.Size(321, 24)
        Me.listProfiles.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Profiles: "
        '
        'allSetting
        '
        Me.allSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.allSetting.Controls.Add(Me.btnDelete)
        Me.allSetting.Controls.Add(Me.btnProfile)
        Me.allSetting.Controls.Add(Me.btnSave)
        Me.allSetting.Controls.Add(Me.listProfiles)
        Me.allSetting.Controls.Add(Me.Label1)
        Me.allSetting.Controls.Add(Me.ipConfigure)
        Me.allSetting.Controls.Add(Me.CurrentConfigure)
        Me.allSetting.Controls.Add(Me.btnClose)
        Me.allSetting.Location = New System.Drawing.Point(9, 1)
        Me.allSetting.Margin = New System.Windows.Forms.Padding(0)
        Me.allSetting.Name = "allSetting"
        Me.allSetting.Size = New System.Drawing.Size(696, 661)
        Me.allSetting.TabIndex = 15
        Me.allSetting.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.ForeColor = System.Drawing.Color.Transparent
        Me.btnDelete.Image = Global.NCM.My.Resources.Resources.save_icon2
        Me.btnDelete.Location = New System.Drawing.Point(640, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(33, 33)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.ForeColor = System.Drawing.Color.Transparent
        Me.btnSave.Image = Global.NCM.My.Resources.Resources.save_icon2
        Me.btnSave.Location = New System.Drawing.Point(601, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(33, 33)
        Me.btnSave.TabIndex = 22
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'ipConfigure
        '
        Me.ipConfigure.Controls.Add(Me.inputDNS2)
        Me.ipConfigure.Controls.Add(Me.Label13)
        Me.ipConfigure.Controls.Add(Me.listWifi)
        Me.ipConfigure.Controls.Add(Me.inputDNS1)
        Me.ipConfigure.Controls.Add(Me.Label12)
        Me.ipConfigure.Controls.Add(Me.btnActivate)
        Me.ipConfigure.Controls.Add(Me.Label2)
        Me.ipConfigure.Controls.Add(Me.autoIP)
        Me.ipConfigure.Controls.Add(Me.LinkLabel1)
        Me.ipConfigure.Controls.Add(Me.inputGateway)
        Me.ipConfigure.Controls.Add(Me.inputSubnet)
        Me.ipConfigure.Controls.Add(Me.inputIP)
        Me.ipConfigure.Controls.Add(Me.listNetwork)
        Me.ipConfigure.Controls.Add(Me.Label16)
        Me.ipConfigure.Controls.Add(Me.LabelNetwork)
        Me.ipConfigure.Controls.Add(Me.adminCheck)
        Me.ipConfigure.Controls.Add(Me.Label6)
        Me.ipConfigure.Controls.Add(Me.Label5)
        Me.ipConfigure.Controls.Add(Me.Label4)
        Me.ipConfigure.Location = New System.Drawing.Point(20, 69)
        Me.ipConfigure.Name = "ipConfigure"
        Me.ipConfigure.Size = New System.Drawing.Size(659, 341)
        Me.ipConfigure.TabIndex = 3
        Me.ipConfigure.TabStop = False
        Me.ipConfigure.Text = "Configuration"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Location = New System.Drawing.Point(324, 166)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 17)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "WIFI:"
        '
        'listWifi
        '
        Me.listWifi.FormattingEnabled = True
        Me.listWifi.Location = New System.Drawing.Point(369, 161)
        Me.listWifi.Name = "listWifi"
        Me.listWifi.Size = New System.Drawing.Size(130, 24)
        Me.listWifi.TabIndex = 17
        '
        'inputDNS1
        '
        Me.inputDNS1.Location = New System.Drawing.Point(131, 257)
        Me.inputDNS1.Name = "inputDNS1"
        Me.inputDNS1.ReadOnly = True
        Me.inputDNS1.Size = New System.Drawing.Size(130, 22)
        Me.inputDNS1.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(68, 289)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 17)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "DNS 2:"
        '
        'btnActivate
        '
        Me.btnActivate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnActivate.Location = New System.Drawing.Point(495, 289)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(158, 33)
        Me.btnActivate.TabIndex = 9
        Me.btnActivate.Text = "&Activate Profile"
        Me.btnActivate.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Setup IP Configurations"
        '
        'autoIP
        '
        Me.autoIP.AutoSize = True
        Me.autoIP.Location = New System.Drawing.Point(41, 79)
        Me.autoIP.Name = "autoIP"
        Me.autoIP.Size = New System.Drawing.Size(187, 21)
        Me.autoIP.TabIndex = 16
        Me.autoIP.Text = "Automatic Configurations"
        Me.autoIP.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(366, 80)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(76, 17)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Add Admin"
        Me.LinkLabel1.Visible = False
        '
        'inputGateway
        '
        Me.inputGateway.Location = New System.Drawing.Point(131, 219)
        Me.inputGateway.Name = "inputGateway"
        Me.inputGateway.ReadOnly = True
        Me.inputGateway.Size = New System.Drawing.Size(130, 22)
        Me.inputGateway.TabIndex = 14
        '
        'inputSubnet
        '
        Me.inputSubnet.Location = New System.Drawing.Point(131, 191)
        Me.inputSubnet.Name = "inputSubnet"
        Me.inputSubnet.ReadOnly = True
        Me.inputSubnet.Size = New System.Drawing.Size(130, 22)
        Me.inputSubnet.TabIndex = 13
        '
        'inputIP
        '
        Me.inputIP.Location = New System.Drawing.Point(131, 163)
        Me.inputIP.Name = "inputIP"
        Me.inputIP.ReadOnly = True
        Me.inputIP.Size = New System.Drawing.Size(130, 22)
        Me.inputIP.TabIndex = 12
        '
        'listNetwork
        '
        Me.listNetwork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listNetwork.FormattingEnabled = True
        Me.listNetwork.Location = New System.Drawing.Point(150, 32)
        Me.listNetwork.Name = "listNetwork"
        Me.listNetwork.Size = New System.Drawing.Size(321, 24)
        Me.listNetwork.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(68, 262)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 17)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "DNS 1:"
        '
        'LabelNetwork
        '
        Me.LabelNetwork.AutoSize = True
        Me.LabelNetwork.Location = New System.Drawing.Point(38, 35)
        Me.LabelNetwork.Name = "LabelNetwork"
        Me.LabelNetwork.Size = New System.Drawing.Size(110, 17)
        Me.LabelNetwork.TabIndex = 0
        Me.LabelNetwork.Text = "Network Device:"
        '
        'adminCheck
        '
        Me.adminCheck.AutoSize = True
        Me.adminCheck.Location = New System.Drawing.Point(251, 79)
        Me.adminCheck.Name = "adminCheck"
        Me.adminCheck.Size = New System.Drawing.Size(99, 21)
        Me.adminCheck.TabIndex = 11
        Me.adminCheck.Text = "I am Admin"
        Me.adminCheck.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Gateway:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Subnet:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(101, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "IP:"
        '
        'CurrentConfigure
        '
        Me.CurrentConfigure.BackColor = System.Drawing.SystemColors.Menu
        Me.CurrentConfigure.Controls.Add(Me.Label3)
        Me.CurrentConfigure.Controls.Add(Me.cComputerName)
        Me.CurrentConfigure.Controls.Add(Me.Label7)
        Me.CurrentConfigure.Controls.Add(Me.cDns2)
        Me.CurrentConfigure.Controls.Add(Me.cDns1)
        Me.CurrentConfigure.Controls.Add(Me.cGateway)
        Me.CurrentConfigure.Controls.Add(Me.cSubnet)
        Me.CurrentConfigure.Controls.Add(Me.cIP)
        Me.CurrentConfigure.Controls.Add(Me.Label8)
        Me.CurrentConfigure.Controls.Add(Me.Label9)
        Me.CurrentConfigure.Controls.Add(Me.Label10)
        Me.CurrentConfigure.Controls.Add(Me.Label11)
        Me.CurrentConfigure.Location = New System.Drawing.Point(20, 416)
        Me.CurrentConfigure.Name = "CurrentConfigure"
        Me.CurrentConfigure.Size = New System.Drawing.Size(659, 181)
        Me.CurrentConfigure.TabIndex = 11
        Me.CurrentConfigure.TabStop = False
        Me.CurrentConfigure.Text = "Current Configuration"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(312, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "DNS 2:"
        '
        'cComputerName
        '
        Me.cComputerName.AutoSize = True
        Me.cComputerName.BackColor = System.Drawing.SystemColors.Info
        Me.cComputerName.Location = New System.Drawing.Point(155, 34)
        Me.cComputerName.Name = "cComputerName"
        Me.cComputerName.Size = New System.Drawing.Size(88, 17)
        Me.cComputerName.TabIndex = 17
        Me.cComputerName.Text = "Name Here.."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Computer Name"
        '
        'cDns2
        '
        Me.cDns2.AutoSize = True
        Me.cDns2.BackColor = System.Drawing.SystemColors.Info
        Me.cDns2.Location = New System.Drawing.Point(371, 67)
        Me.cDns2.Name = "cDns2"
        Me.cDns2.Size = New System.Drawing.Size(80, 17)
        Me.cDns2.TabIndex = 15
        Me.cDns2.Text = "DNS Here.."
        '
        'cDns1
        '
        Me.cDns1.AutoSize = True
        Me.cDns1.BackColor = System.Drawing.SystemColors.Info
        Me.cDns1.Location = New System.Drawing.Point(371, 34)
        Me.cDns1.Name = "cDns1"
        Me.cDns1.Size = New System.Drawing.Size(80, 17)
        Me.cDns1.TabIndex = 14
        Me.cDns1.Text = "DNS Here.."
        '
        'cGateway
        '
        Me.cGateway.AutoSize = True
        Me.cGateway.BackColor = System.Drawing.SystemColors.Info
        Me.cGateway.Location = New System.Drawing.Point(155, 133)
        Me.cGateway.Name = "cGateway"
        Me.cGateway.Size = New System.Drawing.Size(106, 17)
        Me.cGateway.TabIndex = 13
        Me.cGateway.Text = "Gateway Here.."
        '
        'cSubnet
        '
        Me.cSubnet.AutoSize = True
        Me.cSubnet.BackColor = System.Drawing.SystemColors.Info
        Me.cSubnet.Location = New System.Drawing.Point(155, 100)
        Me.cSubnet.Name = "cSubnet"
        Me.cSubnet.Size = New System.Drawing.Size(96, 17)
        Me.cSubnet.TabIndex = 12
        Me.cSubnet.Text = "Subnet Here.."
        '
        'cIP
        '
        Me.cIP.AutoSize = True
        Me.cIP.BackColor = System.Drawing.SystemColors.Info
        Me.cIP.Location = New System.Drawing.Point(155, 67)
        Me.cIP.Name = "cIP"
        Me.cIP.Size = New System.Drawing.Size(62, 17)
        Me.cIP.TabIndex = 11
        Me.cIP.Text = "Ip Here.."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(312, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "DNS 1:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(79, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Gateway:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(89, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Subnet:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(122, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 17)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "IP:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(521, 613)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(158, 33)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'inputDNS2
        '
        Me.inputDNS2.Location = New System.Drawing.Point(131, 286)
        Me.inputDNS2.Name = "inputDNS2"
        Me.inputDNS2.ReadOnly = True
        Me.inputDNS2.Size = New System.Drawing.Size(130, 22)
        Me.inputDNS2.TabIndex = 22
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 668)
        Me.Controls.Add(Me.allSetting)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NCM Ver 1.0"
        Me.allSetting.ResumeLayout(False)
        Me.allSetting.PerformLayout()
        Me.ipConfigure.ResumeLayout(False)
        Me.ipConfigure.PerformLayout()
        Me.CurrentConfigure.ResumeLayout(False)
        Me.CurrentConfigure.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProfile As Button
    Friend WithEvents listProfiles As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents allSetting As GroupBox
    Friend WithEvents ipConfigure As GroupBox
    Friend WithEvents inputGateway As TextBox
    Friend WithEvents inputSubnet As TextBox
    Friend WithEvents listNetwork As ComboBox
    Friend WithEvents LabelNetwork As Label
    Friend WithEvents adminCheck As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CurrentConfigure As GroupBox
    Friend WithEvents cComputerName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cDns2 As Label
    Friend WithEvents cDns1 As Label
    Friend WithEvents cGateway As Label
    Friend WithEvents cSubnet As Label
    Friend WithEvents cIP As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents listWifi As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btnActivate As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents autoIP As CheckBox
    Friend WithEvents inputDNS1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents inputIP As TextBox
    Friend WithEvents inputDNS2 As TextBox
End Class
