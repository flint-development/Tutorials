Public Class Form1

    Public Property zahl As String = ""
    Public Property calc As String = ""


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SIEBEN.Click
        TB.Text += "7"

    End Sub

    Private Sub ACHT_Click(sender As Object, e As EventArgs) Handles ACHT.Click
        TB.Text += "8"

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles NULL.Click
        TB.Text += "0"

    End Sub

    Private Sub EINS_Click(sender As Object, e As EventArgs) Handles EINS.Click
        TB.Text += "1"

    End Sub

    Private Sub ZWEI_Click(sender As Object, e As EventArgs) Handles ZWEI.Click
        TB.Text += "2"

    End Sub

    Private Sub DREI_Click(sender As Object, e As EventArgs) Handles DREI.Click
        TB.Text += "3"

    End Sub

    Private Sub VIER_Click(sender As Object, e As EventArgs) Handles VIER.Click
        TB.Text += "4"

    End Sub

    Private Sub FÜNF_Click(sender As Object, e As EventArgs) Handles FÜNF.Click
        TB.Text += "5"

    End Sub

    Private Sub SECHS_Click(sender As Object, e As EventArgs) Handles SECHS.Click
        TB.Text += "6"

    End Sub

    Private Sub NEUN_Click(sender As Object, e As EventArgs) Handles NEUN.Click
        TB.Text += "9"

    End Sub

    Private Sub DEL_Click(sender As Object, e As EventArgs) Handles DEL.Click
        If (TB.Text.Length > 0) Then
            TB.Text = TB.Text.Substring(0, TB.Text.Length - 1)
        End If

    End Sub

    Private Sub AC_Click(sender As Object, e As EventArgs) Handles AC.Click
        calc = ""
        zahl = ""
        TB.Text = ""

        lbl2.Text = ""

    End Sub

    Private Sub GLEICH_Click(sender As Object, e As EventArgs) Handles GLEICH.Click
        If (calc = "+") Then
            TB.Text = Val(zahl) + Val(TB.Text)
        End If
        If (calc = "-") Then
            TB.Text = Val(zahl) - Val(TB.Text)
        End If
        If (calc = "*") Then
            TB.Text = Val(zahl) * Val(TB.Text)
        End If
        If (calc = "/") Then
            TB.Text = Val(zahl) / Val(TB.Text)
        End If


        lbl2.Text = ""


    End Sub

    Private Sub MAL_Click(sender As Object, e As EventArgs) Handles MAL.Click
        zahl = TB.Text
        lbl2.Text = zahl
        TB.Text = ""

        calc = "*"

    End Sub

    Private Sub GETEILT_Click(sender As Object, e As EventArgs) Handles GETEILT.Click
        zahl = TB.Text
        lbl2.Text = zahl
        TB.Text = ""

        calc = "/"

    End Sub

    Private Sub PLUS_Click(sender As Object, e As EventArgs) Handles PLUS.Click
        zahl = TB.Text
        lbl2.Text = zahl
        TB.Text = ""

        calc = "+"

    End Sub

    Private Sub MINUS_Click(sender As Object, e As EventArgs) Handles MINUS.Click
        zahl = TB.Text
        lbl2.Text = zahl
        TB.Text = ""

        calc = "-"

    End Sub

    Private Sub KOMMA_Click(sender As Object, e As EventArgs) Handles KOMMA.Click
        TB.Text += ","

    End Sub

    Private Sub ROUND_Click(sender As Object, e As EventArgs) Handles ROUND.Click
        TB.Text = Math.Round(Val(TB.Text))

    End Sub

    Private Sub EINSdurchX_Click(sender As Object, e As EventArgs) Handles EINSdurchX.Click
        TB.Text = 1.0 / Val(TB.Text)

    End Sub

    Private Sub PI_Click(sender As Object, e As EventArgs) Handles PI.Click
        TB.Text = Math.PI

    End Sub

    Private Sub E_Click(sender As Object, e As EventArgs) Handles E.Click
        TB.Text = Math.E

    End Sub
End Class
