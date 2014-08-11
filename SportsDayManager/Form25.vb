Public Class Form25

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form25_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form20.f20_dt.Rows(0)("no_of_days") = 2 Then
            RadioButton2.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Are you sure to clean the time table?", MsgBoxStyle.OkCancel, "Clean time table") = 1 Then
            If Val(TextBox2.Text) Mod 5 = 0 Then
                Dim nod As String
                Dim x, y As Integer
                Dim sex() As String = {"M", "F"}
                If RadioButton2.Checked = True Then
                    nod = 2
                Else
                    nod = 1
                End If
                Select Case Form20.f20_dt.Rows(0)("sex")
                    Case "B"
                        x = 0
                        y = 0
                    Case "G"
                        x = 1
                        y = 1
                    Case "C"
                        x = 0
                        y = 1
                End Select
                For i = x To y
                    If Form20.f20_dt.Rows(0)("a_grade") = 1 Then
                        Form20.add_eve2("", TextBox2.Text, TextBox3.Text, sex(i), "A", nod)
                    End If
                    If Form20.f20_dt.Rows(0)("b_grade") = 1 Then
                        Form20.add_eve2("", TextBox2.Text, TextBox3.Text, sex(i), "B", nod)
                    End If
                    If Form20.f20_dt.Rows(0)("c_grade") = 1 Then
                        Form20.add_eve2("", TextBox2.Text, TextBox3.Text, sex(i), "C", nod)
                    End If
                Next
                MsgBox("Cleaned Successfully")
                If RadioButton2.Checked = True Then
                    Form1.dgv_show(Form20.DataGridView4, "_timetableday2")
                Else
                    Form1.dgv_show(Form20.DataGridView2, "_timetableday1")
                End If
            Else
                MsgBox("Inappropriate value entered")
            End If
        End If
    End Sub
End Class