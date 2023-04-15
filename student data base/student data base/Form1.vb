Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.StudentDataSet.Table1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Table1BindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Table1BindingSource.MoveNext()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Table1BindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        total.Text = Val(tvb.Text) + Val(trdbms.Text) + Val(tswe.Text) + Val(tstat.Text)

        Try
            Table1BindingSource.EndEdit()
            Table1TableAdapter.Update(StudentDataSet.Table1)
            MessageBox.Show("Updated Successfully")

        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
        

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Close()
    End Sub
End Class
