Public Class Form11
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim t_code As Integer
        Dim cmdtc As String = "select max(Team_Code) from " + Form1.Proj + "_helperteam"
        t_code = Form1.esint_exe(cmdtc)
        t_code += 1
        Dim cmdstr As String = "insert into " + Form1.Proj + "_helperteam(Team_Code, Team_Name, Leading_Teacher, Working_Area, Duty_Time_Start, Duty_Time_End) value ('" + Trim(Str(t_code)) + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')"
        Form1.enq_exe(cmdstr)
        Form1.dgv_show(Form6.DataGridView4, "_helperteam", "*", "where Team_Code <> '1000' order by Team_Code")
        Form6.Label31.Text = Form6.DataGridView4.Rows.Count & " Rows"
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class