<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.chbText = New System.Windows.Forms.CheckBox()
        Me.frmPlaceOrder = New System.Windows.Forms.Button()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblQuantuty = New System.Windows.Forms.Label()
        Me.cmbLaces = New System.Windows.Forms.ComboBox()
        Me.cmbHeelBackCounter = New System.Windows.Forms.ComboBox()
        Me.cmbHeelTab = New System.Windows.Forms.ComboBox()
        Me.cmbEyestay = New System.Windows.Forms.ComboBox()
        Me.cmbVamp = New System.Windows.Forms.ComboBox()
        Me.cmbQuarter = New System.Windows.Forms.ComboBox()
        Me.chbLogo = New System.Windows.Forms.CheckBox()
        Me.chbLaces = New System.Windows.Forms.CheckBox()
        Me.chbHeelBackCounter = New System.Windows.Forms.CheckBox()
        Me.chbHeelTab = New System.Windows.Forms.CheckBox()
        Me.chbEyestay = New System.Windows.Forms.CheckBox()
        Me.chbVamp = New System.Windows.Forms.CheckBox()
        Me.chbQuarter = New System.Windows.Forms.CheckBox()
        Me.grbStyle = New System.Windows.Forms.GroupBox()
        Me.rdbVintage = New System.Windows.Forms.RadioButton()
        Me.rdbRetro = New System.Windows.Forms.RadioButton()
        Me.rdbClassic = New System.Windows.Forms.RadioButton()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IS1111_Project1DataSet = New IS1111P3.IS1111_Project1DataSet()
        Me.TblOrdersTableAdapter = New IS1111P3.IS1111_Project1DataSetTableAdapters.tblOrdersTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblOrderDetailsTableAdapter = New IS1111P3.IS1111_Project1DataSetTableAdapters.tblOrderDetailsTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grbStyle.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IS1111_Project1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(410, 413)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 33)
        Me.TextBox1.TabIndex = 42
        '
        'chbText
        '
        Me.chbText.AutoSize = True
        Me.chbText.Location = New System.Drawing.Point(57, 415)
        Me.chbText.Name = "chbText"
        Me.chbText.Size = New System.Drawing.Size(74, 29)
        Me.chbText.TabIndex = 41
        Me.chbText.Text = "Text"
        Me.chbText.UseVisualStyleBackColor = True
        '
        'frmPlaceOrder
        '
        Me.frmPlaceOrder.Location = New System.Drawing.Point(410, 507)
        Me.frmPlaceOrder.Name = "frmPlaceOrder"
        Me.frmPlaceOrder.Size = New System.Drawing.Size(146, 34)
        Me.frmPlaceOrder.TabIndex = 40
        Me.frmPlaceOrder.Text = "Place Order"
        Me.frmPlaceOrder.UseVisualStyleBackColor = True
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(200, 507)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(121, 33)
        Me.txtSubtotal.TabIndex = 39
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(57, 507)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(137, 34)
        Me.btnCalculate.TabIndex = 38
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(157, 446)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtQuantity.Size = New System.Drawing.Size(37, 33)
        Me.txtQuantity.TabIndex = 37
        Me.txtQuantity.Text = "1"
        '
        'lblQuantuty
        '
        Me.lblQuantuty.AutoSize = True
        Me.lblQuantuty.Location = New System.Drawing.Point(52, 449)
        Me.lblQuantuty.Name = "lblQuantuty"
        Me.lblQuantuty.Size = New System.Drawing.Size(88, 25)
        Me.lblQuantuty.TabIndex = 36
        Me.lblQuantuty.Text = "Quantity"
        '
        'cmbLaces
        '
        Me.cmbLaces.FormattingEnabled = True
        Me.cmbLaces.Items.AddRange(New Object() {"White", "Blue", "Red", "Yellow", "Pink", "Black"})
        Me.cmbLaces.Location = New System.Drawing.Point(410, 335)
        Me.cmbLaces.Name = "cmbLaces"
        Me.cmbLaces.Size = New System.Drawing.Size(146, 33)
        Me.cmbLaces.TabIndex = 35
        Me.cmbLaces.Text = "White"
        '
        'cmbHeelBackCounter
        '
        Me.cmbHeelBackCounter.FormattingEnabled = True
        Me.cmbHeelBackCounter.Items.AddRange(New Object() {"White", "Blue", "Red", "Yellow", "Pink", "Black"})
        Me.cmbHeelBackCounter.Location = New System.Drawing.Point(410, 294)
        Me.cmbHeelBackCounter.Name = "cmbHeelBackCounter"
        Me.cmbHeelBackCounter.Size = New System.Drawing.Size(146, 33)
        Me.cmbHeelBackCounter.TabIndex = 34
        Me.cmbHeelBackCounter.Text = "White"
        '
        'cmbHeelTab
        '
        Me.cmbHeelTab.FormattingEnabled = True
        Me.cmbHeelTab.Items.AddRange(New Object() {"White", "Blue", "Red", "Yellow", "Pink", "Black"})
        Me.cmbHeelTab.Location = New System.Drawing.Point(410, 253)
        Me.cmbHeelTab.Name = "cmbHeelTab"
        Me.cmbHeelTab.Size = New System.Drawing.Size(146, 33)
        Me.cmbHeelTab.TabIndex = 33
        Me.cmbHeelTab.Text = "White"
        '
        'cmbEyestay
        '
        Me.cmbEyestay.FormattingEnabled = True
        Me.cmbEyestay.Items.AddRange(New Object() {"White", "Blue", "Red", "Yellow", "Pink", "Black"})
        Me.cmbEyestay.Location = New System.Drawing.Point(410, 212)
        Me.cmbEyestay.Name = "cmbEyestay"
        Me.cmbEyestay.Size = New System.Drawing.Size(146, 33)
        Me.cmbEyestay.TabIndex = 32
        Me.cmbEyestay.Text = "White"
        '
        'cmbVamp
        '
        Me.cmbVamp.FormattingEnabled = True
        Me.cmbVamp.Items.AddRange(New Object() {"White", "Blue", "Red", "Yellow", "Pink", "Black"})
        Me.cmbVamp.Location = New System.Drawing.Point(410, 171)
        Me.cmbVamp.Name = "cmbVamp"
        Me.cmbVamp.Size = New System.Drawing.Size(146, 33)
        Me.cmbVamp.TabIndex = 31
        Me.cmbVamp.Text = "White"
        '
        'cmbQuarter
        '
        Me.cmbQuarter.FormattingEnabled = True
        Me.cmbQuarter.Items.AddRange(New Object() {"White", "Blue", "Red", "Yellow", "Pink", "Black"})
        Me.cmbQuarter.Location = New System.Drawing.Point(410, 130)
        Me.cmbQuarter.Name = "cmbQuarter"
        Me.cmbQuarter.Size = New System.Drawing.Size(146, 33)
        Me.cmbQuarter.TabIndex = 30
        Me.cmbQuarter.Text = "White"
        '
        'chbLogo
        '
        Me.chbLogo.AutoSize = True
        Me.chbLogo.Location = New System.Drawing.Point(57, 378)
        Me.chbLogo.Name = "chbLogo"
        Me.chbLogo.Size = New System.Drawing.Size(318, 29)
        Me.chbLogo.TabIndex = 29
        Me.chbLogo.Text = "Logo (18% of custimzation cost)"
        Me.chbLogo.UseVisualStyleBackColor = True
        '
        'chbLaces
        '
        Me.chbLaces.AutoSize = True
        Me.chbLaces.Location = New System.Drawing.Point(57, 337)
        Me.chbLaces.Name = "chbLaces"
        Me.chbLaces.Size = New System.Drawing.Size(149, 29)
        Me.chbLaces.TabIndex = 28
        Me.chbLaces.Text = "Laces ($4.00)"
        Me.chbLaces.UseVisualStyleBackColor = True
        '
        'chbHeelBackCounter
        '
        Me.chbHeelBackCounter.AutoSize = True
        Me.chbHeelBackCounter.Location = New System.Drawing.Point(57, 296)
        Me.chbHeelBackCounter.Name = "chbHeelBackCounter"
        Me.chbHeelBackCounter.Size = New System.Drawing.Size(265, 29)
        Me.chbHeelBackCounter.TabIndex = 27
        Me.chbHeelBackCounter.Text = "Heel/Back Counter ($6.49)"
        Me.chbHeelBackCounter.UseVisualStyleBackColor = True
        '
        'chbHeelTab
        '
        Me.chbHeelTab.AutoSize = True
        Me.chbHeelTab.Location = New System.Drawing.Point(57, 255)
        Me.chbHeelTab.Name = "chbHeelTab"
        Me.chbHeelTab.Size = New System.Drawing.Size(179, 29)
        Me.chbHeelTab.TabIndex = 26
        Me.chbHeelTab.Text = "Heel Tab ($4.99)"
        Me.chbHeelTab.UseVisualStyleBackColor = True
        '
        'chbEyestay
        '
        Me.chbEyestay.AutoSize = True
        Me.chbEyestay.Location = New System.Drawing.Point(57, 214)
        Me.chbEyestay.Name = "chbEyestay"
        Me.chbEyestay.Size = New System.Drawing.Size(163, 29)
        Me.chbEyestay.TabIndex = 25
        Me.chbEyestay.Text = "Eyestay($5.00)"
        Me.chbEyestay.UseVisualStyleBackColor = True
        '
        'chbVamp
        '
        Me.chbVamp.AutoSize = True
        Me.chbVamp.Location = New System.Drawing.Point(57, 173)
        Me.chbVamp.Name = "chbVamp"
        Me.chbVamp.Size = New System.Drawing.Size(160, 29)
        Me.chbVamp.TabIndex = 24
        Me.chbVamp.Text = "Vamp($14.99)"
        Me.chbVamp.UseVisualStyleBackColor = True
        '
        'chbQuarter
        '
        Me.chbQuarter.AutoSize = True
        Me.chbQuarter.Location = New System.Drawing.Point(57, 132)
        Me.chbQuarter.Name = "chbQuarter"
        Me.chbQuarter.Size = New System.Drawing.Size(165, 29)
        Me.chbQuarter.TabIndex = 23
        Me.chbQuarter.Text = "Quarter($8.99)"
        Me.chbQuarter.UseVisualStyleBackColor = True
        '
        'grbStyle
        '
        Me.grbStyle.Controls.Add(Me.rdbVintage)
        Me.grbStyle.Controls.Add(Me.rdbRetro)
        Me.grbStyle.Controls.Add(Me.rdbClassic)
        Me.grbStyle.Location = New System.Drawing.Point(48, 24)
        Me.grbStyle.Name = "grbStyle"
        Me.grbStyle.Size = New System.Drawing.Size(631, 88)
        Me.grbStyle.TabIndex = 22
        Me.grbStyle.TabStop = False
        Me.grbStyle.Text = "Shoe Style"
        '
        'rdbVintage
        '
        Me.rdbVintage.AutoSize = True
        Me.rdbVintage.Location = New System.Drawing.Point(399, 33)
        Me.rdbVintage.Name = "rdbVintage"
        Me.rdbVintage.Size = New System.Drawing.Size(175, 29)
        Me.rdbVintage.TabIndex = 2
        Me.rdbVintage.TabStop = True
        Me.rdbVintage.Text = "Vintage($44.99)"
        Me.rdbVintage.UseVisualStyleBackColor = True
        '
        'rdbRetro
        '
        Me.rdbRetro.AutoSize = True
        Me.rdbRetro.Location = New System.Drawing.Point(221, 34)
        Me.rdbRetro.Name = "rdbRetro"
        Me.rdbRetro.Size = New System.Drawing.Size(161, 29)
        Me.rdbRetro.TabIndex = 1
        Me.rdbRetro.TabStop = True
        Me.rdbRetro.Text = "Retro ($49.50)"
        Me.rdbRetro.UseVisualStyleBackColor = True
        '
        'rdbClassic
        '
        Me.rdbClassic.AutoSize = True
        Me.rdbClassic.Location = New System.Drawing.Point(33, 34)
        Me.rdbClassic.Name = "rdbClassic"
        Me.rdbClassic.Size = New System.Drawing.Size(170, 29)
        Me.rdbClassic.TabIndex = 0
        Me.rdbClassic.TabStop = True
        Me.rdbClassic.Text = "Classic ($54.49)"
        Me.rdbClassic.UseVisualStyleBackColor = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblOrders"
        Me.BindingSource1.DataSource = Me.IS1111_Project1DataSet
        '
        'IS1111_Project1DataSet
        '
        Me.IS1111_Project1DataSet.DataSetName = "IS1111_Project1DataSet"
        Me.IS1111_Project1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblOrdersTableAdapter
        '
        Me.TblOrdersTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(578, 507)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 33)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "tblOrderDetails"
        Me.BindingSource2.DataSource = Me.IS1111_Project1DataSet
        '
        'TblOrderDetailsTableAdapter
        '
        Me.TblOrderDetailsTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(668, 402)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Return"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmNewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 562)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.chbText)
        Me.Controls.Add(Me.frmPlaceOrder)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblQuantuty)
        Me.Controls.Add(Me.cmbLaces)
        Me.Controls.Add(Me.cmbHeelBackCounter)
        Me.Controls.Add(Me.cmbHeelTab)
        Me.Controls.Add(Me.cmbEyestay)
        Me.Controls.Add(Me.cmbVamp)
        Me.Controls.Add(Me.cmbQuarter)
        Me.Controls.Add(Me.chbLogo)
        Me.Controls.Add(Me.chbLaces)
        Me.Controls.Add(Me.chbHeelBackCounter)
        Me.Controls.Add(Me.chbHeelTab)
        Me.Controls.Add(Me.chbEyestay)
        Me.Controls.Add(Me.chbVamp)
        Me.Controls.Add(Me.chbQuarter)
        Me.Controls.Add(Me.grbStyle)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmNewOrder"
        Me.Text = "NewOrder"
        Me.grbStyle.ResumeLayout(False)
        Me.grbStyle.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IS1111_Project1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents chbText As CheckBox
    Friend WithEvents frmPlaceOrder As Button
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantuty As Label
    Friend WithEvents cmbLaces As ComboBox
    Friend WithEvents cmbHeelBackCounter As ComboBox
    Friend WithEvents cmbHeelTab As ComboBox
    Friend WithEvents cmbEyestay As ComboBox
    Friend WithEvents cmbVamp As ComboBox
    Friend WithEvents cmbQuarter As ComboBox
    Friend WithEvents chbLogo As CheckBox
    Friend WithEvents chbLaces As CheckBox
    Friend WithEvents chbHeelBackCounter As CheckBox
    Friend WithEvents chbHeelTab As CheckBox
    Friend WithEvents chbEyestay As CheckBox
    Friend WithEvents chbVamp As CheckBox
    Friend WithEvents chbQuarter As CheckBox
    Friend WithEvents grbStyle As GroupBox
    Friend WithEvents rdbVintage As RadioButton
    Friend WithEvents rdbRetro As RadioButton
    Friend WithEvents rdbClassic As RadioButton
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents IS1111_Project1DataSet As IS1111_Project1DataSet
    Friend WithEvents TblOrdersTableAdapter As IS1111_Project1DataSetTableAdapters.tblOrdersTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents TblOrderDetailsTableAdapter As IS1111_Project1DataSetTableAdapters.tblOrderDetailsTableAdapter
    Friend WithEvents Button2 As Button
End Class
