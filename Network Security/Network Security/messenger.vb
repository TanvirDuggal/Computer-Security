Imports System.DirectoryServices
Imports System.Net
Public Class messenger
    Private Shared i As messenger
    Public Shared ReadOnly Property instance() As messenger
        Get
            If i Is Nothing Then
                i = New messenger
            End If
            Return i
        End Get
    End Property

    Private Sub messenger_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        i = Nothing
    End Sub

    Private Sub messenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim childEntry As DirectoryEntry
        Dim ParentEntry As New DirectoryEntry()
        Try
            ParentEntry.Path = "WinNT:"
            For Each childEntry In ParentEntry.Children
                Dim newNode As New TreeNode(childEntry.Name)
                Select Case childEntry.SchemaClassName
                    Case "Domain"
                        Dim ParentDomain As New TreeNode(childEntry.Name)
                        TreeView1.Nodes.AddRange(New TreeNode() {ParentDomain})

                        Dim SubChildEntry As DirectoryEntry
                        Dim SubParentEntry As New DirectoryEntry()
                        SubParentEntry.Path = "WinNT://" & childEntry.Name
                        For Each SubChildEntry In SubParentEntry.Children
                            Dim newNode1 As New TreeNode(SubChildEntry.Name)
                            Select Case SubChildEntry.SchemaClassName
                                Case "Computer"
                                    ParentDomain.Nodes.Add(newNode1)
                            End Select
                        Next
                End Select
            Next
        Catch Excep As Exception
            MsgBox("Error While Reading Directories")
        Finally
            ParentEntry = Nothing
        End Try

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        txtcomputer.Text = TreeView1.SelectedNode.Text
        TextBox1.Text = GetIPAddress(txtcomputer.Text)
    End Sub

    Function GetIPAddress(ByVal CompName As String) As String
        Dim oAddr As System.Net.IPAddress
        Dim sAddr As String
        Try
            With System.Net.Dns.GetHostByName(CompName)
                oAddr = New System.Net.IPAddress(.AddressList(0).Address)
                sAddr = oAddr.ToString
            End With
            GetIPAddress = sAddr
        Catch Excep As Exception
            MsgBox(Excep.Message, MsgBoxStyle.OkOnly, "Lan Messenger")
        Finally

        End Try
    End Function

    Private Sub CmdSend_Click(sender As Object, e As EventArgs) Handles CmdSend.Click
        If txtcomputer.Text <> "" And txtmessage.Text <> "" Then
            Shell("net send " & txtcomputer.Text & " " & txtmessage.Text)
            txtmessage.Text = ""
            txtmessage.Focus()
        End If
    End Sub

    Private Sub CmdSendAll_Click(sender As Object, e As EventArgs) Handles CmdSendAll.Click
        Shell("net send ALL " & txtmessage.Text)
    End Sub
End Class