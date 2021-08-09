Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ColourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColourToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            TextBox6.ForeColor = ColorDialog1.Color
            'opening the colour dialogue for the dispayed text'
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If fontDialog1.ShowDialog = DialogResult.OK Then
            TextBox6.Font = FontDialog1.Font
            'opening a font dialogue to change font size and styleof the displayed text'
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        'exit button closing form'
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox6.AppendText("   " + vbNewLine)
        TextBox6.AppendText(vbTab & Label1.Text + "   " + TextBox1.Text + vbNewLine)
        'this will display the first label and thetext written in the first text box'
        TextBox6.AppendText("   " + vbNewLine)
        'this line will insert a blank line for spacing'
        TextBox6.AppendText(vbTab & Label2.Text + "   " + TextBox2.Text + vbNewLine)
        'second label and second text box display...'
        TextBox6.AppendText("   " + vbNewLine)
        TextBox6.AppendText(vbTab & Label3.Text + "   " + TextBox3.Text + vbNewLine)
        TextBox6.AppendText("   " + vbNewLine)
        TextBox6.AppendText(vbTab & Label4.Text + "   " + TextBox4.Text + vbNewLine)
        TextBox6.AppendText("   " + vbNewLine)
        TextBox6.AppendText(vbTab & Label5.Text + "   " + TextBox5.Text + vbNewLine)
        TextBox6.AppendText("   " + vbNewLine)
        TextBox6.AppendText("   " + vbNewLine)
        'double spacing'
        TextBox6.AppendText(vbTab & Today & vbTab & TimeOfDay + vbNewLine)
        'this line will input the date and time of when the answers are written and displayed'
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim isave As New SaveFileDialog
        'declaring the variable isave'
        isave.Filter = "txt files (*.txt) |*.txt"
        'what it will be saved as'
        isave.FilterIndex = 2
        isave.RestoreDirectory = False

        If isave.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(isave.FileName, TextBox6.Text)

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class