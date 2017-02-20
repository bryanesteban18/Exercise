Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()
        ListBox1.Items.Add(OpenFileDialog1.FileName)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim File As System.IO.StreamWriter
        ListBox1.Items.Add(TextBox1.Text)
        File = My.Computer.FileSystem.OpenTextFileWriter(TextBox1.Text, True)
        Form2.Show()
    End Sub
End Class
