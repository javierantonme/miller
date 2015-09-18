Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data

Public Class IMPRIMIR
    Dim CONSECUTIVO As Integer
    Private Sub IMPRIMIR_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.RadGridView1.EnableFiltering = True
        Me.RadGridView1.MasterTemplate.EnableFiltering = True
        BUSCAR_TODOS_RC()
    End Sub


    Sub BUSCAR_TODOS_RC()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_TODOS_RC_IMPRIMIR", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            RadGridView1.DataSource = tabla
            conex.Close()
            RadGridView1.Columns(0).Width = 75
            RadGridView1.Columns(1).Width = 100
            RadGridView1.Columns(2).Width = 400
            RadGridView1.Columns(3).Width = 200
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RadButtonElement1_Click(sender As Object, e As EventArgs) Handles RadButtonElement1.Click
        Dispose()
    End Sub

    Private Sub RadGridView1_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridView1.CellDoubleClick
        Dim clickedRow As GridViewRowInfo = e.Row
        CONSECUTIVO = clickedRow.Cells(0).Value.ToString()
        REPORT_RECIBOCAJA.CONSECUTIVO = CONSECUTIVO
        REPORT_RECIBOCAJA.BUSCAR_OID_CONSECUTIVO()
        REPORT_RECIBOCAJA.Show()

    End Sub
End Class
