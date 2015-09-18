Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Public Class IMPRIMIR_LIQUIDACION_2
    Dim OID As Integer
    Private Sub IMPRIMIR_LIQUIDACION_2_Load(sender As Object, e As EventArgs) Handles Me.Load
        BUSCAR_TODOS()
        Me.RadGridView1.EnableFiltering = True
        Me.RadGridView1.MasterTemplate.EnableFiltering = True
    End Sub

    Sub BUSCAR_TODOS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_CLIENTES_LIQUIDACIONES", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            RadGridView1.DataSource = tabla
            conex.Close()
            RadGridView1.Columns(0).Width = 50
            RadGridView1.Columns(1).Width = 75
            RadGridView1.Columns(2).Width = 100
            RadGridView1.Columns(3).Width = 300
            RadGridView1.Columns(4).Width = 160
            RadGridView1.Columns(5).Width = 200
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RadGridView1_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridView1.CellDoubleClick
        Dim clickedRow As GridViewRowInfo = e.Row
        oid = clickedRow.Cells(0).Value.ToString()
        REPORT_LIQUIDACION_vb.LIQUIDACIONC = OID
        REPORT_LIQUIDACION_vb.Show()

    End Sub

    Private Sub BTM_SALIR_Click(sender As Object, e As EventArgs) Handles BTM_SALIR.Click
        Dispose()
    End Sub
End Class
