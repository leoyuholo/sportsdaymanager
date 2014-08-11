Public Class Form23
    Public f23_e_code(0) As String
    Dim sid(0) As String
    Private Sub Form23_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmdstr As String = "select Event_Code, Event_Name from " + Form1.Proj + "_event where Event_code <>'100NNN' union select Event_Code, Event_Name from " + Form1.Proj + "_finals order by Event_Code"
        Dim dt As New DataTable
        Form1.fill_table(cmdstr, dt)
        ReDim f23_e_code(500)
        ListBox1.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            ListBox1.Items.Add(dt.Rows(i)("Event_Name"))
            f23_e_code(i) = dt.Rows(i)("Event_Code")
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            If f23_e_code(ListBox1.SelectedIndex).Substring(f23_e_code(ListBox1.SelectedIndex).Length - 1, 1) = "T" Then
                Form1.dgv_show2(Me.DataGridView1, "select Name, Class, Class_No, House_Name as House, Result as 'Result(Seconds)' from " + Form1.Proj + "_student s, " + Form1.Proj + "_house h, " + Form1.Proj + "_results r where s.SID=r.SID and s.House=h.House_Code and Event_Code ='" + f23_e_code(ListBox1.SelectedIndex) + "' and Absent <>'ABS' order by Result asc")
            Else
                Form1.dgv_show2(Me.DataGridView1, "select Name, Class, Class_No, House_Name as House, Result as 'Result(Meters)' from " + Form1.Proj + "_student s, " + Form1.Proj + "_house h, " + Form1.Proj + "_results r where s.SID=r.SID and s.House=h.House_Code and Event_Code ='" + f23_e_code(ListBox1.SelectedIndex) + "' and Absent <>'ABS' order by Result desc")
            End If
           
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form27.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form28.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex <> -1 Then
            Form26.Show()
        Else
            MsgBox("Please select an event first")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form29.Show()
        Dim cmdstr As String = "drop table if exists " + Form1.Proj + "_finalslane"
        Form1.enq_exe(cmdstr)
        cmdstr = "create table " + Form1.Proj + "_finalslane (Event_Code char(7), Lane1 char(10) , Lane2 char(10), Lane3 char(10), Lane4 char(10), Lane5 char(10), Lane6 char(10), Lane7 char(10), Lane8 char(10))"
        Form1.enq_exe(cmdstr)
        cmdstr = "select right(Event_Code, 6) as Event_Code from " + Form1.Proj + "_finals"
        Dim dt As New DataTable
        Form1.fill_table(cmdstr, dt)
        Dim lane() As String = {"Lane4", "Lane5", "Lane3", "Lane6", "Lane2", "Lane7", "Lane1", "Lane8"}
        For i = 0 To dt.Rows.Count - 1
            cmdstr = "insert into " + Form1.Proj + "_finalslane (Event_Code) value ('F" + dt.Rows(i)("Event_Code") + "')"
            Form1.enq_exe(cmdstr)
            cmdstr = "select SID from " + Form1.Proj + "_results where Result not like 'abs' and Event_Code ='" + dt.Rows(i)("Event_Code") + "' order by Result asc limit 0,8"
            Dim rank As New DataTable
            Form1.fill_table(cmdstr, rank)
            cmdstr = "update " + Form1.Proj + "_finalslane set "
            For j = 0 To rank.Rows.Count - 1
                cmdstr = cmdstr + lane(j) + "= '" + rank.Rows(j)("SID") + "', "
            Next
            cmdstr = cmdstr.Substring(0, cmdstr.Length - 2) + " where Event_Code ='F" + dt.Rows(i)("Event_Code") + "'"
            Form1.enq_exe(cmdstr)
        Next
        Form1.dgv_show2(Me.DataGridView2, "SELECT Event_Name, l1.Name as Lane1, l2.Name as Lane2, l3.Name as Lane3, l4.Name as Lane4, l5.Name as Lane5, l6.Name as Lane6, l7.Name as Lane7, l8.Name as Lane8 FROM " + Form1.Proj + "_finalslane l left join " + Form1.Proj + "_finals f on l.event_code=f.event_code left join " + Form1.Proj + "_student l1 on l.lane1=l1.SID left join " + Form1.Proj + "_student l2 on l.lane2=l2.SID left join " + Form1.Proj + "_student l3 on l.lane3=l3.SID left join " + Form1.Proj + "_student l4 on l.lane4=l4.SID left join " + Form1.Proj + "_student l5 on l.lane5=l5.SID left join " + Form1.Proj + "_student l6 on l.lane6=l6.SID left join " + Form1.Proj + "_student l7 on l.lane7=l7.SID left join " + Form1.Proj + "_student l8 on l.lane8=l8.SID")
        Form29.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form29.Show()
        Dim cmdstr As String = "drop table if exists " + Form1.Proj + "_award"
        Form1.enq_exe(cmdstr)
        cmdstr = "create table " + Form1.Proj + "_award (Event_Code char(7), Champion char(10), 1st_Runner_Up char(10), 2nd_Runner_Up char(10))"
        Form1.enq_exe(cmdstr)
        cmdstr = "select Event_Code from " + Form1.Proj + "_event where Assign_Lane ='0' and Event_Code <>'100NNN' union select Event_Code from " + Form1.Proj + "_finals"
        Dim dt As New DataTable
        Form1.fill_table(cmdstr, dt)
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("Event_Code").ToString.Substring(dt.Rows(i)("Event_Code").ToString.Length - 1, 1) = "T" Then
                cmdstr = "select SID from " + Form1.Proj + "_results where Absent not like 'abs' and Event_Code ='" + dt.Rows(i)("Event_Code") + "' order by Result asc limit 0,3"
            Else
                cmdstr = "select SID from " + Form1.Proj + "_results where Absent not like 'abs' and Event_Code ='" + dt.Rows(i)("Event_Code") + "' order by Result desc limit 0,3"
            End If
            Dim rank As New DataTable
            Form1.fill_table(cmdstr, rank)
            If rank.Rows.Count >= 3 Then
                cmdstr = "insert into " + Form1.Proj + "_award (Event_Code) value ('" + dt.Rows(i)("Event_Code") + "')"
                Form1.enq_exe(cmdstr)
                cmdstr = "update " + Form1.Proj + "_award set Champion= '" + rank.Rows(0)("SID") + "', 1st_Runner_Up= '" + rank.Rows(1)("SID") + "', 2nd_Runner_Up= '" + rank.Rows(2)("SID") + "' where Event_Code ='" + dt.Rows(i)("Event_Code") + "'"
                Form1.enq_exe(cmdstr)
            End If
        Next
        Form1.dgv_show2(Me.DataGridView3, "SELECT Event_Name, c.Name as Champion, cr.result as Champion_Result, 1st.Name as 1st_Runner_Up, 1str.result as 1st_Runner_Up_Result, 2nd.Name as 2nd_Runner_Up, 2ndr.result as 2nd_Runner_Up_Result FROM " + Form1.Proj + "_award a left join (select Event_Code, Event_Name from " + Form1.Proj + "_event union select Event_Code, Event_Name from " + Form1.Proj + "_finals)e on a.Event_Code=e.Event_Code left join " + Form1.Proj + "_student c on a.Champion=c.SID left join " + Form1.Proj + "_results cr on a.Champion=cr.SID and cr.event_code=a.event_code left join " + Form1.Proj + "_student 1st on a.1st_Runner_Up=1st.SID left join " + Form1.Proj + "_results 1str on a.1st_Runner_Up=1str.SID and 1str.event_code=a.event_code left join " + Form1.Proj + "_student 2nd on a.2nd_Runner_Up=2nd.SID left join " + Form1.Proj + "_results 2ndr on a.2nd_Runner_Up=2ndr.SID and 2ndr.event_code=a.event_code")
        Form29.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form1.dgv_show2(Me.DataGridView4, "select House_Name, Total_House_Score from " + Form1.Proj + "_house h, (select House, (House_Score+Adjustment) as Total_House_Score from " + Form1.Proj + "_adjusthousescore a, (select House, sum(Score) as House_Score from " + Form1.Proj + "_student s, " + Form1.Proj + "_results r where s.SID=r.SID group by House) hs where hs.House=a.House_code) t where t.House=h.House_code")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form29.Show()
        Dim cmdstr As String = "select * from SDMCompInfo where proj_code='" + Form1.Proj + "'"
        Dim cdt As New DataTable
        Form1.fill_table(cmdstr, cdt)
        cmdstr = "update " + Form1.Proj + "_results set Score=" + Trim(Str(cdt.Rows(0)("bonus_for_participation"))) + " where Result not like 'ABS'"
        Form1.enq_exe(cmdstr)
        cmdstr = "update " + Form1.Proj + "_results set Score=" + Trim(Str(cdt.Rows(0)("absentee_penalty"))) + " where Absent like 'ABS'"
        Form1.enq_exe(cmdstr)
        cmdstr = "select Event_Code from " + Form1.Proj + "_event where Assign_Lane='0' and Event_Code <>'100NNN' union select Event_Code from " + Form1.Proj + "_finals"
        Dim edt As New DataTable
        Form1.fill_table(cmdstr, edt)
        For i = 0 To edt.Rows.Count - 1
            cmdstr = "update " + Form1.Proj + "_results r set score=score+(select if(r.result=r1.result, " + Trim(Str(cdt.Rows(0)("position1_score"))) + ", if(r.result=r2.result, " + Trim(Str(cdt.Rows(0)("position2_score"))) + ", if(r.result=r3.result, " + Trim(Str(cdt.Rows(0)("position3_score"))) + ", if(r.result=r4.result, " + Trim(Str(cdt.Rows(0)("position4_score"))) + ", if(r.result=r5.result, " + Trim(Str(cdt.Rows(0)("position5_score"))) + ", if(r.result=r6.result, " + Trim(Str(cdt.Rows(0)("position6_score"))) + ", if(r.result=r7.result, " + Trim(Str(cdt.Rows(0)("position7_score"))) + ", if(r.result=r8.result, " + Trim(Str(cdt.Rows(0)("position8_score"))) + ", 0)))))))) from (select result from " + Form1.Proj + "_results r1 where r1.Event_Code='" + edt.Rows(i)("Event_Code") + "' and Absent<>'ABS' order by result desc limit 0,1) r1, (select result from " + Form1.Proj + "_results r1 where r1.Event_Code='" + edt.Rows(i)("Event_Code") + "' and Absent<>'ABS' order by result desc limit 1,1) r2, (select result from " + Form1.Proj + "_results r1 where r1.Event_Code='" + edt.Rows(i)("Event_Code") + "' and Absent<>'ABS' order by result desc limit 2,1) r3, (select result from " + Form1.Proj + "_results r1 where r1.Event_Code='" + edt.Rows(i)("Event_Code") + "' and Absent<>'ABS' order by result desc limit 3,1) r4, (select result from " + Form1.Proj + "_results r1 where r1.Event_Code='" + edt.Rows(i)("Event_Code") + "' and Absent<>'ABS' order by result desc limit 4,1) r5, (select result from " + Form1.Proj + "_results r1 where r1.Event_Code='" + edt.Rows(i)("Event_Code") + "' and Absent<>'ABS' order by result desc limit 5,1) r6, (select result from " + Form1.Proj + "_results r1 where r1.Event_Code='" + edt.Rows(i)("Event_Code") + "' and Absent<>'ABS' order by result desc limit 6,1) r7, (select result from " + Form1.Proj + "_results r1 where r1.Event_Code='" + edt.Rows(i)("Event_Code") + "' and Absent<>'ABS' order by result desc limit 7,1) r8) where r.Event_Code='" + edt.Rows(i)("Event_Code") + "'"
            Form1.enq_exe(cmdstr)
        Next
        Form1.dgv_show2(Me.DataGridView5, "select Name, Class, Class_No, h.House_Name as House, Total_Score from " + Form1.Proj + "_student s, " + Form1.Proj + "_house h, (select SID, sum(Score) as Total_Score from " + Form1.Proj + "_results group by SID) sc where s.House=h.House_code and s.SID=sc.SID order by Total_Score desc")
        Form29.Close()
    End Sub
End Class