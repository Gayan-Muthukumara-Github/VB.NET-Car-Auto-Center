Public Class Form2
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckbxComputer.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles checkbxLeather.CheckedChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSalesPrice.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New Form1

        'Message Box with title, yes no and cancel Butttons  
        MsgBox("Do you really want to exit?", 3, "Exit")
        ' Assume that you press yes Button  
        Me.Close()
        frm.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtSalesPrice.Clear()
        txtAllowance.Clear()
        txtAccessories.Clear()
        txtSubTotal.Clear()
        txtSalesTax.Clear()
        txtAmountDue.Clear()
        checkbxStereo.Checked = False
        checkbxLeather.Checked = False
        CheckbxComputer.Checked = False
        radiobtnStandard.Checked = False
        radioBtnPearlized.Checked = False
        radiobtnCustomized.Checked = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm2 As Form2
        Dim Stereo_sys As Double
        Stereo_sys = 425.76
        Dim Leather_int As Double
        Leather_int = 987.41
        Dim Computer_nav As Double
        Computer_nav = 1741.23
        Dim Standard, Pearlized, Customized_detailing As Double
        Standard = 0
        Pearlized = 345.72
        Customized_detailing = 599.99
        Dim sales_tax As Double
        sales_tax = 0.08
        Dim total_Accessories_and_finish, subTotal As Double
        total_Accessories_and_finish = 0
        subTotal = 0
        If Convert.ToDouble(txtSalesPrice.Text) <= 0 Then
            'Message box with ok button
            MsgBox("Sales Price must greater than zero", 1, "Warning")
            txtAccessories.Clear()
            txtSalesTax.Clear()
            txtSubTotal.Clear()
            txtTotal.Clear()
            txtAmountDue.Clear()

            ' Assume that you press yes Button  
            txtAccessories.Visible = True
            txtSalesTax.Visible = True
            txtSubTotal.Visible = True
            txtTotal.Visible = True
            txtAmountDue.Visible = True








        End If

        If (checkbxStereo.Checked = True) Then
            total_Accessories_and_finish += Stereo_sys
        End If
        If checkbxLeather.Checked = True Then
            total_Accessories_and_finish += Leather_int

        End If
        If CheckbxComputer.Checked = True Then
            total_Accessories_and_finish += Computer_nav

        End If

        If radiobtnStandard.Checked = True Then
            total_Accessories_and_finish += Standard
        ElseIf radioBtnPearlized.Checked = True Then
            total_Accessories_and_finish += Pearlized
        ElseIf radiobtnCustomized.Checked = True Then
            total_Accessories_and_finish += Customized_detailing
        End If
        If txtAllowance.Text = "" Then
            txtAllowance.Text = 0

        End If

        txtAccessories.Text = total_Accessories_and_finish
        subTotal = total_Accessories_and_finish + Convert.ToDouble(txtSalesPrice.Text)
        txtSubTotal.Text = Math.Round(subTotal, 2)
        txtSalesTax.Text = Math.Round(subTotal * sales_tax, 2)
        txtTotal.Text = Math.Round(subTotal + (subTotal * sales_tax), 2)
        txtAmountDue.Text = Math.Round(subTotal + (subTotal * sales_tax) - Convert.ToDouble(txtAllowance.Text), 2)







    End Sub

    Private Sub txtAmountDue_TextChanged(sender As Object, e As EventArgs) Handles txtAmountDue.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class