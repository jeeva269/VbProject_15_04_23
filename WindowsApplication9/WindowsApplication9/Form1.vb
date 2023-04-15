Public Class Form1

    Private Sub VIEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWToolStripMenuItem.Click

    End Sub

    Private Sub QUITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QUITToolStripMenuItem.Click
        MessageBox.Show("You opted Exit!")
        Close()
    End Sub

    Private Sub NEWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NEWToolStripMenuItem.Click
        MessageBox.Show("New file is created")
    End Sub

    Private Sub SAVEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEToolStripMenuItem.Click
        MessageBox.Show("Your file saved successfully!")
    End Sub

    Private Sub PRINTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRINTToolStripMenuItem.Click
        MessageBox.Show("Print is Processing!")
    End Sub
End Class
