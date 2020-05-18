Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Me.ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Text = ""

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.AddRange(ListBox2.Items)
        ListBox2.Items.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUnoDF.Click

        For i = 0 To ListBox1.SelectedItems.Count - 1
            ListBox2.Items.Add(ListBox1.SelectedItems(i))
            ListBox1.Items.Remove(ListBox1.SelectedItems(i))
        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        For i = 0 To ListBox2.SelectedItems.Count - 1
            ListBox1.Items.Add(ListBox2.SelectedItems(i))
            ListBox2.Items.Remove(ListBox2.SelectedItems(i))
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnTodosDF.Click

        ListBox2.Items.AddRange(ListBox1.Items)
        ListBox1.Items.Clear()

    End Sub
End Class
