Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class TERCEROS
    Public X, CLIENTE, PROVEE As Integer
    Private Sub TERCEROS_Load(sender As Object, e As EventArgs) Handles Me.Load
        buscar_DEPARTAMENTOS()
        VALIDACION1()
        BLOQUEAR_BOTONES()
        BUSCAR_CLIENTES_TODOS()
    End Sub
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles BTM_SALIR.Click
        Dispose()
    End Sub

    Sub buscar_DEPARTAMENTOS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_DEPARTAMENTOS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            TB_DEPARTAMENTO.DataSource = tabla
            TB_DEPARTAMENTO.DisplayMember = ("DESCRIPCION")
            TB_DEPARTAMENTO.ValueMember = ("CODIGO")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub buscar_MUNICPIOS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_MINICIPIOS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@DEPARTAMENTO", SqlDbType.Int).Value = TB_DEPARTAMENTO.SelectedValue
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            TB_MUNICIPIO.DataSource = tabla
            TB_MUNICIPIO.DisplayMember = ("DESCRIPCION")
            TB_MUNICIPIO.ValueMember = ("OID")
            conex.Close()
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TB_DEPARTAMENTO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TB_DEPARTAMENTO.SelectedIndexChanged
        buscar_MUNICPIOS()
    End Sub
    Public Function DigitoNIT(ByVal sNit As String) As String
        On Error Resume Next
        Dim sTMP, sTmp1, sTMP2 As String
        Dim i As Integer
        Dim iResiduo As Integer
        Dim iChequeo As Integer
        Dim iPrimos(15) As Integer
        iPrimos(1) = 3 : iPrimos(2) = 7 : iPrimos(3) = 13 : iPrimos(4) = 17 : iPrimos(5) = 19
        iPrimos(6) = 23 : iPrimos(7) = 29 : iPrimos(8) = 37 : iPrimos(9) = 41 : iPrimos(10) = 43
        iPrimos(11) = 47 : iPrimos(12) = 53 : iPrimos(13) = 59 : iPrimos(14) = 67 : iPrimos(15) = 71
        iChequeo = 0 : iResiduo = 0
        For i = 0 To Len(Trim(sNit)) - 1
            sTMP = Mid(sNit, Len(Trim(sNit)) - i, 1)
            iChequeo = iChequeo + (Val(sTMP) * iPrimos(i + 1))
        Next i
        iResiduo = iChequeo Mod 11
        If iResiduo <= 1 Then
            If iResiduo = 0 Then DigitoNIT = 0
            If iResiduo = 1 Then DigitoNIT = 1
        Else
            DigitoNIT = 11 - iResiduo
        End If
        TB_DV.Text = DigitoNIT
        'By GeNeTiKo
    End Function

    Sub valida_doc()
        If TB_TIPO_DOCUMENTO.Text = "NIT" Then
            DigitoNIT(TB_DOCUMENTO.Text)
        Else
            TB_DV.Text = " "
        End If
    End Sub

    Private Sub TB_DOCUMENTO_LostFocus(sender As Object, e As EventArgs) Handles TB_DOCUMENTO.LostFocus
        valida_doc()
        buscando2()
    End Sub

    Sub VALIDACION1()
        If TB_TIPO_PERSONA.Text <> "NATURAL" Then
            TB_P_APELLIDO.Enabled = False
            TB_S_APELLIDO.Enabled = False
            TB_P_NOMBRE.Enabled = False
            TB_S_NOMBRE.Enabled = False
            TB_NOMBRE_COMPLETO.Enabled = True
        Else
            TB_NOMBRE_COMPLETO.Enabled = False
            TB_P_APELLIDO.Enabled = True
            TB_S_APELLIDO.Enabled = True
            TB_P_NOMBRE.Enabled = True
            TB_S_NOMBRE.Enabled = True

        End If
    End Sub

    Private Sub TB_TIPO_PERSONA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TB_TIPO_PERSONA.SelectedIndexChanged
        VALIDACION1()
        LIMPIAR_CAMOS()
    End Sub


    Sub LIMPIAR_CAMOS()
        '  tb_tipo_persona.Items.Clear()
        TB_DOCUMENTO.Clear()
        TB_DV.Clear()
        TB_P_APELLIDO.Clear()
        TB_S_APELLIDO.Clear()
        TB_P_NOMBRE.Clear()
        TB_S_NOMBRE.Clear()
        TB_NOMBRE_COMPLETO.Clear()
        tb_direccion.Clear()
        tb_telefono.Clear()
        'tb_tipo_contribuyente.Refresh()
        'tb_tipo_retencion.Refresh()
        CH_CLIENTE.Checked = False
        CH_PROVEE.Checked = False
    End Sub

    Sub GUARDAR()
        Try
            If CH_CLIENTE.Checked = True Then
                CLIENTE = 1
            Else
                CLIENTE = 0
            End If

            If CH_PROVEE.Checked = True Then
                PROVEE = 1
            Else
                PROVEE = 0
            End If
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_TERCERO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@TERTIPPER", SqlDbType.VarChar).Value = TB_TIPO_PERSONA.Text
            cmd.Parameters.Add("@TERTIPDOC", SqlDbType.VarChar).Value = TB_TIPO_DOCUMENTO.Text
            cmd.Parameters.Add("@TERNUMDOC", SqlDbType.VarChar).Value = TB_DOCUMENTO.Text
            cmd.Parameters.Add("@TERDIGVER", SqlDbType.VarChar).Value = TB_DV.Text
            cmd.Parameters.Add("@MUNICIPIO", SqlDbType.Int).Value = TB_MUNICIPIO.SelectedValue
            cmd.Parameters.Add("@TERPRIAPE", SqlDbType.VarChar).Value = TB_P_APELLIDO.Text
            cmd.Parameters.Add("@TERSEGAPE", SqlDbType.VarChar).Value = TB_S_APELLIDO.Text
            cmd.Parameters.Add("@TERPRINOM", SqlDbType.VarChar).Value = TB_P_NOMBRE.Text
            cmd.Parameters.Add("@TERSEGNOM", SqlDbType.VarChar).Value = TB_S_NOMBRE.Text
            cmd.Parameters.Add("@TERNOMCOM", SqlDbType.VarChar).Value = TB_NOMBRE_COMPLETO.Text
            cmd.Parameters.Add("@TERTIPCON", SqlDbType.VarChar).Value = TB_TIPO_CONTRI.Text
            cmd.Parameters.Add("@TERTIPRET", SqlDbType.VarChar).Value = TB_TIPO_RETENCION.Text
            cmd.Parameters.Add("@TERDIRECC", SqlDbType.VarChar).Value = tb_direccion.Text
            cmd.Parameters.Add("@TERTELEFO", SqlDbType.VarChar).Value = tb_telefono.Text
            cmd.Parameters.Add("@TERCLIENTE", SqlDbType.Int).Value = CLIENTE
            cmd.Parameters.Add("@TERPROVEE", SqlDbType.Int).Value = PROVEE

            conex.Open()
            cmd.ExecuteNonQuery()

            MessageBox.Show("CLIENTE GUARDADO CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub MODIFICAR()
        Try
            If CH_CLIENTE.Checked = True Then
                CLIENTE = 1
            Else
                CLIENTE = 0
            End If

            If CH_PROVEE.Checked = True Then
                PROVEE = 1
            Else
                PROVEE = 0
            End If
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("MODIFICAR_TERCERO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@TERTIPPER", SqlDbType.VarChar).Value = TB_TIPO_PERSONA.Text
            cmd.Parameters.Add("@TERTIPDOC", SqlDbType.VarChar).Value = TB_TIPO_DOCUMENTO.Text
            cmd.Parameters.Add("@TERNUMDOC", SqlDbType.VarChar).Value = TB_DOCUMENTO.Text
            cmd.Parameters.Add("@TERDIGVER", SqlDbType.VarChar).Value = TB_DV.Text
            cmd.Parameters.Add("@MUNICIPIO", SqlDbType.Int).Value = TB_MUNICIPIO.SelectedValue
            cmd.Parameters.Add("@TERPRIAPE", SqlDbType.VarChar).Value = TB_P_APELLIDO.Text
            cmd.Parameters.Add("@TERSEGAPE", SqlDbType.VarChar).Value = TB_S_APELLIDO.Text
            cmd.Parameters.Add("@TERPRINOM", SqlDbType.VarChar).Value = TB_P_NOMBRE.Text
            cmd.Parameters.Add("@TERSEGNOM", SqlDbType.VarChar).Value = TB_S_NOMBRE.Text
            cmd.Parameters.Add("@TERNOMCOM", SqlDbType.VarChar).Value = TB_NOMBRE_COMPLETO.Text
            cmd.Parameters.Add("@TERTIPCON", SqlDbType.VarChar).Value = TB_TIPO_CONTRI.Text
            cmd.Parameters.Add("@TERTIPRET", SqlDbType.VarChar).Value = TB_TIPO_RETENCION.Text
            cmd.Parameters.Add("@TERDIRECC", SqlDbType.VarChar).Value = tb_direccion.Text
            cmd.Parameters.Add("@TERTELEFO", SqlDbType.VarChar).Value = tb_telefono.Text
            cmd.Parameters.Add("@TERCLIENTE", SqlDbType.Int).Value = CLIENTE
            cmd.Parameters.Add("@TERPROVEE", SqlDbType.Int).Value = PROVEE
            conex.Open()
            cmd.ExecuteNonQuery()

            MessageBox.Show("CLIENTE MODIFICADO CORRECTAMENTE", "SISTEMA")
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
            BUSCAR_CLIENTES_TODOS()
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

    Sub NOMBRE_COMPLETO()
        TB_NOMBRE_COMPLETO.Text = TB_P_APELLIDO.Text & " " & TB_S_APELLIDO.Text & " " & TB_P_NOMBRE.Text & " " & TB_S_NOMBRE.Text
    End Sub

    Private Sub TB_P_APELLIDO_TextChanged(sender As Object, e As EventArgs) Handles TB_P_APELLIDO.TextChanged
        NOMBRE_COMPLETO()
    End Sub

    Private Sub TB_S_APELLIDO_TextChanged(sender As Object, e As EventArgs) Handles TB_S_APELLIDO.TextChanged
        NOMBRE_COMPLETO()
    End Sub

    Private Sub TB_P_NOMBRE_TextChanged(sender As Object, e As EventArgs) Handles TB_P_NOMBRE.TextChanged
        NOMBRE_COMPLETO()
    End Sub

    Private Sub TB_S_NOMBRE_TextChanged(sender As Object, e As EventArgs) Handles TB_S_NOMBRE.TextChanged
        NOMBRE_COMPLETO()
    End Sub

    Sub VALIDACIONES_BLANCO()
        If TB_TIPO_PERSONA.Text = "" Then
            MsgBox("EL CAMPO TIPO DE PERSONA DEBE TENER UN VALOR")
        ElseIf TB_DOCUMENTO.Text = "" Then
            MsgBox("EL IDENTIFICACION DEBE TENER UN VALOR")
        ElseIf TB_TIPO_DOCUMENTO.Text = "" Then
            MsgBox("EL CAMPO TIPO DE IDENTIFICACION DEBE TENER UN VALOR")
            'ElseIf TB_P_APELLIDO.Text = "" Then
            '    MsgBox("EL CAMPO PRIMER APELLIDO DEBE TENER UN VALOR")
            'ElseIf TB_P_NOMBRE.Text = "" Then
            '    MsgBox("EL CAMPO PRIMER NOMBRE DEBE TENER UN VALOR")
        ElseIf TB_TIPO_CONTRI.Text = "" Then
            MsgBox("EL CAMPO TIPO DE CONTRIBUYENTE DEBE TENER UN VALOR")
        ElseIf CH_CLIENTE.Checked = False And CH_PROVEE.Checked = False Then
            MsgBox("Debe especificar si es Cliente o Proveedor ")
        Else
            GUARDAR()
            LIMPIAR_CAMOS()
            BLOQUEAR_BOTONES()
            BUSCAR_CLIENTES_TODOS()
        End If
    End Sub

    Sub BUSCAR_CLIENTES_TODOS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_TERCEROS_TODOS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView1.DataSource = tabla
            conex.Close()
            DataGridView1.Columns(0).Width = 50
            DataGridView1.Columns(1).Width = 150
            DataGridView1.Columns(2).Width = 300
            DataGridView1.Columns(3).Width = 200
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub buscando2()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_TERCEROS_IDENTIFICACION", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IDENTIFICACION", SqlDbType.VarChar).Value = TB_DOCUMENTO.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                TB_TIPO_PERSONA.Text = dr(1)
                TB_TIPO_DOCUMENTO.Text = dr(2)
                TB_DOCUMENTO.Text = dr(3)
                TB_DV.Text = dr(4)
                TB_DEPARTAMENTO.Text = dr(18)
                TB_MUNICIPIO.Text = dr(17)
                TB_P_APELLIDO.Text = dr(6)
                TB_S_APELLIDO.Text = dr(7)
                TB_P_NOMBRE.Text = dr(8)
                TB_S_NOMBRE.Text = dr(9)
                TB_NOMBRE_COMPLETO.Text = dr(10)
                TB_TIPO_CONTRI.Text = dr(11)
                TB_TIPO_RETENCION.Text = dr(12)
                tb_direccion.Text = dr(13)
                tb_telefono.Text = dr(14)
                CLIENTE = dr(15)
                PROVEE = dr(16)
                If CLIENTE = 1 Then
                    CH_CLIENTE.Checked = True
                Else
                    CH_CLIENTE.Checked = False
                End If

                If PROVEE = 1 Then
                    CH_PROVEE.Checked = True
                Else
                    CH_PROVEE.Checked = False
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

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        If i <> -1 Then
            If DataGridView1.Rows(i).Selected = True Then
                TB_DOCUMENTO.Text = DataGridView1.Rows(i).Cells(1).Value.ToString()
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