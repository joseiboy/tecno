Imports System.Data.SqlClient
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim Usuarios As New SqlCommand("INSERT INTO Id_Usuarios values(" & TextBox1.Text & "," & TextBox2.Text & ")", con)
        Usuarios.ExecuteNonQuery()

        MsgBox("El Nombre " & TextBox2.Text & " se registro con exito")

    End Sub

    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) Handles btnmostrar.Click
        Try
            Dim da As New SqlDataAdapter("Select *from usuarios", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class