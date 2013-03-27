<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.CrystalClearThemeContainer1 = New WindowsApplication1.CrystalClearThemeContainer()
        Me.CrystalClearControlBox1 = New WindowsApplication1.CrystalClearControlBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalClearButton1 = New WindowsApplication1.CrystalClearButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CrystalClearThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalClearThemeContainer1
        '
        Me.CrystalClearThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CrystalClearThemeContainer1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.CrystalClearThemeContainer1.Controls.Add(Me.CrystalClearControlBox1)
        Me.CrystalClearThemeContainer1.Controls.Add(Me.ListBox1)
        Me.CrystalClearThemeContainer1.Controls.Add(Me.Label1)
        Me.CrystalClearThemeContainer1.Controls.Add(Me.CrystalClearButton1)
        Me.CrystalClearThemeContainer1.Customization = "5ubm/9LS0v/m5ub/5ubm/6qqqv8="
        Me.CrystalClearThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalClearThemeContainer1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CrystalClearThemeContainer1.Image = Nothing
        Me.CrystalClearThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalClearThemeContainer1.MinimumSize = New System.Drawing.Size(175, 150)
        Me.CrystalClearThemeContainer1.Movable = True
        Me.CrystalClearThemeContainer1.Name = "CrystalClearThemeContainer1"
        Me.CrystalClearThemeContainer1.NoRounding = False
        Me.CrystalClearThemeContainer1.Rounding = WindowsApplication1.CrystalClearThemeContainer.RoundingType.None
        Me.CrystalClearThemeContainer1.Sizable = True
        Me.CrystalClearThemeContainer1.Size = New System.Drawing.Size(662, 381)
        Me.CrystalClearThemeContainer1.SmartBounds = True
        Me.CrystalClearThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.CrystalClearThemeContainer1.TabIndex = 0
        Me.CrystalClearThemeContainer1.Text = "Web History"
        Me.CrystalClearThemeContainer1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.CrystalClearThemeContainer1.Transparent = False
        '
        'CrystalClearControlBox1
        '
        Me.CrystalClearControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalClearControlBox1.Customization = "ZGRk/+fn5/+lpaX/8PDw/w=="
        Me.CrystalClearControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CrystalClearControlBox1.Image = Nothing
        Me.CrystalClearControlBox1.Location = New System.Drawing.Point(575, 3)
        Me.CrystalClearControlBox1.Name = "CrystalClearControlBox1"
        Me.CrystalClearControlBox1.NoRounding = False
        Me.CrystalClearControlBox1.Size = New System.Drawing.Size(84, 18)
        Me.CrystalClearControlBox1.TabIndex = 4
        Me.CrystalClearControlBox1.Text = "CrystalClearControlBox1"
        Me.CrystalClearControlBox1.Transparent = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(13, 73)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(637, 290)
        Me.ListBox1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Recently Viewed Webpages"
        '
        'CrystalClearButton1
        '
        Me.CrystalClearButton1.Customization = "5ubm/9LS0v/m5ub/qqqq/wAAAP//////"
        Me.CrystalClearButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CrystalClearButton1.Image = Nothing
        Me.CrystalClearButton1.Location = New System.Drawing.Point(505, 32)
        Me.CrystalClearButton1.Name = "CrystalClearButton1"
        Me.CrystalClearButton1.NoRounding = False
        Me.CrystalClearButton1.Size = New System.Drawing.Size(145, 25)
        Me.CrystalClearButton1.TabIndex = 1
        Me.CrystalClearButton1.Text = "Clear History"
        Me.CrystalClearButton1.Transparent = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 381)
        Me.Controls.Add(Me.CrystalClearThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(175, 150)
        Me.Name = "Form6"
        Me.Text = "Web History"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.CrystalClearThemeContainer1.ResumeLayout(False)
        Me.CrystalClearThemeContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalClearThemeContainer1 As WindowsApplication1.CrystalClearThemeContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CrystalClearButton1 As WindowsApplication1.CrystalClearButton
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CrystalClearControlBox1 As WindowsApplication1.CrystalClearControlBox
End Class
