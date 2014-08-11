Public Class Form14
    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Form6.DataGridView4.CurrentRow.Cells(1).Value
        TextBox2.Text = Form6.DataGridView4.CurrentRow.Cells(2).Value
        TextBox3.Text = Form6.DataGridView4.CurrentRow.Cells(3).Value
        TextBox4.Text = Form6.DataGridView4.CurrentRow.Cells(4).Value
        TextBox5.Text = Form6.DataGridView4.CurrentRow.Cells(5).Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim e_code As String = Form6.DataGridView4.CurrentRow.Cells(0).Value
        Dim cmdstr As String = "update " + Form1.Proj + "_helperteam set Team_Name='" + TextBox1.Text + "', Leading_Teacher='" + TextBox2.Text + "', Working_Area='" + TextBox3.Text + "', Duty_Time_Start='" + TextBox4.Text + "', Duty_Time_End='" + TextBox5.Text + "'where Team_Code='" + Form6.DataGridView4.CurrentRow.Cells(0).Value + "'"
        Form1.enq_exe(cmdstr)
        MsgBox("Edited successfully")
        Form1.dgv_show(Form6.DataGridView4, "_helperteam", "*", "where Team_Code <> '1000' order by Team_Code")
        Form6.Label31.Text = Form6.DataGridView4.Rows.Count & " Rows"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub
End Class