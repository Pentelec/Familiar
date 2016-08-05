Imports Microsoft.VisualBasic
Imports System.IO
Imports Microsoft.VisualBasic.FileIO.TextFieldParser
Imports Microsoft.VisualBasic.FileIO

Public Class Library

    Public fileName1 As String
    Public libFileName As String
    Public pathimp As String
    Public num As Integer

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DisplayPanel.Paint

    End Sub

    Private Sub Library_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LibraryNameHere.Text = fileName1

        ContactName.Text = ContactList.Items.Item(0).ToString

        Using read As New TextFieldParser(pathimp & "\" & ContactList.Items.Item(0).ToString & ".pfcr")
            read.TextFieldType = FileIO.FieldType.Delimited
            read.SetDelimiters("*")
            Dim index As Integer = 0
            While Not read.EndOfData
                Try
                    Dim currentrow As String()
                    currentrow = read.ReadFields()
                    For index = 0 To 50
                        If currentrow(index).StartsWith("COVER") Then
                            Dim cv As String
                            cv = currentrow(index).Remove(0, 5)
                            If cv <> "normal" Then
                                TopPicContact.BackgroundImage = Image.FromFile(cv)
                            Else
                                TopPicContact.BackgroundImage = My.Resources.postoppart
                            End If
                        End If
                        If currentrow(index).StartsWith("BACK") Then
                            Dim bk As String
                            bk = currentrow(index).Remove(0, 4)
                            If bk <> "normal" Then
                                DisplayPanel.BackgroundImage = Image.FromFile(bk)
                            Else
                                DisplayPanel.BackgroundImage = My.Resources.nuevo_LtBlA
                            End If
                        End If
                        If currentrow(index).StartsWith("PIC") Then
                            Dim ct As String
                            ct = currentrow(index).Remove(0, 3)
                            If ct <> "normal" Then
                                ContactPic.BackgroundImage = Image.FromFile(ct)
                            Else
                                ContactPic.BackgroundImage = My.Resources.NO_THEREISNOPHOTO
                            End If
                        End If
                        If currentrow(index).StartsWith("NICKNAME") Then
                            Dim nick As String
                            nick = Chr(34) & currentrow(index).Remove(0, 9) & Chr(34)
                            NickLabel.Text = nick
                        End If
                        If currentrow(index).StartsWith("CELL1") Then
                            Dim cell1s As String
                            cell1s = currentrow(index).Remove(0, 5)
                            Cell1.Text = cell1s
                        End If
                        If currentrow(index).StartsWith("CELL2") Then
                            Dim cell2s As String
                            cell2s = currentrow(index).Remove(0, 5)
                            Cell2.Text = cell2s
                        End If
                        If currentrow(index).StartsWith("HOMENU") Then
                            Dim homen As String
                            homen = currentrow(index).Remove(0, 6)
                            HomeNo.Text = homen
                        End If
                        If currentrow(index).StartsWith("WORKNU") Then
                            Dim workn As String
                            workn = currentrow(index).Remove(0, 6)
                            WorkNo.Text = workn
                        End If
                        If currentrow(index).StartsWith("EMAILLIST") Then
                            Dim elist As String
                            elist = currentrow(index).Remove(0, 10)
                            EmailList.Text = elist
                        End If


                        'Work

                        If currentrow(index).StartsWith("ADW") Then
                            Dim adw As String
                            adw = currentrow(index).Remove(0, 3)
                            AddressW.Text = adw
                        End If
                        If currentrow(index).StartsWith("WEBW") Then
                            Dim webw1 As String
                            webw1 = currentrow(index).Remove(0, 5)
                            WebW.Text = webw1
                        End If
                        If currentrow(index).StartsWith("JOBW") Then
                            Dim jobw1 As String
                            jobw1 = currentrow(index).Remove(0, 5)
                            JobW.Text = jobw1
                        End If
                        If currentrow(index).StartsWith("DEPTW") Then
                            Dim deptw1 As String
                            deptw1 = currentrow(index).Remove(0, 6)
                            DeptW.Text = deptw1
                        End If
                        If currentrow(index).StartsWith("OFFICEW") Then
                            Dim offw1 As String
                            offw1 = currentrow(index).Remove(0, 8)
                            OfficeW.Text = offw1
                        End If
                        If currentrow(index).StartsWith("CITYW") Then
                            Dim cityw1 As String
                            cityw1 = currentrow(index).Remove(0, 6)
                            CityW.Text = cityw1
                        End If
                        If currentrow(index).StartsWith("STATEW") Then
                            Dim w1 As String
                            w1 = currentrow(index).Remove(0, 7)
                            StateW.Text = w1
                        End If
                        If currentrow(index).StartsWith("POSTW") Then
                            Dim a As String
                            a = currentrow(index).Remove(0, 5)
                            PostW.Text = a
                        End If

                        'Home
                        If currentrow(index).StartsWith("ADH") Then
                            Dim a1 As String
                            a1 = currentrow(index).Remove(0, 3)
                            AddressH.Text = a1
                        End If
                        If currentrow(index).StartsWith("FB") Then
                            Dim a2 As String
                            a2 = currentrow(index).Remove(0, 2)
                            FB.Text = a2
                        End If
                        If currentrow(index).StartsWith("TWI") Then
                            Dim a3 As String
                            a3 = currentrow(index).Remove(0, 3)
                            Twi.Text = a3
                        End If
                        If currentrow(index).StartsWith("OTHERSOC") Then
                            Dim a4 As String
                            a4 = currentrow(index).Remove(0, 8)
                            OtherH.Text = a4
                        End If
                        If currentrow(index).StartsWith("BDAY") Then
                            Dim a5 As String
                            a5 = currentrow(index).Remove(0, 4)
                            Bday.Text = a5
                        End If
                        If currentrow(index).StartsWith("SPOU") Then
                            Dim a6 As String
                            a6 = currentrow(index).Remove(0, 4)
                            Spouse.Text = a6
                        End If
                        If currentrow(index).StartsWith("CITYH") Then
                            Dim a7 As String
                            a7 = currentrow(index).Remove(0, 5)
                            CityH.Text = a7
                        End If
                        If currentrow(index).StartsWith("STATEH") Then
                            Dim a8 As String
                            a8 = currentrow(index).Remove(0, 6)
                            StateH.Text = a8
                        End If
                        If currentrow(index).StartsWith("POSTH") Then
                            Dim a9 As String
                            a9 = currentrow(index).Remove(0, 5)
                            PostH.Text = a9
                        End If
                        If currentrow(index).StartsWith("NOTES====") Then
                            Dim a10 As String
                            a10 = currentrow(index).Remove(0, 9)
                            NoteBox.Text = a10
                        End If

                    Next
                Catch ex As Exception
                End Try
            End While
        End Using

    End Sub

    Private Sub ContactList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactList.SelectedIndexChanged

        EmailList.Text = ""
        AddressW.Text = ""
        WebW.Text = ""
        JobW.Text = ""
        DeptW.Text = ""
        OfficeW.Text = ""
        CityW.Text = ""
        StateW.Text = ""
        PostW.Text = ""
        AddressH.Text = ""
        FB.Text = ""
        Twi.Text = ""
        OtherH.Text = ""
        Bday.Text = ""
        Spouse.Text = ""
        CityH.Text = ""
        StateH.Text = ""
        PostH.Text = ""
        NoteBox.Text = ""
        FirstName.Text = ""
        LastName.Text = ""


        ContactName.Text = ContactList.Items.Item(ContactList.SelectedIndex).ToString

        If ContactName.Text.Contains(",") = False Then
            LastName.Text = ContactName.Text
        End If

        TopPicContact.BackgroundImage = My.Resources.postoppart
        DisplayPanel.BackgroundImage = My.Resources.nuevo_LtBlA
        ContactPic.BackgroundImage = My.Resources.NO_THEREISNOPHOTO

        Using read As New TextFieldParser(pathimp & "\" & ContactList.Items.Item(ContactList.SelectedIndex).ToString & ".pfcr")
            read.TextFieldType = FileIO.FieldType.Delimited
            read.SetDelimiters("*")
            Dim index As Integer = 0
            While Not read.EndOfData
                Try
                    Dim currentrow As String()
                    currentrow = read.ReadFields()
                    For index = 0 To 50
                        If currentrow(index).StartsWith("NAME") Then
                            Dim nomnomnom130 As String
                            nomnomnom130 = currentrow(index).Remove(0, 5)
                            ContactName.Text = nomnomnom130
                        End If
                        If currentrow(index).StartsWith("COVER") Then
                            Dim cv As String
                            cv = currentrow(index).Remove(0, 6)
                            If cv <> "normal" Then
                                TopPicContact.BackgroundImage = Image.FromFile(cv)
                            Else
                                TopPicContact.BackgroundImage = My.Resources.postoppart
                            End If
                        End If
                        If currentrow(index).StartsWith("BACK") Then
                            Dim bk As String
                            bk = currentrow(index).Remove(0, 5)
                            If bk <> "normal" Then
                                DisplayPanel.BackgroundImage = Image.FromFile(bk)
                            Else
                                DisplayPanel.BackgroundImage = My.Resources.nuevo_LtBlA
                            End If
                        End If
                        If currentrow(index).StartsWith("PIC") Then
                            Dim ct As String
                            ct = currentrow(index).Remove(0, 4)
                            If ct <> "normal" Then
                                ContactPic.BackgroundImage = Image.FromFile(ct)
                            Else
                                ContactPic.BackgroundImage = My.Resources.NO_THEREISNOPHOTO
                            End If
                        End If
                        Dim fsta2 As String
                        Dim lsta2 As String
                        If currentrow(index).StartsWith("FIRST") Then
                            Dim fstA As String
                            fstA = currentrow(index).Remove(0, 6)
                            FirstName.Text = fstA
                            fsta2 = fstA
                        End If
                        If currentrow(index).StartsWith("LAST") Then
                            Dim lstA As String
                            lstA = currentrow(index).Remove(0, 5)
                            LastName.Text = lstA
                            lsta2 = lstA

                            ContactName.Text = fsta2 & " " & lstA

                        End If

                        If currentrow(index).StartsWith("NICKNAME") Then
                            Dim nick As String
                            nick = Chr(34) & currentrow(index).Remove(0, 9) & Chr(34)
                            NickLabel.Text = nick
                        End If
                        If currentrow(index).StartsWith("CELL1") Then
                            Dim cell1s As String
                            cell1s = currentrow(index).Remove(0, 5)
                            Cell1.Text = cell1s
                        End If
                        If currentrow(index).StartsWith("CELL2") Then
                            Dim cell2s As String
                            cell2s = currentrow(index).Remove(0, 5)
                            Cell2.Text = cell2s
                        End If
                        If currentrow(index).StartsWith("HOMENU") Then
                            Dim homen As String
                            homen = currentrow(index).Remove(0, 6)
                            HomeNo.Text = homen
                        End If
                        If currentrow(index).StartsWith("WORKNU") Then
                            Dim workn As String
                            workn = currentrow(index).Remove(0, 6)
                            WorkNo.Text = workn
                        End If
                        If currentrow(index).StartsWith("EMAILLIST") Then
                            Dim elist As String
                            elist = currentrow(index).Remove(0, 10)
                            EmailList.Text = elist
                        End If


                        'Work

                        If currentrow(index).StartsWith("ADW") Then
                            Dim adw As String
                            adw = currentrow(index).Remove(0, 3)
                            AddressW.Text = adw
                        End If
                        If currentrow(index).StartsWith("WEBW") Then
                            Dim webw1 As String
                            webw1 = currentrow(index).Remove(0, 4)
                            WebW.Text = webw1
                        End If
                        If currentrow(index).StartsWith("JOBW") Then
                            Dim jobw1 As String
                            jobw1 = currentrow(index).Remove(0, 4)
                            JobW.Text = jobw1
                        End If
                        If currentrow(index).StartsWith("DEPTW") Then
                            Dim deptw1 As String
                            deptw1 = currentrow(index).Remove(0, 5)
                            DeptW.Text = deptw1
                        End If
                        If currentrow(index).StartsWith("OFFICEW") Then
                            Dim offw1 As String
                            offw1 = currentrow(index).Remove(0, 7)
                            OfficeW.Text = offw1
                        End If
                        If currentrow(index).StartsWith("CITYW") Then
                            Dim cityw1 As String
                            cityw1 = currentrow(index).Remove(0, 5)
                            CityW.Text = cityw1
                        End If
                        If currentrow(index).StartsWith("STATEW") Then
                            Dim w1 As String
                            w1 = currentrow(index).Remove(0, 6)
                            StateW.Text = w1
                        End If
                        If currentrow(index).StartsWith("POSTW") Then
                            Dim a As String
                            a = currentrow(index).Remove(0, 5)
                            PostW.Text = a
                        End If

                        'Home
                        If currentrow(index).StartsWith("ADH") Then
                            Dim a1 As String
                            a1 = currentrow(index).Remove(0, 3)
                            If a1 <> " " Then
                                a1.Trim(Chr(32))
                                AddressH.Text = a1
                            Else
                                AddressH.Text = a1
                            End If
                            AddressH.Text = a1
                        End If
                        If currentrow(index).StartsWith("FB") Then
                            Dim a2 As String
                            a2 = currentrow(index).Remove(0, 2)
                            If a2 <> " " Then
                                a2.Trim(Chr(32))
                                FB.Text = a2
                            Else
                                FB.Text = a2
                            End If
                            FB.Text = a2
                        End If
                        If currentrow(index).StartsWith("TWI") Then
                            Dim a3 As String
                            a3 = currentrow(index).Remove(0, 3)
                            If a3 <> " " Then
                                a3.Trim(Chr(32))
                                Twi.Text = a3
                            Else
                                Twi.Text = a3
                            End If

                        End If
                        If currentrow(index).StartsWith("OTHERSOC") Then
                            Dim a4 As String
                            a4 = currentrow(index).Remove(0, 8)
                            If a4 <> " " Then
                                a4.Trim(Chr(32))
                                OtherH.Text = a4
                            Else
                                OtherH.Text = a4
                            End If


                        End If
                        If currentrow(index).StartsWith("BDAY") Then
                            Dim a5 As String
                            a5 = currentrow(index).Remove(0, 4)
                            If a5 <> " " Then
                                a5.Trim(Chr(32))
                                Bday.Text = a5
                            End If
                            Bday.Text = a5
                        End If
                        If currentrow(index).StartsWith("SPOU") Then
                            Dim a6 As String
                            a6 = currentrow(index).Remove(0, 4)
                            If a6 <> " " Then
                                a6.Trim(Chr(32))
                                Spouse.Text = a6
                            End If
                            Spouse.Text = a6
                        End If
                        If currentrow(index).StartsWith("CITYH") Then
                            Dim a7 As String
                            a7 = currentrow(index).Remove(0, 5)
                            If a7 <> " " Then
                                a7.Trim(Chr(32))
                                CityH.Text = a7
                            End If
                            CityH.Text = a7
                        End If
                        If currentrow(index).StartsWith("STATEH") Then
                            Dim a8 As String
                            a8 = currentrow(index).Remove(0, 6)
                            If a8 <> " " Then
                                a8.Trim(Chr(32))
                                StateH.Text = a8
                            End If
                            StateH.Text = a8
                        End If
                        If currentrow(index).StartsWith("POSTH") Then
                            Dim a9 As String
                            a9 = currentrow(index).Remove(0, 5)
                            If a9 <> " " Then
                                a9.Trim(Chr(32))
                            End If
                            If a9 <> "" Then
                                PostH.Text = a9
                            End If

                        End If
                        If currentrow(index).StartsWith("NOTES====") Then
                            Dim a10 As String
                            a10 = currentrow(index).Remove(0, 9)
                            If a10 <> " " Then
                                a10.Trim(Chr(32))
                                NoteBox.Text = a10
                            End If
                            NoteBox.Text = a10

                        End If

                    Next
                Catch ex As Exception
                End Try

            End While

        End Using



    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Adjust.Click
        EditCard.libname = libFileName
        EditCard.pathimp = pathimp
        EditCard.num = num
        If ContactList.SelectedIndex <> -1 Then
            EditCard.crdFileName = pathimp & "\" & ContactList.Items.Item(ContactList.SelectedIndex).ToString & ".pfcr"
        Else
            ContactList.SelectedIndex = 0
            EditCard.crdFileName = pathimp & "\" & ContactList.Items.Item(ContactList.SelectedIndex).ToString & ".pfcr"
        End If
        EditCard.Show()
        EditCard.BringToFront()
    End Sub

    Private Sub NickLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NickLabel.Click

    End Sub

    Private Sub NewContactBttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewContactBttn.Click
        NewContact.path = pathimp
        NewContact.libname = libFileName
        NewContact.Show()
        NewContact.BringToFront()
    End Sub

    Private Sub Library_ResizeBegin(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeBegin
        DisplayPanel.Visible = False
    End Sub

    Private Sub Library_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        If Not Me.Size.Width = 949 Then
            AddressW.AutoSize = True
            WebW.AutoSize = True
            JobW.AutoSize = True
            DeptW.AutoSize = True
            CityW.AutoSize = True
        End If
        DisplayPanel.Visible = True
    End Sub

    Private Sub FB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FB.Click
        Dim yp7 As String
        yp7 = FB.Text
        yp7 = yp7.Remove(0, 1)
        Process.Start("http://www.facebook.com/" & yp7)
    End Sub

    Private Sub SwitchToLeatherView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SwitchToLeatherView.Click
        RecrLib1027.pathimp = pathimp
        RecrLib1027.libFileName = libFileName
        RecrLib1027.Show()
        RecrLib1027.BringToFront()
    End Sub

    Private Sub SwitchToLeatherView_MouseHover(sender As Object, e As System.EventArgs) Handles SwitchToLeatherView.MouseHover
        SwitchToLeatherView.BackgroundImage = My.Resources.AltTabArrow
    End Sub

    Private Sub SwitchToLeatherView_MouseLeave(sender As Object, e As System.EventArgs) Handles SwitchToLeatherView.MouseLeave
        SwitchToLeatherView.BackgroundImage = My.Resources.AltTabArrow_Selected
    End Sub

    Private Sub NewContactBttn_MouseHover(sender As Object, e As System.EventArgs) Handles NewContactBttn.MouseHover
        NewContactBttn.BackgroundImage = My.Resources.AltTabPlus_Selected
    End Sub

    Private Sub NewContactBttn_MouseLeave(sender As Object, e As System.EventArgs) Handles NewContactBttn.MouseLeave
        NewContactBttn.BackgroundImage = My.Resources.AltTabPlus
    End Sub

    Private Sub PictureBox1_Click_1(sender As System.Object, e As System.EventArgs) Handles DeleteContact.Click
        Dim ioLine As String
        Dim ioLines As New ArrayList

        ContactList.SelectedIndex = ContactList.SelectedIndex + 1

        Dim crdfilename2 As String
        crdfilename2 = ContactList.Items.Item(ContactList.SelectedIndex - 1).ToString



        My.Computer.FileSystem.DeleteFile(pathimp & "\" & ContactList.Items.Item(ContactList.SelectedIndex - 1).ToString & ".pfcr")

        Using srA As New StreamReader(libFileName)
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

        My.Computer.FileSystem.WriteAllText(libFileName, anotherStringToWrite, False)
        ContactList.Items.RemoveAt(ContactList.SelectedIndex - 1)
    End Sub

    Private Sub DeleteContact_MouseHover(sender As Object, e As System.EventArgs) Handles DeleteContact.MouseHover
        DeleteContact.BackgroundImage = My.Resources.AltTabHyphen_Selected
    End Sub

    Private Sub DeleteContact_MouseLeave(sender As Object, e As System.EventArgs) Handles DeleteContact.MouseLeave
        DeleteContact.BackgroundImage = My.Resources.AltTabHyphen
    End Sub

    Private Sub Ajustes_MouseHover(sender As Object, e As System.EventArgs) Handles Adjust.MouseHover
        Adjust.BackgroundImage = My.Resources.AltTabGear_Selected
    End Sub

    Private Sub Ajustes_MouseLeave(sender As Object, e As System.EventArgs) Handles Adjust.MouseLeave
        Adjust.BackgroundImage = My.Resources.AltTabGear
    End Sub
End Class