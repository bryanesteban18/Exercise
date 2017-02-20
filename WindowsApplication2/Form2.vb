Public Class Form2

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As Integer
        a = ListBox1.SelectedIndex
        ListBox1.Items.Remove(ListBox1.Items.Item(a).ToString)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(DateTimePicker1.Text + ",  " + TextBox1.Text + ",  " + MaskedTextBox1.Text + ",  " + MaskedTextBox2.Text + ",  " + TrackBar1.Text)
        DateTimePicker1.ResetText()
        TextBox1.Clear()
        MaskedTextBox1.Clear()
        MaskedTextBox2.Clear()
        TrackBar1.ResetText()

    End Sub
End Class