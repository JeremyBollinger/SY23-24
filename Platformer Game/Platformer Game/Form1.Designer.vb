<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm2DPlatformer
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm2DPlatformer))
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picAir = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ghostpicturebox = New System.Windows.Forms.PictureBox()
        Me.orangeGhostPictureBox = New System.Windows.Forms.PictureBox()
        Me.blueGhostPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PinkGhostPictureBox = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Mover1 = New Platformer_Game.mover()
        Me.Mover2 = New Platformer_Game.mover()
        Me.Mover3 = New Platformer_Game.mover()
        Me.Mover4 = New Platformer_Game.mover()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ghostpicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.orangeGhostPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blueGhostPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PinkGhostPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Black
        Me.picPlayer.Image = CType(resources.GetObject("picPlayer.Image"), System.Drawing.Image)
        Me.picPlayer.Location = New System.Drawing.Point(23, 332)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(57, 50)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'picAir
        '
        Me.picAir.BackColor = System.Drawing.Color.Black
        Me.picAir.Location = New System.Drawing.Point(2, 0)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(795, 427)
        Me.picAir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAir.TabIndex = 1
        Me.picAir.TabStop = False
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.Black
        Me.picGround.BackgroundImage = CType(resources.GetObject("picGround.BackgroundImage"), System.Drawing.Image)
        Me.picGround.Location = New System.Drawing.Point(2, 380)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(795, 58)
        Me.picGround.TabIndex = 2
        Me.picGround.TabStop = False
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 30
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 30
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 30
        '
        'tmrGameLogic
        '
        Me.tmrGameLogic.Interval = 20
        '
        'tmrGravity
        '
        Me.tmrGravity.Interval = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Location = New System.Drawing.Point(411, 260)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 10)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Red
        Me.PictureBox2.Location = New System.Drawing.Point(38, 262)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(121, 10)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Red
        Me.PictureBox3.Location = New System.Drawing.Point(211, 173)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(121, 10)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'ghostpicturebox
        '
        Me.ghostpicturebox.Image = CType(resources.GetObject("ghostpicturebox.Image"), System.Drawing.Image)
        Me.ghostpicturebox.Location = New System.Drawing.Point(68, 226)
        Me.ghostpicturebox.Name = "ghostpicturebox"
        Me.ghostpicturebox.Size = New System.Drawing.Size(48, 51)
        Me.ghostpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ghostpicturebox.TabIndex = 9
        Me.ghostpicturebox.TabStop = False
        '
        'orangeGhostPictureBox
        '
        Me.orangeGhostPictureBox.Image = CType(resources.GetObject("orangeGhostPictureBox.Image"), System.Drawing.Image)
        Me.orangeGhostPictureBox.Location = New System.Drawing.Point(241, 144)
        Me.orangeGhostPictureBox.Name = "orangeGhostPictureBox"
        Me.orangeGhostPictureBox.Size = New System.Drawing.Size(56, 50)
        Me.orangeGhostPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.orangeGhostPictureBox.TabIndex = 12
        Me.orangeGhostPictureBox.TabStop = False
        '
        'blueGhostPictureBox
        '
        Me.blueGhostPictureBox.Image = CType(resources.GetObject("blueGhostPictureBox.Image"), System.Drawing.Image)
        Me.blueGhostPictureBox.Location = New System.Drawing.Point(406, 235)
        Me.blueGhostPictureBox.Name = "blueGhostPictureBox"
        Me.blueGhostPictureBox.Size = New System.Drawing.Size(54, 59)
        Me.blueGhostPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.blueGhostPictureBox.TabIndex = 14
        Me.blueGhostPictureBox.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Red
        Me.PictureBox4.Location = New System.Drawing.Point(608, 173)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(121, 10)
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "bound"
        '
        'PinkGhostPictureBox
        '
        Me.PinkGhostPictureBox.Image = CType(resources.GetObject("PinkGhostPictureBox.Image"), System.Drawing.Image)
        Me.PinkGhostPictureBox.Location = New System.Drawing.Point(648, 152)
        Me.PinkGhostPictureBox.Name = "PinkGhostPictureBox"
        Me.PinkGhostPictureBox.Size = New System.Drawing.Size(57, 50)
        Me.PinkGhostPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PinkGhostPictureBox.TabIndex = 17
        Me.PinkGhostPictureBox.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(2, 416)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(20, 22)
        Me.TextBox1.TabIndex = 8
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.Transparent
        Me.Mover1.interval = 500
        Me.Mover1.Location = New System.Drawing.Point(38, 231)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(124, 23)
        Me.Mover1.speed = 10
        Me.Mover1.sprite = Me.ghostpicturebox
        Me.Mover1.TabIndex = 10
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.Color.Transparent
        Me.Mover2.interval = 500
        Me.Mover2.Location = New System.Drawing.Point(211, 149)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(121, 18)
        Me.Mover2.speed = 10
        Me.Mover2.sprite = Me.orangeGhostPictureBox
        Me.Mover2.TabIndex = 11
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.Color.Transparent
        Me.Mover3.interval = 500
        Me.Mover3.Location = New System.Drawing.Point(411, 240)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(121, 14)
        Me.Mover3.speed = 10
        Me.Mover3.sprite = Me.blueGhostPictureBox
        Me.Mover3.TabIndex = 13
        '
        'Mover4
        '
        Me.Mover4.BackColor = System.Drawing.Color.Transparent
        Me.Mover4.interval = 500
        Me.Mover4.Location = New System.Drawing.Point(608, 157)
        Me.Mover4.Name = "Mover4"
        Me.Mover4.Size = New System.Drawing.Size(121, 10)
        Me.Mover4.speed = 10
        Me.Mover4.sprite = Me.PinkGhostPictureBox
        Me.Mover4.TabIndex = 16
        '
        'frm2DPlatformer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PinkGhostPictureBox)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.blueGhostPictureBox)
        Me.Controls.Add(Me.orangeGhostPictureBox)
        Me.Controls.Add(Me.ghostpicturebox)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.picAir)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.Mover4)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frm2DPlatformer"
        Me.Text = "Form1"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ghostpicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.orangeGhostPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blueGhostPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PinkGhostPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picAir As PictureBox
    Friend WithEvents picGround As PictureBox
    Friend WithEvents tmrRight As Timer


    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrGameLogic As Timer
    Friend WithEvents tmrGravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ghostpicturebox As PictureBox
    Friend WithEvents Mover1 As mover
    Friend WithEvents Mover2 As mover
    Friend WithEvents orangeGhostPictureBox As PictureBox
    Friend WithEvents Mover3 As mover
    Friend WithEvents blueGhostPictureBox As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Mover4 As mover
    Friend WithEvents PinkGhostPictureBox As PictureBox
    Friend WithEvents TextBox1 As TextBox
End Class
