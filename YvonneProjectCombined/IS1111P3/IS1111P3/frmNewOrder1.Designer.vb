<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewOrder1
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
        Dim ModelLabel As System.Windows.Forms.Label
        Dim QuarterLabel As System.Windows.Forms.Label
        Dim VampLabel As System.Windows.Forms.Label
        Dim EyestayLabel As System.Windows.Forms.Label
        Dim HeelTabLabel As System.Windows.Forms.Label
        Dim HeelBackCounterLabel As System.Windows.Forms.Label
        Dim LacesLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewOrder1))
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IS1111_Project1DataSet = New IS1111P3.IS1111_Project1DataSet()
        Me.TblOrderDetailsTableAdapter = New IS1111P3.IS1111_Project1DataSetTableAdapters.tblOrderDetailsTableAdapter()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TableAdapterManager = New IS1111P3.IS1111_Project1DataSetTableAdapters.TableAdapterManager()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.cmbQuarter = New System.Windows.Forms.ComboBox()
        Me.cmbVamp = New System.Windows.Forms.ComboBox()
        Me.cmbEyestay = New System.Windows.Forms.ComboBox()
        Me.cmbHeeltab = New System.Windows.Forms.ComboBox()
        Me.cmbBackCounter = New System.Windows.Forms.ComboBox()
        Me.cmbLaces = New System.Windows.Forms.ComboBox()
        Me.btnViewOrder = New System.Windows.Forms.Button()
        Me.lblWriting = New System.Windows.Forms.Label()
        Me.btnText = New System.Windows.Forms.Button()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.txtShows = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.rdoLogo = New System.Windows.Forms.RadioButton()
        Me.lblLogo = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        QuarterLabel = New System.Windows.Forms.Label()
        VampLabel = New System.Windows.Forms.Label()
        EyestayLabel = New System.Windows.Forms.Label()
        HeelTabLabel = New System.Windows.Forms.Label()
        HeelBackCounterLabel = New System.Windows.Forms.Label()
        LacesLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IS1111_Project1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(48, 37)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(333, 18)
        ModelLabel.TabIndex = 1
        ModelLabel.Text = "Model (Classic €54.99, Retro €49.50, Vintage €44.99."
        '
        'QuarterLabel
        '
        QuarterLabel.AutoSize = True
        QuarterLabel.Location = New System.Drawing.Point(48, 80)
        QuarterLabel.Name = "QuarterLabel"
        QuarterLabel.Size = New System.Drawing.Size(95, 18)
        QuarterLabel.TabIndex = 3
        QuarterLabel.Text = "Quarter €8.99"
        '
        'VampLabel
        '
        VampLabel.AutoSize = True
        VampLabel.Location = New System.Drawing.Point(48, 119)
        VampLabel.Name = "VampLabel"
        VampLabel.Size = New System.Drawing.Size(91, 18)
        VampLabel.TabIndex = 5
        VampLabel.Text = "Vamp €14.99"
        '
        'EyestayLabel
        '
        EyestayLabel.AutoSize = True
        EyestayLabel.Location = New System.Drawing.Point(48, 157)
        EyestayLabel.Name = "EyestayLabel"
        EyestayLabel.Size = New System.Drawing.Size(93, 18)
        EyestayLabel.TabIndex = 7
        EyestayLabel.Text = "Eyestay €5.00"
        '
        'HeelTabLabel
        '
        HeelTabLabel.AutoSize = True
        HeelTabLabel.Location = New System.Drawing.Point(48, 203)
        HeelTabLabel.Name = "HeelTabLabel"
        HeelTabLabel.Size = New System.Drawing.Size(100, 18)
        HeelTabLabel.TabIndex = 9
        HeelTabLabel.Text = "Heel Tab €4.99"
        '
        'HeelBackCounterLabel
        '
        HeelBackCounterLabel.AutoSize = True
        HeelBackCounterLabel.Location = New System.Drawing.Point(48, 242)
        HeelBackCounterLabel.Name = "HeelBackCounterLabel"
        HeelBackCounterLabel.Size = New System.Drawing.Size(161, 18)
        HeelBackCounterLabel.TabIndex = 11
        HeelBackCounterLabel.Text = "Heel/Back Counter €6.49"
        '
        'LacesLabel
        '
        LacesLabel.AutoSize = True
        LacesLabel.Location = New System.Drawing.Point(48, 281)
        LacesLabel.Name = "LacesLabel"
        LacesLabel.Size = New System.Drawing.Size(80, 18)
        LacesLabel.TabIndex = 13
        LacesLabel.Text = "Laces €4.00"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(48, 320)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(65, 18)
        QuantityLabel.TabIndex = 15
        QuantityLabel.Text = "Quantity:"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblOrderDetails"
        Me.BindingSource1.DataSource = Me.IS1111_Project1DataSet
        '
        'IS1111_Project1DataSet
        '
        Me.IS1111_Project1DataSet.DataSetName = "IS1111_Project1DataSet"
        Me.IS1111_Project1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblOrderDetailsTableAdapter
        '
        Me.TblOrderDetailsTableAdapter.ClearBeforeFill = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.BindingSource1
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(904, 31)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Enabled = False
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Enabled = False
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton1.Text = "Update"
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
        'txtModel
        '
        Me.txtModel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Model", True))
        Me.txtModel.Location = New System.Drawing.Point(413, 37)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 24)
        Me.txtModel.TabIndex = 2
        '
        'txtQuantity
        '
        Me.txtQuantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Quantity", True))
        Me.txtQuantity.Location = New System.Drawing.Point(281, 320)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(184, 24)
        Me.txtQuantity.TabIndex = 16
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(186, 406)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 33)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Order"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(53, 406)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(112, 33)
        Me.btnReturn.TabIndex = 19
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(53, 366)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(112, 33)
        Me.btnCalculate.TabIndex = 20
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(186, 367)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 24)
        Me.txtSubtotal.TabIndex = 21
        '
        'cmbQuarter
        '
        Me.cmbQuarter.FormattingEnabled = True
        Me.cmbQuarter.Items.AddRange(New Object() {"White", "Black", "Red", "Green", "Blue"})
        Me.cmbQuarter.Location = New System.Drawing.Point(344, 76)
        Me.cmbQuarter.Name = "cmbQuarter"
        Me.cmbQuarter.Size = New System.Drawing.Size(121, 24)
        Me.cmbQuarter.TabIndex = 22
        Me.cmbQuarter.Text = "White"
        '
        'cmbVamp
        '
        Me.cmbVamp.FormattingEnabled = True
        Me.cmbVamp.Items.AddRange(New Object() {"White", "Black", "Red", "Green", "Blue"})
        Me.cmbVamp.Location = New System.Drawing.Point(344, 115)
        Me.cmbVamp.Name = "cmbVamp"
        Me.cmbVamp.Size = New System.Drawing.Size(121, 24)
        Me.cmbVamp.TabIndex = 23
        Me.cmbVamp.Text = "White"
        '
        'cmbEyestay
        '
        Me.cmbEyestay.FormattingEnabled = True
        Me.cmbEyestay.Items.AddRange(New Object() {"White", "Black", "Red", "Green", "Blue"})
        Me.cmbEyestay.Location = New System.Drawing.Point(344, 154)
        Me.cmbEyestay.Name = "cmbEyestay"
        Me.cmbEyestay.Size = New System.Drawing.Size(121, 24)
        Me.cmbEyestay.TabIndex = 24
        Me.cmbEyestay.Text = "White"
        '
        'cmbHeeltab
        '
        Me.cmbHeeltab.FormattingEnabled = True
        Me.cmbHeeltab.Items.AddRange(New Object() {"White", "Black", "Red", "Green", "Blue"})
        Me.cmbHeeltab.Location = New System.Drawing.Point(344, 199)
        Me.cmbHeeltab.Name = "cmbHeeltab"
        Me.cmbHeeltab.Size = New System.Drawing.Size(121, 24)
        Me.cmbHeeltab.TabIndex = 25
        Me.cmbHeeltab.Text = "White"
        '
        'cmbBackCounter
        '
        Me.cmbBackCounter.FormattingEnabled = True
        Me.cmbBackCounter.Items.AddRange(New Object() {"White", "Black", "Red", "Green", "Blue"})
        Me.cmbBackCounter.Location = New System.Drawing.Point(344, 238)
        Me.cmbBackCounter.Name = "cmbBackCounter"
        Me.cmbBackCounter.Size = New System.Drawing.Size(121, 24)
        Me.cmbBackCounter.TabIndex = 26
        Me.cmbBackCounter.Text = "White"
        '
        'cmbLaces
        '
        Me.cmbLaces.FormattingEnabled = True
        Me.cmbLaces.Items.AddRange(New Object() {"White", "Black", "Red", "Green", "Blue"})
        Me.cmbLaces.Location = New System.Drawing.Point(344, 277)
        Me.cmbLaces.Name = "cmbLaces"
        Me.cmbLaces.Size = New System.Drawing.Size(121, 24)
        Me.cmbLaces.TabIndex = 27
        Me.cmbLaces.Text = "White"
        '
        'btnViewOrder
        '
        Me.btnViewOrder.Location = New System.Drawing.Point(317, 406)
        Me.btnViewOrder.Name = "btnViewOrder"
        Me.btnViewOrder.Size = New System.Drawing.Size(148, 33)
        Me.btnViewOrder.TabIndex = 28
        Me.btnViewOrder.Text = "View Order"
        Me.btnViewOrder.UseVisualStyleBackColor = True
        '
        'lblWriting
        '
        Me.lblWriting.AutoSize = True
        Me.lblWriting.Location = New System.Drawing.Point(574, 76)
        Me.lblWriting.Name = "lblWriting"
        Me.lblWriting.Size = New System.Drawing.Size(156, 18)
        Me.lblWriting.TabIndex = 29
        Me.lblWriting.Text = "Writing €0.45 Per Letter"
        '
        'btnText
        '
        Me.btnText.Location = New System.Drawing.Point(577, 98)
        Me.btnText.Name = "btnText"
        Me.btnText.Size = New System.Drawing.Size(75, 23)
        Me.btnText.TabIndex = 30
        Me.btnText.Text = "Text"
        Me.btnText.UseVisualStyleBackColor = True
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(684, 98)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(113, 23)
        Me.btnCount.TabIndex = 31
        Me.btnCount.Text = "Calculate Sum"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'txtShows
        '
        Me.txtShows.Location = New System.Drawing.Point(577, 143)
        Me.txtShows.Name = "txtShows"
        Me.txtShows.ReadOnly = True
        Me.txtShows.Size = New System.Drawing.Size(100, 24)
        Me.txtShows.TabIndex = 32
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(710, 143)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(69, 24)
        Me.txtPrice.TabIndex = 33
        '
        'rdoLogo
        '
        Me.rdoLogo.AutoSize = True
        Me.rdoLogo.Location = New System.Drawing.Point(669, 232)
        Me.rdoLogo.Name = "rdoLogo"
        Me.rdoLogo.Size = New System.Drawing.Size(57, 22)
        Me.rdoLogo.TabIndex = 34
        Me.rdoLogo.TabStop = True
        Me.rdoLogo.Text = "Logo"
        Me.rdoLogo.UseVisualStyleBackColor = True
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Location = New System.Drawing.Point(574, 235)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(46, 18)
        Me.lblLogo.TabIndex = 35
        Me.lblLogo.Text = "Logo: "
        '
        'frmNewOrder1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 451)
        Me.Controls.Add(Me.lblLogo)
        Me.Controls.Add(Me.rdoLogo)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtShows)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.btnText)
        Me.Controls.Add(Me.lblWriting)
        Me.Controls.Add(Me.btnViewOrder)
        Me.Controls.Add(Me.cmbLaces)
        Me.Controls.Add(Me.cmbBackCounter)
        Me.Controls.Add(Me.cmbHeeltab)
        Me.Controls.Add(Me.cmbEyestay)
        Me.Controls.Add(Me.cmbVamp)
        Me.Controls.Add(Me.cmbQuarter)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(LacesLabel)
        Me.Controls.Add(HeelBackCounterLabel)
        Me.Controls.Add(HeelTabLabel)
        Me.Controls.Add(EyestayLabel)
        Me.Controls.Add(VampLabel)
        Me.Controls.Add(QuarterLabel)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmNewOrder1"
        Me.Text = "NewOrder"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IS1111_Project1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents IS1111_Project1DataSet As IS1111_Project1DataSet
    Friend WithEvents TblOrderDetailsTableAdapter As IS1111_Project1DataSetTableAdapters.tblOrderDetailsTableAdapter
    Friend WithEvents BindingNavigator1 As BindingNavigator
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
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents TableAdapterManager As IS1111_Project1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents cmbQuarter As ComboBox
    Friend WithEvents cmbVamp As ComboBox
    Friend WithEvents cmbEyestay As ComboBox
    Friend WithEvents cmbHeeltab As ComboBox
    Friend WithEvents cmbBackCounter As ComboBox
    Friend WithEvents cmbLaces As ComboBox
    Friend WithEvents btnViewOrder As Button
    Friend WithEvents lblWriting As Label
    Friend WithEvents btnText As Button
    Friend WithEvents btnCount As Button
    Friend WithEvents txtShows As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents rdoLogo As RadioButton
    Friend WithEvents lblLogo As Label
End Class
