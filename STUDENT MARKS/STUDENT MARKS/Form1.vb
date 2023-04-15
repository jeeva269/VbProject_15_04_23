Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("Register No", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Name", 130, HorizontalAlignment.Left)
        ListView1.Columns.Add("VB", 60, HorizontalAlignment.Center)
        ListView1.Columns.Add("RDBMS", 60, HorizontalAlignment.Center)
        ListView1.Columns.Add("NME", 60, HorizontalAlignment.Center)
        ListView1.Columns.Add("STAT", 60, HorizontalAlignment.Center)
        ListView1.Columns.Add("TOTAL", 60, HorizontalAlignment.Center)
        ListView1.Columns.Add("AVG", 60, HorizontalAlignment.Center)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim VB, RDBMS, NME, STAT As Single
        Dim total, avg As Single
        VB = Val(tvb.Text)
        RDBMS = Val(trdbms.Text)
        NME = Val(tswe.Text)
        STAT = Val(tstat.Text)
        total = VB + RDBMS + NME + STAT
        avg = total / 4
        ListView1.Items.Add(New ListViewItem({treg.Text, tname.Text, VB, RDBMS, NME, STAT, total, avg}))
        treg.Clear()
        tname.Clear()
        tvb.Clear()
        trdbms.Clear()
        tswe.Clear()
        tstat.Clear()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class
