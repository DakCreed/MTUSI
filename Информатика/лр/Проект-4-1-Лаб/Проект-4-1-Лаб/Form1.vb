Option Strict On
Option Explicit On
Imports System.Math

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Single, B As Single, C As Single
        Dim P As Single, Pp As Single, S As Single
        B = CSng((TextBox4.Text)) 'Присваивание переменной В значения поля TextBox2
        A = CSng(TextBox3.Text) 'Присваивание переменной А значения поля TextBox1
        C = CSng(TextBox5.Text) 'Присваивание переменной С значения поля TextBox3
        P = (A + B + C)   'Вычисление периметра и присваивание значения Р
        Pp = P / 2        'Вычисление полуперим. и присваивание значения Рр
        S = CSng((Sqrt(Pp * (Pp - A) * (Pp - B) * (Pp - C))))
        'Вычисление площади и присваивание значения переменной S
        TextBox1.Text = CStr(P)
        'Вывод значения полупериметра в текстовое поле TextBox4
        TextBox2.Text = CStr(S)
        'Вывод значения площади в текстовое поле TextBox5.


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
