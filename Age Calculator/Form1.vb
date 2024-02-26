Option Strict On
Option Explicit On
Option Infer Off
Imports System.Security.AccessControl

Public Class Form1

    Private Age, Year As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Year = CInt(InputBox("Enter your birthyear!", "Prompt Year"))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Age = (2024 - Year)
        TextBox1.Text = CStr(Age) & " Years Old"
    End Sub
End Class
