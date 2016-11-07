<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class messenger
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtcomputer = New System.Windows.Forms.TextBox()
        Me.txtmessage = New System.Windows.Forms.TextBox()
        Me.CmdSendAll = New System.Windows.Forms.Button()
        Me.CmdSend = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 41)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "MESSENGER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(236, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "IP ADDRESS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(284, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NAME"
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(12, 69)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(218, 238)
        Me.TreeView1.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(350, 112)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(138, 20)
        Me.TextBox1.TabIndex = 6
        '
        'txtcomputer
        '
        Me.txtcomputer.Location = New System.Drawing.Point(350, 144)
        Me.txtcomputer.Name = "txtcomputer"
        Me.txtcomputer.ReadOnly = True
        Me.txtcomputer.Size = New System.Drawing.Size(138, 20)
        Me.txtcomputer.TabIndex = 7
        '
        'txtmessage
        '
        Me.txtmessage.Location = New System.Drawing.Point(12, 332)
        Me.txtmessage.Multiline = True
        Me.txtmessage.Name = "txtmessage"
        Me.txtmessage.Size = New System.Drawing.Size(288, 83)
        Me.txtmessage.TabIndex = 8
        '
        'CmdSendAll
        '
        Me.CmdSendAll.Location = New System.Drawing.Point(320, 332)
        Me.CmdSendAll.Name = "CmdSendAll"
        Me.CmdSendAll.Size = New System.Drawing.Size(76, 36)
        Me.CmdSendAll.TabIndex = 9
        Me.CmdSendAll.Text = "SEND ALL"
        Me.CmdSendAll.UseVisualStyleBackColor = True
        '
        'CmdSend
        '
        Me.CmdSend.Location = New System.Drawing.Point(320, 379)
        Me.CmdSend.Name = "CmdSend"
        Me.CmdSend.Size = New System.Drawing.Size(76, 36)
        Me.CmdSend.TabIndex = 10
        Me.CmdSend.Text = "SEND"
        Me.CmdSend.UseVisualStyleBackColor = True
        '
        'messenger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 427)
        Me.Controls.Add(Me.CmdSend)
        Me.Controls.Add(Me.CmdSendAll)
        Me.Controls.Add(Me.txtmessage)
        Me.Controls.Add(Me.txtcomputer)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "messenger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "messenger"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtcomputer As TextBox
    Friend WithEvents txtmessage As TextBox
    Friend WithEvents CmdSendAll As Button
    Friend WithEvents CmdSend As Button
End Class
