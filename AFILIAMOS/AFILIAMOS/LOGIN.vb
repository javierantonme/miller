Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Public Class LOGIN


    Sub buscando_CLIENTE()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INICIO_DE_SESION", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = TB_USUARIO.Text
            cmd.Parameters.Add("@CONTRASEÑA", SqlDbType.VarChar).Value = TB_CONTRASEÑA.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                If Date.Now >= "01-10-2015 00:00:00" Then
                    MsgBox("El tiempo de Licencia Caduco")
                Else
                    MENU11.lb_usuario2.Text = "USUARIO: " + dr(2)
                    Me.Hide()
                    MENU11.ShowDialog()
                End If
            Else
                MsgBox("Error de Incio de Sesion")
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        buscando_CLIENTE()
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Dispose()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class


