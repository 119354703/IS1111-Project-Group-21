<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewOrder2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewOrder2))
        Dim ShoeDetailsIDLabel As System.Windows.Forms.Label
        Dim OrderIDLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim QuarterLabel As System.Windows.Forms.Label
        Dim VampLabel As System.Windows.Forms.Label
        Dim EyestayLabel As System.Windows.Forms.Label
        Dim HeelTabLabel As System.Windows.Forms.Label
        Dim HeelBackCounterLabel As System.Windows.Forms.Label
        Dim LacesLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Me.IS1111_Project1DataSet = New IS1111P3.IS1111_Project1DataSet()
        Me.TblOrderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblOrderDetailsTableAdapter = New IS1111P3.IS1111_Project1DataSetTableAdapters.tblOrderDetailsTableAdapter()
        Me.TableAdapterManager = New IS1111P3.IS1111_Project1DataSetTableAdapters.TableAdapterManager()
        Me.TblOrderDetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TblOrderDetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ShoeDetailsIDTextBox = New System.Windows.Forms.TextBox()
        Me.OrderIDTextBox = New System.Windows.Forms.TextBox()
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.QuarterCheckBox = New System.Windows.Forms.CheckBox()
        Me.VampCheckBox = New System.Windows.Forms.CheckBox()
        Me.EyestayCheckBox = New System.Windows.Forms.CheckBox()
        Me.HeelTabCheckBox = New System.Windows.Forms.CheckBox()
        Me.HeelBackCounterCheckBox = New System.Windows.Forms.CheckBox()
        Me.LacesCheckBox = New System.Windows.Forms.CheckBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        ShoeDetailsIDLabel = New System.Windows.Forms.Label()
        OrderIDLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        QuarterLabel = New System.Windows.Forms.Label()
        VampLabel = New System.Windows.Forms.Label()
        EyestayLabel = New System.Windows.Forms.Label()
        HeelTabLabel = New System.Windows.Forms.Label()
        HeelBackCounterLabel = New System.Windows.Forms.Label()
        LacesLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        CType(Me.IS1111_Project1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblOrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblOrderDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblOrderDetailsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IS1111_Project1DataSet
        '
        Me.IS1111_Project1DataSet.DataSetName = "IS1111_Project1DataSet"
        Me.IS1111_Project1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblOrderDetailsBindingSource
        '
        Me.TblOrderDetailsBindingSource.DataMember = "tblOrderDetails"
        Me.TblOrderDetailsBindingSource.DataSource = Me.IS1111_Project1DataSet
        '
        'TblOrderDetailsTableAdapter
        '
        Me.TblOrderDetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_UserTableAdapter = Nothing
        Me.TableAdapterManager.tblCustomerTableAdapter = Nothing
        Me.TableAdapterManager.tblEmployeeTableAdapter = Nothing
        Me.TableAdapterManager.tblOrderDetailsTableAdapter = Me.TblOrderDetailsTableAdapter
        Me.TableAdapterManager.tblOrdersTableAdapter = Nothing
        Me.TableAdapterManager.tblPriceTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = IS1111P3.IS1111_Project1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblOrderDetailsBindingNavigator
        '
        Me.TblOrderDetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblOrderDetailsBindingNavigator.BindingSource = Me.TblOrderDetailsBindingSource
        Me.TblOrderDetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblOrderDetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblOrderDetailsBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TblOrderDetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblOrderDetailsBindingNavigatorSaveItem})
        Me.TblOrderDetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblOrderDetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblOrderDetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblOrderDetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblOrderDetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblOrderDetailsBindingNavigator.Name = "TblOrderDetailsBindingNavigator"
        Me.TblOrderDetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblOrderDetailsBindingNavigator.Size = New System.Drawing.Size(1154, 31)
        Me.TblOrderDetailsBindingNavigator.TabIndex = 0
        Me.TblOrderDetailsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 25)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TblOrderDetailsBindingNavigatorSaveItem
        '
        Me.TblOrderDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblOrderDetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblOrderDetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblOrderDetailsBindingNavigatorSaveItem.Name = "TblOrderDetailsBindingNavigatorSaveItem"
        Me.TblOrderDetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TblOrderDetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ShoeDetailsIDLabel
        '
        ShoeDetailsIDLabel.AutoSize = True
        ShoeDetailsIDLabel.Location = New System.Drawing.Point(17, 212)
        ShoeDetailsIDLabel.Name = "ShoeDetailsIDLabel"
        ShoeDetailsIDLabel.Size = New System.Drawing.Size(125, 20)
        ShoeDetailsIDLabel.TabIndex = 2
        ShoeDetailsIDLabel.Text = "Shoe Details ID:"
        '
        'ShoeDetailsIDTextBox
        '
        Me.ShoeDetailsIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblOrderDetailsBindingSource, "ShoeDetailsID", True))
        Me.ShoeDetailsIDTextBox.Location = New System.Drawing.Point(165, 212)
        Me.ShoeDetailsIDTextBox.Name = "ShoeDetailsIDTextBox"
        Me.ShoeDetailsIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ShoeDetailsIDTextBox.TabIndex = 3
        '
        'OrderIDLabel
        '
        OrderIDLabel.AutoSize = True
        OrderIDLabel.Location = New System.Drawing.Point(17, 244)
        OrderIDLabel.Name = "OrderIDLabel"
        OrderIDLabel.Size = New System.Drawing.Size(74, 20)
        OrderIDLabel.TabIndex = 4
        OrderIDLabel.Text = "Order ID:"
        '
        'OrderIDTextBox
        '
        Me.OrderIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblOrderDetailsBindingSource, "OrderID", True))
        Me.OrderIDTextBox.Location = New System.Drawing.Point(165, 241)
        Me.OrderIDTextBox.Name = "OrderIDTextBox"
        Me.OrderIDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.OrderIDTextBox.TabIndex = 5
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(17, 276)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(56, 20)
        ModelLabel.TabIndex = 6
        ModelLabel.Text = "Model:"
        '
        'ModelTextBox
        '
        Me.ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblOrderDetailsBindingSource, "Model", True))
        Me.ModelTextBox.Location = New System.Drawing.Point(165, 273)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ModelTextBox.TabIndex = 7
        '
        'QuarterLabel
        '
        QuarterLabel.AutoSize = True
        QuarterLabel.Location = New System.Drawing.Point(17, 306)
        QuarterLabel.Name = "QuarterLabel"
        QuarterLabel.Size = New System.Drawing.Size(67, 20)
        QuarterLabel.TabIndex = 8
        QuarterLabel.Text = "Quarter:"
        '
        'QuarterCheckBox
        '
        Me.QuarterCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblOrderDetailsBindingSource, "Quarter", True))
        Me.QuarterCheckBox.Location = New System.Drawing.Point(165, 305)
        Me.QuarterCheckBox.Name = "QuarterCheckBox"
        Me.QuarterCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.QuarterCheckBox.TabIndex = 9
        Me.QuarterCheckBox.Text = "CheckBox1"
        Me.QuarterCheckBox.UseVisualStyleBackColor = True
        '
        'VampLabel
        '
        VampLabel.AutoSize = True
        VampLabel.Location = New System.Drawing.Point(17, 336)
        VampLabel.Name = "VampLabel"
        VampLabel.Size = New System.Drawing.Size(55, 20)
        VampLabel.TabIndex = 10
        VampLabel.Text = "Vamp:"
        '
        'VampCheckBox
        '
        Me.VampCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblOrderDetailsBindingSource, "Vamp", True))
        Me.VampCheckBox.Location = New System.Drawing.Point(165, 335)
        Me.VampCheckBox.Name = "VampCheckBox"
        Me.VampCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.VampCheckBox.TabIndex = 11
        Me.VampCheckBox.Text = "CheckBox1"
        Me.VampCheckBox.UseVisualStyleBackColor = True
        '
        'EyestayLabel
        '
        EyestayLabel.AutoSize = True
        EyestayLabel.Location = New System.Drawing.Point(17, 366)
        EyestayLabel.Name = "EyestayLabel"
        EyestayLabel.Size = New System.Drawing.Size(69, 20)
        EyestayLabel.TabIndex = 12
        EyestayLabel.Text = "Eyestay:"
        '
        'EyestayCheckBox
        '
        Me.EyestayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblOrderDetailsBindingSource, "Eyestay", True))
        Me.EyestayCheckBox.Location = New System.Drawing.Point(165, 365)
        Me.EyestayCheckBox.Name = "EyestayCheckBox"
        Me.EyestayCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.EyestayCheckBox.TabIndex = 13
        Me.EyestayCheckBox.Text = "CheckBox1"
        Me.EyestayCheckBox.UseVisualStyleBackColor = True
        '
        'HeelTabLabel
        '
        HeelTabLabel.AutoSize = True
        HeelTabLabel.Location = New System.Drawing.Point(17, 395)
        HeelTabLabel.Name = "HeelTabLabel"
        HeelTabLabel.Size = New System.Drawing.Size(77, 20)
        HeelTabLabel.TabIndex = 14
        HeelTabLabel.Text = "Heel Tab:"
        '
        'HeelTabCheckBox
        '
        Me.HeelTabCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblOrderDetailsBindingSource, "HeelTab", True))
        Me.HeelTabCheckBox.Location = New System.Drawing.Point(165, 394)
        Me.HeelTabCheckBox.Name = "HeelTabCheckBox"
        Me.HeelTabCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.HeelTabCheckBox.TabIndex = 15
        Me.HeelTabCheckBox.Text = "CheckBox1"
        Me.HeelTabCheckBox.UseVisualStyleBackColor = True
        '
        'HeelBackCounterLabel
        '
        HeelBackCounterLabel.AutoSize = True
        HeelBackCounterLabel.Location = New System.Drawing.Point(17, 426)
        HeelBackCounterLabel.Name = "HeelBackCounterLabel"
        HeelBackCounterLabel.Size = New System.Drawing.Size(147, 20)
        HeelBackCounterLabel.TabIndex = 16
        HeelBackCounterLabel.Text = "Heel Back Counter:"
        '
        'HeelBackCounterCheckBox
        '
        Me.HeelBackCounterCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblOrderDetailsBindingSource, "HeelBackCounter", True))
        Me.HeelBackCounterCheckBox.Location = New System.Drawing.Point(165, 425)
        Me.HeelBackCounterCheckBox.Name = "HeelBackCounterCheckBox"
        Me.HeelBackCounterCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.HeelBackCounterCheckBox.TabIndex = 17
        Me.HeelBackCounterCheckBox.Text = "CheckBox1"
        Me.HeelBackCounterCheckBox.UseVisualStyleBackColor = True
        '
        'LacesLabel
        '
        LacesLabel.AutoSize = True
        LacesLabel.Location = New System.Drawing.Point(17, 456)
        LacesLabel.Name = "LacesLabel"
        LacesLabel.Size = New System.Drawing.Size(56, 20)
        LacesLabel.TabIndex = 18
        LacesLabel.Text = "Laces:"
        '
        'LacesCheckBox
        '
        Me.LacesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblOrderDetailsBindingSource, "Laces", True))
        Me.LacesCheckBox.Location = New System.Drawing.Point(165, 455)
        Me.LacesCheckBox.Name = "LacesCheckBox"
        Me.LacesCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.LacesCheckBox.TabIndex = 19
        Me.LacesCheckBox.Text = "CheckBox1"
        Me.LacesCheckBox.UseVisualStyleBackColor = True
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(17, 488)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(72, 20)
        QuantityLabel.TabIndex = 20
        QuantityLabel.Text = "Quantity:"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblOrderDetailsBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(165, 485)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(100, 26)
        Me.QuantityTextBox.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 521)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 34)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(165, 521)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 34)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmNewOrder2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 593)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(LacesLabel)
        Me.Controls.Add(Me.LacesCheckBox)
        Me.Controls.Add(HeelBackCounterLabel)
        Me.Controls.Add(Me.HeelBackCounterCheckBox)
        Me.Controls.Add(HeelTabLabel)
        Me.Controls.Add(Me.HeelTabCheckBox)
        Me.Controls.Add(EyestayLabel)
        Me.Controls.Add(Me.EyestayCheckBox)
        Me.Controls.Add(VampLabel)
        Me.Controls.Add(Me.VampCheckBox)
        Me.Controls.Add(QuarterLabel)
        Me.Controls.Add(Me.QuarterCheckBox)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(Me.ModelTextBox)
        Me.Controls.Add(OrderIDLabel)
        Me.Controls.Add(Me.OrderIDTextBox)
        Me.Controls.Add(ShoeDetailsIDLabel)
        Me.Controls.Add(Me.ShoeDetailsIDTextBox)
        Me.Controls.Add(Me.TblOrderDetailsBindingNavigator)
        Me.Name = "frmNewOrder2"
        Me.Text = "frmNewOrder2"
        CType(Me.IS1111_Project1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblOrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblOrderDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblOrderDetailsBindingNavigator.ResumeLayout(False)
        Me.TblOrderDetailsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IS1111_Project1DataSet As IS1111_Project1DataSet
    Friend WithEvents TblOrderDetailsBindingSource As BindingSource
    Friend WithEvents TblOrderDetailsTableAdapter As IS1111_Project1DataSetTableAdapters.tblOrderDetailsTableAdapter
    Friend WithEvents TableAdapterManager As IS1111_Project1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblOrderDetailsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblOrderDetailsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ShoeDetailsIDTextBox As TextBox
    Friend WithEvents OrderIDTextBox As TextBox
    Friend WithEvents ModelTextBox As TextBox
    Friend WithEvents QuarterCheckBox As CheckBox
    Friend WithEvents VampCheckBox As CheckBox
    Friend WithEvents EyestayCheckBox As CheckBox
    Friend WithEvents HeelTabCheckBox As CheckBox
    Friend WithEvents HeelBackCounterCheckBox As CheckBox
    Friend WithEvents LacesCheckBox As CheckBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
