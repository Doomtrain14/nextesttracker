<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_env
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
        Me.txt_env_variables = New System.Windows.Forms.TextBox()
        Me.gbox_instr = New System.Windows.Forms.GroupBox()
        Me.lbl_instr = New System.Windows.Forms.Label()
        Me.cmd_save_env = New System.Windows.Forms.Button()
        Me.gbox_instr.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_env_variables
        '
        Me.txt_env_variables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_env_variables.Location = New System.Drawing.Point(12, 12)
        Me.txt_env_variables.Multiline = True
        Me.txt_env_variables.Name = "txt_env_variables"
        Me.txt_env_variables.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_env_variables.Size = New System.Drawing.Size(248, 174)
        Me.txt_env_variables.TabIndex = 0
        '
        'gbox_instr
        '
        Me.gbox_instr.Controls.Add(Me.lbl_instr)
        Me.gbox_instr.Location = New System.Drawing.Point(266, 4)
        Me.gbox_instr.Name = "gbox_instr"
        Me.gbox_instr.Size = New System.Drawing.Size(125, 142)
        Me.gbox_instr.TabIndex = 1
        Me.gbox_instr.TabStop = False
        '
        'lbl_instr
        '
        Me.lbl_instr.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instr.Location = New System.Drawing.Point(6, 25)
        Me.lbl_instr.Name = "lbl_instr"
        Me.lbl_instr.Size = New System.Drawing.Size(115, 106)
        Me.lbl_instr.TabIndex = 0
        Me.lbl_instr.Text = "Add environment variables as shown below" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Example:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DEVICE_TYPE=HX" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MASK_REV=" & _
    "01A"
        '
        'cmd_save_env
        '
        Me.cmd_save_env.Location = New System.Drawing.Point(266, 152)
        Me.cmd_save_env.Name = "cmd_save_env"
        Me.cmd_save_env.Size = New System.Drawing.Size(125, 33)
        Me.cmd_save_env.TabIndex = 2
        Me.cmd_save_env.Text = "&Save"
        Me.cmd_save_env.UseVisualStyleBackColor = False
        '
        'frm_env
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 199)
        Me.Controls.Add(Me.cmd_save_env)
        Me.Controls.Add(Me.gbox_instr)
        Me.Controls.Add(Me.txt_env_variables)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_env"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Environment Variables"
        Me.gbox_instr.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbox_instr As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_instr As System.Windows.Forms.Label
    Friend WithEvents cmd_save_env As System.Windows.Forms.Button
    Public WithEvents txt_env_variables As System.Windows.Forms.TextBox
End Class
