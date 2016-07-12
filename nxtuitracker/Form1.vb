Imports Microsoft.Win32
Public Structure UI
    Public Directory As String
    Public Version As String
    Public Running As Boolean
End Structure

Public Structure AppMon
    Public Exename As String
    Public Path As String
    Public Appname As String
End Structure


Public Class Form1
    Dim Tick As Long
    Dim m_UI As New UI
    Dim m_Apps(6), m_RunApp As AppMon
    Dim StartTime, EndTime As Date
    Public env_var_text As String
    Dim env_vars() As String

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initilize form
        lbl_indicator.Parent = lbl_runtime
        lbl_indicator.BackColor = Color.Transparent
        lbl_indicator.Location = New Point(27, 30)
        lbl_indicator.Font = New Font("Tahoma", 8.25)

        strip_version.Text = "v" & Application.ProductVersion.ToString

        'Populate menu
        menu_turn_off.DropDownItems.Clear()
        menu_turn_off.DropDownItems.Add("Restart", Nothing, AddressOf menu_shutdown_onclick)
        menu_turn_off.DropDownItems.Add("Log Off", Nothing, AddressOf menu_shutdown_onclick)
        menu_turn_off.DropDownItems.Add("Shut Down", Nothing, AddressOf menu_shutdown_onclick)

        'Set registry
        Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Lattice\Nextest Utilization Tracker", "Path", Application.StartupPath)

        m_Apps(0).Appname = "Nextest UI" : m_Apps(0).Exename = "ui.exe" : m_Apps(0).Path = ""
        m_Apps(1).Appname = "Lot Control Form" : m_Apps(1).Exename = "lotcontrolform.exe" : m_Apps(1).Path = "C:\nextest\LotControlForm\Release\"

        'Default Run app
        m_RunApp.Appname = "Nextest UI" : m_RunApp.Exename = "ui.exe" : m_RunApp.Path = ""

        'Create Mutex

    End Sub

    Private Sub tmr_runtime_Tick(sender As Object, e As EventArgs) Handles tmr_runtime.Tick
        Dim Hrs As Integer  'number of hours
        Dim Min As Integer  'number of Minutes
        Dim Sec As Integer  'number of Sec
        Dim Days As Integer 'number of days

        Tick = Tick + 1

        Sec = Tick Mod 60
        Min = ((Tick - Sec) / 60) Mod 60
        Hrs = ((Tick - (Sec + (Min * 60))) / 3600) Mod 24
        Days = Tick \ 5184000
        lbl_runtime.Text = Format(Days, "00") & ":" & Format(Hrs, "00") & ":" & Format(Min, "00") & ":" & Format(Sec, "00")
        frm_mini.lbl_time.Text = lbl_runtime.Text
        Exit Sub
    End Sub



    Private Sub cmd_start_Click(sender As Object, e As EventArgs) Handles cmd_start.Click
        Tick = 0
        FileOpen(1, Application.StartupPath & "\run.bat", OpenMode.Output, OpenAccess.Write)
        If Len(env_var_text) Then
            env_vars = Split(env_var_text, vbNewLine)

            If env_vars Is Nothing = False Then
                For x As Integer = 0 To UBound(env_vars)
                    PrintLine(1, "Set " & env_vars(x))
                Next
            End If
        End If


        If Len(m_RunApp.Path) > 0 Then
            PrintLine(1, "cd " & m_RunApp.Path)
        End If

        PrintLine(1, m_RunApp.Exename)
        Print(1, "exit")

        FileClose(1)


        cmd_start.Enabled = False
        txt_user.ReadOnly = True
        cmb_group.Enabled = False
        menu_options.Enabled = False

        'Initial setup before running App
        tmr_runtime.Enabled = True
        m_UI.Running = True
        lbl_status.Text = "RUNNING"
        lbl_status.BackColor = Color.FromArgb(128, 255, 128)
        StartTime = Date.Now
        Me.WindowState = FormWindowState.Minimized

        Application.DoEvents()
        bw_run.RunWorkerAsync()

    End Sub
    Private Sub menu_ui_item_onclick(sender As Object, e As EventArgs)
        If sender.ToString = m_UI.Version Then
            MessageBox.Show("Already using " & m_UI.Version & " Nextest UI Version", "Change UI", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim result As Integer
            result = MessageBox.Show("Are you sure you want to change UI Version from " & m_UI.Version & " to " & sender.ToString, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = vbNo Then
                Exit Sub
            End If
        End If

        frm_changeui.targetui = sender.ToString
        frm_changeui.TopMost = True
        frm_changeui.Show()

    End Sub

    Private Sub menu_shutdown_onclick(sender As Object, e As EventArgs)
        Dim result As Integer
        result = MessageBox.Show("Are you sure you want to " & sender.ToString & " the system", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = vbNo Then
            Exit Sub
        End If
        If LCase$(sender.ToString) = "restart" Then
            FileOpen(1, "C:\kill.bat", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, "taskkill /f /im nxtuitrack.exe /im SystemService.exe")
            PrintLine(1, "shutdown -f -r -t 000")
            FileClose(1)
            Shell("C:\kill.bat", AppWinStyle.Hide)
        ElseIf LCase$(sender.ToString) = "log off" Then
            FileOpen(1, "C:\kill.bat", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, "taskkill /f /im nxtuitrack.exe /im SystemService.exe")
            PrintLine(1, "shutdown -f -l -t 000")
            FileClose(1)
            Shell("C:\kill.bat", AppWinStyle.Hide)
        Else
            FileOpen(1, "C:\kill.bat", OpenMode.Output, OpenAccess.Write)
            PrintLine(1, "taskkill /f /im nxtuitrack.exe /im SystemService.exe")
            PrintLine(1, "shutdown -f -s -t 000")
            FileClose(1)
            Shell("C:\kill.bat", AppWinStyle.Hide)
        End If

    End Sub

    Private Sub bw_run_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_run.DoWork
        

        'SHell Execute the bat file to run the app, wait until exit 
        Shell(Application.StartupPath & "\run.bat", AppWinStyle.Hide, True)

        
        'Mark end time then log usage
        EndTime = Date.Now
        LogUsage()

        'Reset Windows
        Me.WindowState = FormWindowState.Normal
        Me.CenterToScreen()

        'Reset Variables and controls
        env_var_text = vbNullString

        lbl_status.Text = "IDLE"
        lbl_status.BackColor = Color.FromArgb(255, 255, 128)
        m_UI.Running = False
        menu_options.Enabled = True
        tmr_runtime.Enabled = False

        'Reset Default Run app
        m_RunApp.Appname = "Nextest UI" : m_RunApp.Exename = "ui.exe" : m_RunApp.Path = ""

        'Delete bat file
        FileIO.FileSystem.DeleteFile(Application.StartupPath & "\run.bat", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        cmd_start.Enabled = True
        txt_user.ReadOnly = False
        cmb_group.Enabled = True

        txt_user.Text = "USER"
        cmb_group.Text = ""

SkipShell:
    End Sub

    Private Sub tmr_eventlistener_Tick(sender As Object, e As EventArgs) Handles tmr_eventlistener.Tick
        Call UpdateUI()
        If (Len(cmb_group.Text) = 0 Or Len(txt_user.Text) = 0 Or LCase$(txt_user.Text) = "user") Then
            cmd_start.Enabled = False
        Else
            If m_UI.Running = False Then
                cmd_start.Enabled = True
            End If
        End If



        If m_UI.Running = False Then
            For Each prog As Process In Process.GetProcesses
                If LCase$(prog.ProcessName) = "ui" Or LCase$(prog.ProcessName) = "lotcontrolform" Then

                    Dim AppIndex As Integer = -1
                    For x As Integer = 0 To UBound(m_Apps)
                        If LCase$(prog.ProcessName) = Replace(LCase$(m_Apps(x).Exename), ".exe", "") Then
                            AppIndex = x
                            m_RunApp.Appname = m_Apps(AppIndex).Appname
                            m_RunApp.Exename = m_Apps(AppIndex).Exename
                            m_RunApp.Path = m_Apps(AppIndex).Path
                            Exit For
                        End If
                    Next

                    prog.Kill()
                    Me.WindowState = FormWindowState.Normal
                    Me.CenterToScreen()
                    tooltip.Show("Please select group in the dropdown menu", cmb_group, New Point(0, -20), 2500)

                    cmd_start.Text = "Start " & m_RunApp.Appname
                End If
            Next
        Else
            If Date.Now.ToString("HH:mm:ss") = "23:59:59" Then
                EndTime = Date.Now
                LogUsage()
                Tick = 0

                StartTime = Date.Now
                System.Threading.Thread.Sleep(1000)
            End If
        End If

        If IsRunning("systemservice") = False Then
            If FileIO.FileSystem.FileExists("C:\Windows\systemservice.exe") = True Then
                Shell("C:\Windows\systemservice.exe", AppWinStyle.NormalFocus, False)
            End If
        End If
    End Sub

    Private Sub llbl_view_logs_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbl_view_logs.LinkClicked
        If FileIO.FileSystem.DirectoryExists(Application.StartupPath & "\logs") = True Then
            Call Shell("explorer.exe """ & Application.StartupPath & "\logs""", vbMaximizedFocus)
        End If
    End Sub

    Private Sub txt_user_GotFocus(sender As Object, e As EventArgs) Handles txt_user.GotFocus
        Call txt_user.SelectAll()
    End Sub

    Private Sub txt_user_MouseUp(sender As Object, e As MouseEventArgs) Handles txt_user.MouseUp
        Call txt_user.SelectAll()
    End Sub

    Private Sub menu_options_Click(sender As Object, e As EventArgs) Handles menu_options.Click
        'Populate UI menu
        Dim FolderList() As String, X As Integer
        FolderList = ListFolders("C:\Nextest\")

        menu_change_ui.DropDownItems.Clear()

        For X = 0 To UBound(FolderList)
            If FileIO.FileSystem.FileExists("C:\Nextest\" & FolderList(X) & "\utils\userel.bat") = True Then
                menu_change_ui.DropDownItems.Add(FolderList(X), Nothing, AddressOf menu_ui_item_onclick)
            End If
        Next
    End Sub


    Private Sub cmb_group_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_group.SelectedIndexChanged
        If txt_user.Text = "USER" Or Len(txt_user.Text) = 0 Then
            tooltip.Show("Please type in your name in the text box", txt_user, New Point(0, -20), 2500)
        End If
    End Sub

    Private Sub menu_set_var_Click(sender As Object, e As EventArgs) Handles menu_set_var.Click

        frm_env.Show(Me)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            frm_mini.lbl_status.Text = lbl_status.Text
            frm_mini.lbl_status.BackColor = lbl_status.BackColor
            frm_mini.lbl_user.Text = txt_user.Text
            frm_mini.lbl_time.Text = lbl_runtime.Text
            frm_mini.lbl_pcname.Text = "Host: " & System.Environment.MachineName.ToString
            frm_mini.Show()
        ElseIf Me.WindowState = FormWindowState.Normal Then
            frm_mini.Hide()
        End If
    End Sub
    Public Sub LogUsage()
        Dim MachineName As String
        Dim FileName As String
        Dim PrintHeaderFlag As Boolean = False
        Dim TickHour As Double

        MachineName = UCase$(System.Environment.MachineName)
        FileName = MachineName & "_WW" & WorkWeek(Now) & ".txt"

        PrintHeaderFlag = FileIO.FileSystem.FileExists(Application.StartupPath & "\logs\" & FileName)
        If FileIO.FileSystem.DirectoryExists(Application.StartupPath & "\logs\") = False Then
            FileIO.FileSystem.CreateDirectory(Application.StartupPath & "\logs\")
        End If

        FileOpen(1, Application.StartupPath & "\logs\" & FileName, OpenMode.Append, OpenAccess.Write)
        If PrintHeaderFlag = False Then
            Print(1, "PC NAME: " & System.Environment.MachineName & vbNewLine)
        End If

        TickHour = Math.Round(CDbl(Tick / 3600), 2)
        If TickHour > 0 Then
            Print(1, cmb_group.Text & ":" & vbTab & DateValue(Now) & vbTab & StartTime.ToString("HH:mm") & "-" & EndTime.ToString("HH:mm") & vbTab & vbTab & TickHour & vbTab & UCase(txt_user.Text) & vbNewLine)
        End If

        FileClose(1)
    End Sub

    Public Sub UpdateUI()
        Dim new_UI As String

        'Get UI Directory
        m_UI.Directory = Registry.GetValue("HKEY_CURRENT_USER\Software\NexTest\", "CurrentRelease", "")

        'Get UI Version
        Dim tempsplit() As String
        tempsplit = Split(m_UI.Directory, "\")
        new_UI = tempsplit(tempsplit.Count - 1)

        'Update PATH variable inside the program
        If m_UI.Version <> new_UI And Len(m_UI.Version) > 0 Then
            Dim NEW_ENV_PATH As String
            NEW_ENV_PATH = Replace$(System.Environment.GetEnvironmentVariable("PATH"), m_UI.Version, new_UI)
            System.Environment.SetEnvironmentVariable("PATH", NEW_ENV_PATH)
        End If

        m_UI.Version = new_UI
        strip_ui.Text = "UI: " & m_UI.Version
        frm_mini.lbl_uiversion.Text = "UI: " & m_UI.Version
    End Sub

    Public Function WorkWeek(ADate As Date) As Integer
        'Dim intReturn As Integer
        'Dim dteFirstSaturday As Date

        '' Find the first Saturday of the year for the passed in date.
        'dteFirstSaturday = CDate("01/01/" & Year(ADate))
        'Do While Weekday(dteFirstSaturday) < vbSaturday
        '    dteFirstSaturday = DateAdd("d", 1, dteFirstSaturday)
        'Loop

        'If ADate <= dteFirstSaturday Then
        '    intReturn = 1
        'Else
        '    ' Determine the number of days between the passed in date and the first Saturday.
        '    intReturn = DateDiff("d", dteFirstSaturday, ADate)
        '    ' Divide the number of days passed by 7 to get the number of weeks.
        '    intReturn = intReturn \ 7 + 1
        '    If Not Weekday(ADate) = vbSaturday Then
        '        intReturn = intReturn + 1
        '    End If
        'End If

        'WorkWeek = intReturn

        WorkWeek = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar.GetWeekOfYear(Now, Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)

    End Function

    Public Function ListFolders(Mypath As String) As String()
        Dim MyName As String, iCount As Integer, TempString As String
        iCount = 0
        TempString = vbNullString
        MyName = Dir(Mypath, vbDirectory)   ' Retrieve the first entry.
        Do While MyName <> ""   ' Start the loop.
            ' Ignore the current directory and the encompassing directory.
            If MyName <> "." And MyName <> ".." Then
                ' Use bitwise comparison to make sure MyName is a directory.
                If (GetAttr(Mypath & MyName) And vbDirectory) = vbDirectory Then
                    TempString = TempString & MyName & ","
                    iCount = iCount + 1
                End If   ' it represents a directory.
            End If
            MyName = Dir()   ' Get next entry.
        Loop

        ListFolders = Split(TempString, ",")
    End Function



    Public Function IsRunning(ProcessName As String) As Boolean
        Dim p() As Process
        p = Process.GetProcessesByName(ProcessName)
        If p.Count > 0 Then
            IsRunning = True
        Else
            IsRunning = False
        End If
    End Function

    Public Function IsProgramLoaded() As Boolean
        IsProgramLoaded = False
        For Each prog As Process In Process.GetProcesses
            If LCase$(prog.ProcessName) = "ui" Then
                If InStr(LCase$(prog.MainWindowTitle), ".exe") > 0 Then
                    IsProgramLoaded = True
                End If
                Exit For
            End If
        Next
    End Function

  
    Private Sub menu_change_ui_Click(sender As Object, e As EventArgs) Handles menu_change_ui.Click

    End Sub
End Class


