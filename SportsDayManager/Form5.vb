Imports System
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Form5
    Dim csr As StreamReader = New StreamReader("settings.txt")
    Dim ds, ui, pwd, db As String
    Dim data(20) As String
    Dim i As Integer
    Dim myConnectionString As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myConnectionString As String
        myConnectionString = "Database=" + TextBox4.Text + ";" + "Data Source=" + TextBox1.Text + ";User Id=" + TextBox2.Text + ";Password=" + TextBox3.Text
        Dim myConnection As New MySqlConnection(myConnectionString)
        Dim cmdstr As String = RichTextBox1.Text
        Dim myCommand As New MySqlCommand(cmdstr)
        myCommand.Connection = myConnection
        myConnection.Open()
        If cmdstr.Substring(0, 6).ToUpper = "SELECT" Then
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(cmdstr, myConnection)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Else
            myCommand.ExecuteNonQuery()
            MsgBox("Success")
        End If
        myCommand.Connection.Close()
    End Sub


    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        While Not csr.EndOfStream
            data(i) = csr.ReadLine
            i += 1
        End While
        csr.Close()
        ds = data(4)
        ui = data(5)
        pwd = data(6)
        db = data(7)
        TextBox1.Text = ds
        TextBox2.Text = ui
        TextBox3.Text = pwd
        TextBox4.Text = db
        myConnectionString = "Database=" + db + ";Data Source=" + ds + ";User Id=" + ui + ";Password=" + pwd
    End Sub
    Sub f5_enq_exe(ByVal cmd As String)
        Try
            Using cn As New MySqlConnection(myConnectionString)
                cn.Open()
                Dim cmdexe = New MySqlCommand(cmd, cn)
                cmdexe.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function f5_esstr_exe(ByVal cmd As String) As String
        Using cn As New MySqlConnection(myConnectionString)
            cn.Open()
            Dim cmdexe = New MySqlCommand(cmd, cn)
            Return cmdexe.ExecuteScalar()
        End Using
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        myConnectionString = "Database=" + TextBox4.Text + ";" + "Data Source=" + TextBox1.Text + ";User Id=" + TextBox2.Text + ";Password=" + TextBox3.Text
        Dim cmdstr As String = "create table SDMProj (Proj_code char(4), Name char(20), Author char(20), PW char(20), Description char(200), Stage_1 tinyint(1) NOT NULL DEFAULT '0', Stage_2 tinyint(1) NOT NULL DEFAULT '0', Stage_3 tinyint(1) NOT NULL DEFAULT '0', Stage_4 tinyint(1) NOT NULL DEFAULT '0', primary key(Proj_code))"
        f5_enq_exe(cmdstr)
        cmdstr = "insert into SDMProj(Proj_code) value ('1000')"
        f5_enq_exe(cmdstr)
        cmdstr = "create table SDMCompInfo (proj_code char(4) NOT NULL, school_name char(200) NOT NULL, school_year char(10) NOT NULL, title_of_competition char(200) NOT NULL, venue char(200) NOT NULL, venue_address char(200) NOT NULL, no_of_days decimal(1) NOT NULL DEFAULT 1, date_of_day1 date NOT NULL DEFAULT '2009-11-1', date_of_day2 date NOT NULL DEFAULT '2009-11-1', bonus_for_participation decimal(2) NOT NULL DEFAULT 1, absentee_penalty decimal(2) NOT NULL DEFAULT -1, bonus_for_finals decimal(2) NOT NULL DEFAULT 2, sex char(1) NOT NULL DEFAULT 'C', a_grade decimal(1) NOT NULL DEFAULT 1, b_grade decimal(1) NOT NULL DEFAULT 1, c_grade decimal(1) NOT NULL  DEFAULT 1, a_grade_time date NOT NULL DEFAULT '1993-12-31', b_grade_time date NOT NULL DEFAULT '1995-12-31', c_grade_time date NOT NULL  DEFAULT '1997-12-31', start_time_day1 char(4) NOT NULL DEFAULT '0830', end_time_day1 char(4) NOT NULL  DEFAULT '1630', start_time_day2 char(4) NOT NULL  DEFAULT '0830', end_time_day2 char(4) NOT NULL DEFAULT '1630', position1_score decimal(2) NOT NULL DEFAULT 9, position2_score decimal(2) NOT NULL DEFAULT 7, position3_score decimal(2) NOT NULL DEFAULT 6, position4_score decimal(2) NOT NULL DEFAULT 5, position5_score decimal(2) NOT NULL DEFAULT 4, position6_score decimal(2) NOT NULL DEFAULT 3, position7_score decimal(2) NOT NULL DEFAULT 2, position8_score decimal(2) NOT NULL DEFAULT 1, primary key(proj_code))"
        f5_enq_exe(cmdstr)
        cmdstr = "create table s_event (Event_Code char(6), Event_Name char(50) NOT NULL, Grade char(1) NOT NULL, Sex char(1) NOT NULL, Field_or_Track char(1) NOT NULL, Assign_Lane decimal(1) NOT NULL DEFAULT '0', Holding_Area char(15) NOT NULL, primary key(Event_Code))"
        f5_enq_exe(cmdstr)
        cmdstr = "insert into s_event(Event_Code) value ('500NNN')"
        f5_enq_exe(cmdstr)
        cmdstr = "create table s_helperteam (Team_Code char(4), Team_Name char(20) NOT NULL, Leading_Teacher char(20) NOT NULL, Working_Area char(20) NOT NULL, Duty_Time_Start char(5) NOT NULL, Duty_Time_End char(5) NOT NULL, primary key(Team_Code))"
        f5_enq_exe(cmdstr)
        cmdstr = "insert into s_helperteam (Team_Code, Team_Name) value ('2001', 'Announcer'), ('2002', 'Closing ceremony'), ('2003', 'Decoration'), ('2004', 'Discus'), ('2005', 'Equipment'), ('2006', 'Finishing judge'), ('2007', 'General affair'), ('2008', 'Spledge representative'), ('2009', 'High  jump'), ('2010', 'Long jump'), ('2011', 'Marshal'), ('2012', 'Master of ceremony'), ('2013', 'Photographer'), ('2014', 'Position judge'), ('2015', 'Discipline'), ('2016', 'Prize presentation'), ('2017', 'Receptionist'), ('2018', 'Recorder'), ('2019', 'Shot-put'), ('2020', 'Start'), ('2021', 'Erumpire'), ('2022', 'Timekeeper')"
        f5_enq_exe(cmdstr)
        Dim g() As Char = {"A", "B", "C"}
        Dim s() As Char = {"M", "F"}
        Dim f() As Char = {"T", "F"}
        Dim n() As String = {"100M", "200M", "400M", "800M", "1500M", "3000M", "110M Hurdles", "High Jump", "Long Jump", "Triple Jump", "Short Put", "Discus"}
        Dim a() As String = {"Track", "Track", "High Jump", "Long Jump", "Triple Jump", "Short Put", "Discus"}
        Dim x, y, z, b, v As Integer
        Dim cmd1 As String = "select max(left(Event_Code,3)) from s_event"
        Dim e_code As String
        For v = 0 To n.Length - 1
            If n(v).Substring(n(v).Length - 1) = "M" Or n(v).Contains("Hurdles") Then
                z = 0
            Else
                z = 1
            End If
            If n(v).Substring(n(v).Length - 1) = "M" Then
                b = 0
            Else
                b = b + 1
            End If
            For x = 0 To g.Length - 1
                For y = 0 To s.Length - 1
                    e_code = f5_esstr_exe(cmd1)
                    e_code = Val(e_code) + 1
                    Dim e_str As String = e_code + g(x) + s(y) + f(z)
                    Dim sx As String
                    If s(y) = "M" Then
                        sx = "Boys"
                    Else
                        sx = "Girls"
                    End If
                    Dim e_name As String = n(v) + "-" + sx + "-" + g(x) + "_Grade"
                    cmdstr = "insert into s_event(Event_Code, Event_Name, Grade, Sex, Field_or_Track, Holding_Area) value ('" + e_str + "','" + e_name + "','" + g(x) + "','" + s(y) + "','" + f(z) + "','" + a(b) + "')"
                    f5_enq_exe(cmdstr)
                Next
            Next
        Next
        f5_enq_exe("update s_event set assign_lane=1 where event_name like '100M%' or like '200M%' or like '400M%' or like '110M%'")
    End Sub
End Class