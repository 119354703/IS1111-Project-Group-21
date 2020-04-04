Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IS1111_Project1DataSet.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.IS1111_Project1DataSet.tblCustomer)
        'TODO: This line of code loads data into the 'IS1111_Project1DataSet.tblEmployee' table. You can move, or remove it, as needed.
        Me.TblEmployeeTableAdapter.Fill(Me.IS1111_Project1DataSet.tblEmployee)
        'TODO: This line of code loads data into the 'IS1111_Project1DataSet.tblEmployee' table. You can move, or remove it, as needed.
        Me.TblEmployeeTableAdapter.Fill(Me.IS1111_Project1DataSet.tblEmployee)
        'TODO: This line of code loads data into the 'IS1111_Project1DataSet.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.IS1111_Project1DataSet.tblCustomer)

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim custQuery = From login In IS1111_Project1DataSet.tblCustomer
                        Where login.CustomerID = txtUsername.Text And login.Password = txtPassword.Text
                        Select login.Password
        Dim staffQuery = From login In IS1111_Project1DataSet.tblEmployee
                         Where login.EmployeeID = txtUsername.Text And login.Password = txtPassword.Text And login.Position = "Staff"
                         Select login.Password

        Dim managerQuery = From login In IS1111_Project1DataSet.tblEmployee
                           Where login.EmployeeID = txtUsername.Text And login.Password = txtPassword.Text And login.Position = "Manager"
                           Select login.Password

        If custQuery.Count = 1 And cmbUserType.Text = "Customer" Then
            strUser = "Customer"
            intUser = CInt(txtUsername.Text)
            frmHomePage.Show()
            Me.Hide()
        ElseIf staffQuery.Count = 1 And cmbUserType.Text = "Employee" Then
            strUser = "Employee"
            intUser = CInt(txtUsername.Text)
            frmHomePage.Show()
            Me.Hide()
        ElseIf managerQuery.Count = 1 And cmbUserType.Text = "Employee" Then
            strUser = "Manager"
            intUser = CInt(txtUsername.Text)
            frmHomePage.Show()
            Me.Hide()
        Else
            MessageBox.Show("Incorrect Details")
            txtUsername.Text = Nothing
            txtPassword.Text = Nothing
        End If
        'MessageBox.Show(strUser)
        'Dim UserQuery = From login In IS1111_Project1DataSet.tbl_User
        '                Where login.Username = txtUsername.Text And login.Password = txtPassword.Text
        '                Select login.Password

        'If UserQuery.Count = 1 Then
        '    frmHomePage.Show()
        '    Me.Hide()
        'End If
    End Sub

End Class