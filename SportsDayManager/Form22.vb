Public Class Form22
    Dim e_code(1000) As String
    Dim sid(500) As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text <> "" And TextBox1.Text <> "" Then
            Dim cmdstr As String
            If TextBox1.Text.ToUpper = "ABS" Then
                cmdstr = "insert into " + Form1.Proj + "_results(SID, Event_Code, Absent) value ('" + sid(ListBox1.SelectedIndex) + "', '" + e_code(ComboBox1.SelectedIndex) + "', '" + TextBox1.Text + "')"
            Else
                cmdstr = "insert into " + Form1.Proj + "_results(SID, Event_Code, Result) value ('" + sid(ListBox1.SelectedIndex) + "', '" + e_code(ComboBox1.SelectedIndex) + "', '" + TextBox1.Text + "')"
            End If
            Try
                Form1.enq_exe(cmdstr)
            Catch ex As Exception
                MsgBox("Dupicate or Inappropriate Result Entered")
            End Try
            MsgBox("Updated Successfully")
            ListBox1.SelectedIndex = 0
            TextBox2.Clear()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form22_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmdstr As String = "select distinct Grade from " + Form1.Proj + "_noofgroups"
        Dim dt As New DataTable
        Form1.fill_table(cmdstr, dt)
        For i = 0 To dt.Rows.Count - 1
            ComboBox3.Items.Add(dt.Rows(i)("Grade"))
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.ResetText()
        ComboBox2.Items.Clear()
        ListBox1.Items.Clear()
        TextBox2.Clear()
        ReDim sid(500)
        If e_code(ComboBox1.SelectedIndex).Substring(0, 1) = "F" Then
            Dim cmdstr As String = "select * from " + Form1.Proj + "_finalslane where Event_Code ='" + e_code(ComboBox1.SelectedIndex) + "'"
            Dim dt As New DataTable
            Form1.fill_table(cmdstr, dt)
            For i = 1 To 8
                ListBox1.Items.Add(Form1.esstr_exe("select concat(Class, ' ', Class_No, ' ', Name) from " + Form1.Proj + "_student where SID ='" + dt.Rows(0)("lane" + Trim(Str(i))) + "'"))
                sid(i - 1) = dt.Rows(0)("lane" + Trim(Str(i)))
            Next
            ComboBox2.Enabled = False
        Else
            Dim cmdstr As String = "select s.SID, concat(Class, ' ', Class_No, ' ', Name) as student from " + Form1.Proj + "_student s, " + Form1.Proj + "_eventregister r where s.SID=r.SID and (Event1 ='" + e_code(ComboBox1.SelectedIndex) + "' or Event2 ='" + e_code(ComboBox1.SelectedIndex) + "' or Event3 ='" + e_code(ComboBox1.SelectedIndex) + "') order by Class, Class_No"
            Dim dt As New DataTable
            Form1.fill_table(cmdstr, dt)
            For i = 0 To dt.Rows.Count - 1
                ListBox1.Items.Add(dt.Rows(i)("student"))
                sid(i) = dt.Rows(i)("SID")
            Next
            cmdstr = "select distinct Class from " + Form1.Proj + "_student s, " + Form1.Proj + "_eventregister r where s.SID=r.SID and (Event1 ='" + e_code(ComboBox1.SelectedIndex) + "' or Event2 ='" + e_code(ComboBox1.SelectedIndex) + "' or Event3 ='" + e_code(ComboBox1.SelectedIndex) + "') order by Class"
            dt.Clear()
            Form1.fill_table(cmdstr, dt)
            For i = 0 To dt.Rows.Count - 1
                ComboBox2.Items.Add(dt.Rows(i)("Class"))
            Next
            ComboBox2.Enabled = True
        End If
        If e_code(ComboBox1.SelectedIndex).Substring(e_code(ComboBox1.SelectedIndex).Length - 1, 1) = "T" Then
            Label5.Text = "Seconds"
        Else
            Label5.Text = "Meters"
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        ComboBox1.ResetText()
        ComboBox1.Items.Clear()
        ComboBox2.ResetText()
        ComboBox2.Items.Clear()
        ListBox1.Items.Clear()
        TextBox2.Clear()
        ReDim e_code(1000)
        Dim cmdstr As String = "select Event_Code, Sex, Event_Name from " + Form1.Proj + "_noofgroups where Grade ='" + ComboBox3.SelectedItem.ToString + "' union select Event_Code, Sex, Event_Name from " + Form1.Proj + "_finals where Grade ='" + ComboBox3.SelectedItem.ToString + "'"
        Dim dt As New DataTable
        Dim sex As String
        Form1.fill_table(cmdstr, dt)
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("Sex") = "M" Then
                sex = "Boys' "
            Else
                sex = "Girls' "
            End If
            ComboBox1.Items.Add(sex + ComboBox3.SelectedItem.ToString + " Grade " + dt.Rows(i)("Event_Name"))
            e_code(i) = dt.Rows(i)("Event_Code")
        Next
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        ListBox1.Items.Clear()
        TextBox2.Clear()
        ReDim sid(500)
        Dim cmdstr As String = "select s.SID, concat(Class, ' ', Class_No, ' ', Name) as student from " + Form1.Proj + "_student s, " + Form1.Proj + "_eventregister r where s.SID=r.SID and (Event1 ='" + e_code(ComboBox1.SelectedIndex) + "' or Event2 ='" + e_code(ComboBox1.SelectedIndex) + "' or Event3 ='" + e_code(ComboBox1.SelectedIndex) + "') and Class ='" + ComboBox2.SelectedItem.ToString + "' order by Class_No"
        Dim dt As New DataTable
        Form1.fill_table(cmdstr, dt)
        For i = 0 To dt.Rows.Count - 1
            ListBox1.Items.Add(dt.Rows(i)("student"))
            sid(i) = dt.Rows(i)("SID")
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            TextBox2.Text = Form1.esstr_exe("select Name from " + Form1.Proj + "_student where SID ='" + sid(ListBox1.SelectedIndex) + "'")
            If Form1.esstr_exe("select 'True' from " + Form1.Proj + "_results where Event_Code ='" + e_code(ComboBox1.SelectedIndex) + "' and SID ='" + sid(ListBox1.SelectedIndex) + "'") = "True" Then
                TextBox1.Text = Form1.esstr_exe("select Result from " + Form1.Proj + "_results where Event_Code ='" + e_code(ComboBox1.SelectedIndex) + "' and SID ='" + sid(ListBox1.SelectedIndex) + "'")
                TextBox1.ReadOnly = True
            Else
                TextBox1.ReadOnly = False
                TextBox1.Clear()
            End If
        End If
    End Sub
End Class