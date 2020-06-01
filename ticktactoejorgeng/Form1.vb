Public Class Form1
    Dim a As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        a = 2
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        a = 3
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        a = 4
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        a = 5
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        a = 6
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        a = 7
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        a = 8
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        a = 9
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Button10.Enabled = False
        Button11.Enabled = True
        If a = 1 Then
            Button1.Text = "X"
            Button1.Enabled = False
        End If
        If a = 2 Then
            Button2.Text = "X"
            Button2.Enabled = False
        End If
        If a = 3 Then
            Button3.Text = "X"
            Button3.Enabled = False
        End If
        If a = 4 Then
            Button4.Text = "X"
            Button4.Enabled = False
        End If
        If a = 5 Then
            Button5.Text = "X"
            Button5.Enabled = False
        End If
        If a = 6 Then
            Button6.Text = "X"
            Button6.Enabled = False
        End If
        If a = 7 Then
            Button7.Text = "X"
            Button7.Enabled = False
        End If
        If a = 8 Then
            Button8.Text = "X"
            Button8.Enabled = False
        End If
        If a = 9 Then
            Button9.Text = "X"
            Button9.Enabled = False
        End If
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            MsgBox("Gano jugador X")
            Button12.Enabled = True
        End If
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            MsgBox("Gano jugador X")
            Button12.Enabled = True
        End If
        If Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            MsgBox("Gano jugador X")
            Button12.Enabled = True
        End If
        If Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            MsgBox("Gano jugador X")
            Button12.Enabled = True
        End If
        If Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            MsgBox("Gano jugador X")
            Button12.Enabled = True
        End If
        If Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            MsgBox("Gano jugador X")
            Button12.Enabled = True
        End If
        If Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            MsgBox("Gano jugador X")
            Button12.Enabled = True
        End If
        If Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            MsgBox("Gano jugador X")
            Button12.Enabled = True
        End If
        If Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            MsgBox("Gano jugador X")
            Button12.Enabled = True
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Button10.Enabled = True
        Button11.Enabled = False
        If a = 1 Then
            Button1.Text = "o"
            Button1.Enabled = False
        End If
        If a = 2 Then
            Button2.Text = "o"
            Button2.Enabled = False
        End If
        If a = 3 Then
            Button3.Text = "o"
            Button3.Enabled = False
        End If
        If a = 4 Then
            Button4.Text = "o"
            Button4.Enabled = False
        End If
        If a = 5 Then
            Button5.Text = "o"
            Button5.Enabled = False
        End If
        If a = 6 Then
            Button6.Text = "o"
            Button6.Enabled = False
        End If
        If a = 7 Then
            Button7.Text = "o"
            Button7.Enabled = False
        End If
        If a = 8 Then
            Button8.Text = "o"
            Button8.Enabled = False
        End If
        If a = 9 Then
            Button9.Text = "o"
            Button9.Enabled = False
        End If
        If Button1.Text = "o" And Button2.Text = "o" And Button3.Text = "o" Then
            MsgBox("Gano jugador o")
            Button12.Enabled = True
        End If
        If Button4.Text = "o" And Button5.Text = "o" And Button6.Text = "o" Then
            MsgBox("Gano jugador o")
            Button12.Enabled = True
        End If
        If Button7.Text = "o" And Button8.Text = "o" And Button9.Text = "o" Then
            MsgBox("Gano jugador o")
            Button12.Enabled = True
        End If
        If Button1.Text = "o" And Button4.Text = "o" And Button7.Text = "o" Then
            MsgBox("Gano jugador o")
            Button12.Enabled = True
        End If
        If Button2.Text = "o" And Button5.Text = "o" And Button8.Text = "o" Then
            MsgBox("Gano jugador o")
            Button12.Enabled = True
        End If
        If Button3.Text = "o" And Button6.Text = "o" And Button9.Text = "o" Then
            MsgBox("Gano jugador o")
            Button12.Enabled = True
        End If
        If Button1.Text = "o" And Button5.Text = "o" And Button9.Text = "o" Then
            MsgBox("Gano jugador o")
            Button12.Enabled = True
        End If
        If Button3.Text = "o" And Button5.Text = "o" And Button7.Text = "o" Then
            MsgBox("Gano jugador o")
            Button12.Enabled = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button12.Enabled = False
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button10.Enabled = True
        Button11.Enabled = True
        Button12.Enabled = False
    End Sub
End Class
