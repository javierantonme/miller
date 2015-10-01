Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms

Public Class FACTURACION
    Public IVA_DB, IVA2, SUB_TOTAL, TOTALL, OID, TotalFinal As Integer

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
                BT_REMISIONES.Enabled = True
                TB_NOMBRE.Text = dr(10)
                TB_DIRECCION.Text = dr(13)
                TB_TELEFONO.Text = dr(14)
                Button1.Enabled = True
                conex.Close()
            Else
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
            DataGridView1.Columns(0).Width = 75
            DataGridView1.Columns(1).Width = 175
            DataGridView1.Columns(2).Width = 150
            DataGridView1.Columns(3).Width = 75
            DataGridView1.Columns(4).Width = 75
            DataGridView1.Columns(5).Width = 75
            DataGridView1.Columns(6).Width = 75
            DataGridView1.Columns(7).Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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

    Sub VALIDACIONES()
        If Val(TB_CANTIDAD_VENTA.Text) > Val(TB_CANTIDAD_ACTUAL.Text) Then
            MsgBox("NO hay existencia suficientes para esta remision")
        Else
            CARGAR()
        End If
    End Sub
    Sub CARGAR()
        CALCULOS()
        Me.DataGridView2.Rows.Add(TB_CODIGO.Text, TB_ARTICULO.Text, TB_CANTIDAD_VENTA.Text, TB_PRECIO.Text, SUB_TOTAL, IVA_DB, TOTALL)
    End Sub
    Sub CALCULOS()

        SUB_TOTAL = Val(TB_CANTIDAD_VENTA.Text * TB_PRECIO.Text)
        IVA2 = Val(SUB_TOTAL * IVA_DB) / 100
        TOTALL = IVA2 + SUB_TOTAL
    End Sub
    Sub GUARDAR_MOVIMIENTO()
        Try
            If DataGridView2.Rows.Count > 0 Then
                For i As Integer = 0 To DataGridView2.Rows.Count - 1
                    Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
                    Dim cmd As New SqlCommand("INGRESAR_CARDEX_FACTURACION", conex)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ARTICULO", SqlDbType.VarChar).Value = DataGridView2.Rows(i).Cells(0).Value.ToString()
                    cmd.Parameters.Add("@CARCONCEP", SqlDbType.Int).Value = 5
                    cmd.Parameters.Add("@CANTMOV", SqlDbType.Int).Value = DataGridView2.Rows(i).Cells(2).Value.ToString()
                    conex.Open()
                    cmd.ExecuteNonQuery()
                    DEVOLUCION_REM.BUSCAR_REMISIONES()
                    '   MessageBox.Show("REGISTRO GUARDADO CORRECTAMENTE", "SISTEMA")
                    conex.Close()
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CAMBIAR_ESTADO_REMISION()
        Try
            If DataGridView1.Rows.Count > 0 Then
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
                    Dim cmd As New SqlCommand("MODIFICAR_REMISIONC_ESTADO", conex)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@OID", SqlDbType.Int).Value = DataGridView1.Rows(i).Cells(0).Value
                    conex.Open()
                    cmd.ExecuteNonQuery()
                    DEVOLUCION_REM.BUSCAR_REMISIONES()
                    '   MessageBox.Show("REGISTRO GUARDADO CORRECTAMENTE", "SISTEMA")
                    conex.Close()
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub TOTALES()
        Try
            Dim Total1, Total2 As Single
            For Each row As DataGridViewRow In DataGridView1.Rows
                Total1 += Val(row.Cells(7).Value)
            Next
            For Each row As DataGridViewRow In DataGridView2.Rows
                Total2 += Val(row.Cells(6).Value)
            Next
            TotalFinal = Total1 + Total2
        Catch ex As Exception
            MessageBox.Show(ex.Message & "Error Funcion SUMA")
        End Try
    End Sub

    Private Sub FACTURACION_Load(sender As Object, e As EventArgs) Handles Me.Load
        BUSCAR_BODEGA()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VALIDACIONES()
    End Sub
    Private Sub LB_INFO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_INFO.SelectedIndexChanged
        buscando3()
    End Sub
    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        Dispose()
    End Sub

    Private Sub TB_ID_LostFocus(sender As Object, e As EventArgs) Handles TB_ID.LostFocus
        buscando2()
    End Sub
    Private Sub BT_REMISIONES_Click(sender As Object, e As EventArgs) Handles BT_REMISIONES.Click
        REMISIONES_PENDIENTES.ShowDialog()
    End Sub
    Private Sub TB_INFO_TextChanged(sender As Object, e As EventArgs) Handles TB_INFO.TextChanged
        PREGUNTA()
    End Sub
    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If DataGridView2.Columns(e.ColumnIndex).Name = "Eliminar" Then
            'eliminar row
            DataGridView2.Rows.RemoveAt(e.RowIndex)
        End If

        '     RECALCULAR()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        GUARDAR_MOVIMIENTO()
        CAMBIAR_ESTADO_REMISION()
        TOTALES()
        PAGOS.ShowDialog()
    End Sub
End Class
