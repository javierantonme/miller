Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data

Public Class USUARIOS
    Dim ACTIVO, X As Integer

    Private Sub USUARIOS_Load(sender As Object, e As EventArgs) Handles Me.Load
        BLOQUEAR_BOTONES()
        LIMPIAR_CAMOS()
        BUSCAR_USUARIOS_TODOS()

        Me.RadGridView1.EnableFiltering = True
        Me.RadGridView1.MasterTemplate.EnableFiltering = True
    End Sub

    Private Sub BTM_SALIR_Click(sender As Object, e As EventArgs) Handles BTM_SALIR.Click
        Dispose()
    End Sub

    Sub LIMPIAR_CAMOS()
        tb_Cedula.Clear()
        TB_NOMBRE.Clear()
        tb_usuario.Clear()
        tb_contraseña.Clear()
    End Sub

    Sub GUARDAR()
        Try
            PREGUNTA_aCTIVO()
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_USUARIO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CEDULA", SqlDbType.VarChar).Value = tb_Cedula.Text
            cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = tb_nombre.Text
            cmd.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = tb_usuario.Text
            cmd.Parameters.Add("@CONTRASEÑA", SqlDbType.VarChar).Value = tb_contraseña.Text
            cmd.Parameters.Add("@ACTIVO", SqlDbType.Int).Value = ACTIVO
            conex.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("USUARIO GUARDADO CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub MODIFICAR()
        Try
            PREGUNTA_aCTIVO()
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("MODIFICAR_USUARIO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CEDULA", SqlDbType.VarChar).Value = tb_Cedula.Text
            cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = tb_nombre.Text
            cmd.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = tb_usuario.Text
            cmd.Parameters.Add("@CONTRASEÑA", SqlDbType.VarChar).Value = tb_contraseña.Text
            cmd.Parameters.Add("@ACTIVO", SqlDbType.Int).Value = ACTIVO
            conex.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("USUARIO MODIFICADO CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BTM_NUEVO_Click(sender As Object, e As EventArgs) Handles BTM_NUEVO.Click
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
            BUSCAR_USUARIOS_TODOS()
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
        If tb_Cedula.Text = "" Then
            MsgBox("EL CAMPO CEDULA DEBE TENER UN VALOR")
        ElseIf tb_nombre.Text = "" Then
            MsgBox("EL CAMPO NOMBRE NO PUDEDE ESTAR EN BLANCO")
        ElseIf tb_usuario.Text = "" Then
            MsgBox("EL USUARIO NO PUEDE ESTAR EN BLANCO")
        ElseIf tb_contraseña.Text = "" Then
            MsgBox("EL CAMPO CONTRASEA NO PUEDE ESTAR EN BLANCO")
        Else
            GUARDAR()
            LIMPIAR_CAMOS()
            BLOQUEAR_BOTONES()
            BUSCAR_USUARIOS_TODOS()
        End If
    End Sub

    Sub BUSCAR_USUARIOS_TODOS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_USUARIO_TODOS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            RadGridView1.DataSource = tabla
            conex.Close()
            RadGridView1.Columns(0).Width = 75
            RadGridView1.Columns(1).Width = 250
            RadGridView1.Columns(2).Width = 100
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub buscando2()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_USUARIO_CEDULA", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CEDULA", SqlDbType.VarChar).Value = tb_Cedula.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                tb_nombre.Text = dr(2)
                tb_usuario.Text = dr(3)
                tb_contraseña.Text = dr(4)
                ACTIVO = dr(5)
                PREGUNTA_ACTIVO2()
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

    Private Sub RadGridView1_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridView1.CellDoubleClick
        Dim clickedRow As GridViewRowInfo = e.Row
        tb_Cedula.Text = clickedRow.Cells(0).Value.ToString()
        buscando2()
        DESBLOQUEAR_BOTONES()
        '  BLOQUEAR_CAMPOS()
        BTM_GUARDAR.Enabled = False
        BTM_NUEVO.Enabled = True
        BTM_MODIFICAR.Enabled = True
    End Sub

    Private Sub BTM_MODIFICAR_Click(sender As Object, e As EventArgs) Handles BTM_MODIFICAR.Click
        X = 2
        DESBLOQUEAR_BOTONES()
        ' desploquear_campos()
        BTM_MODIFICAR.Enabled = False
    End Sub

    Private Sub TB_CEDULA_LostFocus(sender As Object, e As EventArgs) Handles tb_Cedula.LostFocus
        buscando2()
    End Sub

    Sub PREGUNTA_aCTIVO()
        If CheckBox1.Checked = True Then
            ACTIVO = 1
        ElseIf CheckBox1.Checked = False Then
            ACTIVO = 0
        End If
    End Sub

    Sub PREGUNTA_ACTIVO2()
        If ACTIVO = 1 Then
            CheckBox1.Checked = True
        ElseIf ACTIVO = 0 Then
            CheckBox1.Checked = False
        End If
    End Sub

End Class
