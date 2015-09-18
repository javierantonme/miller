Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class KARDEX

    Private Sub KARDEX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BUSCAR_TODOS()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dispose()

    End Sub

    Sub BUSCAR_TODOS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_CARDEX_TODOS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView1.DataSource = tabla
            conex.Close()
            DataGridView1.Columns(0).Width = 150
            DataGridView1.Columns(1).Width = 250
            DataGridView1.Columns(2).Width = 50
            DataGridView1.Columns(3).Width = 50
            DataGridView1.Columns(4).Width = 50
            DataGridView1.Columns(5).Width = 150
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub PREGUNTA1()
        If RB_CODIGO.Checked = True Then
            TB_INFO_FILTRO.Visible = True
            TB_COMBO_FOLTRO.Visible = False
        End If

        If RB_NOMBRE.Checked = True Then
            TB_INFO_FILTRO.Visible = True
            TB_COMBO_FOLTRO.Visible = False
        End If
        If RB_TIPO.Checked = True Then
            TB_INFO_FILTRO.Visible = False
            TB_COMBO_FOLTRO.Visible = True
        End If

    End Sub

    Private Sub RB_CODIGO_CheckedChanged(sender As Object, e As EventArgs) Handles RB_CODIGO.CheckedChanged
        PREGUNTA1()
    End Sub

    Private Sub RB_NOMBRE_CheckedChanged(sender As Object, e As EventArgs) Handles RB_NOMBRE.CheckedChanged
        PREGUNTA1()
    End Sub

    Private Sub RB_TIPO_CheckedChanged(sender As Object, e As EventArgs) Handles RB_TIPO.CheckedChanged
        PREGUNTA1()
    End Sub

    Sub BUSCAR_CODIGO()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_CARDEX_CODIGO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = TB_INFO_FILTRO.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView1.DataSource = tabla
            conex.Close()
            DataGridView1.Columns(0).Width = 150
            DataGridView1.Columns(1).Width = 250
            DataGridView1.Columns(2).Width = 50
            DataGridView1.Columns(3).Width = 50
            DataGridView1.Columns(4).Width = 50
            DataGridView1.Columns(5).Width = 150
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub BUSCAR_NOMBRE()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_CARDEX_NOMBRE", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = TB_INFO_FILTRO.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView1.DataSource = tabla
            conex.Close()
            DataGridView1.Columns(0).Width = 150
            DataGridView1.Columns(1).Width = 250
            DataGridView1.Columns(2).Width = 50
            DataGridView1.Columns(3).Width = 50
            DataGridView1.Columns(4).Width = 50
            DataGridView1.Columns(5).Width = 150
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub BUSCAR_TIPO()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_CARDEX_TIPO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@TIPO", SqlDbType.Int).Value = TB_COMBO_FOLTRO.SelectedIndex
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView1.DataSource = tabla
            conex.Close()
            DataGridView1.Columns(0).Width = 150
            DataGridView1.Columns(1).Width = 250
            DataGridView1.Columns(2).Width = 50
            DataGridView1.Columns(3).Width = 50
            DataGridView1.Columns(4).Width = 50
            DataGridView1.Columns(5).Width = 150
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub PREGUNTA2()
        If RB_CODIGO.Checked = True Then
            BUSCAR_CODIGO()
        End If

        If RB_NOMBRE.Checked = True Then
            BUSCAR_NOMBRE()
        End If
        If RB_TIPO.Checked = True Then
            BUSCAR_TIPO()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PREGUNTA2()
    End Sub
End Class