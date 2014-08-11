Public Class Form27
    Public h_code(0) As String
    Private Sub Form27_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmdstr As String = "select House_Code, House_Name from " + Form1.Proj + "_house"
        Dim dt As New DataTable
        ComboBox1.Items.Clear()
        ComboBox1.ResetText()
        ReDim h_code(100)
        Form1.fill_table(cmdstr, dt)
        For i = 0 To dt.Rows.Count - 1
            ComboBox1.Items.Add(dt.Rows(i)("House_Name"))
            h_code(i) = dt.Rows(i)("House_Code")
        Next
        Form1.dgv_show(Me.DataGridView1, "_adjusthousescore")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = Form1.esstr_exe("select pw from SDMProj where Proj_Code ='" + Form1.Proj + "'") Then
            Dim cmdstr As String = "update " + Form1.Proj + "_adjusthousescore set Adjustment ='" + TextBox1.Text + "' where House_Code ='" + h_code(ComboBox1.SelectedIndex) + "'"
            Form1.enq_exe(cmdstr)
            Form1.dgv_show(Me.DataGridView1, "_adjusthousescore")
            TextBox1.Clear()
            TextBox2.Clear()
        Else
            MsgBox("Incorrect Password")
        End If
    End Sub
End Class