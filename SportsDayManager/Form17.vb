Public Class Form17
    Dim sid As String
    Dim grade As Char
    Dim sex As Char
    Dim e_code(0) As String
    Dim e_code2(0) As String
    Dim e_code3(0) As String

    Private Sub Form17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmdstr As String = "select distinct Class from " + Form1.Proj + "_student"
        Dim dt As New DataTable
        Form1.fill_table(cmdstr, dt)
        For i = 0 To dt.Rows.Count - 1
            ComboBox1.Items.Add(dt.Rows(i)("Class"))
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ComboBox1.SelectedIndex <> -1 And ComboBox5.SelectedIndex <> -1 Then
            Dim dt As New DataTable
            Dim cmdstr As String = "select * from " + Form1.Proj + "_student s, (select SID, 'C' as Grade from " + Form1.Proj + "_student where DOB between (select subdate((b_grade_time),-1) from SDMCompInfo where proj_code ='" + Form1.Proj + "') and (select c_grade_time from SDMCompInfo where proj_code ='" + Form1.Proj + "') union select SID, 'B' as Grade from " + Form1.Proj + "_student where DOB between (select subdate((a_grade_time),-1) from SDMCompInfo where proj_code ='" + Form1.Proj + "') and (select b_grade_time from SDMCompInfo where proj_code ='" + Form1.Proj + "') union select SID, 'A' as Grade from " + Form1.Proj + "_student where DOB between '1980/1/1' and (select a_grade_time from SDMCompInfo where proj_code ='" + Form1.Proj + "')) g where s.SID=g.SID and Class ='" + ComboBox1.Text + "' and Class_No='" + ComboBox5.Text + "'"
            Form1.fill_table(cmdstr, dt)
            sid = dt.Rows(0)("SID")
            grade = dt.Rows(0)("Grade")
            sex = dt.Rows(0)("Sex")
            Label3.Text = "Sex: " + sex + " Grade: " + grade + " " + dt.Rows(0)("Name")
            cmdstr = "select * from " + Form1.Proj + "_eventregister where SID ='" + sid + "'"
            dt.Clear()
            Form1.fill_table(cmdstr, dt)
            ComboBox2.Text = Form1.esstr_exe("select Event_Name from " + Form1.Proj + "_event where Event_Code ='" + dt.Rows(0)("Event1") + "'")
            ComboBox3.Text = Form1.esstr_exe("select Event_Name from " + Form1.Proj + "_event where Event_Code ='" + dt.Rows(0)("Event2") + "'")
            ComboBox4.Text = Form1.esstr_exe("select Event_Name from " + Form1.Proj + "_event where Event_Code ='" + dt.Rows(0)("Event3") + "'")
            ReDim e_code(1000)
            read_event(e_code, ComboBox2)
            ReDim e_code2(1000)
            read_event(e_code2, ComboBox3)
            ReDim e_code3(1000)
            read_event(e_code3, ComboBox4)
            ComboBox2.Enabled = True
            ComboBox3.Enabled = True
            ComboBox4.Enabled = True
            Button1.Enabled = True
        Else
            MsgBox("Invalid entry")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label3.Text = "Please select a student"
        ComboBox1.ResetText()
        ComboBox5.ResetText()
        ComboBox2.ResetText()
        ComboBox3.ResetText()
        ComboBox4.ResetText()
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Sub read_event(ByVal code() As String, ByVal combo As ComboBox)
        Dim readt As New DataTable
        Dim cmdstr As String = "select Event_code, Event_Name from " + Form1.Proj + "_event where Event_Code <> '100NNN' and Grade ='" + grade + "' and Sex ='" + sex + "' order by Event_Code"
        Form1.fill_table(cmdstr, readt)
        combo.Items.Clear()
        For i = 0 To readt.Rows.Count - 1
            combo.Items.Add(readt.Rows(i)("Event_Name"))
            code(i) = readt.Rows(i)("Event_Code")
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox2.SelectedIndex <> -1 And ComboBox3.SelectedIndex <> -1 And ComboBox4.SelectedIndex <> -1 And ComboBox2.SelectedIndex <> ComboBox3.SelectedIndex And ComboBox3.SelectedIndex <> ComboBox4.SelectedIndex And ComboBox2.SelectedIndex <> ComboBox4.SelectedIndex Then
            Dim cmdstr As String = "update " + Form1.Proj + "_eventregister set Event1='" + e_code(ComboBox2.SelectedIndex) + "', Event2='" + e_code2(ComboBox3.SelectedIndex) + "', Event3='" + e_code3(ComboBox4.SelectedIndex) + "' where SID='" + sid + "'"
            Form1.enq_exe(cmdstr)
            MsgBox("registered events successfully ")
            Label3.Text = "Please select a student"
            ComboBox1.ResetText()
            ComboBox5.ResetText()
            ComboBox2.ResetText()
            ComboBox3.ResetText()
            ComboBox4.ResetText()
            ComboBox2.Enabled = False
            ComboBox3.Enabled = False
            ComboBox4.Enabled = False
            Button1.Enabled = False
            If Form1.TabControl2.Visible <> True Then
                Form1.TabControl0.Visible = False
                Form1.TabControl1.Visible = False
                Form1.TabControl2.Visible = True
                Form1.TabControl3.Visible = False
                Form1.TabControl4.Visible = False
                Form1.TabControl5.Visible = False
            End If
        Else
            MsgBox("Invalid entry")
        End If
       
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox5.Items.Clear()
        Dim dt As New DataTable
        Dim cmdstr As String = "select Class_No from " + Form1.Proj + "_student where Class ='" + ComboBox1.Text + "'"
        Form1.fill_table(cmdstr, dt)
        For i = 0 To dt.Rows.Count - 1
            ComboBox5.Items.Add(dt.Rows(i)("Class_No"))
        Next
    End Sub
End Class