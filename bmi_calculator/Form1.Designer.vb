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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBoxHeight = New TextBox()
        TextBoxWeight = New TextBox()
        Label4 = New Label()
        LblResult = New Label()
        BtnCalculate = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(191, 136)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 50)
        Label1.TabIndex = 0
        Label1.Text = "BMI Calculator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(243, 237)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 28)
        Label2.TabIndex = 1
        Label2.Text = "Height"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(243, 313)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 28)
        Label3.TabIndex = 2
        Label3.Text = "Weight"
        ' 
        ' TextBoxHeight
        ' 
        TextBoxHeight.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxHeight.Location = New Point(369, 231)
        TextBoxHeight.Name = "TextBoxHeight"
        TextBoxHeight.Size = New Size(212, 34)
        TextBoxHeight.TabIndex = 3
        TextBoxHeight.TextAlign = HorizontalAlignment.Right
        ' 
        ' TextBoxWeight
        ' 
        TextBoxWeight.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxWeight.Location = New Point(369, 307)
        TextBoxWeight.Name = "TextBoxWeight"
        TextBoxWeight.Size = New Size(212, 34)
        TextBoxWeight.TabIndex = 4
        TextBoxWeight.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(650, 158)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 28)
        Label4.TabIndex = 5
        Label4.Text = "Result"
        ' 
        ' LblResult
        ' 
        LblResult.AutoSize = True
        LblResult.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblResult.Location = New Point(650, 231)
        LblResult.Name = "LblResult"
        LblResult.Size = New Size(24, 28)
        LblResult.TabIndex = 6
        LblResult.Text = "..."
        ' 
        ' BtnCalculate
        ' 
        BtnCalculate.BackColor = Color.MediumAquamarine
        BtnCalculate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnCalculate.Location = New Point(386, 383)
        BtnCalculate.Name = "BtnCalculate"
        BtnCalculate.Size = New Size(173, 64)
        BtnCalculate.TabIndex = 7
        BtnCalculate.Text = "Calculate"
        BtnCalculate.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(553, 315)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 23)
        Label5.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(556, 239)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 23)
        Label6.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(526, 205)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 23)
        Label7.TabIndex = 10
        Label7.Text = "meter"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(505, 281)
        Label8.Name = "Label8"
        Label8.Size = New Size(76, 23)
        Label8.TabIndex = 11
        Label8.Text = "kilogram"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1054, 680)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(BtnCalculate)
        Controls.Add(LblResult)
        Controls.Add(Label4)
        Controls.Add(TextBoxWeight)
        Controls.Add(TextBoxHeight)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxHeight As TextBox
    Friend WithEvents TextBoxWeight As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LblResult As Label
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label

End Class
