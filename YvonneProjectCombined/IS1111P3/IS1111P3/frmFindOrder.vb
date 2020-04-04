Public Class frmFindOrder
    Private Sub frmFindOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IS1111_Project1DataSet.tblOrderDetails' table. You can move, or remove it, as needed.
        Me.TblOrderDetailsTableAdapter.Fill(Me.IS1111_Project1DataSet.tblOrderDetails)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmHomePage.Visible = True
    End Sub
End Class