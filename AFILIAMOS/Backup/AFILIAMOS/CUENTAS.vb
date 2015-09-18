Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Public Class CUENTAS
    Dim X As Integer
    Dim sobrejiro, TIPO_CUENTA_BANCARIA As Integer

    Private Sub CUENTAS_Load(sender As Object, e As EventArgs) Handles Me.Load
        BLOQUEAR_BOTONES()
        LIMPIAR_CAMOS()
        BUSCAR_CUENTAS_TODOS()
        PREGUNTA_SOBREGIRO()
        buscar_BANCOS()
        CONF_COMBO_BANCOS()
        Me.RadGridView1.EnableFiltering = True
        Me.RadGridView1.MasterTemplate.EnableFiltering = True
    End Sub

    Private Sub BTM_SALIR_Click(sender As Object, e As EventArgs) Handles BTM_SALIR.Click
        Dispose()
    End Sub

    Sub LIMPIAR_CAMOS()
        TB_CODIGO.Clear()
        TB_BANCO.Text = ""
        TB_TIPO_CUENTA.Text = ""
        TB_NUMERO_CUENTA.Clear()
        TB_SALDO_INICIAL.Clear()
        TB_VALOR_SOBREGIRO.Text = 0
        CH_SOBREGURO.Checked = False
    End Sub
    Sub PREGUNTA_SOBREJIRO()
        If CH_SOBREGURO.Checked = True Then
            sobrejiro = 1
        ElseIf CH_SOBREGURO.Checked = False Then
            sobrejiro = 0
        End If
    End Sub

    Sub PREGUNTA_TIPO_CUENTA2()
        If TB_TIPO_CUENTA.Text = "CUENTA DE AHORROS" Then
            TIPO_CUENTA_BANCARIA = 0
        ElseIf TB_TIPO_CUENTA.Text = "CUENTA CORRIENTE" Then
            TIPO_CUENTA_BANCARIA = 1
        End If
    End Sub
    Sub GUARDAR()
        Try

            PREGUNTA_SOBREJIRO()
            PREGUNTA_TIPO_CUENTA2()
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_CUENTA", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CUECODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            cmd.Parameters.Add("@BANCO", SqlDbType.Int).Value = TB_BANCO.SelectedValue
            cmd.Parameters.Add("@CUETIPO", SqlDbType.Int).Value = TIPO_CUENTA_BANCARIA
            cmd.Parameters.Add("@CUENUMERO", SqlDbType.VarChar).Value = TB_NUMERO_CUENTA.Text
            cmd.Parameters.Add("@CUESOBGIRO", SqlDbType.Int).Value = sobrejiro
            cmd.Parameters.Add("@CUEVALSOB", SqlDbType.Int).Value = TB_VALOR_SOBREGIRO.Text
            cmd.Parameters.Add("@CUESALINI", SqlDbType.Int).Value = TB_SALDO_INICIAL.Text
            conex.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("CUENTA GUARDADA CORRECTAMENTE", "SISTEMA")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BTM_NUEVO_Click(sender As Object, e As EventArgs) Handles BTM_NUEVO.Click
        X = 1
        LIMPIAR_CAMOS()
        DESBLOQUEAR_BOTONES()
    End Sub
    Private Sub BTM_GUARDAR_Click(sender As Object, e As EventArgs) Handles BTM_GUARDAR.Click
        If X = 1 Then
            VALIDACIONES_BLANCO()
        ElseIf X = 2 Then
            'MODIFICAR()
            'BUSCAR_CAJAS_TODOS()
            'BLOQUEAR_BOTONES()
            'LIMPIAR_CAMOS()
        End If
    End Sub
    Sub BLOQUEAR_BOTONES()
        BTM_NUEVO.Enabled = True
        BTM_GUARDAR.Enabled = False

    End Sub
    Sub DESBLOQUEAR_BOTONES()
        BTM_NUEVO.Enabled = False
        BTM_GUARDAR.Enabled = True
    End Sub
    Sub VALIDACIONES_BLANCO()
        If TB_CODIGO.Text = "" Then
            MsgBox("EL CAMPO CODIGO DEBE TENER UN VALOR")
        ElseIf TB_BANCO.Text = "" Then
            MsgBox("EL CAMPO BANCO NO PUDEDE ESTAR EN BLANCO")
        ElseIf TB_TIPO_CUENTA.Text = "" Then
            MsgBox("EL TIPO DE BCUENTA NO PUEDE ESTAR EN BLANCO")
        ElseIf TB_NUMERO_CUENTA.Text = "" Then
            MsgBox("EL NUMER DE CUENTA NO PUEDE ESTAR EN BLANCO")
        ElseIf TB_SALDO_INICIAL.Text = "" Then
            MsgBox("EL CAMPO SALDO INICIAL NO PUEDE ESTAR EN BLANCO")
        Else
            GUARDAR()
            LIMPIAR_CAMOS()
            BLOQUEAR_BOTONES()
            BUSCAR_CUENTAS_TODOS()
        End If
    End Sub

    Sub BUSCAR_CUENTAS_TODOS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("MOSTRAR_CUENTAS_TODAS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            RadGridView1.DataSource = tabla
            conex.Close()
            RadGridView1.Columns(0).Width = 75
            RadGridView1.Columns(1).Width = 200
            RadGridView1.Columns(2).Width = 170
            RadGridView1.Columns(3).Width = 100
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Sub BUSCAR_TIPO_CUENTA()
    '    If TIPO_CUENTA_BANCARIA = 0 Then
    '        TB_TIPO_CUENTA.Text = "AHORROS"
    '    ElseIf TIPO_CUENTA_BANCARIA = 1 Then
    '        TB_TIPO_CUENTA.Text = "CORRIENTE"
    '    End If
    'End Sub

    Sub buscando2()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("MOSTRAR_CUENTAS_CODIGO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CUECODIGO", SqlDbType.VarChar).Value = TB_CODIGO.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                TB_BANCO.Text = dr(1)
                TB_TIPO_CUENTA.Text = dr(2)
                TB_NUMERO_CUENTA.Text = dr(3)
                sobrejiro = dr(4)
                If sobrejiro = 0 Then
                    CH_SOBREGURO.Checked = False
                ElseIf sobrejiro = 1 Then
                    CH_SOBREGURO.Checked = True
                End If
                PREGUNTA_SOBREGIRO()
                TB_VALOR_SOBREGIRO.Text = dr(5)
                TB_SALDO_INICIAL.Text = dr(6)
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
        'BTM_MODIFICAR.Enabled = True
    End Sub

    Private Sub TB_CODIGO_LostFocus(sender As Object, e As EventArgs) Handles TB_CODIGO.LostFocus
        buscando2()
    End Sub

    Sub PREGUNTA_SOBREGIRO()
        If CH_SOBREGURO.Checked = False Then
            TB_VALOR_SOBREGIRO.Enabled = False
        ElseIf CH_SOBREGURO.Checked = True Then
            TB_VALOR_SOBREGIRO.Enabled = True
        End If
    End Sub

    Sub buscar_BANCOS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_BANCOS_CTAS", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            TB_BANCO.DataSource = tabla
            '  TB_BANCO.DisplayMember = ("Banco")
            TB_BANCO.ValueMember = ("OID")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CH_SOBREGURO_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles CH_SOBREGURO.ToggleStateChanged
        PREGUNTA_SOBREJIRO()
        PREGUNTA_SOBREGIRO()
    End Sub

    Sub CONF_COMBO_BANCOS()
        Me.TB_BANCO.AutoFilter = True
        Me.TB_BANCO.DisplayMember = "Banco"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.TB_BANCO.DisplayMember
        filter.[Operator] = FilterOperator.Contains
        Me.TB_BANCO.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        TB_BANCO.MultiColumnComboBoxElement.EditorControl.EnableCustomFiltering = True
        AddHandler TB_BANCO.MultiColumnComboBoxElement.EditorControl.CustomFiltering, AddressOf EditorControl_CustomFiltering
        AddHandler TB_BANCO.KeyDown, AddressOf TB_BANCO_KeyDown

        TB_BANCO.DropDownSizingMode = SizingMode.UpDownAndRightBottom
        TB_BANCO.DropDownMinSize = New Size(370, 300) ' ANCHO - ALTO

        TB_BANCO.EditorControl.Columns(0).Width = 50
        TB_BANCO.EditorControl.Columns(1).Width = 100
        TB_BANCO.EditorControl.Columns(2).Width = 200

    End Sub

    Private Sub EditorControl_CustomFiltering(sender As Object, e As Telerik.WinControls.UI.GridViewCustomFilteringEventArgs)
        Dim element As RadMultiColumnComboBoxElement = TB_BANCO.MultiColumnComboBoxElement

        Dim textToSearch As String = TB_BANCO.Text
        If AutoCompleteMode.Append = (element.AutoCompleteMode And AutoCompleteMode.Append) Then
            If element.SelectionLength > 0 AndAlso element.SelectionStart > 0 Then
                textToSearch = TB_BANCO.Text.Substring(0, element.SelectionStart)
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

    Private Sub TB_BANCO_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_BANCO.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            If Me.TB_BANCO.ValueMember <> "" Then
                TB_BANCO.SelectedValue = TB_BANCO.EditorControl.CurrentRow.Cells(TB_BANCO.ValueMember).Value
            Else
                TB_BANCO.SelectedValue = TB_BANCO.EditorControl.CurrentRow.Cells(TB_BANCO.DisplayMember).Value
            End If

            TB_BANCO.Text = TB_BANCO.EditorControl.CurrentRow.Cells(TB_BANCO.DisplayMember).Value.ToString()
            TB_BANCO.MultiColumnComboBoxElement.ClosePopup()
            TB_BANCO.MultiColumnComboBoxElement.TextBoxElement.TextBoxItem.SelectAll()
        End If
    End Sub
End Class
