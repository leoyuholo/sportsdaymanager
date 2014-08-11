Imports System
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form15
    Dim csr As StreamReader = New StreamReader("settings.txt")
    Dim ds, ui, pwd, db As String
    Dim data(20) As String
    Dim i As Integer
    Dim myConnectionString As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
    End Sub

    Private Sub Form15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        While Not csr.EndOfStream
            data(i) = csr.ReadLine
            i += 1
        End While
        csr.Close()
        ds = data(4)
        ui = data(5)
        pwd = data(6)
        db = data(7)
        myConnectionString = "Database=" + db + ";Data Source=" + ds + ";User Id=" + ui + ";Password=" + pwd
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myConnectionString2 As String = "Database=" + TextBox4.Text + ";Data Source=" + TextBox1.Text + ";User Id=" + TextBox2.Text + ";Password=" + TextBox3.Text
        Using cn As New MySqlConnection(myConnectionString2)
            cn.Open()
            Dim table As String = TextBox5.Text
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("select * from " + table, cn)
            da.Fill(dt)
            Dim cmdstr As String
            Dim i As Integer
            If TextBox13.Text <> "" Then
                cmdstr = "insert into " + Form1.Proj + "_student(SID, Name, Sex, DOB, House, Class, Class_No, HKID, Emergency_Call_Phone_Number) value "
            Else
                cmdstr = "insert into " + Form1.Proj + "_student(SID, Name, Sex, DOB, House, Class, Class_No) value "
            End If
            For i = 0 To dt.Rows.Count - 1
                If TextBox13.Text <> "" Then
                    cmdstr = cmdstr + "('" + dt.Rows(i)(TextBox6.Text) + "','" + dt.Rows(i)(TextBox7.Text) + "','" + dt.Rows(i)(TextBox8.Text) + "', convert('" + dt.Rows(i)(TextBox9.Text) + "', date),'" + dt.Rows(i)(TextBox10.Text) + "','" + dt.Rows(i)(TextBox11.Text) + "','" + dt.Rows(i)(TextBox12.Text) + "','" + dt.Rows(i)(TextBox14.Text) + "','" + dt.Rows(i)(TextBox13.Text) + "'), "
                Else
                    cmdstr = cmdstr + "('" + dt.Rows(i)(TextBox6.Text) + "','" + dt.Rows(i)(TextBox7.Text) + "','" + dt.Rows(i)(TextBox8.Text) + "', convert('" + dt.Rows(i)(TextBox9.Text) + "',date),'" + dt.Rows(i)(TextBox10.Text) + "','" + dt.Rows(i)(TextBox11.Text) + "','" + dt.Rows(i)(TextBox12.Text) + "','" + dt.Rows(i)(TextBox14.Text) + "'), "
                End If
            Next
            Form1.enq_exe(cmdstr.Substring(0, cmdstr.Length - 2))
            Form1.dgv_show(Form6.DataGridView2, "_student", "*", "order by SID")
            Form6.Label29.Text = Form6.DataGridView2.Rows.Count & " Rows"
        End Using
        Me.Close()
    End Sub
End Class