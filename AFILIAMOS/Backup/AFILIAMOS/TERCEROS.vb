Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data

Public Class TERCEROS
    Dim X As Integer
    Dim CLIENTE, FONDO As Integer
    Private Sub TERCEROS_Load(sender As Object, e As EventArgs) Handles Me.Load
        buscar_MUNICIPIOS()
        conf_combo_municipios()
        VALIDACION1()
        BLOQUEAR_BOTONES()
        BUSCAR_CLIENTES_TODOS()

        Me.RadGridView1.EnableFiltering = True
        Me.RadGridView1.MasterTemplate.EnableFiltering = True
    End Sub

    Private Sub BTM_SALIR_Click(sender As Object, e As EventArgs) Handles BTM_SALIR.Click
        Dispose()
    End Sub

    Sub conf_combo_municipios()
        Me.TB_LUGAR_EXP_MUN.AutoFilter = True
        Me.TB_LUGAR_EXP_MUN.DisplayMember = "MUNICIPIOS"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.TB_LUGAR_EXP_MUN.DisplayMember
        filter.[Operator] = FilterOperator.Contains
        Me.TB_LUGAR_EXP_MUN.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        TB_LUGAR_EXP_MUN.MultiColumnComboBoxElement.EditorControl.EnableCustomFiltering = True
        AddHandler TB_LUGAR_EXP_MUN.MultiColumnComboBoxElement.EditorControl.CustomFiltering, AddressOf EditorControl_CustomFiltering
        AddHandler TB_LUGAR_EXP_MUN.KeyDown, AddressOf TB_LUGAR_EXP_MUN_KeyDown

        TB_LUGAR_EXP_MUN.DropDownSizingMode = SizingMode.UpDownAndRightBottom
        TB_LUGAR_EXP_MUN.DropDownMinSize = New Size(600, 300)

        TB_LUGAR_EXP_MUN.EditorControl.Columns(0).Width = 50
        TB_LUGAR_EXP_MUN.EditorControl.Columns(1).Width = 200
        TB_LUGAR_EXP_MUN.EditorControl.Columns(2).Width = 200

    End Sub

    Sub buscar_MUNICIPIOS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCANDO_MUNICIPIOS_Y_DPTO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            TB_LUGAR_EXP_MUN.DataSource = tabla
            TB_LUGAR_EXP_MUN.ValueMember = ("OID")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EditorControl_CustomFiltering(sender As Object, e As Telerik.WinControls.UI.GridViewCustomFilteringEventArgs)
        Dim element As RadMultiColumnComboBoxElement = TB_LUGAR_EXP_MUN.MultiColumnComboBoxElement

        Dim textToSearch As String = TB_LUGAR_EXP_MUN.Text
        If AutoCompleteMode.Append = (element.AutoCompleteMode And AutoCompleteMode.Append) Then
            If element.SelectionLength > 0 AndAlso element.SelectionStart > 0 Then
                textToSearch = TB_LUGAR_EXP_MUN.Text.Substring(0, element.SelectionStart)
            End If
        End If
        If String.IsNullOrEmpty(textToSearch) Then
            e.Visible = True
            For i As Integer = 0 To element.EditorControl.ColumnCount - 1
                e.Row.Cells(i).Style.Reset()
            Next
            e.Row.InvalidateRow()
            Return
        End If
        e.Visible = False
        For i As Integer = 0 To element.EditorControl.ColumnCount - 1
            Dim text As String = e.Row.Cells(i).Value.ToString()
            If text.IndexOf(textToSearch, 0, StringComparison.InvariantCultureIgnoreCase) >= 0 Then
                e.Visible = True
                e.Row.Cells(i).Style.CustomizeFill = True
                e.Row.Cells(i).Style.DrawFill = True
                e.Row.Cells(i).Style.BackColor = Color.FromArgb(201, 252, 254)
            Else
                e.Row.Cells(i).Style.Reset()
            End If
        Next
        e.Row.InvalidateRow()
    End Sub

    Private Sub TB_LUGAR_EXP_MUN_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_LUGAR_EXP_MUN.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            If Me.TB_LUGAR_EXP_MUN.ValueMember <> "" Then
                TB_LUGAR_EXP_MUN.SelectedValue = TB_LUGAR_EXP_MUN.EditorControl.CurrentRow.Cells(TB_LUGAR_EXP_MUN.ValueMember).Value
            Else
                TB_LUGAR_EXP_MUN.SelectedValue = TB_LUGAR_EXP_MUN.EditorControl.CurrentRow.Cells(TB_LUGAR_EXP_MUN.DisplayMember).Value
            End If

            TB_LUGAR_EXP_MUN.Text = TB_LUGAR_EXP_MUN.EditorControl.CurrentRow.Cells(TB_LUGAR_EXP_MUN.DisplayMember).Value.ToString()
            TB_LUGAR_EXP_MUN.MultiColumnComboBoxElement.ClosePopup()
            TB_LUGAR_EXP_MUN.MultiColumnComboBoxElement.TextBoxElement.TextBoxItem.SelectAll()
        End If
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
        'tb_tipo_contribuyente.Refresh()
        'tb_tipo_retencion.Refresh()
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
            RadGridView1.DataSource = tabla
            conex.Close()
            RadGridView1.Columns(0).Width = 50
            RadGridView1.Columns(1).Width = 150
            RadGridView1.Columns(2).Width = 300
            RadGridView1.Columns(3).Width = 200
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
                TB_LUGAR_EXP_MUN.Text = dr(15)
                TB_P_APELLIDO.Text = dr(6)
                TB_S_APELLIDO.Text = dr(7)
                TB_P_NOMBRE.Text = dr(8)
                TB_S_NOMBRE.Text = dr(9)
                TB_NOMBRE_COMPLETO.Text = dr(10)
                TB_TIPO_CONTRI.Text = dr(11)
                TB_TIPO_RETENCION.Text = dr(12)
               
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

    Sub GUARDAR()
        Try
            If CH_CLIENTE.Checked = True Then
                CLIENTE = 1
            Else
                CLIENTE = 0
            End If

            If CH_FONDO.Checked = True Then
                FONDO = 1
            Else
                FONDO = 0
            End If

            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_TERCERO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@TERTIPPER", SqlDbType.VarChar).Value = TB_TIPO_PERSONA.Text
            cmd.Parameters.Add("@TERTIPDOC", SqlDbType.VarChar).Value = TB_TIPO_DOCUMENTO.Text
            cmd.Parameters.Add("@TERNUMDOC", SqlDbType.VarChar).Value = TB_DOCUMENTO.Text
            cmd.Parameters.Add("@TERDIGVER", SqlDbType.VarChar).Value = TB_DV.Text
            cmd.Parameters.Add("@MUNICIPIO", SqlDbType.Int).Value = TB_LUGAR_EXP_MUN.SelectedValue
            cmd.Parameters.Add("@TERPRIAPE", SqlDbType.VarChar).Value = TB_P_APELLIDO.Text
            cmd.Parameters.Add("@TERSEGAPE", SqlDbType.VarChar).Value = TB_S_APELLIDO.Text
            cmd.Parameters.Add("@TERPRINOM", SqlDbType.VarChar).Value = TB_P_NOMBRE.Text
            cmd.Parameters.Add("@TERSEGNOM", SqlDbType.VarChar).Value = TB_S_NOMBRE.Text
            cmd.Parameters.Add("@TERNOMCOM", SqlDbType.VarChar).Value = TB_NOMBRE_COMPLETO.Text
            cmd.Parameters.Add("@TERTIPCON", SqlDbType.VarChar).Value = TB_TIPO_CONTRI.Text
            cmd.Parameters.Add("@TERTIPRET", SqlDbType.VarChar).Value = TB_TIPO_RETENCION.Text
            cmd.Parameters.Add("@TERDIRECC", SqlDbType.VarChar).Value = TB_DIRECCION.Text
            cmd.Parameters.Add("@TERTELEFO", SqlDbType.VarChar).Value = TB_TELEFONO.Text
            cmd.Parameters.Add("@TERCLIENTE", SqlDbType.Int).Value = CLIENTE
            cmd.Parameters.Add("@TERFONDO", SqlDbType.Int).Value = FONDO
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
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("MODIFICAR_TERCERO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@TERTIPPER", SqlDbType.VarChar).Value = TB_TIPO_PERSONA.Text
            cmd.Parameters.Add("@TERTIPDOC", SqlDbType.VarChar).Value = TB_TIPO_DOCUMENTO.Text
            cmd.Parameters.Add("@TERNUMDOC", SqlDbType.VarChar).Value = TB_DOCUMENTO.Text
            cmd.Parameters.Add("@TERDIGVER", SqlDbType.VarChar).Value = TB_DV.Text
            cmd.Parameters.Add("@MUNICIPIO", SqlDbType.Int).Value = TB_LUGAR_EXP_MUN.SelectedValue
            cmd.Parameters.Add("@TERPRIAPE", SqlDbType.VarChar).Value = TB_P_APELLIDO.Text
            cmd.Parameters.Add("@TERSEGAPE", SqlDbType.VarChar).Value = TB_S_APELLIDO.Text
            cmd.Parameters.Add("@TERPRINOM", SqlDbType.VarChar).Value = TB_P_NOMBRE.Text
            cmd.Parameters.Add("@TERSEGNOM", SqlDbType.VarChar).Value = TB_S_NOMBRE.Text
            cmd.Parameters.Add("@TERNOMCOM", SqlDbType.VarChar).Value = TB_NOMBRE_COMPLETO.Text
            cmd.Parameters.Add("@TERTIPCON", SqlDbType.VarChar).Value = TB_TIPO_CONTRI.Text
            cmd.Parameters.Add("@TERTIPRET", SqlDbType.VarChar).Value = TB_TIPO_RETENCION.Text
            cmd.Parameters.Add("@TERDIRECC", SqlDbType.VarChar).Value = TB_DIRECCION.Text
            cmd.Parameters.Add("@TERTELEFO", SqlDbType.VarChar).Value = TB_TELEFONO.Text
            conex.Open()
            cmd.ExecuteNonQuery()

            MessageBox.Show("CLIENTE GUARDADO CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RadGridView1_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridView1.CellDoubleClick
        Dim clickedRow As GridViewRowInfo = e.Row
        TB_DOCUMENTO.Text = clickedRow.Cells(1).Value.ToString()
        buscando2()
        '   PREGUNTA2()
        desbloquear_botones()
        '    BLOQUEAR_CAMPOS()
        BTM_GUARDAR.Enabled = False
        BTM_NUEVO.Enabled = True
        BTM_MODIFICAR.Enabled = True
    End Sub

    Private Sub BTM_MODIFICAR_Click(sender As Object, e As EventArgs) Handles BTM_MODIFICAR.Click
        x = 2
        DESBLOQUEAR_BOTONES()
        ' desploquear_campos()
        BTM_MODIFICAR.Enabled = False
    End Sub

End Class
