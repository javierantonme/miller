Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class DEVOLUCION2
    Public OID As Integer
    Private Sub DEVOLUCION2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BUSCAR_REMISION()
    End Sub

    Sub BUSCAR_REMISION()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_ARTICULOS_REMISION", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@OID", SqlDbType.Int).Value = OID
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView1.DataSource = tabla
            conex.Close()
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 250
            DataGridView1.Columns(2).Width = 75
  
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub BUSCAR_ARTICULO()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_ARTICULOS_REMISION_2", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@OID", SqlDbType.Int).Value = OID
            cmd.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                TB_ARTICULO.Text = dr(1)
                TB_CANTIDAD.Text = dr(2)
                conex.Close()
            Else
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        If i <> -1 Then
            If DataGridView1.Rows(i).Selected = True Then
                TB_CODIGO.Text = DataGridView1.Rows(i).Cells(0).Value.ToString()
                BUSCAR_ARTICULO()
            End If
        End If
    End Sub

    Sub PREGUNTA_DEVOLUCION()
        If TB_dEVOLUCION.Text = TB_CANTIDAD.Text Then
            GUARDAR_KARDEK()
            ELIMINAR()
            BUSCAR_REMISION()
        Else
            If TB_dEVOLUCION.Text < TB_CANTIDAD.Text Then
                MODIFICAR_cANTIDAD_REMISION()
                GUARDAR_KARDEK()
                BUSCAR_REMISION()
            ElseIf TB_dEVOLUCION.Text > TB_CANTIDAD.Text Then

                MsgBox("Error no puede devolver mas de lo permitido", MsgBoxStyle.Critical)
            End If
        End If

    End Sub

    Sub ELIMINAR()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("ELIMINAR_REGISTRO_REMISION", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@OID", SqlDbType.Int).Value = OID
            cmd.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            conex.Open()
            cmd.ExecuteNonQuery()

            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub GUARDAR_KARDEK()
        Try
            If DataGridView1.Rows.Count > 0 Then
                Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
                Dim cmd As New SqlCommand("INGRESAR_CARDEX_INV2", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ARTICULO", SqlDbType.VarChar).Value = TB_CODIGO.Text
                cmd.Parameters.Add("@CANTMOV", SqlDbType.Int).Value = TB_dEVOLUCION.Text
                conex.Open()
                cmd.ExecuteNonQuery()
                '   MessageBox.Show("REGISTRO GUARDADO CORRECTAMENTE", "SISTEMA")
                conex.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CONFIRMAR()
    End Sub

    Sub MODIFICAR_cANTIDAD_REMISION()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("MODIFICAR_CANTIDAD_REMSION", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@OID", SqlDbType.Int).Value = OID
            cmd.Parameters.Add("@ARTICULO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            cmd.Parameters.Add("@CANTIDAD", SqlDbType.Int).Value = TB_dEVOLUCION.Text
            conex.Open()
            cmd.ExecuteNonQuery()

            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dispose()
    End Sub

    Sub CONFIRMAR()
        Dim Pregunta As Integer

        Pregunta = MsgBox("¿Esta Seguro que Quiere devolver este Producto?.", vbYesNo + vbExclamation + vbDefaultButton2, "Devolución.")

        If Pregunta = vbYes Then
            PREGUNTA_DEVOLUCION()
        End If
    End Sub
End Class