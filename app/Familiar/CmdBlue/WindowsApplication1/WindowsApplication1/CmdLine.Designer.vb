<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CmdLine
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
        Me.Inquiry = New System.Windows.Forms.TextBox()
        Me.Result = New System.Windows.Forms.Label()
        Me.InquiryInsert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Inquiry
        '
        Me.Inquiry.BackColor = System.Drawing.Color.Black
        Me.Inquiry.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inquiry.ForeColor = System.Drawing.Color.White
        Me.Inquiry.Location = New System.Drawing.Point(12, 12)
        Me.Inquiry.Name = "Inquiry"
        Me.Inquiry.Size = New System.Drawing.Size(598, 21)
        Me.Inquiry.TabIndex = 0
        '
        'Result
        '
        Me.Result.Font = New System.Drawing.Font("OCR A Extended", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result.ForeColor = System.Drawing.Color.White
        Me.Result.Location = New System.Drawing.Point(12, 75)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(598, 54)
        Me.Result.TabIndex = 1
        Me.Result.Text = "Label1"
        '
        'InquiryInsert
        '
        Me.InquiryInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InquiryInsert.Font = New System.Drawing.Font("OCR A Extended", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InquiryInsert.ForeColor = System.Drawing.Color.White
        Me.InquiryInsert.Location = New System.Drawing.Point(535, 39)
        Me.InquiryInsert.Name = "InquiryInsert"
        Me.InquiryInsert.Size = New System.Drawing.Size(75, 23)
        Me.InquiryInsert.TabIndex = 2
        Me.InquiryInsert.Text = "Enter"
        Me.InquiryInsert.UseVisualStyleBackColor = True
        '
        'CmdLine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(622, 147)
        Me.Controls.Add(Me.InquiryInsert)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Inquiry)
        Me.Name = "CmdLine"
        Me.Text = "Command Line | Pentelec Familiar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Inquiry As System.Windows.Forms.TextBox
    Friend WithEvents Result As System.Windows.Forms.Label
    Friend WithEvents InquiryInsert As System.Windows.Forms.Button
End Class
