Public Class Form3

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s1, s2, s3, s4 As String
        s1 = TextBox1.Text
        s2 = DateTimePicker1.Text
        s3 = TextBox3.Text
        s4 = TextBox4.Text
        MsgBox("Name: " + s1 + vbNewLine + "DOB: " + s2 + vbNewLine + "Address: " + s3 + vbNewLine + "Mobile No.: " + s4)
    End Sub
End Class