Imports System
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim csr As StreamReader = New StreamReader("settings.txt")
    Dim ds, ui, pwd, db As String
    Dim data(20) As String
    Dim i As Integer
    Public myConnectionString As String
    Public Proj As String
    Public Proj_settings As New DataTable
    Public b7_e_code(0) As String
    Public b8_t_code(0) As String
    Public b15_e_code(0) As String
    Public b16_e_code(0) As String
    Public b17_e_code(0) As String
    Public b19_e_code(0) As String

    Sub dgv_show(ByVal table_no As DataGridView, ByVal table As String, Optional ByVal col As String = "*", Optional ByVal ext As String = "")
        Dim cmdstr As String = "select " + col + " from " + Proj + table + " " + ext
        dgv_show2(table_no, cmdstr)
    End Sub

    Sub dgv_show2(ByVal table_no As DataGridView, ByVal cmd As String)
        
        Using cn As New MySqlConnection(myConnectionString)
            cn.Open()
            Debug.Print(cmd)
            Dim dt As New DataTable
            fill_table(cmd, dt)
            table_no.DataSource = dt
        End Using
    End Sub

    Sub enq_exe(ByVal cmd As String)
        Try
            Using cn As New MySqlConnection(myConnectionString)
                cn.Open()
                Debug.Print(cmd)
                Dim cmdexe = New MySqlCommand(cmd, cn)
                cmdexe.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function esint_exe(ByVal cmd As String) As Integer
        Using cn As New MySqlConnection(myConnectionString)
            cn.Open()
            Debug.Print(cmd)
            Dim cmdexe = New MySqlCommand(cmd, cn)
            Return cmdexe.ExecuteScalar()
        End Using
    End Function

    Function esstr_exe(ByVal cmd As String) As String
        Using cn As New MySqlConnection(myConnectionString)
            cn.Open()
            Debug.Print(cmd)
            Dim cmdexe = New MySqlCommand(cmd, cn)
            Return cmdexe.ExecuteScalar()
        End Using
    End Function

    Sub fill_table(ByVal cmd As String, ByRef dt As DataTable)
        Try
            Using cn As New MySqlConnection(myConnectionString)
                cn.Open()
                Debug.Print(cmd)
                Dim da As New MySqlDataAdapter(cmd, cn)
                da.Fill(dt)
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub menustrip_enable()
        Dim cmdstr As String = "select * from SDMProj where Proj_code ='" + Me.Proj + "'"
        Me.Proj_settings.Clear()
        Me.fill_table(cmdstr, Me.Proj_settings)
        Dim dt As New DataTable
        cmdstr = "select * from SDMCompInfo where proj_code='" + Me.Proj + "'"
        Me.fill_table(cmdstr, dt)
        If Me.Proj = 1000 Then
            ToolsToolStripMenuItem.Enabled = False
            EditProjectToolStripMenuItem.Enabled = False
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            DateTimePicker1.ResetText()
            TextBox9.Clear()
            TextBox10.Clear()
            TextBox23.Clear()
            TextBox24.Clear()
            TextBox25.Clear()
            TextBox26.Clear()
            TextBox27.Clear()
            TextBox28.Clear()
            TextBox29.Clear()
            TextBox30.Clear()
            RadioButton1.Checked = True
            DateTimePicker2.ResetText()
            TextBox11.Clear()
            TextBox12.Clear()
            RadioButton3.Checked = True
            CheckBox1.Checked = False
            DateTimePicker3.ResetText()
            CheckBox2.Checked = False
            DateTimePicker4.ResetText()
            CheckBox3.Checked = False
            DateTimePicker5.ResetText()
            Me.DataGridView1.DataSource = ""
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button23.Enabled = False
            Button24.Enabled = False
            Button25.Enabled = False
            Form30.Close()
        Else
            ToolsToolStripMenuItem.Enabled = True
            EditProjectToolStripMenuItem.Enabled = True
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
            TextBox23.Text = dt.Rows(0)("position1_score")
            TextBox24.Text = dt.Rows(0)("position2_score")
            TextBox25.Text = dt.Rows(0)("position3_score")
            TextBox26.Text = dt.Rows(0)("position4_score")
            TextBox27.Text = dt.Rows(0)("position5_score")
            TextBox28.Text = dt.Rows(0)("position6_score")
            TextBox29.Text = dt.Rows(0)("position7_score")
            TextBox30.Text = dt.Rows(0)("position8_score")
            If dt.Rows(0)("no_of_days") = 1 Then
                RadioButton1.Checked = True
            ElseIf dt.Rows(0)("no_of_days") = 2 Then
                RadioButton2.Checked = True
                DateTimePicker2.Text = dt.Rows(0)("date_of_day2")
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
                DateTimePicker3.Text = dt.Rows(0)("a_grade_time")
            End If
            If dt.Rows(0)("b_grade") = "1" Then
                CheckBox2.Checked = True
                DateTimePicker4.Text = dt.Rows(0)("b_grade_time")
            End If
            If dt.Rows(0)("c_grade") = "1" Then
                CheckBox3.Checked = True
                DateTimePicker5.Text = dt.Rows(0)("c_grade_time")
            End If
            Me.dgv_show(Me.DataGridView1, "_house")
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button23.Enabled = True
            Button24.Enabled = True
            Button25.Enabled = True
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            ListBox3.Items.Clear()
            ListBox4.Items.Clear()
            ListBox5.Items.Clear()
            DataGridView1.DataSource = ""
            DataGridView2.DataSource = ""
            DataGridView3.DataSource = ""
            DataGridView4.DataSource = ""
            DataGridView5.DataSource = ""
            DataGridView6.DataSource = ""
            DataGridView7.DataSource = ""
            DataGridView8.DataSource = ""
            DataGridView9.DataSource = ""
            DataGridView10.DataSource = ""
            DataGridView11.DataSource = ""
            DataGridView12.DataSource = ""
            DataGridView13.DataSource = ""
            DataGridView14.DataSource = ""
            DataGridView15.DataSource = ""
            DataGridView16.DataSource = ""
            DataGridView17.DataSource = ""
        End If
        If Val(Proj_settings.Rows(0)("Stage_1")) = True Then
            EventRegisterToolStripMenuItem.Enabled = True
            HelperRegisterToolStripMenuItem.Enabled = True
            GroupingandDistributeLaneToolStripMenuItem.Enabled = True
            Button7.Enabled = True
            Button8.Enabled = True
            Button9.Enabled = True
            Button10.Enabled = True
            Button26.Enabled = True
            Button27.Enabled = True
            Button28.Enabled = True
            Button29.Enabled = True
        Else
            EventRegisterToolStripMenuItem.Enabled = False
            HelperRegisterToolStripMenuItem.Enabled = False
            GroupingandDistributeLaneToolStripMenuItem.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Button10.Enabled = False
            Button26.Enabled = False
            Button27.Enabled = False
            Button28.Enabled = False
            Button29.Enabled = False
        End If

        If Val(Proj_settings.Rows(0)("Stage_2")) = True Then
            GenerateTimetableToolStripMenuItem.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Button11.Enabled = True
            Button12.Enabled = True
            Button30.Enabled = True
            Button31.Enabled = True
            Button32.Enabled = True
            Button33.Enabled = True
            If dt.Rows(0)("no_of_days") = 2 Then
                Button13.Enabled = True
                Button14.Enabled = True
                Button34.Enabled = True
            End If
        Else
            GenerateTimetableToolStripMenuItem.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button11.Enabled = False
            Button12.Enabled = False
            Button13.Enabled = False
            Button14.Enabled = False
            Button30.Enabled = False
            Button31.Enabled = False
            Button32.Enabled = False
            Button33.Enabled = False
            Button34.Enabled = False
        End If

        If Val(Proj_settings.Rows(0)("Stage_3")) = True Then
            UpdateResultsToolStripMenuItem.Enabled = True
            ResultMonitorToolStripMenuItem.Enabled = True
            Button15.Enabled = True
            Button16.Enabled = True
            Button17.Enabled = True
            Button18.Enabled = True
            Button19.Enabled = True
            Button20.Enabled = True
            Button21.Enabled = True
            Button22.Enabled = True
            Button35.Enabled = True
            Button36.Enabled = True
            Button37.Enabled = True
            Button38.Enabled = True
            Button39.Enabled = True
            Button40.Enabled = True
            Button41.Enabled = True
            Button42.Enabled = True
        Else
            UpdateResultsToolStripMenuItem.Enabled = False
            ResultMonitorToolStripMenuItem.Enabled = False
            Button15.Enabled = False
            Button16.Enabled = False
            Button17.Enabled = False
            Button18.Enabled = False
            Button19.Enabled = False
            Button20.Enabled = False
            Button21.Enabled = False
            Button22.Enabled = False
            Button35.Enabled = False
            Button36.Enabled = False
            Button37.Enabled = False
            Button38.Enabled = False
            Button39.Enabled = False
            Button40.Enabled = False
            Button41.Enabled = False
            Button42.Enabled = False
        End If
        Debug.Print(Proj_settings.Rows(0)("Stage_1") & Proj_settings.Rows(0)("Stage_2"))
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        While Not csr.EndOfStream
            data(i) = csr.ReadLine
            i += 1
        End While
        csr.Close()
        ds = data(4)
        ui = data(5)
        pwd = data(6)
        db = data(7)
        myConnectionString = "Database=" + db + ";Data Source=" + ds + ";User Id=" + ui + ";Password=" + pwd
        TreeView1.ExpandAll()
    End Sub

    Private Sub NewProjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewProjectToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub LoadProjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadProjectToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Are you sure to exit?", MsgBoxStyle.OkCancel, "Exit") = 1 Then
            Me.Close()
        End If
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim tc() As TabControl = {TabControl0, TabControl1, TabControl2, TabControl3, TabControl4, TabControl5}
        Dim n As Integer = Val(TreeView1.SelectedNode.Name.Substring(4))
        If TreeView1.SelectedNode.Index <> -1 Then
            Select Case n
                Case 1 To 10
                    If TabControl0.Visible = False Then
                        For x = 0 To 5
                            tc(x).Visible = False
                        Next
                        TabControl0.Visible = True
                    End If
                    If TreeView1.SelectedNode.Name.Substring(TreeView1.SelectedNode.Name.Length - 1, 1) <> 1 Then
                        TabControl0.SelectTab("tabpage" + TreeView1.SelectedNode.Name.Substring(TreeView1.SelectedNode.Name.Length - 1, 1))
                    End If
                Case 11 To 20
                    If TabControl1.Visible = False Then
                        For x = 0 To 5
                            tc(x).Visible = False
                        Next
                        TabControl1.Visible = True
                    End If
                    If TreeView1.SelectedNode.Name.Substring(TreeView1.SelectedNode.Name.Length - 1, 1) <> 1 Then
                        TabControl1.SelectTab("tabpage" + TreeView1.SelectedNode.Name.Substring(TreeView1.SelectedNode.Name.Length - 2, 2))
                    End If
                Case 21 To 30
                    If TabControl2.Visible = False Then
                        For x = 0 To 5
                            tc(x).Visible = False
                        Next
                        TabControl2.Visible = True
                    End If
                    If TreeView1.SelectedNode.Name.Substring(TreeView1.SelectedNode.Name.Length - 1, 1) <> 1 Then
                        TabControl2.SelectTab("tabpage" + TreeView1.SelectedNode.Name.Substring(TreeView1.SelectedNode.Name.Length - 2, 2))
                    End If
                Case 31 To 40
                    If TabControl3.Visible = False Then
                        For x = 0 To 5
                            tc(x).Visible = False
                        Next
                        TabControl3.Visible = True
                    End If
                    If TreeView1.SelectedNode.Name.Substring(TreeView1.SelectedNode.Name.Length - 1, 1) <> 1 Then
                        TabControl3.SelectTab("tabpage" + TreeView1.SelectedNode.Name.Substring(TreeView1.SelectedNode.Name.Length - 2, 2))
                    End If
                Case 41 To 50
                    If TabControl4.Visible = False Then
                        For x = 0 To 5
                            tc(x).Visible = False
                        Next
                        TabControl4.Visible = True
                    End If
                    If TreeView1.SelectedNode.Name.Substring(TreeView1.SelectedNode.Name.Length - 1, 1) <> 1 Then
                        TabControl4.SelectTab("tabpage" + TreeView1.SelectedNode.Name.Substring(TreeView1.SelectedNode.Name.Length - 2, 2))
                    End If
                Case 51 To 60
                    If TabControl5.Visible = False Then
                        For x = 0 To 5
                            tc(x).Visible = False
                        Next
                        TabControl5.Visible = True
                    End If
                    If TreeView1.SelectedNode.Name.Substring(TreeView1.SelectedNode.Name.Length - 1, 1) <> 1 Then
                        TabControl5.SelectTab("tabpage" + TreeView1.SelectedNode.Name.Substring(TreeView1.SelectedNode.Name.Length - 2, 2))
                    End If
            End Select
        End If
    End Sub

    Private Sub DataEntryWizardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataEntryWizardToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub EventRegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EventRegisterToolStripMenuItem.Click
        Form17.Show()
    End Sub

    Private Sub HelperTeamRegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelperRegisterToolStripMenuItem.Click
        Form18.Show()
    End Sub

    Private Sub GroupingandDistributeLaneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupingandDistributeLaneToolStripMenuItem.Click
        Form19.Show()
    End Sub

    Private Sub GenerateTimetableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateTimetableToolStripMenuItem.Click
        Form20.Show()
    End Sub

    Private Sub UpdateResultsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateResultsToolStripMenuItem.Click
        Form22.Show()
    End Sub

    Private Sub ResultMonitorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResultMonitorToolStripMenuItem.Click
        Form23.Show()
    End Sub

    Private Sub ConnectionSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectionSettingsToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.dgv_show2(Me.DataGridView2, "select * from " + Me.Proj + "_student s where Name like '%" + TextBox13.Text + "%' and Class like '%" + TextBox20.Text + "%'")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.dgv_show2(Me.DataGridView3, "select * from " + Me.Proj + "_event where Event_Name like '%" + TextBox14.Text + "%' and Event_Code <>'100NNN' and Sex like '%" + ComboBox1.Text + "' and Grade like '%" + ComboBox2.Text + "' and Field_or_Track like '%" + ComboBox3.Text + "'")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.dgv_show2(Me.DataGridView4, "select * from " + Me.Proj + "_helperteam where Team_Name like '%" + TextBox15.Text + "%' and Team_Code <>'1000'")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim cmdstr As String = "select Event_Code, Event_Name from " + Me.Proj + "_event where Event_Code <>'100NNN'"
        Dim dt As New DataTable
        Me.fill_table(cmdstr, dt)
        ListBox1.Items.Clear()
        ReDim b7_e_code(1000)
        For j = 0 To dt.Rows.Count - 1
            ListBox1.Items.Add(dt.Rows(j)("Event_Name"))
            b7_e_code(j) = dt.Rows(j)("Event_Code")
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            Me.dgv_show2(Me.DataGridView6, "select Name, Class, Class_No, House_Name as House from " + Me.Proj + "_student s, " + Me.Proj + "_eventregister r, " + Me.Proj + "_house h where s.SID=r.SID and s.house=h.house_code and (Event1 ='" + b7_e_code(ListBox1.SelectedIndex) + "' or Event2='" + b7_e_code(ListBox1.SelectedIndex) + "' or Event3='" + b7_e_code(ListBox1.SelectedIndex) + "')")
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.dgv_show2(Me.DataGridView13, "select Name, Sex, Class, Class_No, House_name as House, Event1, Event2, Event3 from " + Me.Proj + "_student s, " + Me.Proj + "_house h, (select SID, e1.Event_Name as Event1, e2.Event_Name as Event2, e3.Event_Name as Event3 from " + Me.Proj + "_eventregister r left join " + Me.Proj + "_event e1 on r.event1=e1.event_code left join " + Me.Proj + "_event e2 on r.event2=e2.event_code left join " + Me.Proj + "_event e3 on r.event3=e3.event_code) es where s.SID=es.SID and s.house=h.house_code and Name like '%" + TextBox21.Text + "%' and Class like '%" + TextBox33.Text + "%'")
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Form24.Show()
        Form20.large_view(2, Form24.DataGridView1)
        Form24.Text = "2nd Day Time Table"
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Form24.Show()
        Form20.large_view(1, Form24.DataGridView1)
        Form24.Text = "1st Day Time Table"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Form20.large_view(1, Me.DataGridView10)
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Form20.large_view(2, Me.DataGridView11)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim cmdstr As String = "select Event_Code, Event_Name from " + Me.Proj + "_event where Event_Code <>'100NNN' and Assign_Lane ='1' order by Event_Code"
        Dim dt As New DataTable
        Me.fill_table(cmdstr, dt)
        ListBox3.Items.Clear()
        ReDim b15_e_code(1000)
        For j = 0 To dt.Rows.Count - 1
            ListBox3.Items.Add(dt.Rows(j)("Event_Name"))
            b15_e_code(j) = dt.Rows(j)("Event_Code")
        Next
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim cmdstr As String = "select Event_Code, Event_Name from " + Me.Proj + "_finals union select Event_Code, Event_Name from " + Me.Proj + "_event where Event_Code <>'100NNN' and Assign_Lane ='0' and Field_or_Track ='T' order by Event_Code"
        Dim dt As New DataTable
        Me.fill_table(cmdstr, dt)
        ListBox4.Items.Clear()
        ReDim b16_e_code(1000)
        For j = 0 To dt.Rows.Count - 1
            ListBox4.Items.Add(dt.Rows(j)("Event_Name"))
            b16_e_code(j) = dt.Rows(j)("Event_Code")
        Next
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Dim cmdstr As String = "select Event_Code, Event_Name from " + Me.Proj + "_event where Event_Code <>'100NNN' union select Event_Code, Event_Name from " + Me.Proj + "_finals order by Event_Code"
        Dim dt As New DataTable
        Me.fill_table(cmdstr, dt)
        ListBox5.Items.Clear()
        ReDim b17_e_code(1000)
        For j = 0 To dt.Rows.Count - 1
            ListBox5.Items.Add(dt.Rows(j)("Event_Name"))
            b17_e_code(j) = dt.Rows(j)("Event_Code")
        Next
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox3.SelectedIndexChanged
        If ListBox3.SelectedIndex <> -1 Then
            Me.dgv_show2(Me.DataGridView12, "select Name, Class, Class_No, House_Name as House, Result as 'Result(Seconds)' from " + Me.Proj + "_student s, " + Me.Proj + "_results r, " + Me.Proj + "_house h where s.SID=r.SID and s.house=h.house_code and Event_Code='" + b15_e_code(ListBox3.SelectedIndex) + "' and Absent <>'ABS' order by Result asc")
        End If
    End Sub

    Private Sub ListBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox4.SelectedIndexChanged
        If ListBox4.SelectedIndex <> -1 Then
            Me.dgv_show2(Me.DataGridView15, "select Name, Class, Class_No, House_Name as House, Result as 'Result(Seconds)' from " + Me.Proj + "_student s, " + Me.Proj + "_results r, " + Me.Proj + "_house h where s.SID=r.SID and s.house=h.house_code and Event_Code='" + b16_e_code(ListBox4.SelectedIndex) + "' and Absent <>'ABS' order by Result asc")
        End If
    End Sub

    Private Sub ListBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox5.SelectedIndexChanged
        If ListBox5.SelectedIndex <> -1 Then
            Me.dgv_show2(Me.DataGridView16, "select Name, Class, Class_No, House_Name as House, Absent from " + Me.Proj + "_student s, " + Me.Proj + "_results r, " + Me.Proj + "_house h where s.SID=r.SID and s.house=h.house_code and Event_Code='" + b17_e_code(ListBox5.SelectedIndex) + "' and Absent like 'abs'")
        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Me.dgv_show2(Me.DataGridView17, "SELECT Event_Name, c.Name as Champion, 1st.Name as 1st_Runner_Up, 2nd.Name as 2nd_Runner_Up FROM " + Me.Proj + "_award a left join (select Event_Code, Event_Name from " + Me.Proj + "_event union select Event_Code, Event_Name from " + Me.Proj + "_finals)e on a.Event_Code=e.Event_Code left join " + Me.Proj + "_student c on a.Champion=c.SID left join " + Me.Proj + "_student 1st on a.1st_Runner_Up=1st.SID left join " + Me.Proj + "_student 2nd on a.2nd_Runner_Up=2nd.SID")
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Me.dgv_show2(Me.DataGridView18, "select House_Name,  (House_Score + a.Adjustment) as Total_House_Score from " + Me.Proj + "_adjusthousescore a, " + Me.Proj + "_house h, (select House, sum(Score) as House_Score from " + Me.Proj + "_student s, " + Me.Proj + "_results r where s.SID=r.SID group by House)t where t.House=h.House_Code and t.House=a.House_Code")
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Me.dgv_show2(Me.DataGridView19, "select Name, Class, Class_No, h.House_Name as House, (Personal_Score + Adjustment) as Total_Score from " + Me.Proj + "_adjustpersonalscore a ," + Me.Proj + "_student s, " + Me.Proj + "_house h, (select SID, sum(Score) as Personal_Score from " + Me.Proj + "_results group by SID) sc where s.House=h.House_Code and s.SID=sc.SID and a.SID=sc.SID order by Total_Score desc")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.dgv_show2(Me.DataGridView7, "select * from " + Me.Proj + "_noofgroups where Event_Name like '%" + TextBox16.Text + "%' and Sex like '%" + ComboBox6.Text + "' and Grade like '%" + ComboBox5.Text + "' and Field_or_Track like '%" + ComboBox4.Text + "'")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.dgv_show2(Me.DataGridView8, "select Event_Name, mid(Group_Code, 7, 3) as Group_No, Lane1, Lane2, Lane3, Lane4, Lane5, Lane6, Lane7, Lane8 from " + Me.Proj + "_event e, (SELECT Event_Code, Group_Code, l1.Name as Lane1, l2.Name as Lane2, l3.Name as Lane3, l4.Name as Lane4, l5.Name as Lane5, l6.Name as Lane6, l7.Name as Lane7, l8.Name as Lane8 FROM " + Me.Proj + "_lane l left join " + Me.Proj + "_student l1 on l.lane1=l1.SID left join " + Me.Proj + "_student l2 on l.lane2=l2.SID left join " + Me.Proj + "_student l3 on l.lane3=l3.SID left join " + Me.Proj + "_student l4 on l.lane4=l4.SID left join " + Me.Proj + "_student l5 on l.lane5=l5.SID left join " + Me.Proj + "_student l6 on l.lane6=l6.SID left join " + Me.Proj + "_student l7 on l.lane7=l7.SID left join " + Me.Proj + "_student l8 on l.lane8=l8.SID) ls where e.Event_Code=ls.Event_Code and Event_Name like '%" + TextBox17.Text + "%' and Sex like '%" + ComboBox9.Text + "' and Grade like '%" + ComboBox8.Text + "' and Field_or_Track like '%" + ComboBox7.Text + "'")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.dgv_show2(Me.DataGridView9, "select Event_Name, mid(Group_Code, 7, 3) as Group_No, Lane1, Lane2, Lane3, Lane4, Lane5, Lane6, Lane7, Lane8 from " + Me.Proj + "_event e, (SELECT Event_Code, Group_Code, l1.Name as Lane1, l2.Name as Lane2, l3.Name as Lane3, l4.Name as Lane4, l5.Name as Lane5, l6.Name as Lane6, l7.Name as Lane7, l8.Name as Lane8 FROM " + Me.Proj + "_lane l left join " + Me.Proj + "_student l1 on l.lane1=l1.SID left join " + Me.Proj + "_student l2 on l.lane2=l2.SID left join " + Me.Proj + "_student l3 on l.lane3=l3.SID left join " + Me.Proj + "_student l4 on l.lane4=l4.SID left join " + Me.Proj + "_student l5 on l.lane5=l5.SID left join " + Me.Proj + "_student l6 on l.lane6=l6.SID left join " + Me.Proj + "_student l7 on l.lane7=l7.SID left join " + Me.Proj + "_student l8 on l.lane8=l8.SID) ls where e.Event_Code=ls.Event_Code and (Lane1 like '%" + TextBox18.Text + "%' or Lane2 like '%" + TextBox18.Text + "%' or Lane3 like '%" + TextBox18.Text + "%' or Lane4 like '%" + TextBox18.Text + "%' or Lane5 like '%" + TextBox18.Text + "%' or Lane6 like '%" + TextBox18.Text + "%' or Lane7 like '%" + TextBox18.Text + "%' or Lane8 like '%" + TextBox18.Text + "%')")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim cmdstr As String = "select Team_Code, Team_Name from " + Me.Proj + "_helperteam where Team_Code <>'1000'"
        Dim dt As New DataTable
        Me.fill_table(cmdstr, dt)
        ListBox2.Items.Clear()
        ReDim b8_t_code(1000)
        For j = 0 To dt.Rows.Count - 1
            ListBox2.Items.Add(dt.Rows(j)("Team_Name"))
            b8_t_code(j) = dt.Rows(j)("Team_Code")
        Next
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.SelectedIndex <> -1 Then
            Me.dgv_show2(Me.DataGridView5, "select Name, Class, Class_No, House from " + Me.Proj + "_student s, " + Me.Proj + "_helperregister r, " + Me.Proj + "_house h where s.SID=r.SID and s.house=h.house_code and Team_Code ='" + b8_t_code(ListBox2.SelectedIndex) + "'")
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.dgv_show2(Me.DataGridView14, "select Name, Sex, Class, Class_No, House, Team_Name from " + Me.Proj + "_student s, " + Me.Proj + "_helperregister r," + Me.Proj + "_helperteam he, " + Me.Proj + "_house h where s.SID=r.SID and r.Team_Code=he.Team_Code and s.house=h.house_code and Name like '%" + TextBox22.Text + "%' and Class like '%" + TextBox35.Text + "%'")
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Dim cmdstr As String = "select Event_Code, Event_Name from " + Me.Proj + "_event where Event_Code <>'100NNN' and Field_or_Track ='F' order by Event_Code"
        Dim dt As New DataTable
        Me.fill_table(cmdstr, dt)
        ListBox6.Items.Clear()
        ReDim b19_e_code(1000)
        For j = 0 To dt.Rows.Count - 1
            ListBox6.Items.Add(dt.Rows(j)("Event_Name"))
            b19_e_code(j) = dt.Rows(j)("Event_Code")
        Next
    End Sub

    Private Sub ListBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox6.SelectedIndexChanged
        If ListBox6.SelectedIndex <> -1 Then
            Me.dgv_show2(Me.DataGridView20, "select Name, Class, Class_No, House_Name as House, Result as 'Result(Meters)' from " + Me.Proj + "_student s, " + Me.Proj + "_results r, " + Me.Proj + "_house h where s.SID=r.SID and s.house=h.house_code and Event_Code='" + b19_e_code(ListBox6.SelectedIndex) + "' and Absent <>'ABS' order by Result desc")
        End If
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Me.dgv_show2(Me.DataGridView21, "SELECT Event_Name, l1.Name as Lane1, l2.Name as Lane2, l3.Name as Lane3, l4.Name as Lane4, l5.Name as Lane5, l6.Name as Lane6, l7.Name as Lane7, l8.Name as Lane8 FROM " + Me.Proj + "_finalslane l left join " + Me.Proj + "_finals f on l.event_code=f.event_code left join " + Me.Proj + "_student l1 on l.lane1=l1.SID left join " + Me.Proj + "_student l2 on l.lane2=l2.SID left join " + Me.Proj + "_student l3 on l.lane3=l3.SID left join " + Me.Proj + "_student l4 on l.lane4=l4.SID left join " + Me.Proj + "_student l5 on l.lane5=l5.SID left join " + Me.Proj + "_student l6 on l.lane6=l6.SID left join " + Me.Proj + "_student l7 on l.lane7=l7.SID left join " + Me.Proj + "_student l8 on l.lane8=l8.SID")
    End Sub

    Private Sub EditProjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditProjectToolStripMenuItem.Click
        Form8.Show()
    End Sub
    Sub print_html(ByVal dgv As DataGridView, ByVal type As String, Optional ByVal head As String = "")
        Dim strquote As Char = """"
        Dim cmdstr As String = "select * from SDMCompInfo where proj_code ='" + Me.Proj + "'"
        Dim dt As New DataTable
        fill_table(cmdstr, dt)
        Dim printw As StreamWriter = New StreamWriter("temp.html")
        printw.WriteLine("<html>")
        printw.WriteLine("<body>")
        printw.WriteLine("<br><br><br>")
        printw.WriteLine("<center><b><p style=" + strquote + "font-size:20px" + strquote + ">" + dt.Rows(0)("school_name") + "</p></b></center>")
        printw.WriteLine("<center><b><p style=" + strquote + "font-size:20px" + strquote + ">" + "Year " + dt.Rows(0)("school_year") + "</p></b></center>")
        printw.WriteLine("<center><b><p style=" + strquote + "font-size:20px" + strquote + ">" + dt.Rows(0)("title_of_competition") + "</p></b></center>")
        printw.WriteLine("<br><br><br>")
        Select Case type
            Case "n"
                printw.Write("<table border=" + strquote + "1" + strquote + ">")
                For j = 0 To dgv.Columns.Count - 1
                    printw.Write("<th>" & dgv.Columns(j).HeaderText & "</th>")
                Next
                printw.WriteLine("</tr>")
                For k = 0 To dgv.Rows.Count - 1
                    printw.Write("<tr>")
                    For j = 0 To dgv.Rows(k).Cells.Count - 1
                        printw.Write("<td>" & dgv.Rows(k).Cells(j).Value & "</td>")
                    Next
                    printw.WriteLine("</tr>")
                Next
                printw.WriteLine("</table>")
            Case "e"
                printw.WriteLine("<b>" + head + "</b>")
                printw.Write("<table border=" + strquote + "1" + strquote + ">")
                For j = 0 To dgv.Columns.Count - 1
                    printw.Write("<th>" & dgv.Columns(j).HeaderText & "</th>")
                Next
                For k = 0 To dgv.Rows.Count - 1
                    printw.Write("<tr>")
                    For j = 0 To dgv.Rows(k).Cells.Count - 1
                        printw.Write("<td>" & dgv.Rows(k).Cells(j).Value & "</td>")
                    Next
                    printw.WriteLine("</tr>")
                Next
                printw.WriteLine("</table>")
            Case "t"
                printw.WriteLine("Date: " & dt.Rows(0)("date_of_day" + head))
                printw.Write("<table border=" + strquote + "1" + strquote + ">")
                printw.Write("<tr>")
                For j = 0 To dgv.Columns.Count - 1
                    printw.Write("<th>" & dgv.Columns(j).HeaderText & "</th>")
                Next
                printw.WriteLine("</tr>")
                Dim x As String = "1"
                Dim y As String = "1"
                For k = 0 To dgv.Rows.Count - 1
                    printw.Write("<tr>")
                    printw.Write("<th>" & dgv.Rows(k).Cells(0).Value & "</th>")
                    For j = 1 To dgv.Rows(k).Cells.Count - 1
                        If dgv.Rows(k).Cells(j).Value = "" Then
                            printw.Write("<td></td>")
                        Else
                            If dgv.Rows(k).Cells(j).Value <> dgv.Rows(k).Cells(j - 1).Value Then
                                x = check_horizontal(dgv, j, k, 1)
                                If k > 0 AndAlso dgv.Rows(k).Cells(j).Value <> dgv.Rows(k - 1).Cells(j).Value Then
                                    y = check_vertical(dgv, j, k, 1)
                                    printw.Write("<th colspan=" + strquote + x + strquote + " rowspan=" + strquote + y + strquote + ">" & dgv.Rows(k).Cells(j).Value & "</th>")
                                ElseIf k = 0 Then
                                    y = check_vertical(dgv, j, k, 1)
                                    printw.Write("<th colspan=" + strquote + x + strquote + " rowspan=" + strquote + y + strquote + ">" & dgv.Rows(k).Cells(j).Value & "</th>")
                                End If
                            End If
                        End If
                    Next
                    printw.WriteLine("</tr>")
                Next
                printw.WriteLine("</table>")
        End Select

        printw.WriteLine("</body>")
        printw.WriteLine("</html>")
        printw.Close()
        System.Diagnostics.Process.Start("temp.html")
    End Sub
    Function check_horizontal(ByVal dgv As DataGridView, ByVal x As Integer, ByVal y As Integer, ByVal count As Integer)
        If x <> dgv.Rows(y).Cells.Count - 1 AndAlso dgv.Rows(y).Cells(x).Value = dgv.Rows(y).Cells(x + 1).Value Then
            count = check_horizontal(dgv, x + 1, y, count)
            Return count + 1
        Else
            Return count
        End If
    End Function
    Function check_vertical(ByVal dgv As DataGridView, ByVal x As Integer, ByVal y As Integer, ByVal cnt As Integer)
        If y <> dgv.Rows.Count - 1 AndAlso dgv.Rows(y).Cells(x).Value = dgv.Rows(y + 1).Cells(x).Value Then
            cnt = check_vertical(dgv, x, y + 1, cnt)
            Return cnt + 1
        Else
            Return cnt
        End If
    End Function
    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        If DataGridView2.Rows.Count <> 0 Then
            print_html(DataGridView2, "n")
        End If
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        If DataGridView3.Rows.Count <> 0 Then
            print_html(DataGridView3, "n")
        End If
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        If DataGridView4.Rows.Count <> 0 Then
            print_html(DataGridView4, "n")
        End If
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        If DataGridView6.Rows.Count <> 0 Then
            print_html(DataGridView6, "e", ListBox1.SelectedItem.ToString)
        End If
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        If DataGridView5.Rows.Count <> 0 Then
            print_html(DataGridView5, "e", ListBox2.SelectedItem.ToString)
        End If
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        If DataGridView14.Rows.Count <> 0 Then
            print_html(DataGridView14, "n")
        End If
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        If DataGridView13.Rows.Count <> 0 Then
            MsgBox("If you want to print athlets' number sheet, please read instruction")
            print_html(DataGridView13, "n")
        End If
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        If DataGridView7.Rows.Count <> 0 Then
            print_html(DataGridView7, "n")
        End If
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        If DataGridView8.Rows.Count <> 0 Then
            print_html(DataGridView8, "n")
        End If
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        If DataGridView9.Rows.Count <> 0 Then
            print_html(DataGridView9, "n")
        End If
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        If DataGridView10.Rows.Count <> 0 Then
            print_html(DataGridView10, "t", "1")
        End If
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        If DataGridView11.Rows.Count <> 0 Then
            print_html(DataGridView11, "t", "1")
        End If
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        If DataGridView20.Rows.Count <> 0 Then
            print_html(DataGridView20, "e", ListBox6.SelectedItem.ToString)
        End If
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        If DataGridView12.Rows.Count <> 0 Then
            print_html(DataGridView12, "e", ListBox3.SelectedItem.ToString)
        End If
    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        If DataGridView15.Rows.Count <> 0 Then
            print_html(DataGridView15, "e", ListBox4.SelectedItem.ToString)
        End If
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        If DataGridView16.Rows.Count <> 0 Then
            print_html(DataGridView16, "e", ListBox5.SelectedItem.ToString)
        End If
    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        If DataGridView21.Rows.Count <> 0 Then
            print_html(DataGridView21, "n")
        End If
    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        If DataGridView17.Rows.Count <> 0 Then
            print_html(DataGridView17, "n")
        End If
    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        If DataGridView18.Rows.Count <> 0 Then
            print_html(DataGridView18, "n")
        End If
    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        If DataGridView19.Rows.Count <> 0 Then
            print_html(DataGridView19, "n")
        End If
    End Sub

    Private Sub InstructionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstructionToolStripMenuItem.Click
        Dim tc() As TabControl = {TabControl0, TabControl1, TabControl2, TabControl3, TabControl4, TabControl5}
        If TabControl0.Visible = False Then
            For x = 0 To 5
                tc(x).Visible = False
            Next
            TabControl0.Visible = True
        End If
        TabControl0.SelectTab(0)
    End Sub

    Private Sub NoticesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoticesToolStripMenuItem.Click
        Dim tc() As TabControl = {TabControl0, TabControl1, TabControl2, TabControl3, TabControl4, TabControl5}
        If TabControl0.Visible = False Then
            For x = 0 To 5
                tc(x).Visible = False
            Next
            TabControl0.Visible = True
        End If
        TabControl0.SelectTab(1)
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        Dim tc() As TabControl = {TabControl0, TabControl1, TabControl2, TabControl3, TabControl4, TabControl5}
        If TabControl0.Visible = False Then
            For x = 0 To 5
                tc(x).Visible = False
            Next
            TabControl0.Visible = True
        End If
        TabControl0.SelectTab(2)
    End Sub

    Private Sub ProjectGuideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjectGuideToolStripMenuItem.Click
        Form30.Show()
    End Sub
End Class
