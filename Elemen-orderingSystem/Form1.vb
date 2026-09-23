Public Class Form1
    Dim itemName As String = ""
    Dim itemPrice As Decimal = 0.00
    Dim qty As Integer = 0

    Private Sub SelectItem(name As String, price As Decimal)
        itemName = name
        itemPrice = price
        qty = 1

        LblItem.Text = itemName
        LblItemPrice.Text = "PHP " & itemPrice.ToString("0.00")
        LblQty.Text = qty.ToString()
    End Sub
    Private Sub BtnVanilla_Click(sender As Object, e As EventArgs) Handles BtnVanilla.Click
        SelectItem("Vanilla", itemPrice)
    End Sub
    Private Sub BtnCnC_Click(sender As Object, e As EventArgs) Handles BtnCnC.Click
        SelectItem("Cookies N' Cream", itemPrice)
    End Sub
    Private Sub BtnChocolate_Click(sender As Object, e As EventArgs) Handles BtnChocolate.Click
        SelectItem("Chocolate", itemPrice)
    End Sub
    Private Sub BtnStrawberry_Click(sender As Object, e As EventArgs) Handles BtnStrawberry.Click
        SelectItem("Strawberry", itemPrice)
    End Sub
    Private Sub BtnMatcha_Click(sender As Object, e As EventArgs) Handles BtnMatcha.Click
        SelectItem("Matcha", itemPrice)
    End Sub
    Private Sub BtnUbe_Click(sender As Object, e As EventArgs) Handles BtnUbe.Click
        SelectItem("Ube", itemPrice)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        qty += 1
        LblQty.Text = qty.ToString
    End Sub

    Private Sub BtnMinus_Click(sender As Object, e As EventArgs) Handles BtnMinus.Click
        If qty > 1 Then
            qty -= 1
            LblQty.Text = qty.ToString
        End If
    End Sub

    Private Sub BtnAddToCart_Click(sender As Object, e As EventArgs) Handles BtnAddToCart.Click
        If itemName = "" Then
            MessageBox.Show("Please select an item")
            Exit Sub
        End If

        Dim toppings As String = ""
        Dim toppingsPrice As Decimal = 0

        If ChkOreo.Checked Then
            toppings &= "Oreo, "
            toppingsPrice += 20
        End If

        If ChkMarshmallow.Checked Then
            toppings &= "Marshmallow, "
            toppingsPrice += 15
        End If

        If ChkSprinkles.Checked Then
            toppings &= "Sprinkles, "
            toppingsPrice += 15
        End If

        If ChkNuts.Checked Then
            toppings &= "Nuts, "
            toppingsPrice += 20
        End If

        If ChkChocolateSyrup.Checked Then
            toppings &= "Chocolate Syrup, "
            toppingsPrice += 20
        End If

        If toppings.EndsWith(", ") Then
            toppings = toppings.Substring(0, toppings.Length - 2)
        End If

        Dim totalPrice As Decimal
        totalPrice = (itemPrice + toppingsPrice) * qty

        Dim item As New ListViewItem(itemName)
        item.SubItems.Add(toppings)
        item.SubItems.Add(qty.ToString())
        item.SubItems.Add(totalPrice.ToString("0.00"))

        ListViewOrder.Items.Add(item)

    End Sub

End Class
