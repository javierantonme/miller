Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms

Public Class FACTURACION
    Dim IVA_DB, IVA2, SUB_TOTAL, TOTALL, OID As Integer
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
                TB_NOMBRE.Enabled = True
                TB_DIRECCION.Enabled = True
                TB_TELEFONO.Enabled = True
                BT_REMISIONES.Enabled = True
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
        REMISIONES_PENDIENTES.ShowDialog()
    End Sub
    Sub cargarremisiones()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_REMISION", conex)
            cmd.CommandType = CommandType.StoredProcedure
            '  cmd.Parameters.Add("@REMISIONC", SqlDbType.VarChar).Value = OIDSELECCIONADOS
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView1.DataSource = tabla
            conex.Close()
            DataGridView1.Columns(0).Width = 150
            DataGridView1.Columns(1).Width = 150
            DataGridView1.Columns(2).Width = 150
            DataGridView1.Columns(3).Width = 150
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TB_INFO_TextChanged(sender As Object, e As EventArgs) Handles TB_INFO.TextChanged
        PREGUNTA()
    End Sub
    Sub PREGUNTA()
        If RB_CODIGO.Checked = True Then
            buscar_ARTICULO_CODIGO()
        ElseIf RB_DESCRIPCION.Checked = True Then
            buscar_ARTICULO_NOMBRE()
        End If
    End Sub
    Sub buscar_ARTICULO_NOMBRE()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_ARTICULO_II_REM", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = TB_INFO.Text
            'cmd.Parameters.Add("@BODEGA", SqlDbType.Int).Value = TB_BODEGA.SelectedValue
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            LB_INFO.DataSource = tabla
            LB_INFO.DisplayMember = ("ARTDESCRI")
            LB_INFO.ValueMember = ("OID")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub buscar_ARTICULO_CODIGO()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_ARTICULO_II_CODIGO_REM", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = TB_INFO.Text
            ' cmd.Parameters.Add("@BODEGA", SqlDbType.Int).Value = TB_BODEGA.SelectedValue
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            LB_INFO.DataSource = tabla
            LB_INFO.DisplayMember = ("ARTDESCRI")
            LB_INFO.ValueMember = ("OID")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub LB_INFO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_INFO.SelectedIndexChanged
        buscando3()
    End Sub
    Sub buscando3()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_ARTICULOIV", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ARTDESCRI", SqlDbType.NVarChar).Value = LB_INFO.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                TB_CODIGO.Text = dr(0)
                TB_ARTICULO.Text = dr(1)
                TB_PRECIO.Text = dr(2)
                IVA_DB = dr(3)
                '  LB_PRESENTACION.Text = dr(4)
                TB_CANTIDAD_ACTUAL.Text = dr(5)
                conex.Close()
            Else
                conex.Close()
            End If
        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try
    End Sub
    Sub BUSCAR_BODEGA()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_BODEGA_II", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = TB_INFO.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            TB_BODEGA.DataSource = tabla
            TB_BODEGA.DisplayMember = ("BODDESCRI")
            TB_BODEGA.ValueMember = ("OID")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub FACTURACION_Load(sender As Object, e As EventArgs) Handles Me.Load
        BUSCAR_BODEGA()
    End Sub
End Class
