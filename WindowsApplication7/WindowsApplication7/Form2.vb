Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s1, s2, s3, s4 As String
        s1 = TextBox1.Text
        s2 = DateTimePicker1.Text
        s3 = TextBox2.Text
        s4 = TextBox3.Text
        MsgBox("Name: " + s1 + vbNewLine + "DOB: " + s2 + vbNewLine + "Address: " + s3 + vbNewLine + "Mobile No.: " + s4)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class