<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.picplayer = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.obs1 = New System.Windows.Forms.PictureBox()
        Me.obs2 = New System.Windows.Forms.PictureBox()
        Me.obs3 = New System.Windows.Forms.PictureBox()
        CType(Me.picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obs2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.obs3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picplayer
        '
        Me.picplayer.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.picplayer.Location = New System.Drawing.Point(41, 143)
        Me.picplayer.Name = "picplayer"
        Me.picplayer.Size = New System.Drawing.Size(63, 102)
        Me.picplayer.TabIndex = 0
        Me.picplayer.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(3000, 99)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 26)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'obs1
        '
        Me.obs1.BackColor = System.Drawing.Color.Red
        Me.obs1.Location = New System.Drawing.Point(211, 143)
        Me.obs1.Name = "obs1"
        Me.obs1.Size = New System.Drawing.Size(63, 102)
        Me.obs1.TabIndex = 2
        Me.obs1.TabStop = False
        '
        'obs2
        '
        Me.obs2.BackColor = System.Drawing.Color.Red
        Me.obs2.Location = New System.Drawing.Point(342, 143)
        Me.obs2.Name = "obs2"
        Me.obs2.Size = New System.Drawing.Size(63, 102)
        Me.obs2.TabIndex = 3
        Me.obs2.TabStop = False
        '
        'obs3
        '
        Me.obs3.BackColor = System.Drawing.Color.Red
        Me.obs3.Location = New System.Drawing.Point(455, 143)
        Me.obs3.Name = "obs3"
        Me.obs3.Size = New System.Drawing.Size(63, 102)
        Me.obs3.TabIndex = 4
        Me.obs3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(621, 318)
        Me.Controls.Add(Me.obs3)
        Me.Controls.Add(Me.obs2)
        Me.Controls.Add(Me.obs1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picplayer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obs2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.obs3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picplayer As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents obs1 As PictureBox
    Friend WithEvents obs2 As PictureBox
    Friend WithEvents obs3 As PictureBox
End Class
