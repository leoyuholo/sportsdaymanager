Public Class Form16
    Dim cb() As CheckBox = {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5, CheckBox6, CheckBox7, CheckBox8, CheckBox9, CheckBox10, CheckBox11}

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cb() As CheckBox = {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5, CheckBox6, CheckBox7, CheckBox8, CheckBox9, CheckBox10, CheckBox11, CheckBox12}
        For i = 0 To cb.Length - 1
            cb(i).Checked = True
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cb() As CheckBox = {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5, CheckBox6, CheckBox7, CheckBox8, CheckBox9, CheckBox10, CheckBox11, CheckBox12}
        For i = 0 To cb.Length - 1
            cb(i).Checked = False
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cb() As CheckBox = {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5, CheckBox6, CheckBox7, CheckBox8, CheckBox9, CheckBox10, CheckBox11, CheckBox12}
        Dim cmdstr As String = "select sex from SDMCompInfo where proj_code='" + Form1.Proj + "'"
        Dim sex As String = Form1.esstr_exe(cmdstr)
        cmdstr = "select a_grade from SDMCompInfo where proj_code='" + Form1.Proj + "'"
        Dim a As String = Form1.esstr_exe(cmdstr)
        cmdstr = "select b_grade from SDMCompInfo where proj_code='" + Form1.Proj + "'"
        Dim b As String = Form1.esstr_exe(cmdstr)
        cmdstr = "select c_grade from SDMCompInfo where proj_code='" + Form1.Proj + "'"
        Dim c As String = Form1.esstr_exe(cmdstr)
        cmdstr = "insert into " + Form1.Proj + "_event select * from s_event where "
        Select Case sex
            Case "B"
                cmdstr = cmdstr + "(sex='M')"
            Case "G"
                cmdstr = cmdstr + "(sex='F')"
            Case "C"
                cmdstr = cmdstr + "(sex='M' or sex='F')"
        End Select
        cmdstr = cmdstr + " and ("
        If a = 1 Then
            cmdstr = cmdstr + "Grade='A' or "
        End If
        If b = 1 Then
            cmdstr = cmdstr + "Grade='B' or "
        End If
        If c = 1 Then
            cmdstr = cmdstr + "Grade='C' or "
        End If
        cmdstr = cmdstr.Substring(0, cmdstr.Length - 3) + ") and ("
        For i = 0 To 11
            If cb(i).Checked = True Then
                cmdstr = cmdstr + "Event_Name like'" + cb(i).Text + "%' or "
            End If
        Next
        cmdstr = cmdstr.Substring(0, cmdstr.Length - 3) + ")"
        Form1.enq_exe(cmdstr)
        Form1.dgv_show(Form6.DataGridView3, "_event", "*", "where Event_Code <> '100NNN' order by Event_Code")
        Form6.Label30.Text = Form6.DataGridView3.Rows.Count & " Rows"
        Me.Close()
    End Sub

    Private Sub Form16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class