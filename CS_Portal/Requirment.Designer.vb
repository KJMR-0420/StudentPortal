<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Requirment
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
        Dim StudentNoLabel As System.Windows.Forms.Label
        Dim Form138Label As System.Windows.Forms.Label
        Dim Certificate_Of_GraduationLabel As System.Windows.Forms.Label
        Dim NSOLabel As System.Windows.Forms.Label
        Dim Certificate_Of_Good_MoralLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Requirment))
        Me.RequirmentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.RequirmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequirmentDataSet = New CS_Portal.requirmentDataSet()
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
        Me.RequirmentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StudentNoTextBox = New System.Windows.Forms.TextBox()
        Me.Form138CheckBox = New System.Windows.Forms.CheckBox()
        Me.Certificate_Of_GraduationCheckBox = New System.Windows.Forms.CheckBox()
        Me.NSOCheckBox = New System.Windows.Forms.CheckBox()
        Me.Certificate_Of_Good_MoralCheckBox = New System.Windows.Forms.CheckBox()
        Me.RequirmentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RequirmentTableAdapter = New CS_Portal.requirmentDataSetTableAdapters.RequirmentTableAdapter()
        Me.TableAdapterManager = New CS_Portal.requirmentDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        StudentNoLabel = New System.Windows.Forms.Label()
        Form138Label = New System.Windows.Forms.Label()
        Certificate_Of_GraduationLabel = New System.Windows.Forms.Label()
        NSOLabel = New System.Windows.Forms.Label()
        Certificate_Of_Good_MoralLabel = New System.Windows.Forms.Label()
        CType(Me.RequirmentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RequirmentBindingNavigator.SuspendLayout()
        CType(Me.RequirmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequirmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequirmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentNoLabel
        '
        StudentNoLabel.AutoSize = True
        StudentNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StudentNoLabel.Location = New System.Drawing.Point(48, 181)
        StudentNoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        StudentNoLabel.Name = "StudentNoLabel"
        StudentNoLabel.Size = New System.Drawing.Size(120, 24)
        StudentNoLabel.TabIndex = 1
        StudentNoLabel.Text = "Student No:"
        '
        'Form138Label
        '
        Form138Label.AutoSize = True
        Form138Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Form138Label.Location = New System.Drawing.Point(48, 224)
        Form138Label.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Form138Label.Name = "Form138Label"
        Form138Label.Size = New System.Drawing.Size(98, 24)
        Form138Label.TabIndex = 3
        Form138Label.Text = "Form138:"
        '
        'Certificate_Of_GraduationLabel
        '
        Certificate_Of_GraduationLabel.AutoSize = True
        Certificate_Of_GraduationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Certificate_Of_GraduationLabel.Location = New System.Drawing.Point(48, 270)
        Certificate_Of_GraduationLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Certificate_Of_GraduationLabel.Name = "Certificate_Of_GraduationLabel"
        Certificate_Of_GraduationLabel.Size = New System.Drawing.Size(243, 24)
        Certificate_Of_GraduationLabel.TabIndex = 5
        Certificate_Of_GraduationLabel.Text = "Certificate Of Graduation:"
        '
        'NSOLabel
        '
        NSOLabel.AutoSize = True
        NSOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NSOLabel.Location = New System.Drawing.Point(48, 316)
        NSOLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        NSOLabel.Name = "NSOLabel"
        NSOLabel.Size = New System.Drawing.Size(60, 24)
        NSOLabel.TabIndex = 7
        NSOLabel.Text = "NSO:"
        '
        'Certificate_Of_Good_MoralLabel
        '
        Certificate_Of_Good_MoralLabel.AutoSize = True
        Certificate_Of_Good_MoralLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Certificate_Of_Good_MoralLabel.Location = New System.Drawing.Point(48, 362)
        Certificate_Of_Good_MoralLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Certificate_Of_Good_MoralLabel.Name = "Certificate_Of_Good_MoralLabel"
        Certificate_Of_Good_MoralLabel.Size = New System.Drawing.Size(250, 24)
        Certificate_Of_Good_MoralLabel.TabIndex = 9
        Certificate_Of_Good_MoralLabel.Text = "Certificate Of Good Moral:"
        '
        'RequirmentBindingNavigator
        '
        Me.RequirmentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RequirmentBindingNavigator.BindingSource = Me.RequirmentBindingSource
        Me.RequirmentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RequirmentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RequirmentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RequirmentBindingNavigatorSaveItem})
        Me.RequirmentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RequirmentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RequirmentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RequirmentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RequirmentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RequirmentBindingNavigator.Name = "RequirmentBindingNavigator"
        Me.RequirmentBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.RequirmentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RequirmentBindingNavigator.Size = New System.Drawing.Size(1031, 25)
        Me.RequirmentBindingNavigator.TabIndex = 0
        Me.RequirmentBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'RequirmentBindingSource
        '
        Me.RequirmentBindingSource.DataMember = "Requirment"
        Me.RequirmentBindingSource.DataSource = Me.RequirmentDataSet
        '
        'RequirmentDataSet
        '
        Me.RequirmentDataSet.DataSetName = "requirmentDataSet"
        Me.RequirmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(81, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'RequirmentBindingNavigatorSaveItem
        '
        Me.RequirmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RequirmentBindingNavigatorSaveItem.Image = CType(resources.GetObject("RequirmentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RequirmentBindingNavigatorSaveItem.Name = "RequirmentBindingNavigatorSaveItem"
        Me.RequirmentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RequirmentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StudentNoTextBox
        '
        Me.StudentNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RequirmentBindingSource, "StudentNo", True))
        Me.StudentNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentNoTextBox.Location = New System.Drawing.Point(771, 176)
        Me.StudentNoTextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.StudentNoTextBox.Name = "StudentNoTextBox"
        Me.StudentNoTextBox.Size = New System.Drawing.Size(171, 29)
        Me.StudentNoTextBox.TabIndex = 2
        '
        'Form138CheckBox
        '
        Me.Form138CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Form138CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.RequirmentBindingSource, "Form138", True))
        Me.Form138CheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Form138CheckBox.Location = New System.Drawing.Point(771, 216)
        Me.Form138CheckBox.Margin = New System.Windows.Forms.Padding(5)
        Me.Form138CheckBox.Name = "Form138CheckBox"
        Me.Form138CheckBox.Size = New System.Drawing.Size(173, 37)
        Me.Form138CheckBox.TabIndex = 4
        Me.Form138CheckBox.UseVisualStyleBackColor = True
        '
        'Certificate_Of_GraduationCheckBox
        '
        Me.Certificate_Of_GraduationCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Certificate_Of_GraduationCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.RequirmentBindingSource, "Certificate Of Graduation", True))
        Me.Certificate_Of_GraduationCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Certificate_Of_GraduationCheckBox.Location = New System.Drawing.Point(771, 262)
        Me.Certificate_Of_GraduationCheckBox.Margin = New System.Windows.Forms.Padding(5)
        Me.Certificate_Of_GraduationCheckBox.Name = "Certificate_Of_GraduationCheckBox"
        Me.Certificate_Of_GraduationCheckBox.Size = New System.Drawing.Size(173, 37)
        Me.Certificate_Of_GraduationCheckBox.TabIndex = 6
        Me.Certificate_Of_GraduationCheckBox.UseVisualStyleBackColor = True
        '
        'NSOCheckBox
        '
        Me.NSOCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.NSOCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.RequirmentBindingSource, "NSO", True))
        Me.NSOCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NSOCheckBox.Location = New System.Drawing.Point(771, 308)
        Me.NSOCheckBox.Margin = New System.Windows.Forms.Padding(5)
        Me.NSOCheckBox.Name = "NSOCheckBox"
        Me.NSOCheckBox.Size = New System.Drawing.Size(173, 37)
        Me.NSOCheckBox.TabIndex = 8
        Me.NSOCheckBox.UseVisualStyleBackColor = True
        '
        'Certificate_Of_Good_MoralCheckBox
        '
        Me.Certificate_Of_Good_MoralCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Certificate_Of_Good_MoralCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.RequirmentBindingSource, "Certificate Of Good Moral", True))
        Me.Certificate_Of_Good_MoralCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Certificate_Of_Good_MoralCheckBox.Location = New System.Drawing.Point(771, 354)
        Me.Certificate_Of_Good_MoralCheckBox.Margin = New System.Windows.Forms.Padding(5)
        Me.Certificate_Of_Good_MoralCheckBox.Name = "Certificate_Of_Good_MoralCheckBox"
        Me.Certificate_Of_Good_MoralCheckBox.Size = New System.Drawing.Size(173, 37)
        Me.Certificate_Of_Good_MoralCheckBox.TabIndex = 10
        Me.Certificate_Of_Good_MoralCheckBox.UseVisualStyleBackColor = True
        '
        'RequirmentDataGridView
        '
        Me.RequirmentDataGridView.AutoGenerateColumns = False
        Me.RequirmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RequirmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4})
        Me.RequirmentDataGridView.DataSource = Me.RequirmentBindingSource
        Me.RequirmentDataGridView.Location = New System.Drawing.Point(1623, 440)
        Me.RequirmentDataGridView.Margin = New System.Windows.Forms.Padding(5)
        Me.RequirmentDataGridView.Name = "RequirmentDataGridView"
        Me.RequirmentDataGridView.Size = New System.Drawing.Size(225, 183)
        Me.RequirmentDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StudentNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "StudentNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Form138"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Form138"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Certificate Of Graduation"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Certificate Of Graduation"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "NSO"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "NSO"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "Certificate Of Good Moral"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "Certificate Of Good Moral"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        '
        'RequirmentTableAdapter
        '
        Me.RequirmentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RequirmentTableAdapter = Me.RequirmentTableAdapter
        Me.TableAdapterManager.UpdateOrder = CS_Portal.requirmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(38, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(405, 100)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "NOTE:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "THIS REQUIREMENT SHOULD BE COMPLETED" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BEFORE THE GRADUATION FOR YOU TO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G" & _
    "RADUATE AND NOT DELAYED IN MARCHING" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ON THE GRADUATION DAY"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(154, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(380, 28)
        Me.Label2.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(116, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(439, 28)
        Me.Label3.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(289, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(474, 28)
        Me.Label4.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(306, 365)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(380, 28)
        Me.Label5.TabIndex = 16
        '
        'Requirment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 458)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RequirmentDataGridView)
        Me.Controls.Add(StudentNoLabel)
        Me.Controls.Add(Me.StudentNoTextBox)
        Me.Controls.Add(Form138Label)
        Me.Controls.Add(Me.Form138CheckBox)
        Me.Controls.Add(Certificate_Of_GraduationLabel)
        Me.Controls.Add(Me.Certificate_Of_GraduationCheckBox)
        Me.Controls.Add(NSOLabel)
        Me.Controls.Add(Me.NSOCheckBox)
        Me.Controls.Add(Certificate_Of_Good_MoralLabel)
        Me.Controls.Add(Me.Certificate_Of_Good_MoralCheckBox)
        Me.Controls.Add(Me.RequirmentBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Requirment"
        Me.Text = "Requirment"
        CType(Me.RequirmentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RequirmentBindingNavigator.ResumeLayout(False)
        Me.RequirmentBindingNavigator.PerformLayout()
        CType(Me.RequirmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequirmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequirmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RequirmentDataSet As CS_Portal.requirmentDataSet
    Friend WithEvents RequirmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RequirmentTableAdapter As CS_Portal.requirmentDataSetTableAdapters.RequirmentTableAdapter
    Friend WithEvents TableAdapterManager As CS_Portal.requirmentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RequirmentBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RequirmentBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StudentNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Form138CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Certificate_Of_GraduationCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents NSOCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Certificate_Of_Good_MoralCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RequirmentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
