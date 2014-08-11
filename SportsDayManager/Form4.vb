Public Class Form4
    Dim p_code(10000) As String
    Dim dt As New DataTable

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBoxReadName()
    End Sub
    Sub ListBoxReadName()
        dt.Clear()
        Dim cmdstr As String = "select Proj_code, Name from SDMProj where Proj_code <>'1000' order by Proj_code"
        Try
            Form1.fill_table(cmdstr, dt)
        Catch ex As Exception
            Exit Sub
        End Try
        ReDim p_code(10000)
        Me.ListBox1.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            ListBox1.Items.Add(dt.Rows(i)("Name"))
            p_code(i) = dt.Rows(i)("Proj_code")
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex = -1 Then
            If TextBox3.Text = "DebugToolsBox" Then
                Form5.Show()
                Me.Close()
            Else
                MsgBox("Please Select a Project")
            End If
        Else
            If TextBox3.Text = "" Then
                MsgBox("Please Enter Password")
            ElseIf TextBox3.Text = Form1.esstr_exe("select PW from SDMProj where Proj_code ='" + p_code(ListBox1.SelectedIndex) + "'") Then
                Form1.Proj = p_code(ListBox1.SelectedIndex)
                Form1.menustrip_enable()
                Me.Close()
                Form30.Show()
            Else
                MsgBox("Incorrect Password")
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            Dim cmdstr As String = "select Author from SDMProj where Proj_code ='" + p_code(ListBox1.SelectedIndex) + "'"
            TextBox2.Text = Form1.esstr_exe(cmdstr)
            cmdstr = "select Description from SDMProj where Proj_code ='" + p_code(ListBox1.SelectedIndex) + "'"
            RichTextBox1.Text = Form1.esstr_exe(cmdstr)
            TextBox1.Text = ListBox1.SelectedItem
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim checkpw As String
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("Please Select a Project")
        Else
            Dim cmdstr As String = "select PW from SDMProj where Proj_code ='" + p_code(ListBox1.SelectedIndex) + "'"
            checkpw = Form1.esstr_exe(cmdstr)
            If TextBox3.Text = "" Then
                MsgBox("Please Enter Password")
            ElseIf TextBox3.Text = checkpw Then
                If MsgBox("Delete Project " + ListBox1.SelectedItem + "?", MsgBoxStyle.OkCancel, "Delete Project") = 1 Then
                    cmdstr = "drop table if exists " + p_code(ListBox1.SelectedIndex) + "_student"
                    Form1.enq_exe(cmdstr)
                    cmdstr = "drop table if exists " + p_code(ListBox1.SelectedIndex) + "_house"
                    Form1.enq_exe(cmdstr)
                    cmdstr = "drop table if exists " + p_code(ListBox1.SelectedIndex) + "_event"
                    Form1.enq_exe(cmdstr)
                    cmdstr = "drop table if exists " + p_code(ListBox1.SelectedIndex) + "_helperteam"
                    Form1.enq_exe(cmdstr)
                    cmdstr = "drop table if exists " + p_code(ListBox1.SelectedIndex) + "_eventregister"
                    Form1.enq_exe(cmdstr)
                    cmdstr = "drop table if exists " + p_code(ListBox1.SelectedIndex) + "_helperregister"
                    Form1.enq_exe(cmdstr)
                    cmdstr = "drop view if exists " + p_code(ListBox1.SelectedIndex) + "_noofgroups"
                    Form1.enq_exe(cmdstr)
                    cmdstr = "drop table if exists " + p_code(ListBox1.SelectedIndex) + "_lane"
                    Form1.enq_exe(cmdstr)
                    cmdstr = "drop table if exists " + p_code(ListBox1.SelectedIndex) + "_finals"
                    Form1.enq_exe(cmdstr)
                    cmdstr = "drop table if exists " + p_code(ListBox1.SelectedIndex) + "_eventtime"
                    Form1.enq_exe(cmdstr)
                    cmdstr = "drop table if exists " + p_code(ListBox1.SelectedIndex) + "_timetableday1"
                    Form1.enq_exe(cmdstr)
                    cmdstr = "drop table if exists " + p_code(ListBox1.SelectedIndex) + "_timetableday2"
                    Form1.enq_exe(cmdstr)
                    cmdstr = "drop table if exists " + p_code(ListBox1.SelectedIndex) + "_results"
                    Form1.enq_exe(cmdstr)
                    cmdstr = "drop table if exists " + p_code(ListBox1.SelectedIndex) + "_finalslane"
                    Form1.enq_exe(cmdstr)
                    cmdstr = "drop table if exists " + p_code(ListBox1.SelectedIndex) + "_award"
                    Form1.enq_exe(cmdstr)
                    cmdstr = "drop table if exists " + p_code(ListBox1.SelectedIndex) + "_adjustpersonalscore"
                    Form1.enq_exe(cmdstr)
                    cmdstr = "drop table if exists " + p_code(ListBox1.SelectedIndex) + "_adjusthousescore"
                    Form1.enq_exe(cmdstr)

                    cmdstr = "delete from SDMProj where Proj_code ='" + p_code(ListBox1.SelectedIndex) + "'"
                    Form1.enq_exe(cmdstr)
                    cmdstr = "delete from SDMCompInfo where proj_code =" + p_code(ListBox1.SelectedIndex)
                    Form1.enq_exe(cmdstr)
                    Form1.Proj = "1000"
                    Form1.menustrip_enable()
                    MsgBox("Deleted successfully")
                    ListBoxReadName()
                    TextBox3.Clear()
                End If
            Else
                MsgBox("Incorrect Password")
            End If
        End If
    End Sub
End Class