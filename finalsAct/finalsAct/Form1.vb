Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flowLayoutPanelOrders.AutoScroll = True
        flowLayoutPanelOrders.WrapContents = False
        flowLayoutPanelOrders.FlowDirection = FlowDirection.TopDown
        panelTotal.Visible = False
        btnOrder.Visible = False
        btnCancel.Visible = False
    End Sub

    Private Sub AddItem(itemName As String, itemPrice As Decimal)
        ' check if the item already exists 
        For Each pnl As Panel In flowLayoutPanelOrders.Controls
            Dim lblName As Label = pnl.Controls.OfType(Of Label)().
            FirstOrDefault(Function(l) l.Text = itemName)
            Dim lblQty As Label = pnl.Controls.OfType(Of Label)().
            FirstOrDefault(Function(l) IsNumeric(l.Text))

            If lblName IsNot Nothing AndAlso lblQty IsNot Nothing Then
                'inc the qty if the item already exists
                lblQty.Text = (CInt(lblQty.Text) + 1).ToString()
                UpdateTotal()
                Return
            End If
        Next

        Dim newItem As Panel = CreateOrderItemPanel(itemName, itemPrice)
        flowLayoutPanelOrders.Controls.Add(newItem)
        UpdateTotal()

        If flowLayoutPanelOrders.Controls.Count > 0 Then
            panelTotal.Visible = True
            btnOrder.Visible = True
            btnCancel.Visible = True
        End If
    End Sub

    Private Function CreateOrderItemPanel(itemName As String, itemPrice As Decimal) As Panel

        Dim pnl As New Panel()
        pnl.Size = itemPanel.Size
        pnl.BorderStyle = itemPanel.BorderStyle
        pnl.BackColor = itemPanel.BackColor

        Dim lblName As New Label()
        lblName.Text = itemName
        lblName.Font = New Font("Georgia", 11, FontStyle.Regular)
        lblName.AutoSize = True
        lblName.Location = New Point(10, 15)

        Dim lblPrice As New Label()
        lblPrice.Text = "₱" & itemPrice.ToString("F2")
        lblPrice.Font = New Font("Georgia", 12, FontStyle.Regular)
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(290, 18)

        Dim btnMinus As New Button()
        btnMinus.Text = "-"
        btnMinus.Font = New Font("Georgia", 14, FontStyle.Regular)
        btnMinus.Size = New Size(52, 45)
        btnMinus.Location = New Point(140, 52)

        Dim lblQty As New Label()
        lblQty.Text = "1"
        lblQty.Font = New Font("Arial", 12, FontStyle.Regular)
        lblQty.AutoSize = True
        lblQty.Location = New Point(91, 60)

        Dim btnPlus As New Button()
        btnPlus.Text = "+"
        btnPlus.Font = New Font("Georgia", 14, FontStyle.Bold)
        btnPlus.Size = New Size(52, 45)
        btnPlus.Location = New Point(15, 52)

        Dim btnRemove As New Button()
        btnRemove.Text = "X"
        btnRemove.Size = New Size(32, 33)
        btnRemove.Location = New Point(374, 58)

        pnl.Controls.Add(lblName)
        pnl.Controls.Add(lblPrice)
        pnl.Controls.Add(btnMinus)
        pnl.Controls.Add(lblQty)
        pnl.Controls.Add(btnPlus)
        pnl.Controls.Add(btnRemove)

        AddHandler btnPlus.Click, Sub()
                                      lblQty.Text = (CInt(lblQty.Text) + 1).ToString()
                                      UpdateTotal()
                                  End Sub

        AddHandler btnMinus.Click, Sub()
                                       Dim q As Integer = CInt(lblQty.Text)
                                       If q > 1 Then
                                           lblQty.Text = (q - 1).ToString()
                                           UpdateTotal()
                                       End If
                                   End Sub

        AddHandler btnRemove.Click, Sub()
                                        flowLayoutPanelOrders.Controls.Remove(pnl)
                                        UpdateTotal()
                                    End Sub

        Return pnl
    End Function

    'calculate total
    Private Sub UpdateTotal()
        Dim total As Decimal = 0

        'loop in flp
        For Each pnl As Panel In flowLayoutPanelOrders.Controls
            ' Find the price label (starts with ₱)
            Dim lblPrice As Label = pnl.Controls.OfType(Of Label)().
            FirstOrDefault(Function(l) l.Text.StartsWith("₱"))

            ' Find the quantity label (numeric text)
            Dim lblQty As Label = pnl.Controls.OfType(Of Label)().
            FirstOrDefault(Function(l) IsNumeric(l.Text))

            ' If both exist, add to total
            If lblPrice IsNot Nothing AndAlso lblQty IsNot Nothing Then
                Dim price As Decimal = Decimal.Parse(lblPrice.Text.Replace("₱", ""))
                Dim qty As Integer = Integer.Parse(lblQty.Text)
                total += price * qty
            End If
        Next

        lblTotal.Text = "₱" & total.ToString("F2")
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        If flowLayoutPanelOrders.Controls.Count = 0 Then
            MessageBox.Show("No items in your order.", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'summary of order
        Dim orderSummary As String = "Your order:" & Environment.NewLine
        For Each pnl As Panel In flowLayoutPanelOrders.Controls
            Dim lblName As Label = pnl.Controls.OfType(Of Label)().FirstOrDefault(Function(l) Not l.Text.StartsWith("₱") AndAlso Not IsNumeric(l.Text))
            Dim lblPrice As Label = pnl.Controls.OfType(Of Label)().FirstOrDefault(Function(l) l.Text.StartsWith("₱"))
            Dim lblQty As Label = pnl.Controls.OfType(Of Label)().FirstOrDefault(Function(l) IsNumeric(l.Text))

            If lblName IsNot Nothing AndAlso lblPrice IsNot Nothing AndAlso lblQty IsNot Nothing Then
                orderSummary &= $"{lblName.Text} x{lblQty.Text} | {lblPrice.Text}" & Environment.NewLine
            End If
        Next

        orderSummary &= Environment.NewLine & "Total: " & lblTotal.Text

        MessageBox.Show(orderSummary, "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        flowLayoutPanelOrders.Controls.Clear()
        panelTotal.Visible = False
        btnOrder.Visible = False
        btnCancel.Visible = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'checking
        If flowLayoutPanelOrders.Controls.Count = 0 Then
            MessageBox.Show("No items to cancel.", "Cancel Order", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim result As DialogResult = MessageBox.Show("Cancel the current order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            flowLayoutPanelOrders.Controls.Clear()
            panelTotal.Visible = False
        End If
    End Sub

    Private Sub btnAmericano_Click(sender As Object, e As EventArgs) Handles btnAmericano.Click
        AddItem("Americano", 120D)
    End Sub

    Private Sub btnCafeLatte_Click(sender As Object, e As EventArgs) Handles btnCafeLatte.Click
        AddItem("Cafe Latte", 150D)
    End Sub

    Private Sub btnMocha_Click(sender As Object, e As EventArgs) Handles btnMocha.Click
        AddItem("Mocha", 180D)
    End Sub

    Private Sub btnCaramelMacchiato_Click(sender As Object, e As EventArgs) Handles btnCaramelMacchiato.Click
        AddItem("Caramel Macchiato", 200D)
    End Sub

    Private Sub btnVanillaLatte_Click(sender As Object, e As EventArgs) Handles btnVanillaLatte.Click
        AddItem("Vanilla Latte", 170D)
    End Sub

    Private Sub btnIcedAmericano_Click(sender As Object, e As EventArgs) Handles btnIcedAmericano.Click
        AddItem("Iced Americano", 130D)
    End Sub

    Private Sub btnBrownie_Click(sender As Object, e As EventArgs) Handles btnBrownie.Click
        AddItem("Brownie", 90D)
    End Sub

    Private Sub btnCookie_Click(sender As Object, e As EventArgs) Handles btnCookie.Click
        AddItem("Cookie", 80D)
    End Sub

    Private Sub btnCinnamon_Click(sender As Object, e As EventArgs) Handles btnCinnamon.Click
        AddItem("Cinnamon Roll", 100D)
    End Sub

    Private Sub btnWaffle_Click(sender As Object, e As EventArgs) Handles btnWaffle.Click
        AddItem("Waffle", 110D)
    End Sub

    Private Sub btnCroissant_Click(sender As Object, e As EventArgs) Handles btnCroissant.Click
        AddItem("Croissant", 95D)
    End Sub

    Private Sub btnDonut_Click(sender As Object, e As EventArgs) Handles btnDonut.Click
        AddItem("Donut", 85D)
    End Sub
End Class