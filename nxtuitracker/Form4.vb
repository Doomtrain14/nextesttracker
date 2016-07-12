Public Class frm_changeui
    Dim skip As Boolean = False
    Dim ongoing As Boolean = True
    Public targetui As String

    Private Sub frm_changeui_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ongoing Then
            If vbNo = MsgBox("Change UI is still in progress." & vbNewLine & "Are you sure you want to cancel?" & vbNewLine & "(This may cause unexpected behavior)", vbYesNo + vbExclamation, "Confirm") Then
                e.Cancel = True
            Else
                bw_changeui.CancelAsync()
                Form1.WindowState = FormWindowState.Normal
            End If
        Else
            Form1.WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub frm_changeui_Load(sender As Object, e As EventArgs) Handles Me.Load
        Form1.WindowState = FormWindowState.Minimized
        bw_changeui.RunWorkerAsync()
    End Sub


    Private Sub frm_changeui_Shown(sender As Object, e As EventArgs) Handles Me.Shown
       
    End Sub


    Private Sub lbl_skip_MouseUp(sender As Object, e As MouseEventArgs)
        skip = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub bw_changeui_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_changeui.DoWork
        ongoing = True
        lbl_caldata.Text = "Copying ""caldata_" & targetui.Replace(".", "") & """ to ""caldata"""
        lbl_caldata_warning.Text = ""
        lbl_testhead_warning.Text = ""

        Label1.ForeColor = Color.Black
        lbl_caldata.ForeColor = Color.Gray
        Label3.ForeColor = Color.Gray
        Label4.ForeColor = Color.Gray
        Dim ping_result As Boolean = True
        While (skip = False And ping_result = True)
            If My.Computer.Network.IsAvailable Then
                ping_result = My.Computer.Network.Ping("10.1.1.1")
            End If
            System.Threading.Thread.Sleep(1000)
            Application.DoEvents()
        End While

        If skip = True Then
            lbl_testhead_warning.Text = "Skipped"
            pic_chk1.BackColor = Color.Red
        Else
            pic_chk1.BackColor = Color.LimeGreen
        End If



        skip = False


        Label1.ForeColor = Color.Gray
        lbl_caldata.ForeColor = Color.Black
        Label3.ForeColor = Color.Gray
        Label4.ForeColor = Color.Gray

        Dim tempctr As Integer = 50
        While (tempctr > 0)
            System.Threading.Thread.Sleep(100)
            Application.DoEvents()
            tempctr -= 1
        End While
        'Copy caldata
        Dim new_caldata_path As String = "c:\nextest\" & "caldata_" & targetui.Replace(".", "")
        Dim old_caldata_path As String = "c:\nextest\caldata"
        Dim default_caldata_path As String = "c:\nextest\" & "caldata_" & targetui.Substring(0, 2) & "xxx"
        If FileIO.FileSystem.DirectoryExists(new_caldata_path) And System.IO.Directory.GetFiles(new_caldata_path).Count > 0 Then
            If FileIO.FileSystem.DirectoryExists(old_caldata_path) Then
                FileIO.FileSystem.DeleteDirectory(old_caldata_path, FileIO.DeleteDirectoryOption.DeleteAllContents)

            Else
                FileIO.FileSystem.CreateDirectory(old_caldata_path)
            End If

            FileIO.FileSystem.CopyDirectory(new_caldata_path, old_caldata_path, True)
            pic_chk2.BackColor = Color.LimeGreen

        ElseIf FileIO.FileSystem.DirectoryExists(default_caldata_path) And System.IO.Directory.GetFiles(default_caldata_path).Count > 0 Then
            If FileIO.FileSystem.DirectoryExists(old_caldata_path) Then
                FileIO.FileSystem.DeleteDirectory(old_caldata_path, FileIO.DeleteDirectoryOption.DeleteAllContents)

            Else
                FileIO.FileSystem.CreateDirectory(old_caldata_path)
            End If

            FileIO.FileSystem.CopyDirectory(default_caldata_path, old_caldata_path, True)
            pic_chk2.BackColor = Color.Black
            lbl_caldata_warning.Text = "Copying from ""caldata_" & targetui.Substring(0, 2) & "xxx"" to ""caldata"""
        Else
            pic_chk2.BackColor = Color.Red
            lbl_caldata_warning.Text = "No available caldata for " & targetui
            MsgBox("No available caldata for " & targetui & vbNewLine & "Change UI will abort", vbOKOnly + vbCritical, "Abort")
            ongoing = False
            Me.Close()
            Exit Sub
        End If

        skip = False


        Label1.ForeColor = Color.Gray
        lbl_caldata.ForeColor = Color.Gray
        Label3.ForeColor = Color.Black
        Label4.ForeColor = Color.Gray
        tempctr = 50
        While (tempctr > 0)
            System.Threading.Thread.Sleep(100)
            Application.DoEvents()
            tempctr -= 1
        End While

        Me.WindowState = FormWindowState.Minimized

        'Run userel.bat
        If FileIO.FileSystem.FileExists("c:\nextest\" & targetui & "\utils\userel.bat") = True Then
            Shell("c:\nextest\" & targetui & "\utils\userel.bat", AppWinStyle.NormalFocus, True)
        End If
        pic_chk3.BackColor = Color.LimeGreen

        Me.WindowState = FormWindowState.Normal

        Label1.ForeColor = Color.Gray
        lbl_caldata.ForeColor = Color.Gray
        Label3.ForeColor = Color.Gray
        Label4.ForeColor = Color.Black

        tempctr = 40
        While (tempctr > 0)
            System.Threading.Thread.Sleep(100)
            Application.DoEvents()
            tempctr -= 1
        End While
        ongoing = False
        pic_chk4.BackColor = Color.LimeGreen

        Button1.Text = "Close"
    End Sub

    Private Sub lbl_skip_Click(sender As Object, e As EventArgs)

    End Sub


End Class