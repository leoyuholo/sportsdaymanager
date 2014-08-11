Public Class Form20
    Public f20_dt As New DataTable
    Sub add_eve(ByVal event_code As String, ByVal start_time As String, ByVal length As String, ByVal nod As String)
        add_eve2(event_code, start_time, length, event_code.Substring(event_code.Length - 2, 1), event_code.Substring(event_code.Length - 3, 1), nod, event_code.Substring(event_code.Length - 1, 1), True)
    End Sub
    Sub add_eve2(ByVal event_code As String, ByVal start_time As String, ByVal length As String, ByVal sex As String, ByVal grade As String, ByVal nod As String, Optional ByVal tf As String = "F", Optional ByVal eve As Boolean = False)
        If sex = "M" Then
            sex = "Boys"
        ElseIf sex = "F" Then
            sex = "Girls"
        End If
        Select Case grade
            Case "A"
                grade = "A_Grade"
            Case "B"
                grade = "B_Grade"
            Case "C"
                grade = "C_Grade"
        End Select
        Dim Day As String
        If nod = 2 Then
            Day = "2ND"
        Else
            Day = "1ST"
        End If
        If Form19.time_to_min(start_time) + length - 5 > Form19.time_to_min(Form1.esstr_exe("select end_time_day" + nod + " from SDMCompInfo where proj_code ='" + Form1.Proj + "'")) Or Form19.time_to_min(start_time) < Form19.time_to_min(Form1.esstr_exe("select start_time_day" + nod + " from SDMCompInfo where proj_code ='" + Form1.Proj + "'")) Then
            MsgBox("Selected time out of time interval")
        Else
            If eve = True Then
                If Form1.esstr_exe("select 'true' from " + Form1.Proj + "_timetableday" + nod + " where " + sex + "_" + grade + "<> '' and time between '" + start_time + "' and '" + Form19.min_to_time(Form19.time_to_min(start_time) + length - 5) + "'") = "true" Then
                    MsgBox("Some events for " + sex + "_" + grade + " already exist in the selected time interval.")
                ElseIf MsgBox("Please make sure no events hold at the same ground." + Chr(10) + "Continuous?", MsgBoxStyle.OkCancel, "Check ground crash") = 1 Then
                    Dim cmdstr As String = "update " + Form1.Proj + "_timetableday" + nod + " set " + sex + "_" + grade + "='" + event_code + "' where Time ='"
                    For t = Form19.time_to_min(start_time) To Form19.time_to_min(start_time) + length - 5 Step 5
                        Form1.enq_exe(cmdstr + Form19.min_to_time(t) + "'")
                    Next
                    cmdstr = "update " + Form1.Proj + "_eventtime set Start_Time='" + Day + start_time + "', Minutes_Required='" + length + "' where Event_Code='" + event_code + "'"
                    Form1.enq_exe(cmdstr)
                    ttu_dvg_show()
                End If
            Else
                Dim cmdstr As String = "update " + Form1.Proj + "_timetableday" + nod + " set " + sex + "_" + grade + "='" + event_code + "' where Time ='"
                For t = Form19.time_to_min(start_time) To Form19.time_to_min(start_time) + length - 5 Step 5
                    Form1.enq_exe(cmdstr + Form19.min_to_time(t) + "'")
                Next
            End If
        End If
    End Sub
    Sub remove_eve(ByVal event_code As String, Optional ByVal eve As Boolean = False)
        Dim cmdstr As String
        Dim x, y As Integer
        Dim sex() As String = {"Boys", "Girls"}
        Dim nod As Integer = Me.f20_dt.Rows(0)("no_of_days")
        Select Case Me.f20_dt.Rows(0)("sex")
            Case "B"
                x = 0
                y = 0
            Case "G"
                x = 1
                y = 1
            Case "C"
                x = 0
                y = 1
        End Select
        For j = 1 To nod
            For i = x To y
                cmdstr = "update " + Form1.Proj + "_timetableday" + Trim(Str(j)) + " set "
                If Me.f20_dt.Rows(0)("a_grade") = 1 Then
                    cmdstr = cmdstr + sex(i) + "_A_Grade ='' where " + sex(i) + "_A_Grade ='" + event_code + "'"
                    Form1.enq_exe(cmdstr)
                End If
                cmdstr = "update " + Form1.Proj + "_timetableday1 set "
                If Me.f20_dt.Rows(0)("b_grade") = 1 Then
                    cmdstr = cmdstr + sex(i) + "_B_Grade ='' where " + sex(i) + "_B_Grade ='" + event_code + "'"
                    Form1.enq_exe(cmdstr)
                End If
                cmdstr = "update " + Form1.Proj + "_timetableday1 set "
                If Me.f20_dt.Rows(0)("c_grade") = 1 Then
                    cmdstr = cmdstr + sex(i) + "_C_Grade ='' where " + sex(i) + "_C_Grade ='" + event_code + "'"
                    Form1.enq_exe(cmdstr)
                End If
            Next
        Next
        If eve = True Then
            cmdstr = "update " + Form1.Proj + "_eventtime set Start_Time='' where Event_Code='" + event_code + "'"
            Form1.enq_exe(cmdstr)
        End If
    End Sub


    Sub ttu_dvg_show()
        Form1.dgv_show(Me.DataGridView2, "_timetableday1")
        Form1.dgv_show2(Me.DataGridView3, "select g.Event_Code, Event_Name, Grade, Sex, Holding_Area, convert(No_of_Participants, char) as No_of_Participants, convert(No_of_Groups, char) as No_of_Groups, Minutes_Required, Start_Time from " + Form1.Proj + "_noofgroups g, " + Form1.Proj + "_eventtime t where g.Event_Code=t.Event_Code union select f.Event_Code, Event_Name, Grade, Sex, Holding_Area, No_of_Participants, No_of_Groups, Minutes_Required, Start_Time from " + Form1.Proj + "_finals f, " + Form1.Proj + "_eventtime t where f.Event_Code=t.Event_Code")
        If f20_dt.Rows(0)("no_of_days") = 2 Then
            Form1.dgv_show(Me.DataGridView4, "_timetableday2")
            Form1.dgv_show2(Me.DataGridView5, "select g.Event_Code, Event_Name, Grade, Sex, Holding_Area, convert(No_of_Participants, char) as No_of_Participants, convert(No_of_Groups, char) as No_of_Groups, Minutes_Required, Start_Time from " + Form1.Proj + "_noofgroups g, " + Form1.Proj + "_eventtime t where g.Event_Code=t.Event_Code union select f.Event_Code, Event_Name, Grade, Sex, Holding_Area, No_of_Participants, No_of_Groups, Minutes_Required, Start_Time from " + Form1.Proj + "_finals f, " + Form1.Proj + "_eventtime t where f.Event_Code=t.Event_Code")
        End If
    End Sub
    Private Sub Form20_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         Dim cmdstr As String = "select * from SDMCompInfo where proj_code ='" + Form1.Proj + "'"
        Form1.fill_table(cmdstr, f20_dt)
        If f20_dt.Rows(0)("no_of_days") = 2 Then
            GroupBox4.Enabled = True
            GroupBox5.Enabled = True
            RadioButton2.Enabled = True
            RadioButton4.Enabled = True
        End If
        ttu_dvg_show()
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form21.Show()
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Val(TextBox4.Text) Mod 5 = 0 Then
            If TextBox2.Text.Length = 4 AndAlso Val(TextBox2.Text) Mod 5 = 0 Then
                remove_eve(Me.DataGridView3.CurrentRow.Cells("Event_Code").Value)
                Dim nod, day As String
                If RadioButton2.Checked = True Then
                    nod = 2
                    day = "2ND"
                Else
                    nod = 1
                    day = "1ST"
                End If
                add_eve(Me.DataGridView3.CurrentRow.Cells("Event_Code").Value, TextBox2.Text, TextBox4.Text, nod)
                TextBox2.Clear()
                TextBox4.Clear()
            Else
                MsgBox("Inappropriate value entered.")
            End If
        Else
            MsgBox("Please enter a multiple of 5 for Time Length.")
        End If
    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Form21.Show()
    End Sub

    Private Sub Button13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If Val(TextBox1.Text) Mod 5 = 0 Then
            If TextBox3.Text.Length = 4 AndAlso Val(TextBox3.Text) Mod 5 = 0 Then
                Dim nod, day As String
                If RadioButton4.Checked = True Then
                    nod = 2
                    day = "2ND"
                Else
                    nod = 1
                    day = "1ST"
                End If
                add_eve(Me.DataGridView5.CurrentRow.Cells("Event_Code").Value, TextBox3.Text, TextBox1.Text, nod)
                TextBox1.Clear()
                TextBox3.Clear()
            Else
                MsgBox("Inappropriate value entered")
            End If
        Else
            MsgBox("Please enter a multiple of 5 for Time Length.")
        End If
    End Sub

    Private Sub Button15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Me.Close()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Me.Close()
    End Sub

    Private Sub Button14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Dim cmdstr As String = "drop table if exists " + Form1.Proj + "_results"
        Form1.enq_exe(cmdstr)
        cmdstr = "create table " + Form1.Proj + "_results (SID char(10), Event_Code char(7), Result decimal(5,2), Absent char(3), Score decimal(2), primary key(SID, Event_Code))"
        Form1.enq_exe(cmdstr)
        cmdstr = "drop table if exists " + Form1.Proj + "_adjustpersonalscore"
        Form1.enq_exe(cmdstr)
        cmdstr = "create table " + Form1.Proj + "_adjustpersonalscore (SID char(10), Adjustment decimal(3) NOT NULL, primary key(SID))"
        Form1.enq_exe(cmdstr)
        cmdstr = "insert into " + Form1.Proj + "_adjustpersonalscore(SID) select SID from " + Form1.Proj + "_student"
        Form1.enq_exe(cmdstr)
        cmdstr = "drop table if exists " + Form1.Proj + "_adjusthousescore"
        Form1.enq_exe(cmdstr)
        cmdstr = "create table " + Form1.Proj + "_adjusthousescore (House_Code char(10), Adjustment decimal(3) NOT NULL, primary key(House_Code))"
        Form1.enq_exe(cmdstr)
        cmdstr = "insert into " + Form1.Proj + "_adjusthousescore(House_Code) select House_Code from " + Form1.Proj + "_house"
        Form1.enq_exe(cmdstr)
        cmdstr = "drop table if exists " + Form1.Proj + "_finalslane"
        Form1.enq_exe(cmdstr)
        cmdstr = "create table " + Form1.Proj + "_finalslane (Event_Code char(7), Lane1 char(10) , Lane2 char(10), Lane3 char(10), Lane4 char(10), Lane5 char(10), Lane6 char(10), Lane7 char(10), Lane8 char(10))"
        Form1.enq_exe(cmdstr)
        cmdstr = "drop table if exists " + Form1.Proj + "_award"
        Form1.enq_exe(cmdstr)
        cmdstr = "create table " + Form1.Proj + "_award (Event_Code char(7), Champion char(10), 1st_Runner_Up char(10), 2nd_Runner_Up char(10))"
        Form1.enq_exe(cmdstr)

        cmdstr = "update SDMProj set Stage_3 ='1' where Proj_code ='" + Form1.Proj + "'"
        Form1.enq_exe(cmdstr)
        Form1.menustrip_enable()
        MsgBox("You can start sports day now.")
        Form1.TabControl0.Visible = False
        Form1.TabControl1.Visible = False
        Form1.TabControl2.Visible = False
        Form1.TabControl3.Visible = True
        Form1.TabControl4.Visible = False
        Form1.TabControl5.Visible = False
        Form1.TabControl3.SelectTab("TabPage35")
        Me.Close()
        Form30.refresh_load()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Form24.Show()
        large_view(1, Form24.DataGridView1)
        Form24.Text = "1st Day Time Table"
    End Sub
    Sub large_view(ByVal day As Integer, ByVal dgv As DataGridView)
        Dim cmdstr As String = "select * from SDMCompInfo where proj_code ='" + Form1.Proj + "'"
        Dim dt As New DataTable
        Form1.fill_table(cmdstr, dt)

        Dim sex() As String = {"Boys", "Girls"}
        Dim x, y As Integer
        Select Case dt.Rows(0)("sex")
            Case "B"
                x = 0
                y = 0
            Case "G"
                x = 1
                y = 1
            Case "C"
                x = 0
                y = 1
        End Select
        cmdstr = "SELECT Time"
        large_view_addstr(cmdstr, x, y, dt)
        cmdstr = cmdstr + " FROM " + Form1.Proj + "_timetableday" + Trim(Str(day)) + " t"
        Select Case dt.Rows(0)("sex")
            Case "B"
                x = 2
                y = 2
            Case "G"
                x = 3
                y = 3
            Case "C"
                x = 2
                y = 3
        End Select
        large_view_addstr(cmdstr, x, y, dt)
        Form1.dgv_show2(dgv, cmdstr)

    End Sub
    Sub large_view_addstr(ByRef cmdstr As String, ByVal x As Integer, ByVal y As Integer, ByVal dt As DataTable)
        For i = x To y
            If i = 0 Then
                If dt.Rows(0)("a_grade") = 1 Then
                    cmdstr = cmdstr + ", ifnull(e1.Event_Name, Boys_A_Grade) as Boys_A_Grade"
                End If
                If dt.Rows(0)("b_grade") = 1 Then
                    cmdstr = cmdstr + ", ifnull(e2.Event_Name, Boys_B_Grade) as Boys_B_Grade"
                End If
                If dt.Rows(0)("c_grade") = 1 Then
                    cmdstr = cmdstr + ", ifnull(e3.Event_Name, Boys_C_Grade) as Boys_C_Grade"
                End If
            End If
            If i = 1 Then
                If dt.Rows(0)("a_grade") = 1 Then
                    cmdstr = cmdstr + ", ifnull(e4.Event_Name, Girls_A_Grade) as Girls_A_Grade"
                End If
                If dt.Rows(0)("b_grade") = 1 Then
                    cmdstr = cmdstr + ", ifnull(e5.Event_Name, Girls_B_Grade) as Girls_B_Grade"
                End If
                If dt.Rows(0)("c_grade") = 1 Then
                    cmdstr = cmdstr + ", ifnull(e6.Event_Name, Girls_C_Grade) as Girls_C_Grade"
                End If
            End If
            If i = 2 Then
                If dt.Rows(0)("a_grade") = 1 Then
                    cmdstr = cmdstr + " left join " + Form1.Proj + "_event e1 on t.Boys_A_Grade=e1.event_code"
                End If
                If dt.Rows(0)("b_grade") = 1 Then
                    cmdstr = cmdstr + " left join " + Form1.Proj + "_event e2 on t.Boys_B_Grade=e2.event_code"
                End If
                If dt.Rows(0)("c_grade") = 1 Then
                    cmdstr = cmdstr + " left join " + Form1.Proj + "_event e3 on t.Boys_C_Grade=e3.event_code"
                End If
            End If
            If i = 3 Then
                If dt.Rows(0)("a_grade") = 1 Then
                    cmdstr = cmdstr + " left join " + Form1.Proj + "_event e4 on t.Girls_A_Grade=e4.event_code"
                End If
                If dt.Rows(0)("b_grade") = 1 Then
                    cmdstr = cmdstr + " left join " + Form1.Proj + "_event e5 on t.Girls_B_Grade=e5.event_code"
                End If
                If dt.Rows(0)("c_grade") = 1 Then
                    cmdstr = cmdstr + " left join " + Form1.Proj + "_event e6 on t.Girls_C_Grade=e6.event_code"
                End If
            End If
        Next
    End Sub
    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Form24.Show()
        large_view(2, Form24.DataGridView1)
        Form24.Text = "2nd Day Time Table"
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        remove_eve(Me.DataGridView3.CurrentRow.Cells("Event_Code").Value, True)
        ttu_dvg_show()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        remove_eve(Me.DataGridView5.CurrentRow.Cells("Event_Code").Value, True)
        ttu_dvg_show()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Form25.Show()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Form25.Show()
    End Sub

End Class