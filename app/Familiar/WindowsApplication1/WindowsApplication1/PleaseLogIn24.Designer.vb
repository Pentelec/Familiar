﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PleaseLogIn24
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EnterButton = New System.Windows.Forms.PictureBox()
        Me.CloseThatFormNow = New System.Windows.Forms.Label()
        Me.ConnStat = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.EnterButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sign in to Familiar"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.UserNameTextBox.Font = New System.Drawing.Font("Lucida Sans", 14.0!)
        Me.UserNameTextBox.Location = New System.Drawing.Point(169, 89)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(241, 29)
        Me.UserNameTextBox.TabIndex = 2
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PasswordTextBox.Font = New System.Drawing.Font("Lucida Sans", 14.0!)
        Me.PasswordTextBox.Location = New System.Drawing.Point(169, 141)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(241, 29)
        Me.PasswordTextBox.TabIndex = 3
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(50, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "User Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(63, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Password"
        '
        'EnterButton
        '
        Me.EnterButton.BackColor = System.Drawing.Color.Transparent
        Me.EnterButton.BackgroundImage = Global.Familiar.My.Resources.Resources.Enter1
        Me.EnterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.EnterButton.Location = New System.Drawing.Point(427, 99)
        Me.EnterButton.Name = "EnterButton"
        Me.EnterButton.Size = New System.Drawing.Size(115, 58)
        Me.EnterButton.TabIndex = 6
        Me.EnterButton.TabStop = False
        '
        'CloseThatFormNow
        '
        Me.CloseThatFormNow.AutoSize = True
        Me.CloseThatFormNow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseThatFormNow.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CloseThatFormNow.ForeColor = System.Drawing.Color.White
        Me.CloseThatFormNow.Location = New System.Drawing.Point(507, 0)
        Me.CloseThatFormNow.Name = "CloseThatFormNow"
        Me.CloseThatFormNow.Size = New System.Drawing.Size(35, 16)
        Me.CloseThatFormNow.TabIndex = 7
        Me.CloseThatFormNow.Text = "  X  "
        '
        'ConnStat
        '
        Me.ConnStat.BackColor = System.Drawing.Color.Transparent
        Me.ConnStat.Font = New System.Drawing.Font("Lucida Sans", 8.25!)
        Me.ConnStat.Location = New System.Drawing.Point(3, 210)
        Me.ConnStat.Name = "ConnStat"
        Me.ConnStat.Size = New System.Drawing.Size(550, 54)
        Me.ConnStat.TabIndex = 8
        Me.ConnStat.Text = "Attempting to connect...please wait."
        Me.ConnStat.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Familiar.My.Resources.Resources.WhatNewFamiliarGASPLogo2181
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(6, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 43)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(65, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Hopefully very soon, with your help!"
        '
        'PleaseLogIn24
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familiar.My.Resources.Resources.nuevo_LtBlA
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(565, 273)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ConnStat)
        Me.Controls.Add(Me.CloseThatFormNow)
        Me.Controls.Add(Me.EnterButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PleaseLogIn24"
        Me.Text = "PleaseLogIn24"
        CType(Me.EnterButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EnterButton As System.Windows.Forms.PictureBox
    Friend WithEvents CloseThatFormNow As System.Windows.Forms.Label
    Friend WithEvents ConnStat As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
