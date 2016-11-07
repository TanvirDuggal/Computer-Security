Imports System.Security.AccessControl
Imports System.IO
Public Class copy
    Dim cpy As String
    Dim s As String
    Dim lst As Integer
    Dim x As Integer
    Dim crt As String
    Dim path As String
    Private Shared i As copy
    Public Shared ReadOnly Property instance() As copy
        Get
            If i Is Nothing Then
                i = New copy
            End If
            Return i
        End Get
    End Property

    Private Sub copy_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        i = Nothing
    End Sub

    Private Sub copy_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Title = "Choose a file to encrypt"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Filter = "All Files (*.*) | *.*"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
            cpy = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Add(cpy)
        TextBox1.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FolderBrowserDialog1.Description = "Select Destination To Store File"

        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBox2.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim allDrives() As DriveInfo = DriveInfo.GetDrives()

        For x = 0 To ListBox1.Items.Count - 1
            s = s + ListBox1.Items(x) + " + "
        Next

        s = s.Substring(0, s.Length - 2)
        s = s + " = "



        path = TextBox2.Text & "\" & TextBox3.Text & "." & ComboBox1.SelectedItem

        crt = "copy" & " " & s & " " & TextBox2.Text & "\" & TextBox3.Text & "." & ComboBox1.SelectedItem.ToString

        Process.Start("cmd", String.Format("/k {0} ", crt))

        MessageBox.Show("Process Sucessful" & vbCrLf & "File Stored at : " & path)

        ListBox1.Items.Clear()
        TextBox3.Text = ""
        TextBox2.Text = ""
        s = String.Empty
        path = String.Empty
        crt = String.Empty

    End Sub
End Class