Public Class FamiliarShake

    Public isThisTrue As Boolean = False

    Private Sub FamiliarShake_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

            

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        isThisTrue = True

        Dim w1 As New FamiliarShake
        w1.isThisTrue = True
        w1.Show()
        w1.BringToFront()

        Do While isThisTrue
            Me.Location = New Point(VBMath.Rnd * 150, VBMath.Rnd * 150)
            Me.Refresh()
            Application.DoEvents()
        Loop

        

    End Sub

    Sub openMore()
        Dim fm1 As New FamiliarShake
        fm1.isThisTrue = True
        fm1.Show()
        Dim fm2 As New FamiliarShake
        fm2.isThisTrue = True
        fm2.Show()
        Dim fm3 As New FamiliarShake
        fm3.isThisTrue = True
        fm3.Show()
        Dim fm4 As New FamiliarShake
        fm4.isThisTrue = True
        fm4.Show()
        Dim fm5 As New FamiliarShake
        fm5.isThisTrue = True
        fm5.Show()
        Dim fm6 As New FamiliarShake
        fm6.isThisTrue = True
        fm6.Show()
        Dim fm7 As New FamiliarShake
        fm7.isThisTrue = True
        fm7.Show()
        Dim fm8 As New FamiliarShake
        fm8.isThisTrue = True
        fm8.Show()
        Dim fm9 As New FamiliarShake
        fm9.isThisTrue = True
        fm9.Show()
        Dim fm10 As New FamiliarShake
        fm10.isThisTrue = True
        fm10.Show()
    End Sub

    Private Sub FamiliarShake_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick

    End Sub

    Private Sub FamiliarShake_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
        
    End Sub
End Class