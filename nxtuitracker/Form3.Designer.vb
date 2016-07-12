<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mini
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
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_uiversion = New System.Windows.Forms.Label()
        Me.lbl_pcname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_status
        '
        Me.lbl_status.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_status.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.Location = New System.Drawing.Point(53, 6)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(72, 13)
        Me.lbl_status.TabIndex = 0
        Me.lbl_status.Text = "RUNNING"
        '
        'lbl_user
        '
        Me.lbl_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_user.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(53, 23)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(72, 13)
        Me.lbl_user.TabIndex = 1
        Me.lbl_user.Text = "YET"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "User: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Status:"
        '
        'lbl_time
        '
        Me.lbl_time.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_time.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.Location = New System.Drawing.Point(53, 41)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(72, 13)
        Me.lbl_time.TabIndex = 4
        Me.lbl_time.Text = "00:00:00:00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Time:"
        '
        'lbl_uiversion
        '
        Me.lbl_uiversion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_uiversion.Font = New System.Drawing.Font("MS Reference Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_uiversion.ForeColor = System.Drawing.Color.Black
        Me.lbl_uiversion.Location = New System.Drawing.Point(10, 75)
        Me.lbl_uiversion.Name = "lbl_uiversion"
        Me.lbl_uiversion.Size = New System.Drawing.Size(113, 13)
        Me.lbl_uiversion.TabIndex = 6
        Me.lbl_uiversion.Text = "2"
        Me.lbl_uiversion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_pcname
        '
        Me.lbl_pcname.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_pcname.Font = New System.Drawing.Font("MS Reference Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pcname.ForeColor = System.Drawing.Color.Black
        Me.lbl_pcname.Location = New System.Drawing.Point(10, 59)
        Me.lbl_pcname.Name = "lbl_pcname"
        Me.lbl_pcname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_pcname.Size = New System.Drawing.Size(113, 13)
        Me.lbl_pcname.TabIndex = 7
        Me.lbl_pcname.Text = "1"
        Me.lbl_pcname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_mini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(136, 95)
        Me.Controls.Add(Me.lbl_pcname)
        Me.Controls.Add(Me.lbl_uiversion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.lbl_status)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_mini"
        Me.Text = "Mini Tracker"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_status As System.Windows.Forms.Label
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_time As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_uiversion As System.Windows.Forms.Label
    Friend WithEvents lbl_pcname As System.Windows.Forms.Label
End Class
