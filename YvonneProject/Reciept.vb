Public Class Reciept
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lstOutput.Items.Add("Shop ltd")
        lstOutput.Items.Add("Uniersity College Cork, Ireland")
        lstOutput.Items.Add("Mobile Number: 087123456")
        lstOutput.Items.Add("---------------------------------------------------------------------------------------")
        'Will need to get order id an put it in here
        lstOutput.Items.Add("Order ID:")
        lstOutput.Items.Add("Date: 09/04/2020")
        'Get Customer name in here
        lstOutput.Items.Add("Customer Name:")
        'put customer address in here
        lstOutput.Items.Add("Customer Address:")
        'Put in Customer Number Here
        lstOutput.Items.Add("Customer Phone Number:")
        lstOutput.Items.Add("Shoe model to be customised:" & " " & frmShop.cmbShoe.Text)
        lstOutput.Items.Add("Logo:" & " " & frmShop.txtLogo)
        lstOutput.Items.Add("---------------------------------------------------------------------------------------")
        lstOutput.Items.Add("Customisation Description:")
        lstOutput.Items.Add("Quarter:" & " " & frmShop.cmbQuarter.Text)
        lstOutput.Items.Add("Vamps:" & " " & frmShop.cmbVamps.Text)
        lstOutput.Items.Add("Eyestay:" & " " & frmShop.cmbEyestay.Text)
        lstOutput.Items.Add("Laces:" & " " & frmShop.cmbLaces.Text)
        lstOutput.Items.Add("HeelTab:" & " " & frmShop.cmbHeeltab.Text)
        lstOutput.Items.Add("Heel/Back Counter:" & " " & frmShop.cmbBackcounter.Text)
        lstOutput.Items.Add("Text:" & " " & frmShop.txtShows.Text)
        lstOutput.Items.Add("---------------------------------------------------------------------------------------")
        lstOutput.Items.Add("Customisation Description:")
        lstOutput.Items.Add("Quarter:" & " " & frmShop.dblQuarter.ToString("C"))
        lstOutput.Items.Add("Vamps:" & " " & frmShop.dblVamps.ToString("C"))
        lstOutput.Items.Add("Eyestay:" & " " & frmShop.dblEyestay.ToString("C"))
        lstOutput.Items.Add("Laces:" & " " & frmShop.dblLaces.ToString("C"))
        lstOutput.Items.Add("Heel/Back Counter:" & " " & frmShop.dblBackcounter.ToString("C"))
        lstOutput.Items.Add("Text:" & " " & frmShop.txtPrice.Text)
        lstOutput.Items.Add("Logo:" & " " & frmShop.dblLogo.ToString("C"))
        lstOutput.Items.Add("Price Per Shoe:" & " " & frmShop.dblfull.ToString("C"))
        lstOutput.Items.Add("Vat Per Shoe:" & " " & frmShop.dblVat.ToString("C"))
        lstOutput.Items.Add("Total Price:" & " " & frmShop.dblGrandtotal.ToString("C"))
        lstOutput.Items.Add("---------------------------------------------------------------------------------------")
        lstOutput.Items.Add("Served By: Sam Murphy")
        lstOutput.Items.Add("---------------------------------------------------------------------------------------")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Visible = False
    End Sub
End Class