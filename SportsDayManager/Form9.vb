Public Class Form9

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        DateTimePicker1.ResetText()
        ComboBox1.ResetText()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please fill in SID.")
        Else
            Dim cmdstr As String = "insert into " + Form1.Proj + "_student(SID, Name, Sex, DOB, House, Class, Class_No, HKID, Emergency_Call_Phone_Number) value('" + TextBox1.Text + "','" + TextBox2.Text + "','" + ComboBox1.Text + "','" + Trim(Str(DateTimePicker1.Value.Year)) + "/" + Trim(Str(DateTimePicker1.Value.Month)) + "/" + Trim(Str(DateTimePicker1.Value.Day)) + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox7.Text + "','" + TextBox6.Text + "')"
            Form1.enq_exe(cmdstr)
            Form1.dgv_show(Form6.DataGridView2, "_student", "*", "order by SID")
            Form6.Label29.Text = Form6.DataGridView2.Rows.Count & " Rows"
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            DateTimePicker1.ResetText()
            ComboBox1.ResetText()
        End If
    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class