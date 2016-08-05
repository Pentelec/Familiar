Option Strict Off

Imports Microsoft.VisualBasic
Imports System.IO
Imports Microsoft.VisualBasic.FileIO.TextFieldParser
Imports Microsoft.VisualBasic.FileIO
Imports Facebook.Web
Imports System.Net



Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibImporter.Click
        Dim dlg As OpenFileDialog = New OpenFileDialog
        dlg.Title = "Open"
        dlg.Filter = "Pentelec Familiar Library (*.pflb)|*.pflb|All Files (*.*)|*.*"
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim filename As String
            filename = dlg.FileName
            Library.libFileName = filename

            If Lib1.Visible = True And Lib2.Visible = True And Lib3.Visible = True And Lib4.Visible = True And Lib5.Visible = True Then
                My.Settings.Lib1File = filename
            End If

            If Lib1.Visible = True And Lib2.Visible = True And Lib3.Visible = True And Lib4.Visible = True And Lib5.Visible = False Then
                My.Settings.Lib5Active = True
                My.Settings.Lib5File = filename
            End If

            If Lib1.Visible = True And Lib2.Visible = True And Lib3.Visible = True And Lib4.Visible = False Then
                My.Settings.Lib4Active = True
                My.Settings.Lib4File = filename
            End If

            If Lib1.Visible = True And Lib2.Visible = True And Lib3.Visible = False Then
                My.Settings.Lib3Active = True
                My.Settings.Lib3File = filename
            End If

            If Lib1.Visible = True And Lib2.Visible = False Then
                My.Settings.Lib2Active = True
                My.Settings.Lib2File = filename
            End If

            If Lib1.Visible = False Then
                My.Settings.Lib1Active = True
                My.Settings.Lib1File = filename
            End If

            Using read As New TextFieldParser(filename)
                read.TextFieldType = FileIO.FieldType.Delimited
                read.SetDelimiters("*")
                Dim index As Integer = 0
                While Not read.EndOfData
                    Try
                        Dim currentrow As String()
                        currentrow = read.ReadFields()
                        Dim NameOfLib As String
                        For index = 0 To 1
                            If currentrow(index).StartsWith("NAME") Then
                                NameOfLib = currentrow(index).Remove(0, 5)
                                Library.fileName1 = NameOfLib
                                'MsgBox("This is the file's name: " & NameOfLib)
                            End If
                            If currentrow(index).StartsWith("INCLUDEPFCR") Then
                                Dim fileName2 As String
                                fileName2 = currentrow(index).Remove(0, 12)
                                'MsgBox(fileName2)
                                Dim path As String
                                path = dlg.FileName
                                path = path.Remove(path.Length - NameOfLib.Length - 5, 5 + NameOfLib.Length)
                                Library.pathimp = path
                                path = path & "\" & fileName2 & "\name.txt"
                                Dim path1 As String
                                path1 = My.Computer.FileSystem.ReadAllText(path)

                                Library.ContactList.Items.Add(path1)

                            End If
                        Next
                    Catch ex As System.IndexOutOfRangeException
                    End Try
                End While
                Library.Show()
            End Using
        End If

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuestionLink.Click
        QuestionLink.BackgroundImage = My.Resources.QuestionMark
    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuestionLink.MouseHover
        QuestionLink.BackgroundImage = My.Resources.QuestionMarkSelected
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuestionLink.MouseLeave
        QuestionLink.BackgroundImage = My.Resources.QuestionMark
    End Sub

    Private Sub Lib1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lib1.Click
        LoadLib(1)
    End Sub

    Private Sub Lib1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lib1.MouseHover
        Lib1.BackColor = Color.LightYellow
    End Sub

    Private Sub Lib1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lib1.MouseLeave
        Lib1.BackColor = Color.Transparent
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Lib1.Paint

    End Sub

    Private Sub Lib2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lib2.Click
        LoadLib(2)
    End Sub

    Private Sub Lib2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lib2.MouseHover
        Lib2.BackColor = Color.LightYellow
    End Sub

    Private Sub Lib2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lib2.MouseLeave
        Lib2.BackColor = Color.Transparent
    End Sub

    Private Sub Lib2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Lib2.Paint

    End Sub

    Private Sub Lib3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lib3.Click
        LoadLib(3)
    End Sub

    Private Sub Lib3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lib3.MouseHover
        Lib3.BackColor = Color.LightYellow
    End Sub

    Private Sub Lib3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lib3.MouseLeave
        Lib3.BackColor = Color.Transparent
    End Sub

    Private Sub Lib3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Lib3.Paint

    End Sub

    Private Sub Lib4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lib4.Click
        LoadLib(4)
    End Sub

    Private Sub Lib4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lib4.MouseHover
        Lib4.BackColor = Color.LightYellow
    End Sub

    Private Sub Lib4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lib4.MouseLeave
        Lib4.BackColor = Color.Transparent
    End Sub

    Private Sub Lib4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Lib4.Paint

    End Sub

    Private Sub Lib5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lib5.Click
        LoadLib(5)
    End Sub

    Private Sub Lib5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lib5.MouseHover
        Lib5.BackColor = Color.LightYellow
    End Sub

    Private Sub Lib5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lib5.MouseLeave
        Lib5.BackColor = Color.Transparent
    End Sub

    Private Sub Lib5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Lib5.Paint

    End Sub

    Sub LoadLib(ByVal whichOne As Integer)

        Dim filename As String
        If whichOne = 1 Then
            filename = My.Settings.Lib1File
        End If
        If whichOne = 2 Then
            filename = My.Settings.Lib2File
        End If
        If whichOne = 3 Then
            filename = My.Settings.Lib3File
        End If
        If whichOne = 4 Then
            filename = My.Settings.Lib4File
        End If
        If whichOne = 5 Then
            filename = My.Settings.Lib5File
        End If


        Library.libFileName = filename
        Library.num = whichOne

        Using read As New TextFieldParser(filename)
            read.TextFieldType = FileIO.FieldType.Delimited
            read.SetDelimiters("*")
            Dim index As Integer = 0
            While Not read.EndOfData
                Try
                    Dim currentrow As String()
                    currentrow = read.ReadFields()
                    Dim NameOfLib As String
                    For index = 0 To 1
                        If currentrow(index).StartsWith("NAME") Then
                            NameOfLib = currentrow(index).Remove(0, 5)
                            Library.fileName1 = NameOfLib
                            'MsgBox("This is the file's name: " & NameOfLib)
                        End If
                        If currentrow(index).StartsWith("INCLUDEPFCR") Then
                            Dim fileName2 As String
                            fileName2 = currentrow(index).Remove(0, 12)
                            'MsgBox(fileName2)
                            Dim path As String
                            path = filename
                            path = path.Remove(path.Length - NameOfLib.Length - 5, 5 + NameOfLib.Length)
                            Library.pathimp = path
                            path = path & "\" & fileName2 & "\name.txt"
                            Dim path1 As String
                            path1 = My.Computer.FileSystem.ReadAllText(path)


                            ' Suffice the addition of contacts for two differing formats. May change in future versions.
                            Library.ContactList.Items.Add(path1)
                            RecrLib1027.ContactList.Items.Add(path1)

                        End If
                    Next
                Catch ex As System.IndexOutOfRangeException
                End Try
            End While
            Library.Show()
        End Using

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DateLabel.Text = Date.Today
        DateLabel.Left = (Me.ClientSize.Width / 2) - (DateLabel.Width / 2)

        If My.Settings.Lib1Active = True Then
            Using read As New TextFieldParser(My.Settings.Lib1File)
                read.TextFieldType = FileIO.FieldType.Delimited
                read.SetDelimiters("*")
                Dim index As Integer = 0
                While Not read.EndOfData
                    Try
                        Dim currentrow As String()
                        currentrow = read.ReadFields()
                        Dim NameOfLib As String
                        For index = 0 To 1
                            If currentrow(index).StartsWith("NAME") Then
                                NameOfLib = currentrow(index).Remove(0, 5)
                                Lib1Lab.Text = NameOfLib
                                'MsgBox("This is the file's name: " & NameOfLib)
                            End If

                        Next
                    Catch ex As System.IndexOutOfRangeException
                    End Try
                End While
            End Using

            Lib1.Visible = True
        End If


        If My.Settings.Lib2Active = True Then
            Using read As New TextFieldParser(My.Settings.Lib2File)
                read.TextFieldType = FileIO.FieldType.Delimited
                read.SetDelimiters("*")
                Dim index As Integer = 0
                While Not read.EndOfData
                    Try
                        Dim currentrow As String()
                        currentrow = read.ReadFields()
                        Dim NameOfLib As String
                        For index = 0 To 1
                            If currentrow(index).StartsWith("NAME") Then
                                NameOfLib = currentrow(index).Remove(0, 5)
                                Lib2Lab.Text = NameOfLib
                                'MsgBox("This is the file's name: " & NameOfLib)
                            End If

                        Next
                    Catch ex As System.IndexOutOfRangeException
                    End Try
                End While
            End Using

            Lib2.Visible = True
        End If


        If My.Settings.Lib3Active = True Then
            Using read As New TextFieldParser(My.Settings.Lib3File)
                read.TextFieldType = FileIO.FieldType.Delimited
                read.SetDelimiters("*")
                Dim index As Integer = 0
                While Not read.EndOfData
                    Try
                        Dim currentrow As String()
                        currentrow = read.ReadFields()
                        Dim NameOfLib As String
                        For index = 0 To 1
                            If currentrow(index).StartsWith("NAME") Then
                                NameOfLib = currentrow(index).Remove(0, 5)
                                Lib3Lab.Text = NameOfLib
                                'MsgBox("This is the file's name: " & NameOfLib)
                            End If

                        Next
                    Catch ex As System.IndexOutOfRangeException
                    End Try
                End While
            End Using

            Lib3.Visible = True
        End If


        If My.Settings.Lib4Active = True Then
            Using read As New TextFieldParser(My.Settings.Lib4File)
                read.TextFieldType = FileIO.FieldType.Delimited
                read.SetDelimiters("*")
                Dim index As Integer = 0
                While Not read.EndOfData
                    Try
                        Dim currentrow As String()
                        currentrow = read.ReadFields()
                        Dim NameOfLib As String
                        For index = 0 To 1
                            If currentrow(index).StartsWith("NAME") Then
                                NameOfLib = currentrow(index).Remove(0, 5)
                                Lib4Lab.Text = NameOfLib
                                'MsgBox("This is the file's name: " & NameOfLib)
                            End If

                        Next
                    Catch ex As System.IndexOutOfRangeException
                    End Try
                End While
            End Using

            Lib4.Visible = True
        End If


        If My.Settings.Lib5Active = True Then
            Using read As New TextFieldParser(My.Settings.Lib5File)
                read.TextFieldType = FileIO.FieldType.Delimited
                read.SetDelimiters("*")
                Dim index As Integer = 0
                While Not read.EndOfData
                    Try
                        Dim currentrow As String()
                        currentrow = read.ReadFields()
                        Dim NameOfLib As String
                        For index = 0 To 1
                            If currentrow(index).StartsWith("NAME") Then
                                NameOfLib = currentrow(index).Remove(0, 5)
                                Lib5Lab.Text = NameOfLib
                                'MsgBox("This is the file's name: " & NameOfLib)
                            End If

                        Next
                    Catch ex As System.IndexOutOfRangeException
                    End Try
                End While
            End Using

            Lib5.Visible = True
        End If
    End Sub

    Private Sub NewLib_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewLib.Click
        NewLibPopup.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindThePaths.Click
        MsgBox(My.Settings.Lib1File)
        MsgBox(My.Settings.Lib2File)
        MsgBox(My.Settings.Lib3File)
        MsgBox(My.Settings.Lib4File)
        MsgBox(My.Settings.Lib5File)
    End Sub

    Private Sub DevPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DevPanel.Paint

    End Sub

    Private Sub FBManager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FBPopUpMenu.Visible = True
    End Sub

    Private Sub SaveFB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveFB.Click
        My.Settings.FBUser = EmailFB.Text
        My.Settings.FBPass = PasscodeFB.Text
        FBPopUpMenu.Visible = False
    End Sub



    Sub MakeBlankLibrary()
        Dim dlg As SaveFileDialog = New SaveFileDialog
        dlg.Title = "Where to Save?"
        dlg.Filter = "Pentelec Familiar Library (*.pflb)|*.pflb|All Files (*.*)|*.*"
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim filename As String
            filename = dlg.FileName
            My.Computer.FileSystem.WriteAllText(filename, "NAME " & System.IO.Path.GetFileNameWithoutExtension(filename) & "*", False)

            If Lib1.Visible = True And Lib2.Visible = True And Lib3.Visible = True And Lib4.Visible = True And Lib5.Visible = True Then
                My.Settings.Lib1File = filename
            End If

            If Lib1.Visible = True And Lib2.Visible = True And Lib3.Visible = True And Lib4.Visible = True And Lib5.Visible = False Then
                My.Settings.Lib5Active = True
                My.Settings.Lib5File = filename
            End If

            If Lib1.Visible = True And Lib2.Visible = True And Lib3.Visible = True And Lib4.Visible = False Then
                My.Settings.Lib4Active = True
                My.Settings.Lib4File = filename
            End If

            If Lib1.Visible = True And Lib2.Visible = True And Lib3.Visible = False Then
                My.Settings.Lib3Active = True
                My.Settings.Lib3File = filename
            End If

            If Lib1.Visible = True And Lib2.Visible = False Then
                My.Settings.Lib2Active = True
                My.Settings.Lib2File = filename
            End If

            If Lib1.Visible = False Then
                My.Settings.Lib1Active = True
                My.Settings.Lib1File = filename
            End If

            'Start with the contact of Pentelec Familiar here.

            My.Computer.FileSystem.WriteAllText(filename, vbCrLf & "INCLUDEPFCR Your First Contact*", True)
            My.Computer.FileSystem.CreateDirectory(filename.Remove(filename.Length - System.IO.Path.GetFileNameWithoutExtension(filename).Length - 5, System.IO.Path.GetFileNameWithoutExtension(filename).Length + 5) & "\Your First Contact")
            My.Computer.FileSystem.WriteAllText(filename.Remove(filename.Length - System.IO.Path.GetFileNameWithoutExtension(filename).Length - 5, System.IO.Path.GetFileNameWithoutExtension(filename).Length + 5) & "\Your First Contact.pfcr", _
                                                SampleCont.TextBox1.Text, False)
            My.Computer.FileSystem.WriteAllText(filename.Remove(filename.Length - System.IO.Path.GetFileNameWithoutExtension(filename).Length - 5, System.IO.Path.GetFileNameWithoutExtension(filename).Length + 5) & "\Your First Contact\name.txt", _
                                                "Your First Contact", False)


            'End here.


            Using read As New TextFieldParser(filename)
                read.TextFieldType = FileIO.FieldType.Delimited
                read.SetDelimiters("*")
                Dim index As Integer = 0
                While Not read.EndOfData
                    Try
                        Dim currentrow As String()
                        currentrow = read.ReadFields()
                        Dim NameOfLib As String
                        For index = 0 To 1
                            If currentrow(index).StartsWith("NAME") Then
                                NameOfLib = currentrow(index).Remove(0, 5)
                                Library.fileName1 = NameOfLib
                                'MsgBox("This is the file's name: " & NameOfLib)

                            End If
                            If currentrow(index).StartsWith("INCLUDEPFCR") Then
                                Dim fileName2 As String
                                fileName2 = currentrow(index).Remove(0, 12)
                                'MsgBox(fileName2)
                                Dim path As String
                                path = dlg.FileName
                                path = path.Remove(path.Length - NameOfLib.Length - 5, 5 + NameOfLib.Length)
                                Library.pathimp = path
                                path = path & "\" & fileName2 & "\name.txt"
                                Dim path1 As String
                                path1 = My.Computer.FileSystem.ReadAllText(path)

                                Library.ContactList.Items.Add(path1)

                            End If
                        Next
                    Catch ex As System.IndexOutOfRangeException
                    End Try
                End While
                MsgBox("Please close the program entirely and restart to finish.", MsgBoxStyle.OkOnly, "Almost There!")
                Library.Show()
            End Using

        End If
    End Sub

    Private Sub BlankLibraryOption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlankLibraryOption.Click
        MakeBlankLibrary()
        NewLibPopup.Visible = False
    End Sub

    Private Sub BlankLibLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlankLibLabel.Click
        MakeBlankLibrary()
        NewLibPopup.Visible = False
    End Sub

    Private Sub FBNewLib_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FBNewLib.Click
        'WHEN THIS WORKS, UNCOMMENT AND DELETE...well...the comments: MakeFBLibrary()
        TempMsg_FBImport1027.Show()
        TempMsg_FBImport1027.BringToFront()
    End Sub

    Private Sub FBImportLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FBImportLabel.Click
        'WHEN THIS WORKS, UNCOMMENT AND DELETE...well...the comments: MakeFBLibrary()
        TempMsg_FBImport1027.Show()
        TempMsg_FBImport1027.BringToFront()
    End Sub

    Sub MakeFBLibrary()
        Dim dlg As SaveFileDialog = New SaveFileDialog
        dlg.Title = "Where to Save?"
        dlg.Filter = "Pentelec Familiar Library (*.pflb)|*.pflb|All Files (*.*)|*.*"
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim filename As String
            filename = dlg.FileName
            My.Computer.FileSystem.WriteAllText(filename, "NAME " & System.IO.Path.GetFileNameWithoutExtension(filename) & "*", False)

            If Lib1.Visible = True And Lib2.Visible = True And Lib3.Visible = True And Lib4.Visible = True And Lib5.Visible = True Then
                My.Settings.Lib1File = filename
            End If

            If Lib1.Visible = True And Lib2.Visible = True And Lib3.Visible = True And Lib4.Visible = True And Lib5.Visible = False Then
                My.Settings.Lib5Active = True
                My.Settings.Lib5File = filename
            End If

            If Lib1.Visible = True And Lib2.Visible = True And Lib3.Visible = True And Lib4.Visible = False Then
                My.Settings.Lib4Active = True
                My.Settings.Lib4File = filename
            End If

            If Lib1.Visible = True And Lib2.Visible = True And Lib3.Visible = False Then
                My.Settings.Lib3Active = True
                My.Settings.Lib3File = filename
            End If

            If Lib1.Visible = True And Lib2.Visible = False Then
                My.Settings.Lib2Active = True
                My.Settings.Lib2File = filename
            End If

            If Lib1.Visible = False Then
                My.Settings.Lib1Active = True
                My.Settings.Lib1File = filename
            End If

            'Start with the contact of Pentelec Familiar here.

            My.Computer.FileSystem.WriteAllText(filename, vbCrLf & "INCLUDEPFCR Your First Contact*", True)
            My.Computer.FileSystem.CreateDirectory(filename.Remove(filename.Length - System.IO.Path.GetFileNameWithoutExtension(filename).Length - 5, System.IO.Path.GetFileNameWithoutExtension(filename).Length + 5) & "\Your First Contact")
            My.Computer.FileSystem.WriteAllText(filename.Remove(filename.Length - System.IO.Path.GetFileNameWithoutExtension(filename).Length - 5, System.IO.Path.GetFileNameWithoutExtension(filename).Length + 5) & "\Your First Contact.pfcr", _
                                                SampleCont.TextBox1.Text, False)
            My.Computer.FileSystem.WriteAllText(filename.Remove(filename.Length - System.IO.Path.GetFileNameWithoutExtension(filename).Length - 5, System.IO.Path.GetFileNameWithoutExtension(filename).Length + 5) & "\Your First Contact\name.txt", _
                                                "Your First Contact", False)


            'End here.


            ' The reason why the sub is here...Facebook Import.

            'THIS CODE HERE USES FACEBOOK.NET. Uncomment if code below it using Facebook C# SDK does not work, or we need something from here for some reason.
            'Dim appkeyA As String = "496234773721690" ' Write AppKey for FB App.
            'CENSORED! You can guess what is really, really, really wrong with what I did here simply by reading the next line. 
            'Dim fbconnect As New Facebook.Desktop.FacebookClientSession(appkeyA, secretA) ' Create new instance of a session.
            'fbconnect.Initialize(Me) ' Initialize (will pop up in window to verify identity.
            'Dim userID As String = fbconnect.PageUserID.ToString

            'Dim sessionKey As String
            'sessionKey = fbconnect.SessionKey


            'Uncomment when ready.
            ' 
            Dim auth As New Facebook.Web.CanvasAuthorizer
            auth.Permissions = {"user_about_me,friends_about_me"}

            If auth.Authorize() Then
                Dim fbclient = New Facebook.FacebookSession(auth.FacebookWebRequest.AccessToken) 'Get access by using an Access Token.

                Dim inf As Object 'Set variable "inf"
                'inf = Facebook.We
                'inf = fbclient.Get("/me/friends") 'Have int get all friends in the user's Facebook Friends List.
                Dim afbfa As Object 'Set variable "amigo"
                For Each afbfa In inf.data 'Check for all friends (amigos) in the inf.data we pulled from.
                    My.Computer.FileSystem.WriteAllText("C:\t_PeFBImp.ptemp", afbfa.ToString, True) 'Make list of friends.
                Next
            End If




            ' End here for Facebook Importing.






            Using read As New TextFieldParser(filename)
                read.TextFieldType = FileIO.FieldType.Delimited
                read.SetDelimiters("*")
                Dim index As Integer = 0
                While Not read.EndOfData
                    Try
                        Dim currentrow As String()
                        currentrow = read.ReadFields()
                        Dim NameOfLib As String
                        For index = 0 To 1
                            If currentrow(index).StartsWith("NAME") Then
                                NameOfLib = currentrow(index).Remove(0, 5)
                                Library.fileName1 = NameOfLib
                                'MsgBox("This is the file's name: " & NameOfLib)

                            End If
                            If currentrow(index).StartsWith("INCLUDEPFCR") Then
                                Dim fileName2 As String
                                fileName2 = currentrow(index).Remove(0, 12)
                                'MsgBox(fileName2)
                                Dim path As String
                                path = dlg.FileName
                                path = path.Remove(path.Length - NameOfLib.Length - 5, 5 + NameOfLib.Length)
                                Library.pathimp = path
                                path = path & "\" & fileName2 & "\name.txt"
                                Dim path1 As String
                                path1 = My.Computer.FileSystem.ReadAllText(path)

                                Library.ContactList.Items.Add(path1)

                            End If
                        Next
                    Catch ex As System.IndexOutOfRangeException
                    End Try
                End While
                MsgBox("Please close the program entirely and restart to finish.", MsgBoxStyle.OkOnly, "Almost There!")
                Library.Show()
            End Using

        End If
    End Sub

    Private Sub Lib4Pic_Click(sender As Object, e As EventArgs) Handles Lib4Pic.Click

    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        ImportCSV.Show()
        ImportCSV.BringToFront()
    End Sub

    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs) Handles Label10.Click
        UpdaterTrigger.Show()
        UpdaterTrigger.BringToFront()
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        UpdaterTrigger.Show()
        UpdaterTrigger.BringToFront()
    End Sub

    Private Sub UpdatePanel_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles UpdatePanel.Paint
        UpdaterTrigger.Show()
        UpdaterTrigger.BringToFront()
    End Sub

    Private Sub Lib1Lab_Click(sender As System.Object, e As System.EventArgs) Handles Lib1Lab.Click
        LoadLib(1)
    End Sub

    Private Sub Lib2Lab_Click(sender As System.Object, e As System.EventArgs) Handles Lib2Lab.Click
        LoadLib(2)
    End Sub

    Private Sub Lib3Lab_Click(sender As System.Object, e As System.EventArgs) Handles Lib3Lab.Click
        LoadLib(3)
    End Sub

    Private Sub Lib4Lab_Click(sender As System.Object, e As System.EventArgs) Handles Lib4Lab.Click
        LoadLib(4)
    End Sub

    Private Sub Lib5Lab_Click(sender As System.Object, e As System.EventArgs) Handles Lib5Lab.Click
        LoadLib(5)
    End Sub



    Private Sub UserName_Click(sender As System.Object, e As System.EventArgs) Handles UserName.Click
        If UserName.Text = "Sign In" Then
            PleaseLogIn24.Show()
            PleaseLogIn24.BringToFront()
        End If
    End Sub

    Private Sub Feedback_Click(sender As System.Object, e As System.EventArgs) Handles Feedback.Click
        FeedForm.Show()
        FeedForm.BringToFront()
    End Sub

    Private Sub CmdLineSel_Click(sender As System.Object, e As System.EventArgs) Handles CmdLineSel.Click
        CmdLine.Show()
        CmdLine.BringToFront()
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        RunACSVConvert()
    End Sub

    Sub RunACSVConvert()

    End Sub

    Private Sub GetLocalNewsVersion_Click(sender As Object, e As EventArgs) Handles GetLocalNewsVersion.Click
        NewsBrowser.Navigate("file:///C:/wamp/www/news/familiar/index.html")
    End Sub
End Class