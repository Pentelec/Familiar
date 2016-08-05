Imports System.IO

Public Class NewContact

    Public path As String
    Public libname As String
    Dim nmCvPk As String
    Dim nmCtPk As String
    Dim nmBkPk As String

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try

        Dim lines As New List(Of String)

            Using sw As New StreamWriter(path & "\" & LastName.Text & ", " & FirstName.Text & ".pfcr")
                sw.WriteLine("FILENAME" & " " & FirstName.Text & ".pfcr" & "*")
                If nmCvPk <> "" Then
                    Library.TopPicContact.BackgroundImage = Image.FromFile(nmBkPk)
                    Library.Refresh()
                    Application.DoEvents()
                    sw.WriteLine("COVER" & " " & nmCvPk & "*")
                Else
                    sw.WriteLine("COVER normal*")
                End If

                If nmBkPk <> "" Then
                    Library.DisplayPanel.BackgroundImage = Image.FromFile(nmBkPk)
                    Library.Refresh()
                    Application.DoEvents()
                    sw.WriteLine("BACK" & " " & nmBkPk & "*")
                Else
                    sw.WriteLine("BACK normal*")
                End If

                If nmCtPk <> "" Then
                    Library.ContactPic.BackgroundImage = Image.FromFile(nmCtPk)
                    Library.Refresh()
                    Application.DoEvents()
                    sw.WriteLine("PIC" & " " & nmCtPk & "*")
                Else
                    sw.WriteLine("PIC normal*")
                End If

                sw.WriteLine("NAME" & " " & LastName.Text & ", " & FirstName.Text & "*")
                sw.WriteLine("FIRST" & " " & FirstName.Text & "*")
                sw.WriteLine("LAST" & " " & LastName.Text & "*")
                sw.WriteLine("NICKNAME" & " " & NickName.Text & "*")
                sw.WriteLine("CELL1" & " " & Cell1.Text & "*")
                sw.WriteLine("CELL2" & " " & Cell2.Text & "*")
                sw.WriteLine("HOMENU" & " " & HomeNo.Text & "*")
                sw.WriteLine("WORKNU" & " " & WorkNo.Text & "*")
                sw.WriteLine("EMAILLIST" & " " & EmailList.Text & "*")
                sw.WriteLine("ADW" & " " & AddressW.Text & "*")
                sw.WriteLine("WEBW" & " " & WebW.Text & "*")
                sw.WriteLine("JOBW" & " " & JobW.Text & "*")
                sw.WriteLine("DEPTW" & " " & DeptW.Text & "*")
                sw.WriteLine("OFFICEW" & " " & OfficeW.Text & "*")
                sw.WriteLine("CITYW" & " " & CityW.Text & "*")
                sw.WriteLine("STATEW" & " " & StateW.Text & "*")
                sw.WriteLine("POSTW" & " " & PostW.Text & "*")
                sw.WriteLine("ADH" & " " & AddressH.Text & "*")
                sw.WriteLine("FB" & " " & FB.Text & "*")
                sw.WriteLine("TWI" & " " & Twi.Text & "*")
                sw.WriteLine("OTHERSOC" & " " & OtherH.Text & "*")
                sw.WriteLine("BDAY" & " " & Bday.Text & "*")
                sw.WriteLine("SPOU" & " " & Spouse.Text & "*")
                sw.WriteLine("CITYH" & " " & CityH.Text & "*")
                sw.WriteLine("STATEH" & " " & StateH.Text & "*")
                sw.WriteLine("POSTH" & " " & PostH.Text & "*")
                sw.WriteLine("NOTES====" & " " & NoteBox.Text & "*")
                sw.WriteLine("")
                sw.WriteLine("@PGen")

            End Using

            My.Computer.FileSystem.CreateDirectory(path & "\" & LastName.Text & ", " & FirstName.Text)
            My.Computer.FileSystem.WriteAllText(path & "\" & LastName.Text & ", " & FirstName.Text & "\name.txt", LastName.Text & ", " & FirstName.Text, False)

            My.Computer.FileSystem.WriteAllText(libname, vbCrLf & "INCLUDEPFCR" & " " & LastName.Text & ", " & FirstName.Text, True)

            Dim flNm As String = LastName.Text & ", " & FirstName.Text
            Library.ContactList.Items.Add(flNm)
        Library.Refresh()
        Me.Hide()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub ChangeCoverBttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeCoverBttn.Click
        Dim dlg As OpenFileDialog = New OpenFileDialog
        dlg.Title = "Open"
        dlg.Filter = "Portable Network Graphic (*.png)|*.png|JPEG Image File (*.jpg)|*.jpg|Bitmap Image File (*.bmp)|*.bmp|Graphics Interchange Format (*.gif)|.gif|All Files (*.*)|*.*"
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            nmCvPk = dlg.FileName
            TopPicContact.BackgroundImage = Image.FromFile(nmCvPk)
        End If
    End Sub

    Private Sub BackChangePic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackChangePic.Click
        Dim dlg As OpenFileDialog = New OpenFileDialog
        dlg.Title = "Open"
        dlg.Filter = "Portable Network Graphic (*.png)|*.png|JPEG Image File (*.jpg)|*.jpg|Bitmap Image File (*.bmp)|*.bmp|Graphics Interchange Format (*.gif)|.gif|All Files (*.*)|*.*"
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            nmBkPk = dlg.FileName
            DisplayPanel.BackgroundImage = Image.FromFile(nmBkPk)
        End If
    End Sub

    Private Sub ContactPicChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactPicChange.Click
        Dim dlg As OpenFileDialog = New OpenFileDialog
        dlg.Title = "Open"
        dlg.Filter = "Portable Network Graphic (*.png)|*.png|JPEG Image File (*.jpg)|*.jpg|Bitmap Image File (*.bmp)|*.bmp|Graphics Interchange Format (*.gif)|.gif|All Files (*.*)|*.*"
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            nmCtPk = dlg.FileName
            ContactPic.BackgroundImage = Image.FromFile(nmCtPk)
        End If
    End Sub

    Private Sub NewContact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DisplayPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DisplayPanel.Paint

    End Sub

    Private Sub ContactPic_Click(sender As System.Object, e As System.EventArgs) Handles ContactPic.Click

    End Sub


End Class