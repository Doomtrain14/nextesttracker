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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.gb_status = New System.Windows.Forms.GroupBox()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.lbl_instruction = New System.Windows.Forms.Label()
        Me.gb_runtime = New System.Windows.Forms.GroupBox()
        Me.llbl_view_logs = New System.Windows.Forms.LinkLabel()
        Me.lbl_indicator = New System.Windows.Forms.Label()
        Me.lbl_runtime = New System.Windows.Forms.Label()
        Me.tmr_runtime = New System.Windows.Forms.Timer(Me.components)
        Me.cmd_start = New System.Windows.Forms.Button()
        Me.bw_run = New System.ComponentModel.BackgroundWorker()
        Me.ss_bar = New System.Windows.Forms.StatusStrip()
        Me.strip_ui = New System.Windows.Forms.ToolStripStatusLabel()
        Me.strip_version = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menu_options = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menu_set_var = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_change_ui = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menu_turn_off = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmr_eventlistener = New System.Windows.Forms.Timer(Me.components)
        Me.gb_user = New System.Windows.Forms.GroupBox()
        Me.cmb_group = New System.Windows.Forms.ComboBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.menu_env_var = New System.Windows.Forms.ToolStripMenuItem()
        Me.sep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.gb_status.SuspendLayout()
        Me.gb_runtime.SuspendLayout()
        Me.ss_bar.SuspendLayout()
        Me.gb_user.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_status
        '
        Me.gb_status.Controls.Add(Me.lbl_status)
        Me.gb_status.Location = New System.Drawing.Point(7, 29)
        Me.gb_status.Name = "gb_status"
        Me.gb_status.Size = New System.Drawing.Size(241, 76)
        Me.gb_status.TabIndex = 0
        Me.gb_status.TabStop = False
        Me.gb_status.Text = "Status"
        '
        'lbl_status
        '
        Me.lbl_status.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_status.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_status.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.Location = New System.Drawing.Point(11, 23)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(219, 37)
        Me.lbl_status.TabIndex = 0
        Me.lbl_status.Text = "IDLE"
        Me.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_instruction
        '
        Me.lbl_instruction.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instruction.Location = New System.Drawing.Point(9, 9)
        Me.lbl_instruction.Name = "lbl_instruction"
        Me.lbl_instruction.Size = New System.Drawing.Size(239, 17)
        Me.lbl_instruction.TabIndex = 1
        Me.lbl_instruction.Text = "Please enter the required information to start the UI"
        '
        'gb_runtime
        '
        Me.gb_runtime.Controls.Add(Me.llbl_view_logs)
        Me.gb_runtime.Controls.Add(Me.lbl_indicator)
        Me.gb_runtime.Controls.Add(Me.lbl_runtime)
        Me.gb_runtime.Location = New System.Drawing.Point(7, 111)
        Me.gb_runtime.Name = "gb_runtime"
        Me.gb_runtime.Size = New System.Drawing.Size(241, 105)
        Me.gb_runtime.TabIndex = 2
        Me.gb_runtime.TabStop = False
        Me.gb_runtime.Text = "Run Time"
        '
        'llbl_view_logs
        '
        Me.llbl_view_logs.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.llbl_view_logs.AutoSize = True
        Me.llbl_view_logs.Location = New System.Drawing.Point(176, 82)
        Me.llbl_view_logs.Name = "llbl_view_logs"
        Me.llbl_view_logs.Size = New System.Drawing.Size(54, 13)
        Me.llbl_view_logs.TabIndex = 5
        Me.llbl_view_logs.TabStop = True
        Me.llbl_view_logs.Text = "View Logs"
        '
        'lbl_indicator
        '
        Me.lbl_indicator.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_indicator.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_indicator.Location = New System.Drawing.Point(35, 54)
        Me.lbl_indicator.Name = "lbl_indicator"
        Me.lbl_indicator.Size = New System.Drawing.Size(167, 15)
        Me.lbl_indicator.TabIndex = 4
        Me.lbl_indicator.Text = "Days      Hours      Mins       Secs"
        '
        'lbl_runtime
        '
        Me.lbl_runtime.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_runtime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_runtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_runtime.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_runtime.Location = New System.Drawing.Point(11, 23)
        Me.lbl_runtime.Name = "lbl_runtime"
        Me.lbl_runtime.Size = New System.Drawing.Size(219, 53)
        Me.lbl_runtime.TabIndex = 1
        Me.lbl_runtime.Text = "00:00:00:00"
        Me.lbl_runtime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tmr_runtime
        '
        Me.tmr_runtime.Interval = 1000
        '
        'cmd_start
        '
        Me.cmd_start.BackColor = System.Drawing.SystemColors.Control
        Me.cmd_start.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_start.Location = New System.Drawing.Point(7, 325)
        Me.cmd_start.Name = "cmd_start"
        Me.cmd_start.Size = New System.Drawing.Size(241, 40)
        Me.cmd_start.TabIndex = 4
        Me.cmd_start.Text = "Start Nextest UI"
        Me.cmd_start.UseVisualStyleBackColor = False
        '
        'bw_run
        '
        '
        'ss_bar
        '
        Me.ss_bar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.strip_ui, Me.strip_version, Me.menu_options})
        Me.ss_bar.Location = New System.Drawing.Point(0, 372)
        Me.ss_bar.Name = "ss_bar"
        Me.ss_bar.Size = New System.Drawing.Size(254, 22)
        Me.ss_bar.SizingGrip = False
        Me.ss_bar.TabIndex = 4
        Me.ss_bar.Text = "StatusStrip1"
        '
        'strip_ui
        '
        Me.strip_ui.AutoSize = False
        Me.strip_ui.Name = "strip_ui"
        Me.strip_ui.Size = New System.Drawing.Size(130, 17)
        Me.strip_ui.Text = "UI Version: "
        Me.strip_ui.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'strip_version
        '
        Me.strip_version.AutoSize = False
        Me.strip_version.Name = "strip_version"
        Me.strip_version.Size = New System.Drawing.Size(60, 17)
        Me.strip_version.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'menu_options
        '
        Me.menu_options.AutoSize = False
        Me.menu_options.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.menu_options.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_set_var, Me.menu_change_ui, Me.ToolStripSeparator1, Me.menu_turn_off})
        Me.menu_options.Image = CType(resources.GetObject("menu_options.Image"), System.Drawing.Image)
        Me.menu_options.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.menu_options.Name = "menu_options"
        Me.menu_options.Size = New System.Drawing.Size(64, 20)
        Me.menu_options.Text = "Options"
        Me.menu_options.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'menu_set_var
        '
        Me.menu_set_var.Name = "menu_set_var"
        Me.menu_set_var.Size = New System.Drawing.Size(211, 22)
        Me.menu_set_var.Text = "Set Environment Variables"
        '
        'menu_change_ui
        '
        Me.menu_change_ui.Name = "menu_change_ui"
        Me.menu_change_ui.Size = New System.Drawing.Size(211, 22)
        Me.menu_change_ui.Text = "Change UI version"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(208, 6)
        '
        'menu_turn_off
        '
        Me.menu_turn_off.Name = "menu_turn_off"
        Me.menu_turn_off.Size = New System.Drawing.Size(211, 22)
        Me.menu_turn_off.Text = "Turn Off System"
        '
        'tmr_eventlistener
        '
        Me.tmr_eventlistener.Enabled = True
        '
        'gb_user
        '
        Me.gb_user.Controls.Add(Me.cmb_group)
        Me.gb_user.Controls.Add(Me.txt_user)
        Me.gb_user.Location = New System.Drawing.Point(7, 222)
        Me.gb_user.Name = "gb_user"
        Me.gb_user.Size = New System.Drawing.Size(241, 97)
        Me.gb_user.TabIndex = 5
        Me.gb_user.TabStop = False
        Me.gb_user.Text = "Status"
        '
        'cmb_group
        '
        Me.cmb_group.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_group.FormattingEnabled = True
        Me.cmb_group.Items.AddRange(New Object() {"PE", "TD", "REL", "PAR", "RMP", "OPS", "EE"})
        Me.cmb_group.Location = New System.Drawing.Point(11, 20)
        Me.cmb_group.Name = "cmb_group"
        Me.cmb_group.Size = New System.Drawing.Size(219, 21)
        Me.cmb_group.TabIndex = 2
        '
        'txt_user
        '
        Me.txt_user.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_user.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.Location = New System.Drawing.Point(11, 47)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(219, 40)
        Me.txt_user.TabIndex = 3
        Me.txt_user.Text = "USER"
        Me.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'menu_env_var
        '
        Me.menu_env_var.Name = "menu_env_var"
        Me.menu_env_var.Size = New System.Drawing.Size(211, 22)
        Me.menu_env_var.Text = "Set Environment Variables"
        '
        'sep1
        '
        Me.sep1.Name = "sep1"
        Me.sep1.Size = New System.Drawing.Size(208, 6)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 394)
        Me.Controls.Add(Me.gb_user)
        Me.Controls.Add(Me.ss_bar)
        Me.Controls.Add(Me.cmd_start)
        Me.Controls.Add(Me.gb_runtime)
        Me.Controls.Add(Me.lbl_instruction)
        Me.Controls.Add(Me.gb_status)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nextest UI Tracker"
        Me.TopMost = True
        Me.gb_status.ResumeLayout(False)
        Me.gb_runtime.ResumeLayout(False)
        Me.gb_runtime.PerformLayout()
        Me.ss_bar.ResumeLayout(False)
        Me.ss_bar.PerformLayout()
        Me.gb_user.ResumeLayout(False)
        Me.gb_user.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb_status As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_instruction As System.Windows.Forms.Label
    Friend WithEvents lbl_status As System.Windows.Forms.Label
    Friend WithEvents gb_runtime As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_indicator As System.Windows.Forms.Label
    Friend WithEvents lbl_runtime As System.Windows.Forms.Label
    Friend WithEvents tmr_runtime As System.Windows.Forms.Timer
    Friend WithEvents cmd_start As System.Windows.Forms.Button
    Friend WithEvents bw_run As System.ComponentModel.BackgroundWorker
    Friend WithEvents ss_bar As System.Windows.Forms.StatusStrip
    Friend WithEvents strip_ui As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmr_eventlistener As System.Windows.Forms.Timer
    Friend WithEvents llbl_view_logs As System.Windows.Forms.LinkLabel
    Friend WithEvents gb_user As System.Windows.Forms.GroupBox
    Friend WithEvents txt_user As System.Windows.Forms.TextBox
    Friend WithEvents cmb_group As System.Windows.Forms.ComboBox
    Friend WithEvents strip_version As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents menu_env_var As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_options As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents menu_set_var As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_change_ui As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_turn_off As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tooltip As System.Windows.Forms.ToolTip

End Class
