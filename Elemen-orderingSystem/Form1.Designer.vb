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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PanelVanilla = New Panel()
        BtnVanilla = New Button()
        LblPriceVanilla = New Label()
        LblVanilla = New Label()
        PictureBoxVanilla = New PictureBox()
        PanelCnC = New Panel()
        BtnCnC = New Button()
        LblPriceCnC = New Label()
        LblCnC = New Label()
        PictureBoxCnC = New PictureBox()
        PanelChocolate = New Panel()
        BtnChocolate = New Button()
        LblPriceChocolate = New Label()
        LblChocolate = New Label()
        PictureBoxChocolate = New PictureBox()
        PanelStrawberry = New Panel()
        BtnStrawberry = New Button()
        LblPriceStrawberry = New Label()
        LblStrawberry = New Label()
        PictureBoxStrawberry = New PictureBox()
        PanelMatcha = New Panel()
        BtnMatcha = New Button()
        LblPriceMatcha = New Label()
        LblMatcha = New Label()
        PictureBoxMatcha = New PictureBox()
        PanelUbe = New Panel()
        BtnUbe = New Button()
        LblPriceUbe = New Label()
        LblUbe = New Label()
        PictureBoxUbe = New PictureBox()
        Label14 = New Label()
        ListViewOrder = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        LblTotal = New Label()
        Panel7 = New Panel()
        ChkMarshmallow = New CheckBox()
        LblSyrupPrice = New Label()
        LblSprinklesPrice = New Label()
        LblNutsPrice = New Label()
        LblMallowPrice = New Label()
        LblOreoPrice = New Label()
        ChkChocolateSyrup = New CheckBox()
        ChkNuts = New CheckBox()
        ChkSprinkles = New CheckBox()
        ChkOreo = New CheckBox()
        Label23 = New Label()
        Label22 = New Label()
        BtnAddToCart = New Button()
        LblQty = New Label()
        BtnAdd = New Button()
        BtnMinus = New Button()
        LblItemPrice = New Label()
        LblItem = New Label()
        Label16 = New Label()
        FlowLayoutPanel1.SuspendLayout()
        PanelVanilla.SuspendLayout()
        CType(PictureBoxVanilla, ComponentModel.ISupportInitialize).BeginInit()
        PanelCnC.SuspendLayout()
        CType(PictureBoxCnC, ComponentModel.ISupportInitialize).BeginInit()
        PanelChocolate.SuspendLayout()
        CType(PictureBoxChocolate, ComponentModel.ISupportInitialize).BeginInit()
        PanelStrawberry.SuspendLayout()
        CType(PictureBoxStrawberry, ComponentModel.ISupportInitialize).BeginInit()
        PanelMatcha.SuspendLayout()
        CType(PictureBoxMatcha, ComponentModel.ISupportInitialize).BeginInit()
        PanelUbe.SuspendLayout()
        CType(PictureBoxUbe, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(PanelVanilla)
        FlowLayoutPanel1.Controls.Add(PanelCnC)
        FlowLayoutPanel1.Controls.Add(PanelChocolate)
        FlowLayoutPanel1.Controls.Add(PanelStrawberry)
        FlowLayoutPanel1.Controls.Add(PanelMatcha)
        FlowLayoutPanel1.Controls.Add(PanelUbe)
        FlowLayoutPanel1.Location = New Point(2, 101)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(562, 531)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' PanelVanilla
        ' 
        PanelVanilla.Controls.Add(BtnVanilla)
        PanelVanilla.Controls.Add(LblPriceVanilla)
        PanelVanilla.Controls.Add(LblVanilla)
        PanelVanilla.Controls.Add(PictureBoxVanilla)
        PanelVanilla.Location = New Point(3, 3)
        PanelVanilla.Name = "PanelVanilla"
        PanelVanilla.Size = New Size(180, 250)
        PanelVanilla.TabIndex = 2
        ' 
        ' BtnVanilla
        ' 
        BtnVanilla.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnVanilla.Location = New Point(50, 217)
        BtnVanilla.Name = "BtnVanilla"
        BtnVanilla.Size = New Size(80, 30)
        BtnVanilla.TabIndex = 6
        BtnVanilla.Text = "Add"
        BtnVanilla.UseVisualStyleBackColor = True
        ' 
        ' LblPriceVanilla
        ' 
        LblPriceVanilla.AutoSize = True
        LblPriceVanilla.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblPriceVanilla.Location = New Point(50, 188)
        LblPriceVanilla.Name = "LblPriceVanilla"
        LblPriceVanilla.Size = New Size(66, 17)
        LblPriceVanilla.TabIndex = 5
        LblPriceVanilla.Text = "PHP 70.00"
        ' 
        ' LblVanilla
        ' 
        LblVanilla.AutoSize = True
        LblVanilla.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblVanilla.Location = New Point(60, 156)
        LblVanilla.Name = "LblVanilla"
        LblVanilla.Size = New Size(56, 21)
        LblVanilla.TabIndex = 4
        LblVanilla.Text = "Vanilla"
        ' 
        ' PictureBoxVanilla
        ' 
        PictureBoxVanilla.Image = CType(resources.GetObject("PictureBoxVanilla.Image"), Image)
        PictureBoxVanilla.Location = New Point(2, 3)
        PictureBoxVanilla.Name = "PictureBoxVanilla"
        PictureBoxVanilla.Size = New Size(175, 150)
        PictureBoxVanilla.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxVanilla.TabIndex = 3
        PictureBoxVanilla.TabStop = False
        ' 
        ' PanelCnC
        ' 
        PanelCnC.Controls.Add(BtnCnC)
        PanelCnC.Controls.Add(LblPriceCnC)
        PanelCnC.Controls.Add(LblCnC)
        PanelCnC.Controls.Add(PictureBoxCnC)
        PanelCnC.Location = New Point(189, 3)
        PanelCnC.Name = "PanelCnC"
        PanelCnC.Size = New Size(180, 250)
        PanelCnC.TabIndex = 7
        ' 
        ' BtnCnC
        ' 
        BtnCnC.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnCnC.Location = New Point(50, 217)
        BtnCnC.Name = "BtnCnC"
        BtnCnC.Size = New Size(80, 30)
        BtnCnC.TabIndex = 6
        BtnCnC.Text = "Add"
        BtnCnC.UseVisualStyleBackColor = True
        ' 
        ' LblPriceCnC
        ' 
        LblPriceCnC.AutoSize = True
        LblPriceCnC.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblPriceCnC.Location = New Point(50, 188)
        LblPriceCnC.Name = "LblPriceCnC"
        LblPriceCnC.Size = New Size(66, 17)
        LblPriceCnC.TabIndex = 5
        LblPriceCnC.Text = "PHP 85.00"
        ' 
        ' LblCnC
        ' 
        LblCnC.AutoSize = True
        LblCnC.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblCnC.Location = New Point(28, 156)
        LblCnC.Name = "LblCnC"
        LblCnC.Size = New Size(135, 21)
        LblCnC.TabIndex = 4
        LblCnC.Text = "Cookies N' Cream"
        ' 
        ' PictureBoxCnC
        ' 
        PictureBoxCnC.Image = CType(resources.GetObject("PictureBoxCnC.Image"), Image)
        PictureBoxCnC.Location = New Point(2, 3)
        PictureBoxCnC.Name = "PictureBoxCnC"
        PictureBoxCnC.Size = New Size(175, 150)
        PictureBoxCnC.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxCnC.TabIndex = 3
        PictureBoxCnC.TabStop = False
        ' 
        ' PanelChocolate
        ' 
        PanelChocolate.Controls.Add(BtnChocolate)
        PanelChocolate.Controls.Add(LblPriceChocolate)
        PanelChocolate.Controls.Add(LblChocolate)
        PanelChocolate.Controls.Add(PictureBoxChocolate)
        PanelChocolate.Location = New Point(375, 3)
        PanelChocolate.Name = "PanelChocolate"
        PanelChocolate.Size = New Size(180, 250)
        PanelChocolate.TabIndex = 7
        ' 
        ' BtnChocolate
        ' 
        BtnChocolate.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnChocolate.Location = New Point(50, 217)
        BtnChocolate.Name = "BtnChocolate"
        BtnChocolate.Size = New Size(80, 30)
        BtnChocolate.TabIndex = 6
        BtnChocolate.Text = "Add"
        BtnChocolate.UseVisualStyleBackColor = True
        ' 
        ' LblPriceChocolate
        ' 
        LblPriceChocolate.AutoSize = True
        LblPriceChocolate.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblPriceChocolate.Location = New Point(50, 188)
        LblPriceChocolate.Name = "LblPriceChocolate"
        LblPriceChocolate.Size = New Size(66, 17)
        LblPriceChocolate.TabIndex = 5
        LblPriceChocolate.Text = "PHP 70.00"
        ' 
        ' LblChocolate
        ' 
        LblChocolate.AutoSize = True
        LblChocolate.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblChocolate.Location = New Point(51, 156)
        LblChocolate.Name = "LblChocolate"
        LblChocolate.Size = New Size(79, 21)
        LblChocolate.TabIndex = 4
        LblChocolate.Text = "Chocolate"
        ' 
        ' PictureBoxChocolate
        ' 
        PictureBoxChocolate.Image = CType(resources.GetObject("PictureBoxChocolate.Image"), Image)
        PictureBoxChocolate.Location = New Point(2, 3)
        PictureBoxChocolate.Name = "PictureBoxChocolate"
        PictureBoxChocolate.Size = New Size(175, 150)
        PictureBoxChocolate.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxChocolate.TabIndex = 3
        PictureBoxChocolate.TabStop = False
        ' 
        ' PanelStrawberry
        ' 
        PanelStrawberry.Controls.Add(BtnStrawberry)
        PanelStrawberry.Controls.Add(LblPriceStrawberry)
        PanelStrawberry.Controls.Add(LblStrawberry)
        PanelStrawberry.Controls.Add(PictureBoxStrawberry)
        PanelStrawberry.Location = New Point(3, 259)
        PanelStrawberry.Name = "PanelStrawberry"
        PanelStrawberry.Size = New Size(180, 250)
        PanelStrawberry.TabIndex = 7
        ' 
        ' BtnStrawberry
        ' 
        BtnStrawberry.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnStrawberry.Location = New Point(50, 217)
        BtnStrawberry.Name = "BtnStrawberry"
        BtnStrawberry.Size = New Size(80, 30)
        BtnStrawberry.TabIndex = 6
        BtnStrawberry.Text = "Add"
        BtnStrawberry.UseVisualStyleBackColor = True
        ' 
        ' LblPriceStrawberry
        ' 
        LblPriceStrawberry.AutoSize = True
        LblPriceStrawberry.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblPriceStrawberry.Location = New Point(50, 188)
        LblPriceStrawberry.Name = "LblPriceStrawberry"
        LblPriceStrawberry.Size = New Size(66, 17)
        LblPriceStrawberry.TabIndex = 5
        LblPriceStrawberry.Text = "PHP 80.00"
        ' 
        ' LblStrawberry
        ' 
        LblStrawberry.AutoSize = True
        LblStrawberry.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblStrawberry.Location = New Point(44, 156)
        LblStrawberry.Name = "LblStrawberry"
        LblStrawberry.Size = New Size(86, 21)
        LblStrawberry.TabIndex = 4
        LblStrawberry.Text = "Strawberry"
        ' 
        ' PictureBoxStrawberry
        ' 
        PictureBoxStrawberry.Image = CType(resources.GetObject("PictureBoxStrawberry.Image"), Image)
        PictureBoxStrawberry.Location = New Point(2, 3)
        PictureBoxStrawberry.Name = "PictureBoxStrawberry"
        PictureBoxStrawberry.Size = New Size(175, 150)
        PictureBoxStrawberry.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxStrawberry.TabIndex = 3
        PictureBoxStrawberry.TabStop = False
        ' 
        ' PanelMatcha
        ' 
        PanelMatcha.Controls.Add(BtnMatcha)
        PanelMatcha.Controls.Add(LblPriceMatcha)
        PanelMatcha.Controls.Add(LblMatcha)
        PanelMatcha.Controls.Add(PictureBoxMatcha)
        PanelMatcha.Location = New Point(189, 259)
        PanelMatcha.Name = "PanelMatcha"
        PanelMatcha.Size = New Size(180, 250)
        PanelMatcha.TabIndex = 7
        ' 
        ' BtnMatcha
        ' 
        BtnMatcha.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnMatcha.Location = New Point(50, 217)
        BtnMatcha.Name = "BtnMatcha"
        BtnMatcha.Size = New Size(80, 30)
        BtnMatcha.TabIndex = 6
        BtnMatcha.Text = "Add"
        BtnMatcha.UseVisualStyleBackColor = True
        ' 
        ' LblPriceMatcha
        ' 
        LblPriceMatcha.AutoSize = True
        LblPriceMatcha.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblPriceMatcha.Location = New Point(50, 188)
        LblPriceMatcha.Name = "LblPriceMatcha"
        LblPriceMatcha.Size = New Size(73, 17)
        LblPriceMatcha.TabIndex = 5
        LblPriceMatcha.Text = "PHP 100.00"
        ' 
        ' LblMatcha
        ' 
        LblMatcha.AutoSize = True
        LblMatcha.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblMatcha.Location = New Point(60, 156)
        LblMatcha.Name = "LblMatcha"
        LblMatcha.Size = New Size(61, 21)
        LblMatcha.TabIndex = 4
        LblMatcha.Text = "Matcha"
        ' 
        ' PictureBoxMatcha
        ' 
        PictureBoxMatcha.Image = CType(resources.GetObject("PictureBoxMatcha.Image"), Image)
        PictureBoxMatcha.Location = New Point(2, 3)
        PictureBoxMatcha.Name = "PictureBoxMatcha"
        PictureBoxMatcha.Size = New Size(175, 150)
        PictureBoxMatcha.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxMatcha.TabIndex = 3
        PictureBoxMatcha.TabStop = False
        ' 
        ' PanelUbe
        ' 
        PanelUbe.Controls.Add(BtnUbe)
        PanelUbe.Controls.Add(LblPriceUbe)
        PanelUbe.Controls.Add(LblUbe)
        PanelUbe.Controls.Add(PictureBoxUbe)
        PanelUbe.Location = New Point(375, 259)
        PanelUbe.Name = "PanelUbe"
        PanelUbe.Size = New Size(180, 250)
        PanelUbe.TabIndex = 7
        ' 
        ' BtnUbe
        ' 
        BtnUbe.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnUbe.Location = New Point(50, 217)
        BtnUbe.Name = "BtnUbe"
        BtnUbe.Size = New Size(80, 30)
        BtnUbe.TabIndex = 6
        BtnUbe.Text = "Add"
        BtnUbe.UseVisualStyleBackColor = True
        ' 
        ' LblPriceUbe
        ' 
        LblPriceUbe.AutoSize = True
        LblPriceUbe.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblPriceUbe.Location = New Point(50, 188)
        LblPriceUbe.Name = "LblPriceUbe"
        LblPriceUbe.Size = New Size(66, 17)
        LblPriceUbe.TabIndex = 5
        LblPriceUbe.Text = "PHP 70.00"
        ' 
        ' LblUbe
        ' 
        LblUbe.AutoSize = True
        LblUbe.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblUbe.Location = New Point(60, 156)
        LblUbe.Name = "LblUbe"
        LblUbe.Size = New Size(38, 21)
        LblUbe.TabIndex = 4
        LblUbe.Text = "Ube"
        ' 
        ' PictureBoxUbe
        ' 
        PictureBoxUbe.Image = CType(resources.GetObject("PictureBoxUbe.Image"), Image)
        PictureBoxUbe.Location = New Point(2, 3)
        PictureBoxUbe.Name = "PictureBoxUbe"
        PictureBoxUbe.Size = New Size(175, 150)
        PictureBoxUbe.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxUbe.TabIndex = 3
        PictureBoxUbe.TabStop = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(581, 101)
        Label14.Name = "Label14"
        Label14.Size = New Size(124, 25)
        Label14.TabIndex = 2
        Label14.Text = "YOUR ORDER"
        ' 
        ' ListViewOrder
        ' 
        ListViewOrder.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4})
        ListViewOrder.FullRowSelect = True
        ListViewOrder.GridLines = True
        ListViewOrder.Location = New Point(573, 134)
        ListViewOrder.Name = "ListViewOrder"
        ListViewOrder.Size = New Size(462, 158)
        ListViewOrder.TabIndex = 3
        ListViewOrder.UseCompatibleStateImageBehavior = False
        ListViewOrder.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Flavor"
        ColumnHeader1.Width = 150
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Toppings"
        ColumnHeader2.Width = 150
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Qty"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Price"
        ColumnHeader4.Width = 100
        ' 
        ' LblTotal
        ' 
        LblTotal.AutoSize = True
        LblTotal.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTotal.Location = New Point(581, 310)
        LblTotal.Name = "LblTotal"
        LblTotal.Size = New Size(56, 25)
        LblTotal.TabIndex = 4
        LblTotal.Text = "Total:"
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(ChkMarshmallow)
        Panel7.Controls.Add(LblSyrupPrice)
        Panel7.Controls.Add(LblSprinklesPrice)
        Panel7.Controls.Add(LblNutsPrice)
        Panel7.Controls.Add(LblMallowPrice)
        Panel7.Controls.Add(LblOreoPrice)
        Panel7.Controls.Add(ChkChocolateSyrup)
        Panel7.Controls.Add(ChkNuts)
        Panel7.Controls.Add(ChkSprinkles)
        Panel7.Controls.Add(ChkOreo)
        Panel7.Controls.Add(Label23)
        Panel7.Controls.Add(Label22)
        Panel7.Controls.Add(BtnAddToCart)
        Panel7.Controls.Add(LblQty)
        Panel7.Controls.Add(BtnAdd)
        Panel7.Controls.Add(BtnMinus)
        Panel7.Controls.Add(LblItemPrice)
        Panel7.Controls.Add(LblItem)
        Panel7.Controls.Add(Label16)
        Panel7.Location = New Point(573, 359)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(462, 273)
        Panel7.TabIndex = 5
        ' 
        ' ChkMarshmallow
        ' 
        ChkMarshmallow.AutoSize = True
        ChkMarshmallow.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ChkMarshmallow.Location = New Point(167, 114)
        ChkMarshmallow.Margin = New Padding(3, 2, 3, 2)
        ChkMarshmallow.Name = "ChkMarshmallow"
        ChkMarshmallow.Size = New Size(110, 23)
        ChkMarshmallow.TabIndex = 35
        ChkMarshmallow.Text = "Marshmallow"
        ChkMarshmallow.UseVisualStyleBackColor = True
        ' 
        ' LblSyrupPrice
        ' 
        LblSyrupPrice.AutoSize = True
        LblSyrupPrice.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSyrupPrice.Location = New Point(355, 192)
        LblSyrupPrice.Name = "LblSyrupPrice"
        LblSyrupPrice.Size = New Size(84, 17)
        LblSyrupPrice.TabIndex = 34
        LblSyrupPrice.Text = "+PHP 15.00"
        ' 
        ' LblSprinklesPrice
        ' 
        LblSprinklesPrice.AutoSize = True
        LblSprinklesPrice.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSprinklesPrice.Location = New Point(355, 142)
        LblSprinklesPrice.Name = "LblSprinklesPrice"
        LblSprinklesPrice.Size = New Size(84, 17)
        LblSprinklesPrice.TabIndex = 33
        LblSprinklesPrice.Text = "+PHP 15.00"
        ' 
        ' LblNutsPrice
        ' 
        LblNutsPrice.AutoSize = True
        LblNutsPrice.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblNutsPrice.Location = New Point(355, 167)
        LblNutsPrice.Name = "LblNutsPrice"
        LblNutsPrice.Size = New Size(84, 17)
        LblNutsPrice.TabIndex = 32
        LblNutsPrice.Text = "+PHP 20.00"
        ' 
        ' LblMallowPrice
        ' 
        LblMallowPrice.AutoSize = True
        LblMallowPrice.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblMallowPrice.Location = New Point(355, 117)
        LblMallowPrice.Name = "LblMallowPrice"
        LblMallowPrice.Size = New Size(84, 17)
        LblMallowPrice.TabIndex = 31
        LblMallowPrice.Text = "+PHP 15.00"
        ' 
        ' LblOreoPrice
        ' 
        LblOreoPrice.AutoSize = True
        LblOreoPrice.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblOreoPrice.Location = New Point(355, 92)
        LblOreoPrice.Name = "LblOreoPrice"
        LblOreoPrice.Size = New Size(84, 17)
        LblOreoPrice.TabIndex = 30
        LblOreoPrice.Text = "+PHP 20.00"
        ' 
        ' ChkChocolateSyrup
        ' 
        ChkChocolateSyrup.AutoSize = True
        ChkChocolateSyrup.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ChkChocolateSyrup.Location = New Point(167, 189)
        ChkChocolateSyrup.Margin = New Padding(3, 2, 3, 2)
        ChkChocolateSyrup.Name = "ChkChocolateSyrup"
        ChkChocolateSyrup.Size = New Size(128, 23)
        ChkChocolateSyrup.TabIndex = 29
        ChkChocolateSyrup.Text = "Chocolate Syrup"
        ChkChocolateSyrup.UseVisualStyleBackColor = True
        ' 
        ' ChkNuts
        ' 
        ChkNuts.AutoSize = True
        ChkNuts.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ChkNuts.Location = New Point(167, 164)
        ChkNuts.Margin = New Padding(3, 2, 3, 2)
        ChkNuts.Name = "ChkNuts"
        ChkNuts.Size = New Size(57, 23)
        ChkNuts.TabIndex = 28
        ChkNuts.Text = "Nuts"
        ChkNuts.UseVisualStyleBackColor = True
        ' 
        ' ChkSprinkles
        ' 
        ChkSprinkles.AutoSize = True
        ChkSprinkles.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ChkSprinkles.Location = New Point(167, 140)
        ChkSprinkles.Margin = New Padding(3, 2, 3, 2)
        ChkSprinkles.Name = "ChkSprinkles"
        ChkSprinkles.Size = New Size(82, 23)
        ChkSprinkles.TabIndex = 27
        ChkSprinkles.Text = "Sprinkles"
        ChkSprinkles.UseVisualStyleBackColor = True
        ' 
        ' ChkOreo
        ' 
        ChkOreo.AutoSize = True
        ChkOreo.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ChkOreo.Location = New Point(167, 90)
        ChkOreo.Margin = New Padding(3, 2, 3, 2)
        ChkOreo.Name = "ChkOreo"
        ChkOreo.Size = New Size(59, 23)
        ChkOreo.TabIndex = 26
        ChkOreo.Text = "Oreo"
        ChkOreo.UseVisualStyleBackColor = True
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(355, 61)
        Label23.Name = "Label23"
        Label23.Size = New Size(70, 19)
        Label23.TabIndex = 25
        Label23.Text = "(Optional)"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(167, 61)
        Label22.Name = "Label22"
        Label22.Size = New Size(163, 20)
        Label22.TabIndex = 24
        Label22.Text = "CHOOSE TOPPINGS"
        ' 
        ' BtnAddToCart
        ' 
        BtnAddToCart.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnAddToCart.Location = New Point(24, 181)
        BtnAddToCart.Margin = New Padding(3, 2, 3, 2)
        BtnAddToCart.Name = "BtnAddToCart"
        BtnAddToCart.Size = New Size(104, 34)
        BtnAddToCart.TabIndex = 17
        BtnAddToCart.Text = "Add To Cart"
        BtnAddToCart.UseVisualStyleBackColor = True
        ' 
        ' LblQty
        ' 
        LblQty.AutoSize = True
        LblQty.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblQty.Location = New Point(67, 139)
        LblQty.Name = "LblQty"
        LblQty.Size = New Size(16, 17)
        LblQty.TabIndex = 20
        LblQty.Text = "0"
        ' 
        ' BtnAdd
        ' 
        BtnAdd.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnAdd.Location = New Point(94, 131)
        BtnAdd.Margin = New Padding(3, 2, 3, 2)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(35, 30)
        BtnAdd.TabIndex = 19
        BtnAdd.Text = "+"
        BtnAdd.UseVisualStyleBackColor = True
        ' 
        ' BtnMinus
        ' 
        BtnMinus.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnMinus.Location = New Point(24, 131)
        BtnMinus.Margin = New Padding(3, 2, 3, 2)
        BtnMinus.Name = "BtnMinus"
        BtnMinus.Size = New Size(35, 30)
        BtnMinus.TabIndex = 18
        BtnMinus.Text = "−"
        BtnMinus.UseVisualStyleBackColor = True
        ' 
        ' LblItemPrice
        ' 
        LblItemPrice.AutoSize = True
        LblItemPrice.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblItemPrice.Location = New Point(27, 91)
        LblItemPrice.Name = "LblItemPrice"
        LblItemPrice.Size = New Size(73, 17)
        LblItemPrice.TabIndex = 7
        LblItemPrice.Text = "PHP 100.00"
        ' 
        ' LblItem
        ' 
        LblItem.AutoSize = True
        LblItem.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblItem.Location = New Point(27, 59)
        LblItem.Name = "LblItem"
        LblItem.Size = New Size(56, 21)
        LblItem.TabIndex = 7
        LblItem.Text = "Vanilla"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(8, 16)
        Label16.Name = "Label16"
        Label16.Size = New Size(127, 25)
        Label16.TabIndex = 6
        Label16.Text = "ITEM DETAILS"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1073, 680)
        Controls.Add(Panel7)
        Controls.Add(LblTotal)
        Controls.Add(ListViewOrder)
        Controls.Add(Label14)
        Controls.Add(FlowLayoutPanel1)
        Name = "Form1"
        Text = "Form1"
        FlowLayoutPanel1.ResumeLayout(False)
        PanelVanilla.ResumeLayout(False)
        PanelVanilla.PerformLayout()
        CType(PictureBoxVanilla, ComponentModel.ISupportInitialize).EndInit()
        PanelCnC.ResumeLayout(False)
        PanelCnC.PerformLayout()
        CType(PictureBoxCnC, ComponentModel.ISupportInitialize).EndInit()
        PanelChocolate.ResumeLayout(False)
        PanelChocolate.PerformLayout()
        CType(PictureBoxChocolate, ComponentModel.ISupportInitialize).EndInit()
        PanelStrawberry.ResumeLayout(False)
        PanelStrawberry.PerformLayout()
        CType(PictureBoxStrawberry, ComponentModel.ISupportInitialize).EndInit()
        PanelMatcha.ResumeLayout(False)
        PanelMatcha.PerformLayout()
        CType(PictureBoxMatcha, ComponentModel.ISupportInitialize).EndInit()
        PanelUbe.ResumeLayout(False)
        PanelUbe.PerformLayout()
        CType(PictureBoxUbe, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PanelVanilla As Panel
    Friend WithEvents PictureBoxVanilla As PictureBox
    Friend WithEvents BtnVanilla As Button
    Friend WithEvents LblPriceVanilla As Label
    Friend WithEvents LblVanilla As Label
    Friend WithEvents PanelCnC As Panel
    Friend WithEvents BtnCnC As Button
    Friend WithEvents LblPriceCnC As Label
    Friend WithEvents LblCnC As Label
    Friend WithEvents PictureBoxCnC As PictureBox
    Friend WithEvents PanelChocolate As Panel
    Friend WithEvents BtnChocolate As Button
    Friend WithEvents LblPriceChocolate As Label
    Friend WithEvents LblChocolate As Label
    Friend WithEvents PictureBoxChocolate As PictureBox
    Friend WithEvents PanelStrawberry As Panel
    Friend WithEvents BtnStrawberry As Button
    Friend WithEvents LblPriceStrawberry As Label
    Friend WithEvents LblStrawberry As Label
    Friend WithEvents PictureBoxStrawberry As PictureBox
    Friend WithEvents PanelMatcha As Panel
    Friend WithEvents BtnMatcha As Button
    Friend WithEvents LblPriceMatcha As Label
    Friend WithEvents LblMatcha As Label
    Friend WithEvents PictureBoxMatcha As PictureBox
    Friend WithEvents PanelUbe As Panel
    Friend WithEvents BtnUbe As Button
    Friend WithEvents LblPriceUbe As Label
    Friend WithEvents LblUbe As Label
    Friend WithEvents PictureBoxUbe As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ListViewOrder As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents LblTotal As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents LblItem As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents ChkMarshmallow As CheckBox
    Friend WithEvents LblSyrupPrice As Label
    Friend WithEvents LblSprinklesPrice As Label
    Friend WithEvents LblNutsPrice As Label
    Friend WithEvents LblMallowPrice As Label
    Friend WithEvents LblOreoPrice As Label
    Friend WithEvents ChkChocolateSyrup As CheckBox
    Friend WithEvents ChkNuts As CheckBox
    Friend WithEvents ChkSprinkles As CheckBox
    Friend WithEvents ChkOreo As CheckBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents BtnAddToCart As Button
    Friend WithEvents LblQty As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnMinus As Button
    Friend WithEvents LblItemPrice As Label

End Class
