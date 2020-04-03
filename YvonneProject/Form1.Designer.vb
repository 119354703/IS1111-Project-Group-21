<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShop
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
        Me.cmbShoe = New System.Windows.Forms.ComboBox()
        Me.lblShoe = New System.Windows.Forms.Label()
        Me.lblQuarter = New System.Windows.Forms.Label()
        Me.cmbQuarter = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblVamps = New System.Windows.Forms.Label()
        Me.cmbVamps = New System.Windows.Forms.ComboBox()
        Me.lblEyestay = New System.Windows.Forms.Label()
        Me.lblHeeltab = New System.Windows.Forms.Label()
        Me.cmbEyestay = New System.Windows.Forms.ComboBox()
        Me.cmbHeeltab = New System.Windows.Forms.ComboBox()
        Me.lblBackcounter = New System.Windows.Forms.Label()
        Me.cmbBackcounter = New System.Windows.Forms.ComboBox()
        Me.cmbLaces = New System.Windows.Forms.ComboBox()
        Me.lblLaces = New System.Windows.Forms.Label()
        Me.rdoLogo = New System.Windows.Forms.RadioButton()
        Me.btnText = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblFull = New System.Windows.Forms.Label()
        Me.btnReciept = New System.Windows.Forms.Button()
        Me.txtShows = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmbShoe
        '
        Me.cmbShoe.FormattingEnabled = True
        Me.cmbShoe.Items.AddRange(New Object() {"Classic Runner", "Vintage Runner", "Retro Runner"})
        Me.cmbShoe.Location = New System.Drawing.Point(191, 45)
        Me.cmbShoe.Name = "cmbShoe"
        Me.cmbShoe.Size = New System.Drawing.Size(121, 21)
        Me.cmbShoe.TabIndex = 0
        '
        'lblShoe
        '
        Me.lblShoe.AutoSize = True
        Me.lblShoe.Location = New System.Drawing.Point(83, 48)
        Me.lblShoe.Name = "lblShoe"
        Me.lblShoe.Size = New System.Drawing.Size(62, 13)
        Me.lblShoe.TabIndex = 1
        Me.lblShoe.Text = "Shoe Type:"
        '
        'lblQuarter
        '
        Me.lblQuarter.AutoSize = True
        Me.lblQuarter.Location = New System.Drawing.Point(83, 92)
        Me.lblQuarter.Name = "lblQuarter"
        Me.lblQuarter.Size = New System.Drawing.Size(42, 13)
        Me.lblQuarter.TabIndex = 2
        Me.lblQuarter.Text = "Quarter"
        '
        'cmbQuarter
        '
        Me.cmbQuarter.FormattingEnabled = True
        Me.cmbQuarter.Items.AddRange(New Object() {"Blue", "Green", "Red", "Orange", "Black"})
        Me.cmbQuarter.Location = New System.Drawing.Point(191, 84)
        Me.cmbQuarter.Name = "cmbQuarter"
        Me.cmbQuarter.Size = New System.Drawing.Size(121, 21)
        Me.cmbQuarter.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(311, 360)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(129, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save Order"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(226, 321)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ReadOnly = True
        Me.txtDisplay.Size = New System.Drawing.Size(214, 20)
        Me.txtDisplay.TabIndex = 5
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(226, 360)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear Selection"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblVamps
        '
        Me.lblVamps.AutoSize = True
        Me.lblVamps.Location = New System.Drawing.Point(83, 136)
        Me.lblVamps.Name = "lblVamps"
        Me.lblVamps.Size = New System.Drawing.Size(39, 13)
        Me.lblVamps.TabIndex = 7
        Me.lblVamps.Text = "Vamps"
        '
        'cmbVamps
        '
        Me.cmbVamps.FormattingEnabled = True
        Me.cmbVamps.Items.AddRange(New Object() {"Blue", "Green", "Red", "Orange", "Black"})
        Me.cmbVamps.Location = New System.Drawing.Point(191, 128)
        Me.cmbVamps.Name = "cmbVamps"
        Me.cmbVamps.Size = New System.Drawing.Size(121, 21)
        Me.cmbVamps.TabIndex = 8
        '
        'lblEyestay
        '
        Me.lblEyestay.AutoSize = True
        Me.lblEyestay.Location = New System.Drawing.Point(83, 174)
        Me.lblEyestay.Name = "lblEyestay"
        Me.lblEyestay.Size = New System.Drawing.Size(44, 13)
        Me.lblEyestay.TabIndex = 9
        Me.lblEyestay.Text = "Eyestay"
        '
        'lblHeeltab
        '
        Me.lblHeeltab.AutoSize = True
        Me.lblHeeltab.Location = New System.Drawing.Point(83, 218)
        Me.lblHeeltab.Name = "lblHeeltab"
        Me.lblHeeltab.Size = New System.Drawing.Size(51, 13)
        Me.lblHeeltab.TabIndex = 10
        Me.lblHeeltab.Text = "Heel Tab"
        '
        'cmbEyestay
        '
        Me.cmbEyestay.FormattingEnabled = True
        Me.cmbEyestay.Items.AddRange(New Object() {"Blue", "Green", "Red", "Orange", "Black"})
        Me.cmbEyestay.Location = New System.Drawing.Point(191, 171)
        Me.cmbEyestay.Name = "cmbEyestay"
        Me.cmbEyestay.Size = New System.Drawing.Size(121, 21)
        Me.cmbEyestay.TabIndex = 11
        '
        'cmbHeeltab
        '
        Me.cmbHeeltab.FormattingEnabled = True
        Me.cmbHeeltab.Items.AddRange(New Object() {"Blue", "Green", "Red", "Orange", "Black"})
        Me.cmbHeeltab.Location = New System.Drawing.Point(191, 218)
        Me.cmbHeeltab.Name = "cmbHeeltab"
        Me.cmbHeeltab.Size = New System.Drawing.Size(121, 21)
        Me.cmbHeeltab.TabIndex = 12
        '
        'lblBackcounter
        '
        Me.lblBackcounter.AutoSize = True
        Me.lblBackcounter.Location = New System.Drawing.Point(86, 264)
        Me.lblBackcounter.Name = "lblBackcounter"
        Me.lblBackcounter.Size = New System.Drawing.Size(99, 13)
        Me.lblBackcounter.TabIndex = 13
        Me.lblBackcounter.Text = "Heel/Back Counter"
        '
        'cmbBackcounter
        '
        Me.cmbBackcounter.FormattingEnabled = True
        Me.cmbBackcounter.Items.AddRange(New Object() {"Blue", "Green", "Red", "Orange", "Black"})
        Me.cmbBackcounter.Location = New System.Drawing.Point(191, 261)
        Me.cmbBackcounter.Name = "cmbBackcounter"
        Me.cmbBackcounter.Size = New System.Drawing.Size(121, 21)
        Me.cmbBackcounter.TabIndex = 14
        '
        'cmbLaces
        '
        Me.cmbLaces.FormattingEnabled = True
        Me.cmbLaces.Items.AddRange(New Object() {"Blue", "Green", "Red", "Orange", "Black"})
        Me.cmbLaces.Location = New System.Drawing.Point(191, 289)
        Me.cmbLaces.Name = "cmbLaces"
        Me.cmbLaces.Size = New System.Drawing.Size(121, 21)
        Me.cmbLaces.TabIndex = 15
        '
        'lblLaces
        '
        Me.lblLaces.AutoSize = True
        Me.lblLaces.Location = New System.Drawing.Point(89, 289)
        Me.lblLaces.Name = "lblLaces"
        Me.lblLaces.Size = New System.Drawing.Size(39, 13)
        Me.lblLaces.TabIndex = 16
        Me.lblLaces.Text = "Laces:"
        '
        'rdoLogo
        '
        Me.rdoLogo.AutoSize = True
        Me.rdoLogo.Location = New System.Drawing.Point(479, 48)
        Me.rdoLogo.Name = "rdoLogo"
        Me.rdoLogo.Size = New System.Drawing.Size(52, 17)
        Me.rdoLogo.TabIndex = 17
        Me.rdoLogo.TabStop = True
        Me.rdoLogo.Text = "Logo:"
        Me.rdoLogo.UseVisualStyleBackColor = True
        '
        'btnText
        '
        Me.btnText.Location = New System.Drawing.Point(479, 92)
        Me.btnText.Name = "btnText"
        Me.btnText.Size = New System.Drawing.Size(75, 23)
        Me.btnText.TabIndex = 18
        Me.btnText.Text = "Text"
        Me.btnText.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(581, 92)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 19
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(594, 133)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(62, 20)
        Me.txtPrice.TabIndex = 20
        '
        'lblFull
        '
        Me.lblFull.AutoSize = True
        Me.lblFull.Location = New System.Drawing.Point(92, 321)
        Me.lblFull.Name = "lblFull"
        Me.lblFull.Size = New System.Drawing.Size(117, 13)
        Me.lblFull.TabIndex = 21
        Me.lblFull.Text = "Price Per Shoe inc. Vat"
        '
        'btnReciept
        '
        Me.btnReciept.Location = New System.Drawing.Point(668, 360)
        Me.btnReciept.Name = "btnReciept"
        Me.btnReciept.Size = New System.Drawing.Size(75, 23)
        Me.btnReciept.TabIndex = 22
        Me.btnReciept.Text = "To Reciept"
        Me.btnReciept.UseVisualStyleBackColor = True
        '
        'txtShows
        '
        Me.txtShows.Location = New System.Drawing.Point(479, 136)
        Me.txtShows.Name = "txtShows"
        Me.txtShows.Size = New System.Drawing.Size(100, 20)
        Me.txtShows.TabIndex = 23
        '
        'frmShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtShows)
        Me.Controls.Add(Me.btnReciept)
        Me.Controls.Add(Me.lblFull)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnText)
        Me.Controls.Add(Me.rdoLogo)
        Me.Controls.Add(Me.lblLaces)
        Me.Controls.Add(Me.cmbLaces)
        Me.Controls.Add(Me.cmbBackcounter)
        Me.Controls.Add(Me.lblBackcounter)
        Me.Controls.Add(Me.cmbHeeltab)
        Me.Controls.Add(Me.cmbEyestay)
        Me.Controls.Add(Me.lblHeeltab)
        Me.Controls.Add(Me.lblEyestay)
        Me.Controls.Add(Me.cmbVamps)
        Me.Controls.Add(Me.lblVamps)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbQuarter)
        Me.Controls.Add(Me.lblQuarter)
        Me.Controls.Add(Me.lblShoe)
        Me.Controls.Add(Me.cmbShoe)
        Me.Name = "frmShop"
        Me.Text = "Shop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbShoe As ComboBox
    Friend WithEvents lblShoe As Label
    Friend WithEvents lblQuarter As Label
    Friend WithEvents cmbQuarter As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents lblVamps As Label
    Friend WithEvents cmbVamps As ComboBox
    Friend WithEvents lblEyestay As Label
    Friend WithEvents lblHeeltab As Label
    Friend WithEvents cmbEyestay As ComboBox
    Friend WithEvents cmbHeeltab As ComboBox
    Friend WithEvents lblBackcounter As Label
    Friend WithEvents cmbBackcounter As ComboBox
    Friend WithEvents cmbLaces As ComboBox
    Friend WithEvents lblLaces As Label
    Friend WithEvents rdoLogo As RadioButton
    Friend WithEvents btnText As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblFull As Label
    Friend WithEvents btnReciept As Button
    Friend WithEvents txtShows As TextBox
End Class
