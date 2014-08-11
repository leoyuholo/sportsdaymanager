Public Class Form6

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim cmdstr As String = "select * from SDMCompInfo where proj_code='" + Form1.Proj + "'"
        Form1.fill_table(cmdstr, dt)
        TextBox1.Text = dt.Rows(0)("school_name")
        TextBox2.Text = dt.Rows(0)("school_year")
        TextBox3.Text = dt.Rows(0)("title_of_competition")
        TextBox4.Text = dt.Rows(0)("venue")
        TextBox5.Text = dt.Rows(0)("bonus_for_participation")
        TextBox6.Text = dt.Rows(0)("absentee_penalty")
        TextBox7.Text = dt.Rows(0)("bonus_for_finals")
        TextBox8.Text = dt.Rows(0)("venue_address")
        DateTimePicker1.Text = dt.Rows(0)("date_of_day1")
        TextBox9.Text = dt.Rows(0)("start_time_day1")
        TextBox10.Text = dt.Rows(0)("end_time_day1")
        TextBox13.Text = dt.Rows(0)("position1_score")
        TextBox14.Text = dt.Rows(0)("position2_score")
        TextBox15.Text = dt.Rows(0)("position3_score")
        TextBox16.Text = dt.Rows(0)("position4_score")
        TextBox17.Text = dt.Rows(0)("position5_score")
        TextBox18.Text = dt.Rows(0)("position6_score")
        TextBox19.Text = dt.Rows(0)("position7_score")
        TextBox20.Text = dt.Rows(0)("position8_score")

        If dt.Rows(0)("no_of_days") = 1 Then
            RadioButton1.Checked = True
        ElseIf dt.Rows(0)("no_of_days") = 2 Then
            RadioButton2.Checked = True
            DateTimePicker2.Enabled = True
            DateTimePicker2.Text = dt.Rows(0)("date_of_day2")
            TextBox11.Enabled = True
            TextBox12.Enabled = True
            TextBox11.Text = dt.Rows(0)("start_time_day2")
            TextBox12.Text = dt.Rows(0)("end_time_day2")
        End If
        Select Case dt.Rows(0)("sex")
            Case "B"
                RadioButton3.Checked = True
            Case "G"
                RadioButton4.Checked = True
            Case "C"
                RadioButton5.Checked = True
        End Select
        If dt.Rows(0)("a_grade") = "1" Then
            CheckBox1.Checked = True
            DateTimePicker3.Enabled = True
            DateTimePicker3.Text = dt.Rows(0)("a_grade_time")
        End If
        If dt.Rows(0)("b_grade") = "1" Then
            CheckBox2.Checked = True
            DateTimePicker4.Enabled = True
            DateTimePicker4.Text = dt.Rows(0)("b_grade_time")
        End If
        If dt.Rows(0)("c_grade") = "1" Then
            CheckBox3.Checked = True
            DateTimePicker5.Enabled = True
            DateTimePicker5.Text = dt.Rows(0)("c_grade_time")
        End If

        Form1.dgv_show(Me.DataGridView1, "_house")
        Form1.dgv_show(Me.DataGridView2, "_student", "*", "order by SID")
        Label29.Text = Me.DataGridView2.Rows.Count & " Rows"
        Form1.dgv_show(Me.DataGridView3, "_event", "*", "where Event_Code <> '100NNN' order by Event_Code")
        Label30.Text = Me.DataGridView3.Rows.Count & " Rows"
        Form1.dgv_show(Me.DataGridView4, "_helperteam", "*", "where Team_Code <> '1000' order by Team_Code")
        Label31.Text = Me.DataGridView4.Rows.Count & " Rows"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Close()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Me.Close()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nod As Integer
        If RadioButton1.Checked = True Then
            nod = 1
        Else
            nod = 2
        End If
        Dim cmdstr As String = "update SDMCompInfo set school_name='" + TextBox1.Text + "',school_year='" + TextBox2.Text + "',title_of_competition='" + TextBox3.Text + "',venue='" + TextBox4.Text + "',venue_address='" + TextBox8.Text + "',no_of_days=" + Trim(Str(nod)) + ",date_of_day1='" + Trim(Str(DateTimePicker1.Value.Year)) + "/" + Trim(Str(DateTimePicker1.Value.Month)) + "/" + Trim(Str(DateTimePicker1.Value.Day)) + "', start_time_day1 ='" + TextBox9.Text + "', end_time_day1 ='" + TextBox10.Text + "' "
        If RadioButton2.Checked = True Then
            cmdstr = cmdstr + ", date_of_day2='" + Trim(Str(DateTimePicker2.Value.Year)) + "/" + Trim(Str(DateTimePicker2.Value.Month)) + "/" + Trim(Str(DateTimePicker2.Value.Day)) + "', start_time_day2 ='" + TextBox11.Text + "', end_time_day2 ='" + TextBox12.Text + "'"
        End If
        cmdstr = cmdstr + " where proj_code='" + Form1.Proj + "'"
        Form1.enq_exe(cmdstr)
        TabControl1.SelectTab(1)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        DateTimePicker2.Enabled = False
        TextBox11.Enabled = False
        TextBox12.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        DateTimePicker2.Enabled = True
        TextBox11.Enabled = True
        TextBox12.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim sex As String = "C"
        If RadioButton3.Checked = True Then
            sex = "B"
        ElseIf RadioButton4.Checked = True Then
            sex = "G"
        ElseIf RadioButton5.Checked = True Then
            sex = "C"
        End If
        Dim a, b, c As Integer
        If CheckBox1.Checked = True Then
            a = 1
        End If
        If CheckBox2.Checked = True Then
            b = 1
        End If
        If CheckBox3.Checked = True Then
            c = 1
        End If
        If CheckBox1.Checked = True And CheckBox2.Checked = False And CheckBox3.Checked = True Then
            MsgBox("You cannot open A, C grade without B grade")
            Exit Sub
        End If
        Dim cmdstr As String = "update SDMCompInfo set bonus_for_participation='" + TextBox5.Text + "',absentee_penalty='" + TextBox6.Text + "',bonus_for_finals='" + TextBox7.Text + "', position1_score='" + TextBox13.Text + "', position2_score='" + TextBox14.Text + "', position3_score='" + TextBox15.Text + "', position4_score='" + TextBox16.Text + "', position5_score='" + TextBox17.Text + "', position6_score='" + TextBox18.Text + "', position7_score='" + TextBox19.Text + "', position8_score='" + TextBox20.Text + "', sex='" + sex + "',a_grade=" + Trim(Str(a)) + ",b_grade=" + Trim(Str(b)) + ",c_grade=" + Trim(Str(c))
        If CheckBox1.Checked = True Then
            cmdstr = cmdstr + ",a_grade_time='" + Trim(Str(DateTimePicker3.Value.Year)) + "/" + Trim(Str(DateTimePicker3.Value.Month)) + "/" + Trim(Str(DateTimePicker3.Value.Day)) + "'"
        End If
        If CheckBox2.Checked = True Then
            cmdstr = cmdstr + ",b_grade_time='" + Trim(Str(DateTimePicker4.Value.Year)) + "/" + Trim(Str(DateTimePicker4.Value.Month)) + "/" + Trim(Str(DateTimePicker4.Value.Day)) + "'"
        End If
        If CheckBox3.Checked = True Then
            cmdstr = cmdstr + ",c_grade_time='" + Trim(Str(DateTimePicker5.Value.Year)) + "/" + Trim(Str(DateTimePicker5.Value.Month)) + "/" + Trim(Str(DateTimePicker5.Value.Day)) + "'"
        End If
        cmdstr = cmdstr + " where proj_code='" + Form1.Proj + "'"
        Form1.enq_exe(cmdstr)
        TabControl1.SelectTab(2)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Label13.Enabled = True
            DateTimePicker3.Enabled = True
        End If
        If CheckBox1.Checked = False Then
            Label13.Enabled = False
            DateTimePicker3.Enabled = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Label14.Enabled = True
            DateTimePicker4.Enabled = True
        End If
        If CheckBox2.Checked = False Then
            Label14.Enabled = False
            DateTimePicker4.Enabled = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Label15.Enabled = True
            DateTimePicker5.Enabled = True
        End If
        If CheckBox3.Checked = False Then
            Label15.Enabled = False
            DateTimePicker5.Enabled = False
        End If
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        If MsgBox("Delete " + DataGridView1.CurrentRow.Cells(0).Value + " House?", MsgBoxStyle.OkCancel, "Delete House") = 1 Then
            Dim cmdstr As String = "delete from " + Form1.Proj + "_house where House_Code='" + DataGridView1.CurrentRow.Cells(0).Value + "'"
            Form1.enq_exe(cmdstr)
            Form1.dgv_show(Me.DataGridView1, "_house")
        End If
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Form7.Show()
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        If MsgBox("Delete All Students' Record?", MsgBoxStyle.OkCancel, "Delete All Students") = 1 Then
            Dim cmdstr As String = "delete from " + Form1.Proj + "_student"
            Form1.enq_exe(cmdstr)
            Form1.dgv_show(Me.DataGridView2, "_student", "*", "order by SID")
            Label29.Text = Me.DataGridView2.Rows.Count & " Rows"
        End If
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        If MsgBox("Delete Student " + DataGridView2.CurrentRow.Cells(1).Value + "?", MsgBoxStyle.OkCancel, "Delete Student") = 1 Then
            Dim cmdstr As String = "delete from " + Form1.Proj + "_student where SID='" + DataGridView2.CurrentRow.Cells(0).Value + "'"
            Form1.enq_exe(cmdstr)
            Form1.dgv_show(Me.DataGridView2, "_student", "*", "order by SID")
            Label29.Text = Me.DataGridView2.Rows.Count & " Rows"
        End If
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        Form10.Show()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Form9.Show()
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        Form11.Show()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Form12.Show()
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Form13.Show()
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        Form14.Show()
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        Form15.Show()
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        Form16.Show()
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        If MsgBox("Delete All Helper Teams' Record?", MsgBoxStyle.OkCancel, "Delete All Helper Team") = 1 Then
            Dim cmdstr As String = "delete from " + Form1.Proj + "_helperteam where Team_Code <> '1000'"
            Form1.enq_exe(cmdstr)
            Form1.dgv_show(Me.DataGridView4, "_helperteam", "*", "where Team_Code <> '1000' order by Team_Code")
            Label31.Text = Me.DataGridView4.Rows.Count & " Rows"
        End If
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        If MsgBox("Delete Helper Team " + DataGridView4.CurrentRow.Cells(1).Value + "?", MsgBoxStyle.OkCancel, "Delete Helper Team") = 1 Then
            Dim cmdstr As String = "delete from " + Form1.Proj + "_helperteam where Team_Code='" + DataGridView4.CurrentRow.Cells(0).Value + "'"
            Form1.enq_exe(cmdstr)
            Form1.dgv_show(Me.DataGridView4, "_helperteam", "*", "where Team_Code <> '1000' order by Team_Code")
            Label31.Text = Me.DataGridView4.Rows.Count & " Rows"
        End If
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        If MsgBox("Delete All Events?", MsgBoxStyle.OkCancel, "Delete All Events") = 1 Then
            Dim cmdstr As String = "delete from " + Form1.Proj + "_event where Event_Code <>'100NNN'"
            Form1.enq_exe(cmdstr)
            Form1.dgv_show(Me.DataGridView3, "_event", "*", "where Event_Code <> '100NNN' order by Event_Code")
            Label30.Text = Me.DataGridView3.Rows.Count & " Rows"
        End If
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        If MsgBox("Delete " + DataGridView3.CurrentRow.Cells(1).Value + "?", MsgBoxStyle.OkCancel, "Delete Event") = 1 Then
            Dim cmdstr As String = "delete from " + Form1.Proj + "_event where Event_Code='" + DataGridView3.CurrentRow.Cells(0).Value + "'"
            Form1.enq_exe(cmdstr)
            Form1.dgv_show(Me.DataGridView3, "_event", "*", "where Event_Code <> '100NNN' order by Event_Code")
            Label30.Text = Me.DataGridView3.Rows.Count & " Rows"
        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        TabControl1.SelectTab(5)
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        If MsgBox("Reset Helper Team List?", MsgBoxStyle.OkCancel, "Reset Helper Team") = 1 Then
            Dim cmdstr As String = "delete from " + Form1.Proj + "_helperteam"
            Form1.enq_exe(cmdstr)
            cmdstr = ""
            cmdstr = "insert into " + Form1.Proj + "_helperteam select * from s_helperteam"
            Form1.enq_exe(cmdstr)
            Form1.dgv_show(Me.DataGridView4, "_helperteam", "*", "where Team_Code <> '1000' order by Team_Code")
            Label31.Text = Me.DataGridView4.Rows.Count & " Rows"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        TabControl1.SelectTab(3)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TabControl1.SelectTab(3)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        TabControl1.SelectTab(4)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TabControl1.SelectTab(4)
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Dim cmdstr As String = "drop table if exists " + Form1.Proj + "_eventregister"
        Form1.enq_exe(cmdstr)
        cmdstr = "create table " + Form1.Proj + "_eventregister (SID char(10), Event1 char(6) NOT NULL, Event2 char(6) NOT NULL, Event3 char(6) NOT NULL, primary key(SID))"
        Form1.enq_exe(cmdstr)
        cmdstr = "insert into " + Form1.Proj + "_eventregister (SID) select SID from " + Form1.Proj + "_student"
        Form1.enq_exe(cmdstr)
        cmdstr = "drop table if exists " + Form1.Proj + "_helperregister"
        Form1.enq_exe(cmdstr)
        cmdstr = "create table " + Form1.Proj + "_helperregister (SID char(10), Team_Code char(4))"
        Form1.enq_exe(cmdstr)
        cmdstr = "insert into " + Form1.Proj + "_helperregister (SID) select SID from " + Form1.Proj + "_student"
        Form1.enq_exe(cmdstr)
        cmdstr = "drop view if exists " + Form1.Proj + "_noofgroups"
        Form1.enq_exe(cmdstr)
        cmdstr = "create view " + Form1.Proj + "_noofgroups as select e.Event_Code, Event_Name, Grade, Sex, Field_or_Track, Assign_Lane, Holding_Area, count(*) as No_of_Participants, convert(ceiling(count(*)/8), char) as No_of_Groups from " + Form1.Proj + "_event e, " + Form1.Proj + "_eventregister r where Assign_Lane ='1' and (e.Event_Code=r.Event1 or e.Event_Code=r.Event2 or e.Event_Code=r.Event3) group by e.Event_Code union select e.Event_Code, Event_Name, Grade, Sex, Field_or_Track, Assign_Lane, Holding_Area, count(*) as No_of_Participants, '1' as No_of_Groups from " + Form1.Proj + "_event e, " + Form1.Proj + "_eventregister r where Assign_Lane ='0' and (e.Event_Code=r.Event1 or e.Event_Code=r.Event2 or e.Event_Code=r.Event3) group by e.Event_Code"
        Form1.enq_exe(cmdstr)
        cmdstr = "update SDMProj set Stage_1 ='1' where Proj_code ='" + Form1.Proj + "'"
        Form1.enq_exe(cmdstr)
        Form1.menustrip_enable()
        MsgBox("You can start registering process now.")
        Me.Close()
        Form30.refresh_load()
        Form1.TabControl0.Visible = False
        Form1.TabControl1.Visible = True
        Form1.TabControl2.Visible = False
        Form1.TabControl3.Visible = False
        Form1.TabControl4.Visible = False
        Form1.TabControl5.Visible = False
    End Sub

End Class

