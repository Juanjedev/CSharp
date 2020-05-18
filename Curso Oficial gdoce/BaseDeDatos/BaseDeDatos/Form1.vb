Imports System.Data.SqlClient

Public Class Form1

    'Linea de conexion eliminada parcialmente por motivos de seguridad e icompatibilidad de valores
    Dim conexion As New SqlConnection("Data Source=DESKTOP-6OTG8RF\SQLEXPRESS;Initial Catalog=AsociacionDB;Integrated Security=True")
    Dim sentencia, mensaje As String
    Sub Mostrar()

        Dim da As New SqlDataAdapter("select * from Socios1", conexion)
        Dim ds As New DataSet

        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        conexion.Close()

    End Sub

    Sub EjecutarSql(sql As String, msg As String)

        Try
            Dim cmd As New SqlCommand(sql, conexion)
            conexion.Open()
            cmd.ExecuteNonQuery()
            conexion.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Mostrar()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sentencia = "insert into Socios1 values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')"
        mensaje = "Datos agregados correctamente"
        EjecutarSql(sentencia, mensaje)

    End Sub
End Class
