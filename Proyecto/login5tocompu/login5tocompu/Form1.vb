Public Class Form1
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If usuarioRegistrado(TextBox1.Text) = True Then
                Dim contra As String = contrasena(TextBox1.Text)
                If contra.Equals(TextBox2.Text) = True Then
                    Me.Hide()
                    If ConsultarTipoUsuario(TextBox1.Text) = 1 Then
                        Me.Hide()
                        Form2.Show()
                        TextBox2.Text = ""
                        TextBox1.Text = ""

                    ElseIf ConsultarTipoUsuario(TextBox1.Text) = 2 Then
                        Me.Hide()
                        Form3.Show()
                        TextBox2.Text = ""
                        TextBox1.Text = ""

                    Else
                        Me.Hide()
                        Form4.Show()
                        TextBox2.Text = ""
                        TextBox1.Text = ""

                    End If

                Else
                    MsgBox("contraseña Invalida", MsgBoxStyle.Critical)

                End If
            Else
                MsgBox("El Usuario: " + TextBox1.Text + " No se encuentra registrado ")

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()
        If estado = "Conectado" Then
            Label3.Text = "Conectado"
        Else
            Label3.Text = "Desconectado"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
