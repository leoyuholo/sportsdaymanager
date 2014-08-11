Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or RichTextBox1.Text = "" Then
            MsgBox("Please Fill All Blanks")
        ElseIf TextBox3.Text = TextBox4.Text Then
            Dim cmdstr As String = "select max(Proj_code) from SDMProj"
            Dim p_code As Integer = Val(Form1.esstr_exe(cmdstr))
            p_code += 1
            cmdstr = "insert into SDMProj (Proj_code, Name, Author, PW, Description) values ('" + Trim(Str(p_code)) + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + RichTextBox1.Text + "')"
            Form1.enq_exe(cmdstr)
            Form1.Proj = p_code
            cmdstr = "insert into SDMCompInfo (proj_code) value ('" + Form1.Proj + "')"
            Form1.enq_exe(cmdstr)
            Dim cmd1 As String = "create table " + Form1.Proj + "_student (SID char(10), Name char(50) NOT NULL, Sex char (1) NOT NULL, DOB date NOT NULL, House char(2) NOT NULL, Class char(3) NOT NULL, Class_No char(3) NOT NULL, HKID char(10) NOT NULL,Emergency_Call_Phone_Number char(20) NOT NULL, primary key(SID))"
            Form1.enq_exe(cmd1)
            Dim cmd2 As String = "create table " + Form1.Proj + "_house (House_Code char(2), House_Name char(20) NOT NULL, primary key(House_Code))"
            Form1.enq_exe(cmd2)
            Dim cmd3 As String = "create table " + Form1.Proj + "_event (Event_Code char(6), Event_Name char(50) NOT NULL, Grade char(1) NOT NULL, Sex char(1) NOT NULL, Field_or_Track char(1) NOT NULL, Assign_Lane decimal(1) NOT NULL DEFAULT '0', Holding_Area char(15) NOT NULL, primary key(Event_Code))"
            Form1.enq_exe(cmd3)
            cmdstr = "insert into " + Form1.Proj + "_event (Event_Code) value ('100NNN')"
            Form1.enq_exe(cmdstr)
            Dim cmd4 As String = "create table " + Form1.Proj + "_helperteam (Team_Code char(4), Team_Name char(20) NOT NULL, Leading_Teacher char(20) NOT NULL, Working_Area char(20) NOT NULL, Duty_Time_Start char(5) NOT NULL, Duty_Time_End char(5) NOT NULL, primary key(Team_Code))"
            Form1.enq_exe(cmd4)
            cmdstr = "insert into " + Form1.Proj + "_helperteam (Team_Code) value ('1000')"
            Form1.enq_exe(cmdstr)

            Form1.menustrip_enable()
            MsgBox("Created successfully")
            Form30.Show()
            Me.Close()
        Else
            MsgBox("Inconsistent Password Entered")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        RichTextBox1.Clear()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class