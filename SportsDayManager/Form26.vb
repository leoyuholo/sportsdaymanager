Public Class Form26
    Dim sid() As String
    Private Sub Form26_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox3.Text = Form23.ListBox1.SelectedItem.ToString
        Dim cmdstr As String = "select s.SID, concat(Class, ' ', Class_No, ' ', Name) as student from " + Form1.Proj + "_student s, " + Form1.Proj + "_results r where s.SID=r.SID and Event_Code ='" + Form23.f23_e_code(Form23.ListBox1.SelectedIndex) + "'"
        Dim dt As New DataTable
        ReDim sid(500)
        Form1.fill_table(cmdstr, dt)
        For i = 0 To dt.Rows.Count - 1
            ListBox1.Items.Add(dt.Rows(i)("student"))
            sid(i) = dt.Rows(i)("SID")
        Next
        If Form23.f23_e_code(Form23.ListBox1.SelectedIndex).Substring(Form23.f23_e_code(Form23.ListBox1.SelectedIndex).Length - 1, 1) = "T" Then
            Label5.Text = "Seconds"
        Else
            Label5.Text = "Meters"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox4.Text = Form1.esstr_exe("select pw from SDMProj where Proj_Code ='" + Form1.Proj + "'") Then
            Dim cmdstr As String
            If TextBox1.Text.ToUpper = "ABS" Then
                cmdstr = "update " + Form1.Proj + "_results set Result ='', absent='ABS' where SID='" + sid(ListBox1.SelectedIndex) + "' and Event_Code ='" + Form23.f23_e_code(Form23.ListBox1.SelectedIndex) + "'"
            Else
                cmdstr = "update " + Form1.Proj + "_results set Result ='" + TextBox1.Text + "', absent='' where SID='" + sid(ListBox1.SelectedIndex) + "' and Event_Code ='" + Form23.f23_e_code(Form23.ListBox1.SelectedIndex) + "'"
            End If
            Form1.enq_exe(cmdstr)
            MsgBox("Modified Successfully")
        Else
            MsgBox("Incorrect Password")
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            TextBox2.Text = Form1.esstr_exe("select Name from " + Form1.Proj + "_student where SID ='" + sid(ListBox1.SelectedIndex) + "'")
            TextBox1.Text = Form1.esstr_exe("select if(absent='ABS', convert(absent, char), convert(result, char)) from " + Form1.Proj + "_results where SID ='" + sid(ListBox1.SelectedIndex) + "' and Event_Code ='" + Form23.f23_e_code(Form23.ListBox1.SelectedIndex) + "'")
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class