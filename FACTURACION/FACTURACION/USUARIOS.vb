Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class USUARIOS
    Public X, OID As Integer


    Private Sub USUARIOS_Load(sender As Object, e As EventArgs) Handles Me.Load
        BLOQUEAR_BOTONES()
        BUSCAR_BODEGAS_TODOS()
    End Sub
    Private Sub BTM_SALIR_Click(sender As Object, e As EventArgs) Handles BTM_SALIR.Click
        Dispose()
    End Sub


    Private Sub TB_CEDULA_LostFocus(sender As Object, e As EventArgs) Handles TB_CEDULA.LostFocus
        buscando2()
    End Sub

    Sub LIMPIAR_CAMOS()
        TB_CEDULA.Clear()
        TB_NOMBRE.Clear()
        TB_USUARIO.Clear()
        TB_CONTRASEÑA.Clear()
    End Sub

    Sub GUARDAR()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_USUARIO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@USUCODIGO", SqlDbType.VarChar).Value = TB_CEDULA.Text
            cmd.Parameters.Add("@USUNOMBRE", SqlDbType.VarChar).Value = TB_NOMBRE.Text
            cmd.Parameters.Add("@USUUSUARIO", SqlDbType.VarChar).Value = TB_USUARIO.Text
            cmd.Parameters.Add("@USUCONTRA", SqlDbType.VarChar).Value = TB_CONTRASEÑA.Text
            conex.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("USUARIO CREADO CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub MODIFICAR()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("MODIFICAR_USUARIO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@OID", SqlDbType.Int).Value = OID
            cmd.Parameters.Add("@USUCODIGO", SqlDbType.VarChar).Value = TB_CEDULA.Text
            cmd.Parameters.Add("@USUNOMBRE", SqlDbType.VarChar).Value = TB_NOMBRE.Text
            cmd.Parameters.Add("@USUUSUARIO", SqlDbType.VarChar).Value = TB_USUARIO.Text
            cmd.Parameters.Add("@USUCONTRA", SqlDbType.VarChar).Value = TB_CONTRASEÑA.Text
            conex.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("BODEGA MODIFICADA CORRECTAMENTE", "SISTEMA")
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
        ElseIf X = 2 Then
            MODIFICAR()
            BUSCAR_BODEGAS_TODOS()
            BLOQUEAR_BOTONES()
            LIMPIAR_CAMOS()
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
        If TB_CEDULA.Text = "" Then
            MsgBox("EL CAMPO IDENTIFICACION DEBE TENER UN VALOR")
        ElseIf TB_NOMBRE.Text = "" Then
            MsgBox("EL CAMPO NOMBRE DEBE TENER UN VALOR")
        Else
            GUARDAR()
            LIMPIAR_CAMOS()
            BLOQUEAR_BOTONES()
            BUSCAR_BODEGAS_TODOS()
        End If
    End Sub

    Sub BUSCAR_BODEGAS_TODOS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_USUARIOS_TODOS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView1.DataSource = tabla
            conex.Close()
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 240
            DataGridView1.Columns(2).Width = 100
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub buscando2()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_USUARIOS_CODIGO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CODIGO", SqlDbType.VarChar).Value = TB_CEDULA.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                OID = dr(0)
                TB_CEDULA.Text = dr(1)
                TB_NOMBRE.Text = dr(2)
                TB_USUARIO.Text = dr(3)
                TB_CONTRASEÑA.Text = dr(4)
                'BLOQUEAR_CAMPOS()
                BTM_GUARDAR.Enabled = False
                btm_nuevo.Enabled = True
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
                TB_CEDULA.Text = DataGridView1.Rows(i).Cells(0).Value.ToString()
                buscando2()
                DESBLOQUEAR_BOTONES()
                '  BLOQUEAR_CAMPOS()
                BTM_GUARDAR.Enabled = False
                BTM_NUEVO.Enabled = True
                BTM_MODIFICAR.Enabled = True
            End If
        End If
    End Sub
    Private Sub BTM_MODIFICAR_Click(sender As Object, e As EventArgs) Handles BTM_MODIFICAR.Click
        X = 2
        DESBLOQUEAR_BOTONES()
        ' desploquear_campos()
        BTM_MODIFICAR.Enabled = False
    End Sub
End Class