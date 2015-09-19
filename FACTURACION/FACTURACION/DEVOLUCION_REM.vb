Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class DEVOLUCION_REM
    Dim OID As Integer
    Private Sub DEVOLUCION_REM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BUSCAR_REMISIONES()

        TB_fECHA1.CustomFormat = "dd/MM/yyyy hh:mm:ss tt"
        TB_fECHA1.Format = DateTimePickerFormat.Custom

        TB_fECHA2.CustomFormat = "dd/MM/yyyy hh:mm:ss tt"
        TB_fECHA2.Format = DateTimePickerFormat.Custom
    End Sub

    Sub BUSCAR_REMISIONES()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_REMISIONES_TODAS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView1.DataSource = tabla
            conex.Close()
            DataGridView1.Columns(0).Width = 50
            DataGridView1.Columns(1).Width = 75
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 300
            DataGridView1.Columns(4).Width = 100
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub PREGUNTA_RB()
        If RB_CONSECUTIVO.Checked = True Then
            TB_FILTRO_INFO.Visible = True
            TB_fECHA1.Visible = False
            TB_fECHA2.Visible = False
            lb1.Visible = False
            lb2.Visible = False
        End If
        If RB_IDENTIFICACION.Checked = True Then
            TB_FILTRO_INFO.Visible = True
            TB_fECHA1.Visible = False
            TB_fECHA2.Visible = False
            lb1.Visible = False
            lb2.Visible = False
        End If
        If RB_CIENTE.Checked = True Then
            TB_FILTRO_INFO.Visible = True
            TB_fECHA1.Visible = False
            TB_fECHA2.Visible = False
            lb1.Visible = False
            lb2.Visible = False
        End If

        If RB_FECHA.Checked = True Then
            TB_FILTRO_INFO.Visible = False
            TB_fECHA1.Visible = True
            TB_fECHA2.Visible = True
            lb1.Visible = True
            lb2.Visible = True
        End If
    End Sub


    Private Sub RB_CONSECUTIVO_CheckedChanged(sender As Object, e As EventArgs) Handles RB_CONSECUTIVO.CheckedChanged
        PREGUNTA_RB()
    End Sub

    Private Sub RB_IDENTIFICACION_CheckedChanged(sender As Object, e As EventArgs) Handles RB_IDENTIFICACION.CheckedChanged
        PREGUNTA_RB()
    End Sub

    Private Sub RB_CIENTE_CheckedChanged(sender As Object, e As EventArgs) Handles RB_CIENTE.CheckedChanged
        PREGUNTA_RB()
    End Sub

    Private Sub RB_FECHA_CheckedChanged(sender As Object, e As EventArgs) Handles RB_FECHA.CheckedChanged
        PREGUNTA_RB()
    End Sub

    Sub BUSCAR_CONSECUTIVO()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_REMI_CONSECUTIVO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CONSECUTIVO", SqlDbType.Int).Value = TB_FILTRO_INFO.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView1.DataSource = tabla
            conex.Close()
            DataGridView1.Columns(0).Width = 50
            DataGridView1.Columns(1).Width = 75
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 300
            DataGridView1.Columns(4).Width = 100
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub BUSCAR_CEDULA()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_REMI_IDENTIFICACION", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CEDULA", SqlDbType.VarChar).Value = TB_FILTRO_INFO.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView1.DataSource = tabla
            conex.Close()
            DataGridView1.Columns(0).Width = 50
            DataGridView1.Columns(1).Width = 75
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 300
            DataGridView1.Columns(4).Width = 100
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub BUSCAR_NOMBRE()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_REMI_NOMBRE", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = TB_FILTRO_INFO.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView1.DataSource = tabla
            conex.Close()
            DataGridView1.Columns(0).Width = 50
            DataGridView1.Columns(1).Width = 75
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 300
            DataGridView1.Columns(4).Width = 100
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub BUSCAR_fECHAS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_REMI_FECHA", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@FECHA_INICIAL", SqlDbType.DateTime).Value = TB_fECHA1.Value
            cmd.Parameters.Add("@FECHA_FINAL", SqlDbType.DateTime).Value = TB_fECHA2.Value
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView1.DataSource = tabla
            conex.Close()
            DataGridView1.Columns(0).Width = 50
            DataGridView1.Columns(1).Width = 75
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 300
            DataGridView1.Columns(4).Width = 100
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub PREGUNTA2()
        If RB_CONSECUTIVO.Checked = True Then
            BUSCAR_CONSECUTIVO()
        End If
        If RB_IDENTIFICACION.Checked = True Then
            BUSCAR_CEDULA()
        End If
        If RB_CIENTE.Checked = True Then
            BUSCAR_NOMBRE()
        End If

        If RB_FECHA.Checked = True Then
            BUSCAR_fECHAS()
        End If
    End Sub

    Private Sub BTM_BUSCAR_Click(sender As Object, e As EventArgs) Handles BTM_BUSCAR.Click
        PREGUNTA2()
    End Sub

    Sub IMPRIMIR()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        If i <> -1 Then
            If DataGridView1.Rows(i).Selected = True Then
                OID = DataGridView1.Rows(i).Cells(0).Value.ToString()
                RP_REMISION2.OID = OID
                RP_REMISION2.Show()
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        IMPRIMIR()
    End Sub

    Sub DEVOLUCION()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        If i <> -1 Then
            If DataGridView1.Rows(i).Selected = True Then
                DEVOLUCION2.TB_NUMERO_REM.Text = DataGridView1.Rows(i).Cells(1).Value.ToString()
                DEVOLUCION2.OID = DataGridView1.Rows(i).Cells(0).Value.ToString()
                DEVOLUCION2.ShowDialog()
            End If
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        DEVOLUCION()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

        REMISIONES.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dispose()
    End Sub
End Class