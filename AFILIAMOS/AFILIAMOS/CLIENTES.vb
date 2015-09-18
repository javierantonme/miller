Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data

Public Class CLIENTES
    Dim x As Integer
    Dim TIPO As String
    Dim OID_EPS, OID_PENSIONES, OID_ARL, OID_CAJA As Integer

    Private Sub CLIENTES_Load(sender As Object, e As EventArgs) Handles Me.Load
        buscar_MUNICIPIOS()
        conf_combo_municipios()
        VALIDACION1()
        BLOQUEAR_BOTONES()
        BUSCAR_CLIENTES_TODOS()

        buscar_EPS()
        CONFIGURAR_COMBO_EPS()

        buscar_PENSIONES()
        CONFIGURAR_COMBO_PENSIONES()

        buscar_ARL()
        CONFIGURAR_COMBO_ARL()

        buscar_CAJACOM()
        CONFIGURAR_COMBO_CAJACOM()

        buscar_EMPRESA()
        CONFIGURAR_COMBO_EMPRESA()

        Me.RadGridView1.EnableFiltering = True
        Me.RadGridView1.MasterTemplate.EnableFiltering = True
    End Sub
    Private Sub RadButtonElement3_Click(sender As Object, e As EventArgs) Handles BTM_SALIR.Click
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

    Sub CONFIGURAR_COMBO_EPS()
        Me.TB_EPS.AutoFilter = True
        Me.TB_EPS.DisplayMember = "Nombre"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.TB_EPS.DisplayMember
        filter.[Operator] = FilterOperator.Contains
        Me.TB_EPS.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        TB_EPS.MultiColumnComboBoxElement.EditorControl.EnableCustomFiltering = True
        AddHandler TB_EPS.MultiColumnComboBoxElement.EditorControl.CustomFiltering, AddressOf EditorControl_CustomFilteringEPS
        AddHandler TB_EPS.KeyDown, AddressOf TB_EPS_KeyDown

        TB_EPS.DropDownSizingMode = SizingMode.UpDownAndRightBottom
        TB_EPS.DropDownMinSize = New Size(600, 300)

        TB_EPS.EditorControl.Columns(0).Width = 50
        TB_EPS.EditorControl.Columns(1).Width = 100
        TB_EPS.EditorControl.Columns(2).Width = 400
    End Sub

    Sub CONFIGURAR_COMBO_PENSIONES()
        Me.TB_PENSIONES.AutoFilter = True
        Me.TB_PENSIONES.DisplayMember = "Nombre"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.TB_PENSIONES.DisplayMember
        filter.[Operator] = FilterOperator.Contains
        Me.TB_PENSIONES.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        TB_PENSIONES.MultiColumnComboBoxElement.EditorControl.EnableCustomFiltering = True
        AddHandler TB_PENSIONES.MultiColumnComboBoxElement.EditorControl.CustomFiltering, AddressOf EditorControl_CustomFilteringPEN
        AddHandler TB_PENSIONES.KeyDown, AddressOf TB_EPS_KeyDown

        TB_PENSIONES.DropDownSizingMode = SizingMode.UpDownAndRightBottom
        TB_PENSIONES.DropDownMinSize = New Size(600, 300)

        TB_PENSIONES.EditorControl.Columns(0).Width = 50
        TB_PENSIONES.EditorControl.Columns(1).Width = 100
        TB_PENSIONES.EditorControl.Columns(2).Width = 400
    End Sub


    Sub CONFIGURAR_COMBO_ARL()
        Me.TB_ARL.AutoFilter = True
        Me.TB_ARL.DisplayMember = "Nombre"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.TB_ARL.DisplayMember
        filter.[Operator] = FilterOperator.Contains
        Me.TB_ARL.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        TB_ARL.MultiColumnComboBoxElement.EditorControl.EnableCustomFiltering = True
        AddHandler TB_ARL.MultiColumnComboBoxElement.EditorControl.CustomFiltering, AddressOf EditorControl_CustomFilteringARL
        AddHandler TB_ARL.KeyDown, AddressOf TB_ARL_KeyDown

        TB_ARL.DropDownSizingMode = SizingMode.UpDownAndRightBottom
        TB_ARL.DropDownMinSize = New Size(600, 300)

        TB_ARL.EditorControl.Columns(0).Width = 50
        TB_ARL.EditorControl.Columns(1).Width = 100
        TB_ARL.EditorControl.Columns(2).Width = 400
    End Sub

    Sub CONFIGURAR_COMBO_CAJACOM()
        Me.TB_CAJA_COMPENSA.AutoFilter = True
        Me.TB_CAJA_COMPENSA.DisplayMember = "Nombre"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.TB_CAJA_COMPENSA.DisplayMember
        filter.[Operator] = FilterOperator.Contains
        Me.TB_CAJA_COMPENSA.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        TB_CAJA_COMPENSA.MultiColumnComboBoxElement.EditorControl.EnableCustomFiltering = True
        AddHandler TB_CAJA_COMPENSA.MultiColumnComboBoxElement.EditorControl.CustomFiltering, AddressOf EditorControl_CustomFilteringCAJACOM
        AddHandler TB_CAJA_COMPENSA.KeyDown, AddressOf TB_CAJA_COMPENSA_KeyDown

        TB_CAJA_COMPENSA.DropDownSizingMode = SizingMode.UpDownAndRightBottom
        TB_CAJA_COMPENSA.DropDownMinSize = New Size(600, 300)

        TB_CAJA_COMPENSA.EditorControl.Columns(0).Width = 50
        TB_CAJA_COMPENSA.EditorControl.Columns(1).Width = 100
        TB_CAJA_COMPENSA.EditorControl.Columns(2).Width = 400
    End Sub

    Sub CONFIGURAR_COMBO_EMPRESA()
        Me.TB_EMPRESA.AutoFilter = True
        Me.TB_EMPRESA.DisplayMember = "NOMBRE"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.TB_EMPRESA.DisplayMember
        filter.[Operator] = FilterOperator.Contains
        Me.TB_EMPRESA.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        TB_EMPRESA.MultiColumnComboBoxElement.EditorControl.EnableCustomFiltering = True
        AddHandler TB_EMPRESA.MultiColumnComboBoxElement.EditorControl.CustomFiltering, AddressOf EditorControl_CustomFilteringEMPRESA
        AddHandler TB_EMPRESA.KeyDown, AddressOf TB_EMPRESA_KeyDown

        TB_EMPRESA.DropDownSizingMode = SizingMode.UpDownAndRightBottom
        TB_EMPRESA.DropDownMinSize = New Size(420, 300)

        TB_EMPRESA.EditorControl.Columns(0).Width = 100
        TB_EMPRESA.EditorControl.Columns(1).Width = 300
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
    Sub buscar_EPS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_EPS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            TB_EPS.DataSource = tabla
            TB_EPS.ValueMember = ("OID")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub buscar_PENSIONES()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_PENSIONES", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            TB_PENSIONES.DataSource = tabla
            TB_PENSIONES.ValueMember = ("OID")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub buscar_ARL()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_ARL", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            TB_ARL.DataSource = tabla
            TB_ARL.ValueMember = ("OID")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub buscar_CAJACOM()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_CAJACOM", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            TB_CAJA_COMPENSA.DataSource = tabla
            TB_CAJA_COMPENSA.ValueMember = ("OID")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub buscar_EMPRESA()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_EMPRESAS_CLIENTE", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            TB_EMPRESA.DataSource = tabla
            TB_EMPRESA.ValueMember = ("NIT")
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
            Dim cmd As New SqlCommand("BUSCAR_CLIENTES_TODOS", conex)
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
            Dim cmd As New SqlCommand("BUSCAR_CLIENTES_IDENTIFICACION", conex)
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
                TB_LUGAR_EXP_MUN.Text = dr(17)
                TB_P_APELLIDO.Text = dr(6)
                TB_S_APELLIDO.Text = dr(7)
                TB_P_NOMBRE.Text = dr(8)
                TB_S_NOMBRE.Text = dr(9)
                TB_NOMBRE_COMPLETO.Text = dr(10)
                TB_TIPO_CONTRI.Text = dr(11)
                TB_TIPO_RETENCION.Text = dr(12)
                TB_EPS.Text = dr(18)
                TB_PENSIONES.Text = dr(19)
                TB_ARL.Text = dr(20)
                TB_CAJA_COMPENSA.Text = dr(21)
                TIPO = dr(13)
                TB_DIRECCION.Text = dr(14)
                TB_TELEFONO.Text = dr(15)
                If TIPO = "DEPENDIENTE" Then
                    CH_DEPENDIENTE.IsChecked = True
                ElseIf TIPO = "INDEPENDIETE" Then
                    CH_INEPENDIENTE.IsChecked = True
                End If
                TB_EMPRESA.Text = dr(22)
                OID_EPS = dr(23)
                OID_PENSIONES = dr(24)
                OID_ARL = dr(25)
                OID_CAJA = dr(26)

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


    Private Sub EditorControl_CustomFilteringEPS(sender As Object, e As Telerik.WinControls.UI.GridViewCustomFilteringEventArgs)
        Dim element As RadMultiColumnComboBoxElement = TB_EPS.MultiColumnComboBoxElement

        Dim textToSearch As String = TB_EPS.Text
        If AutoCompleteMode.Append = (element.AutoCompleteMode And AutoCompleteMode.Append) Then
            If element.SelectionLength > 0 AndAlso element.SelectionStart > 0 Then
                textToSearch = TB_EPS.Text.Substring(0, element.SelectionStart)
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

    Private Sub TB_EPS_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_EPS.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            If Me.TB_EPS.ValueMember <> "" Then
                TB_EPS.SelectedValue = TB_EPS.EditorControl.CurrentRow.Cells(TB_EPS.ValueMember).Value
            Else
                TB_EPS.SelectedValue = TB_EPS.EditorControl.CurrentRow.Cells(TB_EPS.DisplayMember).Value
            End If

            TB_EPS.Text = TB_EPS.EditorControl.CurrentRow.Cells(TB_EPS.DisplayMember).Value.ToString()
            TB_EPS.MultiColumnComboBoxElement.ClosePopup()
            TB_EPS.MultiColumnComboBoxElement.TextBoxElement.TextBoxItem.SelectAll()
        End If
    End Sub

    Private Sub EditorControl_CustomFilteringPEN(sender As Object, e As Telerik.WinControls.UI.GridViewCustomFilteringEventArgs)
        Dim element As RadMultiColumnComboBoxElement = TB_PENSIONES.MultiColumnComboBoxElement

        Dim textToSearch As String = TB_PENSIONES.Text
        If AutoCompleteMode.Append = (element.AutoCompleteMode And AutoCompleteMode.Append) Then
            If element.SelectionLength > 0 AndAlso element.SelectionStart > 0 Then
                textToSearch = TB_PENSIONES.Text.Substring(0, element.SelectionStart)
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

    Private Sub TB_PENSIONES_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_PENSIONES.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            If Me.TB_PENSIONES.ValueMember <> "" Then
                TB_PENSIONES.SelectedValue = TB_PENSIONES.EditorControl.CurrentRow.Cells(TB_PENSIONES.ValueMember).Value
            Else
                TB_PENSIONES.SelectedValue = TB_PENSIONES.EditorControl.CurrentRow.Cells(TB_PENSIONES.DisplayMember).Value
            End If

            TB_PENSIONES.Text = TB_PENSIONES.EditorControl.CurrentRow.Cells(TB_PENSIONES.DisplayMember).Value.ToString()
            TB_PENSIONES.MultiColumnComboBoxElement.ClosePopup()
            TB_PENSIONES.MultiColumnComboBoxElement.TextBoxElement.TextBoxItem.SelectAll()
        End If
    End Sub

    Private Sub EditorControl_CustomFilteringARL(sender As Object, e As Telerik.WinControls.UI.GridViewCustomFilteringEventArgs)
        Dim element As RadMultiColumnComboBoxElement = TB_ARL.MultiColumnComboBoxElement

        Dim textToSearch As String = TB_ARL.Text
        If AutoCompleteMode.Append = (element.AutoCompleteMode And AutoCompleteMode.Append) Then
            If element.SelectionLength > 0 AndAlso element.SelectionStart > 0 Then
                textToSearch = TB_ARL.Text.Substring(0, element.SelectionStart)
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

    Private Sub TB_ARL_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_ARL.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            If Me.TB_ARL.ValueMember <> "" Then
                TB_ARL.SelectedValue = TB_ARL.EditorControl.CurrentRow.Cells(TB_ARL.ValueMember).Value
            Else
                TB_ARL.SelectedValue = TB_ARL.EditorControl.CurrentRow.Cells(TB_ARL.DisplayMember).Value
            End If

            TB_ARL.Text = TB_ARL.EditorControl.CurrentRow.Cells(TB_ARL.DisplayMember).Value.ToString()
            TB_ARL.MultiColumnComboBoxElement.ClosePopup()
            TB_ARL.MultiColumnComboBoxElement.TextBoxElement.TextBoxItem.SelectAll()
        End If
    End Sub

    Private Sub EditorControl_CustomFilteringCAJACOM(sender As Object, e As Telerik.WinControls.UI.GridViewCustomFilteringEventArgs)
        Dim element As RadMultiColumnComboBoxElement = TB_CAJA_COMPENSA.MultiColumnComboBoxElement

        Dim textToSearch As String = TB_CAJA_COMPENSA.Text
        If AutoCompleteMode.Append = (element.AutoCompleteMode And AutoCompleteMode.Append) Then
            If element.SelectionLength > 0 AndAlso element.SelectionStart > 0 Then
                textToSearch = TB_CAJA_COMPENSA.Text.Substring(0, element.SelectionStart)
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

    Private Sub TB_CAJA_COMPENSA_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_CAJA_COMPENSA.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            If Me.TB_CAJA_COMPENSA.ValueMember <> "" Then
                TB_CAJA_COMPENSA.SelectedValue = TB_CAJA_COMPENSA.EditorControl.CurrentRow.Cells(TB_CAJA_COMPENSA.ValueMember).Value
            Else
                TB_CAJA_COMPENSA.SelectedValue = TB_CAJA_COMPENSA.EditorControl.CurrentRow.Cells(TB_CAJA_COMPENSA.DisplayMember).Value
            End If

            TB_CAJA_COMPENSA.Text = TB_CAJA_COMPENSA.EditorControl.CurrentRow.Cells(TB_CAJA_COMPENSA.DisplayMember).Value.ToString()
            TB_CAJA_COMPENSA.MultiColumnComboBoxElement.ClosePopup()
            TB_CAJA_COMPENSA.MultiColumnComboBoxElement.TextBoxElement.TextBoxItem.SelectAll()
        End If
    End Sub

    Sub GUARDAR()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_CLIENTE", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CLITIPPER", SqlDbType.VarChar).Value = TB_TIPO_PERSONA.Text
            cmd.Parameters.Add("@CLITIPDOC", SqlDbType.VarChar).Value = TB_TIPO_DOCUMENTO.Text
            cmd.Parameters.Add("@CLINUMDOC", SqlDbType.VarChar).Value = TB_DOCUMENTO.Text
            cmd.Parameters.Add("@CLIDIGVER", SqlDbType.VarChar).Value = TB_DV.Text
            cmd.Parameters.Add("@MUNICIPIO", SqlDbType.Int).Value = TB_LUGAR_EXP_MUN.SelectedValue
            cmd.Parameters.Add("@CLIPRIAPE", SqlDbType.VarChar).Value = TB_P_APELLIDO.Text
            cmd.Parameters.Add("@CLISEGAPE", SqlDbType.VarChar).Value = TB_S_APELLIDO.Text
            cmd.Parameters.Add("@CLIPRINOM", SqlDbType.VarChar).Value = TB_P_NOMBRE.Text
            cmd.Parameters.Add("@CLISEGNOM", SqlDbType.VarChar).Value = TB_S_NOMBRE.Text
            cmd.Parameters.Add("@CLINOMCOM", SqlDbType.VarChar).Value = TB_NOMBRE_COMPLETO.Text
            cmd.Parameters.Add("@CLITIPCON", SqlDbType.VarChar).Value = TB_TIPO_CONTRI.Text
            cmd.Parameters.Add("@CLITIPRET", SqlDbType.VarChar).Value = TB_TIPO_RETENCION.Text
            cmd.Parameters.Add("@CLIDIRECC", SqlDbType.VarChar).Value = TB_DIRECCION.Text
            cmd.Parameters.Add("@CLITELEFONO", SqlDbType.VarChar).Value = TB_TELEFONO.Text


            If CH_DEPENDIENTE.IsChecked = True Then
                TIPO = "DEPENDIENTE"
            ElseIf CH_INEPENDIENTE.IsChecked = True Then
                TIPO = "INDEPENDIENTE"
            ElseIf CH_TAXISTA.IsChecked = True Then
                TIPO = "TAXISTA"
            End If
            cmd.Parameters.Add("@TIPOAFILIACION", SqlDbType.VarChar).Value = TIPO

            If CH_DEPENDIENTE.IsChecked = True Then
                cmd.Parameters.Add("@EMPRESA", SqlDbType.VarChar).Value = TB_EMPRESA.SelectedValue
            Else
                cmd.Parameters.Add("@EMPRESA", SqlDbType.VarChar).Value = vbNull
            End If

            conex.Open()
            cmd.ExecuteNonQuery()
            GUARDAR_EPS()
            GUARDAR_PENSIONES()
            GUARDAR_ARL()
            GUARDAR_CAJA()
            MessageBox.Show("CLIENTE GUARDADO CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub MODIFICAR()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("MODIFICAR_CLIENTE", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CLITIPPER", SqlDbType.VarChar).Value = TB_TIPO_PERSONA.Text
            cmd.Parameters.Add("@CLITIPDOC", SqlDbType.VarChar).Value = TB_TIPO_DOCUMENTO.Text
            cmd.Parameters.Add("@CLINUMDOC", SqlDbType.VarChar).Value = TB_DOCUMENTO.Text
            cmd.Parameters.Add("@CLIDIGVER", SqlDbType.VarChar).Value = TB_DV.Text
            cmd.Parameters.Add("@MUNICIPIO", SqlDbType.Int).Value = TB_LUGAR_EXP_MUN.SelectedValue
            cmd.Parameters.Add("@CLIPRIAPE", SqlDbType.VarChar).Value = TB_P_APELLIDO.Text
            cmd.Parameters.Add("@CLISEGAPE", SqlDbType.VarChar).Value = TB_S_APELLIDO.Text
            cmd.Parameters.Add("@CLIPRINOM", SqlDbType.VarChar).Value = TB_P_NOMBRE.Text
            cmd.Parameters.Add("@CLISEGNOM", SqlDbType.VarChar).Value = TB_S_NOMBRE.Text
            cmd.Parameters.Add("@CLINOMCOM", SqlDbType.VarChar).Value = TB_NOMBRE_COMPLETO.Text
            cmd.Parameters.Add("@CLITIPCON", SqlDbType.VarChar).Value = TB_TIPO_CONTRI.Text
            cmd.Parameters.Add("@CLITIPRET", SqlDbType.VarChar).Value = TB_TIPO_RETENCION.Text
            cmd.Parameters.Add("@CLIDIRECC", SqlDbType.VarChar).Value = TB_DIRECCION.Text
            cmd.Parameters.Add("@CLITELEFONO", SqlDbType.VarChar).Value = TB_TELEFONO.Text

            If CH_DEPENDIENTE.IsChecked = True Then
                TIPO = "DEPENDIENTE"
            ElseIf CH_INEPENDIENTE.IsChecked = True Then
                TIPO = "INDEPENDIENTE"
            ElseIf CH_TAXISTA.IsChecked = True Then
                TIPO = "TAXISTA"
            End If
            cmd.Parameters.Add("@TIPOAFILIACION", SqlDbType.VarChar).Value = TIPO
            If CH_DEPENDIENTE.IsChecked = True Then
                cmd.Parameters.Add("@EMPRESA", SqlDbType.VarChar).Value = TB_EMPRESA.SelectedValue
            Else
                cmd.Parameters.Add("@EMPRESA", SqlDbType.VarChar).Value = vbNull
            End If

            conex.Open()
            cmd.ExecuteNonQuery()
            MODIFICAR_EPS()
            MODIFICAR_PENSIONES()
            MODIFICAR_ARL()
            MODIFICAR_CAJA()
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

    Sub GUARDAR_EPS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_FONDO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CLINUMDOC", SqlDbType.VarChar).Value = TB_DOCUMENTO.Text
            cmd.Parameters.Add("@FONDO", SqlDbType.Int).Value = TB_EPS.SelectedValue
            cmd.Parameters.Add("@TIPO", SqlDbType.Int).Value = 1
            conex.Open()
            cmd.ExecuteNonQuery()
            '  MessageBox.Show("BANCO GUARDADO CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub MODIFICAR_EPS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("MODIFICAR_CLIENTES_FONDOS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CLIENTE", SqlDbType.VarChar).Value = TB_DOCUMENTO.Text
            cmd.Parameters.Add("@FONDO", SqlDbType.Int).Value = OID_EPS
            cmd.Parameters.Add("@TIPO", SqlDbType.Int).Value = 1
            conex.Open()
            cmd.ExecuteNonQuery()
            '  MessageBox.Show("BANCO GUARDADO CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub GUARDAR_PENSIONES()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_FONDO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CLINUMDOC", SqlDbType.VarChar).Value = TB_DOCUMENTO.Text
            cmd.Parameters.Add("@FONDO", SqlDbType.Int).Value = TB_PENSIONES.SelectedValue
            cmd.Parameters.Add("@TIPO", SqlDbType.Int).Value = 2
            conex.Open()
            cmd.ExecuteNonQuery()
            '  MessageBox.Show("BANCO GUARDADO CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub MODIFICAR_PENSIONES()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("MODIFICAR_CLIENTES_FONDOS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CLIENTE", SqlDbType.VarChar).Value = TB_DOCUMENTO.Text
            cmd.Parameters.Add("@FONDO", SqlDbType.Int).Value = OID_PENSIONES
            cmd.Parameters.Add("@TIPO", SqlDbType.Int).Value = 2
            conex.Open()
            cmd.ExecuteNonQuery()
            '  MessageBox.Show("BANCO GUARDADO CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub GUARDAR_ARL()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_FONDO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CLINUMDOC", SqlDbType.VarChar).Value = TB_DOCUMENTO.Text
            cmd.Parameters.Add("@FONDO", SqlDbType.Int).Value = TB_ARL.SelectedValue
            cmd.Parameters.Add("@TIPO", SqlDbType.Int).Value = 3
            conex.Open()
            cmd.ExecuteNonQuery()
            '  MessageBox.Show("BANCO GUARDADO CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub MODIFICAR_ARL()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("MODIFICAR_CLIENTES_FONDOS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CLIENTE", SqlDbType.VarChar).Value = TB_DOCUMENTO.Text
            cmd.Parameters.Add("@FONDO", SqlDbType.Int).Value = OID_ARL
            cmd.Parameters.Add("@TIPO", SqlDbType.Int).Value = 3
            conex.Open()
            cmd.ExecuteNonQuery()
            '  MessageBox.Show("BANCO GUARDADO CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub GUARDAR_CAJA()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_FONDO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CLINUMDOC", SqlDbType.VarChar).Value = TB_DOCUMENTO.Text
            cmd.Parameters.Add("@FONDO", SqlDbType.Int).Value = TB_CAJA_COMPENSA.SelectedValue
            cmd.Parameters.Add("@TIPO", SqlDbType.Int).Value = 4
            conex.Open()
            cmd.ExecuteNonQuery()
            '  MessageBox.Show("BANCO GUARDADO CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub MODIFICAR_CAJA()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("MODIFICAR_CLIENTES_FONDOS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CLIENTE", SqlDbType.VarChar).Value = TB_DOCUMENTO.Text
            cmd.Parameters.Add("@FONDO", SqlDbType.Int).Value = OID_CAJA
            cmd.Parameters.Add("@TIPO", SqlDbType.Int).Value = 4
            conex.Open()
            cmd.ExecuteNonQuery()
            '  MessageBox.Show("BANCO GUARDADO CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EditorControl_CustomFilteringEMPRESA(sender As Object, e As Telerik.WinControls.UI.GridViewCustomFilteringEventArgs)
        Dim element As RadMultiColumnComboBoxElement = TB_EMPRESA.MultiColumnComboBoxElement

        Dim textToSearch As String = TB_EMPRESA.Text
        If AutoCompleteMode.Append = (element.AutoCompleteMode And AutoCompleteMode.Append) Then
            If element.SelectionLength > 0 AndAlso element.SelectionStart > 0 Then
                textToSearch = TB_EMPRESA.Text.Substring(0, element.SelectionStart)
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

    Private Sub TB_EMPRESA_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_EMPRESA.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            If Me.TB_EMPRESA.ValueMember <> "" Then
                TB_EMPRESA.SelectedValue = TB_EMPRESA.EditorControl.CurrentRow.Cells(TB_EMPRESA.ValueMember).Value
            Else
                TB_EMPRESA.SelectedValue = TB_EMPRESA.EditorControl.CurrentRow.Cells(TB_EMPRESA.DisplayMember).Value
            End If

            TB_EMPRESA.Text = TB_EMPRESA.EditorControl.CurrentRow.Cells(TB_EMPRESA.DisplayMember).Value.ToString()
            TB_EMPRESA.MultiColumnComboBoxElement.ClosePopup()
            TB_EMPRESA.MultiColumnComboBoxElement.TextBoxElement.TextBoxItem.SelectAll()
        End If
    End Sub

    Sub PREGUNTA_EMPRESA()
        If CH_DEPENDIENTE.IsChecked = True Then
            TB_EMPRESA.Enabled = True
        Else
            TB_EMPRESA.Enabled = False

        End If
    End Sub

    Private Sub CH_INEPENDIENTE_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles CH_INEPENDIENTE.ToggleStateChanged
        PREGUNTA_EMPRESA()
    End Sub

    Private Sub CH_DEPENDIENTE_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles CH_DEPENDIENTE.ToggleStateChanged
        PREGUNTA_EMPRESA()
    End Sub

    Private Sub CH_TAXISTA_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles CH_TAXISTA.ToggleStateChanged
        PREGUNTA_EMPRESA()
    End Sub


End Class
