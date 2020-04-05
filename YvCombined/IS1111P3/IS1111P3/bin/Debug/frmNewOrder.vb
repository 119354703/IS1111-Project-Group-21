Public Class frmNewOrder

    Private Sub frmNewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IS1111_Project1DataSet.tblOrderDetails' table. You can move, or remove it, as needed.
        Me.TblOrderDetailsTableAdapter.Fill(Me.IS1111_Project1DataSet.tblOrderDetails)
        'TODO: This line of code loads data into the 'IS1111_Project1DataSet.tblOrders' table. You can move, or remove it, as needed.
        Me.TblOrdersTableAdapter.Fill(Me.IS1111_Project1DataSet.tblOrders)
        cmbQuarter.Visible = False
        cmbVamp.Visible = False
        cmbEyestay.Visible = False
        cmbHeelTab.Visible = False
        cmbHeelBackCounter.Visible = False
        cmbLaces.Visible = False

        
    End Sub

    Private Sub chbQuarter_CheckedChanged(sender As Object, e As EventArgs) Handles chbQuarter.CheckedChanged
        cmbQuarter.Visible = True
    End Sub

    Private Sub chbVamp_CheckedChanged(sender As Object, e As EventArgs) Handles chbVamp.CheckedChanged
        cmbVamp.Visible = True
    End Sub

    Private Sub chbEyestay_CheckedChanged(sender As Object, e As EventArgs) Handles chbEyestay.CheckedChanged
        cmbEyestay.Visible = True
    End Sub

    Private Sub chbHeelTab_CheckedChanged(sender As Object, e As EventArgs) Handles chbHeelTab.CheckedChanged
        cmbHeelTab.Visible = True
    End Sub

    Private Sub chbHeelBackCounter_CheckedChanged(sender As Object, e As EventArgs) Handles chbHeelBackCounter.CheckedChanged
        cmbHeelBackCounter.Visible = True
    End Sub

    Private Sub chbLaces_CheckedChanged(sender As Object, e As EventArgs) Handles chbLaces.CheckedChanged
        cmbLaces.Visible = True
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If rdbClassic.Checked = True Then
            dblModelPrice = 54.49
            strModel = "Classic"
        ElseIf rdbRetro.Checked = True Then
            dblModelPrice = 49.5
            strModel = "Retro"
        ElseIf rdbVintage.Checked = True Then
            dblModelPrice = 44.99
            strModel = "Vintage"
        End If
        If chbQuarter.Checked = True And cmbQuarter.Text = "White" Then
            dblQuarter = 0
            blQuarter = True
        ElseIf chbQuarter.Checked = True Then
            dblQuarter = 8.99
            blQuarter = True
            strQuarterCol = cmbQuarter.Text
        End If
        If chbVamp.Checked = True And cmbVamp.Text = "White" Then
            dblVamp = 0
            blVamp = True
        ElseIf chbVamp.Checked = True Then
            dblVamp = 14.99
            blVamp = True
            strVampCol = cmbVamp.Text
        End If
        If chbEyestay.Checked = True And cmbEyestay.Text = "White" Then
            dblEyestay = 0
            blEyestay = True
        ElseIf chbEyestay.Checked = True Then
            dblEyestay = 5
            blEyestay = True
            strEyestayCol = cmbEyestay.Text
        End If
        If chbHeelTab.Checked = True And cmbHeelTab.Text = "White" Then
            dblHeeltab = 0
            blHeelTab = True
        ElseIf chbHeelTab.Checked = True Then
            dblHeeltab = 4.99
            blHeelTab = True
            strHeelTabCol = cmbHeelTab.Text
        End If
        If chbHeelBackCounter.Checked = True And cmbHeelBackCounter.Text = "White" Then
            dblHeelBackCounter = 0
            blHeelBackCounter = True
        ElseIf chbHeelBackCounter.Checked = True Then
            dblHeelBackCounter = 6.49
            blHeelBackCounter = True
            strHeelBackCounterCol = -cmbHeelBackCounter.Text
        End If
        If chbLaces.Checked = True And cmbLaces.Text = "White" Then
            dblLaces = 0
            blLaces = True
        ElseIf chbLaces.Checked = True Then
            dblLaces = 4
            blLaces = True
            strLacesCol = cmbLaces.Text
        End If
        dblQuantity = CDbl(txtQuantity.Text)
        dblExtras = (dblQuarter + dblVamp + dblEyestay + dblHeeltab + dblHeelBackCounter + dblLaces)
        If chbLogo.Checked = True Then
            dblLogo = dblSubtotal * 0.18
        Else
            dblLogo = 0
        End If
        dblSubtotal = dblQuantity * (dblExtras + dblModelPrice + dblLogo)
        dblSubtotal = CInt(dblSubtotal)
        txtSubtotal.Text = CStr("$" & dblSubtotal)
    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles frmPlaceOrder.Click
        BindingSource2.AddNew()
        'frmOrderDetails.Show()
        'Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            BindingSource2.EndEdit()
            TblOrderDetailsTableAdapter.Update(Me.IS1111_Project1DataSet.tblOrderDetails)
            MessageBox.Show("Order Placed")
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmHomePage.Show()
        Me.Hide()

    End Sub
End Class