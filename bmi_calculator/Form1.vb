Public Class Form1

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click

        Dim height As Double
        Dim weight As Double
        Dim bmi As Double
        Dim classification As String

        'check if height is number
        If Not Double.TryParse(TextBoxHeight.Text, height) Then
            MessageBox.Show("Height must be a valid number.",
                            "Invalid Input",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Exit Sub
        End If

        'check if weight is number
        If Not Double.TryParse(TextBoxWeight.Text, weight) Then
            MessageBox.Show("Weight must be a valid number.",
                            "Invalid Input",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Exit Sub
        End If

        'compute bmi
        bmi = weight / (height * height)

        'category
        If bmi < 18.5 Then
            classification = "Underweight"
        ElseIf bmi < 25 Then
            classification = "Normal"
        ElseIf bmi < 30 Then
            classification = "Overweight"
        Else
            classification = "Obese"
        End If

        'result
        LblResult.Text = "BMI: " & bmi.ToString("0.00") &
                         vbCrLf &
                         "Category: " & classification
        TextBoxHeight.Clear()
        TextBoxWeight.Clear()
    End Sub

End Class