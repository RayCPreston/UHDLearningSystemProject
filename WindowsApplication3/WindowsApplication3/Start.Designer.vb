<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Me.Student_Enter = New System.Windows.Forms.Button()
        Me.Admin_Enter = New System.Windows.Forms.Button()
        Me.Exit_Start = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Student_Enter
        '
        Me.Student_Enter.Location = New System.Drawing.Point(12, 12)
        Me.Student_Enter.Name = "Student_Enter"
        Me.Student_Enter.Size = New System.Drawing.Size(260, 82)
        Me.Student_Enter.TabIndex = 0
        Me.Student_Enter.Text = "Enter as Student"
        Me.Student_Enter.UseVisualStyleBackColor = True
        '
        'Admin_Enter
        '
        Me.Admin_Enter.Location = New System.Drawing.Point(12, 100)
        Me.Admin_Enter.Name = "Admin_Enter"
        Me.Admin_Enter.Size = New System.Drawing.Size(260, 82)
        Me.Admin_Enter.TabIndex = 1
        Me.Admin_Enter.Text = "Enter as Administrator"
        Me.Admin_Enter.UseVisualStyleBackColor = True
        '
        'Exit_Start
        '
        Me.Exit_Start.Location = New System.Drawing.Point(12, 188)
        Me.Exit_Start.Name = "Exit_Start"
        Me.Exit_Start.Size = New System.Drawing.Size(260, 23)
        Me.Exit_Start.TabIndex = 2
        Me.Exit_Start.Text = "Exit"
        Me.Exit_Start.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 222)
        Me.Controls.Add(Me.Exit_Start)
        Me.Controls.Add(Me.Admin_Enter)
        Me.Controls.Add(Me.Student_Enter)
        Me.Name = "Start"
        Me.Text = "Start"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Student_Enter As Button
    Friend WithEvents Admin_Enter As Button
    Friend WithEvents Exit_Start As Button
End Class
