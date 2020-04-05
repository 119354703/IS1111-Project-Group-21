<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnTrackOrder = New System.Windows.Forms.Button()
        Me.btnFindOrder = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnMyAccount = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTrackOrder
        '
        Me.btnTrackOrder.Location = New System.Drawing.Point(42, 125)
        Me.btnTrackOrder.Name = "btnTrackOrder"
        Me.btnTrackOrder.Size = New System.Drawing.Size(163, 30)
        Me.btnTrackOrder.TabIndex = 1
        Me.btnTrackOrder.Text = "Track Order"
        Me.btnTrackOrder.UseVisualStyleBackColor = True
        '
        'btnFindOrder
        '
        Me.btnFindOrder.Location = New System.Drawing.Point(42, 161)
        Me.btnFindOrder.Name = "btnFindOrder"
        Me.btnFindOrder.Size = New System.Drawing.Size(163, 30)
        Me.btnFindOrder.TabIndex = 2
        Me.btnFindOrder.Text = "Find Order"
        Me.btnFindOrder.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(42, 197)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(163, 30)
        Me.btnCustomer.TabIndex = 3
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnEmployee
        '
        Me.btnEmployee.Location = New System.Drawing.Point(42, 233)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(163, 30)
        Me.btnEmployee.TabIndex = 4
        Me.btnEmployee.Text = "Employee"
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'btnMyAccount
        '
        Me.btnMyAccount.Location = New System.Drawing.Point(42, 269)
        Me.btnMyAccount.Name = "btnMyAccount"
        Me.btnMyAccount.Size = New System.Drawing.Size(163, 30)
        Me.btnMyAccount.TabIndex = 5
        Me.btnMyAccount.Text = "My Account"
        Me.btnMyAccount.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Welcome to YourStyle"
        '
        'btnNewOrder
        '
        Me.btnNewOrder.Location = New System.Drawing.Point(42, 90)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(163, 29)
        Me.btnNewOrder.TabIndex = 8
        Me.btnNewOrder.Text = "New Order"
        Me.btnNewOrder.UseVisualStyleBackColor = True
        '
        'frmHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 404)
        Me.Controls.Add(Me.btnNewOrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMyAccount)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.btnFindOrder)
        Me.Controls.Add(Me.btnTrackOrder)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmHomePage"
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTrackOrder As Button
    Friend WithEvents btnFindOrder As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnEmployee As Button
    Friend WithEvents btnMyAccount As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNewOrder As Button
End Class
