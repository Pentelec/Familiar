<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeedForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FeedForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SomethingIs1 = New System.Windows.Forms.RadioButton()
        Me.SomethingIsGood = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TheWrittenFeedback = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ScreenShotPic = New System.Windows.Forms.PictureBox()
        Me.SendCompSpecs = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SendLeName = New System.Windows.Forms.CheckBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.SendLeEmail = New System.Windows.Forms.CheckBox()
        Me.SumbitALot = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScreenShotPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tell us about your experience."
        '
        'SomethingIs1
        '
        Me.SomethingIs1.AutoSize = True
        Me.SomethingIs1.BackColor = System.Drawing.Color.Transparent
        Me.SomethingIs1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SomethingIs1.Location = New System.Drawing.Point(16, 65)
        Me.SomethingIs1.Name = "SomethingIs1"
        Me.SomethingIs1.Size = New System.Drawing.Size(138, 19)
        Me.SomethingIs1.TabIndex = 2
        Me.SomethingIs1.TabStop = True
        Me.SomethingIs1.Text = "Something is bad."
        Me.SomethingIs1.UseVisualStyleBackColor = False
        '
        'SomethingIsGood
        '
        Me.SomethingIsGood.AutoSize = True
        Me.SomethingIsGood.BackColor = System.Drawing.Color.Transparent
        Me.SomethingIsGood.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SomethingIsGood.Location = New System.Drawing.Point(16, 88)
        Me.SomethingIsGood.Name = "SomethingIsGood"
        Me.SomethingIsGood.Size = New System.Drawing.Size(149, 19)
        Me.SomethingIsGood.TabIndex = 3
        Me.SomethingIsGood.TabStop = True
        Me.SomethingIsGood.Text = "Something is good."
        Me.SomethingIsGood.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Write about it:"
        '
        'TheWrittenFeedback
        '
        Me.TheWrittenFeedback.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TheWrittenFeedback.Location = New System.Drawing.Point(16, 151)
        Me.TheWrittenFeedback.Multiline = True
        Me.TheWrittenFeedback.Name = "TheWrittenFeedback"
        Me.TheWrittenFeedback.Size = New System.Drawing.Size(713, 172)
        Me.TheWrittenFeedback.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(246, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Send us a screenshot:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 10.25!)
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(12, 361)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Optional"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Familiar.My.Resources.Resources.IsThis218
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(488, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 103)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ScreenShotPic
        '
        Me.ScreenShotPic.BackgroundImage = Global.Familiar.My.Resources.Resources.PlusAdd
        Me.ScreenShotPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ScreenShotPic.Location = New System.Drawing.Point(16, 380)
        Me.ScreenShotPic.Name = "ScreenShotPic"
        Me.ScreenShotPic.Size = New System.Drawing.Size(271, 163)
        Me.ScreenShotPic.TabIndex = 9
        Me.ScreenShotPic.TabStop = False
        '
        'SendCompSpecs
        '
        Me.SendCompSpecs.AutoSize = True
        Me.SendCompSpecs.BackColor = System.Drawing.Color.Transparent
        Me.SendCompSpecs.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendCompSpecs.Location = New System.Drawing.Point(347, 380)
        Me.SendCompSpecs.Name = "SendCompSpecs"
        Me.SendCompSpecs.Size = New System.Drawing.Size(314, 18)
        Me.SendCompSpecs.TabIndex = 10
        Me.SendCompSpecs.Text = "Send Computer Specification Information to Pentelec"
        Me.SendCompSpecs.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(343, 338)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(374, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Some more optional information:"
        '
        'SendLeName
        '
        Me.SendLeName.AutoSize = True
        Me.SendLeName.BackColor = System.Drawing.Color.Transparent
        Me.SendLeName.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendLeName.Location = New System.Drawing.Point(347, 404)
        Me.SendLeName.Name = "SendLeName"
        Me.SendLeName.Size = New System.Drawing.Size(139, 18)
        Me.SendLeName.TabIndex = 12
        Me.SendLeName.Text = "Send us your name..."
        Me.SendLeName.UseVisualStyleBackColor = False
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(488, 403)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(237, 20)
        Me.NameTextBox.TabIndex = 13
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(488, 429)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(237, 20)
        Me.EmailTextBox.TabIndex = 15
        '
        'SendLeEmail
        '
        Me.SendLeEmail.AutoSize = True
        Me.SendLeEmail.BackColor = System.Drawing.Color.Transparent
        Me.SendLeEmail.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendLeEmail.Location = New System.Drawing.Point(347, 430)
        Me.SendLeEmail.Name = "SendLeEmail"
        Me.SendLeEmail.Size = New System.Drawing.Size(138, 18)
        Me.SendLeEmail.TabIndex = 14
        Me.SendLeEmail.Text = "Send us your email..."
        Me.SendLeEmail.UseVisualStyleBackColor = False
        '
        'SumbitALot
        '
        Me.SumbitALot.BackColor = System.Drawing.Color.White
        Me.SumbitALot.BackgroundImage = Global.Familiar.My.Resources.Resources.nuevo_LtBlA
        Me.SumbitALot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SumbitALot.Font = New System.Drawing.Font("Lucida Sans", 10.25!, System.Drawing.FontStyle.Bold)
        Me.SumbitALot.Location = New System.Drawing.Point(622, 455)
        Me.SumbitALot.Name = "SumbitALot"
        Me.SumbitALot.Size = New System.Drawing.Size(103, 45)
        Me.SumbitALot.TabIndex = 16
        Me.SumbitALot.Text = "Submit"
        Me.SumbitALot.UseVisualStyleBackColor = False
        '
        'FeedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familiar.My.Resources.Resources.nuevo_LtBlA
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(741, 555)
        Me.Controls.Add(Me.SumbitALot)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.SendLeEmail)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.SendLeName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SendCompSpecs)
        Me.Controls.Add(Me.ScreenShotPic)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TheWrittenFeedback)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SomethingIsGood)
        Me.Controls.Add(Me.SomethingIs1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FeedForm"
        Me.Text = "Tell Us | Pentelec Familiar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScreenShotPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SomethingIs1 As System.Windows.Forms.RadioButton
    Friend WithEvents SomethingIsGood As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TheWrittenFeedback As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ScreenShotPic As System.Windows.Forms.PictureBox
    Friend WithEvents SendCompSpecs As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SendLeName As System.Windows.Forms.CheckBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SendLeEmail As System.Windows.Forms.CheckBox
    Friend WithEvents SumbitALot As System.Windows.Forms.Button
End Class
