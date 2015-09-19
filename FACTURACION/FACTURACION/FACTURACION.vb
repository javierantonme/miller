Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms

Public Class FACTURACION

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        Dispose()
    End Sub

    Private Sub TB_ID_LostFocus(sender As Object, e As EventArgs) Handles TB_ID.LostFocus
        buscando2()
    End Sub

    Sub buscando2()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_CLIENTES_IDENTIFICACION", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IDENTIFICACION", SqlDbType.VarChar).Value = TB_ID.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                TB_NOMBRE.Text = dr(10)
                TB_DIRECCION.Text = dr(13)
                TB_TELEFONO.Text = dr(14)
                conex.Close()
            Else
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BT_REMISIONES_Click(sender As Object, e As EventArgs) Handles BT_REMISIONES.Click
        '   REMISONES_PENDIENTES.ShowDialog()

    End Sub
    
End Class
