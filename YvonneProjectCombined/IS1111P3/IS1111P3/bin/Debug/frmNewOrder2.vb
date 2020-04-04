Public Class frmNewOrder2
    Private Sub TblOrderDetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblOrderDetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblOrderDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.IS1111_Project1DataSet)

    End Sub

    Private Sub frmNewOrder2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IS1111_Project1DataSet.tblOrderDetails' table. You can move, or remove it, as needed.
        Me.TblOrderDetailsTableAdapter.Fill(Me.IS1111_Project1DataSet.tblOrderDetails)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class