Imports System
Imports System.IO
Public Class Form2
    Dim p_code(0) As String
    Dim dt As New DataTable
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim csr As StreamReader = New StreamReader("settings.txt")
        Dim ds, ui, pwd, db As String
        Dim data(20) As String
        Dim i As Integer
        While Not csr.EndOfStream
            data(i) = csr.ReadLine
            i += 1
        End While
        csr.Close()
        ds = data(0)
        ui = data(1)
        pwd = data(2)
        db = data(3)
        TextBox1.Text = ds
        TextBox2.Text = ui
        TextBox3.Text = pwd
        TextBox4.Text = db
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("Please Select a Project")
        Else
            If TextBox5.Text = "" Then
                MsgBox("Please Enter Password")
            ElseIf TextBox5.Text = Form1.esstr_exe("select PW from SDMProj where Proj_code ='" + p_code(ListBox1.SelectedIndex) + "'") Then
                Form1.Proj = p_code(ListBox1.SelectedIndex)
                Dim csw As StreamWriter = New StreamWriter("settings.txt")
                csw.WriteLine(TextBox1.Text)
                csw.WriteLine(TextBox2.Text)
                csw.WriteLine(TextBox3.Text)
                csw.WriteLine(TextBox4.Text)
                csw.WriteLine(p_code(ListBox1.SelectedIndex))
                csw.Close()
                Me.Close()
                Form1.Show()
            Else
                MsgBox("Incorrect Password")
            End If
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.myConnectionString = "Database=" + TextBox4.Text + ";" + "Data Source=" + TextBox1.Text + ";User Id=" + TextBox2.Text + ";Password=" + TextBox3.Text
        ListBoxReadName()
    End Sub
    Sub ListBoxReadName()
        dt.Clear()
        Dim cmdstr As String = "select Proj_code, Name from SDMProj where Proj_code <>'1000' order by Proj_code"
        Form1.fill_table(cmdstr, dt)
        ReDim p_code(10000)
        Me.ListBox1.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            ListBox1.Items.Add(dt.Rows(i)("Name"))
            p_code(i) = dt.Rows(i)("Proj_code")
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            Dim cmdstr As String = "select Author from SDMProj where Proj_code ='" + p_code(ListBox1.SelectedIndex) + "'"
            TextBox7.Text = Form1.esstr_exe(cmdstr)
            cmdstr = "select Description from SDMProj where Proj_code ='" + p_code(ListBox1.SelectedIndex) + "'"
            RichTextBox1.Text = Form1.esstr_exe(cmdstr)
            TextBox6.Text = ListBox1.SelectedItem
        End If
    End Sub
End Class