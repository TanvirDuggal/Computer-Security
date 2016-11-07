Public Class Form1
    Private Sub GetYourPingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetYourPingToolStripMenuItem.Click
        Dim gping As get_ping = get_ping.instance()
        With gping
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub FolderLockerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FolderLockerToolStripMenuItem.Click
        Dim flck As Folder_lock = Folder_lock.instance()
        With flck
            .MdiParent = Me
            .Show()
            .Focus()
        End With

    End Sub

    Private Sub DriveLockerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DriveLockerToolStripMenuItem.Click
        Dim dlck As drive_lock = drive_lock.instance()
        With dlck
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub SysKeyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SysKeyToolStripMenuItem.Click
        Dim sys As syskey = syskey.instance()
        With sys
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub HorizontalTileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalTileToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub VerticalTileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalTileToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel2.Text = DateString
    End Sub

    Private Sub FileCrytographyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileCrytographyToolStripMenuItem.Click
        Dim f As Cryptography = Cryptography.instance()
        With f
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub MessengerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MessengerToolStripMenuItem.Click
        Dim mes As messenger = messenger.instance()
        With mes
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = TimeString
    End Sub

    Private Sub FileCopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileCopyToolStripMenuItem.Click
        Dim cpy As copy = copy.instance()
        With cpy
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub NetworkingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NetworkingToolStripMenuItem.Click
        Dim net As Networking = Networking.instance()
        With net
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub FileHidingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileHidingToolStripMenuItem.Click
        Dim hid As hiding = hiding.instance()
        With hid
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub PingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PingToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
End Class
