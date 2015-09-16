Imports System.Text
Imports System.Text.Encoding
Imports System.IO
Imports System.IO.Ports

Public Class MainForm

    Public WithEvents mySerialPort As New SerialPort 'Δηλωση μεταβλητης mySerialPort σαν μια νεα Σειριακη Κλαση
    Dim SerialMessage As String 'Δηλωση μεταβλητης SerialMessage σαν Αλφαριθμητικο

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If mySerialPort.IsOpen = True Then 'Ελεγχος αν ειναι ανοιχτη η σειριακη θυρα
                mySerialPort.Close() 'Κλεισιμο σειριακης θυρας
            End If

            COMPortComboBox.Items.Clear() 'Καθαρισμος της Λιστας

            'Σκαναρισμα σειριακης θυρας και προσθηκη ονοματος στο ListBox
            For i As Integer = 0 To My.Computer.Ports.SerialPortNames.Count - 1
                COMPortComboBox.Items.Add(My.Computer.Ports.SerialPortNames(i))
            Next

            'Ελεγχος αν δεν υπαρχουν καθολου σειριακες θυρες και απενεργοποιηση των Groups & Buttons
            If COMPortComboBox.Items.Count = 0 Then
                ConnectButton.Enabled = False
                DisconnectButton.Enabled = False
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                GroupBox3.Enabled = False
                GroupBox4.Enabled = False
            Else
                ConnectButton.Enabled = True
                DisconnectButton.Enabled = False
                GroupBox1.Enabled = True
                GroupBox2.Enabled = True
                GroupBox3.Enabled = True
                GroupBox4.Enabled = True
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Serial Port") 'Εμφανιση μηνυματος σε περιπτωση λαθους
        End Try
    End Sub

    Private Sub ScanCOMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScanCOMToolStripMenuItem.Click
        Try
            ToolStatusLbl.Text = "Scanning Serial Port" 'Εμφανιση μηνυματος κατω στο Status

            'Ελεγχος αν ειναι ανοιχτη η σειριακη θυρα
            If mySerialPort.IsOpen = True Then
                mySerialPort.Close() 'Κλεισιμο σειριακης θυρας
            End If

            COMPortComboBox.Items.Clear() 'Καθαρισμος της Λιστας

            'Σκαναρισμα σειριακης θυρας και προσθηκη ονοματος στο ListBox
            For i As Integer = 0 To My.Computer.Ports.SerialPortNames.Count - 1
                COMPortComboBox.Items.Add(My.Computer.Ports.SerialPortNames(i))
            Next

            'Ελεγχος αν δεν υπαρχουν καθολου σειριακες θυρες και απενεργοποιηση ή ενεργοποιηση των Groups & Buttons
            If COMPortComboBox.Items.Count = 0 Then
                ConnectButton.Enabled = False
                DisconnectButton.Enabled = False
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                GroupBox3.Enabled = False
                GroupBox4.Enabled = False
            Else
                ConnectButton.Enabled = True
                DisconnectButton.Enabled = False
                GroupBox1.Enabled = True
                GroupBox2.Enabled = True
                GroupBox3.Enabled = True
                GroupBox4.Enabled = True
            End If

            MsgBox("Scan Complete", MsgBoxStyle.Information, "Serial Port") 'Εμφανιση μηνυματος οτι Ολοκληροθηκε το Scan

            ToolStatusLbl.Text = "Disconnected!" 'Εμφανιση μηνυματος κατω στο Status

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Serial Port") 'Εμφανιση μηνυματος σε περιπτωση λαθους
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Try
            mySerialPort.Close() 'Κλεισιμο της σειριακης θυρας
            End 'Τερματισμος Προγραμματος
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Serial Port - Terminate") 'Εμφανιση μηνυματος σε περιπτωση λαθους
        End Try
    End Sub

    Private Sub Disconnect_Click(sender As Object, e As EventArgs) Handles DisconnectButton.Click
        Try
            mySerialPort.Close() 'Κλεισιμο της σειριακης θυρας
            DisconnectButton.Enabled = False 'Απενεργοποιηση του κουμπιου Disconnect
            ConnectButton.Enabled = True 'Ενεργοποιηση του κουμπιου Connect
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            GroupBox3.Enabled = True
            GroupBox4.Enabled = True
            COMPortComboBox.Enabled = True
            BaudComboBox.Enabled = True
            DataBitsComboBox.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Serial Port - Disconnect") 'Εμφανιση μηνυματος σε περιπτωση λαθους
        End Try
    End Sub

    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        Dim ParityCheck As String 'Δημιουργεια μεταβλητης ParityCheck σαν Αλφαριθμητικο.
        Dim StopBitCheck As Integer 'Δημιουργεια μεταβλητης StopBitCheck σαν Ακεραιος Αριθμος.

        Try
            If mySerialPort.IsOpen = False Then 'Ελεγχος της σειριακης θυρας αν ειναι ανοιχτη.
                mySerialPort.Close() 'Κλεισιμο της σειριακης θυρας.
            End If

            mySerialPort.PortName = COMPortComboBox.Text 'Επιλογη σειριακης θυρας.
            mySerialPort.BaudRate = BaudComboBox.Text 'Επιλογη ρυθμου μεταδωσις σειριακης θυρας.
            mySerialPort.DataBits = DataBitsComboBox.Text 'Επιλογη StopBit ελεγχου σειριακης θυρας.

            'Ελεγχος για την επιλογη του χρηστη
            If ParityCheckEvenRadioButton.Checked = True Then
                mySerialPort.Parity = Parity.Even 'Επιλογη Parity ως Even
                ParityCheck = "Even"
            ElseIf ParityCheckMarkRadioButton.Checked = True Then
                mySerialPort.Parity = Parity.Mark 'Επιλογη Parity ως Mark
                ParityCheck = "Mark"
            ElseIf ParityCheckNoneRadioButton.Checked = True Then
                mySerialPort.Parity = Parity.None 'Επιλογη Parity ως None
                ParityCheck = "None"
            ElseIf ParityCheckOddRadioButton.Checked = True Then
                mySerialPort.Parity = Parity.Odd 'Επιλογη Parity ως Odd
                ParityCheck = "Odd"
            ElseIf ParityCheckSpaceRadioButton.Checked = True Then
                mySerialPort.Parity = Parity.Space 'Επιλογη Parity ως Space
                ParityCheck = "Space"
            End If

            'Ελεγχος για την επιλογη του χρηστη
            If StopBit0RadioButton.Checked = True Then
                mySerialPort.StopBits = StopBits.None 'Επιλογη Stop Bit ως 0
                StopBitCheck = 0
            ElseIf StopBit1RadioButton.Checked = True Then
                mySerialPort.StopBits = StopBits.One 'Επιλογη Stop Bit ως 1
                StopBitCheck = 1
            ElseIf StopBit1point5RadioButton.Checked = True Then
                mySerialPort.StopBits = StopBits.OnePointFive 'Επιλογη Stop Bit ως 1,5
                StopBitCheck = 1.5
            ElseIf StopBit2RadioButton.Checked = True Then
                mySerialPort.StopBits = StopBits.Two 'Επιλογη Stop Bit ως 2
                StopBitCheck = 2
            End If

            mySerialPort.Encoding = Encoding.GetEncoding(EncodingComboBox.Text) 'Επιλογη κωδικοποιησεις του μηνυματος
            mySerialPort.DtrEnable = True 'Ενεργοποιηση του DtR
            mySerialPort.RtsEnable = True 'Ενεργοποιηση του RtS
            mySerialPort.ReceivedBytesThreshold = 1 '
            mySerialPort.Open() 'Ανοιγμα της σειριακης θυρας

            ToolStatusLbl.Text = "Connected at " + COMPortComboBox.Text 'Ονομασια καταστασης της συνδεσεις στο Status Label

            'Aπενεργοποιηση ή ενεργοποιηση των Groups & Buttons
            ConnectButton.Enabled = False
            DisconnectButton.Enabled = True
            GroupBox1.Enabled = True
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            GroupBox4.Enabled = False
            COMPortComboBox.Enabled = False
            BaudComboBox.Enabled = False
            DataBitsComboBox.Enabled = False

            SamplingTimer.Start() 'Ενεργοποιηση της δειγματοληψιας του αισθητηρα απο το Arduino

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Serial Port - Connect") 'Εμφανιση μηνυματος σε περιπτωση λαθους
        End Try
    End Sub

    Public Delegate Sub myDelegate() 'Δημιουργεια ενος Delegate για να αποφυγουμε το κολημα μεχρι και οταν λαβουμε τα Data μας απο την σειριακη θυρα
    Public Delegate Sub CheckForFireWarnings() 'Δημιουργεια ενος Delegate για να αποφυγουμε το κολημα μεχρι και οταν λαβουμε για High θερμοκρασιες

    Private Sub mySerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles mySerialPort.DataReceived
        RecevedRichTxTBox.Invoke(New myDelegate(AddressOf DisplayReceivedMessage)) 'Εμφανιση μηνυματος οταν λαβουμε data απο την σειριακη θυρα
    End Sub

    Private Sub mySerialPort_ErrorReceived(sender As Object, e As SerialErrorReceivedEventArgs) Handles mySerialPort.ErrorReceived
        MsgBox("Error when received Data from " + COMPortComboBox.Text, MsgBoxStyle.Information, "Serial Port - Error Received") 'Εμφανιση μηνυματος σε περιπτωση λαθους
    End Sub

    Private Sub mySerialPort_PinChanged(sender As Object, e As SerialPinChangedEventArgs) Handles mySerialPort.PinChanged
        MsgBox("The PIN has been Changed", MsgBoxStyle.Information, "Serial Port - Pin Changed") 'Εμφανιση μηνυματος σε περιπτωση λαθους
    End Sub

    Public Sub DisplayReceivedMessage()
        Try
            SerialMessage = mySerialPort.ReadExisting() 'Αποθηκευση των data απο την σειριακη θυρα στην μεταβλητη μας
            RecevedRichTxTBox.AppendText(SerialMessage) 'Εμφανιση των data μας απο την μεταβλητη μας στο RichTextBox
            RecevedRichTxTBox.ScrollToCaret() 'Εμφανιση των νεων στοιχειων παντα (refresh)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Serial Port - Display Message") 'Εμφανιση μηνυματος σε περιπτωση λαθους
        End Try
    End Sub

    Private Sub SamplingTimer_Tick(sender As Object, e As EventArgs) Handles SamplingTimer.Tick
        Try
            'Ελεγχος αν ειναι ανοιχτη η σειριακη μας και απενεργοποιηση της δειγματοληψιας
            If mySerialPort.IsOpen = False Then
                SamplingTimer.Stop()
                MsgBox("The tempeture sampling stop because the Serial Port is Closed!", MsgBoxStyle.Information, "Sampling Check")
            Else
                Dim RunCheck As New CheckForFireWarnings(AddressOf FireWarningSub) 'Δημιουργεια μεταβλητης για ενα Delegate

                RunCheck.Invoke() 'Εκτελεση του Delegate μας
                mySerialPort.Write(1) 'Στελνουμε το triger απο την μερια της Visual Basic!
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Serial Port - Sampling Error") 'Εμφανιση μηνυματος σε περιπτωση λαθους
        End Try
    End Sub

    Private Sub Send1Button_Click(sender As Object, e As EventArgs) Handles Send1Button.Click
        Try
            mySerialPort.Write(1) 'Στελνουμε το triger απο την μερια της Visual Basic! (Χειροκηνιτα Εδω)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Serial Port - Send 1") 'Εμφανιση μηνυματος σε περιπτωση λαθους
        End Try
    End Sub

    Private Sub Send0Button_Click(sender As Object, e As EventArgs) Handles Send0Button.Click
        Try
            mySerialPort.Write(0) 'Στελνουμε το triger απο την μερια της Visual Basic! (Χειροκηνιτα Εδω)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Serial Port - Send 0") 'Εμφανιση μηνυματος σε περιπτωση λαθους
        End Try
    End Sub

    Private Function FireWaringFunction(S1 As String, S2 As String) As Boolean
        If S1.Contains(S2) Then 'Ελεγχος αν υπαρχει μια φραση μεσα στο μηνυμα που περνουμε απο την σειριακη μας 
            Return True 'Επιστροφη αληθεις
        Else
            Return False 'Επιστροφη ψευδους
        End If
    End Function

    Private Sub FireWarningSub()
        Dim FireCheck As String = mySerialPort.ReadExisting() 'Δημιουργεια μεταβλητης για το διαβασμα της σειριακης μας

        If FireWaringFunction(FireCheck, "High") = True Then 'Ελεγχος του μηνυματος απο την σειριακης μας και συγκριση με μια λεξη
            If Application.OpenForms.ToString.Contains("FireWarningPanel") = True Then 'Ελεγχος αν ειναι ηδη εμφανισμενο το πανελ

            Else
                FireWarningPanel.Text = "It's just a fire" 'Ονομασια τιτλου ενος πανελ
                FireWarningPanel.Show() 'Εμφανιση του πανελ
            End If
        End If
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Try
            Application.Restart() 'Επανακινηση του Προγραμματος
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Restart Manager")
        End Try
    End Sub
End Class
