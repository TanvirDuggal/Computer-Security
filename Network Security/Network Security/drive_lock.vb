Imports System.Security.AccessControl
Imports System.IO
Public Class drive_lock
    Private Shared i As drive_lock
    Public Shared ReadOnly Property instance() As drive_lock
        Get
            If i Is Nothing Then
                i = New drive_lock
            End If
            Return i
        End Get
    End Property
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim allDrives() As DriveInfo = DriveInfo.GetDrives()

        Dim d As DriveInfo

        For Each d In allDrives
            If d.IsReady = True Then
                ListBox1.Items.Add(d.Name)
                ListBox2.Items.Add("Volume Label :" & " " & d.VolumeLabel & " " & "File System" & " " & d.DriveFormat & " " & "Total Space : " & " " & d.TotalSize & " " & "Free Space : " & " " & d.TotalFreeSpace)
            End If
        Next
        ListBox1.Visible = True
        ListBox2.Visible = True
        Button2.Visible = True
        Button3.Visible = True
    End Sub

    Private Sub drive_lock_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        i = Nothing
    End Sub

    Private Sub drive_lock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fs As FileSystemSecurity = File.GetAccessControl(ListBox1.SelectedItem)
        fs.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
        File.SetAccessControl(ListBox1.SelectedItem, fs)
        MessageBox.Show("FOLDER LOCKED")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fs As FileSystemSecurity = File.GetAccessControl(ListBox1.SelectedItem)
        fs.RemoveAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
        File.SetAccessControl(ListBox1.SelectedItem, fs)
        MessageBox.Show("FOLDER UNLOCKED")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class