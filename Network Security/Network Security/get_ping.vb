Public Class get_ping
    Private WithEvents MyProcess As Process
    Private Delegate Sub AppendOutputTextDelegate(ByVal text As String)
    Private Shared i As get_ping
    Public Shared ReadOnly Property instance() As get_ping
        Get
            If i Is Nothing Then
                i = New get_ping
            End If
            Return i
        End Get
    End Property

    Private Sub get_ping_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        i = Nothing
        'MyProcess.StandardInput.WriteLine("cls")
        'MyProcess.StandardInput.Flush()
        'MyProcess.StandardInput.WriteLine("EXIT") 'send an EXIT command to the Command Prompt
        'MyProcess.StandardInput.Flush()
        MyProcess.Close()
    End Sub

    Private Sub get_ping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = ExecuteButton
        MyProcess = New Process
        With MyProcess.StartInfo
            .FileName = "CMD.EXE"
            .UseShellExecute = False
            .CreateNoWindow = True
            .RedirectStandardInput = True
            .RedirectStandardOutput = True
            .RedirectStandardError = True
        End With
        MyProcess.Start()
        MyProcess.BeginErrorReadLine()
        MyProcess.BeginOutputReadLine()

    End Sub
    Private Sub MyProcess_ErrorDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.ErrorDataReceived
        AppendOutputText(vbCrLf & "Error: " & e.Data)
    End Sub

    Private Sub MyProcess_OutputDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles MyProcess.OutputDataReceived
        AppendOutputText(vbCrLf & e.Data)
    End Sub

    Private Sub AppendOutputText(ByVal text As String)
        If OutputTextBox.InvokeRequired Then
            Dim myDelegate As New AppendOutputTextDelegate(AddressOf AppendOutputText)
            Me.Invoke(myDelegate, text)
        Else
            OutputTextBox.AppendText(text)
        End If
    End Sub

    Private Sub ExecuteButton_Click(sender As Object, e As EventArgs) Handles ExecuteButton.Click
        OutputTextBox.Visible = True
        MyProcess.StandardInput.WriteLine("ping" & " " & InputTextBox.Text)
        MyProcess.StandardInput.Flush()
        InputTextBox.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'OutputTextBox.Visible = True
        'MyProcess.StandardInput.WriteLine("cls")
        'MyProcess.StandardInput.Flush()
        'InputTextBox.Text = ""
        MyProcess.Close()
        Me.Close()
    End Sub

    Private Sub OutputTextBox_TextChanged(sender As Object, e As EventArgs) Handles OutputTextBox.TextChanged

    End Sub
End Class