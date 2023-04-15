Public Class Form1

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s1, s2, s3, s4, s5, s6, s7 As String
        s1 = TextBox1.Text
        s2 = " "
        If RadioButton1.Checked = True Then
            s2 = "Male"
        Else
            s2 = "Female"
        End If
        s3 = DateTimePicker1.Text
        s4 = TextBox2.Text
        s5 = " "
        If CheckBox1.Checked = True Then
            s5 = "Single"
        Else
            s5 = "Married"
        End If
        s6 = TextBox3.Text
        s7 = TextBox4.Text
        MsgBox("Name: " + s1 + vbNewLine + "Gender: " + s2 + vbNewLine + "DOB: " + s3 + vbNewLine + "Mobile No.: " + s4 + vbNewLine + "Marital Status: " + s5 + vbNewLine + "E-Mail ID: " + s6 + vbNewLine + "Address: " + s7 + vbNewLine)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
