<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoinSlot
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CoinSlot))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.NickelButton = New System.Windows.Forms.Button()
        Me.DimeButton = New System.Windows.Forms.Button()
        Me.QuarterButton = New System.Windows.Forms.Button()
        Me.DollarButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(79, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 70)
        Me.Button2.TabIndex = 10
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Location = New System.Drawing.Point(3, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(70, 70)
        Me.Button5.TabIndex = 9
        Me.Button5.UseVisualStyleBackColor = True
        '
        'NickelButton
        '
        Me.NickelButton.BackgroundImage = CType(resources.GetObject("NickelButton.BackgroundImage"), System.Drawing.Image)
        Me.NickelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.NickelButton.Location = New System.Drawing.Point(231, 3)
        Me.NickelButton.Name = "NickelButton"
        Me.NickelButton.Size = New System.Drawing.Size(70, 70)
        Me.NickelButton.TabIndex = 14
        Me.NickelButton.UseVisualStyleBackColor = True
        '
        'DimeButton
        '
        Me.DimeButton.BackgroundImage = CType(resources.GetObject("DimeButton.BackgroundImage"), System.Drawing.Image)
        Me.DimeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DimeButton.Location = New System.Drawing.Point(155, 3)
        Me.DimeButton.Name = "DimeButton"
        Me.DimeButton.Size = New System.Drawing.Size(70, 70)
        Me.DimeButton.TabIndex = 13
        Me.DimeButton.UseVisualStyleBackColor = True
        '
        'QuarterButton
        '
        Me.QuarterButton.BackgroundImage = CType(resources.GetObject("QuarterButton.BackgroundImage"), System.Drawing.Image)
        Me.QuarterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuarterButton.Location = New System.Drawing.Point(79, 3)
        Me.QuarterButton.Name = "QuarterButton"
        Me.QuarterButton.Size = New System.Drawing.Size(70, 70)
        Me.QuarterButton.TabIndex = 12
        Me.QuarterButton.UseVisualStyleBackColor = True
        '
        'DollarButton
        '
        Me.DollarButton.BackgroundImage = CType(resources.GetObject("DollarButton.BackgroundImage"), System.Drawing.Image)
        Me.DollarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DollarButton.Location = New System.Drawing.Point(3, 3)
        Me.DollarButton.Name = "DollarButton"
        Me.DollarButton.Size = New System.Drawing.Size(70, 70)
        Me.DollarButton.TabIndex = 11
        Me.DollarButton.UseVisualStyleBackColor = True
        '
        'CoinSlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.NickelButton)
        Me.Controls.Add(Me.DimeButton)
        Me.Controls.Add(Me.QuarterButton)
        Me.Controls.Add(Me.DollarButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button5)
        Me.Name = "CoinSlot"
        Me.Size = New System.Drawing.Size(332, 101)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents NickelButton As Button
    Friend WithEvents DimeButton As Button
    Friend WithEvents QuarterButton As Button
    Friend WithEvents DollarButton As Button
End Class
