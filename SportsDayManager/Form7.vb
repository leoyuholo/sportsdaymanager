Public Class Form7

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please fill in all blanks.")
        Else
            Dim cmdstr As String = "insert into " + Form1.Proj + "_house(House_Name, House_Code) value('" + TextBox1.Text + "','" + TextBox2.Text + "')"
            Form1.enq_exe(cmdstr)
            Form1.dgv_show(Form6.DataGridView1, "_house")
            TextBox1.Clear()
            TextBox2.Clear()
        End If
    End Sub
End Class