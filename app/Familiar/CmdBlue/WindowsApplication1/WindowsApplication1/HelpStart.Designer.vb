<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpStart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpStart))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextHelp = New System.Windows.Forms.Button()
        Me.GetStartVid = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Wasco Sans", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(372, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to Help"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Familiar.My.Resources.Resources.postitle4
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 110)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TextHelp
        '
        Me.TextHelp.Font = New System.Drawing.Font("Wasco Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextHelp.Location = New System.Drawing.Point(148, 196)
        Me.TextHelp.Name = "TextHelp"
        Me.TextHelp.Size = New System.Drawing.Size(376, 47)
        Me.TextHelp.TabIndex = 2
        Me.TextHelp.Text = "Show Text Help"
        Me.TextHelp.UseVisualStyleBackColor = True
        '
        'GetStartVid
        '
        Me.GetStartVid.Font = New System.Drawing.Font("Wasco Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GetStartVid.Location = New System.Drawing.Point(148, 279)
        Me.GetStartVid.Name = "GetStartVid"
        Me.GetStartVid.Size = New System.Drawing.Size(376, 47)
        Me.GetStartVid.TabIndex = 3
        Me.GetStartVid.Text = "Getting Started (Video)"
        Me.GetStartVid.UseVisualStyleBackColor = True
        '
        'HelpStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familiar.My.Resources.Resources.plec_leather020041511
        Me.ClientSize = New System.Drawing.Size(672, 430)
        Me.Controls.Add(Me.GetStartVid)
        Me.Controls.Add(Me.TextHelp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HelpStart"
        Me.Text = "Welcome to Help"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextHelp As System.Windows.Forms.Button
    Friend WithEvents GetStartVid As System.Windows.Forms.Button
End Class
