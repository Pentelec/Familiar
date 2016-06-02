<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChalkboardTheme1027
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
        Me.ContactList = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ContactList
        '
        Me.ContactList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ContactList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ContactList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ContactList.Cursor = System.Windows.Forms.Cursors.Default
        Me.ContactList.Font = New System.Drawing.Font("AR CENA", 12.0!)
        Me.ContactList.FormattingEnabled = True
        Me.ContactList.ItemHeight = 19
        Me.ContactList.Location = New System.Drawing.Point(12, 183)
        Me.ContactList.Name = "ContactList"
        Me.ContactList.Size = New System.Drawing.Size(249, 247)
        Me.ContactList.Sorted = True
        Me.ContactList.TabIndex = 3
        '
        'ChalkboardTheme1027
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Familiar.My.Resources.Resources.cbback
        Me.ClientSize = New System.Drawing.Size(785, 605)
        Me.Controls.Add(Me.ContactList)
        Me.Font = New System.Drawing.Font("AR CENA", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ChalkboardTheme1027"
        Me.Text = "Chalkboard Library"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContactList As System.Windows.Forms.ListBox
End Class
