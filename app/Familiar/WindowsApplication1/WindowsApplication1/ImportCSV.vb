Imports Microsoft.VisualBasic.FileIO

Public Class ImportCSV

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim dlg As SaveFileDialog = New SaveFileDialog
        dlg.Title = "Where to Save?"
        dlg.Filter = "Pentelec Familiar Library (*.pflb)|*.pflb|All Files (*.*)|*.*"
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim filename As String
            filename = dlg.FileName
            My.Computer.FileSystem.WriteAllText(filename, "NAME " & System.IO.Path.GetFileNameWithoutExtension(filename) & "*", False)

            If Form1.Lib1.Visible = True And Form1.Lib2.Visible = True And Form1.Lib3.Visible = True And Form1.Lib4.Visible = True And Form1.Lib5.Visible = True Then
                My.Settings.Lib1File = filename
            End If

            If Form1.Lib1.Visible = True And Form1.Lib2.Visible = True And Form1.Lib3.Visible = True And Form1.Lib4.Visible = True And Form1.Lib5.Visible = False Then
                My.Settings.Lib5Active = True
                My.Settings.Lib5File = filename
            End If

            If Form1.Lib1.Visible = True And Form1.Lib2.Visible = True And Form1.Lib3.Visible = True And Form1.Lib4.Visible = False Then
                My.Settings.Lib4Active = True
                My.Settings.Lib4File = filename
            End If

            If Form1.Lib1.Visible = True And Form1.Lib2.Visible = True And Form1.Lib3.Visible = False Then
                My.Settings.Lib3Active = True
                My.Settings.Lib3File = filename
            End If

            If Form1.Lib1.Visible = True And Form1.Lib2.Visible = False Then
                My.Settings.Lib2Active = True
                My.Settings.Lib2File = filename
            End If

            If Form1.Lib1.Visible = False Then
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

            ' Figure out the CSV stuff here.





            ' End CSV Implementation.





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
End Class