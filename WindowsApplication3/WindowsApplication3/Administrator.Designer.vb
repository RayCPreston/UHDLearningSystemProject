<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrator
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnVE = New System.Windows.Forms.Button()
        Me.dgvStudentList = New System.Windows.Forms.DataGridView()
        Me.colLastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvStudentList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(357, 20)
        Me.TextBox1.TabIndex = 15
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(375, 30)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(140, 23)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Search Student"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(443, 418)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(362, 418)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(281, 418)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnVE
        '
        Me.btnVE.Location = New System.Drawing.Point(200, 418)
        Me.btnVE.Name = "btnVE"
        Me.btnVE.Size = New System.Drawing.Size(75, 23)
        Me.btnVE.TabIndex = 10
        Me.btnVE.Text = "View/Edit"
        Me.btnVE.UseVisualStyleBackColor = True
        '
        'dgvStudentList
        '
        Me.dgvStudentList.AllowUserToAddRows = False
        Me.dgvStudentList.AllowUserToDeleteRows = False
        Me.dgvStudentList.BackgroundColor = System.Drawing.Color.White
        Me.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudentList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colLastName, Me.colFirstName})
        Me.dgvStudentList.Location = New System.Drawing.Point(12, 59)
        Me.dgvStudentList.Name = "dgvStudentList"
        Me.dgvStudentList.RowHeadersVisible = False
        Me.dgvStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudentList.Size = New System.Drawing.Size(503, 344)
        Me.dgvStudentList.TabIndex = 9
        '
        'colLastName
        '
        Me.colLastName.FillWeight = 300.0!
        Me.colLastName.HeaderText = "Last Name"
        Me.colLastName.Name = "colLastName"
        Me.colLastName.ReadOnly = True
        Me.colLastName.Width = 250
        '
        'colFirstName
        '
        Me.colFirstName.HeaderText = "First Name"
        Me.colFirstName.Name = "colFirstName"
        Me.colFirstName.ReadOnly = True
        Me.colFirstName.Width = 250
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(530, 24)
        Me.MenuStrip1.TabIndex = 16
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
        'Administrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 455)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnVE)
        Me.Controls.Add(Me.dgvStudentList)
        Me.Name = "Administrator"
        Me.Text = "Administrator"
        CType(Me.dgvStudentList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnVE As Button
    Friend WithEvents dgvStudentList As DataGridView
    Friend WithEvents colLastName As DataGridViewTextBoxColumn
    Friend WithEvents colFirstName As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
