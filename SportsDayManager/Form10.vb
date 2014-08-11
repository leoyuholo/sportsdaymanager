Public Class Form10
    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim cmdstr As String = "select * from SDMCompInfo where proj_code='" + Form1.Proj + "'"
        Form1.fill_table(cmdstr, dt)
        Select Case dt.Rows(0)("sex")
            Case "B"
                ComboBox2.Items.Add("M")
            Case "G"
                ComboBox2.Items.Add("F")
            Case "C"
                ComboBox2.Items.Add("M")
                ComboBox2.Items.Add("F")
        End Select
        If dt.Rows(0)("a_grade") = "1" Then
            ComboBox1.Items.Add("A")
        End If
        If dt.Rows(0)("b_grade") = "1" Then
            ComboBox1.Items.Add("B")
        End If
        If dt.Rows(0)("c_grade") = "1" Then
            ComboBox1.Items.Add("C")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        ComboBox3.ResetText()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Then
            MsgBox("Please fill in all blanks.")
        Else
            Dim cmd1 As String = "select max(left(Event_Code,3)) from " + Form1.Proj + "_event"
            Dim assign As Integer
            If CheckBox1.Checked = True Then
                assign = 1
            End If
            Dim e_code As String = Form1.esstr_exe(cmd1)
            e_code = Val(e_code) + 1
            Dim e_str As String = e_code + ComboBox1.Text + ComboBox2.Text + ComboBox3.Text
            Dim cmdstr As String = "insert into " + Form1.Proj + "_event(Event_Code, Event_Name, Grade, Sex, Field_or_Track, Assign_Lane, Holding_Area) value ('" + e_str + "','" + TextBox1.Text + "','" + ComboBox1.Text + "','" + ComboBox2.Text + "','" + ComboBox3.Text + "','" + Trim(Str(assign)) + "','" + TextBox2.Text + "')"
            Form1.enq_exe(cmdstr)
            Form1.dgv_show(Form6.DataGridView3, "_event", "*", "where Event_Code <> '100NNN' order by Event_Code")
            Form6.Label30.Text = Form6.DataGridView3.Rows.Count & " Rows"
            TextBox1.Clear()
            TextBox2.Clear()
            ComboBox1.ResetText()
            ComboBox2.ResetText()
            ComboBox3.ResetText()
        End If
    End Sub

End Class