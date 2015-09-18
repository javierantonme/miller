Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Public Class LIQUIDACION_ASESORES
    Dim PORCEN As Integer
    Private Sub LIQUIDACION_ASESORES_Load(sender As Object, e As EventArgs) Handles Me.Load
        BUSCAR_ASESOR()
        CONF_COMBO_asesor()
    End Sub
    Private Sub BTM_SALIR_Click(sender As Object, e As EventArgs) Handles BTM_SALIR.Click
        Dispose()
    End Sub
    Sub CONF_COMBO_asesor()
        Me.TB_ASESOR.AutoFilter = True
        Me.TB_ASESOR.DisplayMember = "Identificación"

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

    Sub buscando_NOMBRE_ASESOR()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_NOMBRE_ASESOR", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ASECODIGO", SqlDbType.VarChar).Value = TB_ASESOR.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                TB_ASESOR_NOMBRE.Text = dr(0)
                '  LB_PORCENTAJE.Text = dr(1) & "%"
                PORCEN = dr(1)
                conex.Close()
            Else
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub buscando_TOTAL()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_LIQUIDACIONES_ASESOR_Valor", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@FECHA_INICIAL", SqlDbType.DateTime).Value = TB_FECHA_INICIAL.Value
            cmd.Parameters.Add("@FECHA_FINAL", SqlDbType.DateTime).Value = TB_fECHA_FINAL.Value
            cmd.Parameters.Add("@ASESOR", SqlDbType.Int).Value = TB_ASESOR.SelectedValue
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                TB_TOTAL.Text = dr(0)
                conex.Close()
            Else
                conex.Close()
            End If
        Catch ex As Exception
            '   MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TB_ASESOR_LostFocus(sender As Object, e As EventArgs) Handles TB_ASESOR.LostFocus
        buscando_NOMBRE_ASESOR()
    End Sub

    Sub BUSCAR_liquidaciones()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_LIQUIDACIONES_ASESOR", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@FECHA_INICIAL", SqlDbType.DateTime).Value = TB_FECHA_INICIAL.Value
            cmd.Parameters.Add("@FECHA_FINAL", SqlDbType.DateTime).Value = TB_fECHA_FINAL.Value
            cmd.Parameters.Add("@ASESOR", SqlDbType.Int).Value = TB_ASESOR.SelectedValue
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            RadGridView1.DataSource = tabla
            conex.Close()
            RadGridView1.Columns(0).Width = 75
            RadGridView1.Columns(1).Width = 100
            RadGridView1.Columns(2).Width = 100
            RadGridView1.Columns(3).Width = 100
            buscando_TOTAL()
            CALCULO()
        Catch ex As Exception
            '  MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        '     MessageBox.Show(TB_ASESOR.SelectedValue)
        BUSCAR_liquidaciones()
    End Sub

    Sub CALCULO()
        LB_LIQUIDACION.Text = FormatNumber((TB_TOTAL.Text * PORCEN) / 100, 0)
    End Sub
End Class
