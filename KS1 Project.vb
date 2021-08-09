Public Class Homepage
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles name1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Hello " & name1.Text & ". Are you ready to learn? Please choose from the options above.")
        'when done is clicked this will pop up welcoming them this is the code'


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub nameTxt_Click(sender As Object, e As EventArgs) Handles nameTxt.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Browser.Show()
        'opens the web browser form'
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form5.Show()
        'opens up the read and write form'
    End Sub

    Private Sub Calculator_Click(sender As Object, e As EventArgs) Handles Calculator.Click
        Calculator1.Show()
        'opens up the calculator form'

    End Sub
End Class