Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class ARTICULOS
    Public X As Integer
    Private Sub ARTICULOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar_PRESENTACION()
        BLOQUEAR_BOTONES()
        BUSCAR_ARTICULOS_TODOS()
        CANTIDAD()
    End Sub

    Sub buscar_PRESENTACION()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_PRESENTACION", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            TB_PRESENTACION.DataSource = tabla
            TB_PRESENTACION.DisplayMember = ("DESCRIPCION")
            TB_PRESENTACION.ValueMember = ("OID")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BTM_SALIR_Click(sender As Object, e As EventArgs) Handles BTM_SALIR.Click
        Dispose()
    End Sub

    Private Sub TB_CODIGO_LostFocus(sender As Object, e As EventArgs) Handles TB_CODIGO.LostFocus
        buscando2()
    End Sub

    Sub LIMPIAR_CAMOS()
        TB_CODIGO.Clear()
        TB_DESCRIPCION.Clear()
        TB_PRESENTACION.Text = ""
        TB_VALOR.Clear()
        TB_IVA.Text = "16"
    End Sub

    Sub GUARDAR()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_ARTICULO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ARTCODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            cmd.Parameters.Add("@ARTDESCRI", SqlDbType.NVarChar).Value = TB_DESCRIPCION.Text
            cmd.Parameters.Add("@PRESENTACION", SqlDbType.Int).Value = TB_PRESENTACION.SelectedValue
            cmd.Parameters.Add("@ARTVALOR", SqlDbType.Int).Value = TB_VALOR.Text
            cmd.Parameters.Add("@ARTIVA", SqlDbType.Int).Value = TB_IVA.Text
            conex.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("ARTICULO GUARDADO CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub MODIFICAR()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("MODIFICAR_ARTICULO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ARTCODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            cmd.Parameters.Add("@ARTDESCRI", SqlDbType.NVarChar).Value = TB_DESCRIPCION.Text
            cmd.Parameters.Add("@PRESENTACION", SqlDbType.Int).Value = TB_PRESENTACION.SelectedValue
            cmd.Parameters.Add("@ARTVALOR", SqlDbType.Int).Value = TB_VALOR.Text
            cmd.Parameters.Add("@ARTIVA", SqlDbType.Int).Value = TB_IVA.Text
            conex.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("ARTICULO MODIFICADO CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BTM_NUEVO_Click(sender As Object, e As EventArgs) Handles btm_nuevo.Click
        X = 1
        LIMPIAR_CAMOS()
        DESBLOQUEAR_BOTONES()
        BTM_MODIFICAR.Enabled = False

    End Sub

    Private Sub BTM_GUARDAR_Click(sender As Object, e As EventArgs) Handles BTM_GUARDAR.Click
        If X = 1 Then
            VALIDACIONES_BLANCO()
            CANTIDAD()
        ElseIf X = 2 Then
            MODIFICAR()
            BUSCAR_ARTICULOS_TODOS()
            BLOQUEAR_BOTONES()
            LIMPIAR_CAMOS()
            CANTIDAD()
        End If
    End Sub

    Sub BLOQUEAR_BOTONES()
        btm_nuevo.Enabled = True
        btm_guardar.Enabled = False
        BTM_MODIFICAR.Enabled = False
    End Sub
    Sub DESBLOQUEAR_BOTONES()
        btm_nuevo.Enabled = False
        btm_guardar.Enabled = True
        BTM_MODIFICAR.Enabled = True
    End Sub

    Sub VALIDACIONES_BLANCO()
        If TB_CODIGO.Text = "" Then
            MsgBox("EL CAMPO CODIGO DEBE TENER UN VALOR")
        ElseIf TB_DESCRIPCION.Text = "" Then
            MsgBox("EL DESCRIPCION DEBE TENER UN VALOR")
        ElseIf TB_PRESENTACION.Text = "" Then
            MsgBox("EL CAMPO DESCRIPCION DEBE TENER UN VALOR")
        ElseIf TB_IVA.Text = "" Then
            MsgBox("EL CAMPO DE IVA DEBE TENER UN VALOR")
            'ElseIf TB_P_NOMBRE.Text = "" Then
            '    MsgBox("EL CAMPO PRIMER NOMBRE DEBE TENER UN VALOR")
        ElseIf TB_VALOR.Text = "" Then
            MsgBox("EL CAMPO VALOR DEBE TENER UN VALOR")
        Else
            GUARDAR()
            LIMPIAR_CAMOS()
            BLOQUEAR_BOTONES()
            BUSCAR_ARTICULOS_TODOS()
        End If
    End Sub

    Sub BUSCAR_ARTICULOS_TODOS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_TODOS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView1.DataSource = tabla
            conex.Close()
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 400
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 100
            DataGridView1.Columns(4).Width = 100

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub buscando2()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_ARTICULO_CODIGO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ARTCODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                TB_DESCRIPCION.Text = dr(2)
                TB_PRESENTACION.Text = dr(6)
                TB_VALOR.Text = dr(4)
                TB_IVA.Text = dr(5)
                'BLOQUEAR_CAMPOS()
                btm_guardar.Enabled = False
                btm_nuevo.Enabled = True
                conex.Close()
            Else
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTM_MODIFICAR_Click(sender As Object, e As EventArgs) Handles BTM_MODIFICAR.Click
        X = 2
        DESBLOQUEAR_BOTONES()
        ' desploquear_campos()
        BTM_MODIFICAR.Enabled = False
    End Sub

    Sub PREGUNTA_FILTRO()
        If RB_NOMBRE.Checked = True Then
            BUSCAR_POR_NOMBRE()
        ElseIf RB_CODIGO.Checked = True Then
            BUSCAR_POR_CODIGO()
        End If
    End Sub

    Sub BUSCAR_POR_NOMBRE()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_FILTRO_NOMBRE", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar).Value = TB_INFO.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView1.DataSource = tabla
            conex.Close()
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 400
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 100
            DataGridView1.Columns(4).Width = 100

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub BUSCAR_POR_CODIGO()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_FRILTRO_CODIGO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = TB_INFO.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView1.DataSource = tabla
            conex.Close()
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 400
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 100
            DataGridView1.Columns(4).Width = 100

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TB_INFO_TextChanged(sender As Object, e As EventArgs) Handles TB_INFO.TextChanged
        PREGUNTA_FILTRO()
    End Sub

    Sub CANTIDAD()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_CANTIDAD_ARTICULOS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            '    cmd.Parameters.Add("@ARTCODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                LB_CANTIDAD.Text = dr(0) & " Artículos"
                conex.Close()
            Else
                conex.Close()
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_DoubleClick1(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        If i <> -1 Then
            If DataGridView1.Rows(i).Selected = True Then
                TB_CODIGO.Text = DataGridView1.Rows(i).Cells(0).Value.ToString()
                buscando2()
                DESBLOQUEAR_BOTONES()
                '  BLOQUEAR_CAMPOS()
                BTM_GUARDAR.Enabled = False
                btm_nuevo.Enabled = True
                BTM_MODIFICAR.Enabled = True

            End If
        End If
    End Sub
End Class