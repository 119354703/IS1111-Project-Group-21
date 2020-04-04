Public Class frmOrderDetails
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
        lstOutput.Items.Add("Shoe model to be customised:" & " " & frmNewOrder1.txtModel.Text)
        lstOutput.Items.Add("Logo:" & " " & frmNewOrder1.strInput)
        lstOutput.Items.Add("---------------------------------------------------------------------------------------")
        lstOutput.Items.Add("Customisation Description:")
        lstOutput.Items.Add("Quarter:" & " " & frmNewOrder1.cmbQuarter.Text)
        lstOutput.Items.Add("Vamps:" & " " & frmNewOrder1.cmbVamp.Text)
        lstOutput.Items.Add("Eyestay:" & " " & frmNewOrder1.cmbEyestay.Text)
        lstOutput.Items.Add("Laces:" & " " & frmNewOrder1.cmbLaces.Text)
        lstOutput.Items.Add("HeelTab:" & " " & frmNewOrder1.cmbHeeltab.Text)
        lstOutput.Items.Add("Heel/Back Counter:" & " " & frmNewOrder1.cmbBackCounter.Text)
        lstOutput.Items.Add("Text:" & " " & frmNewOrder1.txtShows.Text)
        lstOutput.Items.Add("---------------------------------------------------------------------------------------")
        lstOutput.Items.Add("Customisation Description:")
        lstOutput.Items.Add("Quarter:" & " " & frmNewOrder1.dblQuarter.ToString("C"))
        lstOutput.Items.Add("Vamps:" & " " & frmNewOrder1.dblVamp.ToString("C"))
        lstOutput.Items.Add("Eyestay:" & " " & frmNewOrder1.dblEyestay.ToString("C"))
        lstOutput.Items.Add("Laces:" & " " & frmNewOrder1.dblLaces.ToString("C"))
        lstOutput.Items.Add("Heel/Back Counter:" & " " & frmNewOrder1.dblBackcounter.ToString("C"))
        lstOutput.Items.Add("Text:" & " " & frmNewOrder1.txtPrice.Text)
        lstOutput.Items.Add("Logo:" & " " & frmNewOrder1.dblLogo.ToString("C"))
        lstOutput.Items.Add("Price Per Shoe:" & " " & frmNewOrder1.dblSubtotal.ToString("C"))
        lstOutput.Items.Add("Vat Per Shoe:" & " " & frmNewOrder1.dblVat.ToString("C"))
        lstOutput.Items.Add("Total Price:" & " " & frmNewOrder1.dblGrandtotal.ToString("C"))
        lstOutput.Items.Add("---------------------------------------------------------------------------------------")
        lstOutput.Items.Add("Served By: Sam Murphy")
        lstOutput.Items.Add("---------------------------------------------------------------------------------------")
    End Sub
End Class