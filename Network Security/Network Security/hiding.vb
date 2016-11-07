Public Class hiding
    Dim cpy As String
    Dim x As Integer
    Dim s As String
    Dim crt As String
    Dim path As String
    Private Shared i As hiding
    Public Shared ReadOnly Property instance() As hiding
        Get
            If i Is Nothing Then
                i = New hiding
            End If
            Return i
        End Get
    End Property

    Private Sub hiding_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        i = Nothing
    End Sub

    Private Sub hiding_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
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
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Title = "Choose a file to encrypt"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Filter = "All Files (*.*) | *.*"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox2.Text = OpenFileDialog1.FileName
            cpy = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For x = 0 To ListBox1.Items.Count - 1
            s = s + ListBox1.Items(x) + " + "
        Next

        s = s.Substring(0, s.Length - 2)

        crt = "copy" & " " & "/y" & " " & s & " " & TextBox2.Text


        path = TextBox2.Text

        Process.Start("cmd", String.Format("/k {0} ", crt))

        MessageBox.Show("Process Sucessful" & vbCrLf & "File Stored at : " & path)

        ListBox1.Items.Clear()
        TextBox2.Text = ""
        s = String.Empty
        path = String.Empty
        crt = String.Empty

    End Sub
End Class