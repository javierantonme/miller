Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Public Class REMISIONES_PENDIENTES

    Private Sub REMISIONES_PENDIENTES_Load(sender As Object, e As EventArgs) Handles Me.Load
        mostrar_remisiones()
    End Sub
    Sub mostrar_remisiones()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_REMISIONES_CLIENTE", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CLIENTE", SqlDbType.VarChar).Value = FACTURACION.TB_ID.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView1.DataSource = tabla
            conex.Close()
            DataGridView1.Columns(0).Width = 50
            DataGridView1.Columns(1).Width = 50
            DataGridView1.Columns(2).Width = 50

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BT_ENVIAR_Click(sender As Object, e As EventArgs) Handles BT_ENVIAR.Click
        Dim a As Integer = 0
        Dim filaseleccionada As Integer = 0
        Dim OIDSELECCIONADOS() As Integer
        For a = 0 To DataGridView1.RowCount - 1
            If DataGridView1.Rows(a).Cells(0).Value Then
                ReDim OIDSELECCIONADOS(0 To OIDSELECCIONADOS.Length + 1)
                OIDSELECCIONADOS(filaseleccionada) = DataGridView1.Rows(a).Cells(1).Value
                filaseleccionada = filaseleccionada + 1
                FACTURACION.cargarremisiones(OIDSELECCIONADOS)
            End If
        Next
        Dispose()
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.ColumnIndex = Me.DataGridView1.Columns.Item("Column1").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = Me.DataGridView1.Rows(e.RowIndex).Cells("Column1")
            chkCell.Value = Not chkCell.Value
        End If

        '   MsgBox("Estado: " & EstadoCheck(e.RowIndex))

    End Sub
End Class