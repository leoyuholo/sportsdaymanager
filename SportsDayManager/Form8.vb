Public Class Form8

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmdstr As String = "select Name, Author, Description from SDMProj where Proj_code ='" + Form1.Proj + "'"
        Dim dt As New DataTable
        Form1.fill_table(cmdstr, dt)
        TextBox1.Text = dt.Rows(0)("Name")
        TextBox2.Text = dt.Rows(0)("Author")
        RichTextBox1.Text = dt.Rows(0)("Description")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmdstr As String = "update SDMProj set Name ='" + TextBox1.Text + "', Author ='" + TextBox2.Text + "', Description ='" + RichTextBox1.Text + "' where Proj_code ='" + Form1.Proj + "'"
        Form1.enq_exe(cmdstr)
        If TextBox4.Text = TextBox5.Text Then
            If TextBox3.Text = Form1.esstr_exe("select pw from SDMProj where Proj_code ='" + Form1.Proj + "'") Then
                cmdstr = "update SDMProj set pw ='" + TextBox4.Text + "'"
                MsgBox("Updated successfully")
                Me.Close()
            Else
                MsgBox("Incorrect Password")
            End If
        Else
            MsgBox("Inconsistent Password Entered")
        End If
    End Sub
End Class