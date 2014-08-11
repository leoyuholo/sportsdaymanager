Public Class Form18
    Public t_code(0) As String
    Private Sub Form18_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmdstr As String = "select distinct Class from " + Form1.Proj + "_student"
        Dim dt As New DataTable
        Form1.fill_table(cmdstr, dt)
        For i = 0 To dt.Rows.Count - 1
            ComboBox1.Items.Add(dt.Rows(i)("Class"))
        Next
        cmdstr = "select Team_Code, Team_Name from " + Form1.Proj + "_helperteam where Team_Code <>'1000'"
        dt.Clear()
        Form1.fill_table(cmdstr, dt)
        ComboBox3.Items.Clear()
        ReDim t_code(1000)
        For i = 0 To dt.Rows.Count - 1
            ComboBox3.Items.Add(dt.Rows(i)("Team_Name"))
            t_code(i) = dt.Rows(i)("Team_Code")
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Items.Clear()
        Dim dt As New DataTable
        Dim cmdstr As String = "select Class_No from " + Form1.Proj + "_student where Class ='" + ComboBox1.Text + "'"
        Form1.fill_table(cmdstr, dt)
        For i = 0 To dt.Rows.Count - 1
            ComboBox2.Items.Add(dt.Rows(i)("Class_No"))
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim dt As New DataTable
        Dim cmdstr As String = "select * from " + Form1.Proj + "_student s where Class ='" + ComboBox1.Text + "' and Class_No ='" + ComboBox2.Text + "'"
        Form1.fill_table(cmdstr, dt)
        Label4.Text = "Class: " + ComboBox1.Text + " Class No: " + ComboBox2.Text + " Sex: " + dt.Rows(0)("Sex") + " " + dt.Rows(0)("Name")
        ComboBox3.ResetText()
        Button1.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmdstr As String = "update " + Form1.Proj + "_helperregister set Team_Code ='" + t_code(ComboBox3.SelectedIndex) + "' where SID =(select SID from " + Form1.Proj + "_student where Class ='" + ComboBox1.Text + "' and Class_No ='" + ComboBox2.Text + "')"
        Form1.enq_exe(cmdstr)
        MsgBox("Successfully registered helper team")
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        ComboBox2.Items.Clear()
        ComboBox3.ResetText()
        Label4.Text = "Please select a student"
        Button1.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        ComboBox2.Items.Clear()
        ComboBox3.ResetText()
        Label4.Text = "Please select a student"
        Button1.Enabled = False
    End Sub
End Class