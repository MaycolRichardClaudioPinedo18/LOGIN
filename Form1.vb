﻿Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtemail.Text = "Maycol@senati.pe" And txtpassw.Text = "1234" Then
            Form3.Show()
        Else
            MsgBox("incorrecto")
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
