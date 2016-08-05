Imports System.Net
Imports System.IO
Imports System.IO.Compression
Imports Ionic.Zip


Public Class UpdaterTrigger

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        HelpOnFBImport1027.Show()
        HelpOnFBImport1027.BringToFront()
    End Sub

    Private Sub UpdateBtn_Click(sender As System.Object, e As System.EventArgs) Handles UpdateBtn.Click
        Dim checkForUpdate As New WebClient
        Application.DoEvents()
        checkForUpdate.DownloadFile("http://99.67.192.106/gtrotter/3/starship/updates/starship_update.zip", "C:\Pentelec\GT3\starship\starship_update.zip")
        Application.DoEvents()
        ExtractZIP_CompleteUpdate()
        Application.DoEvents()
        MsgBox("You must restart the browser for changes to take effect.", MsgBoxStyle.OkOnly, Title:="Restart Browser")

    End Sub

    Sub ExtractZIP_CompleteUpdate()

        Dim ZipToUnpack As String = "C:\Pentelec\GT3\starship\starship_update.zip"
        Dim UnpackDirectory As String = "C:\Pentelec\GT3\starship\"
        Using zip1 As ZipFile = ZipFile.Read(ZipToUnpack)
            Dim e As ZipEntry
            For Each e In zip1
                e.Extract(UnpackDirectory, ExtractExistingFileAction.OverwriteSilently)
            Next
        End Using
    End Sub
End Class