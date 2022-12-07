<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentInfo
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
        Me.txtStudentFirst = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStudentLast = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStudentmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStudentNum = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtInst = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtStudentFirst
        '
        Me.txtStudentFirst.Location = New System.Drawing.Point(159, 33)
        Me.txtStudentFirst.Name = "txtStudentFirst"
        Me.txtStudentFirst.Size = New System.Drawing.Size(110, 20)
        Me.txtStudentFirst.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "(Student) First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "(Student) Last Name:"
        '
        'txtStudentLast
        '
        Me.txtStudentLast.Location = New System.Drawing.Point(159, 72)
        Me.txtStudentLast.Name = "txtStudentLast"
        Me.txtStudentLast.Size = New System.Drawing.Size(110, 20)
        Me.txtStudentLast.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "School Or Personal Email:"
        '
        'txtStudentmail
        '
        Me.txtStudentmail.Location = New System.Drawing.Point(182, 110)
        Me.txtStudentmail.Name = "txtStudentmail"
        Me.txtStudentmail.Size = New System.Drawing.Size(214, 20)
        Me.txtStudentmail.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Student ID #:"
        '
        'txtStudentNum
        '
        Me.txtStudentNum.Location = New System.Drawing.Point(110, 148)
        Me.txtStudentNum.Name = "txtStudentNum"
        Me.txtStudentNum.Size = New System.Drawing.Size(140, 20)
        Me.txtStudentNum.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(110, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 46)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Save Info"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtInst
        '
        Me.txtInst.Location = New System.Drawing.Point(584, 33)
        Me.txtInst.Name = "txtInst"
        Me.txtInst.Size = New System.Drawing.Size(174, 20)
        Me.txtInst.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(403, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Instructor Name (Type: W. Sean)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(406, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Label6"
        '
        'StudentInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtInst)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtStudentNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtStudentmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtStudentLast)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStudentFirst)
        Me.Name = "StudentInfo"
        Me.Text = "StudentInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStudentFirst As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStudentLast As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStudentmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStudentNum As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtInst As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
