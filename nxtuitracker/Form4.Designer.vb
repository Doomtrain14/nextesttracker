<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_changeui
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
        Me.bw_changeui = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_testhead_warning = New System.Windows.Forms.Label()
        Me.lbl_skip = New System.Windows.Forms.Label()
        Me.lbl_caldata_warning = New System.Windows.Forms.Label()
        Me.pic_chk4 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pic_chk3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pic_chk2 = New System.Windows.Forms.PictureBox()
        Me.lbl_caldata = New System.Windows.Forms.Label()
        Me.pic_chk1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic_chk4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_chk3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_chk2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_chk1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bw_changeui
        '
        Me.bw_changeui.WorkerReportsProgress = True
        Me.bw_changeui.WorkerSupportsCancellation = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_testhead_warning)
        Me.GroupBox1.Controls.Add(Me.lbl_skip)
        Me.GroupBox1.Controls.Add(Me.lbl_caldata_warning)
        Me.GroupBox1.Controls.Add(Me.pic_chk4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.pic_chk3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.pic_chk2)
        Me.GroupBox1.Controls.Add(Me.lbl_caldata)
        Me.GroupBox1.Controls.Add(Me.pic_chk1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 150)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'lbl_testhead_warning
        '
        Me.lbl_testhead_warning.AutoSize = True
        Me.lbl_testhead_warning.ForeColor = System.Drawing.Color.Red
        Me.lbl_testhead_warning.Location = New System.Drawing.Point(25, 38)
        Me.lbl_testhead_warning.Name = "lbl_testhead_warning"
        Me.lbl_testhead_warning.Size = New System.Drawing.Size(0, 13)
        Me.lbl_testhead_warning.TabIndex = 27
        '
        'lbl_skip
        '
        Me.lbl_skip.AutoSize = True
        Me.lbl_skip.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_skip.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_skip.ForeColor = System.Drawing.Color.MediumBlue
        Me.lbl_skip.Location = New System.Drawing.Point(209, 23)
        Me.lbl_skip.Name = "lbl_skip"
        Me.lbl_skip.Size = New System.Drawing.Size(26, 13)
        Me.lbl_skip.TabIndex = 26
        Me.lbl_skip.Text = "Skip"
        Me.lbl_skip.Visible = False
        '
        'lbl_caldata_warning
        '
        Me.lbl_caldata_warning.AutoSize = True
        Me.lbl_caldata_warning.ForeColor = System.Drawing.Color.Red
        Me.lbl_caldata_warning.Location = New System.Drawing.Point(25, 71)
        Me.lbl_caldata_warning.Name = "lbl_caldata_warning"
        Me.lbl_caldata_warning.Size = New System.Drawing.Size(0, 13)
        Me.lbl_caldata_warning.TabIndex = 24
        '
        'pic_chk4
        '
        Me.pic_chk4.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.pic_chk4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic_chk4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_chk4.Location = New System.Drawing.Point(12, 122)
        Me.pic_chk4.Name = "pic_chk4"
        Me.pic_chk4.Size = New System.Drawing.Size(9, 9)
        Me.pic_chk4.TabIndex = 23
        Me.pic_chk4.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(25, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Please turn ON test head"
        '
        'pic_chk3
        '
        Me.pic_chk3.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.pic_chk3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic_chk3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_chk3.Location = New System.Drawing.Point(12, 90)
        Me.pic_chk3.Name = "pic_chk3"
        Me.pic_chk3.Size = New System.Drawing.Size(9, 9)
        Me.pic_chk3.TabIndex = 21
        Me.pic_chk3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(25, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Run userel.bat"
        '
        'pic_chk2
        '
        Me.pic_chk2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.pic_chk2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic_chk2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_chk2.Location = New System.Drawing.Point(12, 57)
        Me.pic_chk2.Name = "pic_chk2"
        Me.pic_chk2.Size = New System.Drawing.Size(9, 9)
        Me.pic_chk2.TabIndex = 19
        Me.pic_chk2.TabStop = False
        '
        'lbl_caldata
        '
        Me.lbl_caldata.AutoSize = True
        Me.lbl_caldata.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_caldata.Location = New System.Drawing.Point(25, 55)
        Me.lbl_caldata.Name = "lbl_caldata"
        Me.lbl_caldata.Size = New System.Drawing.Size(165, 13)
        Me.lbl_caldata.TabIndex = 18
        Me.lbl_caldata.Text = "Copying caldata_3171 to caldata"
        '
        'pic_chk1
        '
        Me.pic_chk1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.pic_chk1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic_chk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_chk1.Location = New System.Drawing.Point(12, 25)
        Me.pic_chk1.Name = "pic_chk1"
        Me.pic_chk1.Size = New System.Drawing.Size(9, 9)
        Me.pic_chk1.TabIndex = 17
        Me.pic_chk1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Please manually turn OFF test head"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(271, 26)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Proceed"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_changeui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 190)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_changeui"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change UI Progress"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pic_chk4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_chk3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_chk2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_chk1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bw_changeui As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_testhead_warning As System.Windows.Forms.Label
    Friend WithEvents lbl_skip As System.Windows.Forms.Label
    Friend WithEvents lbl_caldata_warning As System.Windows.Forms.Label
    Friend WithEvents pic_chk4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pic_chk3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pic_chk2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_caldata As System.Windows.Forms.Label
    Friend WithEvents pic_chk1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
