Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Module conexion
    Public con As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public Tabla As SqlDataAdapter
    Public estado As String

    Sub abrir()
        Try
            con = New SqlConnection("Data Source=DESKTOP-3ANL4RV;Initial Catalog=logingg;Integrated Security=True")
            con.Open()
            estado = "Conectado"
        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
        End Try
    End Sub

    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select * from usuarios where Nombre='" & nombreUsuario & "'", con)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function contrasena(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select Contraseña from usuarios where Nombre='" & nombreUsuario & "'", con)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("Contraseña")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function


    Function ConsultarTipoUsuario(ByVal nombreUsuario As String) As Integer
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select Roll from usuarios where Nombre='" & nombreUsuario & "'", con)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = CInt(respuesta.Item("Roll"))
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function


End Module
