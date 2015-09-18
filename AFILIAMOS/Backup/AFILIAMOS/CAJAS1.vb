Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Public Class CAJAS1

    Dim X As Integer


    Private Sub CAJAS1_Load(sender As Object, e As EventArgs) Handles Me.Load
        BLOQUEAR_BOTONES()
        LIMPIAR_CAMOS()
        BUSCAR_CAJAS_TODOS()

        Me.RadGridView1.EnableFiltering = True
        Me.RadGridView1.MasterTemplate.EnableFiltering = True
    End Sub


    Private Sub BTM_SALIR_Click(sender As Object, e As EventArgs) Handles BTM_SALIR.Click
        Dispose()
    End Sub

    Sub LIMPIAR_CAMOS()
        TB_CODIGO.Clear()
        TB_NOMBRE.Clear()
        TB_SALDO_INICIAL.Clear()
        TB_PREFIJO.Clear()
    End Sub

    Sub GUARDAR()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_CAJAS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CAJACODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            cmd.Parameters.Add("@CAJAPREFIJO", SqlDbType.VarChar).Value = TB_PREFIJO.Text
            cmd.Parameters.Add("@CAJANOMBRE", SqlDbType.VarChar).Value = TB_NOMBRE.Text
            cmd.Parameters.Add("@CAJASALINI", SqlDbType.Int).Value = TB_SALDO_INICIAL.Text
            conex.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("CAJA GUARDADA CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub MODIFICAR()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("MODIFICAR_CAJAS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CAJACODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            cmd.Parameters.Add("@CAJAPREFIJO", SqlDbType.VarChar).Value = TB_PREFIJO.Text
            cmd.Parameters.Add("@CAJANOMBRE", SqlDbType.VarChar).Value = TB_NOMBRE.Text
            cmd.Parameters.Add("@CAJASALINI", SqlDbType.Int).Value = TB_SALDO_INICIAL.Text
            conex.Open()
            cmd.ExecuteNonQuery()

            MessageBox.Show("CAJA MODIFICADA CORRECTAMENTE", "SISTEMA")
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
            BUSCAR_CAJAS_TODOS()
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
            MsgBox("EL CAMPO CODIGO DEBE TENER UN VALOR")
        ElseIf TB_NOMBRE.Text = "" Then
            MsgBox("EL CAMPO NOMBRE NO PUDEDE ESTAR EN BLANCO")
        ElseIf TB_PREFIJO.Text = "" Then
            MsgBox("EL PREFIJO NO PUEDE ESTAR EN BLANCO")
        ElseIf TB_SALDO_INICIAL.Text = "" Then
            MsgBox("EL CAMPO SALDO INICIAL NO PUEDE ESTAR EN BLANCO")
        Else
            GUARDAR()
            LIMPIAR_CAMOS()
            BLOQUEAR_BOTONES()
            BUSCAR_CAJAS_TODOS()
        End If
    End Sub

    Sub BUSCAR_CAJAS_TODOS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_CAJAS_TODAS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            RadGridView1.DataSource = tabla
            conex.Close()
            RadGridView1.Columns(0).Width = 75
            RadGridView1.Columns(1).Width = 75
            RadGridView1.Columns(2).Width = 250
            RadGridView1.Columns(3).Width = 100
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub buscando2()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_CAJAS_CODIGO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CAJACODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                TB_PREFIJO.Text = dr(2)
                TB_NOMBRE.Text = dr(3)
                TB_SALDO_INICIAL.Text = dr(4)
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
