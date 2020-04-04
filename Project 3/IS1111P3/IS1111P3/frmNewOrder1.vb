Public Class frmNewOrder1
    Private Sub frmNewOrder1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IS1111_Project1DataSet.tblOrderDetails' table. You can move, or remove it, as needed.
        Me.TblOrderDetailsTableAdapter.Fill(Me.IS1111_Project1DataSet.tblOrderDetails)
        BindingSource1.AddNew()
        btnSave.Visible = False
        chbQuarter.Checked = False
        chbVamp.Checked = False
        chbEyestay.Checked = False
        chbHeelTab.Checked = False
        chbHeelBackCounter.Checked = False
        chbLaces.Checked = False
    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtModel.Text = "" Or txtQuantity.Text = "" Then
            MessageBox.Show("Please fill all required fields")
        Else
            Try
                BindingSource1.EndEdit()
                TblOrderDetailsTableAdapter.Update(Me.IS1111_Project1DataSet.tblOrderDetails)
                MessageBox.Show("Order Successfully placed")
            Catch ex As Exception
                MessageBox.Show("Error")
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If txtQuantity.Text = "" Then
            MessageBox.Show("Please fill in a Quantity")
            'ElseIf txtModel.Text <> "Classic" Or txtModel.Text <> "Retro" Or txtModel.Text <> "Vintage" Then
            '    MessageBox.Show("Shoe Model is invalid. Please choose Classic, Retro or Vintage.")
            'ElseIf txtModel.Text <> "Retro" Then
            '    MessageBox.Show("Shoe Model is invalid. Please choose Classic, Retro or Vintage.")
            'ElseIf txtModel.Text <> "Vintage" Then
            '    MessageBox.Show("Shoe Model is invalid. Please choose Classic, Retro or Vintage.")
        Else
            If txtModel.Text = "Classic" Then
                dblModelPrice = 54.49
                strModel = "Classic"
            ElseIf txtModel.Text = "Retro" Then
                dblModelPrice = 49.5
                strModel = "Retro"
            ElseIf txtModel.Text = "Vintage" Then
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
                strHeelBackCounterCol = cmbHeelBackCounter.Text
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
            'If chbLogo.Checked = True Then
            '    dblLogo = dblSubtotal * 0.18
            'Else
            '    dblLogo = 0
            'End If
            dblSubtotal = dblQuantity * (dblExtras + dblModelPrice + dblLogo)
            dblSubtotal = CInt(dblSubtotal)
            txtSubtotal.Text = CStr("$" & dblSubtotal)
            btnSave.Visible = True
        End If
    End Sub

    Private Sub btnViewOrder_Click(sender As Object, e As EventArgs) Handles btnViewOrder.Click

    End Sub
End Class