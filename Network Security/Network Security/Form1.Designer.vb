<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetYourPingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessengerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NetworkingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProtectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DriveLockerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderLockerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SysKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CryptographyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileCrytographyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileCopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileHidingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalTileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalTileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PingToolStripMenuItem, Me.ProtectionToolStripMenuItem, Me.CryptographyToolStripMenuItem, Me.WindowsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.WindowsToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(874, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PingToolStripMenuItem
        '
        Me.PingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetYourPingToolStripMenuItem, Me.MessengerToolStripMenuItem, Me.NetworkingToolStripMenuItem})
        Me.PingToolStripMenuItem.Name = "PingToolStripMenuItem"
        Me.PingToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.PingToolStripMenuItem.Text = "Network"
        '
        'GetYourPingToolStripMenuItem
        '
        Me.GetYourPingToolStripMenuItem.Name = "GetYourPingToolStripMenuItem"
        Me.GetYourPingToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.GetYourPingToolStripMenuItem.Text = "Get Your Ping"
        '
        'MessengerToolStripMenuItem
        '
        Me.MessengerToolStripMenuItem.Name = "MessengerToolStripMenuItem"
        Me.MessengerToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.MessengerToolStripMenuItem.Text = "Messenger"
        '
        'NetworkingToolStripMenuItem
        '
        Me.NetworkingToolStripMenuItem.Name = "NetworkingToolStripMenuItem"
        Me.NetworkingToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.NetworkingToolStripMenuItem.Text = "Networking"
        '
        'ProtectionToolStripMenuItem
        '
        Me.ProtectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DriveLockerToolStripMenuItem, Me.FolderLockerToolStripMenuItem, Me.SysKeyToolStripMenuItem})
        Me.ProtectionToolStripMenuItem.Name = "ProtectionToolStripMenuItem"
        Me.ProtectionToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProtectionToolStripMenuItem.Text = "Securing"
        '
        'DriveLockerToolStripMenuItem
        '
        Me.DriveLockerToolStripMenuItem.Name = "DriveLockerToolStripMenuItem"
        Me.DriveLockerToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.DriveLockerToolStripMenuItem.Text = "Drive Locker"
        '
        'FolderLockerToolStripMenuItem
        '
        Me.FolderLockerToolStripMenuItem.Name = "FolderLockerToolStripMenuItem"
        Me.FolderLockerToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.FolderLockerToolStripMenuItem.Text = "Folder Locker"
        '
        'SysKeyToolStripMenuItem
        '
        Me.SysKeyToolStripMenuItem.Name = "SysKeyToolStripMenuItem"
        Me.SysKeyToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.SysKeyToolStripMenuItem.Text = "SysKey"
        '
        'CryptographyToolStripMenuItem
        '
        Me.CryptographyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileCrytographyToolStripMenuItem, Me.FileCopyToolStripMenuItem, Me.FileHidingToolStripMenuItem})
        Me.CryptographyToolStripMenuItem.Name = "CryptographyToolStripMenuItem"
        Me.CryptographyToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.CryptographyToolStripMenuItem.Text = "Cryptography"
        '
        'FileCrytographyToolStripMenuItem
        '
        Me.FileCrytographyToolStripMenuItem.Name = "FileCrytographyToolStripMenuItem"
        Me.FileCrytographyToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.FileCrytographyToolStripMenuItem.Text = "File Securing"
        '
        'FileCopyToolStripMenuItem
        '
        Me.FileCopyToolStripMenuItem.Name = "FileCopyToolStripMenuItem"
        Me.FileCopyToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.FileCopyToolStripMenuItem.Text = "File copy"
        '
        'FileHidingToolStripMenuItem
        '
        Me.FileHidingToolStripMenuItem.Name = "FileHidingToolStripMenuItem"
        Me.FileHidingToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.FileHidingToolStripMenuItem.Text = "File Hiding"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HorizontalTileToolStripMenuItem, Me.VerticalTileToolStripMenuItem, Me.CascadeToolStripMenuItem})
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.WindowsToolStripMenuItem.Text = "Windows"
        '
        'HorizontalTileToolStripMenuItem
        '
        Me.HorizontalTileToolStripMenuItem.Name = "HorizontalTileToolStripMenuItem"
        Me.HorizontalTileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HorizontalTileToolStripMenuItem.Text = "Horizontal Tile"
        '
        'VerticalTileToolStripMenuItem
        '
        Me.VerticalTileToolStripMenuItem.Name = "VerticalTileToolStripMenuItem"
        Me.VerticalTileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VerticalTileToolStripMenuItem.Text = "Vertical Tile"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CascadeToolStripMenuItem.Text = "Cascade"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 474)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(874, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(65, 17)
        Me.ToolStripStatusLabel1.Text = "Date String"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(68, 17)
        Me.ToolStripStatusLabel2.Text = "Time String"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStripStatusLabel3.RightToLeftAutoMirrorImage = True
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(179, 17)
        Me.ToolStripStatusLabel3.Text = "Design & Created By : Team Mario"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.ToolStripButton4, Me.ToolStripSeparator4, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(874, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "ToolStripButton5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(874, 496)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GetYourPingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProtectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DriveLockerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderLockerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SysKeyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorizontalTileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerticalTileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MessengerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CryptographyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileCrytographyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents FileCopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NetworkingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileHidingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
End Class
