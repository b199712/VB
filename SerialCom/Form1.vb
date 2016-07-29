Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Imports System.Text

Public Class Form1
    '------------------------------------------------
    Dim myPort As Array
    Delegate Sub SetTextCallback(ByVal sTemp As String) 'Added to prevent threading errors during receiveing of data
    Private totalLength As Int32 = 0 '-------
    Private Delegate Sub Display(ByVal buffer As Integer) '-------
    Private receiving As Boolean '-------
    Dim pass() As Byte '-------
    '------------------------------------------------
    Public Sub toByte(ByVal val As String)
        pass = System.Text.Encoding.Default.GetBytes(val)
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim str As String = String.Join(".", myPort)
        myPort = IO.Ports.SerialPort.GetPortNames()
        CmbDutPort.Items.AddRange(myPort)
        CmbCbPort.Items.AddRange(myPort)
        RtbDutIn.Text = str
        BtnDutIn.Enabled = False
        BtnCbIn.Enabled = False
    End Sub

    Private Sub BtnDutOpen_Click(sender As System.Object, e As System.EventArgs) Handles BtnDutOpen.Click
        SerialPort1.PortName = CmbDutPort.Text
        SerialPort1.BaudRate = CmbDutBaud.Text
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        AddHandler SerialPort1.DataReceived, AddressOf SerialPort1_DataReceived
        If SerialPort1.IsOpen = False Then
            SerialPort1.Open()
            receiving = True
        End If
        toByte("pass")
        BtnDutOpen.Enabled = False
        BtnDutIn.Enabled = True
        BtnDutClose.Enabled = True
    End Sub

    Private Sub BtnDutIn_Click(sender As System.Object, e As System.EventArgs) Handles BtnDutIn.Click
        SerialPort1.Write(RtbDutIn.Text & vbCr) 'concatenate with \n
    End Sub

    Private Sub BtnDutClose_Click(sender As System.Object, e As System.EventArgs) Handles BtnDutClose.Click
        SerialPort1.Close()
        BtnDutOpen.Enabled = True
        BtnDutIn.Enabled = False
        BtnDutClose.Enabled = False
    End Sub
    Private Sub SerialPort1_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) '-------
        'Dim buffer(1023) As Byte
        'If DirectCast(sender, SerialPort).BytesToRead > 0 Then
        '    Dim length As Int32 = DirectCast(sender, SerialPort).Read(buffer, 0, buffer.Length)
        '    Array.Resize(buffer, length)
        '    Dim d As New Display(AddressOf DisplayText)
        '    Me.Invoke(d, New Object() {buffer})
        'End If
        Dim tempList As New List(Of Byte)
        Dim counter = 0
        While receiving = True
            Dim receivedValue As Byte = SerialPort1.ReadByte()
            If receivedValue = pass(0) Then
                counter = counter + 1
            End If
        End While
        Dim d As New Display(AddressOf DisplayText)
        Me.Invoke(d, counter)
    End Sub
    'Private Sub SerialPort1_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
    '    ReceivedDutText(SerialPort1.ReadExisting())
    'End Sub

    'Private Sub ReceivedDutText(ByVal sTemp As String) 'input from ReadExisting
    '    Dim temp, correct As String
    '    Dim num As Integer
    '    If Me.RtbDutOut.InvokeRequired Then
    '        Dim x As New SetTextCallback(AddressOf ReceivedDutText)
    '        correct = "NULL"
    '        Me.Invoke(x, New Object() {(sTemp)})
    '    Else
    '        'If Mid(sTemp, 1, 5) = "*****" Then
    '        '    sTemp &= vbCr
    '        '    Call MsgBox("pppp")
    '        '    Me.RtbDutOut.Text &= sTemp
    '        'End If

    '        'temp = sTemp.ToString
    '        'num = InStr(sTemp, "sqa")
    '        'Me.RtbDutOut.Text &= num & vbCr
    '        'If num > 0 Then
    '        '    Me.RtbDutOut.Text = num & vbCr
    '        '    correct = Mid(temp, num, num + 2)
    '        '    Me.RtbDutOut.Text &= correct & vbCr & Len(correct) & vbCr
    '        'End If


    '        'Me.RtbDutOut.Text &= sTemp & vbCr & sTemp.Length & vbCr
    '    End If String.Format("{0}{1}", BitConverter.ToString(buffer), Environment.NewLine)
    'End Sub
    Private Sub DisplayText(ByVal buffer As Integer) '-------
        'RtbDutOut.Text &= BitConverter.ToString(buffer)
        RtbDutOut.Text = buffer
    End Sub
    Private Sub BtnCbOpen_Click(sender As Object, e As EventArgs) Handles BtnCbOpen.Click
        SerialPort2.PortName = CmbCbPort.Text
        SerialPort2.BaudRate = CmbCbBaud.Text
        SerialPort2.Open()
        BtnCbOpen.Enabled = False
        BtnCbIn.Enabled = True
        BtnCbClose.Enabled = True
    End Sub

    Private Sub BtnCbClose_Click(sender As Object, e As EventArgs) Handles BtnCbClose.Click
        SerialPort2.Close()
        BtnCbOpen.Enabled = True
        BtnCbIn.Enabled = False
        BtnCbClose.Enabled = False
    End Sub

    Private Sub SerialPort2_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort2.DataReceived
        ReceivedCbText(SerialPort2.ReadExisting())
    End Sub

    Private Sub ReceivedCbText(ByVal [text] As String) 'input from ReadExisting
        If Me.RtbCbOut.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedCbText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.RtbCbOut.Text &= [text] 'append text
        End If
    End Sub

    Private Sub BtnCbIn_Click(sender As Object, e As EventArgs) Handles BtnCbIn.Click
        SerialPort2.Write(RtbCbIn.Text & vbCr) 'concatenate with \n
    End Sub

End Class
