<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPong
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
        Me.picBall = New System.Windows.Forms.PictureBox()
        Me.picPaddle = New System.Windows.Forms.PictureBox()
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.picBrick3 = New System.Windows.Forms.PictureBox()
        Me.picBrick2 = New System.Windows.Forms.PictureBox()
        Me.picBrick6 = New System.Windows.Forms.PictureBox()
        Me.picBrick7 = New System.Windows.Forms.PictureBox()
        Me.picBrick1 = New System.Windows.Forms.PictureBox()
        Me.picBrick5 = New System.Windows.Forms.PictureBox()
        Me.picBrick8 = New System.Windows.Forms.PictureBox()
        Me.picBrick4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBall
        '
        Me.picBall.BackColor = System.Drawing.Color.White
        Me.picBall.Location = New System.Drawing.Point(342, 132)
        Me.picBall.Name = "picBall"
        Me.picBall.Size = New System.Drawing.Size(15, 15)
        Me.picBall.TabIndex = 0
        Me.picBall.TabStop = False
        '
        'picPaddle
        '
        Me.picPaddle.BackColor = System.Drawing.Color.Blue
        Me.picPaddle.Location = New System.Drawing.Point(282, 512)
        Me.picPaddle.Name = "picPaddle"
        Me.picPaddle.Size = New System.Drawing.Size(110, 20)
        Me.picPaddle.TabIndex = 1
        Me.picPaddle.TabStop = False
        '
        'tmrGame
        '
        Me.tmrGame.Interval = 1
        '
        'picBrick3
        '
        Me.picBrick3.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.picBrick3.Location = New System.Drawing.Point(374, 29)
        Me.picBrick3.Name = "picBrick3"
        Me.picBrick3.Size = New System.Drawing.Size(90, 20)
        Me.picBrick3.TabIndex = 2
        Me.picBrick3.TabStop = False
        '
        'picBrick2
        '
        Me.picBrick2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.picBrick2.Location = New System.Drawing.Point(218, 29)
        Me.picBrick2.Name = "picBrick2"
        Me.picBrick2.Size = New System.Drawing.Size(90, 20)
        Me.picBrick2.TabIndex = 3
        Me.picBrick2.TabStop = False
        '
        'picBrick6
        '
        Me.picBrick6.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.picBrick6.Location = New System.Drawing.Point(218, 78)
        Me.picBrick6.Name = "picBrick6"
        Me.picBrick6.Size = New System.Drawing.Size(90, 20)
        Me.picBrick6.TabIndex = 4
        Me.picBrick6.TabStop = False
        '
        'picBrick7
        '
        Me.picBrick7.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.picBrick7.Location = New System.Drawing.Point(374, 78)
        Me.picBrick7.Name = "picBrick7"
        Me.picBrick7.Size = New System.Drawing.Size(90, 20)
        Me.picBrick7.TabIndex = 5
        Me.picBrick7.TabStop = False
        '
        'picBrick1
        '
        Me.picBrick1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.picBrick1.Location = New System.Drawing.Point(63, 29)
        Me.picBrick1.Name = "picBrick1"
        Me.picBrick1.Size = New System.Drawing.Size(90, 20)
        Me.picBrick1.TabIndex = 6
        Me.picBrick1.TabStop = False
        '
        'picBrick5
        '
        Me.picBrick5.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.picBrick5.Location = New System.Drawing.Point(63, 78)
        Me.picBrick5.Name = "picBrick5"
        Me.picBrick5.Size = New System.Drawing.Size(90, 20)
        Me.picBrick5.TabIndex = 7
        Me.picBrick5.TabStop = False
        '
        'picBrick8
        '
        Me.picBrick8.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.picBrick8.Location = New System.Drawing.Point(530, 78)
        Me.picBrick8.Name = "picBrick8"
        Me.picBrick8.Size = New System.Drawing.Size(90, 20)
        Me.picBrick8.TabIndex = 8
        Me.picBrick8.TabStop = False
        '
        'picBrick4
        '
        Me.picBrick4.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.picBrick4.Location = New System.Drawing.Point(530, 29)
        Me.picBrick4.Name = "picBrick4"
        Me.picBrick4.Size = New System.Drawing.Size(90, 20)
        Me.picBrick4.TabIndex = 9
        Me.picBrick4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 540)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Press ""Enter"" Key To Pause Game."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(445, 540)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Press ""Shift"" Key To Resume Game."
        '
        'frmPong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(684, 562)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picBrick4)
        Me.Controls.Add(Me.picBrick8)
        Me.Controls.Add(Me.picBrick5)
        Me.Controls.Add(Me.picBrick1)
        Me.Controls.Add(Me.picBrick7)
        Me.Controls.Add(Me.picBrick6)
        Me.Controls.Add(Me.picBrick2)
        Me.Controls.Add(Me.picBrick3)
        Me.Controls.Add(Me.picPaddle)
        Me.Controls.Add(Me.picBall)
        Me.Name = "frmPong"
        Me.Text = "Form1"
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBall As System.Windows.Forms.PictureBox
    Friend WithEvents picPaddle As System.Windows.Forms.PictureBox
    Friend WithEvents tmrGame As System.Windows.Forms.Timer
    Friend WithEvents picBrick3 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick2 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick6 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick7 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick1 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick5 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick8 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
