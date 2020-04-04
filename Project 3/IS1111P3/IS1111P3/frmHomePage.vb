Public Class frmHomePage
    Private Sub frmHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show(strUser)
        If strUser = "Customer" Then
            btnFindOrder.Visible = False
            btnCustomer.Visible = False
            btnEmployee.Visible = False
        ElseIf strUser = "Employee" Then
            btnCustomer.Visible = False
            btnEmployee.Visible = False
        End If
    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) 
        frmNewOrder2.Show()
        Me.Hide()
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        frmCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        frmNewOrder.Show()
        Me.Hide()

    End Sub

    Private Sub btnFindOrder_Click(sender As Object, e As EventArgs) Handles btnFindOrder.Click
        frmFindOrder.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmNewOrder1.Show()
        Me.Hide()
    End Sub
End Class