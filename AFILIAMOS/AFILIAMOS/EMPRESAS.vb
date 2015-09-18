Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Public Class EMPRESAS
    Dim X, OID As Integer

    Private Sub EMPRESAS_Load(sender As Object, e As EventArgs) Handles Me.Load
        BLOQUEAR_BOTONES()
        LIMPIAR_CAMOS()
        BUSCAR_BANCOS_TODOS()
        Me.RadGridView1.EnableFiltering = True
        Me.RadGridView1.MasterTemplate.EnableFiltering = True
    End Sub
    Private Sub BTM_SALIR_Click(sender As Object, e As EventArgs) Handles BTM_SALIR.Click
        Dispose()
    End Sub

    Sub LIMPIAR_CAMOS()
        TB_CODIGO.Clear()
        TB_NOMBRE.Clear()
    End Sub

    Sub GUARDAR()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_EMPRESA", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@EMPRENIT", SqlDbType.VarChar).Value = TB_CODIGO.Text
            cmd.Parameters.Add("@EMPRENOMBRE", SqlDbType.VarChar).Value = TB_NOMBRE.Text
            conex.Open()
            cmd.ExecuteNonQuery()
            RadMessageBox.Show("EMPRESA GUARDADA CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub MODIFICAR()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("MODFICAR_EMPRESAS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@OID", SqlDbType.Int).Value = OID
            cmd.Parameters.Add("@EMPRENIT", SqlDbType.VarChar).Value = TB_CODIGO.Text
            cmd.Parameters.Add("@EMPRENOMBRE", SqlDbType.VarChar).Value = TB_NOMBRE.Text
            conex.Open()
            cmd.ExecuteNonQuery()

            RadMessageBox.Show("EMPRESA MODIFICADA CORRECTAMENTE", "SISTEMA")
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
            BUSCAR_BANCOS_TODOS()
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
        If TB_CODIGO.Text = "" Then
            MsgBox("EL CAMPO NIT DEBE TENER UN VALOR")
        ElseIf TB_NOMBRE.Text = "" Then
            MsgBox("EL CAMPO NOMBRE NO PUDEDE ESTAR EN BLANCO")
        Else
            GUARDAR()
            LIMPIAR_CAMOS()
            BLOQUEAR_BOTONES()
            BUSCAR_BANCOS_TODOS()
        End If
    End Sub

    Sub BUSCAR_BANCOS_TODOS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_EMPRESAS_TODAS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            RadGridView1.DataSource = tabla
            conex.Close()
            RadGridView1.Columns(0).Width = 100
            RadGridView1.Columns(1).Width = 320
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub buscando2()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_EMPRESAS_NIT", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@EMPRENIT", SqlDbType.VarChar).Value = TB_CODIGO.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                OID = dr(0)
                TB_NOMBRE.Text = dr(2)
                'BLOQUEAR_CAMPOS()
                BTM_GUARDAR.Enabled = False
                BTM_NUEVO.Enabled = True
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
        TB_CODIGO.Text = clickedRow.Cells(0).Value.ToString()
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

    Private Sub TB_CODIGO_LostFocus(sender As Object, e As EventArgs) Handles TB_CODIGO.LostFocus
        buscando2()
    End Sub

End Class
