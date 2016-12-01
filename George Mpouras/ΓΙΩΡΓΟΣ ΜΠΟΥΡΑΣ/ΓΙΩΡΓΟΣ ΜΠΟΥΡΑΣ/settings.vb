Public Class settings
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles Homepage.Enter

    End Sub

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.Homepage

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Homepage = TextBox1.Text
        MsgBox("Done")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.Homepage = ("http://www.google.com")
    End Sub
End Class