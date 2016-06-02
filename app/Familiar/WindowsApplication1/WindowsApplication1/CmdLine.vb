Public Class CmdLine

    Private Sub InquiryInsert_Click(sender As System.Object, e As System.EventArgs) Handles InquiryInsert.Click
        If Inquiry.Text.StartsWith("doTheHarlemShake()") Then
            FamiliarShake.Show()
            FamiliarShake.BringToFront()
            Result.Text = "Consult the window that has been added in front of this one."
        ElseIf Inquiry.Text.StartsWith("penmem: ") Then
            If Inquiry.Text.StartsWith("penmem: rj_pentelec04: ") Then
                If Inquiry.Text.Contains("starWarsIV") Then
                    Result.Text = "Open a connection in telnet to ||towel.blinkenlights.nl||."
                ElseIf Inquiry.Text.Contains("leatherStyle") Then
                    Form1.BackgroundImage = My.Resources.plec_leather0200415111
                    Result.Text = "Welcome back to leather."
                End If
            End If
            ElseIf Inquiry.Text.StartsWith("penmem: immccann: ") Then
                If Inquiry.Text.Contains("Hokap") Then
                    Result.Text = "Hooooooooooooooooooooooookap"
                ElseIf Inquiry.Text.Contains("idk") Then
                    Result.Text = "Je ne sais pas."
                End If

        ElseIf Inquiry.Text.StartsWith("pdev: ") Then
                If Inquiry.Text.StartsWith("pdev: themes:") Then
                    If Inquiry.Text.Contains("neon-green") Then
                        Form1.BackgroundImage = My.Resources.blackback
                        Form1.DateLabel.ForeColor = Color.LimeGreen
                        Form1.DateLabel.Font = New System.Drawing.Font("OCR A Extended", 16)
                        Form1.Feedback.ForeColor = Color.LimeGreen
                        Form1.Feedback.Font = New System.Drawing.Font("OCR A Extended", 9)
                        Form1.UserName.ForeColor = Color.Lime
                        Form1.UserName.Font = New System.Drawing.Font("OCR A Extended", 14)
                        Form1.LibListLabel.ForeColor = Color.LimeGreen
                        Form1.LibListLabel.Font = New System.Drawing.Font("OCR A Extended", 14)
                    Form1.GetLocalNewsVersion.ForeColor = Color.LimeGreen
                    Form1.GetLocalNewsVersion.Font = New System.Drawing.Font("OCR A Extended", 9)
                    Form1.TheDevGoods.ForeColor = Color.LimeGreen
                        Form1.TheDevGoods.Font = New System.Drawing.Font("OCR A Extended", 14)
                        Form1.ImpALib.ForeColor = Color.LimeGreen
                        Form1.ImpALib.Font = New System.Drawing.Font("OCR A Extended", 9)
                        Form1.QuePasoPaths.ForeColor = Color.LimeGreen
                        Form1.QuePasoPaths.Font = New System.Drawing.Font("OCR A Extended", 9)
                        Form1.YayFunTime.ForeColor = Color.LimeGreen
                        Form1.YayFunTime.Font = New System.Drawing.Font("OCR A Extended", 9)
                        Form1.LibImporter.ForeColor = Color.LimeGreen
                        Form1.LibImporter.Font = New System.Drawing.Font("OCR A Extended", 9)
                        Form1.LibImporter.FlatStyle = FlatStyle.Flat
                        Form1.LibImporter.FlatAppearance.BorderColor = Color.LimeGreen
                        Form1.FindThePaths.ForeColor = Color.LimeGreen
                        Form1.FindThePaths.Font = New System.Drawing.Font("OCR A Extended", 9)
                        Form1.FindThePaths.FlatStyle = FlatStyle.Flat
                        Form1.FindThePaths.FlatAppearance.BorderColor = Color.LimeGreen
                        Form1.CmdLineSel.ForeColor = Color.LimeGreen
                        Form1.CmdLineSel.Font = New System.Drawing.Font("OCR A Extended", 9)
                        Form1.CmdLineSel.FlatStyle = FlatStyle.Flat
                        Form1.CmdLineSel.FlatAppearance.BorderColor = Color.LimeGreen
                        Form1.Lib1Lab.ForeColor = Color.LimeGreen
                        Form1.Lib1Lab.Font = New System.Drawing.Font("OCR A Extended", 12)
                        Form1.Lib2Lab.ForeColor = Color.LimeGreen
                        Form1.Lib2Lab.Font = New System.Drawing.Font("OCR A Extended", 12)
                        Form1.Lib3Lab.ForeColor = Color.LimeGreen
                        Form1.Lib3Lab.Font = New System.Drawing.Font("OCR A Extended", 12)
                        Form1.Lib4Lab.ForeColor = Color.LimeGreen
                        Form1.Lib4Lab.Font = New System.Drawing.Font("OCR A Extended", 12)
                        Form1.Lib5Lab.ForeColor = Color.LimeGreen
                        Form1.Lib5Lab.Font = New System.Drawing.Font("OCR A Extended", 12)
                        Form1.NewsBrowser.BackColor = Color.DimGray
                        Form1.Logo.BackgroundImage = My.Resources.OCRFamiliar
                        Form1.NewLib.BackgroundImage = My.Resources.PlusModeNine
                        Form1.QuestionLink.BackgroundImage = My.Resources.QuestionModeNine
                        Result.Text = "Applied Pentelec Development Theme: 'neon-green'"
                    End If
                Else
                    Result.Text = "Incorrect parameters for command 'pdev' were had."
                End If
            Else

            End If

    End Sub
End Class