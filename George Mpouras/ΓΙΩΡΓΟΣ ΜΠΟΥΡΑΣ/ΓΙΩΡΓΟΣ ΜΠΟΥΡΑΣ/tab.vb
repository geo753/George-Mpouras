Public Class tab
    Private Sub tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebControl1.Source = New Uri(My.Settings.Homepage)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebControl1.GoBack()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebControl1.GoForward()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebControl1.Reload(ignoreCache:=True)



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click




    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".gr") Or TextBox1.Text.Contains(".org") Or TextBox1.Text.Contains(".net") Then
            Try
                WebControl1.Source = New Uri(TextBox1.Text)
            Catch ex As System.UriFormatException
                WebControl1.Source = New Uri("http://" + TextBox1.Text)



            End Try
        End If



    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_ShowCreatedWebView(sender As Object, e As Awesomium.Core.ShowCreatedWebViewEventArgs) Handles WebControl1.ShowCreatedWebView

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub AboutApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutApplicationToolStripMenuItem.Click
        MessageBox.Show("ΑΥΤΗ Η ΕΦΑΡΜΟΓΗ ΔΗΜΙΟΥΡΓΗΘΗΚΕ ΤΟ 2016.ΕΙΝΑΙ ΕΝΑΣ BROWSER ΠΟΥ ΠΡΟΣΠΑΘΕΙ ΝΑ ΚΑΝΕΙ ΤΗΝ ΠΕΡΙΗΓΗΣΗ ΣΑΣ ΣΤΟ ΔΙΑΔΙΚΤΥΟ ΠΙΟ ΓΡΗΓΟΡΗ ", "browser")
    End Sub

    Private Sub AboutProgrammerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutProgrammerToolStripMenuItem.Click
        MessageBox.Show("ΟΝΟΜΑΖΟΜΑΙ ΜΠΟΥΡΑΣ ΓΙΩΡΓΟΣ.ΕΙΜΑΙ ΕΝΑ ΑΝΕΡΧΟΜΕΝΟ ΑΣΤΕΡΙ ΣΤΟΝ ΤΟΜΕΑ ΤΟΥ ΠΡΟΓΡΑΜΜΑΤΙΣΜΟΥ.Η 1Η ΜΟΥ ΔΟΥΛΕΙΑ ΕΙΝΑΙ ΑΥΤΟΣ Ο BROWSER ΚΑΙ ΠΡΟΣΠΑΘΩ ΠΑΝΤΑ ΓΙΑ ΤΟ ΚΑΛΥΤΕΡΟ", "browser")
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        settings.Show()
    End Sub
End Class