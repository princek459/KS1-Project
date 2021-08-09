Public Class Calculator1

    Dim Firstnum As Decimal
    Dim Secondnum As Decimal
    Dim operations As Integer
    Dim operator_selector As Boolean = False
    'setting variables for the calculator'


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Answer.Text <> "0" Then
            Answer.Text += "6"
        Else
            Answer.Text = "6"
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Answer.Text <> "0" Then
            Answer.Text += "1"
        Else
            Answer.Text = "1"
        End If
        'code for the button rrepresenting "1" and copy and paste for buttons 1-9 but change the "" numbers'
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Answer.Text <> "0" Then
            Answer.Text += "2"
        Else
            Answer.Text = "2"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Answer.Text <> "0" Then
            Answer.Text += "3"
        Else
            Answer.Text = "3"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Answer.Text <> "0" Then
            Answer.Text += "4"
        Else
            Answer.Text = "4"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Answer.Text <> "0" Then
            Answer.Text += "5"
        Else
            Answer.Text = "5"
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Answer.Text <> "0" Then
            Answer.Text += "7"
        Else
            Answer.Text = "7"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Answer.Text <> "0" Then
            Answer.Text += "8"
        Else
            Answer.Text = "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Answer.Text <> "0" Then
            Answer.Text += "9"
        Else
            Answer.Text = "9"
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If Answer.Text <> "0" Then
            Answer.Text += "0"

        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Answer.Text = "0"
        'this is the code for C(cancel) will return the text box to 0 when clicked'

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If Not (Answer.Text.Contains(".")) Then
            Answer.Text += "."
        End If
        'code for the decimal point'
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Firstnum = Answer.Text
        Answer.Text = "0"
        operator_selector = True
        operations = 1
        'this is the code for the + operator'
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Firstnum = Answer.Text
        Answer.Text = "0"
        operator_selector = True
        operations = 2
        'this is the code for the - operator and relates to the variables declared at the top'
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Firstnum = Answer.Text
        Answer.Text = "0"
        operator_selector = True
        operations = 3
        'this is the code the multiplication variables'
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Firstnum = Answer.Text
        Answer.Text = "0"
        operator_selector = True
        operations = 4
        'this is the code for the division variables'
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If operator_selector = True Then
            Secondnum = Answer.Text
            If operations = 1 Then
                'in relation to the + button'
                Answer.Text = Firstnum + Secondnum
                'will print answer out'
            ElseIf operations = 2 Then
                'in relation to the - button'
                Answer.Text = Firstnum - Secondnum
            ElseIf operations = 3 Then
                'in relation to the * button'
                Answer.Text = Firstnum * Secondnum
            Else
                If Secondnum = 0 Then
                    Answer.Text = "Error!"
                    'because you cant multiply anything with zero so this will stop this
                Else
                    Answer.Text = Firstnum / Secondnum
                    'in relation to the / button'
                End If
                operator_selector = False
                '4th variable the boolean value'
            End If
        End If
        'this is the code for the = and also relates to the variables set at the top.
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles calc1.Click



    End Sub
End Class