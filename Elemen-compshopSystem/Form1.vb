Public Class Form1

    Private Const SECONDS_PER_PESO As Integer = 300
    Private pcTimeRemain(3) As Integer

    Private Sub ClearSelectedPC()
        RadioBtnPc01.Checked = False
        RadioBtnPc02.Checked = False
        RadioBtnPc03.Checked = False
        RadioBtnPc04.Checked = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each clm As DataGridViewColumn In DataGridViewLogs.Columns
            clm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            clm.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
        DataGridViewLogs.Columns("ClmPrice").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        If DataGridViewLogs.ColumnCount = 0 Then
            DataGridViewLogs.Rows.Add("PC", "PC")
            DataGridViewLogs.Rows.Add("Activity", "ACTIVITY")
            DataGridViewLogs.Rows.Add("Time", "TIME")
            DataGridViewLogs.Rows.Add("Price", "PRICE")
        End If

        ClearSelectedPC()

        TimerMain.Start()
    End Sub

    Private Sub TextBoxAmount_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAmount.TextChanged
        Dim amount As Double

        If Double.TryParse(TextBoxAmount.Text, amount) AndAlso amount > 0 Then
            Dim totalSeconds As Integer = CInt(amount * SECONDS_PER_PESO)
            Dim ts As TimeSpan = TimeSpan.FromSeconds(totalSeconds)

            LblTimeAdded.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", ts.Hours, ts.Minutes, ts.Seconds)
        Else
            LblTimeAdded.Text = "----"
        End If
    End Sub

    Private Sub BtnAddTime_Click(sender As Object, e As EventArgs) Handles BtnAddTime.Click
        Dim amount As Double
        If Not Double.TryParse(TextBoxAmount.Text, amount) OrElse amount <= 0 Then
            MessageBox.Show("Please enter a valid amount", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedPC As Integer = GetSelectedPCIndex()
        If selectedPC = -1 Then
            MessageBox.Show("Please select a PC", "No PC Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim addedSeconds As Integer = CInt(amount * SECONDS_PER_PESO)
        pcTimeRemain(selectedPC) += addedSeconds

        UpdatePCStatusUI(selectedPC, True)

        Dim pcName As String = "0" & (selectedPC + 1)
        Dim calculatedTime As String = LblTimeAdded.Text

        DataGridViewLogs.Rows.Add(pcName, "Added Time", calculatedTime, "₱" & amount.ToString("F2"))

        TextBoxAmount.Clear()
        ClearSelectedPC()
        LblTimeAdded.Text = "----"
    End Sub

    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerMain.Tick
        For i As Integer = 0 To 3
            If pcTimeRemain(i) > 0 Then
                pcTimeRemain(i) -= 1
                UpdateTimerDisplay(i)
                If pcTimeRemain(i) = 0 Then
                    UpdatePCStatusUI(i, False)
                    DataGridViewLogs.Rows.Add("0" & (i + 1), "Time Ended", "----")
                End If
            End If
        Next
    End Sub

    Private Sub BtnStopPc1_Click(sender As Object, e As EventArgs) Handles BtnStopPc1.Click
        StopPCSession(0)
    End Sub

    Private Sub BtnStopPc2_Click(sender As Object, e As EventArgs) Handles BtnStopPc2.Click
        StopPCSession(1)
    End Sub

    Private Sub BtnStopPc3_Click(sender As Object, e As EventArgs) Handles BtnStopPc3.Click
        StopPCSession(2)
    End Sub

    Private Sub BtnStopPc4_Click(sender As Object, e As EventArgs) Handles BtnStopPc4.Click
        StopPCSession(3)
    End Sub

    Private Sub StopPCSession(pcIndex As Integer)
        If pcTimeRemain(pcIndex) > 0 Then
            pcTimeRemain(pcIndex) = 0
            UpdateTimerDisplay(pcIndex)
            UpdatePCStatusUI(pcIndex, False)
            DataGridViewLogs.Rows.Add("0" & (pcIndex + 1), "Time Ended", "----")
        End If
    End Sub

    Private Function GetSelectedPCIndex() As Integer
        If RadioBtnPc01.Checked Then
            Return 0
        ElseIf RadioBtnPc02.Checked Then
            Return 1
        ElseIf RadioBtnPc03.Checked Then
            Return 2
        ElseIf RadioBtnPc04.Checked Then
            Return 3
        Else
            Return -1 ' no PC selected
        End If
    End Function

    Private Sub UpdateTimerDisplay(pcIndex As Integer)
        Dim ts As TimeSpan = TimeSpan.FromSeconds(pcTimeRemain(pcIndex))
        Select Case pcIndex
            Case 0
                LblTimer01.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", ts.Hours, ts.Minutes, ts.Seconds)
            Case 1
                LblTimer02.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", ts.Hours, ts.Minutes, ts.Seconds)
            Case 2
                LblTimer03.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", ts.Hours, ts.Minutes, ts.Seconds)
            Case 3
                LblTimer04.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", ts.Hours, ts.Minutes, ts.Seconds)
        End Select
    End Sub

    Private Sub UpdatePCStatusUI(pcIndex As Integer, isActive As Boolean)
        Dim statusText As String = If(isActive, "● IN USE", "● AVAILABLE")
        Dim statusColor As Color = If(isActive, Color.Red, Color.FromArgb(56, 232, 62))
        Select Case pcIndex
            Case 0
                LblStatusPc1.Text = statusText
                LblStatusPc1.ForeColor = statusColor
                LblStatusPc1.Font = New Font(LblStatusPc1.Font, FontStyle.Bold)
            Case 1
                LblStatusPc2.Text = statusText
                LblStatusPc2.ForeColor = statusColor
                LblStatusPc2.Font = New Font(LblStatusPc2.Font, FontStyle.Bold)
            Case 2
                LblStatusPc3.Text = statusText
                LblStatusPc3.ForeColor = statusColor
                LblStatusPc3.Font = New Font(LblStatusPc3.Font, FontStyle.Bold)
            Case 3
                LblStatusPc4.Text = statusText
                LblStatusPc4.ForeColor = statusColor
                LblStatusPc4.Font = New Font(LblStatusPc4.Font, FontStyle.Bold)
        End Select
    End Sub
End Class
