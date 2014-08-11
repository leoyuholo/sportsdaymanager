Public Class Form30

    Private Sub Form30_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refresh_load()
    End Sub
    Sub refresh_load()
        Dim cmdstr As String = "select * from SDMProj where Proj_code ='" + Form1.Proj + "'"
        Dim ps As New DataTable
        Form1.fill_table(cmdstr, ps)
        If Val(ps.Rows(0)("Stage_1")) = True Then
            GroupBox2.Enabled = True
            GroupBox3.Enabled = True
        Else
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
        End If
        If Val(ps.Rows(0)("Stage_2")) = True Then
            GroupBox4.Enabled = True
        Else
            GroupBox4.Enabled = False
        End If
        If Val(ps.Rows(0)("Stage_3")) = True Then
            GroupBox5.Enabled = True
        Else
            GroupBox5.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form6.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form17.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form18.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form19.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form20.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form22.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form23.Show()
    End Sub
End Class