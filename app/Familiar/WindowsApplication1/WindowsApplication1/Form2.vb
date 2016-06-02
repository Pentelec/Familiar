Option Explicit On
Imports System.Drawing.Imaging
Imports System.Net.Mail
Imports Microsoft.VisualBasic.Devices
Imports System.Management
Imports System.Drawing

Public Class FeedForm
    Private screenBMP As Bitmap
    Private screenGFX As Graphics
    Private leOS As String
    Private leMem As String ' (622016) I get the feeling like I named the others in a similar way just for the reference in this name. 
    Private leProc As String

    Public Enum listInfo
        OperatingSystem
        ProcName
        MemAmount
    End Enum
    Private Sub ScreenShotPic_Click(sender As System.Object, e As System.EventArgs) Handles ScreenShotPic.Click
        ScreenShotIt()
    End Sub

    Public Sub getSpecs(ByVal listInf As listInfo)
        Dim info As New ComputerInfo : Dim Value, vganame, vgamem, proc As String
        If listInf = listInfo.OperatingSystem Then
            leOS = info.OSFullName
        End If
        If listInf = listInfo.MemAmount Then
            leMem = Math.Round((((CDbl(Convert.ToDouble(Val(info.TotalPhysicalMemory))) / 1024)) / 1024), 2) & " MB"
        End If
        

    End Sub

    Public Sub ScreenShotIt()

        Try
            screenBMP = New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb)

            screenGFX = Graphics.FromImage(screenBMP)
            screenGFX.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy)

            ScreenShotPic.BackgroundImage = screenBMP

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub SumbitALot_Click(sender As System.Object, e As System.EventArgs) Handles SumbitALot.Click

        My.Computer.FileSystem.WriteAllText("C:\Pentelec\aimg.png", ScreenShotPic.BackgroundImage.ToString, False)

        'Dim a As New System.Net.WebClient
        'Dim location As String = "http://pentelecemps.webs.com/" + VBMath.Rnd.ToString
        'a.UploadFile(location, "C:\Pentelec\aimg.png") ' To Do: Revise here.

        Dim goodStuff As Boolean = False
        If SomethingIsGood.Checked Then
            goodStuff = True
        End If

        Dim writeSpecsOrNot As String = "Not Included"
        If SendCompSpecs.Checked Then
            getSpecs(listInfo.MemAmount)
            getSpecs(listInfo.OperatingSystem)
            writeSpecsOrNot = "OS: " & leOS & ", Memory: " & leMem
        End If


        Try
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            ' Wow, I did it again. Another password just written right there. Amazing. 
            ' Sorry, friends, but this will be a feature also disabled for the mean time. 
            SmtpServer.Port = 587
            SmtpServer.Host = "smtp.gmail.com"
            SmtpServer.EnableSsl = True
            mail = New MailMessage()
            mail.From = New MailAddress("pentelecfeedback@gmail.com", "Pentelec Feedback Services")
            mail.To.Add("pentelec@gmail.com")
            mail.Subject = "Feedback on Pentelec Familiar | Version: " & My.Settings.VersionNow
            mail.Body = "Current Version: " & My.Settings.VersionNow & vbCrLf & _
                        "+/- (+ is True, - is False): " & goodStuff.ToString & vbCrLf & _
                        "This is what the user had to say about this: " & TheWrittenFeedback.Text & vbCrLf & _
                        "Computer Specifications: " & writeSpecsOrNot & vbCrLf & _
                        "Name: " & NameTextBox.Text & vbCrLf & _
                        "E-Mail: " & EmailTextBox.Text & vbCrLf & _
                        "Link to Screenshot: " & vbCrLf & vbCrLf & "____" & vbCrLf & "Pentelec Feedback Services: Pentelec Familiar Development and Evaluation System"
            SmtpServer.Send(mail)
            MsgBox("Feedback has been sent. Thank you!")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class