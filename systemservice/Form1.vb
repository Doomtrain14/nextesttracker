Imports Microsoft.Win32

Public Class frm_system_svc
    Dim tracker_exepath As String
    Private Sub frm_system_svc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = False
        Me.Visible = False

        tracker_exepath = Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Lattice\Nextest Utilization Tracker", "Path", "")
    End Sub

    Private Sub tmr_listener_Tick(sender As Object, e As EventArgs) Handles tmr_listener.Tick
        If IsRunning("nxtuitrack") = False Then
            If FileIO.FileSystem.FileExists(tracker_exepath & "\nxtuitrack.exe") = True Then
                Shell(tracker_exepath & "\nxtuitrack.exe", AppWinStyle.NormalFocus, False)
            End If
        End If
    End Sub

    Public Function IsRunning(ProcessName As String) As Boolean

        Dim p() As Process
        p = Process.GetProcessesByName(ProcessName)
        If p.Count > 0 Then
            IsRunning = True
        Else
            IsRunning = False
        End If


    End Function
End Class
