<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbGrade = New System.Windows.Forms.ComboBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.cmbCrdHrs = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTCR = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTGP = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblSGPA = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblCCR = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblCGV = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblCGPA = New System.Windows.Forms.Label()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.btnNextSem = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSem = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.resultDGV = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnDeleteAll = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.llblInstruction = New System.Windows.Forms.LinkLabel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.lblClasses = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.grpKey = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblinstruc = New System.Windows.Forms.Label()
        Me.grpIntruc = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.resultDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.grpKey.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpIntruc.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(431, 21)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Course &Title (enter first 3 digits to display the full course title)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(558, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 21)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Credit &Hours"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(680, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "&Grade"
        '
        'cmbGrade
        '
        Me.cmbGrade.FormattingEnabled = True
        Me.cmbGrade.Location = New System.Drawing.Point(673, 46)
        Me.cmbGrade.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbGrade.Name = "cmbGrade"
        Me.cmbGrade.Size = New System.Drawing.Size(56, 25)
        Me.cmbGrade.TabIndex = 2
        '
        'txtCourse
        '
        Me.txtCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCourse.Location = New System.Drawing.Point(6, 47)
        Me.txtCourse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(514, 25)
        Me.txtCourse.TabIndex = 0
        Me.txtCourse.Text = "PLESEA ENTER COURSE"
        '
        'cmbCrdHrs
        '
        Me.cmbCrdHrs.FormattingEnabled = True
        Me.cmbCrdHrs.Location = New System.Drawing.Point(580, 46)
        Me.cmbCrdHrs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbCrdHrs.Name = "cmbCrdHrs"
        Me.cmbCrdHrs.Size = New System.Drawing.Size(49, 25)
        Me.cmbCrdHrs.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 21)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "TCR:"
        '
        'lblTCR
        '
        Me.lblTCR.AutoEllipsis = True
        Me.lblTCR.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTCR.Location = New System.Drawing.Point(85, 22)
        Me.lblTCR.Name = "lblTCR"
        Me.lblTCR.Size = New System.Drawing.Size(58, 26)
        Me.lblTCR.TabIndex = 20
        Me.lblTCR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(159, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 21)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "TGP:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTGP
        '
        Me.lblTGP.AutoEllipsis = True
        Me.lblTGP.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTGP.Location = New System.Drawing.Point(207, 19)
        Me.lblTGP.Name = "lblTGP"
        Me.lblTGP.Size = New System.Drawing.Size(58, 26)
        Me.lblTGP.TabIndex = 22
        Me.lblTGP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(285, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 21)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "SGPA:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSGPA
        '
        Me.lblSGPA.AutoEllipsis = True
        Me.lblSGPA.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSGPA.Location = New System.Drawing.Point(344, 19)
        Me.lblSGPA.Name = "lblSGPA"
        Me.lblSGPA.Size = New System.Drawing.Size(58, 26)
        Me.lblSGPA.TabIndex = 24
        Me.lblSGPA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(423, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 21)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "CCR:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCCR
        '
        Me.lblCCR.AutoEllipsis = True
        Me.lblCCR.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCCR.ForeColor = System.Drawing.Color.Red
        Me.lblCCR.Location = New System.Drawing.Point(478, 19)
        Me.lblCCR.Name = "lblCCR"
        Me.lblCCR.Size = New System.Drawing.Size(58, 26)
        Me.lblCCR.TabIndex = 26
        Me.lblCCR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(555, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 21)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "CGV:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCGV
        '
        Me.lblCGV.AutoEllipsis = True
        Me.lblCGV.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCGV.ForeColor = System.Drawing.Color.Red
        Me.lblCGV.Location = New System.Drawing.Point(606, 20)
        Me.lblCGV.Name = "lblCGV"
        Me.lblCGV.Size = New System.Drawing.Size(58, 26)
        Me.lblCGV.TabIndex = 28
        Me.lblCGV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(670, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 21)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "CGPA:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCGPA
        '
        Me.lblCGPA.AutoEllipsis = True
        Me.lblCGPA.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCGPA.ForeColor = System.Drawing.Color.Red
        Me.lblCGPA.Location = New System.Drawing.Point(730, 21)
        Me.lblCGPA.Name = "lblCGPA"
        Me.lblCGPA.Size = New System.Drawing.Size(58, 26)
        Me.lblCGPA.TabIndex = 30
        Me.lblCGPA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddCourse
        '
        Me.btnAddCourse.BackColor = System.Drawing.Color.Wheat
        Me.btnAddCourse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCourse.ForeColor = System.Drawing.Color.Black
        Me.btnAddCourse.Location = New System.Drawing.Point(23, 17)
        Me.btnAddCourse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(152, 35)
        Me.btnAddCourse.TabIndex = 1
        Me.btnAddCourse.Text = "&Add New Course"
        Me.btnAddCourse.UseVisualStyleBackColor = False
        '
        'btnNextSem
        '
        Me.btnNextSem.BackColor = System.Drawing.Color.Wheat
        Me.btnNextSem.Enabled = False
        Me.btnNextSem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon
        Me.btnNextSem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextSem.Location = New System.Drawing.Point(6, 25)
        Me.btnNextSem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNextSem.Name = "btnNextSem"
        Me.btnNextSem.Size = New System.Drawing.Size(122, 33)
        Me.btnNextSem.TabIndex = 3
        Me.btnNextSem.Text = "&New Semester"
        Me.btnNextSem.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Wheat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(195, 17)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(63, 35)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTGP)
        Me.GroupBox1.Controls.Add(Me.lblTCR)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblSGPA)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblCGPA)
        Me.GroupBox1.Controls.Add(Me.lblCCR)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblCGV)
        Me.GroupBox1.Location = New System.Drawing.Point(289, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(810, 71)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblLevel
        '
        Me.lblLevel.AutoEllipsis = True
        Me.lblLevel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(76, 16)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(37, 26)
        Me.lblLevel.TabIndex = 32
        Me.lblLevel.Text = "100"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 21)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "LEVEL:"
        '
        'lblSem
        '
        Me.lblSem.AutoEllipsis = True
        Me.lblSem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSem.Location = New System.Drawing.Point(215, 20)
        Me.lblSem.Name = "lblSem"
        Me.lblSem.Size = New System.Drawing.Size(30, 26)
        Me.lblSem.TabIndex = 37
        Me.lblSem.Text = "1"
        Me.lblSem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(119, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 21)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "SEMESTER:"
        '
        'resultDGV
        '
        Me.resultDGV.AllowUserToAddRows = False
        DataGridViewCellStyle4.NullValue = Nothing
        Me.resultDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.resultDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.resultDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.resultDGV.BackgroundColor = System.Drawing.Color.White
        Me.resultDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.resultDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.NullValue = Nothing
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.resultDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.resultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.NullValue = Nothing
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.resultDGV.DefaultCellStyle = DataGridViewCellStyle6
        Me.resultDGV.GridColor = System.Drawing.Color.White
        Me.resultDGV.Location = New System.Drawing.Point(29, 439)
        Me.resultDGV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.resultDGV.Name = "resultDGV"
        Me.resultDGV.ReadOnly = True
        Me.resultDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.resultDGV.Size = New System.Drawing.Size(727, 252)
        Me.resultDGV.TabIndex = 3
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Wheat
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(150, 25)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 33)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.BackColor = System.Drawing.Color.Wheat
        Me.btnDeleteAll.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAll.Location = New System.Drawing.Point(248, 25)
        Me.btnDeleteAll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(87, 33)
        Me.btnDeleteAll.TabIndex = 5
        Me.btnDeleteAll.Text = "&Delete All"
        Me.btnDeleteAll.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Bisque
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1181, 99)
        Me.Panel1.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblLevel)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lblSem)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 71)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbCrdHrs)
        Me.GroupBox3.Controls.Add(Me.txtCourse)
        Me.GroupBox3.Controls.Add(Me.cmbGrade)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(54, 203)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(746, 99)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(346, 51)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Guide and legends. This info was obtain from UEW  REVISED " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FRESHERS HANDBOOK"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'llblInstruction
        '
        Me.llblInstruction.AutoSize = True
        Me.llblInstruction.Location = New System.Drawing.Point(927, 117)
        Me.llblInstruction.Name = "llblInstruction"
        Me.llblInstruction.Size = New System.Drawing.Size(181, 17)
        Me.llblInstruction.TabIndex = 4
        Me.llblInstruction.TabStop = True
        Me.llblInstruction.Text = "HOW TO USE THE SOFTWARE"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Wheat
        Me.btnPrint.Enabled = False
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(352, 27)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(63, 28)
        Me.btnPrint.TabIndex = 36
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'lblClasses
        '
        Me.lblClasses.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClasses.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblClasses.Location = New System.Drawing.Point(261, 102)
        Me.lblClasses.Name = "lblClasses"
        Me.lblClasses.Size = New System.Drawing.Size(449, 43)
        Me.lblClasses.TabIndex = 37
        Me.lblClasses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComment
        '
        Me.lblComment.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComment.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblComment.Location = New System.Drawing.Point(261, 145)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(449, 40)
        Me.lblComment.TabIndex = 38
        Me.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnClear)
        Me.GroupBox4.Controls.Add(Me.btnAddCourse)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(266, 302)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(273, 59)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnNextSem)
        Me.GroupBox5.Controls.Add(Me.btnDelete)
        Me.GroupBox5.Controls.Add(Me.btnDeleteAll)
        Me.GroupBox5.Controls.Add(Me.btnPrint)
        Me.GroupBox5.Location = New System.Drawing.Point(239, 367)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(425, 71)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'grpKey
        '
        Me.grpKey.CausesValidation = False
        Me.grpKey.Controls.Add(Me.grpIntruc)
        Me.grpKey.Controls.Add(Me.Label7)
        Me.grpKey.Controls.Add(Me.PictureBox2)
        Me.grpKey.Controls.Add(Me.PictureBox1)
        Me.grpKey.Location = New System.Drawing.Point(806, 194)
        Me.grpKey.Name = "grpKey"
        Me.grpKey.Size = New System.Drawing.Size(375, 520)
        Me.grpKey.TabIndex = 20
        Me.grpKey.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(17, 303)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(346, 211)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(17, 89)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(346, 208)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'lblinstruc
        '
        Me.lblinstruc.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinstruc.Location = New System.Drawing.Point(6, 26)
        Me.lblinstruc.Name = "lblinstruc"
        Me.lblinstruc.Size = New System.Drawing.Size(363, 499)
        Me.lblinstruc.TabIndex = 35
        Me.lblinstruc.Text = resources.GetString("lblinstruc.Text")
        '
        'grpIntruc
        '
        Me.grpIntruc.CausesValidation = False
        Me.grpIntruc.Controls.Add(Me.lblinstruc)
        Me.grpIntruc.Location = New System.Drawing.Point(0, 0)
        Me.grpIntruc.Name = "grpIntruc"
        Me.grpIntruc.Size = New System.Drawing.Size(375, 520)
        Me.grpIntruc.TabIndex = 3
        Me.grpIntruc.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1181, 726)
        Me.Controls.Add(Me.resultDGV)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.lblClasses)
        Me.Controls.Add(Me.llblInstruction)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpKey)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                                 " &
    "                                                                         UEWCOE " &
    "Student Performance Tracker"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.resultDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.grpKey.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpIntruc.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbGrade As ComboBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents cmbCrdHrs As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTCR As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTGP As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblSGPA As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblCCR As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblCGV As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblCGPA As Label
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents btnNextSem As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblLevel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblSem As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents resultDGV As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnDeleteAll As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents llblInstruction As LinkLabel
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents lblClasses As Label
    Friend WithEvents lblComment As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents grpKey As GroupBox
    Friend WithEvents lblinstruc As Label
    Friend WithEvents grpIntruc As GroupBox
End Class
