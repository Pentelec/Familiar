<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpOnFBImport1027
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
        Me.WebKitBrowser1 = New WebKit.WebKitBrowser()
        Me.SuspendLayout()
        '
        'WebKitBrowser1
        '
        Me.WebKitBrowser1.BackColor = System.Drawing.Color.White
        Me.WebKitBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebKitBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebKitBrowser1.Name = "WebKitBrowser1"
        Me.WebKitBrowser1.Size = New System.Drawing.Size(488, 423)
        Me.WebKitBrowser1.TabIndex = 0
        Me.WebKitBrowser1.Url = New System.Uri("https://docs.google.com/spreadsheet/viewform?formkey=dHpMcE1ITjhHOEpEOU1kdmZyWGRO" & _
                "OUE6MQ#gid=0", System.UriKind.Absolute)
        '
        'HelpOnFBImport1027
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 423)
        Me.Controls.Add(Me.WebKitBrowser1)
        Me.Name = "HelpOnFBImport1027"
        Me.Text = "Tell us more..."
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebKitBrowser1 As WebKit.WebKitBrowser
End Class
