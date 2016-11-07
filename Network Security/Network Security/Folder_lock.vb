Imports System.Security.AccessControl
Imports System.IO
Public Class Folder_lock
    Private Shared i As Folder_lock
    Public Shared ReadOnly Property instance() As Folder_lock
        Get
            If i Is Nothing Then
                i = New Folder_lock
            End If
            Return i
        End Get
    End Property

    Private Sub Folder_lock_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        i = Nothing
    End Sub

    Private Sub Folder_lock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        With FolderBrowserDialog1

            If .ShowDialog() = DialogResult.OK Then
                browse_TextBox.Text = .SelectedPath
            End If

        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If browse_TextBox.Text = "" Then
            MessageBox.Show("BROWSER ANY FILE")
        Else
            Dim fs As FileSystemSecurity = File.GetAccessControl(browse_TextBox.Text)
            fs.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
            File.SetAccessControl(browse_TextBox.Text, fs)
            MessageBox.Show("FOLDER LOCKED")
            browse_TextBox.Text = ""
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If browse_TextBox.Text = "" Then
            MessageBox.Show("BROWSER ANY FILE")
        Else
            Dim fs As FileSystemSecurity = File.GetAccessControl(browse_TextBox.Text)
            fs.RemoveAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
            File.SetAccessControl(browse_TextBox.Text, fs)
            MessageBox.Show("FOLDER UNLOCKED")
            browse_TextBox.Text = ""
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class