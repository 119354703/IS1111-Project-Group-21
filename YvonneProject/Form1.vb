Public Class frmShop
    'Declaring variables for calculations
    Public dblShoes, dblfull, dbltotal, dblGrandtotal As Double
    Public dblClassic, dblVintage, dblRetro As Double
    Public strInput As String
    Public dblCount As Double
    Public dblQuarter, dblVamps, dblEyestay, dblHeeltab, dblBackcounter, dblLaces, dblLogo As Double
    Public txtLogo As String


    Private Sub btnReciept_Click(sender As Object, e As EventArgs) Handles btnReciept.Click
        Reciept.Visible = True
    End Sub

    Public dblVat As Double
    Public dbl11count As double

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears order if needed
        txtDisplay.Clear()
        rdoLogo.Checked = False
        txtPrice.Clear()
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

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
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


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Adding up prices for the classics runner depending on what is selected
        txtDisplay.Clear()
        If cmbShoe.Text = "Classic Runner" Then
            dblClassic = 54.49

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
            Else
                dblQuarter = 0
            End If

            If cmbVamps.Text = "Blue" Then
                dblVamps = 14.99
            ElseIf cmbVamps.Text = "Green" Then
                dblVamps = 14.99
            ElseIf cmbVamps.Text = "Red" Then
                dblVamps = 14.99
            ElseIf cmbVamps.Text = "Orange" Then
                dblVamps = 14.99
            ElseIf cmbVamps.Text = "Black" Then
                dblVamps = 14.99
            Else
                dblVamps = 0
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
            Else
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
            Else
                dblHeeltab = 0
            End If

            If cmbBackcounter.Text = "Blue" Then
                dblBackcounter = 6.49
            ElseIf cmbBackcounter.Text = "Green" Then
                dblBackcounter = 6.49
            ElseIf cmbBackcounter.Text = "Red" Then
                dblBackcounter = 6.49
            ElseIf cmbBackcounter.Text = "Orange" Then
                dblBackcounter = 6.49
            ElseIf cmbBackcounter.Text = "Black" Then
                dblBackcounter = 6.49
            Else
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
            Else
                dblLaces = 0
            End If

            If rdoLogo.Checked Then
                dblLogo = 0.18 * (dblQuarter + dblVamps + dblEyestay + dblHeeltab + dblBackcounter)
                txtLogo = "Yes"
            Else
                dblLogo = 0
                txtLogo = "No"
            End If
        End If
        ' Adding up prices for the Vintage runner depending on what is selected
        If cmbShoe.Text = "Vintage Runner" Then
            dblVintage = 44.99

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
            Else
                dblQuarter = 0
            End If

            If cmbVamps.Text = "Blue" Then
                dblVamps = 14.99
            ElseIf cmbVamps.Text = "Green" Then
                dblVamps = 14.99
            ElseIf cmbVamps.Text = "Red" Then
                dblVamps = 14.99
            ElseIf cmbVamps.Text = "Orange" Then
                dblVamps = 14.99
            ElseIf cmbVamps.Text = "Black" Then
                dblVamps = 14.99
            Else
                dblVamps = 0
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
            Else
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
            Else
                dblHeeltab = 0
            End If

            If cmbBackcounter.Text = "Blue" Then
                dblBackcounter = 6.49
            ElseIf cmbBackcounter.Text = "Green" Then
                dblBackcounter = 6.49
            ElseIf cmbBackcounter.Text = "Red" Then
                dblBackcounter = 6.49
            ElseIf cmbBackcounter.Text = "Orange" Then
                dblBackcounter = 6.49
            ElseIf cmbBackcounter.Text = "Black" Then
                dblBackcounter = 6.49
            Else
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
            Else
                dblLaces = 0
            End If

            If rdoLogo.Checked Then
                dblLogo = 0.18 * (dblQuarter + dblVamps + dblEyestay + dblHeeltab + dblBackcounter)
                txtLogo = "Yes"
            Else
                dblLogo = 0
                txtLogo = "No"
            End If
        End If
        ' Adding up prices for the Retro runner depending on what is selected
        If cmbShoe.Text = "Retro Runner" Then
            dblRetro = 49.5

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
            Else
                dblQuarter = 0
            End If

            If cmbVamps.Text = "Blue" Then
                dblVamps = 14.99
            ElseIf cmbVamps.Text = "Green" Then
                dblVamps = 14.99
            ElseIf cmbVamps.Text = "Red" Then
                dblVamps = 14.99
            ElseIf cmbVamps.Text = "Orange" Then
                dblVamps = 14.99
            ElseIf cmbVamps.Text = "Black" Then
                dblVamps = 14.99
            Else
                dblVamps = 0
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
            Else
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
            Else
                dblHeeltab = 0
            End If

            If cmbBackcounter.Text = "Blue" Then
                dblBackcounter = 6.49
            ElseIf cmbBackcounter.Text = "Green" Then
                dblBackcounter = 6.49
            ElseIf cmbBackcounter.Text = "Red" Then
                dblBackcounter = 6.49
            ElseIf cmbBackcounter.Text = "Orange" Then
                dblBackcounter = 6.49
            ElseIf cmbBackcounter.Text = "Black" Then
                dblBackcounter = 6.49
            Else
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
            Else
                dblLaces = 0
            End If

            If rdoLogo.Checked Then
                dblLogo = 0.18 * (dblQuarter + dblVamps + dblEyestay + dblHeeltab + dblBackcounter + dblCount)
                txtLogo = "Yes"
            Else
                dblLogo = 0
                txtLogo = "No"
            End If
        End If
        'Assigning a value to dblShoes
        dblShoes = dblVintage Or dblRetro Or dblClassic
        'Calculating that Vat for the shoe
        dblVat = 0.23 * (dblShoes + dblQuarter + dblVamps + dblEyestay + dblHeeltab + dblBackcounter + dblLaces + dblLogo + dblCount)
        'Calculating the full price for the shoe
        dblfull = dblShoes + dblQuarter + dblVamps + dblEyestay + dblHeeltab + dblBackcounter + dblLaces + dblLogo + dblCount
        dbltotal = dblfull + dblVat
        dblGrandtotal = dbltotal * 2
        'Displaying the full price in a textbox
        txtDisplay.Text = dbltotal.ToString("C")
    End Sub
End Class
