Imports System
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim csr As StreamReader = New StreamReader("settings.txt")
    Dim ds, ui, pwd, db As String
    Dim data(20) As String
    Dim i As Integer
    Public myConnectionString As String
    Public Proj As String

    Dim sid As String
    Dim grade As Char
    Dim sex As Char
    Dim e_code(0) As String
    Dim e_code2(0) As String
    Dim e_code3(0) As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.ToUpper = "SETTINGS" Then
            If TextBox2.Text = "sportsdaymanager" Then
                Form2.Show()
            Else
                MsgBox("User Not Founnd")
            End If
        Else
            Try
                esstr_exe("select 'True' from " + Me.Proj + "_student")
            Catch ex As Exception
                MsgBox(ex.ToString)
                Exit Try
            End Try
            If esstr_exe("select 'True' from " + Me.Proj + "_student where '" + TextBox1.Text + "' in (select SID from " + Me.Proj + "_student)") = "True" Then
                If TextBox2.Text = esstr_exe("select HKID from " + Me.Proj + "_student where SID ='" + TextBox1.Text + "'") Then
                    Panel1.Visible = False
                    Panel2.Visible = True
                    Dim dt As New DataTable
                    Dim cmdstr As String = "select s.SID, Name, Class, Class_No, Sex, DOB, House_Name, Grade from " + Me.Proj + "_student s, " + Me.Proj + "_house h, (select SID, 'C' as Grade from " + Me.Proj + "_student where DOB between (select subdate((b_grade_time),-1) from SDMCompInfo where proj_code ='" + Me.Proj + "') and (select c_grade_time from SDMCompInfo where proj_code ='" + Me.Proj + "') union select SID, 'B' as Grade from " + Me.Proj + "_student where DOB between (select subdate((a_grade_time),-1) from SDMCompInfo where proj_code ='" + Me.Proj + "') and (select b_grade_time from SDMCompInfo where proj_code ='" + Me.Proj + "') union select SID, 'A' as Grade from " + Me.Proj + "_student where DOB between '1980/1/1' and (select a_grade_time from SDMCompInfo where proj_code ='" + Me.Proj + "')) g where s.SID=g.SID and s.House=h.House_Code and s.SID ='" + TextBox1.Text + "'"
                    Me.fill_table(cmdstr, dt)
                    sid = dt.Rows(0)("SID")
                    grade = dt.Rows(0)("Grade")
                    sex = dt.Rows(0)("Sex")
                    RichTextBox1.Text = "Name: " + dt.Rows(0)("Name") + vbNewLine + "Class: " + dt.Rows(0)("Class") + vbNewLine + "Class No: " + dt.Rows(0)("Class_No")
                    cmdstr = "select * from " + Me.Proj + "_eventregister where SID ='" + sid + "'"
                    dt.Clear()
                    Me.fill_table(cmdstr, dt)
                    ComboBox2.Text = Me.esstr_exe("select Event_Name from " + Me.Proj + "_event where Event_Code ='" + dt.Rows(0)("Event1") + "'")
                    ComboBox3.Text = Me.esstr_exe("select Event_Name from " + Me.Proj + "_event where Event_Code ='" + dt.Rows(0)("Event2") + "'")
                    ComboBox4.Text = Me.esstr_exe("select Event_Name from " + Me.Proj + "_event where Event_Code ='" + dt.Rows(0)("Event3") + "'")
                    ReDim e_code(1000)
                    read_event(e_code, ComboBox2)
                    ReDim e_code2(1000)
                    read_event(e_code2, ComboBox3)
                    ReDim e_code3(1000)
                    read_event(e_code3, ComboBox4)
                Else
                    MsgBox("Incorrect Password")
                End If
            Else
                MsgBox("User Not Found")
            End If
        End If
    End Sub
    Sub read_event(ByVal code() As String, ByVal combo As ComboBox)
        Dim readt As New DataTable
        Dim cmdstr As String = "select Event_code, Event_Name from " + Me.Proj + "_event where Event_Code <> '100NNN' and Grade ='" + grade + "' and Sex ='" + sex + "' order by Event_Code"
        Me.fill_table(cmdstr, readt)
        combo.Items.Clear()
        For j = 0 To readt.Rows.Count - 1
            combo.Items.Add(readt.Rows(j)("Event_Name"))
            code(j) = readt.Rows(j)("Event_Code")
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        While Not csr.EndOfStream
            data(i) = csr.ReadLine
            i += 1
        End While
        csr.Close()
        ds = data(0)
        ui = data(1)
        pwd = data(2)
        db = data(3)
        Proj = data(4)
        myConnectionString = "Database=" + db + ";Data Source=" + ds + ";User Id=" + ui + ";Password=" + pwd
    End Sub
    Sub fill_table(ByVal cmd As String, ByRef dt As DataTable)
        Using cn As New MySqlConnection(myConnectionString)
            cn.Open()
            Debug.Print(cmd)
            Dim da As New MySqlDataAdapter(cmd, cn)
            da.Fill(dt)
        End Using
    End Sub
    Function esstr_exe(ByVal cmd As String) As String
        Using cn As New MySqlConnection(myConnectionString)
            cn.Open()
            Debug.Print(cmd)
            Dim cmdexe = New MySqlCommand(cmd, cn)
            Return cmdexe.ExecuteScalar()
        End Using
    End Function
    Sub enq_exe(ByVal cmd As String)
        Using cn As New MySqlConnection(myConnectionString)
            cn.Open()
            Dim cmdexe = New MySqlCommand(cmd, cn)
            cmdexe.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Panel2.Visible = False
        Panel1.Visible = True
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cmdstr As String = "update " + Me.Proj + "_eventregister set Event1='" + e_code(ComboBox2.SelectedIndex) + "', Event2='" + e_code2(ComboBox3.SelectedIndex) + "', Event3='" + e_code3(ComboBox4.SelectedIndex) + "' where SID='" + sid + "'"
        enq_exe(cmdstr)
        MsgBox("Successfully registered events")
        Panel2.Visible = False
        Panel1.Visible = True
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class
