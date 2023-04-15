<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.treg = New System.Windows.Forms.TextBox()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentDataSet = New WindowsApplication1.studentDataSet()
        Me.tname = New System.Windows.Forms.TextBox()
        Me.tvb = New System.Windows.Forms.TextBox()
        Me.trdbms = New System.Windows.Forms.TextBox()
        Me.tswe = New System.Windows.Forms.TextBox()
        Me.tstat = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Table1TableAdapter = New WindowsApplication1.studentDataSetTableAdapters.Table1TableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegisterNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RDBMSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SWEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("LEMON MILK Medium", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(286, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT MARKS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Register No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(102, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(116, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "VB"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(215, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "RDBMS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(323, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "SWE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(424, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "STAT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(526, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "TOTAL"
        '
        'treg
        '
        Me.treg.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Register No", True))
        Me.treg.Location = New System.Drawing.Point(218, 80)
        Me.treg.Name = "treg"
        Me.treg.Size = New System.Drawing.Size(148, 20)
        Me.treg.TabIndex = 8
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.StudentDataSet
        '
        'StudentDataSet
        '
        Me.StudentDataSet.DataSetName = "studentDataSet"
        Me.StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tname
        '
        Me.tname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Name", True))
        Me.tname.Location = New System.Drawing.Point(218, 122)
        Me.tname.Name = "tname"
        Me.tname.Size = New System.Drawing.Size(148, 20)
        Me.tname.TabIndex = 9
        '
        'tvb
        '
        Me.tvb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "VB", True))
        Me.tvb.Location = New System.Drawing.Point(79, 195)
        Me.tvb.Name = "tvb"
        Me.tvb.Size = New System.Drawing.Size(100, 20)
        Me.tvb.TabIndex = 10
        '
        'trdbms
        '
        Me.trdbms.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "RDBMS", True))
        Me.trdbms.Location = New System.Drawing.Point(185, 195)
        Me.trdbms.Name = "trdbms"
        Me.trdbms.Size = New System.Drawing.Size(100, 20)
        Me.trdbms.TabIndex = 11
        '
        'tswe
        '
        Me.tswe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "SWE", True))
        Me.tswe.Location = New System.Drawing.Point(291, 195)
        Me.tswe.Name = "tswe"
        Me.tswe.Size = New System.Drawing.Size(100, 20)
        Me.tswe.TabIndex = 12
        '
        'tstat
        '
        Me.tstat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "STAT", True))
        Me.tstat.Location = New System.Drawing.Point(397, 195)
        Me.tstat.Name = "tstat"
        Me.tstat.Size = New System.Drawing.Size(100, 20)
        Me.tstat.TabIndex = 13
        '
        'total
        '
        Me.total.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "TOTAL", True))
        Me.total.Location = New System.Drawing.Point(503, 195)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 20)
        Me.total.TabIndex = 14
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.Button1.Location = New System.Drawing.Point(427, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Previous"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.Button2.Location = New System.Drawing.Point(427, 116)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Next"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Blue
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.Button3.Location = New System.Drawing.Point(529, 77)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 28)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Green
        Me.Button4.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.Button4.Location = New System.Drawing.Point(529, 116)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(74, 30)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.RegisterNoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.VBDataGridViewTextBoxColumn, Me.RDBMSDataGridViewTextBoxColumn, Me.SWEDataGridViewTextBoxColumn, Me.STATDataGridViewTextBoxColumn, Me.TOTALDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(79, 232)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(524, 192)
        Me.DataGridView1.TabIndex = 19
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        Me.IDDataGridViewTextBoxColumn.Width = 5
        '
        'RegisterNoDataGridViewTextBoxColumn
        '
        Me.RegisterNoDataGridViewTextBoxColumn.DataPropertyName = "Register No"
        Me.RegisterNoDataGridViewTextBoxColumn.HeaderText = "Register No"
        Me.RegisterNoDataGridViewTextBoxColumn.Name = "RegisterNoDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 130
        '
        'VBDataGridViewTextBoxColumn
        '
        Me.VBDataGridViewTextBoxColumn.DataPropertyName = "VB"
        Me.VBDataGridViewTextBoxColumn.HeaderText = "VB"
        Me.VBDataGridViewTextBoxColumn.Name = "VBDataGridViewTextBoxColumn"
        Me.VBDataGridViewTextBoxColumn.Width = 50
        '
        'RDBMSDataGridViewTextBoxColumn
        '
        Me.RDBMSDataGridViewTextBoxColumn.DataPropertyName = "RDBMS"
        Me.RDBMSDataGridViewTextBoxColumn.HeaderText = "RDBMS"
        Me.RDBMSDataGridViewTextBoxColumn.Name = "RDBMSDataGridViewTextBoxColumn"
        Me.RDBMSDataGridViewTextBoxColumn.Width = 50
        '
        'SWEDataGridViewTextBoxColumn
        '
        Me.SWEDataGridViewTextBoxColumn.DataPropertyName = "SWE"
        Me.SWEDataGridViewTextBoxColumn.HeaderText = "SWE"
        Me.SWEDataGridViewTextBoxColumn.Name = "SWEDataGridViewTextBoxColumn"
        Me.SWEDataGridViewTextBoxColumn.Width = 50
        '
        'STATDataGridViewTextBoxColumn
        '
        Me.STATDataGridViewTextBoxColumn.DataPropertyName = "STAT"
        Me.STATDataGridViewTextBoxColumn.HeaderText = "STAT"
        Me.STATDataGridViewTextBoxColumn.Name = "STATDataGridViewTextBoxColumn"
        Me.STATDataGridViewTextBoxColumn.Width = 50
        '
        'TOTALDataGridViewTextBoxColumn
        '
        Me.TOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.HeaderText = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.Name = "TOTALDataGridViewTextBoxColumn"
        Me.TOTALDataGridViewTextBoxColumn.Width = 50
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(307, 453)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 28)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "EXIT"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(773, 504)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.tstat)
        Me.Controls.Add(Me.tswe)
        Me.Controls.Add(Me.trdbms)
        Me.Controls.Add(Me.tvb)
        Me.Controls.Add(Me.tname)
        Me.Controls.Add(Me.treg)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents treg As System.Windows.Forms.TextBox
    Friend WithEvents tname As System.Windows.Forms.TextBox
    Friend WithEvents tvb As System.Windows.Forms.TextBox
    Friend WithEvents trdbms As System.Windows.Forms.TextBox
    Friend WithEvents tswe As System.Windows.Forms.TextBox
    Friend WithEvents tstat As System.Windows.Forms.TextBox
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents StudentDataSet As WindowsApplication1.studentDataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As WindowsApplication1.studentDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegisterNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RDBMSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SWEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button

End Class
