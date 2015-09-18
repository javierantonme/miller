Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Public Class RECIBOS_DE_CABA
    Dim UTLIMO_CONECUTIVO As Integer
    Dim UTLIMO_CONECUTIVO2 As Integer
    Dim VALOR_ANERIOR As Integer
    Dim VARIABLE As Integer
    Private Sub RECIBOS_DE_CABA_Load(sender As Object, e As EventArgs) Handles Me.Load
        BUSCAR_CLIENTE1()
        CONF_COMBO_CLIENTE1()
        TB_CEDULA.Text = ""
        buscando_ultimo_consecutivo2()
    End Sub

    Sub CONF_COMBO_CLIENTE1()
        Me.TB_CEDULA.AutoFilter = True
        Me.TB_CEDULA.DisplayMember = "Identificación"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.TB_CEDULA.DisplayMember
        filter.[Operator] = FilterOperator.Contains
        Me.TB_CEDULA.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        TB_CEDULA.MultiColumnComboBoxElement.EditorControl.EnableCustomFiltering = True
        AddHandler TB_CEDULA.MultiColumnComboBoxElement.EditorControl.CustomFiltering, AddressOf EditorControl_CustomFiltering
        AddHandler TB_CEDULA.KeyDown, AddressOf TB_CEDULA_KeyDown

        TB_CEDULA.DropDownSizingMode = SizingMode.UpDownAndRightBottom
        TB_CEDULA.DropDownMinSize = New Size(650, 300)

        TB_CEDULA.EditorControl.Columns(0).Width = 50
        TB_CEDULA.EditorControl.Columns(1).Width = 75
        TB_CEDULA.EditorControl.Columns(2).Width = 100
        TB_CEDULA.EditorControl.Columns(3).Width = 400

    End Sub

    Sub CONF_COMBO_CONCEPTO()
        Me.TB_CONCEPTO.AutoFilter = True
        Me.TB_CONCEPTO.DisplayMember = "Concepto"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.TB_CONCEPTO.DisplayMember
        filter.[Operator] = FilterOperator.Contains
        Me.TB_CONCEPTO.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        TB_CONCEPTO.MultiColumnComboBoxElement.EditorControl.EnableCustomFiltering = True
        AddHandler TB_CONCEPTO.MultiColumnComboBoxElement.EditorControl.CustomFiltering, AddressOf EditorControl_CustomFilteringConcepto
        AddHandler TB_CONCEPTO.KeyDown, AddressOf TB_CONCEPTO_KeyDown

        TB_CONCEPTO.DropDownSizingMode = SizingMode.UpDownAndRightBottom
        TB_CONCEPTO.DropDownMinSize = New Size(350, 300)

        TB_CONCEPTO.EditorControl.Columns(0).Width = 50
        TB_CONCEPTO.EditorControl.Columns(1).Width = 75
        TB_CONCEPTO.EditorControl.Columns(2).Width = 200

    End Sub

    Sub CONF_COMBO_FORMA_PAGO()
        Me.TB_FORMA_PAGO.AutoFilter = True
        Me.TB_FORMA_PAGO.DisplayMember = "Forma de Pago"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.TB_FORMA_PAGO.DisplayMember
        filter.[Operator] = FilterOperator.Contains
        Me.TB_FORMA_PAGO.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        TB_FORMA_PAGO.MultiColumnComboBoxElement.EditorControl.EnableCustomFiltering = True
        AddHandler TB_FORMA_PAGO.MultiColumnComboBoxElement.EditorControl.CustomFiltering, AddressOf EditorControl_CustomFilteringFormaPago
        AddHandler TB_FORMA_PAGO.KeyDown, AddressOf TB_FORMA_PAGO_KeyDown

        TB_FORMA_PAGO.DropDownSizingMode = SizingMode.UpDownAndRightBottom
        TB_FORMA_PAGO.DropDownMinSize = New Size(350, 300)

        TB_FORMA_PAGO.EditorControl.Columns(0).Width = 50
        TB_FORMA_PAGO.EditorControl.Columns(1).Width = 75
        TB_FORMA_PAGO.EditorControl.Columns(2).Width = 200

    End Sub

    Sub CONF_COMBO_CAJAS()
        Me.TB_CAJA.AutoFilter = True
        Me.TB_CAJA.DisplayMember = "Caja"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.TB_CAJA.DisplayMember
        filter.[Operator] = FilterOperator.Contains
        Me.TB_CAJA.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        TB_CAJA.MultiColumnComboBoxElement.EditorControl.EnableCustomFiltering = True
        AddHandler TB_CAJA.MultiColumnComboBoxElement.EditorControl.CustomFiltering, AddressOf EditorControl_CustomFilteringCaja
        AddHandler TB_CAJA.KeyDown, AddressOf TB_CAJA_KeyDown

        TB_CAJA.DropDownSizingMode = SizingMode.UpDownAndRightBottom
        TB_CAJA.DropDownMinSize = New Size(350, 300)

        TB_CAJA.EditorControl.Columns(0).Width = 50
        TB_CAJA.EditorControl.Columns(1).Width = 75
        TB_CAJA.EditorControl.Columns(2).Width = 200

    End Sub

    Sub CONF_COMBO_CUENTAS()
        Me.TB_CAJA.AutoFilter = True
        Me.TB_CAJA.DisplayMember = "Numero"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.TB_CAJA.DisplayMember
        filter.[Operator] = FilterOperator.Contains
        Me.TB_CAJA.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        TB_CAJA.MultiColumnComboBoxElement.EditorControl.EnableCustomFiltering = True
        AddHandler TB_CAJA.MultiColumnComboBoxElement.EditorControl.CustomFiltering, AddressOf EditorControl_CustomFilteringCuenta
        AddHandler TB_CAJA.KeyDown, AddressOf TB_CAJA_KeyDown

        TB_CAJA.DropDownSizingMode = SizingMode.UpDownAndRightBottom
        TB_CAJA.DropDownMinSize = New Size(550, 300)

        TB_CAJA.EditorControl.Columns(0).Width = 50
        TB_CAJA.EditorControl.Columns(1).Width = 75
        TB_CAJA.EditorControl.Columns(2).Width = 200

    End Sub


    Private Sub EditorControl_CustomFiltering(sender As Object, e As Telerik.WinControls.UI.GridViewCustomFilteringEventArgs)
        Dim element As RadMultiColumnComboBoxElement = TB_CEDULA.MultiColumnComboBoxElement

        Dim textToSearch As String = TB_CEDULA.Text
        If AutoCompleteMode.Append = (element.AutoCompleteMode And AutoCompleteMode.Append) Then
            If element.SelectionLength > 0 AndAlso element.SelectionStart > 0 Then
                textToSearch = TB_CEDULA.Text.Substring(0, element.SelectionStart)
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

    Private Sub TB_CEDULA_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_CEDULA.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            If Me.TB_CEDULA.ValueMember <> "" Then
                TB_CEDULA.SelectedValue = TB_CEDULA.EditorControl.CurrentRow.Cells(TB_CEDULA.ValueMember).Value
            Else
                TB_CEDULA.SelectedValue = TB_CEDULA.EditorControl.CurrentRow.Cells(TB_CEDULA.DisplayMember).Value
            End If

            TB_CEDULA.Text = TB_CEDULA.EditorControl.CurrentRow.Cells(TB_CEDULA.DisplayMember).Value.ToString()
            TB_CEDULA.MultiColumnComboBoxElement.ClosePopup()
            TB_CEDULA.MultiColumnComboBoxElement.TextBoxElement.TextBoxItem.SelectAll()
        End If
    End Sub

    Private Sub EditorControl_CustomFilteringConcepto(sender As Object, e As Telerik.WinControls.UI.GridViewCustomFilteringEventArgs)
        Dim element As RadMultiColumnComboBoxElement = TB_CONCEPTO.MultiColumnComboBoxElement

        Dim textToSearch As String = TB_CONCEPTO.Text
        If AutoCompleteMode.Append = (element.AutoCompleteMode And AutoCompleteMode.Append) Then
            If element.SelectionLength > 0 AndAlso element.SelectionStart > 0 Then
                textToSearch = TB_CONCEPTO.Text.Substring(0, element.SelectionStart)
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

    Private Sub TB_CONCEPTO_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_CONCEPTO.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            If Me.TB_CONCEPTO.ValueMember <> "" Then
                TB_CONCEPTO.SelectedValue = TB_CONCEPTO.EditorControl.CurrentRow.Cells(TB_CONCEPTO.ValueMember).Value
            Else
                TB_CONCEPTO.SelectedValue = TB_CONCEPTO.EditorControl.CurrentRow.Cells(TB_CONCEPTO.DisplayMember).Value
            End If

            TB_CONCEPTO.Text = TB_CONCEPTO.EditorControl.CurrentRow.Cells(TB_CONCEPTO.DisplayMember).Value.ToString()
            TB_CONCEPTO.MultiColumnComboBoxElement.ClosePopup()
            TB_CONCEPTO.MultiColumnComboBoxElement.TextBoxElement.TextBoxItem.SelectAll()
        End If
    End Sub

    Private Sub EditorControl_CustomFilteringFormaPago(sender As Object, e As Telerik.WinControls.UI.GridViewCustomFilteringEventArgs)
        Dim element As RadMultiColumnComboBoxElement = TB_FORMA_PAGO.MultiColumnComboBoxElement

        Dim textToSearch As String = TB_FORMA_PAGO.Text
        If AutoCompleteMode.Append = (element.AutoCompleteMode And AutoCompleteMode.Append) Then
            If element.SelectionLength > 0 AndAlso element.SelectionStart > 0 Then
                textToSearch = TB_FORMA_PAGO.Text.Substring(0, element.SelectionStart)
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

    Private Sub TB_FORMA_PAGO_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_FORMA_PAGO.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            If Me.TB_FORMA_PAGO.ValueMember <> "" Then
                TB_FORMA_PAGO.SelectedValue = TB_FORMA_PAGO.EditorControl.CurrentRow.Cells(TB_FORMA_PAGO.ValueMember).Value
            Else
                TB_FORMA_PAGO.SelectedValue = TB_FORMA_PAGO.EditorControl.CurrentRow.Cells(TB_FORMA_PAGO.DisplayMember).Value
            End If

            TB_FORMA_PAGO.Text = TB_FORMA_PAGO.EditorControl.CurrentRow.Cells(TB_FORMA_PAGO.DisplayMember).Value.ToString()
            TB_FORMA_PAGO.MultiColumnComboBoxElement.ClosePopup()
            TB_FORMA_PAGO.MultiColumnComboBoxElement.TextBoxElement.TextBoxItem.SelectAll()
        End If
    End Sub

    Private Sub EditorControl_CustomFilteringCaja(sender As Object, e As Telerik.WinControls.UI.GridViewCustomFilteringEventArgs)
        Dim element As RadMultiColumnComboBoxElement = TB_CAJA.MultiColumnComboBoxElement

        Dim textToSearch As String = TB_CAJA.Text
        If AutoCompleteMode.Append = (element.AutoCompleteMode And AutoCompleteMode.Append) Then
            If element.SelectionLength > 0 AndAlso element.SelectionStart > 0 Then
                textToSearch = TB_CAJA.Text.Substring(0, element.SelectionStart)
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

    Private Sub TB_CAJA_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_CAJA.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            If Me.TB_CAJA.ValueMember <> "" Then
                TB_CAJA.SelectedValue = TB_CAJA.EditorControl.CurrentRow.Cells(TB_CAJA.ValueMember).Value
            Else
                TB_CAJA.SelectedValue = TB_CAJA.EditorControl.CurrentRow.Cells(TB_CAJA.DisplayMember).Value
            End If

            TB_CAJA.Text = TB_CAJA.EditorControl.CurrentRow.Cells(TB_CAJA.DisplayMember).Value.ToString()
            TB_CAJA.MultiColumnComboBoxElement.ClosePopup()
            TB_CAJA.MultiColumnComboBoxElement.TextBoxElement.TextBoxItem.SelectAll()
        End If
    End Sub

    Private Sub EditorControl_CustomFilteringCuenta(sender As Object, e As Telerik.WinControls.UI.GridViewCustomFilteringEventArgs)
        Dim element As RadMultiColumnComboBoxElement = TB_CAJA.MultiColumnComboBoxElement

        Dim textToSearch As String = TB_CAJA.Text
        If AutoCompleteMode.Append = (element.AutoCompleteMode And AutoCompleteMode.Append) Then
            If element.SelectionLength > 0 AndAlso element.SelectionStart > 0 Then
                textToSearch = TB_CAJA.Text.Substring(0, element.SelectionStart)
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



    Sub BUSCAR_CLIENTE1()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_CLIENTE_RC1", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            TB_CEDULA.DataSource = tabla
            TB_CEDULA.ValueMember = ("OID")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub buscando_CLIENTE()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_CLIENTE_RC", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CLINUMDOC", SqlDbType.VarChar).Value = TB_CEDULA.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                TB_NOMBRE_COMPLETO.Text = dr(0)
                BUSCAR_CONCEPTOS()
                CONF_COMBO_CONCEPTO()

                buscando_FORMA_PAGO()
                CONF_COMBO_FORMA_PAGO()
                conex.Close()
            Else
                If TB_CEDULA.Text = "" Then
                Else
                    MsgBox("Cliente no se encuentra registrado en el sistema, desea agregarlo ahora?", MsgBoxStyle.YesNo)
                    If vbYes Then
                        '  CLIENTES.TB_DOCUMENTO.Text = TB_CEDULA.Text
                        'CLIENTES.X = 1
                        'CLIENTES.DESBLOQUEAR_BOTONES()
                        'CLIENTES.BTM_MODIFICAR.Enabled = False
                        CLIENTES.ShowDialog()
                    End If
                End If
                ' TB_NOMBRE_COMPLETO.Clear()
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TB_CEDULA_LostFocus(sender As Object, e As EventArgs) Handles TB_CEDULA.LostFocus
        buscando_CLIENTE()
    End Sub

    Private Sub BTM_SALIR_Click(sender As Object, e As EventArgs) Handles BTM_SALIR.Click
        Dispose()
    End Sub

    Sub buscando_FORMA_PAGO()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_FORMA_PAGO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            TB_FORMA_PAGO.DataSource = tabla
            TB_FORMA_PAGO.ValueMember = ("Codigo")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Sub BUSCAR_CONCEPTOS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_CONCEPTO_CODIGO_RC", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            TB_CONCEPTO.DataSource = tabla
            TB_CONCEPTO.ValueMember = ("Codigo")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub buscando_ultimo_consecutivo()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_MAXIMO_CONSECUTIVO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            ' cmd.Parameters.Add("@FORPAGCOD", SqlDbType.VarChar).Value = TB_FORMA_PAGO_CODIGO.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                UTLIMO_CONECUTIVO = dr(0)
                conex.Close()
            Else
                '    MsgBox("Este Forma de Pago no se encuentra registrado en el sistema")
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub buscando_ultimo_consecutivo2() ' PARA EL LABEL QUE TIENE EL NUMERO DE CONECECUTIVO
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_MAXIMO_CONSECUTIVO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            ' cmd.Parameters.Add("@FORPAGCOD", SqlDbType.VarChar).Value = TB_FORMA_PAGO_CODIGO.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                LB_NUERO_RC.Text = dr(0) + 1
                conex.Close()
            Else
                '    MsgBox("Este Forma de Pago no se encuentra registrado en el sistema")
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub GUARDAR_CABECERA()
        Try
            buscando_ultimo_consecutivo()
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_RECIBO_CAJA_CABECERA", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CLIENTE", SqlDbType.VarChar).Value = TB_CEDULA.Text
            cmd.Parameters.Add("@RCCABVAL", SqlDbType.Int).Value = TB_VALOR.Text
            cmd.Parameters.Add("@CONCECUTIVO", SqlDbType.Int).Value = UTLIMO_CONECUTIVO
            conex.Open()
            cmd.ExecuteNonQuery()
            'MessageBox.Show("CLIENTE GUARDADO CORRECTAMENTE", "SISTEMA")
            GUARDAR_DETALLE()
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub GUARDAR_DETALLE()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_RECIBO_CAJA_DETALLE", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CONCEPTO", SqlDbType.VarChar).Value = TB_CONCEPTO.SelectedValue
            cmd.Parameters.Add("@OBSERVACIONES", SqlDbType.VarChar).Value = TB_OBSERVACIONES.Text
            cmd.Parameters.Add("@FORMA_PAGO", SqlDbType.VarChar).Value = TB_FORMA_PAGO.SelectedValue
            conex.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("RECIBO DE CAJA GUARDADO CORRECTAMENTE", "SISTEMA")
            If VARIABLE = 1 Then
                BUSCAR_REGISTROS_POR_CAJA()
            ElseIf VARIABLE = 2 Then
                BUSCAR_REGISTROS_POR_CUENTA()
            End If
            LIMPIAR_CAMPOS()
            REPORT_RECIBOCAJA.HC()
            REPORT_RECIBOCAJA.Show()

            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CONFIRMAR()
        Dim PREGUNTA As String
        PREGUNTA = MsgBox("Confirma Guardar Recibo de Caja", MsgBoxStyle.YesNo)
        If vbYes Then
            '  If VARIABLE = 1 Then
            GUARDAR_CABECERA()
            'End If
        End If
    End Sub

    Private Sub BTM_GUARDAR_Click(sender As Object, e As EventArgs) Handles BTM_GUARDAR.Click
        validarciones()
    End Sub

    Sub LIMPIAR_CAMPOS()
        '    TB_CEDULA.Clear()
        TB_NOMBRE_COMPLETO.Clear()
        TB_VALOR.Clear()
        '   TB_CONCEPTO_CODIGO.Clear()
        '  TB_CONCEPTO_DESCRIPCION.Text = ""
        TB_OBSERVACIONES.Clear()
        ' TB_FORMA_PAGO_CODIGO.Clear()
        ' TB_FORMA_PAGO_DESCRIPCION.Text = ""
    End Sub

    Sub validarciones()
        If TB_CEDULA.Text = "" Then
            MsgBox("EL CAMPO IDENTIFICACION NO PUEDE ESTAR EN BLANCO")
        ElseIf TB_CONCEPTO.Text = "" Then
            MsgBox("El CONCEPTO DEBE TENER UN CODIGO")
        ElseIf TB_VALOR.Text = "" Then
            MsgBox("EL RECIBO DE CAJA DEBE TENER UN VALOR")
        ElseIf TB_FORMA_PAGO.Text = "" Then
            MsgBox("LA FORMA DE PAGO DEBE TENER UN CODIGO")
        ElseIf TB_NOMBRE_COMPLETO.Text = "" Then
            MsgBox("DEBE HABER UN NOMBRE DE CLIENTE VALIDO")
        Else
            CONFIRMAR()

        End If
    End Sub

    Sub buscar_CAJAS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_CAJAS2", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            TB_CAJA.DataSource = tabla
            TB_CAJA.ValueMember = ("Codigo")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub buscar_CUENTAS_BANCOS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_DATOS_CUENTA_BANCO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            TB_CAJA.DataSource = tabla
            TB_CAJA.ValueMember = ("OID")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub BUSCAR_REGISTROS_POR_CAJA()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_REGISTRO_CAJA", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CAJA", SqlDbType.Int).Value = TB_CAJA.SelectedValue
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                GUARDAR_MOVIMIENTO_CAJA()
                conex.Close()
            Else
                GUARDAR_PRIMER_MOVIMIENTO_CAJA()
                GUARDAR_MOVIMIENTO_CAJA()
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub BUSCAR_REGISTROS_POR_CUENTA()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_REGISTRO_CUENTA", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CUENTA", SqlDbType.Int).Value = TB_CAJA.SelectedValue
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                GUARDAR_MOVIMIENTO_CUENTA()
                conex.Close()
            Else
                GUARDAR_PRIMER_MOVIMIENTO_CUENTA()
                GUARDAR_MOVIMIENTO_CUENTA()
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub GUARDAR_MOVIMIENTO_CAJA()
        Try
            BUSCAR_VALOR_ANTERIOR()
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_MOVICAJA", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CAJA", SqlDbType.Int).Value = TB_CAJA.SelectedValue
            cmd.Parameters.Add("@CONCEPTO", SqlDbType.VarChar).Value = TB_CONCEPTO.SelectedValue
            cmd.Parameters.Add("@CLIENTE", SqlDbType.VarChar).Value = TB_CEDULA.Text
            cmd.Parameters.Add("@VALOR_ANTERIOR", SqlDbType.Int).Value = VALOR_ANERIOR
            cmd.Parameters.Add("@VALOR_MOV", SqlDbType.Int).Value = Val(TB_VALOR.Text)
            conex.Open()
            cmd.ExecuteNonQuery()
            ' MessageBox.Show("RECIBO DE CAJA GUARDADO CORRECTAMENTE", "SISTEMA")
            LIMPIAR_CAMPOS()
            '   RPRECIBOCAJA.Show()
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub GUARDAR_MOVIMIENTO_CUENTA()
        Try
            BUSCAR_VALOR_ANTERIOR_CUENTA()
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_MOVICAJA3", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CUENTA", SqlDbType.Int).Value = TB_CAJA.SelectedValue
            cmd.Parameters.Add("@CONCEPTO", SqlDbType.VarChar).Value = TB_CONCEPTO.SelectedValue
            cmd.Parameters.Add("@CLIENTE", SqlDbType.VarChar).Value = TB_CEDULA.Text
            cmd.Parameters.Add("@VALOR_ANTERIOR", SqlDbType.Int).Value = VALOR_ANERIOR
            cmd.Parameters.Add("@VALOR_MOV", SqlDbType.Int).Value = Val(TB_VALOR.Text)
            conex.Open()
            cmd.ExecuteNonQuery()
            ' MessageBox.Show("RECIBO DE CAJA GUARDADO CORRECTAMENTE", "SISTEMA")
            LIMPIAR_CAMPOS()
            '   RPRECIBOCAJA.Show()
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub BUSCAR_VALOR_ANTERIOR()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_VALOR_ANTERIOR", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CAJA", SqlDbType.Int).Value = TB_CAJA.SelectedValue
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                VALOR_ANERIOR = dr(0)
                conex.Close()
            Else
                '    MsgBox("Este Forma de Pago no se encuentra registrado en el sistema")
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub BUSCAR_VALOR_ANTERIOR_CUENTA()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_VALOR_ANTERIOR_BANCO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CUENTA", SqlDbType.Int).Value = TB_CAJA.SelectedValue
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                VALOR_ANERIOR = dr(0)
                conex.Close()
            Else
                '    MsgBox("Este Forma de Pago no se encuentra registrado en el sistema")
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub GUARDAR_PRIMER_MOVIMIENTO_CAJA()
        Try
            BUSCAR_VALOR_ANTERIOR()
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_PRIMER_MOVIMIENTO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CAJA", SqlDbType.Int).Value = TB_CAJA.SelectedValue
            conex.Open()
            cmd.ExecuteNonQuery()
            '   MessageBox.Show("RECIBO DE CAJA GUARDADO CORRECTAMENTE", "SISTEMA")
            LIMPIAR_CAMPOS()
            '   RPRECIBOCAJA.Show()
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub GUARDAR_PRIMER_MOVIMIENTO_CUENTA()
        Try
            BUSCAR_VALOR_ANTERIOR_CUENTA()
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_PRIMER_MOVIMIENTO2", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CUENTA", SqlDbType.Int).Value = TB_CAJA.SelectedValue
            conex.Open()
            cmd.ExecuteNonQuery()
            '   MessageBox.Show("RECIBO DE CAJA GUARDADO CORRECTAMENTE", "SISTEMA")
            LIMPIAR_CAMPOS()
            ' RPRECIBOCAJA.Show()
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub PREGUNTA()
        If RB_CAJA.IsChecked = True Then
            LB_CAJA.Text = "Caja"
            LB_CAJA.Visible = True
            TB_CAJA.Visible = True
            buscar_CAJAS()
            CONF_COMBO_CAJAS()
            VARIABLE = 1
        ElseIf RB_BANCOS.IsChecked = True Then
            LB_CAJA.Text = "Cuenta Bancaria"
            LB_CAJA.Visible = True
            TB_CAJA.Visible = True
            buscar_CUENTAS_BANCOS()
            CONF_COMBO_CUENTAS()
            TB_CAJA.EditorControl.Columns(3).Width = 200
            VARIABLE = 2
        End If

    End Sub

    Private Sub RB_CAJA_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles RB_CAJA.ToggleStateChanged
        PREGUNTA()
    End Sub

    Private Sub RB_BANCOS_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles RB_BANCOS.ToggleStateChanged
        PREGUNTA()
    End Sub
End Class
