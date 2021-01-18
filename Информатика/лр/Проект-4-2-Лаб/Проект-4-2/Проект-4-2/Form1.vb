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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim LName As String
        LName = "Дрожжин"
        Label1.Text = LName

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                Birds = 12500
                Label3.Text = Birds
            Case 1
                Insects = 37500000
                Label3.Text = Insects
            Case 2
                WorldPop = 4800000004
                Label3.Text = WorldPop
            Case 3
                Price = 899.99
                Label3.Text = Price
            Case 4
                Pi = 3.1415926535
                Label3.Text = Pi
            Case 5
                Debt = 7600300.5
                Label3.Text = Debt
            Case 6
                RetKey = 13
                Label3.Text = RetKey
            Case 7
                UnicodeChar = "Д"
                Label3.Text = UnicodeChar
            Case 8
                Dog = "pointer"
                Label3.Text = Dog
            Case 9
                Flag = True
                Label3.Text = Flag
            Case 10
                Birthday = #3/1/1963#
                Label3.Text = Birthday
            Case 8
                Dog = "pointer"
                Label3.Text = Dog
            Case 9
                Flag = True
                Label3.Text = Flag
            Case 10
                Birthday = #3/1/1963#
                Label3.Text = Birthday
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Short")
        ListBox1.Items.Add("Integer")
        ListBox1.Items.Add("Long")
        ListBox1.Items.Add("Single")
        ListBox1.Items.Add("Double")
        ListBox1.Items.Add("Decimal")
        ListBox1.Items.Add("Byte")
        ListBox1.Items.Add("Char")
        ListBox1.Items.Add("String")
        ListBox1.Items.Add("Boolean")
        ListBox1.Items.Add("Date")

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
