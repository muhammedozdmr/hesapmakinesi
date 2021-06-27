Public Class Form1

    Dim a, b, hafıza As Decimal
    Dim işlem As Char
    Dim durum, durum2, sayı As Boolean

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        a = 0
        b = 0
        TextBox1.Text = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click
        If durum = True Then
            a = CDec(TextBox1.Text)
            TextBox1.Text = sender.text
            durum = False
            durum2 = True
        Else
            TextBox1.Text = TextBox1.Text + sender.text

        End If
        sayı = True

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click

    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        If durum2 = True Then
            b = CDec(TextBox1.Text)

        End If

        If işlem = "+" Then TextBox1.Text = a + b
        If işlem = "-" Then TextBox1.Text = a - b
        If işlem = "*" Then TextBox1.Text = a * b
        If işlem = "/" Then TextBox1.Text = a / b

        işlem = "/"
        durum = True

    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        If durum2 = True Then
            b = CDec(TextBox1.Text)

        End If



        If işlem = "+" Then TextBox1.Text = a + b
        If işlem = "-" Then TextBox1.Text = a - b
        If işlem = "*" Then TextBox1.Text = a * b
        If işlem = "/" Then TextBox1.Text = a / b

        işlem = "*"
        durum = True

    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        If durum2 = True Then
            b = CDec(TextBox1.Text)

        End If



        If işlem = "+" Then TextBox1.Text = a + b
        If işlem = "-" Then TextBox1.Text = a - b
        If işlem = "*" Then TextBox1.Text = a * b
        If işlem = "/" Then TextBox1.Text = a / b

        işlem = "-"
        durum = True

    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        If durum2 = True Then
            b = CDec(TextBox1.Text)

        End If



        If işlem = "+" Then TextBox1.Text = a + b
        If işlem = "-" Then TextBox1.Text = a - b
        If işlem = "*" Then TextBox1.Text = a * b
        If işlem = "/" Then TextBox1.Text = a / b

        işlem = "+"
        durum = True

    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        If durum2 = True Then


            b = CDec(TextBox1.Text)


            If işlem = "+" Then TextBox1.Text = a + b
            If işlem = "-" Then TextBox1.Text = a - b
            If işlem = "*" Then TextBox1.Text = a * b
            If işlem = "/" Then TextBox1.Text = a / b
        End If
        durum2 = False
        işlem = ""

    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        On Error Resume Next
        TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)


    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        TextBox1.Text = 0

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If sayı = True Then
            TextBox1.Text = CDec(TextBox1.Text)

        End If
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        TextBox1.Text = Math.Sqrt(TextBox1.Text)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = -1 * TextBox1.Text

    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        TextBox1.Text = 1 / TextBox1.Text

    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        If durum2 = True Then
            b = CDec(TextBox1.Text)
            TextBox1.Text = a * b / 100

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        sayı = False
        If TextBox1.Text.IndexOf(",") = -1 Then
            TextBox1.Text = TextBox1.Text + ","
        Else
            Exit Sub
        End If

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        hafıza = "0"
        Label1.Text = " "

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        hafıza = TextBox1.Text
        Label1.Text = "M"


    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        TextBox1.Text = hafıza

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        TextBox1.Text = Val(TextBox1.Text) + hafıza


    End Sub
End Class
