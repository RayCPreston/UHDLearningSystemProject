<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentInfo
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colCourse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colExam1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colExam2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colExam3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colExam4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colExam5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.boxGPA = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblGPA = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCourse, Me.colExam1, Me.colExam2, Me.colExam3, Me.colExam4, Me.colExam5})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 255)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(478, 204)
        Me.DataGridView1.TabIndex = 0
        '
        'colCourse
        '
        Me.colCourse.HeaderText = "Course Name"
        Me.colCourse.Name = "colCourse"
        Me.colCourse.Width = 175
        '
        'colExam1
        '
        Me.colExam1.HeaderText = "Exam 1"
        Me.colExam1.Name = "colExam1"
        Me.colExam1.Width = 60
        '
        'colExam2
        '
        Me.colExam2.HeaderText = "Exam 2"
        Me.colExam2.Name = "colExam2"
        Me.colExam2.Width = 60
        '
        'colExam3
        '
        Me.colExam3.HeaderText = "Exam 3"
        Me.colExam3.Name = "colExam3"
        Me.colExam3.Width = 60
        '
        'colExam4
        '
        Me.colExam4.HeaderText = "Exam 4"
        Me.colExam4.Name = "colExam4"
        Me.colExam4.Width = 60
        '
        'colExam5
        '
        Me.colExam5.HeaderText = "Exam 5"
        Me.colExam5.Name = "colExam5"
        Me.colExam5.Width = 60
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(76, 99)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(90, 20)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(172, 99)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(239, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(172, 127)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(239, 20)
        Me.TextBox2.TabIndex = 4
        '
        'boxGPA
        '
        Me.boxGPA.Location = New System.Drawing.Point(412, 229)
        Me.boxGPA.Name = "boxGPA"
        Me.boxGPA.ReadOnly = True
        Me.boxGPA.Size = New System.Drawing.Size(78, 20)
        Me.boxGPA.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(172, 155)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(239, 20)
        Me.TextBox4.TabIndex = 6
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(76, 125)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(90, 20)
        Me.lblLastName.TabIndex = 7
        Me.lblLastName.Text = "Last Name:"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(251, 465)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(413, 465)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(500, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblGPA
        '
        Me.lblGPA.AutoSize = True
        Me.lblGPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPA.Location = New System.Drawing.Point(359, 227)
        Me.lblGPA.Name = "lblGPA"
        Me.lblGPA.Size = New System.Drawing.Size(47, 20)
        Me.lblGPA.TabIndex = 11
        Me.lblGPA.Text = "GPA:"
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.Location = New System.Drawing.Point(76, 153)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(91, 20)
        Me.lblStudentID.TabIndex = 12
        Me.lblStudentID.Text = "Student ID:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(332, 465)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmStudentInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 496)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.lblGPA)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.boxGPA)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmStudentInfo"
        Me.Text = "frmStudentInfo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents colCourse As DataGridViewTextBoxColumn
    Friend WithEvents colExam1 As DataGridViewTextBoxColumn
    Friend WithEvents colExam2 As DataGridViewTextBoxColumn
    Friend WithEvents colExam3 As DataGridViewTextBoxColumn
    Friend WithEvents colExam4 As DataGridViewTextBoxColumn
    Friend WithEvents colExam5 As DataGridViewTextBoxColumn
    Friend WithEvents lblFirstName As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents boxGPA As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblGPA As Label
    Friend WithEvents lblStudentID As Label
    Friend WithEvents btnSave As Button
End Class
