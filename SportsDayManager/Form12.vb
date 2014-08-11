Public Class Form12
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        ComboBox1.ResetText()
        DateTimePicker1.ResetText()
    End Sub

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Form6.DataGridView2.CurrentRow.Cells(0).Value
        TextBox2.Text = Form6.DataGridView2.CurrentRow.Cells(1).Value
        ComboBox1.Text = Form6.DataGridView2.CurrentRow.Cells(2).Value
        DateTimePicker1.Text = Form6.DataGridView2.CurrentRow.Cells(3).Value
        TextBox3.Text = Form6.DataGridView2.CurrentRow.Cells(4).Value
        TextBox4.Text = Form6.DataGridView2.CurrentRow.Cells(5).Value
        TextBox5.Text = Form6.DataGridView2.CurrentRow.Cells(6).Value
        TextBox6.Text = Form6.DataGridView2.CurrentRow.Cells(7).Value
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please fill in SID.")
        Else
            Dim cmdstr As String = "update " + Form1.Proj + "_student set SID='" + TextBox1.Text + "', Name='" + TextBox2.Text + "', Sex='" + ComboBox1.Text + "', DOB='" + Trim(Str(DateTimePicker1.Value.Year)) + "/" + Trim(Str(DateTimePicker1.Value.Month)) + "/" + Trim(Str(DateTimePicker1.Value.Day)) + "', House='" + TextBox3.Text + "', Class='" + TextBox4.Text + "', Class_No='" + TextBox5.Text + "', HKID ='" + TextBox7.Text + "', Emergency_Call_Phone_Number='" + TextBox6.Text + "' where SID='" + TextBox1.Text + "'"
            Form1.enq_exe(cmdstr)
            MsgBox("Edited successfully")
            Form1.dgv_show(Form6.DataGridView2, "_student", "*", "order by SID")
            Form6.Label29.Text = Form6.DataGridView2.Rows.Count & " Rows"
        End If
    End Sub
End Class