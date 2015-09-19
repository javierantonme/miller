Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class REMISIONES
    Dim IVA_DB, IVA2, SUB_TOTAL, TOTALL, OID As Integer

    Private Sub BTM_SALIR_Click(sender As Object, e As EventArgs) Handles BTM_SALIR.Click
        Dispose()
    End Sub

    Private Sub REMISIONES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BUSCAR_BODEGA()
    End Sub

    Sub buscando2()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_CLIENTES_IDENTIFICACION", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IDENTIFICACION", SqlDbType.VarChar).Value = TB_IDENTIFICACION.Text
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

    Private Sub TB_IDENTIFICACION_LostFocus(sender As Object, e As EventArgs) Handles TB_IDENTIFICACION.LostFocus
        buscando2()
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
                LB_PRESENTACION.Text = dr(4)
                TB_CANTIDAD_ACTUAL.Text = dr(5)
                conex.Close()
            Else
                conex.Close()
            End If
        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub LB_INFO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_INFO.SelectedIndexChanged
        buscando3()
        ' MsgBox(LB_INFO.Text)
    End Sub
    Sub CARGAR()
        CALCULOS()
        Me.DataGridView1.Rows.Add(TB_CODIGO.Text, TB_ARTICULO.Text, TB_CANTIDAD_VENTA.Text, TB_PRECIO.Text, SUB_TOTAL)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VALIDACIONES()
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "Eliminar" Then
            'eliminar row
            DataGridView1.Rows.RemoveAt(e.RowIndex)
        End If

        '     RECALCULAR()
    End Sub
    Sub CALCULOS()

        SUB_TOTAL = Val(TB_CANTIDAD_VENTA.Text * TB_PRECIO.Text)
        IVA2 = Val(SUB_TOTAL * IVA_DB) / 100
        TOTALL = IVA2 + SUB_TOTAL
    End Sub

   

    Sub RECALCULAR()
        Try
            If DataGridView1.Rows.Count > 0 Then
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    DataGridView1.Rows(i).Cells(4).Value = (DataGridView1.Rows(i).Cells(0).Value * DataGridView1.Rows(i).Cells(3).Value)
                    DataGridView1.Rows(i).Cells(5).Value = (DataGridView1.Rows(i).Cells(4).Value * 16) / 100
                    DataGridView1.Rows(i).Cells(6).Value = (DataGridView1.Rows(i).Cells(4).Value + DataGridView1.Rows(i).Cells(5).Value)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MsgBox(4)
        End Try
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        '    RECALCULAR()
    End Sub

    Sub VALIDACIONES()
        If Val(TB_CANTIDAD_VENTA.Text) > Val(TB_CANTIDAD_ACTUAL.Text) Then
            MsgBox("NO hay existencia suficientes para esta remision")
        Else
            CARGAR()
        End If
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

    Sub GUARDAR_CABECERA()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_REMISIONESC", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CLIENTE", SqlDbType.VarChar).Value = TB_IDENTIFICACION.Text
            conex.Open()
            cmd.ExecuteNonQuery()
            GUARDAR_DETALLE()
            GUARDAR_MOVIMIENTO()
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub GUARDAR_DETALLE() 'INGRESAR_INVENTARIO_INICIAL
        Try
            If DataGridView1.Rows.Count > 0 Then
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
                    Dim cmd As New SqlCommand("INGRESAR_REMISIONESD", conex)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ARTICULO", SqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(0).Value.ToString()
                    cmd.Parameters.Add("@CANTIDAD", SqlDbType.Int).Value = DataGridView1.Rows(i).Cells(2).Value.ToString()
                    cmd.Parameters.Add("@VALOR", SqlDbType.Int).Value = DataGridView1.Rows(i).Cells(4).Value.ToString()
                    conex.Open()
                    cmd.ExecuteNonQuery()
                    conex.Close()
                Next
            End If
            MessageBox.Show("REGISTRO GUARDADO CORRECTAMENTE", "SISTEMA")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub GUARDAR_MOVIMIENTO()
        Try
            If DataGridView1.Rows.Count > 0 Then
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
                    Dim cmd As New SqlCommand("INGRESAR_CARDEX", conex)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ARTICULO", SqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(0).Value.ToString()
                    cmd.Parameters.Add("@CARCONCEP", SqlDbType.Int).Value = 1
                    cmd.Parameters.Add("@CANTMOV", SqlDbType.Int).Value = DataGridView1.Rows(i).Cells(2).Value.ToString()
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
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        GUARDAR_CABECERA()
        BUSCAR_LAS_OID_REPORT()
        Dispose()
        RP_REMISION2.Show()
        ' DEVOLUCION_REM.Dispose()
        REPORT_REMISION.WindowState = FormWindowState.Maximized
    End Sub

    Sub BUSCAR_LAS_OID_REPORT()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_LAST_OID_REPORT", conex)
            cmd.CommandType = CommandType.StoredProcedure
            ' cmd.Parameters.Add("@ARTDESCRI", SqlDbType.NVarChar).Value = LB_INFO.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                OID = dr(0)
                RP_REMISION2.OID = OID
                conex.Close()
            Else
                conex.Close()
            End If
        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try
    End Sub

End Class