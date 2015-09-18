Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class INVENTARIO_INICIAL
    Public ESTADO As Integer
    Public CONSEC As Integer
    Public X As Integer
    Private Sub BTM_SALIR_Click(sender As Object, e As EventArgs) Handles BTM_SALIR.Click
        Dispose()
    End Sub

    Private Sub INVENTARIO_INICIAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  BUSCAR_INVENTARIO()
        LIMPIARCAMPOS()
        BUSCAR_BODEGA()
        ' BUSCAR_CONSECUTIVO_SIGUIENTE()
        TB_FECHA.Text = Date.Now.ToString
    End Sub

    Sub buscar_ARTICULO_NOMBRE()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_ARTICULO_II", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = TB_INFO.Text
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
            Dim cmd As New SqlCommand("BUSCAR_ARTICULO_II_CODIGO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = TB_INFO.Text
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

    Sub buscando2()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_ARTICULOII", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ARTDESCRI", SqlDbType.NVarChar).Value = LB_INFO.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                TB_CODIGO.Text = dr(1)
                TB_ARTICULO.Text = dr(2)
                LB_UNIDADES.Text = dr(6)
                conex.Close()
            Else
                conex.Close()
            End If
        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try
    End Sub

    
    Private Sub LB_INFO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_INFO.SelectedIndexChanged
        buscando2()
    End Sub

    Sub GUARDAR_ARTICULOS() 'INGRESAR_INVENTARIO_INICIAL
        Try
            If DataGridView1.Rows.Count > 0 Then
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
                    Dim cmd As New SqlCommand("INGRESAR_INVENTARIO_INICIAL", conex)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ARTICULO", SqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(0).Value.ToString()
                    cmd.Parameters.Add("@CANTIDAD", SqlDbType.Int).Value = DataGridView1.Rows(i).Cells(2).Value.ToString()
                    conex.Open()
                    cmd.ExecuteNonQuery()
                    conex.Close()
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub GUARDAR_ARTICULOS2() 'INGRESAR_INVENTARIO_INICIAL
        Try
            If DataGridView1.Rows.Count > 0 Then
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
                    Dim cmd As New SqlCommand("INGRESAR_INVENTARIO_INICIAL2", conex)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ARTICULO", SqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(0).Value.ToString()
                    cmd.Parameters.Add("@CANTIDAD", SqlDbType.Int).Value = DataGridView1.Rows(i).Cells(2).Value.ToString()
                    cmd.Parameters.Add("@CONSECUTIVO", SqlDbType.Int).Value = TB_CONSECUTIVO.Text
                    conex.Open()
                    cmd.ExecuteNonQuery()
                    conex.Close()
                Next
                MsgBox("Inventario Guardado Correctamente")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Sub GUARDAR_INVENTARIO()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_INVENTARIOC", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@BODEGA", SqlDbType.Int).Value = TB_BODEGA.SelectedValue
            cmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = ESTADO
            conex.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("ARTICULO GUARDADO CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub BUSCAR_INVENTARIO()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_INVETARIO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView2.DataSource = tabla
            conex.Close()
            DataGridView2.Columns(0).Width = 100
            DataGridView2.Columns(1).Width = 200
            DataGridView2.Columns(2).Width = 50
            DataGridView2.Columns(3).Width = 200
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BTM_GUARDAR_Click(sender As Object, e As EventArgs) Handles BTM_GUARDAR.Click
        'buscar_ARTICULO_CODIGO_PARA_PREGUNTA()

        CONFIRMAR_INV.ShowDialog()

    End Sub
    Sub buscar_ARTICULO_CODIGO_PARA_PREGUNTA()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_ARTICULO_II_PREG", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ARTCODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            cmd.Parameters.Add("@BODEGA", SqlDbType.Int).Value = TB_BODEGA.SelectedValue
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                MsgBox("EL ARTICULO YA SE ENCUENTRA EN EL INVENATARIO")
                LIMPIARCAMPOS()
                conex.Close()
            Else
                'GUARDAR()
                BUSCAR_INVENTARIO()
                LIMPIARCAMPOS()
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub LIMPIARCAMPOS()
        TB_INFO.Clear()
        LB_INFO.DataSource = Nothing
        TB_CANTIDAD.Clear()
        TB_CODIGO.Clear()
        TB_ARTICULO.Clear()
    End Sub

    Sub CARGAR()
        Try
            Me.DataGridView1.Rows.Add(TB_CODIGO.Text, TB_ARTICULO.Text, TB_CANTIDAD.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CARGAR()
    End Sub

    Sub BUSCAR_INVENTARIO_CODIGO_ANTERIOR()
        Try
            'DataGridView1.Columns("Codigo").Visible = False
            'DataGridView1.Columns("Descripcion").Visible = False
            'DataGridView1.Columns("Cantidad").Visible = False

            'DataGridView2.Columns.Remove("Codigo")
            'DataGridView2.Columns.Remove("Descripcion")
            'DataGridView1.Columns.Remove("Cantidad")



            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_INVENTARIO_IV", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CONSECUTIVO", SqlDbType.Int).Value = CONSEC
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView2.DataSource = tabla
            DataGridView2.Columns(0).Width = 100
            DataGridView2.Columns(1).Width = 300
            DataGridView2.Columns(2).Width = 100
            conex.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub BUSCAR_CONSECUTIVO_SIGUIENTE()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_SIGUIENTE_CONSECUTIVO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@ARTCODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            'cmd.Parameters.Add("@BODEGA", SqlDbType.Int).Value = TB_BODEGA.SelectedValue
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                TB_CONSECUTIVO.Text = dr(0)
                conex.Close()
            Else
                conex.Close()
            End If
        Catch ex As Exception
            '     MsgBox(ex.Message)
        End Try
    End Sub

    Sub GUARDAR_KARDEK()
        Try
            If DataGridView1.Rows.Count > 0 Then
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
                    Dim cmd As New SqlCommand("INGRESAR_CARDEX_INV", conex)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@ARTICULO", SqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(0).Value.ToString()
                    cmd.Parameters.Add("@CANTMOV", SqlDbType.Int).Value = DataGridView1.Rows(i).Cells(2).Value.ToString()
                    conex.Open()
                    cmd.ExecuteNonQuery()
                    '   MessageBox.Show("REGISTRO GUARDADO CORRECTAMENTE", "SISTEMA")
                    conex.Close()
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class