Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class AJUSTE
    Dim TIPO As Integer
    Private Sub BTM_SALIR_Click(sender As Object, e As EventArgs) Handles BTM_SALIR.Click
        Dispose()
    End Sub

    Private Sub AJUSTE_Load(sender As Object, e As EventArgs) Handles Me.Load
        BUSCAR_BODEGA()
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

    Sub CARGAR()
        Me.DataGridView1.Rows.Add(TB_CODIGO.Text, TB_ARTICULO.Text, TB_CANTIDAD_VENTA.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CARGAR()
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "Eliminar" Then
            DataGridView1.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    Sub GUARDAR()
        Try
            If RB_ENTRADA.Checked = True Then
                TIPO = 1
            ElseIf RB_SALIDA.Checked = True Then
                TIPO = 0
            End If
            If DataGridView1.Rows.Count > 0 Then
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
                    Dim cmd As New SqlCommand("INGRESAR_AJUSTE", conex)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@AJUTIPO", SqlDbType.Int).Value = TIPO
                    cmd.Parameters.Add("@BODEGA", SqlDbType.Int).Value = TB_BODEGA.SelectedValue
                    cmd.Parameters.Add("@ARTICULO", SqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(0).Value.ToString()
                    cmd.Parameters.Add("@AJUCANTIDAD", SqlDbType.Int).Value = DataGridView1.Rows(i).Cells(2).Value.ToString()
                    conex.Open()
                    cmd.ExecuteNonQuery()
                    conex.Close()
                Next
            End If
            MessageBox.Show("AJUSTE GUARDADO CORRECTAMENTE", "SISTEMA")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub GUARDAR_MOVIMIENTO_ENTRADA()
        Try
            If DataGridView1.Rows.Count > 0 Then
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
                    Dim cmd As New SqlCommand("INGRESAR_CARDEX_AJUSTE", conex)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ARTICULO", SqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(0).Value.ToString()
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

    Sub GUARDAR_MOVIMIENTO_SALIDA()
        Try
            If DataGridView1.Rows.Count > 0 Then
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
                    Dim cmd As New SqlCommand("INGRESAR_CARDEX_AJUSTE_RESTA", conex)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ARTICULO", SqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(0).Value.ToString()
                    cmd.Parameters.Add("@CARCONCEP", SqlDbType.Int).Value = 4
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

    Sub VALIDAR()
        If RB_ENTRADA.Checked = False And RB_SALIDA.Checked = False Then
            MsgBox("Debe especificar si es una entrada o una Salida", MsgBoxStyle.Critical, "Error")
        Else
            GUARDAR()
            TIPO_MOVIMIENT()
        End If
    End Sub

    Private Sub BTM_GUARDAR_Click(sender As Object, e As EventArgs) Handles BTM_GUARDAR.Click
        VALIDAR()
    End Sub

    Sub TIPO_MOVIMIENT()
        If RB_ENTRADA.Checked = True Then
            GUARDAR_MOVIMIENTO_ENTRADA()
        ElseIf RB_SALIDA.Checked = True Then
            GUARDAR_MOVIMIENTO_SALIDA()
        End If
    End Sub
End Class