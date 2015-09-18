Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Public Class AFILIACIONES
    Dim EPS, PENSIONES, ARL, CAJA, EPS1, PENSIONES1, ARL1, CAJA1 As Double
    Dim ADMON, ADMON1 As Integer
    Dim TIPO As String
    Dim COD_EPS, COD_PENSIONES, COD_ARL, COD_CAJACOM, TIPO_APORTE, Y As Integer
    Dim RC_EPS, RC_PENSIONES, RC_ARL, RC_CAJA, RC_ADMIN, RC_AFILIACION, GRANTOTAL As Integer



    Private Sub AFILIACIONES_Load(sender As Object, e As EventArgs) Handles Me.Load
        BUSCAR_CLIENTE1()
        CONF_COMBO_CLIENTE1()
        BUSCAR_ASESOR()
        CONF_COMBO_asesor()
        BUSCAR_PORCENTAJES()
        TB_CEDULA.Text = ""
        TB_ASESOR.Text = ""
    End Sub
    Private Sub BTM_SALIR_Click(sender As Object, e As EventArgs) Handles BTM_SALIR.Click
        Dispose()
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

    Sub CONF_COMBO_asesor()
        Me.TB_ASESOR.AutoFilter = True
        Me.TB_ASESOR.DisplayMember = "Nombre"

        Dim filter As New FilterDescriptor()
        filter.PropertyName = Me.TB_ASESOR.DisplayMember
        filter.[Operator] = FilterOperator.Contains
        Me.TB_ASESOR.EditorControl.MasterTemplate.FilterDescriptors.Add(filter)
        TB_ASESOR.MultiColumnComboBoxElement.EditorControl.EnableCustomFiltering = True
        AddHandler TB_ASESOR.MultiColumnComboBoxElement.EditorControl.CustomFiltering, AddressOf EditorControl_CustomFilteringASESOR
        AddHandler TB_ASESOR.KeyDown, AddressOf TB_ASESOR_KeyDown

        TB_ASESOR.DropDownSizingMode = SizingMode.UpDownAndRightBottom
        TB_ASESOR.DropDownMinSize = New Size(455, 300)

        TB_ASESOR.EditorControl.Columns(0).Width = 50
        TB_ASESOR.EditorControl.Columns(1).Width = 75
        TB_ASESOR.EditorControl.Columns(2).Width = 300
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

    Private Sub EditorControl_CustomFilteringASESOR(sender As Object, e As Telerik.WinControls.UI.GridViewCustomFilteringEventArgs)
        Dim element As RadMultiColumnComboBoxElement = TB_ASESOR.MultiColumnComboBoxElement

        Dim textToSearch As String = TB_ASESOR.Text
        If AutoCompleteMode.Append = (element.AutoCompleteMode And AutoCompleteMode.Append) Then
            If element.SelectionLength > 0 AndAlso element.SelectionStart > 0 Then
                textToSearch = TB_ASESOR.Text.Substring(0, element.SelectionStart)
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

    Private Sub TB_ASESOR_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_ASESOR.KeyDown
        If e.KeyCode = System.Windows.Forms.Keys.Enter Then
            If Me.TB_ASESOR.ValueMember <> "" Then
                TB_ASESOR.SelectedValue = TB_ASESOR.EditorControl.CurrentRow.Cells(TB_ASESOR.ValueMember).Value
            Else
                TB_ASESOR.SelectedValue = TB_ASESOR.EditorControl.CurrentRow.Cells(TB_ASESOR.DisplayMember).Value
            End If

            TB_ASESOR.Text = TB_ASESOR.EditorControl.CurrentRow.Cells(TB_ASESOR.DisplayMember).Value.ToString()
            TB_ASESOR.MultiColumnComboBoxElement.ClosePopup()
            TB_ASESOR.MultiColumnComboBoxElement.TextBoxElement.TextBoxItem.SelectAll()
        End If
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

    Sub BUSCAR_ASESOR()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_ASESORES_AFILIACION", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            TB_ASESOR.DataSource = tabla
            TB_ASESOR.ValueMember = ("OID")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub buscando_CLIENTE()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_CLIENTE_AFILIACIONES", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CLINUMDOC", SqlDbType.VarChar).Value = TB_CEDULA.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                TB_NOMBRE_COMPLETO.Text = dr(0)
                TB_DRIECCION.Text = dr(1)
                TB_TELEFONO.Text = dr(2)
                COD_EPS = dr(3)
                TB_EPS.Text = dr(4)
                COD_PENSIONES = dr(5)
                TB_PENSIONES.Text = dr(6)
                COD_ARL = dr(7)
                TB_ARL.Text = dr(8)
                COD_CAJACOM = dr(9)
                TB_CAJA.Text = dr(10)
                TIPO = dr(11)
                TB_TIPOAFILIACION.Text = TIPO
                conex.Close()
            Else
                LIMPIAR_CAMPOS()
                MsgBox("Cliente no se encuentra registrado en el sistema, desea agregarlo ahora?", MsgBoxStyle.YesNo)
                If vbYes Then
                    CLIENTES.ShowDialog()

                End If
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TB_CEDULA_LostFocus(sender As Object, e As EventArgs) Handles TB_CEDULA.LostFocus
        buscando_CLIENTE()
        BUSCAR_SI_ES_AFILIADO()
    End Sub

    Sub PREGUNTA_1()
        If RB_LIQUIDAR_SM.IsChecked = True Then
            TB_VALOR_BASE.Enabled = False
        Else
            TB_VALOR_BASE.Enabled = True
        End If
    End Sub

    Private Sub RB_LIQUIDAR_SM_ToggleStateChanged_1(sender As Object, args As StateChangedEventArgs) Handles RB_LIQUIDAR_SM.ToggleStateChanged
        PREGUNTA_1()
        PREGUNTA2()
    End Sub

    Sub BUSCAR_SALARIO_MINIMO()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_SALARIO_MINIMO", conex)
            cmd.CommandType = CommandType.StoredProcedure
            ' cmd.Parameters.Add("@CLINUMDOC", SqlDbType.VarChar).Value = TB_CEDULA.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                TB_VALOR_BASE.Text = dr(0)
                conex.Close()
            Else
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub PREGUNTA2()
        If RB_LIQUIDAR_SM.Checked = True Then
            BUSCAR_SALARIO_MINIMO()
        Else
            TB_VALOR_BASE.Clear()
        End If
    End Sub

    Sub BUSCAR_PORCENTAJES()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_PORCENTAJES", conex)
            cmd.CommandType = CommandType.StoredProcedure
            ' cmd.Parameters.Add("@CLINUMDOC", SqlDbType.VarChar).Value = TB_CEDULA.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                EPS = dr(1)
                PENSIONES = dr(2)
                ARL = dr(3)
                CAJA = dr(4)
                ADMON = dr(5)
                conex.Close()
            Else
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub LIQUIDAR()
        Try
            If CH_EPS.Checked = True Then
                Me.DataGridView1.Rows.Add(COD_EPS, TB_EPS.Text, EPS1)
            End If

            If CH_PENSION.Checked = True Then
                Me.DataGridView1.Rows.Add(COD_PENSIONES, TB_PENSIONES.Text, PENSIONES1)
            End If

            If CH_ARL.Checked = True Then
                Me.DataGridView1.Rows.Add(COD_ARL, TB_ARL.Text, ARL1)
            End If

            If CH_CAJA.Checked = True Then
                Me.DataGridView1.Rows.Add(COD_CAJACOM, TB_CAJA.Text, CAJA1)
            End If
            'Me.RadGridView1.Rows.Add("Concepto", )
        Catch ex As Exception
            RadMessageBox.Show(ex.Message & "Error Funcion Liquidar")
        End Try
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles BTM_LIQUIDAR.Click
        Try

            If TIPO <> "TAXISTA" Then
                Me.DataGridView1.Rows.Clear()
                Me.DataGridView1.Rows.Add("108", "ADMINISTRACION", ADMON * TB_CANTIDAD.Value)
                CALCULOS()
                LIQUIDAR()
                SUMAR()
            Else
                Me.DataGridView1.Rows.Clear()
                LB_TOTAL.Text = "$" & TB_CANTIDAD.Value * 250000
            End If

        If CH_AFILIACION.Checked = True Then
            Me.DataGridView1.Rows.Clear()
            Me.DataGridView1.Rows.Add("109", "AFILIACION", TB_VALOR_BASE.Text)
            LB_LIQ.Text = "Valor Afiliación"
            SUMAR()
        Else
            LB_LIQ.Text = "Valor Base Liquidacion"
            End If

        Catch ex As Exception
            RadMessageBox.Show(ex.Message & "Error Boton Liquidación")
        End Try
    End Sub

    Sub CALCULOS()
        Try
            EPS1 = ((Val(TB_VALOR_BASE.Text) * EPS) / 100) * TB_CANTIDAD.Value
        PENSIONES1 = ((Val(TB_VALOR_BASE.Text) * PENSIONES) / 100) * TB_CANTIDAD.Value
        ARL1 = ((Val(TB_VALOR_BASE.Text) * ARL) / 100) * TB_CANTIDAD.Value
        CAJA1 = ((Val(TB_VALOR_BASE.Text) * CAJA) / 100) * TB_CANTIDAD.Value
        CAJA1 = CInt(Fix(CAJA1))
            PENSIONES1 = CInt(Fix(PENSIONES1))
        Catch ex As Exception
            RadMessageBox.Show(ex.Message & "Error Funcion Calculos")
        End Try
    End Sub
    Sub SUMAR()
        Try
            Dim Total As Single
            Dim Col As Integer = Me.DataGridView1.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.DataGridView1.Rows
                Total += Val(row.Cells(2).Value)
            Next
            GRANTOTAL = FormatNumber(Total.ToString, 0)
            LB_TOTAL.Text = "$" & FormatNumber(Total.ToString, 0)
        Catch ex As Exception
            RadMessageBox.Show(ex.Message & "Error Funcion SUMA")
        End Try
    End Sub

    Sub LIMPIAR_CAMPOS()
        '    TB_CEDULA.Text = ""
        TB_NOMBRE_COMPLETO.Clear()
        TB_DRIECCION.Clear()
        TB_TELEFONO.Clear()
        Me.DataGridView1.Rows.Clear()
    End Sub

    Sub GUARDAR()
        Try
            If RB_LIQUIDACION.Checked = True Then
                TIPO_APORTE = 1
            ElseIf RB_PAGO_MENSUAL.Checked = True Then
                TIPO_APORTE = 2
            End If
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("INGRESAR_LIQUIDACIONESC", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CLIENTE", SqlDbType.VarChar).Value = TB_CEDULA.Text
            cmd.Parameters.Add("@LIQVALBAS", SqlDbType.Int).Value = TB_VALOR_BASE.Text
            cmd.Parameters.Add("@LIQOBSERVA", SqlDbType.VarChar).Value = TB_OBSERVACIONES.Text
            cmd.Parameters.Add("@USUARIO", SqlDbType.Int).Value = 1
            cmd.Parameters.Add("@LIQTIPAPO", SqlDbType.Int).Value = TIPO_APORTE
            cmd.Parameters.Add("@ASESOR", SqlDbType.Int).Value = TB_ASESOR.SelectedValue
            cmd.Parameters.Add("@LIQVALTOTAL", SqlDbType.Int).Value = GRANTOTAL ' @LIQVALTOTAL
            conex.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("REGISTRO GUARDADO CORRECTAMENTE", "SISTEMA")
            GUARDAR_DETALLE()

            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & "Error Guardando Cabecera")
        End Try
    End Sub

    Private Sub BTM_GUARDAR_Click(sender As Object, e As EventArgs) Handles BTM_GUARDAR.Click
        VALIDACIONES()
        
    End Sub

    Sub GUARDAR_DETALLE()
        Try
            If DataGridView1.Rows.Count > 0 Then
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
                    Dim cmd As New SqlCommand("INGRESAR_LIQUIDACIOND", conex)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@FONDO", SqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(0).Value.ToString()
                    cmd.Parameters.Add("@CANTIDAD", SqlDbType.Int).Value = TB_CANTIDAD.Value
                    cmd.Parameters.Add("@VALOR", SqlDbType.Int).Value = DataGridView1.Rows(i).Cells(2).Value.ToString()
                    conex.Open()
                    cmd.ExecuteNonQuery()
                    BUSCAR_MAX_OID()
                    conex.Close()
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & "Error Guardando el Detalle")
        End Try
    End Sub

    Sub BUSCAR_MAX_OID()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_MAX_OID_LIQUIDACIONC", conex)
            cmd.CommandType = CommandType.StoredProcedure
            ' cmd.Parameters.Add("@CLINUMDOC", SqlDbType.VarChar).Value = TB_CEDULA.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                REPORT_LIQUIDACION_vb.LIQUIDACIONC = dr(0)
                conex.Close()
            Else
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub VALIDACIONES()
        If RB_LIQUIDACION.Checked = False And RB_PAGO_MENSUAL.Checked = False Then
            RadMessageBox.Show(Me, "Error, Debe especificar que tipo de documento es", "Error")
        ElseIf TB_CEDULA.Text = "" Then
            RadMessageBox.Show(Me, "EL numero de Identificacion es Obligatorio", "Error")
        ElseIf TB_NOMBRE_COMPLETO.Text = "" Then
            RadMessageBox.Show(Me, "Los datos del paciente no son validos", "Error")
        ElseIf TB_VALOR_BASE.Text = "" Then
            RadMessageBox.Show(Me, "EL Valor Base es Obligatorio", "Error")
        ElseIf TB_ASESOR.Text = "" Then
            RadMessageBox.Show(Me, "El campo de Asesor no puede estar en Blanco", "Error")
        Else
            Dim ds As DialogResult = RadMessageBox.Show(Me, "Confirma Generar documento?", "Liquidación", MessageBoxButtons.YesNo, RadMessageIcon.Question)
            If ds = Windows.Forms.DialogResult.Yes Then
                GUARDAR()
                REPORT_LIQUIDACION_vb.Show()
                Me.Dispose()
            Else

            End If
        End If
     
    End Sub

    Private Sub CH_AFILIACION_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles CH_AFILIACION.ToggleStateChanged
        If CH_AFILIACION.Checked = True Then
            Me.DataGridView1.Rows.Clear()
            LB_LIQ.Text = "Valor Afiliación"
            CH_EPS.Enabled = False
            CH_EPS.Checked = False
            CH_PENSION.Enabled = False
            CH_PENSION.Checked = False
            CH_ARL.Enabled = False
            CH_ARL.Checked = False
            CH_CAJA.Enabled = False
            CH_CAJA.Checked = False
            RB_LIQUIDAR_SM.Enabled = False
            RB_LIQUIDAR_SM.Checked = False
            Y = 1
        Else
            LB_LIQ.Text = "Valor Base Liquidacion"
            CH_EPS.Enabled = True
            CH_EPS.Checked = False
            CH_PENSION.Enabled = True
            CH_PENSION.Checked = False
            CH_ARL.Enabled = True
            CH_ARL.Checked = False
            CH_CAJA.Enabled = True
            CH_CAJA.Checked = False
            RB_LIQUIDAR_SM.Enabled = True
            RB_LIQUIDAR_SM.Checked = False
            Y = 0
        End If

    End Sub

    Sub PREGUNTA_RC()
        Dim Pds As DialogResult = RadMessageBox.Show(Me, "Desea Generar Recibo de Caja?", "Afiliemos", MessageBoxButtons.YesNo, RadMessageIcon.Question)
        If Windows.Forms.DialogResult.Yes Then
            RECIBOS_DE_CABA.TB_CEDULA.Text = TB_CEDULA.Text
            RECIBOS_DE_CABA.BUSCAR_CLIENTE1()

        End If
    End Sub

    Sub BUSCAR_SI_ES_AFILIADO()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_AFILIACION_EXISTE", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CEDULA", SqlDbType.VarChar).Value = TB_CEDULA.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                PB_CHULO.Visible = True
                RB_PAGO_MENSUAL.Checked = True
                CH_AFILIACION.Checked = False
                CH_AFILIACION.Enabled = False
                conex.Close()
            Else
                PB_CHULO.Visible = False
                conex.Close()
            End If
        Catch ex As Exception
            '   MsgBox(ex.Message)
        End Try
    End Sub

End Class
