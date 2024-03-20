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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ReelControl3 = New SlotMachine.ReelControl()
        Me.ReelControl2 = New SlotMachine.ReelControl()
        Me.ReelControl1 = New SlotMachine.ReelControl()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.BackgroundImage = CType(resources.GetObject("StartButton.BackgroundImage"), System.Drawing.Image)
        Me.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StartButton.Location = New System.Drawing.Point(454, 359)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(108, 58)
        Me.StartButton.TabIndex = 1
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(228, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(325, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(425, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Label3"
        '
        'ReelControl3
        '
        Me.ReelControl3.itemValue = 0
        Me.ReelControl3.Location = New System.Drawing.Point(408, 206)
        Me.ReelControl3.Name = "ReelControl3"
        Me.ReelControl3.Size = New System.Drawing.Size(77, 91)
        Me.ReelControl3.spinTime = 2000
        Me.ReelControl3.TabIndex = 4
        '
        'ReelControl2
        '
        Me.ReelControl2.itemValue = 0
        Me.ReelControl2.Location = New System.Drawing.Point(311, 206)
        Me.ReelControl2.Name = "ReelControl2"
        Me.ReelControl2.Size = New System.Drawing.Size(75, 91)
        Me.ReelControl2.spinTime = 2000
        Me.ReelControl2.TabIndex = 3
        '
        'ReelControl1
        '
        Me.ReelControl1.itemValue = 0
        Me.ReelControl1.Location = New System.Drawing.Point(213, 206)
        Me.ReelControl1.Name = "ReelControl1"
        Me.ReelControl1.Size = New System.Drawing.Size(73, 91)
        Me.ReelControl1.spinTime = 2000
        Me.ReelControl1.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Location = New System.Drawing.Point(718, 75)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 70)
        Me.Button4.TabIndex = 12
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(718, 151)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 70)
        Me.Button3.TabIndex = 11
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(718, 227)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 70)
        Me.Button2.TabIndex = 10
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(718, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 70)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(378, 380)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(42, 16)
        Me.TotalLabel.TabIndex = 13
        Me.TotalLabel.Text = "Credit"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(65, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(593, 437)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReelControl3)
        Me.Controls.Add(Me.ReelControl2)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.ReelControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReelControl1 As ReelControl
    Friend WithEvents StartButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ReelControl2 As ReelControl
    Friend WithEvents ReelControl3 As ReelControl
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TotalLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
