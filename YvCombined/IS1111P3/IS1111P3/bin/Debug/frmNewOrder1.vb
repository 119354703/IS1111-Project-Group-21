Public Class frmNewOrder1
    Public dblBackcounter, dblQuarter, dblVamp, dblEyestay, dblHeeltab, dblLaces, dblCount, dblLogo, dblSubtotal, dblVat, dblGrandtotal As Double
    Public strInput As String

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        'Works with the characters.
        Dim charArray() As Char = strInput.ToCharArray
        'Without the duplicates. Distinct = removes duplicates.
        'We declare this array as we will be comparing it to the original
        Dim distinctArray() As Char = charArray.Distinct.ToArray
        'loop that counts amount of characters in the string
        Dim counter As Integer = 0
        For i As Integer = 0 To distinctArray.Count - 1.0
            For j As Integer = i To charArray.Count - 1 'Inner loop >>Next available letter >> Loops all
                If distinctArray(i) = charArray(j) Then
                    counter += 1
                End If
            Next
            'lstOutput.Items.Add(distinctArray(i) + " ..... " + counter.ToString)
            'counter = 0 'Reset the counter so the next letter can be added.Next
            dblCount = counter * 0.45

            txtPrice.Text = dblCount.ToString("C")
            txtShows.Text = strInput
        Next
    End Sub

    Private Sub btnText_Click(sender As Object, e As EventArgs) Handles btnText.Click
        'gets the character length for the text that will go on the shoe
        strInput = InputBox("Please enter the sentence", "Enter Sentence")
        strInput = strInput.ToLower
        'validation making sure that the text is less than 11 characters
        If Not strInput.Length <= 10 Then
            MsgBox("The word must be less than 10 charcharacters")
        Else
            MsgBox("Word accepted")
        End If
    End Sub

    Private Sub frmNewOrder1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IS1111_Project1DataSet.tblOrderDetails' table. You can move, or remove it, as needed.
        Me.TblOrderDetailsTableAdapter.Fill(Me.IS1111_Project1DataSet.tblOrderDetails)
        BindingSource1.AddNew()
        btnSave.Visible = False
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

                If cmbQuarter.Text = "Blue" Then
                    dblQuarter = 8.99
                ElseIf cmbQuarter.Text = "Green" Then
                    dblQuarter = 8.99
                ElseIf cmbQuarter.Text = "Red" Then
                    dblQuarter = 8.99
                ElseIf cmbQuarter.Text = "Orange" Then
                    dblQuarter = 8.99
                ElseIf cmbQuarter.Text = "Black" Then
                    dblQuarter = 8.99
                ElseIf cmbQuarter.Text = "White" Then
                    dblQuarter = 0
                End If

                If cmbVamp.Text = "Blue" Then
                    dblVamp = 14.99
                ElseIf cmbVamp.Text = "Green" Then
                    dblVamp = 14.99
                ElseIf cmbVamp.Text = "Red" Then
                    dblVamp = 14.99
                ElseIf cmbVamp.Text = "Orange" Then
                    dblVamp = 14.99
                ElseIf cmbVamp.Text = "Black" Then
                    dblVamp = 14.99
                ElseIf cmbVamp.Text = "White" Then
                    dblVamp = 0
                End If

                If cmbEyestay.Text = "Blue" Then
                    dblEyestay = 5
                ElseIf cmbEyestay.Text = "Green" Then
                    dblEyestay = 5
                ElseIf cmbEyestay.Text = "Red" Then
                    dblEyestay = 5
                ElseIf cmbEyestay.Text = "Orange" Then
                    dblEyestay = 5
                ElseIf cmbEyestay.Text = "Black" Then
                    dblEyestay = 5
                ElseIf cmbEyestay.Text = "White" Then
                    dblEyestay = 0
                End If

                If cmbHeeltab.Text = "Blue" Then
                    dblHeeltab = 4.99
                ElseIf cmbHeeltab.Text = "Green" Then
                    dblHeeltab = 4.99
                ElseIf cmbHeeltab.Text = "Red" Then
                    dblHeeltab = 4.99
                ElseIf cmbHeeltab.Text = "Orange" Then
                    dblHeeltab = 4.99
                ElseIf cmbHeeltab.Text = "Black" Then
                    dblHeeltab = 4.99
                ElseIf cmbHeeltab.Text = "White" Then
                    dblHeeltab = 0
                End If

                If cmbBackCounter.Text = "Blue" Then
                    dblBackcounter = 6.49
                ElseIf cmbBackCounter.Text = "Green" Then
                    dblBackcounter = 6.49
                ElseIf cmbBackCounter.Text = "Red" Then
                    dblBackcounter = 6.49
                ElseIf cmbBackCounter.Text = "Orange" Then
                    dblBackcounter = 6.49
                ElseIf cmbBackCounter.Text = "Black" Then
                    dblBackcounter = 6.49
                ElseIf cmbBackCounter.Text = "White" Then
                    dblBackcounter = 0
                End If

                If cmbLaces.Text = "Blue" Then
                    dblLaces = 4
                ElseIf cmbLaces.Text = "Green" Then
                    dblLaces = 4
                ElseIf cmbLaces.Text = "Red" Then
                    dblLaces = 4
                ElseIf cmbLaces.Text = "Orange" Then
                    dblLaces = 4
                ElseIf cmbLaces.Text = "Black" Then
                    dblLaces = 4
                ElseIf cmbLaces.Text = "white" Then
                    dblLaces = 0
                End If

                If rdoLogo.Checked Then
                    dblLogo = 0.18 * (dblQuarter + dblVamp + dblEyestay + dblHeeltab + dblBackcounter)
                Else
                    dblLogo = 0
                End If
            ElseIf txtModel.Text = "Retro" Then
                dblModelPrice = 49.5
                strModel = "Retro"

                If cmbQuarter.Text = "Blue" Then
                    dblQuarter = 8.99
                ElseIf cmbQuarter.Text = "Green" Then
                    dblQuarter = 8.99
                ElseIf cmbQuarter.Text = "Red" Then
                    dblQuarter = 8.99
                ElseIf cmbQuarter.Text = "Orange" Then
                    dblQuarter = 8.99
                ElseIf cmbQuarter.Text = "Black" Then
                    dblQuarter = 8.99
                ElseIf cmbQuarter.Text = "White" Then
                    dblQuarter = 0
                End If

                If cmbVamp.Text = "Blue" Then
                    dblVamp = 14.99
                ElseIf cmbVamp.Text = "Green" Then
                    dblVamp = 14.99
                ElseIf cmbVamp.Text = "Red" Then
                    dblVamp = 14.99
                ElseIf cmbVamp.Text = "Orange" Then
                    dblVamp = 14.99
                ElseIf cmbVamp.Text = "Black" Then
                    dblVamp = 14.99
                ElseIf cmbVamp.Text = "White" Then
                    dblVamp = 0
                End If

                If cmbEyestay.Text = "Blue" Then
                    dblEyestay = 5
                ElseIf cmbEyestay.Text = "Green" Then
                    dblEyestay = 5
                ElseIf cmbEyestay.Text = "Red" Then
                    dblEyestay = 5
                ElseIf cmbEyestay.Text = "Orange" Then
                    dblEyestay = 5
                ElseIf cmbEyestay.Text = "Black" Then
                    dblEyestay = 5
                ElseIf cmbEyestay.Text = "White" Then
                    dblEyestay = 0
                End If

                If cmbHeeltab.Text = "Blue" Then
                    dblHeeltab = 4.99
                ElseIf cmbHeeltab.Text = "Green" Then
                    dblHeeltab = 4.99
                ElseIf cmbHeeltab.Text = "Red" Then
                    dblHeeltab = 4.99
                ElseIf cmbHeeltab.Text = "Orange" Then
                    dblHeeltab = 4.99
                ElseIf cmbHeeltab.Text = "Black" Then
                    dblHeeltab = 4.99
                ElseIf cmbHeeltab.Text = "White" Then
                    dblHeeltab = 0
                End If

                If cmbBackCounter.Text = "Blue" Then
                    dblBackcounter = 6.49
                ElseIf cmbBackCounter.Text = "Green" Then
                    dblBackcounter = 6.49
                ElseIf cmbBackCounter.Text = "Red" Then
                    dblBackcounter = 6.49
                ElseIf cmbBackCounter.Text = "Orange" Then
                    dblBackcounter = 6.49
                ElseIf cmbBackCounter.Text = "Black" Then
                    dblBackcounter = 6.49
                ElseIf cmbBackCounter.Text = "White" Then
                    dblBackcounter = 0
                End If

                If cmbLaces.Text = "Blue" Then
                    dblLaces = 4
                ElseIf cmbLaces.Text = "Green" Then
                    dblLaces = 4
                ElseIf cmbLaces.Text = "Red" Then
                    dblLaces = 4
                ElseIf cmbLaces.Text = "Orange" Then
                    dblLaces = 4
                ElseIf cmbLaces.Text = "Black" Then
                    dblLaces = 4
                ElseIf cmbLaces.Text = "white" Then
                    dblLaces = 0
                End If

                If rdoLogo.Checked Then
                    dblLogo = 0.18 * (dblQuarter + dblVamp + dblEyestay + dblHeeltab + dblBackcounter)
                Else
                    dblLogo = 0
                End If
            ElseIf txtModel.Text = "Vintage" Then
                dblModelPrice = 44.99
                strModel = "Vintage"

                If cmbQuarter.Text = "Blue" Then
                    dblQuarter = 8.99
                ElseIf cmbQuarter.Text = "Green" Then
                    dblQuarter = 8.99
                ElseIf cmbQuarter.Text = "Red" Then
                    dblQuarter = 8.99
                ElseIf cmbQuarter.Text = "Orange" Then
                    dblQuarter = 8.99
                ElseIf cmbQuarter.Text = "Black" Then
                    dblQuarter = 8.99
                ElseIf cmbQuarter.Text = "White" Then
                    dblQuarter = 0
                End If

                If cmbVamp.Text = "Blue" Then
                    dblVamp = 14.99
                ElseIf cmbVamp.Text = "Green" Then
                    dblVamp = 14.99
                ElseIf cmbVamp.Text = "Red" Then
                    dblVamp = 14.99
                ElseIf cmbVamp.Text = "Orange" Then
                    dblVamp = 14.99
                ElseIf cmbVamp.Text = "Black" Then
                    dblVamp = 14.99
                ElseIf cmbVamp.Text = "White" Then
                    dblVamp = 0
                End If

                If cmbEyestay.Text = "Blue" Then
                    dblEyestay = 5
                ElseIf cmbEyestay.Text = "Green" Then
                    dblEyestay = 5
                ElseIf cmbEyestay.Text = "Red" Then
                    dblEyestay = 5
                ElseIf cmbEyestay.Text = "Orange" Then
                    dblEyestay = 5
                ElseIf cmbEyestay.Text = "Black" Then
                    dblEyestay = 5
                ElseIf cmbEyestay.Text = "White" Then
                    dblEyestay = 0
                End If

                If cmbHeeltab.Text = "Blue" Then
                    dblHeeltab = 4.99
                ElseIf cmbHeeltab.Text = "Green" Then
                    dblHeeltab = 4.99
                ElseIf cmbHeeltab.Text = "Red" Then
                    dblHeeltab = 4.99
                ElseIf cmbHeeltab.Text = "Orange" Then
                    dblHeeltab = 4.99
                ElseIf cmbHeeltab.Text = "Black" Then
                    dblHeeltab = 4.99
                ElseIf cmbHeeltab.Text = "White" Then
                    dblHeeltab = 0
                End If

                If cmbBackCounter.Text = "Blue" Then
                    dblBackcounter = 6.49
                ElseIf cmbBackCounter.Text = "Green" Then
                    dblBackcounter = 6.49
                ElseIf cmbBackCounter.Text = "Red" Then
                    dblBackcounter = 6.49
                ElseIf cmbBackCounter.Text = "Orange" Then
                    dblBackcounter = 6.49
                ElseIf cmbBackCounter.Text = "Black" Then
                    dblBackcounter = 6.49
                ElseIf cmbBackCounter.Text = "White" Then
                    dblBackcounter = 0
                End If

                If cmbLaces.Text = "Blue" Then
                    dblLaces = 4
                ElseIf cmbLaces.Text = "Green" Then
                    dblLaces = 4
                ElseIf cmbLaces.Text = "Red" Then
                    dblLaces = 4
                ElseIf cmbLaces.Text = "Orange" Then
                    dblLaces = 4
                ElseIf cmbLaces.Text = "Black" Then
                    dblLaces = 4
                ElseIf cmbLaces.Text = "white" Then
                    dblLaces = 0
                End If

                If rdoLogo.Checked Then
                    dblLogo = 0.18 * (dblQuarter + dblVamp + dblEyestay + dblHeeltab + dblBackcounter + dblCount)
                Else
                    dblLogo = 0
                End If
            End If

            dblQuantity = CDbl(txtQuantity.Text)
            dblExtras = (dblQuarter + dblVamp + dblEyestay + dblHeeltab + dblBackcounter + dblLaces + dblCount + dblLogo)
            'If chbLogo.Checked = True Then
            '    dblLogo = dblSubtotal * 0.18
            'Else
            '    dblLogo = 0
            'End If
            dblVat = 0.23 * (dblModelPrice + dblQuarter + dblVamp + dblEyestay + dblHeeltab + dblBackcounter + dblLaces + dblLogo + dblCount)
            dblSubtotal = dblQuantity * (dblExtras + dblModelPrice + dblLogo)
            dblSubtotal = CInt(dblSubtotal)
            dblGrandtotal = dblSubtotal + dblVat
            txtSubtotal.Text = CStr("€" & dblGrandtotal)
            btnSave.Visible = True
        End If
    End Sub

    Private Sub btnViewOrder_Click(sender As Object, e As EventArgs) Handles btnViewOrder.Click
        frmOrderDetails.Visible = True
        Me.Visible = False
    End Sub
End Class