Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Public Class CONCEPTOS
    Dim TIPO, TIPO2 As Integer
    Dim X As Integer
    Private Sub CONCEPTOS_Load(sender As Object, e As EventArgs) Handles Me.Load
        BLOQUEAR_BOTONES()
        LIMPIAR_CAMOS()
        BUSCAR_CONCEPTOS_TODOS()
        Me.RadGridView1.EnableFiltering = True
        Me.RadGridView1.MasterTemplate.EnableFiltering = True
    End Sub

    Private Sub BTM_SALIR_Click(sender As Object, e As EventArgs) Handles BTM_SALIR.Click
        Dispose()
    End Sub
    Sub LIMPIAR_CAMOS()
        TB_CODIGO.Clear()
        TB_NOMBRE.Clear()
        TB_TIPO.Text = ""
    End Sub

    Sub GUARDAR()
        Try
            PREGUNTA_TIPO()
            PREGUNTA_RB()
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_CONCEPTOS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CONCODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            cmd.Parameters.Add("@CONCDET", SqlDbType.VarChar).Value = TB_NOMBRE.Text
            cmd.Parameters.Add("@CONTIPO", SqlDbType.Int).Value = TIPO
            cmd.Parameters.Add("@TIPO", SqlDbType.Int).Value = TIPO2
            conex.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("CONCEPTO GUARDADO CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub MODIFICAR()
        Try
            PREGUNTA_TIPO()
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("MODIFICAR_CONCEPTOS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CONCODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            cmd.Parameters.Add("@CONCDET", SqlDbType.VarChar).Value = TB_NOMBRE.Text
            cmd.Parameters.Add("@CONTIPO", SqlDbType.Int).Value = TIPO
            cmd.Parameters.Add("@TIPO", SqlDbType.Int).Value = TIPO2
            conex.Open()
            cmd.ExecuteNonQuery()

            MessageBox.Show("CONCPETO MODIFICADO CORRECTAMENTE", "SISTEMA")
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
            BUSCAR_CONCEPTOS_TODOS()
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
        ElseIf TB_TIPO.Text = "" Then
            MsgBox("EL CAMPO TIPO NO PUEDE ESTAR EN BLANCO")
        Else
            GUARDAR()
            LIMPIAR_CAMOS()
            BLOQUEAR_BOTONES()
            BUSCAR_CONCEPTOS_TODOS()
        End If
    End Sub

    Sub BUSCAR_CONCEPTOS_TODOS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_CONCEPTOS_TODOS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            RadGridView1.DataSource = tabla
            ada.Fill(tabla)
            conex.Close()
            RadGridView1.Columns(0).Width = 75
            RadGridView1.Columns(1).Width = 280
            RadGridView1.Columns(2).Width = 170
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub buscando2()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_CONCEPTOS_CODIGO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CONCODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                TB_NOMBRE.Text = dr(1)
                TB_TIPO.Text = dr(2)
                TIPO2 = dr(3)

                If TIPO2 = 1 Then
                    RB_EPS.IsChecked = True
                ElseIf TIPO2 = 2 Then
                    RB_PENSIONES.IsChecked = True
                ElseIf TIPO2 = 3 Then
                    RB_ARL.IsChecked = True
                ElseIf TIPO2 = 4 Then
                    RB_CAJA.IsChecked = True
                ElseIf TIPO2 = 5 Then
                    RB_ADMINISTRACION.IsChecked = True
                ElseIf TIPO2 = 6 Then
                    RB_FILIACION.IsChecked = True
                ElseIf TIPO2 = 7 Then
                    RB_NINGUNO.IsChecked = True
                End If
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

    Sub PREGUNTA_TIPO()
        If TB_TIPO.Text = "RECIBO DE CAJA" Then
            TIPO = 1
        ElseIf TB_TIPO.Text = "COMPROBANTE DE EGRESO" Then
            TIPO = 2
        End If
    End Sub

    Private Sub TB_TIPO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TB_TIPO.SelectedIndexChanged
        PREGUNTA_TIPO()
    End Sub

    Sub PREGUNTA_RB()
        If RB_EPS.IsChecked = True Then
            TIPO2 = 1
        ElseIf RB_PENSIONES.IsChecked = True Then
            TIPO2 = 2
        ElseIf RB_ARL.IsChecked = True Then
            TIPO2 = 3
        ElseIf RB_CAJA.IsChecked = True Then
            TIPO2 = 4
        ElseIf RB_ADMINISTRACION.IsChecked = True Then
            TIPO2 = 5
        ElseIf RB_FILIACION.IsChecked = True Then
            TIPO2 = 6
        ElseIf RB_NINGUNO.IsChecked = True Then
            TIPO2 = 7
        End If
    End Sub
End Class
