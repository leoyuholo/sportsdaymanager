Public Class Form28

    Private Sub Form28_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmdstr As String = "select distinct Class from " + Form1.Proj + "_student"
        Dim dt As New DataTable
        Form1.fill_table(cmdstr, dt)
        For i = 0 To dt.Rows.Count - 1
            ComboBox1.Items.Add(dt.Rows(i)("Class"))
        Next
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        TextBox1.Clear()
        TextBox2.Clear()
        Form1.dgv_show2(Me.DataGridView1, "select Name, Adjustment from " + Form1.Proj + "_student s, " + Form1.Proj + "_adjustpersonalscore a where s.SID=a.SID and Class ='" + ComboBox1.Text + "' and Class_No ='" + ComboBox2.Text + "'")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.ResetText()
        ComboBox2.Items.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        Dim dt As New DataTable
        Dim cmdstr As String = "select Class_No from " + Form1.Proj + "_student where Class ='" + ComboBox1.Text + "'"
        Form1.fill_table(cmdstr, dt)
        For i = 0 To dt.Rows.Count - 1
            ComboBox2.Items.Add(dt.Rows(i)("Class_No"))
        Next
        Form1.dgv_show2(Me.DataGridView1, "select Name, Adjustment from " + Form1.Proj + "_student s, " + Form1.Proj + "_adjustpersonalscore a where s.SID=a.SID and Class ='" + ComboBox1.Text + "'")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = Form1.esstr_exe("select pw from SDMProj where Proj_Code ='" + Form1.Proj + "'") Then
            Dim cmdstr As String = "update " + Form1.Proj + "_adjustpersonalscore set Adjustment ='" + TextBox1.Text + "' where SID in (select SID from " + Form1.Proj + "_student where Class ='" + ComboBox1.Text + "' and Class_No ='" + ComboBox2.Text + "')"
            Form1.enq_exe(cmdstr)
            MsgBox("Adjusted successfully")
            ComboBox2.ResetText()
            ComboBox2.Items.Clear()
            TextBox1.Clear()
            TextBox2.Clear()
        Else
            MsgBox("Incorrect Password")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class