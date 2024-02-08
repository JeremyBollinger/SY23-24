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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FIleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BrandTextbox = New System.Windows.Forms.TextBox()
        Me.ModelTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.YearTextbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MilageTextbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PriceTextbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FirstButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.LastButton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FIleToolStripMenuItem
        '
        Me.FIleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FIleToolStripMenuItem.Name = "FIleToolStripMenuItem"
        Me.FIleToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.FIleToolStripMenuItem.Text = "Cars"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(132, 34)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(23, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Brand:"
        '
        'BrandTextbox
        '
        Me.BrandTextbox.Location = New System.Drawing.Point(132, 146)
        Me.BrandTextbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BrandTextbox.Name = "BrandTextbox"
        Me.BrandTextbox.Size = New System.Drawing.Size(286, 22)
        Me.BrandTextbox.TabIndex = 3
        '
        'ModelTextbox
        '
        Me.ModelTextbox.Location = New System.Drawing.Point(132, 172)
        Me.ModelTextbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ModelTextbox.Name = "ModelTextbox"
        Me.ModelTextbox.Size = New System.Drawing.Size(286, 22)
        Me.ModelTextbox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(23, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Model:"
        '
        'YearTextbox
        '
        Me.YearTextbox.Location = New System.Drawing.Point(132, 198)
        Me.YearTextbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.YearTextbox.Name = "YearTextbox"
        Me.YearTextbox.Size = New System.Drawing.Size(286, 22)
        Me.YearTextbox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(23, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Year:"
        '
        'MilageTextbox
        '
        Me.MilageTextbox.Location = New System.Drawing.Point(132, 225)
        Me.MilageTextbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MilageTextbox.Name = "MilageTextbox"
        Me.MilageTextbox.Size = New System.Drawing.Size(286, 22)
        Me.MilageTextbox.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(23, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Milage:"
        '
        'PriceTextbox
        '
        Me.PriceTextbox.Location = New System.Drawing.Point(132, 251)
        Me.PriceTextbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PriceTextbox.Name = "PriceTextbox"
        Me.PriceTextbox.Size = New System.Drawing.Size(286, 22)
        Me.PriceTextbox.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(23, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Price:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FirstButton
        '
        Me.FirstButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FirstButton.Location = New System.Drawing.Point(324, 34)
        Me.FirstButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FirstButton.Name = "FirstButton"
        Me.FirstButton.Size = New System.Drawing.Size(94, 23)
        Me.FirstButton.TabIndex = 12
        Me.FirstButton.Text = "First"
        Me.FirstButton.UseVisualStyleBackColor = False
        '
        'PreviousButton
        '
        Me.PreviousButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PreviousButton.Location = New System.Drawing.Point(324, 90)
        Me.PreviousButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(94, 23)
        Me.PreviousButton.TabIndex = 13
        Me.PreviousButton.Text = "Previous"
        Me.PreviousButton.UseVisualStyleBackColor = False
        '
        'NextButton
        '
        Me.NextButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NextButton.Location = New System.Drawing.Point(324, 62)
        Me.NextButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(94, 23)
        Me.NextButton.TabIndex = 14
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = False
        '
        'LastButton
        '
        Me.LastButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LastButton.Location = New System.Drawing.Point(324, 118)
        Me.LastButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LastButton.Name = "LastButton"
        Me.LastButton.Size = New System.Drawing.Size(94, 23)
        Me.LastButton.TabIndex = 15
        Me.LastButton.Text = "Last"
        Me.LastButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(800, 360)
        Me.Controls.Add(Me.LastButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.FirstButton)
        Me.Controls.Add(Me.PriceTextbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MilageTextbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.YearTextbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ModelTextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BrandTextbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FIleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BrandTextbox As TextBox
    Friend WithEvents ModelTextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents YearTextbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MilageTextbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PriceTextbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FirstButton As Button
    Friend WithEvents PreviousButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents LastButton As Button
End Class