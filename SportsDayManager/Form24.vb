Public Class Form24

    Private Sub Form24_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DataGridView1.Rows.Count <> 0 Then
            Form1.print_html(DataGridView1, "t", Me.Text.Substring(0, 1))
        End If
    End Sub
End Class