Public Class PleaseLogIn24

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles EnterButton.Click
        Application.DoEvents()
        Try
            Application.DoEvents()
            ConnStat.Visible = True
            Dim connection As New SqlClient.SqlConnection
            Dim command As New SqlClient.SqlCommand
            Dim adapter As New SqlClient.SqlDataAdapter
            Dim dataset As New DataSet

            ' (622016): This will probably crash due to no command string and definition of the server, etc., but this was incredibly insecure the way it was. Wow.
            command.CommandText = "SELECT * FROM [users] WHERE username= '" & UserNameTextBox.Text & "'AND password='" & PasswordTextBox.Text & "';"
            Application.DoEvents()
            connection.Open()
            Application.DoEvents()

            command.Connection = connection

            adapter.SelectCommand = command
            adapter.Fill(dataset, "0")

            Dim count = dataset.Tables(0).Rows.Count

            If count > 0 Then
                MsgBox("Logged In")
                Me.Close()
            Else
                MsgBox("Try again.")
            End If
        Catch ex As Exception
            ConnStat.Text = "No response from the server. Contact Pentelec's rj_pentelec04 and tell him this: " & ex.ToString
            MsgBox(ex.ToString)
        End Try



    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As System.EventArgs) Handles EnterButton.MouseHover
        EnterButton.BackgroundImage = My.Resources.Enter2
    End Sub

    Private Sub EnterButton_MouseLeave(sender As Object, e As System.EventArgs) Handles EnterButton.MouseLeave
        EnterButton.BackgroundImage = My.Resources.Enter1
    End Sub

    Private Sub CloseThatFormNow_Click(sender As System.Object, e As System.EventArgs) Handles CloseThatFormNow.Click
        Me.Close()
    End Sub
End Class