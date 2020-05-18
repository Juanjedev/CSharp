Imports Matc
Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("Euro")
        ComboBox1.Items.Add("Dolar")

        ComboBox2.Items.Add("Dolar")
        ComboBox2.Items.Add("Euro")

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If Val(TextImporte.Text) >= 0 Then


            If ComboBox1.Text = "Euro" And ComboBox2.Text = "Dolar" Then

                LabelTotal.Text = Val(TextImporte.Text) * 1.08903

            ElseIf ComboBox1.Text = "Dolar" And ComboBox2.Text = "Euro" Then

                LabelTotal.Text = Val(TextImporte.Text) / 1.08903

            ElseIf ComboBox1.Text = ComboBox2.Text Then


                Error2.SetError(ComboBox2, "Los valores de conversion deben ser diferentes ")

            End If

        Else

                Error1.SetError(TextImporte, "Debe introducir valor mayor de 0")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Total.Click

    End Sub

    Private Sub TextImporte_TextChanged(sender As Object, e As EventArgs) Handles TextImporte.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub
End Class
