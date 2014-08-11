Public Class Form13

    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextBox1.Text = Form6.DataGridView3.CurrentRow.Cells(1).Value
        ComboBox1.Text = Form6.DataGridView3.CurrentRow.Cells(2).Value
        ComboBox2.Text = Form6.DataGridView3.CurrentRow.Cells(3).Value
        ComboBox3.Text = Form6.DataGridView3.CurrentRow.Cells(4).Value
        If Form6.DataGridView3.CurrentRow.Cells(5).Value = 1 Then
            CheckBox1.Checked = True
        End If
        TextBox2.Text = Form6.DataGridView3.CurrentRow.Cells(6).Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Then
            MsgBox("Please fill in all blanks.")
        Else
            Dim assign As Integer
            If CheckBox1.Checked = True Then
                assign = 1
            End If
            Dim e_code As String = Form6.DataGridView3.CurrentRow.Cells(0).Value
            e_code = e_code.Substring(0, 3)
            Dim e_str As String = e_code + ComboBox1.Text + ComboBox2.Text + ComboBox3.Text
            Dim cmdstr As String = "update " + Form1.Proj + "_event set Event_Code='" + e_str + "', Event_Name='" + TextBox1.Text + "', Grade='" + ComboBox1.Text + "', Sex='" + ComboBox2.Text + "', Field_or_Track='" + ComboBox3.Text + "', Assign_Lane='" + Trim(Str(assign)) + "', Holding_Area='" + TextBox2.Text + "' where Event_Code='" + Form6.DataGridView3.CurrentRow.Cells(0).Value + "'"
            Form1.enq_exe(cmdstr)
            MsgBox("Edited successfully")
            Form1.dgv_show(Form6.DataGridView3, "_event", "*", "where Event_Code <> '100NNN' order by Event_Code")
            Form6.Label30.Text = Form6.DataGridView3.Rows.Count & " Rows"
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        ComboBox3.ResetText()
        CheckBox1.ResetText()
        TextBox2.Clear()
    End Sub
End Class