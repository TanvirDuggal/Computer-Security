Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation

Namespace GetNetworkIpAddress

    Partial Public Class Networking
        Inherits Form
        Private Shared i As Networking
        Public Shared ReadOnly Property instance() As Networking
            Get
                If i Is Nothing Then
                    i = New Networking
                End If
                Return i
            End Get
        End Property
        'Public Sub New()
        '    InitializeComponent()
        'End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs)



        End Sub
        Private Sub Networking_FormClosing(sender As Object, e As FormClosingEventArgs)
            i = Nothing
        End Sub

        Private Sub button1_Click(sender As Object, e As EventArgs)




            'Gets the machine names that are connected on LAN 

            Dim netUtility As New Process()

            netUtility.StartInfo.FileName = "net.exe"

            netUtility.StartInfo.CreateNoWindow = True

            netUtility.StartInfo.Arguments = "view"

            netUtility.StartInfo.RedirectStandardOutput = True

            netUtility.StartInfo.UseShellExecute = False

            netUtility.StartInfo.RedirectStandardError = True

            netUtility.Start()



            Dim streamReader As New StreamReader(netUtility.StandardOutput.BaseStream, netUtility.StandardOutput.CurrentEncoding)



            Dim line As String = ""

            While (InlineAssignHelper(line, streamReader.ReadLine())) IsNot Nothing
                If line.StartsWith("\") Then
                    'listBox1.Items.Add(line.Substring(2).Substring(0, line.Substring(2).IndexOf(" ")).ToUpper());
                    'string myIP = Convert.ToString(System.Net.Dns.GetHostByName(line.Substring(2).Substring(0, line.Substring(2).IndexOf(" ")).ToUpper()).AddressList[0].ToString());
                    'listBox1.Items.Add(myIP);
                    'string pcname = "";
                    '''/string pcname = line.Substring(2).Substring(0, line.Substring(2).IndexOf(" ")).ToUpper();
                    '''/listBox1.Items.Add(line.Substring(2).Substring(0, line.Substring(2).IndexOf(" ")).ToUpper());
                    'string myIP = System.Net.Dns.GetHostByName(line.Substring(2).Substring(0, line.Substring(2).IndexOf(" ")).ToUpper()).AddressList[0].ToString();
                    '''/listBox1.Items.Add(myIP);
                    'string fullname = pcname + " - " + myIP;
                    'listBox1.Items.Add(fullname);


                    Dim pcname As String = line.Substring(2).Substring(0, line.Substring(2).IndexOf(" ")).ToUpper()
                    'listBox1.Items.Add(line.Substring(2).Substring(0, line.Substring(2).IndexOf(" ")).ToUpper());
                    Dim myIP As String = Convert.ToString(System.Net.Dns.GetHostByName(line.Substring(2).Substring(0, line.Substring(2).IndexOf(" ")).ToUpper()).AddressList(0).ToString())
                    'listBox1.Items.Add(myIP);
                    Dim fullname As String = Convert.ToString((Convert.ToString("PC Name : ") & pcname) + " IP Address : ") & myIP

                    ListBox1.Items.Add(fullname)
                End If
            End While

            streamReader.Close()
            netUtility.WaitForExit(1000)


        End Sub

        Private Sub listBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

        End Sub
        Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function

        Friend WithEvents Button1 As Button
        Friend WithEvents ListBox1 As ListBox

        Private Sub InitializeComponent()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.ListBox1 = New System.Windows.Forms.ListBox()
            Me.SuspendLayout()
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(270, 89)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 0
            Me.Button1.Text = "Button1"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'ListBox1
            '
            Me.ListBox1.FormattingEnabled = True
            Me.ListBox1.Location = New System.Drawing.Point(169, 142)
            Me.ListBox1.Name = "ListBox1"
            Me.ListBox1.Size = New System.Drawing.Size(349, 251)
            Me.ListBox1.TabIndex = 1
            '
            'Networking
            '
            Me.ClientSize = New System.Drawing.Size(606, 479)
            Me.Controls.Add(Me.ListBox1)
            Me.Controls.Add(Me.Button1)
            Me.Name = "Networking"
            Me.ResumeLayout(False)

        End Sub
    End Class
End Namespace