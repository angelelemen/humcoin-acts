Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbSmall.Checked = False
        rbMedium.Checked = False
        rbLarge.Checked = False
        rbXL.Checked = False

        rbRed.Checked = False
        rbYellow.Checked = False
        rbBlue.Checked = False

        txtBoxColor.Clear()
        txtBoxPrice.Clear()
        txtBoxSize.Clear()

        chkBoxConfirm.Checked = False
        btnPlaceOrder.Enabled = False
    End Sub

    Private Sub txtBoxSize_TextChanged(sender As Object, e As EventArgs) Handles rbSmall.CheckedChanged, rbMedium.CheckedChanged, rbLarge.CheckedChanged, rbXL.CheckedChanged
        Dim selected As RadioButton = CType(sender, RadioButton)

        If selected.Checked Then
            txtBoxSize.Text = selected.Text
            CalculatePrice()
        End If
    End Sub

    Private Sub txtBoxColor_TextChanged(sender As Object, e As EventArgs) Handles rbRed.CheckedChanged, rbYellow.CheckedChanged, rbBlue.CheckedChanged
        Dim selected As RadioButton = CType(sender, RadioButton)

        If selected.Checked Then
            txtBoxColor.Text = selected.Text

            Select Case selected.Text.ToUpper()
                Case "RED"
                    txtBoxColor.ForeColor = Color.Red
                Case "YELLOW"
                    txtBoxColor.ForeColor = Color.Yellow
                Case "BLUE"
                    txtBoxColor.ForeColor = Color.Blue
            End Select

            CalculatePrice()
        End If
    End Sub

    Private Sub CalculatePrice()
        If rbBlue.Checked Then
            If rbSmall.Checked Then
                txtBoxPrice.Text = "120"
            ElseIf rbMedium.Checked Then
                txtBoxPrice.Text = "140"
            ElseIf rbLarge.Checked Then
                txtBoxPrice.Text = "160"
            ElseIf rbXL.Checked Then
                txtBoxPrice.Text = "180"
            End If
        ElseIf rbYellow.Checked OrElse rbRed.Checked Then
            If rbSmall.Checked Then
                txtBoxPrice.Text = "100"
            ElseIf rbMedium.Checked Then
                txtBoxPrice.Text = "110"
            ElseIf rbLarge.Checked Then
                txtBoxPrice.Text = "120"
            ElseIf rbXL.Checked Then
                txtBoxPrice.Text = "130"
            End If
        End If
    End Sub

    Private Sub chkBoxConfirm_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxConfirm.CheckedChanged
        btnPlaceOrder.Enabled = chkBoxConfirm.Checked
    End Sub
    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        MessageBox.Show("Order Placed", "Order Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub




End Class
