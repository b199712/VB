<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnDutOpen = New System.Windows.Forms.Button()
        Me.BtnDutIn = New System.Windows.Forms.Button()
        Me.CmbDutPort = New System.Windows.Forms.ComboBox()
        Me.RtbDutIn = New System.Windows.Forms.RichTextBox()
        Me.RtbDutOut = New System.Windows.Forms.RichTextBox()
        Me.LblDutIn = New System.Windows.Forms.Label()
        Me.LblDutOut = New System.Windows.Forms.Label()
        Me.BtnDutClose = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.CmbDutBaud = New System.Windows.Forms.ComboBox()
        Me.LblDutPort = New System.Windows.Forms.Label()
        Me.LblCbPort = New System.Windows.Forms.Label()
        Me.CmbCbPort = New System.Windows.Forms.ComboBox()
        Me.BtnCbOpen = New System.Windows.Forms.Button()
        Me.BtnCbClose = New System.Windows.Forms.Button()
        Me.LblCbIn = New System.Windows.Forms.Label()
        Me.RtbCbIn = New System.Windows.Forms.RichTextBox()
        Me.BtnCbIn = New System.Windows.Forms.Button()
        Me.LblCbOut = New System.Windows.Forms.Label()
        Me.RtbCbOut = New System.Windows.Forms.RichTextBox()
        Me.CmbCbBaud = New System.Windows.Forms.ComboBox()
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'BtnDutOpen
        '
        Me.BtnDutOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnDutOpen.Location = New System.Drawing.Point(235, 15)
        Me.BtnDutOpen.Name = "BtnDutOpen"
        Me.BtnDutOpen.Size = New System.Drawing.Size(136, 30)
        Me.BtnDutOpen.TabIndex = 0
        Me.BtnDutOpen.Text = "Open DUT Port"
        Me.BtnDutOpen.UseVisualStyleBackColor = True
        '
        'BtnDutIn
        '
        Me.BtnDutIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnDutIn.Location = New System.Drawing.Point(377, 56)
        Me.BtnDutIn.Name = "BtnDutIn"
        Me.BtnDutIn.Size = New System.Drawing.Size(136, 28)
        Me.BtnDutIn.TabIndex = 1
        Me.BtnDutIn.Text = "DUT Write"
        Me.BtnDutIn.UseVisualStyleBackColor = True
        '
        'CmbDutPort
        '
        Me.CmbDutPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDutPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CmbDutPort.FormattingEnabled = True
        Me.CmbDutPort.Location = New System.Drawing.Point(93, 16)
        Me.CmbDutPort.Name = "CmbDutPort"
        Me.CmbDutPort.Size = New System.Drawing.Size(136, 28)
        Me.CmbDutPort.TabIndex = 3
        '
        'RtbDutIn
        '
        Me.RtbDutIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RtbDutIn.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtbDutIn.Location = New System.Drawing.Point(93, 51)
        Me.RtbDutIn.Name = "RtbDutIn"
        Me.RtbDutIn.Size = New System.Drawing.Size(278, 33)
        Me.RtbDutIn.TabIndex = 4
        Me.RtbDutIn.Text = ""
        '
        'RtbDutOut
        '
        Me.RtbDutOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RtbDutOut.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtbDutOut.Location = New System.Drawing.Point(12, 120)
        Me.RtbDutOut.Name = "RtbDutOut"
        Me.RtbDutOut.Size = New System.Drawing.Size(501, 412)
        Me.RtbDutOut.TabIndex = 5
        Me.RtbDutOut.Text = ""
        '
        'LblDutIn
        '
        Me.LblDutIn.AutoSize = True
        Me.LblDutIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblDutIn.Location = New System.Drawing.Point(12, 59)
        Me.LblDutIn.Name = "LblDutIn"
        Me.LblDutIn.Size = New System.Drawing.Size(83, 20)
        Me.LblDutIn.TabIndex = 6
        Me.LblDutIn.Text = "DUT Input"
        '
        'LblDutOut
        '
        Me.LblDutOut.AutoSize = True
        Me.LblDutOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblDutOut.Location = New System.Drawing.Point(12, 97)
        Me.LblDutOut.Name = "LblDutOut"
        Me.LblDutOut.Size = New System.Drawing.Size(95, 20)
        Me.LblDutOut.TabIndex = 7
        Me.LblDutOut.Text = "DUT Output"
        '
        'BtnDutClose
        '
        Me.BtnDutClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnDutClose.Location = New System.Drawing.Point(377, 15)
        Me.BtnDutClose.Name = "BtnDutClose"
        Me.BtnDutClose.Size = New System.Drawing.Size(136, 30)
        Me.BtnDutClose.TabIndex = 8
        Me.BtnDutClose.Text = "DUT Close"
        Me.BtnDutClose.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 115200
        Me.SerialPort1.PortName = "COM6"
        '
        'CmbDutBaud
        '
        Me.CmbDutBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDutBaud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CmbDutBaud.FormattingEnabled = True
        Me.CmbDutBaud.Items.AddRange(New Object() {"9600", "38400", "57600", "115200"})
        Me.CmbDutBaud.Location = New System.Drawing.Point(377, 89)
        Me.CmbDutBaud.Name = "CmbDutBaud"
        Me.CmbDutBaud.Size = New System.Drawing.Size(136, 28)
        Me.CmbDutBaud.TabIndex = 9
        '
        'LblDutPort
        '
        Me.LblDutPort.AutoSize = True
        Me.LblDutPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblDutPort.Location = New System.Drawing.Point(12, 20)
        Me.LblDutPort.Name = "LblDutPort"
        Me.LblDutPort.Size = New System.Drawing.Size(75, 20)
        Me.LblDutPort.TabIndex = 10
        Me.LblDutPort.Text = "DUT Port"
        '
        'LblCbPort
        '
        Me.LblCbPort.AutoSize = True
        Me.LblCbPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblCbPort.Location = New System.Drawing.Point(527, 20)
        Me.LblCbPort.Name = "LblCbPort"
        Me.LblCbPort.Size = New System.Drawing.Size(64, 20)
        Me.LblCbPort.TabIndex = 13
        Me.LblCbPort.Text = "CB Port"
        '
        'CmbCbPort
        '
        Me.CmbCbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCbPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CmbCbPort.FormattingEnabled = True
        Me.CmbCbPort.Location = New System.Drawing.Point(605, 16)
        Me.CmbCbPort.Name = "CmbCbPort"
        Me.CmbCbPort.Size = New System.Drawing.Size(136, 28)
        Me.CmbCbPort.TabIndex = 12
        '
        'BtnCbOpen
        '
        Me.BtnCbOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnCbOpen.Location = New System.Drawing.Point(747, 17)
        Me.BtnCbOpen.Name = "BtnCbOpen"
        Me.BtnCbOpen.Size = New System.Drawing.Size(136, 28)
        Me.BtnCbOpen.TabIndex = 11
        Me.BtnCbOpen.Text = "Open CB Port"
        Me.BtnCbOpen.UseVisualStyleBackColor = True
        '
        'BtnCbClose
        '
        Me.BtnCbClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnCbClose.Location = New System.Drawing.Point(889, 18)
        Me.BtnCbClose.Name = "BtnCbClose"
        Me.BtnCbClose.Size = New System.Drawing.Size(136, 28)
        Me.BtnCbClose.TabIndex = 14
        Me.BtnCbClose.Text = "CB Close"
        Me.BtnCbClose.UseVisualStyleBackColor = True
        '
        'LblCbIn
        '
        Me.LblCbIn.AutoSize = True
        Me.LblCbIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblCbIn.Location = New System.Drawing.Point(527, 55)
        Me.LblCbIn.Name = "LblCbIn"
        Me.LblCbIn.Size = New System.Drawing.Size(72, 20)
        Me.LblCbIn.TabIndex = 17
        Me.LblCbIn.Text = "CB Input"
        '
        'RtbCbIn
        '
        Me.RtbCbIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RtbCbIn.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtbCbIn.Location = New System.Drawing.Point(605, 50)
        Me.RtbCbIn.Name = "RtbCbIn"
        Me.RtbCbIn.Size = New System.Drawing.Size(278, 33)
        Me.RtbCbIn.TabIndex = 16
        Me.RtbCbIn.Text = ""
        '
        'BtnCbIn
        '
        Me.BtnCbIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnCbIn.Location = New System.Drawing.Point(889, 55)
        Me.BtnCbIn.Name = "BtnCbIn"
        Me.BtnCbIn.Size = New System.Drawing.Size(136, 28)
        Me.BtnCbIn.TabIndex = 15
        Me.BtnCbIn.Text = "CB Write"
        Me.BtnCbIn.UseVisualStyleBackColor = True
        '
        'LblCbOut
        '
        Me.LblCbOut.AutoSize = True
        Me.LblCbOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblCbOut.Location = New System.Drawing.Point(527, 97)
        Me.LblCbOut.Name = "LblCbOut"
        Me.LblCbOut.Size = New System.Drawing.Size(84, 20)
        Me.LblCbOut.TabIndex = 19
        Me.LblCbOut.Text = "CB Output"
        '
        'RtbCbOut
        '
        Me.RtbCbOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RtbCbOut.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtbCbOut.Location = New System.Drawing.Point(531, 120)
        Me.RtbCbOut.Name = "RtbCbOut"
        Me.RtbCbOut.Size = New System.Drawing.Size(494, 412)
        Me.RtbCbOut.TabIndex = 18
        Me.RtbCbOut.Text = ""
        '
        'CmbCbBaud
        '
        Me.CmbCbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCbBaud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CmbCbBaud.FormattingEnabled = True
        Me.CmbCbBaud.Items.AddRange(New Object() {"9600", "38400", "57600", "115200"})
        Me.CmbCbBaud.Location = New System.Drawing.Point(889, 89)
        Me.CmbCbBaud.Name = "CmbCbBaud"
        Me.CmbCbBaud.Size = New System.Drawing.Size(136, 28)
        Me.CmbCbBaud.TabIndex = 20
        '
        'SerialPort2
        '
        Me.SerialPort2.BaudRate = 115200
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1040, 544)
        Me.Controls.Add(Me.CmbCbBaud)
        Me.Controls.Add(Me.LblCbOut)
        Me.Controls.Add(Me.RtbCbOut)
        Me.Controls.Add(Me.LblCbIn)
        Me.Controls.Add(Me.RtbCbIn)
        Me.Controls.Add(Me.BtnCbIn)
        Me.Controls.Add(Me.BtnCbClose)
        Me.Controls.Add(Me.LblCbPort)
        Me.Controls.Add(Me.CmbCbPort)
        Me.Controls.Add(Me.BtnCbOpen)
        Me.Controls.Add(Me.LblDutPort)
        Me.Controls.Add(Me.CmbDutBaud)
        Me.Controls.Add(Me.BtnDutClose)
        Me.Controls.Add(Me.LblDutOut)
        Me.Controls.Add(Me.LblDutIn)
        Me.Controls.Add(Me.RtbDutOut)
        Me.Controls.Add(Me.RtbDutIn)
        Me.Controls.Add(Me.CmbDutPort)
        Me.Controls.Add(Me.BtnDutIn)
        Me.Controls.Add(Me.BtnDutOpen)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SQA Lab Test System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnDutOpen As System.Windows.Forms.Button
    Friend WithEvents BtnDutIn As System.Windows.Forms.Button
    Friend WithEvents CmbDutPort As System.Windows.Forms.ComboBox
    Friend WithEvents RtbDutIn As System.Windows.Forms.RichTextBox
    Friend WithEvents RtbDutOut As System.Windows.Forms.RichTextBox
    Friend WithEvents LblDutIn As System.Windows.Forms.Label
    Friend WithEvents LblDutOut As System.Windows.Forms.Label
    Friend WithEvents BtnDutClose As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents CmbDutBaud As System.Windows.Forms.ComboBox
    Friend WithEvents LblDutPort As System.Windows.Forms.Label
    Friend WithEvents LblCbPort As System.Windows.Forms.Label
    Friend WithEvents CmbCbPort As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCbOpen As System.Windows.Forms.Button
    Friend WithEvents BtnCbClose As System.Windows.Forms.Button
    Friend WithEvents LblCbIn As System.Windows.Forms.Label
    Friend WithEvents RtbCbIn As System.Windows.Forms.RichTextBox
    Friend WithEvents BtnCbIn As System.Windows.Forms.Button
    Friend WithEvents LblCbOut As System.Windows.Forms.Label
    Friend WithEvents RtbCbOut As System.Windows.Forms.RichTextBox
    Friend WithEvents CmbCbBaud As System.Windows.Forms.ComboBox
    Friend WithEvents SerialPort2 As System.IO.Ports.SerialPort

End Class
