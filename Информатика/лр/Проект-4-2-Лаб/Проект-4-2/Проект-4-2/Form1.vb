Imports System.Math
Public Class Form1

    Dim Birds As Short
    Dim Insects As Integer
    Dim WorldPop As Long
    Dim Price As Single
    Dim Pi As Double
    Dim Debt As Decimal
    Dim RetKey As Byte
    Dim UnicodeChar As Char
    Dim Dog As String
    Dim Flag As Boolean
    Dim Birthday As Date
    Dim LName = "Иванов"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim peremX As Double
        Dim peremY As Double
        Dim result As Double
        peremX = TextBox1.Text
        peremY = TextBox3.Text
        result = -((2 * peremX ^ 2) - Sin(peremX ^ 2) / (2 - Exp(-peremY)))
        TextBox2.Text = result

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
