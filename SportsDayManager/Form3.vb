Imports System
Imports System.IO
Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim csr As StreamReader = New StreamReader("settings.txt")
        Dim ds, ui, pwd, db As String
        Dim data(20) As String
        Dim i As Integer
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
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim csr As StreamReader = New StreamReader("settings.txt")
        Dim data(20) As String
        Dim i As Integer
        While Not csr.EndOfStream
            data(i) = csr.ReadLine
            i += 1
        End While
        csr.Close()
        Dim csw As StreamWriter = New StreamWriter("settings.txt")
        csw.WriteLine(data(0))
        csw.WriteLine(data(1))
        csw.WriteLine(data(2))
        csw.WriteLine(data(3))
        csw.WriteLine(TextBox1.Text)
        csw.WriteLine(TextBox2.Text)
        csw.WriteLine(TextBox3.Text)
        csw.WriteLine(TextBox4.Text)
        csw.Close()
        Form1.myConnectionString = "Database=" + TextBox4.Text + ";" + "Data Source=" + TextBox1.Text + ";User Id=" + TextBox2.Text + ";Password=" + TextBox3.Text
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MsgBox("Reset Connection Settings?", MsgBoxStyle.OkCancel, "Reset COnnection Settings") = 1 Then
            Dim csr As StreamReader = New StreamReader("settings.txt")
            Dim data(20) As String
            Dim i As Integer
            While Not csr.EndOfStream
                data(i) = csr.ReadLine
                i += 1
            End While
            csr.Close()
            TextBox1.Text = data(0)
            TextBox2.Text = data(1)
            TextBox3.Text = data(2)
            TextBox4.Text = data(3)
        End If
    End Sub
End Class