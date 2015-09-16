<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStatusLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Send0Button = New System.Windows.Forms.Button()
        Me.DisconnectButton = New System.Windows.Forms.Button()
        Me.Send1Button = New System.Windows.Forms.Button()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.EncodingComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.StopBit0RadioButton = New System.Windows.Forms.RadioButton()
        Me.StopBit1RadioButton = New System.Windows.Forms.RadioButton()
        Me.StopBit2RadioButton = New System.Windows.Forms.RadioButton()
        Me.StopBit1point5RadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ParityCheckNoneRadioButton = New System.Windows.Forms.RadioButton()
        Me.ParityCheckMarkRadioButton = New System.Windows.Forms.RadioButton()
        Me.ParityCheckSpaceRadioButton = New System.Windows.Forms.RadioButton()
        Me.ParityCheckEvenRadioButton = New System.Windows.Forms.RadioButton()
        Me.ParityCheckOddRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataBitsComboBox = New System.Windows.Forms.ComboBox()
        Me.BaudComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.COMPortComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScanCOMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SamplingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RecevedRichTxTBox = New System.Windows.Forms.RichTextBox()
        Me.ArduinoPictureBox = New System.Windows.Forms.PictureBox()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ArduinoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStatusLbl})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 425)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(438, 22)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStatusLbl
        '
        Me.ToolStatusLbl.Name = "ToolStatusLbl"
        Me.ToolStatusLbl.Size = New System.Drawing.Size(86, 17)
        Me.ToolStatusLbl.Text = "Unknow Status"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Send0Button)
        Me.GroupBox1.Controls.Add(Me.DisconnectButton)
        Me.GroupBox1.Controls.Add(Me.Send1Button)
        Me.GroupBox1.Controls.Add(Me.ConnectButton)
        Me.GroupBox1.Controls.Add(Me.ArduinoPictureBox)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DataBitsComboBox)
        Me.GroupBox1.Controls.Add(Me.BaudComboBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.COMPortComboBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(134, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 394)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Serial Port Settings"
        '
        'Send0Button
        '
        Me.Send0Button.Location = New System.Drawing.Point(6, 199)
        Me.Send0Button.Name = "Send0Button"
        Me.Send0Button.Size = New System.Drawing.Size(50, 23)
        Me.Send0Button.TabIndex = 37
        Me.Send0Button.Text = "Send 0"
        Me.Send0Button.UseVisualStyleBackColor = True
        '
        'DisconnectButton
        '
        Me.DisconnectButton.Location = New System.Drawing.Point(130, 199)
        Me.DisconnectButton.Name = "DisconnectButton"
        Me.DisconnectButton.Size = New System.Drawing.Size(75, 23)
        Me.DisconnectButton.TabIndex = 35
        Me.DisconnectButton.Text = "&Disconnect"
        Me.DisconnectButton.UseVisualStyleBackColor = True
        '
        'Send1Button
        '
        Me.Send1Button.Location = New System.Drawing.Point(62, 199)
        Me.Send1Button.Name = "Send1Button"
        Me.Send1Button.Size = New System.Drawing.Size(52, 23)
        Me.Send1Button.TabIndex = 36
        Me.Send1Button.Text = "Send1"
        Me.Send1Button.UseVisualStyleBackColor = True
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(211, 199)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(75, 23)
        Me.ConnectButton.TabIndex = 34
        Me.ConnectButton.Text = "&Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.EncodingComboBox)
        Me.GroupBox4.Location = New System.Drawing.Point(179, 146)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(104, 47)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Encoding"
        '
        'EncodingComboBox
        '
        Me.EncodingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EncodingComboBox.FormattingEnabled = True
        Me.EncodingComboBox.Items.AddRange(New Object() {"Default", "ASCII", "BigEndianUnicode", "Unicode", "UTF32", "UTF7", "UTF8"})
        Me.EncodingComboBox.Location = New System.Drawing.Point(6, 15)
        Me.EncodingComboBox.Name = "EncodingComboBox"
        Me.EncodingComboBox.Size = New System.Drawing.Size(92, 21)
        Me.EncodingComboBox.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.StopBit0RadioButton)
        Me.GroupBox3.Controls.Add(Me.StopBit1RadioButton)
        Me.GroupBox3.Controls.Add(Me.StopBit2RadioButton)
        Me.GroupBox3.Controls.Add(Me.StopBit1point5RadioButton)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 146)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(164, 47)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stop Bits"
        '
        'StopBit0RadioButton
        '
        Me.StopBit0RadioButton.AutoSize = True
        Me.StopBit0RadioButton.Location = New System.Drawing.Point(6, 19)
        Me.StopBit0RadioButton.Name = "StopBit0RadioButton"
        Me.StopBit0RadioButton.Size = New System.Drawing.Size(31, 17)
        Me.StopBit0RadioButton.TabIndex = 13
        Me.StopBit0RadioButton.TabStop = True
        Me.StopBit0RadioButton.Text = "0"
        Me.StopBit0RadioButton.UseVisualStyleBackColor = True
        '
        'StopBit1RadioButton
        '
        Me.StopBit1RadioButton.AutoSize = True
        Me.StopBit1RadioButton.Location = New System.Drawing.Point(43, 19)
        Me.StopBit1RadioButton.Name = "StopBit1RadioButton"
        Me.StopBit1RadioButton.Size = New System.Drawing.Size(31, 17)
        Me.StopBit1RadioButton.TabIndex = 14
        Me.StopBit1RadioButton.TabStop = True
        Me.StopBit1RadioButton.Text = "1"
        Me.StopBit1RadioButton.UseVisualStyleBackColor = True
        '
        'StopBit2RadioButton
        '
        Me.StopBit2RadioButton.AutoSize = True
        Me.StopBit2RadioButton.Location = New System.Drawing.Point(126, 19)
        Me.StopBit2RadioButton.Name = "StopBit2RadioButton"
        Me.StopBit2RadioButton.Size = New System.Drawing.Size(31, 17)
        Me.StopBit2RadioButton.TabIndex = 16
        Me.StopBit2RadioButton.TabStop = True
        Me.StopBit2RadioButton.Text = "2"
        Me.StopBit2RadioButton.UseVisualStyleBackColor = True
        '
        'StopBit1point5RadioButton
        '
        Me.StopBit1point5RadioButton.AutoSize = True
        Me.StopBit1point5RadioButton.Location = New System.Drawing.Point(80, 19)
        Me.StopBit1point5RadioButton.Name = "StopBit1point5RadioButton"
        Me.StopBit1point5RadioButton.Size = New System.Drawing.Size(40, 17)
        Me.StopBit1point5RadioButton.TabIndex = 15
        Me.StopBit1point5RadioButton.TabStop = True
        Me.StopBit1point5RadioButton.Text = "1.5"
        Me.StopBit1point5RadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ParityCheckNoneRadioButton)
        Me.GroupBox2.Controls.Add(Me.ParityCheckMarkRadioButton)
        Me.GroupBox2.Controls.Add(Me.ParityCheckSpaceRadioButton)
        Me.GroupBox2.Controls.Add(Me.ParityCheckEvenRadioButton)
        Me.GroupBox2.Controls.Add(Me.ParityCheckOddRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 46)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parity Check"
        '
        'ParityCheckNoneRadioButton
        '
        Me.ParityCheckNoneRadioButton.AutoSize = True
        Me.ParityCheckNoneRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.ParityCheckNoneRadioButton.Name = "ParityCheckNoneRadioButton"
        Me.ParityCheckNoneRadioButton.Size = New System.Drawing.Size(51, 17)
        Me.ParityCheckNoneRadioButton.TabIndex = 17
        Me.ParityCheckNoneRadioButton.TabStop = True
        Me.ParityCheckNoneRadioButton.Text = "None"
        Me.ParityCheckNoneRadioButton.UseVisualStyleBackColor = True
        '
        'ParityCheckMarkRadioButton
        '
        Me.ParityCheckMarkRadioButton.AutoSize = True
        Me.ParityCheckMarkRadioButton.Location = New System.Drawing.Point(219, 19)
        Me.ParityCheckMarkRadioButton.Name = "ParityCheckMarkRadioButton"
        Me.ParityCheckMarkRadioButton.Size = New System.Drawing.Size(49, 17)
        Me.ParityCheckMarkRadioButton.TabIndex = 20
        Me.ParityCheckMarkRadioButton.TabStop = True
        Me.ParityCheckMarkRadioButton.Text = "Mark"
        Me.ParityCheckMarkRadioButton.UseVisualStyleBackColor = True
        '
        'ParityCheckSpaceRadioButton
        '
        Me.ParityCheckSpaceRadioButton.AutoSize = True
        Me.ParityCheckSpaceRadioButton.Location = New System.Drawing.Point(165, 19)
        Me.ParityCheckSpaceRadioButton.Name = "ParityCheckSpaceRadioButton"
        Me.ParityCheckSpaceRadioButton.Size = New System.Drawing.Size(56, 17)
        Me.ParityCheckSpaceRadioButton.TabIndex = 21
        Me.ParityCheckSpaceRadioButton.TabStop = True
        Me.ParityCheckSpaceRadioButton.Text = "Space"
        Me.ParityCheckSpaceRadioButton.UseVisualStyleBackColor = True
        '
        'ParityCheckEvenRadioButton
        '
        Me.ParityCheckEvenRadioButton.AutoSize = True
        Me.ParityCheckEvenRadioButton.Location = New System.Drawing.Point(63, 19)
        Me.ParityCheckEvenRadioButton.Name = "ParityCheckEvenRadioButton"
        Me.ParityCheckEvenRadioButton.Size = New System.Drawing.Size(50, 17)
        Me.ParityCheckEvenRadioButton.TabIndex = 18
        Me.ParityCheckEvenRadioButton.TabStop = True
        Me.ParityCheckEvenRadioButton.Text = "Even"
        Me.ParityCheckEvenRadioButton.UseVisualStyleBackColor = True
        '
        'ParityCheckOddRadioButton
        '
        Me.ParityCheckOddRadioButton.AutoSize = True
        Me.ParityCheckOddRadioButton.Location = New System.Drawing.Point(114, 19)
        Me.ParityCheckOddRadioButton.Name = "ParityCheckOddRadioButton"
        Me.ParityCheckOddRadioButton.Size = New System.Drawing.Size(45, 17)
        Me.ParityCheckOddRadioButton.TabIndex = 19
        Me.ParityCheckOddRadioButton.TabStop = True
        Me.ParityCheckOddRadioButton.Text = "Odd"
        Me.ParityCheckOddRadioButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Data Bits"
        '
        'DataBitsComboBox
        '
        Me.DataBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DataBitsComboBox.FormattingEnabled = True
        Me.DataBitsComboBox.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.DataBitsComboBox.Location = New System.Drawing.Point(98, 67)
        Me.DataBitsComboBox.Name = "DataBitsComboBox"
        Me.DataBitsComboBox.Size = New System.Drawing.Size(185, 21)
        Me.DataBitsComboBox.TabIndex = 29
        '
        'BaudComboBox
        '
        Me.BaudComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BaudComboBox.FormattingEnabled = True
        Me.BaudComboBox.Items.AddRange(New Object() {"200", "400", "800", "1200", "2400", "4800", "9600", "19200"})
        Me.BaudComboBox.Location = New System.Drawing.Point(98, 40)
        Me.BaudComboBox.Name = "BaudComboBox"
        Me.BaudComboBox.Size = New System.Drawing.Size(185, 21)
        Me.BaudComboBox.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Baud Rate"
        '
        'COMPortComboBox
        '
        Me.COMPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMPortComboBox.FormattingEnabled = True
        Me.COMPortComboBox.Location = New System.Drawing.Point(98, 13)
        Me.COMPortComboBox.Name = "COMPortComboBox"
        Me.COMPortComboBox.Size = New System.Drawing.Size(185, 21)
        Me.COMPortComboBox.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Select COM Port"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(438, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScanCOMToolStripMenuItem, Me.ToolStripSeparator1, Me.RestartToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "&Menu"
        '
        'ScanCOMToolStripMenuItem
        '
        Me.ScanCOMToolStripMenuItem.Name = "ScanCOMToolStripMenuItem"
        Me.ScanCOMToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ScanCOMToolStripMenuItem.Text = "&Scan COM"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'SamplingTimer
        '
        Me.SamplingTimer.Interval = 1000
        '
        'RecevedRichTxTBox
        '
        Me.RecevedRichTxTBox.Location = New System.Drawing.Point(12, 27)
        Me.RecevedRichTxTBox.Name = "RecevedRichTxTBox"
        Me.RecevedRichTxTBox.ReadOnly = True
        Me.RecevedRichTxTBox.Size = New System.Drawing.Size(116, 394)
        Me.RecevedRichTxTBox.TabIndex = 38
        Me.RecevedRichTxTBox.Text = ""
        '
        'ArduinoPictureBox
        '
        Me.ArduinoPictureBox.Image = Global.ArduinoProjectV2.My.Resources.Resources._720px_Arduino_Logo_svg
        Me.ArduinoPictureBox.Location = New System.Drawing.Point(6, 228)
        Me.ArduinoPictureBox.Name = "ArduinoPictureBox"
        Me.ArduinoPictureBox.Size = New System.Drawing.Size(280, 160)
        Me.ArduinoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ArduinoPictureBox.TabIndex = 33
        Me.ArduinoPictureBox.TabStop = False
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RestartToolStripMenuItem.Text = "&Restart"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 447)
        Me.Controls.Add(Me.RecevedRichTxTBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tempeture Sensor Panel"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ArduinoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReceivedListBox As System.Windows.Forms.ListBox
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStatusLbl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScanCOMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents EncodingComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents StopBit0RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents StopBit1RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents StopBit2RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents StopBit1point5RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ParityCheckNoneRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ParityCheckMarkRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ParityCheckSpaceRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ParityCheckEvenRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ParityCheckOddRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataBitsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BaudComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents COMPortComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DisconnectButton As System.Windows.Forms.Button
    Friend WithEvents ConnectButton As System.Windows.Forms.Button
    Friend WithEvents ArduinoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents SamplingTimer As System.Windows.Forms.Timer
    Friend WithEvents Send0Button As System.Windows.Forms.Button
    Friend WithEvents Send1Button As System.Windows.Forms.Button
    Friend WithEvents RecevedRichTxTBox As System.Windows.Forms.RichTextBox
    Friend WithEvents RestartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
