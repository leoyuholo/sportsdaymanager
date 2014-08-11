Public Class Form19
    Function time_to_min(ByVal time As String) As Integer
        Return (Val(time.Substring(0, 2)) * 60) + Val(time.Substring(2, 2))
    End Function
    Function min_to_time(ByVal min As Integer) As String
        Return String.Concat(Math.Floor(min / 60).ToString("00"), (min Mod 60).ToString("00"))
    End Function

    Private Sub Form19_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.dgv_show(Me.DataGridView1, "_noofgroups")
        If Form1.Proj_settings.Rows(0)("Stage_2") = True Then
            Form1.dgv_show2(Me.DataGridView2, "SELECT Event_Name, Group_Code, l1.Name as Lane1, l2.Name as Lane2, l3.Name as Lane3, l4.Name as Lane4, l5.Name as Lane5, l6.Name as Lane6, l7.Name as Lane7, l8.Name as Lane8 FROM " + Form1.Proj + "_lane l left join " + Form1.Proj + "_event e on l.event_code=e.event_code left join " + Form1.Proj + "_student l1 on l.lane1=l1.SID left join " + Form1.Proj + "_student l2 on l.lane2=l2.SID left join " + Form1.Proj + "_student l3 on l.lane3=l3.SID left join " + Form1.Proj + "_student l4 on l.lane4=l4.SID left join " + Form1.Proj + "_student l5 on l.lane5=l5.SID left join " + Form1.Proj + "_student l6 on l.lane6=l6.SID left join " + Form1.Proj + "_student l7 on l.lane7=l7.SID left join " + Form1.Proj + "_student l8 on l.lane8=l8.SID")
            Button4.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Sub distribute_lanes()
        Dim cmd As String = "drop table if exists " + Form1.Proj + "_lane"
        Form1.enq_exe(cmd)
        Dim cmdstr As String = "create table " + Form1.Proj + "_lane (Event_Code char(6), Group_Code char(20), Lane1 char(10) , Lane2 char(10), Lane3 char(10), Lane4 char(10), Lane5 char(10), Lane6 char(10), Lane7 char(10), Lane8 char(10))"
        Form1.enq_exe(cmdstr)

        Dim dt As New DataTable
        cmdstr = "select Event_Code from " + Form1.Proj + "_noofgroups where Assign_Lane ='1' order by Event_Code"
        Form1.fill_table(cmdstr, dt)
        Dim e_code(dt.Rows.Count) As String
        For i = 0 To dt.Rows.Count - 1
            e_code(i) = dt.Rows(i)("Event_Code")
        Next


        Dim n_groups As Integer
        Dim g_code As String
        For f = 0 To dt.Rows.Count - 1
            cmdstr = "select No_of_Groups from " + Form1.Proj + "_noofgroups where Event_Code ='" + e_code(f) + "'"
            n_groups = Form1.esint_exe(cmdstr)
            cmdstr = "insert into " + Form1.Proj + "_lane (Event_Code, Group_Code) value "
            For g = 1 To n_groups
                g_code = e_code(f) + "G" + Trim(g.ToString("00"))
                cmdstr = cmdstr + "('" + e_code(f) + "','" + g_code + "'), "
            Next
            Form1.enq_exe(cmdstr.Substring(0, cmdstr.Length - 2))
        Next


        Dim h, ng, s1, s2 As Integer
        Dim tmp As String
        Dim dtsid As New DataTable
        Dim lane() As String = {"Lane4", "Lane5", "Lane3", "Lane6", "Lane2", "Lane7", "Lane1", "Lane8"}
        For f = 0 To dt.Rows.Count - 1
            cmdstr = "select SID from " + Form1.Proj + "_eventregister where Event1 ='" + e_code(f) + "' or Event2 ='" + e_code(f) + "' or Event3 ='" + e_code(f) + "'"
            dtsid.Reset()
            Form1.fill_table(cmdstr, dtsid)
            Dim sid(dtsid.Rows.Count) As String
            For j = 0 To dtsid.Rows.Count - 1
                sid(j) = dtsid.Rows(j)("SID")
            Next
            Randomize()
            For j = 1 To 100
                Do
                    s1 = Int(Rnd() * (sid.Length - 1))
                    s2 = Int(Rnd() * (sid.Length - 1))
                Loop While s1 = s2
                tmp = sid(s1)
                sid(s1) = sid(s2)
                sid(s2) = tmp
            Next
            h = 0
            cmdstr = "select No_of_Groups from " + Form1.Proj + "_noofgroups where Event_Code ='" + e_code(f) + "'"
            n_groups = Form1.esint_exe(cmdstr)
            For i = 0 To 7
                ng = 1
                For ng = 1 To n_groups
                    If h > dtsid.Rows.Count - 1 Then
                        Exit For
                    Else
                        cmdstr = "update " + Form1.Proj + "_lane set " + lane(i) + "= '" + sid(h) + "' where Group_Code ='" + Trim(e_code(f)) + "G" + Trim(ng.ToString("00")) + "'"
                        Form1.enq_exe(cmdstr)
                        h = h + 1
                    End If
                Next
            Next
        Next
    End Sub
    Sub create_timetable()
        Dim ttdt As New DataTable
        Dim cmdstr As String = "select * from SDMCompInfo where proj_code ='" + Form1.Proj + "'"
        Form1.fill_table(cmdstr, ttdt)
        Dim sex() As String = {"Boys", "Girls"}
        Dim x As Integer = ttdt.Rows(0)("no_of_days")
        For i = 1 To x
            cmdstr = "drop table if exists " + Form1.Proj + "_timetableday" + Trim(Str(i))
            Form1.enq_exe(cmdstr)
            cmdstr = "create table " + Form1.Proj + "_timetableday" + Trim(Str(i)) + " (Time char(4), "
            Select Case ttdt.Rows(0)("sex")
                Case "B"
                    If ttdt.Rows(0)("a_grade") = 1 Then
                        cmdstr = cmdstr + sex(0) + "A_Grade char(20) NOT NULL, "
                    End If
                    If ttdt.Rows(0)("b_grade") = 1 Then
                        cmdstr = cmdstr + sex(0) + "B_Grade char(20) NOT NULL, "
                    End If
                    If ttdt.Rows(0)("c_grade") = 1 Then
                        cmdstr = cmdstr + sex(0) + "C_Grade char(20) NOT NULL, "
                    End If
                Case "G"
                    If ttdt.Rows(0)("a_grade") = 1 Then
                        cmdstr = cmdstr + sex(1) + "A_Grade char(20) NOT NULL, "
                    End If
                    If ttdt.Rows(0)("b_grade") = 1 Then
                        cmdstr = cmdstr + sex(1) + "B_Grade char(20) NOT NULL, "
                    End If
                    If ttdt.Rows(0)("c_grade") = 1 Then
                        cmdstr = cmdstr + sex(1) + "C_Grade char(20) NOT NULL, "
                    End If
                Case "C"
                    For n = 0 To 1
                        If ttdt.Rows(0)("a_grade") = 1 Then
                            cmdstr = cmdstr + sex(n) + "_A_Grade char(20) NOT NULL, "
                        End If
                        If ttdt.Rows(0)("b_grade") = 1 Then
                            cmdstr = cmdstr + sex(n) + "_B_Grade char(20) NOT NULL, "
                        End If
                        If ttdt.Rows(0)("c_grade") = 1 Then
                            cmdstr = cmdstr + sex(n) + "_C_Grade char(20) NOT NULL, "
                        End If
                    Next
            End Select
            cmdstr = cmdstr.Substring(0, cmdstr.Length - 2) + ")"
            Form1.enq_exe(cmdstr)
            Dim start_time As String = ttdt.Rows(0)(String.Concat("start_time_day", Trim(Str(i))))
            Dim end_time As String = ttdt.Rows(0)(String.Concat("end_time_day", Trim(Str(i))))
            cmdstr = "insert into " + Form1.Proj + "_timetableday" + Trim(Str(i)) + " (Time) value "
            For t = time_to_min(start_time) To time_to_min(end_time) Step 5
                cmdstr = cmdstr + "('" + min_to_time(t) + "'), "
            Next
            Form1.enq_exe(cmdstr.Substring(0, cmdstr.Length - 2))
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form29.Show()
        distribute_lanes()
        Dim cmdstr As String
        cmdstr = "drop table if exists " + Form1.Proj + "_finals"
        Form1.enq_exe(cmdstr)
        cmdstr = "create table " + Form1.Proj + "_finals (Event_Code char(7), Event_Name char(50) NOT NULL, Grade char(1) NOT NULL, Sex char(1) NOT NULL, Field_or_Track char(1) NOT NULL, Assign_Lane char(1) NOT NULL, Holding_Area char(15) NOT NULL, No_of_Participants char(1), No_of_Groups char(1), primary key(Event_Code))"
        Form1.enq_exe(cmdstr)
        cmdstr = "insert into " + Form1.Proj + "_finals (Event_Code, Event_Name, Grade, Sex, Field_or_Track, Assign_Lane, Holding_Area, No_of_Participants, No_of_Groups) select concat('F', Event_Code), concat(Event_Name, ' Final'), Grade, Sex, Field_or_Track, Assign_Lane, Holding_Area, '0', '1' from " + Form1.Proj + "_noofgroups where No_of_Groups >1"
        Form1.enq_exe(cmdstr)
        cmdstr = "drop table if exists " + Form1.Proj + "_eventtime"
        Form1.enq_exe(cmdstr)
        cmdstr = "create table " + Form1.Proj + "_eventtime (Event_Code char(7), Minutes_Required char(2) NOT NULL, Start_Time char(7) NOT NULL, primary key(Event_Code))"
        Form1.enq_exe(cmdstr)
        cmdstr = "insert into " + Form1.Proj + "_eventtime(Event_Code) select Event_Code from  " + Form1.Proj + "_noofgroups"
        Form1.enq_exe(cmdstr)
        cmdstr = "insert into " + Form1.Proj + "_eventtime(Event_Code) select Event_Code from  " + Form1.Proj + "_finals"
        Form1.enq_exe(cmdstr)
        create_timetable()
        cmdstr = "update SDMProj set Stage_2 ='1' where Proj_code ='" + Form1.Proj + "'"
        Form1.enq_exe(cmdstr)
        Form1.menustrip_enable()
        Form29.Close()
        MsgBox("You can start planning timetable now.")
        Form1.dgv_show2(Me.DataGridView2, "SELECT Event_Name, Group_Code, l1.Name as Lane1, l2.Name as Lane2, l3.Name as Lane3, l4.Name as Lane4, l5.Name as Lane5, l6.Name as Lane6, l7.Name as Lane7, l8.Name as Lane8 FROM " + Form1.Proj + "_lane l left join " + Form1.Proj + "_event e on l.event_code=e.event_code left join " + Form1.Proj + "_student l1 on l.lane1=l1.SID left join " + Form1.Proj + "_student l2 on l.lane2=l2.SID left join " + Form1.Proj + "_student l3 on l.lane3=l3.SID left join " + Form1.Proj + "_student l4 on l.lane4=l4.SID left join " + Form1.Proj + "_student l5 on l.lane5=l5.SID left join " + Form1.Proj + "_student l6 on l.lane6=l6.SID left join " + Form1.Proj + "_student l7 on l.lane7=l7.SID left join " + Form1.Proj + "_student l8 on l.lane8=l8.SID")
        TabControl1.SelectTab(1)
        Button4.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Form30.refresh_load()
        Form1.TabControl0.Visible = False
        Form1.TabControl1.Visible = False
        Form1.TabControl2.Visible = False
        Form1.TabControl3.Visible = True
        Form1.TabControl4.Visible = False
        Form1.TabControl5.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form29.Show()
        distribute_lanes()
        Dim cmdstr As String
        cmdstr = "delete from " + Form1.Proj + "_finals where Event_Code not in (select concat('F', Event_Code) from " + Form1.Proj + "_noofgroups where No_of_Groups >1)"
        Form1.enq_exe(cmdstr)
        cmdstr = "delete from " + Form1.Proj + "_eventtime where Event_Code not in (select Event_Code from  " + Form1.Proj + "_finals union select Event_Code from " + Form1.Proj + "_noofgroups)"
        Form1.enq_exe(cmdstr)
        cmdstr = "insert into " + Form1.Proj + "_finals (Event_Code, Event_Name, Grade, Sex, Field_or_Track, Assign_Lane, Holding_Area, No_of_Participants, No_of_Groups) select concat('F', Event_Code), concat(Event_Name, ' Final'), Grade, Sex, Field_or_Track, Assign_Lane, Holding_Area, '0', '1' from " + Form1.Proj + "_noofgroups where No_of_Groups >1 and concat('F', Event_Code) not in (select Event_Code from " + Form1.Proj + "_finals)"
        Form1.enq_exe(cmdstr)
        cmdstr = "insert into " + Form1.Proj + "_eventtime(Event_Code) select Event_Code from  " + Form1.Proj + "_noofgroups where Event_Code not in (select Event_Code from " + Form1.Proj + "_eventtime)"
        Form1.enq_exe(cmdstr)
        cmdstr = "insert into " + Form1.Proj + "_eventtime(Event_Code) select Event_Code from  " + Form1.Proj + "_finals where Event_Code not in (select Event_Code from " + Form1.Proj + "_eventtime)"
        Form1.enq_exe(cmdstr)
        Form1.dgv_show2(Me.DataGridView2, "SELECT Event_Name, Group_Code, l1.Name as Lane1, l2.Name as Lane2, l3.Name as Lane3, l4.Name as Lane4, l5.Name as Lane5, l6.Name as Lane6, l7.Name as Lane7, l8.Name as Lane8 FROM " + Form1.Proj + "_lane l left join " + Form1.Proj + "_event e on l.event_code=e.event_code left join " + Form1.Proj + "_student l1 on l.lane1=l1.SID left join " + Form1.Proj + "_student l2 on l.lane2=l2.SID left join " + Form1.Proj + "_student l3 on l.lane3=l3.SID left join " + Form1.Proj + "_student l4 on l.lane4=l4.SID left join " + Form1.Proj + "_student l5 on l.lane5=l5.SID left join " + Form1.Proj + "_student l6 on l.lane6=l6.SID left join " + Form1.Proj + "_student l7 on l.lane7=l7.SID left join " + Form1.Proj + "_student l8 on l.lane8=l8.SID")
        Form29.Close()
    End Sub
End Class