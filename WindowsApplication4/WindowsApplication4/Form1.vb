Public Class Form1
    Dim fsize As Integer

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Font = New Font(TextBox1.Font.FontFamily, fsize, FontStyle.Bold)
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        TextBox1.ForeColor = Color.Gray
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Font = New Font(TextBox1.Font.FontFamily, fsize, FontStyle.Regular)
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        TextBox1.Font = New Font(TextBox1.Font.FontFamily, fsize, FontStyle.Italic)
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        TextBox1.Font = New Font(TextBox1.Font.FontFamily, fsize, FontStyle.Underline)
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        TextBox1.ForeColor = Color.Red
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        TextBox1.ForeColor = Color.Green
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        TextBox1.ForeColor = Color.Pink
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        TextBox1.ForeColor = Color.Blue
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        TextBox1.ForeColor = Color.Purple
    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        TextBox1.ForeColor = Color.Orange
    End Sub

    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton12.CheckedChanged
        TextBox1.ForeColor = Color.SkyBlue
    End Sub

    Private Sub RadioButton16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton16.CheckedChanged
        TextBox1.Font = New Font("Times New Roman", fsize)
    End Sub

    Private Sub RadioButton15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton15.CheckedChanged
        TextBox1.Font = New Font("Autographer", fsize)
    End Sub

    Private Sub RadioButton14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton14.CheckedChanged
        TextBox1.Font = New Font("Snap ITC", fsize)
    End Sub

    Private Sub RadioButton13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton13.CheckedChanged
        TextBox1.Font = New Font("Vikram Poster Font", fsize)
    End Sub

    


    Private Sub TextBox2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        fsize = TextBox2.Text
    End Sub
End Class
