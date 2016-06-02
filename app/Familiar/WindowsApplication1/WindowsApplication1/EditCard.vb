Imports Microsoft.VisualBasic
Imports System.IO
Imports Microsoft.VisualBasic.FileIO.TextFieldParser
Imports Microsoft.VisualBasic.FileIO

Public Class EditCard

    Public crdFileName As String
    Public pathimp As String
    Public libname As String
    Dim nmCvPk As String
    Dim nmCtPk As String
    Dim nmBkPk As String
    Dim origLstNm As String
    Dim origFstNm As String
    Public num As Integer
    Public itsHoveringWait As Boolean = False

    Private Sub EditCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        TopPicContact.BackgroundImage = Library.TopPicContact.BackgroundImage
        ContactPic.BackgroundImage = Library.ContactPic.BackgroundImage
        DisplayPanel.BackgroundImage = Library.DisplayPanel.BackgroundImage
        FirstNameA.Text = Library.FirstName.Text
        origFstNm = Library.FirstName.Text
        LastNameA.Text = Library.LastName.Text
        origLstNm = Library.LastName.Text
        NickName.Text = Library.NickLabel.Text.Trim(Chr(34))
        Cell1.Text = Library.Cell1.Text
        Cell2.Text = Library.Cell2.Text
        HomeNo.Text = Library.HomeNo.Text
        WorkNo.Text = Library.WorkNo.Text
        EmailList.Text = Library.EmailList.Text
        AddressW.Text = Library.AddressW.Text
        WebW.Text = Library.WebW.Text
        JobW.Text = Library.JobW.Text
        DeptW.Text = Library.DeptW.Text
        OfficeW.Text = Library.OfficeW.Text
        CityW.Text = Library.CityW.Text
        StateW.Text = Library.StateW.Text
        PostW.Text = Library.PostW.Text
        If Library.AddressH.Text <> "" Then
            AddressH.Text = Library.AddressH.Text.Remove(0, 1)
        End If
        If Library.FB.Text <> "" Then
            FB.Text = Library.FB.Text.Remove(0, 1)
        End If
        If Library.Twi.Text <> "" Then
            Twi.Text = Library.Twi.Text.Remove(0, 1)
        End If
        If Library.OtherH.Text <> "" Then
            OtherH.Text = Library.OtherH.Text.Remove(0, 1)
        End If
        If Library.Bday.Text <> "" Then
            Bday.Text = Library.Bday.Text.Remove(0, 1)
        End If
        If Library.Spouse.Text <> "" Then
            Spouse.Text = Library.Spouse.Text.Remove(0, 1)
        End If
        If Library.CityH.Text <> "" Then
            CityH.Text = Library.CityH.Text.Remove(0, 1)
        End If
        If Library.StateH.Text <> "" Then
            StateH.Text = Library.StateH.Text.Remove(0, 1)
        End If
        If Library.PostH.Text <> "" Then
            PostH.Text = Library.PostH.Text.Remove(0, 1)
        End If
        If Library.NoteBox.Text <> "" Then
            NoteBox.Text = Library.NoteBox.Text.Remove(0, 1)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If My.Computer.FileSystem.DirectoryExists("C:\Pentelec") = False Then
            My.Computer.FileSystem.CreateDirectory("C:\Pentelec")
        End If
        My.Computer.FileSystem.CopyFile(crdFileName, "C:\Pentelec\a1.txt", True)


        Dim lines As New List(Of String)
        Using sr As New StreamReader(crdFileName)
            While Not sr.EndOfStream
                lines.Add(sr.ReadLine)
            End While
        End Using

        For Each line As String In lines
            lines.Remove(line)
            Exit For
        Next

        If FirstNameA.Text = "" Then
            If LastNameA.Text <> origLstNm Then
                Dim crdfilename2 As String
                crdfilename2 = Library.ContactList.Items.Item(Library.ContactList.SelectedIndex).ToString
                My.Computer.FileSystem.RenameFile(crdFileName, pathimp & "\" & LastNameA.Text & ".pfcr")
                crdFileName = pathimp & "\" & LastNameA.Text & ".pfcr"

                My.Computer.FileSystem.CreateDirectory(pathimp & "\" & LastNameA.Text)
                My.Computer.FileSystem.WriteAllText(pathimp & "\" & LastNameA.Text & "\name.txt", LastNameA.Text, False)

                My.Computer.FileSystem.WriteAllText(libname, vbCrLf & "INCLUDEPFCR" & " " & LastNameA.Text, True)

                Dim ioLine As String
                Dim ioLines As ArrayList

                Using srA As New StreamReader(libname)
                    While Not srA.EndOfStream
                        ioLine = srA.ReadLine
                        ioLines.Add(ioLine)
                        While Not ioLine = ""
                            ioLine = srA.ReadLine
                            If ioLine <> "INCLUDEPFCR " & crdfilename2 Then
                                ioLines.Add(ioLine)
                            End If
                        End While

                    End While

                End Using
                Dim anotherStringToWrite As String
                anotherStringToWrite = String.Join(vbCrLf, ioLines.ToArray())

                My.Computer.FileSystem.WriteAllText(libname, anotherStringToWrite, False)

            End If
        End If

        If origLstNm & "," & origFstNm <> LastNameA.Text & "," & FirstNameA.Text Then
            Dim crdfilename2 As String
            crdfilename2 = Library.ContactList.Items.Item(Library.ContactList.SelectedIndex).ToString
            My.Computer.FileSystem.RenameFile(crdFileName, LastNameA.Text & ", " & FirstNameA.Text & ".pfcr")
            crdFileName = pathimp & "\" & LastNameA.Text & ", " & FirstNameA.Text & ".pfcr"
            My.Computer.FileSystem.CreateDirectory(pathimp & "\" & LastNameA.Text & ", " & FirstNameA.Text)
            My.Computer.FileSystem.WriteAllText(pathimp & "\" & LastNameA.Text & ", " & FirstNameA.Text & "\name.txt", LastNameA.Text & ", " & FirstNameA.Text, False)

            My.Computer.FileSystem.WriteAllText(libname, vbCrLf & "INCLUDEPFCR" & " " & LastNameA.Text & ", " & FirstNameA.Text, True)

            Dim ioLine As String
            Dim ioLines As New ArrayList

            Using srA As New StreamReader(libname)
                While Not srA.EndOfStream
                    ioLine = srA.ReadLine
                    ioLines.Add(ioLine)
                    While Not ioLine = ""
                        ioLine = srA.ReadLine
                        If ioLine <> "INCLUDEPFCR " & crdfilename2 Then
                            ioLines.Add(ioLine)
                        End If
                    End While

                End While

            End Using
            Dim anotherStringToWrite As String
            anotherStringToWrite = String.Join(vbCrLf, ioLines.ToArray())

            My.Computer.FileSystem.WriteAllText(libname, anotherStringToWrite, False)
        End If

        Using sw As New StreamWriter(crdFileName)
            sw.WriteLine("FILENAME" & " " & LastNameA.Text & ", " & FirstNameA.Text & ".pfcr" & "*")
            If nmCvPk <> "" Then
                Library.TopPicContact.BackgroundImage = Image.FromFile(nmCvPk)
                Library.Refresh()
                Application.DoEvents()
                sw.WriteLine("COVER" & " " & nmCvPk & "*")
            Else
                Dim path1 As String
                Using read As New TextFieldParser("C:\Pentelec\a1.txt")
                    read.TextFieldType = FileIO.FieldType.Delimited
                    read.SetDelimiters("*")
                    Dim index As Integer = 0
                    While Not read.EndOfData
                        Try
                            Dim currentrow As String()
                            currentrow = read.ReadFields()
                            For index = 0 To 50
                                If currentrow(index).StartsWith("COVER") Then
                                    Dim a10 As String
                                    a10 = currentrow(index).Remove(0, 6)
                                    path1 = a10
                                    sw.WriteLine("COVER" & " " & path1 & "*")
                                End If
                            Next
                        Catch ex As System.IndexOutOfRangeException
                        End Try
                    End While
                End Using
                Try

                Catch ex As NullReferenceException

                End Try
            End If

            If nmBkPk <> "" Then
                Library.DisplayPanel.BackgroundImage = Image.FromFile(nmBkPk)
                Library.Refresh()
                Application.DoEvents()
                sw.WriteLine("BACK" & " " & nmBkPk & "*")
            Else
                Dim path1 As String
                Using read As New TextFieldParser("C:\Pentelec\a1.txt")
                    read.TextFieldType = FileIO.FieldType.Delimited
                    read.SetDelimiters("*")
                    Dim index As Integer = 0
                    While Not read.EndOfData
                        Try
                            Dim currentrow As String()
                            currentrow = read.ReadFields()
                            For index = 0 To 50
                                If currentrow(index).StartsWith("BACK") Then
                                    Dim a10 As String
                                    a10 = currentrow(index).Remove(0, 5)
                                    path1 = a10
                                    sw.WriteLine("BACK" & " " & path1 & "*")
                                End If
                            Next
                        Catch ex As System.IndexOutOfRangeException
                        End Try
                    End While
                End Using
                Try

                Catch ex As NullReferenceException

                End Try

            End If

            If nmCtPk <> "" Then
                Library.ContactPic.BackgroundImage = Image.FromFile(nmCtPk)
                Library.Refresh()
                Application.DoEvents()
                sw.WriteLine("PIC" & " " & nmCtPk & "*")
            Else
                Dim path1 As String
                Using read As New TextFieldParser("C:\Pentelec\a1.txt")
                    read.TextFieldType = FileIO.FieldType.Delimited
                    read.SetDelimiters("*")
                    Dim index As Integer = 0
                    While Not read.EndOfData
                        Try
                            Dim currentrow As String()
                            currentrow = read.ReadFields()
                            For index = 0 To 50
                                If currentrow(index).StartsWith("PIC") Then
                                    sw.WriteLine(currentrow(index))
                                End If
                            Next
                        Catch ex As System.IndexOutOfRangeException
                        End Try
                    End While
                End Using
                Try

                Catch ex As NullReferenceException

                End Try
            End If

            If FirstNameA.Text <> "" Then
                sw.WriteLine("NAME" & " " & LastNameA.Text & ", " & FirstNameA.Text & "*")
            Else
                sw.WriteLine("NAME" & " " & LastNameA.Text & "*")
            End If
            sw.WriteLine("FIRST" & " " & FirstNameA.Text & "*")
            sw.WriteLine("LAST" & " " & LastNameA.Text & "*")
            sw.WriteLine("CELL1" & " " & Cell1.Text & "*")
            sw.WriteLine("CELL2" & " " & Cell2.Text & "*")
            sw.WriteLine("NICKNAME" & " " & NickName.Text & "*")
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







        Library.Close()
        Form1.LoadLib(num)
        My.Computer.FileSystem.DeleteFile("C:\Pentelec\a1.txt")
        Me.Hide()


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

    Private Sub ContactPicChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactPicChange.Click
        Dim dlg As OpenFileDialog = New OpenFileDialog
        dlg.Title = "Open"
        dlg.Filter = "Portable Network Graphic (*.png)|*.png|JPEG Image File (*.jpg)|*.jpg|Bitmap Image File (*.bmp)|*.bmp|Graphics Interchange Format (*.gif)|.gif|All Files (*.*)|*.*"
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            nmCtPk = dlg.FileName
            ContactPic.BackgroundImage = Image.FromFile(nmCtPk)
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

    Private Sub ContactPicChange_HandleDestroyed(sender As Object, e As System.EventArgs) Handles ContactPicChange.HandleDestroyed

    End Sub


End Class