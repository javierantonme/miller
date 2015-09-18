Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Public Class ASESOR
    Dim X, OID As Integer
    Private Sub ASESOR_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        TB_DIRECCION.Clear()
        TB_TELEFONO.Clear()
        TB_PORCENTAJE.Text = 0
    End Sub

    Sub GUARDAR()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_ASESOR", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ASECODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            cmd.Parameters.Add("@ASENOMBRE", SqlDbType.VarChar).Value = TB_NOMBRE.Text
            cmd.Parameters.Add("@ASEDIRECC", SqlDbType.VarChar).Value = TB_DIRECCION.Text
            cmd.Parameters.Add("@ASETELEFONO", SqlDbType.VarChar).Value = TB_TELEFONO.Text
            cmd.Parameters.Add("@ASEPORCEN", SqlDbType.Int).Value = TB_PORCENTAJE.Text
            conex.Open()
            cmd.ExecuteNonQuery()
            RadMessageBox.Show("ASESOR GUARDADO CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub MODIFICAR()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("MODIFICAR_ASESOR", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@OID", SqlDbType.Int).Value = OID
            cmd.Parameters.Add("@ASECODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            cmd.Parameters.Add("@ASENOMBRE", SqlDbType.VarChar).Value = TB_NOMBRE.Text
            cmd.Parameters.Add("@ASEDIRECC", SqlDbType.VarChar).Value = TB_DIRECCION.Text
            cmd.Parameters.Add("@ASETELEFONO", SqlDbType.VarChar).Value = TB_TELEFONO.Text
            cmd.Parameters.Add("@ASEPORCEN", SqlDbType.Int).Value = TB_PORCENTAJE.Text
            conex.Open()
            cmd.ExecuteNonQuery()

            RadMessageBox.Show("ASESOR MODIFICADO CORRECTAMENTE", "SISTEMA")
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
            MsgBox("EL CAMPO CODIGO DEBE TENER UN VALOR")
        ElseIf TB_NOMBRE.Text = "" Then
            MsgBox("EL CAMPO NOMBRE NO PUDEDE ESTAR EN BLANCO")
        ElseIf TB_DIRECCION.Text = "" Then
            MsgBox("EL CAMPO DIRECCION NO PUEDE ESTAR EN BLANCO")
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
            Dim cmd As New SqlCommand("BUSCAR_ASESORES_TODOS", conex)
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
            Dim cmd As New SqlCommand("BUSCAR_ASESORES_CODIGO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ASECODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                OID = dr(0)
                TB_NOMBRE.Text = dr(2)
                TB_DIRECCION.Text = dr(3)
                TB_TELEFONO.Text = dr(4)
                TB_PORCENTAJE.Text = dr(5)
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

    'Private Sub TB_PORCENTAJE_TextChanged(sender As Object, e As EventArgs) Handles TB_PORCENTAJE.TextChanged
    '    If TB_PORCENTAJE.Text = "" Then
    '        TB_PORCENTAJE.Text = 0
    '    End If
    'End Sub
End Class
