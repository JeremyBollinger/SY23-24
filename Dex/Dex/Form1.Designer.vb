Imports System.IO

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
        Me.BrandTextBox = New System.Windows.Forms.TextBox()
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.YearTextBox = New System.Windows.Forms.TextBox()
        Me.MileageTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BrandLabel = New System.Windows.Forms.Label()
        Me.ModelLabel = New System.Windows.Forms.Label()
        Me.YearLabel = New System.Windows.Forms.Label()
        Me.MileageLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BrandTextBox
        '
        Me.BrandTextBox.Location = New System.Drawing.Point(166, 163)
        Me.BrandTextBox.Name = "BrandTextBox"
        Me.BrandTextBox.Size = New System.Drawing.Size(205, 22)
        Me.BrandTextBox.TabIndex = 0
        '
        'ModelTextBox
        '
        Me.ModelTextBox.Location = New System.Drawing.Point(166, 206)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(205, 22)
        Me.ModelTextBox.TabIndex = 1
        '
        'YearTextBox
        '
        Me.YearTextBox.Location = New System.Drawing.Point(166, 249)
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.Size = New System.Drawing.Size(205, 22)
        Me.YearTextBox.TabIndex = 2
        '
        'MileageTextBox
        '
        Me.MileageTextBox.Location = New System.Drawing.Point(166, 292)
        Me.MileageTextBox.Name = "MileageTextBox"
        Me.MileageTextBox.Size = New System.Drawing.Size(205, 22)
        Me.MileageTextBox.TabIndex = 3
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(166, 335)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(205, 22)
        Me.PriceTextBox.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Location = New System.Drawing.Point(143, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(251, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BrandLabel
        '
        Me.BrandLabel.AutoSize = True
        Me.BrandLabel.Location = New System.Drawing.Point(87, 169)
        Me.BrandLabel.Name = "BrandLabel"
        Me.BrandLabel.Size = New System.Drawing.Size(46, 16)
        Me.BrandLabel.TabIndex = 7
        Me.BrandLabel.Text = "Brand:"
        '
        'ModelLabel
        '
        Me.ModelLabel.AutoSize = True
        Me.ModelLabel.Location = New System.Drawing.Point(85, 212)
        Me.ModelLabel.Name = "ModelLabel"
        Me.ModelLabel.Size = New System.Drawing.Size(48, 16)
        Me.ModelLabel.TabIndex = 8
        Me.ModelLabel.Text = "Model:"
        '
        'YearLabel
        '
        Me.YearLabel.AutoSize = True
        Me.YearLabel.Location = New System.Drawing.Point(94, 255)
        Me.YearLabel.Name = "YearLabel"
        Me.YearLabel.Size = New System.Drawing.Size(39, 16)
        Me.YearLabel.TabIndex = 9
        Me.YearLabel.Text = "Year:"
        '
        'MileageLabel
        '
        Me.MileageLabel.AutoSize = True
        Me.MileageLabel.Location = New System.Drawing.Point(67, 298)
        Me.MileageLabel.Name = "MileageLabel"
        Me.MileageLabel.Size = New System.Drawing.Size(59, 16)
        Me.MileageLabel.TabIndex = 10
        Me.MileageLabel.Text = "Mileage:"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Location = New System.Drawing.Point(92, 341)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(41, 16)
        Me.PriceLabel.TabIndex = 11
        Me.PriceLabel.Text = "Price:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 30)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.SaveToolStripMenuItem1})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(51, 26)
        Me.NewToolStripMenuItem.Text = "Cars"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SaveToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem1
        '
        Me.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        Me.SaveToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.SaveToolStripMenuItem1.Text = "Save"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PriceLabel)
        Me.Controls.Add(Me.MileageLabel)
        Me.Controls.Add(Me.YearLabel)
        Me.Controls.Add(Me.ModelLabel)
        Me.Controls.Add(Me.BrandLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.MileageTextBox)
        Me.Controls.Add(Me.YearTextBox)
        Me.Controls.Add(Me.ModelTextBox)
        Me.Controls.Add(Me.BrandTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BrandTextBox As TextBox
    Friend WithEvents ModelTextBox As TextBox
    Friend WithEvents YearTextBox As TextBox
    Friend WithEvents MileageTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BrandLabel As Label
    Friend WithEvents ModelLabel As Label
    Friend WithEvents YearLabel As Label
    Friend WithEvents MileageLabel As Label
    Friend WithEvents PriceLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem1 As ToolStripMenuItem

    Dim records(50) As String
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        PictureBox1.Image = Nothing
        BrandTextBox.Text = ""
        ModelTextBox.Text = ""
        YearTextBox.Text = ""
        MileageTextBox.Text = ""
        PriceTextBox.Text = ""

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim outfile As New IO.StreamWriter("data.txt")
        outfile.Write(BrandTextBox.Text)
        outfile.Write("|")
        outfile.Write(ModelTextBox.Text)
        outfile.Write("|")
        outfile.Write(YearTextBox.Text)
        outfile.Write("|")
        outfile.Write(MileageTextBox.Text)
        outfile.Write("|")
        outfile.Write(PriceTextBox.Text)
        outfile.Write("|")
        outfile.Write(PictureBox1.ImageLocation)
        outfile.WriteLine()
        outfile.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("data.txt") Then
            Dim infile As New StreamReader("data.txt")
            records(0) = infile.ReadLine
            records(1) = infile.ReadLine
            infile.Close()
        End If
    End Sub
End Class
