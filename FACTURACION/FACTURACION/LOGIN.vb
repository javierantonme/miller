Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class LOGIN
    Public OID As Integer
    Public USUARIO, NOMBRE As String
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        LOGIN()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub LOGIN()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INICIO_DE_SESSION", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = TB_USUARIO.Text
            cmd.Parameters.Add("@CONTRASEÑA", SqlDbType.VarChar).Value = TB_CONTRASEÑA.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                OID = dr(0)
                NOMBRE = dr(2)
                USUARIO = dr(3)
                MENU1.Show()
                Me.Hide()
                conex.Close()
            Else
                MsgBox("Error de Usuario y / o Contraseña")
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
