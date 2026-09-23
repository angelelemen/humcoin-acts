<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Panel1 = New Panel()
        chkBoxConfirm = New CheckBox()
        btnPlaceOrder = New Button()
        txtBoxColor = New TextBox()
        txtBoxPrice = New TextBox()
        txtBoxSize = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        rbRed = New RadioButton()
        rbBlue = New RadioButton()
        rbYellow = New RadioButton()
        GroupBox1 = New GroupBox()
        rbXL = New RadioButton()
        rbLarge = New RadioButton()
        rbMedium = New RadioButton()
        rbSmall = New RadioButton()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(chkBoxConfirm)
        Panel1.Controls.Add(btnPlaceOrder)
        Panel1.Controls.Add(txtBoxColor)
        Panel1.Controls.Add(txtBoxPrice)
        Panel1.Controls.Add(txtBoxSize)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(80, 32)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(708, 551)
        Panel1.TabIndex = 0
        ' 
        ' chkBoxConfirm
        ' 
        chkBoxConfirm.AutoSize = True
        chkBoxConfirm.Location = New Point(329, 453)
        chkBoxConfirm.Name = "chkBoxConfirm"
        chkBoxConfirm.Size = New Size(73, 24)
        chkBoxConfirm.TabIndex = 9
        chkBoxConfirm.Text = "Confirm"
        chkBoxConfirm.UseVisualStyleBackColor = True
        ' 
        ' btnPlaceOrder
        ' 
        btnPlaceOrder.Location = New Point(296, 483)
        btnPlaceOrder.Name = "btnPlaceOrder"
        btnPlaceOrder.Size = New Size(143, 52)
        btnPlaceOrder.TabIndex = 8
        btnPlaceOrder.Text = "Place Order"
        btnPlaceOrder.UseVisualStyleBackColor = True
        ' 
        ' txtBoxColor
        ' 
        txtBoxColor.Location = New Point(272, 355)
        txtBoxColor.Name = "txtBoxColor"
        txtBoxColor.Size = New Size(198, 26)
        txtBoxColor.TabIndex = 7
        ' 
        ' txtBoxPrice
        ' 
        txtBoxPrice.Location = New Point(272, 403)
        txtBoxPrice.Name = "txtBoxPrice"
        txtBoxPrice.Size = New Size(198, 26)
        txtBoxPrice.TabIndex = 6
        ' 
        ' txtBoxSize
        ' 
        txtBoxSize.Location = New Point(272, 308)
        txtBoxSize.Name = "txtBoxSize"
        txtBoxSize.Size = New Size(198, 26)
        txtBoxSize.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(182, 409)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 20)
        Label3.TabIndex = 4
        Label3.Text = "PRICE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(182, 361)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 3
        Label2.Text = "COLOR"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(182, 314)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 20)
        Label1.TabIndex = 2
        Label1.Text = "SIZE"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(rbRed)
        GroupBox2.Controls.Add(rbBlue)
        GroupBox2.Controls.Add(rbYellow)
        GroupBox2.Location = New Point(380, 75)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(200, 204)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "COLOR"
        ' 
        ' rbRed
        ' 
        rbRed.AutoSize = True
        rbRed.Location = New Point(43, 44)
        rbRed.Name = "rbRed"
        rbRed.Size = New Size(54, 24)
        rbRed.TabIndex = 4
        rbRed.TabStop = True
        rbRed.Text = "RED"
        rbRed.UseVisualStyleBackColor = True
        ' 
        ' rbBlue
        ' 
        rbBlue.AutoSize = True
        rbBlue.Location = New Point(43, 137)
        rbBlue.Name = "rbBlue"
        rbBlue.Size = New Size(61, 24)
        rbBlue.TabIndex = 6
        rbBlue.TabStop = True
        rbBlue.Text = "BLUE"
        rbBlue.UseVisualStyleBackColor = True
        ' 
        ' rbYellow
        ' 
        rbYellow.AutoSize = True
        rbYellow.Location = New Point(43, 89)
        rbYellow.Name = "rbYellow"
        rbYellow.Size = New Size(81, 24)
        rbYellow.TabIndex = 5
        rbYellow.TabStop = True
        rbYellow.Text = "YELLOW"
        rbYellow.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbXL)
        GroupBox1.Controls.Add(rbLarge)
        GroupBox1.Controls.Add(rbMedium)
        GroupBox1.Controls.Add(rbSmall)
        GroupBox1.Location = New Point(151, 75)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 204)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "SIZE"
        ' 
        ' rbXL
        ' 
        rbXL.AutoSize = True
        rbXL.Location = New Point(48, 158)
        rbXL.Name = "rbXL"
        rbXL.Size = New Size(42, 24)
        rbXL.TabIndex = 3
        rbXL.TabStop = True
        rbXL.Text = "XL"
        rbXL.UseVisualStyleBackColor = True
        ' 
        ' rbLarge
        ' 
        rbLarge.AutoSize = True
        rbLarge.Location = New Point(48, 115)
        rbLarge.Name = "rbLarge"
        rbLarge.Size = New Size(71, 24)
        rbLarge.TabIndex = 2
        rbLarge.TabStop = True
        rbLarge.Text = "LARGE"
        rbLarge.UseVisualStyleBackColor = True
        ' 
        ' rbMedium
        ' 
        rbMedium.AutoSize = True
        rbMedium.Location = New Point(48, 74)
        rbMedium.Name = "rbMedium"
        rbMedium.Size = New Size(79, 24)
        rbMedium.TabIndex = 1
        rbMedium.TabStop = True
        rbMedium.Text = "MEDIUM"
        rbMedium.UseVisualStyleBackColor = True
        ' 
        ' rbSmall
        ' 
        rbSmall.AutoSize = True
        rbSmall.Location = New Point(48, 35)
        rbSmall.Name = "rbSmall"
        rbSmall.Size = New Size(70, 24)
        rbSmall.TabIndex = 0
        rbSmall.TabStop = True
        rbSmall.Text = "SMALL"
        rbSmall.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.CornflowerBlue
        Panel2.Location = New Point(80, 32)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(708, 43)
        Panel2.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(229), CByte(228), CByte(226))
        ClientSize = New Size(938, 595)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtBoxSize As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkBoxConfirm As CheckBox
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents txtBoxColor As TextBox
    Friend WithEvents txtBoxPrice As TextBox
    Friend WithEvents rbSmall As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents rbRed As RadioButton
    Friend WithEvents rbBlue As RadioButton
    Friend WithEvents rbYellow As RadioButton
    Friend WithEvents rbXL As RadioButton
    Friend WithEvents rbLarge As RadioButton
    Friend WithEvents rbMedium As RadioButton

End Class
