Public Class frmCustomer
    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IS1111_Project1DataSet.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.IS1111_Project1DataSet.tblCustomer)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Me.Validate()
            BindingSource1.EndEdit()
            TblCustomerTableAdapter.Update(Me.IS1111_Project1DataSet.tblCustomer)
            MessageBox.Show("Data Saved", "Status Update")
        Catch ex As Exception
            MessageBox.Show("Error Saving Data")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmLogin.Show()
        Me.Hide()
    End Sub
End Class