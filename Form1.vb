Public Class Form1
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Please provide information!")
            Else
                DbDesigner.LoginIndex()
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            Me.Dispose()
        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please provide information!")
        Else
            DbDesigner.LoginIndex()
        End If
    End Sub
End Class
