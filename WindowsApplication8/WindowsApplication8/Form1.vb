Public Class Form1

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll, HScrollBar2.Scroll, HScrollBar3.Scroll
        Label5.BackColor = Color.FromArgb(HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value)
        NumericUpDown1.Value = HScrollBar1.Value
        NumericUpDown2.Value = HScrollBar2.Value
        NumericUpDown3.Value = HScrollBar3.Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.BackColor = Label5.BackColor
    End Sub
End Class
