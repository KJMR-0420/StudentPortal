<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim MiddleInitialLabel As System.Windows.Forms.Label
        Dim SuffixLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim SectionLabel As System.Windows.Forms.Label
        Dim YearLevelLabel As System.Windows.Forms.Label
        Dim CollegeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSN = New System.Windows.Forms.TextBox()
        Me.ProfileDataSet = New CS_Portal.ProfileDataSet()
        Me.ProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfileTableAdapter = New CS_Portal.ProfileDataSetTableAdapters.ProfileTableAdapter()
        Me.TableAdapterManager = New CS_Portal.ProfileDataSetTableAdapters.TableAdapterManager()
        Me.ProfileBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ProfileBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StudentNoTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleInitialTextBox = New System.Windows.Forms.TextBox()
        Me.SuffixTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.SectionTextBox = New System.Windows.Forms.TextBox()
        Me.YearLevelTextBox = New System.Windows.Forms.TextBox()
        Me.CollegeTextBox = New System.Windows.Forms.TextBox()
        Me.ProfileDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        StudentNoLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        MiddleInitialLabel = New System.Windows.Forms.Label()
        SuffixLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        SectionLabel = New System.Windows.Forms.Label()
        YearLevelLabel = New System.Windows.Forms.Label()
        CollegeLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProfileDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfileBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProfileBindingNavigator.SuspendLayout()
        CType(Me.ProfileDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentNoLabel
        '
        StudentNoLabel.AutoSize = True
        StudentNoLabel.Location = New System.Drawing.Point(630, 51)
        StudentNoLabel.Name = "StudentNoLabel"
        StudentNoLabel.Size = New System.Drawing.Size(64, 13)
        StudentNoLabel.TabIndex = 2
        StudentNoLabel.Text = "Student No:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(630, 77)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 4
        LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(630, 103)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 6
        FirstNameLabel.Text = "First Name:"
        '
        'MiddleInitialLabel
        '
        MiddleInitialLabel.AutoSize = True
        MiddleInitialLabel.Location = New System.Drawing.Point(630, 129)
        MiddleInitialLabel.Name = "MiddleInitialLabel"
        MiddleInitialLabel.Size = New System.Drawing.Size(68, 13)
        MiddleInitialLabel.TabIndex = 8
        MiddleInitialLabel.Text = "Middle Initial:"
        '
        'SuffixLabel
        '
        SuffixLabel.AutoSize = True
        SuffixLabel.Location = New System.Drawing.Point(630, 155)
        SuffixLabel.Name = "SuffixLabel"
        SuffixLabel.Size = New System.Drawing.Size(36, 13)
        SuffixLabel.TabIndex = 10
        SuffixLabel.Text = "Suffix:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(630, 181)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 12
        GenderLabel.Text = "Gender:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(630, 207)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 14
        AgeLabel.Text = "Age:"
        '
        'SectionLabel
        '
        SectionLabel.AutoSize = True
        SectionLabel.Location = New System.Drawing.Point(630, 233)
        SectionLabel.Name = "SectionLabel"
        SectionLabel.Size = New System.Drawing.Size(46, 13)
        SectionLabel.TabIndex = 16
        SectionLabel.Text = "Section:"
        '
        'YearLevelLabel
        '
        YearLevelLabel.AutoSize = True
        YearLevelLabel.Location = New System.Drawing.Point(630, 259)
        YearLevelLabel.Name = "YearLevelLabel"
        YearLevelLabel.Size = New System.Drawing.Size(61, 13)
        YearLevelLabel.TabIndex = 18
        YearLevelLabel.Text = "Year Level:"
        '
        'CollegeLabel
        '
        CollegeLabel.AutoSize = True
        CollegeLabel.Location = New System.Drawing.Point(630, 285)
        CollegeLabel.Name = "CollegeLabel"
        CollegeLabel.Size = New System.Drawing.Size(45, 13)
        CollegeLabel.TabIndex = 20
        CollegeLabel.Text = "College:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtSN)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(121, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 156)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Authentication"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.CS_Portal.My.Resources.Resources.Enter_41039
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(110, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 47)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtSN
        '
        Me.txtSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSN.Location = New System.Drawing.Point(38, 38)
        Me.txtSN.Multiline = True
        Me.txtSN.Name = "txtSN"
        Me.txtSN.Size = New System.Drawing.Size(292, 47)
        Me.txtSN.TabIndex = 0
        Me.txtSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProfileDataSet
        '
        Me.ProfileDataSet.DataSetName = "ProfileDataSet"
        Me.ProfileDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfileBindingSource
        '
        Me.ProfileBindingSource.DataMember = "Profile"
        Me.ProfileBindingSource.DataSource = Me.ProfileDataSet
        '
        'ProfileTableAdapter
        '
        Me.ProfileTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FinalGradeTableAdapter = Nothing
        Me.TableAdapterManager.MidtermGradeTableAdapter = Nothing
        Me.TableAdapterManager.ProfileTableAdapter = Me.ProfileTableAdapter
        Me.TableAdapterManager.UpdateOrder = CS_Portal.ProfileDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProfileBindingNavigator
        '
        Me.ProfileBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProfileBindingNavigator.BindingSource = Me.ProfileBindingSource
        Me.ProfileBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProfileBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProfileBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProfileBindingNavigatorSaveItem})
        Me.ProfileBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProfileBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProfileBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProfileBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProfileBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProfileBindingNavigator.Name = "ProfileBindingNavigator"
        Me.ProfileBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProfileBindingNavigator.Size = New System.Drawing.Size(633, 25)
        Me.ProfileBindingNavigator.TabIndex = 1
        Me.ProfileBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'ProfileBindingNavigatorSaveItem
        '
        Me.ProfileBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProfileBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProfileBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProfileBindingNavigatorSaveItem.Name = "ProfileBindingNavigatorSaveItem"
        Me.ProfileBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProfileBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StudentNoTextBox
        '
        Me.StudentNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "StudentNo", True))
        Me.StudentNoTextBox.Location = New System.Drawing.Point(704, 48)
        Me.StudentNoTextBox.Name = "StudentNoTextBox"
        Me.StudentNoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentNoTextBox.TabIndex = 3
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(704, 74)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 5
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(704, 100)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 7
        '
        'MiddleInitialTextBox
        '
        Me.MiddleInitialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "MiddleInitial", True))
        Me.MiddleInitialTextBox.Location = New System.Drawing.Point(704, 126)
        Me.MiddleInitialTextBox.Name = "MiddleInitialTextBox"
        Me.MiddleInitialTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MiddleInitialTextBox.TabIndex = 9
        '
        'SuffixTextBox
        '
        Me.SuffixTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "Suffix", True))
        Me.SuffixTextBox.Location = New System.Drawing.Point(704, 152)
        Me.SuffixTextBox.Name = "SuffixTextBox"
        Me.SuffixTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SuffixTextBox.TabIndex = 11
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(704, 178)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GenderTextBox.TabIndex = 13
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(704, 204)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AgeTextBox.TabIndex = 15
        '
        'SectionTextBox
        '
        Me.SectionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "Section", True))
        Me.SectionTextBox.Location = New System.Drawing.Point(704, 230)
        Me.SectionTextBox.Name = "SectionTextBox"
        Me.SectionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SectionTextBox.TabIndex = 17
        '
        'YearLevelTextBox
        '
        Me.YearLevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "YearLevel", True))
        Me.YearLevelTextBox.Location = New System.Drawing.Point(704, 256)
        Me.YearLevelTextBox.Name = "YearLevelTextBox"
        Me.YearLevelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.YearLevelTextBox.TabIndex = 19
        '
        'CollegeTextBox
        '
        Me.CollegeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfileBindingSource, "College", True))
        Me.CollegeTextBox.Location = New System.Drawing.Point(704, 282)
        Me.CollegeTextBox.Name = "CollegeTextBox"
        Me.CollegeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CollegeTextBox.TabIndex = 21
        '
        'ProfileDataGridView
        '
        Me.ProfileDataGridView.AutoGenerateColumns = False
        Me.ProfileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProfileDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.ProfileDataGridView.DataSource = Me.ProfileBindingSource
        Me.ProfileDataGridView.Location = New System.Drawing.Point(633, 308)
        Me.ProfileDataGridView.Name = "ProfileDataGridView"
        Me.ProfileDataGridView.Size = New System.Drawing.Size(117, 80)
        Me.ProfileDataGridView.TabIndex = 22
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StudentNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "StudentNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MiddleInitial"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MiddleInitial"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Suffix"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Suffix"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Section"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Section"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "YearLevel"
        Me.DataGridViewTextBoxColumn9.HeaderText = "YearLevel"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "College"
        Me.DataGridViewTextBoxColumn10.HeaderText = "College"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CS_Portal.My.Resources.Resources.cats
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(633, 382)
        Me.Controls.Add(Me.ProfileDataGridView)
        Me.Controls.Add(StudentNoLabel)
        Me.Controls.Add(Me.StudentNoTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(MiddleInitialLabel)
        Me.Controls.Add(Me.MiddleInitialTextBox)
        Me.Controls.Add(SuffixLabel)
        Me.Controls.Add(Me.SuffixTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(SectionLabel)
        Me.Controls.Add(Me.SectionTextBox)
        Me.Controls.Add(YearLevelLabel)
        Me.Controls.Add(Me.YearLevelTextBox)
        Me.Controls.Add(CollegeLabel)
        Me.Controls.Add(Me.CollegeTextBox)
        Me.Controls.Add(Me.ProfileBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LogIn"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProfileDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfileBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProfileBindingNavigator.ResumeLayout(False)
        Me.ProfileBindingNavigator.PerformLayout()
        CType(Me.ProfileDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtSN As System.Windows.Forms.TextBox
    Friend WithEvents ProfileDataSet As CS_Portal.ProfileDataSet
    Friend WithEvents ProfileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfileTableAdapter As CS_Portal.ProfileDataSetTableAdapters.ProfileTableAdapter
    Friend WithEvents TableAdapterManager As CS_Portal.ProfileDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProfileBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ProfileBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StudentNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiddleInitialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SuffixTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SectionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YearLevelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CollegeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProfileDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
